using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I22F10 : IEquatable<Vector3I22F10>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I22F10 X;
        public I22F10 Y;
        public I22F10 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10(I22F10 x, I22F10 y, I22F10 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10(I22F10 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10(I22F10 x, Vector2I22F10 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10(Vector3I22F10 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10(Vector2I22F10 xy, I22F10 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I22F10 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I22F10(I22F10.Zero);
        }
        public static Vector3I22F10 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I22F10(I22F10.One);
        }
        public static Vector3I22F10 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I22F10(I22F10.One, I22F10.Zero, I22F10.Zero);
        }
        public static Vector3I22F10 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I22F10(I22F10.Zero, I22F10.One, I22F10.Zero);
        }
        public static Vector3I22F10 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I22F10(I22F10.Zero, I22F10.Zero, I22F10.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 operator +(Vector3I22F10 a, Vector3I22F10 b) => new Vector3I22F10(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 operator -(Vector3I22F10 a, Vector3I22F10 b) => new Vector3I22F10(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 operator *(Vector3I22F10 a, Vector3I22F10 b) => new Vector3I22F10(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 operator *(Vector3I22F10 a, I22F10 b) => new Vector3I22F10(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 operator *(I22F10 a, Vector3I22F10 b) => new Vector3I22F10(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 operator /(Vector3I22F10 a, Vector3I22F10 b) => new Vector3I22F10(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 operator /(Vector3I22F10 a, I22F10 b) => new Vector3I22F10(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 operator /(I22F10 a, Vector3I22F10 b) => new Vector3I22F10(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I22F10 lhs, Vector3I22F10 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I22F10 lhs, Vector3I22F10 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I22F10 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I22F10(X, X); }
        public Vector2I22F10 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I22F10(X, Y); }
        public Vector2I22F10 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I22F10(X, Z); }
        public Vector2I22F10 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I22F10(Y, X); }
        public Vector2I22F10 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I22F10(Y, Y); }
        public Vector2I22F10 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I22F10(Y, Z); }
        public Vector2I22F10 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I22F10(Z, X); }
        public Vector2I22F10 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I22F10(Z, Y); }
        public Vector2I22F10 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I22F10(Z, Z); }
        public Vector3I22F10 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(X, X, X); }
        public Vector3I22F10 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(X, X, Y); }
        public Vector3I22F10 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(X, X, Z); }
        public Vector3I22F10 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(X, Y, X); }
        public Vector3I22F10 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(X, Y, Y); }
        public Vector3I22F10 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(X, Y, Z); }
        public Vector3I22F10 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(X, Z, X); }
        public Vector3I22F10 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(X, Z, Y); }
        public Vector3I22F10 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(X, Z, Z); }
        public Vector3I22F10 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Y, X, X); }
        public Vector3I22F10 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Y, X, Y); }
        public Vector3I22F10 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Y, X, Z); }
        public Vector3I22F10 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Y, Y, X); }
        public Vector3I22F10 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Y, Y, Y); }
        public Vector3I22F10 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Y, Y, Z); }
        public Vector3I22F10 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Y, Z, X); }
        public Vector3I22F10 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Y, Z, Y); }
        public Vector3I22F10 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Y, Z, Z); }
        public Vector3I22F10 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Z, X, X); }
        public Vector3I22F10 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Z, X, Y); }
        public Vector3I22F10 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Z, X, Z); }
        public Vector3I22F10 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Z, Y, X); }
        public Vector3I22F10 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Z, Y, Y); }
        public Vector3I22F10 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Z, Y, Z); }
        public Vector3I22F10 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Z, Z, X); }
        public Vector3I22F10 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Z, Z, Y); }
        public Vector3I22F10 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I22F10(Z, Z, Z); }
        public Vector4I22F10 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, X, X, X); }
        public Vector4I22F10 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, X, X, Y); }
        public Vector4I22F10 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, X, X, Z); }
        public Vector4I22F10 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, X, Y, X); }
        public Vector4I22F10 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, X, Y, Y); }
        public Vector4I22F10 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, X, Y, Z); }
        public Vector4I22F10 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, X, Z, X); }
        public Vector4I22F10 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, X, Z, Y); }
        public Vector4I22F10 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, X, Z, Z); }
        public Vector4I22F10 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Y, X, X); }
        public Vector4I22F10 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Y, X, Y); }
        public Vector4I22F10 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Y, X, Z); }
        public Vector4I22F10 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Y, Y, X); }
        public Vector4I22F10 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Y, Y, Y); }
        public Vector4I22F10 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Y, Y, Z); }
        public Vector4I22F10 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Y, Z, X); }
        public Vector4I22F10 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Y, Z, Y); }
        public Vector4I22F10 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Y, Z, Z); }
        public Vector4I22F10 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Z, X, X); }
        public Vector4I22F10 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Z, X, Y); }
        public Vector4I22F10 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Z, X, Z); }
        public Vector4I22F10 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Z, Y, X); }
        public Vector4I22F10 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Z, Y, Y); }
        public Vector4I22F10 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Z, Y, Z); }
        public Vector4I22F10 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Z, Z, X); }
        public Vector4I22F10 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Z, Z, Y); }
        public Vector4I22F10 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(X, Z, Z, Z); }
        public Vector4I22F10 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, X, X, X); }
        public Vector4I22F10 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, X, X, Y); }
        public Vector4I22F10 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, X, X, Z); }
        public Vector4I22F10 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, X, Y, X); }
        public Vector4I22F10 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, X, Y, Y); }
        public Vector4I22F10 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, X, Y, Z); }
        public Vector4I22F10 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, X, Z, X); }
        public Vector4I22F10 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, X, Z, Y); }
        public Vector4I22F10 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, X, Z, Z); }
        public Vector4I22F10 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Y, X, X); }
        public Vector4I22F10 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Y, X, Y); }
        public Vector4I22F10 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Y, X, Z); }
        public Vector4I22F10 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Y, Y, X); }
        public Vector4I22F10 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Y, Y, Y); }
        public Vector4I22F10 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Y, Y, Z); }
        public Vector4I22F10 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Y, Z, X); }
        public Vector4I22F10 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Y, Z, Y); }
        public Vector4I22F10 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Y, Z, Z); }
        public Vector4I22F10 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Z, X, X); }
        public Vector4I22F10 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Z, X, Y); }
        public Vector4I22F10 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Z, X, Z); }
        public Vector4I22F10 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Z, Y, X); }
        public Vector4I22F10 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Z, Y, Y); }
        public Vector4I22F10 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Z, Y, Z); }
        public Vector4I22F10 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Z, Z, X); }
        public Vector4I22F10 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Z, Z, Y); }
        public Vector4I22F10 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Y, Z, Z, Z); }
        public Vector4I22F10 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, X, X, X); }
        public Vector4I22F10 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, X, X, Y); }
        public Vector4I22F10 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, X, X, Z); }
        public Vector4I22F10 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, X, Y, X); }
        public Vector4I22F10 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, X, Y, Y); }
        public Vector4I22F10 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, X, Y, Z); }
        public Vector4I22F10 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, X, Z, X); }
        public Vector4I22F10 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, X, Z, Y); }
        public Vector4I22F10 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, X, Z, Z); }
        public Vector4I22F10 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Y, X, X); }
        public Vector4I22F10 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Y, X, Y); }
        public Vector4I22F10 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Y, X, Z); }
        public Vector4I22F10 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Y, Y, X); }
        public Vector4I22F10 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Y, Y, Y); }
        public Vector4I22F10 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Y, Y, Z); }
        public Vector4I22F10 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Y, Z, X); }
        public Vector4I22F10 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Y, Z, Y); }
        public Vector4I22F10 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Y, Z, Z); }
        public Vector4I22F10 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Z, X, X); }
        public Vector4I22F10 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Z, X, Y); }
        public Vector4I22F10 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Z, X, Z); }
        public Vector4I22F10 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Z, Y, X); }
        public Vector4I22F10 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Z, Y, Y); }
        public Vector4I22F10 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Z, Y, Z); }
        public Vector4I22F10 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Z, Z, X); }
        public Vector4I22F10 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Z, Z, Y); }
        public Vector4I22F10 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I22F10(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3I22F10 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I22F10>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I22F10 other)
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
        public Vector3I22F10 Min(Vector3I22F10 other) => new Vector3I22F10(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 Max(Vector3I22F10 other) => new Vector3I22F10(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 Abs() => new Vector3I22F10(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 Half() => new Vector3I22F10(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 Twice() => new Vector3I22F10(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 Clamp(I22F10 min, I22F10 max) => new Vector3I22F10(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 Clamp(
            Vector3I22F10 min, Vector3I22F10 max
        ) => new Vector3I22F10(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 WrappingAdd(Vector3I22F10 other) => new Vector3I22F10(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 WrappingSub(Vector3I22F10 other) => new Vector3I22F10(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 WrappingMul(Vector3I22F10 other) => new Vector3I22F10(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 WrappingAddUnsigned(Vector3U22F10 other) => new Vector3I22F10(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 WrappingSubUnsigned(Vector3U22F10 other) => new Vector3I22F10(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10 UnsignedAbs() => new Vector3U22F10(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 SaturatingAdd(Vector3I22F10 other) => new Vector3I22F10(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 SaturatingMul(I22F10 other) => new Vector3I22F10(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I22F10 other, out long x, out long y, out long z) {
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
        public Vector3I22F10 Cross(Vector3I22F10 other) {
            const long k = 1L << 10;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I22F10(
                I22F10.FromBits((int)(x / k)),
                I22F10.FromBits((int)(y / k)),
                I22F10.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 SaturatingCross(Vector3I22F10 other) {
            const long k = 1L << 10;
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
            return new Vector3I22F10(
                I22F10.FromBits((int)x),
                I22F10.FromBits((int)y),
                I22F10.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I22F10 other) {
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
        public I22F10 Dot(Vector3I22F10 other) {
            const long k = 1L << 8;
            return I22F10.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I22F10 SaturatingDot(Vector3I22F10 other) {
            const long k = 1L << 8;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I22F10.MaxValue;
            } else if (bits < int.MinValue) {
                return I22F10.MinValue;
            } else {
                return I22F10.FromBits((int)bits);
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
        public I46F18 LengthSquared() {
            return I46F18.FromBits(LengthSquaredInternal());
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
        /// <para>This method differs from <c>LengthHalf</c> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <c>LengthHalf</c> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U22F10 LengthHalfUnsigned() => U22F10.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><c>LengthHalfUnsigned</c> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><c>LengthHalfUnsigned</c> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I22F10 LengthHalf() => I22F10.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I23F9 Length() => I23F9.FromBits((int)LengthInternal());

    }

    partial struct I22F10 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I22F10 SaturatingMul(Vector3I22F10 other) => other.SaturatingMul(this);
    }
}
