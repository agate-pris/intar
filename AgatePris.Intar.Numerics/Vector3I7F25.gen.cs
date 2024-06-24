using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I7F25 : IEquatable<Vector3I7F25>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I7F25 X;
        public I7F25 Y;
        public I7F25 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I7F25 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25(I7F25 x, I7F25 y, I7F25 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25(I7F25 x, Vector2I7F25 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25(Vector3I7F25 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25(Vector2I7F25 xy, I7F25 z) : this(xy.X, xy.Y, z) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator +(Vector3I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator -(Vector3I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator *(Vector3I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator *(Vector3I7F25 a, I7F25 b) => new Vector3I7F25(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator *(I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator /(Vector3I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator /(Vector3I7F25 a, I7F25 b) => new Vector3I7F25(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator /(I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I7F25 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, X); }
        public readonly Vector2I7F25 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, Y); }
        public readonly Vector2I7F25 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, Z); }
        public readonly Vector2I7F25 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, X); }
        public readonly Vector2I7F25 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, Y); }
        public readonly Vector2I7F25 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, Z); }
        public readonly Vector2I7F25 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, X); }
        public readonly Vector2I7F25 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, Y); }
        public readonly Vector2I7F25 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, Z); }
        public readonly Vector3I7F25 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, X); }
        public readonly Vector3I7F25 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, Y); }
        public readonly Vector3I7F25 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, Z); }
        public readonly Vector3I7F25 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, X); }
        public readonly Vector3I7F25 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, Y); }
        public readonly Vector3I7F25 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, Z); }
        public readonly Vector3I7F25 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, X); }
        public readonly Vector3I7F25 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, Y); }
        public readonly Vector3I7F25 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, Z); }
        public readonly Vector3I7F25 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, X); }
        public readonly Vector3I7F25 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, Y); }
        public readonly Vector3I7F25 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, Z); }
        public readonly Vector3I7F25 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, X); }
        public readonly Vector3I7F25 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, Y); }
        public readonly Vector3I7F25 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, Z); }
        public readonly Vector3I7F25 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, X); }
        public readonly Vector3I7F25 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, Y); }
        public readonly Vector3I7F25 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, Z); }
        public readonly Vector3I7F25 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, X); }
        public readonly Vector3I7F25 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, Y); }
        public readonly Vector3I7F25 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, Z); }
        public readonly Vector3I7F25 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, X); }
        public readonly Vector3I7F25 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, Y); }
        public readonly Vector3I7F25 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, Z); }
        public readonly Vector3I7F25 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, X); }
        public readonly Vector3I7F25 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, Y); }
        public readonly Vector3I7F25 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, Z); }
        public readonly Vector4I7F25 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, X); }
        public readonly Vector4I7F25 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, Y); }
        public readonly Vector4I7F25 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, Z); }
        public readonly Vector4I7F25 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, X); }
        public readonly Vector4I7F25 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, Y); }
        public readonly Vector4I7F25 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, Z); }
        public readonly Vector4I7F25 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, X); }
        public readonly Vector4I7F25 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, Y); }
        public readonly Vector4I7F25 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, Z); }
        public readonly Vector4I7F25 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, X); }
        public readonly Vector4I7F25 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, Y); }
        public readonly Vector4I7F25 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, Z); }
        public readonly Vector4I7F25 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, X); }
        public readonly Vector4I7F25 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, Y); }
        public readonly Vector4I7F25 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, Z); }
        public readonly Vector4I7F25 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, X); }
        public readonly Vector4I7F25 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, Y); }
        public readonly Vector4I7F25 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, Z); }
        public readonly Vector4I7F25 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, X); }
        public readonly Vector4I7F25 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, Y); }
        public readonly Vector4I7F25 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, Z); }
        public readonly Vector4I7F25 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, X); }
        public readonly Vector4I7F25 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, Y); }
        public readonly Vector4I7F25 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, Z); }
        public readonly Vector4I7F25 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, X); }
        public readonly Vector4I7F25 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, Y); }
        public readonly Vector4I7F25 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, Z); }
        public readonly Vector4I7F25 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, X); }
        public readonly Vector4I7F25 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, Y); }
        public readonly Vector4I7F25 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, Z); }
        public readonly Vector4I7F25 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, X); }
        public readonly Vector4I7F25 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, Y); }
        public readonly Vector4I7F25 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, Z); }
        public readonly Vector4I7F25 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, X); }
        public readonly Vector4I7F25 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, Y); }
        public readonly Vector4I7F25 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, Z); }
        public readonly Vector4I7F25 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, X); }
        public readonly Vector4I7F25 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, Y); }
        public readonly Vector4I7F25 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, Z); }
        public readonly Vector4I7F25 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, X); }
        public readonly Vector4I7F25 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, Y); }
        public readonly Vector4I7F25 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, Z); }
        public readonly Vector4I7F25 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, X); }
        public readonly Vector4I7F25 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, Y); }
        public readonly Vector4I7F25 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, Z); }
        public readonly Vector4I7F25 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, X); }
        public readonly Vector4I7F25 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, Y); }
        public readonly Vector4I7F25 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, Z); }
        public readonly Vector4I7F25 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, X); }
        public readonly Vector4I7F25 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, Y); }
        public readonly Vector4I7F25 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, Z); }
        public readonly Vector4I7F25 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, X); }
        public readonly Vector4I7F25 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, Y); }
        public readonly Vector4I7F25 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, Z); }
        public readonly Vector4I7F25 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, X); }
        public readonly Vector4I7F25 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, Y); }
        public readonly Vector4I7F25 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, Z); }
        public readonly Vector4I7F25 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, X); }
        public readonly Vector4I7F25 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, Y); }
        public readonly Vector4I7F25 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, Z); }
        public readonly Vector4I7F25 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, X); }
        public readonly Vector4I7F25 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, Y); }
        public readonly Vector4I7F25 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, Z); }
        public readonly Vector4I7F25 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, X); }
        public readonly Vector4I7F25 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, Y); }
        public readonly Vector4I7F25 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, Z); }
        public readonly Vector4I7F25 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, X); }
        public readonly Vector4I7F25 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, Y); }
        public readonly Vector4I7F25 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, Z); }
        public readonly Vector4I7F25 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, X); }
        public readonly Vector4I7F25 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, Y); }
        public readonly Vector4I7F25 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, Z); }
        public readonly Vector4I7F25 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, X); }
        public readonly Vector4I7F25 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, Y); }
        public readonly Vector4I7F25 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, Z); }
        public readonly Vector4I7F25 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, X); }
        public readonly Vector4I7F25 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, Y); }
        public readonly Vector4I7F25 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, Z); }
        public readonly Vector4I7F25 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, X); }
        public readonly Vector4I7F25 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, Y); }
        public readonly Vector4I7F25 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I7F25 lhs, Vector3I7F25 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I7F25 lhs, Vector3I7F25 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I7F25({X}, {Y}, {Z})";

        // IEquatable<Vector3I7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I7F25 other)
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
            return $"Vector3I7F25({x}, {y}, {z})";
        }
    }
}
