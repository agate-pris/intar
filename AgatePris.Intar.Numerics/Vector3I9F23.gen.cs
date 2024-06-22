using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct I9F23_3 : IEquatable<I9F23_3>, IFormattable {
        // Fields
        // ---------------------------------------

        public I9F23 x;
        public I9F23 y;
        public I9F23 z;

        // Constants
        // ---------------------------------------

        public static readonly I9F23_3 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I9F23_3(I9F23 x, I9F23 y, I9F23 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I9F23_3(I9F23 x, I9F23_2 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I9F23_3(I9F23_3 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I9F23_3(I9F23_2 xy, I9F23 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23_3 operator +(I9F23_3 a, I9F23_3 b) => new I9F23_3(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23_3 operator -(I9F23_3 a, I9F23_3 b) => new I9F23_3(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23_3 operator *(I9F23_3 a, I9F23_3 b) => new I9F23_3(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23_3 operator *(I9F23_3 a, I9F23 b) => new I9F23_3(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23_3 operator *(I9F23 a, I9F23_3 b) => new I9F23_3(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23_3 operator /(I9F23_3 a, I9F23_3 b) => new I9F23_3(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23_3 operator /(I9F23_3 a, I9F23 b) => new I9F23_3(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23_3 operator /(I9F23 a, I9F23_3 b) => new I9F23_3(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

        public readonly I9F23_2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_2(x, x); }
        public readonly I9F23_2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_2(x, y); }
        public readonly I9F23_2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_2(x, z); }
        public readonly I9F23_2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_2(y, x); }
        public readonly I9F23_2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_2(y, y); }
        public readonly I9F23_2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_2(y, z); }
        public readonly I9F23_2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_2(z, x); }
        public readonly I9F23_2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_2(z, y); }
        public readonly I9F23_2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_2(z, z); }
        public readonly I9F23_3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(x, x, x); }
        public readonly I9F23_3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(x, x, y); }
        public readonly I9F23_3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(x, x, z); }
        public readonly I9F23_3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(x, y, x); }
        public readonly I9F23_3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(x, y, y); }
        public readonly I9F23_3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(x, y, z); }
        public readonly I9F23_3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(x, z, x); }
        public readonly I9F23_3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(x, z, y); }
        public readonly I9F23_3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(x, z, z); }
        public readonly I9F23_3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(y, x, x); }
        public readonly I9F23_3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(y, x, y); }
        public readonly I9F23_3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(y, x, z); }
        public readonly I9F23_3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(y, y, x); }
        public readonly I9F23_3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(y, y, y); }
        public readonly I9F23_3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(y, y, z); }
        public readonly I9F23_3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(y, z, x); }
        public readonly I9F23_3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(y, z, y); }
        public readonly I9F23_3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(y, z, z); }
        public readonly I9F23_3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(z, x, x); }
        public readonly I9F23_3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(z, x, y); }
        public readonly I9F23_3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(z, x, z); }
        public readonly I9F23_3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(z, y, x); }
        public readonly I9F23_3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(z, y, y); }
        public readonly I9F23_3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(z, y, z); }
        public readonly I9F23_3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(z, z, x); }
        public readonly I9F23_3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(z, z, y); }
        public readonly I9F23_3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_3(z, z, z); }
        public readonly I9F23_4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, x, x, x); }
        public readonly I9F23_4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, x, x, y); }
        public readonly I9F23_4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, x, x, z); }
        public readonly I9F23_4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, x, y, x); }
        public readonly I9F23_4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, x, y, y); }
        public readonly I9F23_4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, x, y, z); }
        public readonly I9F23_4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, x, z, x); }
        public readonly I9F23_4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, x, z, y); }
        public readonly I9F23_4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, x, z, z); }
        public readonly I9F23_4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, y, x, x); }
        public readonly I9F23_4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, y, x, y); }
        public readonly I9F23_4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, y, x, z); }
        public readonly I9F23_4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, y, y, x); }
        public readonly I9F23_4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, y, y, y); }
        public readonly I9F23_4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, y, y, z); }
        public readonly I9F23_4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, y, z, x); }
        public readonly I9F23_4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, y, z, y); }
        public readonly I9F23_4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, y, z, z); }
        public readonly I9F23_4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, z, x, x); }
        public readonly I9F23_4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, z, x, y); }
        public readonly I9F23_4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, z, x, z); }
        public readonly I9F23_4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, z, y, x); }
        public readonly I9F23_4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, z, y, y); }
        public readonly I9F23_4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, z, y, z); }
        public readonly I9F23_4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, z, z, x); }
        public readonly I9F23_4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, z, z, y); }
        public readonly I9F23_4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(x, z, z, z); }
        public readonly I9F23_4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, x, x, x); }
        public readonly I9F23_4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, x, x, y); }
        public readonly I9F23_4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, x, x, z); }
        public readonly I9F23_4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, x, y, x); }
        public readonly I9F23_4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, x, y, y); }
        public readonly I9F23_4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, x, y, z); }
        public readonly I9F23_4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, x, z, x); }
        public readonly I9F23_4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, x, z, y); }
        public readonly I9F23_4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, x, z, z); }
        public readonly I9F23_4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, y, x, x); }
        public readonly I9F23_4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, y, x, y); }
        public readonly I9F23_4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, y, x, z); }
        public readonly I9F23_4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, y, y, x); }
        public readonly I9F23_4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, y, y, y); }
        public readonly I9F23_4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, y, y, z); }
        public readonly I9F23_4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, y, z, x); }
        public readonly I9F23_4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, y, z, y); }
        public readonly I9F23_4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, y, z, z); }
        public readonly I9F23_4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, z, x, x); }
        public readonly I9F23_4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, z, x, y); }
        public readonly I9F23_4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, z, x, z); }
        public readonly I9F23_4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, z, y, x); }
        public readonly I9F23_4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, z, y, y); }
        public readonly I9F23_4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, z, y, z); }
        public readonly I9F23_4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, z, z, x); }
        public readonly I9F23_4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, z, z, y); }
        public readonly I9F23_4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(y, z, z, z); }
        public readonly I9F23_4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, x, x, x); }
        public readonly I9F23_4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, x, x, y); }
        public readonly I9F23_4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, x, x, z); }
        public readonly I9F23_4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, x, y, x); }
        public readonly I9F23_4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, x, y, y); }
        public readonly I9F23_4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, x, y, z); }
        public readonly I9F23_4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, x, z, x); }
        public readonly I9F23_4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, x, z, y); }
        public readonly I9F23_4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, x, z, z); }
        public readonly I9F23_4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, y, x, x); }
        public readonly I9F23_4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, y, x, y); }
        public readonly I9F23_4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, y, x, z); }
        public readonly I9F23_4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, y, y, x); }
        public readonly I9F23_4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, y, y, y); }
        public readonly I9F23_4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, y, y, z); }
        public readonly I9F23_4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, y, z, x); }
        public readonly I9F23_4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, y, z, y); }
        public readonly I9F23_4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, y, z, z); }
        public readonly I9F23_4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, z, x, x); }
        public readonly I9F23_4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, z, x, y); }
        public readonly I9F23_4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, z, x, z); }
        public readonly I9F23_4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, z, y, x); }
        public readonly I9F23_4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, z, y, y); }
        public readonly I9F23_4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, z, y, z); }
        public readonly I9F23_4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, z, z, x); }
        public readonly I9F23_4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, z, z, y); }
        public readonly I9F23_4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I9F23_4(z, z, z, z); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I9F23_3 lhs, I9F23_3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I9F23_3 lhs, I9F23_3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I9F23_3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"I9F23_3({x}, {y}, {z})";

        // IEquatable<I9F23_3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I9F23_3 other)
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
            return $"I9F23_3({x}, {y}, {z})";
        }
    }
}
