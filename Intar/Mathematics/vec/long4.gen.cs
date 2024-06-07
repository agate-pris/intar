using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]

#pragma warning disable IDE1006 // 命名スタイル

    public struct long4 : IEquatable<long4>, IFormattable {

#pragma warning restore IDE1006 // 命名スタイル

        // Fields
        // ---------------------------------------

        public long x;
        public long y;
        public long z;
        public long w;

        // Constants
        // ---------------------------------------

        public static readonly long4 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long x, long y, long z, long w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long x, long y, long2 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long x, long3 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long2 xy, long2 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long4 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long x, long2 yz, long w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long3 xyz, long w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long2 xy, long z, long w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator +(long4 a, long4 b) => new long4(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator -(long4 a, long4 b) => new long4(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator *(long4 a, long4 b) => new long4(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator *(long4 a, long b) => new long4(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator *(long a, long4 b) => new long4(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator /(long4 a, long4 b) => new long4(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator /(long4 a, long b) => new long4(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator /(long a, long4 b) => new long4(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly long2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(x, x); }
        public readonly long2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(x, y); }
        public readonly long2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(y, x); }
        public readonly long2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(y, y); }
        public readonly long2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(x, z); }
        public readonly long2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(y, z); }
        public readonly long2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(z, x); }
        public readonly long2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(z, y); }
        public readonly long2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(z, z); }
        public readonly long2 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(x, w); }
        public readonly long2 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(y, w); }
        public readonly long2 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(z, w); }
        public readonly long2 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(w, x); }
        public readonly long2 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(w, y); }
        public readonly long2 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(w, z); }
        public readonly long2 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(w, w); }
        public readonly long3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, x, x); }
        public readonly long3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, x, y); }
        public readonly long3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, y, x); }
        public readonly long3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, y, y); }
        public readonly long3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, x, x); }
        public readonly long3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, x, y); }
        public readonly long3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, y, x); }
        public readonly long3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, y, y); }
        public readonly long3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, x, z); }
        public readonly long3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, y, z); }
        public readonly long3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, z, x); }
        public readonly long3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, z, y); }
        public readonly long3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, z, z); }
        public readonly long3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, x, z); }
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
        public readonly long3 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, x, w); }
        public readonly long3 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, y, w); }
        public readonly long3 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, z, w); }
        public readonly long3 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, w, x); }
        public readonly long3 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, w, y); }
        public readonly long3 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, w, z); }
        public readonly long3 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, w, w); }
        public readonly long3 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, x, w); }
        public readonly long3 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, y, w); }
        public readonly long3 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, z, w); }
        public readonly long3 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, w, x); }
        public readonly long3 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, w, y); }
        public readonly long3 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, w, z); }
        public readonly long3 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, w, w); }
        public readonly long3 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, x, w); }
        public readonly long3 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, y, w); }
        public readonly long3 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, z, w); }
        public readonly long3 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, w, x); }
        public readonly long3 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, w, y); }
        public readonly long3 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, w, z); }
        public readonly long3 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(z, w, w); }
        public readonly long3 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, x, x); }
        public readonly long3 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, x, y); }
        public readonly long3 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, x, z); }
        public readonly long3 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, x, w); }
        public readonly long3 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, y, x); }
        public readonly long3 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, y, y); }
        public readonly long3 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, y, z); }
        public readonly long3 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, y, w); }
        public readonly long3 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, z, x); }
        public readonly long3 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, z, y); }
        public readonly long3 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, z, z); }
        public readonly long3 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, z, w); }
        public readonly long3 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, w, x); }
        public readonly long3 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, w, y); }
        public readonly long3 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, w, z); }
        public readonly long3 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(w, w, w); }
        public readonly long4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, x, x); }
        public readonly long4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, x, y); }
        public readonly long4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, y, x); }
        public readonly long4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, y, y); }
        public readonly long4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, x, x); }
        public readonly long4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, x, y); }
        public readonly long4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, y, x); }
        public readonly long4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, y, y); }
        public readonly long4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, x, x); }
        public readonly long4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, x, y); }
        public readonly long4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, y, x); }
        public readonly long4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, y, y); }
        public readonly long4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, x, x); }
        public readonly long4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, x, y); }
        public readonly long4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, y, x); }
        public readonly long4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, y, y); }
        public readonly long4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, x, z); }
        public readonly long4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, y, z); }
        public readonly long4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, z, x); }
        public readonly long4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, z, y); }
        public readonly long4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, z, z); }
        public readonly long4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, x, z); }
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
        public readonly long4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, x, z); }
        public readonly long4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, y, z); }
        public readonly long4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, z, x); }
        public readonly long4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, z, y); }
        public readonly long4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, z, z); }
        public readonly long4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, x, z); }
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
        public readonly long4 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, x, w); }
        public readonly long4 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, y, w); }
        public readonly long4 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, z, w); }
        public readonly long4 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, w, x); }
        public readonly long4 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, w, y); }
        public readonly long4 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, w, z); }
        public readonly long4 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, w, w); }
        public readonly long4 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, x, w); }
        public readonly long4 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, y, w); }
        public readonly long4 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, z, w); }
        public readonly long4 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, w, x); }
        public readonly long4 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, w, y); }
        public readonly long4 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, w, z); }
        public readonly long4 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, w, w); }
        public readonly long4 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, x, w); }
        public readonly long4 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, y, w); }
        public readonly long4 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, z, w); }
        public readonly long4 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, w, x); }
        public readonly long4 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, w, y); }
        public readonly long4 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, w, z); }
        public readonly long4 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, z, w, w); }
        public readonly long4 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, x, x); }
        public readonly long4 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, x, y); }
        public readonly long4 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, x, z); }
        public readonly long4 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, x, w); }
        public readonly long4 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, y, x); }
        public readonly long4 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, y, y); }
        public readonly long4 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, y, z); }
        public readonly long4 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, y, w); }
        public readonly long4 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, z, x); }
        public readonly long4 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, z, y); }
        public readonly long4 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, z, z); }
        public readonly long4 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, z, w); }
        public readonly long4 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, w, x); }
        public readonly long4 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, w, y); }
        public readonly long4 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, w, z); }
        public readonly long4 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, w, w, w); }
        public readonly long4 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, x, w); }
        public readonly long4 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, y, w); }
        public readonly long4 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, z, w); }
        public readonly long4 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, w, x); }
        public readonly long4 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, w, y); }
        public readonly long4 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, w, z); }
        public readonly long4 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, w, w); }
        public readonly long4 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, x, w); }
        public readonly long4 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, y, w); }
        public readonly long4 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, z, w); }
        public readonly long4 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, w, x); }
        public readonly long4 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, w, y); }
        public readonly long4 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, w, z); }
        public readonly long4 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, w, w); }
        public readonly long4 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, x, w); }
        public readonly long4 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, y, w); }
        public readonly long4 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, z, w); }
        public readonly long4 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, w, x); }
        public readonly long4 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, w, y); }
        public readonly long4 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, w, z); }
        public readonly long4 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, z, w, w); }
        public readonly long4 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, x, x); }
        public readonly long4 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, x, y); }
        public readonly long4 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, x, z); }
        public readonly long4 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, x, w); }
        public readonly long4 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, y, x); }
        public readonly long4 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, y, y); }
        public readonly long4 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, y, z); }
        public readonly long4 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, y, w); }
        public readonly long4 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, z, x); }
        public readonly long4 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, z, y); }
        public readonly long4 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, z, z); }
        public readonly long4 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, z, w); }
        public readonly long4 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, w, x); }
        public readonly long4 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, w, y); }
        public readonly long4 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, w, z); }
        public readonly long4 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, w, w, w); }
        public readonly long4 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, x, w); }
        public readonly long4 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, y, w); }
        public readonly long4 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, z, w); }
        public readonly long4 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, w, x); }
        public readonly long4 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, w, y); }
        public readonly long4 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, w, z); }
        public readonly long4 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, x, w, w); }
        public readonly long4 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, x, w); }
        public readonly long4 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, y, w); }
        public readonly long4 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, z, w); }
        public readonly long4 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, w, x); }
        public readonly long4 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, w, y); }
        public readonly long4 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, w, z); }
        public readonly long4 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, y, w, w); }
        public readonly long4 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, x, w); }
        public readonly long4 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, y, w); }
        public readonly long4 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, z, w); }
        public readonly long4 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, w, x); }
        public readonly long4 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, w, y); }
        public readonly long4 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, w, z); }
        public readonly long4 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, z, w, w); }
        public readonly long4 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, x, x); }
        public readonly long4 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, x, y); }
        public readonly long4 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, x, z); }
        public readonly long4 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, x, w); }
        public readonly long4 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, y, x); }
        public readonly long4 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, y, y); }
        public readonly long4 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, y, z); }
        public readonly long4 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, y, w); }
        public readonly long4 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, z, x); }
        public readonly long4 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, z, y); }
        public readonly long4 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, z, z); }
        public readonly long4 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, z, w); }
        public readonly long4 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, w, x); }
        public readonly long4 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, w, y); }
        public readonly long4 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, w, z); }
        public readonly long4 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(z, w, w, w); }
        public readonly long4 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, x, x); }
        public readonly long4 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, x, y); }
        public readonly long4 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, x, z); }
        public readonly long4 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, x, w); }
        public readonly long4 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, y, x); }
        public readonly long4 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, y, y); }
        public readonly long4 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, y, z); }
        public readonly long4 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, y, w); }
        public readonly long4 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, z, x); }
        public readonly long4 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, z, y); }
        public readonly long4 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, z, z); }
        public readonly long4 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, z, w); }
        public readonly long4 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, w, x); }
        public readonly long4 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, w, y); }
        public readonly long4 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, w, z); }
        public readonly long4 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, x, w, w); }
        public readonly long4 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, x, x); }
        public readonly long4 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, x, y); }
        public readonly long4 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, x, z); }
        public readonly long4 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, x, w); }
        public readonly long4 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, y, x); }
        public readonly long4 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, y, y); }
        public readonly long4 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, y, z); }
        public readonly long4 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, y, w); }
        public readonly long4 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, z, x); }
        public readonly long4 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, z, y); }
        public readonly long4 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, z, z); }
        public readonly long4 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, z, w); }
        public readonly long4 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, w, x); }
        public readonly long4 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, w, y); }
        public readonly long4 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, w, z); }
        public readonly long4 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, y, w, w); }
        public readonly long4 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, x, x); }
        public readonly long4 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, x, y); }
        public readonly long4 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, x, z); }
        public readonly long4 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, x, w); }
        public readonly long4 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, y, x); }
        public readonly long4 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, y, y); }
        public readonly long4 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, y, z); }
        public readonly long4 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, y, w); }
        public readonly long4 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, z, x); }
        public readonly long4 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, z, y); }
        public readonly long4 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, z, z); }
        public readonly long4 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, z, w); }
        public readonly long4 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, w, x); }
        public readonly long4 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, w, y); }
        public readonly long4 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, w, z); }
        public readonly long4 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, z, w, w); }
        public readonly long4 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, x, x); }
        public readonly long4 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, x, y); }
        public readonly long4 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, x, z); }
        public readonly long4 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, x, w); }
        public readonly long4 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, y, x); }
        public readonly long4 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, y, y); }
        public readonly long4 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, y, z); }
        public readonly long4 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, y, w); }
        public readonly long4 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, z, x); }
        public readonly long4 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, z, y); }
        public readonly long4 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, z, z); }
        public readonly long4 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, z, w); }
        public readonly long4 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, w, x); }
        public readonly long4 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, w, y); }
        public readonly long4 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, w, z); }
        public readonly long4 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(long4 lhs, long4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(long4 lhs, long4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is long4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"long4({x}, {y}, {z}, {w})";

        // IEquatable<long4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(long4 rhs)
            => rhs.x == x
            && rhs.y == y
            && rhs.z == z
            && rhs.w == w;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            var z = this.z.ToString(format, formatProvider);
            var w = this.w.ToString(format, formatProvider);
            return $"long4({x}, {y}, {z}, {w})";
        }
    }
}
