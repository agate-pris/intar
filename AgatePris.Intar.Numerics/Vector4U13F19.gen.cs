using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U13F19 : IEquatable<Vector4U13F19>, IFormattable {
        // Fields
        // ---------------------------------------

        public U13F19 x;
        public U13F19 y;
        public U13F19 z;
        public U13F19 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U13F19 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, U13F19 y, U13F19 z, U13F19 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, U13F19 y, Vector2U13F19 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, Vector3U13F19 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector2U13F19 xy, Vector2U13F19 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector4U13F19 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, Vector2U13F19 yz, U13F19 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector3U13F19 xyz, U13F19 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector2U13F19 xy, U13F19 z, U13F19 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator +(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator -(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator *(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator *(Vector4U13F19 a, U13F19 b) => new Vector4U13F19(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator *(U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator /(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator /(Vector4U13F19 a, U13F19 b) => new Vector4U13F19(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator /(U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U13F19 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(x, x); }
        public readonly Vector2U13F19 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(x, y); }
        public readonly Vector2U13F19 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(x, z); }
        public readonly Vector2U13F19 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(x, w); }
        public readonly Vector2U13F19 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(y, x); }
        public readonly Vector2U13F19 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(y, y); }
        public readonly Vector2U13F19 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(y, z); }
        public readonly Vector2U13F19 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(y, w); }
        public readonly Vector2U13F19 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(z, x); }
        public readonly Vector2U13F19 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(z, y); }
        public readonly Vector2U13F19 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(z, z); }
        public readonly Vector2U13F19 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(z, w); }
        public readonly Vector2U13F19 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(w, x); }
        public readonly Vector2U13F19 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(w, y); }
        public readonly Vector2U13F19 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(w, z); }
        public readonly Vector2U13F19 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(w, w); }
        public readonly Vector3U13F19 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, x, x); }
        public readonly Vector3U13F19 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, x, y); }
        public readonly Vector3U13F19 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, x, z); }
        public readonly Vector3U13F19 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, x, w); }
        public readonly Vector3U13F19 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, y, x); }
        public readonly Vector3U13F19 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, y, y); }
        public readonly Vector3U13F19 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, y, z); }
        public readonly Vector3U13F19 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, y, w); }
        public readonly Vector3U13F19 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, z, x); }
        public readonly Vector3U13F19 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, z, y); }
        public readonly Vector3U13F19 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, z, z); }
        public readonly Vector3U13F19 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, z, w); }
        public readonly Vector3U13F19 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, w, x); }
        public readonly Vector3U13F19 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, w, y); }
        public readonly Vector3U13F19 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, w, z); }
        public readonly Vector3U13F19 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, w, w); }
        public readonly Vector3U13F19 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, x, x); }
        public readonly Vector3U13F19 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, x, y); }
        public readonly Vector3U13F19 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, x, z); }
        public readonly Vector3U13F19 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, x, w); }
        public readonly Vector3U13F19 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, y, x); }
        public readonly Vector3U13F19 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, y, y); }
        public readonly Vector3U13F19 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, y, z); }
        public readonly Vector3U13F19 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, y, w); }
        public readonly Vector3U13F19 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, z, x); }
        public readonly Vector3U13F19 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, z, y); }
        public readonly Vector3U13F19 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, z, z); }
        public readonly Vector3U13F19 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, z, w); }
        public readonly Vector3U13F19 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, w, x); }
        public readonly Vector3U13F19 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, w, y); }
        public readonly Vector3U13F19 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, w, z); }
        public readonly Vector3U13F19 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, w, w); }
        public readonly Vector3U13F19 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, x, x); }
        public readonly Vector3U13F19 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, x, y); }
        public readonly Vector3U13F19 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, x, z); }
        public readonly Vector3U13F19 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, x, w); }
        public readonly Vector3U13F19 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, y, x); }
        public readonly Vector3U13F19 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, y, y); }
        public readonly Vector3U13F19 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, y, z); }
        public readonly Vector3U13F19 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, y, w); }
        public readonly Vector3U13F19 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, z, x); }
        public readonly Vector3U13F19 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, z, y); }
        public readonly Vector3U13F19 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, z, z); }
        public readonly Vector3U13F19 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, z, w); }
        public readonly Vector3U13F19 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, w, x); }
        public readonly Vector3U13F19 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, w, y); }
        public readonly Vector3U13F19 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, w, z); }
        public readonly Vector3U13F19 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, w, w); }
        public readonly Vector3U13F19 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, x, x); }
        public readonly Vector3U13F19 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, x, y); }
        public readonly Vector3U13F19 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, x, z); }
        public readonly Vector3U13F19 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, x, w); }
        public readonly Vector3U13F19 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, y, x); }
        public readonly Vector3U13F19 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, y, y); }
        public readonly Vector3U13F19 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, y, z); }
        public readonly Vector3U13F19 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, y, w); }
        public readonly Vector3U13F19 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, z, x); }
        public readonly Vector3U13F19 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, z, y); }
        public readonly Vector3U13F19 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, z, z); }
        public readonly Vector3U13F19 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, z, w); }
        public readonly Vector3U13F19 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, w, x); }
        public readonly Vector3U13F19 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, w, y); }
        public readonly Vector3U13F19 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, w, z); }
        public readonly Vector3U13F19 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(w, w, w); }
        public readonly Vector4U13F19 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, x, x); }
        public readonly Vector4U13F19 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, x, y); }
        public readonly Vector4U13F19 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, x, z); }
        public readonly Vector4U13F19 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, x, w); }
        public readonly Vector4U13F19 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, y, x); }
        public readonly Vector4U13F19 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, y, y); }
        public readonly Vector4U13F19 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, y, z); }
        public readonly Vector4U13F19 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, y, w); }
        public readonly Vector4U13F19 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, z, x); }
        public readonly Vector4U13F19 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, z, y); }
        public readonly Vector4U13F19 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, z, z); }
        public readonly Vector4U13F19 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, z, w); }
        public readonly Vector4U13F19 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, w, x); }
        public readonly Vector4U13F19 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, w, y); }
        public readonly Vector4U13F19 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, w, z); }
        public readonly Vector4U13F19 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, w, w); }
        public readonly Vector4U13F19 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, x, x); }
        public readonly Vector4U13F19 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, x, y); }
        public readonly Vector4U13F19 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, x, z); }
        public readonly Vector4U13F19 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, x, w); }
        public readonly Vector4U13F19 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, y, x); }
        public readonly Vector4U13F19 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, y, y); }
        public readonly Vector4U13F19 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, y, z); }
        public readonly Vector4U13F19 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, y, w); }
        public readonly Vector4U13F19 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, z, x); }
        public readonly Vector4U13F19 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, z, y); }
        public readonly Vector4U13F19 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, z, z); }
        public readonly Vector4U13F19 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, z, w); }
        public readonly Vector4U13F19 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, w, x); }
        public readonly Vector4U13F19 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, w, y); }
        public readonly Vector4U13F19 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, w, z); }
        public readonly Vector4U13F19 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, w, w); }
        public readonly Vector4U13F19 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, x, x); }
        public readonly Vector4U13F19 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, x, y); }
        public readonly Vector4U13F19 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, x, z); }
        public readonly Vector4U13F19 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, x, w); }
        public readonly Vector4U13F19 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, y, x); }
        public readonly Vector4U13F19 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, y, y); }
        public readonly Vector4U13F19 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, y, z); }
        public readonly Vector4U13F19 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, y, w); }
        public readonly Vector4U13F19 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, z, x); }
        public readonly Vector4U13F19 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, z, y); }
        public readonly Vector4U13F19 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, z, z); }
        public readonly Vector4U13F19 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, z, w); }
        public readonly Vector4U13F19 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, w, x); }
        public readonly Vector4U13F19 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, w, y); }
        public readonly Vector4U13F19 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, w, z); }
        public readonly Vector4U13F19 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, w, w); }
        public readonly Vector4U13F19 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, x, x); }
        public readonly Vector4U13F19 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, x, y); }
        public readonly Vector4U13F19 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, x, z); }
        public readonly Vector4U13F19 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, x, w); }
        public readonly Vector4U13F19 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, y, x); }
        public readonly Vector4U13F19 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, y, y); }
        public readonly Vector4U13F19 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, y, z); }
        public readonly Vector4U13F19 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, y, w); }
        public readonly Vector4U13F19 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, z, x); }
        public readonly Vector4U13F19 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, z, y); }
        public readonly Vector4U13F19 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, z, z); }
        public readonly Vector4U13F19 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, z, w); }
        public readonly Vector4U13F19 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, w, x); }
        public readonly Vector4U13F19 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, w, y); }
        public readonly Vector4U13F19 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, w, z); }
        public readonly Vector4U13F19 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, w, w, w); }
        public readonly Vector4U13F19 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, x, x); }
        public readonly Vector4U13F19 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, x, y); }
        public readonly Vector4U13F19 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, x, z); }
        public readonly Vector4U13F19 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, x, w); }
        public readonly Vector4U13F19 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, y, x); }
        public readonly Vector4U13F19 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, y, y); }
        public readonly Vector4U13F19 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, y, z); }
        public readonly Vector4U13F19 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, y, w); }
        public readonly Vector4U13F19 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, z, x); }
        public readonly Vector4U13F19 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, z, y); }
        public readonly Vector4U13F19 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, z, z); }
        public readonly Vector4U13F19 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, z, w); }
        public readonly Vector4U13F19 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, w, x); }
        public readonly Vector4U13F19 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, w, y); }
        public readonly Vector4U13F19 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, w, z); }
        public readonly Vector4U13F19 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, w, w); }
        public readonly Vector4U13F19 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, x, x); }
        public readonly Vector4U13F19 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, x, y); }
        public readonly Vector4U13F19 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, x, z); }
        public readonly Vector4U13F19 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, x, w); }
        public readonly Vector4U13F19 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, y, x); }
        public readonly Vector4U13F19 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, y, y); }
        public readonly Vector4U13F19 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, y, z); }
        public readonly Vector4U13F19 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, y, w); }
        public readonly Vector4U13F19 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, z, x); }
        public readonly Vector4U13F19 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, z, y); }
        public readonly Vector4U13F19 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, z, z); }
        public readonly Vector4U13F19 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, z, w); }
        public readonly Vector4U13F19 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, w, x); }
        public readonly Vector4U13F19 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, w, y); }
        public readonly Vector4U13F19 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, w, z); }
        public readonly Vector4U13F19 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, w, w); }
        public readonly Vector4U13F19 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, x, x); }
        public readonly Vector4U13F19 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, x, y); }
        public readonly Vector4U13F19 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, x, z); }
        public readonly Vector4U13F19 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, x, w); }
        public readonly Vector4U13F19 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, y, x); }
        public readonly Vector4U13F19 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, y, y); }
        public readonly Vector4U13F19 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, y, z); }
        public readonly Vector4U13F19 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, y, w); }
        public readonly Vector4U13F19 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, z, x); }
        public readonly Vector4U13F19 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, z, y); }
        public readonly Vector4U13F19 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, z, z); }
        public readonly Vector4U13F19 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, z, w); }
        public readonly Vector4U13F19 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, w, x); }
        public readonly Vector4U13F19 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, w, y); }
        public readonly Vector4U13F19 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, w, z); }
        public readonly Vector4U13F19 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, w, w); }
        public readonly Vector4U13F19 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, x, x); }
        public readonly Vector4U13F19 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, x, y); }
        public readonly Vector4U13F19 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, x, z); }
        public readonly Vector4U13F19 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, x, w); }
        public readonly Vector4U13F19 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, y, x); }
        public readonly Vector4U13F19 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, y, y); }
        public readonly Vector4U13F19 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, y, z); }
        public readonly Vector4U13F19 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, y, w); }
        public readonly Vector4U13F19 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, z, x); }
        public readonly Vector4U13F19 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, z, y); }
        public readonly Vector4U13F19 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, z, z); }
        public readonly Vector4U13F19 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, z, w); }
        public readonly Vector4U13F19 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, w, x); }
        public readonly Vector4U13F19 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, w, y); }
        public readonly Vector4U13F19 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, w, z); }
        public readonly Vector4U13F19 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, w, w, w); }
        public readonly Vector4U13F19 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, x, x); }
        public readonly Vector4U13F19 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, x, y); }
        public readonly Vector4U13F19 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, x, z); }
        public readonly Vector4U13F19 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, x, w); }
        public readonly Vector4U13F19 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, y, x); }
        public readonly Vector4U13F19 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, y, y); }
        public readonly Vector4U13F19 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, y, z); }
        public readonly Vector4U13F19 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, y, w); }
        public readonly Vector4U13F19 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, z, x); }
        public readonly Vector4U13F19 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, z, y); }
        public readonly Vector4U13F19 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, z, z); }
        public readonly Vector4U13F19 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, z, w); }
        public readonly Vector4U13F19 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, w, x); }
        public readonly Vector4U13F19 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, w, y); }
        public readonly Vector4U13F19 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, w, z); }
        public readonly Vector4U13F19 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, w, w); }
        public readonly Vector4U13F19 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, x, x); }
        public readonly Vector4U13F19 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, x, y); }
        public readonly Vector4U13F19 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, x, z); }
        public readonly Vector4U13F19 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, x, w); }
        public readonly Vector4U13F19 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, y, x); }
        public readonly Vector4U13F19 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, y, y); }
        public readonly Vector4U13F19 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, y, z); }
        public readonly Vector4U13F19 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, y, w); }
        public readonly Vector4U13F19 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, z, x); }
        public readonly Vector4U13F19 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, z, y); }
        public readonly Vector4U13F19 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, z, z); }
        public readonly Vector4U13F19 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, z, w); }
        public readonly Vector4U13F19 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, w, x); }
        public readonly Vector4U13F19 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, w, y); }
        public readonly Vector4U13F19 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, w, z); }
        public readonly Vector4U13F19 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, w, w); }
        public readonly Vector4U13F19 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, x, x); }
        public readonly Vector4U13F19 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, x, y); }
        public readonly Vector4U13F19 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, x, z); }
        public readonly Vector4U13F19 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, x, w); }
        public readonly Vector4U13F19 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, y, x); }
        public readonly Vector4U13F19 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, y, y); }
        public readonly Vector4U13F19 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, y, z); }
        public readonly Vector4U13F19 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, y, w); }
        public readonly Vector4U13F19 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, z, x); }
        public readonly Vector4U13F19 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, z, y); }
        public readonly Vector4U13F19 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, z, z); }
        public readonly Vector4U13F19 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, z, w); }
        public readonly Vector4U13F19 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, w, x); }
        public readonly Vector4U13F19 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, w, y); }
        public readonly Vector4U13F19 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, w, z); }
        public readonly Vector4U13F19 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, w, w); }
        public readonly Vector4U13F19 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, x, x); }
        public readonly Vector4U13F19 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, x, y); }
        public readonly Vector4U13F19 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, x, z); }
        public readonly Vector4U13F19 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, x, w); }
        public readonly Vector4U13F19 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, y, x); }
        public readonly Vector4U13F19 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, y, y); }
        public readonly Vector4U13F19 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, y, z); }
        public readonly Vector4U13F19 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, y, w); }
        public readonly Vector4U13F19 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, z, x); }
        public readonly Vector4U13F19 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, z, y); }
        public readonly Vector4U13F19 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, z, z); }
        public readonly Vector4U13F19 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, z, w); }
        public readonly Vector4U13F19 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, w, x); }
        public readonly Vector4U13F19 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, w, y); }
        public readonly Vector4U13F19 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, w, z); }
        public readonly Vector4U13F19 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, w, w, w); }
        public readonly Vector4U13F19 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, x, x); }
        public readonly Vector4U13F19 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, x, y); }
        public readonly Vector4U13F19 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, x, z); }
        public readonly Vector4U13F19 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, x, w); }
        public readonly Vector4U13F19 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, y, x); }
        public readonly Vector4U13F19 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, y, y); }
        public readonly Vector4U13F19 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, y, z); }
        public readonly Vector4U13F19 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, y, w); }
        public readonly Vector4U13F19 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, z, x); }
        public readonly Vector4U13F19 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, z, y); }
        public readonly Vector4U13F19 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, z, z); }
        public readonly Vector4U13F19 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, z, w); }
        public readonly Vector4U13F19 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, w, x); }
        public readonly Vector4U13F19 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, w, y); }
        public readonly Vector4U13F19 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, w, z); }
        public readonly Vector4U13F19 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, x, w, w); }
        public readonly Vector4U13F19 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, x, x); }
        public readonly Vector4U13F19 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, x, y); }
        public readonly Vector4U13F19 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, x, z); }
        public readonly Vector4U13F19 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, x, w); }
        public readonly Vector4U13F19 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, y, x); }
        public readonly Vector4U13F19 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, y, y); }
        public readonly Vector4U13F19 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, y, z); }
        public readonly Vector4U13F19 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, y, w); }
        public readonly Vector4U13F19 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, z, x); }
        public readonly Vector4U13F19 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, z, y); }
        public readonly Vector4U13F19 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, z, z); }
        public readonly Vector4U13F19 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, z, w); }
        public readonly Vector4U13F19 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, w, x); }
        public readonly Vector4U13F19 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, w, y); }
        public readonly Vector4U13F19 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, w, z); }
        public readonly Vector4U13F19 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, y, w, w); }
        public readonly Vector4U13F19 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, x, x); }
        public readonly Vector4U13F19 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, x, y); }
        public readonly Vector4U13F19 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, x, z); }
        public readonly Vector4U13F19 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, x, w); }
        public readonly Vector4U13F19 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, y, x); }
        public readonly Vector4U13F19 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, y, y); }
        public readonly Vector4U13F19 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, y, z); }
        public readonly Vector4U13F19 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, y, w); }
        public readonly Vector4U13F19 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, z, x); }
        public readonly Vector4U13F19 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, z, y); }
        public readonly Vector4U13F19 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, z, z); }
        public readonly Vector4U13F19 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, z, w); }
        public readonly Vector4U13F19 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, w, x); }
        public readonly Vector4U13F19 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, w, y); }
        public readonly Vector4U13F19 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, w, z); }
        public readonly Vector4U13F19 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, z, w, w); }
        public readonly Vector4U13F19 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, x, x); }
        public readonly Vector4U13F19 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, x, y); }
        public readonly Vector4U13F19 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, x, z); }
        public readonly Vector4U13F19 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, x, w); }
        public readonly Vector4U13F19 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, y, x); }
        public readonly Vector4U13F19 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, y, y); }
        public readonly Vector4U13F19 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, y, z); }
        public readonly Vector4U13F19 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, y, w); }
        public readonly Vector4U13F19 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, z, x); }
        public readonly Vector4U13F19 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, z, y); }
        public readonly Vector4U13F19 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, z, z); }
        public readonly Vector4U13F19 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, z, w); }
        public readonly Vector4U13F19 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, w, x); }
        public readonly Vector4U13F19 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, w, y); }
        public readonly Vector4U13F19 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, w, z); }
        public readonly Vector4U13F19 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U13F19 lhs, Vector4U13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U13F19 lhs, Vector4U13F19 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U13F19({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U13F19 other)
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
            return $"Vector4U13F19({x}, {y}, {z}, {w})";
        }
    }
}
