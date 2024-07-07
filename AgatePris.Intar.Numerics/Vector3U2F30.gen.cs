using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U2F30 : IEquatable<Vector3U2F30>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U2F30 X;
        public U2F30 Y;
        public U2F30 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30(U2F30 x, U2F30 y, U2F30 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30(U2F30 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30(U2F30 x, Vector2U2F30 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30(Vector3U2F30 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30(Vector2U2F30 xy, U2F30 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U2F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U2F30(U2F30.Zero);
        }
        public static Vector3U2F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U2F30(U2F30.One);
        }
        public static Vector3U2F30 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U2F30(U2F30.One, U2F30.Zero, U2F30.Zero);
        }
        public static Vector3U2F30 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U2F30(U2F30.Zero, U2F30.One, U2F30.Zero);
        }
        public static Vector3U2F30 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U2F30(U2F30.Zero, U2F30.Zero, U2F30.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator +(Vector3U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator -(Vector3U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator *(Vector3U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator *(Vector3U2F30 a, U2F30 b) => new Vector3U2F30(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator *(U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator /(Vector3U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator /(Vector3U2F30 a, U2F30 b) => new Vector3U2F30(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 operator /(U2F30 a, Vector3U2F30 b) => new Vector3U2F30(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U2F30 lhs, Vector3U2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U2F30 lhs, Vector3U2F30 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U2F30 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(X, X); }
        public readonly Vector2U2F30 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(X, Y); }
        public readonly Vector2U2F30 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(X, Z); }
        public readonly Vector2U2F30 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Y, X); }
        public readonly Vector2U2F30 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Y, Y); }
        public readonly Vector2U2F30 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Y, Z); }
        public readonly Vector2U2F30 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Z, X); }
        public readonly Vector2U2F30 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Z, Y); }
        public readonly Vector2U2F30 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Z, Z); }
        public readonly Vector3U2F30 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, X, X); }
        public readonly Vector3U2F30 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, X, Y); }
        public readonly Vector3U2F30 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, X, Z); }
        public readonly Vector3U2F30 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Y, X); }
        public readonly Vector3U2F30 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Y, Y); }
        public readonly Vector3U2F30 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Y, Z); }
        public readonly Vector3U2F30 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Z, X); }
        public readonly Vector3U2F30 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Z, Y); }
        public readonly Vector3U2F30 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Z, Z); }
        public readonly Vector3U2F30 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, X, X); }
        public readonly Vector3U2F30 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, X, Y); }
        public readonly Vector3U2F30 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, X, Z); }
        public readonly Vector3U2F30 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Y, X); }
        public readonly Vector3U2F30 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Y, Y); }
        public readonly Vector3U2F30 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Y, Z); }
        public readonly Vector3U2F30 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Z, X); }
        public readonly Vector3U2F30 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Z, Y); }
        public readonly Vector3U2F30 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Z, Z); }
        public readonly Vector3U2F30 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, X, X); }
        public readonly Vector3U2F30 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, X, Y); }
        public readonly Vector3U2F30 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, X, Z); }
        public readonly Vector3U2F30 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Y, X); }
        public readonly Vector3U2F30 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Y, Y); }
        public readonly Vector3U2F30 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Y, Z); }
        public readonly Vector3U2F30 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Z, X); }
        public readonly Vector3U2F30 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Z, Y); }
        public readonly Vector3U2F30 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Z, Z); }
        public readonly Vector4U2F30 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, X, X); }
        public readonly Vector4U2F30 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, X, Y); }
        public readonly Vector4U2F30 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, X, Z); }
        public readonly Vector4U2F30 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Y, X); }
        public readonly Vector4U2F30 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Y, Y); }
        public readonly Vector4U2F30 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Y, Z); }
        public readonly Vector4U2F30 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Z, X); }
        public readonly Vector4U2F30 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Z, Y); }
        public readonly Vector4U2F30 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Z, Z); }
        public readonly Vector4U2F30 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, X, X); }
        public readonly Vector4U2F30 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, X, Y); }
        public readonly Vector4U2F30 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, X, Z); }
        public readonly Vector4U2F30 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Y, X); }
        public readonly Vector4U2F30 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Y, Y); }
        public readonly Vector4U2F30 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Y, Z); }
        public readonly Vector4U2F30 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Z, X); }
        public readonly Vector4U2F30 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Z, Y); }
        public readonly Vector4U2F30 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Z, Z); }
        public readonly Vector4U2F30 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, X, X); }
        public readonly Vector4U2F30 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, X, Y); }
        public readonly Vector4U2F30 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, X, Z); }
        public readonly Vector4U2F30 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Y, X); }
        public readonly Vector4U2F30 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Y, Y); }
        public readonly Vector4U2F30 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Y, Z); }
        public readonly Vector4U2F30 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Z, X); }
        public readonly Vector4U2F30 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Z, Y); }
        public readonly Vector4U2F30 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Z, Z); }
        public readonly Vector4U2F30 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, X, X); }
        public readonly Vector4U2F30 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, X, Y); }
        public readonly Vector4U2F30 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, X, Z); }
        public readonly Vector4U2F30 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Y, X); }
        public readonly Vector4U2F30 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Y, Y); }
        public readonly Vector4U2F30 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Y, Z); }
        public readonly Vector4U2F30 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Z, X); }
        public readonly Vector4U2F30 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Z, Y); }
        public readonly Vector4U2F30 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Z, Z); }
        public readonly Vector4U2F30 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, X, X); }
        public readonly Vector4U2F30 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, X, Y); }
        public readonly Vector4U2F30 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, X, Z); }
        public readonly Vector4U2F30 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Y, X); }
        public readonly Vector4U2F30 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Y, Y); }
        public readonly Vector4U2F30 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Y, Z); }
        public readonly Vector4U2F30 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Z, X); }
        public readonly Vector4U2F30 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Z, Y); }
        public readonly Vector4U2F30 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Z, Z); }
        public readonly Vector4U2F30 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, X, X); }
        public readonly Vector4U2F30 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, X, Y); }
        public readonly Vector4U2F30 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, X, Z); }
        public readonly Vector4U2F30 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Y, X); }
        public readonly Vector4U2F30 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Y, Y); }
        public readonly Vector4U2F30 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Y, Z); }
        public readonly Vector4U2F30 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Z, X); }
        public readonly Vector4U2F30 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Z, Y); }
        public readonly Vector4U2F30 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Z, Z); }
        public readonly Vector4U2F30 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, X, X); }
        public readonly Vector4U2F30 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, X, Y); }
        public readonly Vector4U2F30 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, X, Z); }
        public readonly Vector4U2F30 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Y, X); }
        public readonly Vector4U2F30 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Y, Y); }
        public readonly Vector4U2F30 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Y, Z); }
        public readonly Vector4U2F30 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Z, X); }
        public readonly Vector4U2F30 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Z, Y); }
        public readonly Vector4U2F30 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Z, Z); }
        public readonly Vector4U2F30 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, X, X); }
        public readonly Vector4U2F30 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, X, Y); }
        public readonly Vector4U2F30 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, X, Z); }
        public readonly Vector4U2F30 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Y, X); }
        public readonly Vector4U2F30 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Y, Y); }
        public readonly Vector4U2F30 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Y, Z); }
        public readonly Vector4U2F30 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Z, X); }
        public readonly Vector4U2F30 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Z, Y); }
        public readonly Vector4U2F30 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Z, Z); }
        public readonly Vector4U2F30 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, X, X); }
        public readonly Vector4U2F30 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, X, Y); }
        public readonly Vector4U2F30 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, X, Z); }
        public readonly Vector4U2F30 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Y, X); }
        public readonly Vector4U2F30 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Y, Y); }
        public readonly Vector4U2F30 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Y, Z); }
        public readonly Vector4U2F30 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Z, X); }
        public readonly Vector4U2F30 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Z, Y); }
        public readonly Vector4U2F30 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U2F30 other)
            => other.X == X
            && other.Y == Y
            && other.Z == Z;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            return $"<{x}, {y}, {z}>";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector3U2F30 Half() => new Vector3U2F30(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3U2F30 Twice() => new Vector3U2F30(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3U2F30 Clamp(U2F30 min, U2F30 max) => new Vector3U2F30(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3U2F30 Clamp(
            Vector3U2F30 min, Vector3U2F30 max
        ) => new Vector3U2F30(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U2F30 SaturatingAdd(Vector3U2F30 other) => new Vector3U2F30(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U2F30 SaturatingMul(U2F30 other) => new Vector3U2F30(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U2F30 Cross(Vector3U2F30 other) {
            const ulong k = 1UL << 30;
            var ax = (ulong)X.Bits;
            var ay = (ulong)Y.Bits;
            var az = (ulong)Z.Bits;
            var bx = (ulong)other.X.Bits;
            var by = (ulong)other.Y.Bits;
            var bz = (ulong)other.Z.Bits;
            var x = (ay * bz) - (az * by);
            var y = (az * bx) - (ax * bz);
            var z = (ax * by) - (ay * bx);
            return new Vector3U2F30(
                U2F30.FromBits((uint)(x / k)),
                U2F30.FromBits((uint)(y / k)),
                U2F30.FromBits((uint)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U2F30 Dot(Vector3U2F30 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;
            var z = ((ulong)Z.Bits) * other.Z.Bits;

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x / 4) +
                (y / 4) +
                (z / 4);

            const ulong k = 1UL << 28;
            return U2F30.FromBits((uint)(bits / k));
        }

    }

    partial struct U2F30 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U2F30 SaturatingMul(Vector3U2F30 other) => other.SaturatingMul(this);
    }
}
