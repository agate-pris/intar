using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U14F18 : IEquatable<Vector4U14F18>, IFormattable {
        // Fields
        // ---------------------------------------

        public U14F18 x;
        public U14F18 y;
        public U14F18 z;
        public U14F18 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U14F18 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(U14F18 x, U14F18 y, U14F18 z, U14F18 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(U14F18 x, U14F18 y, Vector2U14F18 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(U14F18 x, Vector3U14F18 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(Vector2U14F18 xy, Vector2U14F18 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(Vector4U14F18 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(U14F18 x, Vector2U14F18 yz, U14F18 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(Vector3U14F18 xyz, U14F18 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(Vector2U14F18 xy, U14F18 z, U14F18 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator +(Vector4U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator -(Vector4U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator *(Vector4U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator *(Vector4U14F18 a, U14F18 b) => new Vector4U14F18(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator *(U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator /(Vector4U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator /(Vector4U14F18 a, U14F18 b) => new Vector4U14F18(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator /(U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U14F18 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(x, x); }
        public readonly Vector2U14F18 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(x, y); }
        public readonly Vector2U14F18 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(x, z); }
        public readonly Vector2U14F18 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(x, w); }
        public readonly Vector2U14F18 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(y, x); }
        public readonly Vector2U14F18 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(y, y); }
        public readonly Vector2U14F18 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(y, z); }
        public readonly Vector2U14F18 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(y, w); }
        public readonly Vector2U14F18 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(z, x); }
        public readonly Vector2U14F18 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(z, y); }
        public readonly Vector2U14F18 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(z, z); }
        public readonly Vector2U14F18 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(z, w); }
        public readonly Vector2U14F18 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(w, x); }
        public readonly Vector2U14F18 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(w, y); }
        public readonly Vector2U14F18 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(w, z); }
        public readonly Vector2U14F18 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(w, w); }
        public readonly Vector3U14F18 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, x, x); }
        public readonly Vector3U14F18 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, x, y); }
        public readonly Vector3U14F18 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, x, z); }
        public readonly Vector3U14F18 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, x, w); }
        public readonly Vector3U14F18 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, y, x); }
        public readonly Vector3U14F18 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, y, y); }
        public readonly Vector3U14F18 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, y, z); }
        public readonly Vector3U14F18 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, y, w); }
        public readonly Vector3U14F18 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, z, x); }
        public readonly Vector3U14F18 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, z, y); }
        public readonly Vector3U14F18 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, z, z); }
        public readonly Vector3U14F18 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, z, w); }
        public readonly Vector3U14F18 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, w, x); }
        public readonly Vector3U14F18 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, w, y); }
        public readonly Vector3U14F18 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, w, z); }
        public readonly Vector3U14F18 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, w, w); }
        public readonly Vector3U14F18 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, x, x); }
        public readonly Vector3U14F18 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, x, y); }
        public readonly Vector3U14F18 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, x, z); }
        public readonly Vector3U14F18 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, x, w); }
        public readonly Vector3U14F18 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, y, x); }
        public readonly Vector3U14F18 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, y, y); }
        public readonly Vector3U14F18 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, y, z); }
        public readonly Vector3U14F18 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, y, w); }
        public readonly Vector3U14F18 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, z, x); }
        public readonly Vector3U14F18 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, z, y); }
        public readonly Vector3U14F18 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, z, z); }
        public readonly Vector3U14F18 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, z, w); }
        public readonly Vector3U14F18 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, w, x); }
        public readonly Vector3U14F18 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, w, y); }
        public readonly Vector3U14F18 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, w, z); }
        public readonly Vector3U14F18 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, w, w); }
        public readonly Vector3U14F18 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, x, x); }
        public readonly Vector3U14F18 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, x, y); }
        public readonly Vector3U14F18 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, x, z); }
        public readonly Vector3U14F18 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, x, w); }
        public readonly Vector3U14F18 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, y, x); }
        public readonly Vector3U14F18 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, y, y); }
        public readonly Vector3U14F18 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, y, z); }
        public readonly Vector3U14F18 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, y, w); }
        public readonly Vector3U14F18 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, z, x); }
        public readonly Vector3U14F18 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, z, y); }
        public readonly Vector3U14F18 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, z, z); }
        public readonly Vector3U14F18 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, z, w); }
        public readonly Vector3U14F18 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, w, x); }
        public readonly Vector3U14F18 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, w, y); }
        public readonly Vector3U14F18 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, w, z); }
        public readonly Vector3U14F18 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, w, w); }
        public readonly Vector3U14F18 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, x, x); }
        public readonly Vector3U14F18 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, x, y); }
        public readonly Vector3U14F18 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, x, z); }
        public readonly Vector3U14F18 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, x, w); }
        public readonly Vector3U14F18 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, y, x); }
        public readonly Vector3U14F18 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, y, y); }
        public readonly Vector3U14F18 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, y, z); }
        public readonly Vector3U14F18 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, y, w); }
        public readonly Vector3U14F18 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, z, x); }
        public readonly Vector3U14F18 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, z, y); }
        public readonly Vector3U14F18 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, z, z); }
        public readonly Vector3U14F18 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, z, w); }
        public readonly Vector3U14F18 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, w, x); }
        public readonly Vector3U14F18 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, w, y); }
        public readonly Vector3U14F18 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, w, z); }
        public readonly Vector3U14F18 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(w, w, w); }
        public readonly Vector4U14F18 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, x, x); }
        public readonly Vector4U14F18 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, x, y); }
        public readonly Vector4U14F18 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, x, z); }
        public readonly Vector4U14F18 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, x, w); }
        public readonly Vector4U14F18 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, y, x); }
        public readonly Vector4U14F18 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, y, y); }
        public readonly Vector4U14F18 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, y, z); }
        public readonly Vector4U14F18 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, y, w); }
        public readonly Vector4U14F18 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, z, x); }
        public readonly Vector4U14F18 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, z, y); }
        public readonly Vector4U14F18 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, z, z); }
        public readonly Vector4U14F18 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, z, w); }
        public readonly Vector4U14F18 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, w, x); }
        public readonly Vector4U14F18 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, w, y); }
        public readonly Vector4U14F18 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, w, z); }
        public readonly Vector4U14F18 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, w, w); }
        public readonly Vector4U14F18 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, x, x); }
        public readonly Vector4U14F18 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, x, y); }
        public readonly Vector4U14F18 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, x, z); }
        public readonly Vector4U14F18 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, x, w); }
        public readonly Vector4U14F18 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, y, x); }
        public readonly Vector4U14F18 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, y, y); }
        public readonly Vector4U14F18 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, y, z); }
        public readonly Vector4U14F18 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, y, w); }
        public readonly Vector4U14F18 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, z, x); }
        public readonly Vector4U14F18 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, z, y); }
        public readonly Vector4U14F18 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, z, z); }
        public readonly Vector4U14F18 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, z, w); }
        public readonly Vector4U14F18 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, w, x); }
        public readonly Vector4U14F18 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, w, y); }
        public readonly Vector4U14F18 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, w, z); }
        public readonly Vector4U14F18 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, w, w); }
        public readonly Vector4U14F18 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, x, x); }
        public readonly Vector4U14F18 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, x, y); }
        public readonly Vector4U14F18 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, x, z); }
        public readonly Vector4U14F18 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, x, w); }
        public readonly Vector4U14F18 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, y, x); }
        public readonly Vector4U14F18 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, y, y); }
        public readonly Vector4U14F18 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, y, z); }
        public readonly Vector4U14F18 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, y, w); }
        public readonly Vector4U14F18 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, z, x); }
        public readonly Vector4U14F18 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, z, y); }
        public readonly Vector4U14F18 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, z, z); }
        public readonly Vector4U14F18 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, z, w); }
        public readonly Vector4U14F18 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, w, x); }
        public readonly Vector4U14F18 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, w, y); }
        public readonly Vector4U14F18 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, w, z); }
        public readonly Vector4U14F18 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, w, w); }
        public readonly Vector4U14F18 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, x, x); }
        public readonly Vector4U14F18 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, x, y); }
        public readonly Vector4U14F18 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, x, z); }
        public readonly Vector4U14F18 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, x, w); }
        public readonly Vector4U14F18 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, y, x); }
        public readonly Vector4U14F18 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, y, y); }
        public readonly Vector4U14F18 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, y, z); }
        public readonly Vector4U14F18 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, y, w); }
        public readonly Vector4U14F18 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, z, x); }
        public readonly Vector4U14F18 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, z, y); }
        public readonly Vector4U14F18 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, z, z); }
        public readonly Vector4U14F18 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, z, w); }
        public readonly Vector4U14F18 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, w, x); }
        public readonly Vector4U14F18 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, w, y); }
        public readonly Vector4U14F18 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, w, z); }
        public readonly Vector4U14F18 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, w, w, w); }
        public readonly Vector4U14F18 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, x, x); }
        public readonly Vector4U14F18 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, x, y); }
        public readonly Vector4U14F18 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, x, z); }
        public readonly Vector4U14F18 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, x, w); }
        public readonly Vector4U14F18 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, y, x); }
        public readonly Vector4U14F18 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, y, y); }
        public readonly Vector4U14F18 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, y, z); }
        public readonly Vector4U14F18 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, y, w); }
        public readonly Vector4U14F18 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, z, x); }
        public readonly Vector4U14F18 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, z, y); }
        public readonly Vector4U14F18 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, z, z); }
        public readonly Vector4U14F18 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, z, w); }
        public readonly Vector4U14F18 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, w, x); }
        public readonly Vector4U14F18 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, w, y); }
        public readonly Vector4U14F18 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, w, z); }
        public readonly Vector4U14F18 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, w, w); }
        public readonly Vector4U14F18 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, x, x); }
        public readonly Vector4U14F18 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, x, y); }
        public readonly Vector4U14F18 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, x, z); }
        public readonly Vector4U14F18 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, x, w); }
        public readonly Vector4U14F18 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, y, x); }
        public readonly Vector4U14F18 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, y, y); }
        public readonly Vector4U14F18 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, y, z); }
        public readonly Vector4U14F18 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, y, w); }
        public readonly Vector4U14F18 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, z, x); }
        public readonly Vector4U14F18 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, z, y); }
        public readonly Vector4U14F18 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, z, z); }
        public readonly Vector4U14F18 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, z, w); }
        public readonly Vector4U14F18 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, w, x); }
        public readonly Vector4U14F18 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, w, y); }
        public readonly Vector4U14F18 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, w, z); }
        public readonly Vector4U14F18 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, w, w); }
        public readonly Vector4U14F18 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, x, x); }
        public readonly Vector4U14F18 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, x, y); }
        public readonly Vector4U14F18 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, x, z); }
        public readonly Vector4U14F18 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, x, w); }
        public readonly Vector4U14F18 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, y, x); }
        public readonly Vector4U14F18 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, y, y); }
        public readonly Vector4U14F18 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, y, z); }
        public readonly Vector4U14F18 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, y, w); }
        public readonly Vector4U14F18 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, z, x); }
        public readonly Vector4U14F18 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, z, y); }
        public readonly Vector4U14F18 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, z, z); }
        public readonly Vector4U14F18 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, z, w); }
        public readonly Vector4U14F18 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, w, x); }
        public readonly Vector4U14F18 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, w, y); }
        public readonly Vector4U14F18 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, w, z); }
        public readonly Vector4U14F18 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, w, w); }
        public readonly Vector4U14F18 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, x, x); }
        public readonly Vector4U14F18 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, x, y); }
        public readonly Vector4U14F18 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, x, z); }
        public readonly Vector4U14F18 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, x, w); }
        public readonly Vector4U14F18 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, y, x); }
        public readonly Vector4U14F18 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, y, y); }
        public readonly Vector4U14F18 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, y, z); }
        public readonly Vector4U14F18 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, y, w); }
        public readonly Vector4U14F18 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, z, x); }
        public readonly Vector4U14F18 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, z, y); }
        public readonly Vector4U14F18 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, z, z); }
        public readonly Vector4U14F18 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, z, w); }
        public readonly Vector4U14F18 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, w, x); }
        public readonly Vector4U14F18 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, w, y); }
        public readonly Vector4U14F18 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, w, z); }
        public readonly Vector4U14F18 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, w, w, w); }
        public readonly Vector4U14F18 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, x, x); }
        public readonly Vector4U14F18 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, x, y); }
        public readonly Vector4U14F18 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, x, z); }
        public readonly Vector4U14F18 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, x, w); }
        public readonly Vector4U14F18 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, y, x); }
        public readonly Vector4U14F18 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, y, y); }
        public readonly Vector4U14F18 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, y, z); }
        public readonly Vector4U14F18 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, y, w); }
        public readonly Vector4U14F18 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, z, x); }
        public readonly Vector4U14F18 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, z, y); }
        public readonly Vector4U14F18 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, z, z); }
        public readonly Vector4U14F18 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, z, w); }
        public readonly Vector4U14F18 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, w, x); }
        public readonly Vector4U14F18 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, w, y); }
        public readonly Vector4U14F18 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, w, z); }
        public readonly Vector4U14F18 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, w, w); }
        public readonly Vector4U14F18 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, x, x); }
        public readonly Vector4U14F18 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, x, y); }
        public readonly Vector4U14F18 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, x, z); }
        public readonly Vector4U14F18 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, x, w); }
        public readonly Vector4U14F18 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, y, x); }
        public readonly Vector4U14F18 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, y, y); }
        public readonly Vector4U14F18 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, y, z); }
        public readonly Vector4U14F18 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, y, w); }
        public readonly Vector4U14F18 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, z, x); }
        public readonly Vector4U14F18 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, z, y); }
        public readonly Vector4U14F18 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, z, z); }
        public readonly Vector4U14F18 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, z, w); }
        public readonly Vector4U14F18 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, w, x); }
        public readonly Vector4U14F18 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, w, y); }
        public readonly Vector4U14F18 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, w, z); }
        public readonly Vector4U14F18 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, w, w); }
        public readonly Vector4U14F18 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, x, x); }
        public readonly Vector4U14F18 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, x, y); }
        public readonly Vector4U14F18 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, x, z); }
        public readonly Vector4U14F18 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, x, w); }
        public readonly Vector4U14F18 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, y, x); }
        public readonly Vector4U14F18 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, y, y); }
        public readonly Vector4U14F18 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, y, z); }
        public readonly Vector4U14F18 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, y, w); }
        public readonly Vector4U14F18 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, z, x); }
        public readonly Vector4U14F18 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, z, y); }
        public readonly Vector4U14F18 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, z, z); }
        public readonly Vector4U14F18 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, z, w); }
        public readonly Vector4U14F18 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, w, x); }
        public readonly Vector4U14F18 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, w, y); }
        public readonly Vector4U14F18 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, w, z); }
        public readonly Vector4U14F18 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, w, w); }
        public readonly Vector4U14F18 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, x, x); }
        public readonly Vector4U14F18 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, x, y); }
        public readonly Vector4U14F18 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, x, z); }
        public readonly Vector4U14F18 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, x, w); }
        public readonly Vector4U14F18 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, y, x); }
        public readonly Vector4U14F18 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, y, y); }
        public readonly Vector4U14F18 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, y, z); }
        public readonly Vector4U14F18 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, y, w); }
        public readonly Vector4U14F18 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, z, x); }
        public readonly Vector4U14F18 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, z, y); }
        public readonly Vector4U14F18 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, z, z); }
        public readonly Vector4U14F18 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, z, w); }
        public readonly Vector4U14F18 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, w, x); }
        public readonly Vector4U14F18 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, w, y); }
        public readonly Vector4U14F18 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, w, z); }
        public readonly Vector4U14F18 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, w, w, w); }
        public readonly Vector4U14F18 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, x, x); }
        public readonly Vector4U14F18 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, x, y); }
        public readonly Vector4U14F18 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, x, z); }
        public readonly Vector4U14F18 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, x, w); }
        public readonly Vector4U14F18 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, y, x); }
        public readonly Vector4U14F18 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, y, y); }
        public readonly Vector4U14F18 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, y, z); }
        public readonly Vector4U14F18 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, y, w); }
        public readonly Vector4U14F18 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, z, x); }
        public readonly Vector4U14F18 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, z, y); }
        public readonly Vector4U14F18 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, z, z); }
        public readonly Vector4U14F18 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, z, w); }
        public readonly Vector4U14F18 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, w, x); }
        public readonly Vector4U14F18 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, w, y); }
        public readonly Vector4U14F18 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, w, z); }
        public readonly Vector4U14F18 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, x, w, w); }
        public readonly Vector4U14F18 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, x, x); }
        public readonly Vector4U14F18 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, x, y); }
        public readonly Vector4U14F18 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, x, z); }
        public readonly Vector4U14F18 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, x, w); }
        public readonly Vector4U14F18 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, y, x); }
        public readonly Vector4U14F18 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, y, y); }
        public readonly Vector4U14F18 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, y, z); }
        public readonly Vector4U14F18 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, y, w); }
        public readonly Vector4U14F18 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, z, x); }
        public readonly Vector4U14F18 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, z, y); }
        public readonly Vector4U14F18 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, z, z); }
        public readonly Vector4U14F18 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, z, w); }
        public readonly Vector4U14F18 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, w, x); }
        public readonly Vector4U14F18 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, w, y); }
        public readonly Vector4U14F18 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, w, z); }
        public readonly Vector4U14F18 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, y, w, w); }
        public readonly Vector4U14F18 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, x, x); }
        public readonly Vector4U14F18 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, x, y); }
        public readonly Vector4U14F18 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, x, z); }
        public readonly Vector4U14F18 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, x, w); }
        public readonly Vector4U14F18 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, y, x); }
        public readonly Vector4U14F18 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, y, y); }
        public readonly Vector4U14F18 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, y, z); }
        public readonly Vector4U14F18 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, y, w); }
        public readonly Vector4U14F18 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, z, x); }
        public readonly Vector4U14F18 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, z, y); }
        public readonly Vector4U14F18 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, z, z); }
        public readonly Vector4U14F18 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, z, w); }
        public readonly Vector4U14F18 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, w, x); }
        public readonly Vector4U14F18 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, w, y); }
        public readonly Vector4U14F18 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, w, z); }
        public readonly Vector4U14F18 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, z, w, w); }
        public readonly Vector4U14F18 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, x, x); }
        public readonly Vector4U14F18 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, x, y); }
        public readonly Vector4U14F18 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, x, z); }
        public readonly Vector4U14F18 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, x, w); }
        public readonly Vector4U14F18 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, y, x); }
        public readonly Vector4U14F18 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, y, y); }
        public readonly Vector4U14F18 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, y, z); }
        public readonly Vector4U14F18 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, y, w); }
        public readonly Vector4U14F18 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, z, x); }
        public readonly Vector4U14F18 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, z, y); }
        public readonly Vector4U14F18 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, z, z); }
        public readonly Vector4U14F18 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, z, w); }
        public readonly Vector4U14F18 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, w, x); }
        public readonly Vector4U14F18 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, w, y); }
        public readonly Vector4U14F18 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, w, z); }
        public readonly Vector4U14F18 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U14F18 lhs, Vector4U14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U14F18 lhs, Vector4U14F18 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U14F18({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U14F18 other)
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
            return $"Vector4U14F18({x}, {y}, {z}, {w})";
        }
    }
}
