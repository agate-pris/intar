using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U4F28 : IEquatable<Vector3U4F28>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U4F28 X;
        public U4F28 Y;
        public U4F28 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U4F28(U4F28 x, U4F28 y, U4F28 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U4F28(U4F28 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U4F28(U4F28 x, Vector2U4F28 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U4F28(Vector3U4F28 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U4F28(Vector2U4F28 xy, U4F28 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U4F28 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U4F28(U4F28.Zero);
        }
        public static Vector3U4F28 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U4F28(U4F28.One);
        }
        public static Vector3U4F28 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U4F28(U4F28.One, U4F28.Zero, U4F28.Zero);
        }
        public static Vector3U4F28 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U4F28(U4F28.Zero, U4F28.One, U4F28.Zero);
        }
        public static Vector3U4F28 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U4F28(U4F28.Zero, U4F28.Zero, U4F28.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator +(Vector3U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator -(Vector3U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator *(Vector3U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator *(Vector3U4F28 a, U4F28 b) => new Vector3U4F28(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator *(U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator /(Vector3U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator /(Vector3U4F28 a, U4F28 b) => new Vector3U4F28(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator /(U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U4F28 lhs, Vector3U4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U4F28 lhs, Vector3U4F28 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U4F28 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, X); }
        public readonly Vector2U4F28 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, Y); }
        public readonly Vector2U4F28 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, Z); }
        public readonly Vector2U4F28 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, X); }
        public readonly Vector2U4F28 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, Y); }
        public readonly Vector2U4F28 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, Z); }
        public readonly Vector2U4F28 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Z, X); }
        public readonly Vector2U4F28 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Z, Y); }
        public readonly Vector2U4F28 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Z, Z); }
        public readonly Vector3U4F28 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, X); }
        public readonly Vector3U4F28 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, Y); }
        public readonly Vector3U4F28 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, Z); }
        public readonly Vector3U4F28 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, X); }
        public readonly Vector3U4F28 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, Y); }
        public readonly Vector3U4F28 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, Z); }
        public readonly Vector3U4F28 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Z, X); }
        public readonly Vector3U4F28 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Z, Y); }
        public readonly Vector3U4F28 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Z, Z); }
        public readonly Vector3U4F28 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, X); }
        public readonly Vector3U4F28 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, Y); }
        public readonly Vector3U4F28 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, Z); }
        public readonly Vector3U4F28 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, X); }
        public readonly Vector3U4F28 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, Y); }
        public readonly Vector3U4F28 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, Z); }
        public readonly Vector3U4F28 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Z, X); }
        public readonly Vector3U4F28 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Z, Y); }
        public readonly Vector3U4F28 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Z, Z); }
        public readonly Vector3U4F28 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, X, X); }
        public readonly Vector3U4F28 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, X, Y); }
        public readonly Vector3U4F28 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, X, Z); }
        public readonly Vector3U4F28 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Y, X); }
        public readonly Vector3U4F28 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Y, Y); }
        public readonly Vector3U4F28 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Y, Z); }
        public readonly Vector3U4F28 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Z, X); }
        public readonly Vector3U4F28 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Z, Y); }
        public readonly Vector3U4F28 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Z, Z); }
        public readonly Vector4U4F28 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, X); }
        public readonly Vector4U4F28 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, Y); }
        public readonly Vector4U4F28 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, Z); }
        public readonly Vector4U4F28 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, X); }
        public readonly Vector4U4F28 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, Y); }
        public readonly Vector4U4F28 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, Z); }
        public readonly Vector4U4F28 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Z, X); }
        public readonly Vector4U4F28 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Z, Y); }
        public readonly Vector4U4F28 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Z, Z); }
        public readonly Vector4U4F28 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, X); }
        public readonly Vector4U4F28 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, Y); }
        public readonly Vector4U4F28 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, Z); }
        public readonly Vector4U4F28 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, X); }
        public readonly Vector4U4F28 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, Y); }
        public readonly Vector4U4F28 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, Z); }
        public readonly Vector4U4F28 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Z, X); }
        public readonly Vector4U4F28 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Z, Y); }
        public readonly Vector4U4F28 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Z, Z); }
        public readonly Vector4U4F28 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, X, X); }
        public readonly Vector4U4F28 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, X, Y); }
        public readonly Vector4U4F28 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, X, Z); }
        public readonly Vector4U4F28 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Y, X); }
        public readonly Vector4U4F28 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Y, Y); }
        public readonly Vector4U4F28 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Y, Z); }
        public readonly Vector4U4F28 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Z, X); }
        public readonly Vector4U4F28 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Z, Y); }
        public readonly Vector4U4F28 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Z, Z); }
        public readonly Vector4U4F28 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, X); }
        public readonly Vector4U4F28 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, Y); }
        public readonly Vector4U4F28 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, Z); }
        public readonly Vector4U4F28 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, X); }
        public readonly Vector4U4F28 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, Y); }
        public readonly Vector4U4F28 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, Z); }
        public readonly Vector4U4F28 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Z, X); }
        public readonly Vector4U4F28 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Z, Y); }
        public readonly Vector4U4F28 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Z, Z); }
        public readonly Vector4U4F28 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, X); }
        public readonly Vector4U4F28 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, Y); }
        public readonly Vector4U4F28 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, Z); }
        public readonly Vector4U4F28 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, X); }
        public readonly Vector4U4F28 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, Y); }
        public readonly Vector4U4F28 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, Z); }
        public readonly Vector4U4F28 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Z, X); }
        public readonly Vector4U4F28 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Z, Y); }
        public readonly Vector4U4F28 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Z, Z); }
        public readonly Vector4U4F28 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, X, X); }
        public readonly Vector4U4F28 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, X, Y); }
        public readonly Vector4U4F28 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, X, Z); }
        public readonly Vector4U4F28 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Y, X); }
        public readonly Vector4U4F28 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Y, Y); }
        public readonly Vector4U4F28 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Y, Z); }
        public readonly Vector4U4F28 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Z, X); }
        public readonly Vector4U4F28 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Z, Y); }
        public readonly Vector4U4F28 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Z, Z); }
        public readonly Vector4U4F28 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, X, X); }
        public readonly Vector4U4F28 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, X, Y); }
        public readonly Vector4U4F28 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, X, Z); }
        public readonly Vector4U4F28 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Y, X); }
        public readonly Vector4U4F28 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Y, Y); }
        public readonly Vector4U4F28 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Y, Z); }
        public readonly Vector4U4F28 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Z, X); }
        public readonly Vector4U4F28 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Z, Y); }
        public readonly Vector4U4F28 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Z, Z); }
        public readonly Vector4U4F28 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, X, X); }
        public readonly Vector4U4F28 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, X, Y); }
        public readonly Vector4U4F28 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, X, Z); }
        public readonly Vector4U4F28 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Y, X); }
        public readonly Vector4U4F28 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Y, Y); }
        public readonly Vector4U4F28 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Y, Z); }
        public readonly Vector4U4F28 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Z, X); }
        public readonly Vector4U4F28 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Z, Y); }
        public readonly Vector4U4F28 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Z, Z); }
        public readonly Vector4U4F28 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, X, X); }
        public readonly Vector4U4F28 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, X, Y); }
        public readonly Vector4U4F28 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, X, Z); }
        public readonly Vector4U4F28 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Y, X); }
        public readonly Vector4U4F28 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Y, Y); }
        public readonly Vector4U4F28 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Y, Z); }
        public readonly Vector4U4F28 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Z, X); }
        public readonly Vector4U4F28 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Z, Y); }
        public readonly Vector4U4F28 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U4F28 other)
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

        public readonly Vector3U4F28 Half() => new Vector3U4F28(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3U4F28 Twice() => new Vector3U4F28(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3U4F28 Clamp(U4F28 min, U4F28 max) => new Vector3U4F28(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3U4F28 Clamp(
            Vector3U4F28 min, Vector3U4F28 max
        ) => new Vector3U4F28(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U4F28 SaturatingAdd(Vector3U4F28 other) => new Vector3U4F28(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U4F28 SaturatingMul(U4F28 other) => new Vector3U4F28(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

    }

    partial struct U4F28 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U4F28 SaturatingMul(Vector3U4F28 other) => other.SaturatingMul(this);
    }
}
