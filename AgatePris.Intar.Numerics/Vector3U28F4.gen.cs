using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U28F4 : IEquatable<Vector3U28F4>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U28F4 X;
        public U28F4 Y;
        public U28F4 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4(U28F4 x, U28F4 y, U28F4 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4(U28F4 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4(U28F4 x, Vector2U28F4 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4(Vector3U28F4 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4(Vector2U28F4 xy, U28F4 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U28F4 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U28F4(U28F4.Zero);
        }
        public static Vector3U28F4 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U28F4(U28F4.One);
        }
        public static Vector3U28F4 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U28F4(U28F4.One, U28F4.Zero, U28F4.Zero);
        }
        public static Vector3U28F4 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U28F4(U28F4.Zero, U28F4.One, U28F4.Zero);
        }
        public static Vector3U28F4 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U28F4(U28F4.Zero, U28F4.Zero, U28F4.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator +(Vector3U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator -(Vector3U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator *(Vector3U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator *(Vector3U28F4 a, U28F4 b) => new Vector3U28F4(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator *(U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator /(Vector3U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator /(Vector3U28F4 a, U28F4 b) => new Vector3U28F4(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator /(U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U28F4 lhs, Vector3U28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U28F4 lhs, Vector3U28F4 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U28F4 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, X); }
        public Vector2U28F4 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, Y); }
        public Vector2U28F4 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, Z); }
        public Vector2U28F4 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, X); }
        public Vector2U28F4 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, Y); }
        public Vector2U28F4 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, Z); }
        public Vector2U28F4 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Z, X); }
        public Vector2U28F4 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Z, Y); }
        public Vector2U28F4 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Z, Z); }
        public Vector3U28F4 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, X); }
        public Vector3U28F4 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, Y); }
        public Vector3U28F4 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, Z); }
        public Vector3U28F4 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, X); }
        public Vector3U28F4 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, Y); }
        public Vector3U28F4 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, Z); }
        public Vector3U28F4 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Z, X); }
        public Vector3U28F4 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Z, Y); }
        public Vector3U28F4 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Z, Z); }
        public Vector3U28F4 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, X); }
        public Vector3U28F4 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, Y); }
        public Vector3U28F4 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, Z); }
        public Vector3U28F4 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, X); }
        public Vector3U28F4 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, Y); }
        public Vector3U28F4 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, Z); }
        public Vector3U28F4 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Z, X); }
        public Vector3U28F4 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Z, Y); }
        public Vector3U28F4 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Z, Z); }
        public Vector3U28F4 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, X, X); }
        public Vector3U28F4 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, X, Y); }
        public Vector3U28F4 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, X, Z); }
        public Vector3U28F4 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Y, X); }
        public Vector3U28F4 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Y, Y); }
        public Vector3U28F4 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Y, Z); }
        public Vector3U28F4 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Z, X); }
        public Vector3U28F4 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Z, Y); }
        public Vector3U28F4 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Z, Z); }
        public Vector4U28F4 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, X); }
        public Vector4U28F4 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, Y); }
        public Vector4U28F4 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, Z); }
        public Vector4U28F4 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, X); }
        public Vector4U28F4 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, Y); }
        public Vector4U28F4 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, Z); }
        public Vector4U28F4 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Z, X); }
        public Vector4U28F4 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Z, Y); }
        public Vector4U28F4 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Z, Z); }
        public Vector4U28F4 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, X); }
        public Vector4U28F4 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, Y); }
        public Vector4U28F4 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, Z); }
        public Vector4U28F4 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, X); }
        public Vector4U28F4 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, Y); }
        public Vector4U28F4 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, Z); }
        public Vector4U28F4 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Z, X); }
        public Vector4U28F4 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Z, Y); }
        public Vector4U28F4 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Z, Z); }
        public Vector4U28F4 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, X, X); }
        public Vector4U28F4 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, X, Y); }
        public Vector4U28F4 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, X, Z); }
        public Vector4U28F4 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Y, X); }
        public Vector4U28F4 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Y, Y); }
        public Vector4U28F4 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Y, Z); }
        public Vector4U28F4 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Z, X); }
        public Vector4U28F4 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Z, Y); }
        public Vector4U28F4 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Z, Z); }
        public Vector4U28F4 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, X); }
        public Vector4U28F4 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, Y); }
        public Vector4U28F4 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, Z); }
        public Vector4U28F4 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, X); }
        public Vector4U28F4 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, Y); }
        public Vector4U28F4 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, Z); }
        public Vector4U28F4 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Z, X); }
        public Vector4U28F4 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Z, Y); }
        public Vector4U28F4 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Z, Z); }
        public Vector4U28F4 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, X); }
        public Vector4U28F4 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, Y); }
        public Vector4U28F4 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, Z); }
        public Vector4U28F4 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, X); }
        public Vector4U28F4 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, Y); }
        public Vector4U28F4 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, Z); }
        public Vector4U28F4 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Z, X); }
        public Vector4U28F4 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Z, Y); }
        public Vector4U28F4 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Z, Z); }
        public Vector4U28F4 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, X, X); }
        public Vector4U28F4 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, X, Y); }
        public Vector4U28F4 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, X, Z); }
        public Vector4U28F4 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Y, X); }
        public Vector4U28F4 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Y, Y); }
        public Vector4U28F4 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Y, Z); }
        public Vector4U28F4 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Z, X); }
        public Vector4U28F4 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Z, Y); }
        public Vector4U28F4 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Z, Z); }
        public Vector4U28F4 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, X, X); }
        public Vector4U28F4 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, X, Y); }
        public Vector4U28F4 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, X, Z); }
        public Vector4U28F4 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Y, X); }
        public Vector4U28F4 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Y, Y); }
        public Vector4U28F4 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Y, Z); }
        public Vector4U28F4 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Z, X); }
        public Vector4U28F4 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Z, Y); }
        public Vector4U28F4 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Z, Z); }
        public Vector4U28F4 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, X, X); }
        public Vector4U28F4 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, X, Y); }
        public Vector4U28F4 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, X, Z); }
        public Vector4U28F4 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Y, X); }
        public Vector4U28F4 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Y, Y); }
        public Vector4U28F4 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Y, Z); }
        public Vector4U28F4 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Z, X); }
        public Vector4U28F4 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Z, Y); }
        public Vector4U28F4 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Z, Z); }
        public Vector4U28F4 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, X, X); }
        public Vector4U28F4 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, X, Y); }
        public Vector4U28F4 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, X, Z); }
        public Vector4U28F4 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Y, X); }
        public Vector4U28F4 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Y, Y); }
        public Vector4U28F4 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Y, Z); }
        public Vector4U28F4 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Z, X); }
        public Vector4U28F4 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Z, Y); }
        public Vector4U28F4 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U28F4 other)
            => other.X == X
            && other.Y == Y
            && other.Z == Z;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            return $"<{x}, {y}, {z}>";
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 Min(Vector3U28F4 other) => new Vector3U28F4(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 Max(Vector3U28F4 other) => new Vector3U28F4(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 Half() => new Vector3U28F4(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 Twice() => new Vector3U28F4(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 Clamp(U28F4 min, U28F4 max) => new Vector3U28F4(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 Clamp(
            Vector3U28F4 min, Vector3U28F4 max
        ) => new Vector3U28F4(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 WrappingAdd(Vector3U28F4 other) => new Vector3U28F4(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 WrappingSub(Vector3U28F4 other) => new Vector3U28F4(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 WrappingMul(Vector3U28F4 other) => new Vector3U28F4(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 WrappingAddSigned(Vector3I28F4 other) => new Vector3U28F4(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 SaturatingAdd(Vector3U28F4 other) => new Vector3U28F4(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 SaturatingMul(U28F4 other) => new Vector3U28F4(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U28F4 other) {
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
        public U28F4 Dot(Vector3U28F4 other) {
            const ulong k = 1UL << 2;
            return U28F4.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U28F4 SaturatingDot(Vector3U28F4 other) {
            const ulong k = 1UL << 2;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U28F4.MaxValue;
            } else {
                return U28F4.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <div class="TIP alert alert-info">
        /// <h5>Tip</h5>
        /// <para>This method divides the square of each element by 4
        /// during the calculation to prevent overflow.</para>
        /// <para>このメソッドはオーバーフローを防ぐため､
        /// 計算の過程で各要素の 2 乗を 4 で除算します｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U58F6 LengthSquared() {
            return U58F6.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <c>LengthHalfSigned</c> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <c>LengthHalfSigned</c> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U28F4 LengthHalf() => U28F4.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><c>LengthHalf</c> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><c>LengthHalf</c> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I28F4 LengthHalfSigned() => I28F4.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U29F3 Length() => U29F3.FromBits(LengthInternal());

    }

    partial struct U28F4 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4 SaturatingMul(Vector3U28F4 other) => other.SaturatingMul(this);
    }
}
