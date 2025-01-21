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

        /// フィールドに表示する値を最大値・最小値で制限する
        internal static float Clamp(float value) {
            var min = (float){{ type }}.MinValue;
            var max = (float){{ type }}.MaxValue;
            return Mathf.Clamp(value, min, max);
        }

        /// 値をシリアライズ時に保存する値に変換する
        internal static {{ bits_type }} ToBits(float value) {
            value = Mathf.Round(value * {{ type }}.OneRepr);

            // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
            return value <= {{ bits_type }}.MinValue ? {{ bits_type }}.MinValue :
                   value >= {{ bits_type }}.MaxValue ? {{ bits_type }}.MaxValue :
                   ({{ bits_type }})value;
        }

        internal static float Restore({{ bits_type }} bits) {
            float f;
            {
                {%- if signed %}
                var sign = 0.5f * System.Math.Sign(bits);
                {%- else %}
                var sign = bits == 0 ? 0.0f : 0.5f;
                {%- endif %}
                f = bits * 100.0f / {{ type }}.OneRepr;
                f = Mathf.Round(f + sign) / 100;
            }
            {{ bits_type }} i;
            {
                var tmp = f * {{ type }}.OneRepr;
                i = ({{ bits_type }})tmp;
            }
            return bits == i ? f : (float)bits / {{ type }}.OneRepr;
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? Restore(bits.{{ bits_type }}Value);

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.FloatField(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = Clamp(value);

            if (EditorGUI.EndChangeCheck()) {
                bits.{{ bits_type }}Value = ToBits(value);
            }

            EditorGUI.EndProperty();
        }
    }
}
