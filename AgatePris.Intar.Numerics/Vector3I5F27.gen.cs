using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I5F27 : IEquatable<Vector3I5F27>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I5F27 X;
        public I5F27 Y;
        public I5F27 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I5F27 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(I5F27 x, I5F27 y, I5F27 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(I5F27 x, Vector2I5F27 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(Vector3I5F27 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(Vector2I5F27 xy, I5F27 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator +(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator -(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator *(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator *(Vector3I5F27 a, I5F27 b) => new Vector3I5F27(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator *(I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator /(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator /(Vector3I5F27 a, I5F27 b) => new Vector3I5F27(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator /(I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I5F27 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, X); }
        public readonly Vector2I5F27 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, Y); }
        public readonly Vector2I5F27 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, Z); }
        public readonly Vector2I5F27 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, X); }
        public readonly Vector2I5F27 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, Y); }
        public readonly Vector2I5F27 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, Z); }
        public readonly Vector2I5F27 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, X); }
        public readonly Vector2I5F27 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, Y); }
        public readonly Vector2I5F27 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, Z); }
        public readonly Vector3I5F27 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, X); }
        public readonly Vector3I5F27 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, Y); }
        public readonly Vector3I5F27 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, Z); }
        public readonly Vector3I5F27 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, X); }
        public readonly Vector3I5F27 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, Y); }
        public readonly Vector3I5F27 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, Z); }
        public readonly Vector3I5F27 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, X); }
        public readonly Vector3I5F27 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, Y); }
        public readonly Vector3I5F27 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, Z); }
        public readonly Vector3I5F27 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, X); }
        public readonly Vector3I5F27 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, Y); }
        public readonly Vector3I5F27 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, Z); }
        public readonly Vector3I5F27 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, X); }
        public readonly Vector3I5F27 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, Y); }
        public readonly Vector3I5F27 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, Z); }
        public readonly Vector3I5F27 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, X); }
        public readonly Vector3I5F27 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, Y); }
        public readonly Vector3I5F27 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, Z); }
        public readonly Vector3I5F27 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, X); }
        public readonly Vector3I5F27 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, Y); }
        public readonly Vector3I5F27 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, Z); }
        public readonly Vector3I5F27 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, X); }
        public readonly Vector3I5F27 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, Y); }
        public readonly Vector3I5F27 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, Z); }
        public readonly Vector3I5F27 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, X); }
        public readonly Vector3I5F27 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, Y); }
        public readonly Vector3I5F27 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, Z); }
        public readonly Vector4I5F27 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, X); }
        public readonly Vector4I5F27 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, Y); }
        public readonly Vector4I5F27 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, Z); }
        public readonly Vector4I5F27 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, X); }
        public readonly Vector4I5F27 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, Y); }
        public readonly Vector4I5F27 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, Z); }
        public readonly Vector4I5F27 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, X); }
        public readonly Vector4I5F27 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, Y); }
        public readonly Vector4I5F27 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, Z); }
        public readonly Vector4I5F27 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, X); }
        public readonly Vector4I5F27 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, Y); }
        public readonly Vector4I5F27 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, Z); }
        public readonly Vector4I5F27 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, X); }
        public readonly Vector4I5F27 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, Y); }
        public readonly Vector4I5F27 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, Z); }
        public readonly Vector4I5F27 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, X); }
        public readonly Vector4I5F27 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, Y); }
        public readonly Vector4I5F27 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, Z); }
        public readonly Vector4I5F27 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, X); }
        public readonly Vector4I5F27 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, Y); }
        public readonly Vector4I5F27 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, Z); }
        public readonly Vector4I5F27 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, X); }
        public readonly Vector4I5F27 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, Y); }
        public readonly Vector4I5F27 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, Z); }
        public readonly Vector4I5F27 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, X); }
        public readonly Vector4I5F27 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, Y); }
        public readonly Vector4I5F27 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, Z); }
        public readonly Vector4I5F27 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, X); }
        public readonly Vector4I5F27 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, Y); }
        public readonly Vector4I5F27 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, Z); }
        public readonly Vector4I5F27 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, X); }
        public readonly Vector4I5F27 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, Y); }
        public readonly Vector4I5F27 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, Z); }
        public readonly Vector4I5F27 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, X); }
        public readonly Vector4I5F27 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, Y); }
        public readonly Vector4I5F27 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, Z); }
        public readonly Vector4I5F27 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, X); }
        public readonly Vector4I5F27 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, Y); }
        public readonly Vector4I5F27 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, Z); }
        public readonly Vector4I5F27 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, X); }
        public readonly Vector4I5F27 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, Y); }
        public readonly Vector4I5F27 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, Z); }
        public readonly Vector4I5F27 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, X); }
        public readonly Vector4I5F27 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, Y); }
        public readonly Vector4I5F27 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, Z); }
        public readonly Vector4I5F27 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, X); }
        public readonly Vector4I5F27 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, Y); }
        public readonly Vector4I5F27 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, Z); }
        public readonly Vector4I5F27 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, X); }
        public readonly Vector4I5F27 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, Y); }
        public readonly Vector4I5F27 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, Z); }
        public readonly Vector4I5F27 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, X); }
        public readonly Vector4I5F27 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, Y); }
        public readonly Vector4I5F27 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, Z); }
        public readonly Vector4I5F27 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, X); }
        public readonly Vector4I5F27 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, Y); }
        public readonly Vector4I5F27 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, Z); }
        public readonly Vector4I5F27 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, X); }
        public readonly Vector4I5F27 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, Y); }
        public readonly Vector4I5F27 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, Z); }
        public readonly Vector4I5F27 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, X); }
        public readonly Vector4I5F27 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, Y); }
        public readonly Vector4I5F27 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, Z); }
        public readonly Vector4I5F27 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, X); }
        public readonly Vector4I5F27 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, Y); }
        public readonly Vector4I5F27 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, Z); }
        public readonly Vector4I5F27 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, X); }
        public readonly Vector4I5F27 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, Y); }
        public readonly Vector4I5F27 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, Z); }
        public readonly Vector4I5F27 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, X); }
        public readonly Vector4I5F27 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, Y); }
        public readonly Vector4I5F27 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, Z); }
        public readonly Vector4I5F27 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, X); }
        public readonly Vector4I5F27 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, Y); }
        public readonly Vector4I5F27 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, Z); }
        public readonly Vector4I5F27 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, X); }
        public readonly Vector4I5F27 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, Y); }
        public readonly Vector4I5F27 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, Z); }
        public readonly Vector4I5F27 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, X); }
        public readonly Vector4I5F27 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, Y); }
        public readonly Vector4I5F27 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I5F27 lhs, Vector3I5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I5F27 lhs, Vector3I5F27 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I5F27({X}, {Y}, {Z})";

        // IEquatable<Vector3I5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I5F27 other)
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
            return $"Vector3I5F27({x}, {y}, {z})";
        }
    }
}
