#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector3UInt128 : IEquatable<Vector3UInt128> {

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public UInt128 X;
        public UInt128 Y;
        public UInt128 Z;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        public static explicit operator System.Numerics.Vector3(Vector3UInt128 a) {
            return new System.Numerics.Vector3((float)a.X, (float)a.Y, (float)a.Z);
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector3(Vector3UInt128 a) {
            return new UnityEngine.Vector3((float)a.X, (float)a.Y, (float)a.Z);
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float3(Vector3UInt128 a) {
            return new Unity.Mathematics.float3((float)a.X, (float)a.Y, (float)a.Z);
        }
#endif

        public Vector3UInt128(UInt128 x, UInt128 y, UInt128 z) {
            X = x;
            Y = y;
            Z = z;
        }

        public UInt128 this[int index] {
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

        #region IComparisonOperators, IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(Vector3UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left.X < right.X, left.Y < right.Y, left.Z < right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left < right.X, left < right.Y, left < right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(Vector3UInt128 left, UInt128 right) {
            return new Vector3Bool(left.X < right, left.Y < right, left.Z < right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(Vector3UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left.X > right.X, left.Y > right.Y, left.Z > right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left > right.X, left > right.Y, left > right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(Vector3UInt128 left, UInt128 right) {
            return new Vector3Bool(left.X > right, left.Y > right, left.Z > right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(Vector3UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left <= right.X, left <= right.Y, left <= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(Vector3UInt128 left, UInt128 right) {
            return new Vector3Bool(left.X <= right, left.Y <= right, left.Z <= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(Vector3UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left >= right.X, left >= right.Y, left >= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(Vector3UInt128 left, UInt128 right) {
            return new Vector3Bool(left.X >= right, left.Y >= right, left.Z >= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left == right.X, left == right.Y, left == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3UInt128 left, UInt128 right) {
            return new Vector3Bool(left.X == right, left.Y == right, left.Z == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(UInt128 left, Vector3UInt128 right) {
            return new Vector3Bool(left != right.X, left != right.Y, left != right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3UInt128 left, UInt128 right) {
            return new Vector3Bool(left.X != right, left.Y != right, left.Z != right);
        }

        #endregion

        #region IShiftOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator <<(Vector3UInt128 left, int right) {
            return new Vector3UInt128(left.X << right, left.Y << right, left.Z << right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator >>(Vector3UInt128 left, int right) {
            return new Vector3UInt128(left.X >> right, left.Y >> right, left.Z >> right);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator >>>(Vector3UInt128 left, int right) {
            return new Vector3UInt128(left.X >>> right, left.Y >>> right, left.Z >>> right);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3UInt128 other) {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector3UInt128 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator +(Vector3UInt128 left, Vector3UInt128 right) {
            return new Vector3UInt128(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator +(Vector3UInt128 left, UInt128 right) {
            return new Vector3UInt128(left.X + right, left.Y + right, left.Z + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator +(UInt128 left, Vector3UInt128 right) {
            return new Vector3UInt128(left + right.X, left + right.Y, left + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator -(Vector3UInt128 left, Vector3UInt128 right) {
            return new Vector3UInt128(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator -(Vector3UInt128 left, UInt128 right) {
            return new Vector3UInt128(left.X - right, left.Y - right, left.Z - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator -(UInt128 left, Vector3UInt128 right) {
            return new Vector3UInt128(left - right.X, left - right.Y, left - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator *(Vector3UInt128 left, Vector3UInt128 right) {
            return new Vector3UInt128(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator *(Vector3UInt128 left, UInt128 right) {
            return new Vector3UInt128(left.X * right, left.Y * right, left.Z * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator *(UInt128 left, Vector3UInt128 right) {
            return new Vector3UInt128(left * right.X, left * right.Y, left * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator /(Vector3UInt128 left, Vector3UInt128 right) {
            return new Vector3UInt128(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator /(Vector3UInt128 left, UInt128 right) {
            return new Vector3UInt128(left.X / right, left.Y / right, left.Z / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator /(UInt128 left, Vector3UInt128 right) {
            return new Vector3UInt128(left / right.X, left / right.Y, left / right.Z);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt128 operator +(Vector3UInt128 x) {
            return new Vector3UInt128(+x.X, +x.Y, +x.Z);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int32(Vector3UInt128 a) {
            return new Vector3Int32((int)a.X, (int)a.Y, (int)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt32(Vector3UInt128 a) {
            return new Vector3UInt32((uint)a.X, (uint)a.Y, (uint)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int64(Vector3UInt128 a) {
            return new Vector3Int64((long)a.X, (long)a.Y, (long)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt64(Vector3UInt128 a) {
            return new Vector3UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int128(Vector3UInt128 a) {
            return new Vector3Int128((Int128)a.X, (Int128)a.Y, (Int128)a.Z);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion

        #region IsNegative, AbsDiff

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Bool IsNegative() {
            return new Vector3Bool(X < 0, Y < 0, Z < 0);
        }

        // 符号なしベクトル型に対しては Abs, UnsignedAbs は定義しない.

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 AbsDiff(Vector3UInt128 other) {
            return new Vector3UInt128(
                Mathi.AbsDiff(X, other.X),
                Mathi.AbsDiff(Y, other.Y),
                Mathi.AbsDiff(Z, other.Z)
            );
        }
        #endregion

        #region Min, Max, MaxComponent, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 Min(Vector3UInt128 other) {
            return new Vector3UInt128(UInt128.Min(X, other.X), UInt128.Min(Y, other.Y), UInt128.Min(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 Max(Vector3UInt128 other) {
            return new Vector3UInt128(UInt128.Max(X, other.X), UInt128.Max(Y, other.Y), UInt128.Max(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal UInt128 MaxComponent() {
            return UInt128.Max(UInt128.Max(X, Y), Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 Clamp(UInt128 min, UInt128 max) {
            return new Vector3UInt128(UInt128.Clamp(X, min, max), UInt128.Clamp(Y, min, max), UInt128.Clamp(Z, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 Clamp(Vector3UInt128 min, Vector3UInt128 max) {
            return new Vector3UInt128(UInt128.Clamp(X, min.X, max.X), UInt128.Clamp(Y, min.Y, max.Y), UInt128.Clamp(Z, min.Z, max.Z));
        }

        #endregion

        #region Half, Twice, ComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 Half() => new Vector3UInt128(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 Twice() => new Vector3UInt128(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal UInt128 ComponentsSum() => X + Y + Z;

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 WrappingAdd(Vector3UInt128 other) {
            return new Vector3UInt128(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 WrappingSub(Vector3UInt128 other) {
            return new Vector3UInt128(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 WrappingNeg() {
            return new Vector3UInt128(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z));
        }

        // Rust に倣って WrappingAddSigned のみを定義し
        // WrappingSubSigned は定義しない.
        // https://doc.rust-lang.org/std/primitive.u32.html#method.wrapping_add_signed

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 WrappingAddSigned(Vector3Int128 other) {
            return new Vector3UInt128(Overflowing.WrappingAddSigned(X, other.X), Overflowing.WrappingAddSigned(Y, other.Y), Overflowing.WrappingAddSigned(Z, other.Z));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 X0() => new Vector2UInt128(X, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 X1() => new Vector2UInt128(X, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 XX() => new Vector2UInt128(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 XY() => new Vector2UInt128(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 XZ() => new Vector2UInt128(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 YX() => new Vector2UInt128(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 YY() => new Vector2UInt128(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 YZ() => new Vector2UInt128(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 ZX() => new Vector2UInt128(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 ZY() => new Vector2UInt128(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 ZZ() => new Vector2UInt128(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XY0() => new Vector3UInt128(X, Y, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XY1() => new Vector3UInt128(X, Y, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XXX() => new Vector3UInt128(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XXY() => new Vector3UInt128(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XXZ() => new Vector3UInt128(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XYX() => new Vector3UInt128(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XYY() => new Vector3UInt128(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XYZ() => new Vector3UInt128(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XZX() => new Vector3UInt128(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XZY() => new Vector3UInt128(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XZZ() => new Vector3UInt128(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YXX() => new Vector3UInt128(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YXY() => new Vector3UInt128(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YXZ() => new Vector3UInt128(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YYX() => new Vector3UInt128(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YYY() => new Vector3UInt128(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YYZ() => new Vector3UInt128(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YZX() => new Vector3UInt128(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YZY() => new Vector3UInt128(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YZZ() => new Vector3UInt128(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZXX() => new Vector3UInt128(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZXY() => new Vector3UInt128(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZXZ() => new Vector3UInt128(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZYX() => new Vector3UInt128(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZYY() => new Vector3UInt128(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZYZ() => new Vector3UInt128(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZZX() => new Vector3UInt128(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZZY() => new Vector3UInt128(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 ZZZ() => new Vector3UInt128(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZ0() => new Vector4UInt128(X, Y, Z, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZ1() => new Vector4UInt128(X, Y, Z, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXXX() => new Vector4UInt128(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXXY() => new Vector4UInt128(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXXZ() => new Vector4UInt128(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXYX() => new Vector4UInt128(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXYY() => new Vector4UInt128(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXYZ() => new Vector4UInt128(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXZX() => new Vector4UInt128(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXZY() => new Vector4UInt128(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXZZ() => new Vector4UInt128(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYXX() => new Vector4UInt128(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYXY() => new Vector4UInt128(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYXZ() => new Vector4UInt128(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYYX() => new Vector4UInt128(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYYY() => new Vector4UInt128(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYYZ() => new Vector4UInt128(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZX() => new Vector4UInt128(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZY() => new Vector4UInt128(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYZZ() => new Vector4UInt128(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZXX() => new Vector4UInt128(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZXY() => new Vector4UInt128(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZXZ() => new Vector4UInt128(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZYX() => new Vector4UInt128(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZYY() => new Vector4UInt128(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZYZ() => new Vector4UInt128(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZZX() => new Vector4UInt128(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZZY() => new Vector4UInt128(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XZZZ() => new Vector4UInt128(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXXX() => new Vector4UInt128(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXXY() => new Vector4UInt128(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXXZ() => new Vector4UInt128(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXYX() => new Vector4UInt128(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXYY() => new Vector4UInt128(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXYZ() => new Vector4UInt128(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXZX() => new Vector4UInt128(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXZY() => new Vector4UInt128(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXZZ() => new Vector4UInt128(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYXX() => new Vector4UInt128(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYXY() => new Vector4UInt128(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYXZ() => new Vector4UInt128(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYYX() => new Vector4UInt128(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYYY() => new Vector4UInt128(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYYZ() => new Vector4UInt128(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYZX() => new Vector4UInt128(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYZY() => new Vector4UInt128(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYZZ() => new Vector4UInt128(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZXX() => new Vector4UInt128(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZXY() => new Vector4UInt128(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZXZ() => new Vector4UInt128(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZYX() => new Vector4UInt128(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZYY() => new Vector4UInt128(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZYZ() => new Vector4UInt128(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZZX() => new Vector4UInt128(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZZY() => new Vector4UInt128(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YZZZ() => new Vector4UInt128(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXXX() => new Vector4UInt128(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXXY() => new Vector4UInt128(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXXZ() => new Vector4UInt128(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXYX() => new Vector4UInt128(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXYY() => new Vector4UInt128(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXYZ() => new Vector4UInt128(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXZX() => new Vector4UInt128(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXZY() => new Vector4UInt128(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZXZZ() => new Vector4UInt128(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYXX() => new Vector4UInt128(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYXY() => new Vector4UInt128(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYXZ() => new Vector4UInt128(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYYX() => new Vector4UInt128(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYYY() => new Vector4UInt128(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYYZ() => new Vector4UInt128(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYZX() => new Vector4UInt128(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYZY() => new Vector4UInt128(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZYZZ() => new Vector4UInt128(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZXX() => new Vector4UInt128(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZXY() => new Vector4UInt128(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZXZ() => new Vector4UInt128(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZYX() => new Vector4UInt128(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZYY() => new Vector4UInt128(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZYZ() => new Vector4UInt128(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZZX() => new Vector4UInt128(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZZY() => new Vector4UInt128(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 ZZZZ() => new Vector4UInt128(Z, Z, Z, Z);

        #endregion

    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
