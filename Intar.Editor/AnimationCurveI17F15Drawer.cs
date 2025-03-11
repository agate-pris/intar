using UnityEditor;
using UnityEngine;

namespace Intar.Editor {
    [CustomPropertyDrawer(typeof(AnimationCurveI17F15))]
    public class AnimationCurveI17F15Drawer : PropertyDrawer {
        static UnityEngine.WrapMode Convert(WrapMode wrapMode) {
            switch (wrapMode) {
                case WrapMode.Once: return UnityEngine.WrapMode.ClampForever;
                case WrapMode.Loop: return UnityEngine.WrapMode.Loop;
                case WrapMode.Default:
                default: return UnityEngine.WrapMode.Clamp;
            }
        }
        static WrapMode Convert(UnityEngine.WrapMode wrapMode) {
            switch (wrapMode) {
                case UnityEngine.WrapMode.Loop:
                case UnityEngine.WrapMode.PingPong: return WrapMode.Loop;
                case UnityEngine.WrapMode.Once:
                case UnityEngine.WrapMode.Default:
                case UnityEngine.WrapMode.ClampForever:
                default: return WrapMode.Once;
            }
        }
        AnimationCurve proxy;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            var keys = property.FindPropertyRelative("keys");

            // 一度すべてのキーをクリアして再構築する。
            // AnimationCurve は内部的にネイティブメモリを参照しているため
            // それによって再アロケーションが走る可能性は低いことを期待する。
            if (proxy == null) {
                proxy = new AnimationCurve();
                if (keys.arraySize > 0) {
                    for (var i = 0; i < keys.arraySize; i++) {
                        var key = keys.GetArrayElementAtIndex(i);
                        _ = proxy.AddKey(new Keyframe(
                            I17F15Drawer.Restore(key.FindPropertyRelative("Time.Bits").intValue),
                            I17F15Drawer.Restore(key.FindPropertyRelative("Value.Bits").intValue),
                            I17F15Drawer.Restore(key.FindPropertyRelative("InTangent.Bits").intValue),
                            I17F15Drawer.Restore(key.FindPropertyRelative("OutTangent.Bits").intValue)
                        ));
                    }
                }
                proxy.preWrapMode = Convert((WrapMode)property.FindPropertyRelative("PreWrapMode").enumValueIndex);
                proxy.postWrapMode = Convert((WrapMode)property.FindPropertyRelative("PostWrapMode").enumValueIndex);
            }

            // GUI を描画し変更を検知する
            {
                EditorGUI.BeginChangeCheck();
                proxy = EditorGUI.CurveField(position, label, proxy);
            }

            // 変更があった場合はプロパティに書き戻す
            if (EditorGUI.EndChangeCheck()) {
                keys.ClearArray();
                keys.arraySize = proxy.length;

                for (var i = 0; i < proxy.length; i++) {
                    var key = keys.GetArrayElementAtIndex(i);
                    var k = proxy.keys[i];
                    key.FindPropertyRelative("Time.Bits").intValue = I17F15Drawer.ToBits(k.time);
                    key.FindPropertyRelative("Value.Bits").intValue = I17F15Drawer.ToBits(k.value);
                    key.FindPropertyRelative("InTangent.Bits").intValue = I17F15Drawer.ToBits(k.inTangent);
                    key.FindPropertyRelative("OutTangent.Bits").intValue = I17F15Drawer.ToBits(k.outTangent);
                }

                // Update wrap modes
                property.FindPropertyRelative("PreWrapMode").enumValueIndex = (int)Convert(proxy.preWrapMode);
                property.FindPropertyRelative("PostWrapMode").enumValueIndex = (int)Convert(proxy.postWrapMode);

                _ = property.serializedObject.ApplyModifiedProperties();
            }
        }
        public override float GetPropertyHeight(
            SerializedProperty property, GUIContent label
        ) => EditorGUI.GetPropertyHeight(SerializedPropertyType.Generic, label);
    }
}
