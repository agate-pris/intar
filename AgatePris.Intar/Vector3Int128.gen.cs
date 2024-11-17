#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector3Int128 : IEquatable<Vector3Int128> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Int128 X;
        public Int128 Y;
        public Int128 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3Int128(Int128 x, Int128 y, Int128 z) {
            X = x;
            Y = y;
            Z = z;
        }

        public Int128 this[int index] {
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

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3Int128 left, Vector3Int128 right) {
            return new Vector3Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3Int128 left, Vector3Int128 right) {
            return new Vector3Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z);
        }

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3Int128 other) {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector3Int128 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        //
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int128 operator +(Vector3Int128 left, Vector3Int128 right) {
            return new Vector3Int128(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int128 operator -(Vector3Int128 left, Vector3Int128 right) {
            return new Vector3Int128(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int128 operator *(Vector3Int128 left, Vector3Int128 right) {
            return new Vector3Int128(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int128 operator /(Vector3Int128 left, Vector3Int128 right) {
            return new Vector3Int128(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int128 operator *(Vector3Int128 left, Int128 right) {
            return new Vector3Int128(left.X * right, left.Y * right, left.Z * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int128 operator *(Int128 left, Vector3Int128 right) {
            return new Vector3Int128(left * right.X, left * right.Y, left * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int128 operator /(Vector3Int128 left, Int128 right) {
            return new Vector3Int128(left.X / right, left.Y / right, left.Z / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int128 operator /(Int128 left, Vector3Int128 right) {
            return new Vector3Int128(left / right.X, left / right.Y, left / right.Z);
        }

        //
        // IUnaryPlusOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int128 operator +(Vector3Int128 x) {
            return new Vector3Int128(+x.X, +x.Y, +x.Z);
        }

        //
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int128 operator -(Vector3Int128 x) {
            return new Vector3Int128(-x.X, -x.Y, -x.Z);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int32(Vector3Int128 a) {
            return new Vector3Int32((int)a.X, (int)a.Y, (int)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt32(Vector3Int128 a) {
            return new Vector3UInt32((uint)a.X, (uint)a.Y, (uint)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int64(Vector3Int128 a) {
            return new Vector3Int64((long)a.X, (long)a.Y, (long)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt64(Vector3Int128 a) {
            return new Vector3UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt128(Vector3Int128 a) {
            return new Vector3UInt128((UInt128)a.X, (UInt128)a.Y, (UInt128)a.Z);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        //
        // Other methods
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int128 Abs() => new Vector3Int128(Int128.Abs(X), Int128.Abs(Y), Int128.Abs(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt128 UnsignedAbs() {
            return new Vector3UInt128(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y), Mathi.UnsignedAbs(Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int128 Min(Vector3Int128 other) {
            return new Vector3Int128(Int128.Min(X, other.X), Int128.Min(Y, other.Y), Int128.Min(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int128 Max(Vector3Int128 other) {
            return new Vector3Int128(Int128.Max(X, other.X), Int128.Max(Y, other.Y), Int128.Max(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int128 Clamp(Int128 min, Int128 max) {
            return new Vector3Int128(Int128.Clamp(X, min, max), Int128.Clamp(Y, min, max), Int128.Clamp(Z, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int128 Clamp(Vector3Int128 min, Vector3Int128 max) {
            return new Vector3Int128(Int128.Clamp(X, min.X, max.X), Int128.Clamp(Y, min.Y, max.Y), Int128.Clamp(Z, min.Z, max.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int128 Half() => new Vector3Int128(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int128 Twice() => new Vector3Int128(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z));

        //
        // Swizzling
        //

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 XX() => new Vector2Int128(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 XY() => new Vector2Int128(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 XZ() => new Vector2Int128(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 YX() => new Vector2Int128(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 YY() => new Vector2Int128(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 YZ() => new Vector2Int128(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 ZX() => new Vector2Int128(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 ZY() => new Vector2Int128(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 ZZ() => new Vector2Int128(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XXX() => new Vector3Int128(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XXY() => new Vector3Int128(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XXZ() => new Vector3Int128(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYX() => new Vector3Int128(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYY() => new Vector3Int128(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYZ() => new Vector3Int128(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XZX() => new Vector3Int128(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XZY() => new Vector3Int128(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XZZ() => new Vector3Int128(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YXX() => new Vector3Int128(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YXY() => new Vector3Int128(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YXZ() => new Vector3Int128(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YYX() => new Vector3Int128(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YYY() => new Vector3Int128(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YYZ() => new Vector3Int128(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YZX() => new Vector3Int128(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YZY() => new Vector3Int128(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YZZ() => new Vector3Int128(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZXX() => new Vector3Int128(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZXY() => new Vector3Int128(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZXZ() => new Vector3Int128(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZYX() => new Vector3Int128(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZYY() => new Vector3Int128(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZYZ() => new Vector3Int128(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZZX() => new Vector3Int128(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZZY() => new Vector3Int128(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 ZZZ() => new Vector3Int128(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXXX() => new Vector4Int128(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXXY() => new Vector4Int128(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXXZ() => new Vector4Int128(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXYX() => new Vector4Int128(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXYY() => new Vector4Int128(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXYZ() => new Vector4Int128(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXZX() => new Vector4Int128(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXZY() => new Vector4Int128(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXZZ() => new Vector4Int128(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYXX() => new Vector4Int128(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYXY() => new Vector4Int128(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYXZ() => new Vector4Int128(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYYX() => new Vector4Int128(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYYY() => new Vector4Int128(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYYZ() => new Vector4Int128(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYZX() => new Vector4Int128(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYZY() => new Vector4Int128(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYZZ() => new Vector4Int128(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZXX() => new Vector4Int128(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZXY() => new Vector4Int128(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZXZ() => new Vector4Int128(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZYX() => new Vector4Int128(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZYY() => new Vector4Int128(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZYZ() => new Vector4Int128(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZZX() => new Vector4Int128(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZZY() => new Vector4Int128(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XZZZ() => new Vector4Int128(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXXX() => new Vector4Int128(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXXY() => new Vector4Int128(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXXZ() => new Vector4Int128(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXYX() => new Vector4Int128(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXYY() => new Vector4Int128(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXYZ() => new Vector4Int128(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXZX() => new Vector4Int128(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXZY() => new Vector4Int128(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXZZ() => new Vector4Int128(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYXX() => new Vector4Int128(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYXY() => new Vector4Int128(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYXZ() => new Vector4Int128(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYYX() => new Vector4Int128(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYYY() => new Vector4Int128(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYYZ() => new Vector4Int128(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYZX() => new Vector4Int128(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYZY() => new Vector4Int128(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYZZ() => new Vector4Int128(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZXX() => new Vector4Int128(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZXY() => new Vector4Int128(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZXZ() => new Vector4Int128(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZYX() => new Vector4Int128(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZYY() => new Vector4Int128(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZYZ() => new Vector4Int128(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZZX() => new Vector4Int128(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZZY() => new Vector4Int128(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YZZZ() => new Vector4Int128(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXXX() => new Vector4Int128(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXXY() => new Vector4Int128(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXXZ() => new Vector4Int128(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXYX() => new Vector4Int128(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXYY() => new Vector4Int128(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXYZ() => new Vector4Int128(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXZX() => new Vector4Int128(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXZY() => new Vector4Int128(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZXZZ() => new Vector4Int128(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYXX() => new Vector4Int128(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYXY() => new Vector4Int128(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYXZ() => new Vector4Int128(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYYX() => new Vector4Int128(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYYY() => new Vector4Int128(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYYZ() => new Vector4Int128(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYZX() => new Vector4Int128(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYZY() => new Vector4Int128(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZYZZ() => new Vector4Int128(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZXX() => new Vector4Int128(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZXY() => new Vector4Int128(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZXZ() => new Vector4Int128(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZYX() => new Vector4Int128(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZYY() => new Vector4Int128(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZYZ() => new Vector4Int128(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZZX() => new Vector4Int128(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZZY() => new Vector4Int128(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 ZZZZ() => new Vector4Int128(Z, Z, Z, Z);

    }
}

#endif // NET7_0_OR_GREATER
