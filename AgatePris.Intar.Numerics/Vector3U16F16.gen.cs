using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U16F16 : IEquatable<Vector3U16F16>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U16F16 X;
        public U16F16 Y;
        public U16F16 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U16F16(U16F16 x, U16F16 y, U16F16 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U16F16(U16F16 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U16F16(U16F16 x, Vector2U16F16 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U16F16(Vector3U16F16 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U16F16(Vector2U16F16 xy, U16F16 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U16F16 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U16F16(U16F16.Zero);
        }
        public static Vector3U16F16 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U16F16(U16F16.One);
        }
        public static Vector3U16F16 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U16F16(U16F16.One, U16F16.Zero, U16F16.Zero);
        }
        public static Vector3U16F16 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U16F16(U16F16.Zero, U16F16.One, U16F16.Zero);
        }
        public static Vector3U16F16 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U16F16(U16F16.Zero, U16F16.Zero, U16F16.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator +(Vector3U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator -(Vector3U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator *(Vector3U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator *(Vector3U16F16 a, U16F16 b) => new Vector3U16F16(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator *(U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator /(Vector3U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator /(Vector3U16F16 a, U16F16 b) => new Vector3U16F16(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator /(U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U16F16 lhs, Vector3U16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U16F16 lhs, Vector3U16F16 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U16F16 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, X); }
        public readonly Vector2U16F16 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, Y); }
        public readonly Vector2U16F16 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, Z); }
        public readonly Vector2U16F16 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, X); }
        public readonly Vector2U16F16 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, Y); }
        public readonly Vector2U16F16 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, Z); }
        public readonly Vector2U16F16 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, X); }
        public readonly Vector2U16F16 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, Y); }
        public readonly Vector2U16F16 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, Z); }
        public readonly Vector3U16F16 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, X); }
        public readonly Vector3U16F16 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, Y); }
        public readonly Vector3U16F16 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, Z); }
        public readonly Vector3U16F16 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, X); }
        public readonly Vector3U16F16 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, Y); }
        public readonly Vector3U16F16 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, Z); }
        public readonly Vector3U16F16 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, X); }
        public readonly Vector3U16F16 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, Y); }
        public readonly Vector3U16F16 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, Z); }
        public readonly Vector3U16F16 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, X); }
        public readonly Vector3U16F16 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, Y); }
        public readonly Vector3U16F16 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, Z); }
        public readonly Vector3U16F16 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, X); }
        public readonly Vector3U16F16 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, Y); }
        public readonly Vector3U16F16 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, Z); }
        public readonly Vector3U16F16 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, X); }
        public readonly Vector3U16F16 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, Y); }
        public readonly Vector3U16F16 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, Z); }
        public readonly Vector3U16F16 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, X); }
        public readonly Vector3U16F16 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, Y); }
        public readonly Vector3U16F16 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, Z); }
        public readonly Vector3U16F16 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, X); }
        public readonly Vector3U16F16 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, Y); }
        public readonly Vector3U16F16 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, Z); }
        public readonly Vector3U16F16 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, X); }
        public readonly Vector3U16F16 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, Y); }
        public readonly Vector3U16F16 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, Z); }
        public readonly Vector4U16F16 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, X); }
        public readonly Vector4U16F16 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, Y); }
        public readonly Vector4U16F16 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, Z); }
        public readonly Vector4U16F16 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, X); }
        public readonly Vector4U16F16 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, Y); }
        public readonly Vector4U16F16 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, Z); }
        public readonly Vector4U16F16 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, X); }
        public readonly Vector4U16F16 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, Y); }
        public readonly Vector4U16F16 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, Z); }
        public readonly Vector4U16F16 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, X); }
        public readonly Vector4U16F16 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, Y); }
        public readonly Vector4U16F16 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, Z); }
        public readonly Vector4U16F16 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, X); }
        public readonly Vector4U16F16 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, Y); }
        public readonly Vector4U16F16 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, Z); }
        public readonly Vector4U16F16 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, X); }
        public readonly Vector4U16F16 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, Y); }
        public readonly Vector4U16F16 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, Z); }
        public readonly Vector4U16F16 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, X); }
        public readonly Vector4U16F16 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, Y); }
        public readonly Vector4U16F16 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, Z); }
        public readonly Vector4U16F16 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, X); }
        public readonly Vector4U16F16 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, Y); }
        public readonly Vector4U16F16 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, Z); }
        public readonly Vector4U16F16 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, X); }
        public readonly Vector4U16F16 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, Y); }
        public readonly Vector4U16F16 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, Z); }
        public readonly Vector4U16F16 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, X); }
        public readonly Vector4U16F16 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, Y); }
        public readonly Vector4U16F16 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, Z); }
        public readonly Vector4U16F16 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, X); }
        public readonly Vector4U16F16 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, Y); }
        public readonly Vector4U16F16 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, Z); }
        public readonly Vector4U16F16 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, X); }
        public readonly Vector4U16F16 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, Y); }
        public readonly Vector4U16F16 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, Z); }
        public readonly Vector4U16F16 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, X); }
        public readonly Vector4U16F16 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, Y); }
        public readonly Vector4U16F16 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, Z); }
        public readonly Vector4U16F16 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, X); }
        public readonly Vector4U16F16 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, Y); }
        public readonly Vector4U16F16 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, Z); }
        public readonly Vector4U16F16 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, X); }
        public readonly Vector4U16F16 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, Y); }
        public readonly Vector4U16F16 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, Z); }
        public readonly Vector4U16F16 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, X); }
        public readonly Vector4U16F16 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, Y); }
        public readonly Vector4U16F16 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, Z); }
        public readonly Vector4U16F16 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, X); }
        public readonly Vector4U16F16 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, Y); }
        public readonly Vector4U16F16 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, Z); }
        public readonly Vector4U16F16 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, X); }
        public readonly Vector4U16F16 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, Y); }
        public readonly Vector4U16F16 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, Z); }
        public readonly Vector4U16F16 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, X); }
        public readonly Vector4U16F16 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, Y); }
        public readonly Vector4U16F16 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, Z); }
        public readonly Vector4U16F16 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, X); }
        public readonly Vector4U16F16 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, Y); }
        public readonly Vector4U16F16 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, Z); }
        public readonly Vector4U16F16 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, X); }
        public readonly Vector4U16F16 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, Y); }
        public readonly Vector4U16F16 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, Z); }
        public readonly Vector4U16F16 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, X); }
        public readonly Vector4U16F16 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, Y); }
        public readonly Vector4U16F16 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, Z); }
        public readonly Vector4U16F16 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, X); }
        public readonly Vector4U16F16 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, Y); }
        public readonly Vector4U16F16 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, Z); }
        public readonly Vector4U16F16 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, X); }
        public readonly Vector4U16F16 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, Y); }
        public readonly Vector4U16F16 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, Z); }
        public readonly Vector4U16F16 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, X); }
        public readonly Vector4U16F16 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, Y); }
        public readonly Vector4U16F16 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, Z); }
        public readonly Vector4U16F16 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, X); }
        public readonly Vector4U16F16 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, Y); }
        public readonly Vector4U16F16 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, Z); }
        public readonly Vector4U16F16 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, X); }
        public readonly Vector4U16F16 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, Y); }
        public readonly Vector4U16F16 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U16F16 other)
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

        public readonly Vector3U16F16 Half() => new Vector3U16F16(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3U16F16 Twice() => new Vector3U16F16(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3U16F16 Clamp(U16F16 min, U16F16 max) => new Vector3U16F16(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3U16F16 Clamp(
            Vector3U16F16 min, Vector3U16F16 max
        ) => new Vector3U16F16(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U16F16 SaturatingAdd(Vector3U16F16 other) => new Vector3U16F16(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U16F16 SaturatingMul(U16F16 other) => new Vector3U16F16(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U16F16 Dot(Vector3U16F16 other) {
            return
                X * other.X +
                Y * other.Y +
                Z * other.Z;
        }

    }

    partial struct U16F16 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U16F16 SaturatingMul(Vector3U16F16 other) => other.SaturatingMul(this);
    }
}
