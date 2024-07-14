using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U19F13 : IEquatable<Vector3U19F13>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U19F13 X;
        public U19F13 Y;
        public U19F13 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13(U19F13 x, U19F13 y, U19F13 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13(U19F13 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13(U19F13 x, Vector2U19F13 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13(Vector3U19F13 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13(Vector2U19F13 xy, U19F13 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U19F13 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U19F13(U19F13.Zero);
        }
        public static Vector3U19F13 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U19F13(U19F13.One);
        }
        public static Vector3U19F13 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U19F13(U19F13.One, U19F13.Zero, U19F13.Zero);
        }
        public static Vector3U19F13 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U19F13(U19F13.Zero, U19F13.One, U19F13.Zero);
        }
        public static Vector3U19F13 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U19F13(U19F13.Zero, U19F13.Zero, U19F13.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator +(Vector3U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator -(Vector3U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator *(Vector3U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator *(Vector3U19F13 a, U19F13 b) => new Vector3U19F13(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator *(U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator /(Vector3U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator /(Vector3U19F13 a, U19F13 b) => new Vector3U19F13(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 operator /(U19F13 a, Vector3U19F13 b) => new Vector3U19F13(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U19F13 lhs, Vector3U19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U19F13 lhs, Vector3U19F13 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U19F13 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(X, X); }
        public Vector2U19F13 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(X, Y); }
        public Vector2U19F13 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(X, Z); }
        public Vector2U19F13 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Y, X); }
        public Vector2U19F13 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Y, Y); }
        public Vector2U19F13 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Y, Z); }
        public Vector2U19F13 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Z, X); }
        public Vector2U19F13 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Z, Y); }
        public Vector2U19F13 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U19F13(Z, Z); }
        public Vector3U19F13 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, X, X); }
        public Vector3U19F13 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, X, Y); }
        public Vector3U19F13 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, X, Z); }
        public Vector3U19F13 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Y, X); }
        public Vector3U19F13 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Y, Y); }
        public Vector3U19F13 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Y, Z); }
        public Vector3U19F13 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Z, X); }
        public Vector3U19F13 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Z, Y); }
        public Vector3U19F13 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(X, Z, Z); }
        public Vector3U19F13 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, X, X); }
        public Vector3U19F13 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, X, Y); }
        public Vector3U19F13 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, X, Z); }
        public Vector3U19F13 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Y, X); }
        public Vector3U19F13 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Y, Y); }
        public Vector3U19F13 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Y, Z); }
        public Vector3U19F13 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Z, X); }
        public Vector3U19F13 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Z, Y); }
        public Vector3U19F13 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Y, Z, Z); }
        public Vector3U19F13 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, X, X); }
        public Vector3U19F13 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, X, Y); }
        public Vector3U19F13 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, X, Z); }
        public Vector3U19F13 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Y, X); }
        public Vector3U19F13 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Y, Y); }
        public Vector3U19F13 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Y, Z); }
        public Vector3U19F13 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Z, X); }
        public Vector3U19F13 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Z, Y); }
        public Vector3U19F13 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U19F13(Z, Z, Z); }
        public Vector4U19F13 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, X, X); }
        public Vector4U19F13 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, X, Y); }
        public Vector4U19F13 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, X, Z); }
        public Vector4U19F13 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Y, X); }
        public Vector4U19F13 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Y, Y); }
        public Vector4U19F13 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Y, Z); }
        public Vector4U19F13 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Z, X); }
        public Vector4U19F13 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Z, Y); }
        public Vector4U19F13 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, X, Z, Z); }
        public Vector4U19F13 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, X, X); }
        public Vector4U19F13 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, X, Y); }
        public Vector4U19F13 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, X, Z); }
        public Vector4U19F13 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Y, X); }
        public Vector4U19F13 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Y, Y); }
        public Vector4U19F13 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Y, Z); }
        public Vector4U19F13 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Z, X); }
        public Vector4U19F13 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Z, Y); }
        public Vector4U19F13 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Y, Z, Z); }
        public Vector4U19F13 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, X, X); }
        public Vector4U19F13 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, X, Y); }
        public Vector4U19F13 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, X, Z); }
        public Vector4U19F13 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Y, X); }
        public Vector4U19F13 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Y, Y); }
        public Vector4U19F13 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Y, Z); }
        public Vector4U19F13 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Z, X); }
        public Vector4U19F13 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Z, Y); }
        public Vector4U19F13 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(X, Z, Z, Z); }
        public Vector4U19F13 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, X, X); }
        public Vector4U19F13 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, X, Y); }
        public Vector4U19F13 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, X, Z); }
        public Vector4U19F13 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Y, X); }
        public Vector4U19F13 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Y, Y); }
        public Vector4U19F13 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Y, Z); }
        public Vector4U19F13 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Z, X); }
        public Vector4U19F13 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Z, Y); }
        public Vector4U19F13 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, X, Z, Z); }
        public Vector4U19F13 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, X, X); }
        public Vector4U19F13 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, X, Y); }
        public Vector4U19F13 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, X, Z); }
        public Vector4U19F13 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Y, X); }
        public Vector4U19F13 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Y, Y); }
        public Vector4U19F13 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Y, Z); }
        public Vector4U19F13 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Z, X); }
        public Vector4U19F13 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Z, Y); }
        public Vector4U19F13 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Y, Z, Z); }
        public Vector4U19F13 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, X, X); }
        public Vector4U19F13 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, X, Y); }
        public Vector4U19F13 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, X, Z); }
        public Vector4U19F13 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Y, X); }
        public Vector4U19F13 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Y, Y); }
        public Vector4U19F13 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Y, Z); }
        public Vector4U19F13 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Z, X); }
        public Vector4U19F13 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Z, Y); }
        public Vector4U19F13 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Y, Z, Z, Z); }
        public Vector4U19F13 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, X, X); }
        public Vector4U19F13 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, X, Y); }
        public Vector4U19F13 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, X, Z); }
        public Vector4U19F13 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Y, X); }
        public Vector4U19F13 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Y, Y); }
        public Vector4U19F13 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Y, Z); }
        public Vector4U19F13 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Z, X); }
        public Vector4U19F13 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Z, Y); }
        public Vector4U19F13 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, X, Z, Z); }
        public Vector4U19F13 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, X, X); }
        public Vector4U19F13 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, X, Y); }
        public Vector4U19F13 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, X, Z); }
        public Vector4U19F13 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Y, X); }
        public Vector4U19F13 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Y, Y); }
        public Vector4U19F13 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Y, Z); }
        public Vector4U19F13 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Z, X); }
        public Vector4U19F13 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Z, Y); }
        public Vector4U19F13 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Y, Z, Z); }
        public Vector4U19F13 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, X, X); }
        public Vector4U19F13 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, X, Y); }
        public Vector4U19F13 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, X, Z); }
        public Vector4U19F13 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Y, X); }
        public Vector4U19F13 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Y, Y); }
        public Vector4U19F13 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Y, Z); }
        public Vector4U19F13 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Z, X); }
        public Vector4U19F13 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Z, Y); }
        public Vector4U19F13 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U19F13(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U19F13>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U19F13 other)
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
        public Vector3U19F13 Min(Vector3U19F13 other) => new Vector3U19F13(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 Max(Vector3U19F13 other) => new Vector3U19F13(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 Half() => new Vector3U19F13(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 Twice() => new Vector3U19F13(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 Clamp(U19F13 min, U19F13 max) => new Vector3U19F13(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 Clamp(
            Vector3U19F13 min, Vector3U19F13 max
        ) => new Vector3U19F13(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 WrappingAdd(Vector3U19F13 other) => new Vector3U19F13(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 WrappingSub(Vector3U19F13 other) => new Vector3U19F13(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 WrappingMul(Vector3U19F13 other) => new Vector3U19F13(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 WrappingAddSigned(Vector3I19F13 other) => new Vector3U19F13(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 SaturatingAdd(Vector3U19F13 other) => new Vector3U19F13(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 SaturatingMul(U19F13 other) => new Vector3U19F13(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U19F13 other) {
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
        public U19F13 Dot(Vector3U19F13 other) {
            const ulong k = 1UL << 11;
            return U19F13.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U19F13 SaturatingDot(Vector3U19F13 other) {
            const ulong k = 1UL << 11;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U19F13.MaxValue;
            } else {
                return U19F13.FromBits((uint)bits);
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
        public U40F24 LengthSquared() {
            return U40F24.FromBits(LengthSquaredInternal());
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
        public U19F13 LengthHalf() => U19F13.FromBits(LengthInternal());

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
        public I19F13 LengthHalfSigned() => I19F13.FromBits(checked((int)LengthInternal()));

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
        public U20F12 Length() => U20F12.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="Length">Length</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="Length">Length</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfSigned"/>
        /// <seealso cref="Length"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I20F12 LengthSigned() => I20F12.FromBits(checked((int)LengthInternal()));

    }

    partial struct U19F13 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U19F13 SaturatingMul(Vector3U19F13 other) => other.SaturatingMul(this);
    }
}
