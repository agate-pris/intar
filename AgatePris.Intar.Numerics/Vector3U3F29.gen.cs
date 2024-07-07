using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U3F29 : IEquatable<Vector3U3F29>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U3F29 X;
        public U3F29 Y;
        public U3F29 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U3F29(U3F29 x, U3F29 y, U3F29 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U3F29(U3F29 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U3F29(U3F29 x, Vector2U3F29 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U3F29(Vector3U3F29 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U3F29(Vector2U3F29 xy, U3F29 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U3F29 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U3F29(U3F29.Zero);
        }
        public static Vector3U3F29 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U3F29(U3F29.One);
        }
        public static Vector3U3F29 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U3F29(U3F29.One, U3F29.Zero, U3F29.Zero);
        }
        public static Vector3U3F29 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U3F29(U3F29.Zero, U3F29.One, U3F29.Zero);
        }
        public static Vector3U3F29 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U3F29(U3F29.Zero, U3F29.Zero, U3F29.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 operator +(Vector3U3F29 a, Vector3U3F29 b) => new Vector3U3F29(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 operator -(Vector3U3F29 a, Vector3U3F29 b) => new Vector3U3F29(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 operator *(Vector3U3F29 a, Vector3U3F29 b) => new Vector3U3F29(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 operator *(Vector3U3F29 a, U3F29 b) => new Vector3U3F29(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 operator *(U3F29 a, Vector3U3F29 b) => new Vector3U3F29(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 operator /(Vector3U3F29 a, Vector3U3F29 b) => new Vector3U3F29(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 operator /(Vector3U3F29 a, U3F29 b) => new Vector3U3F29(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 operator /(U3F29 a, Vector3U3F29 b) => new Vector3U3F29(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U3F29 lhs, Vector3U3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U3F29 lhs, Vector3U3F29 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U3F29 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, X); }
        public readonly Vector2U3F29 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, Y); }
        public readonly Vector2U3F29 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, Z); }
        public readonly Vector2U3F29 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, X); }
        public readonly Vector2U3F29 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, Y); }
        public readonly Vector2U3F29 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, Z); }
        public readonly Vector2U3F29 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, X); }
        public readonly Vector2U3F29 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, Y); }
        public readonly Vector2U3F29 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, Z); }
        public readonly Vector3U3F29 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, X); }
        public readonly Vector3U3F29 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, Y); }
        public readonly Vector3U3F29 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, Z); }
        public readonly Vector3U3F29 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, X); }
        public readonly Vector3U3F29 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, Y); }
        public readonly Vector3U3F29 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, Z); }
        public readonly Vector3U3F29 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, X); }
        public readonly Vector3U3F29 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, Y); }
        public readonly Vector3U3F29 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, Z); }
        public readonly Vector3U3F29 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, X); }
        public readonly Vector3U3F29 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, Y); }
        public readonly Vector3U3F29 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, Z); }
        public readonly Vector3U3F29 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, X); }
        public readonly Vector3U3F29 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, Y); }
        public readonly Vector3U3F29 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, Z); }
        public readonly Vector3U3F29 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, X); }
        public readonly Vector3U3F29 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, Y); }
        public readonly Vector3U3F29 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, Z); }
        public readonly Vector3U3F29 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, X); }
        public readonly Vector3U3F29 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, Y); }
        public readonly Vector3U3F29 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, Z); }
        public readonly Vector3U3F29 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, X); }
        public readonly Vector3U3F29 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, Y); }
        public readonly Vector3U3F29 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, Z); }
        public readonly Vector3U3F29 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, X); }
        public readonly Vector3U3F29 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, Y); }
        public readonly Vector3U3F29 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, Z); }
        public readonly Vector4U3F29 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, X); }
        public readonly Vector4U3F29 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, Y); }
        public readonly Vector4U3F29 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, Z); }
        public readonly Vector4U3F29 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, X); }
        public readonly Vector4U3F29 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, Y); }
        public readonly Vector4U3F29 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, Z); }
        public readonly Vector4U3F29 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, X); }
        public readonly Vector4U3F29 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, Y); }
        public readonly Vector4U3F29 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, Z); }
        public readonly Vector4U3F29 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, X); }
        public readonly Vector4U3F29 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, Y); }
        public readonly Vector4U3F29 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, Z); }
        public readonly Vector4U3F29 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, X); }
        public readonly Vector4U3F29 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, Y); }
        public readonly Vector4U3F29 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, Z); }
        public readonly Vector4U3F29 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, X); }
        public readonly Vector4U3F29 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, Y); }
        public readonly Vector4U3F29 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, Z); }
        public readonly Vector4U3F29 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, X); }
        public readonly Vector4U3F29 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, Y); }
        public readonly Vector4U3F29 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, Z); }
        public readonly Vector4U3F29 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, X); }
        public readonly Vector4U3F29 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, Y); }
        public readonly Vector4U3F29 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, Z); }
        public readonly Vector4U3F29 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, X); }
        public readonly Vector4U3F29 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, Y); }
        public readonly Vector4U3F29 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, Z); }
        public readonly Vector4U3F29 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, X); }
        public readonly Vector4U3F29 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, Y); }
        public readonly Vector4U3F29 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, Z); }
        public readonly Vector4U3F29 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, X); }
        public readonly Vector4U3F29 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, Y); }
        public readonly Vector4U3F29 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, Z); }
        public readonly Vector4U3F29 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, X); }
        public readonly Vector4U3F29 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, Y); }
        public readonly Vector4U3F29 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, Z); }
        public readonly Vector4U3F29 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, X); }
        public readonly Vector4U3F29 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, Y); }
        public readonly Vector4U3F29 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, Z); }
        public readonly Vector4U3F29 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, X); }
        public readonly Vector4U3F29 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, Y); }
        public readonly Vector4U3F29 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, Z); }
        public readonly Vector4U3F29 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, X); }
        public readonly Vector4U3F29 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, Y); }
        public readonly Vector4U3F29 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, Z); }
        public readonly Vector4U3F29 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, X); }
        public readonly Vector4U3F29 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, Y); }
        public readonly Vector4U3F29 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, Z); }
        public readonly Vector4U3F29 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, X); }
        public readonly Vector4U3F29 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, Y); }
        public readonly Vector4U3F29 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, Z); }
        public readonly Vector4U3F29 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, X); }
        public readonly Vector4U3F29 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, Y); }
        public readonly Vector4U3F29 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, Z); }
        public readonly Vector4U3F29 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, X); }
        public readonly Vector4U3F29 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, Y); }
        public readonly Vector4U3F29 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, Z); }
        public readonly Vector4U3F29 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, X); }
        public readonly Vector4U3F29 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, Y); }
        public readonly Vector4U3F29 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, Z); }
        public readonly Vector4U3F29 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, X); }
        public readonly Vector4U3F29 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, Y); }
        public readonly Vector4U3F29 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, Z); }
        public readonly Vector4U3F29 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, X); }
        public readonly Vector4U3F29 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, Y); }
        public readonly Vector4U3F29 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, Z); }
        public readonly Vector4U3F29 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, X); }
        public readonly Vector4U3F29 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, Y); }
        public readonly Vector4U3F29 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, Z); }
        public readonly Vector4U3F29 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, X); }
        public readonly Vector4U3F29 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, Y); }
        public readonly Vector4U3F29 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, Z); }
        public readonly Vector4U3F29 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, X); }
        public readonly Vector4U3F29 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, Y); }
        public readonly Vector4U3F29 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, Z); }
        public readonly Vector4U3F29 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, X); }
        public readonly Vector4U3F29 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, Y); }
        public readonly Vector4U3F29 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, Z); }
        public readonly Vector4U3F29 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, X); }
        public readonly Vector4U3F29 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, Y); }
        public readonly Vector4U3F29 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U3F29 other)
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

        public readonly Vector3U3F29 Half() => new Vector3U3F29(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3U3F29 Twice() => new Vector3U3F29(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3U3F29 Clamp(U3F29 min, U3F29 max) => new Vector3U3F29(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3U3F29 Clamp(
            Vector3U3F29 min, Vector3U3F29 max
        ) => new Vector3U3F29(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U3F29 SaturatingAdd(Vector3U3F29 other) => new Vector3U3F29(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U3F29 SaturatingMul(U3F29 other) => new Vector3U3F29(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U3F29 Dot(Vector3U3F29 other) {
            return
                X * other.X +
                Y * other.Y +
                Z * other.Z;
        }

    }

    partial struct U3F29 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U3F29 SaturatingMul(Vector3U3F29 other) => other.SaturatingMul(this);
    }
}
