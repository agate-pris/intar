{% import "macros.cs" as macros %}
{%- set component = macros::fixed_type(s=true, i=int_nbits, f=frac_nbits) %}
{%- set type = macros::vector_type(type=component, dim=dim) %}
{%- set bits = int_nbits + frac_nbits %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{#- -#}
using UnityEditor;
using UnityEngine;

namespace {{ namespace }}.Editor {
    [CustomPropertyDrawer(typeof({{ type }}))]
    public class {{ type }}Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Repr");
            {%- for c in components %}
            var {{ c|lower }} = p.FindPropertyRelative("{{ c }}");
            {%- endfor %}
            {%- if bits == 32 %}{% set t = 'int'   %}
            {%- else          %}{% set t = 'long'  %}{% endif %}
            var v = EditorGUI.Vector{{ dim }}Field(
                position, label,
                new Vector{{ dim }}(
                    {%- for c in components %}
                    (float){{ c|lower }}.{{ t }}Value / {{ component }}.OneRepr{% if not loop.last %},{% endif %}
                    {%- endfor %}
                )
            );
            {%- for c in components %}
            {{ c|lower }}.{{ t }}Value = unchecked(({{ t }})({{ component }}.OneRepr * v.{{ c|lower }}));
            {%- endfor %}

            EditorGUI.EndProperty();
        }
    }
}
