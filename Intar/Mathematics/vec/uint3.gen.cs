#if !UNITY_2018_3_OR_NEWER

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct uint3 : IEquatable<uint3>, IFormattable {
        // Fields
        // ---------------------------------------

        public uint x;
        public uint y;
        public uint z;

        // Constants
        // ---------------------------------------

        public static readonly uint3 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint x, uint y, uint z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint x, uint2 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint3 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint2 xy, uint z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator +(uint3 a, uint3 b) => new uint3(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator -(uint3 a, uint3 b) => new uint3(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator *(uint3 a, uint3 b) => new uint3(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator *(uint3 a, uint b) => new uint3(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator *(uint a, uint3 b) => new uint3(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator /(uint3 a, uint3 b) => new uint3(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator /(uint3 a, uint b) => new uint3(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 operator /(uint a, uint3 b) => new uint3(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

        public readonly uint2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(x, x); }
        public readonly uint2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(x, y); }
        public readonly uint2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(x, z); }
        public readonly uint2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(y, x); }
        public readonly uint2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(y, y); }
        public readonly uint2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(y, z); }
        public readonly uint2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(z, x); }
        public readonly uint2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(z, y); }
        public readonly uint2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(z, z); }
        public readonly uint3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, x, x); }
        public readonly uint3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, x, y); }
        public readonly uint3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, x, z); }
        public readonly uint3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, y, x); }
        public readonly uint3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, y, y); }
        public readonly uint3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, y, z); }
        public readonly uint3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, z, x); }
        public readonly uint3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, z, y); }
        public readonly uint3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, z, z); }
        public readonly uint3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, x, x); }
        public readonly uint3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, x, y); }
        public readonly uint3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, x, z); }
        public readonly uint3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, y, x); }
        public readonly uint3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, y, y); }
        public readonly uint3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, y, z); }
        public readonly uint3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, z, x); }
        public readonly uint3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, z, y); }
        public readonly uint3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, z, z); }
        public readonly uint3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(z, x, x); }
        public readonly uint3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(z, x, y); }
        public readonly uint3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(z, x, z); }
        public readonly uint3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(z, y, x); }
        public readonly uint3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(z, y, y); }
        public readonly uint3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(z, y, z); }
        public readonly uint3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(z, z, x); }
        public readonly uint3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(z, z, y); }
        public readonly uint3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(z, z, z); }
        public readonly uint4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, x, x); }
        public readonly uint4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, x, y); }
        public readonly uint4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, x, z); }
        public readonly uint4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, y, x); }
        public readonly uint4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, y, y); }
        public readonly uint4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, y, z); }
        public readonly uint4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, z, x); }
        public readonly uint4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, z, y); }
        public readonly uint4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, z, z); }
        public readonly uint4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, x, x); }
        public readonly uint4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, x, y); }
        public readonly uint4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, x, z); }
        public readonly uint4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, y, x); }
        public readonly uint4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, y, y); }
        public readonly uint4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, y, z); }
        public readonly uint4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, z, x); }
        public readonly uint4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, z, y); }
        public readonly uint4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, z, z); }
        public readonly uint4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, z, x, x); }
        public readonly uint4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, z, x, y); }
        public readonly uint4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, z, x, z); }
        public readonly uint4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, z, y, x); }
        public readonly uint4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, z, y, y); }
        public readonly uint4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, z, y, z); }
        public readonly uint4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, z, z, x); }
        public readonly uint4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, z, z, y); }
        public readonly uint4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, z, z, z); }
        public readonly uint4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, x, x); }
        public readonly uint4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, x, y); }
        public readonly uint4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, x, z); }
        public readonly uint4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, y, x); }
        public readonly uint4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, y, y); }
        public readonly uint4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, y, z); }
        public readonly uint4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, z, x); }
        public readonly uint4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, z, y); }
        public readonly uint4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, z, z); }
        public readonly uint4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, x, x); }
        public readonly uint4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, x, y); }
        public readonly uint4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, x, z); }
        public readonly uint4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, y, x); }
        public readonly uint4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, y, y); }
        public readonly uint4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, y, z); }
        public readonly uint4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, z, x); }
        public readonly uint4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, z, y); }
        public readonly uint4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, z, z); }
        public readonly uint4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, z, x, x); }
        public readonly uint4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, z, x, y); }
        public readonly uint4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, z, x, z); }
        public readonly uint4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, z, y, x); }
        public readonly uint4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, z, y, y); }
        public readonly uint4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, z, y, z); }
        public readonly uint4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, z, z, x); }
        public readonly uint4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, z, z, y); }
        public readonly uint4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, z, z, z); }
        public readonly uint4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, x, x, x); }
        public readonly uint4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, x, x, y); }
        public readonly uint4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, x, x, z); }
        public readonly uint4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, x, y, x); }
        public readonly uint4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, x, y, y); }
        public readonly uint4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, x, y, z); }
        public readonly uint4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, x, z, x); }
        public readonly uint4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, x, z, y); }
        public readonly uint4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, x, z, z); }
        public readonly uint4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, y, x, x); }
        public readonly uint4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, y, x, y); }
        public readonly uint4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, y, x, z); }
        public readonly uint4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, y, y, x); }
        public readonly uint4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, y, y, y); }
        public readonly uint4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, y, y, z); }
        public readonly uint4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, y, z, x); }
        public readonly uint4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, y, z, y); }
        public readonly uint4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, y, z, z); }
        public readonly uint4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, z, x, x); }
        public readonly uint4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, z, x, y); }
        public readonly uint4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, z, x, z); }
        public readonly uint4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, z, y, x); }
        public readonly uint4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, z, y, y); }
        public readonly uint4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, z, y, z); }
        public readonly uint4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, z, z, x); }
        public readonly uint4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, z, z, y); }
        public readonly uint4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(z, z, z, z); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(uint3 lhs, uint3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(uint3 lhs, uint3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is uint3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"uint3({x}, {y}, {z})";

        // IEquatable<uint3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(uint3 other)
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
            return $"uint3({x}, {y}, {z})";
        }
    }

    public static partial class math {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 uint3(uint x, uint y, uint z) => new uint3(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 uint3(uint x, uint2 yz) => new uint3(x, yz);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 uint3(uint3 xyz) => new uint3(xyz);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 uint3(uint2 xy, uint z) => new uint3(xy, z);
    }
}

#endif
