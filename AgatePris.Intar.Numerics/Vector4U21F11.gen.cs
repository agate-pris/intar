using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct U21F11_4 : IEquatable<U21F11_4>, IFormattable {
        // Fields
        // ---------------------------------------

        public U21F11 x;
        public U21F11 y;
        public U21F11 z;
        public U21F11 w;

        // Constants
        // ---------------------------------------

        public static readonly U21F11_4 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11_4(U21F11 x, U21F11 y, U21F11 z, U21F11 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11_4(U21F11 x, U21F11 y, U21F11_2 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11_4(U21F11 x, U21F11_3 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11_4(U21F11_2 xy, U21F11_2 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11_4(U21F11_4 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11_4(U21F11 x, U21F11_2 yz, U21F11 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11_4(U21F11_3 xyz, U21F11 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11_4(U21F11_2 xy, U21F11 z, U21F11 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11_4 operator +(U21F11_4 a, U21F11_4 b) => new U21F11_4(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11_4 operator -(U21F11_4 a, U21F11_4 b) => new U21F11_4(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11_4 operator *(U21F11_4 a, U21F11_4 b) => new U21F11_4(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11_4 operator *(U21F11_4 a, U21F11 b) => new U21F11_4(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11_4 operator *(U21F11 a, U21F11_4 b) => new U21F11_4(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11_4 operator /(U21F11_4 a, U21F11_4 b) => new U21F11_4(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11_4 operator /(U21F11_4 a, U21F11 b) => new U21F11_4(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11_4 operator /(U21F11 a, U21F11_4 b) => new U21F11_4(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

        public readonly U21F11_2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(x, x); }
        public readonly U21F11_2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(x, y); }
        public readonly U21F11_2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(x, z); }
        public readonly U21F11_2 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(x, w); }
        public readonly U21F11_2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(y, x); }
        public readonly U21F11_2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(y, y); }
        public readonly U21F11_2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(y, z); }
        public readonly U21F11_2 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(y, w); }
        public readonly U21F11_2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(z, x); }
        public readonly U21F11_2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(z, y); }
        public readonly U21F11_2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(z, z); }
        public readonly U21F11_2 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(z, w); }
        public readonly U21F11_2 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(w, x); }
        public readonly U21F11_2 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(w, y); }
        public readonly U21F11_2 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(w, z); }
        public readonly U21F11_2 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_2(w, w); }
        public readonly U21F11_3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, x, x); }
        public readonly U21F11_3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, x, y); }
        public readonly U21F11_3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, x, z); }
        public readonly U21F11_3 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, x, w); }
        public readonly U21F11_3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, y, x); }
        public readonly U21F11_3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, y, y); }
        public readonly U21F11_3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, y, z); }
        public readonly U21F11_3 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, y, w); }
        public readonly U21F11_3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, z, x); }
        public readonly U21F11_3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, z, y); }
        public readonly U21F11_3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, z, z); }
        public readonly U21F11_3 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, z, w); }
        public readonly U21F11_3 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, w, x); }
        public readonly U21F11_3 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, w, y); }
        public readonly U21F11_3 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, w, z); }
        public readonly U21F11_3 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(x, w, w); }
        public readonly U21F11_3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, x, x); }
        public readonly U21F11_3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, x, y); }
        public readonly U21F11_3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, x, z); }
        public readonly U21F11_3 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, x, w); }
        public readonly U21F11_3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, y, x); }
        public readonly U21F11_3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, y, y); }
        public readonly U21F11_3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, y, z); }
        public readonly U21F11_3 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, y, w); }
        public readonly U21F11_3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, z, x); }
        public readonly U21F11_3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, z, y); }
        public readonly U21F11_3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, z, z); }
        public readonly U21F11_3 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, z, w); }
        public readonly U21F11_3 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, w, x); }
        public readonly U21F11_3 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, w, y); }
        public readonly U21F11_3 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, w, z); }
        public readonly U21F11_3 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(y, w, w); }
        public readonly U21F11_3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, x, x); }
        public readonly U21F11_3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, x, y); }
        public readonly U21F11_3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, x, z); }
        public readonly U21F11_3 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, x, w); }
        public readonly U21F11_3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, y, x); }
        public readonly U21F11_3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, y, y); }
        public readonly U21F11_3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, y, z); }
        public readonly U21F11_3 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, y, w); }
        public readonly U21F11_3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, z, x); }
        public readonly U21F11_3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, z, y); }
        public readonly U21F11_3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, z, z); }
        public readonly U21F11_3 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, z, w); }
        public readonly U21F11_3 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, w, x); }
        public readonly U21F11_3 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, w, y); }
        public readonly U21F11_3 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, w, z); }
        public readonly U21F11_3 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(z, w, w); }
        public readonly U21F11_3 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, x, x); }
        public readonly U21F11_3 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, x, y); }
        public readonly U21F11_3 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, x, z); }
        public readonly U21F11_3 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, x, w); }
        public readonly U21F11_3 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, y, x); }
        public readonly U21F11_3 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, y, y); }
        public readonly U21F11_3 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, y, z); }
        public readonly U21F11_3 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, y, w); }
        public readonly U21F11_3 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, z, x); }
        public readonly U21F11_3 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, z, y); }
        public readonly U21F11_3 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, z, z); }
        public readonly U21F11_3 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, z, w); }
        public readonly U21F11_3 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, w, x); }
        public readonly U21F11_3 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, w, y); }
        public readonly U21F11_3 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, w, z); }
        public readonly U21F11_3 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_3(w, w, w); }
        public readonly U21F11_4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, x, x); }
        public readonly U21F11_4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, x, y); }
        public readonly U21F11_4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, x, z); }
        public readonly U21F11_4 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, x, w); }
        public readonly U21F11_4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, y, x); }
        public readonly U21F11_4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, y, y); }
        public readonly U21F11_4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, y, z); }
        public readonly U21F11_4 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, y, w); }
        public readonly U21F11_4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, z, x); }
        public readonly U21F11_4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, z, y); }
        public readonly U21F11_4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, z, z); }
        public readonly U21F11_4 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, z, w); }
        public readonly U21F11_4 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, w, x); }
        public readonly U21F11_4 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, w, y); }
        public readonly U21F11_4 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, w, z); }
        public readonly U21F11_4 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, x, w, w); }
        public readonly U21F11_4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, x, x); }
        public readonly U21F11_4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, x, y); }
        public readonly U21F11_4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, x, z); }
        public readonly U21F11_4 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, x, w); }
        public readonly U21F11_4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, y, x); }
        public readonly U21F11_4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, y, y); }
        public readonly U21F11_4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, y, z); }
        public readonly U21F11_4 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, y, w); }
        public readonly U21F11_4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, z, x); }
        public readonly U21F11_4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, z, y); }
        public readonly U21F11_4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, z, z); }
        public readonly U21F11_4 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, z, w); }
        public readonly U21F11_4 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, w, x); }
        public readonly U21F11_4 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, w, y); }
        public readonly U21F11_4 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, w, z); }
        public readonly U21F11_4 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, y, w, w); }
        public readonly U21F11_4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, x, x); }
        public readonly U21F11_4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, x, y); }
        public readonly U21F11_4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, x, z); }
        public readonly U21F11_4 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, x, w); }
        public readonly U21F11_4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, y, x); }
        public readonly U21F11_4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, y, y); }
        public readonly U21F11_4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, y, z); }
        public readonly U21F11_4 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, y, w); }
        public readonly U21F11_4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, z, x); }
        public readonly U21F11_4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, z, y); }
        public readonly U21F11_4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, z, z); }
        public readonly U21F11_4 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, z, w); }
        public readonly U21F11_4 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, w, x); }
        public readonly U21F11_4 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, w, y); }
        public readonly U21F11_4 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, w, z); }
        public readonly U21F11_4 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, z, w, w); }
        public readonly U21F11_4 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, x, x); }
        public readonly U21F11_4 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, x, y); }
        public readonly U21F11_4 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, x, z); }
        public readonly U21F11_4 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, x, w); }
        public readonly U21F11_4 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, y, x); }
        public readonly U21F11_4 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, y, y); }
        public readonly U21F11_4 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, y, z); }
        public readonly U21F11_4 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, y, w); }
        public readonly U21F11_4 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, z, x); }
        public readonly U21F11_4 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, z, y); }
        public readonly U21F11_4 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, z, z); }
        public readonly U21F11_4 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, z, w); }
        public readonly U21F11_4 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, w, x); }
        public readonly U21F11_4 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, w, y); }
        public readonly U21F11_4 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, w, z); }
        public readonly U21F11_4 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(x, w, w, w); }
        public readonly U21F11_4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, x, x); }
        public readonly U21F11_4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, x, y); }
        public readonly U21F11_4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, x, z); }
        public readonly U21F11_4 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, x, w); }
        public readonly U21F11_4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, y, x); }
        public readonly U21F11_4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, y, y); }
        public readonly U21F11_4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, y, z); }
        public readonly U21F11_4 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, y, w); }
        public readonly U21F11_4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, z, x); }
        public readonly U21F11_4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, z, y); }
        public readonly U21F11_4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, z, z); }
        public readonly U21F11_4 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, z, w); }
        public readonly U21F11_4 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, w, x); }
        public readonly U21F11_4 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, w, y); }
        public readonly U21F11_4 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, w, z); }
        public readonly U21F11_4 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, x, w, w); }
        public readonly U21F11_4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, x, x); }
        public readonly U21F11_4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, x, y); }
        public readonly U21F11_4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, x, z); }
        public readonly U21F11_4 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, x, w); }
        public readonly U21F11_4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, y, x); }
        public readonly U21F11_4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, y, y); }
        public readonly U21F11_4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, y, z); }
        public readonly U21F11_4 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, y, w); }
        public readonly U21F11_4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, z, x); }
        public readonly U21F11_4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, z, y); }
        public readonly U21F11_4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, z, z); }
        public readonly U21F11_4 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, z, w); }
        public readonly U21F11_4 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, w, x); }
        public readonly U21F11_4 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, w, y); }
        public readonly U21F11_4 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, w, z); }
        public readonly U21F11_4 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, y, w, w); }
        public readonly U21F11_4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, x, x); }
        public readonly U21F11_4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, x, y); }
        public readonly U21F11_4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, x, z); }
        public readonly U21F11_4 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, x, w); }
        public readonly U21F11_4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, y, x); }
        public readonly U21F11_4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, y, y); }
        public readonly U21F11_4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, y, z); }
        public readonly U21F11_4 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, y, w); }
        public readonly U21F11_4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, z, x); }
        public readonly U21F11_4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, z, y); }
        public readonly U21F11_4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, z, z); }
        public readonly U21F11_4 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, z, w); }
        public readonly U21F11_4 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, w, x); }
        public readonly U21F11_4 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, w, y); }
        public readonly U21F11_4 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, w, z); }
        public readonly U21F11_4 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, z, w, w); }
        public readonly U21F11_4 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, x, x); }
        public readonly U21F11_4 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, x, y); }
        public readonly U21F11_4 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, x, z); }
        public readonly U21F11_4 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, x, w); }
        public readonly U21F11_4 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, y, x); }
        public readonly U21F11_4 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, y, y); }
        public readonly U21F11_4 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, y, z); }
        public readonly U21F11_4 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, y, w); }
        public readonly U21F11_4 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, z, x); }
        public readonly U21F11_4 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, z, y); }
        public readonly U21F11_4 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, z, z); }
        public readonly U21F11_4 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, z, w); }
        public readonly U21F11_4 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, w, x); }
        public readonly U21F11_4 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, w, y); }
        public readonly U21F11_4 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, w, z); }
        public readonly U21F11_4 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(y, w, w, w); }
        public readonly U21F11_4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, x, x); }
        public readonly U21F11_4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, x, y); }
        public readonly U21F11_4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, x, z); }
        public readonly U21F11_4 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, x, w); }
        public readonly U21F11_4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, y, x); }
        public readonly U21F11_4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, y, y); }
        public readonly U21F11_4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, y, z); }
        public readonly U21F11_4 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, y, w); }
        public readonly U21F11_4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, z, x); }
        public readonly U21F11_4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, z, y); }
        public readonly U21F11_4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, z, z); }
        public readonly U21F11_4 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, z, w); }
        public readonly U21F11_4 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, w, x); }
        public readonly U21F11_4 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, w, y); }
        public readonly U21F11_4 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, w, z); }
        public readonly U21F11_4 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, x, w, w); }
        public readonly U21F11_4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, x, x); }
        public readonly U21F11_4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, x, y); }
        public readonly U21F11_4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, x, z); }
        public readonly U21F11_4 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, x, w); }
        public readonly U21F11_4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, y, x); }
        public readonly U21F11_4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, y, y); }
        public readonly U21F11_4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, y, z); }
        public readonly U21F11_4 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, y, w); }
        public readonly U21F11_4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, z, x); }
        public readonly U21F11_4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, z, y); }
        public readonly U21F11_4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, z, z); }
        public readonly U21F11_4 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, z, w); }
        public readonly U21F11_4 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, w, x); }
        public readonly U21F11_4 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, w, y); }
        public readonly U21F11_4 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, w, z); }
        public readonly U21F11_4 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, y, w, w); }
        public readonly U21F11_4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, x, x); }
        public readonly U21F11_4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, x, y); }
        public readonly U21F11_4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, x, z); }
        public readonly U21F11_4 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, x, w); }
        public readonly U21F11_4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, y, x); }
        public readonly U21F11_4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, y, y); }
        public readonly U21F11_4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, y, z); }
        public readonly U21F11_4 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, y, w); }
        public readonly U21F11_4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, z, x); }
        public readonly U21F11_4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, z, y); }
        public readonly U21F11_4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, z, z); }
        public readonly U21F11_4 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, z, w); }
        public readonly U21F11_4 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, w, x); }
        public readonly U21F11_4 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, w, y); }
        public readonly U21F11_4 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, w, z); }
        public readonly U21F11_4 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, z, w, w); }
        public readonly U21F11_4 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, x, x); }
        public readonly U21F11_4 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, x, y); }
        public readonly U21F11_4 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, x, z); }
        public readonly U21F11_4 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, x, w); }
        public readonly U21F11_4 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, y, x); }
        public readonly U21F11_4 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, y, y); }
        public readonly U21F11_4 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, y, z); }
        public readonly U21F11_4 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, y, w); }
        public readonly U21F11_4 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, z, x); }
        public readonly U21F11_4 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, z, y); }
        public readonly U21F11_4 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, z, z); }
        public readonly U21F11_4 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, z, w); }
        public readonly U21F11_4 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, w, x); }
        public readonly U21F11_4 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, w, y); }
        public readonly U21F11_4 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, w, z); }
        public readonly U21F11_4 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(z, w, w, w); }
        public readonly U21F11_4 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, x, x); }
        public readonly U21F11_4 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, x, y); }
        public readonly U21F11_4 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, x, z); }
        public readonly U21F11_4 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, x, w); }
        public readonly U21F11_4 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, y, x); }
        public readonly U21F11_4 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, y, y); }
        public readonly U21F11_4 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, y, z); }
        public readonly U21F11_4 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, y, w); }
        public readonly U21F11_4 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, z, x); }
        public readonly U21F11_4 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, z, y); }
        public readonly U21F11_4 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, z, z); }
        public readonly U21F11_4 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, z, w); }
        public readonly U21F11_4 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, w, x); }
        public readonly U21F11_4 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, w, y); }
        public readonly U21F11_4 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, w, z); }
        public readonly U21F11_4 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, x, w, w); }
        public readonly U21F11_4 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, x, x); }
        public readonly U21F11_4 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, x, y); }
        public readonly U21F11_4 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, x, z); }
        public readonly U21F11_4 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, x, w); }
        public readonly U21F11_4 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, y, x); }
        public readonly U21F11_4 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, y, y); }
        public readonly U21F11_4 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, y, z); }
        public readonly U21F11_4 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, y, w); }
        public readonly U21F11_4 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, z, x); }
        public readonly U21F11_4 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, z, y); }
        public readonly U21F11_4 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, z, z); }
        public readonly U21F11_4 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, z, w); }
        public readonly U21F11_4 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, w, x); }
        public readonly U21F11_4 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, w, y); }
        public readonly U21F11_4 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, w, z); }
        public readonly U21F11_4 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, y, w, w); }
        public readonly U21F11_4 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, x, x); }
        public readonly U21F11_4 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, x, y); }
        public readonly U21F11_4 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, x, z); }
        public readonly U21F11_4 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, x, w); }
        public readonly U21F11_4 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, y, x); }
        public readonly U21F11_4 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, y, y); }
        public readonly U21F11_4 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, y, z); }
        public readonly U21F11_4 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, y, w); }
        public readonly U21F11_4 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, z, x); }
        public readonly U21F11_4 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, z, y); }
        public readonly U21F11_4 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, z, z); }
        public readonly U21F11_4 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, z, w); }
        public readonly U21F11_4 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, w, x); }
        public readonly U21F11_4 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, w, y); }
        public readonly U21F11_4 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, w, z); }
        public readonly U21F11_4 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, z, w, w); }
        public readonly U21F11_4 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, x, x); }
        public readonly U21F11_4 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, x, y); }
        public readonly U21F11_4 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, x, z); }
        public readonly U21F11_4 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, x, w); }
        public readonly U21F11_4 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, y, x); }
        public readonly U21F11_4 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, y, y); }
        public readonly U21F11_4 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, y, z); }
        public readonly U21F11_4 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, y, w); }
        public readonly U21F11_4 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, z, x); }
        public readonly U21F11_4 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, z, y); }
        public readonly U21F11_4 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, z, z); }
        public readonly U21F11_4 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, z, w); }
        public readonly U21F11_4 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, w, x); }
        public readonly U21F11_4 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, w, y); }
        public readonly U21F11_4 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, w, z); }
        public readonly U21F11_4 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U21F11_4(w, w, w, w); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U21F11_4 lhs, U21F11_4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U21F11_4 lhs, U21F11_4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U21F11_4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"U21F11_4({x}, {y}, {z}, {w})";

        // IEquatable<U21F11_4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U21F11_4 other)
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
            return $"U21F11_4({x}, {y}, {z}, {w})";
        }
    }
}
