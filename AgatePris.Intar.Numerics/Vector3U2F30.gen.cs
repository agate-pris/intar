using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U2F30 : IEquatable<Vector3U2F30>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U2F30 X;
        public U2F30 Y;
        public U2F30 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3U2F30 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30(U2F30 x, U2F30 y, U2F30 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30(U2F30 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30(U2F30 x, Vector2U2F30 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30(Vector3U2F30 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30(Vector2U2F30 xy, U2F30 z) : this(xy.X, xy.Y, z) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator +(Vector3U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator -(Vector3U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator *(Vector3U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator *(Vector3U2F30 a, U2F30 b) => new Vector3U2F30(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator *(U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator /(Vector3U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator /(Vector3U2F30 a, U2F30 b) => new Vector3U2F30(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator /(U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U2F30 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(X, X); }
        public readonly Vector2U2F30 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(X, Y); }
        public readonly Vector2U2F30 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(X, Z); }
        public readonly Vector2U2F30 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Y, X); }
        public readonly Vector2U2F30 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Y, Y); }
        public readonly Vector2U2F30 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Y, Z); }
        public readonly Vector2U2F30 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Z, X); }
        public readonly Vector2U2F30 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Z, Y); }
        public readonly Vector2U2F30 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Z, Z); }
        public readonly Vector3U2F30 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, X, X); }
        public readonly Vector3U2F30 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, X, Y); }
        public readonly Vector3U2F30 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, X, Z); }
        public readonly Vector3U2F30 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Y, X); }
        public readonly Vector3U2F30 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Y, Y); }
        public readonly Vector3U2F30 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Y, Z); }
        public readonly Vector3U2F30 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Z, X); }
        public readonly Vector3U2F30 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Z, Y); }
        public readonly Vector3U2F30 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Z, Z); }
        public readonly Vector3U2F30 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, X, X); }
        public readonly Vector3U2F30 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, X, Y); }
        public readonly Vector3U2F30 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, X, Z); }
        public readonly Vector3U2F30 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Y, X); }
        public readonly Vector3U2F30 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Y, Y); }
        public readonly Vector3U2F30 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Y, Z); }
        public readonly Vector3U2F30 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Z, X); }
        public readonly Vector3U2F30 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Z, Y); }
        public readonly Vector3U2F30 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Z, Z); }
        public readonly Vector3U2F30 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, X, X); }
        public readonly Vector3U2F30 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, X, Y); }
        public readonly Vector3U2F30 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, X, Z); }
        public readonly Vector3U2F30 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Y, X); }
        public readonly Vector3U2F30 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Y, Y); }
        public readonly Vector3U2F30 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Y, Z); }
        public readonly Vector3U2F30 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Z, X); }
        public readonly Vector3U2F30 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Z, Y); }
        public readonly Vector3U2F30 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Z, Z); }
        public readonly Vector4U2F30 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, X, X); }
        public readonly Vector4U2F30 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, X, Y); }
        public readonly Vector4U2F30 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, X, Z); }
        public readonly Vector4U2F30 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Y, X); }
        public readonly Vector4U2F30 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Y, Y); }
        public readonly Vector4U2F30 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Y, Z); }
        public readonly Vector4U2F30 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Z, X); }
        public readonly Vector4U2F30 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Z, Y); }
        public readonly Vector4U2F30 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Z, Z); }
        public readonly Vector4U2F30 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, X, X); }
        public readonly Vector4U2F30 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, X, Y); }
        public readonly Vector4U2F30 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, X, Z); }
        public readonly Vector4U2F30 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Y, X); }
        public readonly Vector4U2F30 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Y, Y); }
        public readonly Vector4U2F30 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Y, Z); }
        public readonly Vector4U2F30 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Z, X); }
        public readonly Vector4U2F30 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Z, Y); }
        public readonly Vector4U2F30 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Z, Z); }
        public readonly Vector4U2F30 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, X, X); }
        public readonly Vector4U2F30 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, X, Y); }
        public readonly Vector4U2F30 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, X, Z); }
        public readonly Vector4U2F30 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Y, X); }
        public readonly Vector4U2F30 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Y, Y); }
        public readonly Vector4U2F30 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Y, Z); }
        public readonly Vector4U2F30 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Z, X); }
        public readonly Vector4U2F30 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Z, Y); }
        public readonly Vector4U2F30 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Z, Z); }
        public readonly Vector4U2F30 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, X, X); }
        public readonly Vector4U2F30 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, X, Y); }
        public readonly Vector4U2F30 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, X, Z); }
        public readonly Vector4U2F30 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Y, X); }
        public readonly Vector4U2F30 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Y, Y); }
        public readonly Vector4U2F30 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Y, Z); }
        public readonly Vector4U2F30 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Z, X); }
        public readonly Vector4U2F30 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Z, Y); }
        public readonly Vector4U2F30 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Z, Z); }
        public readonly Vector4U2F30 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, X, X); }
        public readonly Vector4U2F30 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, X, Y); }
        public readonly Vector4U2F30 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, X, Z); }
        public readonly Vector4U2F30 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Y, X); }
        public readonly Vector4U2F30 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Y, Y); }
        public readonly Vector4U2F30 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Y, Z); }
        public readonly Vector4U2F30 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Z, X); }
        public readonly Vector4U2F30 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Z, Y); }
        public readonly Vector4U2F30 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Z, Z); }
        public readonly Vector4U2F30 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, X, X); }
        public readonly Vector4U2F30 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, X, Y); }
        public readonly Vector4U2F30 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, X, Z); }
        public readonly Vector4U2F30 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Y, X); }
        public readonly Vector4U2F30 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Y, Y); }
        public readonly Vector4U2F30 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Y, Z); }
        public readonly Vector4U2F30 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Z, X); }
        public readonly Vector4U2F30 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Z, Y); }
        public readonly Vector4U2F30 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Z, Z); }
        public readonly Vector4U2F30 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, X, X); }
        public readonly Vector4U2F30 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, X, Y); }
        public readonly Vector4U2F30 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, X, Z); }
        public readonly Vector4U2F30 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Y, X); }
        public readonly Vector4U2F30 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Y, Y); }
        public readonly Vector4U2F30 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Y, Z); }
        public readonly Vector4U2F30 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Z, X); }
        public readonly Vector4U2F30 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Z, Y); }
        public readonly Vector4U2F30 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Z, Z); }
        public readonly Vector4U2F30 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, X, X); }
        public readonly Vector4U2F30 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, X, Y); }
        public readonly Vector4U2F30 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, X, Z); }
        public readonly Vector4U2F30 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Y, X); }
        public readonly Vector4U2F30 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Y, Y); }
        public readonly Vector4U2F30 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Y, Z); }
        public readonly Vector4U2F30 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Z, X); }
        public readonly Vector4U2F30 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Z, Y); }
        public readonly Vector4U2F30 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Z, Z); }
        public readonly Vector4U2F30 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, X, X); }
        public readonly Vector4U2F30 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, X, Y); }
        public readonly Vector4U2F30 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, X, Z); }
        public readonly Vector4U2F30 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Y, X); }
        public readonly Vector4U2F30 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Y, Y); }
        public readonly Vector4U2F30 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Y, Z); }
        public readonly Vector4U2F30 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Z, X); }
        public readonly Vector4U2F30 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Z, Y); }
        public readonly Vector4U2F30 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U2F30 lhs, Vector3U2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U2F30 lhs, Vector3U2F30 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U2F30({X}, {Y}, {Z})";

        // IEquatable<Vector3U2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U2F30 other)
            => other.X == X
            && other.Y == Y
            && other.Z == Z;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            return $"Vector3U2F30({x}, {y}, {z})";
        }
    }
}
