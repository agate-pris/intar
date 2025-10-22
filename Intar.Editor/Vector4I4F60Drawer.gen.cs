using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector4I4F60))]
    public class Vector4I4F60Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var repr = property.FindPropertyRelative("Repr");
            var x = repr.FindPropertyRelative("X");
            var y = repr.FindPropertyRelative("Y");
            var z = repr.FindPropertyRelative("Z");
            var w = repr.FindPropertyRelative("W");

            // プロパティから値を取得
            var value = new Vector4(
                I4F60Drawer.FromBits(x.longValue),
                I4F60Drawer.FromBits(y.longValue),
                I4F60Drawer.FromBits(z.longValue),
                I4F60Drawer.FromBits(w.longValue)
            );

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.Vector4Field(position, label, value);

            // 値を正規化
            value = new Vector4(I4F60Drawer.Clamp(value.x), I4F60Drawer.Clamp(value.y), I4F60Drawer.Clamp(value.z), I4F60Drawer.Clamp(value.w));

            if (EditorGUI.EndChangeCheck()) {
                x.longValue = I4F60Drawer.ToBits(value.x);
                y.longValue = I4F60Drawer.ToBits(value.y);
                z.longValue = I4F60Drawer.ToBits(value.z);
                w.longValue = I4F60Drawer.ToBits(value.w);
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
