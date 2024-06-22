using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U25F7 : IEquatable<Vector4U25F7>, IFormattable {
        // Fields
        // ---------------------------------------

        public U25F7 x;
        public U25F7 y;
        public U25F7 z;
        public U25F7 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U25F7 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, U25F7 y, U25F7 z, U25F7 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, U25F7 y, Vector2U25F7 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, Vector3U25F7 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector2U25F7 xy, Vector2U25F7 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector4U25F7 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, Vector2U25F7 yz, U25F7 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector3U25F7 xyz, U25F7 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector2U25F7 xy, U25F7 z, U25F7 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator +(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator -(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator *(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator *(Vector4U25F7 a, U25F7 b) => new Vector4U25F7(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator *(U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator /(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator /(Vector4U25F7 a, U25F7 b) => new Vector4U25F7(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator /(U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U25F7 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(x, x); }
        public readonly Vector2U25F7 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(x, y); }
        public readonly Vector2U25F7 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(x, z); }
        public readonly Vector2U25F7 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(x, w); }
        public readonly Vector2U25F7 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(y, x); }
        public readonly Vector2U25F7 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(y, y); }
        public readonly Vector2U25F7 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(y, z); }
        public readonly Vector2U25F7 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(y, w); }
        public readonly Vector2U25F7 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(z, x); }
        public readonly Vector2U25F7 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(z, y); }
        public readonly Vector2U25F7 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(z, z); }
        public readonly Vector2U25F7 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(z, w); }
        public readonly Vector2U25F7 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(w, x); }
        public readonly Vector2U25F7 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(w, y); }
        public readonly Vector2U25F7 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(w, z); }
        public readonly Vector2U25F7 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(w, w); }
        public readonly Vector3U25F7 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, x, x); }
        public readonly Vector3U25F7 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, x, y); }
        public readonly Vector3U25F7 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, x, z); }
        public readonly Vector3U25F7 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, x, w); }
        public readonly Vector3U25F7 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, y, x); }
        public readonly Vector3U25F7 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, y, y); }
        public readonly Vector3U25F7 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, y, z); }
        public readonly Vector3U25F7 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, y, w); }
        public readonly Vector3U25F7 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, z, x); }
        public readonly Vector3U25F7 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, z, y); }
        public readonly Vector3U25F7 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, z, z); }
        public readonly Vector3U25F7 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, z, w); }
        public readonly Vector3U25F7 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, w, x); }
        public readonly Vector3U25F7 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, w, y); }
        public readonly Vector3U25F7 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, w, z); }
        public readonly Vector3U25F7 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, w, w); }
        public readonly Vector3U25F7 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, x, x); }
        public readonly Vector3U25F7 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, x, y); }
        public readonly Vector3U25F7 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, x, z); }
        public readonly Vector3U25F7 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, x, w); }
        public readonly Vector3U25F7 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, y, x); }
        public readonly Vector3U25F7 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, y, y); }
        public readonly Vector3U25F7 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, y, z); }
        public readonly Vector3U25F7 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, y, w); }
        public readonly Vector3U25F7 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, z, x); }
        public readonly Vector3U25F7 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, z, y); }
        public readonly Vector3U25F7 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, z, z); }
        public readonly Vector3U25F7 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, z, w); }
        public readonly Vector3U25F7 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, w, x); }
        public readonly Vector3U25F7 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, w, y); }
        public readonly Vector3U25F7 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, w, z); }
        public readonly Vector3U25F7 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, w, w); }
        public readonly Vector3U25F7 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, x, x); }
        public readonly Vector3U25F7 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, x, y); }
        public readonly Vector3U25F7 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, x, z); }
        public readonly Vector3U25F7 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, x, w); }
        public readonly Vector3U25F7 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, y, x); }
        public readonly Vector3U25F7 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, y, y); }
        public readonly Vector3U25F7 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, y, z); }
        public readonly Vector3U25F7 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, y, w); }
        public readonly Vector3U25F7 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, z, x); }
        public readonly Vector3U25F7 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, z, y); }
        public readonly Vector3U25F7 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, z, z); }
        public readonly Vector3U25F7 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, z, w); }
        public readonly Vector3U25F7 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, w, x); }
        public readonly Vector3U25F7 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, w, y); }
        public readonly Vector3U25F7 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, w, z); }
        public readonly Vector3U25F7 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(z, w, w); }
        public readonly Vector3U25F7 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, x, x); }
        public readonly Vector3U25F7 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, x, y); }
        public readonly Vector3U25F7 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, x, z); }
        public readonly Vector3U25F7 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, x, w); }
        public readonly Vector3U25F7 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, y, x); }
        public readonly Vector3U25F7 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, y, y); }
        public readonly Vector3U25F7 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, y, z); }
        public readonly Vector3U25F7 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, y, w); }
        public readonly Vector3U25F7 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, z, x); }
        public readonly Vector3U25F7 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, z, y); }
        public readonly Vector3U25F7 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, z, z); }
        public readonly Vector3U25F7 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, z, w); }
        public readonly Vector3U25F7 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, w, x); }
        public readonly Vector3U25F7 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, w, y); }
        public readonly Vector3U25F7 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, w, z); }
        public readonly Vector3U25F7 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(w, w, w); }
        public readonly Vector4U25F7 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, x, x); }
        public readonly Vector4U25F7 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, x, y); }
        public readonly Vector4U25F7 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, x, z); }
        public readonly Vector4U25F7 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, x, w); }
        public readonly Vector4U25F7 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, y, x); }
        public readonly Vector4U25F7 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, y, y); }
        public readonly Vector4U25F7 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, y, z); }
        public readonly Vector4U25F7 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, y, w); }
        public readonly Vector4U25F7 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, z, x); }
        public readonly Vector4U25F7 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, z, y); }
        public readonly Vector4U25F7 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, z, z); }
        public readonly Vector4U25F7 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, z, w); }
        public readonly Vector4U25F7 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, w, x); }
        public readonly Vector4U25F7 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, w, y); }
        public readonly Vector4U25F7 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, w, z); }
        public readonly Vector4U25F7 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, w, w); }
        public readonly Vector4U25F7 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, x, x); }
        public readonly Vector4U25F7 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, x, y); }
        public readonly Vector4U25F7 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, x, z); }
        public readonly Vector4U25F7 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, x, w); }
        public readonly Vector4U25F7 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, y, x); }
        public readonly Vector4U25F7 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, y, y); }
        public readonly Vector4U25F7 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, y, z); }
        public readonly Vector4U25F7 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, y, w); }
        public readonly Vector4U25F7 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, z, x); }
        public readonly Vector4U25F7 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, z, y); }
        public readonly Vector4U25F7 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, z, z); }
        public readonly Vector4U25F7 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, z, w); }
        public readonly Vector4U25F7 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, w, x); }
        public readonly Vector4U25F7 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, w, y); }
        public readonly Vector4U25F7 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, w, z); }
        public readonly Vector4U25F7 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, w, w); }
        public readonly Vector4U25F7 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, x, x); }
        public readonly Vector4U25F7 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, x, y); }
        public readonly Vector4U25F7 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, x, z); }
        public readonly Vector4U25F7 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, x, w); }
        public readonly Vector4U25F7 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, y, x); }
        public readonly Vector4U25F7 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, y, y); }
        public readonly Vector4U25F7 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, y, z); }
        public readonly Vector4U25F7 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, y, w); }
        public readonly Vector4U25F7 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, z, x); }
        public readonly Vector4U25F7 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, z, y); }
        public readonly Vector4U25F7 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, z, z); }
        public readonly Vector4U25F7 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, z, w); }
        public readonly Vector4U25F7 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, w, x); }
        public readonly Vector4U25F7 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, w, y); }
        public readonly Vector4U25F7 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, w, z); }
        public readonly Vector4U25F7 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, z, w, w); }
        public readonly Vector4U25F7 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, x, x); }
        public readonly Vector4U25F7 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, x, y); }
        public readonly Vector4U25F7 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, x, z); }
        public readonly Vector4U25F7 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, x, w); }
        public readonly Vector4U25F7 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, y, x); }
        public readonly Vector4U25F7 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, y, y); }
        public readonly Vector4U25F7 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, y, z); }
        public readonly Vector4U25F7 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, y, w); }
        public readonly Vector4U25F7 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, z, x); }
        public readonly Vector4U25F7 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, z, y); }
        public readonly Vector4U25F7 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, z, z); }
        public readonly Vector4U25F7 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, z, w); }
        public readonly Vector4U25F7 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, w, x); }
        public readonly Vector4U25F7 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, w, y); }
        public readonly Vector4U25F7 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, w, z); }
        public readonly Vector4U25F7 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, w, w, w); }
        public readonly Vector4U25F7 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, x, x); }
        public readonly Vector4U25F7 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, x, y); }
        public readonly Vector4U25F7 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, x, z); }
        public readonly Vector4U25F7 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, x, w); }
        public readonly Vector4U25F7 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, y, x); }
        public readonly Vector4U25F7 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, y, y); }
        public readonly Vector4U25F7 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, y, z); }
        public readonly Vector4U25F7 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, y, w); }
        public readonly Vector4U25F7 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, z, x); }
        public readonly Vector4U25F7 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, z, y); }
        public readonly Vector4U25F7 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, z, z); }
        public readonly Vector4U25F7 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, z, w); }
        public readonly Vector4U25F7 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, w, x); }
        public readonly Vector4U25F7 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, w, y); }
        public readonly Vector4U25F7 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, w, z); }
        public readonly Vector4U25F7 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, w, w); }
        public readonly Vector4U25F7 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, x, x); }
        public readonly Vector4U25F7 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, x, y); }
        public readonly Vector4U25F7 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, x, z); }
        public readonly Vector4U25F7 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, x, w); }
        public readonly Vector4U25F7 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, y, x); }
        public readonly Vector4U25F7 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, y, y); }
        public readonly Vector4U25F7 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, y, z); }
        public readonly Vector4U25F7 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, y, w); }
        public readonly Vector4U25F7 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, z, x); }
        public readonly Vector4U25F7 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, z, y); }
        public readonly Vector4U25F7 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, z, z); }
        public readonly Vector4U25F7 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, z, w); }
        public readonly Vector4U25F7 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, w, x); }
        public readonly Vector4U25F7 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, w, y); }
        public readonly Vector4U25F7 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, w, z); }
        public readonly Vector4U25F7 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, w, w); }
        public readonly Vector4U25F7 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, x, x); }
        public readonly Vector4U25F7 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, x, y); }
        public readonly Vector4U25F7 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, x, z); }
        public readonly Vector4U25F7 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, x, w); }
        public readonly Vector4U25F7 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, y, x); }
        public readonly Vector4U25F7 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, y, y); }
        public readonly Vector4U25F7 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, y, z); }
        public readonly Vector4U25F7 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, y, w); }
        public readonly Vector4U25F7 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, z, x); }
        public readonly Vector4U25F7 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, z, y); }
        public readonly Vector4U25F7 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, z, z); }
        public readonly Vector4U25F7 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, z, w); }
        public readonly Vector4U25F7 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, w, x); }
        public readonly Vector4U25F7 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, w, y); }
        public readonly Vector4U25F7 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, w, z); }
        public readonly Vector4U25F7 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, z, w, w); }
        public readonly Vector4U25F7 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, x, x); }
        public readonly Vector4U25F7 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, x, y); }
        public readonly Vector4U25F7 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, x, z); }
        public readonly Vector4U25F7 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, x, w); }
        public readonly Vector4U25F7 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, y, x); }
        public readonly Vector4U25F7 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, y, y); }
        public readonly Vector4U25F7 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, y, z); }
        public readonly Vector4U25F7 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, y, w); }
        public readonly Vector4U25F7 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, z, x); }
        public readonly Vector4U25F7 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, z, y); }
        public readonly Vector4U25F7 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, z, z); }
        public readonly Vector4U25F7 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, z, w); }
        public readonly Vector4U25F7 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, w, x); }
        public readonly Vector4U25F7 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, w, y); }
        public readonly Vector4U25F7 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, w, z); }
        public readonly Vector4U25F7 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, w, w, w); }
        public readonly Vector4U25F7 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, x, x); }
        public readonly Vector4U25F7 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, x, y); }
        public readonly Vector4U25F7 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, x, z); }
        public readonly Vector4U25F7 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, x, w); }
        public readonly Vector4U25F7 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, y, x); }
        public readonly Vector4U25F7 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, y, y); }
        public readonly Vector4U25F7 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, y, z); }
        public readonly Vector4U25F7 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, y, w); }
        public readonly Vector4U25F7 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, z, x); }
        public readonly Vector4U25F7 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, z, y); }
        public readonly Vector4U25F7 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, z, z); }
        public readonly Vector4U25F7 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, z, w); }
        public readonly Vector4U25F7 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, w, x); }
        public readonly Vector4U25F7 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, w, y); }
        public readonly Vector4U25F7 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, w, z); }
        public readonly Vector4U25F7 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, x, w, w); }
        public readonly Vector4U25F7 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, x, x); }
        public readonly Vector4U25F7 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, x, y); }
        public readonly Vector4U25F7 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, x, z); }
        public readonly Vector4U25F7 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, x, w); }
        public readonly Vector4U25F7 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, y, x); }
        public readonly Vector4U25F7 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, y, y); }
        public readonly Vector4U25F7 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, y, z); }
        public readonly Vector4U25F7 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, y, w); }
        public readonly Vector4U25F7 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, z, x); }
        public readonly Vector4U25F7 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, z, y); }
        public readonly Vector4U25F7 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, z, z); }
        public readonly Vector4U25F7 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, z, w); }
        public readonly Vector4U25F7 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, w, x); }
        public readonly Vector4U25F7 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, w, y); }
        public readonly Vector4U25F7 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, w, z); }
        public readonly Vector4U25F7 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, y, w, w); }
        public readonly Vector4U25F7 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, x, x); }
        public readonly Vector4U25F7 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, x, y); }
        public readonly Vector4U25F7 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, x, z); }
        public readonly Vector4U25F7 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, x, w); }
        public readonly Vector4U25F7 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, y, x); }
        public readonly Vector4U25F7 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, y, y); }
        public readonly Vector4U25F7 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, y, z); }
        public readonly Vector4U25F7 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, y, w); }
        public readonly Vector4U25F7 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, z, x); }
        public readonly Vector4U25F7 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, z, y); }
        public readonly Vector4U25F7 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, z, z); }
        public readonly Vector4U25F7 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, z, w); }
        public readonly Vector4U25F7 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, w, x); }
        public readonly Vector4U25F7 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, w, y); }
        public readonly Vector4U25F7 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, w, z); }
        public readonly Vector4U25F7 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, z, w, w); }
        public readonly Vector4U25F7 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, x, x); }
        public readonly Vector4U25F7 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, x, y); }
        public readonly Vector4U25F7 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, x, z); }
        public readonly Vector4U25F7 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, x, w); }
        public readonly Vector4U25F7 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, y, x); }
        public readonly Vector4U25F7 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, y, y); }
        public readonly Vector4U25F7 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, y, z); }
        public readonly Vector4U25F7 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, y, w); }
        public readonly Vector4U25F7 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, z, x); }
        public readonly Vector4U25F7 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, z, y); }
        public readonly Vector4U25F7 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, z, z); }
        public readonly Vector4U25F7 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, z, w); }
        public readonly Vector4U25F7 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, w, x); }
        public readonly Vector4U25F7 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, w, y); }
        public readonly Vector4U25F7 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, w, z); }
        public readonly Vector4U25F7 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(z, w, w, w); }
        public readonly Vector4U25F7 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, x, x); }
        public readonly Vector4U25F7 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, x, y); }
        public readonly Vector4U25F7 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, x, z); }
        public readonly Vector4U25F7 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, x, w); }
        public readonly Vector4U25F7 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, y, x); }
        public readonly Vector4U25F7 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, y, y); }
        public readonly Vector4U25F7 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, y, z); }
        public readonly Vector4U25F7 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, y, w); }
        public readonly Vector4U25F7 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, z, x); }
        public readonly Vector4U25F7 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, z, y); }
        public readonly Vector4U25F7 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, z, z); }
        public readonly Vector4U25F7 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, z, w); }
        public readonly Vector4U25F7 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, w, x); }
        public readonly Vector4U25F7 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, w, y); }
        public readonly Vector4U25F7 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, w, z); }
        public readonly Vector4U25F7 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, x, w, w); }
        public readonly Vector4U25F7 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, x, x); }
        public readonly Vector4U25F7 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, x, y); }
        public readonly Vector4U25F7 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, x, z); }
        public readonly Vector4U25F7 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, x, w); }
        public readonly Vector4U25F7 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, y, x); }
        public readonly Vector4U25F7 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, y, y); }
        public readonly Vector4U25F7 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, y, z); }
        public readonly Vector4U25F7 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, y, w); }
        public readonly Vector4U25F7 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, z, x); }
        public readonly Vector4U25F7 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, z, y); }
        public readonly Vector4U25F7 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, z, z); }
        public readonly Vector4U25F7 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, z, w); }
        public readonly Vector4U25F7 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, w, x); }
        public readonly Vector4U25F7 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, w, y); }
        public readonly Vector4U25F7 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, w, z); }
        public readonly Vector4U25F7 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, y, w, w); }
        public readonly Vector4U25F7 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, x, x); }
        public readonly Vector4U25F7 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, x, y); }
        public readonly Vector4U25F7 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, x, z); }
        public readonly Vector4U25F7 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, x, w); }
        public readonly Vector4U25F7 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, y, x); }
        public readonly Vector4U25F7 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, y, y); }
        public readonly Vector4U25F7 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, y, z); }
        public readonly Vector4U25F7 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, y, w); }
        public readonly Vector4U25F7 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, z, x); }
        public readonly Vector4U25F7 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, z, y); }
        public readonly Vector4U25F7 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, z, z); }
        public readonly Vector4U25F7 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, z, w); }
        public readonly Vector4U25F7 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, w, x); }
        public readonly Vector4U25F7 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, w, y); }
        public readonly Vector4U25F7 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, w, z); }
        public readonly Vector4U25F7 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, z, w, w); }
        public readonly Vector4U25F7 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, x, x); }
        public readonly Vector4U25F7 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, x, y); }
        public readonly Vector4U25F7 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, x, z); }
        public readonly Vector4U25F7 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, x, w); }
        public readonly Vector4U25F7 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, y, x); }
        public readonly Vector4U25F7 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, y, y); }
        public readonly Vector4U25F7 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, y, z); }
        public readonly Vector4U25F7 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, y, w); }
        public readonly Vector4U25F7 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, z, x); }
        public readonly Vector4U25F7 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, z, y); }
        public readonly Vector4U25F7 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, z, z); }
        public readonly Vector4U25F7 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, z, w); }
        public readonly Vector4U25F7 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, w, x); }
        public readonly Vector4U25F7 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, w, y); }
        public readonly Vector4U25F7 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, w, z); }
        public readonly Vector4U25F7 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U25F7 lhs, Vector4U25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U25F7 lhs, Vector4U25F7 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U25F7({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U25F7 other)
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
            return $"Vector4U25F7({x}, {y}, {z}, {w})";
        }
    }
}
