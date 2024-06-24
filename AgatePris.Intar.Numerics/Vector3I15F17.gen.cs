using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I15F17 : IEquatable<Vector3I15F17>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I15F17 X;
        public I15F17 Y;
        public I15F17 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector3I15F17 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I15F17(I15F17 x, I15F17 y, I15F17 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I15F17(I15F17 x, Vector2I15F17 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I15F17(Vector3I15F17 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I15F17(Vector2I15F17 xy, I15F17 z) : this(xy.X, xy.Y, z) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 operator +(Vector3I15F17 a, Vector3I15F17 b) => new Vector3I15F17(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 operator -(Vector3I15F17 a, Vector3I15F17 b) => new Vector3I15F17(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 operator *(Vector3I15F17 a, Vector3I15F17 b) => new Vector3I15F17(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 operator *(Vector3I15F17 a, I15F17 b) => new Vector3I15F17(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 operator *(I15F17 a, Vector3I15F17 b) => new Vector3I15F17(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 operator /(Vector3I15F17 a, Vector3I15F17 b) => new Vector3I15F17(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 operator /(Vector3I15F17 a, I15F17 b) => new Vector3I15F17(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 operator /(I15F17 a, Vector3I15F17 b) => new Vector3I15F17(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I15F17 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(X, X); }
        public readonly Vector2I15F17 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(X, Y); }
        public readonly Vector2I15F17 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(X, Z); }
        public readonly Vector2I15F17 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Y, X); }
        public readonly Vector2I15F17 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Y, Y); }
        public readonly Vector2I15F17 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Y, Z); }
        public readonly Vector2I15F17 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Z, X); }
        public readonly Vector2I15F17 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Z, Y); }
        public readonly Vector2I15F17 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Z, Z); }
        public readonly Vector3I15F17 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, X, X); }
        public readonly Vector3I15F17 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, X, Y); }
        public readonly Vector3I15F17 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, X, Z); }
        public readonly Vector3I15F17 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Y, X); }
        public readonly Vector3I15F17 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Y, Y); }
        public readonly Vector3I15F17 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Y, Z); }
        public readonly Vector3I15F17 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Z, X); }
        public readonly Vector3I15F17 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Z, Y); }
        public readonly Vector3I15F17 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Z, Z); }
        public readonly Vector3I15F17 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, X, X); }
        public readonly Vector3I15F17 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, X, Y); }
        public readonly Vector3I15F17 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, X, Z); }
        public readonly Vector3I15F17 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Y, X); }
        public readonly Vector3I15F17 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Y, Y); }
        public readonly Vector3I15F17 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Y, Z); }
        public readonly Vector3I15F17 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Z, X); }
        public readonly Vector3I15F17 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Z, Y); }
        public readonly Vector3I15F17 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Z, Z); }
        public readonly Vector3I15F17 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, X, X); }
        public readonly Vector3I15F17 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, X, Y); }
        public readonly Vector3I15F17 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, X, Z); }
        public readonly Vector3I15F17 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Y, X); }
        public readonly Vector3I15F17 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Y, Y); }
        public readonly Vector3I15F17 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Y, Z); }
        public readonly Vector3I15F17 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Z, X); }
        public readonly Vector3I15F17 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Z, Y); }
        public readonly Vector3I15F17 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Z, Z); }
        public readonly Vector4I15F17 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, X, X); }
        public readonly Vector4I15F17 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, X, Y); }
        public readonly Vector4I15F17 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, X, Z); }
        public readonly Vector4I15F17 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Y, X); }
        public readonly Vector4I15F17 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Y, Y); }
        public readonly Vector4I15F17 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Y, Z); }
        public readonly Vector4I15F17 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Z, X); }
        public readonly Vector4I15F17 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Z, Y); }
        public readonly Vector4I15F17 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Z, Z); }
        public readonly Vector4I15F17 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, X, X); }
        public readonly Vector4I15F17 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, X, Y); }
        public readonly Vector4I15F17 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, X, Z); }
        public readonly Vector4I15F17 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Y, X); }
        public readonly Vector4I15F17 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Y, Y); }
        public readonly Vector4I15F17 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Y, Z); }
        public readonly Vector4I15F17 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Z, X); }
        public readonly Vector4I15F17 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Z, Y); }
        public readonly Vector4I15F17 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Z, Z); }
        public readonly Vector4I15F17 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, X, X); }
        public readonly Vector4I15F17 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, X, Y); }
        public readonly Vector4I15F17 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, X, Z); }
        public readonly Vector4I15F17 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Y, X); }
        public readonly Vector4I15F17 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Y, Y); }
        public readonly Vector4I15F17 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Y, Z); }
        public readonly Vector4I15F17 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Z, X); }
        public readonly Vector4I15F17 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Z, Y); }
        public readonly Vector4I15F17 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Z, Z); }
        public readonly Vector4I15F17 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, X, X); }
        public readonly Vector4I15F17 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, X, Y); }
        public readonly Vector4I15F17 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, X, Z); }
        public readonly Vector4I15F17 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Y, X); }
        public readonly Vector4I15F17 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Y, Y); }
        public readonly Vector4I15F17 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Y, Z); }
        public readonly Vector4I15F17 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Z, X); }
        public readonly Vector4I15F17 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Z, Y); }
        public readonly Vector4I15F17 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Z, Z); }
        public readonly Vector4I15F17 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, X, X); }
        public readonly Vector4I15F17 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, X, Y); }
        public readonly Vector4I15F17 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, X, Z); }
        public readonly Vector4I15F17 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Y, X); }
        public readonly Vector4I15F17 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Y, Y); }
        public readonly Vector4I15F17 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Y, Z); }
        public readonly Vector4I15F17 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Z, X); }
        public readonly Vector4I15F17 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Z, Y); }
        public readonly Vector4I15F17 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Z, Z); }
        public readonly Vector4I15F17 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, X, X); }
        public readonly Vector4I15F17 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, X, Y); }
        public readonly Vector4I15F17 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, X, Z); }
        public readonly Vector4I15F17 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Y, X); }
        public readonly Vector4I15F17 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Y, Y); }
        public readonly Vector4I15F17 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Y, Z); }
        public readonly Vector4I15F17 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Z, X); }
        public readonly Vector4I15F17 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Z, Y); }
        public readonly Vector4I15F17 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Z, Z); }
        public readonly Vector4I15F17 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, X, X); }
        public readonly Vector4I15F17 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, X, Y); }
        public readonly Vector4I15F17 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, X, Z); }
        public readonly Vector4I15F17 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Y, X); }
        public readonly Vector4I15F17 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Y, Y); }
        public readonly Vector4I15F17 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Y, Z); }
        public readonly Vector4I15F17 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Z, X); }
        public readonly Vector4I15F17 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Z, Y); }
        public readonly Vector4I15F17 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Z, Z); }
        public readonly Vector4I15F17 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, X, X); }
        public readonly Vector4I15F17 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, X, Y); }
        public readonly Vector4I15F17 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, X, Z); }
        public readonly Vector4I15F17 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Y, X); }
        public readonly Vector4I15F17 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Y, Y); }
        public readonly Vector4I15F17 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Y, Z); }
        public readonly Vector4I15F17 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Z, X); }
        public readonly Vector4I15F17 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Z, Y); }
        public readonly Vector4I15F17 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Z, Z); }
        public readonly Vector4I15F17 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, X, X); }
        public readonly Vector4I15F17 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, X, Y); }
        public readonly Vector4I15F17 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, X, Z); }
        public readonly Vector4I15F17 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Y, X); }
        public readonly Vector4I15F17 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Y, Y); }
        public readonly Vector4I15F17 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Y, Z); }
        public readonly Vector4I15F17 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Z, X); }
        public readonly Vector4I15F17 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Z, Y); }
        public readonly Vector4I15F17 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I15F17 lhs, Vector3I15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I15F17 lhs, Vector3I15F17 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I15F17({X}, {Y}, {Z})";

        // IEquatable<Vector3I15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I15F17 other)
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
            return $"Vector3I15F17({x}, {y}, {z})";
        }
    }
}
