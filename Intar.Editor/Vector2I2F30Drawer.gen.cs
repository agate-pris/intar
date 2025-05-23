using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector2I2F30))]
    public class Vector2I2F30Drawer : PropertyDrawer {
        Vector2? cache;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var repr = property.FindPropertyRelative("Repr");
            var x = repr.FindPropertyRelative("X");
            var y = repr.FindPropertyRelative("Y");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? new Vector2(
                I2F30Drawer.Restore(x.intValue),
                I2F30Drawer.Restore(y.intValue)
            );

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.Vector2Field(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = new Vector2(I2F30Drawer.Clamp(value.x), I2F30Drawer.Clamp(value.y));

            if (EditorGUI.EndChangeCheck()) {
                x.intValue = I2F30Drawer.ToBits(cache.Value.x);
                y.intValue = I2F30Drawer.ToBits(cache.Value.y);
            }

            EditorGUI.EndProperty();
        }
    }
}
