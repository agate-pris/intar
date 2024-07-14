using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I27F5 : IEquatable<Vector3I27F5>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I27F5 X;
        public I27F5 Y;
        public I27F5 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5(I27F5 x, I27F5 y, I27F5 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5(I27F5 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5(I27F5 x, Vector2I27F5 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5(Vector3I27F5 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5(Vector2I27F5 xy, I27F5 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I27F5 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I27F5(I27F5.Zero);
        }
        public static Vector3I27F5 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I27F5(I27F5.One);
        }
        public static Vector3I27F5 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I27F5(I27F5.One, I27F5.Zero, I27F5.Zero);
        }
        public static Vector3I27F5 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I27F5(I27F5.Zero, I27F5.One, I27F5.Zero);
        }
        public static Vector3I27F5 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I27F5(I27F5.Zero, I27F5.Zero, I27F5.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 operator +(Vector3I27F5 a, Vector3I27F5 b) => new Vector3I27F5(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 operator -(Vector3I27F5 a, Vector3I27F5 b) => new Vector3I27F5(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 operator *(Vector3I27F5 a, Vector3I27F5 b) => new Vector3I27F5(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 operator *(Vector3I27F5 a, I27F5 b) => new Vector3I27F5(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 operator *(I27F5 a, Vector3I27F5 b) => new Vector3I27F5(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 operator /(Vector3I27F5 a, Vector3I27F5 b) => new Vector3I27F5(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 operator /(Vector3I27F5 a, I27F5 b) => new Vector3I27F5(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 operator /(I27F5 a, Vector3I27F5 b) => new Vector3I27F5(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I27F5 lhs, Vector3I27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I27F5 lhs, Vector3I27F5 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I27F5 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, X); }
        public Vector2I27F5 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, Y); }
        public Vector2I27F5 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, Z); }
        public Vector2I27F5 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, X); }
        public Vector2I27F5 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, Y); }
        public Vector2I27F5 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, Z); }
        public Vector2I27F5 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Z, X); }
        public Vector2I27F5 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Z, Y); }
        public Vector2I27F5 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Z, Z); }
        public Vector3I27F5 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, X); }
        public Vector3I27F5 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, Y); }
        public Vector3I27F5 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, Z); }
        public Vector3I27F5 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, X); }
        public Vector3I27F5 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, Y); }
        public Vector3I27F5 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, Z); }
        public Vector3I27F5 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Z, X); }
        public Vector3I27F5 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Z, Y); }
        public Vector3I27F5 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Z, Z); }
        public Vector3I27F5 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, X); }
        public Vector3I27F5 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, Y); }
        public Vector3I27F5 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, Z); }
        public Vector3I27F5 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, X); }
        public Vector3I27F5 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, Y); }
        public Vector3I27F5 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, Z); }
        public Vector3I27F5 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Z, X); }
        public Vector3I27F5 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Z, Y); }
        public Vector3I27F5 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Z, Z); }
        public Vector3I27F5 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, X, X); }
        public Vector3I27F5 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, X, Y); }
        public Vector3I27F5 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, X, Z); }
        public Vector3I27F5 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Y, X); }
        public Vector3I27F5 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Y, Y); }
        public Vector3I27F5 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Y, Z); }
        public Vector3I27F5 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Z, X); }
        public Vector3I27F5 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Z, Y); }
        public Vector3I27F5 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Z, Z); }
        public Vector4I27F5 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, X); }
        public Vector4I27F5 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, Y); }
        public Vector4I27F5 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, Z); }
        public Vector4I27F5 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, X); }
        public Vector4I27F5 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, Y); }
        public Vector4I27F5 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, Z); }
        public Vector4I27F5 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Z, X); }
        public Vector4I27F5 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Z, Y); }
        public Vector4I27F5 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Z, Z); }
        public Vector4I27F5 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, X); }
        public Vector4I27F5 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, Y); }
        public Vector4I27F5 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, Z); }
        public Vector4I27F5 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, X); }
        public Vector4I27F5 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, Y); }
        public Vector4I27F5 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, Z); }
        public Vector4I27F5 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Z, X); }
        public Vector4I27F5 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Z, Y); }
        public Vector4I27F5 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Z, Z); }
        public Vector4I27F5 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, X, X); }
        public Vector4I27F5 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, X, Y); }
        public Vector4I27F5 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, X, Z); }
        public Vector4I27F5 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Y, X); }
        public Vector4I27F5 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Y, Y); }
        public Vector4I27F5 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Y, Z); }
        public Vector4I27F5 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Z, X); }
        public Vector4I27F5 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Z, Y); }
        public Vector4I27F5 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Z, Z); }
        public Vector4I27F5 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, X); }
        public Vector4I27F5 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, Y); }
        public Vector4I27F5 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, Z); }
        public Vector4I27F5 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, X); }
        public Vector4I27F5 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, Y); }
        public Vector4I27F5 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, Z); }
        public Vector4I27F5 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Z, X); }
        public Vector4I27F5 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Z, Y); }
        public Vector4I27F5 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Z, Z); }
        public Vector4I27F5 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, X); }
        public Vector4I27F5 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, Y); }
        public Vector4I27F5 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, Z); }
        public Vector4I27F5 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, X); }
        public Vector4I27F5 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, Y); }
        public Vector4I27F5 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, Z); }
        public Vector4I27F5 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Z, X); }
        public Vector4I27F5 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Z, Y); }
        public Vector4I27F5 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Z, Z); }
        public Vector4I27F5 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, X, X); }
        public Vector4I27F5 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, X, Y); }
        public Vector4I27F5 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, X, Z); }
        public Vector4I27F5 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Y, X); }
        public Vector4I27F5 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Y, Y); }
        public Vector4I27F5 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Y, Z); }
        public Vector4I27F5 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Z, X); }
        public Vector4I27F5 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Z, Y); }
        public Vector4I27F5 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Z, Z); }
        public Vector4I27F5 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, X, X); }
        public Vector4I27F5 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, X, Y); }
        public Vector4I27F5 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, X, Z); }
        public Vector4I27F5 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Y, X); }
        public Vector4I27F5 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Y, Y); }
        public Vector4I27F5 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Y, Z); }
        public Vector4I27F5 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Z, X); }
        public Vector4I27F5 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Z, Y); }
        public Vector4I27F5 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Z, Z); }
        public Vector4I27F5 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, X, X); }
        public Vector4I27F5 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, X, Y); }
        public Vector4I27F5 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, X, Z); }
        public Vector4I27F5 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Y, X); }
        public Vector4I27F5 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Y, Y); }
        public Vector4I27F5 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Y, Z); }
        public Vector4I27F5 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Z, X); }
        public Vector4I27F5 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Z, Y); }
        public Vector4I27F5 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Z, Z); }
        public Vector4I27F5 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, X, X); }
        public Vector4I27F5 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, X, Y); }
        public Vector4I27F5 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, X, Z); }
        public Vector4I27F5 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Y, X); }
        public Vector4I27F5 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Y, Y); }
        public Vector4I27F5 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Y, Z); }
        public Vector4I27F5 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Z, X); }
        public Vector4I27F5 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Z, Y); }
        public Vector4I27F5 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3I27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I27F5 other)
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
        public Vector3I27F5 Min(Vector3I27F5 other) => new Vector3I27F5(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 Max(Vector3I27F5 other) => new Vector3I27F5(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 Abs() => new Vector3I27F5(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 Half() => new Vector3I27F5(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 Twice() => new Vector3I27F5(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 Clamp(I27F5 min, I27F5 max) => new Vector3I27F5(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 Clamp(
            Vector3I27F5 min, Vector3I27F5 max
        ) => new Vector3I27F5(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 WrappingAdd(Vector3I27F5 other) => new Vector3I27F5(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 WrappingSub(Vector3I27F5 other) => new Vector3I27F5(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 WrappingMul(Vector3I27F5 other) => new Vector3I27F5(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 WrappingAddUnsigned(Vector3U27F5 other) => new Vector3I27F5(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 WrappingSubUnsigned(Vector3U27F5 other) => new Vector3I27F5(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U27F5 UnsignedAbs() => new Vector3U27F5(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 SaturatingAdd(Vector3I27F5 other) => new Vector3I27F5(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 SaturatingMul(I27F5 other) => new Vector3I27F5(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I27F5 other, out long x, out long y, out long z) {
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
        public Vector3I27F5 Cross(Vector3I27F5 other) {
            const long k = 1L << 5;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I27F5(
                I27F5.FromBits((int)(x / k)),
                I27F5.FromBits((int)(y / k)),
                I27F5.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 SaturatingCross(Vector3I27F5 other) {
            const long k = 1L << 5;
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
            return new Vector3I27F5(
                I27F5.FromBits((int)x),
                I27F5.FromBits((int)y),
                I27F5.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I27F5 other) {
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
        public I27F5 Dot(Vector3I27F5 other) {
            const long k = 1L << 3;
            return I27F5.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I27F5 SaturatingDot(Vector3I27F5 other) {
            const long k = 1L << 3;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I27F5.MaxValue;
            } else if (bits < int.MinValue) {
                return I27F5.MinValue;
            } else {
                return I27F5.FromBits((int)bits);
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
        public I56F8 LengthSquared() {
            return I56F8.FromBits(LengthSquaredInternal());
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
        public U27F5 LengthHalfUnsigned() => U27F5.FromBits(LengthInternal());

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
        public I27F5 LengthHalf() => I27F5.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I28F4 Length() => I28F4.FromBits((int)LengthInternal());

    }

    partial struct I27F5 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I27F5 SaturatingMul(Vector3I27F5 other) => other.SaturatingMul(this);
    }
}
