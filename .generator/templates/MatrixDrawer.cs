{% import "macros.cs" as macros %}
{%- set bits = int_nbits + frac_nbits %}
{%- set component = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- set components = ['X', 'Y', 'Z', 'W'] %}
{%- set bits_type = macros::inttype(signed=true, bits=bits) %}
{%- set type = macros::matrix_type(r=rows, c=cols, type=component) -%}
using System.Collections.Generic;
using System.Collections.ObjectModel;

using UnityEditor;
using UnityEngine;

namespace {{ namespace }}.Editor {
    [CustomPropertyDrawer(typeof({{ type }}))]
    public class {{ type }}Drawer : PropertyDrawer {
        static readonly ReadOnlyCollection<string> colPropertyPaths = new ReadOnlyCollection<string>(new[] { "C0", "C1", "C2", "C3" });
        static readonly ReadOnlyCollection<string> rowPropertyPaths = new ReadOnlyCollection<string>(new[] { "X", "Y", "Z", "W" });
        List<SerializedProperty> properties;
        List<float> cache;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            return
                ({{ rows }} * EditorGUIUtility.singleLineHeight) +
                ({{ rows - 1 }} * EditorGUIUtility.standardVerticalSpacing);
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // properties が null の場合, それを初期化する
            // cache が null の場合, それを初期化する
            if (properties == null) {
                properties = new List<SerializedProperty>();
                cache = new List<float>();
                for (var r = 0; r < {{ rows }}; r++) {
                    for (var c = 0; c < {{ cols }}; c++) {
                        var p = property.FindPropertyRelative($"{colPropertyPaths[c]}.Repr.{rowPropertyPaths[r]}");
                        properties.Add(p);
                        cache.Add({{ component }}Drawer.Restore(p.{{ bits_type }}Value));
                    }
                }
            }

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            position.height = EditorGUIUtility.singleLineHeight;
            var x = position.x;
            position.width = (position.width - ({{ cols - 1 }} * EditorGUIUtility.standardVerticalSpacing)) / {{ cols }};

            // UI を表示 & 入力を取得しキャッシュに保存
            EditorGUI.BeginChangeCheck();
            EditorGUIUtility.labelWidth = 15;
            for (var r = 0; r < {{ rows }}; r++) {
                position.x = x;
                for (var c = 0; c < {{ cols }}; c++) {
                    var i = (r * {{ cols }}) + c;
                    cache[i] = {{ component }}Drawer.Clamp(EditorGUI.FloatField(position, " ", cache[i]));
                    position.x += position.width + EditorGUIUtility.standardVerticalSpacing;
                }
                position.y += EditorGUIUtility.standardVerticalSpacing + EditorGUIUtility.singleLineHeight;
            }
            EditorGUIUtility.labelWidth = 0;

            // 変更を確認し, キャッシュをプロパティに保存
            if (EditorGUI.EndChangeCheck()) {
                for (var r = 0; r < {{ rows }}; r++) {
                    for (var c = 0; c < {{ cols }}; c++) {
                        var i = (r * {{ cols }}) + c;
                        properties[i].{{ bits_type }}Value = {{ component }}Drawer.ToBits(cache[i]);
                    }
                }
            }
            EditorGUI.EndProperty();
        }
    }
}
