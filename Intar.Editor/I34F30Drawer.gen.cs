using UnityEditor;
using UnityEngine;

namespace Intar {
    [CustomPropertyDrawer(typeof(I34F30))]
    public class I34F30Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Bits");
            var value = (float)p.longValue / I34F30.OneRepr;
            value = EditorGUI.FloatField(position, label, value);
            p.longValue = unchecked((long)(I34F30.OneRepr * value));

            EditorGUI.EndProperty();
        }
    }
}
