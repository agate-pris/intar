using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I7F25
    : IEquatable<Vector3I7F25>
    , IFormattable
    , IVector<U16F48, I16F48, U8F24, I8F24>
    , IVectorComponentRespective<I7F25> {
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

        // Indexer
        // ---------------------------------------

        public I7F25 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    case 2: Z = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I7F25 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, X); }
        public Vector2I7F25 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, Y); }
        public Vector2I7F25 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, Z); }
        public Vector2I7F25 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, X); }
        public Vector2I7F25 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, Y); }
        public Vector2I7F25 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, Z); }
        public Vector2I7F25 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, X); }
        public Vector2I7F25 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, Y); }
        public Vector2I7F25 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, Z); }
        public Vector3I7F25 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, X); }
        public Vector3I7F25 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, Y); }
        public Vector3I7F25 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, Z); }
        public Vector3I7F25 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, X); }
        public Vector3I7F25 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, Y); }
        public Vector3I7F25 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, Z); }
        public Vector3I7F25 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, X); }
        public Vector3I7F25 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, Y); }
        public Vector3I7F25 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, Z); }
        public Vector3I7F25 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, X); }
        public Vector3I7F25 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, Y); }
        public Vector3I7F25 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, Z); }
        public Vector3I7F25 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, X); }
        public Vector3I7F25 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, Y); }
        public Vector3I7F25 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, Z); }
        public Vector3I7F25 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, X); }
        public Vector3I7F25 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, Y); }
        public Vector3I7F25 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, Z); }
        public Vector3I7F25 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, X); }
        public Vector3I7F25 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, Y); }
        public Vector3I7F25 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, Z); }
        public Vector3I7F25 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, X); }
        public Vector3I7F25 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, Y); }
        public Vector3I7F25 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, Z); }
        public Vector3I7F25 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, X); }
        public Vector3I7F25 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, Y); }
        public Vector3I7F25 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, Z); }
        public Vector4I7F25 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, X); }
        public Vector4I7F25 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, Y); }
        public Vector4I7F25 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, Z); }
        public Vector4I7F25 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, X); }
        public Vector4I7F25 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, Y); }
        public Vector4I7F25 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, Z); }
        public Vector4I7F25 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, X); }
        public Vector4I7F25 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, Y); }
        public Vector4I7F25 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, Z); }
        public Vector4I7F25 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, X); }
        public Vector4I7F25 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, Y); }
        public Vector4I7F25 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, Z); }
        public Vector4I7F25 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, X); }
        public Vector4I7F25 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, Y); }
        public Vector4I7F25 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, Z); }
        public Vector4I7F25 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, X); }
        public Vector4I7F25 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, Y); }
        public Vector4I7F25 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, Z); }
        public Vector4I7F25 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, X); }
        public Vector4I7F25 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, Y); }
        public Vector4I7F25 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, Z); }
        public Vector4I7F25 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, X); }
        public Vector4I7F25 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, Y); }
        public Vector4I7F25 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, Z); }
        public Vector4I7F25 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, X); }
        public Vector4I7F25 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, Y); }
        public Vector4I7F25 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, Z); }
        public Vector4I7F25 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, X); }
        public Vector4I7F25 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, Y); }
        public Vector4I7F25 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, Z); }
        public Vector4I7F25 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, X); }
        public Vector4I7F25 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, Y); }
        public Vector4I7F25 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, Z); }
        public Vector4I7F25 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, X); }
        public Vector4I7F25 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, Y); }
        public Vector4I7F25 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, Z); }
        public Vector4I7F25 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, X); }
        public Vector4I7F25 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, Y); }
        public Vector4I7F25 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, Z); }
        public Vector4I7F25 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, X); }
        public Vector4I7F25 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, Y); }
        public Vector4I7F25 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, Z); }
        public Vector4I7F25 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, X); }
        public Vector4I7F25 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, Y); }
        public Vector4I7F25 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, Z); }
        public Vector4I7F25 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, X); }
        public Vector4I7F25 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, Y); }
        public Vector4I7F25 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, Z); }
        public Vector4I7F25 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, X); }
        public Vector4I7F25 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, Y); }
        public Vector4I7F25 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, Z); }
        public Vector4I7F25 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, X); }
        public Vector4I7F25 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, Y); }
        public Vector4I7F25 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, Z); }
        public Vector4I7F25 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, X); }
        public Vector4I7F25 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, Y); }
        public Vector4I7F25 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, Z); }
        public Vector4I7F25 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, X); }
        public Vector4I7F25 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, Y); }
        public Vector4I7F25 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, Z); }
        public Vector4I7F25 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, X); }
        public Vector4I7F25 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, Y); }
        public Vector4I7F25 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, Z); }
        public Vector4I7F25 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, X); }
        public Vector4I7F25 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, Y); }
        public Vector4I7F25 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, Z); }
        public Vector4I7F25 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, X); }
        public Vector4I7F25 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, Y); }
        public Vector4I7F25 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, Z); }
        public Vector4I7F25 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, X); }
        public Vector4I7F25 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, Y); }
        public Vector4I7F25 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, Z); }
        public Vector4I7F25 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, X); }
        public Vector4I7F25 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, Y); }
        public Vector4I7F25 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, Z); }
        public Vector4I7F25 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, X); }
        public Vector4I7F25 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, Y); }
        public Vector4I7F25 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, Z); }
        public Vector4I7F25 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, X); }
        public Vector4I7F25 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, Y); }
        public Vector4I7F25 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, Z); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3I7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I7F25 other)
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
        public Vector3I7F25 Min(Vector3I7F25 other) => new Vector3I7F25(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 Max(Vector3I7F25 other) => new Vector3I7F25(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 Abs() => new Vector3I7F25(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 Half() => new Vector3I7F25(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 Twice() => new Vector3I7F25(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 Clamp(I7F25 min, I7F25 max) => new Vector3I7F25(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 Clamp(
            Vector3I7F25 min, Vector3I7F25 max
        ) => new Vector3I7F25(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 WrappingAdd(Vector3I7F25 other) => new Vector3I7F25(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 WrappingSub(Vector3I7F25 other) => new Vector3I7F25(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 WrappingMul(Vector3I7F25 other) => new Vector3I7F25(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 WrappingAddUnsigned(Vector3U7F25 other) => new Vector3I7F25(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 WrappingSubUnsigned(Vector3U7F25 other) => new Vector3I7F25(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U7F25 UnsignedAbs() => new Vector3U7F25(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 SaturatingAdd(Vector3I7F25 other) => new Vector3I7F25(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 SaturatingMul(I7F25 other) => new Vector3I7F25(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I7F25 other, out long x, out long y, out long z) {
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
        public Vector3I7F25 Cross(Vector3I7F25 other) {
            const long k = 1L << 25;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I7F25(
                I7F25.FromBits((int)(x / k)),
                I7F25.FromBits((int)(y / k)),
                I7F25.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 SaturatingCross(Vector3I7F25 other) {
            const long k = 1L << 25;
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
            return new Vector3I7F25(
                I7F25.FromBits((int)x),
                I7F25.FromBits((int)y),
                I7F25.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I7F25 other) {
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
        public I7F25 Dot(Vector3I7F25 other) {
            const long k = 1L << 23;
            return I7F25.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I7F25 SaturatingDot(Vector3I7F25 other) {
            const long k = 1L << 23;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I7F25.MaxValue;
            } else if (bits < int.MinValue) {
                return I7F25.MinValue;
            } else {
                return I7F25.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U16F48 LengthSquaredUnsigned() => U16F48.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I16F48 LengthSquaredSigned() => I16F48.FromBits(
            LengthSquaredInternal()
        );

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
        public I16F48 LengthSquared() => LengthSquaredSigned();

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
        public U7F25 LengthHalfUnsigned() => U7F25.FromBits(LengthInternal());

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
        public I7F25 LengthHalf() => I7F25.FromBits(checked((int)LengthInternal()));

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthSigned">LengthSigned</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthSigned">LengthSigned</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        /// <seealso cref="LengthSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F24 LengthUnsigned() => U8F24.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F24 LengthSigned() => I8F24.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F24 Length() => LengthSigned();

    }

    partial struct I7F25 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I7F25 SaturatingMul(Vector3I7F25 other) => other.SaturatingMul(this);
    }
}
