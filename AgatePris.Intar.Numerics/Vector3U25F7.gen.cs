using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U25F7 : IEquatable<Vector3U25F7>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U25F7 X;
        public U25F7 Y;
        public U25F7 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7(U25F7 x, U25F7 y, U25F7 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7(U25F7 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7(U25F7 x, Vector2U25F7 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7(Vector3U25F7 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7(Vector2U25F7 xy, U25F7 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U25F7 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U25F7(U25F7.Zero);
        }
        public static Vector3U25F7 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U25F7(U25F7.One);
        }
        public static Vector3U25F7 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U25F7(U25F7.One, U25F7.Zero, U25F7.Zero);
        }
        public static Vector3U25F7 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U25F7(U25F7.Zero, U25F7.One, U25F7.Zero);
        }
        public static Vector3U25F7 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U25F7(U25F7.Zero, U25F7.Zero, U25F7.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator +(Vector3U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator -(Vector3U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator *(Vector3U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator *(Vector3U25F7 a, U25F7 b) => new Vector3U25F7(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator *(U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator /(Vector3U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator /(Vector3U25F7 a, U25F7 b) => new Vector3U25F7(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator /(U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U25F7 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, X); }
        public readonly Vector2U25F7 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, Y); }
        public readonly Vector2U25F7 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, Z); }
        public readonly Vector2U25F7 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, X); }
        public readonly Vector2U25F7 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, Y); }
        public readonly Vector2U25F7 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, Z); }
        public readonly Vector2U25F7 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, X); }
        public readonly Vector2U25F7 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, Y); }
        public readonly Vector2U25F7 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, Z); }
        public readonly Vector3U25F7 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, X); }
        public readonly Vector3U25F7 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, Y); }
        public readonly Vector3U25F7 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, Z); }
        public readonly Vector3U25F7 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, X); }
        public readonly Vector3U25F7 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, Y); }
        public readonly Vector3U25F7 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, Z); }
        public readonly Vector3U25F7 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, X); }
        public readonly Vector3U25F7 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, Y); }
        public readonly Vector3U25F7 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, Z); }
        public readonly Vector3U25F7 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, X); }
        public readonly Vector3U25F7 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, Y); }
        public readonly Vector3U25F7 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, Z); }
        public readonly Vector3U25F7 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, X); }
        public readonly Vector3U25F7 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, Y); }
        public readonly Vector3U25F7 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, Z); }
        public readonly Vector3U25F7 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, X); }
        public readonly Vector3U25F7 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, Y); }
        public readonly Vector3U25F7 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, Z); }
        public readonly Vector3U25F7 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, X); }
        public readonly Vector3U25F7 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, Y); }
        public readonly Vector3U25F7 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, Z); }
        public readonly Vector3U25F7 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, X); }
        public readonly Vector3U25F7 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, Y); }
        public readonly Vector3U25F7 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, Z); }
        public readonly Vector3U25F7 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, X); }
        public readonly Vector3U25F7 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, Y); }
        public readonly Vector3U25F7 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, Z); }
        public readonly Vector4U25F7 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, X); }
        public readonly Vector4U25F7 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, Y); }
        public readonly Vector4U25F7 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, Z); }
        public readonly Vector4U25F7 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, X); }
        public readonly Vector4U25F7 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, Y); }
        public readonly Vector4U25F7 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, Z); }
        public readonly Vector4U25F7 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, X); }
        public readonly Vector4U25F7 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, Y); }
        public readonly Vector4U25F7 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, Z); }
        public readonly Vector4U25F7 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, X); }
        public readonly Vector4U25F7 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, Y); }
        public readonly Vector4U25F7 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, Z); }
        public readonly Vector4U25F7 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, X); }
        public readonly Vector4U25F7 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, Y); }
        public readonly Vector4U25F7 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, Z); }
        public readonly Vector4U25F7 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, X); }
        public readonly Vector4U25F7 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, Y); }
        public readonly Vector4U25F7 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, Z); }
        public readonly Vector4U25F7 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, X); }
        public readonly Vector4U25F7 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, Y); }
        public readonly Vector4U25F7 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, Z); }
        public readonly Vector4U25F7 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, X); }
        public readonly Vector4U25F7 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, Y); }
        public readonly Vector4U25F7 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, Z); }
        public readonly Vector4U25F7 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, X); }
        public readonly Vector4U25F7 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, Y); }
        public readonly Vector4U25F7 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, Z); }
        public readonly Vector4U25F7 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, X); }
        public readonly Vector4U25F7 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, Y); }
        public readonly Vector4U25F7 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, Z); }
        public readonly Vector4U25F7 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, X); }
        public readonly Vector4U25F7 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, Y); }
        public readonly Vector4U25F7 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, Z); }
        public readonly Vector4U25F7 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, X); }
        public readonly Vector4U25F7 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, Y); }
        public readonly Vector4U25F7 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, Z); }
        public readonly Vector4U25F7 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, X); }
        public readonly Vector4U25F7 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, Y); }
        public readonly Vector4U25F7 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, Z); }
        public readonly Vector4U25F7 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, X); }
        public readonly Vector4U25F7 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, Y); }
        public readonly Vector4U25F7 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, Z); }
        public readonly Vector4U25F7 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, X); }
        public readonly Vector4U25F7 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, Y); }
        public readonly Vector4U25F7 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, Z); }
        public readonly Vector4U25F7 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, X); }
        public readonly Vector4U25F7 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, Y); }
        public readonly Vector4U25F7 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, Z); }
        public readonly Vector4U25F7 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, X); }
        public readonly Vector4U25F7 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, Y); }
        public readonly Vector4U25F7 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, Z); }
        public readonly Vector4U25F7 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, X); }
        public readonly Vector4U25F7 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, Y); }
        public readonly Vector4U25F7 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, Z); }
        public readonly Vector4U25F7 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, X); }
        public readonly Vector4U25F7 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, Y); }
        public readonly Vector4U25F7 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, Z); }
        public readonly Vector4U25F7 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, X); }
        public readonly Vector4U25F7 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, Y); }
        public readonly Vector4U25F7 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, Z); }
        public readonly Vector4U25F7 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, X); }
        public readonly Vector4U25F7 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, Y); }
        public readonly Vector4U25F7 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, Z); }
        public readonly Vector4U25F7 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, X); }
        public readonly Vector4U25F7 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, Y); }
        public readonly Vector4U25F7 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, Z); }
        public readonly Vector4U25F7 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, X); }
        public readonly Vector4U25F7 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, Y); }
        public readonly Vector4U25F7 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, Z); }
        public readonly Vector4U25F7 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, X); }
        public readonly Vector4U25F7 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, Y); }
        public readonly Vector4U25F7 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, Z); }
        public readonly Vector4U25F7 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, X); }
        public readonly Vector4U25F7 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, Y); }
        public readonly Vector4U25F7 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, Z); }
        public readonly Vector4U25F7 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, X); }
        public readonly Vector4U25F7 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, Y); }
        public readonly Vector4U25F7 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, Z); }
        public readonly Vector4U25F7 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, X); }
        public readonly Vector4U25F7 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, Y); }
        public readonly Vector4U25F7 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, Z); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U25F7 lhs, Vector3U25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U25F7 lhs, Vector3U25F7 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U25F7({X}, {Y}, {Z})";

        // IEquatable<Vector3U25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U25F7 other)
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
            return $"Vector3U25F7({x}, {y}, {z})";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector3U25F7 Half() => new Vector3U25F7(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3U25F7 Twice() => new Vector3U25F7(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3U25F7 Clamp(U25F7 min, U25F7 max) => new Vector3U25F7(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3U25F7 Clamp(
            Vector3U25F7 min, Vector3U25F7 max
        ) => new Vector3U25F7(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

    }
}
