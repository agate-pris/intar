using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I12F20 : IEquatable<Vector3I12F20>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I12F20 X;
        public I12F20 Y;
        public I12F20 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20(I12F20 x, I12F20 y, I12F20 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20(I12F20 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20(I12F20 x, Vector2I12F20 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20(Vector3I12F20 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20(Vector2I12F20 xy, I12F20 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I12F20 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I12F20(I12F20.Zero);
        }
        public static Vector3I12F20 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I12F20(I12F20.One);
        }
        public static Vector3I12F20 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I12F20(I12F20.One, I12F20.Zero, I12F20.Zero);
        }
        public static Vector3I12F20 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I12F20(I12F20.Zero, I12F20.One, I12F20.Zero);
        }
        public static Vector3I12F20 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I12F20(I12F20.Zero, I12F20.Zero, I12F20.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator +(Vector3I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator -(Vector3I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator *(Vector3I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator *(Vector3I12F20 a, I12F20 b) => new Vector3I12F20(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator *(I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator /(Vector3I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator /(Vector3I12F20 a, I12F20 b) => new Vector3I12F20(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator /(I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I12F20 lhs, Vector3I12F20 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I12F20 lhs, Vector3I12F20 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I12F20 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, X); }
        public readonly Vector2I12F20 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, Y); }
        public readonly Vector2I12F20 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, Z); }
        public readonly Vector2I12F20 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, X); }
        public readonly Vector2I12F20 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, Y); }
        public readonly Vector2I12F20 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, Z); }
        public readonly Vector2I12F20 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, X); }
        public readonly Vector2I12F20 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, Y); }
        public readonly Vector2I12F20 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, Z); }
        public readonly Vector3I12F20 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, X); }
        public readonly Vector3I12F20 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, Y); }
        public readonly Vector3I12F20 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, Z); }
        public readonly Vector3I12F20 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, X); }
        public readonly Vector3I12F20 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, Y); }
        public readonly Vector3I12F20 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, Z); }
        public readonly Vector3I12F20 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, X); }
        public readonly Vector3I12F20 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, Y); }
        public readonly Vector3I12F20 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, Z); }
        public readonly Vector3I12F20 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, X); }
        public readonly Vector3I12F20 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, Y); }
        public readonly Vector3I12F20 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, Z); }
        public readonly Vector3I12F20 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, X); }
        public readonly Vector3I12F20 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, Y); }
        public readonly Vector3I12F20 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, Z); }
        public readonly Vector3I12F20 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, X); }
        public readonly Vector3I12F20 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, Y); }
        public readonly Vector3I12F20 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, Z); }
        public readonly Vector3I12F20 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, X); }
        public readonly Vector3I12F20 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, Y); }
        public readonly Vector3I12F20 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, Z); }
        public readonly Vector3I12F20 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, X); }
        public readonly Vector3I12F20 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, Y); }
        public readonly Vector3I12F20 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, Z); }
        public readonly Vector3I12F20 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, X); }
        public readonly Vector3I12F20 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, Y); }
        public readonly Vector3I12F20 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, Z); }
        public readonly Vector4I12F20 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, X); }
        public readonly Vector4I12F20 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, Y); }
        public readonly Vector4I12F20 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, Z); }
        public readonly Vector4I12F20 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, X); }
        public readonly Vector4I12F20 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, Y); }
        public readonly Vector4I12F20 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, Z); }
        public readonly Vector4I12F20 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, X); }
        public readonly Vector4I12F20 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, Y); }
        public readonly Vector4I12F20 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, Z); }
        public readonly Vector4I12F20 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, X); }
        public readonly Vector4I12F20 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, Y); }
        public readonly Vector4I12F20 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, Z); }
        public readonly Vector4I12F20 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, X); }
        public readonly Vector4I12F20 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, Y); }
        public readonly Vector4I12F20 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, Z); }
        public readonly Vector4I12F20 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, X); }
        public readonly Vector4I12F20 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, Y); }
        public readonly Vector4I12F20 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, Z); }
        public readonly Vector4I12F20 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, X); }
        public readonly Vector4I12F20 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, Y); }
        public readonly Vector4I12F20 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, Z); }
        public readonly Vector4I12F20 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, X); }
        public readonly Vector4I12F20 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, Y); }
        public readonly Vector4I12F20 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, Z); }
        public readonly Vector4I12F20 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, X); }
        public readonly Vector4I12F20 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, Y); }
        public readonly Vector4I12F20 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, Z); }
        public readonly Vector4I12F20 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, X); }
        public readonly Vector4I12F20 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, Y); }
        public readonly Vector4I12F20 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, Z); }
        public readonly Vector4I12F20 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, X); }
        public readonly Vector4I12F20 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, Y); }
        public readonly Vector4I12F20 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, Z); }
        public readonly Vector4I12F20 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, X); }
        public readonly Vector4I12F20 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, Y); }
        public readonly Vector4I12F20 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, Z); }
        public readonly Vector4I12F20 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, X); }
        public readonly Vector4I12F20 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, Y); }
        public readonly Vector4I12F20 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, Z); }
        public readonly Vector4I12F20 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, X); }
        public readonly Vector4I12F20 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, Y); }
        public readonly Vector4I12F20 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, Z); }
        public readonly Vector4I12F20 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, X); }
        public readonly Vector4I12F20 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, Y); }
        public readonly Vector4I12F20 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, Z); }
        public readonly Vector4I12F20 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, X); }
        public readonly Vector4I12F20 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, Y); }
        public readonly Vector4I12F20 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, Z); }
        public readonly Vector4I12F20 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, X); }
        public readonly Vector4I12F20 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, Y); }
        public readonly Vector4I12F20 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, Z); }
        public readonly Vector4I12F20 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, X); }
        public readonly Vector4I12F20 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, Y); }
        public readonly Vector4I12F20 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, Z); }
        public readonly Vector4I12F20 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, X); }
        public readonly Vector4I12F20 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, Y); }
        public readonly Vector4I12F20 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, Z); }
        public readonly Vector4I12F20 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, X); }
        public readonly Vector4I12F20 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, Y); }
        public readonly Vector4I12F20 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, Z); }
        public readonly Vector4I12F20 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, X); }
        public readonly Vector4I12F20 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, Y); }
        public readonly Vector4I12F20 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, Z); }
        public readonly Vector4I12F20 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, X); }
        public readonly Vector4I12F20 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, Y); }
        public readonly Vector4I12F20 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, Z); }
        public readonly Vector4I12F20 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, X); }
        public readonly Vector4I12F20 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, Y); }
        public readonly Vector4I12F20 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, Z); }
        public readonly Vector4I12F20 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, X); }
        public readonly Vector4I12F20 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, Y); }
        public readonly Vector4I12F20 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, Z); }
        public readonly Vector4I12F20 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, X); }
        public readonly Vector4I12F20 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, Y); }
        public readonly Vector4I12F20 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, Z); }
        public readonly Vector4I12F20 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, X); }
        public readonly Vector4I12F20 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, Y); }
        public readonly Vector4I12F20 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, Z); }
        public readonly Vector4I12F20 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, X); }
        public readonly Vector4I12F20 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, Y); }
        public readonly Vector4I12F20 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I12F20 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I12F20>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I12F20 other)
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

        public readonly Vector3I12F20 Half() => new Vector3I12F20(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I12F20 Twice() => new Vector3I12F20(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I12F20 Clamp(I12F20 min, I12F20 max) => new Vector3I12F20(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I12F20 Clamp(
            Vector3I12F20 min, Vector3I12F20 max
        ) => new Vector3I12F20(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I12F20 SaturatingAdd(Vector3I12F20 other) => new Vector3I12F20(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I12F20 SaturatingMul(I12F20 other) => new Vector3I12F20(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CrossInternal(Vector3I12F20 other, out long x, out long y, out long z) {
            var ax = (long)X.Bits;
            var ay = (long)Y.Bits;
            var az = (long)Z.Bits;
            var bx = (long)other.X.Bits;
            var by = (long)other.Y.Bits;
            var bz = (long)other.Z.Bits;

            const long k = 1L << 20;
            x = ((ay * bz) - (az * by)) / k;
            y = ((az * bx) - (ax * bz)) / k;
            z = ((ax * by) - (ay * bx)) / k;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I12F20 Cross(Vector3I12F20 other) {
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I12F20(
                I12F20.FromBits((int)x),
                I12F20.FromBits((int)y),
                I12F20.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I12F20 SaturatingCross(Vector3I12F20 other) {
            CrossInternal(other, out var x, out var y, out var z);
            if (x > int.MaxValue) {
                x = int.MaxValue;
            } else if (x < int.MinValue) {
                x = int.MinValue;
            }
            if (y > int.MaxValue) {
                y = int.MaxValue;
            } else if (y < int.MinValue) {
                y = int.MinValue;
            }
            if (z > int.MaxValue) {
                z = int.MaxValue;
            } else if (z < int.MinValue) {
                z = int.MinValue;
            }
            return new Vector3I12F20(
                I12F20.FromBits((int)x),
                I12F20.FromBits((int)y),
                I12F20.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector3I12F20 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;
            var z = ((long)Z.Bits) * other.Z.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            var bits =
                (x / 4) +
                (y / 4) +
                (z / 4);

            const long k = 1L << 18;
            return bits / k;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I12F20 Dot(Vector3I12F20 other) => I12F20.FromBits((int)DotInternal(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I12F20 SaturatingDot(Vector3I12F20 other) {
            var bits = DotInternal(other);
            if (bits > int.MaxValue) {
                return I12F20.MaxValue;
            } else if (bits < int.MinValue) {
                return I12F20.MinValue;
            } else {
                return I12F20.FromBits((int)bits);
            }
        }

    }

    partial struct I12F20 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I12F20 SaturatingMul(Vector3I12F20 other) => other.SaturatingMul(this);
    }
}
