using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I24F8 : IEquatable<Vector3I24F8>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I24F8 X;
        public I24F8 Y;
        public I24F8 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I24F8(I24F8 x, I24F8 y, I24F8 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I24F8(I24F8 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I24F8(I24F8 x, Vector2I24F8 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I24F8(Vector3I24F8 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I24F8(Vector2I24F8 xy, I24F8 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I24F8 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I24F8(I24F8.Zero);
        }
        public static Vector3I24F8 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I24F8(I24F8.One);
        }
        public static Vector3I24F8 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I24F8(I24F8.One, I24F8.Zero, I24F8.Zero);
        }
        public static Vector3I24F8 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I24F8(I24F8.Zero, I24F8.One, I24F8.Zero);
        }
        public static Vector3I24F8 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I24F8(I24F8.Zero, I24F8.Zero, I24F8.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator +(Vector3I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator -(Vector3I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator *(Vector3I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator *(Vector3I24F8 a, I24F8 b) => new Vector3I24F8(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator *(I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator /(Vector3I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator /(Vector3I24F8 a, I24F8 b) => new Vector3I24F8(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 operator /(I24F8 a, Vector3I24F8 b) => new Vector3I24F8(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I24F8 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(X, X); }
        public readonly Vector2I24F8 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(X, Y); }
        public readonly Vector2I24F8 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(X, Z); }
        public readonly Vector2I24F8 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Y, X); }
        public readonly Vector2I24F8 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Y, Y); }
        public readonly Vector2I24F8 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Y, Z); }
        public readonly Vector2I24F8 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Z, X); }
        public readonly Vector2I24F8 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Z, Y); }
        public readonly Vector2I24F8 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Z, Z); }
        public readonly Vector3I24F8 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, X, X); }
        public readonly Vector3I24F8 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, X, Y); }
        public readonly Vector3I24F8 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, X, Z); }
        public readonly Vector3I24F8 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Y, X); }
        public readonly Vector3I24F8 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Y, Y); }
        public readonly Vector3I24F8 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Y, Z); }
        public readonly Vector3I24F8 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Z, X); }
        public readonly Vector3I24F8 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Z, Y); }
        public readonly Vector3I24F8 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Z, Z); }
        public readonly Vector3I24F8 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, X, X); }
        public readonly Vector3I24F8 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, X, Y); }
        public readonly Vector3I24F8 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, X, Z); }
        public readonly Vector3I24F8 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Y, X); }
        public readonly Vector3I24F8 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Y, Y); }
        public readonly Vector3I24F8 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Y, Z); }
        public readonly Vector3I24F8 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Z, X); }
        public readonly Vector3I24F8 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Z, Y); }
        public readonly Vector3I24F8 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Z, Z); }
        public readonly Vector3I24F8 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, X, X); }
        public readonly Vector3I24F8 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, X, Y); }
        public readonly Vector3I24F8 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, X, Z); }
        public readonly Vector3I24F8 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Y, X); }
        public readonly Vector3I24F8 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Y, Y); }
        public readonly Vector3I24F8 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Y, Z); }
        public readonly Vector3I24F8 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Z, X); }
        public readonly Vector3I24F8 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Z, Y); }
        public readonly Vector3I24F8 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Z, Z, Z); }
        public readonly Vector4I24F8 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, X, X); }
        public readonly Vector4I24F8 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, X, Y); }
        public readonly Vector4I24F8 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, X, Z); }
        public readonly Vector4I24F8 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Y, X); }
        public readonly Vector4I24F8 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Y, Y); }
        public readonly Vector4I24F8 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Y, Z); }
        public readonly Vector4I24F8 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Z, X); }
        public readonly Vector4I24F8 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Z, Y); }
        public readonly Vector4I24F8 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Z, Z); }
        public readonly Vector4I24F8 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, X, X); }
        public readonly Vector4I24F8 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, X, Y); }
        public readonly Vector4I24F8 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, X, Z); }
        public readonly Vector4I24F8 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Y, X); }
        public readonly Vector4I24F8 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Y, Y); }
        public readonly Vector4I24F8 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Y, Z); }
        public readonly Vector4I24F8 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Z, X); }
        public readonly Vector4I24F8 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Z, Y); }
        public readonly Vector4I24F8 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Z, Z); }
        public readonly Vector4I24F8 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, X, X); }
        public readonly Vector4I24F8 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, X, Y); }
        public readonly Vector4I24F8 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, X, Z); }
        public readonly Vector4I24F8 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Y, X); }
        public readonly Vector4I24F8 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Y, Y); }
        public readonly Vector4I24F8 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Y, Z); }
        public readonly Vector4I24F8 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Z, X); }
        public readonly Vector4I24F8 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Z, Y); }
        public readonly Vector4I24F8 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Z, Z, Z); }
        public readonly Vector4I24F8 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, X, X); }
        public readonly Vector4I24F8 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, X, Y); }
        public readonly Vector4I24F8 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, X, Z); }
        public readonly Vector4I24F8 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Y, X); }
        public readonly Vector4I24F8 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Y, Y); }
        public readonly Vector4I24F8 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Y, Z); }
        public readonly Vector4I24F8 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Z, X); }
        public readonly Vector4I24F8 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Z, Y); }
        public readonly Vector4I24F8 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Z, Z); }
        public readonly Vector4I24F8 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, X, X); }
        public readonly Vector4I24F8 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, X, Y); }
        public readonly Vector4I24F8 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, X, Z); }
        public readonly Vector4I24F8 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Y, X); }
        public readonly Vector4I24F8 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Y, Y); }
        public readonly Vector4I24F8 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Y, Z); }
        public readonly Vector4I24F8 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Z, X); }
        public readonly Vector4I24F8 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Z, Y); }
        public readonly Vector4I24F8 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Z, Z); }
        public readonly Vector4I24F8 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, X, X); }
        public readonly Vector4I24F8 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, X, Y); }
        public readonly Vector4I24F8 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, X, Z); }
        public readonly Vector4I24F8 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Y, X); }
        public readonly Vector4I24F8 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Y, Y); }
        public readonly Vector4I24F8 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Y, Z); }
        public readonly Vector4I24F8 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Z, X); }
        public readonly Vector4I24F8 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Z, Y); }
        public readonly Vector4I24F8 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Z, Z, Z); }
        public readonly Vector4I24F8 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, X, X); }
        public readonly Vector4I24F8 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, X, Y); }
        public readonly Vector4I24F8 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, X, Z); }
        public readonly Vector4I24F8 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Y, X); }
        public readonly Vector4I24F8 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Y, Y); }
        public readonly Vector4I24F8 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Y, Z); }
        public readonly Vector4I24F8 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Z, X); }
        public readonly Vector4I24F8 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Z, Y); }
        public readonly Vector4I24F8 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, X, Z, Z); }
        public readonly Vector4I24F8 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, X, X); }
        public readonly Vector4I24F8 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, X, Y); }
        public readonly Vector4I24F8 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, X, Z); }
        public readonly Vector4I24F8 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Y, X); }
        public readonly Vector4I24F8 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Y, Y); }
        public readonly Vector4I24F8 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Y, Z); }
        public readonly Vector4I24F8 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Z, X); }
        public readonly Vector4I24F8 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Z, Y); }
        public readonly Vector4I24F8 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Y, Z, Z); }
        public readonly Vector4I24F8 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, X, X); }
        public readonly Vector4I24F8 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, X, Y); }
        public readonly Vector4I24F8 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, X, Z); }
        public readonly Vector4I24F8 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Y, X); }
        public readonly Vector4I24F8 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Y, Y); }
        public readonly Vector4I24F8 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Y, Z); }
        public readonly Vector4I24F8 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Z, X); }
        public readonly Vector4I24F8 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Z, Y); }
        public readonly Vector4I24F8 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Z, Z, Z, Z); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I24F8 lhs, Vector3I24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I24F8 lhs, Vector3I24F8 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I24F8 other)
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

        public readonly Vector3I24F8 Half() => new Vector3I24F8(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I24F8 Twice() => new Vector3I24F8(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I24F8 Clamp(I24F8 min, I24F8 max) => new Vector3I24F8(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I24F8 Clamp(
            Vector3I24F8 min, Vector3I24F8 max
        ) => new Vector3I24F8(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

    }
}
