{% import "macros.cs" as macros %}
{%- set type = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- set bits = int_nbits + frac_nbits %}
{#- -#}
using UnityEditor;
using UnityEngine;

namespace {{ namespace }} {
    [CustomPropertyDrawer(typeof({{ type }}))]
    public class {{ type }}Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Bits");
            {%- if signed %}
            {%- if bits == 32 %}{% set t = 'int'   %}
            {%- else          %}{% set t = 'long'  %}{% endif %}{% else %}
            {%- if bits == 32 %}{% set t = 'uint'  %}
            {%- else          %}{% set t = 'ulong' %}{% endif %}{% endif %}
            var value = (float)p.{{ t }}Value / {{ type }}.OneRepr;
            value = EditorGUI.FloatField(position, label, value);
            p.{{ t }}Value = unchecked(({{ t }})({{ type }}.OneRepr * value));

            EditorGUI.EndProperty();
        }
    }
}
