using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U2F30 : IEquatable<Vector4U2F30>, IFormattable {
        // Fields
        // ---------------------------------------

        public U2F30 x;
        public U2F30 y;
        public U2F30 z;
        public U2F30 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U2F30 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, U2F30 y, U2F30 z, U2F30 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, U2F30 y, Vector2U2F30 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, Vector3U2F30 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector2U2F30 xy, Vector2U2F30 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector4U2F30 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, Vector2U2F30 yz, U2F30 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector3U2F30 xyz, U2F30 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector2U2F30 xy, U2F30 z, U2F30 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator +(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator -(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator *(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator *(Vector4U2F30 a, U2F30 b) => new Vector4U2F30(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator *(U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator /(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator /(Vector4U2F30 a, U2F30 b) => new Vector4U2F30(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator /(U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U2F30 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(x, x); }
        public readonly Vector2U2F30 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(x, y); }
        public readonly Vector2U2F30 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(x, z); }
        public readonly Vector2U2F30 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(x, w); }
        public readonly Vector2U2F30 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(y, x); }
        public readonly Vector2U2F30 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(y, y); }
        public readonly Vector2U2F30 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(y, z); }
        public readonly Vector2U2F30 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(y, w); }
        public readonly Vector2U2F30 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(z, x); }
        public readonly Vector2U2F30 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(z, y); }
        public readonly Vector2U2F30 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(z, z); }
        public readonly Vector2U2F30 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(z, w); }
        public readonly Vector2U2F30 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(w, x); }
        public readonly Vector2U2F30 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(w, y); }
        public readonly Vector2U2F30 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(w, z); }
        public readonly Vector2U2F30 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(w, w); }
        public readonly Vector3U2F30 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, x, x); }
        public readonly Vector3U2F30 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, x, y); }
        public readonly Vector3U2F30 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, x, z); }
        public readonly Vector3U2F30 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, x, w); }
        public readonly Vector3U2F30 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, y, x); }
        public readonly Vector3U2F30 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, y, y); }
        public readonly Vector3U2F30 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, y, z); }
        public readonly Vector3U2F30 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, y, w); }
        public readonly Vector3U2F30 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, z, x); }
        public readonly Vector3U2F30 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, z, y); }
        public readonly Vector3U2F30 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, z, z); }
        public readonly Vector3U2F30 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, z, w); }
        public readonly Vector3U2F30 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, w, x); }
        public readonly Vector3U2F30 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, w, y); }
        public readonly Vector3U2F30 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, w, z); }
        public readonly Vector3U2F30 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(x, w, w); }
        public readonly Vector3U2F30 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, x, x); }
        public readonly Vector3U2F30 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, x, y); }
        public readonly Vector3U2F30 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, x, z); }
        public readonly Vector3U2F30 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, x, w); }
        public readonly Vector3U2F30 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, y, x); }
        public readonly Vector3U2F30 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, y, y); }
        public readonly Vector3U2F30 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, y, z); }
        public readonly Vector3U2F30 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, y, w); }
        public readonly Vector3U2F30 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, z, x); }
        public readonly Vector3U2F30 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, z, y); }
        public readonly Vector3U2F30 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, z, z); }
        public readonly Vector3U2F30 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, z, w); }
        public readonly Vector3U2F30 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, w, x); }
        public readonly Vector3U2F30 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, w, y); }
        public readonly Vector3U2F30 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, w, z); }
        public readonly Vector3U2F30 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(y, w, w); }
        public readonly Vector3U2F30 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, x, x); }
        public readonly Vector3U2F30 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, x, y); }
        public readonly Vector3U2F30 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, x, z); }
        public readonly Vector3U2F30 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, x, w); }
        public readonly Vector3U2F30 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, y, x); }
        public readonly Vector3U2F30 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, y, y); }
        public readonly Vector3U2F30 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, y, z); }
        public readonly Vector3U2F30 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, y, w); }
        public readonly Vector3U2F30 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, z, x); }
        public readonly Vector3U2F30 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, z, y); }
        public readonly Vector3U2F30 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, z, z); }
        public readonly Vector3U2F30 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, z, w); }
        public readonly Vector3U2F30 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, w, x); }
        public readonly Vector3U2F30 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, w, y); }
        public readonly Vector3U2F30 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, w, z); }
        public readonly Vector3U2F30 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(z, w, w); }
        public readonly Vector3U2F30 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, x, x); }
        public readonly Vector3U2F30 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, x, y); }
        public readonly Vector3U2F30 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, x, z); }
        public readonly Vector3U2F30 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, x, w); }
        public readonly Vector3U2F30 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, y, x); }
        public readonly Vector3U2F30 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, y, y); }
        public readonly Vector3U2F30 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, y, z); }
        public readonly Vector3U2F30 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, y, w); }
        public readonly Vector3U2F30 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, z, x); }
        public readonly Vector3U2F30 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, z, y); }
        public readonly Vector3U2F30 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, z, z); }
        public readonly Vector3U2F30 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, z, w); }
        public readonly Vector3U2F30 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, w, x); }
        public readonly Vector3U2F30 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, w, y); }
        public readonly Vector3U2F30 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, w, z); }
        public readonly Vector3U2F30 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(w, w, w); }
        public readonly Vector4U2F30 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, x, x); }
        public readonly Vector4U2F30 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, x, y); }
        public readonly Vector4U2F30 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, x, z); }
        public readonly Vector4U2F30 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, x, w); }
        public readonly Vector4U2F30 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, y, x); }
        public readonly Vector4U2F30 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, y, y); }
        public readonly Vector4U2F30 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, y, z); }
        public readonly Vector4U2F30 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, y, w); }
        public readonly Vector4U2F30 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, z, x); }
        public readonly Vector4U2F30 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, z, y); }
        public readonly Vector4U2F30 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, z, z); }
        public readonly Vector4U2F30 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, z, w); }
        public readonly Vector4U2F30 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, w, x); }
        public readonly Vector4U2F30 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, w, y); }
        public readonly Vector4U2F30 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, w, z); }
        public readonly Vector4U2F30 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, x, w, w); }
        public readonly Vector4U2F30 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, x, x); }
        public readonly Vector4U2F30 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, x, y); }
        public readonly Vector4U2F30 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, x, z); }
        public readonly Vector4U2F30 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, x, w); }
        public readonly Vector4U2F30 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, y, x); }
        public readonly Vector4U2F30 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, y, y); }
        public readonly Vector4U2F30 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, y, z); }
        public readonly Vector4U2F30 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, y, w); }
        public readonly Vector4U2F30 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, z, x); }
        public readonly Vector4U2F30 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, z, y); }
        public readonly Vector4U2F30 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, z, z); }
        public readonly Vector4U2F30 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, z, w); }
        public readonly Vector4U2F30 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, w, x); }
        public readonly Vector4U2F30 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, w, y); }
        public readonly Vector4U2F30 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, w, z); }
        public readonly Vector4U2F30 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, y, w, w); }
        public readonly Vector4U2F30 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, x, x); }
        public readonly Vector4U2F30 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, x, y); }
        public readonly Vector4U2F30 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, x, z); }
        public readonly Vector4U2F30 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, x, w); }
        public readonly Vector4U2F30 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, y, x); }
        public readonly Vector4U2F30 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, y, y); }
        public readonly Vector4U2F30 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, y, z); }
        public readonly Vector4U2F30 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, y, w); }
        public readonly Vector4U2F30 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, z, x); }
        public readonly Vector4U2F30 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, z, y); }
        public readonly Vector4U2F30 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, z, z); }
        public readonly Vector4U2F30 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, z, w); }
        public readonly Vector4U2F30 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, w, x); }
        public readonly Vector4U2F30 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, w, y); }
        public readonly Vector4U2F30 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, w, z); }
        public readonly Vector4U2F30 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, z, w, w); }
        public readonly Vector4U2F30 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, x, x); }
        public readonly Vector4U2F30 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, x, y); }
        public readonly Vector4U2F30 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, x, z); }
        public readonly Vector4U2F30 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, x, w); }
        public readonly Vector4U2F30 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, y, x); }
        public readonly Vector4U2F30 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, y, y); }
        public readonly Vector4U2F30 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, y, z); }
        public readonly Vector4U2F30 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, y, w); }
        public readonly Vector4U2F30 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, z, x); }
        public readonly Vector4U2F30 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, z, y); }
        public readonly Vector4U2F30 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, z, z); }
        public readonly Vector4U2F30 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, z, w); }
        public readonly Vector4U2F30 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, w, x); }
        public readonly Vector4U2F30 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, w, y); }
        public readonly Vector4U2F30 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, w, z); }
        public readonly Vector4U2F30 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(x, w, w, w); }
        public readonly Vector4U2F30 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, x, x); }
        public readonly Vector4U2F30 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, x, y); }
        public readonly Vector4U2F30 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, x, z); }
        public readonly Vector4U2F30 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, x, w); }
        public readonly Vector4U2F30 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, y, x); }
        public readonly Vector4U2F30 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, y, y); }
        public readonly Vector4U2F30 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, y, z); }
        public readonly Vector4U2F30 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, y, w); }
        public readonly Vector4U2F30 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, z, x); }
        public readonly Vector4U2F30 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, z, y); }
        public readonly Vector4U2F30 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, z, z); }
        public readonly Vector4U2F30 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, z, w); }
        public readonly Vector4U2F30 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, w, x); }
        public readonly Vector4U2F30 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, w, y); }
        public readonly Vector4U2F30 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, w, z); }
        public readonly Vector4U2F30 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, x, w, w); }
        public readonly Vector4U2F30 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, x, x); }
        public readonly Vector4U2F30 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, x, y); }
        public readonly Vector4U2F30 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, x, z); }
        public readonly Vector4U2F30 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, x, w); }
        public readonly Vector4U2F30 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, y, x); }
        public readonly Vector4U2F30 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, y, y); }
        public readonly Vector4U2F30 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, y, z); }
        public readonly Vector4U2F30 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, y, w); }
        public readonly Vector4U2F30 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, z, x); }
        public readonly Vector4U2F30 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, z, y); }
        public readonly Vector4U2F30 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, z, z); }
        public readonly Vector4U2F30 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, z, w); }
        public readonly Vector4U2F30 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, w, x); }
        public readonly Vector4U2F30 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, w, y); }
        public readonly Vector4U2F30 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, w, z); }
        public readonly Vector4U2F30 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, y, w, w); }
        public readonly Vector4U2F30 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, x, x); }
        public readonly Vector4U2F30 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, x, y); }
        public readonly Vector4U2F30 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, x, z); }
        public readonly Vector4U2F30 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, x, w); }
        public readonly Vector4U2F30 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, y, x); }
        public readonly Vector4U2F30 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, y, y); }
        public readonly Vector4U2F30 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, y, z); }
        public readonly Vector4U2F30 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, y, w); }
        public readonly Vector4U2F30 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, z, x); }
        public readonly Vector4U2F30 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, z, y); }
        public readonly Vector4U2F30 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, z, z); }
        public readonly Vector4U2F30 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, z, w); }
        public readonly Vector4U2F30 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, w, x); }
        public readonly Vector4U2F30 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, w, y); }
        public readonly Vector4U2F30 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, w, z); }
        public readonly Vector4U2F30 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, z, w, w); }
        public readonly Vector4U2F30 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, x, x); }
        public readonly Vector4U2F30 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, x, y); }
        public readonly Vector4U2F30 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, x, z); }
        public readonly Vector4U2F30 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, x, w); }
        public readonly Vector4U2F30 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, y, x); }
        public readonly Vector4U2F30 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, y, y); }
        public readonly Vector4U2F30 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, y, z); }
        public readonly Vector4U2F30 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, y, w); }
        public readonly Vector4U2F30 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, z, x); }
        public readonly Vector4U2F30 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, z, y); }
        public readonly Vector4U2F30 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, z, z); }
        public readonly Vector4U2F30 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, z, w); }
        public readonly Vector4U2F30 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, w, x); }
        public readonly Vector4U2F30 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, w, y); }
        public readonly Vector4U2F30 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, w, z); }
        public readonly Vector4U2F30 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(y, w, w, w); }
        public readonly Vector4U2F30 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, x, x); }
        public readonly Vector4U2F30 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, x, y); }
        public readonly Vector4U2F30 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, x, z); }
        public readonly Vector4U2F30 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, x, w); }
        public readonly Vector4U2F30 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, y, x); }
        public readonly Vector4U2F30 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, y, y); }
        public readonly Vector4U2F30 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, y, z); }
        public readonly Vector4U2F30 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, y, w); }
        public readonly Vector4U2F30 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, z, x); }
        public readonly Vector4U2F30 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, z, y); }
        public readonly Vector4U2F30 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, z, z); }
        public readonly Vector4U2F30 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, z, w); }
        public readonly Vector4U2F30 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, w, x); }
        public readonly Vector4U2F30 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, w, y); }
        public readonly Vector4U2F30 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, w, z); }
        public readonly Vector4U2F30 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, x, w, w); }
        public readonly Vector4U2F30 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, x, x); }
        public readonly Vector4U2F30 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, x, y); }
        public readonly Vector4U2F30 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, x, z); }
        public readonly Vector4U2F30 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, x, w); }
        public readonly Vector4U2F30 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, y, x); }
        public readonly Vector4U2F30 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, y, y); }
        public readonly Vector4U2F30 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, y, z); }
        public readonly Vector4U2F30 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, y, w); }
        public readonly Vector4U2F30 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, z, x); }
        public readonly Vector4U2F30 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, z, y); }
        public readonly Vector4U2F30 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, z, z); }
        public readonly Vector4U2F30 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, z, w); }
        public readonly Vector4U2F30 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, w, x); }
        public readonly Vector4U2F30 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, w, y); }
        public readonly Vector4U2F30 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, w, z); }
        public readonly Vector4U2F30 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, y, w, w); }
        public readonly Vector4U2F30 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, x, x); }
        public readonly Vector4U2F30 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, x, y); }
        public readonly Vector4U2F30 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, x, z); }
        public readonly Vector4U2F30 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, x, w); }
        public readonly Vector4U2F30 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, y, x); }
        public readonly Vector4U2F30 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, y, y); }
        public readonly Vector4U2F30 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, y, z); }
        public readonly Vector4U2F30 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, y, w); }
        public readonly Vector4U2F30 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, z, x); }
        public readonly Vector4U2F30 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, z, y); }
        public readonly Vector4U2F30 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, z, z); }
        public readonly Vector4U2F30 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, z, w); }
        public readonly Vector4U2F30 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, w, x); }
        public readonly Vector4U2F30 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, w, y); }
        public readonly Vector4U2F30 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, w, z); }
        public readonly Vector4U2F30 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, z, w, w); }
        public readonly Vector4U2F30 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, x, x); }
        public readonly Vector4U2F30 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, x, y); }
        public readonly Vector4U2F30 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, x, z); }
        public readonly Vector4U2F30 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, x, w); }
        public readonly Vector4U2F30 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, y, x); }
        public readonly Vector4U2F30 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, y, y); }
        public readonly Vector4U2F30 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, y, z); }
        public readonly Vector4U2F30 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, y, w); }
        public readonly Vector4U2F30 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, z, x); }
        public readonly Vector4U2F30 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, z, y); }
        public readonly Vector4U2F30 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, z, z); }
        public readonly Vector4U2F30 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, z, w); }
        public readonly Vector4U2F30 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, w, x); }
        public readonly Vector4U2F30 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, w, y); }
        public readonly Vector4U2F30 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, w, z); }
        public readonly Vector4U2F30 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(z, w, w, w); }
        public readonly Vector4U2F30 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, x, x); }
        public readonly Vector4U2F30 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, x, y); }
        public readonly Vector4U2F30 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, x, z); }
        public readonly Vector4U2F30 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, x, w); }
        public readonly Vector4U2F30 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, y, x); }
        public readonly Vector4U2F30 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, y, y); }
        public readonly Vector4U2F30 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, y, z); }
        public readonly Vector4U2F30 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, y, w); }
        public readonly Vector4U2F30 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, z, x); }
        public readonly Vector4U2F30 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, z, y); }
        public readonly Vector4U2F30 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, z, z); }
        public readonly Vector4U2F30 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, z, w); }
        public readonly Vector4U2F30 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, w, x); }
        public readonly Vector4U2F30 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, w, y); }
        public readonly Vector4U2F30 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, w, z); }
        public readonly Vector4U2F30 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, x, w, w); }
        public readonly Vector4U2F30 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, x, x); }
        public readonly Vector4U2F30 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, x, y); }
        public readonly Vector4U2F30 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, x, z); }
        public readonly Vector4U2F30 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, x, w); }
        public readonly Vector4U2F30 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, y, x); }
        public readonly Vector4U2F30 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, y, y); }
        public readonly Vector4U2F30 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, y, z); }
        public readonly Vector4U2F30 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, y, w); }
        public readonly Vector4U2F30 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, z, x); }
        public readonly Vector4U2F30 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, z, y); }
        public readonly Vector4U2F30 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, z, z); }
        public readonly Vector4U2F30 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, z, w); }
        public readonly Vector4U2F30 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, w, x); }
        public readonly Vector4U2F30 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, w, y); }
        public readonly Vector4U2F30 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, w, z); }
        public readonly Vector4U2F30 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, y, w, w); }
        public readonly Vector4U2F30 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, x, x); }
        public readonly Vector4U2F30 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, x, y); }
        public readonly Vector4U2F30 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, x, z); }
        public readonly Vector4U2F30 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, x, w); }
        public readonly Vector4U2F30 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, y, x); }
        public readonly Vector4U2F30 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, y, y); }
        public readonly Vector4U2F30 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, y, z); }
        public readonly Vector4U2F30 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, y, w); }
        public readonly Vector4U2F30 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, z, x); }
        public readonly Vector4U2F30 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, z, y); }
        public readonly Vector4U2F30 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, z, z); }
        public readonly Vector4U2F30 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, z, w); }
        public readonly Vector4U2F30 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, w, x); }
        public readonly Vector4U2F30 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, w, y); }
        public readonly Vector4U2F30 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, w, z); }
        public readonly Vector4U2F30 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, z, w, w); }
        public readonly Vector4U2F30 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, x, x); }
        public readonly Vector4U2F30 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, x, y); }
        public readonly Vector4U2F30 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, x, z); }
        public readonly Vector4U2F30 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, x, w); }
        public readonly Vector4U2F30 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, y, x); }
        public readonly Vector4U2F30 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, y, y); }
        public readonly Vector4U2F30 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, y, z); }
        public readonly Vector4U2F30 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, y, w); }
        public readonly Vector4U2F30 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, z, x); }
        public readonly Vector4U2F30 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, z, y); }
        public readonly Vector4U2F30 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, z, z); }
        public readonly Vector4U2F30 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, z, w); }
        public readonly Vector4U2F30 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, w, x); }
        public readonly Vector4U2F30 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, w, y); }
        public readonly Vector4U2F30 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, w, z); }
        public readonly Vector4U2F30 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U2F30 lhs, Vector4U2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U2F30 lhs, Vector4U2F30 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U2F30({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U2F30 other)
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
            return $"Vector4U2F30({x}, {y}, {z}, {w})";
        }
    }
}
