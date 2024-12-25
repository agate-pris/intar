using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector2I2F30))]
    public class Vector2I2F30Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Repr");
            var x = p.FindPropertyRelative("X");
            var y = p.FindPropertyRelative("Y");
            var v = EditorGUI.Vector2Field(
                position, label,
                new Vector2(
                    (float)x.intValue / I2F30.OneRepr,
                    (float)y.intValue / I2F30.OneRepr
                )
            );
            x.intValue = unchecked((int)(I2F30.OneRepr * v.x));
            y.intValue = unchecked((int)(I2F30.OneRepr * v.y));

            EditorGUI.EndProperty();
        }
    }
}
