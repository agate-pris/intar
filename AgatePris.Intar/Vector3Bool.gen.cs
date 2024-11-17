using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct Vector3Bool : IEquatable<Vector3Bool> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        [MarshalAs(UnmanagedType.U1)]
        public bool X;

        [MarshalAs(UnmanagedType.U1)]
        public bool Y;

        [MarshalAs(UnmanagedType.U1)]
        public bool Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Bool(bool x, bool y, bool z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Bool(bool value)
            : this(value, value, value) { }

        #region IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3Bool left, Vector3Bool right) {
            return new Vector3Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3Bool left, Vector3Bool right) {
            return new Vector3Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z);
        }

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3Bool other) {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        #endregion

        #region Object

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj) {
            return obj is Vector3Bool o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() {
            return HashCode.Combine(X, Y, Z);
        }

        #endregion

    }
}
