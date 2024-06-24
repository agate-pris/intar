using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I23F9 : IEquatable<Vector3I23F9>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I23F9 X;
        public I23F9 Y;
        public I23F9 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I23F9(I23F9 x, I23F9 y, I23F9 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I23F9(I23F9 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I23F9(I23F9 x, Vector2I23F9 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I23F9(Vector3I23F9 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I23F9(Vector2I23F9 xy, I23F9 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I23F9 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I23F9(I23F9.Zero);
        }
        public static Vector3I23F9 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I23F9(I23F9.One);
        }
        public static Vector3I23F9 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I23F9(I23F9.One, I23F9.Zero, I23F9.Zero);
        }
        public static Vector3I23F9 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I23F9(I23F9.Zero, I23F9.One, I23F9.Zero);
        }
        public static Vector3I23F9 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I23F9(I23F9.Zero, I23F9.Zero, I23F9.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 operator +(Vector3I23F9 a, Vector3I23F9 b) => new Vector3I23F9(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 operator -(Vector3I23F9 a, Vector3I23F9 b) => new Vector3I23F9(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 operator *(Vector3I23F9 a, Vector3I23F9 b) => new Vector3I23F9(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 operator *(Vector3I23F9 a, I23F9 b) => new Vector3I23F9(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 operator *(I23F9 a, Vector3I23F9 b) => new Vector3I23F9(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 operator /(Vector3I23F9 a, Vector3I23F9 b) => new Vector3I23F9(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 operator /(Vector3I23F9 a, I23F9 b) => new Vector3I23F9(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 operator /(I23F9 a, Vector3I23F9 b) => new Vector3I23F9(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I23F9 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(X, X); }
        public readonly Vector2I23F9 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(X, Y); }
        public readonly Vector2I23F9 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(X, Z); }
        public readonly Vector2I23F9 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Y, X); }
        public readonly Vector2I23F9 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Y, Y); }
        public readonly Vector2I23F9 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Y, Z); }
        public readonly Vector2I23F9 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Z, X); }
        public readonly Vector2I23F9 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Z, Y); }
        public readonly Vector2I23F9 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Z, Z); }
        public readonly Vector3I23F9 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, X, X); }
        public readonly Vector3I23F9 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, X, Y); }
        public readonly Vector3I23F9 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, X, Z); }
        public readonly Vector3I23F9 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Y, X); }
        public readonly Vector3I23F9 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Y, Y); }
        public readonly Vector3I23F9 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Y, Z); }
        public readonly Vector3I23F9 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Z, X); }
        public readonly Vector3I23F9 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Z, Y); }
        public readonly Vector3I23F9 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Z, Z); }
        public readonly Vector3I23F9 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, X, X); }
        public readonly Vector3I23F9 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, X, Y); }
        public readonly Vector3I23F9 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, X, Z); }
        public readonly Vector3I23F9 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Y, X); }
        public readonly Vector3I23F9 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Y, Y); }
        public readonly Vector3I23F9 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Y, Z); }
        public readonly Vector3I23F9 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Z, X); }
        public readonly Vector3I23F9 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Z, Y); }
        public readonly Vector3I23F9 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Z, Z); }
        public readonly Vector3I23F9 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, X, X); }
        public readonly Vector3I23F9 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, X, Y); }
        public readonly Vector3I23F9 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, X, Z); }
        public readonly Vector3I23F9 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Y, X); }
        public readonly Vector3I23F9 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Y, Y); }
        public readonly Vector3I23F9 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Y, Z); }
        public readonly Vector3I23F9 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Z, X); }
        public readonly Vector3I23F9 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Z, Y); }
        public readonly Vector3I23F9 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Z, Z); }
        public readonly Vector4I23F9 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, X, X); }
        public readonly Vector4I23F9 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, X, Y); }
        public readonly Vector4I23F9 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, X, Z); }
        public readonly Vector4I23F9 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Y, X); }
        public readonly Vector4I23F9 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Y, Y); }
        public readonly Vector4I23F9 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Y, Z); }
        public readonly Vector4I23F9 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Z, X); }
        public readonly Vector4I23F9 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Z, Y); }
        public readonly Vector4I23F9 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Z, Z); }
        public readonly Vector4I23F9 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, X, X); }
        public readonly Vector4I23F9 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, X, Y); }
        public readonly Vector4I23F9 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, X, Z); }
        public readonly Vector4I23F9 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Y, X); }
        public readonly Vector4I23F9 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Y, Y); }
        public readonly Vector4I23F9 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Y, Z); }
        public readonly Vector4I23F9 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Z, X); }
        public readonly Vector4I23F9 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Z, Y); }
        public readonly Vector4I23F9 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Z, Z); }
        public readonly Vector4I23F9 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, X, X); }
        public readonly Vector4I23F9 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, X, Y); }
        public readonly Vector4I23F9 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, X, Z); }
        public readonly Vector4I23F9 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Y, X); }
        public readonly Vector4I23F9 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Y, Y); }
        public readonly Vector4I23F9 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Y, Z); }
        public readonly Vector4I23F9 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Z, X); }
        public readonly Vector4I23F9 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Z, Y); }
        public readonly Vector4I23F9 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Z, Z); }
        public readonly Vector4I23F9 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, X, X); }
        public readonly Vector4I23F9 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, X, Y); }
        public readonly Vector4I23F9 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, X, Z); }
        public readonly Vector4I23F9 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Y, X); }
        public readonly Vector4I23F9 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Y, Y); }
        public readonly Vector4I23F9 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Y, Z); }
        public readonly Vector4I23F9 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Z, X); }
        public readonly Vector4I23F9 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Z, Y); }
        public readonly Vector4I23F9 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Z, Z); }
        public readonly Vector4I23F9 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, X, X); }
        public readonly Vector4I23F9 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, X, Y); }
        public readonly Vector4I23F9 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, X, Z); }
        public readonly Vector4I23F9 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Y, X); }
        public readonly Vector4I23F9 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Y, Y); }
        public readonly Vector4I23F9 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Y, Z); }
        public readonly Vector4I23F9 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Z, X); }
        public readonly Vector4I23F9 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Z, Y); }
        public readonly Vector4I23F9 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Z, Z); }
        public readonly Vector4I23F9 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, X, X); }
        public readonly Vector4I23F9 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, X, Y); }
        public readonly Vector4I23F9 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, X, Z); }
        public readonly Vector4I23F9 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Y, X); }
        public readonly Vector4I23F9 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Y, Y); }
        public readonly Vector4I23F9 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Y, Z); }
        public readonly Vector4I23F9 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Z, X); }
        public readonly Vector4I23F9 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Z, Y); }
        public readonly Vector4I23F9 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Z, Z); }
        public readonly Vector4I23F9 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, X, X); }
        public readonly Vector4I23F9 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, X, Y); }
        public readonly Vector4I23F9 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, X, Z); }
        public readonly Vector4I23F9 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Y, X); }
        public readonly Vector4I23F9 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Y, Y); }
        public readonly Vector4I23F9 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Y, Z); }
        public readonly Vector4I23F9 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Z, X); }
        public readonly Vector4I23F9 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Z, Y); }
        public readonly Vector4I23F9 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Z, Z); }
        public readonly Vector4I23F9 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, X, X); }
        public readonly Vector4I23F9 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, X, Y); }
        public readonly Vector4I23F9 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, X, Z); }
        public readonly Vector4I23F9 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Y, X); }
        public readonly Vector4I23F9 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Y, Y); }
        public readonly Vector4I23F9 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Y, Z); }
        public readonly Vector4I23F9 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Z, X); }
        public readonly Vector4I23F9 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Z, Y); }
        public readonly Vector4I23F9 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Z, Z); }
        public readonly Vector4I23F9 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, X, X); }
        public readonly Vector4I23F9 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, X, Y); }
        public readonly Vector4I23F9 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, X, Z); }
        public readonly Vector4I23F9 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Y, X); }
        public readonly Vector4I23F9 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Y, Y); }
        public readonly Vector4I23F9 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Y, Z); }
        public readonly Vector4I23F9 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Z, X); }
        public readonly Vector4I23F9 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Z, Y); }
        public readonly Vector4I23F9 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I23F9 lhs, Vector3I23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I23F9 lhs, Vector3I23F9 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I23F9({X}, {Y}, {Z})";

        // IEquatable<Vector3I23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I23F9 other)
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
            return $"Vector3I23F9({x}, {y}, {z})";
        }
    }
}
