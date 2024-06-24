using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I10F22 : IEquatable<Vector3I10F22>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I10F22 X;
        public I10F22 Y;
        public I10F22 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22(I10F22 x, I10F22 y, I10F22 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22(I10F22 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22(I10F22 x, Vector2I10F22 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22(Vector3I10F22 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22(Vector2I10F22 xy, I10F22 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I10F22 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I10F22(I10F22.Zero);
        }
        public static Vector3I10F22 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I10F22(I10F22.One);
        }
        public static Vector3I10F22 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I10F22(I10F22.One, I10F22.Zero, I10F22.Zero);
        }
        public static Vector3I10F22 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I10F22(I10F22.Zero, I10F22.One, I10F22.Zero);
        }
        public static Vector3I10F22 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I10F22(I10F22.Zero, I10F22.Zero, I10F22.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator +(Vector3I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator -(Vector3I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator *(Vector3I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator *(Vector3I10F22 a, I10F22 b) => new Vector3I10F22(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator *(I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator /(Vector3I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator /(Vector3I10F22 a, I10F22 b) => new Vector3I10F22(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator /(I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I10F22 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(X, X); }
        public readonly Vector2I10F22 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(X, Y); }
        public readonly Vector2I10F22 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(X, Z); }
        public readonly Vector2I10F22 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Y, X); }
        public readonly Vector2I10F22 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Y, Y); }
        public readonly Vector2I10F22 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Y, Z); }
        public readonly Vector2I10F22 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Z, X); }
        public readonly Vector2I10F22 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Z, Y); }
        public readonly Vector2I10F22 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Z, Z); }
        public readonly Vector3I10F22 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, X, X); }
        public readonly Vector3I10F22 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, X, Y); }
        public readonly Vector3I10F22 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, X, Z); }
        public readonly Vector3I10F22 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Y, X); }
        public readonly Vector3I10F22 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Y, Y); }
        public readonly Vector3I10F22 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Y, Z); }
        public readonly Vector3I10F22 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Z, X); }
        public readonly Vector3I10F22 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Z, Y); }
        public readonly Vector3I10F22 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Z, Z); }
        public readonly Vector3I10F22 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, X, X); }
        public readonly Vector3I10F22 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, X, Y); }
        public readonly Vector3I10F22 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, X, Z); }
        public readonly Vector3I10F22 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Y, X); }
        public readonly Vector3I10F22 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Y, Y); }
        public readonly Vector3I10F22 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Y, Z); }
        public readonly Vector3I10F22 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Z, X); }
        public readonly Vector3I10F22 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Z, Y); }
        public readonly Vector3I10F22 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Z, Z); }
        public readonly Vector3I10F22 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, X, X); }
        public readonly Vector3I10F22 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, X, Y); }
        public readonly Vector3I10F22 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, X, Z); }
        public readonly Vector3I10F22 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Y, X); }
        public readonly Vector3I10F22 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Y, Y); }
        public readonly Vector3I10F22 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Y, Z); }
        public readonly Vector3I10F22 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Z, X); }
        public readonly Vector3I10F22 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Z, Y); }
        public readonly Vector3I10F22 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Z, Z); }
        public readonly Vector4I10F22 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, X, X); }
        public readonly Vector4I10F22 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, X, Y); }
        public readonly Vector4I10F22 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, X, Z); }
        public readonly Vector4I10F22 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Y, X); }
        public readonly Vector4I10F22 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Y, Y); }
        public readonly Vector4I10F22 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Y, Z); }
        public readonly Vector4I10F22 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Z, X); }
        public readonly Vector4I10F22 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Z, Y); }
        public readonly Vector4I10F22 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Z, Z); }
        public readonly Vector4I10F22 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, X, X); }
        public readonly Vector4I10F22 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, X, Y); }
        public readonly Vector4I10F22 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, X, Z); }
        public readonly Vector4I10F22 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Y, X); }
        public readonly Vector4I10F22 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Y, Y); }
        public readonly Vector4I10F22 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Y, Z); }
        public readonly Vector4I10F22 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Z, X); }
        public readonly Vector4I10F22 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Z, Y); }
        public readonly Vector4I10F22 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Z, Z); }
        public readonly Vector4I10F22 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, X, X); }
        public readonly Vector4I10F22 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, X, Y); }
        public readonly Vector4I10F22 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, X, Z); }
        public readonly Vector4I10F22 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Y, X); }
        public readonly Vector4I10F22 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Y, Y); }
        public readonly Vector4I10F22 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Y, Z); }
        public readonly Vector4I10F22 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Z, X); }
        public readonly Vector4I10F22 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Z, Y); }
        public readonly Vector4I10F22 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Z, Z); }
        public readonly Vector4I10F22 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, X, X); }
        public readonly Vector4I10F22 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, X, Y); }
        public readonly Vector4I10F22 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, X, Z); }
        public readonly Vector4I10F22 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Y, X); }
        public readonly Vector4I10F22 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Y, Y); }
        public readonly Vector4I10F22 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Y, Z); }
        public readonly Vector4I10F22 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Z, X); }
        public readonly Vector4I10F22 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Z, Y); }
        public readonly Vector4I10F22 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Z, Z); }
        public readonly Vector4I10F22 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, X, X); }
        public readonly Vector4I10F22 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, X, Y); }
        public readonly Vector4I10F22 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, X, Z); }
        public readonly Vector4I10F22 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Y, X); }
        public readonly Vector4I10F22 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Y, Y); }
        public readonly Vector4I10F22 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Y, Z); }
        public readonly Vector4I10F22 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Z, X); }
        public readonly Vector4I10F22 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Z, Y); }
        public readonly Vector4I10F22 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Z, Z); }
        public readonly Vector4I10F22 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, X, X); }
        public readonly Vector4I10F22 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, X, Y); }
        public readonly Vector4I10F22 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, X, Z); }
        public readonly Vector4I10F22 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Y, X); }
        public readonly Vector4I10F22 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Y, Y); }
        public readonly Vector4I10F22 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Y, Z); }
        public readonly Vector4I10F22 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Z, X); }
        public readonly Vector4I10F22 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Z, Y); }
        public readonly Vector4I10F22 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Z, Z); }
        public readonly Vector4I10F22 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, X, X); }
        public readonly Vector4I10F22 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, X, Y); }
        public readonly Vector4I10F22 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, X, Z); }
        public readonly Vector4I10F22 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Y, X); }
        public readonly Vector4I10F22 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Y, Y); }
        public readonly Vector4I10F22 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Y, Z); }
        public readonly Vector4I10F22 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Z, X); }
        public readonly Vector4I10F22 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Z, Y); }
        public readonly Vector4I10F22 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Z, Z); }
        public readonly Vector4I10F22 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, X, X); }
        public readonly Vector4I10F22 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, X, Y); }
        public readonly Vector4I10F22 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, X, Z); }
        public readonly Vector4I10F22 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Y, X); }
        public readonly Vector4I10F22 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Y, Y); }
        public readonly Vector4I10F22 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Y, Z); }
        public readonly Vector4I10F22 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Z, X); }
        public readonly Vector4I10F22 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Z, Y); }
        public readonly Vector4I10F22 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Z, Z); }
        public readonly Vector4I10F22 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, X, X); }
        public readonly Vector4I10F22 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, X, Y); }
        public readonly Vector4I10F22 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, X, Z); }
        public readonly Vector4I10F22 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Y, X); }
        public readonly Vector4I10F22 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Y, Y); }
        public readonly Vector4I10F22 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Y, Z); }
        public readonly Vector4I10F22 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Z, X); }
        public readonly Vector4I10F22 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Z, Y); }
        public readonly Vector4I10F22 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I10F22 lhs, Vector3I10F22 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I10F22 lhs, Vector3I10F22 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I10F22 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I10F22({X}, {Y}, {Z})";

        // IEquatable<Vector3I10F22>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I10F22 other)
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
            return $"Vector3I10F22({x}, {y}, {z})";
        }
    }
}
