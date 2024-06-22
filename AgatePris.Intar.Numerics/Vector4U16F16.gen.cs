using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U16F16 : IEquatable<Vector4U16F16>, IFormattable {
        // Fields
        // ---------------------------------------

        public U16F16 x;
        public U16F16 y;
        public U16F16 z;
        public U16F16 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U16F16 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, U16F16 y, U16F16 z, U16F16 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, U16F16 y, Vector2U16F16 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, Vector3U16F16 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector2U16F16 xy, Vector2U16F16 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector4U16F16 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, Vector2U16F16 yz, U16F16 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector3U16F16 xyz, U16F16 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector2U16F16 xy, U16F16 z, U16F16 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator +(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator -(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(Vector4U16F16 a, U16F16 b) => new Vector4U16F16(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(Vector4U16F16 a, U16F16 b) => new Vector4U16F16(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U16F16 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(x, x); }
        public readonly Vector2U16F16 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(x, y); }
        public readonly Vector2U16F16 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(x, z); }
        public readonly Vector2U16F16 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(x, w); }
        public readonly Vector2U16F16 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(y, x); }
        public readonly Vector2U16F16 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(y, y); }
        public readonly Vector2U16F16 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(y, z); }
        public readonly Vector2U16F16 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(y, w); }
        public readonly Vector2U16F16 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(z, x); }
        public readonly Vector2U16F16 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(z, y); }
        public readonly Vector2U16F16 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(z, z); }
        public readonly Vector2U16F16 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(z, w); }
        public readonly Vector2U16F16 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(w, x); }
        public readonly Vector2U16F16 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(w, y); }
        public readonly Vector2U16F16 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(w, z); }
        public readonly Vector2U16F16 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(w, w); }
        public readonly Vector3U16F16 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, x, x); }
        public readonly Vector3U16F16 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, x, y); }
        public readonly Vector3U16F16 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, x, z); }
        public readonly Vector3U16F16 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, x, w); }
        public readonly Vector3U16F16 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, y, x); }
        public readonly Vector3U16F16 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, y, y); }
        public readonly Vector3U16F16 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, y, z); }
        public readonly Vector3U16F16 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, y, w); }
        public readonly Vector3U16F16 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, z, x); }
        public readonly Vector3U16F16 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, z, y); }
        public readonly Vector3U16F16 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, z, z); }
        public readonly Vector3U16F16 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, z, w); }
        public readonly Vector3U16F16 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, w, x); }
        public readonly Vector3U16F16 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, w, y); }
        public readonly Vector3U16F16 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, w, z); }
        public readonly Vector3U16F16 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, w, w); }
        public readonly Vector3U16F16 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, x, x); }
        public readonly Vector3U16F16 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, x, y); }
        public readonly Vector3U16F16 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, x, z); }
        public readonly Vector3U16F16 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, x, w); }
        public readonly Vector3U16F16 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, y, x); }
        public readonly Vector3U16F16 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, y, y); }
        public readonly Vector3U16F16 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, y, z); }
        public readonly Vector3U16F16 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, y, w); }
        public readonly Vector3U16F16 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, z, x); }
        public readonly Vector3U16F16 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, z, y); }
        public readonly Vector3U16F16 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, z, z); }
        public readonly Vector3U16F16 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, z, w); }
        public readonly Vector3U16F16 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, w, x); }
        public readonly Vector3U16F16 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, w, y); }
        public readonly Vector3U16F16 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, w, z); }
        public readonly Vector3U16F16 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, w, w); }
        public readonly Vector3U16F16 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, x, x); }
        public readonly Vector3U16F16 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, x, y); }
        public readonly Vector3U16F16 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, x, z); }
        public readonly Vector3U16F16 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, x, w); }
        public readonly Vector3U16F16 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, y, x); }
        public readonly Vector3U16F16 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, y, y); }
        public readonly Vector3U16F16 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, y, z); }
        public readonly Vector3U16F16 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, y, w); }
        public readonly Vector3U16F16 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, z, x); }
        public readonly Vector3U16F16 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, z, y); }
        public readonly Vector3U16F16 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, z, z); }
        public readonly Vector3U16F16 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, z, w); }
        public readonly Vector3U16F16 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, w, x); }
        public readonly Vector3U16F16 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, w, y); }
        public readonly Vector3U16F16 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, w, z); }
        public readonly Vector3U16F16 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, w, w); }
        public readonly Vector3U16F16 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, x, x); }
        public readonly Vector3U16F16 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, x, y); }
        public readonly Vector3U16F16 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, x, z); }
        public readonly Vector3U16F16 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, x, w); }
        public readonly Vector3U16F16 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, y, x); }
        public readonly Vector3U16F16 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, y, y); }
        public readonly Vector3U16F16 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, y, z); }
        public readonly Vector3U16F16 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, y, w); }
        public readonly Vector3U16F16 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, z, x); }
        public readonly Vector3U16F16 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, z, y); }
        public readonly Vector3U16F16 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, z, z); }
        public readonly Vector3U16F16 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, z, w); }
        public readonly Vector3U16F16 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, w, x); }
        public readonly Vector3U16F16 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, w, y); }
        public readonly Vector3U16F16 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, w, z); }
        public readonly Vector3U16F16 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(w, w, w); }
        public readonly Vector4U16F16 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, x, x); }
        public readonly Vector4U16F16 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, x, y); }
        public readonly Vector4U16F16 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, x, z); }
        public readonly Vector4U16F16 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, x, w); }
        public readonly Vector4U16F16 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, y, x); }
        public readonly Vector4U16F16 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, y, y); }
        public readonly Vector4U16F16 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, y, z); }
        public readonly Vector4U16F16 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, y, w); }
        public readonly Vector4U16F16 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, z, x); }
        public readonly Vector4U16F16 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, z, y); }
        public readonly Vector4U16F16 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, z, z); }
        public readonly Vector4U16F16 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, z, w); }
        public readonly Vector4U16F16 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, w, x); }
        public readonly Vector4U16F16 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, w, y); }
        public readonly Vector4U16F16 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, w, z); }
        public readonly Vector4U16F16 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, w, w); }
        public readonly Vector4U16F16 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, x, x); }
        public readonly Vector4U16F16 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, x, y); }
        public readonly Vector4U16F16 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, x, z); }
        public readonly Vector4U16F16 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, x, w); }
        public readonly Vector4U16F16 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, y, x); }
        public readonly Vector4U16F16 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, y, y); }
        public readonly Vector4U16F16 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, y, z); }
        public readonly Vector4U16F16 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, y, w); }
        public readonly Vector4U16F16 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, z, x); }
        public readonly Vector4U16F16 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, z, y); }
        public readonly Vector4U16F16 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, z, z); }
        public readonly Vector4U16F16 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, z, w); }
        public readonly Vector4U16F16 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, w, x); }
        public readonly Vector4U16F16 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, w, y); }
        public readonly Vector4U16F16 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, w, z); }
        public readonly Vector4U16F16 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, w, w); }
        public readonly Vector4U16F16 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, x, x); }
        public readonly Vector4U16F16 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, x, y); }
        public readonly Vector4U16F16 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, x, z); }
        public readonly Vector4U16F16 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, x, w); }
        public readonly Vector4U16F16 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, y, x); }
        public readonly Vector4U16F16 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, y, y); }
        public readonly Vector4U16F16 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, y, z); }
        public readonly Vector4U16F16 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, y, w); }
        public readonly Vector4U16F16 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, z, x); }
        public readonly Vector4U16F16 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, z, y); }
        public readonly Vector4U16F16 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, z, z); }
        public readonly Vector4U16F16 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, z, w); }
        public readonly Vector4U16F16 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, w, x); }
        public readonly Vector4U16F16 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, w, y); }
        public readonly Vector4U16F16 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, w, z); }
        public readonly Vector4U16F16 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, w, w); }
        public readonly Vector4U16F16 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, x, x); }
        public readonly Vector4U16F16 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, x, y); }
        public readonly Vector4U16F16 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, x, z); }
        public readonly Vector4U16F16 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, x, w); }
        public readonly Vector4U16F16 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, y, x); }
        public readonly Vector4U16F16 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, y, y); }
        public readonly Vector4U16F16 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, y, z); }
        public readonly Vector4U16F16 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, y, w); }
        public readonly Vector4U16F16 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, z, x); }
        public readonly Vector4U16F16 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, z, y); }
        public readonly Vector4U16F16 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, z, z); }
        public readonly Vector4U16F16 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, z, w); }
        public readonly Vector4U16F16 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, w, x); }
        public readonly Vector4U16F16 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, w, y); }
        public readonly Vector4U16F16 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, w, z); }
        public readonly Vector4U16F16 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, w, w, w); }
        public readonly Vector4U16F16 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, x, x); }
        public readonly Vector4U16F16 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, x, y); }
        public readonly Vector4U16F16 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, x, z); }
        public readonly Vector4U16F16 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, x, w); }
        public readonly Vector4U16F16 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, y, x); }
        public readonly Vector4U16F16 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, y, y); }
        public readonly Vector4U16F16 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, y, z); }
        public readonly Vector4U16F16 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, y, w); }
        public readonly Vector4U16F16 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, z, x); }
        public readonly Vector4U16F16 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, z, y); }
        public readonly Vector4U16F16 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, z, z); }
        public readonly Vector4U16F16 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, z, w); }
        public readonly Vector4U16F16 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, w, x); }
        public readonly Vector4U16F16 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, w, y); }
        public readonly Vector4U16F16 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, w, z); }
        public readonly Vector4U16F16 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, w, w); }
        public readonly Vector4U16F16 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, x, x); }
        public readonly Vector4U16F16 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, x, y); }
        public readonly Vector4U16F16 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, x, z); }
        public readonly Vector4U16F16 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, x, w); }
        public readonly Vector4U16F16 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, y, x); }
        public readonly Vector4U16F16 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, y, y); }
        public readonly Vector4U16F16 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, y, z); }
        public readonly Vector4U16F16 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, y, w); }
        public readonly Vector4U16F16 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, z, x); }
        public readonly Vector4U16F16 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, z, y); }
        public readonly Vector4U16F16 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, z, z); }
        public readonly Vector4U16F16 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, z, w); }
        public readonly Vector4U16F16 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, w, x); }
        public readonly Vector4U16F16 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, w, y); }
        public readonly Vector4U16F16 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, w, z); }
        public readonly Vector4U16F16 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, w, w); }
        public readonly Vector4U16F16 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, x, x); }
        public readonly Vector4U16F16 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, x, y); }
        public readonly Vector4U16F16 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, x, z); }
        public readonly Vector4U16F16 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, x, w); }
        public readonly Vector4U16F16 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, y, x); }
        public readonly Vector4U16F16 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, y, y); }
        public readonly Vector4U16F16 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, y, z); }
        public readonly Vector4U16F16 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, y, w); }
        public readonly Vector4U16F16 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, z, x); }
        public readonly Vector4U16F16 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, z, y); }
        public readonly Vector4U16F16 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, z, z); }
        public readonly Vector4U16F16 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, z, w); }
        public readonly Vector4U16F16 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, w, x); }
        public readonly Vector4U16F16 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, w, y); }
        public readonly Vector4U16F16 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, w, z); }
        public readonly Vector4U16F16 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, w, w); }
        public readonly Vector4U16F16 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, x, x); }
        public readonly Vector4U16F16 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, x, y); }
        public readonly Vector4U16F16 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, x, z); }
        public readonly Vector4U16F16 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, x, w); }
        public readonly Vector4U16F16 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, y, x); }
        public readonly Vector4U16F16 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, y, y); }
        public readonly Vector4U16F16 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, y, z); }
        public readonly Vector4U16F16 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, y, w); }
        public readonly Vector4U16F16 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, z, x); }
        public readonly Vector4U16F16 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, z, y); }
        public readonly Vector4U16F16 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, z, z); }
        public readonly Vector4U16F16 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, z, w); }
        public readonly Vector4U16F16 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, w, x); }
        public readonly Vector4U16F16 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, w, y); }
        public readonly Vector4U16F16 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, w, z); }
        public readonly Vector4U16F16 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, w, w, w); }
        public readonly Vector4U16F16 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, x, x); }
        public readonly Vector4U16F16 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, x, y); }
        public readonly Vector4U16F16 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, x, z); }
        public readonly Vector4U16F16 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, x, w); }
        public readonly Vector4U16F16 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, y, x); }
        public readonly Vector4U16F16 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, y, y); }
        public readonly Vector4U16F16 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, y, z); }
        public readonly Vector4U16F16 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, y, w); }
        public readonly Vector4U16F16 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, z, x); }
        public readonly Vector4U16F16 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, z, y); }
        public readonly Vector4U16F16 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, z, z); }
        public readonly Vector4U16F16 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, z, w); }
        public readonly Vector4U16F16 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, w, x); }
        public readonly Vector4U16F16 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, w, y); }
        public readonly Vector4U16F16 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, w, z); }
        public readonly Vector4U16F16 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, w, w); }
        public readonly Vector4U16F16 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, x, x); }
        public readonly Vector4U16F16 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, x, y); }
        public readonly Vector4U16F16 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, x, z); }
        public readonly Vector4U16F16 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, x, w); }
        public readonly Vector4U16F16 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, y, x); }
        public readonly Vector4U16F16 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, y, y); }
        public readonly Vector4U16F16 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, y, z); }
        public readonly Vector4U16F16 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, y, w); }
        public readonly Vector4U16F16 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, z, x); }
        public readonly Vector4U16F16 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, z, y); }
        public readonly Vector4U16F16 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, z, z); }
        public readonly Vector4U16F16 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, z, w); }
        public readonly Vector4U16F16 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, w, x); }
        public readonly Vector4U16F16 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, w, y); }
        public readonly Vector4U16F16 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, w, z); }
        public readonly Vector4U16F16 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, w, w); }
        public readonly Vector4U16F16 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, x, x); }
        public readonly Vector4U16F16 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, x, y); }
        public readonly Vector4U16F16 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, x, z); }
        public readonly Vector4U16F16 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, x, w); }
        public readonly Vector4U16F16 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, y, x); }
        public readonly Vector4U16F16 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, y, y); }
        public readonly Vector4U16F16 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, y, z); }
        public readonly Vector4U16F16 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, y, w); }
        public readonly Vector4U16F16 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, z, x); }
        public readonly Vector4U16F16 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, z, y); }
        public readonly Vector4U16F16 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, z, z); }
        public readonly Vector4U16F16 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, z, w); }
        public readonly Vector4U16F16 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, w, x); }
        public readonly Vector4U16F16 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, w, y); }
        public readonly Vector4U16F16 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, w, z); }
        public readonly Vector4U16F16 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, w, w); }
        public readonly Vector4U16F16 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, x, x); }
        public readonly Vector4U16F16 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, x, y); }
        public readonly Vector4U16F16 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, x, z); }
        public readonly Vector4U16F16 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, x, w); }
        public readonly Vector4U16F16 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, y, x); }
        public readonly Vector4U16F16 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, y, y); }
        public readonly Vector4U16F16 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, y, z); }
        public readonly Vector4U16F16 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, y, w); }
        public readonly Vector4U16F16 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, z, x); }
        public readonly Vector4U16F16 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, z, y); }
        public readonly Vector4U16F16 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, z, z); }
        public readonly Vector4U16F16 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, z, w); }
        public readonly Vector4U16F16 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, w, x); }
        public readonly Vector4U16F16 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, w, y); }
        public readonly Vector4U16F16 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, w, z); }
        public readonly Vector4U16F16 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, w, w, w); }
        public readonly Vector4U16F16 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, x, x); }
        public readonly Vector4U16F16 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, x, y); }
        public readonly Vector4U16F16 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, x, z); }
        public readonly Vector4U16F16 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, x, w); }
        public readonly Vector4U16F16 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, y, x); }
        public readonly Vector4U16F16 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, y, y); }
        public readonly Vector4U16F16 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, y, z); }
        public readonly Vector4U16F16 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, y, w); }
        public readonly Vector4U16F16 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, z, x); }
        public readonly Vector4U16F16 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, z, y); }
        public readonly Vector4U16F16 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, z, z); }
        public readonly Vector4U16F16 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, z, w); }
        public readonly Vector4U16F16 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, w, x); }
        public readonly Vector4U16F16 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, w, y); }
        public readonly Vector4U16F16 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, w, z); }
        public readonly Vector4U16F16 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, x, w, w); }
        public readonly Vector4U16F16 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, x, x); }
        public readonly Vector4U16F16 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, x, y); }
        public readonly Vector4U16F16 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, x, z); }
        public readonly Vector4U16F16 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, x, w); }
        public readonly Vector4U16F16 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, y, x); }
        public readonly Vector4U16F16 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, y, y); }
        public readonly Vector4U16F16 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, y, z); }
        public readonly Vector4U16F16 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, y, w); }
        public readonly Vector4U16F16 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, z, x); }
        public readonly Vector4U16F16 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, z, y); }
        public readonly Vector4U16F16 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, z, z); }
        public readonly Vector4U16F16 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, z, w); }
        public readonly Vector4U16F16 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, w, x); }
        public readonly Vector4U16F16 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, w, y); }
        public readonly Vector4U16F16 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, w, z); }
        public readonly Vector4U16F16 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, y, w, w); }
        public readonly Vector4U16F16 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, x, x); }
        public readonly Vector4U16F16 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, x, y); }
        public readonly Vector4U16F16 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, x, z); }
        public readonly Vector4U16F16 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, x, w); }
        public readonly Vector4U16F16 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, y, x); }
        public readonly Vector4U16F16 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, y, y); }
        public readonly Vector4U16F16 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, y, z); }
        public readonly Vector4U16F16 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, y, w); }
        public readonly Vector4U16F16 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, z, x); }
        public readonly Vector4U16F16 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, z, y); }
        public readonly Vector4U16F16 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, z, z); }
        public readonly Vector4U16F16 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, z, w); }
        public readonly Vector4U16F16 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, w, x); }
        public readonly Vector4U16F16 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, w, y); }
        public readonly Vector4U16F16 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, w, z); }
        public readonly Vector4U16F16 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, z, w, w); }
        public readonly Vector4U16F16 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, x, x); }
        public readonly Vector4U16F16 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, x, y); }
        public readonly Vector4U16F16 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, x, z); }
        public readonly Vector4U16F16 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, x, w); }
        public readonly Vector4U16F16 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, y, x); }
        public readonly Vector4U16F16 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, y, y); }
        public readonly Vector4U16F16 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, y, z); }
        public readonly Vector4U16F16 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, y, w); }
        public readonly Vector4U16F16 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, z, x); }
        public readonly Vector4U16F16 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, z, y); }
        public readonly Vector4U16F16 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, z, z); }
        public readonly Vector4U16F16 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, z, w); }
        public readonly Vector4U16F16 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, w, x); }
        public readonly Vector4U16F16 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, w, y); }
        public readonly Vector4U16F16 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, w, z); }
        public readonly Vector4U16F16 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U16F16 lhs, Vector4U16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U16F16 lhs, Vector4U16F16 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U16F16({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U16F16 other)
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
            return $"Vector4U16F16({x}, {y}, {z}, {w})";
        }
    }
}
