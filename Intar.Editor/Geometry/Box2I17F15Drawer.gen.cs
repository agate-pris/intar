using Intar.Geometry;
using UnityEngine;
using UnityEditor;

namespace Intar.Editor.Geometry {
    [CustomPropertyDrawer(typeof(Box2I17F15))]
    public class Box2I17F15Drawer : PropertyDrawer {
        Vector2 center;
        Vector2 size;
        float? rotation;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            if (property.isExpanded) {
                return
                    (4 * EditorGUIUtility.singleLineHeight) +
                    (3 * EditorGUIUtility.standardVerticalSpacing);
            }
            return EditorGUIUtility.singleLineHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            position.height = EditorGUIUtility.singleLineHeight;
            label = EditorGUI.BeginProperty(position, label, property);

            if (EditorGUI.PropertyField(position, property, label, false)) {
                EditorGUI.indentLevel++;
                if (!rotation.HasValue) {
                    var transform = property.FindPropertyRelative("Transform");
                    {
                        var translation = transform.FindPropertyRelative("Translation.Repr");
                        var x = translation.FindPropertyRelative("X");
                        var y = translation.FindPropertyRelative("Y");
                        center = new Vector2(
                            I17F15Drawer.FromBits(x.intValue),
                            I17F15Drawer.FromBits(y.intValue)
                        );
                    }
                    {
                        var extents = property.FindPropertyRelative("Extents.Repr");
                        var x = extents.FindPropertyRelative("X");
                        var y = extents.FindPropertyRelative("Y");
                        size = 2 * new Vector2(
                            I17F15Drawer.FromBits(x.intValue),
                            I17F15Drawer.FromBits(y.intValue)
                        );
                    }
                    {
                        var mat = transform.FindPropertyRelative("RotationScale");
                        var th = Mathf.Atan2(
                            mat.FindPropertyRelative("C0.Repr.Y").intValue,
                            mat.FindPropertyRelative("C0.Repr.X").intValue
                        );
                        rotation = Mathf.Round(th * Mathf.Rad2Deg * 100) / 100;
                    }
                }

                EditorGUI.BeginChangeCheck();

                position.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                center = EditorGUI.Vector2Field(position, "Center", center);
                center.x = I17F15Drawer.Clamp(center.x);
                center.y = I17F15Drawer.Clamp(center.y);

                // サイズは安全のため本来設定可能な値の半分に制限する.
                position.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                size = EditorGUI.Vector2Field(position, "Size", size);
                size.x = I17F15Drawer.Clamp(size.x);
                size.y = I17F15Drawer.Clamp(size.y);

                position.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                rotation = EditorGUI.FloatField(position, "Rotation", rotation.Value);
                rotation = Mathf.Clamp(rotation.Value, -180, 180);

                if (EditorGUI.EndChangeCheck()) {
                    var transform = property.FindPropertyRelative("Transform");
                    {
                        var translation = transform.FindPropertyRelative("Translation.Repr");
                        var x = translation.FindPropertyRelative("X");
                        var y = translation.FindPropertyRelative("Y");
                        x.intValue = I17F15Drawer.ToBits(center.x);
                        y.intValue = I17F15Drawer.ToBits(center.y);
                    }
                    {
                        var extents = property.FindPropertyRelative("Extents.Repr");
                        var x = extents.FindPropertyRelative("X");
                        var y = extents.FindPropertyRelative("Y");
                        x.intValue = I17F15Drawer.ToBits(size.x / 2);
                        y.intValue = I17F15Drawer.ToBits(size.y / 2);
                    }
                    {
                        var mat = transform.FindPropertyRelative("RotationScale");
                        var c0 = mat.FindPropertyRelative("C0");
                        var c1 = mat.FindPropertyRelative("C1");
                        var c0X = c0.FindPropertyRelative("Repr.X");
                        var c0Y = c0.FindPropertyRelative("Repr.Y");
                        var c1X = c1.FindPropertyRelative("Repr.X");
                        var c1Y = c1.FindPropertyRelative("Repr.Y");
                        var sin = Mathf.Sin(rotation.Value * Mathf.Deg2Rad);
                        var cos = Mathf.Cos(rotation.Value * Mathf.Deg2Rad);
                        c0X.intValue = I17F15Drawer.ToBits(cos);
                        c0Y.intValue = I17F15Drawer.ToBits(sin);
                        c1X.intValue = I17F15Drawer.ToBits(-sin);
                        c1Y.intValue = I17F15Drawer.ToBits(cos);
                    }
                }
                EditorGUI.EndProperty();
                EditorGUI.indentLevel--;
            }
        }
    }
} // namespace Intar.Editor.Geometry
