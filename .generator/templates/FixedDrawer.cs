{% import "macros.cs" as macros %}
{%- set bits = int_nbits + frac_nbits %}
{%- set bits_type = macros::inttype(signed=signed, bits=bits) %}
{%- set type = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) -%}
using UnityEditor;
using UnityEngine;

namespace {{ namespace }}.Editor {
    [CustomPropertyDrawer(typeof({{ type }}))]
    public class {{ type }}Drawer : PropertyDrawer {
        /// フィールドに表示する値を最大値・最小値で制限する
        internal static float Clamp(float value) {
            var max = (float)(({{ bits_type }}){{ type }}.MaxValue);
            {%- if signed %}
            return Mathf.Clamp(value, -max, max);
            {%- else %}
            return Mathf.Clamp(value, 0, max);
            {%- endif %}
        }

        /// 値をシリアライズ時に保存する値に変換する
        internal static {{ bits_type }} ToBits(float value) {
            value = Mathf.Round(value * {{ type }}.OneRepr);

            // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
            return value <= {{ bits_type }}.MinValue ? {{ bits_type }}.MinValue :
                   value >= {{ bits_type }}.MaxValue ? {{ bits_type }}.MaxValue :
                   ({{ bits_type }})value;
        }

        internal static float FromBits({{ bits_type }} bits) {
            for (var scale = 1.0f; scale < (1 << 25); scale *= 10) {
                var f = Mathf.Round(bits * scale / {{ type }}.OneRepr) / scale;
                if (bits == ToBits(f)) {
                    return f;
                }
            }
            return (float)bits / {{ type }}.OneRepr;
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // プロパティから値を取得し float に変換
            var f = FromBits(bits.{{ bits_type }}Value);

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            f = EditorGUI.FloatField(position, label, f);

            if (EditorGUI.EndChangeCheck()) {
                // 値を正規化してプロパティに反映
                bits.{{ bits_type }}Value = ToBits(Clamp(f));
            }

            EditorGUI.EndProperty();
        }
    }
}
