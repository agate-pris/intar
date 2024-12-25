using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector4I17F15))]
    public class Vector4I17F15Drawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            var p = property.FindPropertyRelative("Repr");
            var x = p.FindPropertyRelative("X");
            var y = p.FindPropertyRelative("Y");
            var z = p.FindPropertyRelative("Z");
            var w = p.FindPropertyRelative("W");
            var v = EditorGUI.Vector4Field(
                position, label,
                new Vector4(
                    (float)x.intValue / I17F15.OneRepr,
                    (float)y.intValue / I17F15.OneRepr,
                    (float)z.intValue / I17F15.OneRepr,
                    (float)w.intValue / I17F15.OneRepr
                )
            );
            x.intValue = unchecked((int)(I17F15.OneRepr * v.x));
            y.intValue = unchecked((int)(I17F15.OneRepr * v.y));
            z.intValue = unchecked((int)(I17F15.OneRepr * v.z));
            w.intValue = unchecked((int)(I17F15.OneRepr * v.w));

            EditorGUI.EndProperty();
        }
    }
}
