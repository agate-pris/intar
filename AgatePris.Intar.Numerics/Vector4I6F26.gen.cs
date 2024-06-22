using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I6F26 : IEquatable<Vector4I6F26>, IFormattable {
        // Fields
        // ---------------------------------------

        public I6F26 x;
        public I6F26 y;
        public I6F26 z;
        public I6F26 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I6F26 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, I6F26 y, I6F26 z, I6F26 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, I6F26 y, Vector2I6F26 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, Vector3I6F26 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector2I6F26 xy, Vector2I6F26 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector4I6F26 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, Vector2I6F26 yz, I6F26 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector3I6F26 xyz, I6F26 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector2I6F26 xy, I6F26 z, I6F26 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator +(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator -(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator *(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator *(Vector4I6F26 a, I6F26 b) => new Vector4I6F26(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator *(I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator /(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator /(Vector4I6F26 a, I6F26 b) => new Vector4I6F26(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator /(I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I6F26 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(x, x); }
        public readonly Vector2I6F26 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(x, y); }
        public readonly Vector2I6F26 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(x, z); }
        public readonly Vector2I6F26 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(x, w); }
        public readonly Vector2I6F26 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(y, x); }
        public readonly Vector2I6F26 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(y, y); }
        public readonly Vector2I6F26 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(y, z); }
        public readonly Vector2I6F26 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(y, w); }
        public readonly Vector2I6F26 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(z, x); }
        public readonly Vector2I6F26 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(z, y); }
        public readonly Vector2I6F26 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(z, z); }
        public readonly Vector2I6F26 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(z, w); }
        public readonly Vector2I6F26 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(w, x); }
        public readonly Vector2I6F26 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(w, y); }
        public readonly Vector2I6F26 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(w, z); }
        public readonly Vector2I6F26 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(w, w); }
        public readonly Vector3I6F26 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, x, x); }
        public readonly Vector3I6F26 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, x, y); }
        public readonly Vector3I6F26 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, x, z); }
        public readonly Vector3I6F26 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, x, w); }
        public readonly Vector3I6F26 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, y, x); }
        public readonly Vector3I6F26 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, y, y); }
        public readonly Vector3I6F26 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, y, z); }
        public readonly Vector3I6F26 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, y, w); }
        public readonly Vector3I6F26 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, z, x); }
        public readonly Vector3I6F26 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, z, y); }
        public readonly Vector3I6F26 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, z, z); }
        public readonly Vector3I6F26 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, z, w); }
        public readonly Vector3I6F26 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, w, x); }
        public readonly Vector3I6F26 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, w, y); }
        public readonly Vector3I6F26 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, w, z); }
        public readonly Vector3I6F26 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, w, w); }
        public readonly Vector3I6F26 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, x, x); }
        public readonly Vector3I6F26 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, x, y); }
        public readonly Vector3I6F26 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, x, z); }
        public readonly Vector3I6F26 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, x, w); }
        public readonly Vector3I6F26 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, y, x); }
        public readonly Vector3I6F26 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, y, y); }
        public readonly Vector3I6F26 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, y, z); }
        public readonly Vector3I6F26 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, y, w); }
        public readonly Vector3I6F26 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, z, x); }
        public readonly Vector3I6F26 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, z, y); }
        public readonly Vector3I6F26 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, z, z); }
        public readonly Vector3I6F26 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, z, w); }
        public readonly Vector3I6F26 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, w, x); }
        public readonly Vector3I6F26 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, w, y); }
        public readonly Vector3I6F26 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, w, z); }
        public readonly Vector3I6F26 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, w, w); }
        public readonly Vector3I6F26 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, x, x); }
        public readonly Vector3I6F26 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, x, y); }
        public readonly Vector3I6F26 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, x, z); }
        public readonly Vector3I6F26 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, x, w); }
        public readonly Vector3I6F26 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, y, x); }
        public readonly Vector3I6F26 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, y, y); }
        public readonly Vector3I6F26 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, y, z); }
        public readonly Vector3I6F26 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, y, w); }
        public readonly Vector3I6F26 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, z, x); }
        public readonly Vector3I6F26 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, z, y); }
        public readonly Vector3I6F26 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, z, z); }
        public readonly Vector3I6F26 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, z, w); }
        public readonly Vector3I6F26 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, w, x); }
        public readonly Vector3I6F26 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, w, y); }
        public readonly Vector3I6F26 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, w, z); }
        public readonly Vector3I6F26 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(z, w, w); }
        public readonly Vector3I6F26 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, x, x); }
        public readonly Vector3I6F26 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, x, y); }
        public readonly Vector3I6F26 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, x, z); }
        public readonly Vector3I6F26 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, x, w); }
        public readonly Vector3I6F26 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, y, x); }
        public readonly Vector3I6F26 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, y, y); }
        public readonly Vector3I6F26 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, y, z); }
        public readonly Vector3I6F26 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, y, w); }
        public readonly Vector3I6F26 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, z, x); }
        public readonly Vector3I6F26 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, z, y); }
        public readonly Vector3I6F26 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, z, z); }
        public readonly Vector3I6F26 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, z, w); }
        public readonly Vector3I6F26 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, w, x); }
        public readonly Vector3I6F26 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, w, y); }
        public readonly Vector3I6F26 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, w, z); }
        public readonly Vector3I6F26 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(w, w, w); }
        public readonly Vector4I6F26 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, x, x); }
        public readonly Vector4I6F26 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, x, y); }
        public readonly Vector4I6F26 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, x, z); }
        public readonly Vector4I6F26 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, x, w); }
        public readonly Vector4I6F26 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, y, x); }
        public readonly Vector4I6F26 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, y, y); }
        public readonly Vector4I6F26 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, y, z); }
        public readonly Vector4I6F26 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, y, w); }
        public readonly Vector4I6F26 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, z, x); }
        public readonly Vector4I6F26 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, z, y); }
        public readonly Vector4I6F26 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, z, z); }
        public readonly Vector4I6F26 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, z, w); }
        public readonly Vector4I6F26 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, w, x); }
        public readonly Vector4I6F26 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, w, y); }
        public readonly Vector4I6F26 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, w, z); }
        public readonly Vector4I6F26 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, w, w); }
        public readonly Vector4I6F26 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, x, x); }
        public readonly Vector4I6F26 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, x, y); }
        public readonly Vector4I6F26 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, x, z); }
        public readonly Vector4I6F26 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, x, w); }
        public readonly Vector4I6F26 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, y, x); }
        public readonly Vector4I6F26 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, y, y); }
        public readonly Vector4I6F26 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, y, z); }
        public readonly Vector4I6F26 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, y, w); }
        public readonly Vector4I6F26 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, z, x); }
        public readonly Vector4I6F26 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, z, y); }
        public readonly Vector4I6F26 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, z, z); }
        public readonly Vector4I6F26 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, z, w); }
        public readonly Vector4I6F26 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, w, x); }
        public readonly Vector4I6F26 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, w, y); }
        public readonly Vector4I6F26 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, w, z); }
        public readonly Vector4I6F26 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, w, w); }
        public readonly Vector4I6F26 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, x, x); }
        public readonly Vector4I6F26 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, x, y); }
        public readonly Vector4I6F26 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, x, z); }
        public readonly Vector4I6F26 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, x, w); }
        public readonly Vector4I6F26 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, y, x); }
        public readonly Vector4I6F26 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, y, y); }
        public readonly Vector4I6F26 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, y, z); }
        public readonly Vector4I6F26 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, y, w); }
        public readonly Vector4I6F26 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, z, x); }
        public readonly Vector4I6F26 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, z, y); }
        public readonly Vector4I6F26 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, z, z); }
        public readonly Vector4I6F26 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, z, w); }
        public readonly Vector4I6F26 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, w, x); }
        public readonly Vector4I6F26 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, w, y); }
        public readonly Vector4I6F26 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, w, z); }
        public readonly Vector4I6F26 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, z, w, w); }
        public readonly Vector4I6F26 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, x, x); }
        public readonly Vector4I6F26 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, x, y); }
        public readonly Vector4I6F26 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, x, z); }
        public readonly Vector4I6F26 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, x, w); }
        public readonly Vector4I6F26 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, y, x); }
        public readonly Vector4I6F26 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, y, y); }
        public readonly Vector4I6F26 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, y, z); }
        public readonly Vector4I6F26 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, y, w); }
        public readonly Vector4I6F26 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, z, x); }
        public readonly Vector4I6F26 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, z, y); }
        public readonly Vector4I6F26 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, z, z); }
        public readonly Vector4I6F26 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, z, w); }
        public readonly Vector4I6F26 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, w, x); }
        public readonly Vector4I6F26 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, w, y); }
        public readonly Vector4I6F26 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, w, z); }
        public readonly Vector4I6F26 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, w, w, w); }
        public readonly Vector4I6F26 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, x, x); }
        public readonly Vector4I6F26 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, x, y); }
        public readonly Vector4I6F26 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, x, z); }
        public readonly Vector4I6F26 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, x, w); }
        public readonly Vector4I6F26 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, y, x); }
        public readonly Vector4I6F26 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, y, y); }
        public readonly Vector4I6F26 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, y, z); }
        public readonly Vector4I6F26 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, y, w); }
        public readonly Vector4I6F26 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, z, x); }
        public readonly Vector4I6F26 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, z, y); }
        public readonly Vector4I6F26 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, z, z); }
        public readonly Vector4I6F26 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, z, w); }
        public readonly Vector4I6F26 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, w, x); }
        public readonly Vector4I6F26 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, w, y); }
        public readonly Vector4I6F26 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, w, z); }
        public readonly Vector4I6F26 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, w, w); }
        public readonly Vector4I6F26 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, x, x); }
        public readonly Vector4I6F26 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, x, y); }
        public readonly Vector4I6F26 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, x, z); }
        public readonly Vector4I6F26 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, x, w); }
        public readonly Vector4I6F26 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, y, x); }
        public readonly Vector4I6F26 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, y, y); }
        public readonly Vector4I6F26 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, y, z); }
        public readonly Vector4I6F26 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, y, w); }
        public readonly Vector4I6F26 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, z, x); }
        public readonly Vector4I6F26 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, z, y); }
        public readonly Vector4I6F26 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, z, z); }
        public readonly Vector4I6F26 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, z, w); }
        public readonly Vector4I6F26 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, w, x); }
        public readonly Vector4I6F26 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, w, y); }
        public readonly Vector4I6F26 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, w, z); }
        public readonly Vector4I6F26 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, w, w); }
        public readonly Vector4I6F26 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, x, x); }
        public readonly Vector4I6F26 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, x, y); }
        public readonly Vector4I6F26 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, x, z); }
        public readonly Vector4I6F26 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, x, w); }
        public readonly Vector4I6F26 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, y, x); }
        public readonly Vector4I6F26 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, y, y); }
        public readonly Vector4I6F26 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, y, z); }
        public readonly Vector4I6F26 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, y, w); }
        public readonly Vector4I6F26 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, z, x); }
        public readonly Vector4I6F26 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, z, y); }
        public readonly Vector4I6F26 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, z, z); }
        public readonly Vector4I6F26 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, z, w); }
        public readonly Vector4I6F26 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, w, x); }
        public readonly Vector4I6F26 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, w, y); }
        public readonly Vector4I6F26 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, w, z); }
        public readonly Vector4I6F26 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, z, w, w); }
        public readonly Vector4I6F26 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, x, x); }
        public readonly Vector4I6F26 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, x, y); }
        public readonly Vector4I6F26 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, x, z); }
        public readonly Vector4I6F26 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, x, w); }
        public readonly Vector4I6F26 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, y, x); }
        public readonly Vector4I6F26 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, y, y); }
        public readonly Vector4I6F26 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, y, z); }
        public readonly Vector4I6F26 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, y, w); }
        public readonly Vector4I6F26 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, z, x); }
        public readonly Vector4I6F26 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, z, y); }
        public readonly Vector4I6F26 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, z, z); }
        public readonly Vector4I6F26 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, z, w); }
        public readonly Vector4I6F26 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, w, x); }
        public readonly Vector4I6F26 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, w, y); }
        public readonly Vector4I6F26 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, w, z); }
        public readonly Vector4I6F26 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, w, w, w); }
        public readonly Vector4I6F26 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, x, x); }
        public readonly Vector4I6F26 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, x, y); }
        public readonly Vector4I6F26 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, x, z); }
        public readonly Vector4I6F26 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, x, w); }
        public readonly Vector4I6F26 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, y, x); }
        public readonly Vector4I6F26 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, y, y); }
        public readonly Vector4I6F26 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, y, z); }
        public readonly Vector4I6F26 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, y, w); }
        public readonly Vector4I6F26 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, z, x); }
        public readonly Vector4I6F26 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, z, y); }
        public readonly Vector4I6F26 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, z, z); }
        public readonly Vector4I6F26 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, z, w); }
        public readonly Vector4I6F26 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, w, x); }
        public readonly Vector4I6F26 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, w, y); }
        public readonly Vector4I6F26 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, w, z); }
        public readonly Vector4I6F26 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, x, w, w); }
        public readonly Vector4I6F26 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, x, x); }
        public readonly Vector4I6F26 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, x, y); }
        public readonly Vector4I6F26 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, x, z); }
        public readonly Vector4I6F26 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, x, w); }
        public readonly Vector4I6F26 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, y, x); }
        public readonly Vector4I6F26 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, y, y); }
        public readonly Vector4I6F26 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, y, z); }
        public readonly Vector4I6F26 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, y, w); }
        public readonly Vector4I6F26 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, z, x); }
        public readonly Vector4I6F26 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, z, y); }
        public readonly Vector4I6F26 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, z, z); }
        public readonly Vector4I6F26 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, z, w); }
        public readonly Vector4I6F26 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, w, x); }
        public readonly Vector4I6F26 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, w, y); }
        public readonly Vector4I6F26 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, w, z); }
        public readonly Vector4I6F26 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, y, w, w); }
        public readonly Vector4I6F26 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, x, x); }
        public readonly Vector4I6F26 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, x, y); }
        public readonly Vector4I6F26 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, x, z); }
        public readonly Vector4I6F26 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, x, w); }
        public readonly Vector4I6F26 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, y, x); }
        public readonly Vector4I6F26 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, y, y); }
        public readonly Vector4I6F26 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, y, z); }
        public readonly Vector4I6F26 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, y, w); }
        public readonly Vector4I6F26 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, z, x); }
        public readonly Vector4I6F26 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, z, y); }
        public readonly Vector4I6F26 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, z, z); }
        public readonly Vector4I6F26 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, z, w); }
        public readonly Vector4I6F26 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, w, x); }
        public readonly Vector4I6F26 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, w, y); }
        public readonly Vector4I6F26 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, w, z); }
        public readonly Vector4I6F26 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, z, w, w); }
        public readonly Vector4I6F26 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, x, x); }
        public readonly Vector4I6F26 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, x, y); }
        public readonly Vector4I6F26 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, x, z); }
        public readonly Vector4I6F26 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, x, w); }
        public readonly Vector4I6F26 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, y, x); }
        public readonly Vector4I6F26 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, y, y); }
        public readonly Vector4I6F26 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, y, z); }
        public readonly Vector4I6F26 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, y, w); }
        public readonly Vector4I6F26 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, z, x); }
        public readonly Vector4I6F26 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, z, y); }
        public readonly Vector4I6F26 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, z, z); }
        public readonly Vector4I6F26 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, z, w); }
        public readonly Vector4I6F26 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, w, x); }
        public readonly Vector4I6F26 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, w, y); }
        public readonly Vector4I6F26 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, w, z); }
        public readonly Vector4I6F26 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(z, w, w, w); }
        public readonly Vector4I6F26 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, x, x); }
        public readonly Vector4I6F26 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, x, y); }
        public readonly Vector4I6F26 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, x, z); }
        public readonly Vector4I6F26 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, x, w); }
        public readonly Vector4I6F26 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, y, x); }
        public readonly Vector4I6F26 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, y, y); }
        public readonly Vector4I6F26 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, y, z); }
        public readonly Vector4I6F26 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, y, w); }
        public readonly Vector4I6F26 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, z, x); }
        public readonly Vector4I6F26 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, z, y); }
        public readonly Vector4I6F26 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, z, z); }
        public readonly Vector4I6F26 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, z, w); }
        public readonly Vector4I6F26 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, w, x); }
        public readonly Vector4I6F26 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, w, y); }
        public readonly Vector4I6F26 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, w, z); }
        public readonly Vector4I6F26 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, x, w, w); }
        public readonly Vector4I6F26 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, x, x); }
        public readonly Vector4I6F26 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, x, y); }
        public readonly Vector4I6F26 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, x, z); }
        public readonly Vector4I6F26 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, x, w); }
        public readonly Vector4I6F26 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, y, x); }
        public readonly Vector4I6F26 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, y, y); }
        public readonly Vector4I6F26 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, y, z); }
        public readonly Vector4I6F26 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, y, w); }
        public readonly Vector4I6F26 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, z, x); }
        public readonly Vector4I6F26 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, z, y); }
        public readonly Vector4I6F26 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, z, z); }
        public readonly Vector4I6F26 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, z, w); }
        public readonly Vector4I6F26 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, w, x); }
        public readonly Vector4I6F26 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, w, y); }
        public readonly Vector4I6F26 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, w, z); }
        public readonly Vector4I6F26 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, y, w, w); }
        public readonly Vector4I6F26 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, x, x); }
        public readonly Vector4I6F26 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, x, y); }
        public readonly Vector4I6F26 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, x, z); }
        public readonly Vector4I6F26 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, x, w); }
        public readonly Vector4I6F26 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, y, x); }
        public readonly Vector4I6F26 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, y, y); }
        public readonly Vector4I6F26 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, y, z); }
        public readonly Vector4I6F26 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, y, w); }
        public readonly Vector4I6F26 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, z, x); }
        public readonly Vector4I6F26 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, z, y); }
        public readonly Vector4I6F26 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, z, z); }
        public readonly Vector4I6F26 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, z, w); }
        public readonly Vector4I6F26 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, w, x); }
        public readonly Vector4I6F26 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, w, y); }
        public readonly Vector4I6F26 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, w, z); }
        public readonly Vector4I6F26 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, z, w, w); }
        public readonly Vector4I6F26 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, x, x); }
        public readonly Vector4I6F26 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, x, y); }
        public readonly Vector4I6F26 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, x, z); }
        public readonly Vector4I6F26 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, x, w); }
        public readonly Vector4I6F26 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, y, x); }
        public readonly Vector4I6F26 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, y, y); }
        public readonly Vector4I6F26 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, y, z); }
        public readonly Vector4I6F26 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, y, w); }
        public readonly Vector4I6F26 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, z, x); }
        public readonly Vector4I6F26 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, z, y); }
        public readonly Vector4I6F26 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, z, z); }
        public readonly Vector4I6F26 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, z, w); }
        public readonly Vector4I6F26 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, w, x); }
        public readonly Vector4I6F26 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, w, y); }
        public readonly Vector4I6F26 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, w, z); }
        public readonly Vector4I6F26 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I6F26 lhs, Vector4I6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I6F26 lhs, Vector4I6F26 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I6F26({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I6F26 other)
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
            return $"Vector4I6F26({x}, {y}, {z}, {w})";
        }
    }
}
