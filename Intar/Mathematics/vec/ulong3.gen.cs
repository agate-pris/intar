using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]

#pragma warning disable IDE1006 // 命名スタイル

    public struct ulong3 : IEquatable<ulong3>, IFormattable {

#pragma warning restore IDE1006 // 命名スタイル

        // Fields
        // ---------------------------------------

        public ulong x;
        public ulong y;
        public ulong z;

        // Constants
        // ---------------------------------------

        public static readonly ulong3 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong x, ulong y, ulong z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong x, ulong2 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong3 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong2 xy, ulong z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator +(ulong3 a, ulong3 b) => new ulong3(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator -(ulong3 a, ulong3 b) => new ulong3(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator *(ulong3 a, ulong3 b) => new ulong3(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator *(ulong3 a, ulong b) => new ulong3(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator *(ulong a, ulong3 b) => new ulong3(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator /(ulong3 a, ulong3 b) => new ulong3(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator /(ulong3 a, ulong b) => new ulong3(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator /(ulong a, ulong3 b) => new ulong3(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly ulong2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(x, x); }
        public readonly ulong2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(x, y); }
        public readonly ulong2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(x, z); }
        public readonly ulong2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(y, x); }
        public readonly ulong2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(y, y); }
        public readonly ulong2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(y, z); }
        public readonly ulong2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(z, x); }
        public readonly ulong2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(z, y); }
        public readonly ulong2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(z, z); }
        public readonly ulong3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, x, x); }
        public readonly ulong3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, x, y); }
        public readonly ulong3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, x, z); }
        public readonly ulong3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, y, x); }
        public readonly ulong3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, y, y); }
        public readonly ulong3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, y, z); }
        public readonly ulong3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, z, x); }
        public readonly ulong3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, z, y); }
        public readonly ulong3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, z, z); }
        public readonly ulong3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, x, x); }
        public readonly ulong3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, x, y); }
        public readonly ulong3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, x, z); }
        public readonly ulong3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, y, x); }
        public readonly ulong3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, y, y); }
        public readonly ulong3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, y, z); }
        public readonly ulong3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, z, x); }
        public readonly ulong3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, z, y); }
        public readonly ulong3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, z, z); }
        public readonly ulong3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, x, x); }
        public readonly ulong3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, x, y); }
        public readonly ulong3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, x, z); }
        public readonly ulong3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, y, x); }
        public readonly ulong3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, y, y); }
        public readonly ulong3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, y, z); }
        public readonly ulong3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, z, x); }
        public readonly ulong3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, z, y); }
        public readonly ulong3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, z, z); }
        public readonly ulong4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, x, x); }
        public readonly ulong4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, x, y); }
        public readonly ulong4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, x, z); }
        public readonly ulong4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, y, x); }
        public readonly ulong4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, y, y); }
        public readonly ulong4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, y, z); }
        public readonly ulong4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, z, x); }
        public readonly ulong4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, z, y); }
        public readonly ulong4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, z, z); }
        public readonly ulong4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, x, x); }
        public readonly ulong4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, x, y); }
        public readonly ulong4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, x, z); }
        public readonly ulong4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, y, x); }
        public readonly ulong4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, y, y); }
        public readonly ulong4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, y, z); }
        public readonly ulong4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, z, x); }
        public readonly ulong4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, z, y); }
        public readonly ulong4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, z, z); }
        public readonly ulong4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, x, x); }
        public readonly ulong4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, x, y); }
        public readonly ulong4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, x, z); }
        public readonly ulong4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, y, x); }
        public readonly ulong4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, y, y); }
        public readonly ulong4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, y, z); }
        public readonly ulong4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, z, x); }
        public readonly ulong4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, z, y); }
        public readonly ulong4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, z, z); }
        public readonly ulong4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, x, x); }
        public readonly ulong4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, x, y); }
        public readonly ulong4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, x, z); }
        public readonly ulong4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, y, x); }
        public readonly ulong4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, y, y); }
        public readonly ulong4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, y, z); }
        public readonly ulong4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, z, x); }
        public readonly ulong4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, z, y); }
        public readonly ulong4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, z, z); }
        public readonly ulong4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, x, x); }
        public readonly ulong4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, x, y); }
        public readonly ulong4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, x, z); }
        public readonly ulong4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, y, x); }
        public readonly ulong4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, y, y); }
        public readonly ulong4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, y, z); }
        public readonly ulong4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, z, x); }
        public readonly ulong4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, z, y); }
        public readonly ulong4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, z, z); }
        public readonly ulong4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, x, x); }
        public readonly ulong4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, x, y); }
        public readonly ulong4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, x, z); }
        public readonly ulong4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, y, x); }
        public readonly ulong4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, y, y); }
        public readonly ulong4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, y, z); }
        public readonly ulong4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, z, x); }
        public readonly ulong4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, z, y); }
        public readonly ulong4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, z, z); }
        public readonly ulong4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, x, x); }
        public readonly ulong4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, x, y); }
        public readonly ulong4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, x, z); }
        public readonly ulong4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, y, x); }
        public readonly ulong4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, y, y); }
        public readonly ulong4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, y, z); }
        public readonly ulong4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, z, x); }
        public readonly ulong4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, z, y); }
        public readonly ulong4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, z, z); }
        public readonly ulong4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, x, x); }
        public readonly ulong4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, x, y); }
        public readonly ulong4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, x, z); }
        public readonly ulong4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, y, x); }
        public readonly ulong4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, y, y); }
        public readonly ulong4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, y, z); }
        public readonly ulong4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, z, x); }
        public readonly ulong4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, z, y); }
        public readonly ulong4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, z, z); }
        public readonly ulong4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, x, x); }
        public readonly ulong4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, x, y); }
        public readonly ulong4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, x, z); }
        public readonly ulong4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, y, x); }
        public readonly ulong4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, y, y); }
        public readonly ulong4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, y, z); }
        public readonly ulong4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, z, x); }
        public readonly ulong4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, z, y); }
        public readonly ulong4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(ulong3 lhs, ulong3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(ulong3 lhs, ulong3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is ulong3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"ulong3({x}, {y}, {z})";

        // IEquatable<ulong3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(ulong3 rhs)
            => rhs.x == x
            && rhs.y == y
            && rhs.z == z;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            var z = this.z.ToString(format, formatProvider);
            return $"ulong3({x}, {y}, {z})";
        }
    }
}
