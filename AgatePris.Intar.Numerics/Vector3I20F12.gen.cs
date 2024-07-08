using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I20F12 : IEquatable<Vector3I20F12>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I20F12 X;
        public I20F12 Y;
        public I20F12 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I20F12(I20F12 x, I20F12 y, I20F12 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I20F12(I20F12 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I20F12(I20F12 x, Vector2I20F12 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I20F12(Vector3I20F12 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I20F12(Vector2I20F12 xy, I20F12 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I20F12 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I20F12(I20F12.Zero);
        }
        public static Vector3I20F12 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I20F12(I20F12.One);
        }
        public static Vector3I20F12 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I20F12(I20F12.One, I20F12.Zero, I20F12.Zero);
        }
        public static Vector3I20F12 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I20F12(I20F12.Zero, I20F12.One, I20F12.Zero);
        }
        public static Vector3I20F12 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I20F12(I20F12.Zero, I20F12.Zero, I20F12.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator +(Vector3I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator -(Vector3I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator *(Vector3I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator *(Vector3I20F12 a, I20F12 b) => new Vector3I20F12(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator *(I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator /(Vector3I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator /(Vector3I20F12 a, I20F12 b) => new Vector3I20F12(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 operator /(I20F12 a, Vector3I20F12 b) => new Vector3I20F12(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I20F12 lhs, Vector3I20F12 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I20F12 lhs, Vector3I20F12 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I20F12 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, X); }
        public readonly Vector2I20F12 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, Y); }
        public readonly Vector2I20F12 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, Z); }
        public readonly Vector2I20F12 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, X); }
        public readonly Vector2I20F12 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, Y); }
        public readonly Vector2I20F12 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, Z); }
        public readonly Vector2I20F12 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Z, X); }
        public readonly Vector2I20F12 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Z, Y); }
        public readonly Vector2I20F12 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Z, Z); }
        public readonly Vector3I20F12 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, X); }
        public readonly Vector3I20F12 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, Y); }
        public readonly Vector3I20F12 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, Z); }
        public readonly Vector3I20F12 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, X); }
        public readonly Vector3I20F12 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, Y); }
        public readonly Vector3I20F12 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, Z); }
        public readonly Vector3I20F12 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Z, X); }
        public readonly Vector3I20F12 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Z, Y); }
        public readonly Vector3I20F12 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Z, Z); }
        public readonly Vector3I20F12 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, X); }
        public readonly Vector3I20F12 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, Y); }
        public readonly Vector3I20F12 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, Z); }
        public readonly Vector3I20F12 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, X); }
        public readonly Vector3I20F12 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, Y); }
        public readonly Vector3I20F12 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, Z); }
        public readonly Vector3I20F12 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Z, X); }
        public readonly Vector3I20F12 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Z, Y); }
        public readonly Vector3I20F12 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Z, Z); }
        public readonly Vector3I20F12 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, X, X); }
        public readonly Vector3I20F12 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, X, Y); }
        public readonly Vector3I20F12 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, X, Z); }
        public readonly Vector3I20F12 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Y, X); }
        public readonly Vector3I20F12 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Y, Y); }
        public readonly Vector3I20F12 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Y, Z); }
        public readonly Vector3I20F12 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Z, X); }
        public readonly Vector3I20F12 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Z, Y); }
        public readonly Vector3I20F12 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Z, Z); }
        public readonly Vector4I20F12 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, X); }
        public readonly Vector4I20F12 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, Y); }
        public readonly Vector4I20F12 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, Z); }
        public readonly Vector4I20F12 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, X); }
        public readonly Vector4I20F12 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, Y); }
        public readonly Vector4I20F12 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, Z); }
        public readonly Vector4I20F12 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Z, X); }
        public readonly Vector4I20F12 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Z, Y); }
        public readonly Vector4I20F12 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Z, Z); }
        public readonly Vector4I20F12 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, X); }
        public readonly Vector4I20F12 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, Y); }
        public readonly Vector4I20F12 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, Z); }
        public readonly Vector4I20F12 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, X); }
        public readonly Vector4I20F12 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, Y); }
        public readonly Vector4I20F12 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, Z); }
        public readonly Vector4I20F12 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Z, X); }
        public readonly Vector4I20F12 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Z, Y); }
        public readonly Vector4I20F12 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Z, Z); }
        public readonly Vector4I20F12 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, X, X); }
        public readonly Vector4I20F12 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, X, Y); }
        public readonly Vector4I20F12 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, X, Z); }
        public readonly Vector4I20F12 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Y, X); }
        public readonly Vector4I20F12 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Y, Y); }
        public readonly Vector4I20F12 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Y, Z); }
        public readonly Vector4I20F12 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Z, X); }
        public readonly Vector4I20F12 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Z, Y); }
        public readonly Vector4I20F12 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Z, Z); }
        public readonly Vector4I20F12 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, X); }
        public readonly Vector4I20F12 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, Y); }
        public readonly Vector4I20F12 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, Z); }
        public readonly Vector4I20F12 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, X); }
        public readonly Vector4I20F12 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, Y); }
        public readonly Vector4I20F12 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, Z); }
        public readonly Vector4I20F12 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Z, X); }
        public readonly Vector4I20F12 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Z, Y); }
        public readonly Vector4I20F12 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Z, Z); }
        public readonly Vector4I20F12 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, X); }
        public readonly Vector4I20F12 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, Y); }
        public readonly Vector4I20F12 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, Z); }
        public readonly Vector4I20F12 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, X); }
        public readonly Vector4I20F12 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, Y); }
        public readonly Vector4I20F12 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, Z); }
        public readonly Vector4I20F12 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Z, X); }
        public readonly Vector4I20F12 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Z, Y); }
        public readonly Vector4I20F12 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Z, Z); }
        public readonly Vector4I20F12 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, X, X); }
        public readonly Vector4I20F12 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, X, Y); }
        public readonly Vector4I20F12 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, X, Z); }
        public readonly Vector4I20F12 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Y, X); }
        public readonly Vector4I20F12 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Y, Y); }
        public readonly Vector4I20F12 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Y, Z); }
        public readonly Vector4I20F12 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Z, X); }
        public readonly Vector4I20F12 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Z, Y); }
        public readonly Vector4I20F12 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Z, Z); }
        public readonly Vector4I20F12 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, X, X); }
        public readonly Vector4I20F12 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, X, Y); }
        public readonly Vector4I20F12 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, X, Z); }
        public readonly Vector4I20F12 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Y, X); }
        public readonly Vector4I20F12 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Y, Y); }
        public readonly Vector4I20F12 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Y, Z); }
        public readonly Vector4I20F12 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Z, X); }
        public readonly Vector4I20F12 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Z, Y); }
        public readonly Vector4I20F12 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Z, Z); }
        public readonly Vector4I20F12 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, X, X); }
        public readonly Vector4I20F12 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, X, Y); }
        public readonly Vector4I20F12 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, X, Z); }
        public readonly Vector4I20F12 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Y, X); }
        public readonly Vector4I20F12 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Y, Y); }
        public readonly Vector4I20F12 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Y, Z); }
        public readonly Vector4I20F12 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Z, X); }
        public readonly Vector4I20F12 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Z, Y); }
        public readonly Vector4I20F12 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Z, Z); }
        public readonly Vector4I20F12 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, X, X); }
        public readonly Vector4I20F12 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, X, Y); }
        public readonly Vector4I20F12 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, X, Z); }
        public readonly Vector4I20F12 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Y, X); }
        public readonly Vector4I20F12 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Y, Y); }
        public readonly Vector4I20F12 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Y, Z); }
        public readonly Vector4I20F12 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Z, X); }
        public readonly Vector4I20F12 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Z, Y); }
        public readonly Vector4I20F12 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I20F12 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I20F12>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I20F12 other)
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

        public readonly Vector3I20F12 Half() => new Vector3I20F12(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I20F12 Twice() => new Vector3I20F12(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I20F12 Clamp(I20F12 min, I20F12 max) => new Vector3I20F12(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I20F12 Clamp(
            Vector3I20F12 min, Vector3I20F12 max
        ) => new Vector3I20F12(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I20F12 SaturatingAdd(Vector3I20F12 other) => new Vector3I20F12(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I20F12 SaturatingMul(I20F12 other) => new Vector3I20F12(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CrossInternal(Vector3I20F12 other, out long x, out long y, out long z) {
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
        public readonly Vector3I20F12 Cross(Vector3I20F12 other) {
            const long k = 1L << 12;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I20F12(
                I20F12.FromBits((int)(x / k)),
                I20F12.FromBits((int)(y / k)),
                I20F12.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I20F12 SaturatingCross(Vector3I20F12 other) {
            const long k = 1L << 12;
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
            return new Vector3I20F12(
                I20F12.FromBits((int)x),
                I20F12.FromBits((int)y),
                I20F12.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector3I20F12 other) {
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
        public readonly I20F12 Dot(Vector3I20F12 other) {
            const long k = 1L << 10;
            return I20F12.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I20F12 SaturatingDot(Vector3I20F12 other) {
            const long k = 1L << 10;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I20F12.MaxValue;
            } else if (bits < int.MinValue) {
                return I20F12.MinValue;
            } else {
                return I20F12.FromBits((int)bits);
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
        public readonly I42F22 LengthSquared() {
            return I42F22.FromBits(LengthSquaredInternal());
        }

    }

    partial struct I20F12 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I20F12 SaturatingMul(Vector3I20F12 other) => other.SaturatingMul(this);
    }
}
