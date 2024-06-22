using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I19F13 : IEquatable<Vector4I19F13>, IFormattable {
        // Fields
        // ---------------------------------------

        public I19F13 x;
        public I19F13 y;
        public I19F13 z;
        public I19F13 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I19F13 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, I19F13 y, I19F13 z, I19F13 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, I19F13 y, Vector2I19F13 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, Vector3I19F13 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector2I19F13 xy, Vector2I19F13 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector4I19F13 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, Vector2I19F13 yz, I19F13 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector3I19F13 xyz, I19F13 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector2I19F13 xy, I19F13 z, I19F13 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator +(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator -(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator *(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator *(Vector4I19F13 a, I19F13 b) => new Vector4I19F13(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator *(I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator /(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator /(Vector4I19F13 a, I19F13 b) => new Vector4I19F13(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator /(I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I19F13 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(x, x); }
        public readonly Vector2I19F13 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(x, y); }
        public readonly Vector2I19F13 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(x, z); }
        public readonly Vector2I19F13 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(x, w); }
        public readonly Vector2I19F13 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(y, x); }
        public readonly Vector2I19F13 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(y, y); }
        public readonly Vector2I19F13 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(y, z); }
        public readonly Vector2I19F13 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(y, w); }
        public readonly Vector2I19F13 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(z, x); }
        public readonly Vector2I19F13 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(z, y); }
        public readonly Vector2I19F13 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(z, z); }
        public readonly Vector2I19F13 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(z, w); }
        public readonly Vector2I19F13 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(w, x); }
        public readonly Vector2I19F13 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(w, y); }
        public readonly Vector2I19F13 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(w, z); }
        public readonly Vector2I19F13 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(w, w); }
        public readonly Vector3I19F13 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, x, x); }
        public readonly Vector3I19F13 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, x, y); }
        public readonly Vector3I19F13 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, x, z); }
        public readonly Vector3I19F13 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, x, w); }
        public readonly Vector3I19F13 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, y, x); }
        public readonly Vector3I19F13 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, y, y); }
        public readonly Vector3I19F13 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, y, z); }
        public readonly Vector3I19F13 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, y, w); }
        public readonly Vector3I19F13 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, z, x); }
        public readonly Vector3I19F13 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, z, y); }
        public readonly Vector3I19F13 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, z, z); }
        public readonly Vector3I19F13 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, z, w); }
        public readonly Vector3I19F13 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, w, x); }
        public readonly Vector3I19F13 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, w, y); }
        public readonly Vector3I19F13 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, w, z); }
        public readonly Vector3I19F13 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, w, w); }
        public readonly Vector3I19F13 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, x, x); }
        public readonly Vector3I19F13 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, x, y); }
        public readonly Vector3I19F13 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, x, z); }
        public readonly Vector3I19F13 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, x, w); }
        public readonly Vector3I19F13 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, y, x); }
        public readonly Vector3I19F13 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, y, y); }
        public readonly Vector3I19F13 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, y, z); }
        public readonly Vector3I19F13 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, y, w); }
        public readonly Vector3I19F13 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, z, x); }
        public readonly Vector3I19F13 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, z, y); }
        public readonly Vector3I19F13 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, z, z); }
        public readonly Vector3I19F13 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, z, w); }
        public readonly Vector3I19F13 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, w, x); }
        public readonly Vector3I19F13 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, w, y); }
        public readonly Vector3I19F13 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, w, z); }
        public readonly Vector3I19F13 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, w, w); }
        public readonly Vector3I19F13 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, x, x); }
        public readonly Vector3I19F13 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, x, y); }
        public readonly Vector3I19F13 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, x, z); }
        public readonly Vector3I19F13 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, x, w); }
        public readonly Vector3I19F13 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, y, x); }
        public readonly Vector3I19F13 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, y, y); }
        public readonly Vector3I19F13 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, y, z); }
        public readonly Vector3I19F13 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, y, w); }
        public readonly Vector3I19F13 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, z, x); }
        public readonly Vector3I19F13 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, z, y); }
        public readonly Vector3I19F13 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, z, z); }
        public readonly Vector3I19F13 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, z, w); }
        public readonly Vector3I19F13 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, w, x); }
        public readonly Vector3I19F13 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, w, y); }
        public readonly Vector3I19F13 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, w, z); }
        public readonly Vector3I19F13 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, w, w); }
        public readonly Vector3I19F13 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, x, x); }
        public readonly Vector3I19F13 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, x, y); }
        public readonly Vector3I19F13 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, x, z); }
        public readonly Vector3I19F13 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, x, w); }
        public readonly Vector3I19F13 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, y, x); }
        public readonly Vector3I19F13 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, y, y); }
        public readonly Vector3I19F13 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, y, z); }
        public readonly Vector3I19F13 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, y, w); }
        public readonly Vector3I19F13 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, z, x); }
        public readonly Vector3I19F13 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, z, y); }
        public readonly Vector3I19F13 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, z, z); }
        public readonly Vector3I19F13 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, z, w); }
        public readonly Vector3I19F13 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, w, x); }
        public readonly Vector3I19F13 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, w, y); }
        public readonly Vector3I19F13 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, w, z); }
        public readonly Vector3I19F13 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(w, w, w); }
        public readonly Vector4I19F13 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, x, x); }
        public readonly Vector4I19F13 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, x, y); }
        public readonly Vector4I19F13 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, x, z); }
        public readonly Vector4I19F13 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, x, w); }
        public readonly Vector4I19F13 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, y, x); }
        public readonly Vector4I19F13 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, y, y); }
        public readonly Vector4I19F13 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, y, z); }
        public readonly Vector4I19F13 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, y, w); }
        public readonly Vector4I19F13 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, z, x); }
        public readonly Vector4I19F13 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, z, y); }
        public readonly Vector4I19F13 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, z, z); }
        public readonly Vector4I19F13 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, z, w); }
        public readonly Vector4I19F13 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, w, x); }
        public readonly Vector4I19F13 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, w, y); }
        public readonly Vector4I19F13 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, w, z); }
        public readonly Vector4I19F13 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, w, w); }
        public readonly Vector4I19F13 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, x, x); }
        public readonly Vector4I19F13 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, x, y); }
        public readonly Vector4I19F13 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, x, z); }
        public readonly Vector4I19F13 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, x, w); }
        public readonly Vector4I19F13 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, y, x); }
        public readonly Vector4I19F13 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, y, y); }
        public readonly Vector4I19F13 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, y, z); }
        public readonly Vector4I19F13 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, y, w); }
        public readonly Vector4I19F13 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, z, x); }
        public readonly Vector4I19F13 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, z, y); }
        public readonly Vector4I19F13 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, z, z); }
        public readonly Vector4I19F13 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, z, w); }
        public readonly Vector4I19F13 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, w, x); }
        public readonly Vector4I19F13 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, w, y); }
        public readonly Vector4I19F13 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, w, z); }
        public readonly Vector4I19F13 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, w, w); }
        public readonly Vector4I19F13 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, x, x); }
        public readonly Vector4I19F13 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, x, y); }
        public readonly Vector4I19F13 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, x, z); }
        public readonly Vector4I19F13 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, x, w); }
        public readonly Vector4I19F13 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, y, x); }
        public readonly Vector4I19F13 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, y, y); }
        public readonly Vector4I19F13 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, y, z); }
        public readonly Vector4I19F13 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, y, w); }
        public readonly Vector4I19F13 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, z, x); }
        public readonly Vector4I19F13 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, z, y); }
        public readonly Vector4I19F13 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, z, z); }
        public readonly Vector4I19F13 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, z, w); }
        public readonly Vector4I19F13 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, w, x); }
        public readonly Vector4I19F13 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, w, y); }
        public readonly Vector4I19F13 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, w, z); }
        public readonly Vector4I19F13 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, w, w); }
        public readonly Vector4I19F13 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, x, x); }
        public readonly Vector4I19F13 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, x, y); }
        public readonly Vector4I19F13 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, x, z); }
        public readonly Vector4I19F13 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, x, w); }
        public readonly Vector4I19F13 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, y, x); }
        public readonly Vector4I19F13 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, y, y); }
        public readonly Vector4I19F13 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, y, z); }
        public readonly Vector4I19F13 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, y, w); }
        public readonly Vector4I19F13 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, z, x); }
        public readonly Vector4I19F13 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, z, y); }
        public readonly Vector4I19F13 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, z, z); }
        public readonly Vector4I19F13 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, z, w); }
        public readonly Vector4I19F13 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, w, x); }
        public readonly Vector4I19F13 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, w, y); }
        public readonly Vector4I19F13 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, w, z); }
        public readonly Vector4I19F13 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, w, w, w); }
        public readonly Vector4I19F13 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, x, x); }
        public readonly Vector4I19F13 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, x, y); }
        public readonly Vector4I19F13 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, x, z); }
        public readonly Vector4I19F13 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, x, w); }
        public readonly Vector4I19F13 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, y, x); }
        public readonly Vector4I19F13 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, y, y); }
        public readonly Vector4I19F13 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, y, z); }
        public readonly Vector4I19F13 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, y, w); }
        public readonly Vector4I19F13 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, z, x); }
        public readonly Vector4I19F13 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, z, y); }
        public readonly Vector4I19F13 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, z, z); }
        public readonly Vector4I19F13 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, z, w); }
        public readonly Vector4I19F13 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, w, x); }
        public readonly Vector4I19F13 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, w, y); }
        public readonly Vector4I19F13 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, w, z); }
        public readonly Vector4I19F13 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, w, w); }
        public readonly Vector4I19F13 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, x, x); }
        public readonly Vector4I19F13 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, x, y); }
        public readonly Vector4I19F13 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, x, z); }
        public readonly Vector4I19F13 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, x, w); }
        public readonly Vector4I19F13 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, y, x); }
        public readonly Vector4I19F13 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, y, y); }
        public readonly Vector4I19F13 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, y, z); }
        public readonly Vector4I19F13 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, y, w); }
        public readonly Vector4I19F13 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, z, x); }
        public readonly Vector4I19F13 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, z, y); }
        public readonly Vector4I19F13 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, z, z); }
        public readonly Vector4I19F13 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, z, w); }
        public readonly Vector4I19F13 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, w, x); }
        public readonly Vector4I19F13 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, w, y); }
        public readonly Vector4I19F13 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, w, z); }
        public readonly Vector4I19F13 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, w, w); }
        public readonly Vector4I19F13 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, x, x); }
        public readonly Vector4I19F13 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, x, y); }
        public readonly Vector4I19F13 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, x, z); }
        public readonly Vector4I19F13 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, x, w); }
        public readonly Vector4I19F13 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, y, x); }
        public readonly Vector4I19F13 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, y, y); }
        public readonly Vector4I19F13 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, y, z); }
        public readonly Vector4I19F13 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, y, w); }
        public readonly Vector4I19F13 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, z, x); }
        public readonly Vector4I19F13 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, z, y); }
        public readonly Vector4I19F13 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, z, z); }
        public readonly Vector4I19F13 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, z, w); }
        public readonly Vector4I19F13 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, w, x); }
        public readonly Vector4I19F13 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, w, y); }
        public readonly Vector4I19F13 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, w, z); }
        public readonly Vector4I19F13 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, w, w); }
        public readonly Vector4I19F13 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, x, x); }
        public readonly Vector4I19F13 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, x, y); }
        public readonly Vector4I19F13 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, x, z); }
        public readonly Vector4I19F13 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, x, w); }
        public readonly Vector4I19F13 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, y, x); }
        public readonly Vector4I19F13 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, y, y); }
        public readonly Vector4I19F13 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, y, z); }
        public readonly Vector4I19F13 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, y, w); }
        public readonly Vector4I19F13 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, z, x); }
        public readonly Vector4I19F13 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, z, y); }
        public readonly Vector4I19F13 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, z, z); }
        public readonly Vector4I19F13 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, z, w); }
        public readonly Vector4I19F13 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, w, x); }
        public readonly Vector4I19F13 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, w, y); }
        public readonly Vector4I19F13 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, w, z); }
        public readonly Vector4I19F13 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, w, w, w); }
        public readonly Vector4I19F13 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, x, x); }
        public readonly Vector4I19F13 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, x, y); }
        public readonly Vector4I19F13 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, x, z); }
        public readonly Vector4I19F13 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, x, w); }
        public readonly Vector4I19F13 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, y, x); }
        public readonly Vector4I19F13 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, y, y); }
        public readonly Vector4I19F13 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, y, z); }
        public readonly Vector4I19F13 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, y, w); }
        public readonly Vector4I19F13 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, z, x); }
        public readonly Vector4I19F13 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, z, y); }
        public readonly Vector4I19F13 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, z, z); }
        public readonly Vector4I19F13 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, z, w); }
        public readonly Vector4I19F13 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, w, x); }
        public readonly Vector4I19F13 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, w, y); }
        public readonly Vector4I19F13 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, w, z); }
        public readonly Vector4I19F13 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, w, w); }
        public readonly Vector4I19F13 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, x, x); }
        public readonly Vector4I19F13 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, x, y); }
        public readonly Vector4I19F13 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, x, z); }
        public readonly Vector4I19F13 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, x, w); }
        public readonly Vector4I19F13 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, y, x); }
        public readonly Vector4I19F13 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, y, y); }
        public readonly Vector4I19F13 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, y, z); }
        public readonly Vector4I19F13 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, y, w); }
        public readonly Vector4I19F13 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, z, x); }
        public readonly Vector4I19F13 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, z, y); }
        public readonly Vector4I19F13 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, z, z); }
        public readonly Vector4I19F13 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, z, w); }
        public readonly Vector4I19F13 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, w, x); }
        public readonly Vector4I19F13 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, w, y); }
        public readonly Vector4I19F13 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, w, z); }
        public readonly Vector4I19F13 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, w, w); }
        public readonly Vector4I19F13 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, x, x); }
        public readonly Vector4I19F13 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, x, y); }
        public readonly Vector4I19F13 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, x, z); }
        public readonly Vector4I19F13 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, x, w); }
        public readonly Vector4I19F13 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, y, x); }
        public readonly Vector4I19F13 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, y, y); }
        public readonly Vector4I19F13 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, y, z); }
        public readonly Vector4I19F13 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, y, w); }
        public readonly Vector4I19F13 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, z, x); }
        public readonly Vector4I19F13 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, z, y); }
        public readonly Vector4I19F13 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, z, z); }
        public readonly Vector4I19F13 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, z, w); }
        public readonly Vector4I19F13 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, w, x); }
        public readonly Vector4I19F13 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, w, y); }
        public readonly Vector4I19F13 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, w, z); }
        public readonly Vector4I19F13 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, w, w); }
        public readonly Vector4I19F13 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, x, x); }
        public readonly Vector4I19F13 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, x, y); }
        public readonly Vector4I19F13 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, x, z); }
        public readonly Vector4I19F13 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, x, w); }
        public readonly Vector4I19F13 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, y, x); }
        public readonly Vector4I19F13 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, y, y); }
        public readonly Vector4I19F13 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, y, z); }
        public readonly Vector4I19F13 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, y, w); }
        public readonly Vector4I19F13 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, z, x); }
        public readonly Vector4I19F13 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, z, y); }
        public readonly Vector4I19F13 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, z, z); }
        public readonly Vector4I19F13 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, z, w); }
        public readonly Vector4I19F13 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, w, x); }
        public readonly Vector4I19F13 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, w, y); }
        public readonly Vector4I19F13 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, w, z); }
        public readonly Vector4I19F13 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, w, w, w); }
        public readonly Vector4I19F13 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, x, x); }
        public readonly Vector4I19F13 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, x, y); }
        public readonly Vector4I19F13 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, x, z); }
        public readonly Vector4I19F13 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, x, w); }
        public readonly Vector4I19F13 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, y, x); }
        public readonly Vector4I19F13 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, y, y); }
        public readonly Vector4I19F13 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, y, z); }
        public readonly Vector4I19F13 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, y, w); }
        public readonly Vector4I19F13 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, z, x); }
        public readonly Vector4I19F13 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, z, y); }
        public readonly Vector4I19F13 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, z, z); }
        public readonly Vector4I19F13 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, z, w); }
        public readonly Vector4I19F13 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, w, x); }
        public readonly Vector4I19F13 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, w, y); }
        public readonly Vector4I19F13 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, w, z); }
        public readonly Vector4I19F13 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, x, w, w); }
        public readonly Vector4I19F13 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, x, x); }
        public readonly Vector4I19F13 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, x, y); }
        public readonly Vector4I19F13 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, x, z); }
        public readonly Vector4I19F13 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, x, w); }
        public readonly Vector4I19F13 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, y, x); }
        public readonly Vector4I19F13 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, y, y); }
        public readonly Vector4I19F13 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, y, z); }
        public readonly Vector4I19F13 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, y, w); }
        public readonly Vector4I19F13 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, z, x); }
        public readonly Vector4I19F13 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, z, y); }
        public readonly Vector4I19F13 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, z, z); }
        public readonly Vector4I19F13 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, z, w); }
        public readonly Vector4I19F13 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, w, x); }
        public readonly Vector4I19F13 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, w, y); }
        public readonly Vector4I19F13 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, w, z); }
        public readonly Vector4I19F13 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, y, w, w); }
        public readonly Vector4I19F13 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, x, x); }
        public readonly Vector4I19F13 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, x, y); }
        public readonly Vector4I19F13 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, x, z); }
        public readonly Vector4I19F13 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, x, w); }
        public readonly Vector4I19F13 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, y, x); }
        public readonly Vector4I19F13 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, y, y); }
        public readonly Vector4I19F13 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, y, z); }
        public readonly Vector4I19F13 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, y, w); }
        public readonly Vector4I19F13 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, z, x); }
        public readonly Vector4I19F13 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, z, y); }
        public readonly Vector4I19F13 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, z, z); }
        public readonly Vector4I19F13 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, z, w); }
        public readonly Vector4I19F13 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, w, x); }
        public readonly Vector4I19F13 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, w, y); }
        public readonly Vector4I19F13 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, w, z); }
        public readonly Vector4I19F13 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, z, w, w); }
        public readonly Vector4I19F13 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, x, x); }
        public readonly Vector4I19F13 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, x, y); }
        public readonly Vector4I19F13 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, x, z); }
        public readonly Vector4I19F13 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, x, w); }
        public readonly Vector4I19F13 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, y, x); }
        public readonly Vector4I19F13 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, y, y); }
        public readonly Vector4I19F13 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, y, z); }
        public readonly Vector4I19F13 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, y, w); }
        public readonly Vector4I19F13 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, z, x); }
        public readonly Vector4I19F13 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, z, y); }
        public readonly Vector4I19F13 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, z, z); }
        public readonly Vector4I19F13 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, z, w); }
        public readonly Vector4I19F13 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, w, x); }
        public readonly Vector4I19F13 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, w, y); }
        public readonly Vector4I19F13 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, w, z); }
        public readonly Vector4I19F13 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I19F13 lhs, Vector4I19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I19F13 lhs, Vector4I19F13 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I19F13({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I19F13>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I19F13 other)
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
            return $"Vector4I19F13({x}, {y}, {z}, {w})";
        }
    }
}
