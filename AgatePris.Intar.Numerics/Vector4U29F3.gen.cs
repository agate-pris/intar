using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U29F3 : IEquatable<Vector4U29F3>, IFormattable {
        // Fields
        // ---------------------------------------

        public U29F3 x;
        public U29F3 y;
        public U29F3 z;
        public U29F3 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U29F3 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(U29F3 x, U29F3 y, U29F3 z, U29F3 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(U29F3 x, U29F3 y, Vector2U29F3 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(U29F3 x, Vector3U29F3 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(Vector2U29F3 xy, Vector2U29F3 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(Vector4U29F3 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(U29F3 x, Vector2U29F3 yz, U29F3 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(Vector3U29F3 xyz, U29F3 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(Vector2U29F3 xy, U29F3 z, U29F3 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator +(Vector4U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator -(Vector4U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator *(Vector4U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator *(Vector4U29F3 a, U29F3 b) => new Vector4U29F3(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator *(U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator /(Vector4U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator /(Vector4U29F3 a, U29F3 b) => new Vector4U29F3(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator /(U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U29F3 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(x, x); }
        public readonly Vector2U29F3 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(x, y); }
        public readonly Vector2U29F3 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(x, z); }
        public readonly Vector2U29F3 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(x, w); }
        public readonly Vector2U29F3 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(y, x); }
        public readonly Vector2U29F3 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(y, y); }
        public readonly Vector2U29F3 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(y, z); }
        public readonly Vector2U29F3 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(y, w); }
        public readonly Vector2U29F3 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(z, x); }
        public readonly Vector2U29F3 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(z, y); }
        public readonly Vector2U29F3 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(z, z); }
        public readonly Vector2U29F3 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(z, w); }
        public readonly Vector2U29F3 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(w, x); }
        public readonly Vector2U29F3 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(w, y); }
        public readonly Vector2U29F3 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(w, z); }
        public readonly Vector2U29F3 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(w, w); }
        public readonly Vector3U29F3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, x, x); }
        public readonly Vector3U29F3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, x, y); }
        public readonly Vector3U29F3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, x, z); }
        public readonly Vector3U29F3 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, x, w); }
        public readonly Vector3U29F3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, y, x); }
        public readonly Vector3U29F3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, y, y); }
        public readonly Vector3U29F3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, y, z); }
        public readonly Vector3U29F3 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, y, w); }
        public readonly Vector3U29F3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, z, x); }
        public readonly Vector3U29F3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, z, y); }
        public readonly Vector3U29F3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, z, z); }
        public readonly Vector3U29F3 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, z, w); }
        public readonly Vector3U29F3 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, w, x); }
        public readonly Vector3U29F3 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, w, y); }
        public readonly Vector3U29F3 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, w, z); }
        public readonly Vector3U29F3 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, w, w); }
        public readonly Vector3U29F3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, x, x); }
        public readonly Vector3U29F3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, x, y); }
        public readonly Vector3U29F3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, x, z); }
        public readonly Vector3U29F3 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, x, w); }
        public readonly Vector3U29F3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, y, x); }
        public readonly Vector3U29F3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, y, y); }
        public readonly Vector3U29F3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, y, z); }
        public readonly Vector3U29F3 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, y, w); }
        public readonly Vector3U29F3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, z, x); }
        public readonly Vector3U29F3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, z, y); }
        public readonly Vector3U29F3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, z, z); }
        public readonly Vector3U29F3 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, z, w); }
        public readonly Vector3U29F3 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, w, x); }
        public readonly Vector3U29F3 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, w, y); }
        public readonly Vector3U29F3 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, w, z); }
        public readonly Vector3U29F3 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, w, w); }
        public readonly Vector3U29F3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, x, x); }
        public readonly Vector3U29F3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, x, y); }
        public readonly Vector3U29F3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, x, z); }
        public readonly Vector3U29F3 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, x, w); }
        public readonly Vector3U29F3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, y, x); }
        public readonly Vector3U29F3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, y, y); }
        public readonly Vector3U29F3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, y, z); }
        public readonly Vector3U29F3 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, y, w); }
        public readonly Vector3U29F3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, z, x); }
        public readonly Vector3U29F3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, z, y); }
        public readonly Vector3U29F3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, z, z); }
        public readonly Vector3U29F3 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, z, w); }
        public readonly Vector3U29F3 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, w, x); }
        public readonly Vector3U29F3 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, w, y); }
        public readonly Vector3U29F3 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, w, z); }
        public readonly Vector3U29F3 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, w, w); }
        public readonly Vector3U29F3 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, x, x); }
        public readonly Vector3U29F3 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, x, y); }
        public readonly Vector3U29F3 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, x, z); }
        public readonly Vector3U29F3 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, x, w); }
        public readonly Vector3U29F3 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, y, x); }
        public readonly Vector3U29F3 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, y, y); }
        public readonly Vector3U29F3 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, y, z); }
        public readonly Vector3U29F3 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, y, w); }
        public readonly Vector3U29F3 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, z, x); }
        public readonly Vector3U29F3 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, z, y); }
        public readonly Vector3U29F3 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, z, z); }
        public readonly Vector3U29F3 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, z, w); }
        public readonly Vector3U29F3 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, w, x); }
        public readonly Vector3U29F3 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, w, y); }
        public readonly Vector3U29F3 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, w, z); }
        public readonly Vector3U29F3 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(w, w, w); }
        public readonly Vector4U29F3 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, x, x); }
        public readonly Vector4U29F3 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, x, y); }
        public readonly Vector4U29F3 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, x, z); }
        public readonly Vector4U29F3 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, x, w); }
        public readonly Vector4U29F3 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, y, x); }
        public readonly Vector4U29F3 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, y, y); }
        public readonly Vector4U29F3 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, y, z); }
        public readonly Vector4U29F3 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, y, w); }
        public readonly Vector4U29F3 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, z, x); }
        public readonly Vector4U29F3 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, z, y); }
        public readonly Vector4U29F3 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, z, z); }
        public readonly Vector4U29F3 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, z, w); }
        public readonly Vector4U29F3 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, w, x); }
        public readonly Vector4U29F3 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, w, y); }
        public readonly Vector4U29F3 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, w, z); }
        public readonly Vector4U29F3 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, w, w); }
        public readonly Vector4U29F3 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, x, x); }
        public readonly Vector4U29F3 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, x, y); }
        public readonly Vector4U29F3 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, x, z); }
        public readonly Vector4U29F3 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, x, w); }
        public readonly Vector4U29F3 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, y, x); }
        public readonly Vector4U29F3 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, y, y); }
        public readonly Vector4U29F3 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, y, z); }
        public readonly Vector4U29F3 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, y, w); }
        public readonly Vector4U29F3 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, z, x); }
        public readonly Vector4U29F3 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, z, y); }
        public readonly Vector4U29F3 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, z, z); }
        public readonly Vector4U29F3 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, z, w); }
        public readonly Vector4U29F3 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, w, x); }
        public readonly Vector4U29F3 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, w, y); }
        public readonly Vector4U29F3 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, w, z); }
        public readonly Vector4U29F3 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, w, w); }
        public readonly Vector4U29F3 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, x, x); }
        public readonly Vector4U29F3 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, x, y); }
        public readonly Vector4U29F3 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, x, z); }
        public readonly Vector4U29F3 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, x, w); }
        public readonly Vector4U29F3 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, y, x); }
        public readonly Vector4U29F3 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, y, y); }
        public readonly Vector4U29F3 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, y, z); }
        public readonly Vector4U29F3 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, y, w); }
        public readonly Vector4U29F3 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, z, x); }
        public readonly Vector4U29F3 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, z, y); }
        public readonly Vector4U29F3 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, z, z); }
        public readonly Vector4U29F3 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, z, w); }
        public readonly Vector4U29F3 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, w, x); }
        public readonly Vector4U29F3 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, w, y); }
        public readonly Vector4U29F3 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, w, z); }
        public readonly Vector4U29F3 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, w, w); }
        public readonly Vector4U29F3 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, x, x); }
        public readonly Vector4U29F3 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, x, y); }
        public readonly Vector4U29F3 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, x, z); }
        public readonly Vector4U29F3 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, x, w); }
        public readonly Vector4U29F3 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, y, x); }
        public readonly Vector4U29F3 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, y, y); }
        public readonly Vector4U29F3 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, y, z); }
        public readonly Vector4U29F3 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, y, w); }
        public readonly Vector4U29F3 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, z, x); }
        public readonly Vector4U29F3 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, z, y); }
        public readonly Vector4U29F3 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, z, z); }
        public readonly Vector4U29F3 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, z, w); }
        public readonly Vector4U29F3 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, w, x); }
        public readonly Vector4U29F3 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, w, y); }
        public readonly Vector4U29F3 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, w, z); }
        public readonly Vector4U29F3 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, w, w, w); }
        public readonly Vector4U29F3 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, x, x); }
        public readonly Vector4U29F3 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, x, y); }
        public readonly Vector4U29F3 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, x, z); }
        public readonly Vector4U29F3 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, x, w); }
        public readonly Vector4U29F3 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, y, x); }
        public readonly Vector4U29F3 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, y, y); }
        public readonly Vector4U29F3 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, y, z); }
        public readonly Vector4U29F3 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, y, w); }
        public readonly Vector4U29F3 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, z, x); }
        public readonly Vector4U29F3 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, z, y); }
        public readonly Vector4U29F3 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, z, z); }
        public readonly Vector4U29F3 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, z, w); }
        public readonly Vector4U29F3 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, w, x); }
        public readonly Vector4U29F3 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, w, y); }
        public readonly Vector4U29F3 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, w, z); }
        public readonly Vector4U29F3 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, w, w); }
        public readonly Vector4U29F3 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, x, x); }
        public readonly Vector4U29F3 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, x, y); }
        public readonly Vector4U29F3 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, x, z); }
        public readonly Vector4U29F3 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, x, w); }
        public readonly Vector4U29F3 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, y, x); }
        public readonly Vector4U29F3 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, y, y); }
        public readonly Vector4U29F3 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, y, z); }
        public readonly Vector4U29F3 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, y, w); }
        public readonly Vector4U29F3 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, z, x); }
        public readonly Vector4U29F3 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, z, y); }
        public readonly Vector4U29F3 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, z, z); }
        public readonly Vector4U29F3 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, z, w); }
        public readonly Vector4U29F3 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, w, x); }
        public readonly Vector4U29F3 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, w, y); }
        public readonly Vector4U29F3 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, w, z); }
        public readonly Vector4U29F3 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, w, w); }
        public readonly Vector4U29F3 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, x, x); }
        public readonly Vector4U29F3 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, x, y); }
        public readonly Vector4U29F3 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, x, z); }
        public readonly Vector4U29F3 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, x, w); }
        public readonly Vector4U29F3 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, y, x); }
        public readonly Vector4U29F3 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, y, y); }
        public readonly Vector4U29F3 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, y, z); }
        public readonly Vector4U29F3 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, y, w); }
        public readonly Vector4U29F3 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, z, x); }
        public readonly Vector4U29F3 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, z, y); }
        public readonly Vector4U29F3 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, z, z); }
        public readonly Vector4U29F3 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, z, w); }
        public readonly Vector4U29F3 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, w, x); }
        public readonly Vector4U29F3 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, w, y); }
        public readonly Vector4U29F3 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, w, z); }
        public readonly Vector4U29F3 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, w, w); }
        public readonly Vector4U29F3 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, x, x); }
        public readonly Vector4U29F3 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, x, y); }
        public readonly Vector4U29F3 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, x, z); }
        public readonly Vector4U29F3 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, x, w); }
        public readonly Vector4U29F3 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, y, x); }
        public readonly Vector4U29F3 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, y, y); }
        public readonly Vector4U29F3 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, y, z); }
        public readonly Vector4U29F3 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, y, w); }
        public readonly Vector4U29F3 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, z, x); }
        public readonly Vector4U29F3 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, z, y); }
        public readonly Vector4U29F3 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, z, z); }
        public readonly Vector4U29F3 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, z, w); }
        public readonly Vector4U29F3 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, w, x); }
        public readonly Vector4U29F3 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, w, y); }
        public readonly Vector4U29F3 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, w, z); }
        public readonly Vector4U29F3 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, w, w, w); }
        public readonly Vector4U29F3 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, x, x); }
        public readonly Vector4U29F3 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, x, y); }
        public readonly Vector4U29F3 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, x, z); }
        public readonly Vector4U29F3 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, x, w); }
        public readonly Vector4U29F3 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, y, x); }
        public readonly Vector4U29F3 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, y, y); }
        public readonly Vector4U29F3 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, y, z); }
        public readonly Vector4U29F3 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, y, w); }
        public readonly Vector4U29F3 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, z, x); }
        public readonly Vector4U29F3 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, z, y); }
        public readonly Vector4U29F3 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, z, z); }
        public readonly Vector4U29F3 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, z, w); }
        public readonly Vector4U29F3 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, w, x); }
        public readonly Vector4U29F3 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, w, y); }
        public readonly Vector4U29F3 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, w, z); }
        public readonly Vector4U29F3 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, w, w); }
        public readonly Vector4U29F3 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, x, x); }
        public readonly Vector4U29F3 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, x, y); }
        public readonly Vector4U29F3 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, x, z); }
        public readonly Vector4U29F3 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, x, w); }
        public readonly Vector4U29F3 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, y, x); }
        public readonly Vector4U29F3 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, y, y); }
        public readonly Vector4U29F3 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, y, z); }
        public readonly Vector4U29F3 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, y, w); }
        public readonly Vector4U29F3 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, z, x); }
        public readonly Vector4U29F3 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, z, y); }
        public readonly Vector4U29F3 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, z, z); }
        public readonly Vector4U29F3 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, z, w); }
        public readonly Vector4U29F3 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, w, x); }
        public readonly Vector4U29F3 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, w, y); }
        public readonly Vector4U29F3 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, w, z); }
        public readonly Vector4U29F3 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, w, w); }
        public readonly Vector4U29F3 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, x, x); }
        public readonly Vector4U29F3 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, x, y); }
        public readonly Vector4U29F3 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, x, z); }
        public readonly Vector4U29F3 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, x, w); }
        public readonly Vector4U29F3 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, y, x); }
        public readonly Vector4U29F3 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, y, y); }
        public readonly Vector4U29F3 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, y, z); }
        public readonly Vector4U29F3 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, y, w); }
        public readonly Vector4U29F3 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, z, x); }
        public readonly Vector4U29F3 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, z, y); }
        public readonly Vector4U29F3 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, z, z); }
        public readonly Vector4U29F3 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, z, w); }
        public readonly Vector4U29F3 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, w, x); }
        public readonly Vector4U29F3 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, w, y); }
        public readonly Vector4U29F3 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, w, z); }
        public readonly Vector4U29F3 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, w, w); }
        public readonly Vector4U29F3 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, x, x); }
        public readonly Vector4U29F3 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, x, y); }
        public readonly Vector4U29F3 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, x, z); }
        public readonly Vector4U29F3 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, x, w); }
        public readonly Vector4U29F3 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, y, x); }
        public readonly Vector4U29F3 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, y, y); }
        public readonly Vector4U29F3 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, y, z); }
        public readonly Vector4U29F3 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, y, w); }
        public readonly Vector4U29F3 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, z, x); }
        public readonly Vector4U29F3 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, z, y); }
        public readonly Vector4U29F3 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, z, z); }
        public readonly Vector4U29F3 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, z, w); }
        public readonly Vector4U29F3 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, w, x); }
        public readonly Vector4U29F3 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, w, y); }
        public readonly Vector4U29F3 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, w, z); }
        public readonly Vector4U29F3 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, w, w, w); }
        public readonly Vector4U29F3 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, x, x); }
        public readonly Vector4U29F3 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, x, y); }
        public readonly Vector4U29F3 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, x, z); }
        public readonly Vector4U29F3 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, x, w); }
        public readonly Vector4U29F3 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, y, x); }
        public readonly Vector4U29F3 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, y, y); }
        public readonly Vector4U29F3 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, y, z); }
        public readonly Vector4U29F3 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, y, w); }
        public readonly Vector4U29F3 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, z, x); }
        public readonly Vector4U29F3 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, z, y); }
        public readonly Vector4U29F3 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, z, z); }
        public readonly Vector4U29F3 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, z, w); }
        public readonly Vector4U29F3 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, w, x); }
        public readonly Vector4U29F3 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, w, y); }
        public readonly Vector4U29F3 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, w, z); }
        public readonly Vector4U29F3 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, x, w, w); }
        public readonly Vector4U29F3 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, x, x); }
        public readonly Vector4U29F3 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, x, y); }
        public readonly Vector4U29F3 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, x, z); }
        public readonly Vector4U29F3 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, x, w); }
        public readonly Vector4U29F3 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, y, x); }
        public readonly Vector4U29F3 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, y, y); }
        public readonly Vector4U29F3 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, y, z); }
        public readonly Vector4U29F3 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, y, w); }
        public readonly Vector4U29F3 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, z, x); }
        public readonly Vector4U29F3 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, z, y); }
        public readonly Vector4U29F3 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, z, z); }
        public readonly Vector4U29F3 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, z, w); }
        public readonly Vector4U29F3 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, w, x); }
        public readonly Vector4U29F3 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, w, y); }
        public readonly Vector4U29F3 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, w, z); }
        public readonly Vector4U29F3 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, y, w, w); }
        public readonly Vector4U29F3 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, x, x); }
        public readonly Vector4U29F3 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, x, y); }
        public readonly Vector4U29F3 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, x, z); }
        public readonly Vector4U29F3 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, x, w); }
        public readonly Vector4U29F3 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, y, x); }
        public readonly Vector4U29F3 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, y, y); }
        public readonly Vector4U29F3 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, y, z); }
        public readonly Vector4U29F3 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, y, w); }
        public readonly Vector4U29F3 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, z, x); }
        public readonly Vector4U29F3 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, z, y); }
        public readonly Vector4U29F3 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, z, z); }
        public readonly Vector4U29F3 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, z, w); }
        public readonly Vector4U29F3 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, w, x); }
        public readonly Vector4U29F3 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, w, y); }
        public readonly Vector4U29F3 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, w, z); }
        public readonly Vector4U29F3 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, z, w, w); }
        public readonly Vector4U29F3 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, x, x); }
        public readonly Vector4U29F3 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, x, y); }
        public readonly Vector4U29F3 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, x, z); }
        public readonly Vector4U29F3 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, x, w); }
        public readonly Vector4U29F3 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, y, x); }
        public readonly Vector4U29F3 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, y, y); }
        public readonly Vector4U29F3 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, y, z); }
        public readonly Vector4U29F3 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, y, w); }
        public readonly Vector4U29F3 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, z, x); }
        public readonly Vector4U29F3 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, z, y); }
        public readonly Vector4U29F3 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, z, z); }
        public readonly Vector4U29F3 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, z, w); }
        public readonly Vector4U29F3 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, w, x); }
        public readonly Vector4U29F3 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, w, y); }
        public readonly Vector4U29F3 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, w, z); }
        public readonly Vector4U29F3 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U29F3 lhs, Vector4U29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U29F3 lhs, Vector4U29F3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U29F3({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U29F3 other)
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
            return $"Vector4U29F3({x}, {y}, {z}, {w})";
        }
    }
}
