using System;
using System.Runtime.CompilerServices;

#if UNITY_5_6_OR_NEWER

using UnityEditor;
using UnityEngine;

#endif

namespace AgatePris.Intar.Numerics {

    [Serializable]

#if UNITY_5_6_OR_NEWER
    [ExecuteAlways, RequireComponent(typeof(Transform))]
#endif
    public class TransformI17F15
#if UNITY_5_6_OR_NEWER
        : MonoBehaviour
#endif
    {
        // Fields
        // ---------------------------------------

#if UNITY_5_6_OR_NEWER
        [SerializeField]
#endif
        TransformI17F15 parent;

#if UNITY_5_6_OR_NEWER
        [SerializeField]
#endif
        Vector3I17F15 localPosition;
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#endif
        Vector3I17F15 localScale = Vector3I17F15.One;
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#endif
        Vector3I17F15 localEulerAnglesHint;

#if !UNITY_5_6_OR_NEWER
        [NonSerialized]
#endif
        QuaternionI17F15? localRotation;
#if !UNITY_5_6_OR_NEWER
        [NonSerialized]
#endif
        Matrix4x4I17F15? localToWorldMatrix;
#if !UNITY_5_6_OR_NEWER
        [NonSerialized]
#endif
        Vector3I17F15? position;

        // Properties
        // ---------------------------------------

        public TransformI17F15 Parent {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => parent;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                if (parent == value) {
                    return;
                }
                parent = value;
                localToWorldMatrix = null;
                position = null;
            }
        }

        public Vector3I17F15 LocalPosition {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => localPosition;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                if (localPosition == value) {
                    return;
                }
                localPosition = value;
                localToWorldMatrix = null;
                position = null;
            }
        }
        public Vector3I17F15 LocalScale {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => localScale;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                if (localScale == value) {
                    return;
                }
                localScale = value;
                localToWorldMatrix = null;
            }
        }
        public Vector3I17F15 LocalEulerAngles {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                if (localEulerAnglesHint == value) {
                    return;
                }
                localEulerAnglesHint = value;
                localRotation = null;
                localToWorldMatrix = null;
            }
        }
        public QuaternionI17F15 LocalRotation {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private get {
                // ユーザは値を明示的にセットすることができる｡
                // よって､ ユーザーは `LocalRotation` が参照される前に明示的に値をセットすることで､
                // オイラー角から四元数に変換する際のアルゴリズムを選択することができる｡
                // (それによって､ 変換時の計算の速度や精度の選択権を得る｡ )
                // もし明示的に四元数で値がセットされていなかった場合､
                // QuaternionI17F15.EulerZxyP5 で値を計算しキャッシュする｡
                if (!localRotation.HasValue) {
                    localRotation = QuaternionI17F15.EulerZxyP5(localEulerAnglesHint);
                }
                return localRotation.Value;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                if (localRotation.HasValue && localRotation.Value == value) {
                    return;
                }
                localRotation = value;
                localToWorldMatrix = null;
            }
        }

        public Matrix4x4I17F15 LocalToWorldMatrix {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                if (!localToWorldMatrix.HasValue) {
                    var y = Matrix4x4I17F15.TRS(localPosition, LocalRotation, localScale);
                    if (parent != null) {
                        var x = parent.LocalToWorldMatrix;
                        var m00 = x.C0.X.SaturatingMul(y.C0.X).SaturatingAdd(x.C1.X.SaturatingMul(y.C0.Y)).SaturatingAdd(x.C2.X.SaturatingMul(y.C0.Z));
                        var m01 = x.C0.X.SaturatingMul(y.C1.X).SaturatingAdd(x.C1.X.SaturatingMul(y.C1.Y)).SaturatingAdd(x.C2.X.SaturatingMul(y.C1.Z));
                        var m02 = x.C0.X.SaturatingMul(y.C2.X).SaturatingAdd(x.C1.X.SaturatingMul(y.C2.Y)).SaturatingAdd(x.C2.X.SaturatingMul(y.C2.Z));
                        var m03 = x.C0.X.SaturatingMul(y.C3.X).SaturatingAdd(x.C1.X.SaturatingMul(y.C3.Y)).SaturatingAdd(x.C2.X.SaturatingMul(y.C3.Z)).SaturatingAdd(x.C3.X);
                        var m10 = x.C0.Y.SaturatingMul(y.C0.X).SaturatingAdd(x.C1.Y.SaturatingMul(y.C0.Y)).SaturatingAdd(x.C2.Y.SaturatingMul(y.C0.Z));
                        var m11 = x.C0.Y.SaturatingMul(y.C1.X).SaturatingAdd(x.C1.Y.SaturatingMul(y.C1.Y)).SaturatingAdd(x.C2.Y.SaturatingMul(y.C1.Z));
                        var m12 = x.C0.Y.SaturatingMul(y.C2.X).SaturatingAdd(x.C1.Y.SaturatingMul(y.C2.Y)).SaturatingAdd(x.C2.Y.SaturatingMul(y.C2.Z));
                        var m13 = x.C0.Y.SaturatingMul(y.C3.X).SaturatingAdd(x.C1.Y.SaturatingMul(y.C3.Y)).SaturatingAdd(x.C2.Y.SaturatingMul(y.C3.Z)).SaturatingAdd(x.C3.Y);
                        var m20 = x.C0.Z.SaturatingMul(y.C0.X).SaturatingAdd(x.C1.Z.SaturatingMul(y.C0.Y)).SaturatingAdd(x.C2.Z.SaturatingMul(y.C0.Z));
                        var m21 = x.C0.Z.SaturatingMul(y.C1.X).SaturatingAdd(x.C1.Z.SaturatingMul(y.C1.Y)).SaturatingAdd(x.C2.Z.SaturatingMul(y.C1.Z));
                        var m22 = x.C0.Z.SaturatingMul(y.C2.X).SaturatingAdd(x.C1.Z.SaturatingMul(y.C2.Y)).SaturatingAdd(x.C2.Z.SaturatingMul(y.C2.Z));
                        var m23 = x.C0.Z.SaturatingMul(y.C3.X).SaturatingAdd(x.C1.Z.SaturatingMul(y.C3.Y)).SaturatingAdd(x.C2.Z.SaturatingMul(y.C3.Z)).SaturatingAdd(x.C3.Z);
                        localToWorldMatrix = new Matrix4x4I17F15(
                            new Vector4I17F15(m00, m10, m20, I17F15.Zero),
                            new Vector4I17F15(m01, m11, m21, I17F15.Zero),
                            new Vector4I17F15(m02, m12, m22, I17F15.Zero),
                            new Vector4I17F15(m03, m13, m23, I17F15.One));
                    } else {
                        localToWorldMatrix = y;
                    }
                }
                return localToWorldMatrix.Value;
            }
        }

        public Vector3I17F15 Position {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                if (!position.HasValue) {
                    // parent の Behaviour.isActiveAndEnabled の真偽に関わらず､
                    // 実際に null かどうかをチェックする｡
                    if (parent is null) {
                        position = localPosition;
                    } else {
                        var m = parent.LocalToWorldMatrix;
                        var x = m.C0.X.SaturatingMul(localPosition.X).SaturatingAdd(m.C1.X.SaturatingMul(localPosition.Y)).SaturatingAdd(m.C2.X.SaturatingMul(localPosition.Z)).SaturatingAdd(m.C3.X);
                        var y = m.C0.Y.SaturatingMul(localPosition.X).SaturatingAdd(m.C1.Y.SaturatingMul(localPosition.Y)).SaturatingAdd(m.C2.Y.SaturatingMul(localPosition.Z)).SaturatingAdd(m.C3.Y);
                        var z = m.C0.Z.SaturatingMul(localPosition.X).SaturatingAdd(m.C1.Z.SaturatingMul(localPosition.Y)).SaturatingAdd(m.C2.Z.SaturatingMul(localPosition.Z)).SaturatingAdd(m.C3.Z);
                        position = new Vector3I17F15(x, y, z);
                    }
                }
                return position.Value;
            }
        }

        // Methods
        // ---------------------------------------

