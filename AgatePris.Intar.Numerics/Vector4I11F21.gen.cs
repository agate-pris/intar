using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I11F21 : IEquatable<Vector4I11F21>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I11F21 X;
        public I11F21 Y;
        public I11F21 Z;
        public I11F21 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(I11F21 x, I11F21 y, I11F21 z, I11F21 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(I11F21 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(I11F21 x, I11F21 y, Vector2I11F21 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(I11F21 x, Vector3I11F21 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(Vector2I11F21 xy, Vector2I11F21 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(Vector4I11F21 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(I11F21 x, Vector2I11F21 yz, I11F21 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(Vector3I11F21 xyz, I11F21 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I11F21(Vector2I11F21 xy, I11F21 z, I11F21 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I11F21 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I11F21(I11F21.Zero);
        }
        public static Vector4I11F21 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I11F21(I11F21.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator +(Vector4I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator -(Vector4I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator *(Vector4I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator *(Vector4I11F21 a, I11F21 b) => new Vector4I11F21(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator *(I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator /(Vector4I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator /(Vector4I11F21 a, I11F21 b) => new Vector4I11F21(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 operator /(I11F21 a, Vector4I11F21 b) => new Vector4I11F21(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I11F21 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, X); }
        public readonly Vector2I11F21 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, Y); }
        public readonly Vector2I11F21 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, Z); }
        public readonly Vector2I11F21 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, W); }
        public readonly Vector2I11F21 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, X); }
        public readonly Vector2I11F21 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, Y); }
        public readonly Vector2I11F21 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, Z); }
        public readonly Vector2I11F21 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, W); }
        public readonly Vector2I11F21 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Z, X); }
        public readonly Vector2I11F21 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Z, Y); }
        public readonly Vector2I11F21 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Z, Z); }
        public readonly Vector2I11F21 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Z, W); }
        public readonly Vector2I11F21 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(W, X); }
        public readonly Vector2I11F21 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(W, Y); }
        public readonly Vector2I11F21 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(W, Z); }
        public readonly Vector2I11F21 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(W, W); }
        public readonly Vector3I11F21 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, X); }
        public readonly Vector3I11F21 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, Y); }
        public readonly Vector3I11F21 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, Z); }
        public readonly Vector3I11F21 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, W); }
        public readonly Vector3I11F21 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, X); }
        public readonly Vector3I11F21 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, Y); }
        public readonly Vector3I11F21 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, Z); }
        public readonly Vector3I11F21 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, W); }
        public readonly Vector3I11F21 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Z, X); }
        public readonly Vector3I11F21 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Z, Y); }
        public readonly Vector3I11F21 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Z, Z); }
        public readonly Vector3I11F21 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Z, W); }
        public readonly Vector3I11F21 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, W, X); }
        public readonly Vector3I11F21 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, W, Y); }
        public readonly Vector3I11F21 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, W, Z); }
        public readonly Vector3I11F21 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, W, W); }
        public readonly Vector3I11F21 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, X); }
        public readonly Vector3I11F21 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, Y); }
        public readonly Vector3I11F21 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, Z); }
        public readonly Vector3I11F21 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, W); }
        public readonly Vector3I11F21 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, X); }
        public readonly Vector3I11F21 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, Y); }
        public readonly Vector3I11F21 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, Z); }
        public readonly Vector3I11F21 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, W); }
        public readonly Vector3I11F21 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Z, X); }
        public readonly Vector3I11F21 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Z, Y); }
        public readonly Vector3I11F21 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Z, Z); }
        public readonly Vector3I11F21 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Z, W); }
        public readonly Vector3I11F21 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, W, X); }
        public readonly Vector3I11F21 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, W, Y); }
        public readonly Vector3I11F21 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, W, Z); }
        public readonly Vector3I11F21 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, W, W); }
        public readonly Vector3I11F21 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, X, X); }
        public readonly Vector3I11F21 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, X, Y); }
        public readonly Vector3I11F21 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, X, Z); }
        public readonly Vector3I11F21 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, X, W); }
        public readonly Vector3I11F21 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Y, X); }
        public readonly Vector3I11F21 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Y, Y); }
        public readonly Vector3I11F21 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Y, Z); }
        public readonly Vector3I11F21 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Y, W); }
        public readonly Vector3I11F21 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Z, X); }
        public readonly Vector3I11F21 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Z, Y); }
        public readonly Vector3I11F21 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Z, Z); }
        public readonly Vector3I11F21 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, Z, W); }
        public readonly Vector3I11F21 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, W, X); }
        public readonly Vector3I11F21 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, W, Y); }
        public readonly Vector3I11F21 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, W, Z); }
        public readonly Vector3I11F21 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Z, W, W); }
        public readonly Vector3I11F21 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, X, X); }
        public readonly Vector3I11F21 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, X, Y); }
        public readonly Vector3I11F21 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, X, Z); }
        public readonly Vector3I11F21 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, X, W); }
        public readonly Vector3I11F21 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, Y, X); }
        public readonly Vector3I11F21 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, Y, Y); }
        public readonly Vector3I11F21 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, Y, Z); }
        public readonly Vector3I11F21 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, Y, W); }
        public readonly Vector3I11F21 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, Z, X); }
        public readonly Vector3I11F21 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, Z, Y); }
        public readonly Vector3I11F21 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, Z, Z); }
        public readonly Vector3I11F21 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, Z, W); }
        public readonly Vector3I11F21 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, W, X); }
        public readonly Vector3I11F21 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, W, Y); }
        public readonly Vector3I11F21 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, W, Z); }
        public readonly Vector3I11F21 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(W, W, W); }
        public readonly Vector4I11F21 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, X); }
        public readonly Vector4I11F21 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, Y); }
        public readonly Vector4I11F21 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, Z); }
        public readonly Vector4I11F21 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, W); }
        public readonly Vector4I11F21 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, X); }
        public readonly Vector4I11F21 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, Y); }
        public readonly Vector4I11F21 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, Z); }
        public readonly Vector4I11F21 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, W); }
        public readonly Vector4I11F21 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Z, X); }
        public readonly Vector4I11F21 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Z, Y); }
        public readonly Vector4I11F21 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Z, Z); }
        public readonly Vector4I11F21 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Z, W); }
        public readonly Vector4I11F21 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, W, X); }
        public readonly Vector4I11F21 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, W, Y); }
        public readonly Vector4I11F21 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, W, Z); }
        public readonly Vector4I11F21 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, W, W); }
        public readonly Vector4I11F21 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, X); }
        public readonly Vector4I11F21 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, Y); }
        public readonly Vector4I11F21 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, Z); }
        public readonly Vector4I11F21 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, W); }
        public readonly Vector4I11F21 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, X); }
        public readonly Vector4I11F21 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, Y); }
        public readonly Vector4I11F21 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, Z); }
        public readonly Vector4I11F21 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, W); }
        public readonly Vector4I11F21 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Z, X); }
        public readonly Vector4I11F21 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Z, Y); }
        public readonly Vector4I11F21 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Z, Z); }
        public readonly Vector4I11F21 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Z, W); }
        public readonly Vector4I11F21 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, W, X); }
        public readonly Vector4I11F21 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, W, Y); }
        public readonly Vector4I11F21 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, W, Z); }
        public readonly Vector4I11F21 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, W, W); }
        public readonly Vector4I11F21 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, X, X); }
        public readonly Vector4I11F21 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, X, Y); }
        public readonly Vector4I11F21 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, X, Z); }
        public readonly Vector4I11F21 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, X, W); }
        public readonly Vector4I11F21 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Y, X); }
        public readonly Vector4I11F21 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Y, Y); }
        public readonly Vector4I11F21 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Y, Z); }
        public readonly Vector4I11F21 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Y, W); }
        public readonly Vector4I11F21 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Z, X); }
        public readonly Vector4I11F21 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Z, Y); }
        public readonly Vector4I11F21 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Z, Z); }
        public readonly Vector4I11F21 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, Z, W); }
        public readonly Vector4I11F21 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, W, X); }
        public readonly Vector4I11F21 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, W, Y); }
        public readonly Vector4I11F21 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, W, Z); }
        public readonly Vector4I11F21 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Z, W, W); }
        public readonly Vector4I11F21 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, X, X); }
        public readonly Vector4I11F21 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, X, Y); }
        public readonly Vector4I11F21 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, X, Z); }
        public readonly Vector4I11F21 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, X, W); }
        public readonly Vector4I11F21 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, Y, X); }
        public readonly Vector4I11F21 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, Y, Y); }
        public readonly Vector4I11F21 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, Y, Z); }
        public readonly Vector4I11F21 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, Y, W); }
        public readonly Vector4I11F21 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, Z, X); }
        public readonly Vector4I11F21 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, Z, Y); }
        public readonly Vector4I11F21 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, Z, Z); }
        public readonly Vector4I11F21 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, Z, W); }
        public readonly Vector4I11F21 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, W, X); }
        public readonly Vector4I11F21 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, W, Y); }
        public readonly Vector4I11F21 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, W, Z); }
        public readonly Vector4I11F21 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, W, W, W); }
        public readonly Vector4I11F21 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, X); }
        public readonly Vector4I11F21 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, Y); }
        public readonly Vector4I11F21 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, Z); }
        public readonly Vector4I11F21 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, W); }
        public readonly Vector4I11F21 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, X); }
        public readonly Vector4I11F21 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, Y); }
        public readonly Vector4I11F21 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, Z); }
        public readonly Vector4I11F21 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, W); }
        public readonly Vector4I11F21 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Z, X); }
        public readonly Vector4I11F21 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Z, Y); }
        public readonly Vector4I11F21 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Z, Z); }
        public readonly Vector4I11F21 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Z, W); }
        public readonly Vector4I11F21 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, W, X); }
        public readonly Vector4I11F21 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, W, Y); }
        public readonly Vector4I11F21 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, W, Z); }
        public readonly Vector4I11F21 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, W, W); }
        public readonly Vector4I11F21 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, X); }
        public readonly Vector4I11F21 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, Y); }
        public readonly Vector4I11F21 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, Z); }
        public readonly Vector4I11F21 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, W); }
        public readonly Vector4I11F21 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, X); }
        public readonly Vector4I11F21 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, Y); }
        public readonly Vector4I11F21 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, Z); }
        public readonly Vector4I11F21 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, W); }
        public readonly Vector4I11F21 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Z, X); }
        public readonly Vector4I11F21 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Z, Y); }
        public readonly Vector4I11F21 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Z, Z); }
        public readonly Vector4I11F21 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Z, W); }
        public readonly Vector4I11F21 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, W, X); }
        public readonly Vector4I11F21 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, W, Y); }
        public readonly Vector4I11F21 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, W, Z); }
        public readonly Vector4I11F21 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, W, W); }
        public readonly Vector4I11F21 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, X, X); }
        public readonly Vector4I11F21 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, X, Y); }
        public readonly Vector4I11F21 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, X, Z); }
        public readonly Vector4I11F21 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, X, W); }
        public readonly Vector4I11F21 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Y, X); }
        public readonly Vector4I11F21 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Y, Y); }
        public readonly Vector4I11F21 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Y, Z); }
        public readonly Vector4I11F21 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Y, W); }
        public readonly Vector4I11F21 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Z, X); }
        public readonly Vector4I11F21 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Z, Y); }
        public readonly Vector4I11F21 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Z, Z); }
        public readonly Vector4I11F21 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, Z, W); }
        public readonly Vector4I11F21 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, W, X); }
        public readonly Vector4I11F21 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, W, Y); }
        public readonly Vector4I11F21 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, W, Z); }
        public readonly Vector4I11F21 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Z, W, W); }
        public readonly Vector4I11F21 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, X, X); }
        public readonly Vector4I11F21 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, X, Y); }
        public readonly Vector4I11F21 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, X, Z); }
        public readonly Vector4I11F21 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, X, W); }
        public readonly Vector4I11F21 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, Y, X); }
        public readonly Vector4I11F21 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, Y, Y); }
        public readonly Vector4I11F21 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, Y, Z); }
        public readonly Vector4I11F21 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, Y, W); }
        public readonly Vector4I11F21 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, Z, X); }
        public readonly Vector4I11F21 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, Z, Y); }
        public readonly Vector4I11F21 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, Z, Z); }
        public readonly Vector4I11F21 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, Z, W); }
        public readonly Vector4I11F21 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, W, X); }
        public readonly Vector4I11F21 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, W, Y); }
        public readonly Vector4I11F21 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, W, Z); }
        public readonly Vector4I11F21 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, W, W, W); }
        public readonly Vector4I11F21 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, X, X); }
        public readonly Vector4I11F21 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, X, Y); }
        public readonly Vector4I11F21 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, X, Z); }
        public readonly Vector4I11F21 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, X, W); }
        public readonly Vector4I11F21 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Y, X); }
        public readonly Vector4I11F21 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Y, Y); }
        public readonly Vector4I11F21 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Y, Z); }
        public readonly Vector4I11F21 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Y, W); }
        public readonly Vector4I11F21 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Z, X); }
        public readonly Vector4I11F21 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Z, Y); }
        public readonly Vector4I11F21 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Z, Z); }
        public readonly Vector4I11F21 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, Z, W); }
        public readonly Vector4I11F21 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, W, X); }
        public readonly Vector4I11F21 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, W, Y); }
        public readonly Vector4I11F21 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, W, Z); }
        public readonly Vector4I11F21 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, X, W, W); }
        public readonly Vector4I11F21 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, X, X); }
        public readonly Vector4I11F21 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, X, Y); }
        public readonly Vector4I11F21 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, X, Z); }
        public readonly Vector4I11F21 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, X, W); }
        public readonly Vector4I11F21 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Y, X); }
        public readonly Vector4I11F21 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Y, Y); }
        public readonly Vector4I11F21 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Y, Z); }
        public readonly Vector4I11F21 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Y, W); }
        public readonly Vector4I11F21 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Z, X); }
        public readonly Vector4I11F21 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Z, Y); }
        public readonly Vector4I11F21 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Z, Z); }
        public readonly Vector4I11F21 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, Z, W); }
        public readonly Vector4I11F21 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, W, X); }
        public readonly Vector4I11F21 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, W, Y); }
        public readonly Vector4I11F21 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, W, Z); }
        public readonly Vector4I11F21 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Y, W, W); }
        public readonly Vector4I11F21 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, X, X); }
        public readonly Vector4I11F21 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, X, Y); }
        public readonly Vector4I11F21 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, X, Z); }
        public readonly Vector4I11F21 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, X, W); }
        public readonly Vector4I11F21 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Y, X); }
        public readonly Vector4I11F21 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Y, Y); }
        public readonly Vector4I11F21 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Y, Z); }
        public readonly Vector4I11F21 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Y, W); }
        public readonly Vector4I11F21 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Z, X); }
        public readonly Vector4I11F21 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Z, Y); }
        public readonly Vector4I11F21 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Z, Z); }
        public readonly Vector4I11F21 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, Z, W); }
        public readonly Vector4I11F21 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, W, X); }
        public readonly Vector4I11F21 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, W, Y); }
        public readonly Vector4I11F21 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, W, Z); }
        public readonly Vector4I11F21 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, Z, W, W); }
        public readonly Vector4I11F21 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, X, X); }
        public readonly Vector4I11F21 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, X, Y); }
        public readonly Vector4I11F21 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, X, Z); }
        public readonly Vector4I11F21 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, X, W); }
        public readonly Vector4I11F21 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, Y, X); }
        public readonly Vector4I11F21 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, Y, Y); }
        public readonly Vector4I11F21 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, Y, Z); }
        public readonly Vector4I11F21 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, Y, W); }
        public readonly Vector4I11F21 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, Z, X); }
        public readonly Vector4I11F21 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, Z, Y); }
        public readonly Vector4I11F21 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, Z, Z); }
        public readonly Vector4I11F21 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, Z, W); }
        public readonly Vector4I11F21 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, W, X); }
        public readonly Vector4I11F21 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, W, Y); }
        public readonly Vector4I11F21 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, W, Z); }
        public readonly Vector4I11F21 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Z, W, W, W); }
        public readonly Vector4I11F21 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, X, X); }
        public readonly Vector4I11F21 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, X, Y); }
        public readonly Vector4I11F21 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, X, Z); }
        public readonly Vector4I11F21 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, X, W); }
        public readonly Vector4I11F21 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, Y, X); }
        public readonly Vector4I11F21 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, Y, Y); }
        public readonly Vector4I11F21 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, Y, Z); }
        public readonly Vector4I11F21 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, Y, W); }
        public readonly Vector4I11F21 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, Z, X); }
        public readonly Vector4I11F21 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, Z, Y); }
        public readonly Vector4I11F21 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, Z, Z); }
        public readonly Vector4I11F21 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, Z, W); }
        public readonly Vector4I11F21 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, W, X); }
        public readonly Vector4I11F21 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, W, Y); }
        public readonly Vector4I11F21 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, W, Z); }
        public readonly Vector4I11F21 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, X, W, W); }
        public readonly Vector4I11F21 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, X, X); }
        public readonly Vector4I11F21 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, X, Y); }
        public readonly Vector4I11F21 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, X, Z); }
        public readonly Vector4I11F21 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, X, W); }
        public readonly Vector4I11F21 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, Y, X); }
        public readonly Vector4I11F21 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, Y, Y); }
        public readonly Vector4I11F21 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, Y, Z); }
        public readonly Vector4I11F21 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, Y, W); }
        public readonly Vector4I11F21 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, Z, X); }
        public readonly Vector4I11F21 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, Z, Y); }
        public readonly Vector4I11F21 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, Z, Z); }
        public readonly Vector4I11F21 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, Z, W); }
        public readonly Vector4I11F21 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, W, X); }
        public readonly Vector4I11F21 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, W, Y); }
        public readonly Vector4I11F21 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, W, Z); }
        public readonly Vector4I11F21 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Y, W, W); }
        public readonly Vector4I11F21 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, X, X); }
        public readonly Vector4I11F21 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, X, Y); }
        public readonly Vector4I11F21 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, X, Z); }
        public readonly Vector4I11F21 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, X, W); }
        public readonly Vector4I11F21 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, Y, X); }
        public readonly Vector4I11F21 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, Y, Y); }
        public readonly Vector4I11F21 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, Y, Z); }
        public readonly Vector4I11F21 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, Y, W); }
        public readonly Vector4I11F21 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, Z, X); }
        public readonly Vector4I11F21 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, Z, Y); }
        public readonly Vector4I11F21 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, Z, Z); }
        public readonly Vector4I11F21 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, Z, W); }
        public readonly Vector4I11F21 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, W, X); }
        public readonly Vector4I11F21 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, W, Y); }
        public readonly Vector4I11F21 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, W, Z); }
        public readonly Vector4I11F21 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, Z, W, W); }
        public readonly Vector4I11F21 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, X, X); }
        public readonly Vector4I11F21 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, X, Y); }
        public readonly Vector4I11F21 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, X, Z); }
        public readonly Vector4I11F21 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, X, W); }
        public readonly Vector4I11F21 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, Y, X); }
        public readonly Vector4I11F21 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, Y, Y); }
        public readonly Vector4I11F21 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, Y, Z); }
        public readonly Vector4I11F21 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, Y, W); }
        public readonly Vector4I11F21 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, Z, X); }
        public readonly Vector4I11F21 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, Z, Y); }
        public readonly Vector4I11F21 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, Z, Z); }
        public readonly Vector4I11F21 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, Z, W); }
        public readonly Vector4I11F21 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, W, X); }
        public readonly Vector4I11F21 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, W, Y); }
        public readonly Vector4I11F21 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, W, Z); }
        public readonly Vector4I11F21 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(W, W, W, W); }

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
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I11F21({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I11F21 other)
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
            return $"Vector4I11F21({x}, {y}, {z}, {w})";
        }
    }
}
