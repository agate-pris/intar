using System.Collections.Generic;
using System.Collections.ObjectModel;

using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Matrix2x2I2F30))]
    public class Matrix2x2I2F30Drawer : PropertyDrawer {
        static readonly ReadOnlyCollection<string> colPropertyPaths = new ReadOnlyCollection<string>(new[] { "C0", "C1", "C2", "C3" });
        static readonly ReadOnlyCollection<string> rowPropertyPaths = new ReadOnlyCollection<string>(new[] { "X", "Y", "Z", "W" });
        List<SerializedProperty> properties;
        List<float> cache;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            return
                (2 * EditorGUIUtility.singleLineHeight) +
                (1 * EditorGUIUtility.standardVerticalSpacing);
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // properties が null の場合, それを初期化する
            // cache が null の場合, それを初期化する
            if (properties == null) {
                properties = new List<SerializedProperty>();
                cache = new List<float>();
                for (var r = 0; r < 2; r++) {
                    for (var c = 0; c < 2; c++) {
                        var p = property.FindPropertyRelative($"{colPropertyPaths[c]}.Repr.{rowPropertyPaths[r]}");
                        properties.Add(p);
                        cache.Add(I2F30Drawer.FromBits(p.intValue));
                    }
                }
            }

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            position.height = EditorGUIUtility.singleLineHeight;
            var x = position.x;
            position.width = (position.width - (1 * EditorGUIUtility.standardVerticalSpacing)) / 2;

            // UI を表示 & 入力を取得しキャッシュに保存
            EditorGUI.BeginChangeCheck();
            EditorGUIUtility.labelWidth = 15;
            for (var r = 0; r < 2; r++) {
                position.x = x;
                for (var c = 0; c < 2; c++) {
                    var i = (r * 2) + c;
                    cache[i] = I2F30Drawer.Clamp(EditorGUI.FloatField(position, " ", cache[i]));
                    position.x += position.width + EditorGUIUtility.standardVerticalSpacing;
                }
                position.y += EditorGUIUtility.standardVerticalSpacing + EditorGUIUtility.singleLineHeight;
            }
            EditorGUIUtility.labelWidth = 0;

            // 変更を確認し, キャッシュをプロパティに保存
            if (EditorGUI.EndChangeCheck()) {
                for (var r = 0; r < 2; r++) {
                    for (var c = 0; c < 2; c++) {
                        var i = (r * 2) + c;
                        properties[i].intValue = I2F30Drawer.ToBits(cache[i]);
                    }
                }
            }
            EditorGUI.EndProperty();
        }
    }
}
