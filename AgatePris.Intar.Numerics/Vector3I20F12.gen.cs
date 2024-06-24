using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I20F12 : IEquatable<Vector3I20F12>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I20F12 X;
        public I20F12 Y;
        public I20F12 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I20F12(I20F12 x, I20F12 y, I20F12 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I20F12(I20F12 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I20F12(I20F12 x, Vector2I20F12 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I20F12(Vector3I20F12 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I20F12(Vector2I20F12 xy, I20F12 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I20F12 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I20F12(I20F12.Zero);
        }
        public static Vector3I20F12 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I20F12(I20F12.One);
        }
        public static Vector3I20F12 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I20F12(I20F12.One, I20F12.Zero, I20F12.Zero);
        }
        public static Vector3I20F12 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I20F12(I20F12.Zero, I20F12.One, I20F12.Zero);
        }
        public static Vector3I20F12 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I20F12(I20F12.Zero, I20F12.Zero, I20F12.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator +(Vector3I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator -(Vector3I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator *(Vector3I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator *(Vector3I20F12 a, I20F12 b) => new Vector3I20F12(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator *(I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator /(Vector3I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator /(Vector3I20F12 a, I20F12 b) => new Vector3I20F12(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator /(I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I20F12 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, X); }
        public readonly Vector2I20F12 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, Y); }
        public readonly Vector2I20F12 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, Z); }
        public readonly Vector2I20F12 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, X); }
        public readonly Vector2I20F12 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, Y); }
        public readonly Vector2I20F12 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, Z); }
        public readonly Vector2I20F12 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Z, X); }
        public readonly Vector2I20F12 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Z, Y); }
        public readonly Vector2I20F12 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Z, Z); }
        public readonly Vector3I20F12 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, X); }
        public readonly Vector3I20F12 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, Y); }
        public readonly Vector3I20F12 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, Z); }
        public readonly Vector3I20F12 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, X); }
        public readonly Vector3I20F12 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, Y); }
        public readonly Vector3I20F12 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, Z); }
        public readonly Vector3I20F12 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Z, X); }
        public readonly Vector3I20F12 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Z, Y); }
        public readonly Vector3I20F12 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Z, Z); }
        public readonly Vector3I20F12 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, X); }
        public readonly Vector3I20F12 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, Y); }
        public readonly Vector3I20F12 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, Z); }
        public readonly Vector3I20F12 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, X); }
        public readonly Vector3I20F12 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, Y); }
        public readonly Vector3I20F12 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, Z); }
        public readonly Vector3I20F12 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Z, X); }
        public readonly Vector3I20F12 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Z, Y); }
        public readonly Vector3I20F12 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Z, Z); }
        public readonly Vector3I20F12 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, X, X); }
        public readonly Vector3I20F12 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, X, Y); }
        public readonly Vector3I20F12 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, X, Z); }
        public readonly Vector3I20F12 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Y, X); }
        public readonly Vector3I20F12 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Y, Y); }
        public readonly Vector3I20F12 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Y, Z); }
        public readonly Vector3I20F12 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Z, X); }
        public readonly Vector3I20F12 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Z, Y); }
        public readonly Vector3I20F12 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Z, Z); }
        public readonly Vector4I20F12 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, X); }
        public readonly Vector4I20F12 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, Y); }
        public readonly Vector4I20F12 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, Z); }
        public readonly Vector4I20F12 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, X); }
        public readonly Vector4I20F12 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, Y); }
        public readonly Vector4I20F12 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, Z); }
        public readonly Vector4I20F12 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Z, X); }
        public readonly Vector4I20F12 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Z, Y); }
        public readonly Vector4I20F12 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Z, Z); }
        public readonly Vector4I20F12 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, X); }
        public readonly Vector4I20F12 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, Y); }
        public readonly Vector4I20F12 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, Z); }
        public readonly Vector4I20F12 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, X); }
        public readonly Vector4I20F12 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, Y); }
        public readonly Vector4I20F12 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, Z); }
        public readonly Vector4I20F12 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Z, X); }
        public readonly Vector4I20F12 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Z, Y); }
        public readonly Vector4I20F12 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Z, Z); }
        public readonly Vector4I20F12 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, X, X); }
        public readonly Vector4I20F12 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, X, Y); }
        public readonly Vector4I20F12 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, X, Z); }
        public readonly Vector4I20F12 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Y, X); }
        public readonly Vector4I20F12 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Y, Y); }
        public readonly Vector4I20F12 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Y, Z); }
        public readonly Vector4I20F12 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Z, X); }
        public readonly Vector4I20F12 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Z, Y); }
        public readonly Vector4I20F12 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Z, Z); }
        public readonly Vector4I20F12 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, X); }
        public readonly Vector4I20F12 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, Y); }
        public readonly Vector4I20F12 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, Z); }
        public readonly Vector4I20F12 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, X); }
        public readonly Vector4I20F12 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, Y); }
        public readonly Vector4I20F12 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, Z); }
        public readonly Vector4I20F12 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Z, X); }
        public readonly Vector4I20F12 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Z, Y); }
        public readonly Vector4I20F12 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Z, Z); }
        public readonly Vector4I20F12 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, X); }
        public readonly Vector4I20F12 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, Y); }
        public readonly Vector4I20F12 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, Z); }
        public readonly Vector4I20F12 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, X); }
        public readonly Vector4I20F12 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, Y); }
        public readonly Vector4I20F12 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, Z); }
        public readonly Vector4I20F12 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Z, X); }
        public readonly Vector4I20F12 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Z, Y); }
        public readonly Vector4I20F12 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Z, Z); }
        public readonly Vector4I20F12 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, X, X); }
        public readonly Vector4I20F12 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, X, Y); }
        public readonly Vector4I20F12 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, X, Z); }
        public readonly Vector4I20F12 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Y, X); }
        public readonly Vector4I20F12 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Y, Y); }
        public readonly Vector4I20F12 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Y, Z); }
        public readonly Vector4I20F12 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Z, X); }
        public readonly Vector4I20F12 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Z, Y); }
        public readonly Vector4I20F12 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Z, Z); }
        public readonly Vector4I20F12 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, X, X); }
        public readonly Vector4I20F12 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, X, Y); }
        public readonly Vector4I20F12 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, X, Z); }
        public readonly Vector4I20F12 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Y, X); }
        public readonly Vector4I20F12 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Y, Y); }
        public readonly Vector4I20F12 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Y, Z); }
        public readonly Vector4I20F12 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Z, X); }
        public readonly Vector4I20F12 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Z, Y); }
        public readonly Vector4I20F12 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Z, Z); }
        public readonly Vector4I20F12 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, X, X); }
        public readonly Vector4I20F12 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, X, Y); }
        public readonly Vector4I20F12 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, X, Z); }
        public readonly Vector4I20F12 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Y, X); }
        public readonly Vector4I20F12 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Y, Y); }
        public readonly Vector4I20F12 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Y, Z); }
        public readonly Vector4I20F12 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Z, X); }
        public readonly Vector4I20F12 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Z, Y); }
        public readonly Vector4I20F12 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Z, Z); }
        public readonly Vector4I20F12 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, X, X); }
        public readonly Vector4I20F12 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, X, Y); }
        public readonly Vector4I20F12 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, X, Z); }
        public readonly Vector4I20F12 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Y, X); }
        public readonly Vector4I20F12 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Y, Y); }
        public readonly Vector4I20F12 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Y, Z); }
        public readonly Vector4I20F12 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Z, X); }
        public readonly Vector4I20F12 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Z, Y); }
        public readonly Vector4I20F12 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I20F12 lhs, Vector3I20F12 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I20F12 lhs, Vector3I20F12 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I20F12 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I20F12({X}, {Y}, {Z})";

        // IEquatable<Vector3I20F12>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I20F12 other)
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
            return $"Vector3I20F12({x}, {y}, {z})";
        }
    }
}
