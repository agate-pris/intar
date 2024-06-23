using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I18F14 : IEquatable<Vector3I18F14>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I18F14 X;
        public I18F14 Y;
        public I18F14 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I18F14 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14(I18F14 x, I18F14 y, I18F14 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14(I18F14 x, Vector2I18F14 yz) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14(Vector3I18F14 xyz) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14(Vector2I18F14 xy, I18F14 z) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator +(Vector3I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator -(Vector3I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator *(Vector3I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator *(Vector3I18F14 a, I18F14 b) => new Vector3I18F14(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator *(I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator /(Vector3I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator /(Vector3I18F14 a, I18F14 b) => new Vector3I18F14(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator /(I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I18F14 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, X); }
        public readonly Vector2I18F14 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, Y); }
        public readonly Vector2I18F14 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, Z); }
        public readonly Vector2I18F14 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, X); }
        public readonly Vector2I18F14 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, Y); }
        public readonly Vector2I18F14 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, Z); }
        public readonly Vector2I18F14 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Z, X); }
        public readonly Vector2I18F14 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Z, Y); }
        public readonly Vector2I18F14 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Z, Z); }
        public readonly Vector3I18F14 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, X); }
        public readonly Vector3I18F14 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, Y); }
        public readonly Vector3I18F14 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, Z); }
        public readonly Vector3I18F14 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, X); }
        public readonly Vector3I18F14 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, Y); }
        public readonly Vector3I18F14 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, Z); }
        public readonly Vector3I18F14 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Z, X); }
        public readonly Vector3I18F14 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Z, Y); }
        public readonly Vector3I18F14 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Z, Z); }
        public readonly Vector3I18F14 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, X); }
        public readonly Vector3I18F14 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, Y); }
        public readonly Vector3I18F14 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, Z); }
        public readonly Vector3I18F14 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, X); }
        public readonly Vector3I18F14 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, Y); }
        public readonly Vector3I18F14 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, Z); }
        public readonly Vector3I18F14 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Z, X); }
        public readonly Vector3I18F14 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Z, Y); }
        public readonly Vector3I18F14 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Z, Z); }
        public readonly Vector3I18F14 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, X, X); }
        public readonly Vector3I18F14 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, X, Y); }
        public readonly Vector3I18F14 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, X, Z); }
        public readonly Vector3I18F14 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Y, X); }
        public readonly Vector3I18F14 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Y, Y); }
        public readonly Vector3I18F14 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Y, Z); }
        public readonly Vector3I18F14 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Z, X); }
        public readonly Vector3I18F14 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Z, Y); }
        public readonly Vector3I18F14 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Z, Z); }
        public readonly Vector4I18F14 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, X); }
        public readonly Vector4I18F14 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, Y); }
        public readonly Vector4I18F14 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, Z); }
        public readonly Vector4I18F14 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, X); }
        public readonly Vector4I18F14 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, Y); }
        public readonly Vector4I18F14 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, Z); }
        public readonly Vector4I18F14 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Z, X); }
        public readonly Vector4I18F14 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Z, Y); }
        public readonly Vector4I18F14 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Z, Z); }
        public readonly Vector4I18F14 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, X); }
        public readonly Vector4I18F14 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, Y); }
        public readonly Vector4I18F14 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, Z); }
        public readonly Vector4I18F14 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, X); }
        public readonly Vector4I18F14 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, Y); }
        public readonly Vector4I18F14 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, Z); }
        public readonly Vector4I18F14 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Z, X); }
        public readonly Vector4I18F14 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Z, Y); }
        public readonly Vector4I18F14 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Z, Z); }
        public readonly Vector4I18F14 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, X, X); }
        public readonly Vector4I18F14 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, X, Y); }
        public readonly Vector4I18F14 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, X, Z); }
        public readonly Vector4I18F14 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Y, X); }
        public readonly Vector4I18F14 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Y, Y); }
        public readonly Vector4I18F14 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Y, Z); }
        public readonly Vector4I18F14 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Z, X); }
        public readonly Vector4I18F14 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Z, Y); }
        public readonly Vector4I18F14 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Z, Z); }
        public readonly Vector4I18F14 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, X); }
        public readonly Vector4I18F14 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, Y); }
        public readonly Vector4I18F14 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, Z); }
        public readonly Vector4I18F14 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, X); }
        public readonly Vector4I18F14 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, Y); }
        public readonly Vector4I18F14 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, Z); }
        public readonly Vector4I18F14 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Z, X); }
        public readonly Vector4I18F14 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Z, Y); }
        public readonly Vector4I18F14 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Z, Z); }
        public readonly Vector4I18F14 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, X); }
        public readonly Vector4I18F14 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, Y); }
        public readonly Vector4I18F14 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, Z); }
        public readonly Vector4I18F14 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, X); }
        public readonly Vector4I18F14 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, Y); }
        public readonly Vector4I18F14 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, Z); }
        public readonly Vector4I18F14 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Z, X); }
        public readonly Vector4I18F14 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Z, Y); }
        public readonly Vector4I18F14 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Z, Z); }
        public readonly Vector4I18F14 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, X, X); }
        public readonly Vector4I18F14 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, X, Y); }
        public readonly Vector4I18F14 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, X, Z); }
        public readonly Vector4I18F14 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Y, X); }
        public readonly Vector4I18F14 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Y, Y); }
        public readonly Vector4I18F14 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Y, Z); }
        public readonly Vector4I18F14 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Z, X); }
        public readonly Vector4I18F14 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Z, Y); }
        public readonly Vector4I18F14 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Z, Z); }
        public readonly Vector4I18F14 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, X, X); }
        public readonly Vector4I18F14 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, X, Y); }
        public readonly Vector4I18F14 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, X, Z); }
        public readonly Vector4I18F14 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Y, X); }
        public readonly Vector4I18F14 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Y, Y); }
        public readonly Vector4I18F14 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Y, Z); }
        public readonly Vector4I18F14 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Z, X); }
        public readonly Vector4I18F14 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Z, Y); }
        public readonly Vector4I18F14 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Z, Z); }
        public readonly Vector4I18F14 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, X, X); }
        public readonly Vector4I18F14 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, X, Y); }
        public readonly Vector4I18F14 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, X, Z); }
        public readonly Vector4I18F14 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Y, X); }
        public readonly Vector4I18F14 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Y, Y); }
        public readonly Vector4I18F14 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Y, Z); }
        public readonly Vector4I18F14 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Z, X); }
        public readonly Vector4I18F14 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Z, Y); }
        public readonly Vector4I18F14 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Z, Z); }
        public readonly Vector4I18F14 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, X, X); }
        public readonly Vector4I18F14 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, X, Y); }
        public readonly Vector4I18F14 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, X, Z); }
        public readonly Vector4I18F14 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Y, X); }
        public readonly Vector4I18F14 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Y, Y); }
        public readonly Vector4I18F14 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Y, Z); }
        public readonly Vector4I18F14 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Z, X); }
        public readonly Vector4I18F14 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Z, Y); }
        public readonly Vector4I18F14 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I18F14 lhs, Vector3I18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I18F14 lhs, Vector3I18F14 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I18F14({X}, {Y}, {Z})";

        // IEquatable<Vector3I18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I18F14 other)
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
            return $"Vector3I18F14({x}, {y}, {z})";
        }
    }
}
