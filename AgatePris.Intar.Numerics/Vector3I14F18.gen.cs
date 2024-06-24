using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I14F18 : IEquatable<Vector3I14F18>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I14F18 X;
        public I14F18 Y;
        public I14F18 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I14F18(I14F18 x, I14F18 y, I14F18 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I14F18(I14F18 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I14F18(I14F18 x, Vector2I14F18 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I14F18(Vector3I14F18 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I14F18(Vector2I14F18 xy, I14F18 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I14F18 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I14F18(I14F18.Zero);
        }
        public static Vector3I14F18 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I14F18(I14F18.One);
        }
        public static Vector3I14F18 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I14F18(I14F18.One, I14F18.Zero, I14F18.Zero);
        }
        public static Vector3I14F18 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I14F18(I14F18.Zero, I14F18.One, I14F18.Zero);
        }
        public static Vector3I14F18 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I14F18(I14F18.Zero, I14F18.Zero, I14F18.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator +(Vector3I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator -(Vector3I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator *(Vector3I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator *(Vector3I14F18 a, I14F18 b) => new Vector3I14F18(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator *(I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator /(Vector3I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator /(Vector3I14F18 a, I14F18 b) => new Vector3I14F18(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator /(I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I14F18 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, X); }
        public readonly Vector2I14F18 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, Y); }
        public readonly Vector2I14F18 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, Z); }
        public readonly Vector2I14F18 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, X); }
        public readonly Vector2I14F18 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, Y); }
        public readonly Vector2I14F18 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, Z); }
        public readonly Vector2I14F18 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Z, X); }
        public readonly Vector2I14F18 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Z, Y); }
        public readonly Vector2I14F18 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Z, Z); }
        public readonly Vector3I14F18 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, X); }
        public readonly Vector3I14F18 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, Y); }
        public readonly Vector3I14F18 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, Z); }
        public readonly Vector3I14F18 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, X); }
        public readonly Vector3I14F18 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, Y); }
        public readonly Vector3I14F18 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, Z); }
        public readonly Vector3I14F18 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Z, X); }
        public readonly Vector3I14F18 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Z, Y); }
        public readonly Vector3I14F18 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Z, Z); }
        public readonly Vector3I14F18 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, X); }
        public readonly Vector3I14F18 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, Y); }
        public readonly Vector3I14F18 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, Z); }
        public readonly Vector3I14F18 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, X); }
        public readonly Vector3I14F18 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, Y); }
        public readonly Vector3I14F18 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, Z); }
        public readonly Vector3I14F18 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Z, X); }
        public readonly Vector3I14F18 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Z, Y); }
        public readonly Vector3I14F18 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Z, Z); }
        public readonly Vector3I14F18 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, X, X); }
        public readonly Vector3I14F18 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, X, Y); }
        public readonly Vector3I14F18 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, X, Z); }
        public readonly Vector3I14F18 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Y, X); }
        public readonly Vector3I14F18 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Y, Y); }
        public readonly Vector3I14F18 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Y, Z); }
        public readonly Vector3I14F18 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Z, X); }
        public readonly Vector3I14F18 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Z, Y); }
        public readonly Vector3I14F18 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Z, Z); }
        public readonly Vector4I14F18 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, X); }
        public readonly Vector4I14F18 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, Y); }
        public readonly Vector4I14F18 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, Z); }
        public readonly Vector4I14F18 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, X); }
        public readonly Vector4I14F18 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, Y); }
        public readonly Vector4I14F18 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, Z); }
        public readonly Vector4I14F18 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Z, X); }
        public readonly Vector4I14F18 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Z, Y); }
        public readonly Vector4I14F18 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Z, Z); }
        public readonly Vector4I14F18 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, X); }
        public readonly Vector4I14F18 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, Y); }
        public readonly Vector4I14F18 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, Z); }
        public readonly Vector4I14F18 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, X); }
        public readonly Vector4I14F18 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, Y); }
        public readonly Vector4I14F18 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, Z); }
        public readonly Vector4I14F18 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Z, X); }
        public readonly Vector4I14F18 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Z, Y); }
        public readonly Vector4I14F18 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Z, Z); }
        public readonly Vector4I14F18 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, X, X); }
        public readonly Vector4I14F18 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, X, Y); }
        public readonly Vector4I14F18 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, X, Z); }
        public readonly Vector4I14F18 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Y, X); }
        public readonly Vector4I14F18 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Y, Y); }
        public readonly Vector4I14F18 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Y, Z); }
        public readonly Vector4I14F18 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Z, X); }
        public readonly Vector4I14F18 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Z, Y); }
        public readonly Vector4I14F18 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Z, Z); }
        public readonly Vector4I14F18 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, X); }
        public readonly Vector4I14F18 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, Y); }
        public readonly Vector4I14F18 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, Z); }
        public readonly Vector4I14F18 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, X); }
        public readonly Vector4I14F18 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, Y); }
        public readonly Vector4I14F18 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, Z); }
        public readonly Vector4I14F18 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Z, X); }
        public readonly Vector4I14F18 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Z, Y); }
        public readonly Vector4I14F18 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Z, Z); }
        public readonly Vector4I14F18 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, X); }
        public readonly Vector4I14F18 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, Y); }
        public readonly Vector4I14F18 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, Z); }
        public readonly Vector4I14F18 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, X); }
        public readonly Vector4I14F18 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, Y); }
        public readonly Vector4I14F18 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, Z); }
        public readonly Vector4I14F18 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Z, X); }
        public readonly Vector4I14F18 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Z, Y); }
        public readonly Vector4I14F18 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Z, Z); }
        public readonly Vector4I14F18 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, X, X); }
        public readonly Vector4I14F18 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, X, Y); }
        public readonly Vector4I14F18 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, X, Z); }
        public readonly Vector4I14F18 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Y, X); }
        public readonly Vector4I14F18 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Y, Y); }
        public readonly Vector4I14F18 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Y, Z); }
        public readonly Vector4I14F18 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Z, X); }
        public readonly Vector4I14F18 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Z, Y); }
        public readonly Vector4I14F18 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Z, Z); }
        public readonly Vector4I14F18 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, X, X); }
        public readonly Vector4I14F18 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, X, Y); }
        public readonly Vector4I14F18 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, X, Z); }
        public readonly Vector4I14F18 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Y, X); }
        public readonly Vector4I14F18 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Y, Y); }
        public readonly Vector4I14F18 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Y, Z); }
        public readonly Vector4I14F18 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Z, X); }
        public readonly Vector4I14F18 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Z, Y); }
        public readonly Vector4I14F18 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Z, Z); }
        public readonly Vector4I14F18 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, X, X); }
        public readonly Vector4I14F18 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, X, Y); }
        public readonly Vector4I14F18 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, X, Z); }
        public readonly Vector4I14F18 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Y, X); }
        public readonly Vector4I14F18 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Y, Y); }
        public readonly Vector4I14F18 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Y, Z); }
        public readonly Vector4I14F18 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Z, X); }
        public readonly Vector4I14F18 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Z, Y); }
        public readonly Vector4I14F18 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Z, Z); }
        public readonly Vector4I14F18 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, X, X); }
        public readonly Vector4I14F18 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, X, Y); }
        public readonly Vector4I14F18 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, X, Z); }
        public readonly Vector4I14F18 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Y, X); }
        public readonly Vector4I14F18 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Y, Y); }
        public readonly Vector4I14F18 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Y, Z); }
        public readonly Vector4I14F18 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Z, X); }
        public readonly Vector4I14F18 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Z, Y); }
        public readonly Vector4I14F18 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I14F18 lhs, Vector3I14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I14F18 lhs, Vector3I14F18 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I14F18({X}, {Y}, {Z})";

        // IEquatable<Vector3I14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I14F18 other)
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
            return $"Vector3I14F18({x}, {y}, {z})";
        }
    }
}
