using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I31F1 : IEquatable<Vector4I31F1>, IFormattable {
        // Fields
        // ---------------------------------------

        public I31F1 x;
        public I31F1 y;
        public I31F1 z;
        public I31F1 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I31F1 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, I31F1 y, I31F1 z, I31F1 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, I31F1 y, Vector2I31F1 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, Vector3I31F1 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector2I31F1 xy, Vector2I31F1 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector4I31F1 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, Vector2I31F1 yz, I31F1 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector3I31F1 xyz, I31F1 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector2I31F1 xy, I31F1 z, I31F1 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator +(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator -(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator *(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator *(Vector4I31F1 a, I31F1 b) => new Vector4I31F1(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator *(I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator /(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator /(Vector4I31F1 a, I31F1 b) => new Vector4I31F1(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator /(I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I31F1 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(x, x); }
        public readonly Vector2I31F1 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(x, y); }
        public readonly Vector2I31F1 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(x, z); }
        public readonly Vector2I31F1 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(x, w); }
        public readonly Vector2I31F1 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(y, x); }
        public readonly Vector2I31F1 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(y, y); }
        public readonly Vector2I31F1 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(y, z); }
        public readonly Vector2I31F1 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(y, w); }
        public readonly Vector2I31F1 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(z, x); }
        public readonly Vector2I31F1 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(z, y); }
        public readonly Vector2I31F1 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(z, z); }
        public readonly Vector2I31F1 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(z, w); }
        public readonly Vector2I31F1 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(w, x); }
        public readonly Vector2I31F1 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(w, y); }
        public readonly Vector2I31F1 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(w, z); }
        public readonly Vector2I31F1 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(w, w); }
        public readonly Vector3I31F1 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, x, x); }
        public readonly Vector3I31F1 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, x, y); }
        public readonly Vector3I31F1 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, x, z); }
        public readonly Vector3I31F1 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, x, w); }
        public readonly Vector3I31F1 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, y, x); }
        public readonly Vector3I31F1 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, y, y); }
        public readonly Vector3I31F1 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, y, z); }
        public readonly Vector3I31F1 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, y, w); }
        public readonly Vector3I31F1 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, z, x); }
        public readonly Vector3I31F1 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, z, y); }
        public readonly Vector3I31F1 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, z, z); }
        public readonly Vector3I31F1 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, z, w); }
        public readonly Vector3I31F1 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, w, x); }
        public readonly Vector3I31F1 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, w, y); }
        public readonly Vector3I31F1 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, w, z); }
        public readonly Vector3I31F1 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, w, w); }
        public readonly Vector3I31F1 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, x, x); }
        public readonly Vector3I31F1 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, x, y); }
        public readonly Vector3I31F1 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, x, z); }
        public readonly Vector3I31F1 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, x, w); }
        public readonly Vector3I31F1 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, y, x); }
        public readonly Vector3I31F1 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, y, y); }
        public readonly Vector3I31F1 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, y, z); }
        public readonly Vector3I31F1 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, y, w); }
        public readonly Vector3I31F1 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, z, x); }
        public readonly Vector3I31F1 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, z, y); }
        public readonly Vector3I31F1 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, z, z); }
        public readonly Vector3I31F1 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, z, w); }
        public readonly Vector3I31F1 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, w, x); }
        public readonly Vector3I31F1 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, w, y); }
        public readonly Vector3I31F1 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, w, z); }
        public readonly Vector3I31F1 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, w, w); }
        public readonly Vector3I31F1 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, x, x); }
        public readonly Vector3I31F1 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, x, y); }
        public readonly Vector3I31F1 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, x, z); }
        public readonly Vector3I31F1 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, x, w); }
        public readonly Vector3I31F1 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, y, x); }
        public readonly Vector3I31F1 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, y, y); }
        public readonly Vector3I31F1 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, y, z); }
        public readonly Vector3I31F1 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, y, w); }
        public readonly Vector3I31F1 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, z, x); }
        public readonly Vector3I31F1 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, z, y); }
        public readonly Vector3I31F1 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, z, z); }
        public readonly Vector3I31F1 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, z, w); }
        public readonly Vector3I31F1 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, w, x); }
        public readonly Vector3I31F1 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, w, y); }
        public readonly Vector3I31F1 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, w, z); }
        public readonly Vector3I31F1 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, w, w); }
        public readonly Vector3I31F1 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, x, x); }
        public readonly Vector3I31F1 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, x, y); }
        public readonly Vector3I31F1 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, x, z); }
        public readonly Vector3I31F1 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, x, w); }
        public readonly Vector3I31F1 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, y, x); }
        public readonly Vector3I31F1 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, y, y); }
        public readonly Vector3I31F1 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, y, z); }
        public readonly Vector3I31F1 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, y, w); }
        public readonly Vector3I31F1 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, z, x); }
        public readonly Vector3I31F1 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, z, y); }
        public readonly Vector3I31F1 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, z, z); }
        public readonly Vector3I31F1 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, z, w); }
        public readonly Vector3I31F1 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, w, x); }
        public readonly Vector3I31F1 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, w, y); }
        public readonly Vector3I31F1 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, w, z); }
        public readonly Vector3I31F1 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(w, w, w); }
        public readonly Vector4I31F1 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, x, x); }
        public readonly Vector4I31F1 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, x, y); }
        public readonly Vector4I31F1 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, x, z); }
        public readonly Vector4I31F1 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, x, w); }
        public readonly Vector4I31F1 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, y, x); }
        public readonly Vector4I31F1 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, y, y); }
        public readonly Vector4I31F1 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, y, z); }
        public readonly Vector4I31F1 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, y, w); }
        public readonly Vector4I31F1 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, z, x); }
        public readonly Vector4I31F1 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, z, y); }
        public readonly Vector4I31F1 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, z, z); }
        public readonly Vector4I31F1 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, z, w); }
        public readonly Vector4I31F1 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, w, x); }
        public readonly Vector4I31F1 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, w, y); }
        public readonly Vector4I31F1 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, w, z); }
        public readonly Vector4I31F1 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, w, w); }
        public readonly Vector4I31F1 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, x, x); }
        public readonly Vector4I31F1 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, x, y); }
        public readonly Vector4I31F1 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, x, z); }
        public readonly Vector4I31F1 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, x, w); }
        public readonly Vector4I31F1 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, y, x); }
        public readonly Vector4I31F1 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, y, y); }
        public readonly Vector4I31F1 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, y, z); }
        public readonly Vector4I31F1 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, y, w); }
        public readonly Vector4I31F1 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, z, x); }
        public readonly Vector4I31F1 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, z, y); }
        public readonly Vector4I31F1 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, z, z); }
        public readonly Vector4I31F1 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, z, w); }
        public readonly Vector4I31F1 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, w, x); }
        public readonly Vector4I31F1 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, w, y); }
        public readonly Vector4I31F1 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, w, z); }
        public readonly Vector4I31F1 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, w, w); }
        public readonly Vector4I31F1 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, x, x); }
        public readonly Vector4I31F1 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, x, y); }
        public readonly Vector4I31F1 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, x, z); }
        public readonly Vector4I31F1 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, x, w); }
        public readonly Vector4I31F1 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, y, x); }
        public readonly Vector4I31F1 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, y, y); }
        public readonly Vector4I31F1 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, y, z); }
        public readonly Vector4I31F1 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, y, w); }
        public readonly Vector4I31F1 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, z, x); }
        public readonly Vector4I31F1 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, z, y); }
        public readonly Vector4I31F1 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, z, z); }
        public readonly Vector4I31F1 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, z, w); }
        public readonly Vector4I31F1 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, w, x); }
        public readonly Vector4I31F1 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, w, y); }
        public readonly Vector4I31F1 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, w, z); }
        public readonly Vector4I31F1 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, w, w); }
        public readonly Vector4I31F1 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, x, x); }
        public readonly Vector4I31F1 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, x, y); }
        public readonly Vector4I31F1 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, x, z); }
        public readonly Vector4I31F1 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, x, w); }
        public readonly Vector4I31F1 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, y, x); }
        public readonly Vector4I31F1 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, y, y); }
        public readonly Vector4I31F1 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, y, z); }
        public readonly Vector4I31F1 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, y, w); }
        public readonly Vector4I31F1 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, z, x); }
        public readonly Vector4I31F1 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, z, y); }
        public readonly Vector4I31F1 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, z, z); }
        public readonly Vector4I31F1 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, z, w); }
        public readonly Vector4I31F1 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, w, x); }
        public readonly Vector4I31F1 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, w, y); }
        public readonly Vector4I31F1 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, w, z); }
        public readonly Vector4I31F1 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, w, w, w); }
        public readonly Vector4I31F1 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, x, x); }
        public readonly Vector4I31F1 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, x, y); }
        public readonly Vector4I31F1 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, x, z); }
        public readonly Vector4I31F1 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, x, w); }
        public readonly Vector4I31F1 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, y, x); }
        public readonly Vector4I31F1 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, y, y); }
        public readonly Vector4I31F1 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, y, z); }
        public readonly Vector4I31F1 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, y, w); }
        public readonly Vector4I31F1 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, z, x); }
        public readonly Vector4I31F1 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, z, y); }
        public readonly Vector4I31F1 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, z, z); }
        public readonly Vector4I31F1 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, z, w); }
        public readonly Vector4I31F1 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, w, x); }
        public readonly Vector4I31F1 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, w, y); }
        public readonly Vector4I31F1 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, w, z); }
        public readonly Vector4I31F1 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, w, w); }
        public readonly Vector4I31F1 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, x, x); }
        public readonly Vector4I31F1 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, x, y); }
        public readonly Vector4I31F1 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, x, z); }
        public readonly Vector4I31F1 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, x, w); }
        public readonly Vector4I31F1 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, y, x); }
        public readonly Vector4I31F1 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, y, y); }
        public readonly Vector4I31F1 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, y, z); }
        public readonly Vector4I31F1 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, y, w); }
        public readonly Vector4I31F1 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, z, x); }
        public readonly Vector4I31F1 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, z, y); }
        public readonly Vector4I31F1 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, z, z); }
        public readonly Vector4I31F1 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, z, w); }
        public readonly Vector4I31F1 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, w, x); }
        public readonly Vector4I31F1 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, w, y); }
        public readonly Vector4I31F1 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, w, z); }
        public readonly Vector4I31F1 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, w, w); }
        public readonly Vector4I31F1 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, x, x); }
        public readonly Vector4I31F1 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, x, y); }
        public readonly Vector4I31F1 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, x, z); }
        public readonly Vector4I31F1 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, x, w); }
        public readonly Vector4I31F1 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, y, x); }
        public readonly Vector4I31F1 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, y, y); }
        public readonly Vector4I31F1 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, y, z); }
        public readonly Vector4I31F1 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, y, w); }
        public readonly Vector4I31F1 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, z, x); }
        public readonly Vector4I31F1 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, z, y); }
        public readonly Vector4I31F1 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, z, z); }
        public readonly Vector4I31F1 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, z, w); }
        public readonly Vector4I31F1 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, w, x); }
        public readonly Vector4I31F1 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, w, y); }
        public readonly Vector4I31F1 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, w, z); }
        public readonly Vector4I31F1 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, w, w); }
        public readonly Vector4I31F1 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, x, x); }
        public readonly Vector4I31F1 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, x, y); }
        public readonly Vector4I31F1 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, x, z); }
        public readonly Vector4I31F1 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, x, w); }
        public readonly Vector4I31F1 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, y, x); }
        public readonly Vector4I31F1 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, y, y); }
        public readonly Vector4I31F1 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, y, z); }
        public readonly Vector4I31F1 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, y, w); }
        public readonly Vector4I31F1 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, z, x); }
        public readonly Vector4I31F1 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, z, y); }
        public readonly Vector4I31F1 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, z, z); }
        public readonly Vector4I31F1 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, z, w); }
        public readonly Vector4I31F1 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, w, x); }
        public readonly Vector4I31F1 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, w, y); }
        public readonly Vector4I31F1 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, w, z); }
        public readonly Vector4I31F1 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, w, w, w); }
        public readonly Vector4I31F1 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, x, x); }
        public readonly Vector4I31F1 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, x, y); }
        public readonly Vector4I31F1 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, x, z); }
        public readonly Vector4I31F1 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, x, w); }
        public readonly Vector4I31F1 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, y, x); }
        public readonly Vector4I31F1 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, y, y); }
        public readonly Vector4I31F1 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, y, z); }
        public readonly Vector4I31F1 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, y, w); }
        public readonly Vector4I31F1 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, z, x); }
        public readonly Vector4I31F1 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, z, y); }
        public readonly Vector4I31F1 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, z, z); }
        public readonly Vector4I31F1 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, z, w); }
        public readonly Vector4I31F1 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, w, x); }
        public readonly Vector4I31F1 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, w, y); }
        public readonly Vector4I31F1 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, w, z); }
        public readonly Vector4I31F1 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, w, w); }
        public readonly Vector4I31F1 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, x, x); }
        public readonly Vector4I31F1 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, x, y); }
        public readonly Vector4I31F1 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, x, z); }
        public readonly Vector4I31F1 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, x, w); }
        public readonly Vector4I31F1 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, y, x); }
        public readonly Vector4I31F1 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, y, y); }
        public readonly Vector4I31F1 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, y, z); }
        public readonly Vector4I31F1 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, y, w); }
        public readonly Vector4I31F1 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, z, x); }
        public readonly Vector4I31F1 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, z, y); }
        public readonly Vector4I31F1 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, z, z); }
        public readonly Vector4I31F1 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, z, w); }
        public readonly Vector4I31F1 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, w, x); }
        public readonly Vector4I31F1 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, w, y); }
        public readonly Vector4I31F1 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, w, z); }
        public readonly Vector4I31F1 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, w, w); }
        public readonly Vector4I31F1 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, x, x); }
        public readonly Vector4I31F1 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, x, y); }
        public readonly Vector4I31F1 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, x, z); }
        public readonly Vector4I31F1 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, x, w); }
        public readonly Vector4I31F1 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, y, x); }
        public readonly Vector4I31F1 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, y, y); }
        public readonly Vector4I31F1 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, y, z); }
        public readonly Vector4I31F1 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, y, w); }
        public readonly Vector4I31F1 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, z, x); }
        public readonly Vector4I31F1 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, z, y); }
        public readonly Vector4I31F1 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, z, z); }
        public readonly Vector4I31F1 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, z, w); }
        public readonly Vector4I31F1 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, w, x); }
        public readonly Vector4I31F1 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, w, y); }
        public readonly Vector4I31F1 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, w, z); }
        public readonly Vector4I31F1 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, w, w); }
        public readonly Vector4I31F1 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, x, x); }
        public readonly Vector4I31F1 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, x, y); }
        public readonly Vector4I31F1 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, x, z); }
        public readonly Vector4I31F1 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, x, w); }
        public readonly Vector4I31F1 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, y, x); }
        public readonly Vector4I31F1 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, y, y); }
        public readonly Vector4I31F1 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, y, z); }
        public readonly Vector4I31F1 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, y, w); }
        public readonly Vector4I31F1 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, z, x); }
        public readonly Vector4I31F1 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, z, y); }
        public readonly Vector4I31F1 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, z, z); }
        public readonly Vector4I31F1 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, z, w); }
        public readonly Vector4I31F1 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, w, x); }
        public readonly Vector4I31F1 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, w, y); }
        public readonly Vector4I31F1 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, w, z); }
        public readonly Vector4I31F1 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, w, w, w); }
        public readonly Vector4I31F1 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, x, x); }
        public readonly Vector4I31F1 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, x, y); }
        public readonly Vector4I31F1 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, x, z); }
        public readonly Vector4I31F1 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, x, w); }
        public readonly Vector4I31F1 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, y, x); }
        public readonly Vector4I31F1 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, y, y); }
        public readonly Vector4I31F1 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, y, z); }
        public readonly Vector4I31F1 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, y, w); }
        public readonly Vector4I31F1 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, z, x); }
        public readonly Vector4I31F1 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, z, y); }
        public readonly Vector4I31F1 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, z, z); }
        public readonly Vector4I31F1 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, z, w); }
        public readonly Vector4I31F1 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, w, x); }
        public readonly Vector4I31F1 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, w, y); }
        public readonly Vector4I31F1 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, w, z); }
        public readonly Vector4I31F1 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, x, w, w); }
        public readonly Vector4I31F1 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, x, x); }
        public readonly Vector4I31F1 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, x, y); }
        public readonly Vector4I31F1 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, x, z); }
        public readonly Vector4I31F1 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, x, w); }
        public readonly Vector4I31F1 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, y, x); }
        public readonly Vector4I31F1 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, y, y); }
        public readonly Vector4I31F1 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, y, z); }
        public readonly Vector4I31F1 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, y, w); }
        public readonly Vector4I31F1 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, z, x); }
        public readonly Vector4I31F1 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, z, y); }
        public readonly Vector4I31F1 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, z, z); }
        public readonly Vector4I31F1 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, z, w); }
        public readonly Vector4I31F1 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, w, x); }
        public readonly Vector4I31F1 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, w, y); }
        public readonly Vector4I31F1 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, w, z); }
        public readonly Vector4I31F1 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, y, w, w); }
        public readonly Vector4I31F1 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, x, x); }
        public readonly Vector4I31F1 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, x, y); }
        public readonly Vector4I31F1 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, x, z); }
        public readonly Vector4I31F1 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, x, w); }
        public readonly Vector4I31F1 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, y, x); }
        public readonly Vector4I31F1 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, y, y); }
        public readonly Vector4I31F1 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, y, z); }
        public readonly Vector4I31F1 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, y, w); }
        public readonly Vector4I31F1 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, z, x); }
        public readonly Vector4I31F1 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, z, y); }
        public readonly Vector4I31F1 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, z, z); }
        public readonly Vector4I31F1 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, z, w); }
        public readonly Vector4I31F1 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, w, x); }
        public readonly Vector4I31F1 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, w, y); }
        public readonly Vector4I31F1 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, w, z); }
        public readonly Vector4I31F1 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, z, w, w); }
        public readonly Vector4I31F1 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, x, x); }
        public readonly Vector4I31F1 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, x, y); }
        public readonly Vector4I31F1 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, x, z); }
        public readonly Vector4I31F1 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, x, w); }
        public readonly Vector4I31F1 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, y, x); }
        public readonly Vector4I31F1 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, y, y); }
        public readonly Vector4I31F1 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, y, z); }
        public readonly Vector4I31F1 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, y, w); }
        public readonly Vector4I31F1 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, z, x); }
        public readonly Vector4I31F1 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, z, y); }
        public readonly Vector4I31F1 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, z, z); }
        public readonly Vector4I31F1 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, z, w); }
        public readonly Vector4I31F1 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, w, x); }
        public readonly Vector4I31F1 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, w, y); }
        public readonly Vector4I31F1 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, w, z); }
        public readonly Vector4I31F1 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I31F1 lhs, Vector4I31F1 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I31F1 lhs, Vector4I31F1 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I31F1 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I31F1({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I31F1>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I31F1 other)
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
            return $"Vector4I31F1({x}, {y}, {z}, {w})";
        }
    }
}
