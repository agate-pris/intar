using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U22F10 : IEquatable<Vector3U22F10>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U22F10 X;
        public U22F10 Y;
        public U22F10 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3U22F10 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(U22F10 x, U22F10 y, U22F10 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(U22F10 x, Vector2U22F10 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(Vector3U22F10 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(Vector2U22F10 xy, U22F10 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator +(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator -(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator *(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator *(Vector3U22F10 a, U22F10 b) => new Vector3U22F10(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator *(U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator /(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator /(Vector3U22F10 a, U22F10 b) => new Vector3U22F10(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator /(U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U22F10 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, X); }
        public readonly Vector2U22F10 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, Y); }
        public readonly Vector2U22F10 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, Z); }
        public readonly Vector2U22F10 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, X); }
        public readonly Vector2U22F10 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, Y); }
        public readonly Vector2U22F10 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, Z); }
        public readonly Vector2U22F10 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Z, X); }
        public readonly Vector2U22F10 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Z, Y); }
        public readonly Vector2U22F10 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Z, Z); }
        public readonly Vector3U22F10 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, X); }
        public readonly Vector3U22F10 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, Y); }
        public readonly Vector3U22F10 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, Z); }
        public readonly Vector3U22F10 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, X); }
        public readonly Vector3U22F10 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, Y); }
        public readonly Vector3U22F10 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, Z); }
        public readonly Vector3U22F10 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Z, X); }
        public readonly Vector3U22F10 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Z, Y); }
        public readonly Vector3U22F10 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Z, Z); }
        public readonly Vector3U22F10 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, X); }
        public readonly Vector3U22F10 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, Y); }
        public readonly Vector3U22F10 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, Z); }
        public readonly Vector3U22F10 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, X); }
        public readonly Vector3U22F10 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, Y); }
        public readonly Vector3U22F10 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, Z); }
        public readonly Vector3U22F10 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Z, X); }
        public readonly Vector3U22F10 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Z, Y); }
        public readonly Vector3U22F10 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Z, Z); }
        public readonly Vector3U22F10 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, X, X); }
        public readonly Vector3U22F10 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, X, Y); }
        public readonly Vector3U22F10 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, X, Z); }
        public readonly Vector3U22F10 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Y, X); }
        public readonly Vector3U22F10 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Y, Y); }
        public readonly Vector3U22F10 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Y, Z); }
        public readonly Vector3U22F10 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Z, X); }
        public readonly Vector3U22F10 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Z, Y); }
        public readonly Vector3U22F10 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Z, Z); }
        public readonly Vector4U22F10 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, X); }
        public readonly Vector4U22F10 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, Y); }
        public readonly Vector4U22F10 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, Z); }
        public readonly Vector4U22F10 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, X); }
        public readonly Vector4U22F10 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, Y); }
        public readonly Vector4U22F10 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, Z); }
        public readonly Vector4U22F10 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Z, X); }
        public readonly Vector4U22F10 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Z, Y); }
        public readonly Vector4U22F10 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Z, Z); }
        public readonly Vector4U22F10 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, X); }
        public readonly Vector4U22F10 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, Y); }
        public readonly Vector4U22F10 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, Z); }
        public readonly Vector4U22F10 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, X); }
        public readonly Vector4U22F10 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, Y); }
        public readonly Vector4U22F10 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, Z); }
        public readonly Vector4U22F10 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Z, X); }
        public readonly Vector4U22F10 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Z, Y); }
        public readonly Vector4U22F10 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Z, Z); }
        public readonly Vector4U22F10 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, X, X); }
        public readonly Vector4U22F10 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, X, Y); }
        public readonly Vector4U22F10 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, X, Z); }
        public readonly Vector4U22F10 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Y, X); }
        public readonly Vector4U22F10 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Y, Y); }
        public readonly Vector4U22F10 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Y, Z); }
        public readonly Vector4U22F10 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Z, X); }
        public readonly Vector4U22F10 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Z, Y); }
        public readonly Vector4U22F10 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Z, Z); }
        public readonly Vector4U22F10 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, X); }
        public readonly Vector4U22F10 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, Y); }
        public readonly Vector4U22F10 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, Z); }
        public readonly Vector4U22F10 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, X); }
        public readonly Vector4U22F10 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, Y); }
        public readonly Vector4U22F10 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, Z); }
        public readonly Vector4U22F10 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Z, X); }
        public readonly Vector4U22F10 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Z, Y); }
        public readonly Vector4U22F10 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Z, Z); }
        public readonly Vector4U22F10 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, X); }
        public readonly Vector4U22F10 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, Y); }
        public readonly Vector4U22F10 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, Z); }
        public readonly Vector4U22F10 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, X); }
        public readonly Vector4U22F10 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, Y); }
        public readonly Vector4U22F10 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, Z); }
        public readonly Vector4U22F10 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Z, X); }
        public readonly Vector4U22F10 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Z, Y); }
        public readonly Vector4U22F10 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Z, Z); }
        public readonly Vector4U22F10 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, X, X); }
        public readonly Vector4U22F10 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, X, Y); }
        public readonly Vector4U22F10 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, X, Z); }
        public readonly Vector4U22F10 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Y, X); }
        public readonly Vector4U22F10 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Y, Y); }
        public readonly Vector4U22F10 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Y, Z); }
        public readonly Vector4U22F10 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Z, X); }
        public readonly Vector4U22F10 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Z, Y); }
        public readonly Vector4U22F10 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Z, Z); }
        public readonly Vector4U22F10 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, X, X); }
        public readonly Vector4U22F10 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, X, Y); }
        public readonly Vector4U22F10 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, X, Z); }
        public readonly Vector4U22F10 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Y, X); }
        public readonly Vector4U22F10 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Y, Y); }
        public readonly Vector4U22F10 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Y, Z); }
        public readonly Vector4U22F10 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Z, X); }
        public readonly Vector4U22F10 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Z, Y); }
        public readonly Vector4U22F10 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Z, Z); }
        public readonly Vector4U22F10 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, X, X); }
        public readonly Vector4U22F10 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, X, Y); }
        public readonly Vector4U22F10 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, X, Z); }
        public readonly Vector4U22F10 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Y, X); }
        public readonly Vector4U22F10 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Y, Y); }
        public readonly Vector4U22F10 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Y, Z); }
        public readonly Vector4U22F10 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Z, X); }
        public readonly Vector4U22F10 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Z, Y); }
        public readonly Vector4U22F10 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Z, Z); }
        public readonly Vector4U22F10 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, X, X); }
        public readonly Vector4U22F10 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, X, Y); }
        public readonly Vector4U22F10 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, X, Z); }
        public readonly Vector4U22F10 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Y, X); }
        public readonly Vector4U22F10 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Y, Y); }
        public readonly Vector4U22F10 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Y, Z); }
        public readonly Vector4U22F10 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Z, X); }
        public readonly Vector4U22F10 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Z, Y); }
        public readonly Vector4U22F10 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U22F10 lhs, Vector3U22F10 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U22F10 lhs, Vector3U22F10 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U22F10 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U22F10({X}, {Y}, {Z})";

        // IEquatable<Vector3U22F10>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U22F10 other)
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
            return $"Vector3U22F10({x}, {y}, {z})";
        }
    }
}
