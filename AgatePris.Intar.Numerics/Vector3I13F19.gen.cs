using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I13F19 : IEquatable<Vector3I13F19>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I13F19 X;
        public I13F19 Y;
        public I13F19 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I13F19 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I13F19(I13F19 x, I13F19 y, I13F19 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I13F19(I13F19 x, Vector2I13F19 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I13F19(Vector3I13F19 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I13F19(Vector2I13F19 xy, I13F19 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 operator +(Vector3I13F19 a, Vector3I13F19 b) => new Vector3I13F19(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 operator -(Vector3I13F19 a, Vector3I13F19 b) => new Vector3I13F19(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 operator *(Vector3I13F19 a, Vector3I13F19 b) => new Vector3I13F19(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 operator *(Vector3I13F19 a, I13F19 b) => new Vector3I13F19(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 operator *(I13F19 a, Vector3I13F19 b) => new Vector3I13F19(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 operator /(Vector3I13F19 a, Vector3I13F19 b) => new Vector3I13F19(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 operator /(Vector3I13F19 a, I13F19 b) => new Vector3I13F19(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 operator /(I13F19 a, Vector3I13F19 b) => new Vector3I13F19(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I13F19 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(X, X); }
        public readonly Vector2I13F19 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(X, Y); }
        public readonly Vector2I13F19 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(X, Z); }
        public readonly Vector2I13F19 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Y, X); }
        public readonly Vector2I13F19 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Y, Y); }
        public readonly Vector2I13F19 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Y, Z); }
        public readonly Vector2I13F19 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Z, X); }
        public readonly Vector2I13F19 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Z, Y); }
        public readonly Vector2I13F19 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Z, Z); }
        public readonly Vector3I13F19 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, X, X); }
        public readonly Vector3I13F19 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, X, Y); }
        public readonly Vector3I13F19 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, X, Z); }
        public readonly Vector3I13F19 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Y, X); }
        public readonly Vector3I13F19 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Y, Y); }
        public readonly Vector3I13F19 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Y, Z); }
        public readonly Vector3I13F19 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Z, X); }
        public readonly Vector3I13F19 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Z, Y); }
        public readonly Vector3I13F19 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Z, Z); }
        public readonly Vector3I13F19 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, X, X); }
        public readonly Vector3I13F19 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, X, Y); }
        public readonly Vector3I13F19 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, X, Z); }
        public readonly Vector3I13F19 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Y, X); }
        public readonly Vector3I13F19 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Y, Y); }
        public readonly Vector3I13F19 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Y, Z); }
        public readonly Vector3I13F19 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Z, X); }
        public readonly Vector3I13F19 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Z, Y); }
        public readonly Vector3I13F19 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Z, Z); }
        public readonly Vector3I13F19 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, X, X); }
        public readonly Vector3I13F19 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, X, Y); }
        public readonly Vector3I13F19 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, X, Z); }
        public readonly Vector3I13F19 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Y, X); }
        public readonly Vector3I13F19 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Y, Y); }
        public readonly Vector3I13F19 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Y, Z); }
        public readonly Vector3I13F19 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Z, X); }
        public readonly Vector3I13F19 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Z, Y); }
        public readonly Vector3I13F19 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Z, Z); }
        public readonly Vector4I13F19 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, X, X); }
        public readonly Vector4I13F19 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, X, Y); }
        public readonly Vector4I13F19 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, X, Z); }
        public readonly Vector4I13F19 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Y, X); }
        public readonly Vector4I13F19 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Y, Y); }
        public readonly Vector4I13F19 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Y, Z); }
        public readonly Vector4I13F19 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Z, X); }
        public readonly Vector4I13F19 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Z, Y); }
        public readonly Vector4I13F19 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Z, Z); }
        public readonly Vector4I13F19 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, X, X); }
        public readonly Vector4I13F19 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, X, Y); }
        public readonly Vector4I13F19 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, X, Z); }
        public readonly Vector4I13F19 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Y, X); }
        public readonly Vector4I13F19 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Y, Y); }
        public readonly Vector4I13F19 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Y, Z); }
        public readonly Vector4I13F19 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Z, X); }
        public readonly Vector4I13F19 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Z, Y); }
        public readonly Vector4I13F19 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Z, Z); }
        public readonly Vector4I13F19 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, X, X); }
        public readonly Vector4I13F19 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, X, Y); }
        public readonly Vector4I13F19 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, X, Z); }
        public readonly Vector4I13F19 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Y, X); }
        public readonly Vector4I13F19 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Y, Y); }
        public readonly Vector4I13F19 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Y, Z); }
        public readonly Vector4I13F19 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Z, X); }
        public readonly Vector4I13F19 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Z, Y); }
        public readonly Vector4I13F19 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Z, Z); }
        public readonly Vector4I13F19 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, X, X); }
        public readonly Vector4I13F19 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, X, Y); }
        public readonly Vector4I13F19 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, X, Z); }
        public readonly Vector4I13F19 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Y, X); }
        public readonly Vector4I13F19 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Y, Y); }
        public readonly Vector4I13F19 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Y, Z); }
        public readonly Vector4I13F19 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Z, X); }
        public readonly Vector4I13F19 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Z, Y); }
        public readonly Vector4I13F19 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Z, Z); }
        public readonly Vector4I13F19 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, X, X); }
        public readonly Vector4I13F19 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, X, Y); }
        public readonly Vector4I13F19 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, X, Z); }
        public readonly Vector4I13F19 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Y, X); }
        public readonly Vector4I13F19 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Y, Y); }
        public readonly Vector4I13F19 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Y, Z); }
        public readonly Vector4I13F19 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Z, X); }
        public readonly Vector4I13F19 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Z, Y); }
        public readonly Vector4I13F19 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Z, Z); }
        public readonly Vector4I13F19 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, X, X); }
        public readonly Vector4I13F19 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, X, Y); }
        public readonly Vector4I13F19 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, X, Z); }
        public readonly Vector4I13F19 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Y, X); }
        public readonly Vector4I13F19 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Y, Y); }
        public readonly Vector4I13F19 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Y, Z); }
        public readonly Vector4I13F19 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Z, X); }
        public readonly Vector4I13F19 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Z, Y); }
        public readonly Vector4I13F19 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Z, Z); }
        public readonly Vector4I13F19 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, X, X); }
        public readonly Vector4I13F19 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, X, Y); }
        public readonly Vector4I13F19 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, X, Z); }
        public readonly Vector4I13F19 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Y, X); }
        public readonly Vector4I13F19 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Y, Y); }
        public readonly Vector4I13F19 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Y, Z); }
        public readonly Vector4I13F19 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Z, X); }
        public readonly Vector4I13F19 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Z, Y); }
        public readonly Vector4I13F19 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Z, Z); }
        public readonly Vector4I13F19 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, X, X); }
        public readonly Vector4I13F19 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, X, Y); }
        public readonly Vector4I13F19 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, X, Z); }
        public readonly Vector4I13F19 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Y, X); }
        public readonly Vector4I13F19 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Y, Y); }
        public readonly Vector4I13F19 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Y, Z); }
        public readonly Vector4I13F19 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Z, X); }
        public readonly Vector4I13F19 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Z, Y); }
        public readonly Vector4I13F19 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Z, Z); }
        public readonly Vector4I13F19 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, X, X); }
        public readonly Vector4I13F19 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, X, Y); }
        public readonly Vector4I13F19 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, X, Z); }
        public readonly Vector4I13F19 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Y, X); }
        public readonly Vector4I13F19 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Y, Y); }
        public readonly Vector4I13F19 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Y, Z); }
        public readonly Vector4I13F19 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Z, X); }
        public readonly Vector4I13F19 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Z, Y); }
        public readonly Vector4I13F19 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I13F19 lhs, Vector3I13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I13F19 lhs, Vector3I13F19 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I13F19({X}, {Y}, {Z})";

        // IEquatable<Vector3I13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I13F19 other)
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
            return $"Vector3I13F19({x}, {y}, {z})";
        }
    }
}
