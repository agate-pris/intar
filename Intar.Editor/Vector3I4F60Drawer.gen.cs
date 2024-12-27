using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector3I4F60))]
    public class Vector3I4F60Drawer : PropertyDrawer {
        /// フィールドに表示する値を最大値・最小値で制限する
        static float Clamp(float value) {
            var min = I4F60.MinValue.LossyToSingle();
            var max = I4F60.MaxValue.LossyToSingle();
            return Mathf.Clamp(value, min, max);
        }

        /// 値をシリアライズ時に保存する値に変換する
        static long ToBits(float value) {
            value *= I4F60.OneRepr;
            return value <= long.MinValue ? long.MinValue :
                   value >= long.MaxValue ? long.MaxValue :
                   (long)value;
        }

        Vector3? cache;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var repr = property.FindPropertyRelative("Repr");
            var x = repr.FindPropertyRelative("X");
            var y = repr.FindPropertyRelative("Y");
            var z = repr.FindPropertyRelative("Z");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? new Vector3(
                (float)x.longValue / I4F60.OneRepr,
                (float)y.longValue / I4F60.OneRepr,
                (float)z.longValue / I4F60.OneRepr
            );

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.Vector3Field(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = new Vector3(Clamp(value.x), Clamp(value.y), Clamp(value.z));

            if (EditorGUI.EndChangeCheck()) {
                x.longValue = ToBits(cache.Value.x);
                y.longValue = ToBits(cache.Value.y);
                z.longValue = ToBits(cache.Value.z);
            }

            EditorGUI.EndProperty();
        }
    }
}
