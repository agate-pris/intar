using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I28F4 : IEquatable<Vector3I28F4>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I28F4 X;
        public I28F4 Y;
        public I28F4 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I28F4 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I28F4(I28F4 x, I28F4 y, I28F4 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I28F4(I28F4 x, Vector2I28F4 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I28F4(Vector3I28F4 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I28F4(Vector2I28F4 xy, I28F4 z) : this(xy.X, xy.Y, z) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator +(Vector3I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator -(Vector3I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator *(Vector3I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator *(Vector3I28F4 a, I28F4 b) => new Vector3I28F4(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator *(I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator /(Vector3I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator /(Vector3I28F4 a, I28F4 b) => new Vector3I28F4(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator /(I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I28F4 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, X); }
        public readonly Vector2I28F4 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, Y); }
        public readonly Vector2I28F4 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, Z); }
        public readonly Vector2I28F4 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, X); }
        public readonly Vector2I28F4 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, Y); }
        public readonly Vector2I28F4 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, Z); }
        public readonly Vector2I28F4 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Z, X); }
        public readonly Vector2I28F4 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Z, Y); }
        public readonly Vector2I28F4 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Z, Z); }
        public readonly Vector3I28F4 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, X); }
        public readonly Vector3I28F4 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, Y); }
        public readonly Vector3I28F4 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, Z); }
        public readonly Vector3I28F4 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, X); }
        public readonly Vector3I28F4 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, Y); }
        public readonly Vector3I28F4 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, Z); }
        public readonly Vector3I28F4 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Z, X); }
        public readonly Vector3I28F4 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Z, Y); }
        public readonly Vector3I28F4 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Z, Z); }
        public readonly Vector3I28F4 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, X); }
        public readonly Vector3I28F4 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, Y); }
        public readonly Vector3I28F4 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, Z); }
        public readonly Vector3I28F4 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, X); }
        public readonly Vector3I28F4 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, Y); }
        public readonly Vector3I28F4 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, Z); }
        public readonly Vector3I28F4 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Z, X); }
        public readonly Vector3I28F4 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Z, Y); }
        public readonly Vector3I28F4 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Z, Z); }
        public readonly Vector3I28F4 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, X, X); }
        public readonly Vector3I28F4 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, X, Y); }
        public readonly Vector3I28F4 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, X, Z); }
        public readonly Vector3I28F4 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Y, X); }
        public readonly Vector3I28F4 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Y, Y); }
        public readonly Vector3I28F4 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Y, Z); }
        public readonly Vector3I28F4 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Z, X); }
        public readonly Vector3I28F4 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Z, Y); }
        public readonly Vector3I28F4 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Z, Z); }
        public readonly Vector4I28F4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, X); }
        public readonly Vector4I28F4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, Y); }
        public readonly Vector4I28F4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, Z); }
        public readonly Vector4I28F4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, X); }
        public readonly Vector4I28F4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, Y); }
        public readonly Vector4I28F4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, Z); }
        public readonly Vector4I28F4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Z, X); }
        public readonly Vector4I28F4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Z, Y); }
        public readonly Vector4I28F4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Z, Z); }
        public readonly Vector4I28F4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, X); }
        public readonly Vector4I28F4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, Y); }
        public readonly Vector4I28F4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, Z); }
        public readonly Vector4I28F4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, X); }
        public readonly Vector4I28F4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, Y); }
        public readonly Vector4I28F4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, Z); }
        public readonly Vector4I28F4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Z, X); }
        public readonly Vector4I28F4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Z, Y); }
        public readonly Vector4I28F4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Z, Z); }
        public readonly Vector4I28F4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, X, X); }
        public readonly Vector4I28F4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, X, Y); }
        public readonly Vector4I28F4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, X, Z); }
        public readonly Vector4I28F4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Y, X); }
        public readonly Vector4I28F4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Y, Y); }
        public readonly Vector4I28F4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Y, Z); }
        public readonly Vector4I28F4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Z, X); }
        public readonly Vector4I28F4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Z, Y); }
        public readonly Vector4I28F4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Z, Z); }
        public readonly Vector4I28F4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, X); }
        public readonly Vector4I28F4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, Y); }
        public readonly Vector4I28F4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, Z); }
        public readonly Vector4I28F4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, X); }
        public readonly Vector4I28F4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, Y); }
        public readonly Vector4I28F4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, Z); }
        public readonly Vector4I28F4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Z, X); }
        public readonly Vector4I28F4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Z, Y); }
        public readonly Vector4I28F4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Z, Z); }
        public readonly Vector4I28F4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, X); }
        public readonly Vector4I28F4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, Y); }
        public readonly Vector4I28F4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, Z); }
        public readonly Vector4I28F4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, X); }
        public readonly Vector4I28F4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, Y); }
        public readonly Vector4I28F4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, Z); }
        public readonly Vector4I28F4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Z, X); }
        public readonly Vector4I28F4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Z, Y); }
        public readonly Vector4I28F4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Z, Z); }
        public readonly Vector4I28F4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, X, X); }
        public readonly Vector4I28F4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, X, Y); }
        public readonly Vector4I28F4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, X, Z); }
        public readonly Vector4I28F4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Y, X); }
        public readonly Vector4I28F4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Y, Y); }
        public readonly Vector4I28F4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Y, Z); }
        public readonly Vector4I28F4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Z, X); }
        public readonly Vector4I28F4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Z, Y); }
        public readonly Vector4I28F4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Z, Z); }
        public readonly Vector4I28F4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, X, X); }
        public readonly Vector4I28F4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, X, Y); }
        public readonly Vector4I28F4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, X, Z); }
        public readonly Vector4I28F4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Y, X); }
        public readonly Vector4I28F4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Y, Y); }
        public readonly Vector4I28F4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Y, Z); }
        public readonly Vector4I28F4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Z, X); }
        public readonly Vector4I28F4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Z, Y); }
        public readonly Vector4I28F4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Z, Z); }
        public readonly Vector4I28F4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, X, X); }
        public readonly Vector4I28F4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, X, Y); }
        public readonly Vector4I28F4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, X, Z); }
        public readonly Vector4I28F4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Y, X); }
        public readonly Vector4I28F4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Y, Y); }
        public readonly Vector4I28F4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Y, Z); }
        public readonly Vector4I28F4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Z, X); }
        public readonly Vector4I28F4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Z, Y); }
        public readonly Vector4I28F4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Z, Z); }
        public readonly Vector4I28F4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, X, X); }
        public readonly Vector4I28F4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, X, Y); }
        public readonly Vector4I28F4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, X, Z); }
        public readonly Vector4I28F4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Y, X); }
        public readonly Vector4I28F4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Y, Y); }
        public readonly Vector4I28F4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Y, Z); }
        public readonly Vector4I28F4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Z, X); }
        public readonly Vector4I28F4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Z, Y); }
        public readonly Vector4I28F4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I28F4 lhs, Vector3I28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I28F4 lhs, Vector3I28F4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I28F4({X}, {Y}, {Z})";

        // IEquatable<Vector3I28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I28F4 other)
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
            return $"Vector3I28F4({x}, {y}, {z})";
        }
    }
}
