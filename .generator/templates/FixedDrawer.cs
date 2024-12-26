{% import "macros.cs" as macros %}
{%- set bits = int_nbits + frac_nbits %}
{%- set bits_type = macros::inttype(signed=signed, bits=bits) %}
{%- set type = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) -%}
using UnityEditor;
using UnityEngine;

namespace {{ namespace }}.Editor {
    [CustomPropertyDrawer(typeof({{ type }}))]
    public class {{ type }}Drawer : PropertyDrawer {
        float? cache;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? (float)bits.{{ bits_type }}Value / {{ type }}.OneRepr;

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.FloatField(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = Mathf.Clamp(
                value,
                {{ type }}.MinValue.LossyToSingle(),
                {{ type }}.MaxValue.LossyToSingle());

            if (EditorGUI.EndChangeCheck()) {
                value *= {{ type }}.OneRepr;

                // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
                bits.{{ bits_type }}Value
                    = value <= {{ bits_type }}.MinValue ? {{ bits_type }}.MinValue
                    : value >= {{ bits_type }}.MaxValue ? {{ bits_type }}.MaxValue
                    : ({{ bits_type }})value;
            }

            EditorGUI.EndProperty();
        }
    }
}
