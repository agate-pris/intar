using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I24F8 : IEquatable<Vector3I24F8>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I24F8 X;
        public I24F8 Y;
        public I24F8 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I24F8 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I24F8(I24F8 x, I24F8 y, I24F8 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I24F8(I24F8 x, Vector2I24F8 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I24F8(Vector3I24F8 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I24F8(Vector2I24F8 xy, I24F8 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator +(Vector3I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator -(Vector3I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator *(Vector3I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator *(Vector3I24F8 a, I24F8 b) => new Vector3I24F8(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator *(I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator /(Vector3I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator /(Vector3I24F8 a, I24F8 b) => new Vector3I24F8(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator /(I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I24F8 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(X, X); }
        public readonly Vector2I24F8 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(X, Y); }
        public readonly Vector2I24F8 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(X, Z); }
        public readonly Vector2I24F8 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Y, X); }
        public readonly Vector2I24F8 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Y, Y); }
        public readonly Vector2I24F8 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Y, Z); }
        public readonly Vector2I24F8 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Z, X); }
        public readonly Vector2I24F8 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Z, Y); }
        public readonly Vector2I24F8 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Z, Z); }
        public readonly Vector3I24F8 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, X, X); }
        public readonly Vector3I24F8 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, X, Y); }
        public readonly Vector3I24F8 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, X, Z); }
        public readonly Vector3I24F8 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Y, X); }
        public readonly Vector3I24F8 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Y, Y); }
        public readonly Vector3I24F8 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Y, Z); }
        public readonly Vector3I24F8 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Z, X); }
        public readonly Vector3I24F8 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Z, Y); }
        public readonly Vector3I24F8 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Z, Z); }
        public readonly Vector3I24F8 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, X, X); }
        public readonly Vector3I24F8 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, X, Y); }
        public readonly Vector3I24F8 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, X, Z); }
        public readonly Vector3I24F8 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Y, X); }
        public readonly Vector3I24F8 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Y, Y); }
        public readonly Vector3I24F8 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Y, Z); }
        public readonly Vector3I24F8 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Z, X); }
        public readonly Vector3I24F8 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Z, Y); }
        public readonly Vector3I24F8 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Z, Z); }
        public readonly Vector3I24F8 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, X, X); }
        public readonly Vector3I24F8 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, X, Y); }
        public readonly Vector3I24F8 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, X, Z); }
        public readonly Vector3I24F8 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Y, X); }
        public readonly Vector3I24F8 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Y, Y); }
        public readonly Vector3I24F8 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Y, Z); }
        public readonly Vector3I24F8 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Z, X); }
        public readonly Vector3I24F8 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Z, Y); }
        public readonly Vector3I24F8 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Z, Z); }
        public readonly Vector4I24F8 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, X, X); }
        public readonly Vector4I24F8 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, X, Y); }
        public readonly Vector4I24F8 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, X, Z); }
        public readonly Vector4I24F8 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Y, X); }
        public readonly Vector4I24F8 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Y, Y); }
        public readonly Vector4I24F8 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Y, Z); }
        public readonly Vector4I24F8 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Z, X); }
        public readonly Vector4I24F8 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Z, Y); }
        public readonly Vector4I24F8 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Z, Z); }
        public readonly Vector4I24F8 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, X, X); }
        public readonly Vector4I24F8 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, X, Y); }
        public readonly Vector4I24F8 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, X, Z); }
        public readonly Vector4I24F8 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Y, X); }
        public readonly Vector4I24F8 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Y, Y); }
        public readonly Vector4I24F8 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Y, Z); }
        public readonly Vector4I24F8 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Z, X); }
        public readonly Vector4I24F8 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Z, Y); }
        public readonly Vector4I24F8 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Z, Z); }
        public readonly Vector4I24F8 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, X, X); }
        public readonly Vector4I24F8 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, X, Y); }
        public readonly Vector4I24F8 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, X, Z); }
        public readonly Vector4I24F8 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Y, X); }
        public readonly Vector4I24F8 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Y, Y); }
        public readonly Vector4I24F8 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Y, Z); }
        public readonly Vector4I24F8 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Z, X); }
        public readonly Vector4I24F8 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Z, Y); }
        public readonly Vector4I24F8 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Z, Z); }
        public readonly Vector4I24F8 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, X, X); }
        public readonly Vector4I24F8 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, X, Y); }
        public readonly Vector4I24F8 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, X, Z); }
        public readonly Vector4I24F8 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Y, X); }
        public readonly Vector4I24F8 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Y, Y); }
        public readonly Vector4I24F8 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Y, Z); }
        public readonly Vector4I24F8 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Z, X); }
        public readonly Vector4I24F8 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Z, Y); }
        public readonly Vector4I24F8 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Z, Z); }
        public readonly Vector4I24F8 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, X, X); }
        public readonly Vector4I24F8 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, X, Y); }
        public readonly Vector4I24F8 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, X, Z); }
        public readonly Vector4I24F8 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Y, X); }
        public readonly Vector4I24F8 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Y, Y); }
        public readonly Vector4I24F8 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Y, Z); }
        public readonly Vector4I24F8 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Z, X); }
        public readonly Vector4I24F8 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Z, Y); }
        public readonly Vector4I24F8 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Z, Z); }
        public readonly Vector4I24F8 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, X, X); }
        public readonly Vector4I24F8 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, X, Y); }
        public readonly Vector4I24F8 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, X, Z); }
        public readonly Vector4I24F8 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Y, X); }
        public readonly Vector4I24F8 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Y, Y); }
        public readonly Vector4I24F8 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Y, Z); }
        public readonly Vector4I24F8 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Z, X); }
        public readonly Vector4I24F8 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Z, Y); }
        public readonly Vector4I24F8 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Z, Z); }
        public readonly Vector4I24F8 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, X, X); }
        public readonly Vector4I24F8 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, X, Y); }
        public readonly Vector4I24F8 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, X, Z); }
        public readonly Vector4I24F8 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Y, X); }
        public readonly Vector4I24F8 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Y, Y); }
        public readonly Vector4I24F8 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Y, Z); }
        public readonly Vector4I24F8 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Z, X); }
        public readonly Vector4I24F8 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Z, Y); }
        public readonly Vector4I24F8 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Z, Z); }
        public readonly Vector4I24F8 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, X, X); }
        public readonly Vector4I24F8 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, X, Y); }
        public readonly Vector4I24F8 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, X, Z); }
        public readonly Vector4I24F8 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Y, X); }
        public readonly Vector4I24F8 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Y, Y); }
        public readonly Vector4I24F8 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Y, Z); }
        public readonly Vector4I24F8 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Z, X); }
        public readonly Vector4I24F8 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Z, Y); }
        public readonly Vector4I24F8 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Z, Z); }
        public readonly Vector4I24F8 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, X, X); }
        public readonly Vector4I24F8 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, X, Y); }
        public readonly Vector4I24F8 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, X, Z); }
        public readonly Vector4I24F8 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Y, X); }
        public readonly Vector4I24F8 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Y, Y); }
        public readonly Vector4I24F8 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Y, Z); }
        public readonly Vector4I24F8 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Z, X); }
        public readonly Vector4I24F8 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Z, Y); }
        public readonly Vector4I24F8 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I24F8 lhs, Vector3I24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I24F8 lhs, Vector3I24F8 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I24F8({X}, {Y}, {Z})";

        // IEquatable<Vector3I24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I24F8 other)
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
            return $"Vector3I24F8({x}, {y}, {z})";
        }
    }
}
