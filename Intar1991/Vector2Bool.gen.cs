using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Intar1991 {
    [Serializable]
    public struct Vector2Bool : IEquatable<Vector2Bool> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        [MarshalAs(UnmanagedType.U1)]
        public bool X;

        [MarshalAs(UnmanagedType.U1)]
        public bool Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Bool(bool x, bool y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Bool(bool value)
            : this(value, value) { }

        #region IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2Bool left, Vector2Bool right) {
            return new Vector2Bool(left.X == right.X, left.Y == right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2Bool left, Vector2Bool right) {
            return new Vector2Bool(left.X != right.X, left.Y != right.Y);
        }

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2Bool other) {
            return X == other.X && Y == other.Y;
        }

        #endregion

        #region Object

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj) {
            return obj is Vector2Bool o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() {
            return HashCode.Combine(X, Y);
        }

        #endregion

    }
}
