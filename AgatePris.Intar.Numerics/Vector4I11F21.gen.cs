using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I11F21 : IEquatable<Vector4I11F21>, IFormattable {
        // Fields
        // ---------------------------------------

        public I11F21 x;
        public I11F21 y;
        public I11F21 z;
        public I11F21 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I11F21 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(I11F21 x, I11F21 y, I11F21 z, I11F21 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(I11F21 x, I11F21 y, Vector2I11F21 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(I11F21 x, Vector3I11F21 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(Vector2I11F21 xy, Vector2I11F21 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(Vector4I11F21 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(I11F21 x, Vector2I11F21 yz, I11F21 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(Vector3I11F21 xyz, I11F21 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(Vector2I11F21 xy, I11F21 z, I11F21 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator +(Vector4I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator -(Vector4I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator *(Vector4I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator *(Vector4I11F21 a, I11F21 b) => new Vector4I11F21(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator *(I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator /(Vector4I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator /(Vector4I11F21 a, I11F21 b) => new Vector4I11F21(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator /(I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I11F21 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(x, x); }
        public readonly Vector2I11F21 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(x, y); }
        public readonly Vector2I11F21 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(x, z); }
        public readonly Vector2I11F21 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(x, w); }
        public readonly Vector2I11F21 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(y, x); }
        public readonly Vector2I11F21 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(y, y); }
        public readonly Vector2I11F21 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(y, z); }
        public readonly Vector2I11F21 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(y, w); }
        public readonly Vector2I11F21 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(z, x); }
        public readonly Vector2I11F21 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(z, y); }
        public readonly Vector2I11F21 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(z, z); }
        public readonly Vector2I11F21 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(z, w); }
        public readonly Vector2I11F21 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(w, x); }
        public readonly Vector2I11F21 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(w, y); }
        public readonly Vector2I11F21 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(w, z); }
        public readonly Vector2I11F21 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(w, w); }
        public readonly Vector3I11F21 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, x, x); }
        public readonly Vector3I11F21 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, x, y); }
        public readonly Vector3I11F21 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, x, z); }
        public readonly Vector3I11F21 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, x, w); }
        public readonly Vector3I11F21 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, y, x); }
        public readonly Vector3I11F21 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, y, y); }
        public readonly Vector3I11F21 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, y, z); }
        public readonly Vector3I11F21 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, y, w); }
        public readonly Vector3I11F21 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, z, x); }
        public readonly Vector3I11F21 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, z, y); }
        public readonly Vector3I11F21 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, z, z); }
        public readonly Vector3I11F21 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, z, w); }
        public readonly Vector3I11F21 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, w, x); }
        public readonly Vector3I11F21 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, w, y); }
        public readonly Vector3I11F21 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, w, z); }
        public readonly Vector3I11F21 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(x, w, w); }
        public readonly Vector3I11F21 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, x, x); }
        public readonly Vector3I11F21 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, x, y); }
        public readonly Vector3I11F21 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, x, z); }
        public readonly Vector3I11F21 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, x, w); }
        public readonly Vector3I11F21 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, y, x); }
        public readonly Vector3I11F21 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, y, y); }
        public readonly Vector3I11F21 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, y, z); }
        public readonly Vector3I11F21 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, y, w); }
        public readonly Vector3I11F21 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, z, x); }
        public readonly Vector3I11F21 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, z, y); }
        public readonly Vector3I11F21 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, z, z); }
        public readonly Vector3I11F21 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, z, w); }
        public readonly Vector3I11F21 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, w, x); }
        public readonly Vector3I11F21 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, w, y); }
        public readonly Vector3I11F21 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, w, z); }
        public readonly Vector3I11F21 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(y, w, w); }
        public readonly Vector3I11F21 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, x, x); }
        public readonly Vector3I11F21 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, x, y); }
        public readonly Vector3I11F21 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, x, z); }
        public readonly Vector3I11F21 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, x, w); }
        public readonly Vector3I11F21 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, y, x); }
        public readonly Vector3I11F21 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, y, y); }
        public readonly Vector3I11F21 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, y, z); }
        public readonly Vector3I11F21 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, y, w); }
        public readonly Vector3I11F21 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, z, x); }
        public readonly Vector3I11F21 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, z, y); }
        public readonly Vector3I11F21 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, z, z); }
        public readonly Vector3I11F21 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, z, w); }
        public readonly Vector3I11F21 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, w, x); }
        public readonly Vector3I11F21 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, w, y); }
        public readonly Vector3I11F21 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, w, z); }
        public readonly Vector3I11F21 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(z, w, w); }
        public readonly Vector3I11F21 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, x, x); }
        public readonly Vector3I11F21 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, x, y); }
        public readonly Vector3I11F21 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, x, z); }
        public readonly Vector3I11F21 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, x, w); }
        public readonly Vector3I11F21 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, y, x); }
        public readonly Vector3I11F21 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, y, y); }
        public readonly Vector3I11F21 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, y, z); }
        public readonly Vector3I11F21 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, y, w); }
        public readonly Vector3I11F21 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, z, x); }
        public readonly Vector3I11F21 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, z, y); }
        public readonly Vector3I11F21 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, z, z); }
        public readonly Vector3I11F21 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, z, w); }
        public readonly Vector3I11F21 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, w, x); }
        public readonly Vector3I11F21 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, w, y); }
        public readonly Vector3I11F21 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, w, z); }
        public readonly Vector3I11F21 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(w, w, w); }
        public readonly Vector4I11F21 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, x, x); }
        public readonly Vector4I11F21 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, x, y); }
        public readonly Vector4I11F21 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, x, z); }
        public readonly Vector4I11F21 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, x, w); }
        public readonly Vector4I11F21 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, y, x); }
        public readonly Vector4I11F21 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, y, y); }
        public readonly Vector4I11F21 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, y, z); }
        public readonly Vector4I11F21 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, y, w); }
        public readonly Vector4I11F21 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, z, x); }
        public readonly Vector4I11F21 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, z, y); }
        public readonly Vector4I11F21 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, z, z); }
        public readonly Vector4I11F21 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, z, w); }
        public readonly Vector4I11F21 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, w, x); }
        public readonly Vector4I11F21 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, w, y); }
        public readonly Vector4I11F21 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, w, z); }
        public readonly Vector4I11F21 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, x, w, w); }
        public readonly Vector4I11F21 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, x, x); }
        public readonly Vector4I11F21 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, x, y); }
        public readonly Vector4I11F21 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, x, z); }
        public readonly Vector4I11F21 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, x, w); }
        public readonly Vector4I11F21 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, y, x); }
        public readonly Vector4I11F21 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, y, y); }
        public readonly Vector4I11F21 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, y, z); }
        public readonly Vector4I11F21 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, y, w); }
        public readonly Vector4I11F21 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, z, x); }
        public readonly Vector4I11F21 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, z, y); }
        public readonly Vector4I11F21 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, z, z); }
        public readonly Vector4I11F21 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, z, w); }
        public readonly Vector4I11F21 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, w, x); }
        public readonly Vector4I11F21 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, w, y); }
        public readonly Vector4I11F21 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, w, z); }
        public readonly Vector4I11F21 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, y, w, w); }
        public readonly Vector4I11F21 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, x, x); }
        public readonly Vector4I11F21 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, x, y); }
        public readonly Vector4I11F21 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, x, z); }
        public readonly Vector4I11F21 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, x, w); }
        public readonly Vector4I11F21 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, y, x); }
        public readonly Vector4I11F21 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, y, y); }
        public readonly Vector4I11F21 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, y, z); }
        public readonly Vector4I11F21 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, y, w); }
        public readonly Vector4I11F21 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, z, x); }
        public readonly Vector4I11F21 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, z, y); }
        public readonly Vector4I11F21 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, z, z); }
        public readonly Vector4I11F21 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, z, w); }
        public readonly Vector4I11F21 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, w, x); }
        public readonly Vector4I11F21 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, w, y); }
        public readonly Vector4I11F21 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, w, z); }
        public readonly Vector4I11F21 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, z, w, w); }
        public readonly Vector4I11F21 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, x, x); }
        public readonly Vector4I11F21 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, x, y); }
        public readonly Vector4I11F21 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, x, z); }
        public readonly Vector4I11F21 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, x, w); }
        public readonly Vector4I11F21 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, y, x); }
        public readonly Vector4I11F21 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, y, y); }
        public readonly Vector4I11F21 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, y, z); }
        public readonly Vector4I11F21 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, y, w); }
        public readonly Vector4I11F21 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, z, x); }
        public readonly Vector4I11F21 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, z, y); }
        public readonly Vector4I11F21 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, z, z); }
        public readonly Vector4I11F21 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, z, w); }
        public readonly Vector4I11F21 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, w, x); }
        public readonly Vector4I11F21 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, w, y); }
        public readonly Vector4I11F21 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, w, z); }
        public readonly Vector4I11F21 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(x, w, w, w); }
        public readonly Vector4I11F21 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, x, x); }
        public readonly Vector4I11F21 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, x, y); }
        public readonly Vector4I11F21 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, x, z); }
        public readonly Vector4I11F21 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, x, w); }
        public readonly Vector4I11F21 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, y, x); }
        public readonly Vector4I11F21 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, y, y); }
        public readonly Vector4I11F21 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, y, z); }
        public readonly Vector4I11F21 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, y, w); }
        public readonly Vector4I11F21 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, z, x); }
        public readonly Vector4I11F21 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, z, y); }
        public readonly Vector4I11F21 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, z, z); }
        public readonly Vector4I11F21 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, z, w); }
        public readonly Vector4I11F21 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, w, x); }
        public readonly Vector4I11F21 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, w, y); }
        public readonly Vector4I11F21 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, w, z); }
        public readonly Vector4I11F21 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, x, w, w); }
        public readonly Vector4I11F21 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, x, x); }
        public readonly Vector4I11F21 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, x, y); }
        public readonly Vector4I11F21 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, x, z); }
        public readonly Vector4I11F21 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, x, w); }
        public readonly Vector4I11F21 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, y, x); }
        public readonly Vector4I11F21 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, y, y); }
        public readonly Vector4I11F21 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, y, z); }
        public readonly Vector4I11F21 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, y, w); }
        public readonly Vector4I11F21 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, z, x); }
        public readonly Vector4I11F21 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, z, y); }
        public readonly Vector4I11F21 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, z, z); }
        public readonly Vector4I11F21 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, z, w); }
        public readonly Vector4I11F21 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, w, x); }
        public readonly Vector4I11F21 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, w, y); }
        public readonly Vector4I11F21 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, w, z); }
        public readonly Vector4I11F21 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, y, w, w); }
        public readonly Vector4I11F21 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, x, x); }
        public readonly Vector4I11F21 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, x, y); }
        public readonly Vector4I11F21 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, x, z); }
        public readonly Vector4I11F21 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, x, w); }
        public readonly Vector4I11F21 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, y, x); }
        public readonly Vector4I11F21 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, y, y); }
        public readonly Vector4I11F21 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, y, z); }
        public readonly Vector4I11F21 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, y, w); }
        public readonly Vector4I11F21 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, z, x); }
        public readonly Vector4I11F21 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, z, y); }
        public readonly Vector4I11F21 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, z, z); }
        public readonly Vector4I11F21 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, z, w); }
        public readonly Vector4I11F21 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, w, x); }
        public readonly Vector4I11F21 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, w, y); }
        public readonly Vector4I11F21 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, w, z); }
        public readonly Vector4I11F21 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, z, w, w); }
        public readonly Vector4I11F21 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, x, x); }
        public readonly Vector4I11F21 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, x, y); }
        public readonly Vector4I11F21 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, x, z); }
        public readonly Vector4I11F21 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, x, w); }
        public readonly Vector4I11F21 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, y, x); }
        public readonly Vector4I11F21 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, y, y); }
        public readonly Vector4I11F21 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, y, z); }
        public readonly Vector4I11F21 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, y, w); }
        public readonly Vector4I11F21 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, z, x); }
        public readonly Vector4I11F21 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, z, y); }
        public readonly Vector4I11F21 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, z, z); }
        public readonly Vector4I11F21 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, z, w); }
        public readonly Vector4I11F21 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, w, x); }
        public readonly Vector4I11F21 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, w, y); }
        public readonly Vector4I11F21 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, w, z); }
        public readonly Vector4I11F21 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(y, w, w, w); }
        public readonly Vector4I11F21 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, x, x); }
        public readonly Vector4I11F21 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, x, y); }
        public readonly Vector4I11F21 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, x, z); }
        public readonly Vector4I11F21 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, x, w); }
        public readonly Vector4I11F21 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, y, x); }
        public readonly Vector4I11F21 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, y, y); }
        public readonly Vector4I11F21 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, y, z); }
        public readonly Vector4I11F21 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, y, w); }
        public readonly Vector4I11F21 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, z, x); }
        public readonly Vector4I11F21 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, z, y); }
        public readonly Vector4I11F21 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, z, z); }
        public readonly Vector4I11F21 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, z, w); }
        public readonly Vector4I11F21 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, w, x); }
        public readonly Vector4I11F21 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, w, y); }
        public readonly Vector4I11F21 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, w, z); }
        public readonly Vector4I11F21 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, x, w, w); }
        public readonly Vector4I11F21 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, x, x); }
        public readonly Vector4I11F21 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, x, y); }
        public readonly Vector4I11F21 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, x, z); }
        public readonly Vector4I11F21 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, x, w); }
        public readonly Vector4I11F21 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, y, x); }
        public readonly Vector4I11F21 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, y, y); }
        public readonly Vector4I11F21 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, y, z); }
        public readonly Vector4I11F21 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, y, w); }
        public readonly Vector4I11F21 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, z, x); }
        public readonly Vector4I11F21 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, z, y); }
        public readonly Vector4I11F21 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, z, z); }
        public readonly Vector4I11F21 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, z, w); }
        public readonly Vector4I11F21 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, w, x); }
        public readonly Vector4I11F21 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, w, y); }
        public readonly Vector4I11F21 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, w, z); }
        public readonly Vector4I11F21 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, y, w, w); }
        public readonly Vector4I11F21 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, x, x); }
        public readonly Vector4I11F21 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, x, y); }
        public readonly Vector4I11F21 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, x, z); }
        public readonly Vector4I11F21 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, x, w); }
        public readonly Vector4I11F21 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, y, x); }
        public readonly Vector4I11F21 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, y, y); }
        public readonly Vector4I11F21 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, y, z); }
        public readonly Vector4I11F21 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, y, w); }
        public readonly Vector4I11F21 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, z, x); }
        public readonly Vector4I11F21 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, z, y); }
        public readonly Vector4I11F21 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, z, z); }
        public readonly Vector4I11F21 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, z, w); }
        public readonly Vector4I11F21 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, w, x); }
        public readonly Vector4I11F21 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, w, y); }
        public readonly Vector4I11F21 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, w, z); }
        public readonly Vector4I11F21 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, z, w, w); }
        public readonly Vector4I11F21 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, x, x); }
        public readonly Vector4I11F21 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, x, y); }
        public readonly Vector4I11F21 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, x, z); }
        public readonly Vector4I11F21 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, x, w); }
        public readonly Vector4I11F21 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, y, x); }
        public readonly Vector4I11F21 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, y, y); }
        public readonly Vector4I11F21 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, y, z); }
        public readonly Vector4I11F21 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, y, w); }
        public readonly Vector4I11F21 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, z, x); }
        public readonly Vector4I11F21 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, z, y); }
        public readonly Vector4I11F21 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, z, z); }
        public readonly Vector4I11F21 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, z, w); }
        public readonly Vector4I11F21 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, w, x); }
        public readonly Vector4I11F21 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, w, y); }
        public readonly Vector4I11F21 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, w, z); }
        public readonly Vector4I11F21 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(z, w, w, w); }
        public readonly Vector4I11F21 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, x, x); }
        public readonly Vector4I11F21 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, x, y); }
        public readonly Vector4I11F21 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, x, z); }
        public readonly Vector4I11F21 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, x, w); }
        public readonly Vector4I11F21 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, y, x); }
        public readonly Vector4I11F21 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, y, y); }
        public readonly Vector4I11F21 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, y, z); }
        public readonly Vector4I11F21 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, y, w); }
        public readonly Vector4I11F21 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, z, x); }
        public readonly Vector4I11F21 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, z, y); }
        public readonly Vector4I11F21 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, z, z); }
        public readonly Vector4I11F21 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, z, w); }
        public readonly Vector4I11F21 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, w, x); }
        public readonly Vector4I11F21 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, w, y); }
        public readonly Vector4I11F21 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, w, z); }
        public readonly Vector4I11F21 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, x, w, w); }
        public readonly Vector4I11F21 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, x, x); }
        public readonly Vector4I11F21 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, x, y); }
        public readonly Vector4I11F21 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, x, z); }
        public readonly Vector4I11F21 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, x, w); }
        public readonly Vector4I11F21 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, y, x); }
        public readonly Vector4I11F21 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, y, y); }
        public readonly Vector4I11F21 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, y, z); }
        public readonly Vector4I11F21 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, y, w); }
        public readonly Vector4I11F21 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, z, x); }
        public readonly Vector4I11F21 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, z, y); }
        public readonly Vector4I11F21 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, z, z); }
        public readonly Vector4I11F21 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, z, w); }
        public readonly Vector4I11F21 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, w, x); }
        public readonly Vector4I11F21 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, w, y); }
        public readonly Vector4I11F21 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, w, z); }
        public readonly Vector4I11F21 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, y, w, w); }
        public readonly Vector4I11F21 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, x, x); }
        public readonly Vector4I11F21 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, x, y); }
        public readonly Vector4I11F21 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, x, z); }
        public readonly Vector4I11F21 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, x, w); }
        public readonly Vector4I11F21 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, y, x); }
        public readonly Vector4I11F21 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, y, y); }
        public readonly Vector4I11F21 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, y, z); }
        public readonly Vector4I11F21 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, y, w); }
        public readonly Vector4I11F21 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, z, x); }
        public readonly Vector4I11F21 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, z, y); }
        public readonly Vector4I11F21 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, z, z); }
        public readonly Vector4I11F21 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, z, w); }
        public readonly Vector4I11F21 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, w, x); }
        public readonly Vector4I11F21 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, w, y); }
        public readonly Vector4I11F21 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, w, z); }
        public readonly Vector4I11F21 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, z, w, w); }
        public readonly Vector4I11F21 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, x, x); }
        public readonly Vector4I11F21 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, x, y); }
        public readonly Vector4I11F21 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, x, z); }
        public readonly Vector4I11F21 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, x, w); }
        public readonly Vector4I11F21 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, y, x); }
        public readonly Vector4I11F21 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, y, y); }
        public readonly Vector4I11F21 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, y, z); }
        public readonly Vector4I11F21 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, y, w); }
        public readonly Vector4I11F21 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, z, x); }
        public readonly Vector4I11F21 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, z, y); }
        public readonly Vector4I11F21 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, z, z); }
        public readonly Vector4I11F21 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, z, w); }
        public readonly Vector4I11F21 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, w, x); }
        public readonly Vector4I11F21 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, w, y); }
        public readonly Vector4I11F21 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, w, z); }
        public readonly Vector4I11F21 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I11F21 lhs, Vector4I11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I11F21 lhs, Vector4I11F21 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I11F21({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I11F21 other)
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
            return $"Vector4I11F21({x}, {y}, {z}, {w})";
        }
    }
}
