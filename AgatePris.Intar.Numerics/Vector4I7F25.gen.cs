using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I7F25 : IEquatable<Vector4I7F25>, IFormattable {
        // Fields
        // ---------------------------------------

        public I7F25 x;
        public I7F25 y;
        public I7F25 z;
        public I7F25 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I7F25 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(I7F25 x, I7F25 y, I7F25 z, I7F25 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(I7F25 x, I7F25 y, Vector2I7F25 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(I7F25 x, Vector3I7F25 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(Vector2I7F25 xy, Vector2I7F25 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(Vector4I7F25 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(I7F25 x, Vector2I7F25 yz, I7F25 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(Vector3I7F25 xyz, I7F25 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(Vector2I7F25 xy, I7F25 z, I7F25 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator +(Vector4I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator -(Vector4I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator *(Vector4I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator *(Vector4I7F25 a, I7F25 b) => new Vector4I7F25(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator *(I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator /(Vector4I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator /(Vector4I7F25 a, I7F25 b) => new Vector4I7F25(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator /(I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I7F25 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(x, x); }
        public readonly Vector2I7F25 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(x, y); }
        public readonly Vector2I7F25 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(x, z); }
        public readonly Vector2I7F25 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(x, w); }
        public readonly Vector2I7F25 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(y, x); }
        public readonly Vector2I7F25 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(y, y); }
        public readonly Vector2I7F25 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(y, z); }
        public readonly Vector2I7F25 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(y, w); }
        public readonly Vector2I7F25 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(z, x); }
        public readonly Vector2I7F25 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(z, y); }
        public readonly Vector2I7F25 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(z, z); }
        public readonly Vector2I7F25 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(z, w); }
        public readonly Vector2I7F25 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(w, x); }
        public readonly Vector2I7F25 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(w, y); }
        public readonly Vector2I7F25 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(w, z); }
        public readonly Vector2I7F25 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(w, w); }
        public readonly Vector3I7F25 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, x, x); }
        public readonly Vector3I7F25 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, x, y); }
        public readonly Vector3I7F25 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, x, z); }
        public readonly Vector3I7F25 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, x, w); }
        public readonly Vector3I7F25 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, y, x); }
        public readonly Vector3I7F25 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, y, y); }
        public readonly Vector3I7F25 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, y, z); }
        public readonly Vector3I7F25 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, y, w); }
        public readonly Vector3I7F25 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, z, x); }
        public readonly Vector3I7F25 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, z, y); }
        public readonly Vector3I7F25 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, z, z); }
        public readonly Vector3I7F25 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, z, w); }
        public readonly Vector3I7F25 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, w, x); }
        public readonly Vector3I7F25 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, w, y); }
        public readonly Vector3I7F25 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, w, z); }
        public readonly Vector3I7F25 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(x, w, w); }
        public readonly Vector3I7F25 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, x, x); }
        public readonly Vector3I7F25 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, x, y); }
        public readonly Vector3I7F25 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, x, z); }
        public readonly Vector3I7F25 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, x, w); }
        public readonly Vector3I7F25 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, y, x); }
        public readonly Vector3I7F25 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, y, y); }
        public readonly Vector3I7F25 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, y, z); }
        public readonly Vector3I7F25 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, y, w); }
        public readonly Vector3I7F25 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, z, x); }
        public readonly Vector3I7F25 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, z, y); }
        public readonly Vector3I7F25 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, z, z); }
        public readonly Vector3I7F25 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, z, w); }
        public readonly Vector3I7F25 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, w, x); }
        public readonly Vector3I7F25 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, w, y); }
        public readonly Vector3I7F25 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, w, z); }
        public readonly Vector3I7F25 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(y, w, w); }
        public readonly Vector3I7F25 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, x, x); }
        public readonly Vector3I7F25 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, x, y); }
        public readonly Vector3I7F25 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, x, z); }
        public readonly Vector3I7F25 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, x, w); }
        public readonly Vector3I7F25 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, y, x); }
        public readonly Vector3I7F25 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, y, y); }
        public readonly Vector3I7F25 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, y, z); }
        public readonly Vector3I7F25 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, y, w); }
        public readonly Vector3I7F25 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, z, x); }
        public readonly Vector3I7F25 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, z, y); }
        public readonly Vector3I7F25 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, z, z); }
        public readonly Vector3I7F25 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, z, w); }
        public readonly Vector3I7F25 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, w, x); }
        public readonly Vector3I7F25 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, w, y); }
        public readonly Vector3I7F25 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, w, z); }
        public readonly Vector3I7F25 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(z, w, w); }
        public readonly Vector3I7F25 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, x, x); }
        public readonly Vector3I7F25 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, x, y); }
        public readonly Vector3I7F25 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, x, z); }
        public readonly Vector3I7F25 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, x, w); }
        public readonly Vector3I7F25 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, y, x); }
        public readonly Vector3I7F25 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, y, y); }
        public readonly Vector3I7F25 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, y, z); }
        public readonly Vector3I7F25 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, y, w); }
        public readonly Vector3I7F25 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, z, x); }
        public readonly Vector3I7F25 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, z, y); }
        public readonly Vector3I7F25 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, z, z); }
        public readonly Vector3I7F25 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, z, w); }
        public readonly Vector3I7F25 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, w, x); }
        public readonly Vector3I7F25 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, w, y); }
        public readonly Vector3I7F25 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, w, z); }
        public readonly Vector3I7F25 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(w, w, w); }
        public readonly Vector4I7F25 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, x, x); }
        public readonly Vector4I7F25 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, x, y); }
        public readonly Vector4I7F25 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, x, z); }
        public readonly Vector4I7F25 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, x, w); }
        public readonly Vector4I7F25 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, y, x); }
        public readonly Vector4I7F25 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, y, y); }
        public readonly Vector4I7F25 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, y, z); }
        public readonly Vector4I7F25 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, y, w); }
        public readonly Vector4I7F25 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, z, x); }
        public readonly Vector4I7F25 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, z, y); }
        public readonly Vector4I7F25 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, z, z); }
        public readonly Vector4I7F25 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, z, w); }
        public readonly Vector4I7F25 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, w, x); }
        public readonly Vector4I7F25 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, w, y); }
        public readonly Vector4I7F25 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, w, z); }
        public readonly Vector4I7F25 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, x, w, w); }
        public readonly Vector4I7F25 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, x, x); }
        public readonly Vector4I7F25 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, x, y); }
        public readonly Vector4I7F25 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, x, z); }
        public readonly Vector4I7F25 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, x, w); }
        public readonly Vector4I7F25 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, y, x); }
        public readonly Vector4I7F25 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, y, y); }
        public readonly Vector4I7F25 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, y, z); }
        public readonly Vector4I7F25 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, y, w); }
        public readonly Vector4I7F25 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, z, x); }
        public readonly Vector4I7F25 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, z, y); }
        public readonly Vector4I7F25 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, z, z); }
        public readonly Vector4I7F25 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, z, w); }
        public readonly Vector4I7F25 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, w, x); }
        public readonly Vector4I7F25 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, w, y); }
        public readonly Vector4I7F25 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, w, z); }
        public readonly Vector4I7F25 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, y, w, w); }
        public readonly Vector4I7F25 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, x, x); }
        public readonly Vector4I7F25 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, x, y); }
        public readonly Vector4I7F25 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, x, z); }
        public readonly Vector4I7F25 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, x, w); }
        public readonly Vector4I7F25 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, y, x); }
        public readonly Vector4I7F25 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, y, y); }
        public readonly Vector4I7F25 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, y, z); }
        public readonly Vector4I7F25 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, y, w); }
        public readonly Vector4I7F25 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, z, x); }
        public readonly Vector4I7F25 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, z, y); }
        public readonly Vector4I7F25 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, z, z); }
        public readonly Vector4I7F25 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, z, w); }
        public readonly Vector4I7F25 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, w, x); }
        public readonly Vector4I7F25 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, w, y); }
        public readonly Vector4I7F25 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, w, z); }
        public readonly Vector4I7F25 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, z, w, w); }
        public readonly Vector4I7F25 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, x, x); }
        public readonly Vector4I7F25 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, x, y); }
        public readonly Vector4I7F25 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, x, z); }
        public readonly Vector4I7F25 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, x, w); }
        public readonly Vector4I7F25 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, y, x); }
        public readonly Vector4I7F25 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, y, y); }
        public readonly Vector4I7F25 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, y, z); }
        public readonly Vector4I7F25 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, y, w); }
        public readonly Vector4I7F25 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, z, x); }
        public readonly Vector4I7F25 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, z, y); }
        public readonly Vector4I7F25 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, z, z); }
        public readonly Vector4I7F25 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, z, w); }
        public readonly Vector4I7F25 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, w, x); }
        public readonly Vector4I7F25 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, w, y); }
        public readonly Vector4I7F25 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, w, z); }
        public readonly Vector4I7F25 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(x, w, w, w); }
        public readonly Vector4I7F25 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, x, x); }
        public readonly Vector4I7F25 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, x, y); }
        public readonly Vector4I7F25 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, x, z); }
        public readonly Vector4I7F25 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, x, w); }
        public readonly Vector4I7F25 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, y, x); }
        public readonly Vector4I7F25 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, y, y); }
        public readonly Vector4I7F25 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, y, z); }
        public readonly Vector4I7F25 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, y, w); }
        public readonly Vector4I7F25 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, z, x); }
        public readonly Vector4I7F25 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, z, y); }
        public readonly Vector4I7F25 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, z, z); }
        public readonly Vector4I7F25 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, z, w); }
        public readonly Vector4I7F25 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, w, x); }
        public readonly Vector4I7F25 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, w, y); }
        public readonly Vector4I7F25 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, w, z); }
        public readonly Vector4I7F25 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, x, w, w); }
        public readonly Vector4I7F25 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, x, x); }
        public readonly Vector4I7F25 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, x, y); }
        public readonly Vector4I7F25 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, x, z); }
        public readonly Vector4I7F25 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, x, w); }
        public readonly Vector4I7F25 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, y, x); }
        public readonly Vector4I7F25 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, y, y); }
        public readonly Vector4I7F25 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, y, z); }
        public readonly Vector4I7F25 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, y, w); }
        public readonly Vector4I7F25 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, z, x); }
        public readonly Vector4I7F25 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, z, y); }
        public readonly Vector4I7F25 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, z, z); }
        public readonly Vector4I7F25 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, z, w); }
        public readonly Vector4I7F25 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, w, x); }
        public readonly Vector4I7F25 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, w, y); }
        public readonly Vector4I7F25 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, w, z); }
        public readonly Vector4I7F25 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, y, w, w); }
        public readonly Vector4I7F25 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, x, x); }
        public readonly Vector4I7F25 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, x, y); }
        public readonly Vector4I7F25 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, x, z); }
        public readonly Vector4I7F25 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, x, w); }
        public readonly Vector4I7F25 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, y, x); }
        public readonly Vector4I7F25 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, y, y); }
        public readonly Vector4I7F25 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, y, z); }
        public readonly Vector4I7F25 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, y, w); }
        public readonly Vector4I7F25 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, z, x); }
        public readonly Vector4I7F25 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, z, y); }
        public readonly Vector4I7F25 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, z, z); }
        public readonly Vector4I7F25 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, z, w); }
        public readonly Vector4I7F25 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, w, x); }
        public readonly Vector4I7F25 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, w, y); }
        public readonly Vector4I7F25 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, w, z); }
        public readonly Vector4I7F25 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, z, w, w); }
        public readonly Vector4I7F25 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, x, x); }
        public readonly Vector4I7F25 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, x, y); }
        public readonly Vector4I7F25 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, x, z); }
        public readonly Vector4I7F25 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, x, w); }
        public readonly Vector4I7F25 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, y, x); }
        public readonly Vector4I7F25 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, y, y); }
        public readonly Vector4I7F25 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, y, z); }
        public readonly Vector4I7F25 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, y, w); }
        public readonly Vector4I7F25 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, z, x); }
        public readonly Vector4I7F25 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, z, y); }
        public readonly Vector4I7F25 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, z, z); }
        public readonly Vector4I7F25 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, z, w); }
        public readonly Vector4I7F25 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, w, x); }
        public readonly Vector4I7F25 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, w, y); }
        public readonly Vector4I7F25 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, w, z); }
        public readonly Vector4I7F25 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(y, w, w, w); }
        public readonly Vector4I7F25 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, x, x); }
        public readonly Vector4I7F25 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, x, y); }
        public readonly Vector4I7F25 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, x, z); }
        public readonly Vector4I7F25 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, x, w); }
        public readonly Vector4I7F25 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, y, x); }
        public readonly Vector4I7F25 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, y, y); }
        public readonly Vector4I7F25 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, y, z); }
        public readonly Vector4I7F25 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, y, w); }
        public readonly Vector4I7F25 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, z, x); }
        public readonly Vector4I7F25 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, z, y); }
        public readonly Vector4I7F25 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, z, z); }
        public readonly Vector4I7F25 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, z, w); }
        public readonly Vector4I7F25 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, w, x); }
        public readonly Vector4I7F25 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, w, y); }
        public readonly Vector4I7F25 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, w, z); }
        public readonly Vector4I7F25 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, x, w, w); }
        public readonly Vector4I7F25 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, x, x); }
        public readonly Vector4I7F25 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, x, y); }
        public readonly Vector4I7F25 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, x, z); }
        public readonly Vector4I7F25 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, x, w); }
        public readonly Vector4I7F25 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, y, x); }
        public readonly Vector4I7F25 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, y, y); }
        public readonly Vector4I7F25 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, y, z); }
        public readonly Vector4I7F25 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, y, w); }
        public readonly Vector4I7F25 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, z, x); }
        public readonly Vector4I7F25 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, z, y); }
        public readonly Vector4I7F25 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, z, z); }
        public readonly Vector4I7F25 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, z, w); }
        public readonly Vector4I7F25 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, w, x); }
        public readonly Vector4I7F25 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, w, y); }
        public readonly Vector4I7F25 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, w, z); }
        public readonly Vector4I7F25 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, y, w, w); }
        public readonly Vector4I7F25 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, x, x); }
        public readonly Vector4I7F25 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, x, y); }
        public readonly Vector4I7F25 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, x, z); }
        public readonly Vector4I7F25 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, x, w); }
        public readonly Vector4I7F25 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, y, x); }
        public readonly Vector4I7F25 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, y, y); }
        public readonly Vector4I7F25 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, y, z); }
        public readonly Vector4I7F25 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, y, w); }
        public readonly Vector4I7F25 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, z, x); }
        public readonly Vector4I7F25 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, z, y); }
        public readonly Vector4I7F25 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, z, z); }
        public readonly Vector4I7F25 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, z, w); }
        public readonly Vector4I7F25 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, w, x); }
        public readonly Vector4I7F25 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, w, y); }
        public readonly Vector4I7F25 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, w, z); }
        public readonly Vector4I7F25 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, z, w, w); }
        public readonly Vector4I7F25 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, x, x); }
        public readonly Vector4I7F25 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, x, y); }
        public readonly Vector4I7F25 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, x, z); }
        public readonly Vector4I7F25 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, x, w); }
        public readonly Vector4I7F25 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, y, x); }
        public readonly Vector4I7F25 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, y, y); }
        public readonly Vector4I7F25 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, y, z); }
        public readonly Vector4I7F25 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, y, w); }
        public readonly Vector4I7F25 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, z, x); }
        public readonly Vector4I7F25 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, z, y); }
        public readonly Vector4I7F25 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, z, z); }
        public readonly Vector4I7F25 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, z, w); }
        public readonly Vector4I7F25 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, w, x); }
        public readonly Vector4I7F25 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, w, y); }
        public readonly Vector4I7F25 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, w, z); }
        public readonly Vector4I7F25 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(z, w, w, w); }
        public readonly Vector4I7F25 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, x, x); }
        public readonly Vector4I7F25 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, x, y); }
        public readonly Vector4I7F25 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, x, z); }
        public readonly Vector4I7F25 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, x, w); }
        public readonly Vector4I7F25 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, y, x); }
        public readonly Vector4I7F25 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, y, y); }
        public readonly Vector4I7F25 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, y, z); }
        public readonly Vector4I7F25 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, y, w); }
        public readonly Vector4I7F25 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, z, x); }
        public readonly Vector4I7F25 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, z, y); }
        public readonly Vector4I7F25 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, z, z); }
        public readonly Vector4I7F25 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, z, w); }
        public readonly Vector4I7F25 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, w, x); }
        public readonly Vector4I7F25 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, w, y); }
        public readonly Vector4I7F25 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, w, z); }
        public readonly Vector4I7F25 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, x, w, w); }
        public readonly Vector4I7F25 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, x, x); }
        public readonly Vector4I7F25 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, x, y); }
        public readonly Vector4I7F25 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, x, z); }
        public readonly Vector4I7F25 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, x, w); }
        public readonly Vector4I7F25 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, y, x); }
        public readonly Vector4I7F25 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, y, y); }
        public readonly Vector4I7F25 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, y, z); }
        public readonly Vector4I7F25 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, y, w); }
        public readonly Vector4I7F25 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, z, x); }
        public readonly Vector4I7F25 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, z, y); }
        public readonly Vector4I7F25 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, z, z); }
        public readonly Vector4I7F25 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, z, w); }
        public readonly Vector4I7F25 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, w, x); }
        public readonly Vector4I7F25 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, w, y); }
        public readonly Vector4I7F25 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, w, z); }
        public readonly Vector4I7F25 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, y, w, w); }
        public readonly Vector4I7F25 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, x, x); }
        public readonly Vector4I7F25 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, x, y); }
        public readonly Vector4I7F25 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, x, z); }
        public readonly Vector4I7F25 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, x, w); }
        public readonly Vector4I7F25 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, y, x); }
        public readonly Vector4I7F25 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, y, y); }
        public readonly Vector4I7F25 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, y, z); }
        public readonly Vector4I7F25 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, y, w); }
        public readonly Vector4I7F25 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, z, x); }
        public readonly Vector4I7F25 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, z, y); }
        public readonly Vector4I7F25 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, z, z); }
        public readonly Vector4I7F25 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, z, w); }
        public readonly Vector4I7F25 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, w, x); }
        public readonly Vector4I7F25 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, w, y); }
        public readonly Vector4I7F25 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, w, z); }
        public readonly Vector4I7F25 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, z, w, w); }
        public readonly Vector4I7F25 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, x, x); }
        public readonly Vector4I7F25 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, x, y); }
        public readonly Vector4I7F25 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, x, z); }
        public readonly Vector4I7F25 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, x, w); }
        public readonly Vector4I7F25 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, y, x); }
        public readonly Vector4I7F25 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, y, y); }
        public readonly Vector4I7F25 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, y, z); }
        public readonly Vector4I7F25 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, y, w); }
        public readonly Vector4I7F25 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, z, x); }
        public readonly Vector4I7F25 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, z, y); }
        public readonly Vector4I7F25 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, z, z); }
        public readonly Vector4I7F25 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, z, w); }
        public readonly Vector4I7F25 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, w, x); }
        public readonly Vector4I7F25 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, w, y); }
        public readonly Vector4I7F25 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, w, z); }
        public readonly Vector4I7F25 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I7F25 lhs, Vector4I7F25 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I7F25 lhs, Vector4I7F25 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I7F25({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I7F25 other)
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
            return $"Vector4I7F25({x}, {y}, {z}, {w})";
        }
    }
}
