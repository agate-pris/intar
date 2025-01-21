using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(I34F30))]
    public class I34F30Drawer : PropertyDrawer {
        float? cache;

        /// フィールドに表示する値を最大値・最小値で制限する
        internal static float Clamp(float value) {
            var min = (float)I34F30.MinValue;
            var max = (float)I34F30.MaxValue;
            return Mathf.Clamp(value, min, max);
        }

        /// 値をシリアライズ時に保存する値に変換する
        internal static long ToBits(float value) {
            value = Mathf.Round(value * I34F30.OneRepr);

            // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
            return value <= long.MinValue ? long.MinValue :
                   value >= long.MaxValue ? long.MaxValue :
                   (long)value;
        }

        internal static float Restore(long bits) {
            float f;
            {
                var sign = 0.5f * System.Math.Sign(bits);
                f = bits * 100.0f / I34F30.OneRepr;
                f = Mathf.Round(f + sign) / 100;
            }
            long i;
            {
                var tmp = f * I34F30.OneRepr;
                i = (long)tmp;
            }
            return bits == i ? f : (float)bits / I34F30.OneRepr;
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? Restore(bits.longValue);

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.FloatField(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = Clamp(value);

            if (EditorGUI.EndChangeCheck()) {
                bits.longValue = ToBits(value);
            }

            EditorGUI.EndProperty();
        }
    }
}
