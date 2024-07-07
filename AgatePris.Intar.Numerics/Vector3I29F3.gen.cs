using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I29F3 : IEquatable<Vector3I29F3>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I29F3 X;
        public I29F3 Y;
        public I29F3 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I29F3(I29F3 x, I29F3 y, I29F3 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I29F3(I29F3 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I29F3(I29F3 x, Vector2I29F3 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I29F3(Vector3I29F3 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I29F3(Vector2I29F3 xy, I29F3 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I29F3 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I29F3(I29F3.Zero);
        }
        public static Vector3I29F3 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I29F3(I29F3.One);
        }
        public static Vector3I29F3 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I29F3(I29F3.One, I29F3.Zero, I29F3.Zero);
        }
        public static Vector3I29F3 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I29F3(I29F3.Zero, I29F3.One, I29F3.Zero);
        }
        public static Vector3I29F3 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I29F3(I29F3.Zero, I29F3.Zero, I29F3.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 operator +(Vector3I29F3 a, Vector3I29F3 b) => new Vector3I29F3(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 operator -(Vector3I29F3 a, Vector3I29F3 b) => new Vector3I29F3(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 operator *(Vector3I29F3 a, Vector3I29F3 b) => new Vector3I29F3(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 operator *(Vector3I29F3 a, I29F3 b) => new Vector3I29F3(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 operator *(I29F3 a, Vector3I29F3 b) => new Vector3I29F3(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 operator /(Vector3I29F3 a, Vector3I29F3 b) => new Vector3I29F3(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 operator /(Vector3I29F3 a, I29F3 b) => new Vector3I29F3(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 operator /(I29F3 a, Vector3I29F3 b) => new Vector3I29F3(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I29F3 lhs, Vector3I29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I29F3 lhs, Vector3I29F3 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I29F3 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, X); }
        public readonly Vector2I29F3 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, Y); }
        public readonly Vector2I29F3 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, Z); }
        public readonly Vector2I29F3 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, X); }
        public readonly Vector2I29F3 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, Y); }
        public readonly Vector2I29F3 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, Z); }
        public readonly Vector2I29F3 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, X); }
        public readonly Vector2I29F3 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, Y); }
        public readonly Vector2I29F3 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, Z); }
        public readonly Vector3I29F3 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, X); }
        public readonly Vector3I29F3 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, Y); }
        public readonly Vector3I29F3 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, Z); }
        public readonly Vector3I29F3 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, X); }
        public readonly Vector3I29F3 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, Y); }
        public readonly Vector3I29F3 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, Z); }
        public readonly Vector3I29F3 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, X); }
        public readonly Vector3I29F3 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, Y); }
        public readonly Vector3I29F3 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, Z); }
        public readonly Vector3I29F3 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, X); }
        public readonly Vector3I29F3 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, Y); }
        public readonly Vector3I29F3 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, Z); }
        public readonly Vector3I29F3 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, X); }
        public readonly Vector3I29F3 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, Y); }
        public readonly Vector3I29F3 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, Z); }
        public readonly Vector3I29F3 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, X); }
        public readonly Vector3I29F3 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, Y); }
        public readonly Vector3I29F3 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, Z); }
        public readonly Vector3I29F3 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, X); }
        public readonly Vector3I29F3 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, Y); }
        public readonly Vector3I29F3 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, Z); }
        public readonly Vector3I29F3 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, X); }
        public readonly Vector3I29F3 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, Y); }
        public readonly Vector3I29F3 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, Z); }
        public readonly Vector3I29F3 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, X); }
        public readonly Vector3I29F3 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, Y); }
        public readonly Vector3I29F3 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, Z); }
        public readonly Vector4I29F3 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, X); }
        public readonly Vector4I29F3 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, Y); }
        public readonly Vector4I29F3 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, Z); }
        public readonly Vector4I29F3 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, X); }
        public readonly Vector4I29F3 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, Y); }
        public readonly Vector4I29F3 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, Z); }
        public readonly Vector4I29F3 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, X); }
        public readonly Vector4I29F3 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, Y); }
        public readonly Vector4I29F3 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, Z); }
        public readonly Vector4I29F3 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, X); }
        public readonly Vector4I29F3 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, Y); }
        public readonly Vector4I29F3 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, Z); }
        public readonly Vector4I29F3 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, X); }
        public readonly Vector4I29F3 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, Y); }
        public readonly Vector4I29F3 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, Z); }
        public readonly Vector4I29F3 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, X); }
        public readonly Vector4I29F3 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, Y); }
        public readonly Vector4I29F3 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, Z); }
        public readonly Vector4I29F3 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, X); }
        public readonly Vector4I29F3 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, Y); }
        public readonly Vector4I29F3 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, Z); }
        public readonly Vector4I29F3 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, X); }
        public readonly Vector4I29F3 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, Y); }
        public readonly Vector4I29F3 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, Z); }
        public readonly Vector4I29F3 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, X); }
        public readonly Vector4I29F3 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, Y); }
        public readonly Vector4I29F3 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, Z); }
        public readonly Vector4I29F3 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, X); }
        public readonly Vector4I29F3 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, Y); }
        public readonly Vector4I29F3 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, Z); }
        public readonly Vector4I29F3 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, X); }
        public readonly Vector4I29F3 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, Y); }
        public readonly Vector4I29F3 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, Z); }
        public readonly Vector4I29F3 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, X); }
        public readonly Vector4I29F3 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, Y); }
        public readonly Vector4I29F3 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, Z); }
        public readonly Vector4I29F3 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, X); }
        public readonly Vector4I29F3 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, Y); }
        public readonly Vector4I29F3 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, Z); }
        public readonly Vector4I29F3 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, X); }
        public readonly Vector4I29F3 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, Y); }
        public readonly Vector4I29F3 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, Z); }
        public readonly Vector4I29F3 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, X); }
        public readonly Vector4I29F3 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, Y); }
        public readonly Vector4I29F3 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, Z); }
        public readonly Vector4I29F3 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, X); }
        public readonly Vector4I29F3 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, Y); }
        public readonly Vector4I29F3 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, Z); }
        public readonly Vector4I29F3 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, X); }
        public readonly Vector4I29F3 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, Y); }
        public readonly Vector4I29F3 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, Z); }
        public readonly Vector4I29F3 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, X); }
        public readonly Vector4I29F3 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, Y); }
        public readonly Vector4I29F3 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, Z); }
        public readonly Vector4I29F3 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, X); }
        public readonly Vector4I29F3 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, Y); }
        public readonly Vector4I29F3 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, Z); }
        public readonly Vector4I29F3 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, X); }
        public readonly Vector4I29F3 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, Y); }
        public readonly Vector4I29F3 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, Z); }
        public readonly Vector4I29F3 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, X); }
        public readonly Vector4I29F3 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, Y); }
        public readonly Vector4I29F3 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, Z); }
        public readonly Vector4I29F3 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, X); }
        public readonly Vector4I29F3 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, Y); }
        public readonly Vector4I29F3 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, Z); }
        public readonly Vector4I29F3 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, X); }
        public readonly Vector4I29F3 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, Y); }
        public readonly Vector4I29F3 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, Z); }
        public readonly Vector4I29F3 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, X); }
        public readonly Vector4I29F3 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, Y); }
        public readonly Vector4I29F3 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, Z); }
        public readonly Vector4I29F3 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, X); }
        public readonly Vector4I29F3 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, Y); }
        public readonly Vector4I29F3 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, Z); }
        public readonly Vector4I29F3 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, X); }
        public readonly Vector4I29F3 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, Y); }
        public readonly Vector4I29F3 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, Z); }
        public readonly Vector4I29F3 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, X); }
        public readonly Vector4I29F3 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, Y); }
        public readonly Vector4I29F3 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I29F3 other)
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

        public readonly Vector3I29F3 Half() => new Vector3I29F3(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I29F3 Twice() => new Vector3I29F3(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I29F3 Clamp(I29F3 min, I29F3 max) => new Vector3I29F3(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I29F3 Clamp(
            Vector3I29F3 min, Vector3I29F3 max
        ) => new Vector3I29F3(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I29F3 SaturatingAdd(Vector3I29F3 other) => new Vector3I29F3(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I29F3 SaturatingMul(I29F3 other) => new Vector3I29F3(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I29F3 Cross(Vector3I29F3 other) {
            return ((this * other.YZX) - (YZX * other)).YZX;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I60F4 WideningDot(Vector3I29F3 other) {
            var x = X.WideningMul(other.X);
            var y = Y.WideningMul(other.Y);
            var z = Z.WideningMul(other.Z);

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x.Bits / 4) +
                (y.Bits / 4) +
                (z.Bits / 4);
            return I60F4.FromBits(bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I29F3 Dot(Vector3I29F3 other) => (I29F3)WideningDot(other);

    }

    partial struct I29F3 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I29F3 SaturatingMul(Vector3I29F3 other) => other.SaturatingMul(this);
    }
}
