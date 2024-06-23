using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I8F24 : IEquatable<Vector3I8F24>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I8F24 X;
        public I8F24 Y;
        public I8F24 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I8F24 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(I8F24 x, I8F24 y, I8F24 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(I8F24 x, Vector2I8F24 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(Vector3I8F24 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(Vector2I8F24 xy, I8F24 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator +(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator -(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator *(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator *(Vector3I8F24 a, I8F24 b) => new Vector3I8F24(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator *(I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator /(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator /(Vector3I8F24 a, I8F24 b) => new Vector3I8F24(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator /(I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I8F24 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, X); }
        public readonly Vector2I8F24 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, Y); }
        public readonly Vector2I8F24 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, Z); }
        public readonly Vector2I8F24 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, X); }
        public readonly Vector2I8F24 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, Y); }
        public readonly Vector2I8F24 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, Z); }
        public readonly Vector2I8F24 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Z, X); }
        public readonly Vector2I8F24 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Z, Y); }
        public readonly Vector2I8F24 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Z, Z); }
        public readonly Vector3I8F24 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, X); }
        public readonly Vector3I8F24 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, Y); }
        public readonly Vector3I8F24 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, Z); }
        public readonly Vector3I8F24 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, X); }
        public readonly Vector3I8F24 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, Y); }
        public readonly Vector3I8F24 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, Z); }
        public readonly Vector3I8F24 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Z, X); }
        public readonly Vector3I8F24 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Z, Y); }
        public readonly Vector3I8F24 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Z, Z); }
        public readonly Vector3I8F24 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, X); }
        public readonly Vector3I8F24 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, Y); }
        public readonly Vector3I8F24 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, Z); }
        public readonly Vector3I8F24 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, X); }
        public readonly Vector3I8F24 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, Y); }
        public readonly Vector3I8F24 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, Z); }
        public readonly Vector3I8F24 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Z, X); }
        public readonly Vector3I8F24 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Z, Y); }
        public readonly Vector3I8F24 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Z, Z); }
        public readonly Vector3I8F24 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, X, X); }
        public readonly Vector3I8F24 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, X, Y); }
        public readonly Vector3I8F24 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, X, Z); }
        public readonly Vector3I8F24 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Y, X); }
        public readonly Vector3I8F24 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Y, Y); }
        public readonly Vector3I8F24 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Y, Z); }
        public readonly Vector3I8F24 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Z, X); }
        public readonly Vector3I8F24 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Z, Y); }
        public readonly Vector3I8F24 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Z, Z); }
        public readonly Vector4I8F24 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, X); }
        public readonly Vector4I8F24 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, Y); }
        public readonly Vector4I8F24 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, Z); }
        public readonly Vector4I8F24 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, X); }
        public readonly Vector4I8F24 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, Y); }
        public readonly Vector4I8F24 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, Z); }
        public readonly Vector4I8F24 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Z, X); }
        public readonly Vector4I8F24 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Z, Y); }
        public readonly Vector4I8F24 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Z, Z); }
        public readonly Vector4I8F24 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, X); }
        public readonly Vector4I8F24 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, Y); }
        public readonly Vector4I8F24 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, Z); }
        public readonly Vector4I8F24 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, X); }
        public readonly Vector4I8F24 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, Y); }
        public readonly Vector4I8F24 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, Z); }
        public readonly Vector4I8F24 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Z, X); }
        public readonly Vector4I8F24 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Z, Y); }
        public readonly Vector4I8F24 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Z, Z); }
        public readonly Vector4I8F24 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, X, X); }
        public readonly Vector4I8F24 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, X, Y); }
        public readonly Vector4I8F24 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, X, Z); }
        public readonly Vector4I8F24 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Y, X); }
        public readonly Vector4I8F24 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Y, Y); }
        public readonly Vector4I8F24 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Y, Z); }
        public readonly Vector4I8F24 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Z, X); }
        public readonly Vector4I8F24 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Z, Y); }
        public readonly Vector4I8F24 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Z, Z); }
        public readonly Vector4I8F24 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, X); }
        public readonly Vector4I8F24 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, Y); }
        public readonly Vector4I8F24 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, Z); }
        public readonly Vector4I8F24 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, X); }
        public readonly Vector4I8F24 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, Y); }
        public readonly Vector4I8F24 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, Z); }
        public readonly Vector4I8F24 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Z, X); }
        public readonly Vector4I8F24 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Z, Y); }
        public readonly Vector4I8F24 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Z, Z); }
        public readonly Vector4I8F24 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, X); }
        public readonly Vector4I8F24 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, Y); }
        public readonly Vector4I8F24 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, Z); }
        public readonly Vector4I8F24 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, X); }
        public readonly Vector4I8F24 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, Y); }
        public readonly Vector4I8F24 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, Z); }
        public readonly Vector4I8F24 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Z, X); }
        public readonly Vector4I8F24 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Z, Y); }
        public readonly Vector4I8F24 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Z, Z); }
        public readonly Vector4I8F24 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, X, X); }
        public readonly Vector4I8F24 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, X, Y); }
        public readonly Vector4I8F24 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, X, Z); }
        public readonly Vector4I8F24 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Y, X); }
        public readonly Vector4I8F24 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Y, Y); }
        public readonly Vector4I8F24 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Y, Z); }
        public readonly Vector4I8F24 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Z, X); }
        public readonly Vector4I8F24 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Z, Y); }
        public readonly Vector4I8F24 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Z, Z); }
        public readonly Vector4I8F24 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, X, X); }
        public readonly Vector4I8F24 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, X, Y); }
        public readonly Vector4I8F24 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, X, Z); }
        public readonly Vector4I8F24 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Y, X); }
        public readonly Vector4I8F24 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Y, Y); }
        public readonly Vector4I8F24 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Y, Z); }
        public readonly Vector4I8F24 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Z, X); }
        public readonly Vector4I8F24 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Z, Y); }
        public readonly Vector4I8F24 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Z, Z); }
        public readonly Vector4I8F24 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, X, X); }
        public readonly Vector4I8F24 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, X, Y); }
        public readonly Vector4I8F24 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, X, Z); }
        public readonly Vector4I8F24 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Y, X); }
        public readonly Vector4I8F24 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Y, Y); }
        public readonly Vector4I8F24 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Y, Z); }
        public readonly Vector4I8F24 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Z, X); }
        public readonly Vector4I8F24 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Z, Y); }
        public readonly Vector4I8F24 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Z, Z); }
        public readonly Vector4I8F24 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, X, X); }
        public readonly Vector4I8F24 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, X, Y); }
        public readonly Vector4I8F24 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, X, Z); }
        public readonly Vector4I8F24 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Y, X); }
        public readonly Vector4I8F24 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Y, Y); }
        public readonly Vector4I8F24 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Y, Z); }
        public readonly Vector4I8F24 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Z, X); }
        public readonly Vector4I8F24 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Z, Y); }
        public readonly Vector4I8F24 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I8F24 lhs, Vector3I8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I8F24 lhs, Vector3I8F24 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I8F24({X}, {Y}, {Z})";

        // IEquatable<Vector3I8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I8F24 other)
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
            return $"Vector3I8F24({x}, {y}, {z})";
        }
    }
}
