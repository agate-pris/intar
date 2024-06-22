using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U18F14 : IEquatable<Vector4U18F14>, IFormattable {
        // Fields
        // ---------------------------------------

        public U18F14 x;
        public U18F14 y;
        public U18F14 z;
        public U18F14 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4U18F14 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(U18F14 x, U18F14 y, U18F14 z, U18F14 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(U18F14 x, U18F14 y, Vector2U18F14 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(U18F14 x, Vector3U18F14 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(Vector2U18F14 xy, Vector2U18F14 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(Vector4U18F14 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(U18F14 x, Vector2U18F14 yz, U18F14 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(Vector3U18F14 xyz, U18F14 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(Vector2U18F14 xy, U18F14 z, U18F14 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator +(Vector4U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator -(Vector4U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator *(Vector4U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator *(Vector4U18F14 a, U18F14 b) => new Vector4U18F14(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator *(U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator /(Vector4U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator /(Vector4U18F14 a, U18F14 b) => new Vector4U18F14(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator /(U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U18F14 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(x, x); }
        public readonly Vector2U18F14 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(x, y); }
        public readonly Vector2U18F14 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(x, z); }
        public readonly Vector2U18F14 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(x, w); }
        public readonly Vector2U18F14 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(y, x); }
        public readonly Vector2U18F14 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(y, y); }
        public readonly Vector2U18F14 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(y, z); }
        public readonly Vector2U18F14 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(y, w); }
        public readonly Vector2U18F14 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(z, x); }
        public readonly Vector2U18F14 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(z, y); }
        public readonly Vector2U18F14 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(z, z); }
        public readonly Vector2U18F14 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(z, w); }
        public readonly Vector2U18F14 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(w, x); }
        public readonly Vector2U18F14 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(w, y); }
        public readonly Vector2U18F14 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(w, z); }
        public readonly Vector2U18F14 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(w, w); }
        public readonly Vector3U18F14 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, x, x); }
        public readonly Vector3U18F14 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, x, y); }
        public readonly Vector3U18F14 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, x, z); }
        public readonly Vector3U18F14 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, x, w); }
        public readonly Vector3U18F14 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, y, x); }
        public readonly Vector3U18F14 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, y, y); }
        public readonly Vector3U18F14 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, y, z); }
        public readonly Vector3U18F14 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, y, w); }
        public readonly Vector3U18F14 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, z, x); }
        public readonly Vector3U18F14 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, z, y); }
        public readonly Vector3U18F14 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, z, z); }
        public readonly Vector3U18F14 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, z, w); }
        public readonly Vector3U18F14 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, w, x); }
        public readonly Vector3U18F14 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, w, y); }
        public readonly Vector3U18F14 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, w, z); }
        public readonly Vector3U18F14 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, w, w); }
        public readonly Vector3U18F14 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, x, x); }
        public readonly Vector3U18F14 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, x, y); }
        public readonly Vector3U18F14 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, x, z); }
        public readonly Vector3U18F14 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, x, w); }
        public readonly Vector3U18F14 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, y, x); }
        public readonly Vector3U18F14 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, y, y); }
        public readonly Vector3U18F14 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, y, z); }
        public readonly Vector3U18F14 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, y, w); }
        public readonly Vector3U18F14 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, z, x); }
        public readonly Vector3U18F14 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, z, y); }
        public readonly Vector3U18F14 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, z, z); }
        public readonly Vector3U18F14 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, z, w); }
        public readonly Vector3U18F14 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, w, x); }
        public readonly Vector3U18F14 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, w, y); }
        public readonly Vector3U18F14 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, w, z); }
        public readonly Vector3U18F14 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, w, w); }
        public readonly Vector3U18F14 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, x, x); }
        public readonly Vector3U18F14 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, x, y); }
        public readonly Vector3U18F14 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, x, z); }
        public readonly Vector3U18F14 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, x, w); }
        public readonly Vector3U18F14 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, y, x); }
        public readonly Vector3U18F14 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, y, y); }
        public readonly Vector3U18F14 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, y, z); }
        public readonly Vector3U18F14 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, y, w); }
        public readonly Vector3U18F14 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, z, x); }
        public readonly Vector3U18F14 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, z, y); }
        public readonly Vector3U18F14 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, z, z); }
        public readonly Vector3U18F14 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, z, w); }
        public readonly Vector3U18F14 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, w, x); }
        public readonly Vector3U18F14 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, w, y); }
        public readonly Vector3U18F14 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, w, z); }
        public readonly Vector3U18F14 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, w, w); }
        public readonly Vector3U18F14 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, x, x); }
        public readonly Vector3U18F14 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, x, y); }
        public readonly Vector3U18F14 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, x, z); }
        public readonly Vector3U18F14 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, x, w); }
        public readonly Vector3U18F14 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, y, x); }
        public readonly Vector3U18F14 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, y, y); }
        public readonly Vector3U18F14 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, y, z); }
        public readonly Vector3U18F14 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, y, w); }
        public readonly Vector3U18F14 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, z, x); }
        public readonly Vector3U18F14 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, z, y); }
        public readonly Vector3U18F14 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, z, z); }
        public readonly Vector3U18F14 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, z, w); }
        public readonly Vector3U18F14 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, w, x); }
        public readonly Vector3U18F14 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, w, y); }
        public readonly Vector3U18F14 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, w, z); }
        public readonly Vector3U18F14 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(w, w, w); }
        public readonly Vector4U18F14 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, x, x); }
        public readonly Vector4U18F14 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, x, y); }
        public readonly Vector4U18F14 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, x, z); }
        public readonly Vector4U18F14 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, x, w); }
        public readonly Vector4U18F14 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, y, x); }
        public readonly Vector4U18F14 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, y, y); }
        public readonly Vector4U18F14 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, y, z); }
        public readonly Vector4U18F14 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, y, w); }
        public readonly Vector4U18F14 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, z, x); }
        public readonly Vector4U18F14 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, z, y); }
        public readonly Vector4U18F14 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, z, z); }
        public readonly Vector4U18F14 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, z, w); }
        public readonly Vector4U18F14 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, w, x); }
        public readonly Vector4U18F14 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, w, y); }
        public readonly Vector4U18F14 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, w, z); }
        public readonly Vector4U18F14 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, w, w); }
        public readonly Vector4U18F14 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, x, x); }
        public readonly Vector4U18F14 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, x, y); }
        public readonly Vector4U18F14 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, x, z); }
        public readonly Vector4U18F14 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, x, w); }
        public readonly Vector4U18F14 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, y, x); }
        public readonly Vector4U18F14 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, y, y); }
        public readonly Vector4U18F14 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, y, z); }
        public readonly Vector4U18F14 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, y, w); }
        public readonly Vector4U18F14 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, z, x); }
        public readonly Vector4U18F14 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, z, y); }
        public readonly Vector4U18F14 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, z, z); }
        public readonly Vector4U18F14 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, z, w); }
        public readonly Vector4U18F14 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, w, x); }
        public readonly Vector4U18F14 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, w, y); }
        public readonly Vector4U18F14 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, w, z); }
        public readonly Vector4U18F14 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, w, w); }
        public readonly Vector4U18F14 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, x, x); }
        public readonly Vector4U18F14 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, x, y); }
        public readonly Vector4U18F14 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, x, z); }
        public readonly Vector4U18F14 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, x, w); }
        public readonly Vector4U18F14 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, y, x); }
        public readonly Vector4U18F14 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, y, y); }
        public readonly Vector4U18F14 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, y, z); }
        public readonly Vector4U18F14 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, y, w); }
        public readonly Vector4U18F14 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, z, x); }
        public readonly Vector4U18F14 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, z, y); }
        public readonly Vector4U18F14 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, z, z); }
        public readonly Vector4U18F14 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, z, w); }
        public readonly Vector4U18F14 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, w, x); }
        public readonly Vector4U18F14 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, w, y); }
        public readonly Vector4U18F14 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, w, z); }
        public readonly Vector4U18F14 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, w, w); }
        public readonly Vector4U18F14 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, x, x); }
        public readonly Vector4U18F14 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, x, y); }
        public readonly Vector4U18F14 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, x, z); }
        public readonly Vector4U18F14 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, x, w); }
        public readonly Vector4U18F14 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, y, x); }
        public readonly Vector4U18F14 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, y, y); }
        public readonly Vector4U18F14 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, y, z); }
        public readonly Vector4U18F14 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, y, w); }
        public readonly Vector4U18F14 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, z, x); }
        public readonly Vector4U18F14 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, z, y); }
        public readonly Vector4U18F14 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, z, z); }
        public readonly Vector4U18F14 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, z, w); }
        public readonly Vector4U18F14 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, w, x); }
        public readonly Vector4U18F14 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, w, y); }
        public readonly Vector4U18F14 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, w, z); }
        public readonly Vector4U18F14 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, w, w, w); }
        public readonly Vector4U18F14 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, x, x); }
        public readonly Vector4U18F14 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, x, y); }
        public readonly Vector4U18F14 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, x, z); }
        public readonly Vector4U18F14 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, x, w); }
        public readonly Vector4U18F14 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, y, x); }
        public readonly Vector4U18F14 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, y, y); }
        public readonly Vector4U18F14 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, y, z); }
        public readonly Vector4U18F14 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, y, w); }
        public readonly Vector4U18F14 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, z, x); }
        public readonly Vector4U18F14 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, z, y); }
        public readonly Vector4U18F14 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, z, z); }
        public readonly Vector4U18F14 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, z, w); }
        public readonly Vector4U18F14 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, w, x); }
        public readonly Vector4U18F14 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, w, y); }
        public readonly Vector4U18F14 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, w, z); }
        public readonly Vector4U18F14 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, w, w); }
        public readonly Vector4U18F14 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, x, x); }
        public readonly Vector4U18F14 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, x, y); }
        public readonly Vector4U18F14 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, x, z); }
        public readonly Vector4U18F14 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, x, w); }
        public readonly Vector4U18F14 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, y, x); }
        public readonly Vector4U18F14 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, y, y); }
        public readonly Vector4U18F14 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, y, z); }
        public readonly Vector4U18F14 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, y, w); }
        public readonly Vector4U18F14 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, z, x); }
        public readonly Vector4U18F14 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, z, y); }
        public readonly Vector4U18F14 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, z, z); }
        public readonly Vector4U18F14 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, z, w); }
        public readonly Vector4U18F14 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, w, x); }
        public readonly Vector4U18F14 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, w, y); }
        public readonly Vector4U18F14 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, w, z); }
        public readonly Vector4U18F14 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, w, w); }
        public readonly Vector4U18F14 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, x, x); }
        public readonly Vector4U18F14 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, x, y); }
        public readonly Vector4U18F14 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, x, z); }
        public readonly Vector4U18F14 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, x, w); }
        public readonly Vector4U18F14 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, y, x); }
        public readonly Vector4U18F14 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, y, y); }
        public readonly Vector4U18F14 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, y, z); }
        public readonly Vector4U18F14 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, y, w); }
        public readonly Vector4U18F14 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, z, x); }
        public readonly Vector4U18F14 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, z, y); }
        public readonly Vector4U18F14 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, z, z); }
        public readonly Vector4U18F14 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, z, w); }
        public readonly Vector4U18F14 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, w, x); }
        public readonly Vector4U18F14 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, w, y); }
        public readonly Vector4U18F14 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, w, z); }
        public readonly Vector4U18F14 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, w, w); }
        public readonly Vector4U18F14 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, x, x); }
        public readonly Vector4U18F14 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, x, y); }
        public readonly Vector4U18F14 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, x, z); }
        public readonly Vector4U18F14 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, x, w); }
        public readonly Vector4U18F14 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, y, x); }
        public readonly Vector4U18F14 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, y, y); }
        public readonly Vector4U18F14 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, y, z); }
        public readonly Vector4U18F14 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, y, w); }
        public readonly Vector4U18F14 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, z, x); }
        public readonly Vector4U18F14 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, z, y); }
        public readonly Vector4U18F14 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, z, z); }
        public readonly Vector4U18F14 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, z, w); }
        public readonly Vector4U18F14 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, w, x); }
        public readonly Vector4U18F14 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, w, y); }
        public readonly Vector4U18F14 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, w, z); }
        public readonly Vector4U18F14 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, w, w, w); }
        public readonly Vector4U18F14 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, x, x); }
        public readonly Vector4U18F14 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, x, y); }
        public readonly Vector4U18F14 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, x, z); }
        public readonly Vector4U18F14 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, x, w); }
        public readonly Vector4U18F14 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, y, x); }
        public readonly Vector4U18F14 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, y, y); }
        public readonly Vector4U18F14 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, y, z); }
        public readonly Vector4U18F14 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, y, w); }
        public readonly Vector4U18F14 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, z, x); }
        public readonly Vector4U18F14 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, z, y); }
        public readonly Vector4U18F14 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, z, z); }
        public readonly Vector4U18F14 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, z, w); }
        public readonly Vector4U18F14 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, w, x); }
        public readonly Vector4U18F14 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, w, y); }
        public readonly Vector4U18F14 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, w, z); }
        public readonly Vector4U18F14 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, w, w); }
        public readonly Vector4U18F14 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, x, x); }
        public readonly Vector4U18F14 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, x, y); }
        public readonly Vector4U18F14 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, x, z); }
        public readonly Vector4U18F14 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, x, w); }
        public readonly Vector4U18F14 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, y, x); }
        public readonly Vector4U18F14 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, y, y); }
        public readonly Vector4U18F14 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, y, z); }
        public readonly Vector4U18F14 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, y, w); }
        public readonly Vector4U18F14 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, z, x); }
        public readonly Vector4U18F14 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, z, y); }
        public readonly Vector4U18F14 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, z, z); }
        public readonly Vector4U18F14 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, z, w); }
        public readonly Vector4U18F14 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, w, x); }
        public readonly Vector4U18F14 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, w, y); }
        public readonly Vector4U18F14 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, w, z); }
        public readonly Vector4U18F14 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, w, w); }
        public readonly Vector4U18F14 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, x, x); }
        public readonly Vector4U18F14 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, x, y); }
        public readonly Vector4U18F14 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, x, z); }
        public readonly Vector4U18F14 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, x, w); }
        public readonly Vector4U18F14 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, y, x); }
        public readonly Vector4U18F14 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, y, y); }
        public readonly Vector4U18F14 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, y, z); }
        public readonly Vector4U18F14 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, y, w); }
        public readonly Vector4U18F14 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, z, x); }
        public readonly Vector4U18F14 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, z, y); }
        public readonly Vector4U18F14 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, z, z); }
        public readonly Vector4U18F14 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, z, w); }
        public readonly Vector4U18F14 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, w, x); }
        public readonly Vector4U18F14 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, w, y); }
        public readonly Vector4U18F14 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, w, z); }
        public readonly Vector4U18F14 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, w, w); }
        public readonly Vector4U18F14 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, x, x); }
        public readonly Vector4U18F14 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, x, y); }
        public readonly Vector4U18F14 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, x, z); }
        public readonly Vector4U18F14 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, x, w); }
        public readonly Vector4U18F14 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, y, x); }
        public readonly Vector4U18F14 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, y, y); }
        public readonly Vector4U18F14 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, y, z); }
        public readonly Vector4U18F14 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, y, w); }
        public readonly Vector4U18F14 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, z, x); }
        public readonly Vector4U18F14 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, z, y); }
        public readonly Vector4U18F14 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, z, z); }
        public readonly Vector4U18F14 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, z, w); }
        public readonly Vector4U18F14 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, w, x); }
        public readonly Vector4U18F14 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, w, y); }
        public readonly Vector4U18F14 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, w, z); }
        public readonly Vector4U18F14 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, w, w, w); }
        public readonly Vector4U18F14 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, x, x); }
        public readonly Vector4U18F14 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, x, y); }
        public readonly Vector4U18F14 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, x, z); }
        public readonly Vector4U18F14 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, x, w); }
        public readonly Vector4U18F14 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, y, x); }
        public readonly Vector4U18F14 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, y, y); }
        public readonly Vector4U18F14 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, y, z); }
        public readonly Vector4U18F14 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, y, w); }
        public readonly Vector4U18F14 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, z, x); }
        public readonly Vector4U18F14 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, z, y); }
        public readonly Vector4U18F14 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, z, z); }
        public readonly Vector4U18F14 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, z, w); }
        public readonly Vector4U18F14 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, w, x); }
        public readonly Vector4U18F14 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, w, y); }
        public readonly Vector4U18F14 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, w, z); }
        public readonly Vector4U18F14 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, x, w, w); }
        public readonly Vector4U18F14 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, x, x); }
        public readonly Vector4U18F14 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, x, y); }
        public readonly Vector4U18F14 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, x, z); }
        public readonly Vector4U18F14 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, x, w); }
        public readonly Vector4U18F14 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, y, x); }
        public readonly Vector4U18F14 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, y, y); }
        public readonly Vector4U18F14 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, y, z); }
        public readonly Vector4U18F14 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, y, w); }
        public readonly Vector4U18F14 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, z, x); }
        public readonly Vector4U18F14 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, z, y); }
        public readonly Vector4U18F14 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, z, z); }
        public readonly Vector4U18F14 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, z, w); }
        public readonly Vector4U18F14 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, w, x); }
        public readonly Vector4U18F14 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, w, y); }
        public readonly Vector4U18F14 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, w, z); }
        public readonly Vector4U18F14 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, y, w, w); }
        public readonly Vector4U18F14 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, x, x); }
        public readonly Vector4U18F14 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, x, y); }
        public readonly Vector4U18F14 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, x, z); }
        public readonly Vector4U18F14 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, x, w); }
        public readonly Vector4U18F14 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, y, x); }
        public readonly Vector4U18F14 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, y, y); }
        public readonly Vector4U18F14 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, y, z); }
        public readonly Vector4U18F14 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, y, w); }
        public readonly Vector4U18F14 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, z, x); }
        public readonly Vector4U18F14 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, z, y); }
        public readonly Vector4U18F14 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, z, z); }
        public readonly Vector4U18F14 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, z, w); }
        public readonly Vector4U18F14 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, w, x); }
        public readonly Vector4U18F14 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, w, y); }
        public readonly Vector4U18F14 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, w, z); }
        public readonly Vector4U18F14 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, z, w, w); }
        public readonly Vector4U18F14 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, x, x); }
        public readonly Vector4U18F14 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, x, y); }
        public readonly Vector4U18F14 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, x, z); }
        public readonly Vector4U18F14 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, x, w); }
        public readonly Vector4U18F14 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, y, x); }
        public readonly Vector4U18F14 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, y, y); }
        public readonly Vector4U18F14 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, y, z); }
        public readonly Vector4U18F14 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, y, w); }
        public readonly Vector4U18F14 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, z, x); }
        public readonly Vector4U18F14 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, z, y); }
        public readonly Vector4U18F14 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, z, z); }
        public readonly Vector4U18F14 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, z, w); }
        public readonly Vector4U18F14 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, w, x); }
        public readonly Vector4U18F14 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, w, y); }
        public readonly Vector4U18F14 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, w, z); }
        public readonly Vector4U18F14 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U18F14 lhs, Vector4U18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U18F14 lhs, Vector4U18F14 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U18F14({x}, {y}, {z}, {w})";

        // IEquatable<Vector4U18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U18F14 other)
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
            return $"Vector4U18F14({x}, {y}, {z}, {w})";
        }
    }
}
