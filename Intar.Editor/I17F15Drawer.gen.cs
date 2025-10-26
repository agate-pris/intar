using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(I17F15))]
    public class I17F15Drawer : PropertyDrawer {
        /// フィールドに表示する値を最大値・最小値で制限する
        internal static float Clamp(float value) {
            var max = (float)((int)I17F15.MaxValue);
            return Mathf.Clamp(value, -max, max);
        }

        /// 値をシリアライズ時に保存する値に変換する
        internal static int ToBits(float value) {
            value = Mathf.Round(value * I17F15.OneRepr);

            // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
            return value <= int.MinValue ? int.MinValue :
                   value >= int.MaxValue ? int.MaxValue :
                   (int)value;
        }

        internal static float FromBits(int bits) {
            for (var scale = 1.0f; scale < (1 << 25); scale *= 10) {
                var f = Mathf.Round(bits * scale / I17F15.OneRepr) / scale;
                if (bits == ToBits(f)) {
                    return f;
                }
            }
            return (float)bits / I17F15.OneRepr;
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // プロパティから値を取得し float に変換
            var f = FromBits(bits.intValue);

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            f = EditorGUI.FloatField(position, label, f);

            if (EditorGUI.EndChangeCheck()) {
                // 値を正規化してプロパティに反映
                bits.intValue = ToBits(Clamp(f));
            }

            EditorGUI.EndProperty();
        }
    }
}
