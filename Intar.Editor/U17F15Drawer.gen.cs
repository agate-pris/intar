using UnityEditor;
using UnityEngine;

namespace Intar {
    [CustomPropertyDrawer(typeof(U17F15))]
    public class U17F15Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Bits");
            var value = (float)p.uintValue / U17F15.OneRepr;
            value = EditorGUI.FloatField(position, label, value);
            p.uintValue = unchecked((uint)(U17F15.OneRepr * value));

            EditorGUI.EndProperty();
        }
    }
}
