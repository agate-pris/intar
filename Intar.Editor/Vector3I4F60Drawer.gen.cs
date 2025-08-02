using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector3I4F60))]
    public class Vector3I4F60Drawer : PropertyDrawer {
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
                I4F60Drawer.FromBits(x.longValue),
                I4F60Drawer.FromBits(y.longValue),
                I4F60Drawer.FromBits(z.longValue)
            );

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.Vector3Field(position, label, value);

            // 値を正規化
            value = new Vector3(I4F60Drawer.Clamp(value.x), I4F60Drawer.Clamp(value.y), I4F60Drawer.Clamp(value.z));

            if (EditorGUI.EndChangeCheck()) {
                x.longValue = I4F60Drawer.ToBits(value.x);
                y.longValue = I4F60Drawer.ToBits(value.y);
                z.longValue = I4F60Drawer.ToBits(value.z);
            }

            EditorGUI.EndProperty();
        }
    }
}
