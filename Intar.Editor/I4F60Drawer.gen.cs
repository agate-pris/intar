using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(I4F60))]
    public class I4F60Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Bits");
            var value = (float)p.longValue / I4F60.OneRepr;
            value = EditorGUI.FloatField(position, label, value);
            p.longValue = unchecked((long)(I4F60.OneRepr * value));

            EditorGUI.EndProperty();
        }
    }
}
