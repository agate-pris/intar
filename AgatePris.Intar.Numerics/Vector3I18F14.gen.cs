using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I18F14 : IEquatable<Vector3I18F14>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I18F14 X;
        public I18F14 Y;
        public I18F14 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14(I18F14 x, I18F14 y, I18F14 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14(I18F14 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14(I18F14 x, Vector2I18F14 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14(Vector3I18F14 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14(Vector2I18F14 xy, I18F14 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I18F14 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I18F14(I18F14.Zero);
        }
        public static Vector3I18F14 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I18F14(I18F14.One);
        }
        public static Vector3I18F14 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I18F14(I18F14.One, I18F14.Zero, I18F14.Zero);
        }
        public static Vector3I18F14 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I18F14(I18F14.Zero, I18F14.One, I18F14.Zero);
        }
        public static Vector3I18F14 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I18F14(I18F14.Zero, I18F14.Zero, I18F14.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator +(Vector3I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator -(Vector3I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator *(Vector3I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator *(Vector3I18F14 a, I18F14 b) => new Vector3I18F14(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator *(I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator /(Vector3I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator /(Vector3I18F14 a, I18F14 b) => new Vector3I18F14(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 operator /(I18F14 a, Vector3I18F14 b) => new Vector3I18F14(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I18F14 lhs, Vector3I18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I18F14 lhs, Vector3I18F14 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I18F14 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, X); }
        public Vector2I18F14 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, Y); }
        public Vector2I18F14 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, Z); }
        public Vector2I18F14 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, X); }
        public Vector2I18F14 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, Y); }
        public Vector2I18F14 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, Z); }
        public Vector2I18F14 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Z, X); }
        public Vector2I18F14 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Z, Y); }
        public Vector2I18F14 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Z, Z); }
        public Vector3I18F14 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, X); }
        public Vector3I18F14 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, Y); }
        public Vector3I18F14 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, Z); }
        public Vector3I18F14 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, X); }
        public Vector3I18F14 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, Y); }
        public Vector3I18F14 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, Z); }
        public Vector3I18F14 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Z, X); }
        public Vector3I18F14 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Z, Y); }
        public Vector3I18F14 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Z, Z); }
        public Vector3I18F14 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, X); }
        public Vector3I18F14 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, Y); }
        public Vector3I18F14 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, Z); }
        public Vector3I18F14 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, X); }
        public Vector3I18F14 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, Y); }
        public Vector3I18F14 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, Z); }
        public Vector3I18F14 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Z, X); }
        public Vector3I18F14 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Z, Y); }
        public Vector3I18F14 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Z, Z); }
        public Vector3I18F14 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, X, X); }
        public Vector3I18F14 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, X, Y); }
        public Vector3I18F14 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, X, Z); }
        public Vector3I18F14 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Y, X); }
        public Vector3I18F14 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Y, Y); }
        public Vector3I18F14 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Y, Z); }
        public Vector3I18F14 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Z, X); }
        public Vector3I18F14 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Z, Y); }
        public Vector3I18F14 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Z, Z); }
        public Vector4I18F14 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, X); }
        public Vector4I18F14 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, Y); }
        public Vector4I18F14 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, Z); }
        public Vector4I18F14 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, X); }
        public Vector4I18F14 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, Y); }
        public Vector4I18F14 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, Z); }
        public Vector4I18F14 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Z, X); }
        public Vector4I18F14 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Z, Y); }
        public Vector4I18F14 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Z, Z); }
        public Vector4I18F14 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, X); }
        public Vector4I18F14 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, Y); }
        public Vector4I18F14 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, Z); }
        public Vector4I18F14 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, X); }
        public Vector4I18F14 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, Y); }
        public Vector4I18F14 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, Z); }
        public Vector4I18F14 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Z, X); }
        public Vector4I18F14 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Z, Y); }
        public Vector4I18F14 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Z, Z); }
        public Vector4I18F14 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, X, X); }
        public Vector4I18F14 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, X, Y); }
        public Vector4I18F14 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, X, Z); }
        public Vector4I18F14 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Y, X); }
        public Vector4I18F14 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Y, Y); }
        public Vector4I18F14 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Y, Z); }
        public Vector4I18F14 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Z, X); }
        public Vector4I18F14 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Z, Y); }
        public Vector4I18F14 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Z, Z); }
        public Vector4I18F14 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, X); }
        public Vector4I18F14 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, Y); }
        public Vector4I18F14 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, Z); }
        public Vector4I18F14 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, X); }
        public Vector4I18F14 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, Y); }
        public Vector4I18F14 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, Z); }
        public Vector4I18F14 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Z, X); }
        public Vector4I18F14 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Z, Y); }
        public Vector4I18F14 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Z, Z); }
        public Vector4I18F14 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, X); }
        public Vector4I18F14 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, Y); }
        public Vector4I18F14 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, Z); }
        public Vector4I18F14 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, X); }
        public Vector4I18F14 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, Y); }
        public Vector4I18F14 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, Z); }
        public Vector4I18F14 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Z, X); }
        public Vector4I18F14 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Z, Y); }
        public Vector4I18F14 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Z, Z); }
        public Vector4I18F14 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, X, X); }
        public Vector4I18F14 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, X, Y); }
        public Vector4I18F14 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, X, Z); }
        public Vector4I18F14 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Y, X); }
        public Vector4I18F14 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Y, Y); }
        public Vector4I18F14 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Y, Z); }
        public Vector4I18F14 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Z, X); }
        public Vector4I18F14 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Z, Y); }
        public Vector4I18F14 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Z, Z); }
        public Vector4I18F14 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, X, X); }
        public Vector4I18F14 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, X, Y); }
        public Vector4I18F14 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, X, Z); }
        public Vector4I18F14 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Y, X); }
        public Vector4I18F14 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Y, Y); }
        public Vector4I18F14 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Y, Z); }
        public Vector4I18F14 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Z, X); }
        public Vector4I18F14 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Z, Y); }
        public Vector4I18F14 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Z, Z); }
        public Vector4I18F14 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, X, X); }
        public Vector4I18F14 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, X, Y); }
        public Vector4I18F14 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, X, Z); }
        public Vector4I18F14 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Y, X); }
        public Vector4I18F14 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Y, Y); }
        public Vector4I18F14 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Y, Z); }
        public Vector4I18F14 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Z, X); }
        public Vector4I18F14 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Z, Y); }
        public Vector4I18F14 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Z, Z); }
        public Vector4I18F14 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, X, X); }
        public Vector4I18F14 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, X, Y); }
        public Vector4I18F14 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, X, Z); }
        public Vector4I18F14 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Y, X); }
        public Vector4I18F14 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Y, Y); }
        public Vector4I18F14 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Y, Z); }
        public Vector4I18F14 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Z, X); }
        public Vector4I18F14 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Z, Y); }
        public Vector4I18F14 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3I18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I18F14 other)
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
        public Vector3I18F14 Min(Vector3I18F14 other) => new Vector3I18F14(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 Max(Vector3I18F14 other) => new Vector3I18F14(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 Abs() => new Vector3I18F14(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 Half() => new Vector3I18F14(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 Twice() => new Vector3I18F14(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 Clamp(I18F14 min, I18F14 max) => new Vector3I18F14(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 Clamp(
            Vector3I18F14 min, Vector3I18F14 max
        ) => new Vector3I18F14(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 WrappingAdd(Vector3I18F14 other) => new Vector3I18F14(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 WrappingSub(Vector3I18F14 other) => new Vector3I18F14(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 WrappingMul(Vector3I18F14 other) => new Vector3I18F14(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 WrappingAddUnsigned(Vector3U18F14 other) => new Vector3I18F14(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 WrappingSubUnsigned(Vector3U18F14 other) => new Vector3I18F14(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U18F14 UnsignedAbs() => new Vector3U18F14(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 SaturatingAdd(Vector3I18F14 other) => new Vector3I18F14(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 SaturatingMul(I18F14 other) => new Vector3I18F14(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I18F14 other, out long x, out long y, out long z) {
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
        public Vector3I18F14 Cross(Vector3I18F14 other) {
            const long k = 1L << 14;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I18F14(
                I18F14.FromBits((int)(x / k)),
                I18F14.FromBits((int)(y / k)),
                I18F14.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 SaturatingCross(Vector3I18F14 other) {
            const long k = 1L << 14;
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
            return new Vector3I18F14(
                I18F14.FromBits((int)x),
                I18F14.FromBits((int)y),
                I18F14.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I18F14 other) {
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
        public I18F14 Dot(Vector3I18F14 other) {
            const long k = 1L << 12;
            return I18F14.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F14 SaturatingDot(Vector3I18F14 other) {
            const long k = 1L << 12;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I18F14.MaxValue;
            } else if (bits < int.MinValue) {
                return I18F14.MinValue;
            } else {
                return I18F14.FromBits((int)bits);
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
        public I38F26 LengthSquared() {
            return I38F26.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F14 LengthHalf() => I18F14.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I19F13 Length() => I19F13.FromBits(LengthInternal());

    }

    partial struct I18F14 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I18F14 SaturatingMul(Vector3I18F14 other) => other.SaturatingMul(this);
    }
}
