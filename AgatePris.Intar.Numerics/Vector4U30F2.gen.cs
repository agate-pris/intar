using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U30F2 : IEquatable<Vector4U30F2>, IFormattable {
        // Fields
        // ---------------------------------------

        public U30F2 x;
        public U30F2 y;
        public U30F2 z;
        public U30F2 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U30F2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, U30F2 y, U30F2 z, U30F2 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, U30F2 y, Vector2U30F2 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, Vector3U30F2 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector2U30F2 xy, Vector2U30F2 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector4U30F2 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, Vector2U30F2 yz, U30F2 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector3U30F2 xyz, U30F2 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector2U30F2 xy, U30F2 z, U30F2 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator +(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator -(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator *(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator *(Vector4U30F2 a, U30F2 b) => new Vector4U30F2(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator *(U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator /(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator /(Vector4U30F2 a, U30F2 b) => new Vector4U30F2(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator /(U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U30F2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(x, x); }
        public readonly Vector2U30F2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(x, y); }
        public readonly Vector2U30F2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(x, z); }
        public readonly Vector2U30F2 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(x, w); }
        public readonly Vector2U30F2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(y, x); }
        public readonly Vector2U30F2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(y, y); }
        public readonly Vector2U30F2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(y, z); }
        public readonly Vector2U30F2 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(y, w); }
        public readonly Vector2U30F2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(z, x); }
        public readonly Vector2U30F2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(z, y); }
        public readonly Vector2U30F2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(z, z); }
        public readonly Vector2U30F2 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(z, w); }
        public readonly Vector2U30F2 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(w, x); }
        public readonly Vector2U30F2 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(w, y); }
        public readonly Vector2U30F2 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(w, z); }
        public readonly Vector2U30F2 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(w, w); }
        public readonly Vector3U30F2 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, x, x); }
        public readonly Vector3U30F2 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, x, y); }
        public readonly Vector3U30F2 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, x, z); }
        public readonly Vector3U30F2 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, x, w); }
        public readonly Vector3U30F2 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, y, x); }
        public readonly Vector3U30F2 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, y, y); }
        public readonly Vector3U30F2 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, y, z); }
        public readonly Vector3U30F2 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, y, w); }
        public readonly Vector3U30F2 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, z, x); }
        public readonly Vector3U30F2 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, z, y); }
        public readonly Vector3U30F2 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, z, z); }
        public readonly Vector3U30F2 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, z, w); }
        public readonly Vector3U30F2 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, w, x); }
        public readonly Vector3U30F2 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, w, y); }
        public readonly Vector3U30F2 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, w, z); }
        public readonly Vector3U30F2 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, w, w); }
        public readonly Vector3U30F2 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, x, x); }
        public readonly Vector3U30F2 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, x, y); }
        public readonly Vector3U30F2 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, x, z); }
        public readonly Vector3U30F2 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, x, w); }
        public readonly Vector3U30F2 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, y, x); }
        public readonly Vector3U30F2 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, y, y); }
        public readonly Vector3U30F2 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, y, z); }
        public readonly Vector3U30F2 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, y, w); }
        public readonly Vector3U30F2 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, z, x); }
        public readonly Vector3U30F2 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, z, y); }
        public readonly Vector3U30F2 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, z, z); }
        public readonly Vector3U30F2 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, z, w); }
        public readonly Vector3U30F2 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, w, x); }
        public readonly Vector3U30F2 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, w, y); }
        public readonly Vector3U30F2 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, w, z); }
        public readonly Vector3U30F2 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, w, w); }
        public readonly Vector3U30F2 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, x, x); }
        public readonly Vector3U30F2 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, x, y); }
        public readonly Vector3U30F2 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, x, z); }
        public readonly Vector3U30F2 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, x, w); }
        public readonly Vector3U30F2 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, y, x); }
        public readonly Vector3U30F2 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, y, y); }
        public readonly Vector3U30F2 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, y, z); }
        public readonly Vector3U30F2 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, y, w); }
        public readonly Vector3U30F2 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, z, x); }
        public readonly Vector3U30F2 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, z, y); }
        public readonly Vector3U30F2 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, z, z); }
        public readonly Vector3U30F2 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, z, w); }
        public readonly Vector3U30F2 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, w, x); }
        public readonly Vector3U30F2 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, w, y); }
        public readonly Vector3U30F2 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, w, z); }
        public readonly Vector3U30F2 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(z, w, w); }
        public readonly Vector3U30F2 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, x, x); }
        public readonly Vector3U30F2 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, x, y); }
        public readonly Vector3U30F2 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, x, z); }
        public readonly Vector3U30F2 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, x, w); }
        public readonly Vector3U30F2 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, y, x); }
        public readonly Vector3U30F2 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, y, y); }
        public readonly Vector3U30F2 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, y, z); }
        public readonly Vector3U30F2 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, y, w); }
        public readonly Vector3U30F2 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, z, x); }
        public readonly Vector3U30F2 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, z, y); }
        public readonly Vector3U30F2 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, z, z); }
        public readonly Vector3U30F2 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, z, w); }
        public readonly Vector3U30F2 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, w, x); }
        public readonly Vector3U30F2 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, w, y); }
        public readonly Vector3U30F2 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, w, z); }
        public readonly Vector3U30F2 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(w, w, w); }
        public readonly Vector4U30F2 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, x, x); }
        public readonly Vector4U30F2 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, x, y); }
        public readonly Vector4U30F2 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, x, z); }
        public readonly Vector4U30F2 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, x, w); }
        public readonly Vector4U30F2 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, y, x); }
        public readonly Vector4U30F2 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, y, y); }
        public readonly Vector4U30F2 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, y, z); }
        public readonly Vector4U30F2 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, y, w); }
        public readonly Vector4U30F2 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, z, x); }
        public readonly Vector4U30F2 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, z, y); }
        public readonly Vector4U30F2 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, z, z); }
        public readonly Vector4U30F2 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, z, w); }
        public readonly Vector4U30F2 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, w, x); }
        public readonly Vector4U30F2 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, w, y); }
        public readonly Vector4U30F2 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, w, z); }
        public readonly Vector4U30F2 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, w, w); }
        public readonly Vector4U30F2 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, x, x); }
        public readonly Vector4U30F2 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, x, y); }
        public readonly Vector4U30F2 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, x, z); }
        public readonly Vector4U30F2 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, x, w); }
        public readonly Vector4U30F2 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, y, x); }
        public readonly Vector4U30F2 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, y, y); }
        public readonly Vector4U30F2 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, y, z); }
        public readonly Vector4U30F2 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, y, w); }
        public readonly Vector4U30F2 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, z, x); }
        public readonly Vector4U30F2 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, z, y); }
        public readonly Vector4U30F2 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, z, z); }
        public readonly Vector4U30F2 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, z, w); }
        public readonly Vector4U30F2 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, w, x); }
        public readonly Vector4U30F2 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, w, y); }
        public readonly Vector4U30F2 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, w, z); }
        public readonly Vector4U30F2 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, w, w); }
        public readonly Vector4U30F2 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, x, x); }
        public readonly Vector4U30F2 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, x, y); }
        public readonly Vector4U30F2 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, x, z); }
        public readonly Vector4U30F2 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, x, w); }
        public readonly Vector4U30F2 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, y, x); }
        public readonly Vector4U30F2 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, y, y); }
        public readonly Vector4U30F2 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, y, z); }
        public readonly Vector4U30F2 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, y, w); }
        public readonly Vector4U30F2 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, z, x); }
        public readonly Vector4U30F2 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, z, y); }
        public readonly Vector4U30F2 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, z, z); }
        public readonly Vector4U30F2 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, z, w); }
        public readonly Vector4U30F2 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, w, x); }
        public readonly Vector4U30F2 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, w, y); }
        public readonly Vector4U30F2 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, w, z); }
        public readonly Vector4U30F2 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, z, w, w); }
        public readonly Vector4U30F2 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, x, x); }
        public readonly Vector4U30F2 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, x, y); }
        public readonly Vector4U30F2 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, x, z); }
        public readonly Vector4U30F2 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, x, w); }
        public readonly Vector4U30F2 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, y, x); }
        public readonly Vector4U30F2 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, y, y); }
        public readonly Vector4U30F2 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, y, z); }
        public readonly Vector4U30F2 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, y, w); }
        public readonly Vector4U30F2 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, z, x); }
        public readonly Vector4U30F2 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, z, y); }
        public readonly Vector4U30F2 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, z, z); }
        public readonly Vector4U30F2 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, z, w); }
        public readonly Vector4U30F2 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, w, x); }
        public readonly Vector4U30F2 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, w, y); }
        public readonly Vector4U30F2 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, w, z); }
        public readonly Vector4U30F2 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, w, w, w); }
        public readonly Vector4U30F2 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, x, x); }
        public readonly Vector4U30F2 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, x, y); }
        public readonly Vector4U30F2 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, x, z); }
        public readonly Vector4U30F2 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, x, w); }
        public readonly Vector4U30F2 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, y, x); }
        public readonly Vector4U30F2 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, y, y); }
        public readonly Vector4U30F2 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, y, z); }
        public readonly Vector4U30F2 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, y, w); }
        public readonly Vector4U30F2 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, z, x); }
        public readonly Vector4U30F2 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, z, y); }
        public readonly Vector4U30F2 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, z, z); }
        public readonly Vector4U30F2 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, z, w); }
        public readonly Vector4U30F2 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, w, x); }
        public readonly Vector4U30F2 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, w, y); }
        public readonly Vector4U30F2 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, w, z); }
        public readonly Vector4U30F2 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, w, w); }
        public readonly Vector4U30F2 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, x, x); }
        public readonly Vector4U30F2 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, x, y); }
        public readonly Vector4U30F2 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, x, z); }
        public readonly Vector4U30F2 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, x, w); }
        public readonly Vector4U30F2 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, y, x); }
        public readonly Vector4U30F2 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, y, y); }
        public readonly Vector4U30F2 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, y, z); }
        public readonly Vector4U30F2 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, y, w); }
        public readonly Vector4U30F2 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, z, x); }
        public readonly Vector4U30F2 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, z, y); }
        public readonly Vector4U30F2 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, z, z); }
        public readonly Vector4U30F2 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, z, w); }
        public readonly Vector4U30F2 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, w, x); }
        public readonly Vector4U30F2 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, w, y); }
        public readonly Vector4U30F2 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, w, z); }
        public readonly Vector4U30F2 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, w, w); }
        public readonly Vector4U30F2 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, x, x); }
        public readonly Vector4U30F2 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, x, y); }
        public readonly Vector4U30F2 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, x, z); }
        public readonly Vector4U30F2 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, x, w); }
        public readonly Vector4U30F2 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, y, x); }
        public readonly Vector4U30F2 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, y, y); }
        public readonly Vector4U30F2 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, y, z); }
        public readonly Vector4U30F2 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, y, w); }
        public readonly Vector4U30F2 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, z, x); }
        public readonly Vector4U30F2 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, z, y); }
        public readonly Vector4U30F2 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, z, z); }
        public readonly Vector4U30F2 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, z, w); }
        public readonly Vector4U30F2 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, w, x); }
        public readonly Vector4U30F2 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, w, y); }
        public readonly Vector4U30F2 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, w, z); }
        public readonly Vector4U30F2 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, z, w, w); }
        public readonly Vector4U30F2 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, x, x); }
        public readonly Vector4U30F2 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, x, y); }
        public readonly Vector4U30F2 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, x, z); }
        public readonly Vector4U30F2 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, x, w); }
        public readonly Vector4U30F2 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, y, x); }
        public readonly Vector4U30F2 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, y, y); }
        public readonly Vector4U30F2 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, y, z); }
        public readonly Vector4U30F2 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, y, w); }
        public readonly Vector4U30F2 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, z, x); }
        public readonly Vector4U30F2 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, z, y); }
        public readonly Vector4U30F2 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, z, z); }
        public readonly Vector4U30F2 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, z, w); }
        public readonly Vector4U30F2 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, w, x); }
        public readonly Vector4U30F2 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, w, y); }
        public readonly Vector4U30F2 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, w, z); }
        public readonly Vector4U30F2 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, w, w, w); }
        public readonly Vector4U30F2 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, x, x); }
        public readonly Vector4U30F2 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, x, y); }
        public readonly Vector4U30F2 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, x, z); }
        public readonly Vector4U30F2 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, x, w); }
        public readonly Vector4U30F2 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, y, x); }
        public readonly Vector4U30F2 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, y, y); }
        public readonly Vector4U30F2 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, y, z); }
        public readonly Vector4U30F2 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, y, w); }
        public readonly Vector4U30F2 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, z, x); }
        public readonly Vector4U30F2 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, z, y); }
        public readonly Vector4U30F2 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, z, z); }
        public readonly Vector4U30F2 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, z, w); }
        public readonly Vector4U30F2 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, w, x); }
        public readonly Vector4U30F2 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, w, y); }
        public readonly Vector4U30F2 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, w, z); }
        public readonly Vector4U30F2 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, x, w, w); }
        public readonly Vector4U30F2 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, x, x); }
        public readonly Vector4U30F2 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, x, y); }
        public readonly Vector4U30F2 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, x, z); }
        public readonly Vector4U30F2 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, x, w); }
        public readonly Vector4U30F2 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, y, x); }
        public readonly Vector4U30F2 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, y, y); }
        public readonly Vector4U30F2 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, y, z); }
        public readonly Vector4U30F2 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, y, w); }
        public readonly Vector4U30F2 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, z, x); }
        public readonly Vector4U30F2 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, z, y); }
        public readonly Vector4U30F2 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, z, z); }
        public readonly Vector4U30F2 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, z, w); }
        public readonly Vector4U30F2 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, w, x); }
        public readonly Vector4U30F2 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, w, y); }
        public readonly Vector4U30F2 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, w, z); }
        public readonly Vector4U30F2 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, y, w, w); }
        public readonly Vector4U30F2 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, x, x); }
        public readonly Vector4U30F2 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, x, y); }
        public readonly Vector4U30F2 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, x, z); }
        public readonly Vector4U30F2 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, x, w); }
        public readonly Vector4U30F2 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, y, x); }
        public readonly Vector4U30F2 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, y, y); }
        public readonly Vector4U30F2 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, y, z); }
        public readonly Vector4U30F2 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, y, w); }
        public readonly Vector4U30F2 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, z, x); }
        public readonly Vector4U30F2 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, z, y); }
        public readonly Vector4U30F2 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, z, z); }
        public readonly Vector4U30F2 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, z, w); }
        public readonly Vector4U30F2 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, w, x); }
        public readonly Vector4U30F2 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, w, y); }
        public readonly Vector4U30F2 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, w, z); }
        public readonly Vector4U30F2 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, z, w, w); }
        public readonly Vector4U30F2 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, x, x); }
        public readonly Vector4U30F2 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, x, y); }
        public readonly Vector4U30F2 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, x, z); }
        public readonly Vector4U30F2 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, x, w); }
        public readonly Vector4U30F2 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, y, x); }
        public readonly Vector4U30F2 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, y, y); }
        public readonly Vector4U30F2 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, y, z); }
        public readonly Vector4U30F2 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, y, w); }
        public readonly Vector4U30F2 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, z, x); }
        public readonly Vector4U30F2 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, z, y); }
        public readonly Vector4U30F2 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, z, z); }
        public readonly Vector4U30F2 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, z, w); }
        public readonly Vector4U30F2 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, w, x); }
        public readonly Vector4U30F2 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, w, y); }
        public readonly Vector4U30F2 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, w, z); }
        public readonly Vector4U30F2 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(z, w, w, w); }
        public readonly Vector4U30F2 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, x, x); }
        public readonly Vector4U30F2 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, x, y); }
        public readonly Vector4U30F2 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, x, z); }
        public readonly Vector4U30F2 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, x, w); }
        public readonly Vector4U30F2 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, y, x); }
        public readonly Vector4U30F2 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, y, y); }
        public readonly Vector4U30F2 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, y, z); }
        public readonly Vector4U30F2 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, y, w); }
        public readonly Vector4U30F2 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, z, x); }
        public readonly Vector4U30F2 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, z, y); }
        public readonly Vector4U30F2 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, z, z); }
        public readonly Vector4U30F2 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, z, w); }
        public readonly Vector4U30F2 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, w, x); }
        public readonly Vector4U30F2 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, w, y); }
        public readonly Vector4U30F2 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, w, z); }
        public readonly Vector4U30F2 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, x, w, w); }
        public readonly Vector4U30F2 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, x, x); }
        public readonly Vector4U30F2 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, x, y); }
        public readonly Vector4U30F2 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, x, z); }
        public readonly Vector4U30F2 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, x, w); }
        public readonly Vector4U30F2 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, y, x); }
        public readonly Vector4U30F2 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, y, y); }
        public readonly Vector4U30F2 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, y, z); }
        public readonly Vector4U30F2 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, y, w); }
        public readonly Vector4U30F2 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, z, x); }
        public readonly Vector4U30F2 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, z, y); }
        public readonly Vector4U30F2 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, z, z); }
        public readonly Vector4U30F2 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, z, w); }
        public readonly Vector4U30F2 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, w, x); }
        public readonly Vector4U30F2 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, w, y); }
        public readonly Vector4U30F2 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, w, z); }
        public readonly Vector4U30F2 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, y, w, w); }
        public readonly Vector4U30F2 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, x, x); }
        public readonly Vector4U30F2 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, x, y); }
        public readonly Vector4U30F2 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, x, z); }
        public readonly Vector4U30F2 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, x, w); }
        public readonly Vector4U30F2 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, y, x); }
        public readonly Vector4U30F2 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, y, y); }
        public readonly Vector4U30F2 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, y, z); }
        public readonly Vector4U30F2 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, y, w); }
        public readonly Vector4U30F2 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, z, x); }
        public readonly Vector4U30F2 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, z, y); }
        public readonly Vector4U30F2 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, z, z); }
        public readonly Vector4U30F2 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, z, w); }
        public readonly Vector4U30F2 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, w, x); }
        public readonly Vector4U30F2 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, w, y); }
        public readonly Vector4U30F2 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, w, z); }
        public readonly Vector4U30F2 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, z, w, w); }
        public readonly Vector4U30F2 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, x, x); }
        public readonly Vector4U30F2 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, x, y); }
        public readonly Vector4U30F2 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, x, z); }
        public readonly Vector4U30F2 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, x, w); }
        public readonly Vector4U30F2 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, y, x); }
        public readonly Vector4U30F2 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, y, y); }
        public readonly Vector4U30F2 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, y, z); }
        public readonly Vector4U30F2 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, y, w); }
        public readonly Vector4U30F2 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, z, x); }
        public readonly Vector4U30F2 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, z, y); }
        public readonly Vector4U30F2 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, z, z); }
        public readonly Vector4U30F2 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, z, w); }
        public readonly Vector4U30F2 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, w, x); }
        public readonly Vector4U30F2 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, w, y); }
        public readonly Vector4U30F2 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, w, z); }
        public readonly Vector4U30F2 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U30F2 lhs, Vector4U30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U30F2 lhs, Vector4U30F2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U30F2({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U30F2 other)
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
            return $"Vector4U30F2({x}, {y}, {z}, {w})";
        }
    }
}
