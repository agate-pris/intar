using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I29F3 : IEquatable<Vector4I29F3>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I29F3 X;
        public I29F3 Y;
        public I29F3 Z;
        public I29F3 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(I29F3 x, I29F3 y, I29F3 z, I29F3 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(I29F3 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(I29F3 x, I29F3 y, Vector2I29F3 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(I29F3 x, Vector3I29F3 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(Vector2I29F3 xy, Vector2I29F3 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(Vector4I29F3 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(I29F3 x, Vector2I29F3 yz, I29F3 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(Vector3I29F3 xyz, I29F3 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(Vector2I29F3 xy, I29F3 z, I29F3 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I29F3 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I29F3(I29F3.Zero);
        }
        public static Vector4I29F3 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I29F3(I29F3.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator +(Vector4I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator -(Vector4I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator *(Vector4I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator *(Vector4I29F3 a, I29F3 b) => new Vector4I29F3(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator *(I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator /(Vector4I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator /(Vector4I29F3 a, I29F3 b) => new Vector4I29F3(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator /(I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I29F3 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, X); }
        public readonly Vector2I29F3 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, Y); }
        public readonly Vector2I29F3 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, Z); }
        public readonly Vector2I29F3 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, W); }
        public readonly Vector2I29F3 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, X); }
        public readonly Vector2I29F3 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, Y); }
        public readonly Vector2I29F3 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, Z); }
        public readonly Vector2I29F3 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, W); }
        public readonly Vector2I29F3 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, X); }
        public readonly Vector2I29F3 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, Y); }
        public readonly Vector2I29F3 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, Z); }
        public readonly Vector2I29F3 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, W); }
        public readonly Vector2I29F3 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(W, X); }
        public readonly Vector2I29F3 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(W, Y); }
        public readonly Vector2I29F3 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(W, Z); }
        public readonly Vector2I29F3 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(W, W); }
        public readonly Vector3I29F3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, X); }
        public readonly Vector3I29F3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, Y); }
        public readonly Vector3I29F3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, Z); }
        public readonly Vector3I29F3 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, W); }
        public readonly Vector3I29F3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, X); }
        public readonly Vector3I29F3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, Y); }
        public readonly Vector3I29F3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, Z); }
        public readonly Vector3I29F3 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, W); }
        public readonly Vector3I29F3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, X); }
        public readonly Vector3I29F3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, Y); }
        public readonly Vector3I29F3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, Z); }
        public readonly Vector3I29F3 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, W); }
        public readonly Vector3I29F3 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, W, X); }
        public readonly Vector3I29F3 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, W, Y); }
        public readonly Vector3I29F3 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, W, Z); }
        public readonly Vector3I29F3 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, W, W); }
        public readonly Vector3I29F3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, X); }
        public readonly Vector3I29F3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, Y); }
        public readonly Vector3I29F3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, Z); }
        public readonly Vector3I29F3 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, W); }
        public readonly Vector3I29F3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, X); }
        public readonly Vector3I29F3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, Y); }
        public readonly Vector3I29F3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, Z); }
        public readonly Vector3I29F3 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, W); }
        public readonly Vector3I29F3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, X); }
        public readonly Vector3I29F3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, Y); }
        public readonly Vector3I29F3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, Z); }
        public readonly Vector3I29F3 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, W); }
        public readonly Vector3I29F3 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, W, X); }
        public readonly Vector3I29F3 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, W, Y); }
        public readonly Vector3I29F3 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, W, Z); }
        public readonly Vector3I29F3 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, W, W); }
        public readonly Vector3I29F3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, X); }
        public readonly Vector3I29F3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, Y); }
        public readonly Vector3I29F3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, Z); }
        public readonly Vector3I29F3 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, W); }
        public readonly Vector3I29F3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, X); }
        public readonly Vector3I29F3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, Y); }
        public readonly Vector3I29F3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, Z); }
        public readonly Vector3I29F3 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, W); }
        public readonly Vector3I29F3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, X); }
        public readonly Vector3I29F3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, Y); }
        public readonly Vector3I29F3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, Z); }
        public readonly Vector3I29F3 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, W); }
        public readonly Vector3I29F3 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, W, X); }
        public readonly Vector3I29F3 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, W, Y); }
        public readonly Vector3I29F3 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, W, Z); }
        public readonly Vector3I29F3 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, W, W); }
        public readonly Vector3I29F3 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, X, X); }
        public readonly Vector3I29F3 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, X, Y); }
        public readonly Vector3I29F3 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, X, Z); }
        public readonly Vector3I29F3 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, X, W); }
        public readonly Vector3I29F3 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Y, X); }
        public readonly Vector3I29F3 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Y, Y); }
        public readonly Vector3I29F3 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Y, Z); }
        public readonly Vector3I29F3 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Y, W); }
        public readonly Vector3I29F3 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Z, X); }
        public readonly Vector3I29F3 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Z, Y); }
        public readonly Vector3I29F3 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Z, Z); }
        public readonly Vector3I29F3 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Z, W); }
        public readonly Vector3I29F3 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, W, X); }
        public readonly Vector3I29F3 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, W, Y); }
        public readonly Vector3I29F3 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, W, Z); }
        public readonly Vector3I29F3 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, W, W); }
        public readonly Vector4I29F3 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, X); }
        public readonly Vector4I29F3 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, Y); }
        public readonly Vector4I29F3 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, Z); }
        public readonly Vector4I29F3 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, W); }
        public readonly Vector4I29F3 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, X); }
        public readonly Vector4I29F3 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, Y); }
        public readonly Vector4I29F3 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, Z); }
        public readonly Vector4I29F3 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, W); }
        public readonly Vector4I29F3 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, X); }
        public readonly Vector4I29F3 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, Y); }
        public readonly Vector4I29F3 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, Z); }
        public readonly Vector4I29F3 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, W); }
        public readonly Vector4I29F3 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, W, X); }
        public readonly Vector4I29F3 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, W, Y); }
        public readonly Vector4I29F3 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, W, Z); }
        public readonly Vector4I29F3 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, W, W); }
        public readonly Vector4I29F3 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, X); }
        public readonly Vector4I29F3 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, Y); }
        public readonly Vector4I29F3 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, Z); }
        public readonly Vector4I29F3 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, W); }
        public readonly Vector4I29F3 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, X); }
        public readonly Vector4I29F3 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, Y); }
        public readonly Vector4I29F3 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, Z); }
        public readonly Vector4I29F3 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, W); }
        public readonly Vector4I29F3 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, X); }
        public readonly Vector4I29F3 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, Y); }
        public readonly Vector4I29F3 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, Z); }
        public readonly Vector4I29F3 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, W); }
        public readonly Vector4I29F3 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, W, X); }
        public readonly Vector4I29F3 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, W, Y); }
        public readonly Vector4I29F3 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, W, Z); }
        public readonly Vector4I29F3 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, W, W); }
        public readonly Vector4I29F3 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, X); }
        public readonly Vector4I29F3 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, Y); }
        public readonly Vector4I29F3 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, Z); }
        public readonly Vector4I29F3 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, W); }
        public readonly Vector4I29F3 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, X); }
        public readonly Vector4I29F3 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, Y); }
        public readonly Vector4I29F3 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, Z); }
        public readonly Vector4I29F3 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, W); }
        public readonly Vector4I29F3 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, X); }
        public readonly Vector4I29F3 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, Y); }
        public readonly Vector4I29F3 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, Z); }
        public readonly Vector4I29F3 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, W); }
        public readonly Vector4I29F3 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, W, X); }
        public readonly Vector4I29F3 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, W, Y); }
        public readonly Vector4I29F3 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, W, Z); }
        public readonly Vector4I29F3 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, W, W); }
        public readonly Vector4I29F3 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, X, X); }
        public readonly Vector4I29F3 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, X, Y); }
        public readonly Vector4I29F3 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, X, Z); }
        public readonly Vector4I29F3 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, X, W); }
        public readonly Vector4I29F3 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Y, X); }
        public readonly Vector4I29F3 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Y, Y); }
        public readonly Vector4I29F3 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Y, Z); }
        public readonly Vector4I29F3 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Y, W); }
        public readonly Vector4I29F3 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Z, X); }
        public readonly Vector4I29F3 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Z, Y); }
        public readonly Vector4I29F3 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Z, Z); }
        public readonly Vector4I29F3 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Z, W); }
        public readonly Vector4I29F3 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, W, X); }
        public readonly Vector4I29F3 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, W, Y); }
        public readonly Vector4I29F3 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, W, Z); }
        public readonly Vector4I29F3 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, W, W); }
        public readonly Vector4I29F3 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, X); }
        public readonly Vector4I29F3 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, Y); }
        public readonly Vector4I29F3 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, Z); }
        public readonly Vector4I29F3 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, W); }
        public readonly Vector4I29F3 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, X); }
        public readonly Vector4I29F3 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, Y); }
        public readonly Vector4I29F3 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, Z); }
        public readonly Vector4I29F3 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, W); }
        public readonly Vector4I29F3 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, X); }
        public readonly Vector4I29F3 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, Y); }
        public readonly Vector4I29F3 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, Z); }
        public readonly Vector4I29F3 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, W); }
        public readonly Vector4I29F3 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, W, X); }
        public readonly Vector4I29F3 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, W, Y); }
        public readonly Vector4I29F3 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, W, Z); }
        public readonly Vector4I29F3 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, W, W); }
        public readonly Vector4I29F3 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, X); }
        public readonly Vector4I29F3 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, Y); }
        public readonly Vector4I29F3 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, Z); }
        public readonly Vector4I29F3 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, W); }
        public readonly Vector4I29F3 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, X); }
        public readonly Vector4I29F3 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, Y); }
        public readonly Vector4I29F3 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, Z); }
        public readonly Vector4I29F3 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, W); }
        public readonly Vector4I29F3 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, X); }
        public readonly Vector4I29F3 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, Y); }
        public readonly Vector4I29F3 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, Z); }
        public readonly Vector4I29F3 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, W); }
        public readonly Vector4I29F3 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, W, X); }
        public readonly Vector4I29F3 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, W, Y); }
        public readonly Vector4I29F3 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, W, Z); }
        public readonly Vector4I29F3 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, W, W); }
        public readonly Vector4I29F3 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, X); }
        public readonly Vector4I29F3 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, Y); }
        public readonly Vector4I29F3 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, Z); }
        public readonly Vector4I29F3 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, W); }
        public readonly Vector4I29F3 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, X); }
        public readonly Vector4I29F3 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, Y); }
        public readonly Vector4I29F3 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, Z); }
        public readonly Vector4I29F3 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, W); }
        public readonly Vector4I29F3 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, X); }
        public readonly Vector4I29F3 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, Y); }
        public readonly Vector4I29F3 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, Z); }
        public readonly Vector4I29F3 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, W); }
        public readonly Vector4I29F3 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, W, X); }
        public readonly Vector4I29F3 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, W, Y); }
        public readonly Vector4I29F3 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, W, Z); }
        public readonly Vector4I29F3 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, W, W); }
        public readonly Vector4I29F3 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, X, X); }
        public readonly Vector4I29F3 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, X, Y); }
        public readonly Vector4I29F3 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, X, Z); }
        public readonly Vector4I29F3 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, X, W); }
        public readonly Vector4I29F3 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Y, X); }
        public readonly Vector4I29F3 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Y, Y); }
        public readonly Vector4I29F3 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Y, Z); }
        public readonly Vector4I29F3 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Y, W); }
        public readonly Vector4I29F3 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Z, X); }
        public readonly Vector4I29F3 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Z, Y); }
        public readonly Vector4I29F3 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Z, Z); }
        public readonly Vector4I29F3 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Z, W); }
        public readonly Vector4I29F3 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, W, X); }
        public readonly Vector4I29F3 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, W, Y); }
        public readonly Vector4I29F3 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, W, Z); }
        public readonly Vector4I29F3 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, W, W); }
        public readonly Vector4I29F3 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, X); }
        public readonly Vector4I29F3 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, Y); }
        public readonly Vector4I29F3 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, Z); }
        public readonly Vector4I29F3 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, W); }
        public readonly Vector4I29F3 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, X); }
        public readonly Vector4I29F3 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, Y); }
        public readonly Vector4I29F3 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, Z); }
        public readonly Vector4I29F3 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, W); }
        public readonly Vector4I29F3 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, X); }
        public readonly Vector4I29F3 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, Y); }
        public readonly Vector4I29F3 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, Z); }
        public readonly Vector4I29F3 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, W); }
        public readonly Vector4I29F3 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, W, X); }
        public readonly Vector4I29F3 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, W, Y); }
        public readonly Vector4I29F3 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, W, Z); }
        public readonly Vector4I29F3 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, W, W); }
        public readonly Vector4I29F3 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, X); }
        public readonly Vector4I29F3 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, Y); }
        public readonly Vector4I29F3 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, Z); }
        public readonly Vector4I29F3 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, W); }
        public readonly Vector4I29F3 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, X); }
        public readonly Vector4I29F3 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, Y); }
        public readonly Vector4I29F3 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, Z); }
        public readonly Vector4I29F3 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, W); }
        public readonly Vector4I29F3 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, X); }
        public readonly Vector4I29F3 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, Y); }
        public readonly Vector4I29F3 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, Z); }
        public readonly Vector4I29F3 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, W); }
        public readonly Vector4I29F3 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, W, X); }
        public readonly Vector4I29F3 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, W, Y); }
        public readonly Vector4I29F3 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, W, Z); }
        public readonly Vector4I29F3 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, W, W); }
        public readonly Vector4I29F3 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, X); }
        public readonly Vector4I29F3 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, Y); }
        public readonly Vector4I29F3 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, Z); }
        public readonly Vector4I29F3 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, W); }
        public readonly Vector4I29F3 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, X); }
        public readonly Vector4I29F3 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, Y); }
        public readonly Vector4I29F3 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, Z); }
        public readonly Vector4I29F3 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, W); }
        public readonly Vector4I29F3 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, X); }
        public readonly Vector4I29F3 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, Y); }
        public readonly Vector4I29F3 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, Z); }
        public readonly Vector4I29F3 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, W); }
        public readonly Vector4I29F3 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, W, X); }
        public readonly Vector4I29F3 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, W, Y); }
        public readonly Vector4I29F3 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, W, Z); }
        public readonly Vector4I29F3 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, W, W); }
        public readonly Vector4I29F3 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, X, X); }
        public readonly Vector4I29F3 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, X, Y); }
        public readonly Vector4I29F3 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, X, Z); }
        public readonly Vector4I29F3 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, X, W); }
        public readonly Vector4I29F3 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Y, X); }
        public readonly Vector4I29F3 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Y, Y); }
        public readonly Vector4I29F3 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Y, Z); }
        public readonly Vector4I29F3 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Y, W); }
        public readonly Vector4I29F3 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Z, X); }
        public readonly Vector4I29F3 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Z, Y); }
        public readonly Vector4I29F3 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Z, Z); }
        public readonly Vector4I29F3 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Z, W); }
        public readonly Vector4I29F3 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, W, X); }
        public readonly Vector4I29F3 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, W, Y); }
        public readonly Vector4I29F3 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, W, Z); }
        public readonly Vector4I29F3 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, W, W); }
        public readonly Vector4I29F3 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, X, X); }
        public readonly Vector4I29F3 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, X, Y); }
        public readonly Vector4I29F3 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, X, Z); }
        public readonly Vector4I29F3 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, X, W); }
        public readonly Vector4I29F3 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Y, X); }
        public readonly Vector4I29F3 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Y, Y); }
        public readonly Vector4I29F3 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Y, Z); }
        public readonly Vector4I29F3 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Y, W); }
        public readonly Vector4I29F3 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Z, X); }
        public readonly Vector4I29F3 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Z, Y); }
        public readonly Vector4I29F3 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Z, Z); }
        public readonly Vector4I29F3 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Z, W); }
        public readonly Vector4I29F3 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, W, X); }
        public readonly Vector4I29F3 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, W, Y); }
        public readonly Vector4I29F3 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, W, Z); }
        public readonly Vector4I29F3 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, W, W); }
        public readonly Vector4I29F3 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, X, X); }
        public readonly Vector4I29F3 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, X, Y); }
        public readonly Vector4I29F3 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, X, Z); }
        public readonly Vector4I29F3 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, X, W); }
        public readonly Vector4I29F3 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Y, X); }
        public readonly Vector4I29F3 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Y, Y); }
        public readonly Vector4I29F3 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Y, Z); }
        public readonly Vector4I29F3 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Y, W); }
        public readonly Vector4I29F3 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Z, X); }
        public readonly Vector4I29F3 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Z, Y); }
        public readonly Vector4I29F3 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Z, Z); }
        public readonly Vector4I29F3 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Z, W); }
        public readonly Vector4I29F3 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, W, X); }
        public readonly Vector4I29F3 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, W, Y); }
        public readonly Vector4I29F3 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, W, Z); }
        public readonly Vector4I29F3 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, W, W); }
        public readonly Vector4I29F3 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, X, X); }
        public readonly Vector4I29F3 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, X, Y); }
        public readonly Vector4I29F3 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, X, Z); }
        public readonly Vector4I29F3 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, X, W); }
        public readonly Vector4I29F3 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Y, X); }
        public readonly Vector4I29F3 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Y, Y); }
        public readonly Vector4I29F3 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Y, Z); }
        public readonly Vector4I29F3 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Y, W); }
        public readonly Vector4I29F3 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Z, X); }
        public readonly Vector4I29F3 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Z, Y); }
        public readonly Vector4I29F3 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Z, Z); }
        public readonly Vector4I29F3 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Z, W); }
        public readonly Vector4I29F3 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, W, X); }
        public readonly Vector4I29F3 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, W, Y); }
        public readonly Vector4I29F3 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, W, Z); }
        public readonly Vector4I29F3 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, W, W); }
        public readonly Vector4I29F3 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, X, X); }
        public readonly Vector4I29F3 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, X, Y); }
        public readonly Vector4I29F3 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, X, Z); }
        public readonly Vector4I29F3 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, X, W); }
        public readonly Vector4I29F3 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Y, X); }
        public readonly Vector4I29F3 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Y, Y); }
        public readonly Vector4I29F3 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Y, Z); }
        public readonly Vector4I29F3 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Y, W); }
        public readonly Vector4I29F3 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Z, X); }
        public readonly Vector4I29F3 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Z, Y); }
        public readonly Vector4I29F3 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Z, Z); }
        public readonly Vector4I29F3 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Z, W); }
        public readonly Vector4I29F3 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, W, X); }
        public readonly Vector4I29F3 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, W, Y); }
        public readonly Vector4I29F3 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, W, Z); }
        public readonly Vector4I29F3 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I29F3 lhs, Vector4I29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I29F3 lhs, Vector4I29F3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I29F3({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I29F3 other)
            => other.X == X
            && other.Y == Y
            && other.Z == Z
            && other.W == W;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            var w = W.ToString(format, formatProvider);
            return $"Vector4I29F3({x}, {y}, {z}, {w})";
        }
    }
}
