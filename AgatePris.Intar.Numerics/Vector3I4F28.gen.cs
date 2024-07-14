using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I4F28 : IEquatable<Vector3I4F28>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I4F28 X;
        public I4F28 Y;
        public I4F28 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28(I4F28 x, I4F28 y, I4F28 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28(I4F28 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28(I4F28 x, Vector2I4F28 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28(Vector3I4F28 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28(Vector2I4F28 xy, I4F28 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I4F28 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I4F28(I4F28.Zero);
        }
        public static Vector3I4F28 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I4F28(I4F28.One);
        }
        public static Vector3I4F28 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I4F28(I4F28.One, I4F28.Zero, I4F28.Zero);
        }
        public static Vector3I4F28 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I4F28(I4F28.Zero, I4F28.One, I4F28.Zero);
        }
        public static Vector3I4F28 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I4F28(I4F28.Zero, I4F28.Zero, I4F28.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator +(Vector3I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator -(Vector3I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator *(Vector3I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator *(Vector3I4F28 a, I4F28 b) => new Vector3I4F28(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator *(I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator /(Vector3I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator /(Vector3I4F28 a, I4F28 b) => new Vector3I4F28(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 operator /(I4F28 a, Vector3I4F28 b) => new Vector3I4F28(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I4F28 lhs, Vector3I4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I4F28 lhs, Vector3I4F28 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I4F28 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, X); }
        public Vector2I4F28 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, Y); }
        public Vector2I4F28 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, Z); }
        public Vector2I4F28 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, X); }
        public Vector2I4F28 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, Y); }
        public Vector2I4F28 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, Z); }
        public Vector2I4F28 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Z, X); }
        public Vector2I4F28 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Z, Y); }
        public Vector2I4F28 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Z, Z); }
        public Vector3I4F28 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, X); }
        public Vector3I4F28 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, Y); }
        public Vector3I4F28 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, Z); }
        public Vector3I4F28 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, X); }
        public Vector3I4F28 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, Y); }
        public Vector3I4F28 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, Z); }
        public Vector3I4F28 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Z, X); }
        public Vector3I4F28 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Z, Y); }
        public Vector3I4F28 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Z, Z); }
        public Vector3I4F28 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, X); }
        public Vector3I4F28 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, Y); }
        public Vector3I4F28 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, Z); }
        public Vector3I4F28 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, X); }
        public Vector3I4F28 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, Y); }
        public Vector3I4F28 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, Z); }
        public Vector3I4F28 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Z, X); }
        public Vector3I4F28 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Z, Y); }
        public Vector3I4F28 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Z, Z); }
        public Vector3I4F28 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, X, X); }
        public Vector3I4F28 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, X, Y); }
        public Vector3I4F28 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, X, Z); }
        public Vector3I4F28 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Y, X); }
        public Vector3I4F28 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Y, Y); }
        public Vector3I4F28 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Y, Z); }
        public Vector3I4F28 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Z, X); }
        public Vector3I4F28 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Z, Y); }
        public Vector3I4F28 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Z, Z); }
        public Vector4I4F28 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, X); }
        public Vector4I4F28 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, Y); }
        public Vector4I4F28 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, Z); }
        public Vector4I4F28 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, X); }
        public Vector4I4F28 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, Y); }
        public Vector4I4F28 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, Z); }
        public Vector4I4F28 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Z, X); }
        public Vector4I4F28 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Z, Y); }
        public Vector4I4F28 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Z, Z); }
        public Vector4I4F28 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, X); }
        public Vector4I4F28 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, Y); }
        public Vector4I4F28 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, Z); }
        public Vector4I4F28 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, X); }
        public Vector4I4F28 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, Y); }
        public Vector4I4F28 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, Z); }
        public Vector4I4F28 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Z, X); }
        public Vector4I4F28 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Z, Y); }
        public Vector4I4F28 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Z, Z); }
        public Vector4I4F28 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, X, X); }
        public Vector4I4F28 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, X, Y); }
        public Vector4I4F28 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, X, Z); }
        public Vector4I4F28 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Y, X); }
        public Vector4I4F28 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Y, Y); }
        public Vector4I4F28 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Y, Z); }
        public Vector4I4F28 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Z, X); }
        public Vector4I4F28 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Z, Y); }
        public Vector4I4F28 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Z, Z); }
        public Vector4I4F28 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, X); }
        public Vector4I4F28 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, Y); }
        public Vector4I4F28 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, Z); }
        public Vector4I4F28 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, X); }
        public Vector4I4F28 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, Y); }
        public Vector4I4F28 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, Z); }
        public Vector4I4F28 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Z, X); }
        public Vector4I4F28 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Z, Y); }
        public Vector4I4F28 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Z, Z); }
        public Vector4I4F28 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, X); }
        public Vector4I4F28 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, Y); }
        public Vector4I4F28 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, Z); }
        public Vector4I4F28 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, X); }
        public Vector4I4F28 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, Y); }
        public Vector4I4F28 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, Z); }
        public Vector4I4F28 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Z, X); }
        public Vector4I4F28 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Z, Y); }
        public Vector4I4F28 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Z, Z); }
        public Vector4I4F28 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, X, X); }
        public Vector4I4F28 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, X, Y); }
        public Vector4I4F28 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, X, Z); }
        public Vector4I4F28 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Y, X); }
        public Vector4I4F28 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Y, Y); }
        public Vector4I4F28 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Y, Z); }
        public Vector4I4F28 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Z, X); }
        public Vector4I4F28 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Z, Y); }
        public Vector4I4F28 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Z, Z); }
        public Vector4I4F28 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, X, X); }
        public Vector4I4F28 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, X, Y); }
        public Vector4I4F28 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, X, Z); }
        public Vector4I4F28 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Y, X); }
        public Vector4I4F28 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Y, Y); }
        public Vector4I4F28 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Y, Z); }
        public Vector4I4F28 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Z, X); }
        public Vector4I4F28 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Z, Y); }
        public Vector4I4F28 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Z, Z); }
        public Vector4I4F28 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, X, X); }
        public Vector4I4F28 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, X, Y); }
        public Vector4I4F28 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, X, Z); }
        public Vector4I4F28 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Y, X); }
        public Vector4I4F28 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Y, Y); }
        public Vector4I4F28 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Y, Z); }
        public Vector4I4F28 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Z, X); }
        public Vector4I4F28 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Z, Y); }
        public Vector4I4F28 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Z, Z); }
        public Vector4I4F28 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, X, X); }
        public Vector4I4F28 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, X, Y); }
        public Vector4I4F28 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, X, Z); }
        public Vector4I4F28 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Y, X); }
        public Vector4I4F28 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Y, Y); }
        public Vector4I4F28 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Y, Z); }
        public Vector4I4F28 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Z, X); }
        public Vector4I4F28 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Z, Y); }
        public Vector4I4F28 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3I4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I4F28 other)
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
        public Vector3I4F28 Min(Vector3I4F28 other) => new Vector3I4F28(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 Max(Vector3I4F28 other) => new Vector3I4F28(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 Abs() => new Vector3I4F28(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 Half() => new Vector3I4F28(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 Twice() => new Vector3I4F28(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 Clamp(I4F28 min, I4F28 max) => new Vector3I4F28(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 Clamp(
            Vector3I4F28 min, Vector3I4F28 max
        ) => new Vector3I4F28(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 WrappingAdd(Vector3I4F28 other) => new Vector3I4F28(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 WrappingSub(Vector3I4F28 other) => new Vector3I4F28(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 WrappingMul(Vector3I4F28 other) => new Vector3I4F28(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 WrappingAddUnsigned(Vector3U4F28 other) => new Vector3I4F28(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 WrappingSubUnsigned(Vector3U4F28 other) => new Vector3I4F28(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U4F28 UnsignedAbs() => new Vector3U4F28(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 SaturatingAdd(Vector3I4F28 other) => new Vector3I4F28(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 SaturatingMul(I4F28 other) => new Vector3I4F28(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I4F28 other, out long x, out long y, out long z) {
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
        public Vector3I4F28 Cross(Vector3I4F28 other) {
            const long k = 1L << 28;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I4F28(
                I4F28.FromBits((int)(x / k)),
                I4F28.FromBits((int)(y / k)),
                I4F28.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 SaturatingCross(Vector3I4F28 other) {
            const long k = 1L << 28;
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
            return new Vector3I4F28(
                I4F28.FromBits((int)x),
                I4F28.FromBits((int)y),
                I4F28.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I4F28 other) {
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
        public I4F28 Dot(Vector3I4F28 other) {
            const long k = 1L << 26;
            return I4F28.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F28 SaturatingDot(Vector3I4F28 other) {
            const long k = 1L << 26;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I4F28.MaxValue;
            } else if (bits < int.MinValue) {
                return I4F28.MinValue;
            } else {
                return I4F28.FromBits((int)bits);
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
        public I10F54 LengthSquared() {
            return I10F54.FromBits(LengthSquaredInternal());
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
        public U4F28 LengthHalfUnsigned() => U4F28.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F28 LengthHalf() => I4F28.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I5F27 Length() => I5F27.FromBits((int)LengthInternal());

    }

    partial struct I4F28 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F28 SaturatingMul(Vector3I4F28 other) => other.SaturatingMul(this);
    }
}
