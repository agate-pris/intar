using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I30F2 : IEquatable<Vector3I30F2>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I30F2 X;
        public I30F2 Y;
        public I30F2 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 x, I30F2 y, I30F2 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 x, Vector2I30F2 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(Vector3I30F2 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(Vector2I30F2 xy, I30F2 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I30F2 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.Zero);
        }
        public static Vector3I30F2 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.One);
        }
        public static Vector3I30F2 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.One, I30F2.Zero, I30F2.Zero);
        }
        public static Vector3I30F2 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.Zero, I30F2.One, I30F2.Zero);
        }
        public static Vector3I30F2 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.Zero, I30F2.Zero, I30F2.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator +(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator -(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(Vector3I30F2 a, I30F2 b) => new Vector3I30F2(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(Vector3I30F2 a, I30F2 b) => new Vector3I30F2(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I30F2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(X, X); }
        public readonly Vector2I30F2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(X, Y); }
        public readonly Vector2I30F2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(X, Z); }
        public readonly Vector2I30F2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Y, X); }
        public readonly Vector2I30F2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Y, Y); }
        public readonly Vector2I30F2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Y, Z); }
        public readonly Vector2I30F2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Z, X); }
        public readonly Vector2I30F2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Z, Y); }
        public readonly Vector2I30F2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Z, Z); }
        public readonly Vector3I30F2 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, X, X); }
        public readonly Vector3I30F2 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, X, Y); }
        public readonly Vector3I30F2 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, X, Z); }
        public readonly Vector3I30F2 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Y, X); }
        public readonly Vector3I30F2 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Y, Y); }
        public readonly Vector3I30F2 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Y, Z); }
        public readonly Vector3I30F2 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Z, X); }
        public readonly Vector3I30F2 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Z, Y); }
        public readonly Vector3I30F2 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Z, Z); }
        public readonly Vector3I30F2 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, X, X); }
        public readonly Vector3I30F2 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, X, Y); }
        public readonly Vector3I30F2 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, X, Z); }
        public readonly Vector3I30F2 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Y, X); }
        public readonly Vector3I30F2 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Y, Y); }
        public readonly Vector3I30F2 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Y, Z); }
        public readonly Vector3I30F2 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Z, X); }
        public readonly Vector3I30F2 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Z, Y); }
        public readonly Vector3I30F2 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Z, Z); }
        public readonly Vector3I30F2 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, X, X); }
        public readonly Vector3I30F2 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, X, Y); }
        public readonly Vector3I30F2 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, X, Z); }
        public readonly Vector3I30F2 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Y, X); }
        public readonly Vector3I30F2 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Y, Y); }
        public readonly Vector3I30F2 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Y, Z); }
        public readonly Vector3I30F2 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Z, X); }
        public readonly Vector3I30F2 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Z, Y); }
        public readonly Vector3I30F2 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Z, Z); }
        public readonly Vector4I30F2 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, X, X); }
        public readonly Vector4I30F2 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, X, Y); }
        public readonly Vector4I30F2 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, X, Z); }
        public readonly Vector4I30F2 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Y, X); }
        public readonly Vector4I30F2 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Y, Y); }
        public readonly Vector4I30F2 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Y, Z); }
        public readonly Vector4I30F2 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Z, X); }
        public readonly Vector4I30F2 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Z, Y); }
        public readonly Vector4I30F2 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Z, Z); }
        public readonly Vector4I30F2 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, X, X); }
        public readonly Vector4I30F2 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, X, Y); }
        public readonly Vector4I30F2 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, X, Z); }
        public readonly Vector4I30F2 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Y, X); }
        public readonly Vector4I30F2 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Y, Y); }
        public readonly Vector4I30F2 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Y, Z); }
        public readonly Vector4I30F2 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Z, X); }
        public readonly Vector4I30F2 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Z, Y); }
        public readonly Vector4I30F2 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Z, Z); }
        public readonly Vector4I30F2 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, X, X); }
        public readonly Vector4I30F2 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, X, Y); }
        public readonly Vector4I30F2 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, X, Z); }
        public readonly Vector4I30F2 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Y, X); }
        public readonly Vector4I30F2 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Y, Y); }
        public readonly Vector4I30F2 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Y, Z); }
        public readonly Vector4I30F2 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Z, X); }
        public readonly Vector4I30F2 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Z, Y); }
        public readonly Vector4I30F2 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Z, Z); }
        public readonly Vector4I30F2 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, X, X); }
        public readonly Vector4I30F2 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, X, Y); }
        public readonly Vector4I30F2 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, X, Z); }
        public readonly Vector4I30F2 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Y, X); }
        public readonly Vector4I30F2 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Y, Y); }
        public readonly Vector4I30F2 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Y, Z); }
        public readonly Vector4I30F2 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Z, X); }
        public readonly Vector4I30F2 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Z, Y); }
        public readonly Vector4I30F2 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Z, Z); }
        public readonly Vector4I30F2 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, X, X); }
        public readonly Vector4I30F2 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, X, Y); }
        public readonly Vector4I30F2 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, X, Z); }
        public readonly Vector4I30F2 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Y, X); }
        public readonly Vector4I30F2 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Y, Y); }
        public readonly Vector4I30F2 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Y, Z); }
        public readonly Vector4I30F2 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Z, X); }
        public readonly Vector4I30F2 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Z, Y); }
        public readonly Vector4I30F2 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Z, Z); }
        public readonly Vector4I30F2 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, X, X); }
        public readonly Vector4I30F2 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, X, Y); }
        public readonly Vector4I30F2 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, X, Z); }
        public readonly Vector4I30F2 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Y, X); }
        public readonly Vector4I30F2 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Y, Y); }
        public readonly Vector4I30F2 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Y, Z); }
        public readonly Vector4I30F2 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Z, X); }
        public readonly Vector4I30F2 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Z, Y); }
        public readonly Vector4I30F2 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Z, Z); }
        public readonly Vector4I30F2 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, X, X); }
        public readonly Vector4I30F2 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, X, Y); }
        public readonly Vector4I30F2 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, X, Z); }
        public readonly Vector4I30F2 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Y, X); }
        public readonly Vector4I30F2 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Y, Y); }
        public readonly Vector4I30F2 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Y, Z); }
        public readonly Vector4I30F2 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Z, X); }
        public readonly Vector4I30F2 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Z, Y); }
        public readonly Vector4I30F2 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Z, Z); }
        public readonly Vector4I30F2 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, X, X); }
        public readonly Vector4I30F2 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, X, Y); }
        public readonly Vector4I30F2 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, X, Z); }
        public readonly Vector4I30F2 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Y, X); }
        public readonly Vector4I30F2 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Y, Y); }
        public readonly Vector4I30F2 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Y, Z); }
        public readonly Vector4I30F2 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Z, X); }
        public readonly Vector4I30F2 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Z, Y); }
        public readonly Vector4I30F2 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Z, Z); }
        public readonly Vector4I30F2 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, X, X); }
        public readonly Vector4I30F2 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, X, Y); }
        public readonly Vector4I30F2 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, X, Z); }
        public readonly Vector4I30F2 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Y, X); }
        public readonly Vector4I30F2 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Y, Y); }
        public readonly Vector4I30F2 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Y, Z); }
        public readonly Vector4I30F2 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Z, X); }
        public readonly Vector4I30F2 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Z, Y); }
        public readonly Vector4I30F2 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I30F2 lhs, Vector3I30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I30F2 lhs, Vector3I30F2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I30F2({X}, {Y}, {Z})";

        // IEquatable<Vector3I30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I30F2 other)
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
            return $"Vector3I30F2({x}, {y}, {z})";
        }
    }
}
