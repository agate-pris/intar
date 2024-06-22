using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U17F15 : IEquatable<Vector4U17F15>, IFormattable {
        // Fields
        // ---------------------------------------

        public U17F15 x;
        public U17F15 y;
        public U17F15 z;
        public U17F15 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U17F15 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(U17F15 x, U17F15 y, U17F15 z, U17F15 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(U17F15 x, U17F15 y, Vector2U17F15 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(U17F15 x, Vector3U17F15 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(Vector2U17F15 xy, Vector2U17F15 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(Vector4U17F15 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(U17F15 x, Vector2U17F15 yz, U17F15 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(Vector3U17F15 xyz, U17F15 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(Vector2U17F15 xy, U17F15 z, U17F15 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator +(Vector4U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator -(Vector4U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator *(Vector4U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator *(Vector4U17F15 a, U17F15 b) => new Vector4U17F15(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator *(U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator /(Vector4U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator /(Vector4U17F15 a, U17F15 b) => new Vector4U17F15(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator /(U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U17F15 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(x, x); }
        public readonly Vector2U17F15 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(x, y); }
        public readonly Vector2U17F15 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(x, z); }
        public readonly Vector2U17F15 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(x, w); }
        public readonly Vector2U17F15 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(y, x); }
        public readonly Vector2U17F15 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(y, y); }
        public readonly Vector2U17F15 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(y, z); }
        public readonly Vector2U17F15 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(y, w); }
        public readonly Vector2U17F15 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(z, x); }
        public readonly Vector2U17F15 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(z, y); }
        public readonly Vector2U17F15 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(z, z); }
        public readonly Vector2U17F15 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(z, w); }
        public readonly Vector2U17F15 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(w, x); }
        public readonly Vector2U17F15 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(w, y); }
        public readonly Vector2U17F15 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(w, z); }
        public readonly Vector2U17F15 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(w, w); }
        public readonly Vector3U17F15 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, x, x); }
        public readonly Vector3U17F15 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, x, y); }
        public readonly Vector3U17F15 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, x, z); }
        public readonly Vector3U17F15 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, x, w); }
        public readonly Vector3U17F15 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, y, x); }
        public readonly Vector3U17F15 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, y, y); }
        public readonly Vector3U17F15 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, y, z); }
        public readonly Vector3U17F15 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, y, w); }
        public readonly Vector3U17F15 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, z, x); }
        public readonly Vector3U17F15 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, z, y); }
        public readonly Vector3U17F15 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, z, z); }
        public readonly Vector3U17F15 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, z, w); }
        public readonly Vector3U17F15 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, w, x); }
        public readonly Vector3U17F15 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, w, y); }
        public readonly Vector3U17F15 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, w, z); }
        public readonly Vector3U17F15 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, w, w); }
        public readonly Vector3U17F15 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, x, x); }
        public readonly Vector3U17F15 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, x, y); }
        public readonly Vector3U17F15 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, x, z); }
        public readonly Vector3U17F15 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, x, w); }
        public readonly Vector3U17F15 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, y, x); }
        public readonly Vector3U17F15 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, y, y); }
        public readonly Vector3U17F15 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, y, z); }
        public readonly Vector3U17F15 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, y, w); }
        public readonly Vector3U17F15 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, z, x); }
        public readonly Vector3U17F15 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, z, y); }
        public readonly Vector3U17F15 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, z, z); }
        public readonly Vector3U17F15 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, z, w); }
        public readonly Vector3U17F15 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, w, x); }
        public readonly Vector3U17F15 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, w, y); }
        public readonly Vector3U17F15 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, w, z); }
        public readonly Vector3U17F15 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, w, w); }
        public readonly Vector3U17F15 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, x, x); }
        public readonly Vector3U17F15 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, x, y); }
        public readonly Vector3U17F15 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, x, z); }
        public readonly Vector3U17F15 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, x, w); }
        public readonly Vector3U17F15 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, y, x); }
        public readonly Vector3U17F15 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, y, y); }
        public readonly Vector3U17F15 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, y, z); }
        public readonly Vector3U17F15 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, y, w); }
        public readonly Vector3U17F15 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, z, x); }
        public readonly Vector3U17F15 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, z, y); }
        public readonly Vector3U17F15 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, z, z); }
        public readonly Vector3U17F15 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, z, w); }
        public readonly Vector3U17F15 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, w, x); }
        public readonly Vector3U17F15 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, w, y); }
        public readonly Vector3U17F15 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, w, z); }
        public readonly Vector3U17F15 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, w, w); }
        public readonly Vector3U17F15 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, x, x); }
        public readonly Vector3U17F15 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, x, y); }
        public readonly Vector3U17F15 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, x, z); }
        public readonly Vector3U17F15 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, x, w); }
        public readonly Vector3U17F15 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, y, x); }
        public readonly Vector3U17F15 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, y, y); }
        public readonly Vector3U17F15 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, y, z); }
        public readonly Vector3U17F15 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, y, w); }
        public readonly Vector3U17F15 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, z, x); }
        public readonly Vector3U17F15 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, z, y); }
        public readonly Vector3U17F15 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, z, z); }
        public readonly Vector3U17F15 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, z, w); }
        public readonly Vector3U17F15 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, w, x); }
        public readonly Vector3U17F15 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, w, y); }
        public readonly Vector3U17F15 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, w, z); }
        public readonly Vector3U17F15 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(w, w, w); }
        public readonly Vector4U17F15 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, x, x); }
        public readonly Vector4U17F15 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, x, y); }
        public readonly Vector4U17F15 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, x, z); }
        public readonly Vector4U17F15 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, x, w); }
        public readonly Vector4U17F15 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, y, x); }
        public readonly Vector4U17F15 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, y, y); }
        public readonly Vector4U17F15 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, y, z); }
        public readonly Vector4U17F15 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, y, w); }
        public readonly Vector4U17F15 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, z, x); }
        public readonly Vector4U17F15 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, z, y); }
        public readonly Vector4U17F15 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, z, z); }
        public readonly Vector4U17F15 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, z, w); }
        public readonly Vector4U17F15 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, w, x); }
        public readonly Vector4U17F15 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, w, y); }
        public readonly Vector4U17F15 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, w, z); }
        public readonly Vector4U17F15 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, w, w); }
        public readonly Vector4U17F15 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, x, x); }
        public readonly Vector4U17F15 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, x, y); }
        public readonly Vector4U17F15 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, x, z); }
        public readonly Vector4U17F15 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, x, w); }
        public readonly Vector4U17F15 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, y, x); }
        public readonly Vector4U17F15 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, y, y); }
        public readonly Vector4U17F15 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, y, z); }
        public readonly Vector4U17F15 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, y, w); }
        public readonly Vector4U17F15 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, z, x); }
        public readonly Vector4U17F15 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, z, y); }
        public readonly Vector4U17F15 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, z, z); }
        public readonly Vector4U17F15 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, z, w); }
        public readonly Vector4U17F15 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, w, x); }
        public readonly Vector4U17F15 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, w, y); }
        public readonly Vector4U17F15 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, w, z); }
        public readonly Vector4U17F15 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, w, w); }
        public readonly Vector4U17F15 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, x, x); }
        public readonly Vector4U17F15 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, x, y); }
        public readonly Vector4U17F15 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, x, z); }
        public readonly Vector4U17F15 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, x, w); }
        public readonly Vector4U17F15 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, y, x); }
        public readonly Vector4U17F15 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, y, y); }
        public readonly Vector4U17F15 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, y, z); }
        public readonly Vector4U17F15 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, y, w); }
        public readonly Vector4U17F15 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, z, x); }
        public readonly Vector4U17F15 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, z, y); }
        public readonly Vector4U17F15 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, z, z); }
        public readonly Vector4U17F15 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, z, w); }
        public readonly Vector4U17F15 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, w, x); }
        public readonly Vector4U17F15 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, w, y); }
        public readonly Vector4U17F15 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, w, z); }
        public readonly Vector4U17F15 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, w, w); }
        public readonly Vector4U17F15 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, x, x); }
        public readonly Vector4U17F15 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, x, y); }
        public readonly Vector4U17F15 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, x, z); }
        public readonly Vector4U17F15 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, x, w); }
        public readonly Vector4U17F15 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, y, x); }
        public readonly Vector4U17F15 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, y, y); }
        public readonly Vector4U17F15 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, y, z); }
        public readonly Vector4U17F15 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, y, w); }
        public readonly Vector4U17F15 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, z, x); }
        public readonly Vector4U17F15 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, z, y); }
        public readonly Vector4U17F15 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, z, z); }
        public readonly Vector4U17F15 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, z, w); }
        public readonly Vector4U17F15 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, w, x); }
        public readonly Vector4U17F15 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, w, y); }
        public readonly Vector4U17F15 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, w, z); }
        public readonly Vector4U17F15 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, w, w, w); }
        public readonly Vector4U17F15 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, x, x); }
        public readonly Vector4U17F15 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, x, y); }
        public readonly Vector4U17F15 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, x, z); }
        public readonly Vector4U17F15 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, x, w); }
        public readonly Vector4U17F15 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, y, x); }
        public readonly Vector4U17F15 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, y, y); }
        public readonly Vector4U17F15 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, y, z); }
        public readonly Vector4U17F15 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, y, w); }
        public readonly Vector4U17F15 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, z, x); }
        public readonly Vector4U17F15 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, z, y); }
        public readonly Vector4U17F15 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, z, z); }
        public readonly Vector4U17F15 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, z, w); }
        public readonly Vector4U17F15 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, w, x); }
        public readonly Vector4U17F15 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, w, y); }
        public readonly Vector4U17F15 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, w, z); }
        public readonly Vector4U17F15 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, w, w); }
        public readonly Vector4U17F15 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, x, x); }
        public readonly Vector4U17F15 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, x, y); }
        public readonly Vector4U17F15 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, x, z); }
        public readonly Vector4U17F15 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, x, w); }
        public readonly Vector4U17F15 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, y, x); }
        public readonly Vector4U17F15 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, y, y); }
        public readonly Vector4U17F15 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, y, z); }
        public readonly Vector4U17F15 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, y, w); }
        public readonly Vector4U17F15 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, z, x); }
        public readonly Vector4U17F15 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, z, y); }
        public readonly Vector4U17F15 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, z, z); }
        public readonly Vector4U17F15 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, z, w); }
        public readonly Vector4U17F15 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, w, x); }
        public readonly Vector4U17F15 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, w, y); }
        public readonly Vector4U17F15 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, w, z); }
        public readonly Vector4U17F15 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, w, w); }
        public readonly Vector4U17F15 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, x, x); }
        public readonly Vector4U17F15 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, x, y); }
        public readonly Vector4U17F15 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, x, z); }
        public readonly Vector4U17F15 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, x, w); }
        public readonly Vector4U17F15 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, y, x); }
        public readonly Vector4U17F15 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, y, y); }
        public readonly Vector4U17F15 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, y, z); }
        public readonly Vector4U17F15 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, y, w); }
        public readonly Vector4U17F15 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, z, x); }
        public readonly Vector4U17F15 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, z, y); }
        public readonly Vector4U17F15 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, z, z); }
        public readonly Vector4U17F15 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, z, w); }
        public readonly Vector4U17F15 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, w, x); }
        public readonly Vector4U17F15 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, w, y); }
        public readonly Vector4U17F15 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, w, z); }
        public readonly Vector4U17F15 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, w, w); }
        public readonly Vector4U17F15 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, x, x); }
        public readonly Vector4U17F15 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, x, y); }
        public readonly Vector4U17F15 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, x, z); }
        public readonly Vector4U17F15 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, x, w); }
        public readonly Vector4U17F15 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, y, x); }
        public readonly Vector4U17F15 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, y, y); }
        public readonly Vector4U17F15 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, y, z); }
        public readonly Vector4U17F15 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, y, w); }
        public readonly Vector4U17F15 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, z, x); }
        public readonly Vector4U17F15 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, z, y); }
        public readonly Vector4U17F15 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, z, z); }
        public readonly Vector4U17F15 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, z, w); }
        public readonly Vector4U17F15 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, w, x); }
        public readonly Vector4U17F15 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, w, y); }
        public readonly Vector4U17F15 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, w, z); }
        public readonly Vector4U17F15 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, w, w, w); }
        public readonly Vector4U17F15 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, x, x); }
        public readonly Vector4U17F15 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, x, y); }
        public readonly Vector4U17F15 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, x, z); }
        public readonly Vector4U17F15 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, x, w); }
        public readonly Vector4U17F15 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, y, x); }
        public readonly Vector4U17F15 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, y, y); }
        public readonly Vector4U17F15 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, y, z); }
        public readonly Vector4U17F15 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, y, w); }
        public readonly Vector4U17F15 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, z, x); }
        public readonly Vector4U17F15 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, z, y); }
        public readonly Vector4U17F15 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, z, z); }
        public readonly Vector4U17F15 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, z, w); }
        public readonly Vector4U17F15 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, w, x); }
        public readonly Vector4U17F15 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, w, y); }
        public readonly Vector4U17F15 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, w, z); }
        public readonly Vector4U17F15 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, w, w); }
        public readonly Vector4U17F15 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, x, x); }
        public readonly Vector4U17F15 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, x, y); }
        public readonly Vector4U17F15 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, x, z); }
        public readonly Vector4U17F15 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, x, w); }
        public readonly Vector4U17F15 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, y, x); }
        public readonly Vector4U17F15 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, y, y); }
        public readonly Vector4U17F15 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, y, z); }
        public readonly Vector4U17F15 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, y, w); }
        public readonly Vector4U17F15 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, z, x); }
        public readonly Vector4U17F15 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, z, y); }
        public readonly Vector4U17F15 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, z, z); }
        public readonly Vector4U17F15 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, z, w); }
        public readonly Vector4U17F15 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, w, x); }
        public readonly Vector4U17F15 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, w, y); }
        public readonly Vector4U17F15 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, w, z); }
        public readonly Vector4U17F15 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, w, w); }
        public readonly Vector4U17F15 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, x, x); }
        public readonly Vector4U17F15 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, x, y); }
        public readonly Vector4U17F15 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, x, z); }
        public readonly Vector4U17F15 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, x, w); }
        public readonly Vector4U17F15 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, y, x); }
        public readonly Vector4U17F15 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, y, y); }
        public readonly Vector4U17F15 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, y, z); }
        public readonly Vector4U17F15 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, y, w); }
        public readonly Vector4U17F15 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, z, x); }
        public readonly Vector4U17F15 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, z, y); }
        public readonly Vector4U17F15 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, z, z); }
        public readonly Vector4U17F15 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, z, w); }
        public readonly Vector4U17F15 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, w, x); }
        public readonly Vector4U17F15 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, w, y); }
        public readonly Vector4U17F15 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, w, z); }
        public readonly Vector4U17F15 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, w, w); }
        public readonly Vector4U17F15 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, x, x); }
        public readonly Vector4U17F15 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, x, y); }
        public readonly Vector4U17F15 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, x, z); }
        public readonly Vector4U17F15 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, x, w); }
        public readonly Vector4U17F15 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, y, x); }
        public readonly Vector4U17F15 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, y, y); }
        public readonly Vector4U17F15 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, y, z); }
        public readonly Vector4U17F15 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, y, w); }
        public readonly Vector4U17F15 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, z, x); }
        public readonly Vector4U17F15 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, z, y); }
        public readonly Vector4U17F15 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, z, z); }
        public readonly Vector4U17F15 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, z, w); }
        public readonly Vector4U17F15 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, w, x); }
        public readonly Vector4U17F15 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, w, y); }
        public readonly Vector4U17F15 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, w, z); }
        public readonly Vector4U17F15 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, w, w, w); }
        public readonly Vector4U17F15 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, x, x); }
        public readonly Vector4U17F15 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, x, y); }
        public readonly Vector4U17F15 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, x, z); }
        public readonly Vector4U17F15 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, x, w); }
        public readonly Vector4U17F15 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, y, x); }
        public readonly Vector4U17F15 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, y, y); }
        public readonly Vector4U17F15 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, y, z); }
        public readonly Vector4U17F15 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, y, w); }
        public readonly Vector4U17F15 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, z, x); }
        public readonly Vector4U17F15 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, z, y); }
        public readonly Vector4U17F15 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, z, z); }
        public readonly Vector4U17F15 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, z, w); }
        public readonly Vector4U17F15 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, w, x); }
        public readonly Vector4U17F15 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, w, y); }
        public readonly Vector4U17F15 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, w, z); }
        public readonly Vector4U17F15 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, x, w, w); }
        public readonly Vector4U17F15 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, x, x); }
        public readonly Vector4U17F15 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, x, y); }
        public readonly Vector4U17F15 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, x, z); }
        public readonly Vector4U17F15 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, x, w); }
        public readonly Vector4U17F15 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, y, x); }
        public readonly Vector4U17F15 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, y, y); }
        public readonly Vector4U17F15 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, y, z); }
        public readonly Vector4U17F15 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, y, w); }
        public readonly Vector4U17F15 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, z, x); }
        public readonly Vector4U17F15 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, z, y); }
        public readonly Vector4U17F15 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, z, z); }
        public readonly Vector4U17F15 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, z, w); }
        public readonly Vector4U17F15 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, w, x); }
        public readonly Vector4U17F15 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, w, y); }
        public readonly Vector4U17F15 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, w, z); }
        public readonly Vector4U17F15 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, y, w, w); }
        public readonly Vector4U17F15 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, x, x); }
        public readonly Vector4U17F15 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, x, y); }
        public readonly Vector4U17F15 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, x, z); }
        public readonly Vector4U17F15 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, x, w); }
        public readonly Vector4U17F15 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, y, x); }
        public readonly Vector4U17F15 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, y, y); }
        public readonly Vector4U17F15 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, y, z); }
        public readonly Vector4U17F15 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, y, w); }
        public readonly Vector4U17F15 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, z, x); }
        public readonly Vector4U17F15 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, z, y); }
        public readonly Vector4U17F15 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, z, z); }
        public readonly Vector4U17F15 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, z, w); }
        public readonly Vector4U17F15 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, w, x); }
        public readonly Vector4U17F15 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, w, y); }
        public readonly Vector4U17F15 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, w, z); }
        public readonly Vector4U17F15 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, z, w, w); }
        public readonly Vector4U17F15 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, x, x); }
        public readonly Vector4U17F15 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, x, y); }
        public readonly Vector4U17F15 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, x, z); }
        public readonly Vector4U17F15 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, x, w); }
        public readonly Vector4U17F15 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, y, x); }
        public readonly Vector4U17F15 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, y, y); }
        public readonly Vector4U17F15 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, y, z); }
        public readonly Vector4U17F15 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, y, w); }
        public readonly Vector4U17F15 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, z, x); }
        public readonly Vector4U17F15 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, z, y); }
        public readonly Vector4U17F15 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, z, z); }
        public readonly Vector4U17F15 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, z, w); }
        public readonly Vector4U17F15 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, w, x); }
        public readonly Vector4U17F15 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, w, y); }
        public readonly Vector4U17F15 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, w, z); }
        public readonly Vector4U17F15 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U17F15 lhs, Vector4U17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U17F15 lhs, Vector4U17F15 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U17F15({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U17F15 other)
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
            return $"Vector4U17F15({x}, {y}, {z}, {w})";
        }
    }
}
