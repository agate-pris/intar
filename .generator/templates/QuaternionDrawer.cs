{% import "macros.cs" as macros %}
{%- set bits = int_nbits + frac_nbits %}
{%- set components = ['X', 'Y', 'Z', 'W'] %}
{%- set component = macros::fixed_type(s=true, i=int_nbits, f=frac_nbits) %}
{%- set bits_type = macros::inttype(signed=true, bits=bits) %}
{%- set type = macros::quaternion(i=int_nbits, f=frac_nbits) -%}
using UnityEditor;
using UnityEngine;

namespace {{ namespace }}.Editor {
    [CustomPropertyDrawer(typeof({{ type }}))]
    public class {{ type }}Drawer : PropertyDrawer {
        Vector4? cache;
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
            var value = cache ?? new Vector4(
                {%- for c in components %}
                (float){{ c|lower }}.{{ bits_type }}Value / {{ component }}.OneRepr{% if not loop.last %},{% endif %}
                {%- endfor %}
            );

            // UI を表示 & 入力をキャッシュ
            EditorGUI.BeginChangeCheck();
            cache = EditorGUI.Vector4Field(position, label, value);

            if (EditorGUI.EndChangeCheck()) {
                value = cache.Value.normalized;
                {%- for c in components %}
                {{ c|lower }}.{{ bits_type }}Value = ({{ bits_type }})(value.{{ c|lower }} * {{ component }}.OneRepr);
                {%- endfor %}
            }
            EditorGUI.EndProperty();
        }
    }
}
