using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U21F11 : IEquatable<Vector3U21F11>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U21F11 X;
        public U21F11 Y;
        public U21F11 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(U21F11 x, U21F11 y, U21F11 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(U21F11 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(U21F11 x, Vector2U21F11 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(Vector3U21F11 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(Vector2U21F11 xy, U21F11 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U21F11 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U21F11(U21F11.Zero);
        }
        public static Vector3U21F11 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U21F11(U21F11.One);
        }
        public static Vector3U21F11 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U21F11(U21F11.One, U21F11.Zero, U21F11.Zero);
        }
        public static Vector3U21F11 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U21F11(U21F11.Zero, U21F11.One, U21F11.Zero);
        }
        public static Vector3U21F11 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U21F11(U21F11.Zero, U21F11.Zero, U21F11.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator +(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator -(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator *(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator *(Vector3U21F11 a, U21F11 b) => new Vector3U21F11(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator *(U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator /(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator /(Vector3U21F11 a, U21F11 b) => new Vector3U21F11(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator /(U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U21F11 lhs, Vector3U21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U21F11 lhs, Vector3U21F11 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U21F11 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, X); }
        public Vector2U21F11 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, Y); }
        public Vector2U21F11 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, Z); }
        public Vector2U21F11 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, X); }
        public Vector2U21F11 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, Y); }
        public Vector2U21F11 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, Z); }
        public Vector2U21F11 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, X); }
        public Vector2U21F11 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, Y); }
        public Vector2U21F11 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, Z); }
        public Vector3U21F11 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, X); }
        public Vector3U21F11 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, Y); }
        public Vector3U21F11 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, Z); }
        public Vector3U21F11 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, X); }
        public Vector3U21F11 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, Y); }
        public Vector3U21F11 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, Z); }
        public Vector3U21F11 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, X); }
        public Vector3U21F11 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, Y); }
        public Vector3U21F11 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, Z); }
        public Vector3U21F11 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, X); }
        public Vector3U21F11 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, Y); }
        public Vector3U21F11 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, Z); }
        public Vector3U21F11 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, X); }
        public Vector3U21F11 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, Y); }
        public Vector3U21F11 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, Z); }
        public Vector3U21F11 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, X); }
        public Vector3U21F11 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, Y); }
        public Vector3U21F11 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, Z); }
        public Vector3U21F11 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, X); }
        public Vector3U21F11 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, Y); }
        public Vector3U21F11 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, Z); }
        public Vector3U21F11 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, X); }
        public Vector3U21F11 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, Y); }
        public Vector3U21F11 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, Z); }
        public Vector3U21F11 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, X); }
        public Vector3U21F11 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, Y); }
        public Vector3U21F11 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, Z); }
        public Vector4U21F11 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, X); }
        public Vector4U21F11 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, Y); }
        public Vector4U21F11 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, Z); }
        public Vector4U21F11 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, X); }
        public Vector4U21F11 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, Y); }
        public Vector4U21F11 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, Z); }
        public Vector4U21F11 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, X); }
        public Vector4U21F11 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, Y); }
        public Vector4U21F11 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, Z); }
        public Vector4U21F11 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, X); }
        public Vector4U21F11 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, Y); }
        public Vector4U21F11 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, Z); }
        public Vector4U21F11 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, X); }
        public Vector4U21F11 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, Y); }
        public Vector4U21F11 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, Z); }
        public Vector4U21F11 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, X); }
        public Vector4U21F11 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, Y); }
        public Vector4U21F11 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, Z); }
        public Vector4U21F11 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, X); }
        public Vector4U21F11 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, Y); }
        public Vector4U21F11 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, Z); }
        public Vector4U21F11 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, X); }
        public Vector4U21F11 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, Y); }
        public Vector4U21F11 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, Z); }
        public Vector4U21F11 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, X); }
        public Vector4U21F11 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, Y); }
        public Vector4U21F11 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, Z); }
        public Vector4U21F11 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, X); }
        public Vector4U21F11 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, Y); }
        public Vector4U21F11 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, Z); }
        public Vector4U21F11 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, X); }
        public Vector4U21F11 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, Y); }
        public Vector4U21F11 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, Z); }
        public Vector4U21F11 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, X); }
        public Vector4U21F11 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, Y); }
        public Vector4U21F11 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, Z); }
        public Vector4U21F11 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, X); }
        public Vector4U21F11 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, Y); }
        public Vector4U21F11 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, Z); }
        public Vector4U21F11 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, X); }
        public Vector4U21F11 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, Y); }
        public Vector4U21F11 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, Z); }
        public Vector4U21F11 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, X); }
        public Vector4U21F11 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, Y); }
        public Vector4U21F11 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, Z); }
        public Vector4U21F11 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, X); }
        public Vector4U21F11 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, Y); }
        public Vector4U21F11 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, Z); }
        public Vector4U21F11 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, X); }
        public Vector4U21F11 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, Y); }
        public Vector4U21F11 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, Z); }
        public Vector4U21F11 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, X); }
        public Vector4U21F11 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, Y); }
        public Vector4U21F11 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, Z); }
        public Vector4U21F11 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, X); }
        public Vector4U21F11 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, Y); }
        public Vector4U21F11 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, Z); }
        public Vector4U21F11 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, X); }
        public Vector4U21F11 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, Y); }
        public Vector4U21F11 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, Z); }
        public Vector4U21F11 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, X); }
        public Vector4U21F11 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, Y); }
        public Vector4U21F11 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, Z); }
        public Vector4U21F11 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, X); }
        public Vector4U21F11 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, Y); }
        public Vector4U21F11 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, Z); }
        public Vector4U21F11 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, X); }
        public Vector4U21F11 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, Y); }
        public Vector4U21F11 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, Z); }
        public Vector4U21F11 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, X); }
        public Vector4U21F11 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, Y); }
        public Vector4U21F11 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, Z); }
        public Vector4U21F11 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, X); }
        public Vector4U21F11 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, Y); }
        public Vector4U21F11 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, Z); }
        public Vector4U21F11 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, X); }
        public Vector4U21F11 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, Y); }
        public Vector4U21F11 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, Z); }
        public Vector4U21F11 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, X); }
        public Vector4U21F11 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, Y); }
        public Vector4U21F11 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U21F11 other)
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
        public Vector3U21F11 Min(Vector3U21F11 other) => new Vector3U21F11(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 Max(Vector3U21F11 other) => new Vector3U21F11(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 Half() => new Vector3U21F11(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 Twice() => new Vector3U21F11(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 Clamp(U21F11 min, U21F11 max) => new Vector3U21F11(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 Clamp(
            Vector3U21F11 min, Vector3U21F11 max
        ) => new Vector3U21F11(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 WrappingAdd(Vector3U21F11 other) => new Vector3U21F11(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 WrappingSub(Vector3U21F11 other) => new Vector3U21F11(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 WrappingMul(Vector3U21F11 other) => new Vector3U21F11(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 WrappingAddSigned(Vector3I21F11 other) => new Vector3U21F11(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 SaturatingAdd(Vector3U21F11 other) => new Vector3U21F11(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 SaturatingMul(U21F11 other) => new Vector3U21F11(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U21F11 other) {
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
        public U21F11 Dot(Vector3U21F11 other) {
            const ulong k = 1UL << 9;
            return U21F11.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11 SaturatingDot(Vector3U21F11 other) {
            const ulong k = 1UL << 9;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U21F11.MaxValue;
            } else {
                return U21F11.FromBits((uint)bits);
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
        public U44F20 LengthSquared() {
            return U44F20.FromBits(LengthSquaredInternal());
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
        public U21F11 LengthHalf() => U21F11.FromBits(LengthInternal());

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
        public I21F11 LengthHalfSigned() => I21F11.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U22F10 Length() => U22F10.FromBits(LengthInternal());

    }

    partial struct U21F11 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 SaturatingMul(Vector3U21F11 other) => other.SaturatingMul(this);
    }
}
