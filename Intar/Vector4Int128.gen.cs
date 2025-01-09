#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector4Int128 : IEquatable<Vector4Int128> {

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public Int128 X;
        public Int128 Y;
        public Int128 Z;
        public Int128 W;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        public static explicit operator System.Numerics.Vector4(Vector4Int128 a) {
            return new System.Numerics.Vector4((float)a.X, (float)a.Y, (float)a.Z, (float)a.W);
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector4(Vector4Int128 a) {
            return new UnityEngine.Vector4((float)a.X, (float)a.Y, (float)a.Z, (float)a.W);
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float4(Vector4Int128 a) {
            return new Unity.Mathematics.float4((float)a.X, (float)a.Y, (float)a.Z, (float)a.W);
        }
#endif

        public Vector4Int128(Int128 x, Int128 y, Int128 z, Int128 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public Int128 this[int index] {
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
        public static Vector4Bool operator <(Vector4Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left.X < right.X, left.Y < right.Y, left.Z < right.Z, left.W < right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <(Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left < right.X, left < right.Y, left < right.Z, left < right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <(Vector4Int128 left, Int128 right) {
            return new Vector4Bool(left.X < right, left.Y < right, left.Z < right, left.W < right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >(Vector4Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left.X > right.X, left.Y > right.Y, left.Z > right.Z, left.W > right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >(Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left > right.X, left > right.Y, left > right.Z, left > right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >(Vector4Int128 left, Int128 right) {
            return new Vector4Bool(left.X > right, left.Y > right, left.Z > right, left.W > right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <=(Vector4Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z, left.W <= right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <=(Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left <= right.X, left <= right.Y, left <= right.Z, left <= right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator <=(Vector4Int128 left, Int128 right) {
            return new Vector4Bool(left.X <= right, left.Y <= right, left.Z <= right, left.W <= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >=(Vector4Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z, left.W >= right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >=(Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left >= right.X, left >= right.Y, left >= right.Z, left >= right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator >=(Vector4Int128 left, Int128 right) {
            return new Vector4Bool(left.X >= right, left.Y >= right, left.Z >= right, left.W >= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z, left.W == right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left == right.X, left == right.Y, left == right.Z, left == right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4Int128 left, Int128 right) {
            return new Vector4Bool(left.X == right, left.Y == right, left.Z == right, left.W == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z, left.W != right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Int128 left, Vector4Int128 right) {
            return new Vector4Bool(left != right.X, left != right.Y, left != right.Z, left != right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4Int128 left, Int128 right) {
            return new Vector4Bool(left.X != right, left.Y != right, left.Z != right, left.W != right);
        }

        #endregion

        #region IShiftOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator <<(Vector4Int128 left, int right) {
            return new Vector4Int128(left.X << right, left.Y << right, left.Z << right, left.W << right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator >>(Vector4Int128 left, int right) {
            return new Vector4Int128(left.X >> right, left.Y >> right, left.Z >> right, left.W >> right);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator >>>(Vector4Int128 left, int right) {
            return new Vector4Int128(left.X >>> right, left.Y >>> right, left.Z >>> right, left.W >>> right);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4Int128 other) {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector4Int128 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator +(Vector4Int128 left, Vector4Int128 right) {
            return new Vector4Int128(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator +(Vector4Int128 left, Int128 right) {
            return new Vector4Int128(left.X + right, left.Y + right, left.Z + right, left.W + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator +(Int128 left, Vector4Int128 right) {
            return new Vector4Int128(left + right.X, left + right.Y, left + right.Z, left + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator -(Vector4Int128 left, Vector4Int128 right) {
            return new Vector4Int128(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator -(Vector4Int128 left, Int128 right) {
            return new Vector4Int128(left.X - right, left.Y - right, left.Z - right, left.W - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator -(Int128 left, Vector4Int128 right) {
            return new Vector4Int128(left - right.X, left - right.Y, left - right.Z, left - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator *(Vector4Int128 left, Vector4Int128 right) {
            return new Vector4Int128(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator *(Vector4Int128 left, Int128 right) {
            return new Vector4Int128(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator *(Int128 left, Vector4Int128 right) {
            return new Vector4Int128(left * right.X, left * right.Y, left * right.Z, left * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator /(Vector4Int128 left, Vector4Int128 right) {
            return new Vector4Int128(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator /(Vector4Int128 left, Int128 right) {
            return new Vector4Int128(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator /(Int128 left, Vector4Int128 right) {
            return new Vector4Int128(left / right.X, left / right.Y, left / right.Z, left / right.W);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator +(Vector4Int128 x) {
            return new Vector4Int128(+x.X, +x.Y, +x.Z, +x.W);
        }

        #endregion

        #region IUnarryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int128 operator -(Vector4Int128 x) {
            return new Vector4Int128(-x.X, -x.Y, -x.Z, -x.W);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int32(Vector4Int128 a) {
            return new Vector4Int32((int)a.X, (int)a.Y, (int)a.Z, (int)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt32(Vector4Int128 a) {
            return new Vector4UInt32((uint)a.X, (uint)a.Y, (uint)a.Z, (uint)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int64(Vector4Int128 a) {
            return new Vector4Int64((long)a.X, (long)a.Y, (long)a.Z, (long)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt64(Vector4Int128 a) {
            return new Vector4UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z, (ulong)a.W);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt128(Vector4Int128 a) {
            return new Vector4UInt128((UInt128)a.X, (UInt128)a.Y, (UInt128)a.Z, (UInt128)a.W);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion

        #region IsNegative, Abs, UnsignedAbs, IsNegativeAndUnsignedAbs, AbsDiff

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Bool IsNegative() {
            return new Vector4Bool(X < 0, Y < 0, Z < 0, W < 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 Abs() => new Vector4Int128(Int128.Abs(X), Int128.Abs(Y), Int128.Abs(Z), Int128.Abs(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 UnsignedAbs() {
            var isNegative = IsNegative();
            return new Vector4UInt128(
                unchecked((UInt128)(isNegative.X ? Overflowing.WrappingNeg(X) : X)),
                unchecked((UInt128)(isNegative.Y ? Overflowing.WrappingNeg(Y) : Y)),
                unchecked((UInt128)(isNegative.Z ? Overflowing.WrappingNeg(Z) : Z)),
                unchecked((UInt128)(isNegative.W ? Overflowing.WrappingNeg(W) : W))
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal (Vector4Bool isNegative, Vector4UInt128 unsignedAbs) IsNegativeAndUnsignedAbs() {
            var isNegative = IsNegative();
            var unsignedAbs = new Vector4UInt128(
                unchecked((UInt128)(isNegative.X ? Overflowing.WrappingNeg(X) : X)),
                unchecked((UInt128)(isNegative.Y ? Overflowing.WrappingNeg(Y) : Y)),
                unchecked((UInt128)(isNegative.Z ? Overflowing.WrappingNeg(Z) : Z)),
                unchecked((UInt128)(isNegative.W ? Overflowing.WrappingNeg(W) : W))
            );
            return (isNegative, unsignedAbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt128 AbsDiff(Vector4Int128 other) {
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
        public Vector4Int128 Min(Vector4Int128 other) {
            return new Vector4Int128(Int128.Min(X, other.X), Int128.Min(Y, other.Y), Int128.Min(Z, other.Z), Int128.Min(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 Max(Vector4Int128 other) {
            return new Vector4Int128(Int128.Max(X, other.X), Int128.Max(Y, other.Y), Int128.Max(Z, other.Z), Int128.Max(W, other.W));
        }

        // MaxComponent は符号なしの場合のみ定義する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 Clamp(Int128 min, Int128 max) {
            return new Vector4Int128(Int128.Clamp(X, min, max), Int128.Clamp(Y, min, max), Int128.Clamp(Z, min, max), Int128.Clamp(W, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 Clamp(Vector4Int128 min, Vector4Int128 max) {
            return new Vector4Int128(Int128.Clamp(X, min.X, max.X), Int128.Clamp(Y, min.Y, max.Y), Int128.Clamp(Z, min.Z, max.Z), Int128.Clamp(W, min.W, max.W));
        }

        #endregion

        #region Half, Twice, ComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 Half() => new Vector4Int128(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z), Mathi.Half(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 Twice() => new Vector4Int128(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z), Mathi.Twice(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Int128 ComponentsSum() => X + Y + Z + W;

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 WrappingAdd(Vector4Int128 other) {
            return new Vector4Int128(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z), Overflowing.WrappingAdd(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 WrappingSub(Vector4Int128 other) {
            return new Vector4Int128(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z), Overflowing.WrappingSub(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 WrappingNeg() {
            return new Vector4Int128(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z), Overflowing.WrappingNeg(W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 WrappingAddUnsigned(Vector4UInt128 other) {
            return new Vector4Int128(Overflowing.WrappingAddUnsigned(X, other.X), Overflowing.WrappingAddUnsigned(Y, other.Y), Overflowing.WrappingAddUnsigned(Z, other.Z), Overflowing.WrappingAddUnsigned(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 WrappingSubUnsigned(Vector4UInt128 other) {
            return new Vector4Int128(Overflowing.WrappingSubUnsigned(X, other.X), Overflowing.WrappingSubUnsigned(Y, other.Y), Overflowing.WrappingSubUnsigned(Z, other.Z), Overflowing.WrappingSubUnsigned(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int128 WrappingAbs() {
            return new Vector4Int128(Overflowing.WrappingAbs(X), Overflowing.WrappingAbs(Y), Overflowing.WrappingAbs(Z), Overflowing.WrappingAbs(W));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 X0() => new Vector2Int128(X, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 X1() => new Vector2Int128(X, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 XX() => new Vector2Int128(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 XY() => new Vector2Int128(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 XZ() => new Vector2Int128(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 XW() => new Vector2Int128(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 YX() => new Vector2Int128(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 YY() => new Vector2Int128(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 YZ() => new Vector2Int128(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 YW() => new Vector2Int128(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 ZX() => new Vector2Int128(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 ZY() => new Vector2Int128(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 ZZ() => new Vector2Int128(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 ZW() => new Vector2Int128(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 WX() => new Vector2Int128(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 WY() => new Vector2Int128(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 WZ() => new Vector2Int128(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 WW() => new Vector2Int128(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XY0() => new Vector3Int128(X, Y, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XY1() => new Vector3Int128(X, Y, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XXX() => new Vector3Int128(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XXY() => new Vector3Int128(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XXZ() => new Vector3Int128(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XXW() => new Vector3Int128(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYX() => new Vector3Int128(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYY() => new Vector3Int128(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYZ() => new Vector3Int128(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYW() => new Vector3Int128(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XZX() => new Vector3Int128(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XZY() => new Vector3Int128(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XZZ() => new Vector3Int128(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XZW() => new Vector3Int128(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XWX() => new Vector3Int128(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XWY() => new Vector3Int128(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XWZ() => new Vector3Int128(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XWW() => new Vector3Int128(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YXX() => new Vector3Int128(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YXY() => new Vector3Int128(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YXZ() => new Vector3Int128(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YXW() => new Vector3Int128(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YYX() => new Vector3Int128(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YYY() => new Vector3Int128(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YYZ() => new Vector3Int128(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YYW() => new Vector3Int128(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YZX() => new Vector3Int128(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YZY() => new Vector3Int128(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YZZ() => new Vector3Int128(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YZW() => new Vector3Int128(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YWX() => new Vector3Int128(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YWY() => new Vector3Int128(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YWZ() => new Vector3Int128(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YWW() => new Vector3Int128(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZXX() => new Vector3Int128(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZXY() => new Vector3Int128(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZXZ() => new Vector3Int128(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZXW() => new Vector3Int128(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZYX() => new Vector3Int128(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZYY() => new Vector3Int128(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZYZ() => new Vector3Int128(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZYW() => new Vector3Int128(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZZX() => new Vector3Int128(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZZY() => new Vector3Int128(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZZZ() => new Vector3Int128(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZZW() => new Vector3Int128(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZWX() => new Vector3Int128(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZWY() => new Vector3Int128(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZWZ() => new Vector3Int128(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZWW() => new Vector3Int128(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WXX() => new Vector3Int128(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WXY() => new Vector3Int128(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WXZ() => new Vector3Int128(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WXW() => new Vector3Int128(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WYX() => new Vector3Int128(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WYY() => new Vector3Int128(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WYZ() => new Vector3Int128(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WYW() => new Vector3Int128(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WZX() => new Vector3Int128(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WZY() => new Vector3Int128(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WZZ() => new Vector3Int128(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WZW() => new Vector3Int128(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WWX() => new Vector3Int128(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WWY() => new Vector3Int128(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WWZ() => new Vector3Int128(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 WWW() => new Vector3Int128(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYZ0() => new Vector3Int128(X, Y, Z, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYZ1() => new Vector3Int128(X, Y, Z, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXXX() => new Vector4Int128(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXXY() => new Vector4Int128(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXXZ() => new Vector4Int128(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXXW() => new Vector4Int128(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXYX() => new Vector4Int128(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXYY() => new Vector4Int128(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXYZ() => new Vector4Int128(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXYW() => new Vector4Int128(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXZX() => new Vector4Int128(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXZY() => new Vector4Int128(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXZZ() => new Vector4Int128(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXZW() => new Vector4Int128(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXWX() => new Vector4Int128(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXWY() => new Vector4Int128(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXWZ() => new Vector4Int128(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXWW() => new Vector4Int128(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYXX() => new Vector4Int128(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYXY() => new Vector4Int128(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYXZ() => new Vector4Int128(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYXW() => new Vector4Int128(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYYX() => new Vector4Int128(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYYY() => new Vector4Int128(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYYZ() => new Vector4Int128(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYYW() => new Vector4Int128(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYZX() => new Vector4Int128(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYZY() => new Vector4Int128(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYZZ() => new Vector4Int128(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYZW() => new Vector4Int128(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYWX() => new Vector4Int128(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYWY() => new Vector4Int128(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYWZ() => new Vector4Int128(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYWW() => new Vector4Int128(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZXX() => new Vector4Int128(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZXY() => new Vector4Int128(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZXZ() => new Vector4Int128(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZXW() => new Vector4Int128(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZYX() => new Vector4Int128(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZYY() => new Vector4Int128(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZYZ() => new Vector4Int128(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZYW() => new Vector4Int128(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZZX() => new Vector4Int128(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZZY() => new Vector4Int128(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZZZ() => new Vector4Int128(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZZW() => new Vector4Int128(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZWX() => new Vector4Int128(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZWY() => new Vector4Int128(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZWZ() => new Vector4Int128(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZWW() => new Vector4Int128(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWXX() => new Vector4Int128(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWXY() => new Vector4Int128(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWXZ() => new Vector4Int128(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWXW() => new Vector4Int128(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWYX() => new Vector4Int128(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWYY() => new Vector4Int128(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWYZ() => new Vector4Int128(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWYW() => new Vector4Int128(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWZX() => new Vector4Int128(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWZY() => new Vector4Int128(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWZZ() => new Vector4Int128(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWZW() => new Vector4Int128(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWWX() => new Vector4Int128(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWWY() => new Vector4Int128(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWWZ() => new Vector4Int128(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XWWW() => new Vector4Int128(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXXX() => new Vector4Int128(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXXY() => new Vector4Int128(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXXZ() => new Vector4Int128(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXXW() => new Vector4Int128(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXYX() => new Vector4Int128(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXYY() => new Vector4Int128(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXYZ() => new Vector4Int128(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXYW() => new Vector4Int128(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXZX() => new Vector4Int128(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXZY() => new Vector4Int128(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXZZ() => new Vector4Int128(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXZW() => new Vector4Int128(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXWX() => new Vector4Int128(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXWY() => new Vector4Int128(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXWZ() => new Vector4Int128(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXWW() => new Vector4Int128(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYXX() => new Vector4Int128(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYXY() => new Vector4Int128(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYXZ() => new Vector4Int128(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYXW() => new Vector4Int128(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYYX() => new Vector4Int128(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYYY() => new Vector4Int128(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYYZ() => new Vector4Int128(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYYW() => new Vector4Int128(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYZX() => new Vector4Int128(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYZY() => new Vector4Int128(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYZZ() => new Vector4Int128(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYZW() => new Vector4Int128(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYWX() => new Vector4Int128(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYWY() => new Vector4Int128(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYWZ() => new Vector4Int128(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYWW() => new Vector4Int128(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZXX() => new Vector4Int128(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZXY() => new Vector4Int128(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZXZ() => new Vector4Int128(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZXW() => new Vector4Int128(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZYX() => new Vector4Int128(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZYY() => new Vector4Int128(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZYZ() => new Vector4Int128(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZYW() => new Vector4Int128(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZZX() => new Vector4Int128(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZZY() => new Vector4Int128(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZZZ() => new Vector4Int128(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZZW() => new Vector4Int128(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZWX() => new Vector4Int128(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZWY() => new Vector4Int128(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZWZ() => new Vector4Int128(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZWW() => new Vector4Int128(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWXX() => new Vector4Int128(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWXY() => new Vector4Int128(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWXZ() => new Vector4Int128(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWXW() => new Vector4Int128(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWYX() => new Vector4Int128(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWYY() => new Vector4Int128(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWYZ() => new Vector4Int128(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWYW() => new Vector4Int128(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWZX() => new Vector4Int128(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWZY() => new Vector4Int128(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWZZ() => new Vector4Int128(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWZW() => new Vector4Int128(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWWX() => new Vector4Int128(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWWY() => new Vector4Int128(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWWZ() => new Vector4Int128(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YWWW() => new Vector4Int128(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXXX() => new Vector4Int128(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXXY() => new Vector4Int128(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXXZ() => new Vector4Int128(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXXW() => new Vector4Int128(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXYX() => new Vector4Int128(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXYY() => new Vector4Int128(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXYZ() => new Vector4Int128(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXYW() => new Vector4Int128(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXZX() => new Vector4Int128(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXZY() => new Vector4Int128(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXZZ() => new Vector4Int128(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXZW() => new Vector4Int128(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXWX() => new Vector4Int128(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXWY() => new Vector4Int128(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXWZ() => new Vector4Int128(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXWW() => new Vector4Int128(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYXX() => new Vector4Int128(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYXY() => new Vector4Int128(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYXZ() => new Vector4Int128(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYXW() => new Vector4Int128(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYYX() => new Vector4Int128(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYYY() => new Vector4Int128(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYYZ() => new Vector4Int128(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYYW() => new Vector4Int128(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYZX() => new Vector4Int128(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYZY() => new Vector4Int128(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYZZ() => new Vector4Int128(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYZW() => new Vector4Int128(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYWX() => new Vector4Int128(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYWY() => new Vector4Int128(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYWZ() => new Vector4Int128(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYWW() => new Vector4Int128(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZXX() => new Vector4Int128(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZXY() => new Vector4Int128(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZXZ() => new Vector4Int128(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZXW() => new Vector4Int128(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZYX() => new Vector4Int128(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZYY() => new Vector4Int128(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZYZ() => new Vector4Int128(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZYW() => new Vector4Int128(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZZX() => new Vector4Int128(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZZY() => new Vector4Int128(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZZZ() => new Vector4Int128(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZZW() => new Vector4Int128(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZWX() => new Vector4Int128(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZWY() => new Vector4Int128(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZWZ() => new Vector4Int128(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZWW() => new Vector4Int128(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWXX() => new Vector4Int128(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWXY() => new Vector4Int128(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWXZ() => new Vector4Int128(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWXW() => new Vector4Int128(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWYX() => new Vector4Int128(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWYY() => new Vector4Int128(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWYZ() => new Vector4Int128(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWYW() => new Vector4Int128(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWZX() => new Vector4Int128(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWZY() => new Vector4Int128(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWZZ() => new Vector4Int128(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWZW() => new Vector4Int128(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWWX() => new Vector4Int128(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWWY() => new Vector4Int128(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWWZ() => new Vector4Int128(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZWWW() => new Vector4Int128(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXXX() => new Vector4Int128(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXXY() => new Vector4Int128(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXXZ() => new Vector4Int128(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXXW() => new Vector4Int128(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXYX() => new Vector4Int128(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXYY() => new Vector4Int128(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXYZ() => new Vector4Int128(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXYW() => new Vector4Int128(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXZX() => new Vector4Int128(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXZY() => new Vector4Int128(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXZZ() => new Vector4Int128(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXZW() => new Vector4Int128(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXWX() => new Vector4Int128(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXWY() => new Vector4Int128(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXWZ() => new Vector4Int128(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WXWW() => new Vector4Int128(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYXX() => new Vector4Int128(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYXY() => new Vector4Int128(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYXZ() => new Vector4Int128(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYXW() => new Vector4Int128(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYYX() => new Vector4Int128(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYYY() => new Vector4Int128(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYYZ() => new Vector4Int128(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYYW() => new Vector4Int128(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYZX() => new Vector4Int128(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYZY() => new Vector4Int128(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYZZ() => new Vector4Int128(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYZW() => new Vector4Int128(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYWX() => new Vector4Int128(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYWY() => new Vector4Int128(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYWZ() => new Vector4Int128(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WYWW() => new Vector4Int128(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZXX() => new Vector4Int128(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZXY() => new Vector4Int128(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZXZ() => new Vector4Int128(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZXW() => new Vector4Int128(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZYX() => new Vector4Int128(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZYY() => new Vector4Int128(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZYZ() => new Vector4Int128(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZYW() => new Vector4Int128(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZZX() => new Vector4Int128(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZZY() => new Vector4Int128(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZZZ() => new Vector4Int128(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZZW() => new Vector4Int128(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZWX() => new Vector4Int128(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZWY() => new Vector4Int128(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZWZ() => new Vector4Int128(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WZWW() => new Vector4Int128(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWXX() => new Vector4Int128(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWXY() => new Vector4Int128(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWXZ() => new Vector4Int128(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWXW() => new Vector4Int128(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWYX() => new Vector4Int128(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWYY() => new Vector4Int128(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWYZ() => new Vector4Int128(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWYW() => new Vector4Int128(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWZX() => new Vector4Int128(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWZY() => new Vector4Int128(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWZZ() => new Vector4Int128(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWZW() => new Vector4Int128(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWWX() => new Vector4Int128(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWWY() => new Vector4Int128(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWWZ() => new Vector4Int128(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 WWWW() => new Vector4Int128(W, W, W, W);

        #endregion

    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
