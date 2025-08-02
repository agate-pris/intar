{% import "macros.cs" as macros %}
{%- set dim = 2 %}
{%- set int_nbits = 17 %}
{%- set frac_nbits = 15 %}
{%- set nbits = int_nbits+frac_nbits %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{%- set component = macros::fixed_type(s=true, i=int_nbits, f=frac_nbits) %}
{%- set bits = macros::inttype(signed=true, bits=nbits) %}
{%- set type = 'Box' ~ dim ~ component -%}
using Intar.Geometry;
using UnityEngine;
using UnityEditor;

namespace {{ namespace }}.Editor.Geometry {
    [CustomPropertyDrawer(typeof({{ type }}))]
    public class {{ type }}Drawer : PropertyDrawer {
        Vector{{ dim }} center;
        Vector{{ dim }} size;
        {%- if dim == 2 %}
        float? rotation;
        {%- else %}
        {{- throw(message='not implemented') }}
        {%- endif %}

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            if (property.isExpanded) {
                return
                    (4 * EditorGUIUtility.singleLineHeight) +
                    (3 * EditorGUIUtility.standardVerticalSpacing);
            }
            return EditorGUIUtility.singleLineHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            position.height = EditorGUIUtility.singleLineHeight;
            label = EditorGUI.BeginProperty(position, label, property);

            if (EditorGUI.PropertyField(position, property, label, false)) {
                EditorGUI.indentLevel++;
                if (!rotation.HasValue) {
                    var transform = property.FindPropertyRelative("Transform");
                    {
                        var translation = transform.FindPropertyRelative("Translation.Repr");
                        {%- for c in components %}
                        var {{ c|lower }} = translation.FindPropertyRelative("{{ c }}");
                        {%- endfor %}
                        center = new Vector{{ dim }}(
                            {%- for c in components %}
                            {{ component }}Drawer.FromBits({{ c|lower }}.{{ bits }}Value)
                            {%- if not loop.last %},{% endif %}
                            {%- endfor %}
                        );
                    }
                    {
                        var extents = property.FindPropertyRelative("Extents.Repr");
                        {%- for c in components %}
                        var {{ c|lower }} = extents.FindPropertyRelative("{{ c }}");
                        {%- endfor %}
                        size = 2 * new Vector{{ dim }}(
                            {%- for c in components %}
                            {{ component }}Drawer.FromBits({{ c|lower }}.{{ bits }}Value)
                            {%- if not loop.last %},{% endif %}
                            {%- endfor %}
                        );
                    }
                    {
                        var mat = transform.FindPropertyRelative("RotationScale");
                        {%- if dim == 2 %}
                        var th = Mathf.Atan2(
                            mat.FindPropertyRelative("C0.Repr.Y").{{ bits }}Value,
                            mat.FindPropertyRelative("C0.Repr.X").{{ bits }}Value
                        );
                        rotation = Mathf.Round(th * Mathf.Rad2Deg * 100) / 100;
                        {%- else %}
                        {{- throw(message='not implemented') }}
                        {%- endif %}
                    }
                }

                EditorGUI.BeginChangeCheck();

                position.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                center = EditorGUI.Vector{{ dim }}Field(position, "Center", center);
                {%- for c in components %}
                center.{{ c|lower }} = {{ component }}Drawer.Clamp(center.{{ c|lower }});
                {%- endfor %}

                // サイズは安全のため本来設定可能な値の半分に制限する.
                position.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                size = EditorGUI.Vector{{ dim }}Field(position, "Size", size);
                {%- for c in components %}
                size.{{ c|lower }} = {{ component }}Drawer.Clamp(size.{{ c|lower }});
                {%- endfor %}

                position.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                {%- if dim == 2 %}
                rotation = EditorGUI.FloatField(position, "Rotation", rotation.Value);
                rotation = Mathf.Clamp(rotation.Value, -180, 180);
                {%- else %}
                {{- throw(message='not implemented') }}
                {%- endif %}

                if (EditorGUI.EndChangeCheck()) {
                    var transform = property.FindPropertyRelative("Transform");
                    {
                        var translation = transform.FindPropertyRelative("Translation.Repr");
                        {%- for c in components %}
                        var {{ c|lower }} = translation.FindPropertyRelative("{{ c }}");
                        {%- endfor %}
                        {%- for c in components %}
                        {{ c|lower }}.intValue = {{ component }}Drawer.ToBits(center.{{ c|lower }});
                        {%- endfor %}
                    }
                    {
                        var extents = property.FindPropertyRelative("Extents.Repr");
                        {%- for c in components %}
                        var {{ c|lower }} = extents.FindPropertyRelative("{{ c }}");
                        {%- endfor %}
                        {%- for c in components %}
                        {{ c|lower }}.intValue = {{ component }}Drawer.ToBits(size.{{ c|lower }} / 2);
                        {%- endfor %}
                    }
                    {%- if dim == 2 %}
                    {
                        var mat = transform.FindPropertyRelative("RotationScale");
                        var c0 = mat.FindPropertyRelative("C0");
                        var c1 = mat.FindPropertyRelative("C1");
                        var c0X = c0.FindPropertyRelative("Repr.X");
                        var c0Y = c0.FindPropertyRelative("Repr.Y");
                        var c1X = c1.FindPropertyRelative("Repr.X");
                        var c1Y = c1.FindPropertyRelative("Repr.Y");
                        var sin = Mathf.Sin(rotation.Value * Mathf.Deg2Rad);
                        var cos = Mathf.Cos(rotation.Value * Mathf.Deg2Rad);
                        c0X.intValue = {{ component }}Drawer.ToBits(cos);
                        c0Y.intValue = {{ component }}Drawer.ToBits(sin);
                        c1X.intValue = {{ component }}Drawer.ToBits(-sin);
                        c1Y.intValue = {{ component }}Drawer.ToBits(cos);
                    }
                    {%- else %}
                    {{- throw(message='not implemented') }}
                    {%- endif %}
                }
                EditorGUI.EndProperty();
                EditorGUI.indentLevel--;
            }
        }
    }
} // namespace {{ namespace }}.Editor.Geometry
