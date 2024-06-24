using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I31F1 : IEquatable<Vector4I31F1>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I31F1 X;
        public I31F1 Y;
        public I31F1 Z;
        public I31F1 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, I31F1 y, I31F1 z, I31F1 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, I31F1 y, Vector2I31F1 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, Vector3I31F1 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector2I31F1 xy, Vector2I31F1 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector4I31F1 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, Vector2I31F1 yz, I31F1 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector3I31F1 xyz, I31F1 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector2I31F1 xy, I31F1 z, I31F1 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I31F1 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I31F1(I31F1.Zero);
        }
        public static Vector4I31F1 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I31F1(I31F1.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator +(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator -(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator *(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator *(Vector4I31F1 a, I31F1 b) => new Vector4I31F1(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator *(I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator /(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator /(Vector4I31F1 a, I31F1 b) => new Vector4I31F1(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator /(I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I31F1 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, X); }
        public readonly Vector2I31F1 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, Y); }
        public readonly Vector2I31F1 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, Z); }
        public readonly Vector2I31F1 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, W); }
        public readonly Vector2I31F1 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, X); }
        public readonly Vector2I31F1 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, Y); }
        public readonly Vector2I31F1 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, Z); }
        public readonly Vector2I31F1 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, W); }
        public readonly Vector2I31F1 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, X); }
        public readonly Vector2I31F1 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, Y); }
        public readonly Vector2I31F1 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, Z); }
        public readonly Vector2I31F1 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, W); }
        public readonly Vector2I31F1 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(W, X); }
        public readonly Vector2I31F1 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(W, Y); }
        public readonly Vector2I31F1 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(W, Z); }
        public readonly Vector2I31F1 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(W, W); }
        public readonly Vector3I31F1 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, X); }
        public readonly Vector3I31F1 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, Y); }
        public readonly Vector3I31F1 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, Z); }
        public readonly Vector3I31F1 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, W); }
        public readonly Vector3I31F1 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, X); }
        public readonly Vector3I31F1 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, Y); }
        public readonly Vector3I31F1 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, Z); }
        public readonly Vector3I31F1 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, W); }
        public readonly Vector3I31F1 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, X); }
        public readonly Vector3I31F1 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, Y); }
        public readonly Vector3I31F1 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, Z); }
        public readonly Vector3I31F1 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, W); }
        public readonly Vector3I31F1 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, W, X); }
        public readonly Vector3I31F1 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, W, Y); }
        public readonly Vector3I31F1 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, W, Z); }
        public readonly Vector3I31F1 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, W, W); }
        public readonly Vector3I31F1 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, X); }
        public readonly Vector3I31F1 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, Y); }
        public readonly Vector3I31F1 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, Z); }
        public readonly Vector3I31F1 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, W); }
        public readonly Vector3I31F1 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, X); }
        public readonly Vector3I31F1 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, Y); }
        public readonly Vector3I31F1 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, Z); }
        public readonly Vector3I31F1 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, W); }
        public readonly Vector3I31F1 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, X); }
        public readonly Vector3I31F1 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, Y); }
        public readonly Vector3I31F1 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, Z); }
        public readonly Vector3I31F1 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, W); }
        public readonly Vector3I31F1 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, W, X); }
        public readonly Vector3I31F1 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, W, Y); }
        public readonly Vector3I31F1 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, W, Z); }
        public readonly Vector3I31F1 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, W, W); }
        public readonly Vector3I31F1 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, X); }
        public readonly Vector3I31F1 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, Y); }
        public readonly Vector3I31F1 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, Z); }
        public readonly Vector3I31F1 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, W); }
        public readonly Vector3I31F1 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, X); }
        public readonly Vector3I31F1 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, Y); }
        public readonly Vector3I31F1 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, Z); }
        public readonly Vector3I31F1 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, W); }
        public readonly Vector3I31F1 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, X); }
        public readonly Vector3I31F1 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, Y); }
        public readonly Vector3I31F1 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, Z); }
        public readonly Vector3I31F1 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, W); }
        public readonly Vector3I31F1 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, W, X); }
        public readonly Vector3I31F1 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, W, Y); }
        public readonly Vector3I31F1 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, W, Z); }
        public readonly Vector3I31F1 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, W, W); }
        public readonly Vector3I31F1 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, X, X); }
        public readonly Vector3I31F1 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, X, Y); }
        public readonly Vector3I31F1 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, X, Z); }
        public readonly Vector3I31F1 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, X, W); }
        public readonly Vector3I31F1 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Y, X); }
        public readonly Vector3I31F1 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Y, Y); }
        public readonly Vector3I31F1 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Y, Z); }
        public readonly Vector3I31F1 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Y, W); }
        public readonly Vector3I31F1 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Z, X); }
        public readonly Vector3I31F1 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Z, Y); }
        public readonly Vector3I31F1 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Z, Z); }
        public readonly Vector3I31F1 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Z, W); }
        public readonly Vector3I31F1 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, W, X); }
        public readonly Vector3I31F1 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, W, Y); }
        public readonly Vector3I31F1 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, W, Z); }
        public readonly Vector3I31F1 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, W, W); }
        public readonly Vector4I31F1 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, X); }
        public readonly Vector4I31F1 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, Y); }
        public readonly Vector4I31F1 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, Z); }
        public readonly Vector4I31F1 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, W); }
        public readonly Vector4I31F1 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, X); }
        public readonly Vector4I31F1 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, Y); }
        public readonly Vector4I31F1 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, Z); }
        public readonly Vector4I31F1 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, W); }
        public readonly Vector4I31F1 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, X); }
        public readonly Vector4I31F1 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, Y); }
        public readonly Vector4I31F1 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, Z); }
        public readonly Vector4I31F1 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, W); }
        public readonly Vector4I31F1 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, W, X); }
        public readonly Vector4I31F1 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, W, Y); }
        public readonly Vector4I31F1 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, W, Z); }
        public readonly Vector4I31F1 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, W, W); }
        public readonly Vector4I31F1 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, X); }
        public readonly Vector4I31F1 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, Y); }
        public readonly Vector4I31F1 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, Z); }
        public readonly Vector4I31F1 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, W); }
        public readonly Vector4I31F1 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, X); }
        public readonly Vector4I31F1 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, Y); }
        public readonly Vector4I31F1 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, Z); }
        public readonly Vector4I31F1 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, W); }
        public readonly Vector4I31F1 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, X); }
        public readonly Vector4I31F1 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, Y); }
        public readonly Vector4I31F1 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, Z); }
        public readonly Vector4I31F1 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, W); }
        public readonly Vector4I31F1 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, W, X); }
        public readonly Vector4I31F1 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, W, Y); }
        public readonly Vector4I31F1 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, W, Z); }
        public readonly Vector4I31F1 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, W, W); }
        public readonly Vector4I31F1 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, X); }
        public readonly Vector4I31F1 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, Y); }
        public readonly Vector4I31F1 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, Z); }
        public readonly Vector4I31F1 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, W); }
        public readonly Vector4I31F1 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, X); }
        public readonly Vector4I31F1 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, Y); }
        public readonly Vector4I31F1 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, Z); }
        public readonly Vector4I31F1 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, W); }
        public readonly Vector4I31F1 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, X); }
        public readonly Vector4I31F1 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, Y); }
        public readonly Vector4I31F1 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, Z); }
        public readonly Vector4I31F1 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, W); }
        public readonly Vector4I31F1 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, W, X); }
        public readonly Vector4I31F1 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, W, Y); }
        public readonly Vector4I31F1 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, W, Z); }
        public readonly Vector4I31F1 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, W, W); }
        public readonly Vector4I31F1 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, X, X); }
        public readonly Vector4I31F1 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, X, Y); }
        public readonly Vector4I31F1 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, X, Z); }
        public readonly Vector4I31F1 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, X, W); }
        public readonly Vector4I31F1 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Y, X); }
        public readonly Vector4I31F1 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Y, Y); }
        public readonly Vector4I31F1 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Y, Z); }
        public readonly Vector4I31F1 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Y, W); }
        public readonly Vector4I31F1 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Z, X); }
        public readonly Vector4I31F1 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Z, Y); }
        public readonly Vector4I31F1 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Z, Z); }
        public readonly Vector4I31F1 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Z, W); }
        public readonly Vector4I31F1 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, W, X); }
        public readonly Vector4I31F1 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, W, Y); }
        public readonly Vector4I31F1 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, W, Z); }
        public readonly Vector4I31F1 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, W, W); }
        public readonly Vector4I31F1 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, X); }
        public readonly Vector4I31F1 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, Y); }
        public readonly Vector4I31F1 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, Z); }
        public readonly Vector4I31F1 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, W); }
        public readonly Vector4I31F1 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, X); }
        public readonly Vector4I31F1 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, Y); }
        public readonly Vector4I31F1 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, Z); }
        public readonly Vector4I31F1 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, W); }
        public readonly Vector4I31F1 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, X); }
        public readonly Vector4I31F1 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, Y); }
        public readonly Vector4I31F1 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, Z); }
        public readonly Vector4I31F1 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, W); }
        public readonly Vector4I31F1 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, W, X); }
        public readonly Vector4I31F1 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, W, Y); }
        public readonly Vector4I31F1 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, W, Z); }
        public readonly Vector4I31F1 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, W, W); }
        public readonly Vector4I31F1 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, X); }
        public readonly Vector4I31F1 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, Y); }
        public readonly Vector4I31F1 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, Z); }
        public readonly Vector4I31F1 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, W); }
        public readonly Vector4I31F1 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, X); }
        public readonly Vector4I31F1 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, Y); }
        public readonly Vector4I31F1 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, Z); }
        public readonly Vector4I31F1 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, W); }
        public readonly Vector4I31F1 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, X); }
        public readonly Vector4I31F1 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, Y); }
        public readonly Vector4I31F1 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, Z); }
        public readonly Vector4I31F1 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, W); }
        public readonly Vector4I31F1 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, W, X); }
        public readonly Vector4I31F1 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, W, Y); }
        public readonly Vector4I31F1 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, W, Z); }
        public readonly Vector4I31F1 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, W, W); }
        public readonly Vector4I31F1 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, X); }
        public readonly Vector4I31F1 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, Y); }
        public readonly Vector4I31F1 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, Z); }
        public readonly Vector4I31F1 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, W); }
        public readonly Vector4I31F1 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, X); }
        public readonly Vector4I31F1 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, Y); }
        public readonly Vector4I31F1 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, Z); }
        public readonly Vector4I31F1 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, W); }
        public readonly Vector4I31F1 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, X); }
        public readonly Vector4I31F1 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, Y); }
        public readonly Vector4I31F1 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, Z); }
        public readonly Vector4I31F1 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, W); }
        public readonly Vector4I31F1 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, W, X); }
        public readonly Vector4I31F1 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, W, Y); }
        public readonly Vector4I31F1 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, W, Z); }
        public readonly Vector4I31F1 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, W, W); }
        public readonly Vector4I31F1 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, X, X); }
        public readonly Vector4I31F1 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, X, Y); }
        public readonly Vector4I31F1 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, X, Z); }
        public readonly Vector4I31F1 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, X, W); }
        public readonly Vector4I31F1 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Y, X); }
        public readonly Vector4I31F1 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Y, Y); }
        public readonly Vector4I31F1 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Y, Z); }
        public readonly Vector4I31F1 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Y, W); }
        public readonly Vector4I31F1 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Z, X); }
        public readonly Vector4I31F1 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Z, Y); }
        public readonly Vector4I31F1 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Z, Z); }
        public readonly Vector4I31F1 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Z, W); }
        public readonly Vector4I31F1 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, W, X); }
        public readonly Vector4I31F1 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, W, Y); }
        public readonly Vector4I31F1 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, W, Z); }
        public readonly Vector4I31F1 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, W, W); }
        public readonly Vector4I31F1 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, X); }
        public readonly Vector4I31F1 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, Y); }
        public readonly Vector4I31F1 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, Z); }
        public readonly Vector4I31F1 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, W); }
        public readonly Vector4I31F1 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, X); }
        public readonly Vector4I31F1 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, Y); }
        public readonly Vector4I31F1 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, Z); }
        public readonly Vector4I31F1 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, W); }
        public readonly Vector4I31F1 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, X); }
        public readonly Vector4I31F1 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, Y); }
        public readonly Vector4I31F1 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, Z); }
        public readonly Vector4I31F1 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, W); }
        public readonly Vector4I31F1 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, W, X); }
        public readonly Vector4I31F1 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, W, Y); }
        public readonly Vector4I31F1 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, W, Z); }
        public readonly Vector4I31F1 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, W, W); }
        public readonly Vector4I31F1 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, X); }
        public readonly Vector4I31F1 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, Y); }
        public readonly Vector4I31F1 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, Z); }
        public readonly Vector4I31F1 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, W); }
        public readonly Vector4I31F1 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, X); }
        public readonly Vector4I31F1 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, Y); }
        public readonly Vector4I31F1 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, Z); }
        public readonly Vector4I31F1 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, W); }
        public readonly Vector4I31F1 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, X); }
        public readonly Vector4I31F1 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, Y); }
        public readonly Vector4I31F1 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, Z); }
        public readonly Vector4I31F1 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, W); }
        public readonly Vector4I31F1 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, W, X); }
        public readonly Vector4I31F1 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, W, Y); }
        public readonly Vector4I31F1 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, W, Z); }
        public readonly Vector4I31F1 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, W, W); }
        public readonly Vector4I31F1 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, X); }
        public readonly Vector4I31F1 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, Y); }
        public readonly Vector4I31F1 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, Z); }
        public readonly Vector4I31F1 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, W); }
        public readonly Vector4I31F1 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, X); }
        public readonly Vector4I31F1 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, Y); }
        public readonly Vector4I31F1 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, Z); }
        public readonly Vector4I31F1 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, W); }
        public readonly Vector4I31F1 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, X); }
        public readonly Vector4I31F1 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, Y); }
        public readonly Vector4I31F1 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, Z); }
        public readonly Vector4I31F1 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, W); }
        public readonly Vector4I31F1 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, W, X); }
        public readonly Vector4I31F1 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, W, Y); }
        public readonly Vector4I31F1 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, W, Z); }
        public readonly Vector4I31F1 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, W, W); }
        public readonly Vector4I31F1 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, X, X); }
        public readonly Vector4I31F1 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, X, Y); }
        public readonly Vector4I31F1 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, X, Z); }
        public readonly Vector4I31F1 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, X, W); }
        public readonly Vector4I31F1 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Y, X); }
        public readonly Vector4I31F1 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Y, Y); }
        public readonly Vector4I31F1 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Y, Z); }
        public readonly Vector4I31F1 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Y, W); }
        public readonly Vector4I31F1 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Z, X); }
        public readonly Vector4I31F1 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Z, Y); }
        public readonly Vector4I31F1 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Z, Z); }
        public readonly Vector4I31F1 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Z, W); }
        public readonly Vector4I31F1 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, W, X); }
        public readonly Vector4I31F1 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, W, Y); }
        public readonly Vector4I31F1 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, W, Z); }
        public readonly Vector4I31F1 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, W, W); }
        public readonly Vector4I31F1 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, X, X); }
        public readonly Vector4I31F1 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, X, Y); }
        public readonly Vector4I31F1 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, X, Z); }
        public readonly Vector4I31F1 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, X, W); }
        public readonly Vector4I31F1 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Y, X); }
        public readonly Vector4I31F1 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Y, Y); }
        public readonly Vector4I31F1 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Y, Z); }
        public readonly Vector4I31F1 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Y, W); }
        public readonly Vector4I31F1 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Z, X); }
        public readonly Vector4I31F1 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Z, Y); }
        public readonly Vector4I31F1 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Z, Z); }
        public readonly Vector4I31F1 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Z, W); }
        public readonly Vector4I31F1 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, W, X); }
        public readonly Vector4I31F1 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, W, Y); }
        public readonly Vector4I31F1 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, W, Z); }
        public readonly Vector4I31F1 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, W, W); }
        public readonly Vector4I31F1 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, X, X); }
        public readonly Vector4I31F1 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, X, Y); }
        public readonly Vector4I31F1 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, X, Z); }
        public readonly Vector4I31F1 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, X, W); }
        public readonly Vector4I31F1 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Y, X); }
        public readonly Vector4I31F1 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Y, Y); }
        public readonly Vector4I31F1 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Y, Z); }
        public readonly Vector4I31F1 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Y, W); }
        public readonly Vector4I31F1 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Z, X); }
        public readonly Vector4I31F1 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Z, Y); }
        public readonly Vector4I31F1 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Z, Z); }
        public readonly Vector4I31F1 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Z, W); }
        public readonly Vector4I31F1 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, W, X); }
        public readonly Vector4I31F1 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, W, Y); }
        public readonly Vector4I31F1 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, W, Z); }
        public readonly Vector4I31F1 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, W, W); }
        public readonly Vector4I31F1 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, X, X); }
        public readonly Vector4I31F1 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, X, Y); }
        public readonly Vector4I31F1 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, X, Z); }
        public readonly Vector4I31F1 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, X, W); }
        public readonly Vector4I31F1 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Y, X); }
        public readonly Vector4I31F1 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Y, Y); }
        public readonly Vector4I31F1 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Y, Z); }
        public readonly Vector4I31F1 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Y, W); }
        public readonly Vector4I31F1 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Z, X); }
        public readonly Vector4I31F1 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Z, Y); }
        public readonly Vector4I31F1 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Z, Z); }
        public readonly Vector4I31F1 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Z, W); }
        public readonly Vector4I31F1 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, W, X); }
        public readonly Vector4I31F1 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, W, Y); }
        public readonly Vector4I31F1 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, W, Z); }
        public readonly Vector4I31F1 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, W, W); }
        public readonly Vector4I31F1 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, X, X); }
        public readonly Vector4I31F1 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, X, Y); }
        public readonly Vector4I31F1 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, X, Z); }
        public readonly Vector4I31F1 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, X, W); }
        public readonly Vector4I31F1 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Y, X); }
        public readonly Vector4I31F1 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Y, Y); }
        public readonly Vector4I31F1 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Y, Z); }
        public readonly Vector4I31F1 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Y, W); }
        public readonly Vector4I31F1 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Z, X); }
        public readonly Vector4I31F1 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Z, Y); }
        public readonly Vector4I31F1 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Z, Z); }
        public readonly Vector4I31F1 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Z, W); }
        public readonly Vector4I31F1 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, W, X); }
        public readonly Vector4I31F1 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, W, Y); }
        public readonly Vector4I31F1 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, W, Z); }
        public readonly Vector4I31F1 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I31F1 lhs, Vector4I31F1 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I31F1 lhs, Vector4I31F1 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I31F1 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I31F1({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I31F1>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I31F1 other)
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
            return $"Vector4I31F1({x}, {y}, {z}, {w})";
        }
    }
}
