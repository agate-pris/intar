using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U21F11 : IEquatable<Vector3U21F11>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U21F11 X;
        public U21F11 Y;
        public U21F11 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3U21F11 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(U21F11 x, U21F11 y, U21F11 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(U21F11 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(U21F11 x, Vector2U21F11 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(Vector3U21F11 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(Vector2U21F11 xy, U21F11 z) : this(xy.X, xy.Y, z) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator +(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator -(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator *(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator *(Vector3U21F11 a, U21F11 b) => new Vector3U21F11(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator *(U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator /(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator /(Vector3U21F11 a, U21F11 b) => new Vector3U21F11(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator /(U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U21F11 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, X); }
        public readonly Vector2U21F11 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, Y); }
        public readonly Vector2U21F11 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, Z); }
        public readonly Vector2U21F11 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, X); }
        public readonly Vector2U21F11 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, Y); }
        public readonly Vector2U21F11 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, Z); }
        public readonly Vector2U21F11 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, X); }
        public readonly Vector2U21F11 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, Y); }
        public readonly Vector2U21F11 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, Z); }
        public readonly Vector3U21F11 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, X); }
        public readonly Vector3U21F11 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, Y); }
        public readonly Vector3U21F11 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, Z); }
        public readonly Vector3U21F11 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, X); }
        public readonly Vector3U21F11 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, Y); }
        public readonly Vector3U21F11 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, Z); }
        public readonly Vector3U21F11 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, X); }
        public readonly Vector3U21F11 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, Y); }
        public readonly Vector3U21F11 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, Z); }
        public readonly Vector3U21F11 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, X); }
        public readonly Vector3U21F11 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, Y); }
        public readonly Vector3U21F11 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, Z); }
        public readonly Vector3U21F11 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, X); }
        public readonly Vector3U21F11 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, Y); }
        public readonly Vector3U21F11 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, Z); }
        public readonly Vector3U21F11 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, X); }
        public readonly Vector3U21F11 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, Y); }
        public readonly Vector3U21F11 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, Z); }
        public readonly Vector3U21F11 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, X); }
        public readonly Vector3U21F11 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, Y); }
        public readonly Vector3U21F11 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, Z); }
        public readonly Vector3U21F11 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, X); }
        public readonly Vector3U21F11 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, Y); }
        public readonly Vector3U21F11 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, Z); }
        public readonly Vector3U21F11 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, X); }
        public readonly Vector3U21F11 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, Y); }
        public readonly Vector3U21F11 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, Z); }
        public readonly Vector4U21F11 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, X); }
        public readonly Vector4U21F11 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, Y); }
        public readonly Vector4U21F11 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, Z); }
        public readonly Vector4U21F11 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, X); }
        public readonly Vector4U21F11 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, Y); }
        public readonly Vector4U21F11 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, Z); }
        public readonly Vector4U21F11 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, X); }
        public readonly Vector4U21F11 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, Y); }
        public readonly Vector4U21F11 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, Z); }
        public readonly Vector4U21F11 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, X); }
        public readonly Vector4U21F11 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, Y); }
        public readonly Vector4U21F11 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, Z); }
        public readonly Vector4U21F11 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, X); }
        public readonly Vector4U21F11 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, Y); }
        public readonly Vector4U21F11 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, Z); }
        public readonly Vector4U21F11 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, X); }
        public readonly Vector4U21F11 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, Y); }
        public readonly Vector4U21F11 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, Z); }
        public readonly Vector4U21F11 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, X); }
        public readonly Vector4U21F11 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, Y); }
        public readonly Vector4U21F11 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, Z); }
        public readonly Vector4U21F11 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, X); }
        public readonly Vector4U21F11 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, Y); }
        public readonly Vector4U21F11 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, Z); }
        public readonly Vector4U21F11 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, X); }
        public readonly Vector4U21F11 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, Y); }
        public readonly Vector4U21F11 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, Z); }
        public readonly Vector4U21F11 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, X); }
        public readonly Vector4U21F11 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, Y); }
        public readonly Vector4U21F11 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, Z); }
        public readonly Vector4U21F11 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, X); }
        public readonly Vector4U21F11 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, Y); }
        public readonly Vector4U21F11 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, Z); }
        public readonly Vector4U21F11 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, X); }
        public readonly Vector4U21F11 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, Y); }
        public readonly Vector4U21F11 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, Z); }
        public readonly Vector4U21F11 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, X); }
        public readonly Vector4U21F11 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, Y); }
        public readonly Vector4U21F11 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, Z); }
        public readonly Vector4U21F11 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, X); }
        public readonly Vector4U21F11 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, Y); }
        public readonly Vector4U21F11 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, Z); }
        public readonly Vector4U21F11 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, X); }
        public readonly Vector4U21F11 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, Y); }
        public readonly Vector4U21F11 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, Z); }
        public readonly Vector4U21F11 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, X); }
        public readonly Vector4U21F11 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, Y); }
        public readonly Vector4U21F11 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, Z); }
        public readonly Vector4U21F11 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, X); }
        public readonly Vector4U21F11 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, Y); }
        public readonly Vector4U21F11 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, Z); }
        public readonly Vector4U21F11 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, X); }
        public readonly Vector4U21F11 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, Y); }
        public readonly Vector4U21F11 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, Z); }
        public readonly Vector4U21F11 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, X); }
        public readonly Vector4U21F11 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, Y); }
        public readonly Vector4U21F11 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, Z); }
        public readonly Vector4U21F11 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, X); }
        public readonly Vector4U21F11 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, Y); }
        public readonly Vector4U21F11 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, Z); }
        public readonly Vector4U21F11 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, X); }
        public readonly Vector4U21F11 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, Y); }
        public readonly Vector4U21F11 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, Z); }
        public readonly Vector4U21F11 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, X); }
        public readonly Vector4U21F11 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, Y); }
        public readonly Vector4U21F11 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, Z); }
        public readonly Vector4U21F11 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, X); }
        public readonly Vector4U21F11 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, Y); }
        public readonly Vector4U21F11 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, Z); }
        public readonly Vector4U21F11 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, X); }
        public readonly Vector4U21F11 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, Y); }
        public readonly Vector4U21F11 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, Z); }
        public readonly Vector4U21F11 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, X); }
        public readonly Vector4U21F11 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, Y); }
        public readonly Vector4U21F11 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, Z); }
        public readonly Vector4U21F11 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, X); }
        public readonly Vector4U21F11 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, Y); }
        public readonly Vector4U21F11 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, Z); }
        public readonly Vector4U21F11 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, X); }
        public readonly Vector4U21F11 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, Y); }
        public readonly Vector4U21F11 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U21F11 lhs, Vector3U21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U21F11 lhs, Vector3U21F11 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U21F11({X}, {Y}, {Z})";

        // IEquatable<Vector3U21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U21F11 other)
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
            return $"Vector3U21F11({x}, {y}, {z})";
        }
    }
}
