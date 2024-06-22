using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I15F17 : IEquatable<Vector4I15F17>, IFormattable {
        // Fields
        // ---------------------------------------

        public I15F17 x;
        public I15F17 y;
        public I15F17 z;
        public I15F17 w;

        // Constants
        // ---------------------------------------

        public static readonly Vector4I15F17 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(I15F17 x, I15F17 y, I15F17 z, I15F17 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(I15F17 x, I15F17 y, Vector2I15F17 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(I15F17 x, Vector3I15F17 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(Vector2I15F17 xy, Vector2I15F17 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(Vector4I15F17 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(I15F17 x, Vector2I15F17 yz, I15F17 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(Vector3I15F17 xyz, I15F17 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(Vector2I15F17 xy, I15F17 z, I15F17 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator +(Vector4I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z,
            a.w + b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator -(Vector4I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z,
            a.w - b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator *(Vector4I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z,
            a.w * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator *(Vector4I15F17 a, I15F17 b) => new Vector4I15F17(
            a.x * b,
            a.y * b,
            a.z * b,
            a.w * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator *(I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a * b.x,
            a * b.y,
            a * b.z,
            a * b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator /(Vector4I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z,
            a.w / b.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator /(Vector4I15F17 a, I15F17 b) => new Vector4I15F17(
            a.x / b,
            a.y / b,
            a.z / b,
            a.w / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator /(I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a / b.x,
            a / b.y,
            a / b.z,
            a / b.w);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I15F17 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(x, x); }
        public readonly Vector2I15F17 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(x, y); }
        public readonly Vector2I15F17 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(x, z); }
        public readonly Vector2I15F17 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(x, w); }
        public readonly Vector2I15F17 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(y, x); }
        public readonly Vector2I15F17 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(y, y); }
        public readonly Vector2I15F17 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(y, z); }
        public readonly Vector2I15F17 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(y, w); }
        public readonly Vector2I15F17 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(z, x); }
        public readonly Vector2I15F17 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(z, y); }
        public readonly Vector2I15F17 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(z, z); }
        public readonly Vector2I15F17 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(z, w); }
        public readonly Vector2I15F17 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(w, x); }
        public readonly Vector2I15F17 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(w, y); }
        public readonly Vector2I15F17 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(w, z); }
        public readonly Vector2I15F17 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(w, w); }
        public readonly Vector3I15F17 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, x, x); }
        public readonly Vector3I15F17 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, x, y); }
        public readonly Vector3I15F17 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, x, z); }
        public readonly Vector3I15F17 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, x, w); }
        public readonly Vector3I15F17 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, y, x); }
        public readonly Vector3I15F17 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, y, y); }
        public readonly Vector3I15F17 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, y, z); }
        public readonly Vector3I15F17 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, y, w); }
        public readonly Vector3I15F17 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, z, x); }
        public readonly Vector3I15F17 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, z, y); }
        public readonly Vector3I15F17 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, z, z); }
        public readonly Vector3I15F17 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, z, w); }
        public readonly Vector3I15F17 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, w, x); }
        public readonly Vector3I15F17 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, w, y); }
        public readonly Vector3I15F17 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, w, z); }
        public readonly Vector3I15F17 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, w, w); }
        public readonly Vector3I15F17 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, x, x); }
        public readonly Vector3I15F17 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, x, y); }
        public readonly Vector3I15F17 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, x, z); }
        public readonly Vector3I15F17 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, x, w); }
        public readonly Vector3I15F17 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, y, x); }
        public readonly Vector3I15F17 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, y, y); }
        public readonly Vector3I15F17 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, y, z); }
        public readonly Vector3I15F17 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, y, w); }
        public readonly Vector3I15F17 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, z, x); }
        public readonly Vector3I15F17 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, z, y); }
        public readonly Vector3I15F17 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, z, z); }
        public readonly Vector3I15F17 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, z, w); }
        public readonly Vector3I15F17 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, w, x); }
        public readonly Vector3I15F17 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, w, y); }
        public readonly Vector3I15F17 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, w, z); }
        public readonly Vector3I15F17 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, w, w); }
        public readonly Vector3I15F17 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, x, x); }
        public readonly Vector3I15F17 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, x, y); }
        public readonly Vector3I15F17 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, x, z); }
        public readonly Vector3I15F17 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, x, w); }
        public readonly Vector3I15F17 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, y, x); }
        public readonly Vector3I15F17 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, y, y); }
        public readonly Vector3I15F17 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, y, z); }
        public readonly Vector3I15F17 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, y, w); }
        public readonly Vector3I15F17 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, z, x); }
        public readonly Vector3I15F17 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, z, y); }
        public readonly Vector3I15F17 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, z, z); }
        public readonly Vector3I15F17 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, z, w); }
        public readonly Vector3I15F17 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, w, x); }
        public readonly Vector3I15F17 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, w, y); }
        public readonly Vector3I15F17 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, w, z); }
        public readonly Vector3I15F17 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(z, w, w); }
        public readonly Vector3I15F17 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, x, x); }
        public readonly Vector3I15F17 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, x, y); }
        public readonly Vector3I15F17 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, x, z); }
        public readonly Vector3I15F17 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, x, w); }
        public readonly Vector3I15F17 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, y, x); }
        public readonly Vector3I15F17 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, y, y); }
        public readonly Vector3I15F17 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, y, z); }
        public readonly Vector3I15F17 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, y, w); }
        public readonly Vector3I15F17 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, z, x); }
        public readonly Vector3I15F17 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, z, y); }
        public readonly Vector3I15F17 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, z, z); }
        public readonly Vector3I15F17 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, z, w); }
        public readonly Vector3I15F17 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, w, x); }
        public readonly Vector3I15F17 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, w, y); }
        public readonly Vector3I15F17 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, w, z); }
        public readonly Vector3I15F17 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(w, w, w); }
        public readonly Vector4I15F17 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, x, x); }
        public readonly Vector4I15F17 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, x, y); }
        public readonly Vector4I15F17 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, x, z); }
        public readonly Vector4I15F17 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, x, w); }
        public readonly Vector4I15F17 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, y, x); }
        public readonly Vector4I15F17 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, y, y); }
        public readonly Vector4I15F17 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, y, z); }
        public readonly Vector4I15F17 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, y, w); }
        public readonly Vector4I15F17 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, z, x); }
        public readonly Vector4I15F17 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, z, y); }
        public readonly Vector4I15F17 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, z, z); }
        public readonly Vector4I15F17 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, z, w); }
        public readonly Vector4I15F17 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, w, x); }
        public readonly Vector4I15F17 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, w, y); }
        public readonly Vector4I15F17 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, w, z); }
        public readonly Vector4I15F17 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, w, w); }
        public readonly Vector4I15F17 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, x, x); }
        public readonly Vector4I15F17 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, x, y); }
        public readonly Vector4I15F17 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, x, z); }
        public readonly Vector4I15F17 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, x, w); }
        public readonly Vector4I15F17 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, y, x); }
        public readonly Vector4I15F17 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, y, y); }
        public readonly Vector4I15F17 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, y, z); }
        public readonly Vector4I15F17 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, y, w); }
        public readonly Vector4I15F17 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, z, x); }
        public readonly Vector4I15F17 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, z, y); }
        public readonly Vector4I15F17 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, z, z); }
        public readonly Vector4I15F17 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, z, w); }
        public readonly Vector4I15F17 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, w, x); }
        public readonly Vector4I15F17 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, w, y); }
        public readonly Vector4I15F17 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, w, z); }
        public readonly Vector4I15F17 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, w, w); }
        public readonly Vector4I15F17 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, x, x); }
        public readonly Vector4I15F17 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, x, y); }
        public readonly Vector4I15F17 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, x, z); }
        public readonly Vector4I15F17 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, x, w); }
        public readonly Vector4I15F17 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, y, x); }
        public readonly Vector4I15F17 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, y, y); }
        public readonly Vector4I15F17 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, y, z); }
        public readonly Vector4I15F17 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, y, w); }
        public readonly Vector4I15F17 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, z, x); }
        public readonly Vector4I15F17 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, z, y); }
        public readonly Vector4I15F17 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, z, z); }
        public readonly Vector4I15F17 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, z, w); }
        public readonly Vector4I15F17 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, w, x); }
        public readonly Vector4I15F17 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, w, y); }
        public readonly Vector4I15F17 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, w, z); }
        public readonly Vector4I15F17 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, z, w, w); }
        public readonly Vector4I15F17 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, x, x); }
        public readonly Vector4I15F17 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, x, y); }
        public readonly Vector4I15F17 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, x, z); }
        public readonly Vector4I15F17 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, x, w); }
        public readonly Vector4I15F17 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, y, x); }
        public readonly Vector4I15F17 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, y, y); }
        public readonly Vector4I15F17 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, y, z); }
        public readonly Vector4I15F17 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, y, w); }
        public readonly Vector4I15F17 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, z, x); }
        public readonly Vector4I15F17 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, z, y); }
        public readonly Vector4I15F17 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, z, z); }
        public readonly Vector4I15F17 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, z, w); }
        public readonly Vector4I15F17 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, w, x); }
        public readonly Vector4I15F17 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, w, y); }
        public readonly Vector4I15F17 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, w, z); }
        public readonly Vector4I15F17 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, w, w, w); }
        public readonly Vector4I15F17 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, x, x); }
        public readonly Vector4I15F17 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, x, y); }
        public readonly Vector4I15F17 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, x, z); }
        public readonly Vector4I15F17 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, x, w); }
        public readonly Vector4I15F17 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, y, x); }
        public readonly Vector4I15F17 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, y, y); }
        public readonly Vector4I15F17 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, y, z); }
        public readonly Vector4I15F17 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, y, w); }
        public readonly Vector4I15F17 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, z, x); }
        public readonly Vector4I15F17 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, z, y); }
        public readonly Vector4I15F17 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, z, z); }
        public readonly Vector4I15F17 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, z, w); }
        public readonly Vector4I15F17 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, w, x); }
        public readonly Vector4I15F17 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, w, y); }
        public readonly Vector4I15F17 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, w, z); }
        public readonly Vector4I15F17 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, w, w); }
        public readonly Vector4I15F17 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, x, x); }
        public readonly Vector4I15F17 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, x, y); }
        public readonly Vector4I15F17 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, x, z); }
        public readonly Vector4I15F17 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, x, w); }
        public readonly Vector4I15F17 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, y, x); }
        public readonly Vector4I15F17 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, y, y); }
        public readonly Vector4I15F17 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, y, z); }
        public readonly Vector4I15F17 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, y, w); }
        public readonly Vector4I15F17 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, z, x); }
        public readonly Vector4I15F17 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, z, y); }
        public readonly Vector4I15F17 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, z, z); }
        public readonly Vector4I15F17 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, z, w); }
        public readonly Vector4I15F17 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, w, x); }
        public readonly Vector4I15F17 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, w, y); }
        public readonly Vector4I15F17 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, w, z); }
        public readonly Vector4I15F17 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, w, w); }
        public readonly Vector4I15F17 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, x, x); }
        public readonly Vector4I15F17 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, x, y); }
        public readonly Vector4I15F17 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, x, z); }
        public readonly Vector4I15F17 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, x, w); }
        public readonly Vector4I15F17 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, y, x); }
        public readonly Vector4I15F17 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, y, y); }
        public readonly Vector4I15F17 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, y, z); }
        public readonly Vector4I15F17 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, y, w); }
        public readonly Vector4I15F17 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, z, x); }
        public readonly Vector4I15F17 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, z, y); }
        public readonly Vector4I15F17 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, z, z); }
        public readonly Vector4I15F17 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, z, w); }
        public readonly Vector4I15F17 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, w, x); }
        public readonly Vector4I15F17 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, w, y); }
        public readonly Vector4I15F17 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, w, z); }
        public readonly Vector4I15F17 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, z, w, w); }
        public readonly Vector4I15F17 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, x, x); }
        public readonly Vector4I15F17 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, x, y); }
        public readonly Vector4I15F17 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, x, z); }
        public readonly Vector4I15F17 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, x, w); }
        public readonly Vector4I15F17 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, y, x); }
        public readonly Vector4I15F17 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, y, y); }
        public readonly Vector4I15F17 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, y, z); }
        public readonly Vector4I15F17 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, y, w); }
        public readonly Vector4I15F17 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, z, x); }
        public readonly Vector4I15F17 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, z, y); }
        public readonly Vector4I15F17 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, z, z); }
        public readonly Vector4I15F17 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, z, w); }
        public readonly Vector4I15F17 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, w, x); }
        public readonly Vector4I15F17 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, w, y); }
        public readonly Vector4I15F17 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, w, z); }
        public readonly Vector4I15F17 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, w, w, w); }
        public readonly Vector4I15F17 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, x, x); }
        public readonly Vector4I15F17 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, x, y); }
        public readonly Vector4I15F17 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, x, z); }
        public readonly Vector4I15F17 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, x, w); }
        public readonly Vector4I15F17 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, y, x); }
        public readonly Vector4I15F17 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, y, y); }
        public readonly Vector4I15F17 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, y, z); }
        public readonly Vector4I15F17 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, y, w); }
        public readonly Vector4I15F17 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, z, x); }
        public readonly Vector4I15F17 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, z, y); }
        public readonly Vector4I15F17 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, z, z); }
        public readonly Vector4I15F17 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, z, w); }
        public readonly Vector4I15F17 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, w, x); }
        public readonly Vector4I15F17 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, w, y); }
        public readonly Vector4I15F17 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, w, z); }
        public readonly Vector4I15F17 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, x, w, w); }
        public readonly Vector4I15F17 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, x, x); }
        public readonly Vector4I15F17 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, x, y); }
        public readonly Vector4I15F17 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, x, z); }
        public readonly Vector4I15F17 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, x, w); }
        public readonly Vector4I15F17 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, y, x); }
        public readonly Vector4I15F17 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, y, y); }
        public readonly Vector4I15F17 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, y, z); }
        public readonly Vector4I15F17 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, y, w); }
        public readonly Vector4I15F17 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, z, x); }
        public readonly Vector4I15F17 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, z, y); }
        public readonly Vector4I15F17 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, z, z); }
        public readonly Vector4I15F17 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, z, w); }
        public readonly Vector4I15F17 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, w, x); }
        public readonly Vector4I15F17 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, w, y); }
        public readonly Vector4I15F17 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, w, z); }
        public readonly Vector4I15F17 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, y, w, w); }
        public readonly Vector4I15F17 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, x, x); }
        public readonly Vector4I15F17 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, x, y); }
        public readonly Vector4I15F17 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, x, z); }
        public readonly Vector4I15F17 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, x, w); }
        public readonly Vector4I15F17 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, y, x); }
        public readonly Vector4I15F17 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, y, y); }
        public readonly Vector4I15F17 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, y, z); }
        public readonly Vector4I15F17 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, y, w); }
        public readonly Vector4I15F17 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, z, x); }
        public readonly Vector4I15F17 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, z, y); }
        public readonly Vector4I15F17 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, z, z); }
        public readonly Vector4I15F17 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, z, w); }
        public readonly Vector4I15F17 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, w, x); }
        public readonly Vector4I15F17 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, w, y); }
        public readonly Vector4I15F17 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, w, z); }
        public readonly Vector4I15F17 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, z, w, w); }
        public readonly Vector4I15F17 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, x, x); }
        public readonly Vector4I15F17 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, x, y); }
        public readonly Vector4I15F17 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, x, z); }
        public readonly Vector4I15F17 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, x, w); }
        public readonly Vector4I15F17 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, y, x); }
        public readonly Vector4I15F17 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, y, y); }
        public readonly Vector4I15F17 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, y, z); }
        public readonly Vector4I15F17 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, y, w); }
        public readonly Vector4I15F17 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, z, x); }
        public readonly Vector4I15F17 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, z, y); }
        public readonly Vector4I15F17 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, z, z); }
        public readonly Vector4I15F17 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, z, w); }
        public readonly Vector4I15F17 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, w, x); }
        public readonly Vector4I15F17 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, w, y); }
        public readonly Vector4I15F17 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, w, z); }
        public readonly Vector4I15F17 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(z, w, w, w); }
        public readonly Vector4I15F17 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, x, x); }
        public readonly Vector4I15F17 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, x, y); }
        public readonly Vector4I15F17 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, x, z); }
        public readonly Vector4I15F17 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, x, w); }
        public readonly Vector4I15F17 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, y, x); }
        public readonly Vector4I15F17 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, y, y); }
        public readonly Vector4I15F17 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, y, z); }
        public readonly Vector4I15F17 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, y, w); }
        public readonly Vector4I15F17 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, z, x); }
        public readonly Vector4I15F17 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, z, y); }
        public readonly Vector4I15F17 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, z, z); }
        public readonly Vector4I15F17 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, z, w); }
        public readonly Vector4I15F17 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, w, x); }
        public readonly Vector4I15F17 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, w, y); }
        public readonly Vector4I15F17 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, w, z); }
        public readonly Vector4I15F17 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, x, w, w); }
        public readonly Vector4I15F17 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, x, x); }
        public readonly Vector4I15F17 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, x, y); }
        public readonly Vector4I15F17 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, x, z); }
        public readonly Vector4I15F17 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, x, w); }
        public readonly Vector4I15F17 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, y, x); }
        public readonly Vector4I15F17 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, y, y); }
        public readonly Vector4I15F17 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, y, z); }
        public readonly Vector4I15F17 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, y, w); }
        public readonly Vector4I15F17 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, z, x); }
        public readonly Vector4I15F17 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, z, y); }
        public readonly Vector4I15F17 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, z, z); }
        public readonly Vector4I15F17 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, z, w); }
        public readonly Vector4I15F17 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, w, x); }
        public readonly Vector4I15F17 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, w, y); }
        public readonly Vector4I15F17 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, w, z); }
        public readonly Vector4I15F17 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, y, w, w); }
        public readonly Vector4I15F17 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, x, x); }
        public readonly Vector4I15F17 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, x, y); }
        public readonly Vector4I15F17 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, x, z); }
        public readonly Vector4I15F17 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, x, w); }
        public readonly Vector4I15F17 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, y, x); }
        public readonly Vector4I15F17 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, y, y); }
        public readonly Vector4I15F17 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, y, z); }
        public readonly Vector4I15F17 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, y, w); }
        public readonly Vector4I15F17 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, z, x); }
        public readonly Vector4I15F17 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, z, y); }
        public readonly Vector4I15F17 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, z, z); }
        public readonly Vector4I15F17 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, z, w); }
        public readonly Vector4I15F17 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, w, x); }
        public readonly Vector4I15F17 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, w, y); }
        public readonly Vector4I15F17 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, w, z); }
        public readonly Vector4I15F17 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, z, w, w); }
        public readonly Vector4I15F17 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, x, x); }
        public readonly Vector4I15F17 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, x, y); }
        public readonly Vector4I15F17 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, x, z); }
        public readonly Vector4I15F17 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, x, w); }
        public readonly Vector4I15F17 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, y, x); }
        public readonly Vector4I15F17 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, y, y); }
        public readonly Vector4I15F17 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, y, z); }
        public readonly Vector4I15F17 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, y, w); }
        public readonly Vector4I15F17 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, z, x); }
        public readonly Vector4I15F17 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, z, y); }
        public readonly Vector4I15F17 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, z, z); }
        public readonly Vector4I15F17 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, z, w); }
        public readonly Vector4I15F17 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, w, x); }
        public readonly Vector4I15F17 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, w, y); }
        public readonly Vector4I15F17 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, w, z); }
        public readonly Vector4I15F17 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(w, w, w, w); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I15F17 lhs, Vector4I15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I15F17 lhs, Vector4I15F17 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I15F17({x}, {y}, {z}, {w})";

        // IEquatable<Vector4I15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I15F17 other)
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
            return $"Vector4I15F17({x}, {y}, {z}, {w})";
        }
    }
}
