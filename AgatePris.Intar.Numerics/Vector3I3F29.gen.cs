using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I3F29 : IEquatable<Vector3I3F29>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I3F29 X;
        public I3F29 Y;
        public I3F29 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I3F29 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I3F29(I3F29 x, I3F29 y, I3F29 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I3F29(I3F29 x, Vector2I3F29 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I3F29(Vector3I3F29 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I3F29(Vector2I3F29 xy, I3F29 z) : this(xy.X, xy.Y, z) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator +(Vector3I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator -(Vector3I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator *(Vector3I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator *(Vector3I3F29 a, I3F29 b) => new Vector3I3F29(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator *(I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator /(Vector3I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator /(Vector3I3F29 a, I3F29 b) => new Vector3I3F29(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator /(I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I3F29 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(X, X); }
        public readonly Vector2I3F29 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(X, Y); }
        public readonly Vector2I3F29 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(X, Z); }
        public readonly Vector2I3F29 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(Y, X); }
        public readonly Vector2I3F29 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(Y, Y); }
        public readonly Vector2I3F29 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(Y, Z); }
        public readonly Vector2I3F29 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(Z, X); }
        public readonly Vector2I3F29 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(Z, Y); }
        public readonly Vector2I3F29 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(Z, Z); }
        public readonly Vector3I3F29 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, X, X); }
        public readonly Vector3I3F29 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, X, Y); }
        public readonly Vector3I3F29 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, X, Z); }
        public readonly Vector3I3F29 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, Y, X); }
        public readonly Vector3I3F29 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, Y, Y); }
        public readonly Vector3I3F29 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, Y, Z); }
        public readonly Vector3I3F29 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, Z, X); }
        public readonly Vector3I3F29 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, Z, Y); }
        public readonly Vector3I3F29 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, Z, Z); }
        public readonly Vector3I3F29 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, X, X); }
        public readonly Vector3I3F29 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, X, Y); }
        public readonly Vector3I3F29 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, X, Z); }
        public readonly Vector3I3F29 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, Y, X); }
        public readonly Vector3I3F29 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, Y, Y); }
        public readonly Vector3I3F29 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, Y, Z); }
        public readonly Vector3I3F29 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, Z, X); }
        public readonly Vector3I3F29 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, Z, Y); }
        public readonly Vector3I3F29 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, Z, Z); }
        public readonly Vector3I3F29 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Z, X, X); }
        public readonly Vector3I3F29 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Z, X, Y); }
        public readonly Vector3I3F29 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Z, X, Z); }
        public readonly Vector3I3F29 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Z, Y, X); }
        public readonly Vector3I3F29 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Z, Y, Y); }
        public readonly Vector3I3F29 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Z, Y, Z); }
        public readonly Vector3I3F29 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Z, Z, X); }
        public readonly Vector3I3F29 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Z, Z, Y); }
        public readonly Vector3I3F29 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Z, Z, Z); }
        public readonly Vector4I3F29 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, X, X); }
        public readonly Vector4I3F29 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, X, Y); }
        public readonly Vector4I3F29 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, X, Z); }
        public readonly Vector4I3F29 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, Y, X); }
        public readonly Vector4I3F29 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, Y, Y); }
        public readonly Vector4I3F29 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, Y, Z); }
        public readonly Vector4I3F29 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, Z, X); }
        public readonly Vector4I3F29 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, Z, Y); }
        public readonly Vector4I3F29 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, Z, Z); }
        public readonly Vector4I3F29 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, X, X); }
        public readonly Vector4I3F29 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, X, Y); }
        public readonly Vector4I3F29 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, X, Z); }
        public readonly Vector4I3F29 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, Y, X); }
        public readonly Vector4I3F29 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, Y, Y); }
        public readonly Vector4I3F29 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, Y, Z); }
        public readonly Vector4I3F29 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, Z, X); }
        public readonly Vector4I3F29 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, Z, Y); }
        public readonly Vector4I3F29 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, Z, Z); }
        public readonly Vector4I3F29 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Z, X, X); }
        public readonly Vector4I3F29 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Z, X, Y); }
        public readonly Vector4I3F29 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Z, X, Z); }
        public readonly Vector4I3F29 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Z, Y, X); }
        public readonly Vector4I3F29 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Z, Y, Y); }
        public readonly Vector4I3F29 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Z, Y, Z); }
        public readonly Vector4I3F29 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Z, Z, X); }
        public readonly Vector4I3F29 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Z, Z, Y); }
        public readonly Vector4I3F29 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Z, Z, Z); }
        public readonly Vector4I3F29 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, X, X); }
        public readonly Vector4I3F29 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, X, Y); }
        public readonly Vector4I3F29 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, X, Z); }
        public readonly Vector4I3F29 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, Y, X); }
        public readonly Vector4I3F29 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, Y, Y); }
        public readonly Vector4I3F29 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, Y, Z); }
        public readonly Vector4I3F29 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, Z, X); }
        public readonly Vector4I3F29 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, Z, Y); }
        public readonly Vector4I3F29 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, Z, Z); }
        public readonly Vector4I3F29 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, X, X); }
        public readonly Vector4I3F29 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, X, Y); }
        public readonly Vector4I3F29 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, X, Z); }
        public readonly Vector4I3F29 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, Y, X); }
        public readonly Vector4I3F29 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, Y, Y); }
        public readonly Vector4I3F29 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, Y, Z); }
        public readonly Vector4I3F29 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, Z, X); }
        public readonly Vector4I3F29 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, Z, Y); }
        public readonly Vector4I3F29 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, Z, Z); }
        public readonly Vector4I3F29 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Z, X, X); }
        public readonly Vector4I3F29 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Z, X, Y); }
        public readonly Vector4I3F29 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Z, X, Z); }
        public readonly Vector4I3F29 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Z, Y, X); }
        public readonly Vector4I3F29 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Z, Y, Y); }
        public readonly Vector4I3F29 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Z, Y, Z); }
        public readonly Vector4I3F29 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Z, Z, X); }
        public readonly Vector4I3F29 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Z, Z, Y); }
        public readonly Vector4I3F29 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Z, Z, Z); }
        public readonly Vector4I3F29 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, X, X, X); }
        public readonly Vector4I3F29 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, X, X, Y); }
        public readonly Vector4I3F29 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, X, X, Z); }
        public readonly Vector4I3F29 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, X, Y, X); }
        public readonly Vector4I3F29 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, X, Y, Y); }
        public readonly Vector4I3F29 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, X, Y, Z); }
        public readonly Vector4I3F29 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, X, Z, X); }
        public readonly Vector4I3F29 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, X, Z, Y); }
        public readonly Vector4I3F29 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, X, Z, Z); }
        public readonly Vector4I3F29 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Y, X, X); }
        public readonly Vector4I3F29 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Y, X, Y); }
        public readonly Vector4I3F29 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Y, X, Z); }
        public readonly Vector4I3F29 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Y, Y, X); }
        public readonly Vector4I3F29 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Y, Y, Y); }
        public readonly Vector4I3F29 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Y, Y, Z); }
        public readonly Vector4I3F29 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Y, Z, X); }
        public readonly Vector4I3F29 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Y, Z, Y); }
        public readonly Vector4I3F29 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Y, Z, Z); }
        public readonly Vector4I3F29 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Z, X, X); }
        public readonly Vector4I3F29 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Z, X, Y); }
        public readonly Vector4I3F29 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Z, X, Z); }
        public readonly Vector4I3F29 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Z, Y, X); }
        public readonly Vector4I3F29 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Z, Y, Y); }
        public readonly Vector4I3F29 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Z, Y, Z); }
        public readonly Vector4I3F29 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Z, Z, X); }
        public readonly Vector4I3F29 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Z, Z, Y); }
        public readonly Vector4I3F29 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I3F29 lhs, Vector3I3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I3F29 lhs, Vector3I3F29 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I3F29({X}, {Y}, {Z})";

        // IEquatable<Vector3I3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I3F29 other)
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
            return $"Vector3I3F29({x}, {y}, {z})";
        }
    }
}
