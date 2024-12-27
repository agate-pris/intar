using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(U4F60))]
    public class U4F60Drawer : PropertyDrawer {
        float? cache;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var bits = property.FindPropertyRelative("Bits");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? (float)bits.ulongValue / U4F60.OneRepr;

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.FloatField(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = Mathf.Clamp(
                value,
                U4F60.MinValue.LossyToSingle(),
                U4F60.MaxValue.LossyToSingle());

            if (EditorGUI.EndChangeCheck()) {
                value *= U4F60.OneRepr;

                // 必ず <=, >= を使う. Clamp ではオーバーフローを引き起こす.
                bits.ulongValue
                    = value <= ulong.MinValue ? ulong.MinValue
                    : value >= ulong.MaxValue ? ulong.MaxValue
                    : (ulong)value;
            }

            EditorGUI.EndProperty();
        }
    }
}
