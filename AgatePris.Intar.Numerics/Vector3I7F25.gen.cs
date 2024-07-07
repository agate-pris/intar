using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I7F25 : IEquatable<Vector3I7F25>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I7F25 X;
        public I7F25 Y;
        public I7F25 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25(I7F25 x, I7F25 y, I7F25 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25(I7F25 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25(I7F25 x, Vector2I7F25 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25(Vector3I7F25 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25(Vector2I7F25 xy, I7F25 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I7F25 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I7F25(I7F25.Zero);
        }
        public static Vector3I7F25 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I7F25(I7F25.One);
        }
        public static Vector3I7F25 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I7F25(I7F25.One, I7F25.Zero, I7F25.Zero);
        }
        public static Vector3I7F25 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I7F25(I7F25.Zero, I7F25.One, I7F25.Zero);
        }
        public static Vector3I7F25 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I7F25(I7F25.Zero, I7F25.Zero, I7F25.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator +(Vector3I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator -(Vector3I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator *(Vector3I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator *(Vector3I7F25 a, I7F25 b) => new Vector3I7F25(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator *(I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator /(Vector3I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator /(Vector3I7F25 a, I7F25 b) => new Vector3I7F25(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 operator /(I7F25 a, Vector3I7F25 b) => new Vector3I7F25(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I7F25 lhs, Vector3I7F25 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I7F25 lhs, Vector3I7F25 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I7F25 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, X); }
        public readonly Vector2I7F25 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, Y); }
        public readonly Vector2I7F25 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, Z); }
        public readonly Vector2I7F25 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, X); }
        public readonly Vector2I7F25 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, Y); }
        public readonly Vector2I7F25 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, Z); }
        public readonly Vector2I7F25 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, X); }
        public readonly Vector2I7F25 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, Y); }
        public readonly Vector2I7F25 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, Z); }
        public readonly Vector3I7F25 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, X); }
        public readonly Vector3I7F25 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, Y); }
        public readonly Vector3I7F25 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, Z); }
        public readonly Vector3I7F25 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, X); }
        public readonly Vector3I7F25 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, Y); }
        public readonly Vector3I7F25 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, Z); }
        public readonly Vector3I7F25 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, X); }
        public readonly Vector3I7F25 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, Y); }
        public readonly Vector3I7F25 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, Z); }
        public readonly Vector3I7F25 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, X); }
        public readonly Vector3I7F25 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, Y); }
        public readonly Vector3I7F25 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, Z); }
        public readonly Vector3I7F25 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, X); }
        public readonly Vector3I7F25 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, Y); }
        public readonly Vector3I7F25 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, Z); }
        public readonly Vector3I7F25 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, X); }
        public readonly Vector3I7F25 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, Y); }
        public readonly Vector3I7F25 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, Z); }
        public readonly Vector3I7F25 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, X); }
        public readonly Vector3I7F25 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, Y); }
        public readonly Vector3I7F25 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, Z); }
        public readonly Vector3I7F25 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, X); }
        public readonly Vector3I7F25 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, Y); }
        public readonly Vector3I7F25 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, Z); }
        public readonly Vector3I7F25 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, X); }
        public readonly Vector3I7F25 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, Y); }
        public readonly Vector3I7F25 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, Z); }
        public readonly Vector4I7F25 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, X); }
        public readonly Vector4I7F25 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, Y); }
        public readonly Vector4I7F25 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, Z); }
        public readonly Vector4I7F25 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, X); }
        public readonly Vector4I7F25 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, Y); }
        public readonly Vector4I7F25 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, Z); }
        public readonly Vector4I7F25 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, X); }
        public readonly Vector4I7F25 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, Y); }
        public readonly Vector4I7F25 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, Z); }
        public readonly Vector4I7F25 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, X); }
        public readonly Vector4I7F25 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, Y); }
        public readonly Vector4I7F25 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, Z); }
        public readonly Vector4I7F25 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, X); }
        public readonly Vector4I7F25 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, Y); }
        public readonly Vector4I7F25 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, Z); }
        public readonly Vector4I7F25 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, X); }
        public readonly Vector4I7F25 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, Y); }
        public readonly Vector4I7F25 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, Z); }
        public readonly Vector4I7F25 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, X); }
        public readonly Vector4I7F25 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, Y); }
        public readonly Vector4I7F25 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, Z); }
        public readonly Vector4I7F25 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, X); }
        public readonly Vector4I7F25 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, Y); }
        public readonly Vector4I7F25 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, Z); }
        public readonly Vector4I7F25 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, X); }
        public readonly Vector4I7F25 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, Y); }
        public readonly Vector4I7F25 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, Z); }
        public readonly Vector4I7F25 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, X); }
        public readonly Vector4I7F25 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, Y); }
        public readonly Vector4I7F25 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, Z); }
        public readonly Vector4I7F25 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, X); }
        public readonly Vector4I7F25 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, Y); }
        public readonly Vector4I7F25 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, Z); }
        public readonly Vector4I7F25 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, X); }
        public readonly Vector4I7F25 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, Y); }
        public readonly Vector4I7F25 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, Z); }
        public readonly Vector4I7F25 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, X); }
        public readonly Vector4I7F25 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, Y); }
        public readonly Vector4I7F25 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, Z); }
        public readonly Vector4I7F25 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, X); }
        public readonly Vector4I7F25 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, Y); }
        public readonly Vector4I7F25 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, Z); }
        public readonly Vector4I7F25 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, X); }
        public readonly Vector4I7F25 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, Y); }
        public readonly Vector4I7F25 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, Z); }
        public readonly Vector4I7F25 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, X); }
        public readonly Vector4I7F25 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, Y); }
        public readonly Vector4I7F25 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, Z); }
        public readonly Vector4I7F25 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, X); }
        public readonly Vector4I7F25 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, Y); }
        public readonly Vector4I7F25 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, Z); }
        public readonly Vector4I7F25 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, X); }
        public readonly Vector4I7F25 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, Y); }
        public readonly Vector4I7F25 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, Z); }
        public readonly Vector4I7F25 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, X); }
        public readonly Vector4I7F25 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, Y); }
        public readonly Vector4I7F25 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, Z); }
        public readonly Vector4I7F25 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, X); }
        public readonly Vector4I7F25 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, Y); }
        public readonly Vector4I7F25 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, Z); }
        public readonly Vector4I7F25 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, X); }
        public readonly Vector4I7F25 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, Y); }
        public readonly Vector4I7F25 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, Z); }
        public readonly Vector4I7F25 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, X); }
        public readonly Vector4I7F25 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, Y); }
        public readonly Vector4I7F25 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, Z); }
        public readonly Vector4I7F25 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, X); }
        public readonly Vector4I7F25 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, Y); }
        public readonly Vector4I7F25 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, Z); }
        public readonly Vector4I7F25 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, X); }
        public readonly Vector4I7F25 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, Y); }
        public readonly Vector4I7F25 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, Z); }
        public readonly Vector4I7F25 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, X); }
        public readonly Vector4I7F25 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, Y); }
        public readonly Vector4I7F25 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, Z); }
        public readonly Vector4I7F25 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, X); }
        public readonly Vector4I7F25 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, Y); }
        public readonly Vector4I7F25 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, Z); }
        public readonly Vector4I7F25 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, X); }
        public readonly Vector4I7F25 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, Y); }
        public readonly Vector4I7F25 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I7F25 other)
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

        public readonly Vector3I7F25 Half() => new Vector3I7F25(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I7F25 Twice() => new Vector3I7F25(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I7F25 Clamp(I7F25 min, I7F25 max) => new Vector3I7F25(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I7F25 Clamp(
            Vector3I7F25 min, Vector3I7F25 max
        ) => new Vector3I7F25(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I7F25 SaturatingAdd(Vector3I7F25 other) => new Vector3I7F25(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I7F25 SaturatingMul(I7F25 other) => new Vector3I7F25(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I7F25 Cross(Vector3I7F25 other) {
            return ((this * other.YZX) - (YZX * other)).YZX;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I16F48 Dot(Vector3I7F25 other) {
            var x = X.WideningMul(other.X);
            var y = Y.WideningMul(other.Y);
            var z = Z.WideningMul(other.Z);

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x.Bits / 4) +
                (y.Bits / 4) +
                (z.Bits / 4);
            return I16F48.FromBits(bits);
        }

    }

    partial struct I7F25 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I7F25 SaturatingMul(Vector3I7F25 other) => other.SaturatingMul(this);
    }
}
