using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(I17F15))]
    public class I17F15Drawer : PropertyDrawer {
        float? cache;

        /// フィールドに表示する値を最大値・最小値で制限する
        internal static float Clamp(float value) {
            var min = (float)I17F15.MinValue;
            var max = (float)I17F15.MaxValue;
            return Mathf.Clamp(value, min, max);
        }

        /// 値をシリアライズ時に保存する値に変換する
        internal static int ToBits(float value) {
            value = Mathf.Round(value * I17F15.OneRepr);

            // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
            return value <= int.MinValue ? int.MinValue :
                   value >= int.MaxValue ? int.MaxValue :
                   (int)value;
        }

        internal static float Restore(int bits) {
            float f;
            {
                var sign = 0.5f * System.Math.Sign(bits);
                f = bits * 100.0f / I17F15.OneRepr;
                f = Mathf.Round(f + sign) / 100;
            }
            int i;
            {
                var tmp = f * I17F15.OneRepr;
                i = (int)tmp;
            }
            return bits == i ? f : (float)bits / I17F15.OneRepr;
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? Restore(bits.intValue);

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.FloatField(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = Clamp(value);

            if (EditorGUI.EndChangeCheck()) {
                bits.intValue = ToBits(value);
            }

            EditorGUI.EndProperty();
        }
    }
}
