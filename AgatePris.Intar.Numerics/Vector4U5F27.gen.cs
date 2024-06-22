using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U5F27 : IEquatable<Vector4U5F27>, IFormattable {
        // Fields
        // ---------------------------------------

        public U5F27 x;
        public U5F27 y;
        public U5F27 z;
        public U5F27 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U5F27 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U5F27(U5F27 x, U5F27 y, U5F27 z, U5F27 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U5F27(U5F27 x, U5F27 y, Vector2U5F27 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U5F27(U5F27 x, Vector3U5F27 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U5F27(Vector2U5F27 xy, Vector2U5F27 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U5F27(Vector4U5F27 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U5F27(U5F27 x, Vector2U5F27 yz, U5F27 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U5F27(Vector3U5F27 xyz, U5F27 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U5F27(Vector2U5F27 xy, U5F27 z, U5F27 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 operator +(Vector4U5F27 a, Vector4U5F27 b) => new Vector4U5F27(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 operator -(Vector4U5F27 a, Vector4U5F27 b) => new Vector4U5F27(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 operator *(Vector4U5F27 a, Vector4U5F27 b) => new Vector4U5F27(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 operator *(Vector4U5F27 a, U5F27 b) => new Vector4U5F27(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 operator *(U5F27 a, Vector4U5F27 b) => new Vector4U5F27(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 operator /(Vector4U5F27 a, Vector4U5F27 b) => new Vector4U5F27(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 operator /(Vector4U5F27 a, U5F27 b) => new Vector4U5F27(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 operator /(U5F27 a, Vector4U5F27 b) => new Vector4U5F27(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U5F27 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(x, x); }
        public readonly Vector2U5F27 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(x, y); }
        public readonly Vector2U5F27 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(x, z); }
        public readonly Vector2U5F27 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(x, w); }
        public readonly Vector2U5F27 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(y, x); }
        public readonly Vector2U5F27 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(y, y); }
        public readonly Vector2U5F27 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(y, z); }
        public readonly Vector2U5F27 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(y, w); }
        public readonly Vector2U5F27 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(z, x); }
        public readonly Vector2U5F27 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(z, y); }
        public readonly Vector2U5F27 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(z, z); }
        public readonly Vector2U5F27 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(z, w); }
        public readonly Vector2U5F27 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(w, x); }
        public readonly Vector2U5F27 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(w, y); }
        public readonly Vector2U5F27 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(w, z); }
        public readonly Vector2U5F27 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(w, w); }
        public readonly Vector3U5F27 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, x, x); }
        public readonly Vector3U5F27 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, x, y); }
        public readonly Vector3U5F27 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, x, z); }
        public readonly Vector3U5F27 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, x, w); }
        public readonly Vector3U5F27 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, y, x); }
        public readonly Vector3U5F27 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, y, y); }
        public readonly Vector3U5F27 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, y, z); }
        public readonly Vector3U5F27 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, y, w); }
        public readonly Vector3U5F27 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, z, x); }
        public readonly Vector3U5F27 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, z, y); }
        public readonly Vector3U5F27 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, z, z); }
        public readonly Vector3U5F27 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, z, w); }
        public readonly Vector3U5F27 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, w, x); }
        public readonly Vector3U5F27 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, w, y); }
        public readonly Vector3U5F27 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, w, z); }
        public readonly Vector3U5F27 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(x, w, w); }
        public readonly Vector3U5F27 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, x, x); }
        public readonly Vector3U5F27 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, x, y); }
        public readonly Vector3U5F27 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, x, z); }
        public readonly Vector3U5F27 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, x, w); }
        public readonly Vector3U5F27 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, y, x); }
        public readonly Vector3U5F27 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, y, y); }
        public readonly Vector3U5F27 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, y, z); }
        public readonly Vector3U5F27 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, y, w); }
        public readonly Vector3U5F27 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, z, x); }
        public readonly Vector3U5F27 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, z, y); }
        public readonly Vector3U5F27 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, z, z); }
        public readonly Vector3U5F27 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, z, w); }
        public readonly Vector3U5F27 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, w, x); }
        public readonly Vector3U5F27 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, w, y); }
        public readonly Vector3U5F27 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, w, z); }
        public readonly Vector3U5F27 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(y, w, w); }
        public readonly Vector3U5F27 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, x, x); }
        public readonly Vector3U5F27 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, x, y); }
        public readonly Vector3U5F27 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, x, z); }
        public readonly Vector3U5F27 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, x, w); }
        public readonly Vector3U5F27 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, y, x); }
        public readonly Vector3U5F27 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, y, y); }
        public readonly Vector3U5F27 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, y, z); }
        public readonly Vector3U5F27 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, y, w); }
        public readonly Vector3U5F27 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, z, x); }
        public readonly Vector3U5F27 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, z, y); }
        public readonly Vector3U5F27 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, z, z); }
        public readonly Vector3U5F27 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, z, w); }
        public readonly Vector3U5F27 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, w, x); }
        public readonly Vector3U5F27 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, w, y); }
        public readonly Vector3U5F27 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, w, z); }
        public readonly Vector3U5F27 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(z, w, w); }
        public readonly Vector3U5F27 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, x, x); }
        public readonly Vector3U5F27 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, x, y); }
        public readonly Vector3U5F27 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, x, z); }
        public readonly Vector3U5F27 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, x, w); }
        public readonly Vector3U5F27 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, y, x); }
        public readonly Vector3U5F27 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, y, y); }
        public readonly Vector3U5F27 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, y, z); }
        public readonly Vector3U5F27 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, y, w); }
        public readonly Vector3U5F27 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, z, x); }
        public readonly Vector3U5F27 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, z, y); }
        public readonly Vector3U5F27 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, z, z); }
        public readonly Vector3U5F27 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, z, w); }
        public readonly Vector3U5F27 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, w, x); }
        public readonly Vector3U5F27 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, w, y); }
        public readonly Vector3U5F27 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, w, z); }
        public readonly Vector3U5F27 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(w, w, w); }
        public readonly Vector4U5F27 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, x, x); }
        public readonly Vector4U5F27 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, x, y); }
        public readonly Vector4U5F27 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, x, z); }
        public readonly Vector4U5F27 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, x, w); }
        public readonly Vector4U5F27 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, y, x); }
        public readonly Vector4U5F27 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, y, y); }
        public readonly Vector4U5F27 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, y, z); }
        public readonly Vector4U5F27 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, y, w); }
        public readonly Vector4U5F27 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, z, x); }
        public readonly Vector4U5F27 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, z, y); }
        public readonly Vector4U5F27 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, z, z); }
        public readonly Vector4U5F27 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, z, w); }
        public readonly Vector4U5F27 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, w, x); }
        public readonly Vector4U5F27 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, w, y); }
        public readonly Vector4U5F27 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, w, z); }
        public readonly Vector4U5F27 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, x, w, w); }
        public readonly Vector4U5F27 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, x, x); }
        public readonly Vector4U5F27 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, x, y); }
        public readonly Vector4U5F27 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, x, z); }
        public readonly Vector4U5F27 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, x, w); }
        public readonly Vector4U5F27 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, y, x); }
        public readonly Vector4U5F27 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, y, y); }
        public readonly Vector4U5F27 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, y, z); }
        public readonly Vector4U5F27 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, y, w); }
        public readonly Vector4U5F27 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, z, x); }
        public readonly Vector4U5F27 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, z, y); }
        public readonly Vector4U5F27 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, z, z); }
        public readonly Vector4U5F27 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, z, w); }
        public readonly Vector4U5F27 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, w, x); }
        public readonly Vector4U5F27 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, w, y); }
        public readonly Vector4U5F27 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, w, z); }
        public readonly Vector4U5F27 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, y, w, w); }
        public readonly Vector4U5F27 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, x, x); }
        public readonly Vector4U5F27 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, x, y); }
        public readonly Vector4U5F27 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, x, z); }
        public readonly Vector4U5F27 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, x, w); }
        public readonly Vector4U5F27 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, y, x); }
        public readonly Vector4U5F27 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, y, y); }
        public readonly Vector4U5F27 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, y, z); }
        public readonly Vector4U5F27 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, y, w); }
        public readonly Vector4U5F27 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, z, x); }
        public readonly Vector4U5F27 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, z, y); }
        public readonly Vector4U5F27 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, z, z); }
        public readonly Vector4U5F27 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, z, w); }
        public readonly Vector4U5F27 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, w, x); }
        public readonly Vector4U5F27 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, w, y); }
        public readonly Vector4U5F27 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, w, z); }
        public readonly Vector4U5F27 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, z, w, w); }
        public readonly Vector4U5F27 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, x, x); }
        public readonly Vector4U5F27 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, x, y); }
        public readonly Vector4U5F27 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, x, z); }
        public readonly Vector4U5F27 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, x, w); }
        public readonly Vector4U5F27 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, y, x); }
        public readonly Vector4U5F27 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, y, y); }
        public readonly Vector4U5F27 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, y, z); }
        public readonly Vector4U5F27 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, y, w); }
        public readonly Vector4U5F27 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, z, x); }
        public readonly Vector4U5F27 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, z, y); }
        public readonly Vector4U5F27 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, z, z); }
        public readonly Vector4U5F27 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, z, w); }
        public readonly Vector4U5F27 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, w, x); }
        public readonly Vector4U5F27 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, w, y); }
        public readonly Vector4U5F27 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, w, z); }
        public readonly Vector4U5F27 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(x, w, w, w); }
        public readonly Vector4U5F27 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, x, x); }
        public readonly Vector4U5F27 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, x, y); }
        public readonly Vector4U5F27 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, x, z); }
        public readonly Vector4U5F27 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, x, w); }
        public readonly Vector4U5F27 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, y, x); }
        public readonly Vector4U5F27 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, y, y); }
        public readonly Vector4U5F27 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, y, z); }
        public readonly Vector4U5F27 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, y, w); }
        public readonly Vector4U5F27 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, z, x); }
        public readonly Vector4U5F27 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, z, y); }
        public readonly Vector4U5F27 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, z, z); }
        public readonly Vector4U5F27 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, z, w); }
        public readonly Vector4U5F27 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, w, x); }
        public readonly Vector4U5F27 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, w, y); }
        public readonly Vector4U5F27 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, w, z); }
        public readonly Vector4U5F27 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, x, w, w); }
        public readonly Vector4U5F27 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, x, x); }
        public readonly Vector4U5F27 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, x, y); }
        public readonly Vector4U5F27 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, x, z); }
        public readonly Vector4U5F27 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, x, w); }
        public readonly Vector4U5F27 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, y, x); }
        public readonly Vector4U5F27 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, y, y); }
        public readonly Vector4U5F27 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, y, z); }
        public readonly Vector4U5F27 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, y, w); }
        public readonly Vector4U5F27 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, z, x); }
        public readonly Vector4U5F27 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, z, y); }
        public readonly Vector4U5F27 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, z, z); }
        public readonly Vector4U5F27 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, z, w); }
        public readonly Vector4U5F27 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, w, x); }
        public readonly Vector4U5F27 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, w, y); }
        public readonly Vector4U5F27 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, w, z); }
        public readonly Vector4U5F27 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, y, w, w); }
        public readonly Vector4U5F27 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, x, x); }
        public readonly Vector4U5F27 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, x, y); }
        public readonly Vector4U5F27 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, x, z); }
        public readonly Vector4U5F27 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, x, w); }
        public readonly Vector4U5F27 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, y, x); }
        public readonly Vector4U5F27 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, y, y); }
        public readonly Vector4U5F27 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, y, z); }
        public readonly Vector4U5F27 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, y, w); }
        public readonly Vector4U5F27 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, z, x); }
        public readonly Vector4U5F27 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, z, y); }
        public readonly Vector4U5F27 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, z, z); }
        public readonly Vector4U5F27 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, z, w); }
        public readonly Vector4U5F27 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, w, x); }
        public readonly Vector4U5F27 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, w, y); }
        public readonly Vector4U5F27 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, w, z); }
        public readonly Vector4U5F27 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, z, w, w); }
        public readonly Vector4U5F27 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, x, x); }
        public readonly Vector4U5F27 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, x, y); }
        public readonly Vector4U5F27 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, x, z); }
        public readonly Vector4U5F27 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, x, w); }
        public readonly Vector4U5F27 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, y, x); }
        public readonly Vector4U5F27 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, y, y); }
        public readonly Vector4U5F27 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, y, z); }
        public readonly Vector4U5F27 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, y, w); }
        public readonly Vector4U5F27 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, z, x); }
        public readonly Vector4U5F27 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, z, y); }
        public readonly Vector4U5F27 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, z, z); }
        public readonly Vector4U5F27 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, z, w); }
        public readonly Vector4U5F27 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, w, x); }
        public readonly Vector4U5F27 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, w, y); }
        public readonly Vector4U5F27 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, w, z); }
        public readonly Vector4U5F27 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(y, w, w, w); }
        public readonly Vector4U5F27 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, x, x); }
        public readonly Vector4U5F27 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, x, y); }
        public readonly Vector4U5F27 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, x, z); }
        public readonly Vector4U5F27 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, x, w); }
        public readonly Vector4U5F27 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, y, x); }
        public readonly Vector4U5F27 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, y, y); }
        public readonly Vector4U5F27 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, y, z); }
        public readonly Vector4U5F27 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, y, w); }
        public readonly Vector4U5F27 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, z, x); }
        public readonly Vector4U5F27 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, z, y); }
        public readonly Vector4U5F27 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, z, z); }
        public readonly Vector4U5F27 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, z, w); }
        public readonly Vector4U5F27 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, w, x); }
        public readonly Vector4U5F27 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, w, y); }
        public readonly Vector4U5F27 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, w, z); }
        public readonly Vector4U5F27 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, x, w, w); }
        public readonly Vector4U5F27 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, x, x); }
        public readonly Vector4U5F27 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, x, y); }
        public readonly Vector4U5F27 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, x, z); }
        public readonly Vector4U5F27 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, x, w); }
        public readonly Vector4U5F27 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, y, x); }
        public readonly Vector4U5F27 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, y, y); }
        public readonly Vector4U5F27 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, y, z); }
        public readonly Vector4U5F27 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, y, w); }
        public readonly Vector4U5F27 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, z, x); }
        public readonly Vector4U5F27 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, z, y); }
        public readonly Vector4U5F27 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, z, z); }
        public readonly Vector4U5F27 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, z, w); }
        public readonly Vector4U5F27 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, w, x); }
        public readonly Vector4U5F27 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, w, y); }
        public readonly Vector4U5F27 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, w, z); }
        public readonly Vector4U5F27 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, y, w, w); }
        public readonly Vector4U5F27 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, x, x); }
        public readonly Vector4U5F27 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, x, y); }
        public readonly Vector4U5F27 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, x, z); }
        public readonly Vector4U5F27 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, x, w); }
        public readonly Vector4U5F27 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, y, x); }
        public readonly Vector4U5F27 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, y, y); }
        public readonly Vector4U5F27 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, y, z); }
        public readonly Vector4U5F27 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, y, w); }
        public readonly Vector4U5F27 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, z, x); }
        public readonly Vector4U5F27 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, z, y); }
        public readonly Vector4U5F27 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, z, z); }
        public readonly Vector4U5F27 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, z, w); }
        public readonly Vector4U5F27 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, w, x); }
        public readonly Vector4U5F27 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, w, y); }
        public readonly Vector4U5F27 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, w, z); }
        public readonly Vector4U5F27 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, z, w, w); }
        public readonly Vector4U5F27 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, x, x); }
        public readonly Vector4U5F27 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, x, y); }
        public readonly Vector4U5F27 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, x, z); }
        public readonly Vector4U5F27 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, x, w); }
        public readonly Vector4U5F27 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, y, x); }
        public readonly Vector4U5F27 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, y, y); }
        public readonly Vector4U5F27 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, y, z); }
        public readonly Vector4U5F27 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, y, w); }
        public readonly Vector4U5F27 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, z, x); }
        public readonly Vector4U5F27 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, z, y); }
        public readonly Vector4U5F27 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, z, z); }
        public readonly Vector4U5F27 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, z, w); }
        public readonly Vector4U5F27 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, w, x); }
        public readonly Vector4U5F27 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, w, y); }
        public readonly Vector4U5F27 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, w, z); }
        public readonly Vector4U5F27 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(z, w, w, w); }
        public readonly Vector4U5F27 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, x, x); }
        public readonly Vector4U5F27 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, x, y); }
        public readonly Vector4U5F27 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, x, z); }
        public readonly Vector4U5F27 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, x, w); }
        public readonly Vector4U5F27 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, y, x); }
        public readonly Vector4U5F27 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, y, y); }
        public readonly Vector4U5F27 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, y, z); }
        public readonly Vector4U5F27 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, y, w); }
        public readonly Vector4U5F27 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, z, x); }
        public readonly Vector4U5F27 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, z, y); }
        public readonly Vector4U5F27 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, z, z); }
        public readonly Vector4U5F27 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, z, w); }
        public readonly Vector4U5F27 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, w, x); }
        public readonly Vector4U5F27 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, w, y); }
        public readonly Vector4U5F27 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, w, z); }
        public readonly Vector4U5F27 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, x, w, w); }
        public readonly Vector4U5F27 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, x, x); }
        public readonly Vector4U5F27 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, x, y); }
        public readonly Vector4U5F27 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, x, z); }
        public readonly Vector4U5F27 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, x, w); }
        public readonly Vector4U5F27 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, y, x); }
        public readonly Vector4U5F27 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, y, y); }
        public readonly Vector4U5F27 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, y, z); }
        public readonly Vector4U5F27 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, y, w); }
        public readonly Vector4U5F27 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, z, x); }
        public readonly Vector4U5F27 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, z, y); }
        public readonly Vector4U5F27 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, z, z); }
        public readonly Vector4U5F27 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, z, w); }
        public readonly Vector4U5F27 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, w, x); }
        public readonly Vector4U5F27 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, w, y); }
        public readonly Vector4U5F27 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, w, z); }
        public readonly Vector4U5F27 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, y, w, w); }
        public readonly Vector4U5F27 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, x, x); }
        public readonly Vector4U5F27 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, x, y); }
        public readonly Vector4U5F27 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, x, z); }
        public readonly Vector4U5F27 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, x, w); }
        public readonly Vector4U5F27 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, y, x); }
        public readonly Vector4U5F27 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, y, y); }
        public readonly Vector4U5F27 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, y, z); }
        public readonly Vector4U5F27 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, y, w); }
        public readonly Vector4U5F27 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, z, x); }
        public readonly Vector4U5F27 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, z, y); }
        public readonly Vector4U5F27 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, z, z); }
        public readonly Vector4U5F27 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, z, w); }
        public readonly Vector4U5F27 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, w, x); }
        public readonly Vector4U5F27 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, w, y); }
        public readonly Vector4U5F27 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, w, z); }
        public readonly Vector4U5F27 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, z, w, w); }
        public readonly Vector4U5F27 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, x, x); }
        public readonly Vector4U5F27 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, x, y); }
        public readonly Vector4U5F27 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, x, z); }
        public readonly Vector4U5F27 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, x, w); }
        public readonly Vector4U5F27 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, y, x); }
        public readonly Vector4U5F27 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, y, y); }
        public readonly Vector4U5F27 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, y, z); }
        public readonly Vector4U5F27 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, y, w); }
        public readonly Vector4U5F27 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, z, x); }
        public readonly Vector4U5F27 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, z, y); }
        public readonly Vector4U5F27 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, z, z); }
        public readonly Vector4U5F27 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, z, w); }
        public readonly Vector4U5F27 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, w, x); }
        public readonly Vector4U5F27 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, w, y); }
        public readonly Vector4U5F27 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, w, z); }
        public readonly Vector4U5F27 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U5F27 lhs, Vector4U5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U5F27 lhs, Vector4U5F27 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U5F27({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U5F27 other)
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
            return $"Vector4U5F27({x}, {y}, {z}, {w})";
        }
    }
}
