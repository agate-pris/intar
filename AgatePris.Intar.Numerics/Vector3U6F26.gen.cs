using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U6F26 : IEquatable<Vector3U6F26>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U6F26 X;
        public U6F26 Y;
        public U6F26 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U6F26(U6F26 x, U6F26 y, U6F26 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U6F26(U6F26 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U6F26(U6F26 x, Vector2U6F26 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U6F26(Vector3U6F26 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U6F26(Vector2U6F26 xy, U6F26 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U6F26 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U6F26(U6F26.Zero);
        }
        public static Vector3U6F26 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U6F26(U6F26.One);
        }
        public static Vector3U6F26 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U6F26(U6F26.One, U6F26.Zero, U6F26.Zero);
        }
        public static Vector3U6F26 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U6F26(U6F26.Zero, U6F26.One, U6F26.Zero);
        }
        public static Vector3U6F26 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U6F26(U6F26.Zero, U6F26.Zero, U6F26.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator +(Vector3U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator -(Vector3U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator *(Vector3U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator *(Vector3U6F26 a, U6F26 b) => new Vector3U6F26(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator *(U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator /(Vector3U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator /(Vector3U6F26 a, U6F26 b) => new Vector3U6F26(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator /(U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U6F26 lhs, Vector3U6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U6F26 lhs, Vector3U6F26 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U6F26 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(X, X); }
        public readonly Vector2U6F26 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(X, Y); }
        public readonly Vector2U6F26 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(X, Z); }
        public readonly Vector2U6F26 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(Y, X); }
        public readonly Vector2U6F26 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(Y, Y); }
        public readonly Vector2U6F26 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(Y, Z); }
        public readonly Vector2U6F26 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(Z, X); }
        public readonly Vector2U6F26 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(Z, Y); }
        public readonly Vector2U6F26 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(Z, Z); }
        public readonly Vector3U6F26 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, X, X); }
        public readonly Vector3U6F26 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, X, Y); }
        public readonly Vector3U6F26 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, X, Z); }
        public readonly Vector3U6F26 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, Y, X); }
        public readonly Vector3U6F26 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, Y, Y); }
        public readonly Vector3U6F26 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, Y, Z); }
        public readonly Vector3U6F26 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, Z, X); }
        public readonly Vector3U6F26 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, Z, Y); }
        public readonly Vector3U6F26 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, Z, Z); }
        public readonly Vector3U6F26 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, X, X); }
        public readonly Vector3U6F26 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, X, Y); }
        public readonly Vector3U6F26 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, X, Z); }
        public readonly Vector3U6F26 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, Y, X); }
        public readonly Vector3U6F26 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, Y, Y); }
        public readonly Vector3U6F26 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, Y, Z); }
        public readonly Vector3U6F26 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, Z, X); }
        public readonly Vector3U6F26 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, Z, Y); }
        public readonly Vector3U6F26 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, Z, Z); }
        public readonly Vector3U6F26 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Z, X, X); }
        public readonly Vector3U6F26 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Z, X, Y); }
        public readonly Vector3U6F26 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Z, X, Z); }
        public readonly Vector3U6F26 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Z, Y, X); }
        public readonly Vector3U6F26 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Z, Y, Y); }
        public readonly Vector3U6F26 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Z, Y, Z); }
        public readonly Vector3U6F26 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Z, Z, X); }
        public readonly Vector3U6F26 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Z, Z, Y); }
        public readonly Vector3U6F26 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Z, Z, Z); }
        public readonly Vector4U6F26 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, X, X); }
        public readonly Vector4U6F26 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, X, Y); }
        public readonly Vector4U6F26 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, X, Z); }
        public readonly Vector4U6F26 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, Y, X); }
        public readonly Vector4U6F26 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, Y, Y); }
        public readonly Vector4U6F26 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, Y, Z); }
        public readonly Vector4U6F26 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, Z, X); }
        public readonly Vector4U6F26 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, Z, Y); }
        public readonly Vector4U6F26 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, Z, Z); }
        public readonly Vector4U6F26 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, X, X); }
        public readonly Vector4U6F26 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, X, Y); }
        public readonly Vector4U6F26 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, X, Z); }
        public readonly Vector4U6F26 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, Y, X); }
        public readonly Vector4U6F26 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, Y, Y); }
        public readonly Vector4U6F26 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, Y, Z); }
        public readonly Vector4U6F26 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, Z, X); }
        public readonly Vector4U6F26 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, Z, Y); }
        public readonly Vector4U6F26 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, Z, Z); }
        public readonly Vector4U6F26 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Z, X, X); }
        public readonly Vector4U6F26 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Z, X, Y); }
        public readonly Vector4U6F26 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Z, X, Z); }
        public readonly Vector4U6F26 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Z, Y, X); }
        public readonly Vector4U6F26 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Z, Y, Y); }
        public readonly Vector4U6F26 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Z, Y, Z); }
        public readonly Vector4U6F26 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Z, Z, X); }
        public readonly Vector4U6F26 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Z, Z, Y); }
        public readonly Vector4U6F26 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Z, Z, Z); }
        public readonly Vector4U6F26 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, X, X); }
        public readonly Vector4U6F26 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, X, Y); }
        public readonly Vector4U6F26 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, X, Z); }
        public readonly Vector4U6F26 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, Y, X); }
        public readonly Vector4U6F26 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, Y, Y); }
        public readonly Vector4U6F26 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, Y, Z); }
        public readonly Vector4U6F26 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, Z, X); }
        public readonly Vector4U6F26 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, Z, Y); }
        public readonly Vector4U6F26 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, Z, Z); }
        public readonly Vector4U6F26 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, X, X); }
        public readonly Vector4U6F26 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, X, Y); }
        public readonly Vector4U6F26 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, X, Z); }
        public readonly Vector4U6F26 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, Y, X); }
        public readonly Vector4U6F26 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, Y, Y); }
        public readonly Vector4U6F26 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, Y, Z); }
        public readonly Vector4U6F26 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, Z, X); }
        public readonly Vector4U6F26 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, Z, Y); }
        public readonly Vector4U6F26 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, Z, Z); }
        public readonly Vector4U6F26 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Z, X, X); }
        public readonly Vector4U6F26 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Z, X, Y); }
        public readonly Vector4U6F26 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Z, X, Z); }
        public readonly Vector4U6F26 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Z, Y, X); }
        public readonly Vector4U6F26 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Z, Y, Y); }
        public readonly Vector4U6F26 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Z, Y, Z); }
        public readonly Vector4U6F26 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Z, Z, X); }
        public readonly Vector4U6F26 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Z, Z, Y); }
        public readonly Vector4U6F26 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Z, Z, Z); }
        public readonly Vector4U6F26 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, X, X, X); }
        public readonly Vector4U6F26 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, X, X, Y); }
        public readonly Vector4U6F26 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, X, X, Z); }
        public readonly Vector4U6F26 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, X, Y, X); }
        public readonly Vector4U6F26 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, X, Y, Y); }
        public readonly Vector4U6F26 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, X, Y, Z); }
        public readonly Vector4U6F26 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, X, Z, X); }
        public readonly Vector4U6F26 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, X, Z, Y); }
        public readonly Vector4U6F26 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, X, Z, Z); }
        public readonly Vector4U6F26 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Y, X, X); }
        public readonly Vector4U6F26 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Y, X, Y); }
        public readonly Vector4U6F26 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Y, X, Z); }
        public readonly Vector4U6F26 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Y, Y, X); }
        public readonly Vector4U6F26 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Y, Y, Y); }
        public readonly Vector4U6F26 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Y, Y, Z); }
        public readonly Vector4U6F26 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Y, Z, X); }
        public readonly Vector4U6F26 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Y, Z, Y); }
        public readonly Vector4U6F26 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Y, Z, Z); }
        public readonly Vector4U6F26 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Z, X, X); }
        public readonly Vector4U6F26 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Z, X, Y); }
        public readonly Vector4U6F26 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Z, X, Z); }
        public readonly Vector4U6F26 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Z, Y, X); }
        public readonly Vector4U6F26 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Z, Y, Y); }
        public readonly Vector4U6F26 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Z, Y, Z); }
        public readonly Vector4U6F26 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Z, Z, X); }
        public readonly Vector4U6F26 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Z, Z, Y); }
        public readonly Vector4U6F26 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U6F26 other)
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
        public readonly Vector3U6F26 Half() => new Vector3U6F26(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U6F26 Twice() => new Vector3U6F26(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U6F26 Clamp(U6F26 min, U6F26 max) => new Vector3U6F26(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U6F26 Clamp(
            Vector3U6F26 min, Vector3U6F26 max
        ) => new Vector3U6F26(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U6F26 SaturatingAdd(Vector3U6F26 other) => new Vector3U6F26(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U6F26 SaturatingMul(U6F26 other) => new Vector3U6F26(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong DotInternal(Vector3U6F26 other) {
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
        public readonly U6F26 Dot(Vector3U6F26 other) {
            const ulong k = 1UL << 24;
            return U6F26.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U6F26 SaturatingDot(Vector3U6F26 other) {
            const ulong k = 1UL << 24;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U6F26.MaxValue;
            } else {
                return U6F26.FromBits((uint)bits);
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
        public readonly U14F50 LengthSquared() {
            return U14F50.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U6F26 LengthHalf() => U6F26.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U7F25 Length() => U7F25.FromBits(LengthInternal());

    }

    partial struct U6F26 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U6F26 SaturatingMul(Vector3U6F26 other) => other.SaturatingMul(this);
    }
}
