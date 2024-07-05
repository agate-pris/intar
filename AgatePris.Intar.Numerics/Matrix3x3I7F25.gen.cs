using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Matrix3x3I7F25 : IEquatable<Matrix3x3I7F25> {

        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3I7F25 C0;
        public Vector3I7F25 C1;
        public Vector3I7F25 C2;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix3x3I7F25(
            Vector3I7F25 c0,
            Vector3I7F25 c1,
            Vector3I7F25 c2
        ) {
            C0 = c0;
            C1 = c1;
            C2 = c2;
        }

        // Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Matrix3x3I7F25 left, Matrix3x3I7F25 right) => left.Equals(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Matrix3x3I7F25 left, Matrix3x3I7F25 right) => !(left == right);

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Matrix3x3I7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(C0, C1, C2);

        // IEquatable<Matrix3x3I7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Matrix3x3I7F25 other) =>
            C0 == other.C0 &&
            C1 == other.C1 &&
            C2 == other.C2;

    }
}
