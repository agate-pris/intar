using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U24F8 : IEquatable<Vector4U24F8>, IFormattable {
        // Fields
        // ---------------------------------------

        public U24F8 x;
        public U24F8 y;
        public U24F8 z;
        public U24F8 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U24F8 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, U24F8 y, U24F8 z, U24F8 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, U24F8 y, Vector2U24F8 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, Vector3U24F8 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector2U24F8 xy, Vector2U24F8 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector4U24F8 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, Vector2U24F8 yz, U24F8 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector3U24F8 xyz, U24F8 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector2U24F8 xy, U24F8 z, U24F8 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator +(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator -(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator *(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator *(Vector4U24F8 a, U24F8 b) => new Vector4U24F8(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator *(U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator /(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator /(Vector4U24F8 a, U24F8 b) => new Vector4U24F8(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator /(U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U24F8 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(x, x); }
        public readonly Vector2U24F8 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(x, y); }
        public readonly Vector2U24F8 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(x, z); }
        public readonly Vector2U24F8 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(x, w); }
        public readonly Vector2U24F8 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(y, x); }
        public readonly Vector2U24F8 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(y, y); }
        public readonly Vector2U24F8 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(y, z); }
        public readonly Vector2U24F8 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(y, w); }
        public readonly Vector2U24F8 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(z, x); }
        public readonly Vector2U24F8 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(z, y); }
        public readonly Vector2U24F8 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(z, z); }
        public readonly Vector2U24F8 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(z, w); }
        public readonly Vector2U24F8 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(w, x); }
        public readonly Vector2U24F8 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(w, y); }
        public readonly Vector2U24F8 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(w, z); }
        public readonly Vector2U24F8 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(w, w); }
        public readonly Vector3U24F8 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, x, x); }
        public readonly Vector3U24F8 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, x, y); }
        public readonly Vector3U24F8 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, x, z); }
        public readonly Vector3U24F8 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, x, w); }
        public readonly Vector3U24F8 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, y, x); }
        public readonly Vector3U24F8 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, y, y); }
        public readonly Vector3U24F8 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, y, z); }
        public readonly Vector3U24F8 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, y, w); }
        public readonly Vector3U24F8 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, z, x); }
        public readonly Vector3U24F8 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, z, y); }
        public readonly Vector3U24F8 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, z, z); }
        public readonly Vector3U24F8 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, z, w); }
        public readonly Vector3U24F8 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, w, x); }
        public readonly Vector3U24F8 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, w, y); }
        public readonly Vector3U24F8 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, w, z); }
        public readonly Vector3U24F8 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, w, w); }
        public readonly Vector3U24F8 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, x, x); }
        public readonly Vector3U24F8 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, x, y); }
        public readonly Vector3U24F8 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, x, z); }
        public readonly Vector3U24F8 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, x, w); }
        public readonly Vector3U24F8 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, y, x); }
        public readonly Vector3U24F8 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, y, y); }
        public readonly Vector3U24F8 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, y, z); }
        public readonly Vector3U24F8 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, y, w); }
        public readonly Vector3U24F8 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, z, x); }
        public readonly Vector3U24F8 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, z, y); }
        public readonly Vector3U24F8 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, z, z); }
        public readonly Vector3U24F8 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, z, w); }
        public readonly Vector3U24F8 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, w, x); }
        public readonly Vector3U24F8 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, w, y); }
        public readonly Vector3U24F8 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, w, z); }
        public readonly Vector3U24F8 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, w, w); }
        public readonly Vector3U24F8 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, x, x); }
        public readonly Vector3U24F8 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, x, y); }
        public readonly Vector3U24F8 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, x, z); }
        public readonly Vector3U24F8 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, x, w); }
        public readonly Vector3U24F8 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, y, x); }
        public readonly Vector3U24F8 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, y, y); }
        public readonly Vector3U24F8 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, y, z); }
        public readonly Vector3U24F8 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, y, w); }
        public readonly Vector3U24F8 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, z, x); }
        public readonly Vector3U24F8 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, z, y); }
        public readonly Vector3U24F8 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, z, z); }
        public readonly Vector3U24F8 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, z, w); }
        public readonly Vector3U24F8 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, w, x); }
        public readonly Vector3U24F8 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, w, y); }
        public readonly Vector3U24F8 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, w, z); }
        public readonly Vector3U24F8 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, w, w); }
        public readonly Vector3U24F8 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, x, x); }
        public readonly Vector3U24F8 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, x, y); }
        public readonly Vector3U24F8 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, x, z); }
        public readonly Vector3U24F8 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, x, w); }
        public readonly Vector3U24F8 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, y, x); }
        public readonly Vector3U24F8 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, y, y); }
        public readonly Vector3U24F8 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, y, z); }
        public readonly Vector3U24F8 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, y, w); }
        public readonly Vector3U24F8 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, z, x); }
        public readonly Vector3U24F8 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, z, y); }
        public readonly Vector3U24F8 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, z, z); }
        public readonly Vector3U24F8 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, z, w); }
        public readonly Vector3U24F8 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, w, x); }
        public readonly Vector3U24F8 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, w, y); }
        public readonly Vector3U24F8 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, w, z); }
        public readonly Vector3U24F8 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(w, w, w); }
        public readonly Vector4U24F8 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, x, x); }
        public readonly Vector4U24F8 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, x, y); }
        public readonly Vector4U24F8 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, x, z); }
        public readonly Vector4U24F8 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, x, w); }
        public readonly Vector4U24F8 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, y, x); }
        public readonly Vector4U24F8 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, y, y); }
        public readonly Vector4U24F8 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, y, z); }
        public readonly Vector4U24F8 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, y, w); }
        public readonly Vector4U24F8 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, z, x); }
        public readonly Vector4U24F8 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, z, y); }
        public readonly Vector4U24F8 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, z, z); }
        public readonly Vector4U24F8 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, z, w); }
        public readonly Vector4U24F8 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, w, x); }
        public readonly Vector4U24F8 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, w, y); }
        public readonly Vector4U24F8 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, w, z); }
        public readonly Vector4U24F8 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, w, w); }
        public readonly Vector4U24F8 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, x, x); }
        public readonly Vector4U24F8 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, x, y); }
        public readonly Vector4U24F8 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, x, z); }
        public readonly Vector4U24F8 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, x, w); }
        public readonly Vector4U24F8 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, y, x); }
        public readonly Vector4U24F8 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, y, y); }
        public readonly Vector4U24F8 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, y, z); }
        public readonly Vector4U24F8 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, y, w); }
        public readonly Vector4U24F8 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, z, x); }
        public readonly Vector4U24F8 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, z, y); }
        public readonly Vector4U24F8 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, z, z); }
        public readonly Vector4U24F8 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, z, w); }
        public readonly Vector4U24F8 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, w, x); }
        public readonly Vector4U24F8 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, w, y); }
        public readonly Vector4U24F8 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, w, z); }
        public readonly Vector4U24F8 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, w, w); }
        public readonly Vector4U24F8 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, x, x); }
        public readonly Vector4U24F8 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, x, y); }
        public readonly Vector4U24F8 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, x, z); }
        public readonly Vector4U24F8 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, x, w); }
        public readonly Vector4U24F8 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, y, x); }
        public readonly Vector4U24F8 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, y, y); }
        public readonly Vector4U24F8 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, y, z); }
        public readonly Vector4U24F8 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, y, w); }
        public readonly Vector4U24F8 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, z, x); }
        public readonly Vector4U24F8 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, z, y); }
        public readonly Vector4U24F8 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, z, z); }
        public readonly Vector4U24F8 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, z, w); }
        public readonly Vector4U24F8 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, w, x); }
        public readonly Vector4U24F8 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, w, y); }
        public readonly Vector4U24F8 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, w, z); }
        public readonly Vector4U24F8 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, w, w); }
        public readonly Vector4U24F8 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, x, x); }
        public readonly Vector4U24F8 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, x, y); }
        public readonly Vector4U24F8 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, x, z); }
        public readonly Vector4U24F8 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, x, w); }
        public readonly Vector4U24F8 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, y, x); }
        public readonly Vector4U24F8 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, y, y); }
        public readonly Vector4U24F8 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, y, z); }
        public readonly Vector4U24F8 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, y, w); }
        public readonly Vector4U24F8 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, z, x); }
        public readonly Vector4U24F8 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, z, y); }
        public readonly Vector4U24F8 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, z, z); }
        public readonly Vector4U24F8 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, z, w); }
        public readonly Vector4U24F8 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, w, x); }
        public readonly Vector4U24F8 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, w, y); }
        public readonly Vector4U24F8 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, w, z); }
        public readonly Vector4U24F8 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, w, w, w); }
        public readonly Vector4U24F8 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, x, x); }
        public readonly Vector4U24F8 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, x, y); }
        public readonly Vector4U24F8 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, x, z); }
        public readonly Vector4U24F8 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, x, w); }
        public readonly Vector4U24F8 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, y, x); }
        public readonly Vector4U24F8 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, y, y); }
        public readonly Vector4U24F8 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, y, z); }
        public readonly Vector4U24F8 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, y, w); }
        public readonly Vector4U24F8 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, z, x); }
        public readonly Vector4U24F8 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, z, y); }
        public readonly Vector4U24F8 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, z, z); }
        public readonly Vector4U24F8 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, z, w); }
        public readonly Vector4U24F8 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, w, x); }
        public readonly Vector4U24F8 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, w, y); }
        public readonly Vector4U24F8 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, w, z); }
        public readonly Vector4U24F8 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, w, w); }
        public readonly Vector4U24F8 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, x, x); }
        public readonly Vector4U24F8 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, x, y); }
        public readonly Vector4U24F8 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, x, z); }
        public readonly Vector4U24F8 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, x, w); }
        public readonly Vector4U24F8 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, y, x); }
        public readonly Vector4U24F8 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, y, y); }
        public readonly Vector4U24F8 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, y, z); }
        public readonly Vector4U24F8 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, y, w); }
        public readonly Vector4U24F8 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, z, x); }
        public readonly Vector4U24F8 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, z, y); }
        public readonly Vector4U24F8 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, z, z); }
        public readonly Vector4U24F8 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, z, w); }
        public readonly Vector4U24F8 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, w, x); }
        public readonly Vector4U24F8 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, w, y); }
        public readonly Vector4U24F8 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, w, z); }
        public readonly Vector4U24F8 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, w, w); }
        public readonly Vector4U24F8 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, x, x); }
        public readonly Vector4U24F8 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, x, y); }
        public readonly Vector4U24F8 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, x, z); }
        public readonly Vector4U24F8 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, x, w); }
        public readonly Vector4U24F8 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, y, x); }
        public readonly Vector4U24F8 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, y, y); }
        public readonly Vector4U24F8 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, y, z); }
        public readonly Vector4U24F8 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, y, w); }
        public readonly Vector4U24F8 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, z, x); }
        public readonly Vector4U24F8 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, z, y); }
        public readonly Vector4U24F8 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, z, z); }
        public readonly Vector4U24F8 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, z, w); }
        public readonly Vector4U24F8 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, w, x); }
        public readonly Vector4U24F8 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, w, y); }
        public readonly Vector4U24F8 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, w, z); }
        public readonly Vector4U24F8 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, w, w); }
        public readonly Vector4U24F8 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, x, x); }
        public readonly Vector4U24F8 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, x, y); }
        public readonly Vector4U24F8 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, x, z); }
        public readonly Vector4U24F8 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, x, w); }
        public readonly Vector4U24F8 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, y, x); }
        public readonly Vector4U24F8 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, y, y); }
        public readonly Vector4U24F8 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, y, z); }
        public readonly Vector4U24F8 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, y, w); }
        public readonly Vector4U24F8 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, z, x); }
        public readonly Vector4U24F8 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, z, y); }
        public readonly Vector4U24F8 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, z, z); }
        public readonly Vector4U24F8 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, z, w); }
        public readonly Vector4U24F8 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, w, x); }
        public readonly Vector4U24F8 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, w, y); }
        public readonly Vector4U24F8 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, w, z); }
        public readonly Vector4U24F8 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, w, w, w); }
        public readonly Vector4U24F8 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, x, x); }
        public readonly Vector4U24F8 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, x, y); }
        public readonly Vector4U24F8 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, x, z); }
        public readonly Vector4U24F8 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, x, w); }
        public readonly Vector4U24F8 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, y, x); }
        public readonly Vector4U24F8 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, y, y); }
        public readonly Vector4U24F8 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, y, z); }
        public readonly Vector4U24F8 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, y, w); }
        public readonly Vector4U24F8 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, z, x); }
        public readonly Vector4U24F8 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, z, y); }
        public readonly Vector4U24F8 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, z, z); }
        public readonly Vector4U24F8 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, z, w); }
        public readonly Vector4U24F8 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, w, x); }
        public readonly Vector4U24F8 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, w, y); }
        public readonly Vector4U24F8 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, w, z); }
        public readonly Vector4U24F8 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, w, w); }
        public readonly Vector4U24F8 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, x, x); }
        public readonly Vector4U24F8 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, x, y); }
        public readonly Vector4U24F8 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, x, z); }
        public readonly Vector4U24F8 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, x, w); }
        public readonly Vector4U24F8 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, y, x); }
        public readonly Vector4U24F8 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, y, y); }
        public readonly Vector4U24F8 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, y, z); }
        public readonly Vector4U24F8 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, y, w); }
        public readonly Vector4U24F8 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, z, x); }
        public readonly Vector4U24F8 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, z, y); }
        public readonly Vector4U24F8 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, z, z); }
        public readonly Vector4U24F8 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, z, w); }
        public readonly Vector4U24F8 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, w, x); }
        public readonly Vector4U24F8 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, w, y); }
        public readonly Vector4U24F8 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, w, z); }
        public readonly Vector4U24F8 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, w, w); }
        public readonly Vector4U24F8 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, x, x); }
        public readonly Vector4U24F8 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, x, y); }
        public readonly Vector4U24F8 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, x, z); }
        public readonly Vector4U24F8 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, x, w); }
        public readonly Vector4U24F8 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, y, x); }
        public readonly Vector4U24F8 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, y, y); }
        public readonly Vector4U24F8 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, y, z); }
        public readonly Vector4U24F8 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, y, w); }
        public readonly Vector4U24F8 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, z, x); }
        public readonly Vector4U24F8 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, z, y); }
        public readonly Vector4U24F8 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, z, z); }
        public readonly Vector4U24F8 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, z, w); }
        public readonly Vector4U24F8 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, w, x); }
        public readonly Vector4U24F8 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, w, y); }
        public readonly Vector4U24F8 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, w, z); }
        public readonly Vector4U24F8 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, w, w); }
        public readonly Vector4U24F8 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, x, x); }
        public readonly Vector4U24F8 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, x, y); }
        public readonly Vector4U24F8 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, x, z); }
        public readonly Vector4U24F8 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, x, w); }
        public readonly Vector4U24F8 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, y, x); }
        public readonly Vector4U24F8 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, y, y); }
        public readonly Vector4U24F8 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, y, z); }
        public readonly Vector4U24F8 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, y, w); }
        public readonly Vector4U24F8 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, z, x); }
        public readonly Vector4U24F8 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, z, y); }
        public readonly Vector4U24F8 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, z, z); }
        public readonly Vector4U24F8 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, z, w); }
        public readonly Vector4U24F8 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, w, x); }
        public readonly Vector4U24F8 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, w, y); }
        public readonly Vector4U24F8 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, w, z); }
        public readonly Vector4U24F8 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, w, w, w); }
        public readonly Vector4U24F8 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, x, x); }
        public readonly Vector4U24F8 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, x, y); }
        public readonly Vector4U24F8 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, x, z); }
        public readonly Vector4U24F8 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, x, w); }
        public readonly Vector4U24F8 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, y, x); }
        public readonly Vector4U24F8 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, y, y); }
        public readonly Vector4U24F8 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, y, z); }
        public readonly Vector4U24F8 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, y, w); }
        public readonly Vector4U24F8 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, z, x); }
        public readonly Vector4U24F8 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, z, y); }
        public readonly Vector4U24F8 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, z, z); }
        public readonly Vector4U24F8 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, z, w); }
        public readonly Vector4U24F8 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, w, x); }
        public readonly Vector4U24F8 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, w, y); }
        public readonly Vector4U24F8 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, w, z); }
        public readonly Vector4U24F8 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, x, w, w); }
        public readonly Vector4U24F8 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, x, x); }
        public readonly Vector4U24F8 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, x, y); }
        public readonly Vector4U24F8 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, x, z); }
        public readonly Vector4U24F8 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, x, w); }
        public readonly Vector4U24F8 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, y, x); }
        public readonly Vector4U24F8 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, y, y); }
        public readonly Vector4U24F8 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, y, z); }
        public readonly Vector4U24F8 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, y, w); }
        public readonly Vector4U24F8 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, z, x); }
        public readonly Vector4U24F8 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, z, y); }
        public readonly Vector4U24F8 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, z, z); }
        public readonly Vector4U24F8 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, z, w); }
        public readonly Vector4U24F8 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, w, x); }
        public readonly Vector4U24F8 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, w, y); }
        public readonly Vector4U24F8 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, w, z); }
        public readonly Vector4U24F8 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, y, w, w); }
        public readonly Vector4U24F8 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, x, x); }
        public readonly Vector4U24F8 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, x, y); }
        public readonly Vector4U24F8 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, x, z); }
        public readonly Vector4U24F8 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, x, w); }
        public readonly Vector4U24F8 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, y, x); }
        public readonly Vector4U24F8 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, y, y); }
        public readonly Vector4U24F8 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, y, z); }
        public readonly Vector4U24F8 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, y, w); }
        public readonly Vector4U24F8 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, z, x); }
        public readonly Vector4U24F8 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, z, y); }
        public readonly Vector4U24F8 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, z, z); }
        public readonly Vector4U24F8 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, z, w); }
        public readonly Vector4U24F8 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, w, x); }
        public readonly Vector4U24F8 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, w, y); }
        public readonly Vector4U24F8 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, w, z); }
        public readonly Vector4U24F8 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, z, w, w); }
        public readonly Vector4U24F8 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, x, x); }
        public readonly Vector4U24F8 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, x, y); }
        public readonly Vector4U24F8 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, x, z); }
        public readonly Vector4U24F8 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, x, w); }
        public readonly Vector4U24F8 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, y, x); }
        public readonly Vector4U24F8 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, y, y); }
        public readonly Vector4U24F8 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, y, z); }
        public readonly Vector4U24F8 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, y, w); }
        public readonly Vector4U24F8 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, z, x); }
        public readonly Vector4U24F8 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, z, y); }
        public readonly Vector4U24F8 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, z, z); }
        public readonly Vector4U24F8 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, z, w); }
        public readonly Vector4U24F8 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, w, x); }
        public readonly Vector4U24F8 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, w, y); }
        public readonly Vector4U24F8 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, w, z); }
        public readonly Vector4U24F8 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U24F8 lhs, Vector4U24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U24F8 lhs, Vector4U24F8 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U24F8({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U24F8 other)
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
            return $"Vector4U24F8({x}, {y}, {z}, {w})";
        }
    }
}
