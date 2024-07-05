using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I14F18 : IEquatable<Vector3I14F18>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I14F18 X;
        public I14F18 Y;
        public I14F18 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I14F18(I14F18 x, I14F18 y, I14F18 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I14F18(I14F18 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I14F18(I14F18 x, Vector2I14F18 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I14F18(Vector3I14F18 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I14F18(Vector2I14F18 xy, I14F18 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I14F18 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I14F18(I14F18.Zero);
        }
        public static Vector3I14F18 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I14F18(I14F18.One);
        }
        public static Vector3I14F18 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I14F18(I14F18.One, I14F18.Zero, I14F18.Zero);
        }
        public static Vector3I14F18 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I14F18(I14F18.Zero, I14F18.One, I14F18.Zero);
        }
        public static Vector3I14F18 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I14F18(I14F18.Zero, I14F18.Zero, I14F18.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator +(Vector3I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator -(Vector3I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator *(Vector3I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator *(Vector3I14F18 a, I14F18 b) => new Vector3I14F18(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator *(I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator /(Vector3I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator /(Vector3I14F18 a, I14F18 b) => new Vector3I14F18(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 operator /(I14F18 a, Vector3I14F18 b) => new Vector3I14F18(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I14F18 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, X); }
        public readonly Vector2I14F18 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, Y); }
        public readonly Vector2I14F18 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, Z); }
        public readonly Vector2I14F18 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, X); }
        public readonly Vector2I14F18 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, Y); }
        public readonly Vector2I14F18 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, Z); }
        public readonly Vector2I14F18 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Z, X); }
        public readonly Vector2I14F18 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Z, Y); }
        public readonly Vector2I14F18 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Z, Z); }
        public readonly Vector3I14F18 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, X); }
        public readonly Vector3I14F18 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, Y); }
        public readonly Vector3I14F18 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, Z); }
        public readonly Vector3I14F18 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, X); }
        public readonly Vector3I14F18 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, Y); }
        public readonly Vector3I14F18 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, Z); }
        public readonly Vector3I14F18 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Z, X); }
        public readonly Vector3I14F18 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Z, Y); }
        public readonly Vector3I14F18 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Z, Z); }
        public readonly Vector3I14F18 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, X); }
        public readonly Vector3I14F18 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, Y); }
        public readonly Vector3I14F18 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, Z); }
        public readonly Vector3I14F18 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, X); }
        public readonly Vector3I14F18 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, Y); }
        public readonly Vector3I14F18 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, Z); }
        public readonly Vector3I14F18 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Z, X); }
        public readonly Vector3I14F18 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Z, Y); }
        public readonly Vector3I14F18 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Z, Z); }
        public readonly Vector3I14F18 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, X, X); }
        public readonly Vector3I14F18 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, X, Y); }
        public readonly Vector3I14F18 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, X, Z); }
        public readonly Vector3I14F18 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Y, X); }
        public readonly Vector3I14F18 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Y, Y); }
        public readonly Vector3I14F18 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Y, Z); }
        public readonly Vector3I14F18 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Z, X); }
        public readonly Vector3I14F18 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Z, Y); }
        public readonly Vector3I14F18 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Z, Z); }
        public readonly Vector4I14F18 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, X); }
        public readonly Vector4I14F18 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, Y); }
        public readonly Vector4I14F18 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, Z); }
        public readonly Vector4I14F18 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, X); }
        public readonly Vector4I14F18 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, Y); }
        public readonly Vector4I14F18 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, Z); }
        public readonly Vector4I14F18 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Z, X); }
        public readonly Vector4I14F18 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Z, Y); }
        public readonly Vector4I14F18 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Z, Z); }
        public readonly Vector4I14F18 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, X); }
        public readonly Vector4I14F18 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, Y); }
        public readonly Vector4I14F18 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, Z); }
        public readonly Vector4I14F18 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, X); }
        public readonly Vector4I14F18 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, Y); }
        public readonly Vector4I14F18 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, Z); }
        public readonly Vector4I14F18 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Z, X); }
        public readonly Vector4I14F18 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Z, Y); }
        public readonly Vector4I14F18 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Z, Z); }
        public readonly Vector4I14F18 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, X, X); }
        public readonly Vector4I14F18 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, X, Y); }
        public readonly Vector4I14F18 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, X, Z); }
        public readonly Vector4I14F18 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Y, X); }
        public readonly Vector4I14F18 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Y, Y); }
        public readonly Vector4I14F18 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Y, Z); }
        public readonly Vector4I14F18 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Z, X); }
        public readonly Vector4I14F18 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Z, Y); }
        public readonly Vector4I14F18 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Z, Z); }
        public readonly Vector4I14F18 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, X); }
        public readonly Vector4I14F18 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, Y); }
        public readonly Vector4I14F18 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, Z); }
        public readonly Vector4I14F18 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, X); }
        public readonly Vector4I14F18 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, Y); }
        public readonly Vector4I14F18 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, Z); }
        public readonly Vector4I14F18 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Z, X); }
        public readonly Vector4I14F18 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Z, Y); }
        public readonly Vector4I14F18 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Z, Z); }
        public readonly Vector4I14F18 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, X); }
        public readonly Vector4I14F18 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, Y); }
        public readonly Vector4I14F18 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, Z); }
        public readonly Vector4I14F18 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, X); }
        public readonly Vector4I14F18 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, Y); }
        public readonly Vector4I14F18 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, Z); }
        public readonly Vector4I14F18 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Z, X); }
        public readonly Vector4I14F18 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Z, Y); }
        public readonly Vector4I14F18 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Z, Z); }
        public readonly Vector4I14F18 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, X, X); }
        public readonly Vector4I14F18 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, X, Y); }
        public readonly Vector4I14F18 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, X, Z); }
        public readonly Vector4I14F18 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Y, X); }
        public readonly Vector4I14F18 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Y, Y); }
        public readonly Vector4I14F18 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Y, Z); }
        public readonly Vector4I14F18 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Z, X); }
        public readonly Vector4I14F18 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Z, Y); }
        public readonly Vector4I14F18 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Z, Z); }
        public readonly Vector4I14F18 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, X, X); }
        public readonly Vector4I14F18 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, X, Y); }
        public readonly Vector4I14F18 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, X, Z); }
        public readonly Vector4I14F18 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Y, X); }
        public readonly Vector4I14F18 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Y, Y); }
        public readonly Vector4I14F18 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Y, Z); }
        public readonly Vector4I14F18 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Z, X); }
        public readonly Vector4I14F18 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Z, Y); }
        public readonly Vector4I14F18 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Z, Z); }
        public readonly Vector4I14F18 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, X, X); }
        public readonly Vector4I14F18 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, X, Y); }
        public readonly Vector4I14F18 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, X, Z); }
        public readonly Vector4I14F18 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Y, X); }
        public readonly Vector4I14F18 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Y, Y); }
        public readonly Vector4I14F18 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Y, Z); }
        public readonly Vector4I14F18 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Z, X); }
        public readonly Vector4I14F18 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Z, Y); }
        public readonly Vector4I14F18 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Z, Z); }
        public readonly Vector4I14F18 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, X, X); }
        public readonly Vector4I14F18 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, X, Y); }
        public readonly Vector4I14F18 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, X, Z); }
        public readonly Vector4I14F18 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Y, X); }
        public readonly Vector4I14F18 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Y, Y); }
        public readonly Vector4I14F18 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Y, Z); }
        public readonly Vector4I14F18 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Z, X); }
        public readonly Vector4I14F18 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Z, Y); }
        public readonly Vector4I14F18 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Z, Z); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I14F18 lhs, Vector3I14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I14F18 lhs, Vector3I14F18 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I14F18 other)
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

        public readonly Vector3I14F18 Half() => new Vector3I14F18(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I14F18 Twice() => new Vector3I14F18(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I14F18 Clamp(I14F18 min, I14F18 max) => new Vector3I14F18(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I14F18 Clamp(
            Vector3I14F18 min, Vector3I14F18 max
        ) => new Vector3I14F18(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I14F18 SaturatingAdd(Vector3I14F18 other) => new Vector3I14F18(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I14F18 SaturatingMul(I14F18 other) => new Vector3I14F18(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

    }

    partial struct I14F18 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I14F18 SaturatingMul(Vector3I14F18 other) => other.SaturatingMul(this);
    }
}
