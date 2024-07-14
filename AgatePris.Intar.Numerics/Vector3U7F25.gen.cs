using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U7F25 : IEquatable<Vector3U7F25>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U7F25 X;
        public U7F25 Y;
        public U7F25 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25(U7F25 x, U7F25 y, U7F25 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25(U7F25 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25(U7F25 x, Vector2U7F25 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25(Vector3U7F25 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25(Vector2U7F25 xy, U7F25 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U7F25 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U7F25(U7F25.Zero);
        }
        public static Vector3U7F25 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U7F25(U7F25.One);
        }
        public static Vector3U7F25 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U7F25(U7F25.One, U7F25.Zero, U7F25.Zero);
        }
        public static Vector3U7F25 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U7F25(U7F25.Zero, U7F25.One, U7F25.Zero);
        }
        public static Vector3U7F25 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U7F25(U7F25.Zero, U7F25.Zero, U7F25.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 operator +(Vector3U7F25 a, Vector3U7F25 b) => new Vector3U7F25(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 operator -(Vector3U7F25 a, Vector3U7F25 b) => new Vector3U7F25(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 operator *(Vector3U7F25 a, Vector3U7F25 b) => new Vector3U7F25(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 operator *(Vector3U7F25 a, U7F25 b) => new Vector3U7F25(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 operator *(U7F25 a, Vector3U7F25 b) => new Vector3U7F25(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 operator /(Vector3U7F25 a, Vector3U7F25 b) => new Vector3U7F25(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 operator /(Vector3U7F25 a, U7F25 b) => new Vector3U7F25(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 operator /(U7F25 a, Vector3U7F25 b) => new Vector3U7F25(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U7F25 lhs, Vector3U7F25 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U7F25 lhs, Vector3U7F25 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U7F25 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(X, X); }
        public Vector2U7F25 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(X, Y); }
        public Vector2U7F25 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(X, Z); }
        public Vector2U7F25 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Y, X); }
        public Vector2U7F25 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Y, Y); }
        public Vector2U7F25 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Y, Z); }
        public Vector2U7F25 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Z, X); }
        public Vector2U7F25 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Z, Y); }
        public Vector2U7F25 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Z, Z); }
        public Vector3U7F25 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, X, X); }
        public Vector3U7F25 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, X, Y); }
        public Vector3U7F25 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, X, Z); }
        public Vector3U7F25 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Y, X); }
        public Vector3U7F25 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Y, Y); }
        public Vector3U7F25 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Y, Z); }
        public Vector3U7F25 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Z, X); }
        public Vector3U7F25 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Z, Y); }
        public Vector3U7F25 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Z, Z); }
        public Vector3U7F25 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, X, X); }
        public Vector3U7F25 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, X, Y); }
        public Vector3U7F25 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, X, Z); }
        public Vector3U7F25 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Y, X); }
        public Vector3U7F25 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Y, Y); }
        public Vector3U7F25 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Y, Z); }
        public Vector3U7F25 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Z, X); }
        public Vector3U7F25 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Z, Y); }
        public Vector3U7F25 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Z, Z); }
        public Vector3U7F25 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, X, X); }
        public Vector3U7F25 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, X, Y); }
        public Vector3U7F25 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, X, Z); }
        public Vector3U7F25 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Y, X); }
        public Vector3U7F25 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Y, Y); }
        public Vector3U7F25 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Y, Z); }
        public Vector3U7F25 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Z, X); }
        public Vector3U7F25 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Z, Y); }
        public Vector3U7F25 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Z, Z); }
        public Vector4U7F25 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, X, X); }
        public Vector4U7F25 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, X, Y); }
        public Vector4U7F25 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, X, Z); }
        public Vector4U7F25 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Y, X); }
        public Vector4U7F25 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Y, Y); }
        public Vector4U7F25 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Y, Z); }
        public Vector4U7F25 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Z, X); }
        public Vector4U7F25 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Z, Y); }
        public Vector4U7F25 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Z, Z); }
        public Vector4U7F25 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, X, X); }
        public Vector4U7F25 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, X, Y); }
        public Vector4U7F25 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, X, Z); }
        public Vector4U7F25 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Y, X); }
        public Vector4U7F25 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Y, Y); }
        public Vector4U7F25 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Y, Z); }
        public Vector4U7F25 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Z, X); }
        public Vector4U7F25 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Z, Y); }
        public Vector4U7F25 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Z, Z); }
        public Vector4U7F25 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, X, X); }
        public Vector4U7F25 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, X, Y); }
        public Vector4U7F25 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, X, Z); }
        public Vector4U7F25 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Y, X); }
        public Vector4U7F25 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Y, Y); }
        public Vector4U7F25 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Y, Z); }
        public Vector4U7F25 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Z, X); }
        public Vector4U7F25 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Z, Y); }
        public Vector4U7F25 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Z, Z); }
        public Vector4U7F25 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, X, X); }
        public Vector4U7F25 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, X, Y); }
        public Vector4U7F25 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, X, Z); }
        public Vector4U7F25 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Y, X); }
        public Vector4U7F25 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Y, Y); }
        public Vector4U7F25 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Y, Z); }
        public Vector4U7F25 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Z, X); }
        public Vector4U7F25 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Z, Y); }
        public Vector4U7F25 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Z, Z); }
        public Vector4U7F25 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, X, X); }
        public Vector4U7F25 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, X, Y); }
        public Vector4U7F25 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, X, Z); }
        public Vector4U7F25 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Y, X); }
        public Vector4U7F25 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Y, Y); }
        public Vector4U7F25 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Y, Z); }
        public Vector4U7F25 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Z, X); }
        public Vector4U7F25 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Z, Y); }
        public Vector4U7F25 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Z, Z); }
        public Vector4U7F25 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, X, X); }
        public Vector4U7F25 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, X, Y); }
        public Vector4U7F25 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, X, Z); }
        public Vector4U7F25 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Y, X); }
        public Vector4U7F25 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Y, Y); }
        public Vector4U7F25 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Y, Z); }
        public Vector4U7F25 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Z, X); }
        public Vector4U7F25 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Z, Y); }
        public Vector4U7F25 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Z, Z); }
        public Vector4U7F25 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, X, X); }
        public Vector4U7F25 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, X, Y); }
        public Vector4U7F25 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, X, Z); }
        public Vector4U7F25 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Y, X); }
        public Vector4U7F25 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Y, Y); }
        public Vector4U7F25 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Y, Z); }
        public Vector4U7F25 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Z, X); }
        public Vector4U7F25 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Z, Y); }
        public Vector4U7F25 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Z, Z); }
        public Vector4U7F25 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, X, X); }
        public Vector4U7F25 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, X, Y); }
        public Vector4U7F25 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, X, Z); }
        public Vector4U7F25 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Y, X); }
        public Vector4U7F25 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Y, Y); }
        public Vector4U7F25 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Y, Z); }
        public Vector4U7F25 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Z, X); }
        public Vector4U7F25 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Z, Y); }
        public Vector4U7F25 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Z, Z); }
        public Vector4U7F25 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, X, X); }
        public Vector4U7F25 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, X, Y); }
        public Vector4U7F25 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, X, Z); }
        public Vector4U7F25 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Y, X); }
        public Vector4U7F25 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Y, Y); }
        public Vector4U7F25 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Y, Z); }
        public Vector4U7F25 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Z, X); }
        public Vector4U7F25 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Z, Y); }
        public Vector4U7F25 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U7F25 other)
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
        public Vector3U7F25 Min(Vector3U7F25 other) => new Vector3U7F25(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 Max(Vector3U7F25 other) => new Vector3U7F25(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 Half() => new Vector3U7F25(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 Twice() => new Vector3U7F25(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 Clamp(U7F25 min, U7F25 max) => new Vector3U7F25(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 Clamp(
            Vector3U7F25 min, Vector3U7F25 max
        ) => new Vector3U7F25(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 WrappingAdd(Vector3U7F25 other) => new Vector3U7F25(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 WrappingSub(Vector3U7F25 other) => new Vector3U7F25(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 WrappingMul(Vector3U7F25 other) => new Vector3U7F25(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 WrappingAddSigned(Vector3I7F25 other) => new Vector3U7F25(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 SaturatingAdd(Vector3U7F25 other) => new Vector3U7F25(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 SaturatingMul(U7F25 other) => new Vector3U7F25(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U7F25 other) {
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
        public U7F25 Dot(Vector3U7F25 other) {
            const ulong k = 1UL << 23;
            return U7F25.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U7F25 SaturatingDot(Vector3U7F25 other) {
            const ulong k = 1UL << 23;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U7F25.MaxValue;
            } else {
                return U7F25.FromBits((uint)bits);
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
        public U16F48 LengthSquared() {
            return U16F48.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U7F25 LengthHalf() => U7F25.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F24 Length() => U8F24.FromBits(LengthInternal());

    }

    partial struct U7F25 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 SaturatingMul(Vector3U7F25 other) => other.SaturatingMul(this);
    }
}
