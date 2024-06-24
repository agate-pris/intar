using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U17F15 : IEquatable<Vector3U17F15>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U17F15 X;
        public U17F15 Y;
        public U17F15 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(U17F15 x, U17F15 y, U17F15 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(U17F15 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(U17F15 x, Vector2U17F15 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(Vector3U17F15 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(Vector2U17F15 xy, U17F15 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U17F15(U17F15.Zero);
        }
        public static Vector3U17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U17F15(U17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator +(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator -(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator *(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator *(Vector3U17F15 a, U17F15 b) => new Vector3U17F15(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator *(U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator /(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator /(Vector3U17F15 a, U17F15 b) => new Vector3U17F15(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator /(U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U17F15 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, X); }
        public readonly Vector2U17F15 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, Y); }
        public readonly Vector2U17F15 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, Z); }
        public readonly Vector2U17F15 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, X); }
        public readonly Vector2U17F15 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, Y); }
        public readonly Vector2U17F15 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, Z); }
        public readonly Vector2U17F15 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Z, X); }
        public readonly Vector2U17F15 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Z, Y); }
        public readonly Vector2U17F15 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Z, Z); }
        public readonly Vector3U17F15 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, X); }
        public readonly Vector3U17F15 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, Y); }
        public readonly Vector3U17F15 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, Z); }
        public readonly Vector3U17F15 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, X); }
        public readonly Vector3U17F15 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, Y); }
        public readonly Vector3U17F15 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, Z); }
        public readonly Vector3U17F15 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Z, X); }
        public readonly Vector3U17F15 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Z, Y); }
        public readonly Vector3U17F15 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Z, Z); }
        public readonly Vector3U17F15 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, X); }
        public readonly Vector3U17F15 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, Y); }
        public readonly Vector3U17F15 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, Z); }
        public readonly Vector3U17F15 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, X); }
        public readonly Vector3U17F15 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, Y); }
        public readonly Vector3U17F15 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, Z); }
        public readonly Vector3U17F15 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Z, X); }
        public readonly Vector3U17F15 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Z, Y); }
        public readonly Vector3U17F15 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Z, Z); }
        public readonly Vector3U17F15 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, X, X); }
        public readonly Vector3U17F15 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, X, Y); }
        public readonly Vector3U17F15 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, X, Z); }
        public readonly Vector3U17F15 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Y, X); }
        public readonly Vector3U17F15 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Y, Y); }
        public readonly Vector3U17F15 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Y, Z); }
        public readonly Vector3U17F15 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Z, X); }
        public readonly Vector3U17F15 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Z, Y); }
        public readonly Vector3U17F15 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Z, Z); }
        public readonly Vector4U17F15 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, X); }
        public readonly Vector4U17F15 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, Y); }
        public readonly Vector4U17F15 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, Z); }
        public readonly Vector4U17F15 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, X); }
        public readonly Vector4U17F15 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, Y); }
        public readonly Vector4U17F15 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, Z); }
        public readonly Vector4U17F15 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Z, X); }
        public readonly Vector4U17F15 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Z, Y); }
        public readonly Vector4U17F15 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Z, Z); }
        public readonly Vector4U17F15 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, X); }
        public readonly Vector4U17F15 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, Y); }
        public readonly Vector4U17F15 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, Z); }
        public readonly Vector4U17F15 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, X); }
        public readonly Vector4U17F15 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, Y); }
        public readonly Vector4U17F15 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, Z); }
        public readonly Vector4U17F15 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Z, X); }
        public readonly Vector4U17F15 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Z, Y); }
        public readonly Vector4U17F15 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Z, Z); }
        public readonly Vector4U17F15 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, X, X); }
        public readonly Vector4U17F15 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, X, Y); }
        public readonly Vector4U17F15 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, X, Z); }
        public readonly Vector4U17F15 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Y, X); }
        public readonly Vector4U17F15 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Y, Y); }
        public readonly Vector4U17F15 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Y, Z); }
        public readonly Vector4U17F15 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Z, X); }
        public readonly Vector4U17F15 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Z, Y); }
        public readonly Vector4U17F15 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Z, Z); }
        public readonly Vector4U17F15 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, X); }
        public readonly Vector4U17F15 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, Y); }
        public readonly Vector4U17F15 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, Z); }
        public readonly Vector4U17F15 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, X); }
        public readonly Vector4U17F15 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, Y); }
        public readonly Vector4U17F15 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, Z); }
        public readonly Vector4U17F15 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Z, X); }
        public readonly Vector4U17F15 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Z, Y); }
        public readonly Vector4U17F15 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Z, Z); }
        public readonly Vector4U17F15 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, X); }
        public readonly Vector4U17F15 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, Y); }
        public readonly Vector4U17F15 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, Z); }
        public readonly Vector4U17F15 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, X); }
        public readonly Vector4U17F15 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, Y); }
        public readonly Vector4U17F15 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, Z); }
        public readonly Vector4U17F15 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Z, X); }
        public readonly Vector4U17F15 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Z, Y); }
        public readonly Vector4U17F15 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Z, Z); }
        public readonly Vector4U17F15 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, X, X); }
        public readonly Vector4U17F15 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, X, Y); }
        public readonly Vector4U17F15 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, X, Z); }
        public readonly Vector4U17F15 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Y, X); }
        public readonly Vector4U17F15 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Y, Y); }
        public readonly Vector4U17F15 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Y, Z); }
        public readonly Vector4U17F15 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Z, X); }
        public readonly Vector4U17F15 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Z, Y); }
        public readonly Vector4U17F15 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Z, Z); }
        public readonly Vector4U17F15 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, X, X); }
        public readonly Vector4U17F15 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, X, Y); }
        public readonly Vector4U17F15 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, X, Z); }
        public readonly Vector4U17F15 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Y, X); }
        public readonly Vector4U17F15 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Y, Y); }
        public readonly Vector4U17F15 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Y, Z); }
        public readonly Vector4U17F15 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Z, X); }
        public readonly Vector4U17F15 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Z, Y); }
        public readonly Vector4U17F15 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Z, Z); }
        public readonly Vector4U17F15 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, X, X); }
        public readonly Vector4U17F15 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, X, Y); }
        public readonly Vector4U17F15 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, X, Z); }
        public readonly Vector4U17F15 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Y, X); }
        public readonly Vector4U17F15 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Y, Y); }
        public readonly Vector4U17F15 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Y, Z); }
        public readonly Vector4U17F15 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Z, X); }
        public readonly Vector4U17F15 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Z, Y); }
        public readonly Vector4U17F15 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Z, Z); }
        public readonly Vector4U17F15 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, X, X); }
        public readonly Vector4U17F15 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, X, Y); }
        public readonly Vector4U17F15 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, X, Z); }
        public readonly Vector4U17F15 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Y, X); }
        public readonly Vector4U17F15 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Y, Y); }
        public readonly Vector4U17F15 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Y, Z); }
        public readonly Vector4U17F15 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Z, X); }
        public readonly Vector4U17F15 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Z, Y); }
        public readonly Vector4U17F15 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U17F15 lhs, Vector3U17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U17F15 lhs, Vector3U17F15 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U17F15({X}, {Y}, {Z})";

        // IEquatable<Vector3U17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U17F15 other)
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
            return $"Vector3U17F15({x}, {y}, {z})";
        }
    }
}
