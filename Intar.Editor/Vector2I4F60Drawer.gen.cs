using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector2I4F60))]
    public class Vector2I4F60Drawer : PropertyDrawer {
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
                    (float)x.longValue / I4F60.OneRepr,
                    (float)y.longValue / I4F60.OneRepr
                )
            );
            x.longValue = unchecked((long)(I4F60.OneRepr * v.x));
            y.longValue = unchecked((long)(I4F60.OneRepr * v.y));

            EditorGUI.EndProperty();
        }
    }
}
