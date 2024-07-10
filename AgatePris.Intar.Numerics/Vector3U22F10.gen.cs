using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U22F10 : IEquatable<Vector3U22F10>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U22F10 X;
        public U22F10 Y;
        public U22F10 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(U22F10 x, U22F10 y, U22F10 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(U22F10 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(U22F10 x, Vector2U22F10 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(Vector3U22F10 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(Vector2U22F10 xy, U22F10 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U22F10 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U22F10(U22F10.Zero);
        }
        public static Vector3U22F10 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U22F10(U22F10.One);
        }
        public static Vector3U22F10 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U22F10(U22F10.One, U22F10.Zero, U22F10.Zero);
        }
        public static Vector3U22F10 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U22F10(U22F10.Zero, U22F10.One, U22F10.Zero);
        }
        public static Vector3U22F10 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U22F10(U22F10.Zero, U22F10.Zero, U22F10.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator +(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator -(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator *(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator *(Vector3U22F10 a, U22F10 b) => new Vector3U22F10(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator *(U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator /(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator /(Vector3U22F10 a, U22F10 b) => new Vector3U22F10(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator /(U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U22F10 lhs, Vector3U22F10 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U22F10 lhs, Vector3U22F10 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U22F10 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, X); }
        public readonly Vector2U22F10 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, Y); }
        public readonly Vector2U22F10 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, Z); }
        public readonly Vector2U22F10 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, X); }
        public readonly Vector2U22F10 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, Y); }
        public readonly Vector2U22F10 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, Z); }
        public readonly Vector2U22F10 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Z, X); }
        public readonly Vector2U22F10 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Z, Y); }
        public readonly Vector2U22F10 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Z, Z); }
        public readonly Vector3U22F10 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, X); }
        public readonly Vector3U22F10 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, Y); }
        public readonly Vector3U22F10 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, Z); }
        public readonly Vector3U22F10 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, X); }
        public readonly Vector3U22F10 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, Y); }
        public readonly Vector3U22F10 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, Z); }
        public readonly Vector3U22F10 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Z, X); }
        public readonly Vector3U22F10 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Z, Y); }
        public readonly Vector3U22F10 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Z, Z); }
        public readonly Vector3U22F10 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, X); }
        public readonly Vector3U22F10 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, Y); }
        public readonly Vector3U22F10 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, Z); }
        public readonly Vector3U22F10 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, X); }
        public readonly Vector3U22F10 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, Y); }
        public readonly Vector3U22F10 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, Z); }
        public readonly Vector3U22F10 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Z, X); }
        public readonly Vector3U22F10 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Z, Y); }
        public readonly Vector3U22F10 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Z, Z); }
        public readonly Vector3U22F10 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, X, X); }
        public readonly Vector3U22F10 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, X, Y); }
        public readonly Vector3U22F10 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, X, Z); }
        public readonly Vector3U22F10 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Y, X); }
        public readonly Vector3U22F10 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Y, Y); }
        public readonly Vector3U22F10 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Y, Z); }
        public readonly Vector3U22F10 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Z, X); }
        public readonly Vector3U22F10 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Z, Y); }
        public readonly Vector3U22F10 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Z, Z); }
        public readonly Vector4U22F10 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, X); }
        public readonly Vector4U22F10 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, Y); }
        public readonly Vector4U22F10 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, Z); }
        public readonly Vector4U22F10 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, X); }
        public readonly Vector4U22F10 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, Y); }
        public readonly Vector4U22F10 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, Z); }
        public readonly Vector4U22F10 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Z, X); }
        public readonly Vector4U22F10 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Z, Y); }
        public readonly Vector4U22F10 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Z, Z); }
        public readonly Vector4U22F10 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, X); }
        public readonly Vector4U22F10 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, Y); }
        public readonly Vector4U22F10 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, Z); }
        public readonly Vector4U22F10 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, X); }
        public readonly Vector4U22F10 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, Y); }
        public readonly Vector4U22F10 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, Z); }
        public readonly Vector4U22F10 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Z, X); }
        public readonly Vector4U22F10 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Z, Y); }
        public readonly Vector4U22F10 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Z, Z); }
        public readonly Vector4U22F10 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, X, X); }
        public readonly Vector4U22F10 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, X, Y); }
        public readonly Vector4U22F10 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, X, Z); }
        public readonly Vector4U22F10 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Y, X); }
        public readonly Vector4U22F10 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Y, Y); }
        public readonly Vector4U22F10 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Y, Z); }
        public readonly Vector4U22F10 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Z, X); }
        public readonly Vector4U22F10 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Z, Y); }
        public readonly Vector4U22F10 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Z, Z); }
        public readonly Vector4U22F10 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, X); }
        public readonly Vector4U22F10 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, Y); }
        public readonly Vector4U22F10 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, Z); }
        public readonly Vector4U22F10 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, X); }
        public readonly Vector4U22F10 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, Y); }
        public readonly Vector4U22F10 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, Z); }
        public readonly Vector4U22F10 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Z, X); }
        public readonly Vector4U22F10 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Z, Y); }
        public readonly Vector4U22F10 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Z, Z); }
        public readonly Vector4U22F10 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, X); }
        public readonly Vector4U22F10 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, Y); }
        public readonly Vector4U22F10 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, Z); }
        public readonly Vector4U22F10 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, X); }
        public readonly Vector4U22F10 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, Y); }
        public readonly Vector4U22F10 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, Z); }
        public readonly Vector4U22F10 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Z, X); }
        public readonly Vector4U22F10 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Z, Y); }
        public readonly Vector4U22F10 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Z, Z); }
        public readonly Vector4U22F10 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, X, X); }
        public readonly Vector4U22F10 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, X, Y); }
        public readonly Vector4U22F10 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, X, Z); }
        public readonly Vector4U22F10 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Y, X); }
        public readonly Vector4U22F10 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Y, Y); }
        public readonly Vector4U22F10 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Y, Z); }
        public readonly Vector4U22F10 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Z, X); }
        public readonly Vector4U22F10 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Z, Y); }
        public readonly Vector4U22F10 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Z, Z); }
        public readonly Vector4U22F10 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, X, X); }
        public readonly Vector4U22F10 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, X, Y); }
        public readonly Vector4U22F10 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, X, Z); }
        public readonly Vector4U22F10 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Y, X); }
        public readonly Vector4U22F10 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Y, Y); }
        public readonly Vector4U22F10 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Y, Z); }
        public readonly Vector4U22F10 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Z, X); }
        public readonly Vector4U22F10 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Z, Y); }
        public readonly Vector4U22F10 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Z, Z); }
        public readonly Vector4U22F10 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, X, X); }
        public readonly Vector4U22F10 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, X, Y); }
        public readonly Vector4U22F10 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, X, Z); }
        public readonly Vector4U22F10 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Y, X); }
        public readonly Vector4U22F10 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Y, Y); }
        public readonly Vector4U22F10 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Y, Z); }
        public readonly Vector4U22F10 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Z, X); }
        public readonly Vector4U22F10 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Z, Y); }
        public readonly Vector4U22F10 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Z, Z); }
        public readonly Vector4U22F10 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, X, X); }
        public readonly Vector4U22F10 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, X, Y); }
        public readonly Vector4U22F10 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, X, Z); }
        public readonly Vector4U22F10 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Y, X); }
        public readonly Vector4U22F10 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Y, Y); }
        public readonly Vector4U22F10 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Y, Z); }
        public readonly Vector4U22F10 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Z, X); }
        public readonly Vector4U22F10 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Z, Y); }
        public readonly Vector4U22F10 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U22F10 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U22F10>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U22F10 other)
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U22F10 Half() => new Vector3U22F10(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U22F10 Twice() => new Vector3U22F10(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U22F10 Clamp(U22F10 min, U22F10 max) => new Vector3U22F10(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U22F10 Clamp(
            Vector3U22F10 min, Vector3U22F10 max
        ) => new Vector3U22F10(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U22F10 SaturatingAdd(Vector3U22F10 other) => new Vector3U22F10(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U22F10 SaturatingMul(U22F10 other) => new Vector3U22F10(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong DotInternal(Vector3U22F10 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;
            var z = ((ulong)Z.Bits) * other.Z.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4) +
                (z / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U22F10 Dot(Vector3U22F10 other) {
            const ulong k = 1UL << 8;
            return U22F10.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U22F10 SaturatingDot(Vector3U22F10 other) {
            const ulong k = 1UL << 8;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U22F10.MaxValue;
            } else {
                return U22F10.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// ベクトルの長さの 2 乗を返します｡
        /// </summary>
        /// <remarks>
        /// オーバーフローを防ぐため､ 計算の過程で 4 で除算しています｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U46F18 LengthSquared() {
            return U46F18.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U22F10 LengthHalf() => U22F10.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U23F9 Length() => U23F9.FromBits(LengthInternal());

    }

    partial struct U22F10 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U22F10 SaturatingMul(Vector3U22F10 other) => other.SaturatingMul(this);
    }
}
