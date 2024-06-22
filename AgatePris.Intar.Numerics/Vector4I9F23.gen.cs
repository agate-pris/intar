using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I9F23 : IEquatable<Vector4I9F23>, IFormattable {
        // Fields
        // ---------------------------------------

        public I9F23 x;
        public I9F23 y;
        public I9F23 z;
        public I9F23 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I9F23 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(I9F23 x, I9F23 y, I9F23 z, I9F23 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(I9F23 x, I9F23 y, Vector2I9F23 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(I9F23 x, Vector3I9F23 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(Vector2I9F23 xy, Vector2I9F23 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(Vector4I9F23 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(I9F23 x, Vector2I9F23 yz, I9F23 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(Vector3I9F23 xyz, I9F23 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(Vector2I9F23 xy, I9F23 z, I9F23 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator +(Vector4I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator -(Vector4I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator *(Vector4I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator *(Vector4I9F23 a, I9F23 b) => new Vector4I9F23(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator *(I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator /(Vector4I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator /(Vector4I9F23 a, I9F23 b) => new Vector4I9F23(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator /(I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I9F23 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(x, x); }
        public readonly Vector2I9F23 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(x, y); }
        public readonly Vector2I9F23 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(x, z); }
        public readonly Vector2I9F23 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(x, w); }
        public readonly Vector2I9F23 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(y, x); }
        public readonly Vector2I9F23 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(y, y); }
        public readonly Vector2I9F23 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(y, z); }
        public readonly Vector2I9F23 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(y, w); }
        public readonly Vector2I9F23 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(z, x); }
        public readonly Vector2I9F23 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(z, y); }
        public readonly Vector2I9F23 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(z, z); }
        public readonly Vector2I9F23 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(z, w); }
        public readonly Vector2I9F23 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(w, x); }
        public readonly Vector2I9F23 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(w, y); }
        public readonly Vector2I9F23 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(w, z); }
        public readonly Vector2I9F23 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(w, w); }
        public readonly Vector3I9F23 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, x, x); }
        public readonly Vector3I9F23 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, x, y); }
        public readonly Vector3I9F23 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, x, z); }
        public readonly Vector3I9F23 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, x, w); }
        public readonly Vector3I9F23 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, y, x); }
        public readonly Vector3I9F23 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, y, y); }
        public readonly Vector3I9F23 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, y, z); }
        public readonly Vector3I9F23 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, y, w); }
        public readonly Vector3I9F23 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, z, x); }
        public readonly Vector3I9F23 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, z, y); }
        public readonly Vector3I9F23 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, z, z); }
        public readonly Vector3I9F23 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, z, w); }
        public readonly Vector3I9F23 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, w, x); }
        public readonly Vector3I9F23 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, w, y); }
        public readonly Vector3I9F23 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, w, z); }
        public readonly Vector3I9F23 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(x, w, w); }
        public readonly Vector3I9F23 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, x, x); }
        public readonly Vector3I9F23 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, x, y); }
        public readonly Vector3I9F23 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, x, z); }
        public readonly Vector3I9F23 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, x, w); }
        public readonly Vector3I9F23 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, y, x); }
        public readonly Vector3I9F23 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, y, y); }
        public readonly Vector3I9F23 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, y, z); }
        public readonly Vector3I9F23 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, y, w); }
        public readonly Vector3I9F23 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, z, x); }
        public readonly Vector3I9F23 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, z, y); }
        public readonly Vector3I9F23 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, z, z); }
        public readonly Vector3I9F23 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, z, w); }
        public readonly Vector3I9F23 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, w, x); }
        public readonly Vector3I9F23 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, w, y); }
        public readonly Vector3I9F23 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, w, z); }
        public readonly Vector3I9F23 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(y, w, w); }
        public readonly Vector3I9F23 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, x, x); }
        public readonly Vector3I9F23 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, x, y); }
        public readonly Vector3I9F23 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, x, z); }
        public readonly Vector3I9F23 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, x, w); }
        public readonly Vector3I9F23 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, y, x); }
        public readonly Vector3I9F23 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, y, y); }
        public readonly Vector3I9F23 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, y, z); }
        public readonly Vector3I9F23 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, y, w); }
        public readonly Vector3I9F23 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, z, x); }
        public readonly Vector3I9F23 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, z, y); }
        public readonly Vector3I9F23 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, z, z); }
        public readonly Vector3I9F23 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, z, w); }
        public readonly Vector3I9F23 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, w, x); }
        public readonly Vector3I9F23 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, w, y); }
        public readonly Vector3I9F23 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, w, z); }
        public readonly Vector3I9F23 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(z, w, w); }
        public readonly Vector3I9F23 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, x, x); }
        public readonly Vector3I9F23 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, x, y); }
        public readonly Vector3I9F23 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, x, z); }
        public readonly Vector3I9F23 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, x, w); }
        public readonly Vector3I9F23 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, y, x); }
        public readonly Vector3I9F23 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, y, y); }
        public readonly Vector3I9F23 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, y, z); }
        public readonly Vector3I9F23 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, y, w); }
        public readonly Vector3I9F23 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, z, x); }
        public readonly Vector3I9F23 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, z, y); }
        public readonly Vector3I9F23 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, z, z); }
        public readonly Vector3I9F23 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, z, w); }
        public readonly Vector3I9F23 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, w, x); }
        public readonly Vector3I9F23 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, w, y); }
        public readonly Vector3I9F23 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, w, z); }
        public readonly Vector3I9F23 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(w, w, w); }
        public readonly Vector4I9F23 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, x, x); }
        public readonly Vector4I9F23 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, x, y); }
        public readonly Vector4I9F23 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, x, z); }
        public readonly Vector4I9F23 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, x, w); }
        public readonly Vector4I9F23 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, y, x); }
        public readonly Vector4I9F23 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, y, y); }
        public readonly Vector4I9F23 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, y, z); }
        public readonly Vector4I9F23 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, y, w); }
        public readonly Vector4I9F23 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, z, x); }
        public readonly Vector4I9F23 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, z, y); }
        public readonly Vector4I9F23 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, z, z); }
        public readonly Vector4I9F23 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, z, w); }
        public readonly Vector4I9F23 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, w, x); }
        public readonly Vector4I9F23 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, w, y); }
        public readonly Vector4I9F23 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, w, z); }
        public readonly Vector4I9F23 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, x, w, w); }
        public readonly Vector4I9F23 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, x, x); }
        public readonly Vector4I9F23 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, x, y); }
        public readonly Vector4I9F23 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, x, z); }
        public readonly Vector4I9F23 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, x, w); }
        public readonly Vector4I9F23 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, y, x); }
        public readonly Vector4I9F23 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, y, y); }
        public readonly Vector4I9F23 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, y, z); }
        public readonly Vector4I9F23 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, y, w); }
        public readonly Vector4I9F23 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, z, x); }
        public readonly Vector4I9F23 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, z, y); }
        public readonly Vector4I9F23 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, z, z); }
        public readonly Vector4I9F23 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, z, w); }
        public readonly Vector4I9F23 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, w, x); }
        public readonly Vector4I9F23 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, w, y); }
        public readonly Vector4I9F23 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, w, z); }
        public readonly Vector4I9F23 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, y, w, w); }
        public readonly Vector4I9F23 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, x, x); }
        public readonly Vector4I9F23 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, x, y); }
        public readonly Vector4I9F23 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, x, z); }
        public readonly Vector4I9F23 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, x, w); }
        public readonly Vector4I9F23 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, y, x); }
        public readonly Vector4I9F23 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, y, y); }
        public readonly Vector4I9F23 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, y, z); }
        public readonly Vector4I9F23 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, y, w); }
        public readonly Vector4I9F23 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, z, x); }
        public readonly Vector4I9F23 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, z, y); }
        public readonly Vector4I9F23 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, z, z); }
        public readonly Vector4I9F23 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, z, w); }
        public readonly Vector4I9F23 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, w, x); }
        public readonly Vector4I9F23 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, w, y); }
        public readonly Vector4I9F23 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, w, z); }
        public readonly Vector4I9F23 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, z, w, w); }
        public readonly Vector4I9F23 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, x, x); }
        public readonly Vector4I9F23 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, x, y); }
        public readonly Vector4I9F23 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, x, z); }
        public readonly Vector4I9F23 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, x, w); }
        public readonly Vector4I9F23 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, y, x); }
        public readonly Vector4I9F23 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, y, y); }
        public readonly Vector4I9F23 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, y, z); }
        public readonly Vector4I9F23 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, y, w); }
        public readonly Vector4I9F23 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, z, x); }
        public readonly Vector4I9F23 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, z, y); }
        public readonly Vector4I9F23 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, z, z); }
        public readonly Vector4I9F23 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, z, w); }
        public readonly Vector4I9F23 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, w, x); }
        public readonly Vector4I9F23 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, w, y); }
        public readonly Vector4I9F23 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, w, z); }
        public readonly Vector4I9F23 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(x, w, w, w); }
        public readonly Vector4I9F23 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, x, x); }
        public readonly Vector4I9F23 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, x, y); }
        public readonly Vector4I9F23 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, x, z); }
        public readonly Vector4I9F23 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, x, w); }
        public readonly Vector4I9F23 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, y, x); }
        public readonly Vector4I9F23 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, y, y); }
        public readonly Vector4I9F23 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, y, z); }
        public readonly Vector4I9F23 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, y, w); }
        public readonly Vector4I9F23 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, z, x); }
        public readonly Vector4I9F23 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, z, y); }
        public readonly Vector4I9F23 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, z, z); }
        public readonly Vector4I9F23 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, z, w); }
        public readonly Vector4I9F23 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, w, x); }
        public readonly Vector4I9F23 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, w, y); }
        public readonly Vector4I9F23 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, w, z); }
        public readonly Vector4I9F23 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, x, w, w); }
        public readonly Vector4I9F23 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, x, x); }
        public readonly Vector4I9F23 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, x, y); }
        public readonly Vector4I9F23 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, x, z); }
        public readonly Vector4I9F23 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, x, w); }
        public readonly Vector4I9F23 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, y, x); }
        public readonly Vector4I9F23 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, y, y); }
        public readonly Vector4I9F23 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, y, z); }
        public readonly Vector4I9F23 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, y, w); }
        public readonly Vector4I9F23 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, z, x); }
        public readonly Vector4I9F23 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, z, y); }
        public readonly Vector4I9F23 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, z, z); }
        public readonly Vector4I9F23 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, z, w); }
        public readonly Vector4I9F23 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, w, x); }
        public readonly Vector4I9F23 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, w, y); }
        public readonly Vector4I9F23 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, w, z); }
        public readonly Vector4I9F23 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, y, w, w); }
        public readonly Vector4I9F23 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, x, x); }
        public readonly Vector4I9F23 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, x, y); }
        public readonly Vector4I9F23 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, x, z); }
        public readonly Vector4I9F23 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, x, w); }
        public readonly Vector4I9F23 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, y, x); }
        public readonly Vector4I9F23 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, y, y); }
        public readonly Vector4I9F23 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, y, z); }
        public readonly Vector4I9F23 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, y, w); }
        public readonly Vector4I9F23 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, z, x); }
        public readonly Vector4I9F23 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, z, y); }
        public readonly Vector4I9F23 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, z, z); }
        public readonly Vector4I9F23 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, z, w); }
        public readonly Vector4I9F23 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, w, x); }
        public readonly Vector4I9F23 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, w, y); }
        public readonly Vector4I9F23 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, w, z); }
        public readonly Vector4I9F23 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, z, w, w); }
        public readonly Vector4I9F23 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, x, x); }
        public readonly Vector4I9F23 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, x, y); }
        public readonly Vector4I9F23 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, x, z); }
        public readonly Vector4I9F23 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, x, w); }
        public readonly Vector4I9F23 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, y, x); }
        public readonly Vector4I9F23 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, y, y); }
        public readonly Vector4I9F23 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, y, z); }
        public readonly Vector4I9F23 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, y, w); }
        public readonly Vector4I9F23 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, z, x); }
        public readonly Vector4I9F23 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, z, y); }
        public readonly Vector4I9F23 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, z, z); }
        public readonly Vector4I9F23 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, z, w); }
        public readonly Vector4I9F23 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, w, x); }
        public readonly Vector4I9F23 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, w, y); }
        public readonly Vector4I9F23 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, w, z); }
        public readonly Vector4I9F23 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(y, w, w, w); }
        public readonly Vector4I9F23 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, x, x); }
        public readonly Vector4I9F23 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, x, y); }
        public readonly Vector4I9F23 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, x, z); }
        public readonly Vector4I9F23 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, x, w); }
        public readonly Vector4I9F23 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, y, x); }
        public readonly Vector4I9F23 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, y, y); }
        public readonly Vector4I9F23 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, y, z); }
        public readonly Vector4I9F23 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, y, w); }
        public readonly Vector4I9F23 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, z, x); }
        public readonly Vector4I9F23 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, z, y); }
        public readonly Vector4I9F23 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, z, z); }
        public readonly Vector4I9F23 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, z, w); }
        public readonly Vector4I9F23 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, w, x); }
        public readonly Vector4I9F23 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, w, y); }
        public readonly Vector4I9F23 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, w, z); }
        public readonly Vector4I9F23 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, x, w, w); }
        public readonly Vector4I9F23 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, x, x); }
        public readonly Vector4I9F23 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, x, y); }
        public readonly Vector4I9F23 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, x, z); }
        public readonly Vector4I9F23 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, x, w); }
        public readonly Vector4I9F23 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, y, x); }
        public readonly Vector4I9F23 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, y, y); }
        public readonly Vector4I9F23 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, y, z); }
        public readonly Vector4I9F23 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, y, w); }
        public readonly Vector4I9F23 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, z, x); }
        public readonly Vector4I9F23 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, z, y); }
        public readonly Vector4I9F23 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, z, z); }
        public readonly Vector4I9F23 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, z, w); }
        public readonly Vector4I9F23 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, w, x); }
        public readonly Vector4I9F23 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, w, y); }
        public readonly Vector4I9F23 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, w, z); }
        public readonly Vector4I9F23 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, y, w, w); }
        public readonly Vector4I9F23 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, x, x); }
        public readonly Vector4I9F23 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, x, y); }
        public readonly Vector4I9F23 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, x, z); }
        public readonly Vector4I9F23 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, x, w); }
        public readonly Vector4I9F23 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, y, x); }
        public readonly Vector4I9F23 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, y, y); }
        public readonly Vector4I9F23 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, y, z); }
        public readonly Vector4I9F23 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, y, w); }
        public readonly Vector4I9F23 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, z, x); }
        public readonly Vector4I9F23 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, z, y); }
        public readonly Vector4I9F23 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, z, z); }
        public readonly Vector4I9F23 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, z, w); }
        public readonly Vector4I9F23 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, w, x); }
        public readonly Vector4I9F23 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, w, y); }
        public readonly Vector4I9F23 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, w, z); }
        public readonly Vector4I9F23 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, z, w, w); }
        public readonly Vector4I9F23 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, x, x); }
        public readonly Vector4I9F23 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, x, y); }
        public readonly Vector4I9F23 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, x, z); }
        public readonly Vector4I9F23 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, x, w); }
        public readonly Vector4I9F23 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, y, x); }
        public readonly Vector4I9F23 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, y, y); }
        public readonly Vector4I9F23 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, y, z); }
        public readonly Vector4I9F23 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, y, w); }
        public readonly Vector4I9F23 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, z, x); }
        public readonly Vector4I9F23 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, z, y); }
        public readonly Vector4I9F23 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, z, z); }
        public readonly Vector4I9F23 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, z, w); }
        public readonly Vector4I9F23 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, w, x); }
        public readonly Vector4I9F23 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, w, y); }
        public readonly Vector4I9F23 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, w, z); }
        public readonly Vector4I9F23 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(z, w, w, w); }
        public readonly Vector4I9F23 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, x, x); }
        public readonly Vector4I9F23 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, x, y); }
        public readonly Vector4I9F23 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, x, z); }
        public readonly Vector4I9F23 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, x, w); }
        public readonly Vector4I9F23 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, y, x); }
        public readonly Vector4I9F23 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, y, y); }
        public readonly Vector4I9F23 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, y, z); }
        public readonly Vector4I9F23 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, y, w); }
        public readonly Vector4I9F23 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, z, x); }
        public readonly Vector4I9F23 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, z, y); }
        public readonly Vector4I9F23 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, z, z); }
        public readonly Vector4I9F23 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, z, w); }
        public readonly Vector4I9F23 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, w, x); }
        public readonly Vector4I9F23 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, w, y); }
        public readonly Vector4I9F23 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, w, z); }
        public readonly Vector4I9F23 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, x, w, w); }
        public readonly Vector4I9F23 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, x, x); }
        public readonly Vector4I9F23 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, x, y); }
        public readonly Vector4I9F23 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, x, z); }
        public readonly Vector4I9F23 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, x, w); }
        public readonly Vector4I9F23 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, y, x); }
        public readonly Vector4I9F23 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, y, y); }
        public readonly Vector4I9F23 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, y, z); }
        public readonly Vector4I9F23 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, y, w); }
        public readonly Vector4I9F23 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, z, x); }
        public readonly Vector4I9F23 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, z, y); }
        public readonly Vector4I9F23 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, z, z); }
        public readonly Vector4I9F23 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, z, w); }
        public readonly Vector4I9F23 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, w, x); }
        public readonly Vector4I9F23 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, w, y); }
        public readonly Vector4I9F23 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, w, z); }
        public readonly Vector4I9F23 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, y, w, w); }
        public readonly Vector4I9F23 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, x, x); }
        public readonly Vector4I9F23 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, x, y); }
        public readonly Vector4I9F23 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, x, z); }
        public readonly Vector4I9F23 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, x, w); }
        public readonly Vector4I9F23 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, y, x); }
        public readonly Vector4I9F23 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, y, y); }
        public readonly Vector4I9F23 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, y, z); }
        public readonly Vector4I9F23 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, y, w); }
        public readonly Vector4I9F23 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, z, x); }
        public readonly Vector4I9F23 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, z, y); }
        public readonly Vector4I9F23 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, z, z); }
        public readonly Vector4I9F23 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, z, w); }
        public readonly Vector4I9F23 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, w, x); }
        public readonly Vector4I9F23 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, w, y); }
        public readonly Vector4I9F23 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, w, z); }
        public readonly Vector4I9F23 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, z, w, w); }
        public readonly Vector4I9F23 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, x, x); }
        public readonly Vector4I9F23 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, x, y); }
        public readonly Vector4I9F23 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, x, z); }
        public readonly Vector4I9F23 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, x, w); }
        public readonly Vector4I9F23 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, y, x); }
        public readonly Vector4I9F23 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, y, y); }
        public readonly Vector4I9F23 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, y, z); }
        public readonly Vector4I9F23 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, y, w); }
        public readonly Vector4I9F23 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, z, x); }
        public readonly Vector4I9F23 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, z, y); }
        public readonly Vector4I9F23 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, z, z); }
        public readonly Vector4I9F23 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, z, w); }
        public readonly Vector4I9F23 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, w, x); }
        public readonly Vector4I9F23 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, w, y); }
        public readonly Vector4I9F23 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, w, z); }
        public readonly Vector4I9F23 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I9F23 lhs, Vector4I9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I9F23 lhs, Vector4I9F23 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I9F23({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I9F23 other)
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
            return $"Vector4I9F23({x}, {y}, {z}, {w})";
        }
    }
}
