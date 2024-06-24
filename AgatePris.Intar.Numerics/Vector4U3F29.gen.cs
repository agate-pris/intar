using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U3F29 : IEquatable<Vector4U3F29>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U3F29 X;
        public U3F29 Y;
        public U3F29 Z;
        public U3F29 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, U3F29 y, U3F29 z, U3F29 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, U3F29 y, Vector2U3F29 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, Vector3U3F29 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector2U3F29 xy, Vector2U3F29 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector4U3F29 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, Vector2U3F29 yz, U3F29 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector3U3F29 xyz, U3F29 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector2U3F29 xy, U3F29 z, U3F29 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U3F29 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.Zero);
        }
        public static Vector4U3F29 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator +(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator -(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator *(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator *(Vector4U3F29 a, U3F29 b) => new Vector4U3F29(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator *(U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator /(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator /(Vector4U3F29 a, U3F29 b) => new Vector4U3F29(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator /(U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U3F29 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, X); }
        public readonly Vector2U3F29 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, Y); }
        public readonly Vector2U3F29 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, Z); }
        public readonly Vector2U3F29 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, W); }
        public readonly Vector2U3F29 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, X); }
        public readonly Vector2U3F29 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, Y); }
        public readonly Vector2U3F29 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, Z); }
        public readonly Vector2U3F29 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, W); }
        public readonly Vector2U3F29 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, X); }
        public readonly Vector2U3F29 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, Y); }
        public readonly Vector2U3F29 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, Z); }
        public readonly Vector2U3F29 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, W); }
        public readonly Vector2U3F29 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(W, X); }
        public readonly Vector2U3F29 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(W, Y); }
        public readonly Vector2U3F29 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(W, Z); }
        public readonly Vector2U3F29 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(W, W); }
        public readonly Vector3U3F29 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, X); }
        public readonly Vector3U3F29 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, Y); }
        public readonly Vector3U3F29 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, Z); }
        public readonly Vector3U3F29 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, W); }
        public readonly Vector3U3F29 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, X); }
        public readonly Vector3U3F29 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, Y); }
        public readonly Vector3U3F29 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, Z); }
        public readonly Vector3U3F29 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, W); }
        public readonly Vector3U3F29 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, X); }
        public readonly Vector3U3F29 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, Y); }
        public readonly Vector3U3F29 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, Z); }
        public readonly Vector3U3F29 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, W); }
        public readonly Vector3U3F29 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, W, X); }
        public readonly Vector3U3F29 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, W, Y); }
        public readonly Vector3U3F29 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, W, Z); }
        public readonly Vector3U3F29 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, W, W); }
        public readonly Vector3U3F29 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, X); }
        public readonly Vector3U3F29 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, Y); }
        public readonly Vector3U3F29 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, Z); }
        public readonly Vector3U3F29 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, W); }
        public readonly Vector3U3F29 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, X); }
        public readonly Vector3U3F29 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, Y); }
        public readonly Vector3U3F29 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, Z); }
        public readonly Vector3U3F29 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, W); }
        public readonly Vector3U3F29 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, X); }
        public readonly Vector3U3F29 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, Y); }
        public readonly Vector3U3F29 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, Z); }
        public readonly Vector3U3F29 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, W); }
        public readonly Vector3U3F29 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, W, X); }
        public readonly Vector3U3F29 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, W, Y); }
        public readonly Vector3U3F29 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, W, Z); }
        public readonly Vector3U3F29 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, W, W); }
        public readonly Vector3U3F29 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, X); }
        public readonly Vector3U3F29 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, Y); }
        public readonly Vector3U3F29 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, Z); }
        public readonly Vector3U3F29 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, W); }
        public readonly Vector3U3F29 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, X); }
        public readonly Vector3U3F29 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, Y); }
        public readonly Vector3U3F29 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, Z); }
        public readonly Vector3U3F29 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, W); }
        public readonly Vector3U3F29 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, X); }
        public readonly Vector3U3F29 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, Y); }
        public readonly Vector3U3F29 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, Z); }
        public readonly Vector3U3F29 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, W); }
        public readonly Vector3U3F29 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, W, X); }
        public readonly Vector3U3F29 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, W, Y); }
        public readonly Vector3U3F29 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, W, Z); }
        public readonly Vector3U3F29 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, W, W); }
        public readonly Vector3U3F29 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, X, X); }
        public readonly Vector3U3F29 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, X, Y); }
        public readonly Vector3U3F29 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, X, Z); }
        public readonly Vector3U3F29 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, X, W); }
        public readonly Vector3U3F29 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Y, X); }
        public readonly Vector3U3F29 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Y, Y); }
        public readonly Vector3U3F29 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Y, Z); }
        public readonly Vector3U3F29 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Y, W); }
        public readonly Vector3U3F29 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Z, X); }
        public readonly Vector3U3F29 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Z, Y); }
        public readonly Vector3U3F29 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Z, Z); }
        public readonly Vector3U3F29 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Z, W); }
        public readonly Vector3U3F29 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, W, X); }
        public readonly Vector3U3F29 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, W, Y); }
        public readonly Vector3U3F29 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, W, Z); }
        public readonly Vector3U3F29 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, W, W); }
        public readonly Vector4U3F29 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, X); }
        public readonly Vector4U3F29 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, Y); }
        public readonly Vector4U3F29 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, Z); }
        public readonly Vector4U3F29 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, W); }
        public readonly Vector4U3F29 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, X); }
        public readonly Vector4U3F29 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, Y); }
        public readonly Vector4U3F29 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, Z); }
        public readonly Vector4U3F29 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, W); }
        public readonly Vector4U3F29 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, X); }
        public readonly Vector4U3F29 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, Y); }
        public readonly Vector4U3F29 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, Z); }
        public readonly Vector4U3F29 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, W); }
        public readonly Vector4U3F29 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, W, X); }
        public readonly Vector4U3F29 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, W, Y); }
        public readonly Vector4U3F29 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, W, Z); }
        public readonly Vector4U3F29 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, W, W); }
        public readonly Vector4U3F29 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, X); }
        public readonly Vector4U3F29 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, Y); }
        public readonly Vector4U3F29 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, Z); }
        public readonly Vector4U3F29 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, W); }
        public readonly Vector4U3F29 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, X); }
        public readonly Vector4U3F29 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, Y); }
        public readonly Vector4U3F29 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, Z); }
        public readonly Vector4U3F29 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, W); }
        public readonly Vector4U3F29 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, X); }
        public readonly Vector4U3F29 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, Y); }
        public readonly Vector4U3F29 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, Z); }
        public readonly Vector4U3F29 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, W); }
        public readonly Vector4U3F29 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, W, X); }
        public readonly Vector4U3F29 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, W, Y); }
        public readonly Vector4U3F29 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, W, Z); }
        public readonly Vector4U3F29 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, W, W); }
        public readonly Vector4U3F29 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, X); }
        public readonly Vector4U3F29 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, Y); }
        public readonly Vector4U3F29 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, Z); }
        public readonly Vector4U3F29 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, W); }
        public readonly Vector4U3F29 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, X); }
        public readonly Vector4U3F29 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, Y); }
        public readonly Vector4U3F29 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, Z); }
        public readonly Vector4U3F29 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, W); }
        public readonly Vector4U3F29 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, X); }
        public readonly Vector4U3F29 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, Y); }
        public readonly Vector4U3F29 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, Z); }
        public readonly Vector4U3F29 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, W); }
        public readonly Vector4U3F29 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, W, X); }
        public readonly Vector4U3F29 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, W, Y); }
        public readonly Vector4U3F29 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, W, Z); }
        public readonly Vector4U3F29 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, W, W); }
        public readonly Vector4U3F29 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, X, X); }
        public readonly Vector4U3F29 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, X, Y); }
        public readonly Vector4U3F29 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, X, Z); }
        public readonly Vector4U3F29 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, X, W); }
        public readonly Vector4U3F29 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Y, X); }
        public readonly Vector4U3F29 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Y, Y); }
        public readonly Vector4U3F29 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Y, Z); }
        public readonly Vector4U3F29 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Y, W); }
        public readonly Vector4U3F29 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Z, X); }
        public readonly Vector4U3F29 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Z, Y); }
        public readonly Vector4U3F29 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Z, Z); }
        public readonly Vector4U3F29 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Z, W); }
        public readonly Vector4U3F29 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, W, X); }
        public readonly Vector4U3F29 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, W, Y); }
        public readonly Vector4U3F29 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, W, Z); }
        public readonly Vector4U3F29 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, W, W); }
        public readonly Vector4U3F29 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, X); }
        public readonly Vector4U3F29 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, Y); }
        public readonly Vector4U3F29 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, Z); }
        public readonly Vector4U3F29 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, W); }
        public readonly Vector4U3F29 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, X); }
        public readonly Vector4U3F29 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, Y); }
        public readonly Vector4U3F29 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, Z); }
        public readonly Vector4U3F29 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, W); }
        public readonly Vector4U3F29 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, X); }
        public readonly Vector4U3F29 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, Y); }
        public readonly Vector4U3F29 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, Z); }
        public readonly Vector4U3F29 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, W); }
        public readonly Vector4U3F29 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, W, X); }
        public readonly Vector4U3F29 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, W, Y); }
        public readonly Vector4U3F29 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, W, Z); }
        public readonly Vector4U3F29 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, W, W); }
        public readonly Vector4U3F29 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, X); }
        public readonly Vector4U3F29 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, Y); }
        public readonly Vector4U3F29 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, Z); }
        public readonly Vector4U3F29 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, W); }
        public readonly Vector4U3F29 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, X); }
        public readonly Vector4U3F29 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, Y); }
        public readonly Vector4U3F29 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, Z); }
        public readonly Vector4U3F29 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, W); }
        public readonly Vector4U3F29 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, X); }
        public readonly Vector4U3F29 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, Y); }
        public readonly Vector4U3F29 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, Z); }
        public readonly Vector4U3F29 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, W); }
        public readonly Vector4U3F29 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, W, X); }
        public readonly Vector4U3F29 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, W, Y); }
        public readonly Vector4U3F29 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, W, Z); }
        public readonly Vector4U3F29 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, W, W); }
        public readonly Vector4U3F29 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, X); }
        public readonly Vector4U3F29 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, Y); }
        public readonly Vector4U3F29 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, Z); }
        public readonly Vector4U3F29 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, W); }
        public readonly Vector4U3F29 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, X); }
        public readonly Vector4U3F29 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, Y); }
        public readonly Vector4U3F29 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, Z); }
        public readonly Vector4U3F29 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, W); }
        public readonly Vector4U3F29 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, X); }
        public readonly Vector4U3F29 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, Y); }
        public readonly Vector4U3F29 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, Z); }
        public readonly Vector4U3F29 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, W); }
        public readonly Vector4U3F29 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, W, X); }
        public readonly Vector4U3F29 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, W, Y); }
        public readonly Vector4U3F29 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, W, Z); }
        public readonly Vector4U3F29 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, W, W); }
        public readonly Vector4U3F29 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, X, X); }
        public readonly Vector4U3F29 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, X, Y); }
        public readonly Vector4U3F29 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, X, Z); }
        public readonly Vector4U3F29 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, X, W); }
        public readonly Vector4U3F29 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Y, X); }
        public readonly Vector4U3F29 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Y, Y); }
        public readonly Vector4U3F29 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Y, Z); }
        public readonly Vector4U3F29 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Y, W); }
        public readonly Vector4U3F29 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Z, X); }
        public readonly Vector4U3F29 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Z, Y); }
        public readonly Vector4U3F29 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Z, Z); }
        public readonly Vector4U3F29 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Z, W); }
        public readonly Vector4U3F29 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, W, X); }
        public readonly Vector4U3F29 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, W, Y); }
        public readonly Vector4U3F29 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, W, Z); }
        public readonly Vector4U3F29 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, W, W); }
        public readonly Vector4U3F29 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, X); }
        public readonly Vector4U3F29 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, Y); }
        public readonly Vector4U3F29 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, Z); }
        public readonly Vector4U3F29 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, W); }
        public readonly Vector4U3F29 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, X); }
        public readonly Vector4U3F29 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, Y); }
        public readonly Vector4U3F29 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, Z); }
        public readonly Vector4U3F29 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, W); }
        public readonly Vector4U3F29 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, X); }
        public readonly Vector4U3F29 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, Y); }
        public readonly Vector4U3F29 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, Z); }
        public readonly Vector4U3F29 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, W); }
        public readonly Vector4U3F29 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, W, X); }
        public readonly Vector4U3F29 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, W, Y); }
        public readonly Vector4U3F29 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, W, Z); }
        public readonly Vector4U3F29 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, W, W); }
        public readonly Vector4U3F29 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, X); }
        public readonly Vector4U3F29 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, Y); }
        public readonly Vector4U3F29 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, Z); }
        public readonly Vector4U3F29 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, W); }
        public readonly Vector4U3F29 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, X); }
        public readonly Vector4U3F29 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, Y); }
        public readonly Vector4U3F29 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, Z); }
        public readonly Vector4U3F29 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, W); }
        public readonly Vector4U3F29 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, X); }
        public readonly Vector4U3F29 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, Y); }
        public readonly Vector4U3F29 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, Z); }
        public readonly Vector4U3F29 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, W); }
        public readonly Vector4U3F29 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, W, X); }
        public readonly Vector4U3F29 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, W, Y); }
        public readonly Vector4U3F29 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, W, Z); }
        public readonly Vector4U3F29 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, W, W); }
        public readonly Vector4U3F29 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, X); }
        public readonly Vector4U3F29 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, Y); }
        public readonly Vector4U3F29 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, Z); }
        public readonly Vector4U3F29 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, W); }
        public readonly Vector4U3F29 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, X); }
        public readonly Vector4U3F29 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, Y); }
        public readonly Vector4U3F29 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, Z); }
        public readonly Vector4U3F29 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, W); }
        public readonly Vector4U3F29 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, X); }
        public readonly Vector4U3F29 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, Y); }
        public readonly Vector4U3F29 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, Z); }
        public readonly Vector4U3F29 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, W); }
        public readonly Vector4U3F29 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, W, X); }
        public readonly Vector4U3F29 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, W, Y); }
        public readonly Vector4U3F29 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, W, Z); }
        public readonly Vector4U3F29 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, W, W); }
        public readonly Vector4U3F29 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, X, X); }
        public readonly Vector4U3F29 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, X, Y); }
        public readonly Vector4U3F29 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, X, Z); }
        public readonly Vector4U3F29 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, X, W); }
        public readonly Vector4U3F29 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Y, X); }
        public readonly Vector4U3F29 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Y, Y); }
        public readonly Vector4U3F29 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Y, Z); }
        public readonly Vector4U3F29 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Y, W); }
        public readonly Vector4U3F29 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Z, X); }
        public readonly Vector4U3F29 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Z, Y); }
        public readonly Vector4U3F29 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Z, Z); }
        public readonly Vector4U3F29 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Z, W); }
        public readonly Vector4U3F29 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, W, X); }
        public readonly Vector4U3F29 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, W, Y); }
        public readonly Vector4U3F29 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, W, Z); }
        public readonly Vector4U3F29 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, W, W); }
        public readonly Vector4U3F29 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, X, X); }
        public readonly Vector4U3F29 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, X, Y); }
        public readonly Vector4U3F29 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, X, Z); }
        public readonly Vector4U3F29 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, X, W); }
        public readonly Vector4U3F29 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Y, X); }
        public readonly Vector4U3F29 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Y, Y); }
        public readonly Vector4U3F29 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Y, Z); }
        public readonly Vector4U3F29 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Y, W); }
        public readonly Vector4U3F29 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Z, X); }
        public readonly Vector4U3F29 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Z, Y); }
        public readonly Vector4U3F29 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Z, Z); }
        public readonly Vector4U3F29 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Z, W); }
        public readonly Vector4U3F29 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, W, X); }
        public readonly Vector4U3F29 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, W, Y); }
        public readonly Vector4U3F29 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, W, Z); }
        public readonly Vector4U3F29 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, W, W); }
        public readonly Vector4U3F29 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, X, X); }
        public readonly Vector4U3F29 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, X, Y); }
        public readonly Vector4U3F29 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, X, Z); }
        public readonly Vector4U3F29 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, X, W); }
        public readonly Vector4U3F29 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Y, X); }
        public readonly Vector4U3F29 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Y, Y); }
        public readonly Vector4U3F29 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Y, Z); }
        public readonly Vector4U3F29 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Y, W); }
        public readonly Vector4U3F29 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Z, X); }
        public readonly Vector4U3F29 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Z, Y); }
        public readonly Vector4U3F29 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Z, Z); }
        public readonly Vector4U3F29 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Z, W); }
        public readonly Vector4U3F29 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, W, X); }
        public readonly Vector4U3F29 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, W, Y); }
        public readonly Vector4U3F29 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, W, Z); }
        public readonly Vector4U3F29 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, W, W); }
        public readonly Vector4U3F29 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, X, X); }
        public readonly Vector4U3F29 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, X, Y); }
        public readonly Vector4U3F29 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, X, Z); }
        public readonly Vector4U3F29 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, X, W); }
        public readonly Vector4U3F29 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Y, X); }
        public readonly Vector4U3F29 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Y, Y); }
        public readonly Vector4U3F29 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Y, Z); }
        public readonly Vector4U3F29 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Y, W); }
        public readonly Vector4U3F29 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Z, X); }
        public readonly Vector4U3F29 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Z, Y); }
        public readonly Vector4U3F29 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Z, Z); }
        public readonly Vector4U3F29 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Z, W); }
        public readonly Vector4U3F29 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, W, X); }
        public readonly Vector4U3F29 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, W, Y); }
        public readonly Vector4U3F29 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, W, Z); }
        public readonly Vector4U3F29 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, W, W); }
        public readonly Vector4U3F29 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, X, X); }
        public readonly Vector4U3F29 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, X, Y); }
        public readonly Vector4U3F29 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, X, Z); }
        public readonly Vector4U3F29 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, X, W); }
        public readonly Vector4U3F29 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Y, X); }
        public readonly Vector4U3F29 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Y, Y); }
        public readonly Vector4U3F29 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Y, Z); }
        public readonly Vector4U3F29 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Y, W); }
        public readonly Vector4U3F29 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Z, X); }
        public readonly Vector4U3F29 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Z, Y); }
        public readonly Vector4U3F29 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Z, Z); }
        public readonly Vector4U3F29 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Z, W); }
        public readonly Vector4U3F29 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, W, X); }
        public readonly Vector4U3F29 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, W, Y); }
        public readonly Vector4U3F29 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, W, Z); }
        public readonly Vector4U3F29 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U3F29 lhs, Vector4U3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U3F29 lhs, Vector4U3F29 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U3F29({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U3F29 other)
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
            return $"Vector4U3F29({x}, {y}, {z}, {w})";
        }
    }
}
