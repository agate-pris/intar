using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(U17F15))]
    public class U17F15Drawer : PropertyDrawer {
        float? cache;
        /// フィールドに表示する値を最大値・最小値で制限する
        static float Clamp(float value) {
            var min = (float)U17F15.MinValue;
            var max = (float)U17F15.MaxValue;
            return Mathf.Clamp(value, min, max);
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? (float)bits.uintValue / U17F15.OneRepr;

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.FloatField(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = Clamp(value);

            if (EditorGUI.EndChangeCheck()) {
                value *= U17F15.OneRepr;

                // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
                bits.uintValue
                    = value <= uint.MinValue ? uint.MinValue
                    : value >= uint.MaxValue ? uint.MaxValue
                    : (uint)value;
            }

            EditorGUI.EndProperty();
        }
    }
}
