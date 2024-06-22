using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U23F9 : IEquatable<Vector4U23F9>, IFormattable {
        // Fields
        // ---------------------------------------

        public U23F9 x;
        public U23F9 y;
        public U23F9 z;
        public U23F9 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U23F9 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(U23F9 x, U23F9 y, U23F9 z, U23F9 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(U23F9 x, U23F9 y, Vector2U23F9 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(U23F9 x, Vector3U23F9 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(Vector2U23F9 xy, Vector2U23F9 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(Vector4U23F9 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(U23F9 x, Vector2U23F9 yz, U23F9 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(Vector3U23F9 xyz, U23F9 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(Vector2U23F9 xy, U23F9 z, U23F9 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator +(Vector4U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator -(Vector4U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator *(Vector4U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator *(Vector4U23F9 a, U23F9 b) => new Vector4U23F9(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator *(U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator /(Vector4U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator /(Vector4U23F9 a, U23F9 b) => new Vector4U23F9(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator /(U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U23F9 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(x, x); }
        public readonly Vector2U23F9 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(x, y); }
        public readonly Vector2U23F9 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(x, z); }
        public readonly Vector2U23F9 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(x, w); }
        public readonly Vector2U23F9 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(y, x); }
        public readonly Vector2U23F9 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(y, y); }
        public readonly Vector2U23F9 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(y, z); }
        public readonly Vector2U23F9 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(y, w); }
        public readonly Vector2U23F9 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(z, x); }
        public readonly Vector2U23F9 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(z, y); }
        public readonly Vector2U23F9 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(z, z); }
        public readonly Vector2U23F9 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(z, w); }
        public readonly Vector2U23F9 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(w, x); }
        public readonly Vector2U23F9 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(w, y); }
        public readonly Vector2U23F9 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(w, z); }
        public readonly Vector2U23F9 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(w, w); }
        public readonly Vector3U23F9 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, x, x); }
        public readonly Vector3U23F9 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, x, y); }
        public readonly Vector3U23F9 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, x, z); }
        public readonly Vector3U23F9 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, x, w); }
        public readonly Vector3U23F9 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, y, x); }
        public readonly Vector3U23F9 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, y, y); }
        public readonly Vector3U23F9 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, y, z); }
        public readonly Vector3U23F9 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, y, w); }
        public readonly Vector3U23F9 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, z, x); }
        public readonly Vector3U23F9 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, z, y); }
        public readonly Vector3U23F9 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, z, z); }
        public readonly Vector3U23F9 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, z, w); }
        public readonly Vector3U23F9 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, w, x); }
        public readonly Vector3U23F9 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, w, y); }
        public readonly Vector3U23F9 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, w, z); }
        public readonly Vector3U23F9 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, w, w); }
        public readonly Vector3U23F9 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, x, x); }
        public readonly Vector3U23F9 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, x, y); }
        public readonly Vector3U23F9 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, x, z); }
        public readonly Vector3U23F9 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, x, w); }
        public readonly Vector3U23F9 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, y, x); }
        public readonly Vector3U23F9 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, y, y); }
        public readonly Vector3U23F9 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, y, z); }
        public readonly Vector3U23F9 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, y, w); }
        public readonly Vector3U23F9 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, z, x); }
        public readonly Vector3U23F9 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, z, y); }
        public readonly Vector3U23F9 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, z, z); }
        public readonly Vector3U23F9 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, z, w); }
        public readonly Vector3U23F9 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, w, x); }
        public readonly Vector3U23F9 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, w, y); }
        public readonly Vector3U23F9 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, w, z); }
        public readonly Vector3U23F9 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, w, w); }
        public readonly Vector3U23F9 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, x, x); }
        public readonly Vector3U23F9 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, x, y); }
        public readonly Vector3U23F9 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, x, z); }
        public readonly Vector3U23F9 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, x, w); }
        public readonly Vector3U23F9 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, y, x); }
        public readonly Vector3U23F9 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, y, y); }
        public readonly Vector3U23F9 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, y, z); }
        public readonly Vector3U23F9 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, y, w); }
        public readonly Vector3U23F9 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, z, x); }
        public readonly Vector3U23F9 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, z, y); }
        public readonly Vector3U23F9 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, z, z); }
        public readonly Vector3U23F9 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, z, w); }
        public readonly Vector3U23F9 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, w, x); }
        public readonly Vector3U23F9 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, w, y); }
        public readonly Vector3U23F9 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, w, z); }
        public readonly Vector3U23F9 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, w, w); }
        public readonly Vector3U23F9 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, x, x); }
        public readonly Vector3U23F9 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, x, y); }
        public readonly Vector3U23F9 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, x, z); }
        public readonly Vector3U23F9 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, x, w); }
        public readonly Vector3U23F9 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, y, x); }
        public readonly Vector3U23F9 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, y, y); }
        public readonly Vector3U23F9 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, y, z); }
        public readonly Vector3U23F9 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, y, w); }
        public readonly Vector3U23F9 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, z, x); }
        public readonly Vector3U23F9 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, z, y); }
        public readonly Vector3U23F9 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, z, z); }
        public readonly Vector3U23F9 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, z, w); }
        public readonly Vector3U23F9 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, w, x); }
        public readonly Vector3U23F9 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, w, y); }
        public readonly Vector3U23F9 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, w, z); }
        public readonly Vector3U23F9 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(w, w, w); }
        public readonly Vector4U23F9 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, x, x); }
        public readonly Vector4U23F9 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, x, y); }
        public readonly Vector4U23F9 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, x, z); }
        public readonly Vector4U23F9 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, x, w); }
        public readonly Vector4U23F9 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, y, x); }
        public readonly Vector4U23F9 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, y, y); }
        public readonly Vector4U23F9 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, y, z); }
        public readonly Vector4U23F9 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, y, w); }
        public readonly Vector4U23F9 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, z, x); }
        public readonly Vector4U23F9 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, z, y); }
        public readonly Vector4U23F9 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, z, z); }
        public readonly Vector4U23F9 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, z, w); }
        public readonly Vector4U23F9 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, w, x); }
        public readonly Vector4U23F9 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, w, y); }
        public readonly Vector4U23F9 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, w, z); }
        public readonly Vector4U23F9 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, w, w); }
        public readonly Vector4U23F9 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, x, x); }
        public readonly Vector4U23F9 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, x, y); }
        public readonly Vector4U23F9 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, x, z); }
        public readonly Vector4U23F9 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, x, w); }
        public readonly Vector4U23F9 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, y, x); }
        public readonly Vector4U23F9 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, y, y); }
        public readonly Vector4U23F9 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, y, z); }
        public readonly Vector4U23F9 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, y, w); }
        public readonly Vector4U23F9 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, z, x); }
        public readonly Vector4U23F9 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, z, y); }
        public readonly Vector4U23F9 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, z, z); }
        public readonly Vector4U23F9 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, z, w); }
        public readonly Vector4U23F9 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, w, x); }
        public readonly Vector4U23F9 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, w, y); }
        public readonly Vector4U23F9 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, w, z); }
        public readonly Vector4U23F9 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, w, w); }
        public readonly Vector4U23F9 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, x, x); }
        public readonly Vector4U23F9 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, x, y); }
        public readonly Vector4U23F9 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, x, z); }
        public readonly Vector4U23F9 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, x, w); }
        public readonly Vector4U23F9 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, y, x); }
        public readonly Vector4U23F9 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, y, y); }
        public readonly Vector4U23F9 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, y, z); }
        public readonly Vector4U23F9 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, y, w); }
        public readonly Vector4U23F9 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, z, x); }
        public readonly Vector4U23F9 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, z, y); }
        public readonly Vector4U23F9 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, z, z); }
        public readonly Vector4U23F9 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, z, w); }
        public readonly Vector4U23F9 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, w, x); }
        public readonly Vector4U23F9 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, w, y); }
        public readonly Vector4U23F9 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, w, z); }
        public readonly Vector4U23F9 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, w, w); }
        public readonly Vector4U23F9 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, x, x); }
        public readonly Vector4U23F9 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, x, y); }
        public readonly Vector4U23F9 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, x, z); }
        public readonly Vector4U23F9 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, x, w); }
        public readonly Vector4U23F9 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, y, x); }
        public readonly Vector4U23F9 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, y, y); }
        public readonly Vector4U23F9 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, y, z); }
        public readonly Vector4U23F9 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, y, w); }
        public readonly Vector4U23F9 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, z, x); }
        public readonly Vector4U23F9 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, z, y); }
        public readonly Vector4U23F9 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, z, z); }
        public readonly Vector4U23F9 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, z, w); }
        public readonly Vector4U23F9 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, w, x); }
        public readonly Vector4U23F9 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, w, y); }
        public readonly Vector4U23F9 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, w, z); }
        public readonly Vector4U23F9 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, w, w, w); }
        public readonly Vector4U23F9 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, x, x); }
        public readonly Vector4U23F9 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, x, y); }
        public readonly Vector4U23F9 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, x, z); }
        public readonly Vector4U23F9 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, x, w); }
        public readonly Vector4U23F9 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, y, x); }
        public readonly Vector4U23F9 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, y, y); }
        public readonly Vector4U23F9 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, y, z); }
        public readonly Vector4U23F9 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, y, w); }
        public readonly Vector4U23F9 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, z, x); }
        public readonly Vector4U23F9 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, z, y); }
        public readonly Vector4U23F9 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, z, z); }
        public readonly Vector4U23F9 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, z, w); }
        public readonly Vector4U23F9 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, w, x); }
        public readonly Vector4U23F9 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, w, y); }
        public readonly Vector4U23F9 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, w, z); }
        public readonly Vector4U23F9 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, w, w); }
        public readonly Vector4U23F9 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, x, x); }
        public readonly Vector4U23F9 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, x, y); }
        public readonly Vector4U23F9 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, x, z); }
        public readonly Vector4U23F9 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, x, w); }
        public readonly Vector4U23F9 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, y, x); }
        public readonly Vector4U23F9 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, y, y); }
        public readonly Vector4U23F9 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, y, z); }
        public readonly Vector4U23F9 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, y, w); }
        public readonly Vector4U23F9 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, z, x); }
        public readonly Vector4U23F9 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, z, y); }
        public readonly Vector4U23F9 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, z, z); }
        public readonly Vector4U23F9 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, z, w); }
        public readonly Vector4U23F9 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, w, x); }
        public readonly Vector4U23F9 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, w, y); }
        public readonly Vector4U23F9 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, w, z); }
        public readonly Vector4U23F9 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, w, w); }
        public readonly Vector4U23F9 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, x, x); }
        public readonly Vector4U23F9 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, x, y); }
        public readonly Vector4U23F9 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, x, z); }
        public readonly Vector4U23F9 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, x, w); }
        public readonly Vector4U23F9 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, y, x); }
        public readonly Vector4U23F9 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, y, y); }
        public readonly Vector4U23F9 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, y, z); }
        public readonly Vector4U23F9 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, y, w); }
        public readonly Vector4U23F9 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, z, x); }
        public readonly Vector4U23F9 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, z, y); }
        public readonly Vector4U23F9 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, z, z); }
        public readonly Vector4U23F9 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, z, w); }
        public readonly Vector4U23F9 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, w, x); }
        public readonly Vector4U23F9 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, w, y); }
        public readonly Vector4U23F9 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, w, z); }
        public readonly Vector4U23F9 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, w, w); }
        public readonly Vector4U23F9 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, x, x); }
        public readonly Vector4U23F9 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, x, y); }
        public readonly Vector4U23F9 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, x, z); }
        public readonly Vector4U23F9 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, x, w); }
        public readonly Vector4U23F9 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, y, x); }
        public readonly Vector4U23F9 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, y, y); }
        public readonly Vector4U23F9 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, y, z); }
        public readonly Vector4U23F9 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, y, w); }
        public readonly Vector4U23F9 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, z, x); }
        public readonly Vector4U23F9 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, z, y); }
        public readonly Vector4U23F9 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, z, z); }
        public readonly Vector4U23F9 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, z, w); }
        public readonly Vector4U23F9 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, w, x); }
        public readonly Vector4U23F9 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, w, y); }
        public readonly Vector4U23F9 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, w, z); }
        public readonly Vector4U23F9 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, w, w, w); }
        public readonly Vector4U23F9 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, x, x); }
        public readonly Vector4U23F9 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, x, y); }
        public readonly Vector4U23F9 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, x, z); }
        public readonly Vector4U23F9 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, x, w); }
        public readonly Vector4U23F9 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, y, x); }
        public readonly Vector4U23F9 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, y, y); }
        public readonly Vector4U23F9 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, y, z); }
        public readonly Vector4U23F9 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, y, w); }
        public readonly Vector4U23F9 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, z, x); }
        public readonly Vector4U23F9 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, z, y); }
        public readonly Vector4U23F9 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, z, z); }
        public readonly Vector4U23F9 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, z, w); }
        public readonly Vector4U23F9 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, w, x); }
        public readonly Vector4U23F9 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, w, y); }
        public readonly Vector4U23F9 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, w, z); }
        public readonly Vector4U23F9 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, w, w); }
        public readonly Vector4U23F9 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, x, x); }
        public readonly Vector4U23F9 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, x, y); }
        public readonly Vector4U23F9 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, x, z); }
        public readonly Vector4U23F9 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, x, w); }
        public readonly Vector4U23F9 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, y, x); }
        public readonly Vector4U23F9 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, y, y); }
        public readonly Vector4U23F9 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, y, z); }
        public readonly Vector4U23F9 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, y, w); }
        public readonly Vector4U23F9 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, z, x); }
        public readonly Vector4U23F9 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, z, y); }
        public readonly Vector4U23F9 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, z, z); }
        public readonly Vector4U23F9 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, z, w); }
        public readonly Vector4U23F9 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, w, x); }
        public readonly Vector4U23F9 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, w, y); }
        public readonly Vector4U23F9 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, w, z); }
        public readonly Vector4U23F9 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, w, w); }
        public readonly Vector4U23F9 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, x, x); }
        public readonly Vector4U23F9 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, x, y); }
        public readonly Vector4U23F9 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, x, z); }
        public readonly Vector4U23F9 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, x, w); }
        public readonly Vector4U23F9 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, y, x); }
        public readonly Vector4U23F9 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, y, y); }
        public readonly Vector4U23F9 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, y, z); }
        public readonly Vector4U23F9 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, y, w); }
        public readonly Vector4U23F9 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, z, x); }
        public readonly Vector4U23F9 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, z, y); }
        public readonly Vector4U23F9 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, z, z); }
        public readonly Vector4U23F9 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, z, w); }
        public readonly Vector4U23F9 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, w, x); }
        public readonly Vector4U23F9 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, w, y); }
        public readonly Vector4U23F9 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, w, z); }
        public readonly Vector4U23F9 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, w, w); }
        public readonly Vector4U23F9 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, x, x); }
        public readonly Vector4U23F9 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, x, y); }
        public readonly Vector4U23F9 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, x, z); }
        public readonly Vector4U23F9 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, x, w); }
        public readonly Vector4U23F9 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, y, x); }
        public readonly Vector4U23F9 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, y, y); }
        public readonly Vector4U23F9 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, y, z); }
        public readonly Vector4U23F9 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, y, w); }
        public readonly Vector4U23F9 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, z, x); }
        public readonly Vector4U23F9 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, z, y); }
        public readonly Vector4U23F9 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, z, z); }
        public readonly Vector4U23F9 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, z, w); }
        public readonly Vector4U23F9 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, w, x); }
        public readonly Vector4U23F9 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, w, y); }
        public readonly Vector4U23F9 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, w, z); }
        public readonly Vector4U23F9 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, w, w, w); }
        public readonly Vector4U23F9 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, x, x); }
        public readonly Vector4U23F9 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, x, y); }
        public readonly Vector4U23F9 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, x, z); }
        public readonly Vector4U23F9 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, x, w); }
        public readonly Vector4U23F9 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, y, x); }
        public readonly Vector4U23F9 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, y, y); }
        public readonly Vector4U23F9 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, y, z); }
        public readonly Vector4U23F9 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, y, w); }
        public readonly Vector4U23F9 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, z, x); }
        public readonly Vector4U23F9 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, z, y); }
        public readonly Vector4U23F9 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, z, z); }
        public readonly Vector4U23F9 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, z, w); }
        public readonly Vector4U23F9 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, w, x); }
        public readonly Vector4U23F9 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, w, y); }
        public readonly Vector4U23F9 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, w, z); }
        public readonly Vector4U23F9 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, x, w, w); }
        public readonly Vector4U23F9 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, x, x); }
        public readonly Vector4U23F9 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, x, y); }
        public readonly Vector4U23F9 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, x, z); }
        public readonly Vector4U23F9 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, x, w); }
        public readonly Vector4U23F9 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, y, x); }
        public readonly Vector4U23F9 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, y, y); }
        public readonly Vector4U23F9 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, y, z); }
        public readonly Vector4U23F9 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, y, w); }
        public readonly Vector4U23F9 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, z, x); }
        public readonly Vector4U23F9 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, z, y); }
        public readonly Vector4U23F9 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, z, z); }
        public readonly Vector4U23F9 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, z, w); }
        public readonly Vector4U23F9 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, w, x); }
        public readonly Vector4U23F9 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, w, y); }
        public readonly Vector4U23F9 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, w, z); }
        public readonly Vector4U23F9 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, y, w, w); }
        public readonly Vector4U23F9 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, x, x); }
        public readonly Vector4U23F9 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, x, y); }
        public readonly Vector4U23F9 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, x, z); }
        public readonly Vector4U23F9 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, x, w); }
        public readonly Vector4U23F9 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, y, x); }
        public readonly Vector4U23F9 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, y, y); }
        public readonly Vector4U23F9 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, y, z); }
        public readonly Vector4U23F9 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, y, w); }
        public readonly Vector4U23F9 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, z, x); }
        public readonly Vector4U23F9 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, z, y); }
        public readonly Vector4U23F9 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, z, z); }
        public readonly Vector4U23F9 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, z, w); }
        public readonly Vector4U23F9 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, w, x); }
        public readonly Vector4U23F9 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, w, y); }
        public readonly Vector4U23F9 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, w, z); }
        public readonly Vector4U23F9 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, z, w, w); }
        public readonly Vector4U23F9 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, x, x); }
        public readonly Vector4U23F9 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, x, y); }
        public readonly Vector4U23F9 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, x, z); }
        public readonly Vector4U23F9 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, x, w); }
        public readonly Vector4U23F9 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, y, x); }
        public readonly Vector4U23F9 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, y, y); }
        public readonly Vector4U23F9 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, y, z); }
        public readonly Vector4U23F9 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, y, w); }
        public readonly Vector4U23F9 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, z, x); }
        public readonly Vector4U23F9 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, z, y); }
        public readonly Vector4U23F9 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, z, z); }
        public readonly Vector4U23F9 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, z, w); }
        public readonly Vector4U23F9 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, w, x); }
        public readonly Vector4U23F9 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, w, y); }
        public readonly Vector4U23F9 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, w, z); }
        public readonly Vector4U23F9 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U23F9 lhs, Vector4U23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U23F9 lhs, Vector4U23F9 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U23F9({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U23F9 other)
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
            return $"Vector4U23F9({x}, {y}, {z}, {w})";
        }
    }
}
