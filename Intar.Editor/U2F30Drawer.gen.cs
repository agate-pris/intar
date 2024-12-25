using UnityEditor;
using UnityEngine;

namespace Intar {
    [CustomPropertyDrawer(typeof(U2F30))]
    public class U2F30Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Bits");
            var value = (float)p.uintValue / U2F30.OneRepr;
            value = EditorGUI.FloatField(position, label, value);
            p.uintValue = unchecked((uint)(U2F30.OneRepr * value));

            EditorGUI.EndProperty();
        }
    }
}