#if UNITY_EDITOR

        void Update() {
            if (Application.isPlaying || !transform) {
                return;
            }
            {
                const float max = 65535;
                const float min = -65536;
                {
                    var x = Mathf.Clamp(transform.localPosition.x, min, max);
                    var y = Mathf.Clamp(transform.localPosition.y, min, max);
                    var z = Mathf.Clamp(transform.localPosition.z, min, max);
                    transform.localPosition = new Vector3(x, y, z);
                    localPosition = new Vector3I17F15(
                        I17F15.FromBits((int)(x * I17F15.One.Bits)),
                        I17F15.FromBits((int)(y * I17F15.One.Bits)),
                        I17F15.FromBits((int)(z * I17F15.One.Bits)));
                }
                {
                    var x = Mathf.Clamp(transform.localScale.x, min, max);
                    var y = Mathf.Clamp(transform.localScale.y, min, max);
                    var z = Mathf.Clamp(transform.localScale.z, min, max);
                    transform.localScale = new Vector3(x, y, z);
                    localScale = new Vector3I17F15(
                        I17F15.FromBits((int)(x * I17F15.One.Bits)),
                        I17F15.FromBits((int)(y * I17F15.One.Bits)),
                        I17F15.FromBits((int)(z * I17F15.One.Bits)));
                }
            }
            {
                const int right = 90;
                const float min = -5898240;
                const float max = 5898239;
                var serializedObject = new SerializedObject(transform);
                var serializedProperty = serializedObject.FindProperty("m_LocalEulerAnglesHint");
                var x = Mathf.Clamp(serializedProperty.vector3Value.x, min, max);
                var y = Mathf.Clamp(serializedProperty.vector3Value.y, min, max);
                var z = Mathf.Clamp(serializedProperty.vector3Value.z, min, max);
                var v = new Vector3(x, y, z);
                serializedProperty.vector3Value = v;
                _ = serializedObject.ApplyModifiedProperties();
                transform.localEulerAngles = v;
                localEulerAnglesHint = new Vector3I17F15(
                    I17F15.FromBits((int)(x * I17F15.One.Bits / right)),
                    I17F15.FromBits((int)(y * I17F15.One.Bits / right)),
                    I17F15.FromBits((int)(z * I17F15.One.Bits / right)));
            }
        }

#endif

#if UNITY_5_6_OR_NEWER

        void LateUpdate() {
            transform.localPosition = new Vector3(
                (float)localPosition.X,
                (float)localPosition.Y,
                (float)localPosition.Z);
            transform.localScale = new Vector3(
                (float)localScale.X,
                (float)localScale.Y,
                (float)localScale.Z);

            // TODO: Add rotation represented by Quaternion
        }

        void OnTransformParentChanged() {
            localToWorldMatrix = null;
            position = null;
        }

#endif

    }
}
