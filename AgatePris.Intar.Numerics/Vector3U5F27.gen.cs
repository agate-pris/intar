using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U5F27 : IEquatable<Vector3U5F27>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U5F27 X;
        public U5F27 Y;
        public U5F27 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27(U5F27 x, U5F27 y, U5F27 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27(U5F27 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27(U5F27 x, Vector2U5F27 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27(Vector3U5F27 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27(Vector2U5F27 xy, U5F27 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U5F27 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U5F27(U5F27.Zero);
        }
        public static Vector3U5F27 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U5F27(U5F27.One);
        }
        public static Vector3U5F27 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U5F27(U5F27.One, U5F27.Zero, U5F27.Zero);
        }
        public static Vector3U5F27 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U5F27(U5F27.Zero, U5F27.One, U5F27.Zero);
        }
        public static Vector3U5F27 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U5F27(U5F27.Zero, U5F27.Zero, U5F27.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 operator +(Vector3U5F27 a, Vector3U5F27 b) => new Vector3U5F27(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 operator -(Vector3U5F27 a, Vector3U5F27 b) => new Vector3U5F27(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 operator *(Vector3U5F27 a, Vector3U5F27 b) => new Vector3U5F27(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 operator *(Vector3U5F27 a, U5F27 b) => new Vector3U5F27(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 operator *(U5F27 a, Vector3U5F27 b) => new Vector3U5F27(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 operator /(Vector3U5F27 a, Vector3U5F27 b) => new Vector3U5F27(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 operator /(Vector3U5F27 a, U5F27 b) => new Vector3U5F27(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 operator /(U5F27 a, Vector3U5F27 b) => new Vector3U5F27(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U5F27 lhs, Vector3U5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U5F27 lhs, Vector3U5F27 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U5F27 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(X, X); }
        public Vector2U5F27 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(X, Y); }
        public Vector2U5F27 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(X, Z); }
        public Vector2U5F27 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(Y, X); }
        public Vector2U5F27 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(Y, Y); }
        public Vector2U5F27 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(Y, Z); }
        public Vector2U5F27 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(Z, X); }
        public Vector2U5F27 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(Z, Y); }
        public Vector2U5F27 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(Z, Z); }
        public Vector3U5F27 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, X, X); }
        public Vector3U5F27 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, X, Y); }
        public Vector3U5F27 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, X, Z); }
        public Vector3U5F27 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, Y, X); }
        public Vector3U5F27 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, Y, Y); }
        public Vector3U5F27 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, Y, Z); }
        public Vector3U5F27 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, Z, X); }
        public Vector3U5F27 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, Z, Y); }
        public Vector3U5F27 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, Z, Z); }
        public Vector3U5F27 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, X, X); }
        public Vector3U5F27 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, X, Y); }
        public Vector3U5F27 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, X, Z); }
        public Vector3U5F27 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, Y, X); }
        public Vector3U5F27 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, Y, Y); }
        public Vector3U5F27 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, Y, Z); }
        public Vector3U5F27 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, Z, X); }
        public Vector3U5F27 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, Z, Y); }
        public Vector3U5F27 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, Z, Z); }
        public Vector3U5F27 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Z, X, X); }
        public Vector3U5F27 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Z, X, Y); }
        public Vector3U5F27 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Z, X, Z); }
        public Vector3U5F27 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Z, Y, X); }
        public Vector3U5F27 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Z, Y, Y); }
        public Vector3U5F27 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Z, Y, Z); }
        public Vector3U5F27 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Z, Z, X); }
        public Vector3U5F27 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Z, Z, Y); }
        public Vector3U5F27 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Z, Z, Z); }
        public Vector4U5F27 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, X, X); }
        public Vector4U5F27 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, X, Y); }
        public Vector4U5F27 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, X, Z); }
        public Vector4U5F27 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, Y, X); }
        public Vector4U5F27 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, Y, Y); }
        public Vector4U5F27 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, Y, Z); }
        public Vector4U5F27 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, Z, X); }
        public Vector4U5F27 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, Z, Y); }
        public Vector4U5F27 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, Z, Z); }
        public Vector4U5F27 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, X, X); }
        public Vector4U5F27 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, X, Y); }
        public Vector4U5F27 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, X, Z); }
        public Vector4U5F27 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, Y, X); }
        public Vector4U5F27 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, Y, Y); }
        public Vector4U5F27 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, Y, Z); }
        public Vector4U5F27 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, Z, X); }
        public Vector4U5F27 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, Z, Y); }
        public Vector4U5F27 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, Z, Z); }
        public Vector4U5F27 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Z, X, X); }
        public Vector4U5F27 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Z, X, Y); }
        public Vector4U5F27 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Z, X, Z); }
        public Vector4U5F27 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Z, Y, X); }
        public Vector4U5F27 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Z, Y, Y); }
        public Vector4U5F27 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Z, Y, Z); }
        public Vector4U5F27 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Z, Z, X); }
        public Vector4U5F27 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Z, Z, Y); }
        public Vector4U5F27 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Z, Z, Z); }
        public Vector4U5F27 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, X, X); }
        public Vector4U5F27 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, X, Y); }
        public Vector4U5F27 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, X, Z); }
        public Vector4U5F27 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, Y, X); }
        public Vector4U5F27 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, Y, Y); }
        public Vector4U5F27 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, Y, Z); }
        public Vector4U5F27 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, Z, X); }
        public Vector4U5F27 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, Z, Y); }
        public Vector4U5F27 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, Z, Z); }
        public Vector4U5F27 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, X, X); }
        public Vector4U5F27 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, X, Y); }
        public Vector4U5F27 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, X, Z); }
        public Vector4U5F27 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, Y, X); }
        public Vector4U5F27 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, Y, Y); }
        public Vector4U5F27 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, Y, Z); }
        public Vector4U5F27 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, Z, X); }
        public Vector4U5F27 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, Z, Y); }
        public Vector4U5F27 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, Z, Z); }
        public Vector4U5F27 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Z, X, X); }
        public Vector4U5F27 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Z, X, Y); }
        public Vector4U5F27 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Z, X, Z); }
        public Vector4U5F27 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Z, Y, X); }
        public Vector4U5F27 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Z, Y, Y); }
        public Vector4U5F27 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Z, Y, Z); }
        public Vector4U5F27 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Z, Z, X); }
        public Vector4U5F27 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Z, Z, Y); }
        public Vector4U5F27 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Z, Z, Z); }
        public Vector4U5F27 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, X, X, X); }
        public Vector4U5F27 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, X, X, Y); }
        public Vector4U5F27 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, X, X, Z); }
        public Vector4U5F27 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, X, Y, X); }
        public Vector4U5F27 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, X, Y, Y); }
        public Vector4U5F27 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, X, Y, Z); }
        public Vector4U5F27 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, X, Z, X); }
        public Vector4U5F27 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, X, Z, Y); }
        public Vector4U5F27 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, X, Z, Z); }
        public Vector4U5F27 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Y, X, X); }
        public Vector4U5F27 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Y, X, Y); }
        public Vector4U5F27 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Y, X, Z); }
        public Vector4U5F27 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Y, Y, X); }
        public Vector4U5F27 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Y, Y, Y); }
        public Vector4U5F27 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Y, Y, Z); }
        public Vector4U5F27 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Y, Z, X); }
        public Vector4U5F27 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Y, Z, Y); }
        public Vector4U5F27 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Y, Z, Z); }
        public Vector4U5F27 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Z, X, X); }
        public Vector4U5F27 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Z, X, Y); }
        public Vector4U5F27 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Z, X, Z); }
        public Vector4U5F27 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Z, Y, X); }
        public Vector4U5F27 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Z, Y, Y); }
        public Vector4U5F27 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Z, Y, Z); }
        public Vector4U5F27 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Z, Z, X); }
        public Vector4U5F27 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Z, Z, Y); }
        public Vector4U5F27 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U5F27 other)
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
        public Vector3U5F27 Min(Vector3U5F27 other) => new Vector3U5F27(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 Max(Vector3U5F27 other) => new Vector3U5F27(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 Half() => new Vector3U5F27(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 Twice() => new Vector3U5F27(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 Clamp(U5F27 min, U5F27 max) => new Vector3U5F27(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 Clamp(
            Vector3U5F27 min, Vector3U5F27 max
        ) => new Vector3U5F27(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 WrappingAdd(Vector3U5F27 other) => new Vector3U5F27(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 WrappingSub(Vector3U5F27 other) => new Vector3U5F27(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 WrappingMul(Vector3U5F27 other) => new Vector3U5F27(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 WrappingAddSigned(Vector3I5F27 other) => new Vector3U5F27(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 SaturatingAdd(Vector3U5F27 other) => new Vector3U5F27(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 SaturatingMul(U5F27 other) => new Vector3U5F27(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U5F27 other) {
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
        public U5F27 Dot(Vector3U5F27 other) {
            const ulong k = 1UL << 25;
            return U5F27.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U5F27 SaturatingDot(Vector3U5F27 other) {
            const ulong k = 1UL << 25;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U5F27.MaxValue;
            } else {
                return U5F27.FromBits((uint)bits);
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
        public U12F52 LengthSquared() {
            return U12F52.FromBits(LengthSquaredInternal());
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
        /// <para>This method differs from <see cref="LengthHalfSigned">LengthHalfSigned</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalfSigned">LengthHalfSigned</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U5F27 LengthHalf() => U5F27.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalf">LengthHalf</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalf">LengthHalf</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I5F27 LengthHalfSigned() => I5F27.FromBits(checked((int)LengthInternal()));

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <c>LengthSigned</c> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <c>LengthSigned</c> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U6F26 Length() => U6F26.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><c>Length</c> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><c>Length</c> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I6F26 LengthSigned() => I6F26.FromBits(checked((int)LengthInternal()));

    }

    partial struct U5F27 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U5F27 SaturatingMul(Vector3U5F27 other) => other.SaturatingMul(this);
    }
}
