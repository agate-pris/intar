using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(U33F31))]
    public class U33F31Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Bits");
            var value = (float)p.ulongValue / U33F31.OneRepr;
            value = EditorGUI.FloatField(position, label, value);
            p.ulongValue = unchecked((ulong)(U33F31.OneRepr * value));

            EditorGUI.EndProperty();
        }
    }
}
