using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(U2F62))]
    public class U2F62Drawer : PropertyDrawer {
        /// フィールドに表示する値を最大値・最小値で制限する
        internal static float Clamp(float value) {
            var max = (float)((ulong)U2F62.MaxValue);
            return Mathf.Clamp(value, 0, max);
        }

        /// 値をシリアライズ時に保存する値に変換する
        internal static ulong ToBits(float value) {
            value = Mathf.Round(value * U2F62.OneRepr);

            // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
            return value <= ulong.MinValue ? ulong.MinValue :
                   value >= ulong.MaxValue ? ulong.MaxValue :
                   (ulong)value;
        }

        internal static float FromBits(ulong bits) {
            for (var scale = 1.0f; scale < (1 << 25); scale *= 10) {
                var f = Mathf.Round(bits * scale / U2F62.OneRepr) / scale;
                if (bits == ToBits(f)) {
                    return f;
                }
            }
            return (float)bits / U2F62.OneRepr;
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // プロパティから値を取得し float に変換
            var f = FromBits(bits.ulongValue);

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            f = EditorGUI.FloatField(position, label, f);

            if (EditorGUI.EndChangeCheck()) {
                // 値を正規化してプロパティに反映
                bits.ulongValue = ToBits(Clamp(f));
            }

            EditorGUI.EndProperty();
        }
    }
}
