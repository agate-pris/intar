using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U18F14 : IEquatable<Vector3U18F14>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U18F14 X;
        public U18F14 Y;
        public U18F14 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U18F14(U18F14 x, U18F14 y, U18F14 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U18F14(U18F14 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U18F14(U18F14 x, Vector2U18F14 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U18F14(Vector3U18F14 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U18F14(Vector2U18F14 xy, U18F14 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U18F14 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U18F14(U18F14.Zero);
        }
        public static Vector3U18F14 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U18F14(U18F14.One);
        }
        public static Vector3U18F14 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U18F14(U18F14.One, U18F14.Zero, U18F14.Zero);
        }
        public static Vector3U18F14 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U18F14(U18F14.Zero, U18F14.One, U18F14.Zero);
        }
        public static Vector3U18F14 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U18F14(U18F14.Zero, U18F14.Zero, U18F14.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator +(Vector3U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator -(Vector3U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator *(Vector3U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator *(Vector3U18F14 a, U18F14 b) => new Vector3U18F14(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator *(U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator /(Vector3U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator /(Vector3U18F14 a, U18F14 b) => new Vector3U18F14(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator /(U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U18F14 lhs, Vector3U18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U18F14 lhs, Vector3U18F14 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U18F14 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(X, X); }
        public readonly Vector2U18F14 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(X, Y); }
        public readonly Vector2U18F14 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(X, Z); }
        public readonly Vector2U18F14 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(Y, X); }
        public readonly Vector2U18F14 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(Y, Y); }
        public readonly Vector2U18F14 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(Y, Z); }
        public readonly Vector2U18F14 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(Z, X); }
        public readonly Vector2U18F14 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(Z, Y); }
        public readonly Vector2U18F14 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(Z, Z); }
        public readonly Vector3U18F14 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(X, X, X); }
        public readonly Vector3U18F14 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(X, X, Y); }
        public readonly Vector3U18F14 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(X, X, Z); }
        public readonly Vector3U18F14 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(X, Y, X); }
        public readonly Vector3U18F14 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(X, Y, Y); }
        public readonly Vector3U18F14 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(X, Y, Z); }
        public readonly Vector3U18F14 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(X, Z, X); }
        public readonly Vector3U18F14 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(X, Z, Y); }
        public readonly Vector3U18F14 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(X, Z, Z); }
        public readonly Vector3U18F14 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Y, X, X); }
        public readonly Vector3U18F14 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Y, X, Y); }
        public readonly Vector3U18F14 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Y, X, Z); }
        public readonly Vector3U18F14 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Y, Y, X); }
        public readonly Vector3U18F14 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Y, Y, Y); }
        public readonly Vector3U18F14 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Y, Y, Z); }
        public readonly Vector3U18F14 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Y, Z, X); }
        public readonly Vector3U18F14 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Y, Z, Y); }
        public readonly Vector3U18F14 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Y, Z, Z); }
        public readonly Vector3U18F14 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Z, X, X); }
        public readonly Vector3U18F14 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Z, X, Y); }
        public readonly Vector3U18F14 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Z, X, Z); }
        public readonly Vector3U18F14 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Z, Y, X); }
        public readonly Vector3U18F14 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Z, Y, Y); }
        public readonly Vector3U18F14 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Z, Y, Z); }
        public readonly Vector3U18F14 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Z, Z, X); }
        public readonly Vector3U18F14 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Z, Z, Y); }
        public readonly Vector3U18F14 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(Z, Z, Z); }
        public readonly Vector4U18F14 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, X, X, X); }
        public readonly Vector4U18F14 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, X, X, Y); }
        public readonly Vector4U18F14 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, X, X, Z); }
        public readonly Vector4U18F14 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, X, Y, X); }
        public readonly Vector4U18F14 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, X, Y, Y); }
        public readonly Vector4U18F14 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, X, Y, Z); }
        public readonly Vector4U18F14 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, X, Z, X); }
        public readonly Vector4U18F14 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, X, Z, Y); }
        public readonly Vector4U18F14 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, X, Z, Z); }
        public readonly Vector4U18F14 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Y, X, X); }
        public readonly Vector4U18F14 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Y, X, Y); }
        public readonly Vector4U18F14 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Y, X, Z); }
        public readonly Vector4U18F14 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Y, Y, X); }
        public readonly Vector4U18F14 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Y, Y, Y); }
        public readonly Vector4U18F14 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Y, Y, Z); }
        public readonly Vector4U18F14 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Y, Z, X); }
        public readonly Vector4U18F14 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Y, Z, Y); }
        public readonly Vector4U18F14 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Y, Z, Z); }
        public readonly Vector4U18F14 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Z, X, X); }
        public readonly Vector4U18F14 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Z, X, Y); }
        public readonly Vector4U18F14 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Z, X, Z); }
        public readonly Vector4U18F14 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Z, Y, X); }
        public readonly Vector4U18F14 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Z, Y, Y); }
        public readonly Vector4U18F14 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Z, Y, Z); }
        public readonly Vector4U18F14 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Z, Z, X); }
        public readonly Vector4U18F14 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Z, Z, Y); }
        public readonly Vector4U18F14 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(X, Z, Z, Z); }
        public readonly Vector4U18F14 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, X, X, X); }
        public readonly Vector4U18F14 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, X, X, Y); }
        public readonly Vector4U18F14 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, X, X, Z); }
        public readonly Vector4U18F14 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, X, Y, X); }
        public readonly Vector4U18F14 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, X, Y, Y); }
        public readonly Vector4U18F14 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, X, Y, Z); }
        public readonly Vector4U18F14 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, X, Z, X); }
        public readonly Vector4U18F14 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, X, Z, Y); }
        public readonly Vector4U18F14 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, X, Z, Z); }
        public readonly Vector4U18F14 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Y, X, X); }
        public readonly Vector4U18F14 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Y, X, Y); }
        public readonly Vector4U18F14 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Y, X, Z); }
        public readonly Vector4U18F14 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Y, Y, X); }
        public readonly Vector4U18F14 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Y, Y, Y); }
        public readonly Vector4U18F14 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Y, Y, Z); }
        public readonly Vector4U18F14 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Y, Z, X); }
        public readonly Vector4U18F14 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Y, Z, Y); }
        public readonly Vector4U18F14 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Y, Z, Z); }
        public readonly Vector4U18F14 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Z, X, X); }
        public readonly Vector4U18F14 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Z, X, Y); }
        public readonly Vector4U18F14 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Z, X, Z); }
        public readonly Vector4U18F14 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Z, Y, X); }
        public readonly Vector4U18F14 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Z, Y, Y); }
        public readonly Vector4U18F14 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Z, Y, Z); }
        public readonly Vector4U18F14 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Z, Z, X); }
        public readonly Vector4U18F14 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Z, Z, Y); }
        public readonly Vector4U18F14 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Y, Z, Z, Z); }
        public readonly Vector4U18F14 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, X, X, X); }
        public readonly Vector4U18F14 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, X, X, Y); }
        public readonly Vector4U18F14 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, X, X, Z); }
        public readonly Vector4U18F14 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, X, Y, X); }
        public readonly Vector4U18F14 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, X, Y, Y); }
        public readonly Vector4U18F14 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, X, Y, Z); }
        public readonly Vector4U18F14 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, X, Z, X); }
        public readonly Vector4U18F14 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, X, Z, Y); }
        public readonly Vector4U18F14 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, X, Z, Z); }
        public readonly Vector4U18F14 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Y, X, X); }
        public readonly Vector4U18F14 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Y, X, Y); }
        public readonly Vector4U18F14 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Y, X, Z); }
        public readonly Vector4U18F14 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Y, Y, X); }
        public readonly Vector4U18F14 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Y, Y, Y); }
        public readonly Vector4U18F14 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Y, Y, Z); }
        public readonly Vector4U18F14 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Y, Z, X); }
        public readonly Vector4U18F14 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Y, Z, Y); }
        public readonly Vector4U18F14 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Y, Z, Z); }
        public readonly Vector4U18F14 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Z, X, X); }
        public readonly Vector4U18F14 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Z, X, Y); }
        public readonly Vector4U18F14 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Z, X, Z); }
        public readonly Vector4U18F14 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Z, Y, X); }
        public readonly Vector4U18F14 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Z, Y, Y); }
        public readonly Vector4U18F14 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Z, Y, Z); }
        public readonly Vector4U18F14 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Z, Z, X); }
        public readonly Vector4U18F14 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Z, Z, Y); }
        public readonly Vector4U18F14 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U18F14 other)
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

        public readonly Vector3U18F14 Half() => new Vector3U18F14(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3U18F14 Twice() => new Vector3U18F14(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3U18F14 Clamp(U18F14 min, U18F14 max) => new Vector3U18F14(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3U18F14 Clamp(
            Vector3U18F14 min, Vector3U18F14 max
        ) => new Vector3U18F14(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U18F14 SaturatingAdd(Vector3U18F14 other) => new Vector3U18F14(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U18F14 SaturatingMul(U18F14 other) => new Vector3U18F14(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

    }

    partial struct U18F14 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3U18F14 SaturatingMul(Vector3U18F14 other) => other.SaturatingMul(this);
    }
}
