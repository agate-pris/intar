using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I2F30 : IEquatable<Vector3I2F30>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I2F30 X;
        public I2F30 Y;
        public I2F30 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(I2F30 x, I2F30 y, I2F30 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(I2F30 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(I2F30 x, Vector2I2F30 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(Vector3I2F30 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(Vector2I2F30 xy, I2F30 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I2F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(I2F30.Zero);
        }
        public static Vector3I2F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(I2F30.One);
        }
        public static Vector3I2F30 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(I2F30.One, I2F30.Zero, I2F30.Zero);
        }
        public static Vector3I2F30 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(I2F30.Zero, I2F30.One, I2F30.Zero);
        }
        public static Vector3I2F30 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(I2F30.Zero, I2F30.Zero, I2F30.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator +(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator -(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator *(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator *(Vector3I2F30 a, I2F30 b) => new Vector3I2F30(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator *(I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator /(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator /(Vector3I2F30 a, I2F30 b) => new Vector3I2F30(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator /(I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I2F30 lhs, Vector3I2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I2F30 lhs, Vector3I2F30 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I2F30 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, X); }
        public Vector2I2F30 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, Y); }
        public Vector2I2F30 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, Z); }
        public Vector2I2F30 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, X); }
        public Vector2I2F30 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, Y); }
        public Vector2I2F30 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, Z); }
        public Vector2I2F30 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, X); }
        public Vector2I2F30 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, Y); }
        public Vector2I2F30 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, Z); }
        public Vector3I2F30 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, X); }
        public Vector3I2F30 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, Y); }
        public Vector3I2F30 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, Z); }
        public Vector3I2F30 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, X); }
        public Vector3I2F30 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, Y); }
        public Vector3I2F30 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, Z); }
        public Vector3I2F30 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, X); }
        public Vector3I2F30 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, Y); }
        public Vector3I2F30 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, Z); }
        public Vector3I2F30 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, X); }
        public Vector3I2F30 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, Y); }
        public Vector3I2F30 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, Z); }
        public Vector3I2F30 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, X); }
        public Vector3I2F30 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, Y); }
        public Vector3I2F30 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, Z); }
        public Vector3I2F30 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, X); }
        public Vector3I2F30 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, Y); }
        public Vector3I2F30 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, Z); }
        public Vector3I2F30 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, X); }
        public Vector3I2F30 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, Y); }
        public Vector3I2F30 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, Z); }
        public Vector3I2F30 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, X); }
        public Vector3I2F30 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, Y); }
        public Vector3I2F30 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, Z); }
        public Vector3I2F30 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, X); }
        public Vector3I2F30 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, Y); }
        public Vector3I2F30 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, Z); }
        public Vector4I2F30 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, X); }
        public Vector4I2F30 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, Y); }
        public Vector4I2F30 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, Z); }
        public Vector4I2F30 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, X); }
        public Vector4I2F30 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, Y); }
        public Vector4I2F30 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, Z); }
        public Vector4I2F30 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, X); }
        public Vector4I2F30 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, Y); }
        public Vector4I2F30 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, Z); }
        public Vector4I2F30 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, X); }
        public Vector4I2F30 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, Y); }
        public Vector4I2F30 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, Z); }
        public Vector4I2F30 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, X); }
        public Vector4I2F30 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, Y); }
        public Vector4I2F30 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, Z); }
        public Vector4I2F30 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, X); }
        public Vector4I2F30 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, Y); }
        public Vector4I2F30 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, Z); }
        public Vector4I2F30 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, X); }
        public Vector4I2F30 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, Y); }
        public Vector4I2F30 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, Z); }
        public Vector4I2F30 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, X); }
        public Vector4I2F30 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, Y); }
        public Vector4I2F30 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, Z); }
        public Vector4I2F30 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, X); }
        public Vector4I2F30 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, Y); }
        public Vector4I2F30 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, Z); }
        public Vector4I2F30 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, X); }
        public Vector4I2F30 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, Y); }
        public Vector4I2F30 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, Z); }
        public Vector4I2F30 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, X); }
        public Vector4I2F30 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, Y); }
        public Vector4I2F30 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, Z); }
        public Vector4I2F30 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, X); }
        public Vector4I2F30 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, Y); }
        public Vector4I2F30 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, Z); }
        public Vector4I2F30 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, X); }
        public Vector4I2F30 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, Y); }
        public Vector4I2F30 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, Z); }
        public Vector4I2F30 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, X); }
        public Vector4I2F30 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, Y); }
        public Vector4I2F30 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, Z); }
        public Vector4I2F30 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, X); }
        public Vector4I2F30 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, Y); }
        public Vector4I2F30 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, Z); }
        public Vector4I2F30 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, X); }
        public Vector4I2F30 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, Y); }
        public Vector4I2F30 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, Z); }
        public Vector4I2F30 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, X); }
        public Vector4I2F30 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, Y); }
        public Vector4I2F30 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, Z); }
        public Vector4I2F30 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, X); }
        public Vector4I2F30 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, Y); }
        public Vector4I2F30 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, Z); }
        public Vector4I2F30 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, X); }
        public Vector4I2F30 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, Y); }
        public Vector4I2F30 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, Z); }
        public Vector4I2F30 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, X); }
        public Vector4I2F30 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, Y); }
        public Vector4I2F30 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, Z); }
        public Vector4I2F30 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, X); }
        public Vector4I2F30 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, Y); }
        public Vector4I2F30 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, Z); }
        public Vector4I2F30 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, X); }
        public Vector4I2F30 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, Y); }
        public Vector4I2F30 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, Z); }
        public Vector4I2F30 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, X); }
        public Vector4I2F30 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, Y); }
        public Vector4I2F30 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, Z); }
        public Vector4I2F30 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, X); }
        public Vector4I2F30 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, Y); }
        public Vector4I2F30 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, Z); }
        public Vector4I2F30 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, X); }
        public Vector4I2F30 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, Y); }
        public Vector4I2F30 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, Z); }
        public Vector4I2F30 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, X); }
        public Vector4I2F30 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, Y); }
        public Vector4I2F30 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, Z); }
        public Vector4I2F30 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, X); }
        public Vector4I2F30 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, Y); }
        public Vector4I2F30 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I2F30 other)
            => other.X == X
            && other.Y == Y
            && other.Z == Z;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            return $"<{x}, {y}, {z}>";
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Min(Vector3I2F30 other) => new Vector3I2F30(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Max(Vector3I2F30 other) => new Vector3I2F30(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Abs() => new Vector3I2F30(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Half() => new Vector3I2F30(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Twice() => new Vector3I2F30(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Clamp(I2F30 min, I2F30 max) => new Vector3I2F30(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Clamp(
            Vector3I2F30 min, Vector3I2F30 max
        ) => new Vector3I2F30(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 WrappingAdd(Vector3I2F30 other) => new Vector3I2F30(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 WrappingSub(Vector3I2F30 other) => new Vector3I2F30(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 WrappingMul(Vector3I2F30 other) => new Vector3I2F30(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 WrappingAddUnsigned(Vector3U2F30 other) => new Vector3I2F30(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 WrappingSubUnsigned(Vector3U2F30 other) => new Vector3I2F30(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30 UnsignedAbs() => new Vector3U2F30(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SaturatingAdd(Vector3I2F30 other) => new Vector3I2F30(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SaturatingMul(I2F30 other) => new Vector3I2F30(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I2F30 other, out long x, out long y, out long z) {
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
        public Vector3I2F30 Cross(Vector3I2F30 other) {
            const long k = 1L << 30;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I2F30(
                I2F30.FromBits((int)(x / k)),
                I2F30.FromBits((int)(y / k)),
                I2F30.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SaturatingCross(Vector3I2F30 other) {
            const long k = 1L << 30;
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
            return new Vector3I2F30(
                I2F30.FromBits((int)x),
                I2F30.FromBits((int)y),
                I2F30.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I2F30 other) {
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
        public I2F30 Dot(Vector3I2F30 other) {
            const long k = 1L << 28;
            return I2F30.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 SaturatingDot(Vector3I2F30 other) {
            const long k = 1L << 28;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I2F30.MaxValue;
            } else if (bits < int.MinValue) {
                return I2F30.MinValue;
            } else {
                return I2F30.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <div class="TIP alert alert-info">
        /// <h5>Tip</h5>
        /// <para>This method divides the square of each element by 4
        /// during the calculation to prevent overflow.</para>
        /// <para>このメソッドはオーバーフローを防ぐため､
        /// 計算の過程で各要素の 2 乗を 4 で除算します｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I6F58 LengthSquared() {
            return I6F58.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            var squared = LengthSquaredInternal();
            return (uint)Mathi.Sqrt((ulong)squared);
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthHalf">LengthHalf</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalf">LengthHalf</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 LengthHalfUnsigned() => U2F30.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 LengthHalf() => I2F30.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I3F29 Length() => I3F29.FromBits((int)LengthInternal());

    }

    partial struct I2F30 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SaturatingMul(Vector3I2F30 other) => other.SaturatingMul(this);
    }
}
