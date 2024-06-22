using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U28F4 : IEquatable<Vector4U28F4>, IFormattable {
        // Fields
        // ---------------------------------------

        public U28F4 x;
        public U28F4 y;
        public U28F4 z;
        public U28F4 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U28F4 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, U28F4 y, U28F4 z, U28F4 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, U28F4 y, Vector2U28F4 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, Vector3U28F4 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector2U28F4 xy, Vector2U28F4 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector4U28F4 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, Vector2U28F4 yz, U28F4 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector3U28F4 xyz, U28F4 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector2U28F4 xy, U28F4 z, U28F4 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator +(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator -(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator *(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator *(Vector4U28F4 a, U28F4 b) => new Vector4U28F4(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator *(U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator /(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator /(Vector4U28F4 a, U28F4 b) => new Vector4U28F4(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator /(U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U28F4 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(x, x); }
        public readonly Vector2U28F4 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(x, y); }
        public readonly Vector2U28F4 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(x, z); }
        public readonly Vector2U28F4 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(x, w); }
        public readonly Vector2U28F4 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(y, x); }
        public readonly Vector2U28F4 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(y, y); }
        public readonly Vector2U28F4 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(y, z); }
        public readonly Vector2U28F4 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(y, w); }
        public readonly Vector2U28F4 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(z, x); }
        public readonly Vector2U28F4 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(z, y); }
        public readonly Vector2U28F4 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(z, z); }
        public readonly Vector2U28F4 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(z, w); }
        public readonly Vector2U28F4 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(w, x); }
        public readonly Vector2U28F4 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(w, y); }
        public readonly Vector2U28F4 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(w, z); }
        public readonly Vector2U28F4 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(w, w); }
        public readonly Vector3U28F4 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, x, x); }
        public readonly Vector3U28F4 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, x, y); }
        public readonly Vector3U28F4 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, x, z); }
        public readonly Vector3U28F4 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, x, w); }
        public readonly Vector3U28F4 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, y, x); }
        public readonly Vector3U28F4 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, y, y); }
        public readonly Vector3U28F4 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, y, z); }
        public readonly Vector3U28F4 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, y, w); }
        public readonly Vector3U28F4 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, z, x); }
        public readonly Vector3U28F4 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, z, y); }
        public readonly Vector3U28F4 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, z, z); }
        public readonly Vector3U28F4 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, z, w); }
        public readonly Vector3U28F4 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, w, x); }
        public readonly Vector3U28F4 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, w, y); }
        public readonly Vector3U28F4 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, w, z); }
        public readonly Vector3U28F4 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, w, w); }
        public readonly Vector3U28F4 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, x, x); }
        public readonly Vector3U28F4 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, x, y); }
        public readonly Vector3U28F4 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, x, z); }
        public readonly Vector3U28F4 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, x, w); }
        public readonly Vector3U28F4 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, y, x); }
        public readonly Vector3U28F4 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, y, y); }
        public readonly Vector3U28F4 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, y, z); }
        public readonly Vector3U28F4 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, y, w); }
        public readonly Vector3U28F4 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, z, x); }
        public readonly Vector3U28F4 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, z, y); }
        public readonly Vector3U28F4 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, z, z); }
        public readonly Vector3U28F4 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, z, w); }
        public readonly Vector3U28F4 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, w, x); }
        public readonly Vector3U28F4 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, w, y); }
        public readonly Vector3U28F4 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, w, z); }
        public readonly Vector3U28F4 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, w, w); }
        public readonly Vector3U28F4 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, x, x); }
        public readonly Vector3U28F4 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, x, y); }
        public readonly Vector3U28F4 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, x, z); }
        public readonly Vector3U28F4 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, x, w); }
        public readonly Vector3U28F4 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, y, x); }
        public readonly Vector3U28F4 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, y, y); }
        public readonly Vector3U28F4 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, y, z); }
        public readonly Vector3U28F4 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, y, w); }
        public readonly Vector3U28F4 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, z, x); }
        public readonly Vector3U28F4 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, z, y); }
        public readonly Vector3U28F4 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, z, z); }
        public readonly Vector3U28F4 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, z, w); }
        public readonly Vector3U28F4 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, w, x); }
        public readonly Vector3U28F4 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, w, y); }
        public readonly Vector3U28F4 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, w, z); }
        public readonly Vector3U28F4 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, w, w); }
        public readonly Vector3U28F4 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, x, x); }
        public readonly Vector3U28F4 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, x, y); }
        public readonly Vector3U28F4 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, x, z); }
        public readonly Vector3U28F4 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, x, w); }
        public readonly Vector3U28F4 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, y, x); }
        public readonly Vector3U28F4 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, y, y); }
        public readonly Vector3U28F4 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, y, z); }
        public readonly Vector3U28F4 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, y, w); }
        public readonly Vector3U28F4 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, z, x); }
        public readonly Vector3U28F4 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, z, y); }
        public readonly Vector3U28F4 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, z, z); }
        public readonly Vector3U28F4 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, z, w); }
        public readonly Vector3U28F4 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, w, x); }
        public readonly Vector3U28F4 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, w, y); }
        public readonly Vector3U28F4 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, w, z); }
        public readonly Vector3U28F4 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(w, w, w); }
        public readonly Vector4U28F4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, x, x); }
        public readonly Vector4U28F4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, x, y); }
        public readonly Vector4U28F4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, x, z); }
        public readonly Vector4U28F4 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, x, w); }
        public readonly Vector4U28F4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, y, x); }
        public readonly Vector4U28F4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, y, y); }
        public readonly Vector4U28F4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, y, z); }
        public readonly Vector4U28F4 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, y, w); }
        public readonly Vector4U28F4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, z, x); }
        public readonly Vector4U28F4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, z, y); }
        public readonly Vector4U28F4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, z, z); }
        public readonly Vector4U28F4 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, z, w); }
        public readonly Vector4U28F4 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, w, x); }
        public readonly Vector4U28F4 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, w, y); }
        public readonly Vector4U28F4 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, w, z); }
        public readonly Vector4U28F4 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, w, w); }
        public readonly Vector4U28F4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, x, x); }
        public readonly Vector4U28F4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, x, y); }
        public readonly Vector4U28F4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, x, z); }
        public readonly Vector4U28F4 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, x, w); }
        public readonly Vector4U28F4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, y, x); }
        public readonly Vector4U28F4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, y, y); }
        public readonly Vector4U28F4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, y, z); }
        public readonly Vector4U28F4 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, y, w); }
        public readonly Vector4U28F4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, z, x); }
        public readonly Vector4U28F4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, z, y); }
        public readonly Vector4U28F4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, z, z); }
        public readonly Vector4U28F4 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, z, w); }
        public readonly Vector4U28F4 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, w, x); }
        public readonly Vector4U28F4 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, w, y); }
        public readonly Vector4U28F4 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, w, z); }
        public readonly Vector4U28F4 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, w, w); }
        public readonly Vector4U28F4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, x, x); }
        public readonly Vector4U28F4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, x, y); }
        public readonly Vector4U28F4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, x, z); }
        public readonly Vector4U28F4 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, x, w); }
        public readonly Vector4U28F4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, y, x); }
        public readonly Vector4U28F4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, y, y); }
        public readonly Vector4U28F4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, y, z); }
        public readonly Vector4U28F4 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, y, w); }
        public readonly Vector4U28F4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, z, x); }
        public readonly Vector4U28F4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, z, y); }
        public readonly Vector4U28F4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, z, z); }
        public readonly Vector4U28F4 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, z, w); }
        public readonly Vector4U28F4 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, w, x); }
        public readonly Vector4U28F4 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, w, y); }
        public readonly Vector4U28F4 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, w, z); }
        public readonly Vector4U28F4 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, w, w); }
        public readonly Vector4U28F4 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, x, x); }
        public readonly Vector4U28F4 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, x, y); }
        public readonly Vector4U28F4 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, x, z); }
        public readonly Vector4U28F4 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, x, w); }
        public readonly Vector4U28F4 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, y, x); }
        public readonly Vector4U28F4 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, y, y); }
        public readonly Vector4U28F4 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, y, z); }
        public readonly Vector4U28F4 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, y, w); }
        public readonly Vector4U28F4 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, z, x); }
        public readonly Vector4U28F4 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, z, y); }
        public readonly Vector4U28F4 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, z, z); }
        public readonly Vector4U28F4 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, z, w); }
        public readonly Vector4U28F4 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, w, x); }
        public readonly Vector4U28F4 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, w, y); }
        public readonly Vector4U28F4 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, w, z); }
        public readonly Vector4U28F4 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, w, w, w); }
        public readonly Vector4U28F4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, x, x); }
        public readonly Vector4U28F4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, x, y); }
        public readonly Vector4U28F4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, x, z); }
        public readonly Vector4U28F4 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, x, w); }
        public readonly Vector4U28F4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, y, x); }
        public readonly Vector4U28F4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, y, y); }
        public readonly Vector4U28F4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, y, z); }
        public readonly Vector4U28F4 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, y, w); }
        public readonly Vector4U28F4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, z, x); }
        public readonly Vector4U28F4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, z, y); }
        public readonly Vector4U28F4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, z, z); }
        public readonly Vector4U28F4 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, z, w); }
        public readonly Vector4U28F4 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, w, x); }
        public readonly Vector4U28F4 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, w, y); }
        public readonly Vector4U28F4 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, w, z); }
        public readonly Vector4U28F4 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, w, w); }
        public readonly Vector4U28F4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, x, x); }
        public readonly Vector4U28F4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, x, y); }
        public readonly Vector4U28F4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, x, z); }
        public readonly Vector4U28F4 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, x, w); }
        public readonly Vector4U28F4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, y, x); }
        public readonly Vector4U28F4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, y, y); }
        public readonly Vector4U28F4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, y, z); }
        public readonly Vector4U28F4 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, y, w); }
        public readonly Vector4U28F4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, z, x); }
        public readonly Vector4U28F4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, z, y); }
        public readonly Vector4U28F4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, z, z); }
        public readonly Vector4U28F4 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, z, w); }
        public readonly Vector4U28F4 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, w, x); }
        public readonly Vector4U28F4 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, w, y); }
        public readonly Vector4U28F4 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, w, z); }
        public readonly Vector4U28F4 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, w, w); }
        public readonly Vector4U28F4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, x, x); }
        public readonly Vector4U28F4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, x, y); }
        public readonly Vector4U28F4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, x, z); }
        public readonly Vector4U28F4 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, x, w); }
        public readonly Vector4U28F4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, y, x); }
        public readonly Vector4U28F4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, y, y); }
        public readonly Vector4U28F4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, y, z); }
        public readonly Vector4U28F4 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, y, w); }
        public readonly Vector4U28F4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, z, x); }
        public readonly Vector4U28F4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, z, y); }
        public readonly Vector4U28F4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, z, z); }
        public readonly Vector4U28F4 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, z, w); }
        public readonly Vector4U28F4 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, w, x); }
        public readonly Vector4U28F4 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, w, y); }
        public readonly Vector4U28F4 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, w, z); }
        public readonly Vector4U28F4 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, w, w); }
        public readonly Vector4U28F4 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, x, x); }
        public readonly Vector4U28F4 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, x, y); }
        public readonly Vector4U28F4 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, x, z); }
        public readonly Vector4U28F4 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, x, w); }
        public readonly Vector4U28F4 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, y, x); }
        public readonly Vector4U28F4 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, y, y); }
        public readonly Vector4U28F4 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, y, z); }
        public readonly Vector4U28F4 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, y, w); }
        public readonly Vector4U28F4 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, z, x); }
        public readonly Vector4U28F4 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, z, y); }
        public readonly Vector4U28F4 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, z, z); }
        public readonly Vector4U28F4 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, z, w); }
        public readonly Vector4U28F4 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, w, x); }
        public readonly Vector4U28F4 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, w, y); }
        public readonly Vector4U28F4 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, w, z); }
        public readonly Vector4U28F4 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, w, w, w); }
        public readonly Vector4U28F4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, x, x); }
        public readonly Vector4U28F4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, x, y); }
        public readonly Vector4U28F4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, x, z); }
        public readonly Vector4U28F4 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, x, w); }
        public readonly Vector4U28F4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, y, x); }
        public readonly Vector4U28F4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, y, y); }
        public readonly Vector4U28F4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, y, z); }
        public readonly Vector4U28F4 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, y, w); }
        public readonly Vector4U28F4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, z, x); }
        public readonly Vector4U28F4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, z, y); }
        public readonly Vector4U28F4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, z, z); }
        public readonly Vector4U28F4 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, z, w); }
        public readonly Vector4U28F4 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, w, x); }
        public readonly Vector4U28F4 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, w, y); }
        public readonly Vector4U28F4 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, w, z); }
        public readonly Vector4U28F4 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, w, w); }
        public readonly Vector4U28F4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, x, x); }
        public readonly Vector4U28F4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, x, y); }
        public readonly Vector4U28F4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, x, z); }
        public readonly Vector4U28F4 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, x, w); }
        public readonly Vector4U28F4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, y, x); }
        public readonly Vector4U28F4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, y, y); }
        public readonly Vector4U28F4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, y, z); }
        public readonly Vector4U28F4 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, y, w); }
        public readonly Vector4U28F4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, z, x); }
        public readonly Vector4U28F4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, z, y); }
        public readonly Vector4U28F4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, z, z); }
        public readonly Vector4U28F4 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, z, w); }
        public readonly Vector4U28F4 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, w, x); }
        public readonly Vector4U28F4 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, w, y); }
        public readonly Vector4U28F4 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, w, z); }
        public readonly Vector4U28F4 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, w, w); }
        public readonly Vector4U28F4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, x, x); }
        public readonly Vector4U28F4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, x, y); }
        public readonly Vector4U28F4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, x, z); }
        public readonly Vector4U28F4 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, x, w); }
        public readonly Vector4U28F4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, y, x); }
        public readonly Vector4U28F4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, y, y); }
        public readonly Vector4U28F4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, y, z); }
        public readonly Vector4U28F4 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, y, w); }
        public readonly Vector4U28F4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, z, x); }
        public readonly Vector4U28F4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, z, y); }
        public readonly Vector4U28F4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, z, z); }
        public readonly Vector4U28F4 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, z, w); }
        public readonly Vector4U28F4 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, w, x); }
        public readonly Vector4U28F4 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, w, y); }
        public readonly Vector4U28F4 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, w, z); }
        public readonly Vector4U28F4 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, w, w); }
        public readonly Vector4U28F4 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, x, x); }
        public readonly Vector4U28F4 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, x, y); }
        public readonly Vector4U28F4 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, x, z); }
        public readonly Vector4U28F4 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, x, w); }
        public readonly Vector4U28F4 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, y, x); }
        public readonly Vector4U28F4 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, y, y); }
        public readonly Vector4U28F4 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, y, z); }
        public readonly Vector4U28F4 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, y, w); }
        public readonly Vector4U28F4 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, z, x); }
        public readonly Vector4U28F4 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, z, y); }
        public readonly Vector4U28F4 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, z, z); }
        public readonly Vector4U28F4 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, z, w); }
        public readonly Vector4U28F4 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, w, x); }
        public readonly Vector4U28F4 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, w, y); }
        public readonly Vector4U28F4 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, w, z); }
        public readonly Vector4U28F4 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, w, w, w); }
        public readonly Vector4U28F4 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, x, x); }
        public readonly Vector4U28F4 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, x, y); }
        public readonly Vector4U28F4 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, x, z); }
        public readonly Vector4U28F4 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, x, w); }
        public readonly Vector4U28F4 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, y, x); }
        public readonly Vector4U28F4 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, y, y); }
        public readonly Vector4U28F4 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, y, z); }
        public readonly Vector4U28F4 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, y, w); }
        public readonly Vector4U28F4 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, z, x); }
        public readonly Vector4U28F4 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, z, y); }
        public readonly Vector4U28F4 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, z, z); }
        public readonly Vector4U28F4 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, z, w); }
        public readonly Vector4U28F4 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, w, x); }
        public readonly Vector4U28F4 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, w, y); }
        public readonly Vector4U28F4 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, w, z); }
        public readonly Vector4U28F4 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, x, w, w); }
        public readonly Vector4U28F4 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, x, x); }
        public readonly Vector4U28F4 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, x, y); }
        public readonly Vector4U28F4 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, x, z); }
        public readonly Vector4U28F4 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, x, w); }
        public readonly Vector4U28F4 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, y, x); }
        public readonly Vector4U28F4 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, y, y); }
        public readonly Vector4U28F4 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, y, z); }
        public readonly Vector4U28F4 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, y, w); }
        public readonly Vector4U28F4 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, z, x); }
        public readonly Vector4U28F4 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, z, y); }
        public readonly Vector4U28F4 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, z, z); }
        public readonly Vector4U28F4 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, z, w); }
        public readonly Vector4U28F4 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, w, x); }
        public readonly Vector4U28F4 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, w, y); }
        public readonly Vector4U28F4 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, w, z); }
        public readonly Vector4U28F4 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, y, w, w); }
        public readonly Vector4U28F4 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, x, x); }
        public readonly Vector4U28F4 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, x, y); }
        public readonly Vector4U28F4 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, x, z); }
        public readonly Vector4U28F4 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, x, w); }
        public readonly Vector4U28F4 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, y, x); }
        public readonly Vector4U28F4 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, y, y); }
        public readonly Vector4U28F4 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, y, z); }
        public readonly Vector4U28F4 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, y, w); }
        public readonly Vector4U28F4 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, z, x); }
        public readonly Vector4U28F4 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, z, y); }
        public readonly Vector4U28F4 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, z, z); }
        public readonly Vector4U28F4 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, z, w); }
        public readonly Vector4U28F4 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, w, x); }
        public readonly Vector4U28F4 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, w, y); }
        public readonly Vector4U28F4 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, w, z); }
        public readonly Vector4U28F4 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, z, w, w); }
        public readonly Vector4U28F4 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, x, x); }
        public readonly Vector4U28F4 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, x, y); }
        public readonly Vector4U28F4 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, x, z); }
        public readonly Vector4U28F4 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, x, w); }
        public readonly Vector4U28F4 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, y, x); }
        public readonly Vector4U28F4 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, y, y); }
        public readonly Vector4U28F4 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, y, z); }
        public readonly Vector4U28F4 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, y, w); }
        public readonly Vector4U28F4 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, z, x); }
        public readonly Vector4U28F4 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, z, y); }
        public readonly Vector4U28F4 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, z, z); }
        public readonly Vector4U28F4 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, z, w); }
        public readonly Vector4U28F4 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, w, x); }
        public readonly Vector4U28F4 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, w, y); }
        public readonly Vector4U28F4 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, w, z); }
        public readonly Vector4U28F4 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U28F4 lhs, Vector4U28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U28F4 lhs, Vector4U28F4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U28F4({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U28F4 other)
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
            return $"Vector4U28F4({x}, {y}, {z}, {w})";
        }
    }
}
