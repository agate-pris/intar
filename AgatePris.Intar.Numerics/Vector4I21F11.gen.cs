using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I21F11 : IEquatable<Vector4I21F11>, IFormattable {
        // Fields
        // ---------------------------------------

        public I21F11 x;
        public I21F11 y;
        public I21F11 z;
        public I21F11 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I21F11 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I21F11(I21F11 x, I21F11 y, I21F11 z, I21F11 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I21F11(I21F11 x, I21F11 y, Vector2I21F11 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I21F11(I21F11 x, Vector3I21F11 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I21F11(Vector2I21F11 xy, Vector2I21F11 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I21F11(Vector4I21F11 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I21F11(I21F11 x, Vector2I21F11 yz, I21F11 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I21F11(Vector3I21F11 xyz, I21F11 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I21F11(Vector2I21F11 xy, I21F11 z, I21F11 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 operator +(Vector4I21F11 a, Vector4I21F11 b) => new Vector4I21F11(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 operator -(Vector4I21F11 a, Vector4I21F11 b) => new Vector4I21F11(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 operator *(Vector4I21F11 a, Vector4I21F11 b) => new Vector4I21F11(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 operator *(Vector4I21F11 a, I21F11 b) => new Vector4I21F11(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 operator *(I21F11 a, Vector4I21F11 b) => new Vector4I21F11(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 operator /(Vector4I21F11 a, Vector4I21F11 b) => new Vector4I21F11(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 operator /(Vector4I21F11 a, I21F11 b) => new Vector4I21F11(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 operator /(I21F11 a, Vector4I21F11 b) => new Vector4I21F11(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I21F11 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(x, x); }
        public readonly Vector2I21F11 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(x, y); }
        public readonly Vector2I21F11 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(x, z); }
        public readonly Vector2I21F11 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(x, w); }
        public readonly Vector2I21F11 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(y, x); }
        public readonly Vector2I21F11 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(y, y); }
        public readonly Vector2I21F11 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(y, z); }
        public readonly Vector2I21F11 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(y, w); }
        public readonly Vector2I21F11 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(z, x); }
        public readonly Vector2I21F11 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(z, y); }
        public readonly Vector2I21F11 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(z, z); }
        public readonly Vector2I21F11 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(z, w); }
        public readonly Vector2I21F11 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(w, x); }
        public readonly Vector2I21F11 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(w, y); }
        public readonly Vector2I21F11 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(w, z); }
        public readonly Vector2I21F11 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(w, w); }
        public readonly Vector3I21F11 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, x, x); }
        public readonly Vector3I21F11 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, x, y); }
        public readonly Vector3I21F11 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, x, z); }
        public readonly Vector3I21F11 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, x, w); }
        public readonly Vector3I21F11 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, y, x); }
        public readonly Vector3I21F11 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, y, y); }
        public readonly Vector3I21F11 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, y, z); }
        public readonly Vector3I21F11 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, y, w); }
        public readonly Vector3I21F11 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, z, x); }
        public readonly Vector3I21F11 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, z, y); }
        public readonly Vector3I21F11 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, z, z); }
        public readonly Vector3I21F11 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, z, w); }
        public readonly Vector3I21F11 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, w, x); }
        public readonly Vector3I21F11 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, w, y); }
        public readonly Vector3I21F11 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, w, z); }
        public readonly Vector3I21F11 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, w, w); }
        public readonly Vector3I21F11 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, x, x); }
        public readonly Vector3I21F11 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, x, y); }
        public readonly Vector3I21F11 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, x, z); }
        public readonly Vector3I21F11 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, x, w); }
        public readonly Vector3I21F11 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, y, x); }
        public readonly Vector3I21F11 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, y, y); }
        public readonly Vector3I21F11 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, y, z); }
        public readonly Vector3I21F11 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, y, w); }
        public readonly Vector3I21F11 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, z, x); }
        public readonly Vector3I21F11 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, z, y); }
        public readonly Vector3I21F11 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, z, z); }
        public readonly Vector3I21F11 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, z, w); }
        public readonly Vector3I21F11 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, w, x); }
        public readonly Vector3I21F11 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, w, y); }
        public readonly Vector3I21F11 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, w, z); }
        public readonly Vector3I21F11 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, w, w); }
        public readonly Vector3I21F11 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, x, x); }
        public readonly Vector3I21F11 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, x, y); }
        public readonly Vector3I21F11 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, x, z); }
        public readonly Vector3I21F11 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, x, w); }
        public readonly Vector3I21F11 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, y, x); }
        public readonly Vector3I21F11 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, y, y); }
        public readonly Vector3I21F11 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, y, z); }
        public readonly Vector3I21F11 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, y, w); }
        public readonly Vector3I21F11 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, z, x); }
        public readonly Vector3I21F11 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, z, y); }
        public readonly Vector3I21F11 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, z, z); }
        public readonly Vector3I21F11 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, z, w); }
        public readonly Vector3I21F11 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, w, x); }
        public readonly Vector3I21F11 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, w, y); }
        public readonly Vector3I21F11 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, w, z); }
        public readonly Vector3I21F11 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, w, w); }
        public readonly Vector3I21F11 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, x, x); }
        public readonly Vector3I21F11 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, x, y); }
        public readonly Vector3I21F11 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, x, z); }
        public readonly Vector3I21F11 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, x, w); }
        public readonly Vector3I21F11 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, y, x); }
        public readonly Vector3I21F11 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, y, y); }
        public readonly Vector3I21F11 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, y, z); }
        public readonly Vector3I21F11 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, y, w); }
        public readonly Vector3I21F11 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, z, x); }
        public readonly Vector3I21F11 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, z, y); }
        public readonly Vector3I21F11 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, z, z); }
        public readonly Vector3I21F11 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, z, w); }
        public readonly Vector3I21F11 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, w, x); }
        public readonly Vector3I21F11 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, w, y); }
        public readonly Vector3I21F11 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, w, z); }
        public readonly Vector3I21F11 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(w, w, w); }
        public readonly Vector4I21F11 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, x, x); }
        public readonly Vector4I21F11 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, x, y); }
        public readonly Vector4I21F11 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, x, z); }
        public readonly Vector4I21F11 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, x, w); }
        public readonly Vector4I21F11 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, y, x); }
        public readonly Vector4I21F11 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, y, y); }
        public readonly Vector4I21F11 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, y, z); }
        public readonly Vector4I21F11 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, y, w); }
        public readonly Vector4I21F11 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, z, x); }
        public readonly Vector4I21F11 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, z, y); }
        public readonly Vector4I21F11 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, z, z); }
        public readonly Vector4I21F11 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, z, w); }
        public readonly Vector4I21F11 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, w, x); }
        public readonly Vector4I21F11 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, w, y); }
        public readonly Vector4I21F11 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, w, z); }
        public readonly Vector4I21F11 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, w, w); }
        public readonly Vector4I21F11 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, x, x); }
        public readonly Vector4I21F11 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, x, y); }
        public readonly Vector4I21F11 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, x, z); }
        public readonly Vector4I21F11 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, x, w); }
        public readonly Vector4I21F11 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, y, x); }
        public readonly Vector4I21F11 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, y, y); }
        public readonly Vector4I21F11 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, y, z); }
        public readonly Vector4I21F11 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, y, w); }
        public readonly Vector4I21F11 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, z, x); }
        public readonly Vector4I21F11 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, z, y); }
        public readonly Vector4I21F11 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, z, z); }
        public readonly Vector4I21F11 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, z, w); }
        public readonly Vector4I21F11 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, w, x); }
        public readonly Vector4I21F11 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, w, y); }
        public readonly Vector4I21F11 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, w, z); }
        public readonly Vector4I21F11 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, w, w); }
        public readonly Vector4I21F11 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, x, x); }
        public readonly Vector4I21F11 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, x, y); }
        public readonly Vector4I21F11 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, x, z); }
        public readonly Vector4I21F11 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, x, w); }
        public readonly Vector4I21F11 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, y, x); }
        public readonly Vector4I21F11 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, y, y); }
        public readonly Vector4I21F11 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, y, z); }
        public readonly Vector4I21F11 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, y, w); }
        public readonly Vector4I21F11 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, z, x); }
        public readonly Vector4I21F11 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, z, y); }
        public readonly Vector4I21F11 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, z, z); }
        public readonly Vector4I21F11 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, z, w); }
        public readonly Vector4I21F11 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, w, x); }
        public readonly Vector4I21F11 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, w, y); }
        public readonly Vector4I21F11 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, w, z); }
        public readonly Vector4I21F11 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, w, w); }
        public readonly Vector4I21F11 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, x, x); }
        public readonly Vector4I21F11 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, x, y); }
        public readonly Vector4I21F11 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, x, z); }
        public readonly Vector4I21F11 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, x, w); }
        public readonly Vector4I21F11 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, y, x); }
        public readonly Vector4I21F11 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, y, y); }
        public readonly Vector4I21F11 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, y, z); }
        public readonly Vector4I21F11 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, y, w); }
        public readonly Vector4I21F11 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, z, x); }
        public readonly Vector4I21F11 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, z, y); }
        public readonly Vector4I21F11 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, z, z); }
        public readonly Vector4I21F11 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, z, w); }
        public readonly Vector4I21F11 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, w, x); }
        public readonly Vector4I21F11 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, w, y); }
        public readonly Vector4I21F11 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, w, z); }
        public readonly Vector4I21F11 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, w, w, w); }
        public readonly Vector4I21F11 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, x, x); }
        public readonly Vector4I21F11 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, x, y); }
        public readonly Vector4I21F11 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, x, z); }
        public readonly Vector4I21F11 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, x, w); }
        public readonly Vector4I21F11 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, y, x); }
        public readonly Vector4I21F11 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, y, y); }
        public readonly Vector4I21F11 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, y, z); }
        public readonly Vector4I21F11 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, y, w); }
        public readonly Vector4I21F11 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, z, x); }
        public readonly Vector4I21F11 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, z, y); }
        public readonly Vector4I21F11 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, z, z); }
        public readonly Vector4I21F11 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, z, w); }
        public readonly Vector4I21F11 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, w, x); }
        public readonly Vector4I21F11 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, w, y); }
        public readonly Vector4I21F11 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, w, z); }
        public readonly Vector4I21F11 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, w, w); }
        public readonly Vector4I21F11 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, x, x); }
        public readonly Vector4I21F11 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, x, y); }
        public readonly Vector4I21F11 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, x, z); }
        public readonly Vector4I21F11 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, x, w); }
        public readonly Vector4I21F11 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, y, x); }
        public readonly Vector4I21F11 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, y, y); }
        public readonly Vector4I21F11 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, y, z); }
        public readonly Vector4I21F11 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, y, w); }
        public readonly Vector4I21F11 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, z, x); }
        public readonly Vector4I21F11 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, z, y); }
        public readonly Vector4I21F11 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, z, z); }
        public readonly Vector4I21F11 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, z, w); }
        public readonly Vector4I21F11 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, w, x); }
        public readonly Vector4I21F11 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, w, y); }
        public readonly Vector4I21F11 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, w, z); }
        public readonly Vector4I21F11 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, w, w); }
        public readonly Vector4I21F11 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, x, x); }
        public readonly Vector4I21F11 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, x, y); }
        public readonly Vector4I21F11 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, x, z); }
        public readonly Vector4I21F11 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, x, w); }
        public readonly Vector4I21F11 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, y, x); }
        public readonly Vector4I21F11 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, y, y); }
        public readonly Vector4I21F11 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, y, z); }
        public readonly Vector4I21F11 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, y, w); }
        public readonly Vector4I21F11 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, z, x); }
        public readonly Vector4I21F11 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, z, y); }
        public readonly Vector4I21F11 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, z, z); }
        public readonly Vector4I21F11 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, z, w); }
        public readonly Vector4I21F11 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, w, x); }
        public readonly Vector4I21F11 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, w, y); }
        public readonly Vector4I21F11 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, w, z); }
        public readonly Vector4I21F11 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, w, w); }
        public readonly Vector4I21F11 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, x, x); }
        public readonly Vector4I21F11 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, x, y); }
        public readonly Vector4I21F11 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, x, z); }
        public readonly Vector4I21F11 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, x, w); }
        public readonly Vector4I21F11 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, y, x); }
        public readonly Vector4I21F11 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, y, y); }
        public readonly Vector4I21F11 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, y, z); }
        public readonly Vector4I21F11 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, y, w); }
        public readonly Vector4I21F11 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, z, x); }
        public readonly Vector4I21F11 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, z, y); }
        public readonly Vector4I21F11 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, z, z); }
        public readonly Vector4I21F11 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, z, w); }
        public readonly Vector4I21F11 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, w, x); }
        public readonly Vector4I21F11 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, w, y); }
        public readonly Vector4I21F11 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, w, z); }
        public readonly Vector4I21F11 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, w, w, w); }
        public readonly Vector4I21F11 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, x, x); }
        public readonly Vector4I21F11 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, x, y); }
        public readonly Vector4I21F11 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, x, z); }
        public readonly Vector4I21F11 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, x, w); }
        public readonly Vector4I21F11 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, y, x); }
        public readonly Vector4I21F11 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, y, y); }
        public readonly Vector4I21F11 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, y, z); }
        public readonly Vector4I21F11 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, y, w); }
        public readonly Vector4I21F11 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, z, x); }
        public readonly Vector4I21F11 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, z, y); }
        public readonly Vector4I21F11 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, z, z); }
        public readonly Vector4I21F11 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, z, w); }
        public readonly Vector4I21F11 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, w, x); }
        public readonly Vector4I21F11 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, w, y); }
        public readonly Vector4I21F11 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, w, z); }
        public readonly Vector4I21F11 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, w, w); }
        public readonly Vector4I21F11 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, x, x); }
        public readonly Vector4I21F11 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, x, y); }
        public readonly Vector4I21F11 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, x, z); }
        public readonly Vector4I21F11 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, x, w); }
        public readonly Vector4I21F11 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, y, x); }
        public readonly Vector4I21F11 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, y, y); }
        public readonly Vector4I21F11 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, y, z); }
        public readonly Vector4I21F11 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, y, w); }
        public readonly Vector4I21F11 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, z, x); }
        public readonly Vector4I21F11 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, z, y); }
        public readonly Vector4I21F11 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, z, z); }
        public readonly Vector4I21F11 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, z, w); }
        public readonly Vector4I21F11 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, w, x); }
        public readonly Vector4I21F11 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, w, y); }
        public readonly Vector4I21F11 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, w, z); }
        public readonly Vector4I21F11 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, w, w); }
        public readonly Vector4I21F11 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, x, x); }
        public readonly Vector4I21F11 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, x, y); }
        public readonly Vector4I21F11 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, x, z); }
        public readonly Vector4I21F11 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, x, w); }
        public readonly Vector4I21F11 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, y, x); }
        public readonly Vector4I21F11 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, y, y); }
        public readonly Vector4I21F11 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, y, z); }
        public readonly Vector4I21F11 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, y, w); }
        public readonly Vector4I21F11 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, z, x); }
        public readonly Vector4I21F11 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, z, y); }
        public readonly Vector4I21F11 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, z, z); }
        public readonly Vector4I21F11 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, z, w); }
        public readonly Vector4I21F11 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, w, x); }
        public readonly Vector4I21F11 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, w, y); }
        public readonly Vector4I21F11 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, w, z); }
        public readonly Vector4I21F11 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, w, w); }
        public readonly Vector4I21F11 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, x, x); }
        public readonly Vector4I21F11 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, x, y); }
        public readonly Vector4I21F11 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, x, z); }
        public readonly Vector4I21F11 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, x, w); }
        public readonly Vector4I21F11 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, y, x); }
        public readonly Vector4I21F11 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, y, y); }
        public readonly Vector4I21F11 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, y, z); }
        public readonly Vector4I21F11 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, y, w); }
        public readonly Vector4I21F11 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, z, x); }
        public readonly Vector4I21F11 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, z, y); }
        public readonly Vector4I21F11 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, z, z); }
        public readonly Vector4I21F11 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, z, w); }
        public readonly Vector4I21F11 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, w, x); }
        public readonly Vector4I21F11 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, w, y); }
        public readonly Vector4I21F11 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, w, z); }
        public readonly Vector4I21F11 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, w, w, w); }
        public readonly Vector4I21F11 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, x, x); }
        public readonly Vector4I21F11 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, x, y); }
        public readonly Vector4I21F11 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, x, z); }
        public readonly Vector4I21F11 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, x, w); }
        public readonly Vector4I21F11 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, y, x); }
        public readonly Vector4I21F11 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, y, y); }
        public readonly Vector4I21F11 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, y, z); }
        public readonly Vector4I21F11 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, y, w); }
        public readonly Vector4I21F11 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, z, x); }
        public readonly Vector4I21F11 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, z, y); }
        public readonly Vector4I21F11 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, z, z); }
        public readonly Vector4I21F11 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, z, w); }
        public readonly Vector4I21F11 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, w, x); }
        public readonly Vector4I21F11 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, w, y); }
        public readonly Vector4I21F11 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, w, z); }
        public readonly Vector4I21F11 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, x, w, w); }
        public readonly Vector4I21F11 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, x, x); }
        public readonly Vector4I21F11 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, x, y); }
        public readonly Vector4I21F11 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, x, z); }
        public readonly Vector4I21F11 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, x, w); }
        public readonly Vector4I21F11 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, y, x); }
        public readonly Vector4I21F11 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, y, y); }
        public readonly Vector4I21F11 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, y, z); }
        public readonly Vector4I21F11 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, y, w); }
        public readonly Vector4I21F11 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, z, x); }
        public readonly Vector4I21F11 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, z, y); }
        public readonly Vector4I21F11 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, z, z); }
        public readonly Vector4I21F11 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, z, w); }
        public readonly Vector4I21F11 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, w, x); }
        public readonly Vector4I21F11 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, w, y); }
        public readonly Vector4I21F11 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, w, z); }
        public readonly Vector4I21F11 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, y, w, w); }
        public readonly Vector4I21F11 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, x, x); }
        public readonly Vector4I21F11 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, x, y); }
        public readonly Vector4I21F11 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, x, z); }
        public readonly Vector4I21F11 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, x, w); }
        public readonly Vector4I21F11 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, y, x); }
        public readonly Vector4I21F11 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, y, y); }
        public readonly Vector4I21F11 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, y, z); }
        public readonly Vector4I21F11 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, y, w); }
        public readonly Vector4I21F11 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, z, x); }
        public readonly Vector4I21F11 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, z, y); }
        public readonly Vector4I21F11 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, z, z); }
        public readonly Vector4I21F11 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, z, w); }
        public readonly Vector4I21F11 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, w, x); }
        public readonly Vector4I21F11 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, w, y); }
        public readonly Vector4I21F11 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, w, z); }
        public readonly Vector4I21F11 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, z, w, w); }
        public readonly Vector4I21F11 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, x, x); }
        public readonly Vector4I21F11 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, x, y); }
        public readonly Vector4I21F11 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, x, z); }
        public readonly Vector4I21F11 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, x, w); }
        public readonly Vector4I21F11 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, y, x); }
        public readonly Vector4I21F11 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, y, y); }
        public readonly Vector4I21F11 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, y, z); }
        public readonly Vector4I21F11 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, y, w); }
        public readonly Vector4I21F11 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, z, x); }
        public readonly Vector4I21F11 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, z, y); }
        public readonly Vector4I21F11 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, z, z); }
        public readonly Vector4I21F11 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, z, w); }
        public readonly Vector4I21F11 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, w, x); }
        public readonly Vector4I21F11 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, w, y); }
        public readonly Vector4I21F11 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, w, z); }
        public readonly Vector4I21F11 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I21F11 lhs, Vector4I21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I21F11 lhs, Vector4I21F11 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I21F11({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I21F11 other)
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
            return $"Vector4I21F11({x}, {y}, {z}, {w})";
        }
    }
}
