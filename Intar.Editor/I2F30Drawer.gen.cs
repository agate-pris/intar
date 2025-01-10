using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(I2F30))]
    public class I2F30Drawer : PropertyDrawer {
        float? cache;
        /// フィールドに表示する値を最大値・最小値で制限する
        static float Clamp(float value) {
            var min = (float)I2F30.MinValue;
            var max = (float)I2F30.MaxValue;
            return Mathf.Clamp(value, min, max);
        }
        internal static float Restore(int bits) {
            if (bits == 0) {
                return 0;
            }

            var isNegative = bits < 0;
            var abs = Mathi.UnsignedAbs(bits);
            var lowerBound = abs;
            var upperBound = abs + 1;
            var result = System.Math.Abs((float)(bits / I2F30.OneRepr));
            var precision = 0.1f;

            for (var digit = 0; digit < 10; digit++) {
                // 上限を以下の最も大きい値を選ぶ.
                // その値が下限以上であれば, それが正解.
                for (var num = 0; num < 10; num++) {
                    var current = result + (precision * num);
                    var next = result + (precision * (num + 1));

                    // 次の値が上限以上の場合,
                    // 現在の値を確定し次の桁へ進む.
                    // upperBound が浮動小数点数に変換された時に精度を失った場合,
                    // 0 方向への丸めが行われることを想定している.
                    // その場合, upperBound「以上」という条件は厳密に成立する.
                    if (next * I2F30.OneRepr >= upperBound) {
                        result = current;
                        break;
                    }

                    // 現在の値が下限以上の場合, それを返す.
                    // current は next 以下であるため,
                    // current * I2F30.OneRepr は upperBound 以下である.
                    // よって current * I2F30.OneRepr は整数型に安全にキャストできる.
                    // キャストした値は 0 方向に丸められるため,
                    // lowerBound「以上」という条件は厳密に成立する.
                    if ((uint)(current * I2F30.OneRepr) >= lowerBound) {
                        return isNegative ? -current : current;
                    }
                }
                precision *= 0.1f;
            }

            // 桁数が足りなかった場合のためのフォールバック処理.
            // 固定小数点数の内部表現に戻す時,
            // キャストで 0 方向に丸められた時に値が小さくならないように 0.5 を足す.
            return (bits + (Mathf.Sign(bits) * 0.5f)) / I2F30.OneRepr;
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
                value *= I2F30.OneRepr;

                // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
                bits.intValue
                    = value <= int.MinValue ? int.MinValue
                    : value >= int.MaxValue ? int.MaxValue
                    : (int)value;
            }

            EditorGUI.EndProperty();
        }
    }
}
