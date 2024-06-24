using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U19F13 : IEquatable<Vector3U19F13>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U19F13 X;
        public U19F13 Y;
        public U19F13 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13(U19F13 x, U19F13 y, U19F13 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13(U19F13 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13(U19F13 x, Vector2U19F13 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13(Vector3U19F13 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13(Vector2U19F13 xy, U19F13 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U19F13 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U19F13(U19F13.Zero);
        }
        public static Vector3U19F13 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U19F13(U19F13.One);
        }
        public static Vector3U19F13 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U19F13(U19F13.One, U19F13.Zero, U19F13.Zero);
        }
        public static Vector3U19F13 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U19F13(U19F13.Zero, U19F13.One, U19F13.Zero);
        }
        public static Vector3U19F13 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U19F13(U19F13.Zero, U19F13.Zero, U19F13.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator +(Vector3U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator -(Vector3U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator *(Vector3U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator *(Vector3U19F13 a, U19F13 b) => new Vector3U19F13(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator *(U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator /(Vector3U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator /(Vector3U19F13 a, U19F13 b) => new Vector3U19F13(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator /(U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U19F13 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(X, X); }
        public readonly Vector2U19F13 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(X, Y); }
        public readonly Vector2U19F13 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(X, Z); }
        public readonly Vector2U19F13 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Y, X); }
        public readonly Vector2U19F13 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Y, Y); }
        public readonly Vector2U19F13 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Y, Z); }
        public readonly Vector2U19F13 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Z, X); }
        public readonly Vector2U19F13 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Z, Y); }
        public readonly Vector2U19F13 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Z, Z); }
        public readonly Vector3U19F13 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, X, X); }
        public readonly Vector3U19F13 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, X, Y); }
        public readonly Vector3U19F13 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, X, Z); }
        public readonly Vector3U19F13 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Y, X); }
        public readonly Vector3U19F13 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Y, Y); }
        public readonly Vector3U19F13 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Y, Z); }
        public readonly Vector3U19F13 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Z, X); }
        public readonly Vector3U19F13 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Z, Y); }
        public readonly Vector3U19F13 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Z, Z); }
        public readonly Vector3U19F13 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, X, X); }
        public readonly Vector3U19F13 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, X, Y); }
        public readonly Vector3U19F13 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, X, Z); }
        public readonly Vector3U19F13 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Y, X); }
        public readonly Vector3U19F13 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Y, Y); }
        public readonly Vector3U19F13 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Y, Z); }
        public readonly Vector3U19F13 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Z, X); }
        public readonly Vector3U19F13 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Z, Y); }
        public readonly Vector3U19F13 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Z, Z); }
        public readonly Vector3U19F13 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, X, X); }
        public readonly Vector3U19F13 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, X, Y); }
        public readonly Vector3U19F13 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, X, Z); }
        public readonly Vector3U19F13 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Y, X); }
        public readonly Vector3U19F13 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Y, Y); }
        public readonly Vector3U19F13 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Y, Z); }
        public readonly Vector3U19F13 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Z, X); }
        public readonly Vector3U19F13 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Z, Y); }
        public readonly Vector3U19F13 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Z, Z); }
        public readonly Vector4U19F13 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, X, X); }
        public readonly Vector4U19F13 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, X, Y); }
        public readonly Vector4U19F13 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, X, Z); }
        public readonly Vector4U19F13 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Y, X); }
        public readonly Vector4U19F13 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Y, Y); }
        public readonly Vector4U19F13 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Y, Z); }
        public readonly Vector4U19F13 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Z, X); }
        public readonly Vector4U19F13 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Z, Y); }
        public readonly Vector4U19F13 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Z, Z); }
        public readonly Vector4U19F13 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, X, X); }
        public readonly Vector4U19F13 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, X, Y); }
        public readonly Vector4U19F13 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, X, Z); }
        public readonly Vector4U19F13 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Y, X); }
        public readonly Vector4U19F13 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Y, Y); }
        public readonly Vector4U19F13 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Y, Z); }
        public readonly Vector4U19F13 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Z, X); }
        public readonly Vector4U19F13 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Z, Y); }
        public readonly Vector4U19F13 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Z, Z); }
        public readonly Vector4U19F13 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, X, X); }
        public readonly Vector4U19F13 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, X, Y); }
        public readonly Vector4U19F13 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, X, Z); }
        public readonly Vector4U19F13 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Y, X); }
        public readonly Vector4U19F13 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Y, Y); }
        public readonly Vector4U19F13 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Y, Z); }
        public readonly Vector4U19F13 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Z, X); }
        public readonly Vector4U19F13 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Z, Y); }
        public readonly Vector4U19F13 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Z, Z); }
        public readonly Vector4U19F13 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, X, X); }
        public readonly Vector4U19F13 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, X, Y); }
        public readonly Vector4U19F13 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, X, Z); }
        public readonly Vector4U19F13 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Y, X); }
        public readonly Vector4U19F13 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Y, Y); }
        public readonly Vector4U19F13 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Y, Z); }
        public readonly Vector4U19F13 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Z, X); }
        public readonly Vector4U19F13 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Z, Y); }
        public readonly Vector4U19F13 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Z, Z); }
        public readonly Vector4U19F13 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, X, X); }
        public readonly Vector4U19F13 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, X, Y); }
        public readonly Vector4U19F13 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, X, Z); }
        public readonly Vector4U19F13 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Y, X); }
        public readonly Vector4U19F13 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Y, Y); }
        public readonly Vector4U19F13 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Y, Z); }
        public readonly Vector4U19F13 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Z, X); }
        public readonly Vector4U19F13 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Z, Y); }
        public readonly Vector4U19F13 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Z, Z); }
        public readonly Vector4U19F13 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, X, X); }
        public readonly Vector4U19F13 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, X, Y); }
        public readonly Vector4U19F13 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, X, Z); }
        public readonly Vector4U19F13 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Y, X); }
        public readonly Vector4U19F13 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Y, Y); }
        public readonly Vector4U19F13 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Y, Z); }
        public readonly Vector4U19F13 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Z, X); }
        public readonly Vector4U19F13 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Z, Y); }
        public readonly Vector4U19F13 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Z, Z); }
        public readonly Vector4U19F13 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, X, X); }
        public readonly Vector4U19F13 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, X, Y); }
        public readonly Vector4U19F13 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, X, Z); }
        public readonly Vector4U19F13 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Y, X); }
        public readonly Vector4U19F13 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Y, Y); }
        public readonly Vector4U19F13 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Y, Z); }
        public readonly Vector4U19F13 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Z, X); }
        public readonly Vector4U19F13 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Z, Y); }
        public readonly Vector4U19F13 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Z, Z); }
        public readonly Vector4U19F13 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, X, X); }
        public readonly Vector4U19F13 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, X, Y); }
        public readonly Vector4U19F13 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, X, Z); }
        public readonly Vector4U19F13 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Y, X); }
        public readonly Vector4U19F13 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Y, Y); }
        public readonly Vector4U19F13 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Y, Z); }
        public readonly Vector4U19F13 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Z, X); }
        public readonly Vector4U19F13 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Z, Y); }
        public readonly Vector4U19F13 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Z, Z); }
        public readonly Vector4U19F13 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, X, X); }
        public readonly Vector4U19F13 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, X, Y); }
        public readonly Vector4U19F13 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, X, Z); }
        public readonly Vector4U19F13 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Y, X); }
        public readonly Vector4U19F13 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Y, Y); }
        public readonly Vector4U19F13 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Y, Z); }
        public readonly Vector4U19F13 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Z, X); }
        public readonly Vector4U19F13 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Z, Y); }
        public readonly Vector4U19F13 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U19F13 lhs, Vector3U19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U19F13 lhs, Vector3U19F13 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U19F13({X}, {Y}, {Z})";

        // IEquatable<Vector3U19F13>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U19F13 other)
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
            return $"Vector3U19F13({x}, {y}, {z})";
        }
    }
}
