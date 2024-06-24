using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I16F16 : IEquatable<Vector3I16F16>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I16F16 X;
        public I16F16 Y;
        public I16F16 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I16F16 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I16F16(I16F16 x, I16F16 y, I16F16 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I16F16(I16F16 x, Vector2I16F16 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I16F16(Vector3I16F16 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I16F16(Vector2I16F16 xy, I16F16 z) : this(xy.X, xy.Y, z) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 operator +(Vector3I16F16 a, Vector3I16F16 b) => new Vector3I16F16(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 operator -(Vector3I16F16 a, Vector3I16F16 b) => new Vector3I16F16(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 operator *(Vector3I16F16 a, Vector3I16F16 b) => new Vector3I16F16(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 operator *(Vector3I16F16 a, I16F16 b) => new Vector3I16F16(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 operator *(I16F16 a, Vector3I16F16 b) => new Vector3I16F16(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 operator /(Vector3I16F16 a, Vector3I16F16 b) => new Vector3I16F16(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 operator /(Vector3I16F16 a, I16F16 b) => new Vector3I16F16(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 operator /(I16F16 a, Vector3I16F16 b) => new Vector3I16F16(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I16F16 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(X, X); }
        public readonly Vector2I16F16 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(X, Y); }
        public readonly Vector2I16F16 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(X, Z); }
        public readonly Vector2I16F16 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Y, X); }
        public readonly Vector2I16F16 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Y, Y); }
        public readonly Vector2I16F16 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Y, Z); }
        public readonly Vector2I16F16 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Z, X); }
        public readonly Vector2I16F16 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Z, Y); }
        public readonly Vector2I16F16 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Z, Z); }
        public readonly Vector3I16F16 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, X, X); }
        public readonly Vector3I16F16 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, X, Y); }
        public readonly Vector3I16F16 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, X, Z); }
        public readonly Vector3I16F16 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Y, X); }
        public readonly Vector3I16F16 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Y, Y); }
        public readonly Vector3I16F16 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Y, Z); }
        public readonly Vector3I16F16 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Z, X); }
        public readonly Vector3I16F16 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Z, Y); }
        public readonly Vector3I16F16 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Z, Z); }
        public readonly Vector3I16F16 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, X, X); }
        public readonly Vector3I16F16 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, X, Y); }
        public readonly Vector3I16F16 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, X, Z); }
        public readonly Vector3I16F16 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Y, X); }
        public readonly Vector3I16F16 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Y, Y); }
        public readonly Vector3I16F16 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Y, Z); }
        public readonly Vector3I16F16 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Z, X); }
        public readonly Vector3I16F16 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Z, Y); }
        public readonly Vector3I16F16 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Z, Z); }
        public readonly Vector3I16F16 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Z, X, X); }
        public readonly Vector3I16F16 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Z, X, Y); }
        public readonly Vector3I16F16 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Z, X, Z); }
        public readonly Vector3I16F16 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Z, Y, X); }
        public readonly Vector3I16F16 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Z, Y, Y); }
        public readonly Vector3I16F16 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Z, Y, Z); }
        public readonly Vector3I16F16 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Z, Z, X); }
        public readonly Vector3I16F16 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Z, Z, Y); }
        public readonly Vector3I16F16 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Z, Z, Z); }
        public readonly Vector4I16F16 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, X, X); }
        public readonly Vector4I16F16 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, X, Y); }
        public readonly Vector4I16F16 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, X, Z); }
        public readonly Vector4I16F16 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Y, X); }
        public readonly Vector4I16F16 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Y, Y); }
        public readonly Vector4I16F16 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Y, Z); }
        public readonly Vector4I16F16 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Z, X); }
        public readonly Vector4I16F16 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Z, Y); }
        public readonly Vector4I16F16 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Z, Z); }
        public readonly Vector4I16F16 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, X, X); }
        public readonly Vector4I16F16 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, X, Y); }
        public readonly Vector4I16F16 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, X, Z); }
        public readonly Vector4I16F16 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Y, X); }
        public readonly Vector4I16F16 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Y, Y); }
        public readonly Vector4I16F16 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Y, Z); }
        public readonly Vector4I16F16 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Z, X); }
        public readonly Vector4I16F16 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Z, Y); }
        public readonly Vector4I16F16 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Z, Z); }
        public readonly Vector4I16F16 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Z, X, X); }
        public readonly Vector4I16F16 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Z, X, Y); }
        public readonly Vector4I16F16 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Z, X, Z); }
        public readonly Vector4I16F16 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Z, Y, X); }
        public readonly Vector4I16F16 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Z, Y, Y); }
        public readonly Vector4I16F16 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Z, Y, Z); }
        public readonly Vector4I16F16 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Z, Z, X); }
        public readonly Vector4I16F16 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Z, Z, Y); }
        public readonly Vector4I16F16 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Z, Z, Z); }
        public readonly Vector4I16F16 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, X, X); }
        public readonly Vector4I16F16 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, X, Y); }
        public readonly Vector4I16F16 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, X, Z); }
        public readonly Vector4I16F16 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Y, X); }
        public readonly Vector4I16F16 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Y, Y); }
        public readonly Vector4I16F16 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Y, Z); }
        public readonly Vector4I16F16 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Z, X); }
        public readonly Vector4I16F16 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Z, Y); }
        public readonly Vector4I16F16 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Z, Z); }
        public readonly Vector4I16F16 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, X, X); }
        public readonly Vector4I16F16 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, X, Y); }
        public readonly Vector4I16F16 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, X, Z); }
        public readonly Vector4I16F16 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Y, X); }
        public readonly Vector4I16F16 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Y, Y); }
        public readonly Vector4I16F16 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Y, Z); }
        public readonly Vector4I16F16 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Z, X); }
        public readonly Vector4I16F16 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Z, Y); }
        public readonly Vector4I16F16 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Z, Z); }
        public readonly Vector4I16F16 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Z, X, X); }
        public readonly Vector4I16F16 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Z, X, Y); }
        public readonly Vector4I16F16 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Z, X, Z); }
        public readonly Vector4I16F16 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Z, Y, X); }
        public readonly Vector4I16F16 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Z, Y, Y); }
        public readonly Vector4I16F16 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Z, Y, Z); }
        public readonly Vector4I16F16 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Z, Z, X); }
        public readonly Vector4I16F16 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Z, Z, Y); }
        public readonly Vector4I16F16 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Z, Z, Z); }
        public readonly Vector4I16F16 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, X, X, X); }
        public readonly Vector4I16F16 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, X, X, Y); }
        public readonly Vector4I16F16 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, X, X, Z); }
        public readonly Vector4I16F16 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, X, Y, X); }
        public readonly Vector4I16F16 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, X, Y, Y); }
        public readonly Vector4I16F16 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, X, Y, Z); }
        public readonly Vector4I16F16 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, X, Z, X); }
        public readonly Vector4I16F16 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, X, Z, Y); }
        public readonly Vector4I16F16 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, X, Z, Z); }
        public readonly Vector4I16F16 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Y, X, X); }
        public readonly Vector4I16F16 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Y, X, Y); }
        public readonly Vector4I16F16 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Y, X, Z); }
        public readonly Vector4I16F16 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Y, Y, X); }
        public readonly Vector4I16F16 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Y, Y, Y); }
        public readonly Vector4I16F16 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Y, Y, Z); }
        public readonly Vector4I16F16 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Y, Z, X); }
        public readonly Vector4I16F16 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Y, Z, Y); }
        public readonly Vector4I16F16 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Y, Z, Z); }
        public readonly Vector4I16F16 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Z, X, X); }
        public readonly Vector4I16F16 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Z, X, Y); }
        public readonly Vector4I16F16 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Z, X, Z); }
        public readonly Vector4I16F16 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Z, Y, X); }
        public readonly Vector4I16F16 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Z, Y, Y); }
        public readonly Vector4I16F16 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Z, Y, Z); }
        public readonly Vector4I16F16 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Z, Z, X); }
        public readonly Vector4I16F16 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Z, Z, Y); }
        public readonly Vector4I16F16 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I16F16 lhs, Vector3I16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I16F16 lhs, Vector3I16F16 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I16F16({X}, {Y}, {Z})";

        // IEquatable<Vector3I16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I16F16 other)
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
            return $"Vector3I16F16({x}, {y}, {z})";
        }
    }
}
