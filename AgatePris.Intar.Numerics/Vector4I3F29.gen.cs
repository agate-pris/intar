using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I3F29 : IEquatable<Vector4I3F29>, IFormattable {
        // Fields
        // ---------------------------------------

        public I3F29 x;
        public I3F29 y;
        public I3F29 z;
        public I3F29 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I3F29 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I3F29(I3F29 x, I3F29 y, I3F29 z, I3F29 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I3F29(I3F29 x, I3F29 y, Vector2I3F29 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I3F29(I3F29 x, Vector3I3F29 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I3F29(Vector2I3F29 xy, Vector2I3F29 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I3F29(Vector4I3F29 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I3F29(I3F29 x, Vector2I3F29 yz, I3F29 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I3F29(Vector3I3F29 xyz, I3F29 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I3F29(Vector2I3F29 xy, I3F29 z, I3F29 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 operator +(Vector4I3F29 a, Vector4I3F29 b) => new Vector4I3F29(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 operator -(Vector4I3F29 a, Vector4I3F29 b) => new Vector4I3F29(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 operator *(Vector4I3F29 a, Vector4I3F29 b) => new Vector4I3F29(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 operator *(Vector4I3F29 a, I3F29 b) => new Vector4I3F29(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 operator *(I3F29 a, Vector4I3F29 b) => new Vector4I3F29(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 operator /(Vector4I3F29 a, Vector4I3F29 b) => new Vector4I3F29(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 operator /(Vector4I3F29 a, I3F29 b) => new Vector4I3F29(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 operator /(I3F29 a, Vector4I3F29 b) => new Vector4I3F29(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I3F29 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(x, x); }
        public readonly Vector2I3F29 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(x, y); }
        public readonly Vector2I3F29 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(x, z); }
        public readonly Vector2I3F29 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(x, w); }
        public readonly Vector2I3F29 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(y, x); }
        public readonly Vector2I3F29 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(y, y); }
        public readonly Vector2I3F29 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(y, z); }
        public readonly Vector2I3F29 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(y, w); }
        public readonly Vector2I3F29 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(z, x); }
        public readonly Vector2I3F29 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(z, y); }
        public readonly Vector2I3F29 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(z, z); }
        public readonly Vector2I3F29 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(z, w); }
        public readonly Vector2I3F29 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(w, x); }
        public readonly Vector2I3F29 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(w, y); }
        public readonly Vector2I3F29 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(w, z); }
        public readonly Vector2I3F29 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(w, w); }
        public readonly Vector3I3F29 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, x, x); }
        public readonly Vector3I3F29 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, x, y); }
        public readonly Vector3I3F29 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, x, z); }
        public readonly Vector3I3F29 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, x, w); }
        public readonly Vector3I3F29 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, y, x); }
        public readonly Vector3I3F29 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, y, y); }
        public readonly Vector3I3F29 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, y, z); }
        public readonly Vector3I3F29 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, y, w); }
        public readonly Vector3I3F29 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, z, x); }
        public readonly Vector3I3F29 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, z, y); }
        public readonly Vector3I3F29 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, z, z); }
        public readonly Vector3I3F29 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, z, w); }
        public readonly Vector3I3F29 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, w, x); }
        public readonly Vector3I3F29 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, w, y); }
        public readonly Vector3I3F29 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, w, z); }
        public readonly Vector3I3F29 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, w, w); }
        public readonly Vector3I3F29 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, x, x); }
        public readonly Vector3I3F29 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, x, y); }
        public readonly Vector3I3F29 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, x, z); }
        public readonly Vector3I3F29 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, x, w); }
        public readonly Vector3I3F29 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, y, x); }
        public readonly Vector3I3F29 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, y, y); }
        public readonly Vector3I3F29 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, y, z); }
        public readonly Vector3I3F29 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, y, w); }
        public readonly Vector3I3F29 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, z, x); }
        public readonly Vector3I3F29 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, z, y); }
        public readonly Vector3I3F29 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, z, z); }
        public readonly Vector3I3F29 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, z, w); }
        public readonly Vector3I3F29 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, w, x); }
        public readonly Vector3I3F29 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, w, y); }
        public readonly Vector3I3F29 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, w, z); }
        public readonly Vector3I3F29 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, w, w); }
        public readonly Vector3I3F29 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, x, x); }
        public readonly Vector3I3F29 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, x, y); }
        public readonly Vector3I3F29 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, x, z); }
        public readonly Vector3I3F29 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, x, w); }
        public readonly Vector3I3F29 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, y, x); }
        public readonly Vector3I3F29 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, y, y); }
        public readonly Vector3I3F29 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, y, z); }
        public readonly Vector3I3F29 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, y, w); }
        public readonly Vector3I3F29 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, z, x); }
        public readonly Vector3I3F29 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, z, y); }
        public readonly Vector3I3F29 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, z, z); }
        public readonly Vector3I3F29 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, z, w); }
        public readonly Vector3I3F29 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, w, x); }
        public readonly Vector3I3F29 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, w, y); }
        public readonly Vector3I3F29 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, w, z); }
        public readonly Vector3I3F29 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, w, w); }
        public readonly Vector3I3F29 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, x, x); }
        public readonly Vector3I3F29 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, x, y); }
        public readonly Vector3I3F29 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, x, z); }
        public readonly Vector3I3F29 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, x, w); }
        public readonly Vector3I3F29 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, y, x); }
        public readonly Vector3I3F29 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, y, y); }
        public readonly Vector3I3F29 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, y, z); }
        public readonly Vector3I3F29 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, y, w); }
        public readonly Vector3I3F29 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, z, x); }
        public readonly Vector3I3F29 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, z, y); }
        public readonly Vector3I3F29 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, z, z); }
        public readonly Vector3I3F29 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, z, w); }
        public readonly Vector3I3F29 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, w, x); }
        public readonly Vector3I3F29 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, w, y); }
        public readonly Vector3I3F29 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, w, z); }
        public readonly Vector3I3F29 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(w, w, w); }
        public readonly Vector4I3F29 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, x, x); }
        public readonly Vector4I3F29 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, x, y); }
        public readonly Vector4I3F29 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, x, z); }
        public readonly Vector4I3F29 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, x, w); }
        public readonly Vector4I3F29 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, y, x); }
        public readonly Vector4I3F29 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, y, y); }
        public readonly Vector4I3F29 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, y, z); }
        public readonly Vector4I3F29 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, y, w); }
        public readonly Vector4I3F29 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, z, x); }
        public readonly Vector4I3F29 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, z, y); }
        public readonly Vector4I3F29 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, z, z); }
        public readonly Vector4I3F29 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, z, w); }
        public readonly Vector4I3F29 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, w, x); }
        public readonly Vector4I3F29 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, w, y); }
        public readonly Vector4I3F29 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, w, z); }
        public readonly Vector4I3F29 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, w, w); }
        public readonly Vector4I3F29 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, x, x); }
        public readonly Vector4I3F29 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, x, y); }
        public readonly Vector4I3F29 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, x, z); }
        public readonly Vector4I3F29 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, x, w); }
        public readonly Vector4I3F29 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, y, x); }
        public readonly Vector4I3F29 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, y, y); }
        public readonly Vector4I3F29 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, y, z); }
        public readonly Vector4I3F29 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, y, w); }
        public readonly Vector4I3F29 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, z, x); }
        public readonly Vector4I3F29 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, z, y); }
        public readonly Vector4I3F29 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, z, z); }
        public readonly Vector4I3F29 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, z, w); }
        public readonly Vector4I3F29 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, w, x); }
        public readonly Vector4I3F29 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, w, y); }
        public readonly Vector4I3F29 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, w, z); }
        public readonly Vector4I3F29 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, w, w); }
        public readonly Vector4I3F29 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, x, x); }
        public readonly Vector4I3F29 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, x, y); }
        public readonly Vector4I3F29 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, x, z); }
        public readonly Vector4I3F29 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, x, w); }
        public readonly Vector4I3F29 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, y, x); }
        public readonly Vector4I3F29 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, y, y); }
        public readonly Vector4I3F29 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, y, z); }
        public readonly Vector4I3F29 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, y, w); }
        public readonly Vector4I3F29 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, z, x); }
        public readonly Vector4I3F29 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, z, y); }
        public readonly Vector4I3F29 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, z, z); }
        public readonly Vector4I3F29 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, z, w); }
        public readonly Vector4I3F29 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, w, x); }
        public readonly Vector4I3F29 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, w, y); }
        public readonly Vector4I3F29 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, w, z); }
        public readonly Vector4I3F29 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, w, w); }
        public readonly Vector4I3F29 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, x, x); }
        public readonly Vector4I3F29 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, x, y); }
        public readonly Vector4I3F29 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, x, z); }
        public readonly Vector4I3F29 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, x, w); }
        public readonly Vector4I3F29 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, y, x); }
        public readonly Vector4I3F29 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, y, y); }
        public readonly Vector4I3F29 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, y, z); }
        public readonly Vector4I3F29 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, y, w); }
        public readonly Vector4I3F29 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, z, x); }
        public readonly Vector4I3F29 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, z, y); }
        public readonly Vector4I3F29 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, z, z); }
        public readonly Vector4I3F29 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, z, w); }
        public readonly Vector4I3F29 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, w, x); }
        public readonly Vector4I3F29 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, w, y); }
        public readonly Vector4I3F29 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, w, z); }
        public readonly Vector4I3F29 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, w, w, w); }
        public readonly Vector4I3F29 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, x, x); }
        public readonly Vector4I3F29 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, x, y); }
        public readonly Vector4I3F29 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, x, z); }
        public readonly Vector4I3F29 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, x, w); }
        public readonly Vector4I3F29 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, y, x); }
        public readonly Vector4I3F29 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, y, y); }
        public readonly Vector4I3F29 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, y, z); }
        public readonly Vector4I3F29 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, y, w); }
        public readonly Vector4I3F29 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, z, x); }
        public readonly Vector4I3F29 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, z, y); }
        public readonly Vector4I3F29 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, z, z); }
        public readonly Vector4I3F29 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, z, w); }
        public readonly Vector4I3F29 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, w, x); }
        public readonly Vector4I3F29 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, w, y); }
        public readonly Vector4I3F29 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, w, z); }
        public readonly Vector4I3F29 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, w, w); }
        public readonly Vector4I3F29 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, x, x); }
        public readonly Vector4I3F29 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, x, y); }
        public readonly Vector4I3F29 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, x, z); }
        public readonly Vector4I3F29 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, x, w); }
        public readonly Vector4I3F29 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, y, x); }
        public readonly Vector4I3F29 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, y, y); }
        public readonly Vector4I3F29 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, y, z); }
        public readonly Vector4I3F29 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, y, w); }
        public readonly Vector4I3F29 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, z, x); }
        public readonly Vector4I3F29 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, z, y); }
        public readonly Vector4I3F29 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, z, z); }
        public readonly Vector4I3F29 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, z, w); }
        public readonly Vector4I3F29 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, w, x); }
        public readonly Vector4I3F29 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, w, y); }
        public readonly Vector4I3F29 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, w, z); }
        public readonly Vector4I3F29 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, w, w); }
        public readonly Vector4I3F29 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, x, x); }
        public readonly Vector4I3F29 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, x, y); }
        public readonly Vector4I3F29 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, x, z); }
        public readonly Vector4I3F29 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, x, w); }
        public readonly Vector4I3F29 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, y, x); }
        public readonly Vector4I3F29 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, y, y); }
        public readonly Vector4I3F29 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, y, z); }
        public readonly Vector4I3F29 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, y, w); }
        public readonly Vector4I3F29 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, z, x); }
        public readonly Vector4I3F29 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, z, y); }
        public readonly Vector4I3F29 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, z, z); }
        public readonly Vector4I3F29 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, z, w); }
        public readonly Vector4I3F29 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, w, x); }
        public readonly Vector4I3F29 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, w, y); }
        public readonly Vector4I3F29 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, w, z); }
        public readonly Vector4I3F29 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, w, w); }
        public readonly Vector4I3F29 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, x, x); }
        public readonly Vector4I3F29 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, x, y); }
        public readonly Vector4I3F29 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, x, z); }
        public readonly Vector4I3F29 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, x, w); }
        public readonly Vector4I3F29 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, y, x); }
        public readonly Vector4I3F29 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, y, y); }
        public readonly Vector4I3F29 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, y, z); }
        public readonly Vector4I3F29 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, y, w); }
        public readonly Vector4I3F29 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, z, x); }
        public readonly Vector4I3F29 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, z, y); }
        public readonly Vector4I3F29 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, z, z); }
        public readonly Vector4I3F29 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, z, w); }
        public readonly Vector4I3F29 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, w, x); }
        public readonly Vector4I3F29 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, w, y); }
        public readonly Vector4I3F29 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, w, z); }
        public readonly Vector4I3F29 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, w, w, w); }
        public readonly Vector4I3F29 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, x, x); }
        public readonly Vector4I3F29 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, x, y); }
        public readonly Vector4I3F29 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, x, z); }
        public readonly Vector4I3F29 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, x, w); }
        public readonly Vector4I3F29 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, y, x); }
        public readonly Vector4I3F29 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, y, y); }
        public readonly Vector4I3F29 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, y, z); }
        public readonly Vector4I3F29 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, y, w); }
        public readonly Vector4I3F29 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, z, x); }
        public readonly Vector4I3F29 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, z, y); }
        public readonly Vector4I3F29 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, z, z); }
        public readonly Vector4I3F29 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, z, w); }
        public readonly Vector4I3F29 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, w, x); }
        public readonly Vector4I3F29 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, w, y); }
        public readonly Vector4I3F29 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, w, z); }
        public readonly Vector4I3F29 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, w, w); }
        public readonly Vector4I3F29 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, x, x); }
        public readonly Vector4I3F29 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, x, y); }
        public readonly Vector4I3F29 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, x, z); }
        public readonly Vector4I3F29 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, x, w); }
        public readonly Vector4I3F29 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, y, x); }
        public readonly Vector4I3F29 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, y, y); }
        public readonly Vector4I3F29 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, y, z); }
        public readonly Vector4I3F29 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, y, w); }
        public readonly Vector4I3F29 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, z, x); }
        public readonly Vector4I3F29 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, z, y); }
        public readonly Vector4I3F29 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, z, z); }
        public readonly Vector4I3F29 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, z, w); }
        public readonly Vector4I3F29 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, w, x); }
        public readonly Vector4I3F29 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, w, y); }
        public readonly Vector4I3F29 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, w, z); }
        public readonly Vector4I3F29 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, w, w); }
        public readonly Vector4I3F29 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, x, x); }
        public readonly Vector4I3F29 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, x, y); }
        public readonly Vector4I3F29 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, x, z); }
        public readonly Vector4I3F29 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, x, w); }
        public readonly Vector4I3F29 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, y, x); }
        public readonly Vector4I3F29 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, y, y); }
        public readonly Vector4I3F29 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, y, z); }
        public readonly Vector4I3F29 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, y, w); }
        public readonly Vector4I3F29 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, z, x); }
        public readonly Vector4I3F29 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, z, y); }
        public readonly Vector4I3F29 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, z, z); }
        public readonly Vector4I3F29 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, z, w); }
        public readonly Vector4I3F29 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, w, x); }
        public readonly Vector4I3F29 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, w, y); }
        public readonly Vector4I3F29 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, w, z); }
        public readonly Vector4I3F29 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, w, w); }
        public readonly Vector4I3F29 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, x, x); }
        public readonly Vector4I3F29 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, x, y); }
        public readonly Vector4I3F29 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, x, z); }
        public readonly Vector4I3F29 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, x, w); }
        public readonly Vector4I3F29 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, y, x); }
        public readonly Vector4I3F29 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, y, y); }
        public readonly Vector4I3F29 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, y, z); }
        public readonly Vector4I3F29 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, y, w); }
        public readonly Vector4I3F29 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, z, x); }
        public readonly Vector4I3F29 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, z, y); }
        public readonly Vector4I3F29 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, z, z); }
        public readonly Vector4I3F29 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, z, w); }
        public readonly Vector4I3F29 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, w, x); }
        public readonly Vector4I3F29 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, w, y); }
        public readonly Vector4I3F29 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, w, z); }
        public readonly Vector4I3F29 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, w, w, w); }
        public readonly Vector4I3F29 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, x, x); }
        public readonly Vector4I3F29 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, x, y); }
        public readonly Vector4I3F29 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, x, z); }
        public readonly Vector4I3F29 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, x, w); }
        public readonly Vector4I3F29 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, y, x); }
        public readonly Vector4I3F29 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, y, y); }
        public readonly Vector4I3F29 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, y, z); }
        public readonly Vector4I3F29 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, y, w); }
        public readonly Vector4I3F29 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, z, x); }
        public readonly Vector4I3F29 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, z, y); }
        public readonly Vector4I3F29 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, z, z); }
        public readonly Vector4I3F29 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, z, w); }
        public readonly Vector4I3F29 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, w, x); }
        public readonly Vector4I3F29 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, w, y); }
        public readonly Vector4I3F29 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, w, z); }
        public readonly Vector4I3F29 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, x, w, w); }
        public readonly Vector4I3F29 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, x, x); }
        public readonly Vector4I3F29 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, x, y); }
        public readonly Vector4I3F29 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, x, z); }
        public readonly Vector4I3F29 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, x, w); }
        public readonly Vector4I3F29 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, y, x); }
        public readonly Vector4I3F29 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, y, y); }
        public readonly Vector4I3F29 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, y, z); }
        public readonly Vector4I3F29 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, y, w); }
        public readonly Vector4I3F29 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, z, x); }
        public readonly Vector4I3F29 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, z, y); }
        public readonly Vector4I3F29 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, z, z); }
        public readonly Vector4I3F29 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, z, w); }
        public readonly Vector4I3F29 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, w, x); }
        public readonly Vector4I3F29 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, w, y); }
        public readonly Vector4I3F29 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, w, z); }
        public readonly Vector4I3F29 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, y, w, w); }
        public readonly Vector4I3F29 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, x, x); }
        public readonly Vector4I3F29 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, x, y); }
        public readonly Vector4I3F29 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, x, z); }
        public readonly Vector4I3F29 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, x, w); }
        public readonly Vector4I3F29 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, y, x); }
        public readonly Vector4I3F29 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, y, y); }
        public readonly Vector4I3F29 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, y, z); }
        public readonly Vector4I3F29 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, y, w); }
        public readonly Vector4I3F29 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, z, x); }
        public readonly Vector4I3F29 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, z, y); }
        public readonly Vector4I3F29 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, z, z); }
        public readonly Vector4I3F29 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, z, w); }
        public readonly Vector4I3F29 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, w, x); }
        public readonly Vector4I3F29 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, w, y); }
        public readonly Vector4I3F29 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, w, z); }
        public readonly Vector4I3F29 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, z, w, w); }
        public readonly Vector4I3F29 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, x, x); }
        public readonly Vector4I3F29 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, x, y); }
        public readonly Vector4I3F29 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, x, z); }
        public readonly Vector4I3F29 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, x, w); }
        public readonly Vector4I3F29 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, y, x); }
        public readonly Vector4I3F29 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, y, y); }
        public readonly Vector4I3F29 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, y, z); }
        public readonly Vector4I3F29 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, y, w); }
        public readonly Vector4I3F29 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, z, x); }
        public readonly Vector4I3F29 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, z, y); }
        public readonly Vector4I3F29 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, z, z); }
        public readonly Vector4I3F29 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, z, w); }
        public readonly Vector4I3F29 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, w, x); }
        public readonly Vector4I3F29 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, w, y); }
        public readonly Vector4I3F29 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, w, z); }
        public readonly Vector4I3F29 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I3F29 lhs, Vector4I3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I3F29 lhs, Vector4I3F29 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I3F29({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I3F29 other)
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
            return $"Vector4I3F29({x}, {y}, {z}, {w})";
        }
    }
}
