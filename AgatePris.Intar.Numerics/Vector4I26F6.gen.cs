using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct I26F6_4 : IEquatable<I26F6_4>, IFormattable {
        // Fields
        // ---------------------------------------

        public I26F6 x;
        public I26F6 y;
        public I26F6 z;
        public I26F6 w;

        // Constants
        // ---------------------------------------

        public static readonly I26F6_4 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F6_4(I26F6 x, I26F6 y, I26F6 z, I26F6 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F6_4(I26F6 x, I26F6 y, I26F6_2 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F6_4(I26F6 x, I26F6_3 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F6_4(I26F6_2 xy, I26F6_2 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F6_4(I26F6_4 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F6_4(I26F6 x, I26F6_2 yz, I26F6 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F6_4(I26F6_3 xyz, I26F6 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F6_4(I26F6_2 xy, I26F6 z, I26F6 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6_4 operator +(I26F6_4 a, I26F6_4 b) => new I26F6_4(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6_4 operator -(I26F6_4 a, I26F6_4 b) => new I26F6_4(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6_4 operator *(I26F6_4 a, I26F6_4 b) => new I26F6_4(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6_4 operator *(I26F6_4 a, I26F6 b) => new I26F6_4(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6_4 operator *(I26F6 a, I26F6_4 b) => new I26F6_4(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6_4 operator /(I26F6_4 a, I26F6_4 b) => new I26F6_4(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6_4 operator /(I26F6_4 a, I26F6 b) => new I26F6_4(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6_4 operator /(I26F6 a, I26F6_4 b) => new I26F6_4(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

        public readonly I26F6_2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(x, x); }
        public readonly I26F6_2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(x, y); }
        public readonly I26F6_2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(x, z); }
        public readonly I26F6_2 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(x, w); }
        public readonly I26F6_2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(y, x); }
        public readonly I26F6_2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(y, y); }
        public readonly I26F6_2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(y, z); }
        public readonly I26F6_2 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(y, w); }
        public readonly I26F6_2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(z, x); }
        public readonly I26F6_2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(z, y); }
        public readonly I26F6_2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(z, z); }
        public readonly I26F6_2 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(z, w); }
        public readonly I26F6_2 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(w, x); }
        public readonly I26F6_2 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(w, y); }
        public readonly I26F6_2 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(w, z); }
        public readonly I26F6_2 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_2(w, w); }
        public readonly I26F6_3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, x, x); }
        public readonly I26F6_3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, x, y); }
        public readonly I26F6_3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, x, z); }
        public readonly I26F6_3 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, x, w); }
        public readonly I26F6_3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, y, x); }
        public readonly I26F6_3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, y, y); }
        public readonly I26F6_3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, y, z); }
        public readonly I26F6_3 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, y, w); }
        public readonly I26F6_3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, z, x); }
        public readonly I26F6_3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, z, y); }
        public readonly I26F6_3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, z, z); }
        public readonly I26F6_3 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, z, w); }
        public readonly I26F6_3 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, w, x); }
        public readonly I26F6_3 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, w, y); }
        public readonly I26F6_3 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, w, z); }
        public readonly I26F6_3 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(x, w, w); }
        public readonly I26F6_3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, x, x); }
        public readonly I26F6_3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, x, y); }
        public readonly I26F6_3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, x, z); }
        public readonly I26F6_3 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, x, w); }
        public readonly I26F6_3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, y, x); }
        public readonly I26F6_3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, y, y); }
        public readonly I26F6_3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, y, z); }
        public readonly I26F6_3 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, y, w); }
        public readonly I26F6_3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, z, x); }
        public readonly I26F6_3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, z, y); }
        public readonly I26F6_3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, z, z); }
        public readonly I26F6_3 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, z, w); }
        public readonly I26F6_3 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, w, x); }
        public readonly I26F6_3 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, w, y); }
        public readonly I26F6_3 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, w, z); }
        public readonly I26F6_3 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(y, w, w); }
        public readonly I26F6_3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, x, x); }
        public readonly I26F6_3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, x, y); }
        public readonly I26F6_3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, x, z); }
        public readonly I26F6_3 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, x, w); }
        public readonly I26F6_3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, y, x); }
        public readonly I26F6_3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, y, y); }
        public readonly I26F6_3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, y, z); }
        public readonly I26F6_3 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, y, w); }
        public readonly I26F6_3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, z, x); }
        public readonly I26F6_3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, z, y); }
        public readonly I26F6_3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, z, z); }
        public readonly I26F6_3 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, z, w); }
        public readonly I26F6_3 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, w, x); }
        public readonly I26F6_3 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, w, y); }
        public readonly I26F6_3 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, w, z); }
        public readonly I26F6_3 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(z, w, w); }
        public readonly I26F6_3 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, x, x); }
        public readonly I26F6_3 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, x, y); }
        public readonly I26F6_3 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, x, z); }
        public readonly I26F6_3 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, x, w); }
        public readonly I26F6_3 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, y, x); }
        public readonly I26F6_3 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, y, y); }
        public readonly I26F6_3 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, y, z); }
        public readonly I26F6_3 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, y, w); }
        public readonly I26F6_3 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, z, x); }
        public readonly I26F6_3 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, z, y); }
        public readonly I26F6_3 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, z, z); }
        public readonly I26F6_3 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, z, w); }
        public readonly I26F6_3 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, w, x); }
        public readonly I26F6_3 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, w, y); }
        public readonly I26F6_3 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, w, z); }
        public readonly I26F6_3 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_3(w, w, w); }
        public readonly I26F6_4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, x, x); }
        public readonly I26F6_4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, x, y); }
        public readonly I26F6_4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, x, z); }
        public readonly I26F6_4 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, x, w); }
        public readonly I26F6_4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, y, x); }
        public readonly I26F6_4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, y, y); }
        public readonly I26F6_4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, y, z); }
        public readonly I26F6_4 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, y, w); }
        public readonly I26F6_4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, z, x); }
        public readonly I26F6_4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, z, y); }
        public readonly I26F6_4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, z, z); }
        public readonly I26F6_4 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, z, w); }
        public readonly I26F6_4 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, w, x); }
        public readonly I26F6_4 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, w, y); }
        public readonly I26F6_4 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, w, z); }
        public readonly I26F6_4 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, x, w, w); }
        public readonly I26F6_4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, x, x); }
        public readonly I26F6_4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, x, y); }
        public readonly I26F6_4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, x, z); }
        public readonly I26F6_4 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, x, w); }
        public readonly I26F6_4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, y, x); }
        public readonly I26F6_4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, y, y); }
        public readonly I26F6_4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, y, z); }
        public readonly I26F6_4 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, y, w); }
        public readonly I26F6_4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, z, x); }
        public readonly I26F6_4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, z, y); }
        public readonly I26F6_4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, z, z); }
        public readonly I26F6_4 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, z, w); }
        public readonly I26F6_4 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, w, x); }
        public readonly I26F6_4 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, w, y); }
        public readonly I26F6_4 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, w, z); }
        public readonly I26F6_4 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, y, w, w); }
        public readonly I26F6_4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, x, x); }
        public readonly I26F6_4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, x, y); }
        public readonly I26F6_4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, x, z); }
        public readonly I26F6_4 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, x, w); }
        public readonly I26F6_4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, y, x); }
        public readonly I26F6_4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, y, y); }
        public readonly I26F6_4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, y, z); }
        public readonly I26F6_4 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, y, w); }
        public readonly I26F6_4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, z, x); }
        public readonly I26F6_4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, z, y); }
        public readonly I26F6_4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, z, z); }
        public readonly I26F6_4 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, z, w); }
        public readonly I26F6_4 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, w, x); }
        public readonly I26F6_4 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, w, y); }
        public readonly I26F6_4 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, w, z); }
        public readonly I26F6_4 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, z, w, w); }
        public readonly I26F6_4 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, x, x); }
        public readonly I26F6_4 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, x, y); }
        public readonly I26F6_4 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, x, z); }
        public readonly I26F6_4 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, x, w); }
        public readonly I26F6_4 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, y, x); }
        public readonly I26F6_4 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, y, y); }
        public readonly I26F6_4 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, y, z); }
        public readonly I26F6_4 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, y, w); }
        public readonly I26F6_4 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, z, x); }
        public readonly I26F6_4 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, z, y); }
        public readonly I26F6_4 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, z, z); }
        public readonly I26F6_4 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, z, w); }
        public readonly I26F6_4 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, w, x); }
        public readonly I26F6_4 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, w, y); }
        public readonly I26F6_4 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, w, z); }
        public readonly I26F6_4 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(x, w, w, w); }
        public readonly I26F6_4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, x, x); }
        public readonly I26F6_4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, x, y); }
        public readonly I26F6_4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, x, z); }
        public readonly I26F6_4 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, x, w); }
        public readonly I26F6_4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, y, x); }
        public readonly I26F6_4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, y, y); }
        public readonly I26F6_4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, y, z); }
        public readonly I26F6_4 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, y, w); }
        public readonly I26F6_4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, z, x); }
        public readonly I26F6_4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, z, y); }
        public readonly I26F6_4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, z, z); }
        public readonly I26F6_4 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, z, w); }
        public readonly I26F6_4 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, w, x); }
        public readonly I26F6_4 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, w, y); }
        public readonly I26F6_4 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, w, z); }
        public readonly I26F6_4 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, x, w, w); }
        public readonly I26F6_4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, x, x); }
        public readonly I26F6_4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, x, y); }
        public readonly I26F6_4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, x, z); }
        public readonly I26F6_4 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, x, w); }
        public readonly I26F6_4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, y, x); }
        public readonly I26F6_4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, y, y); }
        public readonly I26F6_4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, y, z); }
        public readonly I26F6_4 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, y, w); }
        public readonly I26F6_4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, z, x); }
        public readonly I26F6_4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, z, y); }
        public readonly I26F6_4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, z, z); }
        public readonly I26F6_4 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, z, w); }
        public readonly I26F6_4 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, w, x); }
        public readonly I26F6_4 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, w, y); }
        public readonly I26F6_4 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, w, z); }
        public readonly I26F6_4 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, y, w, w); }
        public readonly I26F6_4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, x, x); }
        public readonly I26F6_4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, x, y); }
        public readonly I26F6_4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, x, z); }
        public readonly I26F6_4 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, x, w); }
        public readonly I26F6_4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, y, x); }
        public readonly I26F6_4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, y, y); }
        public readonly I26F6_4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, y, z); }
        public readonly I26F6_4 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, y, w); }
        public readonly I26F6_4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, z, x); }
        public readonly I26F6_4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, z, y); }
        public readonly I26F6_4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, z, z); }
        public readonly I26F6_4 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, z, w); }
        public readonly I26F6_4 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, w, x); }
        public readonly I26F6_4 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, w, y); }
        public readonly I26F6_4 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, w, z); }
        public readonly I26F6_4 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, z, w, w); }
        public readonly I26F6_4 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, x, x); }
        public readonly I26F6_4 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, x, y); }
        public readonly I26F6_4 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, x, z); }
        public readonly I26F6_4 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, x, w); }
        public readonly I26F6_4 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, y, x); }
        public readonly I26F6_4 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, y, y); }
        public readonly I26F6_4 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, y, z); }
        public readonly I26F6_4 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, y, w); }
        public readonly I26F6_4 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, z, x); }
        public readonly I26F6_4 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, z, y); }
        public readonly I26F6_4 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, z, z); }
        public readonly I26F6_4 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, z, w); }
        public readonly I26F6_4 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, w, x); }
        public readonly I26F6_4 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, w, y); }
        public readonly I26F6_4 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, w, z); }
        public readonly I26F6_4 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(y, w, w, w); }
        public readonly I26F6_4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, x, x); }
        public readonly I26F6_4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, x, y); }
        public readonly I26F6_4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, x, z); }
        public readonly I26F6_4 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, x, w); }
        public readonly I26F6_4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, y, x); }
        public readonly I26F6_4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, y, y); }
        public readonly I26F6_4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, y, z); }
        public readonly I26F6_4 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, y, w); }
        public readonly I26F6_4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, z, x); }
        public readonly I26F6_4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, z, y); }
        public readonly I26F6_4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, z, z); }
        public readonly I26F6_4 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, z, w); }
        public readonly I26F6_4 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, w, x); }
        public readonly I26F6_4 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, w, y); }
        public readonly I26F6_4 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, w, z); }
        public readonly I26F6_4 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, x, w, w); }
        public readonly I26F6_4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, x, x); }
        public readonly I26F6_4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, x, y); }
        public readonly I26F6_4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, x, z); }
        public readonly I26F6_4 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, x, w); }
        public readonly I26F6_4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, y, x); }
        public readonly I26F6_4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, y, y); }
        public readonly I26F6_4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, y, z); }
        public readonly I26F6_4 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, y, w); }
        public readonly I26F6_4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, z, x); }
        public readonly I26F6_4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, z, y); }
        public readonly I26F6_4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, z, z); }
        public readonly I26F6_4 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, z, w); }
        public readonly I26F6_4 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, w, x); }
        public readonly I26F6_4 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, w, y); }
        public readonly I26F6_4 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, w, z); }
        public readonly I26F6_4 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, y, w, w); }
        public readonly I26F6_4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, x, x); }
        public readonly I26F6_4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, x, y); }
        public readonly I26F6_4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, x, z); }
        public readonly I26F6_4 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, x, w); }
        public readonly I26F6_4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, y, x); }
        public readonly I26F6_4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, y, y); }
        public readonly I26F6_4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, y, z); }
        public readonly I26F6_4 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, y, w); }
        public readonly I26F6_4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, z, x); }
        public readonly I26F6_4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, z, y); }
        public readonly I26F6_4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, z, z); }
        public readonly I26F6_4 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, z, w); }
        public readonly I26F6_4 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, w, x); }
        public readonly I26F6_4 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, w, y); }
        public readonly I26F6_4 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, w, z); }
        public readonly I26F6_4 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, z, w, w); }
        public readonly I26F6_4 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, x, x); }
        public readonly I26F6_4 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, x, y); }
        public readonly I26F6_4 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, x, z); }
        public readonly I26F6_4 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, x, w); }
        public readonly I26F6_4 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, y, x); }
        public readonly I26F6_4 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, y, y); }
        public readonly I26F6_4 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, y, z); }
        public readonly I26F6_4 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, y, w); }
        public readonly I26F6_4 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, z, x); }
        public readonly I26F6_4 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, z, y); }
        public readonly I26F6_4 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, z, z); }
        public readonly I26F6_4 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, z, w); }
        public readonly I26F6_4 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, w, x); }
        public readonly I26F6_4 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, w, y); }
        public readonly I26F6_4 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, w, z); }
        public readonly I26F6_4 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(z, w, w, w); }
        public readonly I26F6_4 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, x, x); }
        public readonly I26F6_4 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, x, y); }
        public readonly I26F6_4 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, x, z); }
        public readonly I26F6_4 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, x, w); }
        public readonly I26F6_4 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, y, x); }
        public readonly I26F6_4 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, y, y); }
        public readonly I26F6_4 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, y, z); }
        public readonly I26F6_4 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, y, w); }
        public readonly I26F6_4 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, z, x); }
        public readonly I26F6_4 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, z, y); }
        public readonly I26F6_4 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, z, z); }
        public readonly I26F6_4 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, z, w); }
        public readonly I26F6_4 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, w, x); }
        public readonly I26F6_4 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, w, y); }
        public readonly I26F6_4 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, w, z); }
        public readonly I26F6_4 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, x, w, w); }
        public readonly I26F6_4 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, x, x); }
        public readonly I26F6_4 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, x, y); }
        public readonly I26F6_4 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, x, z); }
        public readonly I26F6_4 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, x, w); }
        public readonly I26F6_4 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, y, x); }
        public readonly I26F6_4 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, y, y); }
        public readonly I26F6_4 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, y, z); }
        public readonly I26F6_4 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, y, w); }
        public readonly I26F6_4 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, z, x); }
        public readonly I26F6_4 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, z, y); }
        public readonly I26F6_4 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, z, z); }
        public readonly I26F6_4 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, z, w); }
        public readonly I26F6_4 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, w, x); }
        public readonly I26F6_4 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, w, y); }
        public readonly I26F6_4 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, w, z); }
        public readonly I26F6_4 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, y, w, w); }
        public readonly I26F6_4 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, x, x); }
        public readonly I26F6_4 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, x, y); }
        public readonly I26F6_4 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, x, z); }
        public readonly I26F6_4 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, x, w); }
        public readonly I26F6_4 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, y, x); }
        public readonly I26F6_4 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, y, y); }
        public readonly I26F6_4 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, y, z); }
        public readonly I26F6_4 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, y, w); }
        public readonly I26F6_4 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, z, x); }
        public readonly I26F6_4 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, z, y); }
        public readonly I26F6_4 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, z, z); }
        public readonly I26F6_4 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, z, w); }
        public readonly I26F6_4 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, w, x); }
        public readonly I26F6_4 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, w, y); }
        public readonly I26F6_4 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, w, z); }
        public readonly I26F6_4 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, z, w, w); }
        public readonly I26F6_4 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, x, x); }
        public readonly I26F6_4 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, x, y); }
        public readonly I26F6_4 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, x, z); }
        public readonly I26F6_4 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, x, w); }
        public readonly I26F6_4 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, y, x); }
        public readonly I26F6_4 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, y, y); }
        public readonly I26F6_4 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, y, z); }
        public readonly I26F6_4 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, y, w); }
        public readonly I26F6_4 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, z, x); }
        public readonly I26F6_4 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, z, y); }
        public readonly I26F6_4 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, z, z); }
        public readonly I26F6_4 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, z, w); }
        public readonly I26F6_4 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, w, x); }
        public readonly I26F6_4 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, w, y); }
        public readonly I26F6_4 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, w, z); }
        public readonly I26F6_4 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I26F6_4(w, w, w, w); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I26F6_4 lhs, I26F6_4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I26F6_4 lhs, I26F6_4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I26F6_4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"I26F6_4({x}, {y}, {z}, {w})";

        // IEquatable<I26F6_4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I26F6_4 other)
            => other.x == x
            && other.y == y
            && other.z == z
            && other.w == w;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            var z = this.z.ToString(format, formatProvider);
            var w = this.w.ToString(format, formatProvider);
            return $"I26F6_4({x}, {y}, {z}, {w})";
        }
    }
}
