using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector3I34F30))]
    public class Vector3I34F30Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var repr = property.FindPropertyRelative("Repr");
            var x = repr.FindPropertyRelative("X");
            var y = repr.FindPropertyRelative("Y");
            var z = repr.FindPropertyRelative("Z");

            // プロパティから値を取得
            var value = new Vector3(
                I34F30Drawer.FromBits(x.longValue),
                I34F30Drawer.FromBits(y.longValue),
                I34F30Drawer.FromBits(z.longValue)
            );

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.Vector3Field(position, label, value);

            // 値を正規化
            value = new Vector3(I34F30Drawer.Clamp(value.x), I34F30Drawer.Clamp(value.y), I34F30Drawer.Clamp(value.z));

            if (EditorGUI.EndChangeCheck()) {
                x.longValue = I34F30Drawer.ToBits(value.x);
                y.longValue = I34F30Drawer.ToBits(value.y);
                z.longValue = I34F30Drawer.ToBits(value.z);
            }

            EditorGUI.EndProperty();
        }
    }
}
