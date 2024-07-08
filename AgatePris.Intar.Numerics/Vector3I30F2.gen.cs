using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I30F2 : IEquatable<Vector3I30F2>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I30F2 X;
        public I30F2 Y;
        public I30F2 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 x, I30F2 y, I30F2 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 x, Vector2I30F2 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(Vector3I30F2 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(Vector2I30F2 xy, I30F2 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I30F2 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.Zero);
        }
        public static Vector3I30F2 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.One);
        }
        public static Vector3I30F2 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.One, I30F2.Zero, I30F2.Zero);
        }
        public static Vector3I30F2 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.Zero, I30F2.One, I30F2.Zero);
        }
        public static Vector3I30F2 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.Zero, I30F2.Zero, I30F2.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator +(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator -(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(Vector3I30F2 a, I30F2 b) => new Vector3I30F2(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(Vector3I30F2 a, I30F2 b) => new Vector3I30F2(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I30F2 lhs, Vector3I30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I30F2 lhs, Vector3I30F2 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I30F2 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(X, X); }
        public readonly Vector2I30F2 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(X, Y); }
        public readonly Vector2I30F2 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(X, Z); }
        public readonly Vector2I30F2 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Y, X); }
        public readonly Vector2I30F2 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Y, Y); }
        public readonly Vector2I30F2 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Y, Z); }
        public readonly Vector2I30F2 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Z, X); }
        public readonly Vector2I30F2 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Z, Y); }
        public readonly Vector2I30F2 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Z, Z); }
        public readonly Vector3I30F2 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, X, X); }
        public readonly Vector3I30F2 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, X, Y); }
        public readonly Vector3I30F2 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, X, Z); }
        public readonly Vector3I30F2 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Y, X); }
        public readonly Vector3I30F2 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Y, Y); }
        public readonly Vector3I30F2 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Y, Z); }
        public readonly Vector3I30F2 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Z, X); }
        public readonly Vector3I30F2 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Z, Y); }
        public readonly Vector3I30F2 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Z, Z); }
        public readonly Vector3I30F2 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, X, X); }
        public readonly Vector3I30F2 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, X, Y); }
        public readonly Vector3I30F2 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, X, Z); }
        public readonly Vector3I30F2 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Y, X); }
        public readonly Vector3I30F2 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Y, Y); }
        public readonly Vector3I30F2 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Y, Z); }
        public readonly Vector3I30F2 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Z, X); }
        public readonly Vector3I30F2 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Z, Y); }
        public readonly Vector3I30F2 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Z, Z); }
        public readonly Vector3I30F2 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, X, X); }
        public readonly Vector3I30F2 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, X, Y); }
        public readonly Vector3I30F2 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, X, Z); }
        public readonly Vector3I30F2 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Y, X); }
        public readonly Vector3I30F2 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Y, Y); }
        public readonly Vector3I30F2 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Y, Z); }
        public readonly Vector3I30F2 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Z, X); }
        public readonly Vector3I30F2 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Z, Y); }
        public readonly Vector3I30F2 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Z, Z, Z); }
        public readonly Vector4I30F2 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, X, X); }
        public readonly Vector4I30F2 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, X, Y); }
        public readonly Vector4I30F2 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, X, Z); }
        public readonly Vector4I30F2 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Y, X); }
        public readonly Vector4I30F2 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Y, Y); }
        public readonly Vector4I30F2 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Y, Z); }
        public readonly Vector4I30F2 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Z, X); }
        public readonly Vector4I30F2 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Z, Y); }
        public readonly Vector4I30F2 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Z, Z); }
        public readonly Vector4I30F2 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, X, X); }
        public readonly Vector4I30F2 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, X, Y); }
        public readonly Vector4I30F2 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, X, Z); }
        public readonly Vector4I30F2 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Y, X); }
        public readonly Vector4I30F2 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Y, Y); }
        public readonly Vector4I30F2 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Y, Z); }
        public readonly Vector4I30F2 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Z, X); }
        public readonly Vector4I30F2 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Z, Y); }
        public readonly Vector4I30F2 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Z, Z); }
        public readonly Vector4I30F2 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, X, X); }
        public readonly Vector4I30F2 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, X, Y); }
        public readonly Vector4I30F2 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, X, Z); }
        public readonly Vector4I30F2 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Y, X); }
        public readonly Vector4I30F2 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Y, Y); }
        public readonly Vector4I30F2 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Y, Z); }
        public readonly Vector4I30F2 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Z, X); }
        public readonly Vector4I30F2 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Z, Y); }
        public readonly Vector4I30F2 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Z, Z, Z); }
        public readonly Vector4I30F2 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, X, X); }
        public readonly Vector4I30F2 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, X, Y); }
        public readonly Vector4I30F2 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, X, Z); }
        public readonly Vector4I30F2 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Y, X); }
        public readonly Vector4I30F2 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Y, Y); }
        public readonly Vector4I30F2 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Y, Z); }
        public readonly Vector4I30F2 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Z, X); }
        public readonly Vector4I30F2 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Z, Y); }
        public readonly Vector4I30F2 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Z, Z); }
        public readonly Vector4I30F2 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, X, X); }
        public readonly Vector4I30F2 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, X, Y); }
        public readonly Vector4I30F2 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, X, Z); }
        public readonly Vector4I30F2 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Y, X); }
        public readonly Vector4I30F2 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Y, Y); }
        public readonly Vector4I30F2 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Y, Z); }
        public readonly Vector4I30F2 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Z, X); }
        public readonly Vector4I30F2 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Z, Y); }
        public readonly Vector4I30F2 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Z, Z); }
        public readonly Vector4I30F2 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, X, X); }
        public readonly Vector4I30F2 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, X, Y); }
        public readonly Vector4I30F2 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, X, Z); }
        public readonly Vector4I30F2 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Y, X); }
        public readonly Vector4I30F2 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Y, Y); }
        public readonly Vector4I30F2 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Y, Z); }
        public readonly Vector4I30F2 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Z, X); }
        public readonly Vector4I30F2 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Z, Y); }
        public readonly Vector4I30F2 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Z, Z, Z); }
        public readonly Vector4I30F2 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, X, X); }
        public readonly Vector4I30F2 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, X, Y); }
        public readonly Vector4I30F2 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, X, Z); }
        public readonly Vector4I30F2 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Y, X); }
        public readonly Vector4I30F2 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Y, Y); }
        public readonly Vector4I30F2 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Y, Z); }
        public readonly Vector4I30F2 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Z, X); }
        public readonly Vector4I30F2 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Z, Y); }
        public readonly Vector4I30F2 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, X, Z, Z); }
        public readonly Vector4I30F2 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, X, X); }
        public readonly Vector4I30F2 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, X, Y); }
        public readonly Vector4I30F2 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, X, Z); }
        public readonly Vector4I30F2 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Y, X); }
        public readonly Vector4I30F2 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Y, Y); }
        public readonly Vector4I30F2 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Y, Z); }
        public readonly Vector4I30F2 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Z, X); }
        public readonly Vector4I30F2 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Z, Y); }
        public readonly Vector4I30F2 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Y, Z, Z); }
        public readonly Vector4I30F2 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, X, X); }
        public readonly Vector4I30F2 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, X, Y); }
        public readonly Vector4I30F2 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, X, Z); }
        public readonly Vector4I30F2 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Y, X); }
        public readonly Vector4I30F2 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Y, Y); }
        public readonly Vector4I30F2 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Y, Z); }
        public readonly Vector4I30F2 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Z, X); }
        public readonly Vector4I30F2 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Z, Y); }
        public readonly Vector4I30F2 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I30F2 other)
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

        public readonly Vector3I30F2 Half() => new Vector3I30F2(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I30F2 Twice() => new Vector3I30F2(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I30F2 Clamp(I30F2 min, I30F2 max) => new Vector3I30F2(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I30F2 Clamp(
            Vector3I30F2 min, Vector3I30F2 max
        ) => new Vector3I30F2(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I30F2 SaturatingAdd(Vector3I30F2 other) => new Vector3I30F2(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I30F2 SaturatingMul(I30F2 other) => new Vector3I30F2(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CrossInternal(Vector3I30F2 other, out long x, out long y, out long z) {
            var ax = (long)X.Bits;
            var ay = (long)Y.Bits;
            var az = (long)Z.Bits;
            var bx = (long)other.X.Bits;
            var by = (long)other.Y.Bits;
            var bz = (long)other.Z.Bits;

            const long k = 1L << 2;
            x = ((ay * bz) - (az * by)) / k;
            y = ((az * bx) - (ax * bz)) / k;
            z = ((ax * by) - (ay * bx)) / k;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I30F2 Cross(Vector3I30F2 other) {
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I30F2(
                I30F2.FromBits((int)x),
                I30F2.FromBits((int)y),
                I30F2.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I30F2 SaturatingCross(Vector3I30F2 other) {
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
            return new Vector3I30F2(
                I30F2.FromBits((int)x),
                I30F2.FromBits((int)y),
                I30F2.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector3I30F2 other) {
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
        public readonly I30F2 Dot(Vector3I30F2 other) {
            const long k = 1L << 0;
            return I30F2.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I30F2 SaturatingDot(Vector3I30F2 other) {
            const long k = 1L << 0;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I30F2.MaxValue;
            } else if (bits < int.MinValue) {
                return I30F2.MinValue;
            } else {
                return I30F2.FromBits((int)bits);
            }
        }

    }

    partial struct I30F2 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I30F2 SaturatingMul(Vector3I30F2 other) => other.SaturatingMul(this);
    }
}
