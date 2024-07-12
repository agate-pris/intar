using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U8F24 : IEquatable<Vector3U8F24>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U8F24 X;
        public U8F24 Y;
        public U8F24 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24(U8F24 x, U8F24 y, U8F24 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24(U8F24 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24(U8F24 x, Vector2U8F24 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24(Vector3U8F24 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24(Vector2U8F24 xy, U8F24 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U8F24 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U8F24(U8F24.Zero);
        }
        public static Vector3U8F24 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U8F24(U8F24.One);
        }
        public static Vector3U8F24 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U8F24(U8F24.One, U8F24.Zero, U8F24.Zero);
        }
        public static Vector3U8F24 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U8F24(U8F24.Zero, U8F24.One, U8F24.Zero);
        }
        public static Vector3U8F24 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U8F24(U8F24.Zero, U8F24.Zero, U8F24.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator +(Vector3U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator -(Vector3U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator *(Vector3U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator *(Vector3U8F24 a, U8F24 b) => new Vector3U8F24(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator *(U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator /(Vector3U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator /(Vector3U8F24 a, U8F24 b) => new Vector3U8F24(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator /(U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U8F24 lhs, Vector3U8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U8F24 lhs, Vector3U8F24 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U8F24 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(X, X); }
        public Vector2U8F24 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(X, Y); }
        public Vector2U8F24 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(X, Z); }
        public Vector2U8F24 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Y, X); }
        public Vector2U8F24 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Y, Y); }
        public Vector2U8F24 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Y, Z); }
        public Vector2U8F24 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Z, X); }
        public Vector2U8F24 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Z, Y); }
        public Vector2U8F24 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Z, Z); }
        public Vector3U8F24 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, X, X); }
        public Vector3U8F24 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, X, Y); }
        public Vector3U8F24 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, X, Z); }
        public Vector3U8F24 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Y, X); }
        public Vector3U8F24 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Y, Y); }
        public Vector3U8F24 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Y, Z); }
        public Vector3U8F24 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Z, X); }
        public Vector3U8F24 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Z, Y); }
        public Vector3U8F24 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Z, Z); }
        public Vector3U8F24 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, X, X); }
        public Vector3U8F24 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, X, Y); }
        public Vector3U8F24 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, X, Z); }
        public Vector3U8F24 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Y, X); }
        public Vector3U8F24 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Y, Y); }
        public Vector3U8F24 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Y, Z); }
        public Vector3U8F24 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Z, X); }
        public Vector3U8F24 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Z, Y); }
        public Vector3U8F24 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Z, Z); }
        public Vector3U8F24 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, X, X); }
        public Vector3U8F24 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, X, Y); }
        public Vector3U8F24 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, X, Z); }
        public Vector3U8F24 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Y, X); }
        public Vector3U8F24 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Y, Y); }
        public Vector3U8F24 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Y, Z); }
        public Vector3U8F24 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Z, X); }
        public Vector3U8F24 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Z, Y); }
        public Vector3U8F24 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Z, Z); }
        public Vector4U8F24 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, X, X); }
        public Vector4U8F24 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, X, Y); }
        public Vector4U8F24 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, X, Z); }
        public Vector4U8F24 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Y, X); }
        public Vector4U8F24 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Y, Y); }
        public Vector4U8F24 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Y, Z); }
        public Vector4U8F24 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Z, X); }
        public Vector4U8F24 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Z, Y); }
        public Vector4U8F24 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Z, Z); }
        public Vector4U8F24 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, X, X); }
        public Vector4U8F24 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, X, Y); }
        public Vector4U8F24 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, X, Z); }
        public Vector4U8F24 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Y, X); }
        public Vector4U8F24 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Y, Y); }
        public Vector4U8F24 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Y, Z); }
        public Vector4U8F24 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Z, X); }
        public Vector4U8F24 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Z, Y); }
        public Vector4U8F24 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Z, Z); }
        public Vector4U8F24 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, X, X); }
        public Vector4U8F24 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, X, Y); }
        public Vector4U8F24 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, X, Z); }
        public Vector4U8F24 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Y, X); }
        public Vector4U8F24 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Y, Y); }
        public Vector4U8F24 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Y, Z); }
        public Vector4U8F24 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Z, X); }
        public Vector4U8F24 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Z, Y); }
        public Vector4U8F24 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Z, Z); }
        public Vector4U8F24 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, X, X); }
        public Vector4U8F24 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, X, Y); }
        public Vector4U8F24 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, X, Z); }
        public Vector4U8F24 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Y, X); }
        public Vector4U8F24 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Y, Y); }
        public Vector4U8F24 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Y, Z); }
        public Vector4U8F24 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Z, X); }
        public Vector4U8F24 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Z, Y); }
        public Vector4U8F24 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Z, Z); }
        public Vector4U8F24 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, X, X); }
        public Vector4U8F24 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, X, Y); }
        public Vector4U8F24 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, X, Z); }
        public Vector4U8F24 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Y, X); }
        public Vector4U8F24 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Y, Y); }
        public Vector4U8F24 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Y, Z); }
        public Vector4U8F24 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Z, X); }
        public Vector4U8F24 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Z, Y); }
        public Vector4U8F24 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Z, Z); }
        public Vector4U8F24 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, X, X); }
        public Vector4U8F24 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, X, Y); }
        public Vector4U8F24 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, X, Z); }
        public Vector4U8F24 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Y, X); }
        public Vector4U8F24 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Y, Y); }
        public Vector4U8F24 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Y, Z); }
        public Vector4U8F24 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Z, X); }
        public Vector4U8F24 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Z, Y); }
        public Vector4U8F24 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Z, Z); }
        public Vector4U8F24 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, X, X); }
        public Vector4U8F24 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, X, Y); }
        public Vector4U8F24 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, X, Z); }
        public Vector4U8F24 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Y, X); }
        public Vector4U8F24 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Y, Y); }
        public Vector4U8F24 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Y, Z); }
        public Vector4U8F24 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Z, X); }
        public Vector4U8F24 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Z, Y); }
        public Vector4U8F24 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Z, Z); }
        public Vector4U8F24 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, X, X); }
        public Vector4U8F24 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, X, Y); }
        public Vector4U8F24 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, X, Z); }
        public Vector4U8F24 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Y, X); }
        public Vector4U8F24 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Y, Y); }
        public Vector4U8F24 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Y, Z); }
        public Vector4U8F24 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Z, X); }
        public Vector4U8F24 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Z, Y); }
        public Vector4U8F24 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Z, Z); }
        public Vector4U8F24 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, X, X); }
        public Vector4U8F24 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, X, Y); }
        public Vector4U8F24 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, X, Z); }
        public Vector4U8F24 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Y, X); }
        public Vector4U8F24 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Y, Y); }
        public Vector4U8F24 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Y, Z); }
        public Vector4U8F24 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Z, X); }
        public Vector4U8F24 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Z, Y); }
        public Vector4U8F24 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U8F24 other)
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
        public Vector3U8F24 Min(Vector3U8F24 other) => new Vector3U8F24(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Max(Vector3U8F24 other) => new Vector3U8F24(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Half() => new Vector3U8F24(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Twice() => new Vector3U8F24(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Clamp(U8F24 min, U8F24 max) => new Vector3U8F24(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Clamp(
            Vector3U8F24 min, Vector3U8F24 max
        ) => new Vector3U8F24(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 WrappingAdd(Vector3U8F24 other) => new Vector3U8F24(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 WrappingSub(Vector3U8F24 other) => new Vector3U8F24(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 WrappingMul(Vector3U8F24 other) => new Vector3U8F24(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 WrappingAddSigned(Vector3I8F24 other) => new Vector3U8F24(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 SaturatingAdd(Vector3U8F24 other) => new Vector3U8F24(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 SaturatingMul(U8F24 other) => new Vector3U8F24(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U8F24 other) {
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
        public U8F24 Dot(Vector3U8F24 other) {
            const ulong k = 1UL << 22;
            return U8F24.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F24 SaturatingDot(Vector3U8F24 other) {
            const ulong k = 1UL << 22;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U8F24.MaxValue;
            } else {
                return U8F24.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// ベクトルの長さの 2 乗を返します｡
        /// </summary>
        /// <remarks>
        /// オーバーフローを防ぐため､ 計算の過程で 4 で除算しています｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U18F46 LengthSquared() {
            return U18F46.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F24 LengthHalf() => U8F24.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U9F23 Length() => U9F23.FromBits(LengthInternal());

    }

    partial struct U8F24 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 SaturatingMul(Vector3U8F24 other) => other.SaturatingMul(this);
    }
}
