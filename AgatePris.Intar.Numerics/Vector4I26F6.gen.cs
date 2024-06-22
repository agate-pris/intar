using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I26F6 : IEquatable<Vector4I26F6>, IFormattable {
        // Fields
        // ---------------------------------------

        public I26F6 x;
        public I26F6 y;
        public I26F6 z;
        public I26F6 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I26F6 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I26F6(I26F6 x, I26F6 y, I26F6 z, I26F6 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I26F6(I26F6 x, I26F6 y, Vector2I26F6 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I26F6(I26F6 x, Vector3I26F6 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I26F6(Vector2I26F6 xy, Vector2I26F6 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I26F6(Vector4I26F6 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I26F6(I26F6 x, Vector2I26F6 yz, I26F6 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I26F6(Vector3I26F6 xyz, I26F6 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I26F6(Vector2I26F6 xy, I26F6 z, I26F6 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 operator +(Vector4I26F6 a, Vector4I26F6 b) => new Vector4I26F6(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 operator -(Vector4I26F6 a, Vector4I26F6 b) => new Vector4I26F6(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 operator *(Vector4I26F6 a, Vector4I26F6 b) => new Vector4I26F6(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 operator *(Vector4I26F6 a, I26F6 b) => new Vector4I26F6(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 operator *(I26F6 a, Vector4I26F6 b) => new Vector4I26F6(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 operator /(Vector4I26F6 a, Vector4I26F6 b) => new Vector4I26F6(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 operator /(Vector4I26F6 a, I26F6 b) => new Vector4I26F6(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 operator /(I26F6 a, Vector4I26F6 b) => new Vector4I26F6(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I26F6 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(x, x); }
        public readonly Vector2I26F6 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(x, y); }
        public readonly Vector2I26F6 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(x, z); }
        public readonly Vector2I26F6 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(x, w); }
        public readonly Vector2I26F6 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(y, x); }
        public readonly Vector2I26F6 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(y, y); }
        public readonly Vector2I26F6 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(y, z); }
        public readonly Vector2I26F6 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(y, w); }
        public readonly Vector2I26F6 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(z, x); }
        public readonly Vector2I26F6 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(z, y); }
        public readonly Vector2I26F6 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(z, z); }
        public readonly Vector2I26F6 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(z, w); }
        public readonly Vector2I26F6 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(w, x); }
        public readonly Vector2I26F6 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(w, y); }
        public readonly Vector2I26F6 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(w, z); }
        public readonly Vector2I26F6 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(w, w); }
        public readonly Vector3I26F6 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, x, x); }
        public readonly Vector3I26F6 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, x, y); }
        public readonly Vector3I26F6 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, x, z); }
        public readonly Vector3I26F6 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, x, w); }
        public readonly Vector3I26F6 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, y, x); }
        public readonly Vector3I26F6 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, y, y); }
        public readonly Vector3I26F6 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, y, z); }
        public readonly Vector3I26F6 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, y, w); }
        public readonly Vector3I26F6 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, z, x); }
        public readonly Vector3I26F6 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, z, y); }
        public readonly Vector3I26F6 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, z, z); }
        public readonly Vector3I26F6 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, z, w); }
        public readonly Vector3I26F6 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, w, x); }
        public readonly Vector3I26F6 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, w, y); }
        public readonly Vector3I26F6 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, w, z); }
        public readonly Vector3I26F6 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, w, w); }
        public readonly Vector3I26F6 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, x, x); }
        public readonly Vector3I26F6 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, x, y); }
        public readonly Vector3I26F6 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, x, z); }
        public readonly Vector3I26F6 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, x, w); }
        public readonly Vector3I26F6 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, y, x); }
        public readonly Vector3I26F6 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, y, y); }
        public readonly Vector3I26F6 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, y, z); }
        public readonly Vector3I26F6 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, y, w); }
        public readonly Vector3I26F6 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, z, x); }
        public readonly Vector3I26F6 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, z, y); }
        public readonly Vector3I26F6 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, z, z); }
        public readonly Vector3I26F6 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, z, w); }
        public readonly Vector3I26F6 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, w, x); }
        public readonly Vector3I26F6 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, w, y); }
        public readonly Vector3I26F6 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, w, z); }
        public readonly Vector3I26F6 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, w, w); }
        public readonly Vector3I26F6 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, x, x); }
        public readonly Vector3I26F6 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, x, y); }
        public readonly Vector3I26F6 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, x, z); }
        public readonly Vector3I26F6 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, x, w); }
        public readonly Vector3I26F6 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, y, x); }
        public readonly Vector3I26F6 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, y, y); }
        public readonly Vector3I26F6 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, y, z); }
        public readonly Vector3I26F6 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, y, w); }
        public readonly Vector3I26F6 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, z, x); }
        public readonly Vector3I26F6 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, z, y); }
        public readonly Vector3I26F6 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, z, z); }
        public readonly Vector3I26F6 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, z, w); }
        public readonly Vector3I26F6 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, w, x); }
        public readonly Vector3I26F6 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, w, y); }
        public readonly Vector3I26F6 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, w, z); }
        public readonly Vector3I26F6 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(z, w, w); }
        public readonly Vector3I26F6 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, x, x); }
        public readonly Vector3I26F6 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, x, y); }
        public readonly Vector3I26F6 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, x, z); }
        public readonly Vector3I26F6 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, x, w); }
        public readonly Vector3I26F6 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, y, x); }
        public readonly Vector3I26F6 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, y, y); }
        public readonly Vector3I26F6 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, y, z); }
        public readonly Vector3I26F6 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, y, w); }
        public readonly Vector3I26F6 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, z, x); }
        public readonly Vector3I26F6 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, z, y); }
        public readonly Vector3I26F6 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, z, z); }
        public readonly Vector3I26F6 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, z, w); }
        public readonly Vector3I26F6 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, w, x); }
        public readonly Vector3I26F6 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, w, y); }
        public readonly Vector3I26F6 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, w, z); }
        public readonly Vector3I26F6 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(w, w, w); }
        public readonly Vector4I26F6 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, x, x); }
        public readonly Vector4I26F6 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, x, y); }
        public readonly Vector4I26F6 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, x, z); }
        public readonly Vector4I26F6 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, x, w); }
        public readonly Vector4I26F6 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, y, x); }
        public readonly Vector4I26F6 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, y, y); }
        public readonly Vector4I26F6 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, y, z); }
        public readonly Vector4I26F6 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, y, w); }
        public readonly Vector4I26F6 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, z, x); }
        public readonly Vector4I26F6 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, z, y); }
        public readonly Vector4I26F6 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, z, z); }
        public readonly Vector4I26F6 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, z, w); }
        public readonly Vector4I26F6 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, w, x); }
        public readonly Vector4I26F6 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, w, y); }
        public readonly Vector4I26F6 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, w, z); }
        public readonly Vector4I26F6 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, w, w); }
        public readonly Vector4I26F6 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, x, x); }
        public readonly Vector4I26F6 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, x, y); }
        public readonly Vector4I26F6 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, x, z); }
        public readonly Vector4I26F6 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, x, w); }
        public readonly Vector4I26F6 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, y, x); }
        public readonly Vector4I26F6 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, y, y); }
        public readonly Vector4I26F6 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, y, z); }
        public readonly Vector4I26F6 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, y, w); }
        public readonly Vector4I26F6 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, z, x); }
        public readonly Vector4I26F6 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, z, y); }
        public readonly Vector4I26F6 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, z, z); }
        public readonly Vector4I26F6 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, z, w); }
        public readonly Vector4I26F6 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, w, x); }
        public readonly Vector4I26F6 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, w, y); }
        public readonly Vector4I26F6 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, w, z); }
        public readonly Vector4I26F6 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, w, w); }
        public readonly Vector4I26F6 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, x, x); }
        public readonly Vector4I26F6 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, x, y); }
        public readonly Vector4I26F6 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, x, z); }
        public readonly Vector4I26F6 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, x, w); }
        public readonly Vector4I26F6 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, y, x); }
        public readonly Vector4I26F6 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, y, y); }
        public readonly Vector4I26F6 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, y, z); }
        public readonly Vector4I26F6 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, y, w); }
        public readonly Vector4I26F6 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, z, x); }
        public readonly Vector4I26F6 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, z, y); }
        public readonly Vector4I26F6 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, z, z); }
        public readonly Vector4I26F6 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, z, w); }
        public readonly Vector4I26F6 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, w, x); }
        public readonly Vector4I26F6 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, w, y); }
        public readonly Vector4I26F6 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, w, z); }
        public readonly Vector4I26F6 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, z, w, w); }
        public readonly Vector4I26F6 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, x, x); }
        public readonly Vector4I26F6 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, x, y); }
        public readonly Vector4I26F6 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, x, z); }
        public readonly Vector4I26F6 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, x, w); }
        public readonly Vector4I26F6 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, y, x); }
        public readonly Vector4I26F6 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, y, y); }
        public readonly Vector4I26F6 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, y, z); }
        public readonly Vector4I26F6 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, y, w); }
        public readonly Vector4I26F6 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, z, x); }
        public readonly Vector4I26F6 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, z, y); }
        public readonly Vector4I26F6 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, z, z); }
        public readonly Vector4I26F6 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, z, w); }
        public readonly Vector4I26F6 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, w, x); }
        public readonly Vector4I26F6 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, w, y); }
        public readonly Vector4I26F6 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, w, z); }
        public readonly Vector4I26F6 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, w, w, w); }
        public readonly Vector4I26F6 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, x, x); }
        public readonly Vector4I26F6 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, x, y); }
        public readonly Vector4I26F6 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, x, z); }
        public readonly Vector4I26F6 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, x, w); }
        public readonly Vector4I26F6 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, y, x); }
        public readonly Vector4I26F6 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, y, y); }
        public readonly Vector4I26F6 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, y, z); }
        public readonly Vector4I26F6 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, y, w); }
        public readonly Vector4I26F6 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, z, x); }
        public readonly Vector4I26F6 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, z, y); }
        public readonly Vector4I26F6 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, z, z); }
        public readonly Vector4I26F6 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, z, w); }
        public readonly Vector4I26F6 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, w, x); }
        public readonly Vector4I26F6 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, w, y); }
        public readonly Vector4I26F6 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, w, z); }
        public readonly Vector4I26F6 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, w, w); }
        public readonly Vector4I26F6 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, x, x); }
        public readonly Vector4I26F6 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, x, y); }
        public readonly Vector4I26F6 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, x, z); }
        public readonly Vector4I26F6 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, x, w); }
        public readonly Vector4I26F6 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, y, x); }
        public readonly Vector4I26F6 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, y, y); }
        public readonly Vector4I26F6 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, y, z); }
        public readonly Vector4I26F6 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, y, w); }
        public readonly Vector4I26F6 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, z, x); }
        public readonly Vector4I26F6 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, z, y); }
        public readonly Vector4I26F6 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, z, z); }
        public readonly Vector4I26F6 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, z, w); }
        public readonly Vector4I26F6 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, w, x); }
        public readonly Vector4I26F6 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, w, y); }
        public readonly Vector4I26F6 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, w, z); }
        public readonly Vector4I26F6 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, w, w); }
        public readonly Vector4I26F6 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, x, x); }
        public readonly Vector4I26F6 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, x, y); }
        public readonly Vector4I26F6 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, x, z); }
        public readonly Vector4I26F6 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, x, w); }
        public readonly Vector4I26F6 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, y, x); }
        public readonly Vector4I26F6 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, y, y); }
        public readonly Vector4I26F6 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, y, z); }
        public readonly Vector4I26F6 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, y, w); }
        public readonly Vector4I26F6 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, z, x); }
        public readonly Vector4I26F6 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, z, y); }
        public readonly Vector4I26F6 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, z, z); }
        public readonly Vector4I26F6 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, z, w); }
        public readonly Vector4I26F6 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, w, x); }
        public readonly Vector4I26F6 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, w, y); }
        public readonly Vector4I26F6 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, w, z); }
        public readonly Vector4I26F6 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, z, w, w); }
        public readonly Vector4I26F6 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, x, x); }
        public readonly Vector4I26F6 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, x, y); }
        public readonly Vector4I26F6 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, x, z); }
        public readonly Vector4I26F6 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, x, w); }
        public readonly Vector4I26F6 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, y, x); }
        public readonly Vector4I26F6 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, y, y); }
        public readonly Vector4I26F6 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, y, z); }
        public readonly Vector4I26F6 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, y, w); }
        public readonly Vector4I26F6 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, z, x); }
        public readonly Vector4I26F6 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, z, y); }
        public readonly Vector4I26F6 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, z, z); }
        public readonly Vector4I26F6 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, z, w); }
        public readonly Vector4I26F6 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, w, x); }
        public readonly Vector4I26F6 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, w, y); }
        public readonly Vector4I26F6 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, w, z); }
        public readonly Vector4I26F6 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, w, w, w); }
        public readonly Vector4I26F6 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, x, x); }
        public readonly Vector4I26F6 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, x, y); }
        public readonly Vector4I26F6 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, x, z); }
        public readonly Vector4I26F6 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, x, w); }
        public readonly Vector4I26F6 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, y, x); }
        public readonly Vector4I26F6 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, y, y); }
        public readonly Vector4I26F6 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, y, z); }
        public readonly Vector4I26F6 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, y, w); }
        public readonly Vector4I26F6 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, z, x); }
        public readonly Vector4I26F6 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, z, y); }
        public readonly Vector4I26F6 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, z, z); }
        public readonly Vector4I26F6 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, z, w); }
        public readonly Vector4I26F6 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, w, x); }
        public readonly Vector4I26F6 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, w, y); }
        public readonly Vector4I26F6 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, w, z); }
        public readonly Vector4I26F6 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, x, w, w); }
        public readonly Vector4I26F6 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, x, x); }
        public readonly Vector4I26F6 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, x, y); }
        public readonly Vector4I26F6 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, x, z); }
        public readonly Vector4I26F6 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, x, w); }
        public readonly Vector4I26F6 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, y, x); }
        public readonly Vector4I26F6 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, y, y); }
        public readonly Vector4I26F6 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, y, z); }
        public readonly Vector4I26F6 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, y, w); }
        public readonly Vector4I26F6 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, z, x); }
        public readonly Vector4I26F6 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, z, y); }
        public readonly Vector4I26F6 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, z, z); }
        public readonly Vector4I26F6 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, z, w); }
        public readonly Vector4I26F6 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, w, x); }
        public readonly Vector4I26F6 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, w, y); }
        public readonly Vector4I26F6 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, w, z); }
        public readonly Vector4I26F6 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, y, w, w); }
        public readonly Vector4I26F6 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, x, x); }
        public readonly Vector4I26F6 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, x, y); }
        public readonly Vector4I26F6 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, x, z); }
        public readonly Vector4I26F6 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, x, w); }
        public readonly Vector4I26F6 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, y, x); }
        public readonly Vector4I26F6 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, y, y); }
        public readonly Vector4I26F6 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, y, z); }
        public readonly Vector4I26F6 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, y, w); }
        public readonly Vector4I26F6 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, z, x); }
        public readonly Vector4I26F6 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, z, y); }
        public readonly Vector4I26F6 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, z, z); }
        public readonly Vector4I26F6 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, z, w); }
        public readonly Vector4I26F6 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, w, x); }
        public readonly Vector4I26F6 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, w, y); }
        public readonly Vector4I26F6 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, w, z); }
        public readonly Vector4I26F6 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, z, w, w); }
        public readonly Vector4I26F6 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, x, x); }
        public readonly Vector4I26F6 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, x, y); }
        public readonly Vector4I26F6 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, x, z); }
        public readonly Vector4I26F6 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, x, w); }
        public readonly Vector4I26F6 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, y, x); }
        public readonly Vector4I26F6 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, y, y); }
        public readonly Vector4I26F6 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, y, z); }
        public readonly Vector4I26F6 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, y, w); }
        public readonly Vector4I26F6 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, z, x); }
        public readonly Vector4I26F6 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, z, y); }
        public readonly Vector4I26F6 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, z, z); }
        public readonly Vector4I26F6 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, z, w); }
        public readonly Vector4I26F6 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, w, x); }
        public readonly Vector4I26F6 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, w, y); }
        public readonly Vector4I26F6 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, w, z); }
        public readonly Vector4I26F6 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(z, w, w, w); }
        public readonly Vector4I26F6 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, x, x); }
        public readonly Vector4I26F6 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, x, y); }
        public readonly Vector4I26F6 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, x, z); }
        public readonly Vector4I26F6 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, x, w); }
        public readonly Vector4I26F6 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, y, x); }
        public readonly Vector4I26F6 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, y, y); }
        public readonly Vector4I26F6 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, y, z); }
        public readonly Vector4I26F6 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, y, w); }
        public readonly Vector4I26F6 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, z, x); }
        public readonly Vector4I26F6 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, z, y); }
        public readonly Vector4I26F6 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, z, z); }
        public readonly Vector4I26F6 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, z, w); }
        public readonly Vector4I26F6 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, w, x); }
        public readonly Vector4I26F6 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, w, y); }
        public readonly Vector4I26F6 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, w, z); }
        public readonly Vector4I26F6 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, x, w, w); }
        public readonly Vector4I26F6 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, x, x); }
        public readonly Vector4I26F6 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, x, y); }
        public readonly Vector4I26F6 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, x, z); }
        public readonly Vector4I26F6 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, x, w); }
        public readonly Vector4I26F6 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, y, x); }
        public readonly Vector4I26F6 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, y, y); }
        public readonly Vector4I26F6 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, y, z); }
        public readonly Vector4I26F6 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, y, w); }
        public readonly Vector4I26F6 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, z, x); }
        public readonly Vector4I26F6 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, z, y); }
        public readonly Vector4I26F6 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, z, z); }
        public readonly Vector4I26F6 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, z, w); }
        public readonly Vector4I26F6 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, w, x); }
        public readonly Vector4I26F6 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, w, y); }
        public readonly Vector4I26F6 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, w, z); }
        public readonly Vector4I26F6 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, y, w, w); }
        public readonly Vector4I26F6 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, x, x); }
        public readonly Vector4I26F6 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, x, y); }
        public readonly Vector4I26F6 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, x, z); }
        public readonly Vector4I26F6 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, x, w); }
        public readonly Vector4I26F6 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, y, x); }
        public readonly Vector4I26F6 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, y, y); }
        public readonly Vector4I26F6 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, y, z); }
        public readonly Vector4I26F6 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, y, w); }
        public readonly Vector4I26F6 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, z, x); }
        public readonly Vector4I26F6 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, z, y); }
        public readonly Vector4I26F6 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, z, z); }
        public readonly Vector4I26F6 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, z, w); }
        public readonly Vector4I26F6 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, w, x); }
        public readonly Vector4I26F6 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, w, y); }
        public readonly Vector4I26F6 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, w, z); }
        public readonly Vector4I26F6 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, z, w, w); }
        public readonly Vector4I26F6 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, x, x); }
        public readonly Vector4I26F6 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, x, y); }
        public readonly Vector4I26F6 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, x, z); }
        public readonly Vector4I26F6 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, x, w); }
        public readonly Vector4I26F6 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, y, x); }
        public readonly Vector4I26F6 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, y, y); }
        public readonly Vector4I26F6 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, y, z); }
        public readonly Vector4I26F6 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, y, w); }
        public readonly Vector4I26F6 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, z, x); }
        public readonly Vector4I26F6 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, z, y); }
        public readonly Vector4I26F6 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, z, z); }
        public readonly Vector4I26F6 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, z, w); }
        public readonly Vector4I26F6 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, w, x); }
        public readonly Vector4I26F6 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, w, y); }
        public readonly Vector4I26F6 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, w, z); }
        public readonly Vector4I26F6 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I26F6 lhs, Vector4I26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I26F6 lhs, Vector4I26F6 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I26F6({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I26F6 other)
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
            return $"Vector4I26F6({x}, {y}, {z}, {w})";
        }
    }
}
