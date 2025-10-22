using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector2I2F30))]
    public class Vector2I2F30Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var repr = property.FindPropertyRelative("Repr");
            var x = repr.FindPropertyRelative("X");
            var y = repr.FindPropertyRelative("Y");

            // プロパティから値を取得
            var value = new Vector2(
                I2F30Drawer.FromBits(x.intValue),
                I2F30Drawer.FromBits(y.intValue)
            );

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.Vector2Field(position, label, value);

            // 値を正規化
            value = new Vector2(I2F30Drawer.Clamp(value.x), I2F30Drawer.Clamp(value.y));

            if (EditorGUI.EndChangeCheck()) {
                x.intValue = I2F30Drawer.ToBits(value.x);
                y.intValue = I2F30Drawer.ToBits(value.y);
            }

            EditorGUI.EndProperty();
        }
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            var l = EditorGUIUtility.wideMode ? 1 : 2;
            var s = l - 1;
            return (l * EditorGUIUtility.singleLineHeight)
                 + (s * EditorGUIUtility.standardVerticalSpacing);
        }
    }
}
