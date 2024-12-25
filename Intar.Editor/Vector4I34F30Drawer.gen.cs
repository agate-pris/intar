using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector4I34F30))]
    public class Vector4I34F30Drawer : PropertyDrawer {
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
                    (float)x.longValue / I34F30.OneRepr,
                    (float)y.longValue / I34F30.OneRepr,
                    (float)z.longValue / I34F30.OneRepr,
                    (float)w.longValue / I34F30.OneRepr
                )
            );
            x.longValue = unchecked((long)(I34F30.OneRepr * v.x));
            y.longValue = unchecked((long)(I34F30.OneRepr * v.y));
            z.longValue = unchecked((long)(I34F30.OneRepr * v.z));
            w.longValue = unchecked((long)(I34F30.OneRepr * v.w));

            EditorGUI.EndProperty();
        }
    }
}
