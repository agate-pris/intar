using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I9F23 : IEquatable<Vector3I9F23>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I9F23 X;
        public I9F23 Y;
        public I9F23 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I9F23(I9F23 x, I9F23 y, I9F23 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I9F23(I9F23 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I9F23(I9F23 x, Vector2I9F23 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I9F23(Vector3I9F23 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I9F23(Vector2I9F23 xy, I9F23 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I9F23 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I9F23(I9F23.Zero);
        }
        public static Vector3I9F23 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I9F23(I9F23.One);
        }
        public static Vector3I9F23 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I9F23(I9F23.One, I9F23.Zero, I9F23.Zero);
        }
        public static Vector3I9F23 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I9F23(I9F23.Zero, I9F23.One, I9F23.Zero);
        }
        public static Vector3I9F23 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I9F23(I9F23.Zero, I9F23.Zero, I9F23.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 operator +(Vector3I9F23 a, Vector3I9F23 b) => new Vector3I9F23(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 operator -(Vector3I9F23 a, Vector3I9F23 b) => new Vector3I9F23(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 operator *(Vector3I9F23 a, Vector3I9F23 b) => new Vector3I9F23(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 operator *(Vector3I9F23 a, I9F23 b) => new Vector3I9F23(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 operator *(I9F23 a, Vector3I9F23 b) => new Vector3I9F23(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 operator /(Vector3I9F23 a, Vector3I9F23 b) => new Vector3I9F23(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 operator /(Vector3I9F23 a, I9F23 b) => new Vector3I9F23(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 operator /(I9F23 a, Vector3I9F23 b) => new Vector3I9F23(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I9F23 lhs, Vector3I9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I9F23 lhs, Vector3I9F23 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I9F23 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(X, X); }
        public readonly Vector2I9F23 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(X, Y); }
        public readonly Vector2I9F23 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(X, Z); }
        public readonly Vector2I9F23 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Y, X); }
        public readonly Vector2I9F23 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Y, Y); }
        public readonly Vector2I9F23 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Y, Z); }
        public readonly Vector2I9F23 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Z, X); }
        public readonly Vector2I9F23 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Z, Y); }
        public readonly Vector2I9F23 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Z, Z); }
        public readonly Vector3I9F23 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, X, X); }
        public readonly Vector3I9F23 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, X, Y); }
        public readonly Vector3I9F23 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, X, Z); }
        public readonly Vector3I9F23 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Y, X); }
        public readonly Vector3I9F23 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Y, Y); }
        public readonly Vector3I9F23 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Y, Z); }
        public readonly Vector3I9F23 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Z, X); }
        public readonly Vector3I9F23 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Z, Y); }
        public readonly Vector3I9F23 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Z, Z); }
        public readonly Vector3I9F23 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, X, X); }
        public readonly Vector3I9F23 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, X, Y); }
        public readonly Vector3I9F23 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, X, Z); }
        public readonly Vector3I9F23 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Y, X); }
        public readonly Vector3I9F23 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Y, Y); }
        public readonly Vector3I9F23 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Y, Z); }
        public readonly Vector3I9F23 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Z, X); }
        public readonly Vector3I9F23 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Z, Y); }
        public readonly Vector3I9F23 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Z, Z); }
        public readonly Vector3I9F23 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, X, X); }
        public readonly Vector3I9F23 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, X, Y); }
        public readonly Vector3I9F23 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, X, Z); }
        public readonly Vector3I9F23 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Y, X); }
        public readonly Vector3I9F23 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Y, Y); }
        public readonly Vector3I9F23 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Y, Z); }
        public readonly Vector3I9F23 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Z, X); }
        public readonly Vector3I9F23 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Z, Y); }
        public readonly Vector3I9F23 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Z, Z); }
        public readonly Vector4I9F23 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, X, X); }
        public readonly Vector4I9F23 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, X, Y); }
        public readonly Vector4I9F23 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, X, Z); }
        public readonly Vector4I9F23 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Y, X); }
        public readonly Vector4I9F23 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Y, Y); }
        public readonly Vector4I9F23 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Y, Z); }
        public readonly Vector4I9F23 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Z, X); }
        public readonly Vector4I9F23 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Z, Y); }
        public readonly Vector4I9F23 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Z, Z); }
        public readonly Vector4I9F23 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, X, X); }
        public readonly Vector4I9F23 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, X, Y); }
        public readonly Vector4I9F23 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, X, Z); }
        public readonly Vector4I9F23 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Y, X); }
        public readonly Vector4I9F23 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Y, Y); }
        public readonly Vector4I9F23 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Y, Z); }
        public readonly Vector4I9F23 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Z, X); }
        public readonly Vector4I9F23 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Z, Y); }
        public readonly Vector4I9F23 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Z, Z); }
        public readonly Vector4I9F23 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, X, X); }
        public readonly Vector4I9F23 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, X, Y); }
        public readonly Vector4I9F23 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, X, Z); }
        public readonly Vector4I9F23 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Y, X); }
        public readonly Vector4I9F23 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Y, Y); }
        public readonly Vector4I9F23 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Y, Z); }
        public readonly Vector4I9F23 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Z, X); }
        public readonly Vector4I9F23 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Z, Y); }
        public readonly Vector4I9F23 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Z, Z); }
        public readonly Vector4I9F23 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, X, X); }
        public readonly Vector4I9F23 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, X, Y); }
        public readonly Vector4I9F23 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, X, Z); }
        public readonly Vector4I9F23 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Y, X); }
        public readonly Vector4I9F23 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Y, Y); }
        public readonly Vector4I9F23 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Y, Z); }
        public readonly Vector4I9F23 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Z, X); }
        public readonly Vector4I9F23 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Z, Y); }
        public readonly Vector4I9F23 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Z, Z); }
        public readonly Vector4I9F23 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, X, X); }
        public readonly Vector4I9F23 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, X, Y); }
        public readonly Vector4I9F23 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, X, Z); }
        public readonly Vector4I9F23 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Y, X); }
        public readonly Vector4I9F23 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Y, Y); }
        public readonly Vector4I9F23 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Y, Z); }
        public readonly Vector4I9F23 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Z, X); }
        public readonly Vector4I9F23 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Z, Y); }
        public readonly Vector4I9F23 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Z, Z); }
        public readonly Vector4I9F23 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, X, X); }
        public readonly Vector4I9F23 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, X, Y); }
        public readonly Vector4I9F23 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, X, Z); }
        public readonly Vector4I9F23 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Y, X); }
        public readonly Vector4I9F23 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Y, Y); }
        public readonly Vector4I9F23 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Y, Z); }
        public readonly Vector4I9F23 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Z, X); }
        public readonly Vector4I9F23 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Z, Y); }
        public readonly Vector4I9F23 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Z, Z); }
        public readonly Vector4I9F23 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, X, X); }
        public readonly Vector4I9F23 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, X, Y); }
        public readonly Vector4I9F23 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, X, Z); }
        public readonly Vector4I9F23 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Y, X); }
        public readonly Vector4I9F23 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Y, Y); }
        public readonly Vector4I9F23 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Y, Z); }
        public readonly Vector4I9F23 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Z, X); }
        public readonly Vector4I9F23 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Z, Y); }
        public readonly Vector4I9F23 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Z, Z); }
        public readonly Vector4I9F23 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, X, X); }
        public readonly Vector4I9F23 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, X, Y); }
        public readonly Vector4I9F23 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, X, Z); }
        public readonly Vector4I9F23 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Y, X); }
        public readonly Vector4I9F23 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Y, Y); }
        public readonly Vector4I9F23 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Y, Z); }
        public readonly Vector4I9F23 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Z, X); }
        public readonly Vector4I9F23 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Z, Y); }
        public readonly Vector4I9F23 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Z, Z); }
        public readonly Vector4I9F23 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, X, X); }
        public readonly Vector4I9F23 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, X, Y); }
        public readonly Vector4I9F23 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, X, Z); }
        public readonly Vector4I9F23 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Y, X); }
        public readonly Vector4I9F23 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Y, Y); }
        public readonly Vector4I9F23 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Y, Z); }
        public readonly Vector4I9F23 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Z, X); }
        public readonly Vector4I9F23 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Z, Y); }
        public readonly Vector4I9F23 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I9F23 other)
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

        public readonly Vector3I9F23 Half() => new Vector3I9F23(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I9F23 Twice() => new Vector3I9F23(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I9F23 Clamp(I9F23 min, I9F23 max) => new Vector3I9F23(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I9F23 Clamp(
            Vector3I9F23 min, Vector3I9F23 max
        ) => new Vector3I9F23(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I9F23 SaturatingAdd(Vector3I9F23 other) => new Vector3I9F23(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I9F23 SaturatingMul(I9F23 other) => new Vector3I9F23(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I9F23 Cross(Vector3I9F23 other) {
            return ((this * other.YZX) - (YZX * other)).YZX;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I20F44 WideningDot(Vector3I9F23 other) {
            var x = X.WideningMul(other.X);
            var y = Y.WideningMul(other.Y);
            var z = Z.WideningMul(other.Z);

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x.Bits / 4) +
                (y.Bits / 4) +
                (z.Bits / 4);
            return I20F44.FromBits(bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I9F23 Dot(Vector3I9F23 other) => (I9F23)WideningDot(other);

    }

    partial struct I9F23 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I9F23 SaturatingMul(Vector3I9F23 other) => other.SaturatingMul(this);
    }
}
