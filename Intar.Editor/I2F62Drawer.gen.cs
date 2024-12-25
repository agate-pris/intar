using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(I2F62))]
    public class I2F62Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Bits");
            var value = (float)p.longValue / I2F62.OneRepr;
            value = EditorGUI.FloatField(position, label, value);
            p.longValue = unchecked((long)(I2F62.OneRepr * value));

            EditorGUI.EndProperty();
        }
    }
}
