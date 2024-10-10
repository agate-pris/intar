using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Matrix4x4I17F15 : IEquatable<Matrix4x4I17F15> {

        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4I17F15 C0;
        public Vector4I17F15 C1;
        public Vector4I17F15 C2;
        public Vector4I17F15 C3;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix4x4I17F15(
            Vector4I17F15 c0,
            Vector4I17F15 c1,
            Vector4I17F15 c2,
            Vector4I17F15 c3
        ) {
            C0 = c0;
            C1 = c1;
            C2 = c2;
            C3 = c3;
        }

        // Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Matrix4x4I17F15 left, Matrix4x4I17F15 right) => left.Equals(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Matrix4x4I17F15 left, Matrix4x4I17F15 right) => !(left == right);

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Matrix4x4I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(C0, C1, C2, C3);

        // IEquatable<Matrix4x4I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Matrix4x4I17F15 other) =>
            C0 == other.C0 &&
            C1 == other.C1 &&
            C2 == other.C2 &&
            C3 == other.C3;

        // Methods
        // ---------------------------------------

        /// Prerequisite: q is normalized (to prevent overflow)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4I17F15 TRS(
            Vector3I17F15 translation, QuaternionI17F15 rotation, Vector3I17F15 scale
        ) {
            var v = rotation.IJKW;
            var vXNeg = -rotation.I;
            var vYNeg = -rotation.J;
            var vZNeg = -rotation.K;
            var vWNeg = -rotation.W;
            var v2 = v.Twice();
            var c0 = Vector3I17F15.UnitX + (v2.Y * new Vector3I17F15(vYNeg, v.X, vWNeg)) - (v2.Z * new Vector3I17F15(v.Z, vWNeg, vXNeg));
            var c1 = Vector3I17F15.UnitY + (v2.Z * new Vector3I17F15(vWNeg, vZNeg, v.Y)) - (v2.X * new Vector3I17F15(vYNeg, v.X, vWNeg));
            var c2 = Vector3I17F15.UnitZ + (v2.X * new Vector3I17F15(v.Z, vWNeg, vXNeg)) - (v2.Y * new Vector3I17F15(vWNeg, vZNeg, v.Y));
            return new Matrix4x4I17F15(
                new Vector4I17F15(c0.SaturatingMul(scale.X), I17F15.Zero),
                new Vector4I17F15(c1.SaturatingMul(scale.Y), I17F15.Zero),
                new Vector4I17F15(c2.SaturatingMul(scale.Z), I17F15.Zero),
                new Vector4I17F15(translation, I17F15.One));
        }

    }
}
