using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I4F28 : IEquatable<Vector4I4F28>, IFormattable {
        // Fields
        // ---------------------------------------

        public I4F28 x;
        public I4F28 y;
        public I4F28 z;
        public I4F28 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I4F28 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(I4F28 x, I4F28 y, I4F28 z, I4F28 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(I4F28 x, I4F28 y, Vector2I4F28 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(I4F28 x, Vector3I4F28 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(Vector2I4F28 xy, Vector2I4F28 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(Vector4I4F28 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(I4F28 x, Vector2I4F28 yz, I4F28 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(Vector3I4F28 xyz, I4F28 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(Vector2I4F28 xy, I4F28 z, I4F28 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator +(Vector4I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator -(Vector4I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator *(Vector4I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator *(Vector4I4F28 a, I4F28 b) => new Vector4I4F28(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator *(I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator /(Vector4I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator /(Vector4I4F28 a, I4F28 b) => new Vector4I4F28(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator /(I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I4F28 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(x, x); }
        public readonly Vector2I4F28 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(x, y); }
        public readonly Vector2I4F28 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(x, z); }
        public readonly Vector2I4F28 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(x, w); }
        public readonly Vector2I4F28 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(y, x); }
        public readonly Vector2I4F28 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(y, y); }
        public readonly Vector2I4F28 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(y, z); }
        public readonly Vector2I4F28 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(y, w); }
        public readonly Vector2I4F28 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(z, x); }
        public readonly Vector2I4F28 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(z, y); }
        public readonly Vector2I4F28 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(z, z); }
        public readonly Vector2I4F28 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(z, w); }
        public readonly Vector2I4F28 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(w, x); }
        public readonly Vector2I4F28 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(w, y); }
        public readonly Vector2I4F28 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(w, z); }
        public readonly Vector2I4F28 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(w, w); }
        public readonly Vector3I4F28 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, x, x); }
        public readonly Vector3I4F28 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, x, y); }
        public readonly Vector3I4F28 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, x, z); }
        public readonly Vector3I4F28 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, x, w); }
        public readonly Vector3I4F28 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, y, x); }
        public readonly Vector3I4F28 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, y, y); }
        public readonly Vector3I4F28 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, y, z); }
        public readonly Vector3I4F28 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, y, w); }
        public readonly Vector3I4F28 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, z, x); }
        public readonly Vector3I4F28 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, z, y); }
        public readonly Vector3I4F28 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, z, z); }
        public readonly Vector3I4F28 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, z, w); }
        public readonly Vector3I4F28 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, w, x); }
        public readonly Vector3I4F28 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, w, y); }
        public readonly Vector3I4F28 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, w, z); }
        public readonly Vector3I4F28 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, w, w); }
        public readonly Vector3I4F28 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, x, x); }
        public readonly Vector3I4F28 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, x, y); }
        public readonly Vector3I4F28 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, x, z); }
        public readonly Vector3I4F28 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, x, w); }
        public readonly Vector3I4F28 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, y, x); }
        public readonly Vector3I4F28 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, y, y); }
        public readonly Vector3I4F28 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, y, z); }
        public readonly Vector3I4F28 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, y, w); }
        public readonly Vector3I4F28 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, z, x); }
        public readonly Vector3I4F28 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, z, y); }
        public readonly Vector3I4F28 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, z, z); }
        public readonly Vector3I4F28 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, z, w); }
        public readonly Vector3I4F28 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, w, x); }
        public readonly Vector3I4F28 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, w, y); }
        public readonly Vector3I4F28 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, w, z); }
        public readonly Vector3I4F28 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, w, w); }
        public readonly Vector3I4F28 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, x, x); }
        public readonly Vector3I4F28 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, x, y); }
        public readonly Vector3I4F28 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, x, z); }
        public readonly Vector3I4F28 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, x, w); }
        public readonly Vector3I4F28 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, y, x); }
        public readonly Vector3I4F28 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, y, y); }
        public readonly Vector3I4F28 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, y, z); }
        public readonly Vector3I4F28 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, y, w); }
        public readonly Vector3I4F28 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, z, x); }
        public readonly Vector3I4F28 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, z, y); }
        public readonly Vector3I4F28 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, z, z); }
        public readonly Vector3I4F28 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, z, w); }
        public readonly Vector3I4F28 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, w, x); }
        public readonly Vector3I4F28 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, w, y); }
        public readonly Vector3I4F28 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, w, z); }
        public readonly Vector3I4F28 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(z, w, w); }
        public readonly Vector3I4F28 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, x, x); }
        public readonly Vector3I4F28 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, x, y); }
        public readonly Vector3I4F28 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, x, z); }
        public readonly Vector3I4F28 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, x, w); }
        public readonly Vector3I4F28 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, y, x); }
        public readonly Vector3I4F28 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, y, y); }
        public readonly Vector3I4F28 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, y, z); }
        public readonly Vector3I4F28 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, y, w); }
        public readonly Vector3I4F28 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, z, x); }
        public readonly Vector3I4F28 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, z, y); }
        public readonly Vector3I4F28 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, z, z); }
        public readonly Vector3I4F28 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, z, w); }
        public readonly Vector3I4F28 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, w, x); }
        public readonly Vector3I4F28 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, w, y); }
        public readonly Vector3I4F28 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, w, z); }
        public readonly Vector3I4F28 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(w, w, w); }
        public readonly Vector4I4F28 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, x, x); }
        public readonly Vector4I4F28 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, x, y); }
        public readonly Vector4I4F28 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, x, z); }
        public readonly Vector4I4F28 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, x, w); }
        public readonly Vector4I4F28 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, y, x); }
        public readonly Vector4I4F28 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, y, y); }
        public readonly Vector4I4F28 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, y, z); }
        public readonly Vector4I4F28 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, y, w); }
        public readonly Vector4I4F28 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, z, x); }
        public readonly Vector4I4F28 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, z, y); }
        public readonly Vector4I4F28 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, z, z); }
        public readonly Vector4I4F28 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, z, w); }
        public readonly Vector4I4F28 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, w, x); }
        public readonly Vector4I4F28 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, w, y); }
        public readonly Vector4I4F28 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, w, z); }
        public readonly Vector4I4F28 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, w, w); }
        public readonly Vector4I4F28 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, x, x); }
        public readonly Vector4I4F28 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, x, y); }
        public readonly Vector4I4F28 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, x, z); }
        public readonly Vector4I4F28 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, x, w); }
        public readonly Vector4I4F28 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, y, x); }
        public readonly Vector4I4F28 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, y, y); }
        public readonly Vector4I4F28 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, y, z); }
        public readonly Vector4I4F28 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, y, w); }
        public readonly Vector4I4F28 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, z, x); }
        public readonly Vector4I4F28 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, z, y); }
        public readonly Vector4I4F28 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, z, z); }
        public readonly Vector4I4F28 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, z, w); }
        public readonly Vector4I4F28 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, w, x); }
        public readonly Vector4I4F28 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, w, y); }
        public readonly Vector4I4F28 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, w, z); }
        public readonly Vector4I4F28 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, w, w); }
        public readonly Vector4I4F28 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, x, x); }
        public readonly Vector4I4F28 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, x, y); }
        public readonly Vector4I4F28 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, x, z); }
        public readonly Vector4I4F28 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, x, w); }
        public readonly Vector4I4F28 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, y, x); }
        public readonly Vector4I4F28 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, y, y); }
        public readonly Vector4I4F28 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, y, z); }
        public readonly Vector4I4F28 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, y, w); }
        public readonly Vector4I4F28 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, z, x); }
        public readonly Vector4I4F28 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, z, y); }
        public readonly Vector4I4F28 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, z, z); }
        public readonly Vector4I4F28 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, z, w); }
        public readonly Vector4I4F28 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, w, x); }
        public readonly Vector4I4F28 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, w, y); }
        public readonly Vector4I4F28 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, w, z); }
        public readonly Vector4I4F28 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, z, w, w); }
        public readonly Vector4I4F28 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, x, x); }
        public readonly Vector4I4F28 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, x, y); }
        public readonly Vector4I4F28 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, x, z); }
        public readonly Vector4I4F28 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, x, w); }
        public readonly Vector4I4F28 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, y, x); }
        public readonly Vector4I4F28 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, y, y); }
        public readonly Vector4I4F28 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, y, z); }
        public readonly Vector4I4F28 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, y, w); }
        public readonly Vector4I4F28 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, z, x); }
        public readonly Vector4I4F28 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, z, y); }
        public readonly Vector4I4F28 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, z, z); }
        public readonly Vector4I4F28 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, z, w); }
        public readonly Vector4I4F28 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, w, x); }
        public readonly Vector4I4F28 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, w, y); }
        public readonly Vector4I4F28 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, w, z); }
        public readonly Vector4I4F28 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, w, w, w); }
        public readonly Vector4I4F28 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, x, x); }
        public readonly Vector4I4F28 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, x, y); }
        public readonly Vector4I4F28 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, x, z); }
        public readonly Vector4I4F28 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, x, w); }
        public readonly Vector4I4F28 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, y, x); }
        public readonly Vector4I4F28 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, y, y); }
        public readonly Vector4I4F28 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, y, z); }
        public readonly Vector4I4F28 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, y, w); }
        public readonly Vector4I4F28 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, z, x); }
        public readonly Vector4I4F28 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, z, y); }
        public readonly Vector4I4F28 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, z, z); }
        public readonly Vector4I4F28 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, z, w); }
        public readonly Vector4I4F28 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, w, x); }
        public readonly Vector4I4F28 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, w, y); }
        public readonly Vector4I4F28 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, w, z); }
        public readonly Vector4I4F28 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, w, w); }
        public readonly Vector4I4F28 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, x, x); }
        public readonly Vector4I4F28 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, x, y); }
        public readonly Vector4I4F28 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, x, z); }
        public readonly Vector4I4F28 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, x, w); }
        public readonly Vector4I4F28 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, y, x); }
        public readonly Vector4I4F28 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, y, y); }
        public readonly Vector4I4F28 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, y, z); }
        public readonly Vector4I4F28 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, y, w); }
        public readonly Vector4I4F28 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, z, x); }
        public readonly Vector4I4F28 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, z, y); }
        public readonly Vector4I4F28 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, z, z); }
        public readonly Vector4I4F28 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, z, w); }
        public readonly Vector4I4F28 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, w, x); }
        public readonly Vector4I4F28 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, w, y); }
        public readonly Vector4I4F28 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, w, z); }
        public readonly Vector4I4F28 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, w, w); }
        public readonly Vector4I4F28 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, x, x); }
        public readonly Vector4I4F28 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, x, y); }
        public readonly Vector4I4F28 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, x, z); }
        public readonly Vector4I4F28 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, x, w); }
        public readonly Vector4I4F28 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, y, x); }
        public readonly Vector4I4F28 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, y, y); }
        public readonly Vector4I4F28 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, y, z); }
        public readonly Vector4I4F28 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, y, w); }
        public readonly Vector4I4F28 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, z, x); }
        public readonly Vector4I4F28 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, z, y); }
        public readonly Vector4I4F28 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, z, z); }
        public readonly Vector4I4F28 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, z, w); }
        public readonly Vector4I4F28 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, w, x); }
        public readonly Vector4I4F28 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, w, y); }
        public readonly Vector4I4F28 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, w, z); }
        public readonly Vector4I4F28 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, z, w, w); }
        public readonly Vector4I4F28 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, x, x); }
        public readonly Vector4I4F28 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, x, y); }
        public readonly Vector4I4F28 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, x, z); }
        public readonly Vector4I4F28 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, x, w); }
        public readonly Vector4I4F28 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, y, x); }
        public readonly Vector4I4F28 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, y, y); }
        public readonly Vector4I4F28 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, y, z); }
        public readonly Vector4I4F28 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, y, w); }
        public readonly Vector4I4F28 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, z, x); }
        public readonly Vector4I4F28 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, z, y); }
        public readonly Vector4I4F28 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, z, z); }
        public readonly Vector4I4F28 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, z, w); }
        public readonly Vector4I4F28 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, w, x); }
        public readonly Vector4I4F28 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, w, y); }
        public readonly Vector4I4F28 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, w, z); }
        public readonly Vector4I4F28 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, w, w, w); }
        public readonly Vector4I4F28 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, x, x); }
        public readonly Vector4I4F28 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, x, y); }
        public readonly Vector4I4F28 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, x, z); }
        public readonly Vector4I4F28 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, x, w); }
        public readonly Vector4I4F28 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, y, x); }
        public readonly Vector4I4F28 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, y, y); }
        public readonly Vector4I4F28 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, y, z); }
        public readonly Vector4I4F28 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, y, w); }
        public readonly Vector4I4F28 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, z, x); }
        public readonly Vector4I4F28 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, z, y); }
        public readonly Vector4I4F28 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, z, z); }
        public readonly Vector4I4F28 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, z, w); }
        public readonly Vector4I4F28 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, w, x); }
        public readonly Vector4I4F28 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, w, y); }
        public readonly Vector4I4F28 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, w, z); }
        public readonly Vector4I4F28 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, x, w, w); }
        public readonly Vector4I4F28 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, x, x); }
        public readonly Vector4I4F28 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, x, y); }
        public readonly Vector4I4F28 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, x, z); }
        public readonly Vector4I4F28 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, x, w); }
        public readonly Vector4I4F28 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, y, x); }
        public readonly Vector4I4F28 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, y, y); }
        public readonly Vector4I4F28 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, y, z); }
        public readonly Vector4I4F28 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, y, w); }
        public readonly Vector4I4F28 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, z, x); }
        public readonly Vector4I4F28 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, z, y); }
        public readonly Vector4I4F28 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, z, z); }
        public readonly Vector4I4F28 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, z, w); }
        public readonly Vector4I4F28 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, w, x); }
        public readonly Vector4I4F28 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, w, y); }
        public readonly Vector4I4F28 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, w, z); }
        public readonly Vector4I4F28 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, y, w, w); }
        public readonly Vector4I4F28 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, x, x); }
        public readonly Vector4I4F28 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, x, y); }
        public readonly Vector4I4F28 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, x, z); }
        public readonly Vector4I4F28 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, x, w); }
        public readonly Vector4I4F28 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, y, x); }
        public readonly Vector4I4F28 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, y, y); }
        public readonly Vector4I4F28 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, y, z); }
        public readonly Vector4I4F28 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, y, w); }
        public readonly Vector4I4F28 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, z, x); }
        public readonly Vector4I4F28 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, z, y); }
        public readonly Vector4I4F28 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, z, z); }
        public readonly Vector4I4F28 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, z, w); }
        public readonly Vector4I4F28 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, w, x); }
        public readonly Vector4I4F28 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, w, y); }
        public readonly Vector4I4F28 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, w, z); }
        public readonly Vector4I4F28 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, z, w, w); }
        public readonly Vector4I4F28 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, x, x); }
        public readonly Vector4I4F28 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, x, y); }
        public readonly Vector4I4F28 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, x, z); }
        public readonly Vector4I4F28 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, x, w); }
        public readonly Vector4I4F28 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, y, x); }
        public readonly Vector4I4F28 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, y, y); }
        public readonly Vector4I4F28 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, y, z); }
        public readonly Vector4I4F28 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, y, w); }
        public readonly Vector4I4F28 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, z, x); }
        public readonly Vector4I4F28 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, z, y); }
        public readonly Vector4I4F28 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, z, z); }
        public readonly Vector4I4F28 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, z, w); }
        public readonly Vector4I4F28 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, w, x); }
        public readonly Vector4I4F28 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, w, y); }
        public readonly Vector4I4F28 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, w, z); }
        public readonly Vector4I4F28 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(z, w, w, w); }
        public readonly Vector4I4F28 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, x, x); }
        public readonly Vector4I4F28 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, x, y); }
        public readonly Vector4I4F28 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, x, z); }
        public readonly Vector4I4F28 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, x, w); }
        public readonly Vector4I4F28 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, y, x); }
        public readonly Vector4I4F28 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, y, y); }
        public readonly Vector4I4F28 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, y, z); }
        public readonly Vector4I4F28 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, y, w); }
        public readonly Vector4I4F28 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, z, x); }
        public readonly Vector4I4F28 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, z, y); }
        public readonly Vector4I4F28 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, z, z); }
        public readonly Vector4I4F28 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, z, w); }
        public readonly Vector4I4F28 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, w, x); }
        public readonly Vector4I4F28 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, w, y); }
        public readonly Vector4I4F28 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, w, z); }
        public readonly Vector4I4F28 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, x, w, w); }
        public readonly Vector4I4F28 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, x, x); }
        public readonly Vector4I4F28 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, x, y); }
        public readonly Vector4I4F28 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, x, z); }
        public readonly Vector4I4F28 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, x, w); }
        public readonly Vector4I4F28 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, y, x); }
        public readonly Vector4I4F28 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, y, y); }
        public readonly Vector4I4F28 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, y, z); }
        public readonly Vector4I4F28 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, y, w); }
        public readonly Vector4I4F28 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, z, x); }
        public readonly Vector4I4F28 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, z, y); }
        public readonly Vector4I4F28 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, z, z); }
        public readonly Vector4I4F28 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, z, w); }
        public readonly Vector4I4F28 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, w, x); }
        public readonly Vector4I4F28 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, w, y); }
        public readonly Vector4I4F28 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, w, z); }
        public readonly Vector4I4F28 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, y, w, w); }
        public readonly Vector4I4F28 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, x, x); }
        public readonly Vector4I4F28 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, x, y); }
        public readonly Vector4I4F28 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, x, z); }
        public readonly Vector4I4F28 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, x, w); }
        public readonly Vector4I4F28 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, y, x); }
        public readonly Vector4I4F28 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, y, y); }
        public readonly Vector4I4F28 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, y, z); }
        public readonly Vector4I4F28 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, y, w); }
        public readonly Vector4I4F28 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, z, x); }
        public readonly Vector4I4F28 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, z, y); }
        public readonly Vector4I4F28 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, z, z); }
        public readonly Vector4I4F28 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, z, w); }
        public readonly Vector4I4F28 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, w, x); }
        public readonly Vector4I4F28 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, w, y); }
        public readonly Vector4I4F28 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, w, z); }
        public readonly Vector4I4F28 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, z, w, w); }
        public readonly Vector4I4F28 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, x, x); }
        public readonly Vector4I4F28 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, x, y); }
        public readonly Vector4I4F28 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, x, z); }
        public readonly Vector4I4F28 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, x, w); }
        public readonly Vector4I4F28 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, y, x); }
        public readonly Vector4I4F28 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, y, y); }
        public readonly Vector4I4F28 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, y, z); }
        public readonly Vector4I4F28 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, y, w); }
        public readonly Vector4I4F28 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, z, x); }
        public readonly Vector4I4F28 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, z, y); }
        public readonly Vector4I4F28 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, z, z); }
        public readonly Vector4I4F28 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, z, w); }
        public readonly Vector4I4F28 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, w, x); }
        public readonly Vector4I4F28 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, w, y); }
        public readonly Vector4I4F28 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, w, z); }
        public readonly Vector4I4F28 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I4F28 lhs, Vector4I4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I4F28 lhs, Vector4I4F28 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I4F28({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I4F28 other)
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
            return $"Vector4I4F28({x}, {y}, {z}, {w})";
        }
    }
}
