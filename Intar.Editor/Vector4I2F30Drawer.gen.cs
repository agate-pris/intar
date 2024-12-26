using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(Vector4I2F30))]
    public class Vector4I2F30Drawer : PropertyDrawer {
        /// フィールドに表示する値を最大値・最小値で制限する
        static float Clamp(float value) {
            var min = I2F30.MinValue.LossyToSingle();
            var max = I2F30.MaxValue.LossyToSingle();
            return Mathf.Clamp(value, min, max);
        }

        /// 値をシリアライズ時に保存する値に変換する
        static int ToBits(float value) {
            value *= I2F30.OneRepr;
            return value <= int.MinValue ? int.MinValue :
                   value >= int.MaxValue ? int.MaxValue :
                   (int)value;
        }

        Vector4? cache;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            label = EditorGUI.BeginProperty(position, label, property);

            var repr = property.FindPropertyRelative("Repr");
            var x = repr.FindPropertyRelative("X");
            var y = repr.FindPropertyRelative("Y");
            var z = repr.FindPropertyRelative("Z");
            var w = repr.FindPropertyRelative("W");

            // すでに値がキャッシュされている場合はそれを使う
            // それ以外の場合, プロパティから値を取得してキャッシュする
            var value = cache ?? new Vector4(
                (float)x.intValue / I2F30.OneRepr,
                (float)y.intValue / I2F30.OneRepr,
                (float)z.intValue / I2F30.OneRepr,
                (float)w.intValue / I2F30.OneRepr
            );

            // UI を表示 & 入力を取得
            EditorGUI.BeginChangeCheck();
            value = EditorGUI.Vector4Field(position, label, value);

            // 値を正規化してキャッシュを更新
            cache = new Vector4(Clamp(value.x), Clamp(value.y), Clamp(value.z), Clamp(value.w));

            if (EditorGUI.EndChangeCheck()) {
                x.intValue = ToBits(cache.Value.x);
                y.intValue = ToBits(cache.Value.y);
                z.intValue = ToBits(cache.Value.z);
                w.intValue = ToBits(cache.Value.w);
            }

            EditorGUI.EndProperty();
        }
    }
}
