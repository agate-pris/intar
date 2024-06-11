using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]

#pragma warning disable IDE1006 // 命名スタイル

    public struct ulong4 : IEquatable<ulong4>, IFormattable {

#pragma warning restore IDE1006 // 命名スタイル

        // Fields
        // ---------------------------------------

        public ulong x;
        public ulong y;
        public ulong z;
        public ulong w;

        // Constants
        // ---------------------------------------

        public static readonly ulong4 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong x, ulong y, ulong z, ulong w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong x, ulong y, ulong2 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong x, ulong3 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong2 xy, ulong2 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong4 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong x, ulong2 yz, ulong w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong3 xyz, ulong w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong2 xy, ulong z, ulong w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator +(ulong4 a, ulong4 b) => new ulong4(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator -(ulong4 a, ulong4 b) => new ulong4(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator *(ulong4 a, ulong4 b) => new ulong4(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator *(ulong4 a, ulong b) => new ulong4(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator *(ulong a, ulong4 b) => new ulong4(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator /(ulong4 a, ulong4 b) => new ulong4(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator /(ulong4 a, ulong b) => new ulong4(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator /(ulong a, ulong4 b) => new ulong4(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly ulong2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(x, x); }
        public readonly ulong2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(x, y); }
        public readonly ulong2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(x, z); }
        public readonly ulong2 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(x, w); }
        public readonly ulong2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(y, x); }
        public readonly ulong2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(y, y); }
        public readonly ulong2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(y, z); }
        public readonly ulong2 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(y, w); }
        public readonly ulong2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(z, x); }
        public readonly ulong2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(z, y); }
        public readonly ulong2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(z, z); }
        public readonly ulong2 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(z, w); }
        public readonly ulong2 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(w, x); }
        public readonly ulong2 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(w, y); }
        public readonly ulong2 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(w, z); }
        public readonly ulong2 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(w, w); }
        public readonly ulong3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, x, x); }
        public readonly ulong3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, x, y); }
        public readonly ulong3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, x, z); }
        public readonly ulong3 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, x, w); }
        public readonly ulong3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, y, x); }
        public readonly ulong3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, y, y); }
        public readonly ulong3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, y, z); }
        public readonly ulong3 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, y, w); }
        public readonly ulong3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, z, x); }
        public readonly ulong3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, z, y); }
        public readonly ulong3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, z, z); }
        public readonly ulong3 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, z, w); }
        public readonly ulong3 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, w, x); }
        public readonly ulong3 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, w, y); }
        public readonly ulong3 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, w, z); }
        public readonly ulong3 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, w, w); }
        public readonly ulong3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, x, x); }
        public readonly ulong3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, x, y); }
        public readonly ulong3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, x, z); }
        public readonly ulong3 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, x, w); }
        public readonly ulong3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, y, x); }
        public readonly ulong3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, y, y); }
        public readonly ulong3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, y, z); }
        public readonly ulong3 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, y, w); }
        public readonly ulong3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, z, x); }
        public readonly ulong3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, z, y); }
        public readonly ulong3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, z, z); }
        public readonly ulong3 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, z, w); }
        public readonly ulong3 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, w, x); }
        public readonly ulong3 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, w, y); }
        public readonly ulong3 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, w, z); }
        public readonly ulong3 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, w, w); }
        public readonly ulong3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, x, x); }
        public readonly ulong3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, x, y); }
        public readonly ulong3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, x, z); }
        public readonly ulong3 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, x, w); }
        public readonly ulong3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, y, x); }
        public readonly ulong3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, y, y); }
        public readonly ulong3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, y, z); }
        public readonly ulong3 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, y, w); }
        public readonly ulong3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, z, x); }
        public readonly ulong3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, z, y); }
        public readonly ulong3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, z, z); }
        public readonly ulong3 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, z, w); }
        public readonly ulong3 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, w, x); }
        public readonly ulong3 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, w, y); }
        public readonly ulong3 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, w, z); }
        public readonly ulong3 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(z, w, w); }
        public readonly ulong3 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, x, x); }
        public readonly ulong3 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, x, y); }
        public readonly ulong3 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, x, z); }
        public readonly ulong3 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, x, w); }
        public readonly ulong3 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, y, x); }
        public readonly ulong3 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, y, y); }
        public readonly ulong3 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, y, z); }
        public readonly ulong3 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, y, w); }
        public readonly ulong3 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, z, x); }
        public readonly ulong3 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, z, y); }
        public readonly ulong3 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, z, z); }
        public readonly ulong3 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, z, w); }
        public readonly ulong3 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, w, x); }
        public readonly ulong3 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, w, y); }
        public readonly ulong3 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, w, z); }
        public readonly ulong3 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(w, w, w); }
        public readonly ulong4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, x, x); }
        public readonly ulong4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, x, y); }
        public readonly ulong4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, x, z); }
        public readonly ulong4 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, x, w); }
        public readonly ulong4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, y, x); }
        public readonly ulong4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, y, y); }
        public readonly ulong4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, y, z); }
        public readonly ulong4 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, y, w); }
        public readonly ulong4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, z, x); }
        public readonly ulong4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, z, y); }
        public readonly ulong4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, z, z); }
        public readonly ulong4 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, z, w); }
        public readonly ulong4 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, w, x); }
        public readonly ulong4 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, w, y); }
        public readonly ulong4 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, w, z); }
        public readonly ulong4 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, w, w); }
        public readonly ulong4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, x, x); }
        public readonly ulong4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, x, y); }
        public readonly ulong4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, x, z); }
        public readonly ulong4 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, x, w); }
        public readonly ulong4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, y, x); }
        public readonly ulong4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, y, y); }
        public readonly ulong4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, y, z); }
        public readonly ulong4 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, y, w); }
        public readonly ulong4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, z, x); }
        public readonly ulong4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, z, y); }
        public readonly ulong4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, z, z); }
        public readonly ulong4 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, z, w); }
        public readonly ulong4 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, w, x); }
        public readonly ulong4 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, w, y); }
        public readonly ulong4 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, w, z); }
        public readonly ulong4 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, w, w); }
        public readonly ulong4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, x, x); }
        public readonly ulong4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, x, y); }
        public readonly ulong4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, x, z); }
        public readonly ulong4 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, x, w); }
        public readonly ulong4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, y, x); }
        public readonly ulong4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, y, y); }
        public readonly ulong4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, y, z); }
        public readonly ulong4 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, y, w); }
        public readonly ulong4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, z, x); }
        public readonly ulong4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, z, y); }
        public readonly ulong4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, z, z); }
        public readonly ulong4 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, z, w); }
        public readonly ulong4 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, w, x); }
        public readonly ulong4 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, w, y); }
        public readonly ulong4 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, w, z); }
        public readonly ulong4 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, z, w, w); }
        public readonly ulong4 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, x, x); }
        public readonly ulong4 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, x, y); }
        public readonly ulong4 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, x, z); }
        public readonly ulong4 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, x, w); }
        public readonly ulong4 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, y, x); }
        public readonly ulong4 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, y, y); }
        public readonly ulong4 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, y, z); }
        public readonly ulong4 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, y, w); }
        public readonly ulong4 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, z, x); }
        public readonly ulong4 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, z, y); }
        public readonly ulong4 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, z, z); }
        public readonly ulong4 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, z, w); }
        public readonly ulong4 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, w, x); }
        public readonly ulong4 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, w, y); }
        public readonly ulong4 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, w, z); }
        public readonly ulong4 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, w, w, w); }
        public readonly ulong4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, x, x); }
        public readonly ulong4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, x, y); }
        public readonly ulong4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, x, z); }
        public readonly ulong4 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, x, w); }
        public readonly ulong4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, y, x); }
        public readonly ulong4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, y, y); }
        public readonly ulong4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, y, z); }
        public readonly ulong4 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, y, w); }
        public readonly ulong4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, z, x); }
        public readonly ulong4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, z, y); }
        public readonly ulong4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, z, z); }
        public readonly ulong4 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, z, w); }
        public readonly ulong4 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, w, x); }
        public readonly ulong4 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, w, y); }
        public readonly ulong4 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, w, z); }
        public readonly ulong4 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, w, w); }
        public readonly ulong4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, x, x); }
        public readonly ulong4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, x, y); }
        public readonly ulong4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, x, z); }
        public readonly ulong4 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, x, w); }
        public readonly ulong4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, y, x); }
        public readonly ulong4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, y, y); }
        public readonly ulong4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, y, z); }
        public readonly ulong4 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, y, w); }
        public readonly ulong4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, z, x); }
        public readonly ulong4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, z, y); }
        public readonly ulong4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, z, z); }
        public readonly ulong4 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, z, w); }
        public readonly ulong4 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, w, x); }
        public readonly ulong4 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, w, y); }
        public readonly ulong4 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, w, z); }
        public readonly ulong4 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, w, w); }
        public readonly ulong4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, x, x); }
        public readonly ulong4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, x, y); }
        public readonly ulong4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, x, z); }
        public readonly ulong4 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, x, w); }
        public readonly ulong4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, y, x); }
        public readonly ulong4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, y, y); }
        public readonly ulong4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, y, z); }
        public readonly ulong4 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, y, w); }
        public readonly ulong4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, z, x); }
        public readonly ulong4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, z, y); }
        public readonly ulong4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, z, z); }
        public readonly ulong4 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, z, w); }
        public readonly ulong4 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, w, x); }
        public readonly ulong4 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, w, y); }
        public readonly ulong4 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, w, z); }
        public readonly ulong4 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, z, w, w); }
        public readonly ulong4 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, x, x); }
        public readonly ulong4 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, x, y); }
        public readonly ulong4 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, x, z); }
        public readonly ulong4 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, x, w); }
        public readonly ulong4 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, y, x); }
        public readonly ulong4 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, y, y); }
        public readonly ulong4 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, y, z); }
        public readonly ulong4 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, y, w); }
        public readonly ulong4 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, z, x); }
        public readonly ulong4 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, z, y); }
        public readonly ulong4 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, z, z); }
        public readonly ulong4 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, z, w); }
        public readonly ulong4 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, w, x); }
        public readonly ulong4 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, w, y); }
        public readonly ulong4 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, w, z); }
        public readonly ulong4 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, w, w, w); }
        public readonly ulong4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, x, x); }
        public readonly ulong4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, x, y); }
        public readonly ulong4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, x, z); }
        public readonly ulong4 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, x, w); }
        public readonly ulong4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, y, x); }
        public readonly ulong4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, y, y); }
        public readonly ulong4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, y, z); }
        public readonly ulong4 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, y, w); }
        public readonly ulong4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, z, x); }
        public readonly ulong4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, z, y); }
        public readonly ulong4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, z, z); }
        public readonly ulong4 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, z, w); }
        public readonly ulong4 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, w, x); }
        public readonly ulong4 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, w, y); }
        public readonly ulong4 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, w, z); }
        public readonly ulong4 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, x, w, w); }
        public readonly ulong4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, x, x); }
        public readonly ulong4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, x, y); }
        public readonly ulong4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, x, z); }
        public readonly ulong4 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, x, w); }
        public readonly ulong4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, y, x); }
        public readonly ulong4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, y, y); }
        public readonly ulong4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, y, z); }
        public readonly ulong4 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, y, w); }
        public readonly ulong4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, z, x); }
        public readonly ulong4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, z, y); }
        public readonly ulong4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, z, z); }
        public readonly ulong4 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, z, w); }
        public readonly ulong4 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, w, x); }
        public readonly ulong4 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, w, y); }
        public readonly ulong4 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, w, z); }
        public readonly ulong4 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, y, w, w); }
        public readonly ulong4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, x, x); }
        public readonly ulong4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, x, y); }
        public readonly ulong4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, x, z); }
        public readonly ulong4 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, x, w); }
        public readonly ulong4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, y, x); }
        public readonly ulong4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, y, y); }
        public readonly ulong4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, y, z); }
        public readonly ulong4 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, y, w); }
        public readonly ulong4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, z, x); }
        public readonly ulong4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, z, y); }
        public readonly ulong4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, z, z); }
        public readonly ulong4 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, z, w); }
        public readonly ulong4 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, w, x); }
        public readonly ulong4 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, w, y); }
        public readonly ulong4 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, w, z); }
        public readonly ulong4 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, z, w, w); }
        public readonly ulong4 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, x, x); }
        public readonly ulong4 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, x, y); }
        public readonly ulong4 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, x, z); }
        public readonly ulong4 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, x, w); }
        public readonly ulong4 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, y, x); }
        public readonly ulong4 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, y, y); }
        public readonly ulong4 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, y, z); }
        public readonly ulong4 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, y, w); }
        public readonly ulong4 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, z, x); }
        public readonly ulong4 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, z, y); }
        public readonly ulong4 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, z, z); }
        public readonly ulong4 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, z, w); }
        public readonly ulong4 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, w, x); }
        public readonly ulong4 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, w, y); }
        public readonly ulong4 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, w, z); }
        public readonly ulong4 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(z, w, w, w); }
        public readonly ulong4 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, x, x); }
        public readonly ulong4 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, x, y); }
        public readonly ulong4 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, x, z); }
        public readonly ulong4 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, x, w); }
        public readonly ulong4 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, y, x); }
        public readonly ulong4 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, y, y); }
        public readonly ulong4 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, y, z); }
        public readonly ulong4 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, y, w); }
        public readonly ulong4 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, z, x); }
        public readonly ulong4 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, z, y); }
        public readonly ulong4 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, z, z); }
        public readonly ulong4 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, z, w); }
        public readonly ulong4 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, w, x); }
        public readonly ulong4 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, w, y); }
        public readonly ulong4 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, w, z); }
        public readonly ulong4 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, x, w, w); }
        public readonly ulong4 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, x, x); }
        public readonly ulong4 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, x, y); }
        public readonly ulong4 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, x, z); }
        public readonly ulong4 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, x, w); }
        public readonly ulong4 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, y, x); }
        public readonly ulong4 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, y, y); }
        public readonly ulong4 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, y, z); }
        public readonly ulong4 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, y, w); }
        public readonly ulong4 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, z, x); }
        public readonly ulong4 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, z, y); }
        public readonly ulong4 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, z, z); }
        public readonly ulong4 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, z, w); }
        public readonly ulong4 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, w, x); }
        public readonly ulong4 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, w, y); }
        public readonly ulong4 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, w, z); }
        public readonly ulong4 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, y, w, w); }
        public readonly ulong4 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, x, x); }
        public readonly ulong4 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, x, y); }
        public readonly ulong4 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, x, z); }
        public readonly ulong4 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, x, w); }
        public readonly ulong4 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, y, x); }
        public readonly ulong4 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, y, y); }
        public readonly ulong4 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, y, z); }
        public readonly ulong4 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, y, w); }
        public readonly ulong4 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, z, x); }
        public readonly ulong4 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, z, y); }
        public readonly ulong4 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, z, z); }
        public readonly ulong4 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, z, w); }
        public readonly ulong4 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, w, x); }
        public readonly ulong4 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, w, y); }
        public readonly ulong4 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, w, z); }
        public readonly ulong4 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, z, w, w); }
        public readonly ulong4 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, x, x); }
        public readonly ulong4 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, x, y); }
        public readonly ulong4 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, x, z); }
        public readonly ulong4 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, x, w); }
        public readonly ulong4 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, y, x); }
        public readonly ulong4 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, y, y); }
        public readonly ulong4 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, y, z); }
        public readonly ulong4 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, y, w); }
        public readonly ulong4 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, z, x); }
        public readonly ulong4 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, z, y); }
        public readonly ulong4 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, z, z); }
        public readonly ulong4 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, z, w); }
        public readonly ulong4 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, w, x); }
        public readonly ulong4 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, w, y); }
        public readonly ulong4 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, w, z); }
        public readonly ulong4 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(ulong4 lhs, ulong4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(ulong4 lhs, ulong4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is ulong4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"ulong4({x}, {y}, {z}, {w})";

        // IEquatable<ulong4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(ulong4 other)
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
            return $"ulong4({x}, {y}, {z}, {w})";
        }
    }
}
