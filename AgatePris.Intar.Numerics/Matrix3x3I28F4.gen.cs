using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Matrix3x3I28F4 : IEquatable<Matrix3x3I28F4> {

        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3I28F4 C0;
        public Vector3I28F4 C1;
        public Vector3I28F4 C2;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix3x3I28F4(
            Vector3I28F4 c0,
            Vector3I28F4 c1,
            Vector3I28F4 c2
        ) {
            C0 = c0;
            C1 = c1;
            C2 = c2;
        }

        // Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Matrix3x3I28F4 left, Matrix3x3I28F4 right) => left.Equals(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Matrix3x3I28F4 left, Matrix3x3I28F4 right) => !(left == right);

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Matrix3x3I28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(C0, C1, C2);

        // IEquatable<Matrix3x3I28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Matrix3x3I28F4 other) =>
            C0 == other.C0 &&
            C1 == other.C1 &&
            C2 == other.C2;

    }
}
