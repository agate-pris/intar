using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U23F9 : IEquatable<Vector3U23F9>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U23F9 X;
        public U23F9 Y;
        public U23F9 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(U23F9 x, U23F9 y, U23F9 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(U23F9 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(U23F9 x, Vector2U23F9 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(Vector3U23F9 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(Vector2U23F9 xy, U23F9 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U23F9 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U23F9(U23F9.Zero);
        }
        public static Vector3U23F9 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U23F9(U23F9.One);
        }
        public static Vector3U23F9 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U23F9(U23F9.One, U23F9.Zero, U23F9.Zero);
        }
        public static Vector3U23F9 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U23F9(U23F9.Zero, U23F9.One, U23F9.Zero);
        }
        public static Vector3U23F9 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U23F9(U23F9.Zero, U23F9.Zero, U23F9.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator +(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator -(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator *(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator *(Vector3U23F9 a, U23F9 b) => new Vector3U23F9(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator *(U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator /(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator /(Vector3U23F9 a, U23F9 b) => new Vector3U23F9(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator /(U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U23F9 lhs, Vector3U23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U23F9 lhs, Vector3U23F9 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U23F9 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(X, X); }
        public Vector2U23F9 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(X, Y); }
        public Vector2U23F9 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(X, Z); }
        public Vector2U23F9 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Y, X); }
        public Vector2U23F9 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Y, Y); }
        public Vector2U23F9 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Y, Z); }
        public Vector2U23F9 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Z, X); }
        public Vector2U23F9 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Z, Y); }
        public Vector2U23F9 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Z, Z); }
        public Vector3U23F9 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, X, X); }
        public Vector3U23F9 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, X, Y); }
        public Vector3U23F9 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, X, Z); }
        public Vector3U23F9 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Y, X); }
        public Vector3U23F9 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Y, Y); }
        public Vector3U23F9 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Y, Z); }
        public Vector3U23F9 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Z, X); }
        public Vector3U23F9 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Z, Y); }
        public Vector3U23F9 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Z, Z); }
        public Vector3U23F9 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, X, X); }
        public Vector3U23F9 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, X, Y); }
        public Vector3U23F9 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, X, Z); }
        public Vector3U23F9 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Y, X); }
        public Vector3U23F9 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Y, Y); }
        public Vector3U23F9 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Y, Z); }
        public Vector3U23F9 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Z, X); }
        public Vector3U23F9 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Z, Y); }
        public Vector3U23F9 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Z, Z); }
        public Vector3U23F9 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, X, X); }
        public Vector3U23F9 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, X, Y); }
        public Vector3U23F9 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, X, Z); }
        public Vector3U23F9 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Y, X); }
        public Vector3U23F9 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Y, Y); }
        public Vector3U23F9 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Y, Z); }
        public Vector3U23F9 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Z, X); }
        public Vector3U23F9 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Z, Y); }
        public Vector3U23F9 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Z, Z); }
        public Vector4U23F9 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, X, X); }
        public Vector4U23F9 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, X, Y); }
        public Vector4U23F9 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, X, Z); }
        public Vector4U23F9 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Y, X); }
        public Vector4U23F9 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Y, Y); }
        public Vector4U23F9 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Y, Z); }
        public Vector4U23F9 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Z, X); }
        public Vector4U23F9 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Z, Y); }
        public Vector4U23F9 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Z, Z); }
        public Vector4U23F9 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, X, X); }
        public Vector4U23F9 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, X, Y); }
        public Vector4U23F9 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, X, Z); }
        public Vector4U23F9 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Y, X); }
        public Vector4U23F9 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Y, Y); }
        public Vector4U23F9 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Y, Z); }
        public Vector4U23F9 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Z, X); }
        public Vector4U23F9 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Z, Y); }
        public Vector4U23F9 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Z, Z); }
        public Vector4U23F9 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, X, X); }
        public Vector4U23F9 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, X, Y); }
        public Vector4U23F9 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, X, Z); }
        public Vector4U23F9 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Y, X); }
        public Vector4U23F9 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Y, Y); }
        public Vector4U23F9 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Y, Z); }
        public Vector4U23F9 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Z, X); }
        public Vector4U23F9 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Z, Y); }
        public Vector4U23F9 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Z, Z); }
        public Vector4U23F9 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, X, X); }
        public Vector4U23F9 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, X, Y); }
        public Vector4U23F9 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, X, Z); }
        public Vector4U23F9 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Y, X); }
        public Vector4U23F9 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Y, Y); }
        public Vector4U23F9 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Y, Z); }
        public Vector4U23F9 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Z, X); }
        public Vector4U23F9 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Z, Y); }
        public Vector4U23F9 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Z, Z); }
        public Vector4U23F9 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, X, X); }
        public Vector4U23F9 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, X, Y); }
        public Vector4U23F9 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, X, Z); }
        public Vector4U23F9 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Y, X); }
        public Vector4U23F9 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Y, Y); }
        public Vector4U23F9 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Y, Z); }
        public Vector4U23F9 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Z, X); }
        public Vector4U23F9 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Z, Y); }
        public Vector4U23F9 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Z, Z); }
        public Vector4U23F9 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, X, X); }
        public Vector4U23F9 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, X, Y); }
        public Vector4U23F9 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, X, Z); }
        public Vector4U23F9 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Y, X); }
        public Vector4U23F9 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Y, Y); }
        public Vector4U23F9 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Y, Z); }
        public Vector4U23F9 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Z, X); }
        public Vector4U23F9 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Z, Y); }
        public Vector4U23F9 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Z, Z); }
        public Vector4U23F9 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, X, X); }
        public Vector4U23F9 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, X, Y); }
        public Vector4U23F9 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, X, Z); }
        public Vector4U23F9 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Y, X); }
        public Vector4U23F9 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Y, Y); }
        public Vector4U23F9 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Y, Z); }
        public Vector4U23F9 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Z, X); }
        public Vector4U23F9 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Z, Y); }
        public Vector4U23F9 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Z, Z); }
        public Vector4U23F9 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, X, X); }
        public Vector4U23F9 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, X, Y); }
        public Vector4U23F9 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, X, Z); }
        public Vector4U23F9 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Y, X); }
        public Vector4U23F9 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Y, Y); }
        public Vector4U23F9 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Y, Z); }
        public Vector4U23F9 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Z, X); }
        public Vector4U23F9 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Z, Y); }
        public Vector4U23F9 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Z, Z); }
        public Vector4U23F9 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, X, X); }
        public Vector4U23F9 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, X, Y); }
        public Vector4U23F9 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, X, Z); }
        public Vector4U23F9 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Y, X); }
        public Vector4U23F9 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Y, Y); }
        public Vector4U23F9 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Y, Z); }
        public Vector4U23F9 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Z, X); }
        public Vector4U23F9 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Z, Y); }
        public Vector4U23F9 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U23F9 other)
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
        public Vector3U23F9 Min(Vector3U23F9 other) => new Vector3U23F9(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 Max(Vector3U23F9 other) => new Vector3U23F9(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 Half() => new Vector3U23F9(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 Twice() => new Vector3U23F9(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 Clamp(U23F9 min, U23F9 max) => new Vector3U23F9(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 Clamp(
            Vector3U23F9 min, Vector3U23F9 max
        ) => new Vector3U23F9(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 WrappingAdd(Vector3U23F9 other) => new Vector3U23F9(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 WrappingSub(Vector3U23F9 other) => new Vector3U23F9(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 WrappingMul(Vector3U23F9 other) => new Vector3U23F9(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 WrappingAddSigned(Vector3I23F9 other) => new Vector3U23F9(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 SaturatingAdd(Vector3U23F9 other) => new Vector3U23F9(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 SaturatingMul(U23F9 other) => new Vector3U23F9(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U23F9 other) {
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
        public U23F9 Dot(Vector3U23F9 other) {
            const ulong k = 1UL << 7;
            return U23F9.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U23F9 SaturatingDot(Vector3U23F9 other) {
            const ulong k = 1UL << 7;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U23F9.MaxValue;
            } else {
                return U23F9.FromBits((uint)bits);
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
        public U48F16 LengthSquared() {
            return U48F16.FromBits(LengthSquaredInternal());
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
        public U23F9 LengthHalf() => U23F9.FromBits(LengthInternal());

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
        public I23F9 LengthHalfSigned() => I23F9.FromBits(checked((int)LengthInternal()));

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
        public U24F8 LengthUnsigned() => U24F8.FromBits(LengthInternal());

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
        public I24F8 LengthSigned() => I24F8.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U24F8 Length() => LengthUnsigned();

    }

    partial struct U23F9 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 SaturatingMul(Vector3U23F9 other) => other.SaturatingMul(this);
    }
}
