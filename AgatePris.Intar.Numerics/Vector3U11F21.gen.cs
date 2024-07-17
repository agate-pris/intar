using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U11F21 : IEquatable<Vector3U11F21>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U11F21 X;
        public U11F21 Y;
        public U11F21 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21(U11F21 x, U11F21 y, U11F21 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21(U11F21 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21(U11F21 x, Vector2U11F21 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21(Vector3U11F21 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21(Vector2U11F21 xy, U11F21 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U11F21 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U11F21(U11F21.Zero);
        }
        public static Vector3U11F21 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U11F21(U11F21.One);
        }
        public static Vector3U11F21 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U11F21(U11F21.One, U11F21.Zero, U11F21.Zero);
        }
        public static Vector3U11F21 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U11F21(U11F21.Zero, U11F21.One, U11F21.Zero);
        }
        public static Vector3U11F21 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U11F21(U11F21.Zero, U11F21.Zero, U11F21.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator +(Vector3U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator -(Vector3U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator *(Vector3U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator *(Vector3U11F21 a, U11F21 b) => new Vector3U11F21(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator *(U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator /(Vector3U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator /(Vector3U11F21 a, U11F21 b) => new Vector3U11F21(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator /(U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U11F21 lhs, Vector3U11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U11F21 lhs, Vector3U11F21 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U11F21 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, X); }
        public Vector2U11F21 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, Y); }
        public Vector2U11F21 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, Z); }
        public Vector2U11F21 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, X); }
        public Vector2U11F21 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, Y); }
        public Vector2U11F21 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, Z); }
        public Vector2U11F21 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Z, X); }
        public Vector2U11F21 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Z, Y); }
        public Vector2U11F21 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Z, Z); }
        public Vector3U11F21 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, X); }
        public Vector3U11F21 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, Y); }
        public Vector3U11F21 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, Z); }
        public Vector3U11F21 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, X); }
        public Vector3U11F21 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, Y); }
        public Vector3U11F21 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, Z); }
        public Vector3U11F21 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Z, X); }
        public Vector3U11F21 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Z, Y); }
        public Vector3U11F21 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Z, Z); }
        public Vector3U11F21 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, X); }
        public Vector3U11F21 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, Y); }
        public Vector3U11F21 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, Z); }
        public Vector3U11F21 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, X); }
        public Vector3U11F21 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, Y); }
        public Vector3U11F21 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, Z); }
        public Vector3U11F21 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Z, X); }
        public Vector3U11F21 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Z, Y); }
        public Vector3U11F21 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Z, Z); }
        public Vector3U11F21 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, X, X); }
        public Vector3U11F21 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, X, Y); }
        public Vector3U11F21 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, X, Z); }
        public Vector3U11F21 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Y, X); }
        public Vector3U11F21 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Y, Y); }
        public Vector3U11F21 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Y, Z); }
        public Vector3U11F21 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Z, X); }
        public Vector3U11F21 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Z, Y); }
        public Vector3U11F21 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Z, Z); }
        public Vector4U11F21 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, X); }
        public Vector4U11F21 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, Y); }
        public Vector4U11F21 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, Z); }
        public Vector4U11F21 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, X); }
        public Vector4U11F21 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, Y); }
        public Vector4U11F21 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, Z); }
        public Vector4U11F21 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Z, X); }
        public Vector4U11F21 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Z, Y); }
        public Vector4U11F21 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Z, Z); }
        public Vector4U11F21 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, X); }
        public Vector4U11F21 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, Y); }
        public Vector4U11F21 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, Z); }
        public Vector4U11F21 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, X); }
        public Vector4U11F21 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, Y); }
        public Vector4U11F21 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, Z); }
        public Vector4U11F21 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Z, X); }
        public Vector4U11F21 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Z, Y); }
        public Vector4U11F21 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Z, Z); }
        public Vector4U11F21 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, X, X); }
        public Vector4U11F21 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, X, Y); }
        public Vector4U11F21 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, X, Z); }
        public Vector4U11F21 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Y, X); }
        public Vector4U11F21 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Y, Y); }
        public Vector4U11F21 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Y, Z); }
        public Vector4U11F21 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Z, X); }
        public Vector4U11F21 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Z, Y); }
        public Vector4U11F21 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Z, Z); }
        public Vector4U11F21 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, X); }
        public Vector4U11F21 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, Y); }
        public Vector4U11F21 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, Z); }
        public Vector4U11F21 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, X); }
        public Vector4U11F21 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, Y); }
        public Vector4U11F21 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, Z); }
        public Vector4U11F21 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Z, X); }
        public Vector4U11F21 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Z, Y); }
        public Vector4U11F21 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Z, Z); }
        public Vector4U11F21 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, X); }
        public Vector4U11F21 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, Y); }
        public Vector4U11F21 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, Z); }
        public Vector4U11F21 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, X); }
        public Vector4U11F21 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, Y); }
        public Vector4U11F21 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, Z); }
        public Vector4U11F21 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Z, X); }
        public Vector4U11F21 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Z, Y); }
        public Vector4U11F21 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Z, Z); }
        public Vector4U11F21 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, X, X); }
        public Vector4U11F21 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, X, Y); }
        public Vector4U11F21 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, X, Z); }
        public Vector4U11F21 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Y, X); }
        public Vector4U11F21 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Y, Y); }
        public Vector4U11F21 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Y, Z); }
        public Vector4U11F21 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Z, X); }
        public Vector4U11F21 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Z, Y); }
        public Vector4U11F21 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Z, Z); }
        public Vector4U11F21 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, X, X); }
        public Vector4U11F21 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, X, Y); }
        public Vector4U11F21 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, X, Z); }
        public Vector4U11F21 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Y, X); }
        public Vector4U11F21 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Y, Y); }
        public Vector4U11F21 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Y, Z); }
        public Vector4U11F21 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Z, X); }
        public Vector4U11F21 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Z, Y); }
        public Vector4U11F21 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Z, Z); }
        public Vector4U11F21 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, X, X); }
        public Vector4U11F21 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, X, Y); }
        public Vector4U11F21 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, X, Z); }
        public Vector4U11F21 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Y, X); }
        public Vector4U11F21 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Y, Y); }
        public Vector4U11F21 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Y, Z); }
        public Vector4U11F21 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Z, X); }
        public Vector4U11F21 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Z, Y); }
        public Vector4U11F21 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Z, Z); }
        public Vector4U11F21 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, X, X); }
        public Vector4U11F21 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, X, Y); }
        public Vector4U11F21 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, X, Z); }
        public Vector4U11F21 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Y, X); }
        public Vector4U11F21 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Y, Y); }
        public Vector4U11F21 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Y, Z); }
        public Vector4U11F21 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Z, X); }
        public Vector4U11F21 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Z, Y); }
        public Vector4U11F21 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U11F21 other)
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
        public Vector3U11F21 Min(Vector3U11F21 other) => new Vector3U11F21(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 Max(Vector3U11F21 other) => new Vector3U11F21(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 Half() => new Vector3U11F21(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 Twice() => new Vector3U11F21(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 Clamp(U11F21 min, U11F21 max) => new Vector3U11F21(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 Clamp(
            Vector3U11F21 min, Vector3U11F21 max
        ) => new Vector3U11F21(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 WrappingAdd(Vector3U11F21 other) => new Vector3U11F21(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 WrappingSub(Vector3U11F21 other) => new Vector3U11F21(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 WrappingMul(Vector3U11F21 other) => new Vector3U11F21(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 WrappingAddSigned(Vector3I11F21 other) => new Vector3U11F21(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 SaturatingAdd(Vector3U11F21 other) => new Vector3U11F21(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 SaturatingMul(U11F21 other) => new Vector3U11F21(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U11F21 other) {
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
        public U11F21 Dot(Vector3U11F21 other) {
            const ulong k = 1UL << 19;
            return U11F21.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U11F21 SaturatingDot(Vector3U11F21 other) {
            const ulong k = 1UL << 19;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U11F21.MaxValue;
            } else {
                return U11F21.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U24F40 LengthSquaredUnsigned() => U24F40.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I24F40 LengthSquaredSigned() => I24F40.FromBits(
            (long)LengthSquaredInternal()
        );

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
        public U24F40 LengthSquared() => LengthSquaredUnsigned();

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
        public U11F21 LengthHalf() => U11F21.FromBits(LengthInternal());

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
        public I11F21 LengthHalfSigned() => I11F21.FromBits(checked((int)LengthInternal()));

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
        public U12F20 LengthUnsigned() => U12F20.FromBits(LengthInternal());

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
        public I12F20 LengthSigned() => I12F20.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U12F20 Length() => LengthUnsigned();

    }

    partial struct U11F21 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21 SaturatingMul(Vector3U11F21 other) => other.SaturatingMul(this);
    }
}
