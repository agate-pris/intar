using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I26F6 : IEquatable<Vector3I26F6>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I26F6 X;
        public I26F6 Y;
        public I26F6 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I26F6(I26F6 x, I26F6 y, I26F6 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I26F6(I26F6 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I26F6(I26F6 x, Vector2I26F6 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I26F6(Vector3I26F6 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I26F6(Vector2I26F6 xy, I26F6 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I26F6 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I26F6(I26F6.Zero);
        }
        public static Vector3I26F6 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I26F6(I26F6.One);
        }
        public static Vector3I26F6 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I26F6(I26F6.One, I26F6.Zero, I26F6.Zero);
        }
        public static Vector3I26F6 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I26F6(I26F6.Zero, I26F6.One, I26F6.Zero);
        }
        public static Vector3I26F6 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I26F6(I26F6.Zero, I26F6.Zero, I26F6.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 operator +(Vector3I26F6 a, Vector3I26F6 b) => new Vector3I26F6(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 operator -(Vector3I26F6 a, Vector3I26F6 b) => new Vector3I26F6(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 operator *(Vector3I26F6 a, Vector3I26F6 b) => new Vector3I26F6(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 operator *(Vector3I26F6 a, I26F6 b) => new Vector3I26F6(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 operator *(I26F6 a, Vector3I26F6 b) => new Vector3I26F6(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 operator /(Vector3I26F6 a, Vector3I26F6 b) => new Vector3I26F6(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 operator /(Vector3I26F6 a, I26F6 b) => new Vector3I26F6(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 operator /(I26F6 a, Vector3I26F6 b) => new Vector3I26F6(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I26F6 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(X, X); }
        public readonly Vector2I26F6 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(X, Y); }
        public readonly Vector2I26F6 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(X, Z); }
        public readonly Vector2I26F6 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(Y, X); }
        public readonly Vector2I26F6 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(Y, Y); }
        public readonly Vector2I26F6 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(Y, Z); }
        public readonly Vector2I26F6 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(Z, X); }
        public readonly Vector2I26F6 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(Z, Y); }
        public readonly Vector2I26F6 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(Z, Z); }
        public readonly Vector3I26F6 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, X, X); }
        public readonly Vector3I26F6 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, X, Y); }
        public readonly Vector3I26F6 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, X, Z); }
        public readonly Vector3I26F6 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, Y, X); }
        public readonly Vector3I26F6 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, Y, Y); }
        public readonly Vector3I26F6 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, Y, Z); }
        public readonly Vector3I26F6 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, Z, X); }
        public readonly Vector3I26F6 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, Z, Y); }
        public readonly Vector3I26F6 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, Z, Z); }
        public readonly Vector3I26F6 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, X, X); }
        public readonly Vector3I26F6 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, X, Y); }
        public readonly Vector3I26F6 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, X, Z); }
        public readonly Vector3I26F6 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, Y, X); }
        public readonly Vector3I26F6 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, Y, Y); }
        public readonly Vector3I26F6 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, Y, Z); }
        public readonly Vector3I26F6 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, Z, X); }
        public readonly Vector3I26F6 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, Z, Y); }
        public readonly Vector3I26F6 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, Z, Z); }
        public readonly Vector3I26F6 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Z, X, X); }
        public readonly Vector3I26F6 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Z, X, Y); }
        public readonly Vector3I26F6 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Z, X, Z); }
        public readonly Vector3I26F6 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Z, Y, X); }
        public readonly Vector3I26F6 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Z, Y, Y); }
        public readonly Vector3I26F6 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Z, Y, Z); }
        public readonly Vector3I26F6 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Z, Z, X); }
        public readonly Vector3I26F6 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Z, Z, Y); }
        public readonly Vector3I26F6 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Z, Z, Z); }
        public readonly Vector4I26F6 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, X, X); }
        public readonly Vector4I26F6 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, X, Y); }
        public readonly Vector4I26F6 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, X, Z); }
        public readonly Vector4I26F6 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, Y, X); }
        public readonly Vector4I26F6 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, Y, Y); }
        public readonly Vector4I26F6 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, Y, Z); }
        public readonly Vector4I26F6 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, Z, X); }
        public readonly Vector4I26F6 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, Z, Y); }
        public readonly Vector4I26F6 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, Z, Z); }
        public readonly Vector4I26F6 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, X, X); }
        public readonly Vector4I26F6 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, X, Y); }
        public readonly Vector4I26F6 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, X, Z); }
        public readonly Vector4I26F6 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, Y, X); }
        public readonly Vector4I26F6 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, Y, Y); }
        public readonly Vector4I26F6 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, Y, Z); }
        public readonly Vector4I26F6 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, Z, X); }
        public readonly Vector4I26F6 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, Z, Y); }
        public readonly Vector4I26F6 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, Z, Z); }
        public readonly Vector4I26F6 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Z, X, X); }
        public readonly Vector4I26F6 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Z, X, Y); }
        public readonly Vector4I26F6 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Z, X, Z); }
        public readonly Vector4I26F6 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Z, Y, X); }
        public readonly Vector4I26F6 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Z, Y, Y); }
        public readonly Vector4I26F6 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Z, Y, Z); }
        public readonly Vector4I26F6 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Z, Z, X); }
        public readonly Vector4I26F6 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Z, Z, Y); }
        public readonly Vector4I26F6 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Z, Z, Z); }
        public readonly Vector4I26F6 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, X, X); }
        public readonly Vector4I26F6 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, X, Y); }
        public readonly Vector4I26F6 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, X, Z); }
        public readonly Vector4I26F6 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, Y, X); }
        public readonly Vector4I26F6 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, Y, Y); }
        public readonly Vector4I26F6 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, Y, Z); }
        public readonly Vector4I26F6 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, Z, X); }
        public readonly Vector4I26F6 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, Z, Y); }
        public readonly Vector4I26F6 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, Z, Z); }
        public readonly Vector4I26F6 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, X, X); }
        public readonly Vector4I26F6 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, X, Y); }
        public readonly Vector4I26F6 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, X, Z); }
        public readonly Vector4I26F6 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, Y, X); }
        public readonly Vector4I26F6 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, Y, Y); }
        public readonly Vector4I26F6 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, Y, Z); }
        public readonly Vector4I26F6 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, Z, X); }
        public readonly Vector4I26F6 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, Z, Y); }
        public readonly Vector4I26F6 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, Z, Z); }
        public readonly Vector4I26F6 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Z, X, X); }
        public readonly Vector4I26F6 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Z, X, Y); }
        public readonly Vector4I26F6 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Z, X, Z); }
        public readonly Vector4I26F6 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Z, Y, X); }
        public readonly Vector4I26F6 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Z, Y, Y); }
        public readonly Vector4I26F6 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Z, Y, Z); }
        public readonly Vector4I26F6 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Z, Z, X); }
        public readonly Vector4I26F6 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Z, Z, Y); }
        public readonly Vector4I26F6 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Z, Z, Z); }
        public readonly Vector4I26F6 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, X, X, X); }
        public readonly Vector4I26F6 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, X, X, Y); }
        public readonly Vector4I26F6 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, X, X, Z); }
        public readonly Vector4I26F6 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, X, Y, X); }
        public readonly Vector4I26F6 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, X, Y, Y); }
        public readonly Vector4I26F6 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, X, Y, Z); }
        public readonly Vector4I26F6 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, X, Z, X); }
        public readonly Vector4I26F6 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, X, Z, Y); }
        public readonly Vector4I26F6 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, X, Z, Z); }
        public readonly Vector4I26F6 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Y, X, X); }
        public readonly Vector4I26F6 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Y, X, Y); }
        public readonly Vector4I26F6 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Y, X, Z); }
        public readonly Vector4I26F6 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Y, Y, X); }
        public readonly Vector4I26F6 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Y, Y, Y); }
        public readonly Vector4I26F6 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Y, Y, Z); }
        public readonly Vector4I26F6 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Y, Z, X); }
        public readonly Vector4I26F6 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Y, Z, Y); }
        public readonly Vector4I26F6 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Y, Z, Z); }
        public readonly Vector4I26F6 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Z, X, X); }
        public readonly Vector4I26F6 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Z, X, Y); }
        public readonly Vector4I26F6 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Z, X, Z); }
        public readonly Vector4I26F6 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Z, Y, X); }
        public readonly Vector4I26F6 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Z, Y, Y); }
        public readonly Vector4I26F6 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Z, Y, Z); }
        public readonly Vector4I26F6 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Z, Z, X); }
        public readonly Vector4I26F6 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Z, Z, Y); }
        public readonly Vector4I26F6 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Z, Z, Z, Z); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I26F6 lhs, Vector3I26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I26F6 lhs, Vector3I26F6 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I26F6 other)
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

        public readonly Vector3I26F6 Half() => new Vector3I26F6(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I26F6 Twice() => new Vector3I26F6(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I26F6 Clamp(I26F6 min, I26F6 max) => new Vector3I26F6(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I26F6 Clamp(
            Vector3I26F6 min, Vector3I26F6 max
        ) => new Vector3I26F6(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I26F6 SaturatingAdd(Vector3I26F6 other) => new Vector3I26F6(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I26F6 SaturatingMul(I26F6 other) => new Vector3I26F6(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

    }
}
