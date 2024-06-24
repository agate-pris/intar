using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I4F28 : IEquatable<Vector3I4F28>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I4F28 X;
        public I4F28 Y;
        public I4F28 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I4F28 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28(I4F28 x, I4F28 y, I4F28 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28(I4F28 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28(I4F28 x, Vector2I4F28 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28(Vector3I4F28 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28(Vector2I4F28 xy, I4F28 z) : this(xy.X, xy.Y, z) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator +(Vector3I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator -(Vector3I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator *(Vector3I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator *(Vector3I4F28 a, I4F28 b) => new Vector3I4F28(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator *(I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator /(Vector3I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator /(Vector3I4F28 a, I4F28 b) => new Vector3I4F28(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator /(I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I4F28 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, X); }
        public readonly Vector2I4F28 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, Y); }
        public readonly Vector2I4F28 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, Z); }
        public readonly Vector2I4F28 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, X); }
        public readonly Vector2I4F28 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, Y); }
        public readonly Vector2I4F28 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, Z); }
        public readonly Vector2I4F28 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Z, X); }
        public readonly Vector2I4F28 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Z, Y); }
        public readonly Vector2I4F28 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Z, Z); }
        public readonly Vector3I4F28 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, X); }
        public readonly Vector3I4F28 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, Y); }
        public readonly Vector3I4F28 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, Z); }
        public readonly Vector3I4F28 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, X); }
        public readonly Vector3I4F28 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, Y); }
        public readonly Vector3I4F28 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, Z); }
        public readonly Vector3I4F28 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Z, X); }
        public readonly Vector3I4F28 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Z, Y); }
        public readonly Vector3I4F28 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Z, Z); }
        public readonly Vector3I4F28 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, X); }
        public readonly Vector3I4F28 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, Y); }
        public readonly Vector3I4F28 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, Z); }
        public readonly Vector3I4F28 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, X); }
        public readonly Vector3I4F28 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, Y); }
        public readonly Vector3I4F28 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, Z); }
        public readonly Vector3I4F28 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Z, X); }
        public readonly Vector3I4F28 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Z, Y); }
        public readonly Vector3I4F28 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Z, Z); }
        public readonly Vector3I4F28 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, X, X); }
        public readonly Vector3I4F28 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, X, Y); }
        public readonly Vector3I4F28 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, X, Z); }
        public readonly Vector3I4F28 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Y, X); }
        public readonly Vector3I4F28 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Y, Y); }
        public readonly Vector3I4F28 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Y, Z); }
        public readonly Vector3I4F28 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Z, X); }
        public readonly Vector3I4F28 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Z, Y); }
        public readonly Vector3I4F28 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Z, Z); }
        public readonly Vector4I4F28 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, X); }
        public readonly Vector4I4F28 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, Y); }
        public readonly Vector4I4F28 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, Z); }
        public readonly Vector4I4F28 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, X); }
        public readonly Vector4I4F28 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, Y); }
        public readonly Vector4I4F28 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, Z); }
        public readonly Vector4I4F28 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Z, X); }
        public readonly Vector4I4F28 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Z, Y); }
        public readonly Vector4I4F28 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Z, Z); }
        public readonly Vector4I4F28 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, X); }
        public readonly Vector4I4F28 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, Y); }
        public readonly Vector4I4F28 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, Z); }
        public readonly Vector4I4F28 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, X); }
        public readonly Vector4I4F28 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, Y); }
        public readonly Vector4I4F28 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, Z); }
        public readonly Vector4I4F28 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Z, X); }
        public readonly Vector4I4F28 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Z, Y); }
        public readonly Vector4I4F28 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Z, Z); }
        public readonly Vector4I4F28 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, X, X); }
        public readonly Vector4I4F28 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, X, Y); }
        public readonly Vector4I4F28 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, X, Z); }
        public readonly Vector4I4F28 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Y, X); }
        public readonly Vector4I4F28 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Y, Y); }
        public readonly Vector4I4F28 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Y, Z); }
        public readonly Vector4I4F28 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Z, X); }
        public readonly Vector4I4F28 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Z, Y); }
        public readonly Vector4I4F28 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Z, Z); }
        public readonly Vector4I4F28 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, X); }
        public readonly Vector4I4F28 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, Y); }
        public readonly Vector4I4F28 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, Z); }
        public readonly Vector4I4F28 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, X); }
        public readonly Vector4I4F28 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, Y); }
        public readonly Vector4I4F28 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, Z); }
        public readonly Vector4I4F28 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Z, X); }
        public readonly Vector4I4F28 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Z, Y); }
        public readonly Vector4I4F28 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Z, Z); }
        public readonly Vector4I4F28 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, X); }
        public readonly Vector4I4F28 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, Y); }
        public readonly Vector4I4F28 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, Z); }
        public readonly Vector4I4F28 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, X); }
        public readonly Vector4I4F28 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, Y); }
        public readonly Vector4I4F28 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, Z); }
        public readonly Vector4I4F28 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Z, X); }
        public readonly Vector4I4F28 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Z, Y); }
        public readonly Vector4I4F28 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Z, Z); }
        public readonly Vector4I4F28 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, X, X); }
        public readonly Vector4I4F28 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, X, Y); }
        public readonly Vector4I4F28 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, X, Z); }
        public readonly Vector4I4F28 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Y, X); }
        public readonly Vector4I4F28 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Y, Y); }
        public readonly Vector4I4F28 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Y, Z); }
        public readonly Vector4I4F28 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Z, X); }
        public readonly Vector4I4F28 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Z, Y); }
        public readonly Vector4I4F28 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Z, Z); }
        public readonly Vector4I4F28 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, X, X); }
        public readonly Vector4I4F28 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, X, Y); }
        public readonly Vector4I4F28 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, X, Z); }
        public readonly Vector4I4F28 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Y, X); }
        public readonly Vector4I4F28 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Y, Y); }
        public readonly Vector4I4F28 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Y, Z); }
        public readonly Vector4I4F28 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Z, X); }
        public readonly Vector4I4F28 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Z, Y); }
        public readonly Vector4I4F28 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Z, Z); }
        public readonly Vector4I4F28 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, X, X); }
        public readonly Vector4I4F28 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, X, Y); }
        public readonly Vector4I4F28 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, X, Z); }
        public readonly Vector4I4F28 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Y, X); }
        public readonly Vector4I4F28 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Y, Y); }
        public readonly Vector4I4F28 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Y, Z); }
        public readonly Vector4I4F28 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Z, X); }
        public readonly Vector4I4F28 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Z, Y); }
        public readonly Vector4I4F28 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Z, Z); }
        public readonly Vector4I4F28 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, X, X); }
        public readonly Vector4I4F28 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, X, Y); }
        public readonly Vector4I4F28 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, X, Z); }
        public readonly Vector4I4F28 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Y, X); }
        public readonly Vector4I4F28 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Y, Y); }
        public readonly Vector4I4F28 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Y, Z); }
        public readonly Vector4I4F28 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Z, X); }
        public readonly Vector4I4F28 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Z, Y); }
        public readonly Vector4I4F28 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I4F28 lhs, Vector3I4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I4F28 lhs, Vector3I4F28 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I4F28({X}, {Y}, {Z})";

        // IEquatable<Vector3I4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I4F28 other)
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
            return $"Vector3I4F28({x}, {y}, {z})";
        }
    }
}
