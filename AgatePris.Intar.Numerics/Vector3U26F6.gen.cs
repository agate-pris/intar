using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U26F6 : IEquatable<Vector3U26F6>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U26F6 X;
        public U26F6 Y;
        public U26F6 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(U26F6 x, U26F6 y, U26F6 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(U26F6 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(U26F6 x, Vector2U26F6 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(Vector3U26F6 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(Vector2U26F6 xy, U26F6 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U26F6 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U26F6(U26F6.Zero);
        }
        public static Vector3U26F6 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U26F6(U26F6.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator +(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator -(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator *(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator *(Vector3U26F6 a, U26F6 b) => new Vector3U26F6(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator *(U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator /(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator /(Vector3U26F6 a, U26F6 b) => new Vector3U26F6(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator /(U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U26F6 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, X); }
        public readonly Vector2U26F6 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, Y); }
        public readonly Vector2U26F6 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, Z); }
        public readonly Vector2U26F6 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, X); }
        public readonly Vector2U26F6 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, Y); }
        public readonly Vector2U26F6 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, Z); }
        public readonly Vector2U26F6 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, X); }
        public readonly Vector2U26F6 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, Y); }
        public readonly Vector2U26F6 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, Z); }
        public readonly Vector3U26F6 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, X); }
        public readonly Vector3U26F6 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, Y); }
        public readonly Vector3U26F6 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, Z); }
        public readonly Vector3U26F6 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, X); }
        public readonly Vector3U26F6 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, Y); }
        public readonly Vector3U26F6 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, Z); }
        public readonly Vector3U26F6 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, X); }
        public readonly Vector3U26F6 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, Y); }
        public readonly Vector3U26F6 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, Z); }
        public readonly Vector3U26F6 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, X); }
        public readonly Vector3U26F6 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, Y); }
        public readonly Vector3U26F6 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, Z); }
        public readonly Vector3U26F6 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, X); }
        public readonly Vector3U26F6 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, Y); }
        public readonly Vector3U26F6 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, Z); }
        public readonly Vector3U26F6 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, X); }
        public readonly Vector3U26F6 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, Y); }
        public readonly Vector3U26F6 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, Z); }
        public readonly Vector3U26F6 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, X); }
        public readonly Vector3U26F6 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, Y); }
        public readonly Vector3U26F6 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, Z); }
        public readonly Vector3U26F6 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, X); }
        public readonly Vector3U26F6 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, Y); }
        public readonly Vector3U26F6 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, Z); }
        public readonly Vector3U26F6 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, X); }
        public readonly Vector3U26F6 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, Y); }
        public readonly Vector3U26F6 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, Z); }
        public readonly Vector4U26F6 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, X); }
        public readonly Vector4U26F6 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, Y); }
        public readonly Vector4U26F6 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, Z); }
        public readonly Vector4U26F6 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, X); }
        public readonly Vector4U26F6 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, Y); }
        public readonly Vector4U26F6 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, Z); }
        public readonly Vector4U26F6 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, X); }
        public readonly Vector4U26F6 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, Y); }
        public readonly Vector4U26F6 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, Z); }
        public readonly Vector4U26F6 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, X); }
        public readonly Vector4U26F6 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, Y); }
        public readonly Vector4U26F6 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, Z); }
        public readonly Vector4U26F6 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, X); }
        public readonly Vector4U26F6 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, Y); }
        public readonly Vector4U26F6 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, Z); }
        public readonly Vector4U26F6 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, X); }
        public readonly Vector4U26F6 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, Y); }
        public readonly Vector4U26F6 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, Z); }
        public readonly Vector4U26F6 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, X); }
        public readonly Vector4U26F6 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, Y); }
        public readonly Vector4U26F6 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, Z); }
        public readonly Vector4U26F6 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, X); }
        public readonly Vector4U26F6 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, Y); }
        public readonly Vector4U26F6 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, Z); }
        public readonly Vector4U26F6 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, X); }
        public readonly Vector4U26F6 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, Y); }
        public readonly Vector4U26F6 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, Z); }
        public readonly Vector4U26F6 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, X); }
        public readonly Vector4U26F6 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, Y); }
        public readonly Vector4U26F6 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, Z); }
        public readonly Vector4U26F6 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, X); }
        public readonly Vector4U26F6 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, Y); }
        public readonly Vector4U26F6 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, Z); }
        public readonly Vector4U26F6 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, X); }
        public readonly Vector4U26F6 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, Y); }
        public readonly Vector4U26F6 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, Z); }
        public readonly Vector4U26F6 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, X); }
        public readonly Vector4U26F6 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, Y); }
        public readonly Vector4U26F6 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, Z); }
        public readonly Vector4U26F6 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, X); }
        public readonly Vector4U26F6 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, Y); }
        public readonly Vector4U26F6 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, Z); }
        public readonly Vector4U26F6 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, X); }
        public readonly Vector4U26F6 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, Y); }
        public readonly Vector4U26F6 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, Z); }
        public readonly Vector4U26F6 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, X); }
        public readonly Vector4U26F6 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, Y); }
        public readonly Vector4U26F6 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, Z); }
        public readonly Vector4U26F6 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, X); }
        public readonly Vector4U26F6 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, Y); }
        public readonly Vector4U26F6 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, Z); }
        public readonly Vector4U26F6 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, X); }
        public readonly Vector4U26F6 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, Y); }
        public readonly Vector4U26F6 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, Z); }
        public readonly Vector4U26F6 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, X); }
        public readonly Vector4U26F6 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, Y); }
        public readonly Vector4U26F6 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, Z); }
        public readonly Vector4U26F6 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, X); }
        public readonly Vector4U26F6 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, Y); }
        public readonly Vector4U26F6 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, Z); }
        public readonly Vector4U26F6 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, X); }
        public readonly Vector4U26F6 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, Y); }
        public readonly Vector4U26F6 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, Z); }
        public readonly Vector4U26F6 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, X); }
        public readonly Vector4U26F6 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, Y); }
        public readonly Vector4U26F6 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, Z); }
        public readonly Vector4U26F6 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, X); }
        public readonly Vector4U26F6 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, Y); }
        public readonly Vector4U26F6 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, Z); }
        public readonly Vector4U26F6 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, X); }
        public readonly Vector4U26F6 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, Y); }
        public readonly Vector4U26F6 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, Z); }
        public readonly Vector4U26F6 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, X); }
        public readonly Vector4U26F6 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, Y); }
        public readonly Vector4U26F6 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, Z); }
        public readonly Vector4U26F6 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, X); }
        public readonly Vector4U26F6 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, Y); }
        public readonly Vector4U26F6 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, Z); }
        public readonly Vector4U26F6 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, X); }
        public readonly Vector4U26F6 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, Y); }
        public readonly Vector4U26F6 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U26F6 lhs, Vector3U26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U26F6 lhs, Vector3U26F6 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U26F6({X}, {Y}, {Z})";

        // IEquatable<Vector3U26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U26F6 other)
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
            return $"Vector3U26F6({x}, {y}, {z})";
        }
    }
}
