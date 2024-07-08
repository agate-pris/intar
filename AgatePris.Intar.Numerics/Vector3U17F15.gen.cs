using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U17F15 : IEquatable<Vector3U17F15>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U17F15 X;
        public U17F15 Y;
        public U17F15 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(U17F15 x, U17F15 y, U17F15 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(U17F15 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(U17F15 x, Vector2U17F15 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(Vector3U17F15 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(Vector2U17F15 xy, U17F15 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U17F15(U17F15.Zero);
        }
        public static Vector3U17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U17F15(U17F15.One);
        }
        public static Vector3U17F15 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U17F15(U17F15.One, U17F15.Zero, U17F15.Zero);
        }
        public static Vector3U17F15 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U17F15(U17F15.Zero, U17F15.One, U17F15.Zero);
        }
        public static Vector3U17F15 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U17F15(U17F15.Zero, U17F15.Zero, U17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator +(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator -(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator *(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator *(Vector3U17F15 a, U17F15 b) => new Vector3U17F15(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator *(U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator /(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator /(Vector3U17F15 a, U17F15 b) => new Vector3U17F15(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator /(U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U17F15 lhs, Vector3U17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U17F15 lhs, Vector3U17F15 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U17F15 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, X); }
        public readonly Vector2U17F15 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, Y); }
        public readonly Vector2U17F15 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, Z); }
        public readonly Vector2U17F15 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, X); }
        public readonly Vector2U17F15 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, Y); }
        public readonly Vector2U17F15 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, Z); }
        public readonly Vector2U17F15 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Z, X); }
        public readonly Vector2U17F15 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Z, Y); }
        public readonly Vector2U17F15 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Z, Z); }
        public readonly Vector3U17F15 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, X); }
        public readonly Vector3U17F15 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, Y); }
        public readonly Vector3U17F15 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, Z); }
        public readonly Vector3U17F15 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, X); }
        public readonly Vector3U17F15 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, Y); }
        public readonly Vector3U17F15 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, Z); }
        public readonly Vector3U17F15 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Z, X); }
        public readonly Vector3U17F15 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Z, Y); }
        public readonly Vector3U17F15 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Z, Z); }
        public readonly Vector3U17F15 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, X); }
        public readonly Vector3U17F15 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, Y); }
        public readonly Vector3U17F15 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, Z); }
        public readonly Vector3U17F15 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, X); }
        public readonly Vector3U17F15 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, Y); }
        public readonly Vector3U17F15 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, Z); }
        public readonly Vector3U17F15 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Z, X); }
        public readonly Vector3U17F15 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Z, Y); }
        public readonly Vector3U17F15 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Z, Z); }
        public readonly Vector3U17F15 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, X, X); }
        public readonly Vector3U17F15 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, X, Y); }
        public readonly Vector3U17F15 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, X, Z); }
        public readonly Vector3U17F15 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Y, X); }
        public readonly Vector3U17F15 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Y, Y); }
        public readonly Vector3U17F15 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Y, Z); }
        public readonly Vector3U17F15 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Z, X); }
        public readonly Vector3U17F15 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Z, Y); }
        public readonly Vector3U17F15 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Z, Z); }
        public readonly Vector4U17F15 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, X); }
        public readonly Vector4U17F15 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, Y); }
        public readonly Vector4U17F15 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, Z); }
        public readonly Vector4U17F15 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, X); }
        public readonly Vector4U17F15 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, Y); }
        public readonly Vector4U17F15 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, Z); }
        public readonly Vector4U17F15 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Z, X); }
        public readonly Vector4U17F15 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Z, Y); }
        public readonly Vector4U17F15 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Z, Z); }
        public readonly Vector4U17F15 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, X); }
        public readonly Vector4U17F15 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, Y); }
        public readonly Vector4U17F15 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, Z); }
        public readonly Vector4U17F15 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, X); }
        public readonly Vector4U17F15 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, Y); }
        public readonly Vector4U17F15 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, Z); }
        public readonly Vector4U17F15 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Z, X); }
        public readonly Vector4U17F15 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Z, Y); }
        public readonly Vector4U17F15 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Z, Z); }
        public readonly Vector4U17F15 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, X, X); }
        public readonly Vector4U17F15 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, X, Y); }
        public readonly Vector4U17F15 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, X, Z); }
        public readonly Vector4U17F15 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Y, X); }
        public readonly Vector4U17F15 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Y, Y); }
        public readonly Vector4U17F15 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Y, Z); }
        public readonly Vector4U17F15 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Z, X); }
        public readonly Vector4U17F15 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Z, Y); }
        public readonly Vector4U17F15 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Z, Z); }
        public readonly Vector4U17F15 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, X); }
        public readonly Vector4U17F15 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, Y); }
        public readonly Vector4U17F15 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, Z); }
        public readonly Vector4U17F15 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, X); }
        public readonly Vector4U17F15 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, Y); }
        public readonly Vector4U17F15 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, Z); }
        public readonly Vector4U17F15 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Z, X); }
        public readonly Vector4U17F15 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Z, Y); }
        public readonly Vector4U17F15 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Z, Z); }
        public readonly Vector4U17F15 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, X); }
        public readonly Vector4U17F15 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, Y); }
        public readonly Vector4U17F15 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, Z); }
        public readonly Vector4U17F15 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, X); }
        public readonly Vector4U17F15 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, Y); }
        public readonly Vector4U17F15 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, Z); }
        public readonly Vector4U17F15 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Z, X); }
        public readonly Vector4U17F15 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Z, Y); }
        public readonly Vector4U17F15 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Z, Z); }
        public readonly Vector4U17F15 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, X, X); }
        public readonly Vector4U17F15 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, X, Y); }
        public readonly Vector4U17F15 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, X, Z); }
        public readonly Vector4U17F15 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Y, X); }
        public readonly Vector4U17F15 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Y, Y); }
        public readonly Vector4U17F15 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Y, Z); }
        public readonly Vector4U17F15 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Z, X); }
        public readonly Vector4U17F15 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Z, Y); }
        public readonly Vector4U17F15 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Z, Z); }
        public readonly Vector4U17F15 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, X, X); }
        public readonly Vector4U17F15 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, X, Y); }
        public readonly Vector4U17F15 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, X, Z); }
        public readonly Vector4U17F15 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Y, X); }
        public readonly Vector4U17F15 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Y, Y); }
        public readonly Vector4U17F15 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Y, Z); }
        public readonly Vector4U17F15 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Z, X); }
        public readonly Vector4U17F15 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Z, Y); }
        public readonly Vector4U17F15 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Z, Z); }
        public readonly Vector4U17F15 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, X, X); }
        public readonly Vector4U17F15 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, X, Y); }
        public readonly Vector4U17F15 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, X, Z); }
        public readonly Vector4U17F15 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Y, X); }
        public readonly Vector4U17F15 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Y, Y); }
        public readonly Vector4U17F15 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Y, Z); }
        public readonly Vector4U17F15 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Z, X); }
        public readonly Vector4U17F15 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Z, Y); }
        public readonly Vector4U17F15 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Z, Z); }
        public readonly Vector4U17F15 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, X, X); }
        public readonly Vector4U17F15 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, X, Y); }
        public readonly Vector4U17F15 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, X, Z); }
        public readonly Vector4U17F15 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Y, X); }
        public readonly Vector4U17F15 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Y, Y); }
        public readonly Vector4U17F15 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Y, Z); }
        public readonly Vector4U17F15 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Z, X); }
        public readonly Vector4U17F15 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Z, Y); }
        public readonly Vector4U17F15 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U17F15 other)
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

        public readonly Vector3U17F15 Half() => new Vector3U17F15(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3U17F15 Twice() => new Vector3U17F15(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3U17F15 Clamp(U17F15 min, U17F15 max) => new Vector3U17F15(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3U17F15 Clamp(
            Vector3U17F15 min, Vector3U17F15 max
        ) => new Vector3U17F15(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U17F15 SaturatingAdd(Vector3U17F15 other) => new Vector3U17F15(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U17F15 SaturatingMul(U17F15 other) => new Vector3U17F15(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U17F15 Dot(Vector3U17F15 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;
            var z = ((ulong)Z.Bits) * other.Z.Bits;

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x / 4) +
                (y / 4) +
                (z / 4);

            const ulong k = 1UL << 13;
            return U17F15.FromBits((uint)(bits / k));
        }

    }

    partial struct U17F15 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U17F15 SaturatingMul(Vector3U17F15 other) => other.SaturatingMul(this);
    }
}
