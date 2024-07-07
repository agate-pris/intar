using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U15F17 : IEquatable<Vector3U15F17>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U15F17 X;
        public U15F17 Y;
        public U15F17 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(U15F17 x, U15F17 y, U15F17 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(U15F17 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(U15F17 x, Vector2U15F17 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(Vector3U15F17 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(Vector2U15F17 xy, U15F17 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U15F17 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U15F17(U15F17.Zero);
        }
        public static Vector3U15F17 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U15F17(U15F17.One);
        }
        public static Vector3U15F17 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U15F17(U15F17.One, U15F17.Zero, U15F17.Zero);
        }
        public static Vector3U15F17 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U15F17(U15F17.Zero, U15F17.One, U15F17.Zero);
        }
        public static Vector3U15F17 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U15F17(U15F17.Zero, U15F17.Zero, U15F17.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator +(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator -(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator *(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator *(Vector3U15F17 a, U15F17 b) => new Vector3U15F17(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator *(U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator /(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator /(Vector3U15F17 a, U15F17 b) => new Vector3U15F17(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator /(U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U15F17 lhs, Vector3U15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U15F17 lhs, Vector3U15F17 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U15F17 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, X); }
        public readonly Vector2U15F17 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, Y); }
        public readonly Vector2U15F17 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, Z); }
        public readonly Vector2U15F17 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, X); }
        public readonly Vector2U15F17 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, Y); }
        public readonly Vector2U15F17 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, Z); }
        public readonly Vector2U15F17 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Z, X); }
        public readonly Vector2U15F17 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Z, Y); }
        public readonly Vector2U15F17 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Z, Z); }
        public readonly Vector3U15F17 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, X); }
        public readonly Vector3U15F17 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, Y); }
        public readonly Vector3U15F17 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, Z); }
        public readonly Vector3U15F17 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, X); }
        public readonly Vector3U15F17 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, Y); }
        public readonly Vector3U15F17 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, Z); }
        public readonly Vector3U15F17 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Z, X); }
        public readonly Vector3U15F17 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Z, Y); }
        public readonly Vector3U15F17 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Z, Z); }
        public readonly Vector3U15F17 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, X); }
        public readonly Vector3U15F17 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, Y); }
        public readonly Vector3U15F17 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, Z); }
        public readonly Vector3U15F17 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, X); }
        public readonly Vector3U15F17 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, Y); }
        public readonly Vector3U15F17 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, Z); }
        public readonly Vector3U15F17 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Z, X); }
        public readonly Vector3U15F17 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Z, Y); }
        public readonly Vector3U15F17 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Z, Z); }
        public readonly Vector3U15F17 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, X, X); }
        public readonly Vector3U15F17 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, X, Y); }
        public readonly Vector3U15F17 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, X, Z); }
        public readonly Vector3U15F17 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Y, X); }
        public readonly Vector3U15F17 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Y, Y); }
        public readonly Vector3U15F17 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Y, Z); }
        public readonly Vector3U15F17 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Z, X); }
        public readonly Vector3U15F17 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Z, Y); }
        public readonly Vector3U15F17 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Z, Z); }
        public readonly Vector4U15F17 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, X); }
        public readonly Vector4U15F17 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, Y); }
        public readonly Vector4U15F17 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, Z); }
        public readonly Vector4U15F17 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, X); }
        public readonly Vector4U15F17 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, Y); }
        public readonly Vector4U15F17 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, Z); }
        public readonly Vector4U15F17 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Z, X); }
        public readonly Vector4U15F17 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Z, Y); }
        public readonly Vector4U15F17 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Z, Z); }
        public readonly Vector4U15F17 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, X); }
        public readonly Vector4U15F17 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, Y); }
        public readonly Vector4U15F17 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, Z); }
        public readonly Vector4U15F17 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, X); }
        public readonly Vector4U15F17 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, Y); }
        public readonly Vector4U15F17 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, Z); }
        public readonly Vector4U15F17 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Z, X); }
        public readonly Vector4U15F17 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Z, Y); }
        public readonly Vector4U15F17 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Z, Z); }
        public readonly Vector4U15F17 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, X, X); }
        public readonly Vector4U15F17 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, X, Y); }
        public readonly Vector4U15F17 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, X, Z); }
        public readonly Vector4U15F17 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Y, X); }
        public readonly Vector4U15F17 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Y, Y); }
        public readonly Vector4U15F17 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Y, Z); }
        public readonly Vector4U15F17 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Z, X); }
        public readonly Vector4U15F17 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Z, Y); }
        public readonly Vector4U15F17 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Z, Z); }
        public readonly Vector4U15F17 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, X); }
        public readonly Vector4U15F17 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, Y); }
        public readonly Vector4U15F17 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, Z); }
        public readonly Vector4U15F17 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, X); }
        public readonly Vector4U15F17 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, Y); }
        public readonly Vector4U15F17 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, Z); }
        public readonly Vector4U15F17 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Z, X); }
        public readonly Vector4U15F17 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Z, Y); }
        public readonly Vector4U15F17 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Z, Z); }
        public readonly Vector4U15F17 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, X); }
        public readonly Vector4U15F17 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, Y); }
        public readonly Vector4U15F17 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, Z); }
        public readonly Vector4U15F17 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, X); }
        public readonly Vector4U15F17 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, Y); }
        public readonly Vector4U15F17 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, Z); }
        public readonly Vector4U15F17 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Z, X); }
        public readonly Vector4U15F17 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Z, Y); }
        public readonly Vector4U15F17 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Z, Z); }
        public readonly Vector4U15F17 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, X, X); }
        public readonly Vector4U15F17 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, X, Y); }
        public readonly Vector4U15F17 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, X, Z); }
        public readonly Vector4U15F17 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Y, X); }
        public readonly Vector4U15F17 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Y, Y); }
        public readonly Vector4U15F17 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Y, Z); }
        public readonly Vector4U15F17 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Z, X); }
        public readonly Vector4U15F17 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Z, Y); }
        public readonly Vector4U15F17 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Z, Z); }
        public readonly Vector4U15F17 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, X, X); }
        public readonly Vector4U15F17 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, X, Y); }
        public readonly Vector4U15F17 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, X, Z); }
        public readonly Vector4U15F17 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Y, X); }
        public readonly Vector4U15F17 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Y, Y); }
        public readonly Vector4U15F17 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Y, Z); }
        public readonly Vector4U15F17 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Z, X); }
        public readonly Vector4U15F17 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Z, Y); }
        public readonly Vector4U15F17 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Z, Z); }
        public readonly Vector4U15F17 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, X, X); }
        public readonly Vector4U15F17 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, X, Y); }
        public readonly Vector4U15F17 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, X, Z); }
        public readonly Vector4U15F17 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Y, X); }
        public readonly Vector4U15F17 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Y, Y); }
        public readonly Vector4U15F17 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Y, Z); }
        public readonly Vector4U15F17 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Z, X); }
        public readonly Vector4U15F17 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Z, Y); }
        public readonly Vector4U15F17 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Z, Z); }
        public readonly Vector4U15F17 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, X, X); }
        public readonly Vector4U15F17 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, X, Y); }
        public readonly Vector4U15F17 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, X, Z); }
        public readonly Vector4U15F17 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Y, X); }
        public readonly Vector4U15F17 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Y, Y); }
        public readonly Vector4U15F17 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Y, Z); }
        public readonly Vector4U15F17 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Z, X); }
        public readonly Vector4U15F17 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Z, Y); }
        public readonly Vector4U15F17 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U15F17 other)
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

        public readonly Vector3U15F17 Half() => new Vector3U15F17(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3U15F17 Twice() => new Vector3U15F17(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3U15F17 Clamp(U15F17 min, U15F17 max) => new Vector3U15F17(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3U15F17 Clamp(
            Vector3U15F17 min, Vector3U15F17 max
        ) => new Vector3U15F17(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U15F17 SaturatingAdd(Vector3U15F17 other) => new Vector3U15F17(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U15F17 SaturatingMul(U15F17 other) => new Vector3U15F17(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U15F17 Cross(Vector3U15F17 other) {
            const ulong k = 1UL << 17;
            var ax = (ulong)X.Bits;
            var ay = (ulong)Y.Bits;
            var az = (ulong)Z.Bits;
            var bx = (ulong)other.X.Bits;
            var by = (ulong)other.Y.Bits;
            var bz = (ulong)other.Z.Bits;
            var x = (ay * bz) - (az * by);
            var y = (az * bx) - (ax * bz);
            var z = (ax * by) - (ay * bx);
            return new Vector3U15F17(
                U15F17.FromBits((uint)(x / k)),
                U15F17.FromBits((uint)(y / k)),
                U15F17.FromBits((uint)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U15F17 Dot(Vector3U15F17 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;
            var z = ((ulong)Z.Bits) * other.Z.Bits;

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x / 4) +
                (y / 4) +
                (z / 4);

            const ulong k = 1UL << 15;
            return U15F17.FromBits((uint)(bits / k));
        }

    }

    partial struct U15F17 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U15F17 SaturatingMul(Vector3U15F17 other) => other.SaturatingMul(this);
    }
}
