using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Intar1991 {
    [Serializable]
    public struct Vector4Bool : IEquatable<Vector4Bool> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        [MarshalAs(UnmanagedType.U1)]
        public bool X;

        [MarshalAs(UnmanagedType.U1)]
        public bool Y;

        [MarshalAs(UnmanagedType.U1)]
        public bool Z;

        [MarshalAs(UnmanagedType.U1)]
        public bool W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Bool(bool x, bool y, bool z, bool w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Bool(bool value)
            : this(value, value, value, value) { }

        #region IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4Bool left, Vector4Bool right) {
            return new Vector4Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z, left.W == right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4Bool left, Vector4Bool right) {
            return new Vector4Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z, left.W != right.W);
        }

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4Bool other) {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }

        #endregion

        #region Object

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj) {
            return obj is Vector4Bool o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() {
            return HashCode.Combine(X, Y, Z, W);
        }

        #endregion

    }
}
