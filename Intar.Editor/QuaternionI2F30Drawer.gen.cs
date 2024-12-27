using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(QuaternionI2F30))]
    public class QuaternionI2F30Drawer : PropertyDrawer {
        Vector4? cache;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var repr = property.FindPropertyRelative("Repr");
            var x = repr.FindPropertyRelative("X");
            var y = repr.FindPropertyRelative("Y");
            var z = repr.FindPropertyRelative("Z");
            var w = repr.FindPropertyRelative("W");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? new Vector4(
                (float)x.intValue / I2F30.OneRepr,
                (float)y.intValue / I2F30.OneRepr,
                (float)z.intValue / I2F30.OneRepr,
                (float)w.intValue / I2F30.OneRepr
            );

            // UI を表示 & 入力をキャッシュ
            EditorGUI.BeginChangeCheck();
            cache = EditorGUI.Vector4Field(position, label, value);

            if (EditorGUI.EndChangeCheck()) {
                value = cache.Value.normalized;
                x.intValue = (int)(value.x * I2F30.OneRepr);
                y.intValue = (int)(value.y * I2F30.OneRepr);
                z.intValue = (int)(value.z * I2F30.OneRepr);
                w.intValue = (int)(value.w * I2F30.OneRepr);
            }
            EditorGUI.EndProperty();
        }
    }
}
