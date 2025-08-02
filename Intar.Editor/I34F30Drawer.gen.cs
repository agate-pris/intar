using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(I34F30))]
    public class I34F30Drawer : PropertyDrawer {
        /// フィールドに表示する値を最大値・最小値で制限する
        internal static float Clamp(float value) {
            var max = (float)((long)I34F30.MaxValue);
            return Mathf.Clamp(value, -max, max);
        }

        /// 値をシリアライズ時に保存する値に変換する
        internal static long ToBits(float value) {
            value = Mathf.Round(value * I34F30.OneRepr);

            // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
            return value <= long.MinValue ? long.MinValue :
                   value >= long.MaxValue ? long.MaxValue :
                   (long)value;
        }

        internal static float FromBits(long bits) {
            for (var scale = 1.0f; scale < (1 << 25); scale *= 10) {
                var f = Mathf.Round(bits * scale / I34F30.OneRepr) / scale;
                if (bits == ToBits(f)) {
                    return f;
                }
            }
            return (float)bits / I34F30.OneRepr;
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // プロパティから値を取得し float に変換
            var f = FromBits(bits.longValue);

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            f = EditorGUI.FloatField(position, label, f);

            if (EditorGUI.EndChangeCheck()) {
                // 値を正規化してプロパティに反映
                bits.longValue = ToBits(Clamp(f));
            }

            EditorGUI.EndProperty();
        }
    }
}
