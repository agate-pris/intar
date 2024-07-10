using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I5F27 : IEquatable<Vector3I5F27>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I5F27 X;
        public I5F27 Y;
        public I5F27 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(I5F27 x, I5F27 y, I5F27 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(I5F27 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(I5F27 x, Vector2I5F27 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(Vector3I5F27 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(Vector2I5F27 xy, I5F27 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I5F27 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I5F27(I5F27.Zero);
        }
        public static Vector3I5F27 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I5F27(I5F27.One);
        }
        public static Vector3I5F27 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I5F27(I5F27.One, I5F27.Zero, I5F27.Zero);
        }
        public static Vector3I5F27 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I5F27(I5F27.Zero, I5F27.One, I5F27.Zero);
        }
        public static Vector3I5F27 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I5F27(I5F27.Zero, I5F27.Zero, I5F27.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator +(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator -(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator *(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator *(Vector3I5F27 a, I5F27 b) => new Vector3I5F27(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator *(I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator /(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator /(Vector3I5F27 a, I5F27 b) => new Vector3I5F27(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator /(I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I5F27 lhs, Vector3I5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I5F27 lhs, Vector3I5F27 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I5F27 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, X); }
        public readonly Vector2I5F27 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, Y); }
        public readonly Vector2I5F27 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, Z); }
        public readonly Vector2I5F27 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, X); }
        public readonly Vector2I5F27 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, Y); }
        public readonly Vector2I5F27 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, Z); }
        public readonly Vector2I5F27 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, X); }
        public readonly Vector2I5F27 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, Y); }
        public readonly Vector2I5F27 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, Z); }
        public readonly Vector3I5F27 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, X); }
        public readonly Vector3I5F27 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, Y); }
        public readonly Vector3I5F27 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, Z); }
        public readonly Vector3I5F27 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, X); }
        public readonly Vector3I5F27 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, Y); }
        public readonly Vector3I5F27 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, Z); }
        public readonly Vector3I5F27 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, X); }
        public readonly Vector3I5F27 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, Y); }
        public readonly Vector3I5F27 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, Z); }
        public readonly Vector3I5F27 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, X); }
        public readonly Vector3I5F27 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, Y); }
        public readonly Vector3I5F27 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, Z); }
        public readonly Vector3I5F27 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, X); }
        public readonly Vector3I5F27 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, Y); }
        public readonly Vector3I5F27 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, Z); }
        public readonly Vector3I5F27 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, X); }
        public readonly Vector3I5F27 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, Y); }
        public readonly Vector3I5F27 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, Z); }
        public readonly Vector3I5F27 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, X); }
        public readonly Vector3I5F27 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, Y); }
        public readonly Vector3I5F27 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, Z); }
        public readonly Vector3I5F27 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, X); }
        public readonly Vector3I5F27 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, Y); }
        public readonly Vector3I5F27 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, Z); }
        public readonly Vector3I5F27 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, X); }
        public readonly Vector3I5F27 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, Y); }
        public readonly Vector3I5F27 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, Z); }
        public readonly Vector4I5F27 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, X); }
        public readonly Vector4I5F27 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, Y); }
        public readonly Vector4I5F27 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, Z); }
        public readonly Vector4I5F27 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, X); }
        public readonly Vector4I5F27 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, Y); }
        public readonly Vector4I5F27 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, Z); }
        public readonly Vector4I5F27 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, X); }
        public readonly Vector4I5F27 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, Y); }
        public readonly Vector4I5F27 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, Z); }
        public readonly Vector4I5F27 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, X); }
        public readonly Vector4I5F27 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, Y); }
        public readonly Vector4I5F27 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, Z); }
        public readonly Vector4I5F27 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, X); }
        public readonly Vector4I5F27 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, Y); }
        public readonly Vector4I5F27 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, Z); }
        public readonly Vector4I5F27 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, X); }
        public readonly Vector4I5F27 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, Y); }
        public readonly Vector4I5F27 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, Z); }
        public readonly Vector4I5F27 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, X); }
        public readonly Vector4I5F27 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, Y); }
        public readonly Vector4I5F27 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, Z); }
        public readonly Vector4I5F27 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, X); }
        public readonly Vector4I5F27 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, Y); }
        public readonly Vector4I5F27 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, Z); }
        public readonly Vector4I5F27 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, X); }
        public readonly Vector4I5F27 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, Y); }
        public readonly Vector4I5F27 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, Z); }
        public readonly Vector4I5F27 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, X); }
        public readonly Vector4I5F27 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, Y); }
        public readonly Vector4I5F27 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, Z); }
        public readonly Vector4I5F27 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, X); }
        public readonly Vector4I5F27 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, Y); }
        public readonly Vector4I5F27 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, Z); }
        public readonly Vector4I5F27 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, X); }
        public readonly Vector4I5F27 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, Y); }
        public readonly Vector4I5F27 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, Z); }
        public readonly Vector4I5F27 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, X); }
        public readonly Vector4I5F27 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, Y); }
        public readonly Vector4I5F27 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, Z); }
        public readonly Vector4I5F27 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, X); }
        public readonly Vector4I5F27 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, Y); }
        public readonly Vector4I5F27 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, Z); }
        public readonly Vector4I5F27 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, X); }
        public readonly Vector4I5F27 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, Y); }
        public readonly Vector4I5F27 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, Z); }
        public readonly Vector4I5F27 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, X); }
        public readonly Vector4I5F27 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, Y); }
        public readonly Vector4I5F27 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, Z); }
        public readonly Vector4I5F27 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, X); }
        public readonly Vector4I5F27 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, Y); }
        public readonly Vector4I5F27 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, Z); }
        public readonly Vector4I5F27 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, X); }
        public readonly Vector4I5F27 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, Y); }
        public readonly Vector4I5F27 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, Z); }
        public readonly Vector4I5F27 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, X); }
        public readonly Vector4I5F27 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, Y); }
        public readonly Vector4I5F27 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, Z); }
        public readonly Vector4I5F27 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, X); }
        public readonly Vector4I5F27 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, Y); }
        public readonly Vector4I5F27 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, Z); }
        public readonly Vector4I5F27 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, X); }
        public readonly Vector4I5F27 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, Y); }
        public readonly Vector4I5F27 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, Z); }
        public readonly Vector4I5F27 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, X); }
        public readonly Vector4I5F27 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, Y); }
        public readonly Vector4I5F27 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, Z); }
        public readonly Vector4I5F27 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, X); }
        public readonly Vector4I5F27 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, Y); }
        public readonly Vector4I5F27 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, Z); }
        public readonly Vector4I5F27 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, X); }
        public readonly Vector4I5F27 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, Y); }
        public readonly Vector4I5F27 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, Z); }
        public readonly Vector4I5F27 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, X); }
        public readonly Vector4I5F27 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, Y); }
        public readonly Vector4I5F27 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, Z); }
        public readonly Vector4I5F27 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, X); }
        public readonly Vector4I5F27 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, Y); }
        public readonly Vector4I5F27 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, Z); }
        public readonly Vector4I5F27 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, X); }
        public readonly Vector4I5F27 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, Y); }
        public readonly Vector4I5F27 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I5F27 other)
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I5F27 Half() => new Vector3I5F27(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I5F27 Twice() => new Vector3I5F27(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I5F27 Clamp(I5F27 min, I5F27 max) => new Vector3I5F27(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I5F27 Clamp(
            Vector3I5F27 min, Vector3I5F27 max
        ) => new Vector3I5F27(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I5F27 SaturatingAdd(Vector3I5F27 other) => new Vector3I5F27(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I5F27 SaturatingMul(I5F27 other) => new Vector3I5F27(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CrossInternal(Vector3I5F27 other, out long x, out long y, out long z) {
            var ax = (long)X.Bits;
            var ay = (long)Y.Bits;
            var az = (long)Z.Bits;
            var bx = (long)other.X.Bits;
            var by = (long)other.Y.Bits;
            var bz = (long)other.Z.Bits;

            x = (ay * bz) - (az * by);
            y = (az * bx) - (ax * bz);
            z = (ax * by) - (ay * bx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I5F27 Cross(Vector3I5F27 other) {
            const long k = 1L << 27;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I5F27(
                I5F27.FromBits((int)(x / k)),
                I5F27.FromBits((int)(y / k)),
                I5F27.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I5F27 SaturatingCross(Vector3I5F27 other) {
            const long k = 1L << 27;
            CrossInternal(other, out var x, out var y, out var z);
            x /= k;
            if (x > int.MaxValue) {
                x = int.MaxValue;
            } else if (x < int.MinValue) {
                x = int.MinValue;
            }
            y /= k;
            if (y > int.MaxValue) {
                y = int.MaxValue;
            } else if (y < int.MinValue) {
                y = int.MinValue;
            }
            z /= k;
            if (z > int.MaxValue) {
                z = int.MaxValue;
            } else if (z < int.MinValue) {
                z = int.MinValue;
            }
            return new Vector3I5F27(
                I5F27.FromBits((int)x),
                I5F27.FromBits((int)y),
                I5F27.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector3I5F27 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;
            var z = ((long)Z.Bits) * other.Z.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4) +
                (z / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I5F27 Dot(Vector3I5F27 other) {
            const long k = 1L << 25;
            return I5F27.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I5F27 SaturatingDot(Vector3I5F27 other) {
            const long k = 1L << 25;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I5F27.MaxValue;
            } else if (bits < int.MinValue) {
                return I5F27.MinValue;
            } else {
                return I5F27.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// ベクトルの長さの 2 乗を返します｡
        /// </summary>
        /// <remarks>
        /// オーバーフローを防ぐため､ 計算の過程で 4 で除算しています｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I12F52 LengthSquared() {
            return I12F52.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I5F27 LengthHalf() => I5F27.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I6F26 Length() => I6F26.FromBits(LengthInternal());

    }

    partial struct I5F27 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I5F27 SaturatingMul(Vector3I5F27 other) => other.SaturatingMul(this);
    }
}
