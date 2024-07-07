using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I8F24 : IEquatable<Vector3I8F24>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I8F24 X;
        public I8F24 Y;
        public I8F24 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(I8F24 x, I8F24 y, I8F24 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(I8F24 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(I8F24 x, Vector2I8F24 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(Vector3I8F24 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(Vector2I8F24 xy, I8F24 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I8F24 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I8F24(I8F24.Zero);
        }
        public static Vector3I8F24 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I8F24(I8F24.One);
        }
        public static Vector3I8F24 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I8F24(I8F24.One, I8F24.Zero, I8F24.Zero);
        }
        public static Vector3I8F24 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I8F24(I8F24.Zero, I8F24.One, I8F24.Zero);
        }
        public static Vector3I8F24 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I8F24(I8F24.Zero, I8F24.Zero, I8F24.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator +(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator -(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator *(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator *(Vector3I8F24 a, I8F24 b) => new Vector3I8F24(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator *(I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator /(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator /(Vector3I8F24 a, I8F24 b) => new Vector3I8F24(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator /(I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I8F24 lhs, Vector3I8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I8F24 lhs, Vector3I8F24 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I8F24 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, X); }
        public readonly Vector2I8F24 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, Y); }
        public readonly Vector2I8F24 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, Z); }
        public readonly Vector2I8F24 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, X); }
        public readonly Vector2I8F24 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, Y); }
        public readonly Vector2I8F24 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, Z); }
        public readonly Vector2I8F24 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Z, X); }
        public readonly Vector2I8F24 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Z, Y); }
        public readonly Vector2I8F24 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Z, Z); }
        public readonly Vector3I8F24 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, X); }
        public readonly Vector3I8F24 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, Y); }
        public readonly Vector3I8F24 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, Z); }
        public readonly Vector3I8F24 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, X); }
        public readonly Vector3I8F24 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, Y); }
        public readonly Vector3I8F24 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, Z); }
        public readonly Vector3I8F24 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Z, X); }
        public readonly Vector3I8F24 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Z, Y); }
        public readonly Vector3I8F24 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Z, Z); }
        public readonly Vector3I8F24 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, X); }
        public readonly Vector3I8F24 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, Y); }
        public readonly Vector3I8F24 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, Z); }
        public readonly Vector3I8F24 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, X); }
        public readonly Vector3I8F24 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, Y); }
        public readonly Vector3I8F24 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, Z); }
        public readonly Vector3I8F24 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Z, X); }
        public readonly Vector3I8F24 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Z, Y); }
        public readonly Vector3I8F24 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Z, Z); }
        public readonly Vector3I8F24 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, X, X); }
        public readonly Vector3I8F24 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, X, Y); }
        public readonly Vector3I8F24 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, X, Z); }
        public readonly Vector3I8F24 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Y, X); }
        public readonly Vector3I8F24 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Y, Y); }
        public readonly Vector3I8F24 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Y, Z); }
        public readonly Vector3I8F24 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Z, X); }
        public readonly Vector3I8F24 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Z, Y); }
        public readonly Vector3I8F24 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Z, Z); }
        public readonly Vector4I8F24 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, X); }
        public readonly Vector4I8F24 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, Y); }
        public readonly Vector4I8F24 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, Z); }
        public readonly Vector4I8F24 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, X); }
        public readonly Vector4I8F24 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, Y); }
        public readonly Vector4I8F24 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, Z); }
        public readonly Vector4I8F24 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Z, X); }
        public readonly Vector4I8F24 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Z, Y); }
        public readonly Vector4I8F24 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Z, Z); }
        public readonly Vector4I8F24 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, X); }
        public readonly Vector4I8F24 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, Y); }
        public readonly Vector4I8F24 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, Z); }
        public readonly Vector4I8F24 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, X); }
        public readonly Vector4I8F24 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, Y); }
        public readonly Vector4I8F24 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, Z); }
        public readonly Vector4I8F24 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Z, X); }
        public readonly Vector4I8F24 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Z, Y); }
        public readonly Vector4I8F24 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Z, Z); }
        public readonly Vector4I8F24 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, X, X); }
        public readonly Vector4I8F24 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, X, Y); }
        public readonly Vector4I8F24 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, X, Z); }
        public readonly Vector4I8F24 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Y, X); }
        public readonly Vector4I8F24 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Y, Y); }
        public readonly Vector4I8F24 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Y, Z); }
        public readonly Vector4I8F24 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Z, X); }
        public readonly Vector4I8F24 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Z, Y); }
        public readonly Vector4I8F24 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Z, Z); }
        public readonly Vector4I8F24 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, X); }
        public readonly Vector4I8F24 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, Y); }
        public readonly Vector4I8F24 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, Z); }
        public readonly Vector4I8F24 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, X); }
        public readonly Vector4I8F24 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, Y); }
        public readonly Vector4I8F24 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, Z); }
        public readonly Vector4I8F24 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Z, X); }
        public readonly Vector4I8F24 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Z, Y); }
        public readonly Vector4I8F24 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Z, Z); }
        public readonly Vector4I8F24 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, X); }
        public readonly Vector4I8F24 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, Y); }
        public readonly Vector4I8F24 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, Z); }
        public readonly Vector4I8F24 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, X); }
        public readonly Vector4I8F24 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, Y); }
        public readonly Vector4I8F24 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, Z); }
        public readonly Vector4I8F24 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Z, X); }
        public readonly Vector4I8F24 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Z, Y); }
        public readonly Vector4I8F24 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Z, Z); }
        public readonly Vector4I8F24 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, X, X); }
        public readonly Vector4I8F24 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, X, Y); }
        public readonly Vector4I8F24 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, X, Z); }
        public readonly Vector4I8F24 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Y, X); }
        public readonly Vector4I8F24 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Y, Y); }
        public readonly Vector4I8F24 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Y, Z); }
        public readonly Vector4I8F24 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Z, X); }
        public readonly Vector4I8F24 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Z, Y); }
        public readonly Vector4I8F24 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Z, Z); }
        public readonly Vector4I8F24 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, X, X); }
        public readonly Vector4I8F24 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, X, Y); }
        public readonly Vector4I8F24 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, X, Z); }
        public readonly Vector4I8F24 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Y, X); }
        public readonly Vector4I8F24 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Y, Y); }
        public readonly Vector4I8F24 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Y, Z); }
        public readonly Vector4I8F24 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Z, X); }
        public readonly Vector4I8F24 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Z, Y); }
        public readonly Vector4I8F24 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Z, Z); }
        public readonly Vector4I8F24 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, X, X); }
        public readonly Vector4I8F24 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, X, Y); }
        public readonly Vector4I8F24 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, X, Z); }
        public readonly Vector4I8F24 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Y, X); }
        public readonly Vector4I8F24 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Y, Y); }
        public readonly Vector4I8F24 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Y, Z); }
        public readonly Vector4I8F24 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Z, X); }
        public readonly Vector4I8F24 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Z, Y); }
        public readonly Vector4I8F24 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Z, Z); }
        public readonly Vector4I8F24 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, X, X); }
        public readonly Vector4I8F24 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, X, Y); }
        public readonly Vector4I8F24 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, X, Z); }
        public readonly Vector4I8F24 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Y, X); }
        public readonly Vector4I8F24 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Y, Y); }
        public readonly Vector4I8F24 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Y, Z); }
        public readonly Vector4I8F24 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Z, X); }
        public readonly Vector4I8F24 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Z, Y); }
        public readonly Vector4I8F24 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I8F24 other)
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

        public readonly Vector3I8F24 Half() => new Vector3I8F24(
            X.Half(),
            Y.Half(),
            Z.Half());

        public readonly Vector3I8F24 Twice() => new Vector3I8F24(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        public readonly Vector3I8F24 Clamp(I8F24 min, I8F24 max) => new Vector3I8F24(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        public readonly Vector3I8F24 Clamp(
            Vector3I8F24 min, Vector3I8F24 max
        ) => new Vector3I8F24(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I8F24 SaturatingAdd(Vector3I8F24 other) => new Vector3I8F24(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I8F24 SaturatingMul(I8F24 other) => new Vector3I8F24(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I8F24 Cross(Vector3I8F24 other) {
            return ((this * other.YZX) - (YZX * other)).YZX;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I18F46 WideningDot(Vector3I8F24 other) {
            var x = X.WideningMul(other.X);
            var y = Y.WideningMul(other.Y);
            var z = Z.WideningMul(other.Z);

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x.Bits / 4) +
                (y.Bits / 4) +
                (z.Bits / 4);
            return I18F46.FromBits(bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I8F24 Dot(Vector3I8F24 other) => (I8F24)WideningDot(other);

    }

    partial struct I8F24 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector3I8F24 SaturatingMul(Vector3I8F24 other) => other.SaturatingMul(this);
    }
}
