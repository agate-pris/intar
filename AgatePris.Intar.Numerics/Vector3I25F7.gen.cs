using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I25F7 : IEquatable<Vector3I25F7>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I25F7 X;
        public I25F7 Y;
        public I25F7 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I25F7(I25F7 x, I25F7 y, I25F7 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I25F7(I25F7 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I25F7(I25F7 x, Vector2I25F7 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I25F7(Vector3I25F7 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I25F7(Vector2I25F7 xy, I25F7 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I25F7 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I25F7(I25F7.Zero);
        }
        public static Vector3I25F7 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I25F7(I25F7.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator +(Vector3I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator -(Vector3I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator *(Vector3I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator *(Vector3I25F7 a, I25F7 b) => new Vector3I25F7(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator *(I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator /(Vector3I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator /(Vector3I25F7 a, I25F7 b) => new Vector3I25F7(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator /(I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I25F7 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(X, X); }
        public readonly Vector2I25F7 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(X, Y); }
        public readonly Vector2I25F7 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(X, Z); }
        public readonly Vector2I25F7 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(Y, X); }
        public readonly Vector2I25F7 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(Y, Y); }
        public readonly Vector2I25F7 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(Y, Z); }
        public readonly Vector2I25F7 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(Z, X); }
        public readonly Vector2I25F7 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(Z, Y); }
        public readonly Vector2I25F7 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(Z, Z); }
        public readonly Vector3I25F7 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, X, X); }
        public readonly Vector3I25F7 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, X, Y); }
        public readonly Vector3I25F7 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, X, Z); }
        public readonly Vector3I25F7 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, Y, X); }
        public readonly Vector3I25F7 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, Y, Y); }
        public readonly Vector3I25F7 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, Y, Z); }
        public readonly Vector3I25F7 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, Z, X); }
        public readonly Vector3I25F7 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, Z, Y); }
        public readonly Vector3I25F7 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, Z, Z); }
        public readonly Vector3I25F7 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, X, X); }
        public readonly Vector3I25F7 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, X, Y); }
        public readonly Vector3I25F7 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, X, Z); }
        public readonly Vector3I25F7 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, Y, X); }
        public readonly Vector3I25F7 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, Y, Y); }
        public readonly Vector3I25F7 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, Y, Z); }
        public readonly Vector3I25F7 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, Z, X); }
        public readonly Vector3I25F7 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, Z, Y); }
        public readonly Vector3I25F7 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, Z, Z); }
        public readonly Vector3I25F7 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Z, X, X); }
        public readonly Vector3I25F7 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Z, X, Y); }
        public readonly Vector3I25F7 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Z, X, Z); }
        public readonly Vector3I25F7 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Z, Y, X); }
        public readonly Vector3I25F7 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Z, Y, Y); }
        public readonly Vector3I25F7 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Z, Y, Z); }
        public readonly Vector3I25F7 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Z, Z, X); }
        public readonly Vector3I25F7 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Z, Z, Y); }
        public readonly Vector3I25F7 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Z, Z, Z); }
        public readonly Vector4I25F7 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, X, X); }
        public readonly Vector4I25F7 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, X, Y); }
        public readonly Vector4I25F7 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, X, Z); }
        public readonly Vector4I25F7 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, Y, X); }
        public readonly Vector4I25F7 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, Y, Y); }
        public readonly Vector4I25F7 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, Y, Z); }
        public readonly Vector4I25F7 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, Z, X); }
        public readonly Vector4I25F7 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, Z, Y); }
        public readonly Vector4I25F7 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, Z, Z); }
        public readonly Vector4I25F7 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, X, X); }
        public readonly Vector4I25F7 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, X, Y); }
        public readonly Vector4I25F7 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, X, Z); }
        public readonly Vector4I25F7 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, Y, X); }
        public readonly Vector4I25F7 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, Y, Y); }
        public readonly Vector4I25F7 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, Y, Z); }
        public readonly Vector4I25F7 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, Z, X); }
        public readonly Vector4I25F7 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, Z, Y); }
        public readonly Vector4I25F7 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, Z, Z); }
        public readonly Vector4I25F7 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Z, X, X); }
        public readonly Vector4I25F7 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Z, X, Y); }
        public readonly Vector4I25F7 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Z, X, Z); }
        public readonly Vector4I25F7 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Z, Y, X); }
        public readonly Vector4I25F7 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Z, Y, Y); }
        public readonly Vector4I25F7 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Z, Y, Z); }
        public readonly Vector4I25F7 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Z, Z, X); }
        public readonly Vector4I25F7 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Z, Z, Y); }
        public readonly Vector4I25F7 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Z, Z, Z); }
        public readonly Vector4I25F7 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, X, X); }
        public readonly Vector4I25F7 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, X, Y); }
        public readonly Vector4I25F7 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, X, Z); }
        public readonly Vector4I25F7 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, Y, X); }
        public readonly Vector4I25F7 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, Y, Y); }
        public readonly Vector4I25F7 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, Y, Z); }
        public readonly Vector4I25F7 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, Z, X); }
        public readonly Vector4I25F7 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, Z, Y); }
        public readonly Vector4I25F7 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, Z, Z); }
        public readonly Vector4I25F7 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, X, X); }
        public readonly Vector4I25F7 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, X, Y); }
        public readonly Vector4I25F7 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, X, Z); }
        public readonly Vector4I25F7 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, Y, X); }
        public readonly Vector4I25F7 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, Y, Y); }
        public readonly Vector4I25F7 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, Y, Z); }
        public readonly Vector4I25F7 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, Z, X); }
        public readonly Vector4I25F7 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, Z, Y); }
        public readonly Vector4I25F7 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, Z, Z); }
        public readonly Vector4I25F7 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Z, X, X); }
        public readonly Vector4I25F7 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Z, X, Y); }
        public readonly Vector4I25F7 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Z, X, Z); }
        public readonly Vector4I25F7 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Z, Y, X); }
        public readonly Vector4I25F7 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Z, Y, Y); }
        public readonly Vector4I25F7 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Z, Y, Z); }
        public readonly Vector4I25F7 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Z, Z, X); }
        public readonly Vector4I25F7 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Z, Z, Y); }
        public readonly Vector4I25F7 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Z, Z, Z); }
        public readonly Vector4I25F7 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, X, X, X); }
        public readonly Vector4I25F7 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, X, X, Y); }
        public readonly Vector4I25F7 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, X, X, Z); }
        public readonly Vector4I25F7 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, X, Y, X); }
        public readonly Vector4I25F7 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, X, Y, Y); }
        public readonly Vector4I25F7 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, X, Y, Z); }
        public readonly Vector4I25F7 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, X, Z, X); }
        public readonly Vector4I25F7 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, X, Z, Y); }
        public readonly Vector4I25F7 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, X, Z, Z); }
        public readonly Vector4I25F7 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Y, X, X); }
        public readonly Vector4I25F7 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Y, X, Y); }
        public readonly Vector4I25F7 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Y, X, Z); }
        public readonly Vector4I25F7 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Y, Y, X); }
        public readonly Vector4I25F7 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Y, Y, Y); }
        public readonly Vector4I25F7 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Y, Y, Z); }
        public readonly Vector4I25F7 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Y, Z, X); }
        public readonly Vector4I25F7 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Y, Z, Y); }
        public readonly Vector4I25F7 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Y, Z, Z); }
        public readonly Vector4I25F7 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Z, X, X); }
        public readonly Vector4I25F7 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Z, X, Y); }
        public readonly Vector4I25F7 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Z, X, Z); }
        public readonly Vector4I25F7 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Z, Y, X); }
        public readonly Vector4I25F7 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Z, Y, Y); }
        public readonly Vector4I25F7 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Z, Y, Z); }
        public readonly Vector4I25F7 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Z, Z, X); }
        public readonly Vector4I25F7 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Z, Z, Y); }
        public readonly Vector4I25F7 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Z, Z, Z, Z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I25F7 lhs, Vector3I25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I25F7 lhs, Vector3I25F7 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I25F7({X}, {Y}, {Z})";

        // IEquatable<Vector3I25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I25F7 other)
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
            return $"Vector3I25F7({x}, {y}, {z})";
        }
    }
}
