using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U13F19 : IEquatable<Vector3U13F19>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U13F19 X;
        public U13F19 Y;
        public U13F19 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(U13F19 x, U13F19 y, U13F19 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(U13F19 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(U13F19 x, Vector2U13F19 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(Vector3U13F19 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(Vector2U13F19 xy, U13F19 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U13F19 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U13F19(U13F19.Zero);
        }
        public static Vector3U13F19 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U13F19(U13F19.One);
        }
        public static Vector3U13F19 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U13F19(U13F19.One, U13F19.Zero, U13F19.Zero);
        }
        public static Vector3U13F19 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U13F19(U13F19.Zero, U13F19.One, U13F19.Zero);
        }
        public static Vector3U13F19 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U13F19(U13F19.Zero, U13F19.Zero, U13F19.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator +(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator -(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator *(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator *(Vector3U13F19 a, U13F19 b) => new Vector3U13F19(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator *(U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator /(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator /(Vector3U13F19 a, U13F19 b) => new Vector3U13F19(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator /(U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U13F19 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, X); }
        public readonly Vector2U13F19 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, Y); }
        public readonly Vector2U13F19 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, Z); }
        public readonly Vector2U13F19 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, X); }
        public readonly Vector2U13F19 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, Y); }
        public readonly Vector2U13F19 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, Z); }
        public readonly Vector2U13F19 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Z, X); }
        public readonly Vector2U13F19 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Z, Y); }
        public readonly Vector2U13F19 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Z, Z); }
        public readonly Vector3U13F19 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, X); }
        public readonly Vector3U13F19 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, Y); }
        public readonly Vector3U13F19 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, Z); }
        public readonly Vector3U13F19 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, X); }
        public readonly Vector3U13F19 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, Y); }
        public readonly Vector3U13F19 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, Z); }
        public readonly Vector3U13F19 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Z, X); }
        public readonly Vector3U13F19 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Z, Y); }
        public readonly Vector3U13F19 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Z, Z); }
        public readonly Vector3U13F19 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, X); }
        public readonly Vector3U13F19 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, Y); }
        public readonly Vector3U13F19 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, Z); }
        public readonly Vector3U13F19 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, X); }
        public readonly Vector3U13F19 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, Y); }
        public readonly Vector3U13F19 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, Z); }
        public readonly Vector3U13F19 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Z, X); }
        public readonly Vector3U13F19 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Z, Y); }
        public readonly Vector3U13F19 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Z, Z); }
        public readonly Vector3U13F19 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, X, X); }
        public readonly Vector3U13F19 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, X, Y); }
        public readonly Vector3U13F19 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, X, Z); }
        public readonly Vector3U13F19 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Y, X); }
        public readonly Vector3U13F19 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Y, Y); }
        public readonly Vector3U13F19 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Y, Z); }
        public readonly Vector3U13F19 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Z, X); }
        public readonly Vector3U13F19 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Z, Y); }
        public readonly Vector3U13F19 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Z, Z); }
        public readonly Vector4U13F19 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, X); }
        public readonly Vector4U13F19 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, Y); }
        public readonly Vector4U13F19 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, Z); }
        public readonly Vector4U13F19 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, X); }
        public readonly Vector4U13F19 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, Y); }
        public readonly Vector4U13F19 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, Z); }
        public readonly Vector4U13F19 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Z, X); }
        public readonly Vector4U13F19 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Z, Y); }
        public readonly Vector4U13F19 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Z, Z); }
        public readonly Vector4U13F19 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, X); }
        public readonly Vector4U13F19 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, Y); }
        public readonly Vector4U13F19 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, Z); }
        public readonly Vector4U13F19 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, X); }
        public readonly Vector4U13F19 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, Y); }
        public readonly Vector4U13F19 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, Z); }
        public readonly Vector4U13F19 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Z, X); }
        public readonly Vector4U13F19 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Z, Y); }
        public readonly Vector4U13F19 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Z, Z); }
        public readonly Vector4U13F19 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, X, X); }
        public readonly Vector4U13F19 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, X, Y); }
        public readonly Vector4U13F19 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, X, Z); }
        public readonly Vector4U13F19 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Y, X); }
        public readonly Vector4U13F19 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Y, Y); }
        public readonly Vector4U13F19 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Y, Z); }
        public readonly Vector4U13F19 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Z, X); }
        public readonly Vector4U13F19 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Z, Y); }
        public readonly Vector4U13F19 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Z, Z); }
        public readonly Vector4U13F19 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, X); }
        public readonly Vector4U13F19 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, Y); }
        public readonly Vector4U13F19 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, Z); }
        public readonly Vector4U13F19 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, X); }
        public readonly Vector4U13F19 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, Y); }
        public readonly Vector4U13F19 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, Z); }
        public readonly Vector4U13F19 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Z, X); }
        public readonly Vector4U13F19 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Z, Y); }
        public readonly Vector4U13F19 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Z, Z); }
        public readonly Vector4U13F19 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, X); }
        public readonly Vector4U13F19 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, Y); }
        public readonly Vector4U13F19 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, Z); }
        public readonly Vector4U13F19 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, X); }
        public readonly Vector4U13F19 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, Y); }
        public readonly Vector4U13F19 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, Z); }
        public readonly Vector4U13F19 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Z, X); }
        public readonly Vector4U13F19 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Z, Y); }
        public readonly Vector4U13F19 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Z, Z); }
        public readonly Vector4U13F19 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, X, X); }
        public readonly Vector4U13F19 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, X, Y); }
        public readonly Vector4U13F19 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, X, Z); }
        public readonly Vector4U13F19 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Y, X); }
        public readonly Vector4U13F19 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Y, Y); }
        public readonly Vector4U13F19 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Y, Z); }
        public readonly Vector4U13F19 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Z, X); }
        public readonly Vector4U13F19 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Z, Y); }
        public readonly Vector4U13F19 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Z, Z); }
        public readonly Vector4U13F19 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, X, X); }
        public readonly Vector4U13F19 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, X, Y); }
        public readonly Vector4U13F19 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, X, Z); }
        public readonly Vector4U13F19 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Y, X); }
        public readonly Vector4U13F19 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Y, Y); }
        public readonly Vector4U13F19 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Y, Z); }
        public readonly Vector4U13F19 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Z, X); }
        public readonly Vector4U13F19 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Z, Y); }
        public readonly Vector4U13F19 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Z, Z); }
        public readonly Vector4U13F19 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, X, X); }
        public readonly Vector4U13F19 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, X, Y); }
        public readonly Vector4U13F19 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, X, Z); }
        public readonly Vector4U13F19 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Y, X); }
        public readonly Vector4U13F19 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Y, Y); }
        public readonly Vector4U13F19 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Y, Z); }
        public readonly Vector4U13F19 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Z, X); }
        public readonly Vector4U13F19 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Z, Y); }
        public readonly Vector4U13F19 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Z, Z); }
        public readonly Vector4U13F19 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, X, X); }
        public readonly Vector4U13F19 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, X, Y); }
        public readonly Vector4U13F19 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, X, Z); }
        public readonly Vector4U13F19 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Y, X); }
        public readonly Vector4U13F19 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Y, Y); }
        public readonly Vector4U13F19 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Y, Z); }
        public readonly Vector4U13F19 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Z, X); }
        public readonly Vector4U13F19 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Z, Y); }
        public readonly Vector4U13F19 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Z, Z); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U13F19 lhs, Vector3U13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U13F19 lhs, Vector3U13F19 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U13F19 other)
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

        public readonly Vector3U13F19 Half() => new Vector3U13F19(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3U13F19 Twice() => new Vector3U13F19(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3U13F19 Clamp(U13F19 min, U13F19 max) => new Vector3U13F19(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3U13F19 Clamp(
            Vector3U13F19 min, Vector3U13F19 max
        ) => new Vector3U13F19(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U13F19 SaturatingAdd(Vector3U13F19 other) => new Vector3U13F19(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

    }
}
