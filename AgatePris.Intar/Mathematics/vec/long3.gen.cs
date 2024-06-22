using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct long3 : IEquatable<long3>, IFormattable {
        // Fields
        // ---------------------------------------

        public long x;
        public long y;
        public long z;

        // Constants
        // ---------------------------------------

        public static readonly long3 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(long x, long y, long z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(long x, long2 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(long3 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(long2 xy, long z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator +(long3 a, long3 b) => new long3(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator -(long3 a, long3 b) => new long3(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator *(long3 a, long3 b) => new long3(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator *(long3 a, long b) => new long3(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator *(long a, long3 b) => new long3(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator /(long3 a, long3 b) => new long3(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator /(long3 a, long b) => new long3(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator /(long a, long3 b) => new long3(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

        public readonly long2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(x, x); }
        public readonly long2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(x, y); }
        public readonly long2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(x, z); }
        public readonly long2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(y, x); }
        public readonly long2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(y, y); }
        public readonly long2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(y, z); }
        public readonly long2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(z, x); }
        public readonly long2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(z, y); }
        public readonly long2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(z, z); }
        public readonly long3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, x, x); }
        public readonly long3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, x, y); }
        public readonly long3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, x, z); }
        public readonly long3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, y, x); }
        public readonly long3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, y, y); }
        public readonly long3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, y, z); }
        public readonly long3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, z, x); }
        public readonly long3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, z, y); }
        public readonly long3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, z, z); }
        public readonly long3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, x, x); }
        public readonly long3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, x, y); }
        public readonly long3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, x, z); }
        public readonly long3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, y, x); }
        public readonly long3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, y, y); }
        public readonly long3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, y, z); }
        public readonly long3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, z, x); }
        public readonly long3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, z, y); }
        public readonly long3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, z, z); }
        public readonly long3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, x, x); }
        public readonly long3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, x, y); }
        public readonly long3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, x, z); }
        public readonly long3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, y, x); }
        public readonly long3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, y, y); }
        public readonly long3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, y, z); }
        public readonly long3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, z, x); }
        public readonly long3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, z, y); }
        public readonly long3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, z, z); }
        public readonly long4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, x, x); }
        public readonly long4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, x, y); }
        public readonly long4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, x, z); }
        public readonly long4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, y, x); }
        public readonly long4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, y, y); }
        public readonly long4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, y, z); }
        public readonly long4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, z, x); }
        public readonly long4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, z, y); }
        public readonly long4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, z, z); }
        public readonly long4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, x, x); }
        public readonly long4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, x, y); }
        public readonly long4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, x, z); }
        public readonly long4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, y, x); }
        public readonly long4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, y, y); }
        public readonly long4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, y, z); }
        public readonly long4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, z, x); }
        public readonly long4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, z, y); }
        public readonly long4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, z, z); }
        public readonly long4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, x, x); }
        public readonly long4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, x, y); }
        public readonly long4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, x, z); }
        public readonly long4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, y, x); }
        public readonly long4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, y, y); }
        public readonly long4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, y, z); }
        public readonly long4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, z, x); }
        public readonly long4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, z, y); }
        public readonly long4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, z, z); }
        public readonly long4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, x, x); }
        public readonly long4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, x, y); }
        public readonly long4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, x, z); }
        public readonly long4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, y, x); }
        public readonly long4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, y, y); }
        public readonly long4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, y, z); }
        public readonly long4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, z, x); }
        public readonly long4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, z, y); }
        public readonly long4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, z, z); }
        public readonly long4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, x, x); }
        public readonly long4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, x, y); }
        public readonly long4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, x, z); }
        public readonly long4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, y, x); }
        public readonly long4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, y, y); }
        public readonly long4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, y, z); }
        public readonly long4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, z, x); }
        public readonly long4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, z, y); }
        public readonly long4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, z, z); }
        public readonly long4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, x, x); }
        public readonly long4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, x, y); }
        public readonly long4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, x, z); }
        public readonly long4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, y, x); }
        public readonly long4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, y, y); }
        public readonly long4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, y, z); }
        public readonly long4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, z, x); }
        public readonly long4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, z, y); }
        public readonly long4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, z, z); }
        public readonly long4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, x, x); }
        public readonly long4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, x, y); }
        public readonly long4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, x, z); }
        public readonly long4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, y, x); }
        public readonly long4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, y, y); }
        public readonly long4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, y, z); }
        public readonly long4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, z, x); }
        public readonly long4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, z, y); }
        public readonly long4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, z, z); }
        public readonly long4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, x, x); }
        public readonly long4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, x, y); }
        public readonly long4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, x, z); }
        public readonly long4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, y, x); }
        public readonly long4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, y, y); }
        public readonly long4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, y, z); }
        public readonly long4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, z, x); }
        public readonly long4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, z, y); }
        public readonly long4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, z, z); }
        public readonly long4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, x, x); }
        public readonly long4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, x, y); }
        public readonly long4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, x, z); }
        public readonly long4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, y, x); }
        public readonly long4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, y, y); }
        public readonly long4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, y, z); }
        public readonly long4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, z, x); }
        public readonly long4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, z, y); }
        public readonly long4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, z, z); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(long3 lhs, long3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(long3 lhs, long3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is long3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"long3({x}, {y}, {z})";

        // IEquatable<long3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(long3 other)
            => other.x == x
            && other.y == y
            && other.z == z;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            var z = this.z.ToString(format, formatProvider);
            return $"long3({x}, {y}, {z})";
        }
    }

    public static partial class math {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(long x, long y, long z) => new long3(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(long x, long2 yz) => new long3(x, yz);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(long3 xyz) => new long3(xyz);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(long2 xy, long z) => new long3(xy, z);
    }
}
