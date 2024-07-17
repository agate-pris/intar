using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U29F3 : IEquatable<Vector3U29F3>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U29F3 X;
        public U29F3 Y;
        public U29F3 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(U29F3 x, U29F3 y, U29F3 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(U29F3 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(U29F3 x, Vector2U29F3 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(Vector3U29F3 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(Vector2U29F3 xy, U29F3 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U29F3 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U29F3(U29F3.Zero);
        }
        public static Vector3U29F3 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U29F3(U29F3.One);
        }
        public static Vector3U29F3 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U29F3(U29F3.One, U29F3.Zero, U29F3.Zero);
        }
        public static Vector3U29F3 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U29F3(U29F3.Zero, U29F3.One, U29F3.Zero);
        }
        public static Vector3U29F3 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U29F3(U29F3.Zero, U29F3.Zero, U29F3.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator +(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator -(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator *(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator *(Vector3U29F3 a, U29F3 b) => new Vector3U29F3(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator *(U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator /(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator /(Vector3U29F3 a, U29F3 b) => new Vector3U29F3(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator /(U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U29F3 lhs, Vector3U29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U29F3 lhs, Vector3U29F3 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U29F3 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(X, X); }
        public Vector2U29F3 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(X, Y); }
        public Vector2U29F3 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(X, Z); }
        public Vector2U29F3 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Y, X); }
        public Vector2U29F3 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Y, Y); }
        public Vector2U29F3 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Y, Z); }
        public Vector2U29F3 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Z, X); }
        public Vector2U29F3 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Z, Y); }
        public Vector2U29F3 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Z, Z); }
        public Vector3U29F3 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, X, X); }
        public Vector3U29F3 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, X, Y); }
        public Vector3U29F3 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, X, Z); }
        public Vector3U29F3 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Y, X); }
        public Vector3U29F3 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Y, Y); }
        public Vector3U29F3 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Y, Z); }
        public Vector3U29F3 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Z, X); }
        public Vector3U29F3 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Z, Y); }
        public Vector3U29F3 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Z, Z); }
        public Vector3U29F3 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, X, X); }
        public Vector3U29F3 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, X, Y); }
        public Vector3U29F3 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, X, Z); }
        public Vector3U29F3 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Y, X); }
        public Vector3U29F3 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Y, Y); }
        public Vector3U29F3 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Y, Z); }
        public Vector3U29F3 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Z, X); }
        public Vector3U29F3 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Z, Y); }
        public Vector3U29F3 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Z, Z); }
        public Vector3U29F3 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, X, X); }
        public Vector3U29F3 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, X, Y); }
        public Vector3U29F3 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, X, Z); }
        public Vector3U29F3 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Y, X); }
        public Vector3U29F3 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Y, Y); }
        public Vector3U29F3 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Y, Z); }
        public Vector3U29F3 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Z, X); }
        public Vector3U29F3 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Z, Y); }
        public Vector3U29F3 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Z, Z, Z); }
        public Vector4U29F3 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, X, X); }
        public Vector4U29F3 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, X, Y); }
        public Vector4U29F3 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, X, Z); }
        public Vector4U29F3 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Y, X); }
        public Vector4U29F3 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Y, Y); }
        public Vector4U29F3 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Y, Z); }
        public Vector4U29F3 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Z, X); }
        public Vector4U29F3 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Z, Y); }
        public Vector4U29F3 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Z, Z); }
        public Vector4U29F3 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, X, X); }
        public Vector4U29F3 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, X, Y); }
        public Vector4U29F3 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, X, Z); }
        public Vector4U29F3 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Y, X); }
        public Vector4U29F3 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Y, Y); }
        public Vector4U29F3 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Y, Z); }
        public Vector4U29F3 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Z, X); }
        public Vector4U29F3 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Z, Y); }
        public Vector4U29F3 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Z, Z); }
        public Vector4U29F3 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, X, X); }
        public Vector4U29F3 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, X, Y); }
        public Vector4U29F3 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, X, Z); }
        public Vector4U29F3 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Y, X); }
        public Vector4U29F3 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Y, Y); }
        public Vector4U29F3 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Y, Z); }
        public Vector4U29F3 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Z, X); }
        public Vector4U29F3 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Z, Y); }
        public Vector4U29F3 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Z, Z, Z); }
        public Vector4U29F3 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, X, X); }
        public Vector4U29F3 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, X, Y); }
        public Vector4U29F3 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, X, Z); }
        public Vector4U29F3 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Y, X); }
        public Vector4U29F3 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Y, Y); }
        public Vector4U29F3 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Y, Z); }
        public Vector4U29F3 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Z, X); }
        public Vector4U29F3 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Z, Y); }
        public Vector4U29F3 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Z, Z); }
        public Vector4U29F3 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, X, X); }
        public Vector4U29F3 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, X, Y); }
        public Vector4U29F3 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, X, Z); }
        public Vector4U29F3 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Y, X); }
        public Vector4U29F3 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Y, Y); }
        public Vector4U29F3 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Y, Z); }
        public Vector4U29F3 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Z, X); }
        public Vector4U29F3 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Z, Y); }
        public Vector4U29F3 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Z, Z); }
        public Vector4U29F3 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, X, X); }
        public Vector4U29F3 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, X, Y); }
        public Vector4U29F3 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, X, Z); }
        public Vector4U29F3 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Y, X); }
        public Vector4U29F3 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Y, Y); }
        public Vector4U29F3 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Y, Z); }
        public Vector4U29F3 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Z, X); }
        public Vector4U29F3 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Z, Y); }
        public Vector4U29F3 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Z, Z, Z); }
        public Vector4U29F3 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, X, X); }
        public Vector4U29F3 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, X, Y); }
        public Vector4U29F3 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, X, Z); }
        public Vector4U29F3 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Y, X); }
        public Vector4U29F3 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Y, Y); }
        public Vector4U29F3 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Y, Z); }
        public Vector4U29F3 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Z, X); }
        public Vector4U29F3 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Z, Y); }
        public Vector4U29F3 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, X, Z, Z); }
        public Vector4U29F3 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, X, X); }
        public Vector4U29F3 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, X, Y); }
        public Vector4U29F3 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, X, Z); }
        public Vector4U29F3 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Y, X); }
        public Vector4U29F3 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Y, Y); }
        public Vector4U29F3 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Y, Z); }
        public Vector4U29F3 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Z, X); }
        public Vector4U29F3 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Z, Y); }
        public Vector4U29F3 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Y, Z, Z); }
        public Vector4U29F3 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, X, X); }
        public Vector4U29F3 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, X, Y); }
        public Vector4U29F3 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, X, Z); }
        public Vector4U29F3 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Y, X); }
        public Vector4U29F3 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Y, Y); }
        public Vector4U29F3 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Y, Z); }
        public Vector4U29F3 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Z, X); }
        public Vector4U29F3 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Z, Y); }
        public Vector4U29F3 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U29F3 other)
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
        public Vector3U29F3 Min(Vector3U29F3 other) => new Vector3U29F3(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 Max(Vector3U29F3 other) => new Vector3U29F3(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 Half() => new Vector3U29F3(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 Twice() => new Vector3U29F3(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 Clamp(U29F3 min, U29F3 max) => new Vector3U29F3(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 Clamp(
            Vector3U29F3 min, Vector3U29F3 max
        ) => new Vector3U29F3(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 WrappingAdd(Vector3U29F3 other) => new Vector3U29F3(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 WrappingSub(Vector3U29F3 other) => new Vector3U29F3(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 WrappingMul(Vector3U29F3 other) => new Vector3U29F3(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 WrappingAddSigned(Vector3I29F3 other) => new Vector3U29F3(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 SaturatingAdd(Vector3U29F3 other) => new Vector3U29F3(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 SaturatingMul(U29F3 other) => new Vector3U29F3(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U29F3 other) {
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
        public U29F3 Dot(Vector3U29F3 other) {
            const ulong k = 1UL << 1;
            return U29F3.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U29F3 SaturatingDot(Vector3U29F3 other) {
            const ulong k = 1UL << 1;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U29F3.MaxValue;
            } else {
                return U29F3.FromBits((uint)bits);
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
        public U60F4 LengthSquared() {
            return U60F4.FromBits(LengthSquaredInternal());
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
        public U29F3 LengthHalf() => U29F3.FromBits(LengthInternal());

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
        public I29F3 LengthHalfSigned() => I29F3.FromBits(checked((int)LengthInternal()));

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthSigned">LengthSigned</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthSigned">LengthSigned</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U30F2 LengthUnsigned() => U30F2.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfSigned"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I30F2 LengthSigned() => I30F2.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U30F2 Length() => LengthUnsigned();

    }

    partial struct U29F3 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3 SaturatingMul(Vector3U29F3 other) => other.SaturatingMul(this);
    }
}
