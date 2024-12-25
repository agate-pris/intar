using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(I17F15))]
    public class I17F15Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Bits");
            var value = (float)p.intValue / I17F15.OneRepr;
            value = EditorGUI.FloatField(position, label, value);
            p.intValue = unchecked((int)(I17F15.OneRepr * value));

            EditorGUI.EndProperty();
        }
    }
}
