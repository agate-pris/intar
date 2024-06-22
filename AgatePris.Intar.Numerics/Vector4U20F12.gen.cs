using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U20F12 : IEquatable<Vector4U20F12>, IFormattable {
        // Fields
        // ---------------------------------------

        public U20F12 x;
        public U20F12 y;
        public U20F12 z;
        public U20F12 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U20F12 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(U20F12 x, U20F12 y, U20F12 z, U20F12 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(U20F12 x, U20F12 y, Vector2U20F12 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(U20F12 x, Vector3U20F12 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(Vector2U20F12 xy, Vector2U20F12 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(Vector4U20F12 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(U20F12 x, Vector2U20F12 yz, U20F12 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(Vector3U20F12 xyz, U20F12 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(Vector2U20F12 xy, U20F12 z, U20F12 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator +(Vector4U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator -(Vector4U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator *(Vector4U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator *(Vector4U20F12 a, U20F12 b) => new Vector4U20F12(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator *(U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator /(Vector4U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator /(Vector4U20F12 a, U20F12 b) => new Vector4U20F12(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator /(U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U20F12 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(x, x); }
        public readonly Vector2U20F12 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(x, y); }
        public readonly Vector2U20F12 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(x, z); }
        public readonly Vector2U20F12 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(x, w); }
        public readonly Vector2U20F12 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(y, x); }
        public readonly Vector2U20F12 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(y, y); }
        public readonly Vector2U20F12 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(y, z); }
        public readonly Vector2U20F12 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(y, w); }
        public readonly Vector2U20F12 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(z, x); }
        public readonly Vector2U20F12 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(z, y); }
        public readonly Vector2U20F12 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(z, z); }
        public readonly Vector2U20F12 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(z, w); }
        public readonly Vector2U20F12 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(w, x); }
        public readonly Vector2U20F12 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(w, y); }
        public readonly Vector2U20F12 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(w, z); }
        public readonly Vector2U20F12 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(w, w); }
        public readonly Vector3U20F12 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, x, x); }
        public readonly Vector3U20F12 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, x, y); }
        public readonly Vector3U20F12 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, x, z); }
        public readonly Vector3U20F12 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, x, w); }
        public readonly Vector3U20F12 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, y, x); }
        public readonly Vector3U20F12 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, y, y); }
        public readonly Vector3U20F12 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, y, z); }
        public readonly Vector3U20F12 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, y, w); }
        public readonly Vector3U20F12 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, z, x); }
        public readonly Vector3U20F12 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, z, y); }
        public readonly Vector3U20F12 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, z, z); }
        public readonly Vector3U20F12 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, z, w); }
        public readonly Vector3U20F12 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, w, x); }
        public readonly Vector3U20F12 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, w, y); }
        public readonly Vector3U20F12 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, w, z); }
        public readonly Vector3U20F12 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, w, w); }
        public readonly Vector3U20F12 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, x, x); }
        public readonly Vector3U20F12 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, x, y); }
        public readonly Vector3U20F12 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, x, z); }
        public readonly Vector3U20F12 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, x, w); }
        public readonly Vector3U20F12 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, y, x); }
        public readonly Vector3U20F12 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, y, y); }
        public readonly Vector3U20F12 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, y, z); }
        public readonly Vector3U20F12 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, y, w); }
        public readonly Vector3U20F12 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, z, x); }
        public readonly Vector3U20F12 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, z, y); }
        public readonly Vector3U20F12 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, z, z); }
        public readonly Vector3U20F12 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, z, w); }
        public readonly Vector3U20F12 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, w, x); }
        public readonly Vector3U20F12 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, w, y); }
        public readonly Vector3U20F12 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, w, z); }
        public readonly Vector3U20F12 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, w, w); }
        public readonly Vector3U20F12 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, x, x); }
        public readonly Vector3U20F12 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, x, y); }
        public readonly Vector3U20F12 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, x, z); }
        public readonly Vector3U20F12 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, x, w); }
        public readonly Vector3U20F12 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, y, x); }
        public readonly Vector3U20F12 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, y, y); }
        public readonly Vector3U20F12 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, y, z); }
        public readonly Vector3U20F12 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, y, w); }
        public readonly Vector3U20F12 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, z, x); }
        public readonly Vector3U20F12 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, z, y); }
        public readonly Vector3U20F12 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, z, z); }
        public readonly Vector3U20F12 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, z, w); }
        public readonly Vector3U20F12 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, w, x); }
        public readonly Vector3U20F12 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, w, y); }
        public readonly Vector3U20F12 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, w, z); }
        public readonly Vector3U20F12 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, w, w); }
        public readonly Vector3U20F12 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, x, x); }
        public readonly Vector3U20F12 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, x, y); }
        public readonly Vector3U20F12 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, x, z); }
        public readonly Vector3U20F12 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, x, w); }
        public readonly Vector3U20F12 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, y, x); }
        public readonly Vector3U20F12 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, y, y); }
        public readonly Vector3U20F12 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, y, z); }
        public readonly Vector3U20F12 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, y, w); }
        public readonly Vector3U20F12 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, z, x); }
        public readonly Vector3U20F12 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, z, y); }
        public readonly Vector3U20F12 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, z, z); }
        public readonly Vector3U20F12 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, z, w); }
        public readonly Vector3U20F12 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, w, x); }
        public readonly Vector3U20F12 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, w, y); }
        public readonly Vector3U20F12 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, w, z); }
        public readonly Vector3U20F12 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(w, w, w); }
        public readonly Vector4U20F12 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, x, x); }
        public readonly Vector4U20F12 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, x, y); }
        public readonly Vector4U20F12 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, x, z); }
        public readonly Vector4U20F12 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, x, w); }
        public readonly Vector4U20F12 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, y, x); }
        public readonly Vector4U20F12 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, y, y); }
        public readonly Vector4U20F12 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, y, z); }
        public readonly Vector4U20F12 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, y, w); }
        public readonly Vector4U20F12 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, z, x); }
        public readonly Vector4U20F12 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, z, y); }
        public readonly Vector4U20F12 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, z, z); }
        public readonly Vector4U20F12 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, z, w); }
        public readonly Vector4U20F12 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, w, x); }
        public readonly Vector4U20F12 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, w, y); }
        public readonly Vector4U20F12 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, w, z); }
        public readonly Vector4U20F12 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, w, w); }
        public readonly Vector4U20F12 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, x, x); }
        public readonly Vector4U20F12 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, x, y); }
        public readonly Vector4U20F12 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, x, z); }
        public readonly Vector4U20F12 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, x, w); }
        public readonly Vector4U20F12 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, y, x); }
        public readonly Vector4U20F12 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, y, y); }
        public readonly Vector4U20F12 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, y, z); }
        public readonly Vector4U20F12 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, y, w); }
        public readonly Vector4U20F12 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, z, x); }
        public readonly Vector4U20F12 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, z, y); }
        public readonly Vector4U20F12 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, z, z); }
        public readonly Vector4U20F12 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, z, w); }
        public readonly Vector4U20F12 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, w, x); }
        public readonly Vector4U20F12 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, w, y); }
        public readonly Vector4U20F12 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, w, z); }
        public readonly Vector4U20F12 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, w, w); }
        public readonly Vector4U20F12 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, x, x); }
        public readonly Vector4U20F12 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, x, y); }
        public readonly Vector4U20F12 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, x, z); }
        public readonly Vector4U20F12 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, x, w); }
        public readonly Vector4U20F12 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, y, x); }
        public readonly Vector4U20F12 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, y, y); }
        public readonly Vector4U20F12 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, y, z); }
        public readonly Vector4U20F12 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, y, w); }
        public readonly Vector4U20F12 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, z, x); }
        public readonly Vector4U20F12 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, z, y); }
        public readonly Vector4U20F12 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, z, z); }
        public readonly Vector4U20F12 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, z, w); }
        public readonly Vector4U20F12 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, w, x); }
        public readonly Vector4U20F12 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, w, y); }
        public readonly Vector4U20F12 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, w, z); }
        public readonly Vector4U20F12 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, w, w); }
        public readonly Vector4U20F12 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, x, x); }
        public readonly Vector4U20F12 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, x, y); }
        public readonly Vector4U20F12 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, x, z); }
        public readonly Vector4U20F12 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, x, w); }
        public readonly Vector4U20F12 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, y, x); }
        public readonly Vector4U20F12 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, y, y); }
        public readonly Vector4U20F12 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, y, z); }
        public readonly Vector4U20F12 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, y, w); }
        public readonly Vector4U20F12 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, z, x); }
        public readonly Vector4U20F12 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, z, y); }
        public readonly Vector4U20F12 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, z, z); }
        public readonly Vector4U20F12 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, z, w); }
        public readonly Vector4U20F12 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, w, x); }
        public readonly Vector4U20F12 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, w, y); }
        public readonly Vector4U20F12 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, w, z); }
        public readonly Vector4U20F12 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, w, w, w); }
        public readonly Vector4U20F12 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, x, x); }
        public readonly Vector4U20F12 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, x, y); }
        public readonly Vector4U20F12 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, x, z); }
        public readonly Vector4U20F12 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, x, w); }
        public readonly Vector4U20F12 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, y, x); }
        public readonly Vector4U20F12 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, y, y); }
        public readonly Vector4U20F12 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, y, z); }
        public readonly Vector4U20F12 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, y, w); }
        public readonly Vector4U20F12 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, z, x); }
        public readonly Vector4U20F12 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, z, y); }
        public readonly Vector4U20F12 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, z, z); }
        public readonly Vector4U20F12 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, z, w); }
        public readonly Vector4U20F12 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, w, x); }
        public readonly Vector4U20F12 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, w, y); }
        public readonly Vector4U20F12 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, w, z); }
        public readonly Vector4U20F12 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, w, w); }
        public readonly Vector4U20F12 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, x, x); }
        public readonly Vector4U20F12 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, x, y); }
        public readonly Vector4U20F12 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, x, z); }
        public readonly Vector4U20F12 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, x, w); }
        public readonly Vector4U20F12 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, y, x); }
        public readonly Vector4U20F12 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, y, y); }
        public readonly Vector4U20F12 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, y, z); }
        public readonly Vector4U20F12 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, y, w); }
        public readonly Vector4U20F12 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, z, x); }
        public readonly Vector4U20F12 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, z, y); }
        public readonly Vector4U20F12 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, z, z); }
        public readonly Vector4U20F12 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, z, w); }
        public readonly Vector4U20F12 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, w, x); }
        public readonly Vector4U20F12 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, w, y); }
        public readonly Vector4U20F12 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, w, z); }
        public readonly Vector4U20F12 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, w, w); }
        public readonly Vector4U20F12 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, x, x); }
        public readonly Vector4U20F12 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, x, y); }
        public readonly Vector4U20F12 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, x, z); }
        public readonly Vector4U20F12 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, x, w); }
        public readonly Vector4U20F12 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, y, x); }
        public readonly Vector4U20F12 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, y, y); }
        public readonly Vector4U20F12 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, y, z); }
        public readonly Vector4U20F12 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, y, w); }
        public readonly Vector4U20F12 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, z, x); }
        public readonly Vector4U20F12 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, z, y); }
        public readonly Vector4U20F12 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, z, z); }
        public readonly Vector4U20F12 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, z, w); }
        public readonly Vector4U20F12 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, w, x); }
        public readonly Vector4U20F12 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, w, y); }
        public readonly Vector4U20F12 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, w, z); }
        public readonly Vector4U20F12 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, w, w); }
        public readonly Vector4U20F12 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, x, x); }
        public readonly Vector4U20F12 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, x, y); }
        public readonly Vector4U20F12 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, x, z); }
        public readonly Vector4U20F12 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, x, w); }
        public readonly Vector4U20F12 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, y, x); }
        public readonly Vector4U20F12 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, y, y); }
        public readonly Vector4U20F12 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, y, z); }
        public readonly Vector4U20F12 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, y, w); }
        public readonly Vector4U20F12 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, z, x); }
        public readonly Vector4U20F12 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, z, y); }
        public readonly Vector4U20F12 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, z, z); }
        public readonly Vector4U20F12 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, z, w); }
        public readonly Vector4U20F12 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, w, x); }
        public readonly Vector4U20F12 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, w, y); }
        public readonly Vector4U20F12 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, w, z); }
        public readonly Vector4U20F12 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, w, w, w); }
        public readonly Vector4U20F12 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, x, x); }
        public readonly Vector4U20F12 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, x, y); }
        public readonly Vector4U20F12 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, x, z); }
        public readonly Vector4U20F12 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, x, w); }
        public readonly Vector4U20F12 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, y, x); }
        public readonly Vector4U20F12 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, y, y); }
        public readonly Vector4U20F12 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, y, z); }
        public readonly Vector4U20F12 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, y, w); }
        public readonly Vector4U20F12 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, z, x); }
        public readonly Vector4U20F12 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, z, y); }
        public readonly Vector4U20F12 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, z, z); }
        public readonly Vector4U20F12 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, z, w); }
        public readonly Vector4U20F12 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, w, x); }
        public readonly Vector4U20F12 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, w, y); }
        public readonly Vector4U20F12 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, w, z); }
        public readonly Vector4U20F12 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, w, w); }
        public readonly Vector4U20F12 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, x, x); }
        public readonly Vector4U20F12 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, x, y); }
        public readonly Vector4U20F12 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, x, z); }
        public readonly Vector4U20F12 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, x, w); }
        public readonly Vector4U20F12 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, y, x); }
        public readonly Vector4U20F12 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, y, y); }
        public readonly Vector4U20F12 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, y, z); }
        public readonly Vector4U20F12 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, y, w); }
        public readonly Vector4U20F12 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, z, x); }
        public readonly Vector4U20F12 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, z, y); }
        public readonly Vector4U20F12 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, z, z); }
        public readonly Vector4U20F12 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, z, w); }
        public readonly Vector4U20F12 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, w, x); }
        public readonly Vector4U20F12 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, w, y); }
        public readonly Vector4U20F12 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, w, z); }
        public readonly Vector4U20F12 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, w, w); }
        public readonly Vector4U20F12 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, x, x); }
        public readonly Vector4U20F12 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, x, y); }
        public readonly Vector4U20F12 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, x, z); }
        public readonly Vector4U20F12 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, x, w); }
        public readonly Vector4U20F12 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, y, x); }
        public readonly Vector4U20F12 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, y, y); }
        public readonly Vector4U20F12 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, y, z); }
        public readonly Vector4U20F12 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, y, w); }
        public readonly Vector4U20F12 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, z, x); }
        public readonly Vector4U20F12 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, z, y); }
        public readonly Vector4U20F12 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, z, z); }
        public readonly Vector4U20F12 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, z, w); }
        public readonly Vector4U20F12 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, w, x); }
        public readonly Vector4U20F12 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, w, y); }
        public readonly Vector4U20F12 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, w, z); }
        public readonly Vector4U20F12 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, w, w); }
        public readonly Vector4U20F12 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, x, x); }
        public readonly Vector4U20F12 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, x, y); }
        public readonly Vector4U20F12 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, x, z); }
        public readonly Vector4U20F12 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, x, w); }
        public readonly Vector4U20F12 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, y, x); }
        public readonly Vector4U20F12 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, y, y); }
        public readonly Vector4U20F12 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, y, z); }
        public readonly Vector4U20F12 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, y, w); }
        public readonly Vector4U20F12 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, z, x); }
        public readonly Vector4U20F12 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, z, y); }
        public readonly Vector4U20F12 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, z, z); }
        public readonly Vector4U20F12 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, z, w); }
        public readonly Vector4U20F12 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, w, x); }
        public readonly Vector4U20F12 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, w, y); }
        public readonly Vector4U20F12 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, w, z); }
        public readonly Vector4U20F12 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, w, w, w); }
        public readonly Vector4U20F12 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, x, x); }
        public readonly Vector4U20F12 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, x, y); }
        public readonly Vector4U20F12 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, x, z); }
        public readonly Vector4U20F12 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, x, w); }
        public readonly Vector4U20F12 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, y, x); }
        public readonly Vector4U20F12 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, y, y); }
        public readonly Vector4U20F12 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, y, z); }
        public readonly Vector4U20F12 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, y, w); }
        public readonly Vector4U20F12 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, z, x); }
        public readonly Vector4U20F12 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, z, y); }
        public readonly Vector4U20F12 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, z, z); }
        public readonly Vector4U20F12 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, z, w); }
        public readonly Vector4U20F12 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, w, x); }
        public readonly Vector4U20F12 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, w, y); }
        public readonly Vector4U20F12 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, w, z); }
        public readonly Vector4U20F12 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, x, w, w); }
        public readonly Vector4U20F12 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, x, x); }
        public readonly Vector4U20F12 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, x, y); }
        public readonly Vector4U20F12 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, x, z); }
        public readonly Vector4U20F12 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, x, w); }
        public readonly Vector4U20F12 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, y, x); }
        public readonly Vector4U20F12 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, y, y); }
        public readonly Vector4U20F12 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, y, z); }
        public readonly Vector4U20F12 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, y, w); }
        public readonly Vector4U20F12 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, z, x); }
        public readonly Vector4U20F12 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, z, y); }
        public readonly Vector4U20F12 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, z, z); }
        public readonly Vector4U20F12 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, z, w); }
        public readonly Vector4U20F12 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, w, x); }
        public readonly Vector4U20F12 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, w, y); }
        public readonly Vector4U20F12 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, w, z); }
        public readonly Vector4U20F12 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, y, w, w); }
        public readonly Vector4U20F12 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, x, x); }
        public readonly Vector4U20F12 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, x, y); }
        public readonly Vector4U20F12 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, x, z); }
        public readonly Vector4U20F12 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, x, w); }
        public readonly Vector4U20F12 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, y, x); }
        public readonly Vector4U20F12 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, y, y); }
        public readonly Vector4U20F12 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, y, z); }
        public readonly Vector4U20F12 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, y, w); }
        public readonly Vector4U20F12 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, z, x); }
        public readonly Vector4U20F12 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, z, y); }
        public readonly Vector4U20F12 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, z, z); }
        public readonly Vector4U20F12 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, z, w); }
        public readonly Vector4U20F12 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, w, x); }
        public readonly Vector4U20F12 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, w, y); }
        public readonly Vector4U20F12 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, w, z); }
        public readonly Vector4U20F12 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, z, w, w); }
        public readonly Vector4U20F12 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, x, x); }
        public readonly Vector4U20F12 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, x, y); }
        public readonly Vector4U20F12 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, x, z); }
        public readonly Vector4U20F12 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, x, w); }
        public readonly Vector4U20F12 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, y, x); }
        public readonly Vector4U20F12 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, y, y); }
        public readonly Vector4U20F12 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, y, z); }
        public readonly Vector4U20F12 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, y, w); }
        public readonly Vector4U20F12 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, z, x); }
        public readonly Vector4U20F12 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, z, y); }
        public readonly Vector4U20F12 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, z, z); }
        public readonly Vector4U20F12 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, z, w); }
        public readonly Vector4U20F12 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, w, x); }
        public readonly Vector4U20F12 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, w, y); }
        public readonly Vector4U20F12 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, w, z); }
        public readonly Vector4U20F12 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U20F12 lhs, Vector4U20F12 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U20F12 lhs, Vector4U20F12 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U20F12 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U20F12({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U20F12>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U20F12 other)
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
            return $"Vector4U20F12({x}, {y}, {z}, {w})";
        }
    }
}
