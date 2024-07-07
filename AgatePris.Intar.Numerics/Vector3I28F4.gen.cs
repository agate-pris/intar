using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I28F4 : IEquatable<Vector3I28F4>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I28F4 X;
        public I28F4 Y;
        public I28F4 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I28F4(I28F4 x, I28F4 y, I28F4 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I28F4(I28F4 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I28F4(I28F4 x, Vector2I28F4 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I28F4(Vector3I28F4 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I28F4(Vector2I28F4 xy, I28F4 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I28F4 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I28F4(I28F4.Zero);
        }
        public static Vector3I28F4 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I28F4(I28F4.One);
        }
        public static Vector3I28F4 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I28F4(I28F4.One, I28F4.Zero, I28F4.Zero);
        }
        public static Vector3I28F4 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I28F4(I28F4.Zero, I28F4.One, I28F4.Zero);
        }
        public static Vector3I28F4 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I28F4(I28F4.Zero, I28F4.Zero, I28F4.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator +(Vector3I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator -(Vector3I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator *(Vector3I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator *(Vector3I28F4 a, I28F4 b) => new Vector3I28F4(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator *(I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator /(Vector3I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator /(Vector3I28F4 a, I28F4 b) => new Vector3I28F4(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 operator /(I28F4 a, Vector3I28F4 b) => new Vector3I28F4(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I28F4 lhs, Vector3I28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I28F4 lhs, Vector3I28F4 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I28F4 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, X); }
        public readonly Vector2I28F4 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, Y); }
        public readonly Vector2I28F4 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, Z); }
        public readonly Vector2I28F4 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, X); }
        public readonly Vector2I28F4 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, Y); }
        public readonly Vector2I28F4 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, Z); }
        public readonly Vector2I28F4 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Z, X); }
        public readonly Vector2I28F4 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Z, Y); }
        public readonly Vector2I28F4 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Z, Z); }
        public readonly Vector3I28F4 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, X); }
        public readonly Vector3I28F4 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, Y); }
        public readonly Vector3I28F4 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, Z); }
        public readonly Vector3I28F4 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, X); }
        public readonly Vector3I28F4 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, Y); }
        public readonly Vector3I28F4 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, Z); }
        public readonly Vector3I28F4 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Z, X); }
        public readonly Vector3I28F4 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Z, Y); }
        public readonly Vector3I28F4 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Z, Z); }
        public readonly Vector3I28F4 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, X); }
        public readonly Vector3I28F4 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, Y); }
        public readonly Vector3I28F4 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, Z); }
        public readonly Vector3I28F4 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, X); }
        public readonly Vector3I28F4 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, Y); }
        public readonly Vector3I28F4 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, Z); }
        public readonly Vector3I28F4 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Z, X); }
        public readonly Vector3I28F4 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Z, Y); }
        public readonly Vector3I28F4 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Z, Z); }
        public readonly Vector3I28F4 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, X, X); }
        public readonly Vector3I28F4 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, X, Y); }
        public readonly Vector3I28F4 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, X, Z); }
        public readonly Vector3I28F4 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Y, X); }
        public readonly Vector3I28F4 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Y, Y); }
        public readonly Vector3I28F4 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Y, Z); }
        public readonly Vector3I28F4 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Z, X); }
        public readonly Vector3I28F4 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Z, Y); }
        public readonly Vector3I28F4 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Z, Z); }
        public readonly Vector4I28F4 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, X); }
        public readonly Vector4I28F4 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, Y); }
        public readonly Vector4I28F4 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, Z); }
        public readonly Vector4I28F4 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, X); }
        public readonly Vector4I28F4 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, Y); }
        public readonly Vector4I28F4 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, Z); }
        public readonly Vector4I28F4 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Z, X); }
        public readonly Vector4I28F4 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Z, Y); }
        public readonly Vector4I28F4 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Z, Z); }
        public readonly Vector4I28F4 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, X); }
        public readonly Vector4I28F4 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, Y); }
        public readonly Vector4I28F4 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, Z); }
        public readonly Vector4I28F4 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, X); }
        public readonly Vector4I28F4 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, Y); }
        public readonly Vector4I28F4 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, Z); }
        public readonly Vector4I28F4 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Z, X); }
        public readonly Vector4I28F4 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Z, Y); }
        public readonly Vector4I28F4 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Z, Z); }
        public readonly Vector4I28F4 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, X, X); }
        public readonly Vector4I28F4 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, X, Y); }
        public readonly Vector4I28F4 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, X, Z); }
        public readonly Vector4I28F4 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Y, X); }
        public readonly Vector4I28F4 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Y, Y); }
        public readonly Vector4I28F4 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Y, Z); }
        public readonly Vector4I28F4 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Z, X); }
        public readonly Vector4I28F4 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Z, Y); }
        public readonly Vector4I28F4 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Z, Z); }
        public readonly Vector4I28F4 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, X); }
        public readonly Vector4I28F4 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, Y); }
        public readonly Vector4I28F4 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, Z); }
        public readonly Vector4I28F4 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, X); }
        public readonly Vector4I28F4 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, Y); }
        public readonly Vector4I28F4 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, Z); }
        public readonly Vector4I28F4 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Z, X); }
        public readonly Vector4I28F4 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Z, Y); }
        public readonly Vector4I28F4 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Z, Z); }
        public readonly Vector4I28F4 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, X); }
        public readonly Vector4I28F4 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, Y); }
        public readonly Vector4I28F4 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, Z); }
        public readonly Vector4I28F4 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, X); }
        public readonly Vector4I28F4 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, Y); }
        public readonly Vector4I28F4 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, Z); }
        public readonly Vector4I28F4 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Z, X); }
        public readonly Vector4I28F4 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Z, Y); }
        public readonly Vector4I28F4 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Z, Z); }
        public readonly Vector4I28F4 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, X, X); }
        public readonly Vector4I28F4 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, X, Y); }
        public readonly Vector4I28F4 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, X, Z); }
        public readonly Vector4I28F4 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Y, X); }
        public readonly Vector4I28F4 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Y, Y); }
        public readonly Vector4I28F4 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Y, Z); }
        public readonly Vector4I28F4 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Z, X); }
        public readonly Vector4I28F4 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Z, Y); }
        public readonly Vector4I28F4 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Z, Z); }
        public readonly Vector4I28F4 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, X, X); }
        public readonly Vector4I28F4 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, X, Y); }
        public readonly Vector4I28F4 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, X, Z); }
        public readonly Vector4I28F4 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Y, X); }
        public readonly Vector4I28F4 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Y, Y); }
        public readonly Vector4I28F4 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Y, Z); }
        public readonly Vector4I28F4 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Z, X); }
        public readonly Vector4I28F4 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Z, Y); }
        public readonly Vector4I28F4 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Z, Z); }
        public readonly Vector4I28F4 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, X, X); }
        public readonly Vector4I28F4 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, X, Y); }
        public readonly Vector4I28F4 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, X, Z); }
        public readonly Vector4I28F4 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Y, X); }
        public readonly Vector4I28F4 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Y, Y); }
        public readonly Vector4I28F4 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Y, Z); }
        public readonly Vector4I28F4 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Z, X); }
        public readonly Vector4I28F4 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Z, Y); }
        public readonly Vector4I28F4 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Z, Z); }
        public readonly Vector4I28F4 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, X, X); }
        public readonly Vector4I28F4 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, X, Y); }
        public readonly Vector4I28F4 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, X, Z); }
        public readonly Vector4I28F4 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Y, X); }
        public readonly Vector4I28F4 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Y, Y); }
        public readonly Vector4I28F4 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Y, Z); }
        public readonly Vector4I28F4 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Z, X); }
        public readonly Vector4I28F4 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Z, Y); }
        public readonly Vector4I28F4 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I28F4 other)
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
            return $"<{x}, {y}, {z}>";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector3I28F4 Half() => new Vector3I28F4(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I28F4 Twice() => new Vector3I28F4(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I28F4 Clamp(I28F4 min, I28F4 max) => new Vector3I28F4(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I28F4 Clamp(
            Vector3I28F4 min, Vector3I28F4 max
        ) => new Vector3I28F4(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I28F4 SaturatingAdd(Vector3I28F4 other) => new Vector3I28F4(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I28F4 SaturatingMul(I28F4 other) => new Vector3I28F4(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I28F4 Cross(Vector3I28F4 other) {
            const long k = 1L << 4;
            var ax = (long)X.Bits;
            var ay = (long)Y.Bits;
            var az = (long)Z.Bits;
            var bx = (long)other.X.Bits;
            var by = (long)other.Y.Bits;
            var bz = (long)other.Z.Bits;
            var x = (ay * bz) - (az * by);
            var y = (az * bx) - (ax * bz);
            var z = (ax * by) - (ay * bx);
            return new Vector3I28F4(
                I28F4.FromBits((int)(x / k)),
                I28F4.FromBits((int)(y / k)),
                I28F4.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I58F6 WideningDot(Vector3I28F4 other) {
            var x = X.WideningMul(other.X);
            var y = Y.WideningMul(other.Y);
            var z = Z.WideningMul(other.Z);

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x.Bits / 4) +
                (y.Bits / 4) +
                (z.Bits / 4);
            return I58F6.FromBits(bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I28F4 Dot(Vector3I28F4 other) => (I28F4)WideningDot(other);

    }

    partial struct I28F4 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I28F4 SaturatingMul(Vector3I28F4 other) => other.SaturatingMul(this);
    }
}
