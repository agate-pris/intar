#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector4UInt128 : IEquatable<Vector4UInt128> {
        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public UInt128 X;
        public UInt128 Y;
        public UInt128 Z;
        public UInt128 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion

        public static explicit operator System.Numerics.Vector4(Vector4UInt128 a) {
            return new System.Numerics.Vector4((float)a.X, (float)a.Y, (float)a.Z, (float)a.W);
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector4(Vector4UInt128 a) {
            return new UnityEngine.Vector4((float)a.X, (float)a.Y, (float)a.Z, (float)a.W);
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float4(Vector4UInt128 a) {
            return new Unity.Mathematics.float4((float)a.X, (float)a.Y, (float)a.Z, (float)a.W);
        }
#endif

        public Vector4UInt128(UInt128 x, UInt128 y, UInt128 z, UInt128 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public UInt128 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    case 3: return W;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    case 2: Z = value; break;
                    case 3: W = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        #region IComparisonOperators, IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <(Vector4UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left.X < right.X, left.Y < right.Y, left.Z < right.Z, left.W < right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <(UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left < right.X, left < right.Y, left < right.Z, left < right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <(Vector4UInt128 left, UInt128 right) {
            return new Vector4Bool(left.X < right, left.Y < right, left.Z < right, left.W < right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >(Vector4UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left.X > right.X, left.Y > right.Y, left.Z > right.Z, left.W > right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >(UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left > right.X, left > right.Y, left > right.Z, left > right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >(Vector4UInt128 left, UInt128 right) {
            return new Vector4Bool(left.X > right, left.Y > right, left.Z > right, left.W > right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <=(Vector4UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z, left.W <= right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <=(UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left <= right.X, left <= right.Y, left <= right.Z, left <= right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <=(Vector4UInt128 left, UInt128 right) {
            return new Vector4Bool(left.X <= right, left.Y <= right, left.Z <= right, left.W <= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >=(Vector4UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z, left.W >= right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >=(UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left >= right.X, left >= right.Y, left >= right.Z, left >= right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >=(Vector4UInt128 left, UInt128 right) {
            return new Vector4Bool(left.X >= right, left.Y >= right, left.Z >= right, left.W >= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z, left.W == right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left == right.X, left == right.Y, left == right.Z, left == right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4UInt128 left, UInt128 right) {
            return new Vector4Bool(left.X == right, left.Y == right, left.Z == right, left.W == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z, left.W != right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(UInt128 left, Vector4UInt128 right) {
            return new Vector4Bool(left != right.X, left != right.Y, left != right.Z, left != right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4UInt128 left, UInt128 right) {
            return new Vector4Bool(left.X != right, left.Y != right, left.Z != right, left.W != right);
        }

        #endregion

        #region IShiftOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator <<(Vector4UInt128 left, int right) {
            return new Vector4UInt128(left.X << right, left.Y << right, left.Z << right, left.W << right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator >>(Vector4UInt128 left, int right) {
            return new Vector4UInt128(left.X >> right, left.Y >> right, left.Z >> right, left.W >> right);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator >>>(Vector4UInt128 left, int right) {
            return new Vector4UInt128(left.X >>> right, left.Y >>> right, left.Z >>> right, left.W >>> right);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4UInt128 other) {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector4UInt128 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator +(Vector4UInt128 left, Vector4UInt128 right) {
            return new Vector4UInt128(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator +(Vector4UInt128 left, UInt128 right) {
            return new Vector4UInt128(left.X + right, left.Y + right, left.Z + right, left.W + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator +(UInt128 left, Vector4UInt128 right) {
            return new Vector4UInt128(left + right.X, left + right.Y, left + right.Z, left + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator -(Vector4UInt128 left, Vector4UInt128 right) {
            return new Vector4UInt128(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator -(Vector4UInt128 left, UInt128 right) {
            return new Vector4UInt128(left.X - right, left.Y - right, left.Z - right, left.W - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator -(UInt128 left, Vector4UInt128 right) {
            return new Vector4UInt128(left - right.X, left - right.Y, left - right.Z, left - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator *(Vector4UInt128 left, Vector4UInt128 right) {
            return new Vector4UInt128(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator *(Vector4UInt128 left, UInt128 right) {
            return new Vector4UInt128(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator *(UInt128 left, Vector4UInt128 right) {
            return new Vector4UInt128(left * right.X, left * right.Y, left * right.Z, left * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator /(Vector4UInt128 left, Vector4UInt128 right) {
            return new Vector4UInt128(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator /(Vector4UInt128 left, UInt128 right) {
            return new Vector4UInt128(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator /(UInt128 left, Vector4UInt128 right) {
            return new Vector4UInt128(left / right.X, left / right.Y, left / right.Z, left / right.W);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt128 operator +(Vector4UInt128 x) {
            return new Vector4UInt128(+x.X, +x.Y, +x.Z, +x.W);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int32(Vector4UInt128 a) {
            return new Vector4Int32((int)a.X, (int)a.Y, (int)a.Z, (int)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt32(Vector4UInt128 a) {
            return new Vector4UInt32((uint)a.X, (uint)a.Y, (uint)a.Z, (uint)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int64(Vector4UInt128 a) {
            return new Vector4Int64((long)a.X, (long)a.Y, (long)a.Z, (long)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt64(Vector4UInt128 a) {
            return new Vector4UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z, (ulong)a.W);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int128(Vector4UInt128 a) {
            return new Vector4Int128((Int128)a.X, (Int128)a.Y, (Int128)a.Z, (Int128)a.W);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion

        #region IsNegative, AbsDiff

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Bool IsNegative() {
            return new Vector4Bool(X < 0, Y < 0, Z < 0, W < 0);
        }

        // 符号なしベクトル型に対しては Abs, UnsignedAbs は定義しない.

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 AbsDiff(Vector4UInt128 other) {
            return new Vector4UInt128(
                Mathi.AbsDiff(X, other.X),
                Mathi.AbsDiff(Y, other.Y),
                Mathi.AbsDiff(Z, other.Z),
                Mathi.AbsDiff(W, other.W)
            );
        }
        #endregion

        #region Min, Max, MaxComponent, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 Min(Vector4UInt128 other) {
            return new Vector4UInt128(UInt128.Min(X, other.X), UInt128.Min(Y, other.Y), UInt128.Min(Z, other.Z), UInt128.Min(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 Max(Vector4UInt128 other) {
            return new Vector4UInt128(UInt128.Max(X, other.X), UInt128.Max(Y, other.Y), UInt128.Max(Z, other.Z), UInt128.Max(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal UInt128 MaxComponent() {
            return UInt128.Max(UInt128.Max(X, Y), UInt128.Max(Z, W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 Clamp(UInt128 min, UInt128 max) {
            return new Vector4UInt128(UInt128.Clamp(X, min, max), UInt128.Clamp(Y, min, max), UInt128.Clamp(Z, min, max), UInt128.Clamp(W, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 Clamp(Vector4UInt128 min, Vector4UInt128 max) {
            return new Vector4UInt128(UInt128.Clamp(X, min.X, max.X), UInt128.Clamp(Y, min.Y, max.Y), UInt128.Clamp(Z, min.Z, max.Z), UInt128.Clamp(W, min.W, max.W));
        }

        #endregion

        #region Half, Twice, ComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 Half() => new Vector4UInt128(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z), Mathi.Half(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 Twice() => new Vector4UInt128(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z), Mathi.Twice(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal UInt128 ComponentsSum() => X + Y + Z + W;

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 WrappingAdd(Vector4UInt128 other) {
            return new Vector4UInt128(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z), Overflowing.WrappingAdd(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 WrappingSub(Vector4UInt128 other) {
            return new Vector4UInt128(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z), Overflowing.WrappingSub(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 WrappingNeg() {
            return new Vector4UInt128(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z), Overflowing.WrappingNeg(W));
        }

        // Rust に倣って WrappingAddSigned のみを定義し
        // WrappingSubSigned は定義しない.
        // https://doc.rust-lang.org/std/primitive.u32.html#method.wrapping_add_signed

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 WrappingAddSigned(Vector4Int128 other) {
            return new Vector4UInt128(Overflowing.WrappingAddSigned(X, other.X), Overflowing.WrappingAddSigned(Y, other.Y), Overflowing.WrappingAddSigned(Z, other.Z), Overflowing.WrappingAddSigned(W, other.W));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 X0() => new Vector2UInt128(X, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 X1() => new Vector2UInt128(X, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 XX() => new Vector2UInt128(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 XY() => new Vector2UInt128(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 XZ() => new Vector2UInt128(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 XW() => new Vector2UInt128(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 YX() => new Vector2UInt128(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 YY() => new Vector2UInt128(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 YZ() => new Vector2UInt128(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 YW() => new Vector2UInt128(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 ZX() => new Vector2UInt128(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 ZY() => new Vector2UInt128(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 ZZ() => new Vector2UInt128(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 ZW() => new Vector2UInt128(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 WX() => new Vector2UInt128(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 WY() => new Vector2UInt128(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 WZ() => new Vector2UInt128(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 WW() => new Vector2UInt128(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XY0() => new Vector3UInt128(X, Y, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XY1() => new Vector3UInt128(X, Y, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XXX() => new Vector3UInt128(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XXY() => new Vector3UInt128(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XXZ() => new Vector3UInt128(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XXW() => new Vector3UInt128(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XYX() => new Vector3UInt128(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XYY() => new Vector3UInt128(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XYZ() => new Vector3UInt128(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XYW() => new Vector3UInt128(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XZX() => new Vector3UInt128(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XZY() => new Vector3UInt128(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XZZ() => new Vector3UInt128(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XZW() => new Vector3UInt128(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XWX() => new Vector3UInt128(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XWY() => new Vector3UInt128(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XWZ() => new Vector3UInt128(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XWW() => new Vector3UInt128(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YXX() => new Vector3UInt128(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YXY() => new Vector3UInt128(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YXZ() => new Vector3UInt128(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YXW() => new Vector3UInt128(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YYX() => new Vector3UInt128(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YYY() => new Vector3UInt128(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YYZ() => new Vector3UInt128(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YYW() => new Vector3UInt128(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YZX() => new Vector3UInt128(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YZY() => new Vector3UInt128(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YZZ() => new Vector3UInt128(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YZW() => new Vector3UInt128(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YWX() => new Vector3UInt128(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YWY() => new Vector3UInt128(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YWZ() => new Vector3UInt128(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YWW() => new Vector3UInt128(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZXX() => new Vector3UInt128(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZXY() => new Vector3UInt128(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZXZ() => new Vector3UInt128(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZXW() => new Vector3UInt128(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZYX() => new Vector3UInt128(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZYY() => new Vector3UInt128(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZYZ() => new Vector3UInt128(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZYW() => new Vector3UInt128(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZZX() => new Vector3UInt128(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZZY() => new Vector3UInt128(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZZZ() => new Vector3UInt128(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZZW() => new Vector3UInt128(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZWX() => new Vector3UInt128(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZWY() => new Vector3UInt128(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZWZ() => new Vector3UInt128(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZWW() => new Vector3UInt128(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WXX() => new Vector3UInt128(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WXY() => new Vector3UInt128(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WXZ() => new Vector3UInt128(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WXW() => new Vector3UInt128(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WYX() => new Vector3UInt128(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WYY() => new Vector3UInt128(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WYZ() => new Vector3UInt128(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WYW() => new Vector3UInt128(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WZX() => new Vector3UInt128(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WZY() => new Vector3UInt128(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WZZ() => new Vector3UInt128(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WZW() => new Vector3UInt128(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WWX() => new Vector3UInt128(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WWY() => new Vector3UInt128(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WWZ() => new Vector3UInt128(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 WWW() => new Vector3UInt128(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZ0() => new Vector4UInt128(X, Y, Z, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZ1() => new Vector4UInt128(X, Y, Z, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXXX() => new Vector4UInt128(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXXY() => new Vector4UInt128(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXXZ() => new Vector4UInt128(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXXW() => new Vector4UInt128(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXYX() => new Vector4UInt128(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXYY() => new Vector4UInt128(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXYZ() => new Vector4UInt128(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXYW() => new Vector4UInt128(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXZX() => new Vector4UInt128(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXZY() => new Vector4UInt128(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXZZ() => new Vector4UInt128(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXZW() => new Vector4UInt128(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXWX() => new Vector4UInt128(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXWY() => new Vector4UInt128(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXWZ() => new Vector4UInt128(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXWW() => new Vector4UInt128(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYXX() => new Vector4UInt128(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYXY() => new Vector4UInt128(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYXZ() => new Vector4UInt128(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYXW() => new Vector4UInt128(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYYX() => new Vector4UInt128(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYYY() => new Vector4UInt128(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYYZ() => new Vector4UInt128(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYYW() => new Vector4UInt128(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZX() => new Vector4UInt128(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZY() => new Vector4UInt128(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZZ() => new Vector4UInt128(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZW() => new Vector4UInt128(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYWX() => new Vector4UInt128(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYWY() => new Vector4UInt128(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYWZ() => new Vector4UInt128(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYWW() => new Vector4UInt128(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZXX() => new Vector4UInt128(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZXY() => new Vector4UInt128(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZXZ() => new Vector4UInt128(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZXW() => new Vector4UInt128(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZYX() => new Vector4UInt128(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZYY() => new Vector4UInt128(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZYZ() => new Vector4UInt128(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZYW() => new Vector4UInt128(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZZX() => new Vector4UInt128(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZZY() => new Vector4UInt128(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZZZ() => new Vector4UInt128(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZZW() => new Vector4UInt128(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZWX() => new Vector4UInt128(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZWY() => new Vector4UInt128(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZWZ() => new Vector4UInt128(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZWW() => new Vector4UInt128(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWXX() => new Vector4UInt128(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWXY() => new Vector4UInt128(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWXZ() => new Vector4UInt128(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWXW() => new Vector4UInt128(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWYX() => new Vector4UInt128(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWYY() => new Vector4UInt128(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWYZ() => new Vector4UInt128(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWYW() => new Vector4UInt128(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWZX() => new Vector4UInt128(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWZY() => new Vector4UInt128(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWZZ() => new Vector4UInt128(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWZW() => new Vector4UInt128(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWWX() => new Vector4UInt128(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWWY() => new Vector4UInt128(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWWZ() => new Vector4UInt128(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XWWW() => new Vector4UInt128(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXXX() => new Vector4UInt128(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXXY() => new Vector4UInt128(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXXZ() => new Vector4UInt128(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXXW() => new Vector4UInt128(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXYX() => new Vector4UInt128(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXYY() => new Vector4UInt128(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXYZ() => new Vector4UInt128(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXYW() => new Vector4UInt128(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXZX() => new Vector4UInt128(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXZY() => new Vector4UInt128(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXZZ() => new Vector4UInt128(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXZW() => new Vector4UInt128(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXWX() => new Vector4UInt128(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXWY() => new Vector4UInt128(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXWZ() => new Vector4UInt128(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXWW() => new Vector4UInt128(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYXX() => new Vector4UInt128(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYXY() => new Vector4UInt128(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYXZ() => new Vector4UInt128(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYXW() => new Vector4UInt128(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYYX() => new Vector4UInt128(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYYY() => new Vector4UInt128(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYYZ() => new Vector4UInt128(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYYW() => new Vector4UInt128(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYZX() => new Vector4UInt128(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYZY() => new Vector4UInt128(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYZZ() => new Vector4UInt128(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYZW() => new Vector4UInt128(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYWX() => new Vector4UInt128(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYWY() => new Vector4UInt128(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYWZ() => new Vector4UInt128(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYWW() => new Vector4UInt128(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZXX() => new Vector4UInt128(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZXY() => new Vector4UInt128(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZXZ() => new Vector4UInt128(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZXW() => new Vector4UInt128(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZYX() => new Vector4UInt128(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZYY() => new Vector4UInt128(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZYZ() => new Vector4UInt128(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZYW() => new Vector4UInt128(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZZX() => new Vector4UInt128(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZZY() => new Vector4UInt128(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZZZ() => new Vector4UInt128(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZZW() => new Vector4UInt128(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZWX() => new Vector4UInt128(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZWY() => new Vector4UInt128(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZWZ() => new Vector4UInt128(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZWW() => new Vector4UInt128(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWXX() => new Vector4UInt128(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWXY() => new Vector4UInt128(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWXZ() => new Vector4UInt128(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWXW() => new Vector4UInt128(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWYX() => new Vector4UInt128(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWYY() => new Vector4UInt128(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWYZ() => new Vector4UInt128(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWYW() => new Vector4UInt128(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWZX() => new Vector4UInt128(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWZY() => new Vector4UInt128(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWZZ() => new Vector4UInt128(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWZW() => new Vector4UInt128(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWWX() => new Vector4UInt128(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWWY() => new Vector4UInt128(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWWZ() => new Vector4UInt128(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YWWW() => new Vector4UInt128(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXXX() => new Vector4UInt128(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXXY() => new Vector4UInt128(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXXZ() => new Vector4UInt128(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXXW() => new Vector4UInt128(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXYX() => new Vector4UInt128(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXYY() => new Vector4UInt128(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXYZ() => new Vector4UInt128(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXYW() => new Vector4UInt128(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXZX() => new Vector4UInt128(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXZY() => new Vector4UInt128(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXZZ() => new Vector4UInt128(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXZW() => new Vector4UInt128(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXWX() => new Vector4UInt128(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXWY() => new Vector4UInt128(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXWZ() => new Vector4UInt128(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXWW() => new Vector4UInt128(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYXX() => new Vector4UInt128(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYXY() => new Vector4UInt128(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYXZ() => new Vector4UInt128(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYXW() => new Vector4UInt128(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYYX() => new Vector4UInt128(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYYY() => new Vector4UInt128(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYYZ() => new Vector4UInt128(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYYW() => new Vector4UInt128(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYZX() => new Vector4UInt128(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYZY() => new Vector4UInt128(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYZZ() => new Vector4UInt128(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYZW() => new Vector4UInt128(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYWX() => new Vector4UInt128(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYWY() => new Vector4UInt128(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYWZ() => new Vector4UInt128(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYWW() => new Vector4UInt128(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZXX() => new Vector4UInt128(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZXY() => new Vector4UInt128(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZXZ() => new Vector4UInt128(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZXW() => new Vector4UInt128(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZYX() => new Vector4UInt128(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZYY() => new Vector4UInt128(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZYZ() => new Vector4UInt128(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZYW() => new Vector4UInt128(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZZX() => new Vector4UInt128(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZZY() => new Vector4UInt128(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZZZ() => new Vector4UInt128(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZZW() => new Vector4UInt128(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZWX() => new Vector4UInt128(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZWY() => new Vector4UInt128(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZWZ() => new Vector4UInt128(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZWW() => new Vector4UInt128(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWXX() => new Vector4UInt128(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWXY() => new Vector4UInt128(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWXZ() => new Vector4UInt128(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWXW() => new Vector4UInt128(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWYX() => new Vector4UInt128(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWYY() => new Vector4UInt128(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWYZ() => new Vector4UInt128(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWYW() => new Vector4UInt128(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWZX() => new Vector4UInt128(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWZY() => new Vector4UInt128(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWZZ() => new Vector4UInt128(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWZW() => new Vector4UInt128(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWWX() => new Vector4UInt128(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWWY() => new Vector4UInt128(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWWZ() => new Vector4UInt128(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZWWW() => new Vector4UInt128(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXXX() => new Vector4UInt128(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXXY() => new Vector4UInt128(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXXZ() => new Vector4UInt128(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXXW() => new Vector4UInt128(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXYX() => new Vector4UInt128(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXYY() => new Vector4UInt128(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXYZ() => new Vector4UInt128(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXYW() => new Vector4UInt128(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXZX() => new Vector4UInt128(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXZY() => new Vector4UInt128(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXZZ() => new Vector4UInt128(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXZW() => new Vector4UInt128(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXWX() => new Vector4UInt128(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXWY() => new Vector4UInt128(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXWZ() => new Vector4UInt128(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WXWW() => new Vector4UInt128(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYXX() => new Vector4UInt128(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYXY() => new Vector4UInt128(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYXZ() => new Vector4UInt128(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYXW() => new Vector4UInt128(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYYX() => new Vector4UInt128(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYYY() => new Vector4UInt128(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYYZ() => new Vector4UInt128(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYYW() => new Vector4UInt128(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYZX() => new Vector4UInt128(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYZY() => new Vector4UInt128(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYZZ() => new Vector4UInt128(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYZW() => new Vector4UInt128(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYWX() => new Vector4UInt128(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYWY() => new Vector4UInt128(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYWZ() => new Vector4UInt128(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WYWW() => new Vector4UInt128(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZXX() => new Vector4UInt128(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZXY() => new Vector4UInt128(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZXZ() => new Vector4UInt128(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZXW() => new Vector4UInt128(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZYX() => new Vector4UInt128(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZYY() => new Vector4UInt128(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZYZ() => new Vector4UInt128(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZYW() => new Vector4UInt128(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZZX() => new Vector4UInt128(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZZY() => new Vector4UInt128(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZZZ() => new Vector4UInt128(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZZW() => new Vector4UInt128(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZWX() => new Vector4UInt128(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZWY() => new Vector4UInt128(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZWZ() => new Vector4UInt128(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WZWW() => new Vector4UInt128(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWXX() => new Vector4UInt128(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWXY() => new Vector4UInt128(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWXZ() => new Vector4UInt128(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWXW() => new Vector4UInt128(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWYX() => new Vector4UInt128(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWYY() => new Vector4UInt128(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWYZ() => new Vector4UInt128(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWYW() => new Vector4UInt128(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWZX() => new Vector4UInt128(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWZY() => new Vector4UInt128(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWZZ() => new Vector4UInt128(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWZW() => new Vector4UInt128(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWWX() => new Vector4UInt128(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWWY() => new Vector4UInt128(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWWZ() => new Vector4UInt128(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 WWWW() => new Vector4UInt128(W, W, W, W);

        #endregion

    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
