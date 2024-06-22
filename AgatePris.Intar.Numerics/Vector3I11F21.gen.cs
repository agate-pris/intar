using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I11F21 : IEquatable<Vector3I11F21>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I11F21 X;
        public I11F21 Y;
        public I11F21 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I11F21 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I11F21(I11F21 x, I11F21 y, I11F21 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I11F21(I11F21 x, Vector2I11F21 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I11F21(Vector3I11F21 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I11F21(Vector2I11F21 xy, I11F21 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 operator +(Vector3I11F21 a, Vector3I11F21 b) => new Vector3I11F21(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 operator -(Vector3I11F21 a, Vector3I11F21 b) => new Vector3I11F21(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 operator *(Vector3I11F21 a, Vector3I11F21 b) => new Vector3I11F21(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 operator *(Vector3I11F21 a, I11F21 b) => new Vector3I11F21(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 operator *(I11F21 a, Vector3I11F21 b) => new Vector3I11F21(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 operator /(Vector3I11F21 a, Vector3I11F21 b) => new Vector3I11F21(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 operator /(Vector3I11F21 a, I11F21 b) => new Vector3I11F21(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 operator /(I11F21 a, Vector3I11F21 b) => new Vector3I11F21(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I11F21 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, X); }
        public readonly Vector2I11F21 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, Y); }
        public readonly Vector2I11F21 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, Z); }
        public readonly Vector2I11F21 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, X); }
        public readonly Vector2I11F21 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, Y); }
        public readonly Vector2I11F21 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, Z); }
        public readonly Vector2I11F21 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Z, X); }
        public readonly Vector2I11F21 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Z, Y); }
        public readonly Vector2I11F21 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Z, Z); }
        public readonly Vector3I11F21 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, X); }
        public readonly Vector3I11F21 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, Y); }
        public readonly Vector3I11F21 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, Z); }
        public readonly Vector3I11F21 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, X); }
        public readonly Vector3I11F21 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, Y); }
        public readonly Vector3I11F21 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, Z); }
        public readonly Vector3I11F21 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Z, X); }
        public readonly Vector3I11F21 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Z, Y); }
        public readonly Vector3I11F21 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Z, Z); }
        public readonly Vector3I11F21 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, X); }
        public readonly Vector3I11F21 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, Y); }
        public readonly Vector3I11F21 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, Z); }
        public readonly Vector3I11F21 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, X); }
        public readonly Vector3I11F21 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, Y); }
        public readonly Vector3I11F21 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, Z); }
        public readonly Vector3I11F21 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Z, X); }
        public readonly Vector3I11F21 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Z, Y); }
        public readonly Vector3I11F21 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Z, Z); }
        public readonly Vector3I11F21 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, X, X); }
        public readonly Vector3I11F21 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, X, Y); }
        public readonly Vector3I11F21 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, X, Z); }
        public readonly Vector3I11F21 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Y, X); }
        public readonly Vector3I11F21 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Y, Y); }
        public readonly Vector3I11F21 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Y, Z); }
        public readonly Vector3I11F21 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Z, X); }
        public readonly Vector3I11F21 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Z, Y); }
        public readonly Vector3I11F21 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Z, Z); }
        public readonly Vector4I11F21 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, X); }
        public readonly Vector4I11F21 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, Y); }
        public readonly Vector4I11F21 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, Z); }
        public readonly Vector4I11F21 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, X); }
        public readonly Vector4I11F21 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, Y); }
        public readonly Vector4I11F21 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, Z); }
        public readonly Vector4I11F21 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Z, X); }
        public readonly Vector4I11F21 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Z, Y); }
        public readonly Vector4I11F21 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Z, Z); }
        public readonly Vector4I11F21 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, X); }
        public readonly Vector4I11F21 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, Y); }
        public readonly Vector4I11F21 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, Z); }
        public readonly Vector4I11F21 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, X); }
        public readonly Vector4I11F21 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, Y); }
        public readonly Vector4I11F21 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, Z); }
        public readonly Vector4I11F21 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Z, X); }
        public readonly Vector4I11F21 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Z, Y); }
        public readonly Vector4I11F21 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Z, Z); }
        public readonly Vector4I11F21 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, X, X); }
        public readonly Vector4I11F21 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, X, Y); }
        public readonly Vector4I11F21 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, X, Z); }
        public readonly Vector4I11F21 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Y, X); }
        public readonly Vector4I11F21 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Y, Y); }
        public readonly Vector4I11F21 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Y, Z); }
        public readonly Vector4I11F21 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Z, X); }
        public readonly Vector4I11F21 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Z, Y); }
        public readonly Vector4I11F21 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Z, Z); }
        public readonly Vector4I11F21 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, X); }
        public readonly Vector4I11F21 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, Y); }
        public readonly Vector4I11F21 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, Z); }
        public readonly Vector4I11F21 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, X); }
        public readonly Vector4I11F21 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, Y); }
        public readonly Vector4I11F21 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, Z); }
        public readonly Vector4I11F21 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Z, X); }
        public readonly Vector4I11F21 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Z, Y); }
        public readonly Vector4I11F21 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Z, Z); }
        public readonly Vector4I11F21 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, X); }
        public readonly Vector4I11F21 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, Y); }
        public readonly Vector4I11F21 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, Z); }
        public readonly Vector4I11F21 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, X); }
        public readonly Vector4I11F21 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, Y); }
        public readonly Vector4I11F21 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, Z); }
        public readonly Vector4I11F21 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Z, X); }
        public readonly Vector4I11F21 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Z, Y); }
        public readonly Vector4I11F21 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Z, Z); }
        public readonly Vector4I11F21 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, X, X); }
        public readonly Vector4I11F21 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, X, Y); }
        public readonly Vector4I11F21 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, X, Z); }
        public readonly Vector4I11F21 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Y, X); }
        public readonly Vector4I11F21 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Y, Y); }
        public readonly Vector4I11F21 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Y, Z); }
        public readonly Vector4I11F21 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Z, X); }
        public readonly Vector4I11F21 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Z, Y); }
        public readonly Vector4I11F21 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Z, Z); }
        public readonly Vector4I11F21 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, X, X); }
        public readonly Vector4I11F21 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, X, Y); }
        public readonly Vector4I11F21 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, X, Z); }
        public readonly Vector4I11F21 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Y, X); }
        public readonly Vector4I11F21 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Y, Y); }
        public readonly Vector4I11F21 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Y, Z); }
        public readonly Vector4I11F21 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Z, X); }
        public readonly Vector4I11F21 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Z, Y); }
        public readonly Vector4I11F21 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Z, Z); }
        public readonly Vector4I11F21 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, X, X); }
        public readonly Vector4I11F21 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, X, Y); }
        public readonly Vector4I11F21 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, X, Z); }
        public readonly Vector4I11F21 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Y, X); }
        public readonly Vector4I11F21 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Y, Y); }
        public readonly Vector4I11F21 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Y, Z); }
        public readonly Vector4I11F21 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Z, X); }
        public readonly Vector4I11F21 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Z, Y); }
        public readonly Vector4I11F21 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Z, Z); }
        public readonly Vector4I11F21 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, X, X); }
        public readonly Vector4I11F21 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, X, Y); }
        public readonly Vector4I11F21 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, X, Z); }
        public readonly Vector4I11F21 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Y, X); }
        public readonly Vector4I11F21 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Y, Y); }
        public readonly Vector4I11F21 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Y, Z); }
        public readonly Vector4I11F21 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Z, X); }
        public readonly Vector4I11F21 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Z, Y); }
        public readonly Vector4I11F21 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I11F21 lhs, Vector3I11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I11F21 lhs, Vector3I11F21 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I11F21({X}, {Y}, {Z})";

        // IEquatable<Vector3I11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I11F21 other)
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
            return $"Vector3I11F21({x}, {y}, {z})";
        }
    }
}
