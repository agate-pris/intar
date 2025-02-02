using System.Collections.Generic;
using System.Collections.ObjectModel;

using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Matrix3x3I17F15))]
    public class Matrix3x3I17F15Drawer : PropertyDrawer {
        static readonly ReadOnlyCollection<string> colPropertyPaths = new ReadOnlyCollection<string>(new[] { "C0", "C1", "C2", "C3" });
        static readonly ReadOnlyCollection<string> rowPropertyPaths = new ReadOnlyCollection<string>(new[] { "X", "Y", "Z", "W" });
        List<SerializedProperty> properties;
        List<float> cache;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            return
                (3 * EditorGUIUtility.singleLineHeight) +
                (2 * EditorGUIUtility.standardVerticalSpacing);
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // properties が null の場合, それを初期化する
            // cache が null の場合, それを初期化する
            if (properties == null) {
                properties = new List<SerializedProperty>();
                cache = new List<float>();
                for (var r = 0; r < 3; r++) {
                    for (var c = 0; c < 3; c++) {
                        var p = property.FindPropertyRelative($"{colPropertyPaths[c]}.Repr.{rowPropertyPaths[r]}");
                        properties.Add(p);
                        cache.Add(I17F15Drawer.Restore(p.intValue));
                    }
                }
            }

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            position.height = EditorGUIUtility.singleLineHeight;
            var x = position.x;
            position.width = (position.width - (2 * EditorGUIUtility.standardVerticalSpacing)) / 3;

            // UI を表示 & 入力を取得しキャッシュに保存
            EditorGUI.BeginChangeCheck();
            EditorGUIUtility.labelWidth = 15;
            for (var r = 0; r < 3; r++) {
                position.x = x;
                for (var c = 0; c < 3; c++) {
                    var i = (r * 3) + c;
                    cache[i] = I17F15Drawer.Clamp(EditorGUI.FloatField(position, " ", cache[i]));
                    position.x += position.width + EditorGUIUtility.standardVerticalSpacing;
                }
                position.y += EditorGUIUtility.standardVerticalSpacing + EditorGUIUtility.singleLineHeight;
            }
            EditorGUIUtility.labelWidth = 0;

            // 変更を確認し, キャッシュをプロパティに保存
            if (EditorGUI.EndChangeCheck()) {
                for (var r = 0; r < 3; r++) {
                    for (var c = 0; c < 3; c++) {
                        var i = (r * 3) + c;
                        properties[i].intValue = I17F15Drawer.ToBits(cache[i]);
                    }
                }
            }
            EditorGUI.EndProperty();
        }
    }
}
