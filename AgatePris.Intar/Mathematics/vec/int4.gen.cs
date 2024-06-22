#if !UNITY_2018_3_OR_NEWER

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct int4 : IEquatable<int4>, IFormattable {
        // Fields
        // ---------------------------------------

        public int x;
        public int y;
        public int z;
        public int w;

        // Constants
        // ---------------------------------------

        public static readonly int4 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int x, int y, int z, int w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int x, int y, int2 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int x, int3 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int2 xy, int2 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int4 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int x, int2 yz, int w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int3 xyz, int w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int2 xy, int z, int w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator +(int4 a, int4 b) => new int4(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator -(int4 a, int4 b) => new int4(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator *(int4 a, int4 b) => new int4(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator *(int4 a, int b) => new int4(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator *(int a, int4 b) => new int4(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator /(int4 a, int4 b) => new int4(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator /(int4 a, int b) => new int4(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 operator /(int a, int4 b) => new int4(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

        public readonly int2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(x, x); }
        public readonly int2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(x, y); }
        public readonly int2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(x, z); }
        public readonly int2 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(x, w); }
        public readonly int2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(y, x); }
        public readonly int2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(y, y); }
        public readonly int2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(y, z); }
        public readonly int2 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(y, w); }
        public readonly int2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(z, x); }
        public readonly int2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(z, y); }
        public readonly int2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(z, z); }
        public readonly int2 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(z, w); }
        public readonly int2 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(w, x); }
        public readonly int2 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(w, y); }
        public readonly int2 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(w, z); }
        public readonly int2 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(w, w); }
        public readonly int3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, x, x); }
        public readonly int3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, x, y); }
        public readonly int3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, x, z); }
        public readonly int3 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, x, w); }
        public readonly int3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, y, x); }
        public readonly int3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, y, y); }
        public readonly int3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, y, z); }
        public readonly int3 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, y, w); }
        public readonly int3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, z, x); }
        public readonly int3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, z, y); }
        public readonly int3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, z, z); }
        public readonly int3 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, z, w); }
        public readonly int3 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, w, x); }
        public readonly int3 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, w, y); }
        public readonly int3 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, w, z); }
        public readonly int3 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, w, w); }
        public readonly int3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, x, x); }
        public readonly int3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, x, y); }
        public readonly int3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, x, z); }
        public readonly int3 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, x, w); }
        public readonly int3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, y, x); }
        public readonly int3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, y, y); }
        public readonly int3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, y, z); }
        public readonly int3 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, y, w); }
        public readonly int3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, z, x); }
        public readonly int3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, z, y); }
        public readonly int3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, z, z); }
        public readonly int3 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, z, w); }
        public readonly int3 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, w, x); }
        public readonly int3 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, w, y); }
        public readonly int3 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, w, z); }
        public readonly int3 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, w, w); }
        public readonly int3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, x, x); }
        public readonly int3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, x, y); }
        public readonly int3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, x, z); }
        public readonly int3 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, x, w); }
        public readonly int3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, y, x); }
        public readonly int3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, y, y); }
        public readonly int3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, y, z); }
        public readonly int3 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, y, w); }
        public readonly int3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, z, x); }
        public readonly int3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, z, y); }
        public readonly int3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, z, z); }
        public readonly int3 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, z, w); }
        public readonly int3 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, w, x); }
        public readonly int3 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, w, y); }
        public readonly int3 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, w, z); }
        public readonly int3 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(z, w, w); }
        public readonly int3 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, x, x); }
        public readonly int3 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, x, y); }
        public readonly int3 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, x, z); }
        public readonly int3 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, x, w); }
        public readonly int3 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, y, x); }
        public readonly int3 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, y, y); }
        public readonly int3 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, y, z); }
        public readonly int3 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, y, w); }
        public readonly int3 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, z, x); }
        public readonly int3 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, z, y); }
        public readonly int3 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, z, z); }
        public readonly int3 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, z, w); }
        public readonly int3 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, w, x); }
        public readonly int3 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, w, y); }
        public readonly int3 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, w, z); }
        public readonly int3 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(w, w, w); }
        public readonly int4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, x, x); }
        public readonly int4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, x, y); }
        public readonly int4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, x, z); }
        public readonly int4 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, x, w); }
        public readonly int4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, y, x); }
        public readonly int4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, y, y); }
        public readonly int4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, y, z); }
        public readonly int4 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, y, w); }
        public readonly int4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, z, x); }
        public readonly int4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, z, y); }
        public readonly int4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, z, z); }
        public readonly int4 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, z, w); }
        public readonly int4 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, w, x); }
        public readonly int4 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, w, y); }
        public readonly int4 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, w, z); }
        public readonly int4 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, w, w); }
        public readonly int4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, x, x); }
        public readonly int4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, x, y); }
        public readonly int4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, x, z); }
        public readonly int4 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, x, w); }
        public readonly int4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, y, x); }
        public readonly int4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, y, y); }
        public readonly int4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, y, z); }
        public readonly int4 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, y, w); }
        public readonly int4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, z, x); }
        public readonly int4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, z, y); }
        public readonly int4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, z, z); }
        public readonly int4 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, z, w); }
        public readonly int4 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, w, x); }
        public readonly int4 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, w, y); }
        public readonly int4 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, w, z); }
        public readonly int4 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, w, w); }
        public readonly int4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, x, x); }
        public readonly int4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, x, y); }
        public readonly int4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, x, z); }
        public readonly int4 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, x, w); }
        public readonly int4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, y, x); }
        public readonly int4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, y, y); }
        public readonly int4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, y, z); }
        public readonly int4 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, y, w); }
        public readonly int4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, z, x); }
        public readonly int4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, z, y); }
        public readonly int4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, z, z); }
        public readonly int4 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, z, w); }
        public readonly int4 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, w, x); }
        public readonly int4 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, w, y); }
        public readonly int4 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, w, z); }
        public readonly int4 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, z, w, w); }
        public readonly int4 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, x, x); }
        public readonly int4 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, x, y); }
        public readonly int4 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, x, z); }
        public readonly int4 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, x, w); }
        public readonly int4 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, y, x); }
        public readonly int4 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, y, y); }
        public readonly int4 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, y, z); }
        public readonly int4 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, y, w); }
        public readonly int4 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, z, x); }
        public readonly int4 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, z, y); }
        public readonly int4 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, z, z); }
        public readonly int4 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, z, w); }
        public readonly int4 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, w, x); }
        public readonly int4 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, w, y); }
        public readonly int4 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, w, z); }
        public readonly int4 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, w, w, w); }
        public readonly int4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, x, x); }
        public readonly int4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, x, y); }
        public readonly int4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, x, z); }
        public readonly int4 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, x, w); }
        public readonly int4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, y, x); }
        public readonly int4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, y, y); }
        public readonly int4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, y, z); }
        public readonly int4 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, y, w); }
        public readonly int4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, z, x); }
        public readonly int4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, z, y); }
        public readonly int4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, z, z); }
        public readonly int4 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, z, w); }
        public readonly int4 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, w, x); }
        public readonly int4 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, w, y); }
        public readonly int4 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, w, z); }
        public readonly int4 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, w, w); }
        public readonly int4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, x, x); }
        public readonly int4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, x, y); }
        public readonly int4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, x, z); }
        public readonly int4 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, x, w); }
        public readonly int4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, y, x); }
        public readonly int4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, y, y); }
        public readonly int4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, y, z); }
        public readonly int4 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, y, w); }
        public readonly int4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, z, x); }
        public readonly int4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, z, y); }
        public readonly int4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, z, z); }
        public readonly int4 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, z, w); }
        public readonly int4 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, w, x); }
        public readonly int4 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, w, y); }
        public readonly int4 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, w, z); }
        public readonly int4 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, w, w); }
        public readonly int4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, x, x); }
        public readonly int4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, x, y); }
        public readonly int4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, x, z); }
        public readonly int4 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, x, w); }
        public readonly int4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, y, x); }
        public readonly int4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, y, y); }
        public readonly int4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, y, z); }
        public readonly int4 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, y, w); }
        public readonly int4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, z, x); }
        public readonly int4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, z, y); }
        public readonly int4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, z, z); }
        public readonly int4 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, z, w); }
        public readonly int4 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, w, x); }
        public readonly int4 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, w, y); }
        public readonly int4 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, w, z); }
        public readonly int4 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, z, w, w); }
        public readonly int4 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, x, x); }
        public readonly int4 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, x, y); }
        public readonly int4 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, x, z); }
        public readonly int4 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, x, w); }
        public readonly int4 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, y, x); }
        public readonly int4 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, y, y); }
        public readonly int4 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, y, z); }
        public readonly int4 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, y, w); }
        public readonly int4 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, z, x); }
        public readonly int4 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, z, y); }
        public readonly int4 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, z, z); }
        public readonly int4 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, z, w); }
        public readonly int4 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, w, x); }
        public readonly int4 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, w, y); }
        public readonly int4 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, w, z); }
        public readonly int4 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, w, w, w); }
        public readonly int4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, x, x); }
        public readonly int4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, x, y); }
        public readonly int4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, x, z); }
        public readonly int4 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, x, w); }
        public readonly int4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, y, x); }
        public readonly int4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, y, y); }
        public readonly int4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, y, z); }
        public readonly int4 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, y, w); }
        public readonly int4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, z, x); }
        public readonly int4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, z, y); }
        public readonly int4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, z, z); }
        public readonly int4 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, z, w); }
        public readonly int4 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, w, x); }
        public readonly int4 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, w, y); }
        public readonly int4 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, w, z); }
        public readonly int4 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, x, w, w); }
        public readonly int4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, x, x); }
        public readonly int4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, x, y); }
        public readonly int4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, x, z); }
        public readonly int4 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, x, w); }
        public readonly int4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, y, x); }
        public readonly int4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, y, y); }
        public readonly int4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, y, z); }
        public readonly int4 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, y, w); }
        public readonly int4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, z, x); }
        public readonly int4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, z, y); }
        public readonly int4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, z, z); }
        public readonly int4 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, z, w); }
        public readonly int4 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, w, x); }
        public readonly int4 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, w, y); }
        public readonly int4 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, w, z); }
        public readonly int4 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, y, w, w); }
        public readonly int4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, x, x); }
        public readonly int4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, x, y); }
        public readonly int4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, x, z); }
        public readonly int4 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, x, w); }
        public readonly int4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, y, x); }
        public readonly int4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, y, y); }
        public readonly int4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, y, z); }
        public readonly int4 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, y, w); }
        public readonly int4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, z, x); }
        public readonly int4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, z, y); }
        public readonly int4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, z, z); }
        public readonly int4 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, z, w); }
        public readonly int4 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, w, x); }
        public readonly int4 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, w, y); }
        public readonly int4 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, w, z); }
        public readonly int4 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, z, w, w); }
        public readonly int4 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, x, x); }
        public readonly int4 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, x, y); }
        public readonly int4 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, x, z); }
        public readonly int4 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, x, w); }
        public readonly int4 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, y, x); }
        public readonly int4 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, y, y); }
        public readonly int4 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, y, z); }
        public readonly int4 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, y, w); }
        public readonly int4 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, z, x); }
        public readonly int4 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, z, y); }
        public readonly int4 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, z, z); }
        public readonly int4 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, z, w); }
        public readonly int4 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, w, x); }
        public readonly int4 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, w, y); }
        public readonly int4 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, w, z); }
        public readonly int4 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(z, w, w, w); }
        public readonly int4 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, x, x); }
        public readonly int4 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, x, y); }
        public readonly int4 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, x, z); }
        public readonly int4 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, x, w); }
        public readonly int4 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, y, x); }
        public readonly int4 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, y, y); }
        public readonly int4 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, y, z); }
        public readonly int4 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, y, w); }
        public readonly int4 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, z, x); }
        public readonly int4 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, z, y); }
        public readonly int4 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, z, z); }
        public readonly int4 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, z, w); }
        public readonly int4 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, w, x); }
        public readonly int4 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, w, y); }
        public readonly int4 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, w, z); }
        public readonly int4 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, x, w, w); }
        public readonly int4 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, x, x); }
        public readonly int4 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, x, y); }
        public readonly int4 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, x, z); }
        public readonly int4 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, x, w); }
        public readonly int4 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, y, x); }
        public readonly int4 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, y, y); }
        public readonly int4 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, y, z); }
        public readonly int4 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, y, w); }
        public readonly int4 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, z, x); }
        public readonly int4 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, z, y); }
        public readonly int4 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, z, z); }
        public readonly int4 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, z, w); }
        public readonly int4 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, w, x); }
        public readonly int4 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, w, y); }
        public readonly int4 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, w, z); }
        public readonly int4 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, y, w, w); }
        public readonly int4 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, x, x); }
        public readonly int4 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, x, y); }
        public readonly int4 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, x, z); }
        public readonly int4 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, x, w); }
        public readonly int4 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, y, x); }
        public readonly int4 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, y, y); }
        public readonly int4 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, y, z); }
        public readonly int4 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, y, w); }
        public readonly int4 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, z, x); }
        public readonly int4 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, z, y); }
        public readonly int4 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, z, z); }
        public readonly int4 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, z, w); }
        public readonly int4 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, w, x); }
        public readonly int4 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, w, y); }
        public readonly int4 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, w, z); }
        public readonly int4 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, z, w, w); }
        public readonly int4 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, x, x); }
        public readonly int4 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, x, y); }
        public readonly int4 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, x, z); }
        public readonly int4 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, x, w); }
        public readonly int4 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, y, x); }
        public readonly int4 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, y, y); }
        public readonly int4 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, y, z); }
        public readonly int4 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, y, w); }
        public readonly int4 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, z, x); }
        public readonly int4 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, z, y); }
        public readonly int4 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, z, z); }
        public readonly int4 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, z, w); }
        public readonly int4 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, w, x); }
        public readonly int4 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, w, y); }
        public readonly int4 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, w, z); }
        public readonly int4 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(w, w, w, w); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(int4 lhs, int4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(int4 lhs, int4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is int4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"int4({x}, {y}, {z}, {w})";

        // IEquatable<int4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(int4 other)
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
            return $"int4({x}, {y}, {z}, {w})";
        }
    }

    public static partial class math {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 int4(int x, int y, int z, int w) => new int4(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 int4(int x, int y, int2 zw) => new int4(x, y, zw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 int4(int x, int3 yzw) => new int4(x, yzw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 int4(int2 xy, int2 zw) => new int4(xy, zw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 int4(int4 xyzw) => new int4(xyzw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 int4(int x, int2 yz, int w) => new int4(x, yz, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 int4(int3 xyz, int w) => new int4(xyz, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 int4(int2 xy, int z, int w) => new int4(xy, z, w);
    }
}

#endif
