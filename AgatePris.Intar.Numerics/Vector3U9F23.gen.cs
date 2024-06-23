using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U9F23 : IEquatable<Vector3U9F23>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U9F23 X;
        public U9F23 Y;
        public U9F23 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3U9F23 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U9F23(U9F23 x, U9F23 y, U9F23 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U9F23(U9F23 x, Vector2U9F23 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U9F23(Vector3U9F23 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U9F23(Vector2U9F23 xy, U9F23 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator +(Vector3U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator -(Vector3U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator *(Vector3U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator *(Vector3U9F23 a, U9F23 b) => new Vector3U9F23(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator *(U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator /(Vector3U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator /(Vector3U9F23 a, U9F23 b) => new Vector3U9F23(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator /(U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U9F23 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, X); }
        public readonly Vector2U9F23 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, Y); }
        public readonly Vector2U9F23 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, Z); }
        public readonly Vector2U9F23 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, X); }
        public readonly Vector2U9F23 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, Y); }
        public readonly Vector2U9F23 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, Z); }
        public readonly Vector2U9F23 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Z, X); }
        public readonly Vector2U9F23 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Z, Y); }
        public readonly Vector2U9F23 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Z, Z); }
        public readonly Vector3U9F23 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, X); }
        public readonly Vector3U9F23 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, Y); }
        public readonly Vector3U9F23 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, Z); }
        public readonly Vector3U9F23 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, X); }
        public readonly Vector3U9F23 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, Y); }
        public readonly Vector3U9F23 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, Z); }
        public readonly Vector3U9F23 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Z, X); }
        public readonly Vector3U9F23 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Z, Y); }
        public readonly Vector3U9F23 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Z, Z); }
        public readonly Vector3U9F23 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, X); }
        public readonly Vector3U9F23 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, Y); }
        public readonly Vector3U9F23 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, Z); }
        public readonly Vector3U9F23 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, X); }
        public readonly Vector3U9F23 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, Y); }
        public readonly Vector3U9F23 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, Z); }
        public readonly Vector3U9F23 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Z, X); }
        public readonly Vector3U9F23 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Z, Y); }
        public readonly Vector3U9F23 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Z, Z); }
        public readonly Vector3U9F23 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, X, X); }
        public readonly Vector3U9F23 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, X, Y); }
        public readonly Vector3U9F23 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, X, Z); }
        public readonly Vector3U9F23 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Y, X); }
        public readonly Vector3U9F23 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Y, Y); }
        public readonly Vector3U9F23 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Y, Z); }
        public readonly Vector3U9F23 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Z, X); }
        public readonly Vector3U9F23 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Z, Y); }
        public readonly Vector3U9F23 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Z, Z); }
        public readonly Vector4U9F23 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, X); }
        public readonly Vector4U9F23 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, Y); }
        public readonly Vector4U9F23 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, Z); }
        public readonly Vector4U9F23 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, X); }
        public readonly Vector4U9F23 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, Y); }
        public readonly Vector4U9F23 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, Z); }
        public readonly Vector4U9F23 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Z, X); }
        public readonly Vector4U9F23 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Z, Y); }
        public readonly Vector4U9F23 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Z, Z); }
        public readonly Vector4U9F23 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, X); }
        public readonly Vector4U9F23 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, Y); }
        public readonly Vector4U9F23 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, Z); }
        public readonly Vector4U9F23 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, X); }
        public readonly Vector4U9F23 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, Y); }
        public readonly Vector4U9F23 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, Z); }
        public readonly Vector4U9F23 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Z, X); }
        public readonly Vector4U9F23 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Z, Y); }
        public readonly Vector4U9F23 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Z, Z); }
        public readonly Vector4U9F23 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, X, X); }
        public readonly Vector4U9F23 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, X, Y); }
        public readonly Vector4U9F23 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, X, Z); }
        public readonly Vector4U9F23 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Y, X); }
        public readonly Vector4U9F23 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Y, Y); }
        public readonly Vector4U9F23 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Y, Z); }
        public readonly Vector4U9F23 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Z, X); }
        public readonly Vector4U9F23 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Z, Y); }
        public readonly Vector4U9F23 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Z, Z); }
        public readonly Vector4U9F23 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, X); }
        public readonly Vector4U9F23 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, Y); }
        public readonly Vector4U9F23 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, Z); }
        public readonly Vector4U9F23 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, X); }
        public readonly Vector4U9F23 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, Y); }
        public readonly Vector4U9F23 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, Z); }
        public readonly Vector4U9F23 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Z, X); }
        public readonly Vector4U9F23 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Z, Y); }
        public readonly Vector4U9F23 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Z, Z); }
        public readonly Vector4U9F23 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, X); }
        public readonly Vector4U9F23 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, Y); }
        public readonly Vector4U9F23 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, Z); }
        public readonly Vector4U9F23 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, X); }
        public readonly Vector4U9F23 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, Y); }
        public readonly Vector4U9F23 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, Z); }
        public readonly Vector4U9F23 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Z, X); }
        public readonly Vector4U9F23 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Z, Y); }
        public readonly Vector4U9F23 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Z, Z); }
        public readonly Vector4U9F23 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, X, X); }
        public readonly Vector4U9F23 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, X, Y); }
        public readonly Vector4U9F23 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, X, Z); }
        public readonly Vector4U9F23 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Y, X); }
        public readonly Vector4U9F23 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Y, Y); }
        public readonly Vector4U9F23 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Y, Z); }
        public readonly Vector4U9F23 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Z, X); }
        public readonly Vector4U9F23 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Z, Y); }
        public readonly Vector4U9F23 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Z, Z); }
        public readonly Vector4U9F23 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, X, X); }
        public readonly Vector4U9F23 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, X, Y); }
        public readonly Vector4U9F23 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, X, Z); }
        public readonly Vector4U9F23 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Y, X); }
        public readonly Vector4U9F23 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Y, Y); }
        public readonly Vector4U9F23 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Y, Z); }
        public readonly Vector4U9F23 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Z, X); }
        public readonly Vector4U9F23 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Z, Y); }
        public readonly Vector4U9F23 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Z, Z); }
        public readonly Vector4U9F23 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, X, X); }
        public readonly Vector4U9F23 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, X, Y); }
        public readonly Vector4U9F23 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, X, Z); }
        public readonly Vector4U9F23 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Y, X); }
        public readonly Vector4U9F23 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Y, Y); }
        public readonly Vector4U9F23 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Y, Z); }
        public readonly Vector4U9F23 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Z, X); }
        public readonly Vector4U9F23 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Z, Y); }
        public readonly Vector4U9F23 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Z, Z); }
        public readonly Vector4U9F23 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, X, X); }
        public readonly Vector4U9F23 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, X, Y); }
        public readonly Vector4U9F23 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, X, Z); }
        public readonly Vector4U9F23 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Y, X); }
        public readonly Vector4U9F23 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Y, Y); }
        public readonly Vector4U9F23 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Y, Z); }
        public readonly Vector4U9F23 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Z, X); }
        public readonly Vector4U9F23 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Z, Y); }
        public readonly Vector4U9F23 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U9F23 lhs, Vector3U9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U9F23 lhs, Vector3U9F23 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U9F23({X}, {Y}, {Z})";

        // IEquatable<Vector3U9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U9F23 other)
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
            return $"Vector3U9F23({x}, {y}, {z})";
        }
    }
}
