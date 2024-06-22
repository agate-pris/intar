using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I8F24 : IEquatable<Vector4I8F24>, IFormattable {
        // Fields
        // ---------------------------------------

        public I8F24 x;
        public I8F24 y;
        public I8F24 z;
        public I8F24 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I8F24 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(I8F24 x, I8F24 y, I8F24 z, I8F24 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(I8F24 x, I8F24 y, Vector2I8F24 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(I8F24 x, Vector3I8F24 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(Vector2I8F24 xy, Vector2I8F24 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(Vector4I8F24 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(I8F24 x, Vector2I8F24 yz, I8F24 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(Vector3I8F24 xyz, I8F24 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(Vector2I8F24 xy, I8F24 z, I8F24 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator +(Vector4I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator -(Vector4I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator *(Vector4I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator *(Vector4I8F24 a, I8F24 b) => new Vector4I8F24(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator *(I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator /(Vector4I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator /(Vector4I8F24 a, I8F24 b) => new Vector4I8F24(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator /(I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I8F24 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(x, x); }
        public readonly Vector2I8F24 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(x, y); }
        public readonly Vector2I8F24 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(x, z); }
        public readonly Vector2I8F24 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(x, w); }
        public readonly Vector2I8F24 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(y, x); }
        public readonly Vector2I8F24 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(y, y); }
        public readonly Vector2I8F24 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(y, z); }
        public readonly Vector2I8F24 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(y, w); }
        public readonly Vector2I8F24 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(z, x); }
        public readonly Vector2I8F24 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(z, y); }
        public readonly Vector2I8F24 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(z, z); }
        public readonly Vector2I8F24 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(z, w); }
        public readonly Vector2I8F24 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(w, x); }
        public readonly Vector2I8F24 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(w, y); }
        public readonly Vector2I8F24 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(w, z); }
        public readonly Vector2I8F24 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(w, w); }
        public readonly Vector3I8F24 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, x, x); }
        public readonly Vector3I8F24 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, x, y); }
        public readonly Vector3I8F24 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, x, z); }
        public readonly Vector3I8F24 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, x, w); }
        public readonly Vector3I8F24 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, y, x); }
        public readonly Vector3I8F24 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, y, y); }
        public readonly Vector3I8F24 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, y, z); }
        public readonly Vector3I8F24 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, y, w); }
        public readonly Vector3I8F24 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, z, x); }
        public readonly Vector3I8F24 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, z, y); }
        public readonly Vector3I8F24 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, z, z); }
        public readonly Vector3I8F24 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, z, w); }
        public readonly Vector3I8F24 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, w, x); }
        public readonly Vector3I8F24 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, w, y); }
        public readonly Vector3I8F24 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, w, z); }
        public readonly Vector3I8F24 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, w, w); }
        public readonly Vector3I8F24 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, x, x); }
        public readonly Vector3I8F24 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, x, y); }
        public readonly Vector3I8F24 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, x, z); }
        public readonly Vector3I8F24 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, x, w); }
        public readonly Vector3I8F24 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, y, x); }
        public readonly Vector3I8F24 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, y, y); }
        public readonly Vector3I8F24 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, y, z); }
        public readonly Vector3I8F24 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, y, w); }
        public readonly Vector3I8F24 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, z, x); }
        public readonly Vector3I8F24 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, z, y); }
        public readonly Vector3I8F24 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, z, z); }
        public readonly Vector3I8F24 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, z, w); }
        public readonly Vector3I8F24 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, w, x); }
        public readonly Vector3I8F24 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, w, y); }
        public readonly Vector3I8F24 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, w, z); }
        public readonly Vector3I8F24 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, w, w); }
        public readonly Vector3I8F24 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, x, x); }
        public readonly Vector3I8F24 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, x, y); }
        public readonly Vector3I8F24 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, x, z); }
        public readonly Vector3I8F24 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, x, w); }
        public readonly Vector3I8F24 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, y, x); }
        public readonly Vector3I8F24 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, y, y); }
        public readonly Vector3I8F24 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, y, z); }
        public readonly Vector3I8F24 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, y, w); }
        public readonly Vector3I8F24 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, z, x); }
        public readonly Vector3I8F24 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, z, y); }
        public readonly Vector3I8F24 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, z, z); }
        public readonly Vector3I8F24 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, z, w); }
        public readonly Vector3I8F24 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, w, x); }
        public readonly Vector3I8F24 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, w, y); }
        public readonly Vector3I8F24 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, w, z); }
        public readonly Vector3I8F24 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, w, w); }
        public readonly Vector3I8F24 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, x, x); }
        public readonly Vector3I8F24 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, x, y); }
        public readonly Vector3I8F24 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, x, z); }
        public readonly Vector3I8F24 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, x, w); }
        public readonly Vector3I8F24 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, y, x); }
        public readonly Vector3I8F24 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, y, y); }
        public readonly Vector3I8F24 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, y, z); }
        public readonly Vector3I8F24 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, y, w); }
        public readonly Vector3I8F24 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, z, x); }
        public readonly Vector3I8F24 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, z, y); }
        public readonly Vector3I8F24 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, z, z); }
        public readonly Vector3I8F24 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, z, w); }
        public readonly Vector3I8F24 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, w, x); }
        public readonly Vector3I8F24 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, w, y); }
        public readonly Vector3I8F24 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, w, z); }
        public readonly Vector3I8F24 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(w, w, w); }
        public readonly Vector4I8F24 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, x, x); }
        public readonly Vector4I8F24 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, x, y); }
        public readonly Vector4I8F24 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, x, z); }
        public readonly Vector4I8F24 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, x, w); }
        public readonly Vector4I8F24 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, y, x); }
        public readonly Vector4I8F24 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, y, y); }
        public readonly Vector4I8F24 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, y, z); }
        public readonly Vector4I8F24 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, y, w); }
        public readonly Vector4I8F24 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, z, x); }
        public readonly Vector4I8F24 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, z, y); }
        public readonly Vector4I8F24 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, z, z); }
        public readonly Vector4I8F24 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, z, w); }
        public readonly Vector4I8F24 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, w, x); }
        public readonly Vector4I8F24 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, w, y); }
        public readonly Vector4I8F24 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, w, z); }
        public readonly Vector4I8F24 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, w, w); }
        public readonly Vector4I8F24 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, x, x); }
        public readonly Vector4I8F24 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, x, y); }
        public readonly Vector4I8F24 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, x, z); }
        public readonly Vector4I8F24 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, x, w); }
        public readonly Vector4I8F24 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, y, x); }
        public readonly Vector4I8F24 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, y, y); }
        public readonly Vector4I8F24 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, y, z); }
        public readonly Vector4I8F24 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, y, w); }
        public readonly Vector4I8F24 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, z, x); }
        public readonly Vector4I8F24 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, z, y); }
        public readonly Vector4I8F24 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, z, z); }
        public readonly Vector4I8F24 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, z, w); }
        public readonly Vector4I8F24 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, w, x); }
        public readonly Vector4I8F24 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, w, y); }
        public readonly Vector4I8F24 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, w, z); }
        public readonly Vector4I8F24 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, w, w); }
        public readonly Vector4I8F24 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, x, x); }
        public readonly Vector4I8F24 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, x, y); }
        public readonly Vector4I8F24 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, x, z); }
        public readonly Vector4I8F24 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, x, w); }
        public readonly Vector4I8F24 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, y, x); }
        public readonly Vector4I8F24 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, y, y); }
        public readonly Vector4I8F24 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, y, z); }
        public readonly Vector4I8F24 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, y, w); }
        public readonly Vector4I8F24 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, z, x); }
        public readonly Vector4I8F24 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, z, y); }
        public readonly Vector4I8F24 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, z, z); }
        public readonly Vector4I8F24 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, z, w); }
        public readonly Vector4I8F24 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, w, x); }
        public readonly Vector4I8F24 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, w, y); }
        public readonly Vector4I8F24 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, w, z); }
        public readonly Vector4I8F24 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, w, w); }
        public readonly Vector4I8F24 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, x, x); }
        public readonly Vector4I8F24 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, x, y); }
        public readonly Vector4I8F24 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, x, z); }
        public readonly Vector4I8F24 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, x, w); }
        public readonly Vector4I8F24 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, y, x); }
        public readonly Vector4I8F24 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, y, y); }
        public readonly Vector4I8F24 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, y, z); }
        public readonly Vector4I8F24 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, y, w); }
        public readonly Vector4I8F24 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, z, x); }
        public readonly Vector4I8F24 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, z, y); }
        public readonly Vector4I8F24 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, z, z); }
        public readonly Vector4I8F24 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, z, w); }
        public readonly Vector4I8F24 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, w, x); }
        public readonly Vector4I8F24 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, w, y); }
        public readonly Vector4I8F24 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, w, z); }
        public readonly Vector4I8F24 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, w, w, w); }
        public readonly Vector4I8F24 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, x, x); }
        public readonly Vector4I8F24 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, x, y); }
        public readonly Vector4I8F24 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, x, z); }
        public readonly Vector4I8F24 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, x, w); }
        public readonly Vector4I8F24 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, y, x); }
        public readonly Vector4I8F24 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, y, y); }
        public readonly Vector4I8F24 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, y, z); }
        public readonly Vector4I8F24 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, y, w); }
        public readonly Vector4I8F24 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, z, x); }
        public readonly Vector4I8F24 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, z, y); }
        public readonly Vector4I8F24 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, z, z); }
        public readonly Vector4I8F24 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, z, w); }
        public readonly Vector4I8F24 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, w, x); }
        public readonly Vector4I8F24 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, w, y); }
        public readonly Vector4I8F24 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, w, z); }
        public readonly Vector4I8F24 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, w, w); }
        public readonly Vector4I8F24 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, x, x); }
        public readonly Vector4I8F24 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, x, y); }
        public readonly Vector4I8F24 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, x, z); }
        public readonly Vector4I8F24 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, x, w); }
        public readonly Vector4I8F24 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, y, x); }
        public readonly Vector4I8F24 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, y, y); }
        public readonly Vector4I8F24 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, y, z); }
        public readonly Vector4I8F24 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, y, w); }
        public readonly Vector4I8F24 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, z, x); }
        public readonly Vector4I8F24 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, z, y); }
        public readonly Vector4I8F24 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, z, z); }
        public readonly Vector4I8F24 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, z, w); }
        public readonly Vector4I8F24 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, w, x); }
        public readonly Vector4I8F24 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, w, y); }
        public readonly Vector4I8F24 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, w, z); }
        public readonly Vector4I8F24 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, w, w); }
        public readonly Vector4I8F24 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, x, x); }
        public readonly Vector4I8F24 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, x, y); }
        public readonly Vector4I8F24 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, x, z); }
        public readonly Vector4I8F24 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, x, w); }
        public readonly Vector4I8F24 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, y, x); }
        public readonly Vector4I8F24 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, y, y); }
        public readonly Vector4I8F24 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, y, z); }
        public readonly Vector4I8F24 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, y, w); }
        public readonly Vector4I8F24 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, z, x); }
        public readonly Vector4I8F24 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, z, y); }
        public readonly Vector4I8F24 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, z, z); }
        public readonly Vector4I8F24 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, z, w); }
        public readonly Vector4I8F24 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, w, x); }
        public readonly Vector4I8F24 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, w, y); }
        public readonly Vector4I8F24 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, w, z); }
        public readonly Vector4I8F24 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, w, w); }
        public readonly Vector4I8F24 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, x, x); }
        public readonly Vector4I8F24 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, x, y); }
        public readonly Vector4I8F24 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, x, z); }
        public readonly Vector4I8F24 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, x, w); }
        public readonly Vector4I8F24 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, y, x); }
        public readonly Vector4I8F24 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, y, y); }
        public readonly Vector4I8F24 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, y, z); }
        public readonly Vector4I8F24 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, y, w); }
        public readonly Vector4I8F24 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, z, x); }
        public readonly Vector4I8F24 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, z, y); }
        public readonly Vector4I8F24 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, z, z); }
        public readonly Vector4I8F24 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, z, w); }
        public readonly Vector4I8F24 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, w, x); }
        public readonly Vector4I8F24 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, w, y); }
        public readonly Vector4I8F24 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, w, z); }
        public readonly Vector4I8F24 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, w, w, w); }
        public readonly Vector4I8F24 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, x, x); }
        public readonly Vector4I8F24 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, x, y); }
        public readonly Vector4I8F24 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, x, z); }
        public readonly Vector4I8F24 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, x, w); }
        public readonly Vector4I8F24 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, y, x); }
        public readonly Vector4I8F24 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, y, y); }
        public readonly Vector4I8F24 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, y, z); }
        public readonly Vector4I8F24 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, y, w); }
        public readonly Vector4I8F24 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, z, x); }
        public readonly Vector4I8F24 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, z, y); }
        public readonly Vector4I8F24 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, z, z); }
        public readonly Vector4I8F24 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, z, w); }
        public readonly Vector4I8F24 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, w, x); }
        public readonly Vector4I8F24 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, w, y); }
        public readonly Vector4I8F24 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, w, z); }
        public readonly Vector4I8F24 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, w, w); }
        public readonly Vector4I8F24 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, x, x); }
        public readonly Vector4I8F24 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, x, y); }
        public readonly Vector4I8F24 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, x, z); }
        public readonly Vector4I8F24 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, x, w); }
        public readonly Vector4I8F24 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, y, x); }
        public readonly Vector4I8F24 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, y, y); }
        public readonly Vector4I8F24 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, y, z); }
        public readonly Vector4I8F24 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, y, w); }
        public readonly Vector4I8F24 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, z, x); }
        public readonly Vector4I8F24 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, z, y); }
        public readonly Vector4I8F24 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, z, z); }
        public readonly Vector4I8F24 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, z, w); }
        public readonly Vector4I8F24 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, w, x); }
        public readonly Vector4I8F24 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, w, y); }
        public readonly Vector4I8F24 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, w, z); }
        public readonly Vector4I8F24 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, w, w); }
        public readonly Vector4I8F24 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, x, x); }
        public readonly Vector4I8F24 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, x, y); }
        public readonly Vector4I8F24 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, x, z); }
        public readonly Vector4I8F24 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, x, w); }
        public readonly Vector4I8F24 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, y, x); }
        public readonly Vector4I8F24 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, y, y); }
        public readonly Vector4I8F24 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, y, z); }
        public readonly Vector4I8F24 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, y, w); }
        public readonly Vector4I8F24 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, z, x); }
        public readonly Vector4I8F24 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, z, y); }
        public readonly Vector4I8F24 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, z, z); }
        public readonly Vector4I8F24 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, z, w); }
        public readonly Vector4I8F24 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, w, x); }
        public readonly Vector4I8F24 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, w, y); }
        public readonly Vector4I8F24 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, w, z); }
        public readonly Vector4I8F24 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, w, w); }
        public readonly Vector4I8F24 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, x, x); }
        public readonly Vector4I8F24 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, x, y); }
        public readonly Vector4I8F24 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, x, z); }
        public readonly Vector4I8F24 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, x, w); }
        public readonly Vector4I8F24 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, y, x); }
        public readonly Vector4I8F24 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, y, y); }
        public readonly Vector4I8F24 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, y, z); }
        public readonly Vector4I8F24 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, y, w); }
        public readonly Vector4I8F24 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, z, x); }
        public readonly Vector4I8F24 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, z, y); }
        public readonly Vector4I8F24 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, z, z); }
        public readonly Vector4I8F24 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, z, w); }
        public readonly Vector4I8F24 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, w, x); }
        public readonly Vector4I8F24 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, w, y); }
        public readonly Vector4I8F24 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, w, z); }
        public readonly Vector4I8F24 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, w, w, w); }
        public readonly Vector4I8F24 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, x, x); }
        public readonly Vector4I8F24 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, x, y); }
        public readonly Vector4I8F24 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, x, z); }
        public readonly Vector4I8F24 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, x, w); }
        public readonly Vector4I8F24 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, y, x); }
        public readonly Vector4I8F24 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, y, y); }
        public readonly Vector4I8F24 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, y, z); }
        public readonly Vector4I8F24 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, y, w); }
        public readonly Vector4I8F24 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, z, x); }
        public readonly Vector4I8F24 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, z, y); }
        public readonly Vector4I8F24 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, z, z); }
        public readonly Vector4I8F24 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, z, w); }
        public readonly Vector4I8F24 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, w, x); }
        public readonly Vector4I8F24 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, w, y); }
        public readonly Vector4I8F24 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, w, z); }
        public readonly Vector4I8F24 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, x, w, w); }
        public readonly Vector4I8F24 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, x, x); }
        public readonly Vector4I8F24 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, x, y); }
        public readonly Vector4I8F24 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, x, z); }
        public readonly Vector4I8F24 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, x, w); }
        public readonly Vector4I8F24 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, y, x); }
        public readonly Vector4I8F24 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, y, y); }
        public readonly Vector4I8F24 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, y, z); }
        public readonly Vector4I8F24 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, y, w); }
        public readonly Vector4I8F24 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, z, x); }
        public readonly Vector4I8F24 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, z, y); }
        public readonly Vector4I8F24 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, z, z); }
        public readonly Vector4I8F24 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, z, w); }
        public readonly Vector4I8F24 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, w, x); }
        public readonly Vector4I8F24 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, w, y); }
        public readonly Vector4I8F24 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, w, z); }
        public readonly Vector4I8F24 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, y, w, w); }
        public readonly Vector4I8F24 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, x, x); }
        public readonly Vector4I8F24 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, x, y); }
        public readonly Vector4I8F24 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, x, z); }
        public readonly Vector4I8F24 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, x, w); }
        public readonly Vector4I8F24 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, y, x); }
        public readonly Vector4I8F24 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, y, y); }
        public readonly Vector4I8F24 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, y, z); }
        public readonly Vector4I8F24 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, y, w); }
        public readonly Vector4I8F24 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, z, x); }
        public readonly Vector4I8F24 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, z, y); }
        public readonly Vector4I8F24 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, z, z); }
        public readonly Vector4I8F24 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, z, w); }
        public readonly Vector4I8F24 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, w, x); }
        public readonly Vector4I8F24 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, w, y); }
        public readonly Vector4I8F24 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, w, z); }
        public readonly Vector4I8F24 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, z, w, w); }
        public readonly Vector4I8F24 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, x, x); }
        public readonly Vector4I8F24 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, x, y); }
        public readonly Vector4I8F24 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, x, z); }
        public readonly Vector4I8F24 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, x, w); }
        public readonly Vector4I8F24 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, y, x); }
        public readonly Vector4I8F24 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, y, y); }
        public readonly Vector4I8F24 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, y, z); }
        public readonly Vector4I8F24 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, y, w); }
        public readonly Vector4I8F24 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, z, x); }
        public readonly Vector4I8F24 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, z, y); }
        public readonly Vector4I8F24 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, z, z); }
        public readonly Vector4I8F24 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, z, w); }
        public readonly Vector4I8F24 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, w, x); }
        public readonly Vector4I8F24 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, w, y); }
        public readonly Vector4I8F24 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, w, z); }
        public readonly Vector4I8F24 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I8F24 lhs, Vector4I8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I8F24 lhs, Vector4I8F24 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I8F24({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I8F24 other)
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
            return $"Vector4I8F24({x}, {y}, {z}, {w})";
        }
    }
}
