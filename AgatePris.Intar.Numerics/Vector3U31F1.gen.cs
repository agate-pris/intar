using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U31F1 : IEquatable<Vector3U31F1>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U31F1 X;
        public U31F1 Y;
        public U31F1 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U31F1(U31F1 x, U31F1 y, U31F1 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U31F1(U31F1 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U31F1(U31F1 x, Vector2U31F1 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U31F1(Vector3U31F1 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U31F1(Vector2U31F1 xy, U31F1 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U31F1 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U31F1(U31F1.Zero);
        }
        public static Vector3U31F1 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U31F1(U31F1.One);
        }
        public static Vector3U31F1 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U31F1(U31F1.One, U31F1.Zero, U31F1.Zero);
        }
        public static Vector3U31F1 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U31F1(U31F1.Zero, U31F1.One, U31F1.Zero);
        }
        public static Vector3U31F1 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U31F1(U31F1.Zero, U31F1.Zero, U31F1.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 operator +(Vector3U31F1 a, Vector3U31F1 b) => new Vector3U31F1(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 operator -(Vector3U31F1 a, Vector3U31F1 b) => new Vector3U31F1(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 operator *(Vector3U31F1 a, Vector3U31F1 b) => new Vector3U31F1(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 operator *(Vector3U31F1 a, U31F1 b) => new Vector3U31F1(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 operator *(U31F1 a, Vector3U31F1 b) => new Vector3U31F1(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 operator /(Vector3U31F1 a, Vector3U31F1 b) => new Vector3U31F1(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 operator /(Vector3U31F1 a, U31F1 b) => new Vector3U31F1(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 operator /(U31F1 a, Vector3U31F1 b) => new Vector3U31F1(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U31F1 lhs, Vector3U31F1 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U31F1 lhs, Vector3U31F1 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U31F1 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(X, X); }
        public readonly Vector2U31F1 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(X, Y); }
        public readonly Vector2U31F1 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(X, Z); }
        public readonly Vector2U31F1 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(Y, X); }
        public readonly Vector2U31F1 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(Y, Y); }
        public readonly Vector2U31F1 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(Y, Z); }
        public readonly Vector2U31F1 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(Z, X); }
        public readonly Vector2U31F1 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(Z, Y); }
        public readonly Vector2U31F1 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(Z, Z); }
        public readonly Vector3U31F1 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, X, X); }
        public readonly Vector3U31F1 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, X, Y); }
        public readonly Vector3U31F1 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, X, Z); }
        public readonly Vector3U31F1 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, Y, X); }
        public readonly Vector3U31F1 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, Y, Y); }
        public readonly Vector3U31F1 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, Y, Z); }
        public readonly Vector3U31F1 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, Z, X); }
        public readonly Vector3U31F1 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, Z, Y); }
        public readonly Vector3U31F1 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, Z, Z); }
        public readonly Vector3U31F1 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, X, X); }
        public readonly Vector3U31F1 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, X, Y); }
        public readonly Vector3U31F1 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, X, Z); }
        public readonly Vector3U31F1 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, Y, X); }
        public readonly Vector3U31F1 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, Y, Y); }
        public readonly Vector3U31F1 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, Y, Z); }
        public readonly Vector3U31F1 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, Z, X); }
        public readonly Vector3U31F1 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, Z, Y); }
        public readonly Vector3U31F1 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, Z, Z); }
        public readonly Vector3U31F1 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Z, X, X); }
        public readonly Vector3U31F1 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Z, X, Y); }
        public readonly Vector3U31F1 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Z, X, Z); }
        public readonly Vector3U31F1 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Z, Y, X); }
        public readonly Vector3U31F1 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Z, Y, Y); }
        public readonly Vector3U31F1 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Z, Y, Z); }
        public readonly Vector3U31F1 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Z, Z, X); }
        public readonly Vector3U31F1 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Z, Z, Y); }
        public readonly Vector3U31F1 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Z, Z, Z); }
        public readonly Vector4U31F1 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, X, X); }
        public readonly Vector4U31F1 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, X, Y); }
        public readonly Vector4U31F1 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, X, Z); }
        public readonly Vector4U31F1 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, Y, X); }
        public readonly Vector4U31F1 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, Y, Y); }
        public readonly Vector4U31F1 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, Y, Z); }
        public readonly Vector4U31F1 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, Z, X); }
        public readonly Vector4U31F1 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, Z, Y); }
        public readonly Vector4U31F1 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, Z, Z); }
        public readonly Vector4U31F1 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, X, X); }
        public readonly Vector4U31F1 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, X, Y); }
        public readonly Vector4U31F1 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, X, Z); }
        public readonly Vector4U31F1 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, Y, X); }
        public readonly Vector4U31F1 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, Y, Y); }
        public readonly Vector4U31F1 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, Y, Z); }
        public readonly Vector4U31F1 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, Z, X); }
        public readonly Vector4U31F1 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, Z, Y); }
        public readonly Vector4U31F1 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, Z, Z); }
        public readonly Vector4U31F1 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Z, X, X); }
        public readonly Vector4U31F1 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Z, X, Y); }
        public readonly Vector4U31F1 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Z, X, Z); }
        public readonly Vector4U31F1 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Z, Y, X); }
        public readonly Vector4U31F1 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Z, Y, Y); }
        public readonly Vector4U31F1 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Z, Y, Z); }
        public readonly Vector4U31F1 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Z, Z, X); }
        public readonly Vector4U31F1 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Z, Z, Y); }
        public readonly Vector4U31F1 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Z, Z, Z); }
        public readonly Vector4U31F1 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, X, X); }
        public readonly Vector4U31F1 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, X, Y); }
        public readonly Vector4U31F1 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, X, Z); }
        public readonly Vector4U31F1 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, Y, X); }
        public readonly Vector4U31F1 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, Y, Y); }
        public readonly Vector4U31F1 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, Y, Z); }
        public readonly Vector4U31F1 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, Z, X); }
        public readonly Vector4U31F1 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, Z, Y); }
        public readonly Vector4U31F1 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, Z, Z); }
        public readonly Vector4U31F1 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, X, X); }
        public readonly Vector4U31F1 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, X, Y); }
        public readonly Vector4U31F1 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, X, Z); }
        public readonly Vector4U31F1 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, Y, X); }
        public readonly Vector4U31F1 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, Y, Y); }
        public readonly Vector4U31F1 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, Y, Z); }
        public readonly Vector4U31F1 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, Z, X); }
        public readonly Vector4U31F1 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, Z, Y); }
        public readonly Vector4U31F1 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, Z, Z); }
        public readonly Vector4U31F1 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Z, X, X); }
        public readonly Vector4U31F1 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Z, X, Y); }
        public readonly Vector4U31F1 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Z, X, Z); }
        public readonly Vector4U31F1 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Z, Y, X); }
        public readonly Vector4U31F1 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Z, Y, Y); }
        public readonly Vector4U31F1 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Z, Y, Z); }
        public readonly Vector4U31F1 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Z, Z, X); }
        public readonly Vector4U31F1 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Z, Z, Y); }
        public readonly Vector4U31F1 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Z, Z, Z); }
        public readonly Vector4U31F1 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, X, X, X); }
        public readonly Vector4U31F1 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, X, X, Y); }
        public readonly Vector4U31F1 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, X, X, Z); }
        public readonly Vector4U31F1 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, X, Y, X); }
        public readonly Vector4U31F1 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, X, Y, Y); }
        public readonly Vector4U31F1 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, X, Y, Z); }
        public readonly Vector4U31F1 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, X, Z, X); }
        public readonly Vector4U31F1 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, X, Z, Y); }
        public readonly Vector4U31F1 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, X, Z, Z); }
        public readonly Vector4U31F1 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Y, X, X); }
        public readonly Vector4U31F1 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Y, X, Y); }
        public readonly Vector4U31F1 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Y, X, Z); }
        public readonly Vector4U31F1 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Y, Y, X); }
        public readonly Vector4U31F1 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Y, Y, Y); }
        public readonly Vector4U31F1 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Y, Y, Z); }
        public readonly Vector4U31F1 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Y, Z, X); }
        public readonly Vector4U31F1 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Y, Z, Y); }
        public readonly Vector4U31F1 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Y, Z, Z); }
        public readonly Vector4U31F1 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Z, X, X); }
        public readonly Vector4U31F1 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Z, X, Y); }
        public readonly Vector4U31F1 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Z, X, Z); }
        public readonly Vector4U31F1 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Z, Y, X); }
        public readonly Vector4U31F1 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Z, Y, Y); }
        public readonly Vector4U31F1 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Z, Y, Z); }
        public readonly Vector4U31F1 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Z, Z, X); }
        public readonly Vector4U31F1 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Z, Z, Y); }
        public readonly Vector4U31F1 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U31F1 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U31F1>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U31F1 other)
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

        public readonly Vector3U31F1 Half() => new Vector3U31F1(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3U31F1 Twice() => new Vector3U31F1(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3U31F1 Clamp(U31F1 min, U31F1 max) => new Vector3U31F1(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3U31F1 Clamp(
            Vector3U31F1 min, Vector3U31F1 max
        ) => new Vector3U31F1(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U31F1 SaturatingAdd(Vector3U31F1 other) => new Vector3U31F1(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U31F1 SaturatingMul(U31F1 other) => new Vector3U31F1(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U31F1 Cross(Vector3U31F1 other) {
            return (this * other.YZX - this.YZX * other).YZX;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U31F1 Dot(Vector3U31F1 other) {
            return
                X * other.X +
                Y * other.Y +
                Z * other.Z;
        }

    }

    partial struct U31F1 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U31F1 SaturatingMul(Vector3U31F1 other) => other.SaturatingMul(this);
    }
}
