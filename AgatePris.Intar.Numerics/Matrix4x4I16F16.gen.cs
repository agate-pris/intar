using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Matrix4x4I16F16 : IEquatable<Matrix4x4I16F16> {

        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4I16F16 C0;
        public Vector4I16F16 C1;
        public Vector4I16F16 C2;
        public Vector4I16F16 C3;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix4x4I16F16(
            Vector4I16F16 c0,
            Vector4I16F16 c1,
            Vector4I16F16 c2,
            Vector4I16F16 c3
        ) {
            C0 = c0;
            C1 = c1;
            C2 = c2;
            C3 = c3;
        }

        // Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Matrix4x4I16F16 left, Matrix4x4I16F16 right) => left.Equals(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Matrix4x4I16F16 left, Matrix4x4I16F16 right) => !(left == right);

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Matrix4x4I16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(C0, C1, C2, C3);

        // IEquatable<Matrix4x4I16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Matrix4x4I16F16 other) =>
            C0 == other.C0 &&
            C1 == other.C1 &&
            C2 == other.C2 &&
            C3 == other.C3;

    }
}
