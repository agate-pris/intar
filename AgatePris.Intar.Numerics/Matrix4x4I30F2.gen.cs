using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Matrix4x4I30F2 : IEquatable<Matrix4x4I30F2> {

        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4I30F2 C0;
        public Vector4I30F2 C1;
        public Vector4I30F2 C2;
        public Vector4I30F2 C3;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix4x4I30F2(
            Vector4I30F2 c0,
            Vector4I30F2 c1,
            Vector4I30F2 c2,
            Vector4I30F2 c3
        ) {
            C0 = c0;
            C1 = c1;
            C2 = c2;
            C3 = c3;
        }

        // Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Matrix4x4I30F2 left, Matrix4x4I30F2 right) => left.Equals(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Matrix4x4I30F2 left, Matrix4x4I30F2 right) => !(left == right);

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Matrix4x4I30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(C0, C1, C2, C3);

        // IEquatable<Matrix4x4I30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Matrix4x4I30F2 other) =>
            C0 == other.C0 &&
            C1 == other.C1 &&
            C2 == other.C2 &&
            C3 == other.C3;

    }
}
