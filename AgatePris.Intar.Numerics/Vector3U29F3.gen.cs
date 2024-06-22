using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U29F3 : IEquatable<Vector3U29F3>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U29F3 X;
        public U29F3 Y;
        public U29F3 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3U29F3 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(U29F3 x, U29F3 y, U29F3 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(U29F3 x, Vector2U29F3 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(Vector3U29F3 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(Vector2U29F3 xy, U29F3 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator +(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator -(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator *(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator *(Vector3U29F3 a, U29F3 b) => new Vector3U29F3(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator *(U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator /(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator /(Vector3U29F3 a, U29F3 b) => new Vector3U29F3(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator /(U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U29F3 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(X, X); }
        public readonly Vector2U29F3 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(X, Y); }
        public readonly Vector2U29F3 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(X, Z); }
        public readonly Vector2U29F3 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Y, X); }
        public readonly Vector2U29F3 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Y, Y); }
        public readonly Vector2U29F3 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Y, Z); }
        public readonly Vector2U29F3 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Z, X); }
        public readonly Vector2U29F3 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Z, Y); }
        public readonly Vector2U29F3 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Z, Z); }
        public readonly Vector3U29F3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, X, X); }
        public readonly Vector3U29F3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, X, Y); }
        public readonly Vector3U29F3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, X, Z); }
        public readonly Vector3U29F3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Y, X); }
        public readonly Vector3U29F3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Y, Y); }
        public readonly Vector3U29F3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Y, Z); }
        public readonly Vector3U29F3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Z, X); }
        public readonly Vector3U29F3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Z, Y); }
        public readonly Vector3U29F3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Z, Z); }
        public readonly Vector3U29F3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, X, X); }
        public readonly Vector3U29F3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, X, Y); }
        public readonly Vector3U29F3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, X, Z); }
        public readonly Vector3U29F3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Y, X); }
        public readonly Vector3U29F3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Y, Y); }
        public readonly Vector3U29F3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Y, Z); }
        public readonly Vector3U29F3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Z, X); }
        public readonly Vector3U29F3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Z, Y); }
        public readonly Vector3U29F3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Z, Z); }
        public readonly Vector3U29F3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, X, X); }
        public readonly Vector3U29F3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, X, Y); }
        public readonly Vector3U29F3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, X, Z); }
        public readonly Vector3U29F3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Y, X); }
        public readonly Vector3U29F3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Y, Y); }
        public readonly Vector3U29F3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Y, Z); }
        public readonly Vector3U29F3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Z, X); }
        public readonly Vector3U29F3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Z, Y); }
        public readonly Vector3U29F3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Z, Z); }
        public readonly Vector4U29F3 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, X, X); }
        public readonly Vector4U29F3 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, X, Y); }
        public readonly Vector4U29F3 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, X, Z); }
        public readonly Vector4U29F3 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Y, X); }
        public readonly Vector4U29F3 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Y, Y); }
        public readonly Vector4U29F3 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Y, Z); }
        public readonly Vector4U29F3 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Z, X); }
        public readonly Vector4U29F3 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Z, Y); }
        public readonly Vector4U29F3 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Z, Z); }
        public readonly Vector4U29F3 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, X, X); }
        public readonly Vector4U29F3 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, X, Y); }
        public readonly Vector4U29F3 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, X, Z); }
        public readonly Vector4U29F3 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Y, X); }
        public readonly Vector4U29F3 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Y, Y); }
        public readonly Vector4U29F3 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Y, Z); }
        public readonly Vector4U29F3 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Z, X); }
        public readonly Vector4U29F3 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Z, Y); }
        public readonly Vector4U29F3 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Z, Z); }
        public readonly Vector4U29F3 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, X, X); }
        public readonly Vector4U29F3 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, X, Y); }
        public readonly Vector4U29F3 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, X, Z); }
        public readonly Vector4U29F3 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Y, X); }
        public readonly Vector4U29F3 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Y, Y); }
        public readonly Vector4U29F3 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Y, Z); }
        public readonly Vector4U29F3 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Z, X); }
        public readonly Vector4U29F3 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Z, Y); }
        public readonly Vector4U29F3 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Z, Z); }
        public readonly Vector4U29F3 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, X, X); }
        public readonly Vector4U29F3 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, X, Y); }
        public readonly Vector4U29F3 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, X, Z); }
        public readonly Vector4U29F3 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Y, X); }
        public readonly Vector4U29F3 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Y, Y); }
        public readonly Vector4U29F3 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Y, Z); }
        public readonly Vector4U29F3 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Z, X); }
        public readonly Vector4U29F3 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Z, Y); }
        public readonly Vector4U29F3 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Z, Z); }
        public readonly Vector4U29F3 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, X, X); }
        public readonly Vector4U29F3 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, X, Y); }
        public readonly Vector4U29F3 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, X, Z); }
        public readonly Vector4U29F3 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Y, X); }
        public readonly Vector4U29F3 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Y, Y); }
        public readonly Vector4U29F3 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Y, Z); }
        public readonly Vector4U29F3 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Z, X); }
        public readonly Vector4U29F3 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Z, Y); }
        public readonly Vector4U29F3 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Z, Z); }
        public readonly Vector4U29F3 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, X, X); }
        public readonly Vector4U29F3 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, X, Y); }
        public readonly Vector4U29F3 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, X, Z); }
        public readonly Vector4U29F3 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Y, X); }
        public readonly Vector4U29F3 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Y, Y); }
        public readonly Vector4U29F3 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Y, Z); }
        public readonly Vector4U29F3 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Z, X); }
        public readonly Vector4U29F3 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Z, Y); }
        public readonly Vector4U29F3 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Z, Z); }
        public readonly Vector4U29F3 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, X, X); }
        public readonly Vector4U29F3 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, X, Y); }
        public readonly Vector4U29F3 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, X, Z); }
        public readonly Vector4U29F3 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Y, X); }
        public readonly Vector4U29F3 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Y, Y); }
        public readonly Vector4U29F3 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Y, Z); }
        public readonly Vector4U29F3 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Z, X); }
        public readonly Vector4U29F3 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Z, Y); }
        public readonly Vector4U29F3 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Z, Z); }
        public readonly Vector4U29F3 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, X, X); }
        public readonly Vector4U29F3 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, X, Y); }
        public readonly Vector4U29F3 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, X, Z); }
        public readonly Vector4U29F3 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Y, X); }
        public readonly Vector4U29F3 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Y, Y); }
        public readonly Vector4U29F3 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Y, Z); }
        public readonly Vector4U29F3 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Z, X); }
        public readonly Vector4U29F3 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Z, Y); }
        public readonly Vector4U29F3 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Z, Z); }
        public readonly Vector4U29F3 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, X, X); }
        public readonly Vector4U29F3 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, X, Y); }
        public readonly Vector4U29F3 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, X, Z); }
        public readonly Vector4U29F3 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Y, X); }
        public readonly Vector4U29F3 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Y, Y); }
        public readonly Vector4U29F3 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Y, Z); }
        public readonly Vector4U29F3 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Z, X); }
        public readonly Vector4U29F3 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Z, Y); }
        public readonly Vector4U29F3 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U29F3 lhs, Vector3U29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U29F3 lhs, Vector3U29F3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U29F3({X}, {Y}, {Z})";

        // IEquatable<Vector3U29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U29F3 other)
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
            return $"Vector3U29F3({x}, {y}, {z})";
        }
    }
}
