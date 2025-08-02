using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector3I34F30))]
    public class Vector3I34F30Drawer : PropertyDrawer {
        Vector3? cache;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var repr = property.FindPropertyRelative("Repr");
            var x = repr.FindPropertyRelative("X");
            var y = repr.FindPropertyRelative("Y");
            var z = repr.FindPropertyRelative("Z");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? new Vector3(
                I34F30Drawer.FromBits(x.longValue),
                I34F30Drawer.FromBits(y.longValue),
                I34F30Drawer.FromBits(z.longValue)
            );

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.Vector3Field(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = new Vector3(I34F30Drawer.Clamp(value.x), I34F30Drawer.Clamp(value.y), I34F30Drawer.Clamp(value.z));

            if (EditorGUI.EndChangeCheck()) {
                x.longValue = I34F30Drawer.ToBits(cache.Value.x);
                y.longValue = I34F30Drawer.ToBits(cache.Value.y);
                z.longValue = I34F30Drawer.ToBits(cache.Value.z);
            }

            EditorGUI.EndProperty();
        }
    }
}
