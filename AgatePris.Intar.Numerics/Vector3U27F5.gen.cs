using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U27F5 : IEquatable<Vector3U27F5>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U27F5 X;
        public U27F5 Y;
        public U27F5 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3U27F5 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U27F5(U27F5 x, U27F5 y, U27F5 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U27F5(U27F5 x, Vector2U27F5 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U27F5(Vector3U27F5 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U27F5(Vector2U27F5 xy, U27F5 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator +(Vector3U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator -(Vector3U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator *(Vector3U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator *(Vector3U27F5 a, U27F5 b) => new Vector3U27F5(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator *(U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator /(Vector3U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator /(Vector3U27F5 a, U27F5 b) => new Vector3U27F5(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator /(U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U27F5 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(X, X); }
        public readonly Vector2U27F5 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(X, Y); }
        public readonly Vector2U27F5 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(X, Z); }
        public readonly Vector2U27F5 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Y, X); }
        public readonly Vector2U27F5 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Y, Y); }
        public readonly Vector2U27F5 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Y, Z); }
        public readonly Vector2U27F5 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Z, X); }
        public readonly Vector2U27F5 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Z, Y); }
        public readonly Vector2U27F5 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Z, Z); }
        public readonly Vector3U27F5 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, X, X); }
        public readonly Vector3U27F5 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, X, Y); }
        public readonly Vector3U27F5 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, X, Z); }
        public readonly Vector3U27F5 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Y, X); }
        public readonly Vector3U27F5 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Y, Y); }
        public readonly Vector3U27F5 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Y, Z); }
        public readonly Vector3U27F5 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Z, X); }
        public readonly Vector3U27F5 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Z, Y); }
        public readonly Vector3U27F5 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Z, Z); }
        public readonly Vector3U27F5 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, X, X); }
        public readonly Vector3U27F5 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, X, Y); }
        public readonly Vector3U27F5 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, X, Z); }
        public readonly Vector3U27F5 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Y, X); }
        public readonly Vector3U27F5 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Y, Y); }
        public readonly Vector3U27F5 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Y, Z); }
        public readonly Vector3U27F5 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Z, X); }
        public readonly Vector3U27F5 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Z, Y); }
        public readonly Vector3U27F5 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Z, Z); }
        public readonly Vector3U27F5 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, X, X); }
        public readonly Vector3U27F5 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, X, Y); }
        public readonly Vector3U27F5 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, X, Z); }
        public readonly Vector3U27F5 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Y, X); }
        public readonly Vector3U27F5 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Y, Y); }
        public readonly Vector3U27F5 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Y, Z); }
        public readonly Vector3U27F5 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Z, X); }
        public readonly Vector3U27F5 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Z, Y); }
        public readonly Vector3U27F5 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Z, Z); }
        public readonly Vector4U27F5 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, X, X); }
        public readonly Vector4U27F5 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, X, Y); }
        public readonly Vector4U27F5 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, X, Z); }
        public readonly Vector4U27F5 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Y, X); }
        public readonly Vector4U27F5 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Y, Y); }
        public readonly Vector4U27F5 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Y, Z); }
        public readonly Vector4U27F5 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Z, X); }
        public readonly Vector4U27F5 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Z, Y); }
        public readonly Vector4U27F5 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Z, Z); }
        public readonly Vector4U27F5 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, X, X); }
        public readonly Vector4U27F5 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, X, Y); }
        public readonly Vector4U27F5 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, X, Z); }
        public readonly Vector4U27F5 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Y, X); }
        public readonly Vector4U27F5 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Y, Y); }
        public readonly Vector4U27F5 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Y, Z); }
        public readonly Vector4U27F5 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Z, X); }
        public readonly Vector4U27F5 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Z, Y); }
        public readonly Vector4U27F5 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Z, Z); }
        public readonly Vector4U27F5 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, X, X); }
        public readonly Vector4U27F5 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, X, Y); }
        public readonly Vector4U27F5 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, X, Z); }
        public readonly Vector4U27F5 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Y, X); }
        public readonly Vector4U27F5 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Y, Y); }
        public readonly Vector4U27F5 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Y, Z); }
        public readonly Vector4U27F5 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Z, X); }
        public readonly Vector4U27F5 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Z, Y); }
        public readonly Vector4U27F5 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Z, Z); }
        public readonly Vector4U27F5 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, X, X); }
        public readonly Vector4U27F5 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, X, Y); }
        public readonly Vector4U27F5 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, X, Z); }
        public readonly Vector4U27F5 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Y, X); }
        public readonly Vector4U27F5 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Y, Y); }
        public readonly Vector4U27F5 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Y, Z); }
        public readonly Vector4U27F5 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Z, X); }
        public readonly Vector4U27F5 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Z, Y); }
        public readonly Vector4U27F5 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Z, Z); }
        public readonly Vector4U27F5 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, X, X); }
        public readonly Vector4U27F5 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, X, Y); }
        public readonly Vector4U27F5 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, X, Z); }
        public readonly Vector4U27F5 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Y, X); }
        public readonly Vector4U27F5 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Y, Y); }
        public readonly Vector4U27F5 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Y, Z); }
        public readonly Vector4U27F5 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Z, X); }
        public readonly Vector4U27F5 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Z, Y); }
        public readonly Vector4U27F5 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Z, Z); }
        public readonly Vector4U27F5 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, X, X); }
        public readonly Vector4U27F5 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, X, Y); }
        public readonly Vector4U27F5 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, X, Z); }
        public readonly Vector4U27F5 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Y, X); }
        public readonly Vector4U27F5 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Y, Y); }
        public readonly Vector4U27F5 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Y, Z); }
        public readonly Vector4U27F5 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Z, X); }
        public readonly Vector4U27F5 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Z, Y); }
        public readonly Vector4U27F5 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Z, Z); }
        public readonly Vector4U27F5 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, X, X); }
        public readonly Vector4U27F5 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, X, Y); }
        public readonly Vector4U27F5 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, X, Z); }
        public readonly Vector4U27F5 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Y, X); }
        public readonly Vector4U27F5 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Y, Y); }
        public readonly Vector4U27F5 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Y, Z); }
        public readonly Vector4U27F5 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Z, X); }
        public readonly Vector4U27F5 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Z, Y); }
        public readonly Vector4U27F5 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Z, Z); }
        public readonly Vector4U27F5 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, X, X); }
        public readonly Vector4U27F5 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, X, Y); }
        public readonly Vector4U27F5 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, X, Z); }
        public readonly Vector4U27F5 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Y, X); }
        public readonly Vector4U27F5 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Y, Y); }
        public readonly Vector4U27F5 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Y, Z); }
        public readonly Vector4U27F5 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Z, X); }
        public readonly Vector4U27F5 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Z, Y); }
        public readonly Vector4U27F5 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Z, Z); }
        public readonly Vector4U27F5 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, X, X); }
        public readonly Vector4U27F5 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, X, Y); }
        public readonly Vector4U27F5 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, X, Z); }
        public readonly Vector4U27F5 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Y, X); }
        public readonly Vector4U27F5 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Y, Y); }
        public readonly Vector4U27F5 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Y, Z); }
        public readonly Vector4U27F5 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Z, X); }
        public readonly Vector4U27F5 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Z, Y); }
        public readonly Vector4U27F5 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U27F5 lhs, Vector3U27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U27F5 lhs, Vector3U27F5 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U27F5({X}, {Y}, {Z})";

        // IEquatable<Vector3U27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U27F5 other)
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
            return $"Vector3U27F5({x}, {y}, {z})";
        }
    }
}
