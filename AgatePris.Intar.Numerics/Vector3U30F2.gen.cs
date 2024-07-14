using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U30F2 : IEquatable<Vector3U30F2>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U30F2 X;
        public U30F2 Y;
        public U30F2 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2(U30F2 x, U30F2 y, U30F2 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2(U30F2 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2(U30F2 x, Vector2U30F2 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2(Vector3U30F2 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2(Vector2U30F2 xy, U30F2 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U30F2 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U30F2(U30F2.Zero);
        }
        public static Vector3U30F2 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U30F2(U30F2.One);
        }
        public static Vector3U30F2 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U30F2(U30F2.One, U30F2.Zero, U30F2.Zero);
        }
        public static Vector3U30F2 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U30F2(U30F2.Zero, U30F2.One, U30F2.Zero);
        }
        public static Vector3U30F2 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U30F2(U30F2.Zero, U30F2.Zero, U30F2.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 operator +(Vector3U30F2 a, Vector3U30F2 b) => new Vector3U30F2(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 operator -(Vector3U30F2 a, Vector3U30F2 b) => new Vector3U30F2(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 operator *(Vector3U30F2 a, Vector3U30F2 b) => new Vector3U30F2(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 operator *(Vector3U30F2 a, U30F2 b) => new Vector3U30F2(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 operator *(U30F2 a, Vector3U30F2 b) => new Vector3U30F2(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 operator /(Vector3U30F2 a, Vector3U30F2 b) => new Vector3U30F2(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 operator /(Vector3U30F2 a, U30F2 b) => new Vector3U30F2(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 operator /(U30F2 a, Vector3U30F2 b) => new Vector3U30F2(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U30F2 lhs, Vector3U30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U30F2 lhs, Vector3U30F2 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U30F2 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, X); }
        public Vector2U30F2 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, Y); }
        public Vector2U30F2 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, Z); }
        public Vector2U30F2 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, X); }
        public Vector2U30F2 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, Y); }
        public Vector2U30F2 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, Z); }
        public Vector2U30F2 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, X); }
        public Vector2U30F2 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, Y); }
        public Vector2U30F2 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, Z); }
        public Vector3U30F2 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, X); }
        public Vector3U30F2 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, Y); }
        public Vector3U30F2 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, Z); }
        public Vector3U30F2 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, X); }
        public Vector3U30F2 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, Y); }
        public Vector3U30F2 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, Z); }
        public Vector3U30F2 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, X); }
        public Vector3U30F2 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, Y); }
        public Vector3U30F2 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, Z); }
        public Vector3U30F2 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, X); }
        public Vector3U30F2 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, Y); }
        public Vector3U30F2 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, Z); }
        public Vector3U30F2 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, X); }
        public Vector3U30F2 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, Y); }
        public Vector3U30F2 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, Z); }
        public Vector3U30F2 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, X); }
        public Vector3U30F2 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, Y); }
        public Vector3U30F2 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, Z); }
        public Vector3U30F2 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, X); }
        public Vector3U30F2 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, Y); }
        public Vector3U30F2 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, Z); }
        public Vector3U30F2 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, X); }
        public Vector3U30F2 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, Y); }
        public Vector3U30F2 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, Z); }
        public Vector3U30F2 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, X); }
        public Vector3U30F2 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, Y); }
        public Vector3U30F2 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, Z); }
        public Vector4U30F2 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, X); }
        public Vector4U30F2 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, Y); }
        public Vector4U30F2 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, Z); }
        public Vector4U30F2 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, X); }
        public Vector4U30F2 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, Y); }
        public Vector4U30F2 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, Z); }
        public Vector4U30F2 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, X); }
        public Vector4U30F2 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, Y); }
        public Vector4U30F2 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, Z); }
        public Vector4U30F2 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, X); }
        public Vector4U30F2 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, Y); }
        public Vector4U30F2 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, Z); }
        public Vector4U30F2 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, X); }
        public Vector4U30F2 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, Y); }
        public Vector4U30F2 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, Z); }
        public Vector4U30F2 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, X); }
        public Vector4U30F2 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, Y); }
        public Vector4U30F2 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, Z); }
        public Vector4U30F2 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, X); }
        public Vector4U30F2 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, Y); }
        public Vector4U30F2 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, Z); }
        public Vector4U30F2 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, X); }
        public Vector4U30F2 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, Y); }
        public Vector4U30F2 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, Z); }
        public Vector4U30F2 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, X); }
        public Vector4U30F2 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, Y); }
        public Vector4U30F2 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, Z); }
        public Vector4U30F2 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, X); }
        public Vector4U30F2 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, Y); }
        public Vector4U30F2 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, Z); }
        public Vector4U30F2 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, X); }
        public Vector4U30F2 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, Y); }
        public Vector4U30F2 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, Z); }
        public Vector4U30F2 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, X); }
        public Vector4U30F2 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, Y); }
        public Vector4U30F2 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, Z); }
        public Vector4U30F2 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, X); }
        public Vector4U30F2 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, Y); }
        public Vector4U30F2 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, Z); }
        public Vector4U30F2 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, X); }
        public Vector4U30F2 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, Y); }
        public Vector4U30F2 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, Z); }
        public Vector4U30F2 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, X); }
        public Vector4U30F2 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, Y); }
        public Vector4U30F2 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, Z); }
        public Vector4U30F2 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, X); }
        public Vector4U30F2 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, Y); }
        public Vector4U30F2 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, Z); }
        public Vector4U30F2 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, X); }
        public Vector4U30F2 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, Y); }
        public Vector4U30F2 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, Z); }
        public Vector4U30F2 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, X); }
        public Vector4U30F2 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, Y); }
        public Vector4U30F2 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, Z); }
        public Vector4U30F2 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, X); }
        public Vector4U30F2 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, Y); }
        public Vector4U30F2 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, Z); }
        public Vector4U30F2 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, X); }
        public Vector4U30F2 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, Y); }
        public Vector4U30F2 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, Z); }
        public Vector4U30F2 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, X); }
        public Vector4U30F2 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, Y); }
        public Vector4U30F2 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, Z); }
        public Vector4U30F2 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, X); }
        public Vector4U30F2 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, Y); }
        public Vector4U30F2 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, Z); }
        public Vector4U30F2 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, X); }
        public Vector4U30F2 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, Y); }
        public Vector4U30F2 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, Z); }
        public Vector4U30F2 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, X); }
        public Vector4U30F2 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, Y); }
        public Vector4U30F2 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, Z); }
        public Vector4U30F2 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, X); }
        public Vector4U30F2 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, Y); }
        public Vector4U30F2 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, Z); }
        public Vector4U30F2 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, X); }
        public Vector4U30F2 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, Y); }
        public Vector4U30F2 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, Z); }
        public Vector4U30F2 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, X); }
        public Vector4U30F2 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, Y); }
        public Vector4U30F2 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U30F2 other)
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
        public Vector3U30F2 Min(Vector3U30F2 other) => new Vector3U30F2(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 Max(Vector3U30F2 other) => new Vector3U30F2(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 Half() => new Vector3U30F2(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 Twice() => new Vector3U30F2(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 Clamp(U30F2 min, U30F2 max) => new Vector3U30F2(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 Clamp(
            Vector3U30F2 min, Vector3U30F2 max
        ) => new Vector3U30F2(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 WrappingAdd(Vector3U30F2 other) => new Vector3U30F2(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 WrappingSub(Vector3U30F2 other) => new Vector3U30F2(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 WrappingMul(Vector3U30F2 other) => new Vector3U30F2(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 WrappingAddSigned(Vector3I30F2 other) => new Vector3U30F2(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 SaturatingAdd(Vector3U30F2 other) => new Vector3U30F2(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 SaturatingMul(U30F2 other) => new Vector3U30F2(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U30F2 other) {
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
        public U30F2 Dot(Vector3U30F2 other) {
            const ulong k = 1UL << 0;
            return U30F2.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U30F2 SaturatingDot(Vector3U30F2 other) {
            const ulong k = 1UL << 0;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U30F2.MaxValue;
            } else {
                return U30F2.FromBits((uint)bits);
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
        public U62F2 LengthSquared() {
            return U62F2.FromBits(LengthSquaredInternal());
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
        public U30F2 LengthHalf() => U30F2.FromBits(LengthInternal());

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
        public I30F2 LengthHalfSigned() => I30F2.FromBits(checked((int)LengthInternal()));

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
        public U31F1 Length() => U31F1.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
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
        public I31F1 LengthSigned() => I31F1.FromBits(checked((int)LengthInternal()));

    }

    partial struct U30F2 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 SaturatingMul(Vector3U30F2 other) => other.SaturatingMul(this);
    }
}
