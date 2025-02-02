using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(U4F60))]
    public class U4F60Drawer : PropertyDrawer {
        float? cache;

        /// フィールドに表示する値を最大値・最小値で制限する
        internal static float Clamp(float value) {
            var min = (float)U4F60.MinValue;
            var max = (float)U4F60.MaxValue;
            return Mathf.Clamp(value, min, max);
        }

        /// 値をシリアライズ時に保存する値に変換する
        internal static ulong ToBits(float value) {
            value = Mathf.Round(value * U4F60.OneRepr);

            // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
            return value <= ulong.MinValue ? ulong.MinValue :
                   value >= ulong.MaxValue ? ulong.MaxValue :
                   (ulong)value;
        }

        internal static float Restore(ulong bits) {
            float f;
            {
                var sign = bits == 0 ? 0.0f : 0.5f;
                f = bits * 100.0f / U4F60.OneRepr;
                f = Mathf.Round(f + sign) / 100;
            }
            ulong i;
            {
                var tmp = f * U4F60.OneRepr;
                i = (ulong)tmp;
            }
            return bits == i ? f : (float)bits / U4F60.OneRepr;
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? Restore(bits.ulongValue);

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.FloatField(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = Clamp(value);

            if (EditorGUI.EndChangeCheck()) {
                bits.ulongValue = ToBits(value);
            }

            EditorGUI.EndProperty();
        }
    }
}
