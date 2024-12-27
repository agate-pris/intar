{% import "macros.cs" as macros %}
{%- set bits = int_nbits + frac_nbits %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{%- set component = macros::fixed_type(s=true, i=int_nbits, f=frac_nbits) %}
{%- set bits_type = macros::inttype(signed=true, bits=bits) %}
{%- set type = macros::vector_type(type=component, dim=dim) -%}
using UnityEditor;
using UnityEngine;

namespace {{ namespace }}.Editor {
    [CustomPropertyDrawer(typeof({{ type }}))]
    public class {{ type }}Drawer : PropertyDrawer {
        /// フィールドに表示する値を最大値・最小値で制限する
        static float Clamp(float value) {
            var min = {{ component }}.MinValue.LossyToSingle();
            var max = {{ component }}.MaxValue.LossyToSingle();
            return Mathf.Clamp(value, min, max);
        }

        /// 値をシリアライズ時に保存する値に変換する
        static {{ bits_type }} ToBits(float value) {
            value *= {{ component }}.OneRepr;
            return value <= {{ bits_type }}.MinValue ? {{ bits_type }}.MinValue :
                   value >= {{ bits_type }}.MaxValue ? {{ bits_type }}.MaxValue :
                   ({{ bits_type }})value;
        }

        Vector{{ dim }}? cache;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var repr = property.FindPropertyRelative("Repr");
            {%- for c in components %}
            var {{ c|lower }} = repr.FindPropertyRelative("{{ c }}");
            {%- endfor %}

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? new Vector{{ dim }}(
                {%- for c in components %}
                (float){{ c|lower }}.{{ bits_type }}Value / {{ component }}.OneRepr{% if not loop.last %},{% endif %}
                {%- endfor %}
            );

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.Vector{{ dim }}Field(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = new Vector{{ dim }}(
                {%- for c in components -%}
                Clamp(value.{{ c|lower }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );

            if (EditorGUI.EndChangeCheck()) {
                {%- for c in components %}
                {{ c|lower }}.{{ bits_type }}Value = ToBits(cache.Value.{{ c|lower }});
                {%- endfor %}
            }

            EditorGUI.EndProperty();
        }
    }
}
