using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I31F1 : IEquatable<Vector3I31F1>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I31F1 X;
        public I31F1 Y;
        public I31F1 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I31F1 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I31F1(I31F1 x, I31F1 y, I31F1 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I31F1(I31F1 x, Vector2I31F1 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I31F1(Vector3I31F1 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I31F1(Vector2I31F1 xy, I31F1 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator +(Vector3I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator -(Vector3I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator *(Vector3I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator *(Vector3I31F1 a, I31F1 b) => new Vector3I31F1(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator *(I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator /(Vector3I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator /(Vector3I31F1 a, I31F1 b) => new Vector3I31F1(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator /(I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I31F1 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, X); }
        public readonly Vector2I31F1 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, Y); }
        public readonly Vector2I31F1 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, Z); }
        public readonly Vector2I31F1 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, X); }
        public readonly Vector2I31F1 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, Y); }
        public readonly Vector2I31F1 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, Z); }
        public readonly Vector2I31F1 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, X); }
        public readonly Vector2I31F1 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, Y); }
        public readonly Vector2I31F1 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, Z); }
        public readonly Vector3I31F1 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, X); }
        public readonly Vector3I31F1 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, Y); }
        public readonly Vector3I31F1 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, Z); }
        public readonly Vector3I31F1 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, X); }
        public readonly Vector3I31F1 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, Y); }
        public readonly Vector3I31F1 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, Z); }
        public readonly Vector3I31F1 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, X); }
        public readonly Vector3I31F1 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, Y); }
        public readonly Vector3I31F1 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, Z); }
        public readonly Vector3I31F1 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, X); }
        public readonly Vector3I31F1 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, Y); }
        public readonly Vector3I31F1 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, Z); }
        public readonly Vector3I31F1 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, X); }
        public readonly Vector3I31F1 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, Y); }
        public readonly Vector3I31F1 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, Z); }
        public readonly Vector3I31F1 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, X); }
        public readonly Vector3I31F1 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, Y); }
        public readonly Vector3I31F1 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, Z); }
        public readonly Vector3I31F1 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, X); }
        public readonly Vector3I31F1 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, Y); }
        public readonly Vector3I31F1 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, Z); }
        public readonly Vector3I31F1 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, X); }
        public readonly Vector3I31F1 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, Y); }
        public readonly Vector3I31F1 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, Z); }
        public readonly Vector3I31F1 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, X); }
        public readonly Vector3I31F1 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, Y); }
        public readonly Vector3I31F1 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, Z); }
        public readonly Vector4I31F1 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, X); }
        public readonly Vector4I31F1 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, Y); }
        public readonly Vector4I31F1 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, Z); }
        public readonly Vector4I31F1 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, X); }
        public readonly Vector4I31F1 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, Y); }
        public readonly Vector4I31F1 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, Z); }
        public readonly Vector4I31F1 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, X); }
        public readonly Vector4I31F1 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, Y); }
        public readonly Vector4I31F1 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, Z); }
        public readonly Vector4I31F1 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, X); }
        public readonly Vector4I31F1 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, Y); }
        public readonly Vector4I31F1 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, Z); }
        public readonly Vector4I31F1 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, X); }
        public readonly Vector4I31F1 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, Y); }
        public readonly Vector4I31F1 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, Z); }
        public readonly Vector4I31F1 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, X); }
        public readonly Vector4I31F1 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, Y); }
        public readonly Vector4I31F1 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, Z); }
        public readonly Vector4I31F1 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, X); }
        public readonly Vector4I31F1 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, Y); }
        public readonly Vector4I31F1 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, Z); }
        public readonly Vector4I31F1 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, X); }
        public readonly Vector4I31F1 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, Y); }
        public readonly Vector4I31F1 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, Z); }
        public readonly Vector4I31F1 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, X); }
        public readonly Vector4I31F1 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, Y); }
        public readonly Vector4I31F1 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, Z); }
        public readonly Vector4I31F1 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, X); }
        public readonly Vector4I31F1 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, Y); }
        public readonly Vector4I31F1 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, Z); }
        public readonly Vector4I31F1 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, X); }
        public readonly Vector4I31F1 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, Y); }
        public readonly Vector4I31F1 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, Z); }
        public readonly Vector4I31F1 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, X); }
        public readonly Vector4I31F1 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, Y); }
        public readonly Vector4I31F1 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, Z); }
        public readonly Vector4I31F1 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, X); }
        public readonly Vector4I31F1 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, Y); }
        public readonly Vector4I31F1 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, Z); }
        public readonly Vector4I31F1 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, X); }
        public readonly Vector4I31F1 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, Y); }
        public readonly Vector4I31F1 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, Z); }
        public readonly Vector4I31F1 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, X); }
        public readonly Vector4I31F1 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, Y); }
        public readonly Vector4I31F1 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, Z); }
        public readonly Vector4I31F1 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, X); }
        public readonly Vector4I31F1 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, Y); }
        public readonly Vector4I31F1 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, Z); }
        public readonly Vector4I31F1 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, X); }
        public readonly Vector4I31F1 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, Y); }
        public readonly Vector4I31F1 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, Z); }
        public readonly Vector4I31F1 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, X); }
        public readonly Vector4I31F1 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, Y); }
        public readonly Vector4I31F1 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, Z); }
        public readonly Vector4I31F1 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, X); }
        public readonly Vector4I31F1 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, Y); }
        public readonly Vector4I31F1 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, Z); }
        public readonly Vector4I31F1 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, X); }
        public readonly Vector4I31F1 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, Y); }
        public readonly Vector4I31F1 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, Z); }
        public readonly Vector4I31F1 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, X); }
        public readonly Vector4I31F1 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, Y); }
        public readonly Vector4I31F1 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, Z); }
        public readonly Vector4I31F1 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, X); }
        public readonly Vector4I31F1 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, Y); }
        public readonly Vector4I31F1 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, Z); }
        public readonly Vector4I31F1 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, X); }
        public readonly Vector4I31F1 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, Y); }
        public readonly Vector4I31F1 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, Z); }
        public readonly Vector4I31F1 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, X); }
        public readonly Vector4I31F1 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, Y); }
        public readonly Vector4I31F1 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, Z); }
        public readonly Vector4I31F1 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, X); }
        public readonly Vector4I31F1 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, Y); }
        public readonly Vector4I31F1 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, Z); }
        public readonly Vector4I31F1 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, X); }
        public readonly Vector4I31F1 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, Y); }
        public readonly Vector4I31F1 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, Z); }
        public readonly Vector4I31F1 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, X); }
        public readonly Vector4I31F1 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, Y); }
        public readonly Vector4I31F1 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I31F1 lhs, Vector3I31F1 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I31F1 lhs, Vector3I31F1 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I31F1 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I31F1({X}, {Y}, {Z})";

        // IEquatable<Vector3I31F1>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I31F1 other)
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
            return $"Vector3I31F1({x}, {y}, {z})";
        }
    }
}
