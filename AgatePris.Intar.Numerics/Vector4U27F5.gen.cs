using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U27F5 : IEquatable<Vector4U27F5>, IFormattable {
        // Fields
        // ---------------------------------------

        public U27F5 x;
        public U27F5 y;
        public U27F5 z;
        public U27F5 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U27F5 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, U27F5 y, U27F5 z, U27F5 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, U27F5 y, Vector2U27F5 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, Vector3U27F5 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector2U27F5 xy, Vector2U27F5 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector4U27F5 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, Vector2U27F5 yz, U27F5 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector3U27F5 xyz, U27F5 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector2U27F5 xy, U27F5 z, U27F5 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator +(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator -(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator *(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator *(Vector4U27F5 a, U27F5 b) => new Vector4U27F5(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator *(U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator /(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator /(Vector4U27F5 a, U27F5 b) => new Vector4U27F5(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator /(U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U27F5 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(x, x); }
        public readonly Vector2U27F5 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(x, y); }
        public readonly Vector2U27F5 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(x, z); }
        public readonly Vector2U27F5 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(x, w); }
        public readonly Vector2U27F5 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(y, x); }
        public readonly Vector2U27F5 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(y, y); }
        public readonly Vector2U27F5 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(y, z); }
        public readonly Vector2U27F5 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(y, w); }
        public readonly Vector2U27F5 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(z, x); }
        public readonly Vector2U27F5 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(z, y); }
        public readonly Vector2U27F5 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(z, z); }
        public readonly Vector2U27F5 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(z, w); }
        public readonly Vector2U27F5 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(w, x); }
        public readonly Vector2U27F5 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(w, y); }
        public readonly Vector2U27F5 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(w, z); }
        public readonly Vector2U27F5 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(w, w); }
        public readonly Vector3U27F5 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, x, x); }
        public readonly Vector3U27F5 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, x, y); }
        public readonly Vector3U27F5 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, x, z); }
        public readonly Vector3U27F5 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, x, w); }
        public readonly Vector3U27F5 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, y, x); }
        public readonly Vector3U27F5 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, y, y); }
        public readonly Vector3U27F5 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, y, z); }
        public readonly Vector3U27F5 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, y, w); }
        public readonly Vector3U27F5 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, z, x); }
        public readonly Vector3U27F5 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, z, y); }
        public readonly Vector3U27F5 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, z, z); }
        public readonly Vector3U27F5 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, z, w); }
        public readonly Vector3U27F5 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, w, x); }
        public readonly Vector3U27F5 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, w, y); }
        public readonly Vector3U27F5 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, w, z); }
        public readonly Vector3U27F5 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, w, w); }
        public readonly Vector3U27F5 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, x, x); }
        public readonly Vector3U27F5 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, x, y); }
        public readonly Vector3U27F5 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, x, z); }
        public readonly Vector3U27F5 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, x, w); }
        public readonly Vector3U27F5 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, y, x); }
        public readonly Vector3U27F5 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, y, y); }
        public readonly Vector3U27F5 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, y, z); }
        public readonly Vector3U27F5 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, y, w); }
        public readonly Vector3U27F5 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, z, x); }
        public readonly Vector3U27F5 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, z, y); }
        public readonly Vector3U27F5 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, z, z); }
        public readonly Vector3U27F5 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, z, w); }
        public readonly Vector3U27F5 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, w, x); }
        public readonly Vector3U27F5 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, w, y); }
        public readonly Vector3U27F5 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, w, z); }
        public readonly Vector3U27F5 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, w, w); }
        public readonly Vector3U27F5 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, x, x); }
        public readonly Vector3U27F5 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, x, y); }
        public readonly Vector3U27F5 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, x, z); }
        public readonly Vector3U27F5 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, x, w); }
        public readonly Vector3U27F5 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, y, x); }
        public readonly Vector3U27F5 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, y, y); }
        public readonly Vector3U27F5 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, y, z); }
        public readonly Vector3U27F5 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, y, w); }
        public readonly Vector3U27F5 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, z, x); }
        public readonly Vector3U27F5 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, z, y); }
        public readonly Vector3U27F5 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, z, z); }
        public readonly Vector3U27F5 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, z, w); }
        public readonly Vector3U27F5 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, w, x); }
        public readonly Vector3U27F5 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, w, y); }
        public readonly Vector3U27F5 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, w, z); }
        public readonly Vector3U27F5 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, w, w); }
        public readonly Vector3U27F5 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, x, x); }
        public readonly Vector3U27F5 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, x, y); }
        public readonly Vector3U27F5 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, x, z); }
        public readonly Vector3U27F5 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, x, w); }
        public readonly Vector3U27F5 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, y, x); }
        public readonly Vector3U27F5 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, y, y); }
        public readonly Vector3U27F5 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, y, z); }
        public readonly Vector3U27F5 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, y, w); }
        public readonly Vector3U27F5 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, z, x); }
        public readonly Vector3U27F5 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, z, y); }
        public readonly Vector3U27F5 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, z, z); }
        public readonly Vector3U27F5 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, z, w); }
        public readonly Vector3U27F5 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, w, x); }
        public readonly Vector3U27F5 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, w, y); }
        public readonly Vector3U27F5 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, w, z); }
        public readonly Vector3U27F5 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(w, w, w); }
        public readonly Vector4U27F5 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, x, x); }
        public readonly Vector4U27F5 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, x, y); }
        public readonly Vector4U27F5 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, x, z); }
        public readonly Vector4U27F5 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, x, w); }
        public readonly Vector4U27F5 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, y, x); }
        public readonly Vector4U27F5 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, y, y); }
        public readonly Vector4U27F5 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, y, z); }
        public readonly Vector4U27F5 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, y, w); }
        public readonly Vector4U27F5 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, z, x); }
        public readonly Vector4U27F5 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, z, y); }
        public readonly Vector4U27F5 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, z, z); }
        public readonly Vector4U27F5 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, z, w); }
        public readonly Vector4U27F5 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, w, x); }
        public readonly Vector4U27F5 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, w, y); }
        public readonly Vector4U27F5 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, w, z); }
        public readonly Vector4U27F5 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, w, w); }
        public readonly Vector4U27F5 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, x, x); }
        public readonly Vector4U27F5 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, x, y); }
        public readonly Vector4U27F5 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, x, z); }
        public readonly Vector4U27F5 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, x, w); }
        public readonly Vector4U27F5 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, y, x); }
        public readonly Vector4U27F5 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, y, y); }
        public readonly Vector4U27F5 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, y, z); }
        public readonly Vector4U27F5 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, y, w); }
        public readonly Vector4U27F5 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, z, x); }
        public readonly Vector4U27F5 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, z, y); }
        public readonly Vector4U27F5 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, z, z); }
        public readonly Vector4U27F5 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, z, w); }
        public readonly Vector4U27F5 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, w, x); }
        public readonly Vector4U27F5 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, w, y); }
        public readonly Vector4U27F5 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, w, z); }
        public readonly Vector4U27F5 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, w, w); }
        public readonly Vector4U27F5 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, x, x); }
        public readonly Vector4U27F5 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, x, y); }
        public readonly Vector4U27F5 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, x, z); }
        public readonly Vector4U27F5 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, x, w); }
        public readonly Vector4U27F5 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, y, x); }
        public readonly Vector4U27F5 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, y, y); }
        public readonly Vector4U27F5 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, y, z); }
        public readonly Vector4U27F5 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, y, w); }
        public readonly Vector4U27F5 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, z, x); }
        public readonly Vector4U27F5 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, z, y); }
        public readonly Vector4U27F5 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, z, z); }
        public readonly Vector4U27F5 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, z, w); }
        public readonly Vector4U27F5 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, w, x); }
        public readonly Vector4U27F5 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, w, y); }
        public readonly Vector4U27F5 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, w, z); }
        public readonly Vector4U27F5 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, w, w); }
        public readonly Vector4U27F5 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, x, x); }
        public readonly Vector4U27F5 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, x, y); }
        public readonly Vector4U27F5 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, x, z); }
        public readonly Vector4U27F5 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, x, w); }
        public readonly Vector4U27F5 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, y, x); }
        public readonly Vector4U27F5 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, y, y); }
        public readonly Vector4U27F5 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, y, z); }
        public readonly Vector4U27F5 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, y, w); }
        public readonly Vector4U27F5 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, z, x); }
        public readonly Vector4U27F5 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, z, y); }
        public readonly Vector4U27F5 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, z, z); }
        public readonly Vector4U27F5 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, z, w); }
        public readonly Vector4U27F5 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, w, x); }
        public readonly Vector4U27F5 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, w, y); }
        public readonly Vector4U27F5 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, w, z); }
        public readonly Vector4U27F5 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, w, w, w); }
        public readonly Vector4U27F5 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, x, x); }
        public readonly Vector4U27F5 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, x, y); }
        public readonly Vector4U27F5 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, x, z); }
        public readonly Vector4U27F5 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, x, w); }
        public readonly Vector4U27F5 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, y, x); }
        public readonly Vector4U27F5 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, y, y); }
        public readonly Vector4U27F5 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, y, z); }
        public readonly Vector4U27F5 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, y, w); }
        public readonly Vector4U27F5 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, z, x); }
        public readonly Vector4U27F5 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, z, y); }
        public readonly Vector4U27F5 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, z, z); }
        public readonly Vector4U27F5 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, z, w); }
        public readonly Vector4U27F5 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, w, x); }
        public readonly Vector4U27F5 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, w, y); }
        public readonly Vector4U27F5 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, w, z); }
        public readonly Vector4U27F5 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, w, w); }
        public readonly Vector4U27F5 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, x, x); }
        public readonly Vector4U27F5 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, x, y); }
        public readonly Vector4U27F5 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, x, z); }
        public readonly Vector4U27F5 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, x, w); }
        public readonly Vector4U27F5 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, y, x); }
        public readonly Vector4U27F5 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, y, y); }
        public readonly Vector4U27F5 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, y, z); }
        public readonly Vector4U27F5 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, y, w); }
        public readonly Vector4U27F5 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, z, x); }
        public readonly Vector4U27F5 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, z, y); }
        public readonly Vector4U27F5 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, z, z); }
        public readonly Vector4U27F5 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, z, w); }
        public readonly Vector4U27F5 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, w, x); }
        public readonly Vector4U27F5 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, w, y); }
        public readonly Vector4U27F5 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, w, z); }
        public readonly Vector4U27F5 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, w, w); }
        public readonly Vector4U27F5 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, x, x); }
        public readonly Vector4U27F5 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, x, y); }
        public readonly Vector4U27F5 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, x, z); }
        public readonly Vector4U27F5 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, x, w); }
        public readonly Vector4U27F5 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, y, x); }
        public readonly Vector4U27F5 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, y, y); }
        public readonly Vector4U27F5 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, y, z); }
        public readonly Vector4U27F5 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, y, w); }
        public readonly Vector4U27F5 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, z, x); }
        public readonly Vector4U27F5 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, z, y); }
        public readonly Vector4U27F5 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, z, z); }
        public readonly Vector4U27F5 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, z, w); }
        public readonly Vector4U27F5 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, w, x); }
        public readonly Vector4U27F5 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, w, y); }
        public readonly Vector4U27F5 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, w, z); }
        public readonly Vector4U27F5 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, w, w); }
        public readonly Vector4U27F5 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, x, x); }
        public readonly Vector4U27F5 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, x, y); }
        public readonly Vector4U27F5 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, x, z); }
        public readonly Vector4U27F5 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, x, w); }
        public readonly Vector4U27F5 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, y, x); }
        public readonly Vector4U27F5 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, y, y); }
        public readonly Vector4U27F5 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, y, z); }
        public readonly Vector4U27F5 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, y, w); }
        public readonly Vector4U27F5 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, z, x); }
        public readonly Vector4U27F5 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, z, y); }
        public readonly Vector4U27F5 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, z, z); }
        public readonly Vector4U27F5 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, z, w); }
        public readonly Vector4U27F5 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, w, x); }
        public readonly Vector4U27F5 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, w, y); }
        public readonly Vector4U27F5 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, w, z); }
        public readonly Vector4U27F5 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, w, w, w); }
        public readonly Vector4U27F5 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, x, x); }
        public readonly Vector4U27F5 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, x, y); }
        public readonly Vector4U27F5 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, x, z); }
        public readonly Vector4U27F5 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, x, w); }
        public readonly Vector4U27F5 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, y, x); }
        public readonly Vector4U27F5 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, y, y); }
        public readonly Vector4U27F5 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, y, z); }
        public readonly Vector4U27F5 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, y, w); }
        public readonly Vector4U27F5 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, z, x); }
        public readonly Vector4U27F5 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, z, y); }
        public readonly Vector4U27F5 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, z, z); }
        public readonly Vector4U27F5 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, z, w); }
        public readonly Vector4U27F5 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, w, x); }
        public readonly Vector4U27F5 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, w, y); }
        public readonly Vector4U27F5 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, w, z); }
        public readonly Vector4U27F5 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, w, w); }
        public readonly Vector4U27F5 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, x, x); }
        public readonly Vector4U27F5 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, x, y); }
        public readonly Vector4U27F5 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, x, z); }
        public readonly Vector4U27F5 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, x, w); }
        public readonly Vector4U27F5 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, y, x); }
        public readonly Vector4U27F5 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, y, y); }
        public readonly Vector4U27F5 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, y, z); }
        public readonly Vector4U27F5 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, y, w); }
        public readonly Vector4U27F5 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, z, x); }
        public readonly Vector4U27F5 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, z, y); }
        public readonly Vector4U27F5 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, z, z); }
        public readonly Vector4U27F5 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, z, w); }
        public readonly Vector4U27F5 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, w, x); }
        public readonly Vector4U27F5 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, w, y); }
        public readonly Vector4U27F5 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, w, z); }
        public readonly Vector4U27F5 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, w, w); }
        public readonly Vector4U27F5 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, x, x); }
        public readonly Vector4U27F5 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, x, y); }
        public readonly Vector4U27F5 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, x, z); }
        public readonly Vector4U27F5 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, x, w); }
        public readonly Vector4U27F5 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, y, x); }
        public readonly Vector4U27F5 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, y, y); }
        public readonly Vector4U27F5 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, y, z); }
        public readonly Vector4U27F5 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, y, w); }
        public readonly Vector4U27F5 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, z, x); }
        public readonly Vector4U27F5 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, z, y); }
        public readonly Vector4U27F5 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, z, z); }
        public readonly Vector4U27F5 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, z, w); }
        public readonly Vector4U27F5 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, w, x); }
        public readonly Vector4U27F5 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, w, y); }
        public readonly Vector4U27F5 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, w, z); }
        public readonly Vector4U27F5 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, w, w); }
        public readonly Vector4U27F5 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, x, x); }
        public readonly Vector4U27F5 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, x, y); }
        public readonly Vector4U27F5 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, x, z); }
        public readonly Vector4U27F5 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, x, w); }
        public readonly Vector4U27F5 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, y, x); }
        public readonly Vector4U27F5 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, y, y); }
        public readonly Vector4U27F5 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, y, z); }
        public readonly Vector4U27F5 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, y, w); }
        public readonly Vector4U27F5 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, z, x); }
        public readonly Vector4U27F5 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, z, y); }
        public readonly Vector4U27F5 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, z, z); }
        public readonly Vector4U27F5 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, z, w); }
        public readonly Vector4U27F5 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, w, x); }
        public readonly Vector4U27F5 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, w, y); }
        public readonly Vector4U27F5 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, w, z); }
        public readonly Vector4U27F5 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, w, w, w); }
        public readonly Vector4U27F5 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, x, x); }
        public readonly Vector4U27F5 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, x, y); }
        public readonly Vector4U27F5 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, x, z); }
        public readonly Vector4U27F5 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, x, w); }
        public readonly Vector4U27F5 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, y, x); }
        public readonly Vector4U27F5 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, y, y); }
        public readonly Vector4U27F5 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, y, z); }
        public readonly Vector4U27F5 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, y, w); }
        public readonly Vector4U27F5 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, z, x); }
        public readonly Vector4U27F5 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, z, y); }
        public readonly Vector4U27F5 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, z, z); }
        public readonly Vector4U27F5 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, z, w); }
        public readonly Vector4U27F5 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, w, x); }
        public readonly Vector4U27F5 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, w, y); }
        public readonly Vector4U27F5 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, w, z); }
        public readonly Vector4U27F5 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, x, w, w); }
        public readonly Vector4U27F5 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, x, x); }
        public readonly Vector4U27F5 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, x, y); }
        public readonly Vector4U27F5 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, x, z); }
        public readonly Vector4U27F5 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, x, w); }
        public readonly Vector4U27F5 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, y, x); }
        public readonly Vector4U27F5 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, y, y); }
        public readonly Vector4U27F5 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, y, z); }
        public readonly Vector4U27F5 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, y, w); }
        public readonly Vector4U27F5 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, z, x); }
        public readonly Vector4U27F5 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, z, y); }
        public readonly Vector4U27F5 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, z, z); }
        public readonly Vector4U27F5 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, z, w); }
        public readonly Vector4U27F5 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, w, x); }
        public readonly Vector4U27F5 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, w, y); }
        public readonly Vector4U27F5 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, w, z); }
        public readonly Vector4U27F5 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, y, w, w); }
        public readonly Vector4U27F5 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, x, x); }
        public readonly Vector4U27F5 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, x, y); }
        public readonly Vector4U27F5 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, x, z); }
        public readonly Vector4U27F5 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, x, w); }
        public readonly Vector4U27F5 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, y, x); }
        public readonly Vector4U27F5 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, y, y); }
        public readonly Vector4U27F5 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, y, z); }
        public readonly Vector4U27F5 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, y, w); }
        public readonly Vector4U27F5 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, z, x); }
        public readonly Vector4U27F5 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, z, y); }
        public readonly Vector4U27F5 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, z, z); }
        public readonly Vector4U27F5 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, z, w); }
        public readonly Vector4U27F5 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, w, x); }
        public readonly Vector4U27F5 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, w, y); }
        public readonly Vector4U27F5 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, w, z); }
        public readonly Vector4U27F5 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, z, w, w); }
        public readonly Vector4U27F5 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, x, x); }
        public readonly Vector4U27F5 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, x, y); }
        public readonly Vector4U27F5 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, x, z); }
        public readonly Vector4U27F5 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, x, w); }
        public readonly Vector4U27F5 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, y, x); }
        public readonly Vector4U27F5 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, y, y); }
        public readonly Vector4U27F5 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, y, z); }
        public readonly Vector4U27F5 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, y, w); }
        public readonly Vector4U27F5 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, z, x); }
        public readonly Vector4U27F5 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, z, y); }
        public readonly Vector4U27F5 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, z, z); }
        public readonly Vector4U27F5 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, z, w); }
        public readonly Vector4U27F5 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, w, x); }
        public readonly Vector4U27F5 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, w, y); }
        public readonly Vector4U27F5 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, w, z); }
        public readonly Vector4U27F5 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U27F5 lhs, Vector4U27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U27F5 lhs, Vector4U27F5 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U27F5({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U27F5 other)
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
            return $"Vector4U27F5({x}, {y}, {z}, {w})";
        }
    }
}
