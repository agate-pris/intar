using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U10F22 : IEquatable<Vector4U10F22>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U10F22 X;
        public U10F22 Y;
        public U10F22 Z;
        public U10F22 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U10F22(U10F22 x, U10F22 y, U10F22 z, U10F22 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U10F22(U10F22 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U10F22(U10F22 x, U10F22 y, Vector2U10F22 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U10F22(U10F22 x, Vector3U10F22 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U10F22(Vector2U10F22 xy, Vector2U10F22 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U10F22(Vector4U10F22 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U10F22(U10F22 x, Vector2U10F22 yz, U10F22 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U10F22(Vector3U10F22 xyz, U10F22 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U10F22(Vector2U10F22 xy, U10F22 z, U10F22 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U10F22 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U10F22(U10F22.Zero);
        }
        public static Vector4U10F22 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U10F22(U10F22.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 operator +(Vector4U10F22 a, Vector4U10F22 b) => new Vector4U10F22(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 operator -(Vector4U10F22 a, Vector4U10F22 b) => new Vector4U10F22(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 operator *(Vector4U10F22 a, Vector4U10F22 b) => new Vector4U10F22(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 operator *(Vector4U10F22 a, U10F22 b) => new Vector4U10F22(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 operator *(U10F22 a, Vector4U10F22 b) => new Vector4U10F22(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 operator /(Vector4U10F22 a, Vector4U10F22 b) => new Vector4U10F22(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 operator /(Vector4U10F22 a, U10F22 b) => new Vector4U10F22(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 operator /(U10F22 a, Vector4U10F22 b) => new Vector4U10F22(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U10F22 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(X, X); }
        public readonly Vector2U10F22 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(X, Y); }
        public readonly Vector2U10F22 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(X, Z); }
        public readonly Vector2U10F22 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(X, W); }
        public readonly Vector2U10F22 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Y, X); }
        public readonly Vector2U10F22 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Y, Y); }
        public readonly Vector2U10F22 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Y, Z); }
        public readonly Vector2U10F22 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Y, W); }
        public readonly Vector2U10F22 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Z, X); }
        public readonly Vector2U10F22 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Z, Y); }
        public readonly Vector2U10F22 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Z, Z); }
        public readonly Vector2U10F22 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Z, W); }
        public readonly Vector2U10F22 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(W, X); }
        public readonly Vector2U10F22 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(W, Y); }
        public readonly Vector2U10F22 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(W, Z); }
        public readonly Vector2U10F22 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(W, W); }
        public readonly Vector3U10F22 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, X, X); }
        public readonly Vector3U10F22 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, X, Y); }
        public readonly Vector3U10F22 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, X, Z); }
        public readonly Vector3U10F22 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, X, W); }
        public readonly Vector3U10F22 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Y, X); }
        public readonly Vector3U10F22 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Y, Y); }
        public readonly Vector3U10F22 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Y, Z); }
        public readonly Vector3U10F22 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Y, W); }
        public readonly Vector3U10F22 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Z, X); }
        public readonly Vector3U10F22 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Z, Y); }
        public readonly Vector3U10F22 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Z, Z); }
        public readonly Vector3U10F22 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Z, W); }
        public readonly Vector3U10F22 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, W, X); }
        public readonly Vector3U10F22 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, W, Y); }
        public readonly Vector3U10F22 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, W, Z); }
        public readonly Vector3U10F22 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, W, W); }
        public readonly Vector3U10F22 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, X, X); }
        public readonly Vector3U10F22 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, X, Y); }
        public readonly Vector3U10F22 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, X, Z); }
        public readonly Vector3U10F22 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, X, W); }
        public readonly Vector3U10F22 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Y, X); }
        public readonly Vector3U10F22 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Y, Y); }
        public readonly Vector3U10F22 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Y, Z); }
        public readonly Vector3U10F22 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Y, W); }
        public readonly Vector3U10F22 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Z, X); }
        public readonly Vector3U10F22 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Z, Y); }
        public readonly Vector3U10F22 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Z, Z); }
        public readonly Vector3U10F22 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Z, W); }
        public readonly Vector3U10F22 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, W, X); }
        public readonly Vector3U10F22 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, W, Y); }
        public readonly Vector3U10F22 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, W, Z); }
        public readonly Vector3U10F22 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, W, W); }
        public readonly Vector3U10F22 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, X, X); }
        public readonly Vector3U10F22 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, X, Y); }
        public readonly Vector3U10F22 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, X, Z); }
        public readonly Vector3U10F22 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, X, W); }
        public readonly Vector3U10F22 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, Y, X); }
        public readonly Vector3U10F22 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, Y, Y); }
        public readonly Vector3U10F22 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, Y, Z); }
        public readonly Vector3U10F22 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, Y, W); }
        public readonly Vector3U10F22 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, Z, X); }
        public readonly Vector3U10F22 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, Z, Y); }
        public readonly Vector3U10F22 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, Z, Z); }
        public readonly Vector3U10F22 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, Z, W); }
        public readonly Vector3U10F22 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, W, X); }
        public readonly Vector3U10F22 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, W, Y); }
        public readonly Vector3U10F22 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, W, Z); }
        public readonly Vector3U10F22 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Z, W, W); }
        public readonly Vector3U10F22 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, X, X); }
        public readonly Vector3U10F22 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, X, Y); }
        public readonly Vector3U10F22 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, X, Z); }
        public readonly Vector3U10F22 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, X, W); }
        public readonly Vector3U10F22 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, Y, X); }
        public readonly Vector3U10F22 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, Y, Y); }
        public readonly Vector3U10F22 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, Y, Z); }
        public readonly Vector3U10F22 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, Y, W); }
        public readonly Vector3U10F22 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, Z, X); }
        public readonly Vector3U10F22 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, Z, Y); }
        public readonly Vector3U10F22 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, Z, Z); }
        public readonly Vector3U10F22 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, Z, W); }
        public readonly Vector3U10F22 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, W, X); }
        public readonly Vector3U10F22 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, W, Y); }
        public readonly Vector3U10F22 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, W, Z); }
        public readonly Vector3U10F22 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(W, W, W); }
        public readonly Vector4U10F22 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, X, X); }
        public readonly Vector4U10F22 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, X, Y); }
        public readonly Vector4U10F22 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, X, Z); }
        public readonly Vector4U10F22 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, X, W); }
        public readonly Vector4U10F22 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Y, X); }
        public readonly Vector4U10F22 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Y, Y); }
        public readonly Vector4U10F22 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Y, Z); }
        public readonly Vector4U10F22 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Y, W); }
        public readonly Vector4U10F22 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Z, X); }
        public readonly Vector4U10F22 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Z, Y); }
        public readonly Vector4U10F22 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Z, Z); }
        public readonly Vector4U10F22 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Z, W); }
        public readonly Vector4U10F22 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, W, X); }
        public readonly Vector4U10F22 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, W, Y); }
        public readonly Vector4U10F22 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, W, Z); }
        public readonly Vector4U10F22 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, W, W); }
        public readonly Vector4U10F22 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, X, X); }
        public readonly Vector4U10F22 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, X, Y); }
        public readonly Vector4U10F22 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, X, Z); }
        public readonly Vector4U10F22 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, X, W); }
        public readonly Vector4U10F22 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Y, X); }
        public readonly Vector4U10F22 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Y, Y); }
        public readonly Vector4U10F22 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Y, Z); }
        public readonly Vector4U10F22 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Y, W); }
        public readonly Vector4U10F22 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Z, X); }
        public readonly Vector4U10F22 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Z, Y); }
        public readonly Vector4U10F22 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Z, Z); }
        public readonly Vector4U10F22 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Z, W); }
        public readonly Vector4U10F22 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, W, X); }
        public readonly Vector4U10F22 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, W, Y); }
        public readonly Vector4U10F22 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, W, Z); }
        public readonly Vector4U10F22 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, W, W); }
        public readonly Vector4U10F22 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, X, X); }
        public readonly Vector4U10F22 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, X, Y); }
        public readonly Vector4U10F22 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, X, Z); }
        public readonly Vector4U10F22 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, X, W); }
        public readonly Vector4U10F22 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, Y, X); }
        public readonly Vector4U10F22 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, Y, Y); }
        public readonly Vector4U10F22 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, Y, Z); }
        public readonly Vector4U10F22 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, Y, W); }
        public readonly Vector4U10F22 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, Z, X); }
        public readonly Vector4U10F22 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, Z, Y); }
        public readonly Vector4U10F22 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, Z, Z); }
        public readonly Vector4U10F22 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, Z, W); }
        public readonly Vector4U10F22 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, W, X); }
        public readonly Vector4U10F22 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, W, Y); }
        public readonly Vector4U10F22 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, W, Z); }
        public readonly Vector4U10F22 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Z, W, W); }
        public readonly Vector4U10F22 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, X, X); }
        public readonly Vector4U10F22 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, X, Y); }
        public readonly Vector4U10F22 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, X, Z); }
        public readonly Vector4U10F22 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, X, W); }
        public readonly Vector4U10F22 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, Y, X); }
        public readonly Vector4U10F22 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, Y, Y); }
        public readonly Vector4U10F22 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, Y, Z); }
        public readonly Vector4U10F22 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, Y, W); }
        public readonly Vector4U10F22 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, Z, X); }
        public readonly Vector4U10F22 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, Z, Y); }
        public readonly Vector4U10F22 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, Z, Z); }
        public readonly Vector4U10F22 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, Z, W); }
        public readonly Vector4U10F22 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, W, X); }
        public readonly Vector4U10F22 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, W, Y); }
        public readonly Vector4U10F22 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, W, Z); }
        public readonly Vector4U10F22 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, W, W, W); }
        public readonly Vector4U10F22 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, X, X); }
        public readonly Vector4U10F22 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, X, Y); }
        public readonly Vector4U10F22 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, X, Z); }
        public readonly Vector4U10F22 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, X, W); }
        public readonly Vector4U10F22 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Y, X); }
        public readonly Vector4U10F22 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Y, Y); }
        public readonly Vector4U10F22 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Y, Z); }
        public readonly Vector4U10F22 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Y, W); }
        public readonly Vector4U10F22 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Z, X); }
        public readonly Vector4U10F22 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Z, Y); }
        public readonly Vector4U10F22 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Z, Z); }
        public readonly Vector4U10F22 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Z, W); }
        public readonly Vector4U10F22 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, W, X); }
        public readonly Vector4U10F22 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, W, Y); }
        public readonly Vector4U10F22 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, W, Z); }
        public readonly Vector4U10F22 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, W, W); }
        public readonly Vector4U10F22 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, X, X); }
        public readonly Vector4U10F22 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, X, Y); }
        public readonly Vector4U10F22 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, X, Z); }
        public readonly Vector4U10F22 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, X, W); }
        public readonly Vector4U10F22 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Y, X); }
        public readonly Vector4U10F22 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Y, Y); }
        public readonly Vector4U10F22 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Y, Z); }
        public readonly Vector4U10F22 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Y, W); }
        public readonly Vector4U10F22 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Z, X); }
        public readonly Vector4U10F22 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Z, Y); }
        public readonly Vector4U10F22 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Z, Z); }
        public readonly Vector4U10F22 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Z, W); }
        public readonly Vector4U10F22 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, W, X); }
        public readonly Vector4U10F22 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, W, Y); }
        public readonly Vector4U10F22 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, W, Z); }
        public readonly Vector4U10F22 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, W, W); }
        public readonly Vector4U10F22 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, X, X); }
        public readonly Vector4U10F22 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, X, Y); }
        public readonly Vector4U10F22 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, X, Z); }
        public readonly Vector4U10F22 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, X, W); }
        public readonly Vector4U10F22 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, Y, X); }
        public readonly Vector4U10F22 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, Y, Y); }
        public readonly Vector4U10F22 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, Y, Z); }
        public readonly Vector4U10F22 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, Y, W); }
        public readonly Vector4U10F22 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, Z, X); }
        public readonly Vector4U10F22 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, Z, Y); }
        public readonly Vector4U10F22 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, Z, Z); }
        public readonly Vector4U10F22 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, Z, W); }
        public readonly Vector4U10F22 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, W, X); }
        public readonly Vector4U10F22 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, W, Y); }
        public readonly Vector4U10F22 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, W, Z); }
        public readonly Vector4U10F22 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Z, W, W); }
        public readonly Vector4U10F22 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, X, X); }
        public readonly Vector4U10F22 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, X, Y); }
        public readonly Vector4U10F22 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, X, Z); }
        public readonly Vector4U10F22 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, X, W); }
        public readonly Vector4U10F22 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, Y, X); }
        public readonly Vector4U10F22 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, Y, Y); }
        public readonly Vector4U10F22 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, Y, Z); }
        public readonly Vector4U10F22 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, Y, W); }
        public readonly Vector4U10F22 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, Z, X); }
        public readonly Vector4U10F22 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, Z, Y); }
        public readonly Vector4U10F22 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, Z, Z); }
        public readonly Vector4U10F22 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, Z, W); }
        public readonly Vector4U10F22 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, W, X); }
        public readonly Vector4U10F22 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, W, Y); }
        public readonly Vector4U10F22 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, W, Z); }
        public readonly Vector4U10F22 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, W, W, W); }
        public readonly Vector4U10F22 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, X, X); }
        public readonly Vector4U10F22 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, X, Y); }
        public readonly Vector4U10F22 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, X, Z); }
        public readonly Vector4U10F22 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, X, W); }
        public readonly Vector4U10F22 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, Y, X); }
        public readonly Vector4U10F22 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, Y, Y); }
        public readonly Vector4U10F22 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, Y, Z); }
        public readonly Vector4U10F22 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, Y, W); }
        public readonly Vector4U10F22 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, Z, X); }
        public readonly Vector4U10F22 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, Z, Y); }
        public readonly Vector4U10F22 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, Z, Z); }
        public readonly Vector4U10F22 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, Z, W); }
        public readonly Vector4U10F22 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, W, X); }
        public readonly Vector4U10F22 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, W, Y); }
        public readonly Vector4U10F22 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, W, Z); }
        public readonly Vector4U10F22 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, X, W, W); }
        public readonly Vector4U10F22 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, X, X); }
        public readonly Vector4U10F22 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, X, Y); }
        public readonly Vector4U10F22 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, X, Z); }
        public readonly Vector4U10F22 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, X, W); }
        public readonly Vector4U10F22 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, Y, X); }
        public readonly Vector4U10F22 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, Y, Y); }
        public readonly Vector4U10F22 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, Y, Z); }
        public readonly Vector4U10F22 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, Y, W); }
        public readonly Vector4U10F22 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, Z, X); }
        public readonly Vector4U10F22 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, Z, Y); }
        public readonly Vector4U10F22 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, Z, Z); }
        public readonly Vector4U10F22 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, Z, W); }
        public readonly Vector4U10F22 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, W, X); }
        public readonly Vector4U10F22 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, W, Y); }
        public readonly Vector4U10F22 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, W, Z); }
        public readonly Vector4U10F22 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Y, W, W); }
        public readonly Vector4U10F22 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, X, X); }
        public readonly Vector4U10F22 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, X, Y); }
        public readonly Vector4U10F22 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, X, Z); }
        public readonly Vector4U10F22 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, X, W); }
        public readonly Vector4U10F22 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, Y, X); }
        public readonly Vector4U10F22 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, Y, Y); }
        public readonly Vector4U10F22 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, Y, Z); }
        public readonly Vector4U10F22 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, Y, W); }
        public readonly Vector4U10F22 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, Z, X); }
        public readonly Vector4U10F22 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, Z, Y); }
        public readonly Vector4U10F22 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, Z, Z); }
        public readonly Vector4U10F22 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, Z, W); }
        public readonly Vector4U10F22 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, W, X); }
        public readonly Vector4U10F22 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, W, Y); }
        public readonly Vector4U10F22 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, W, Z); }
        public readonly Vector4U10F22 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, Z, W, W); }
        public readonly Vector4U10F22 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, X, X); }
        public readonly Vector4U10F22 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, X, Y); }
        public readonly Vector4U10F22 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, X, Z); }
        public readonly Vector4U10F22 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, X, W); }
        public readonly Vector4U10F22 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, Y, X); }
        public readonly Vector4U10F22 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, Y, Y); }
        public readonly Vector4U10F22 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, Y, Z); }
        public readonly Vector4U10F22 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, Y, W); }
        public readonly Vector4U10F22 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, Z, X); }
        public readonly Vector4U10F22 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, Z, Y); }
        public readonly Vector4U10F22 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, Z, Z); }
        public readonly Vector4U10F22 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, Z, W); }
        public readonly Vector4U10F22 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, W, X); }
        public readonly Vector4U10F22 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, W, Y); }
        public readonly Vector4U10F22 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, W, Z); }
        public readonly Vector4U10F22 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Z, W, W, W); }
        public readonly Vector4U10F22 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, X, X); }
        public readonly Vector4U10F22 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, X, Y); }
        public readonly Vector4U10F22 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, X, Z); }
        public readonly Vector4U10F22 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, X, W); }
        public readonly Vector4U10F22 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, Y, X); }
        public readonly Vector4U10F22 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, Y, Y); }
        public readonly Vector4U10F22 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, Y, Z); }
        public readonly Vector4U10F22 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, Y, W); }
        public readonly Vector4U10F22 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, Z, X); }
        public readonly Vector4U10F22 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, Z, Y); }
        public readonly Vector4U10F22 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, Z, Z); }
        public readonly Vector4U10F22 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, Z, W); }
        public readonly Vector4U10F22 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, W, X); }
        public readonly Vector4U10F22 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, W, Y); }
        public readonly Vector4U10F22 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, W, Z); }
        public readonly Vector4U10F22 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, X, W, W); }
        public readonly Vector4U10F22 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, X, X); }
        public readonly Vector4U10F22 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, X, Y); }
        public readonly Vector4U10F22 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, X, Z); }
        public readonly Vector4U10F22 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, X, W); }
        public readonly Vector4U10F22 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, Y, X); }
        public readonly Vector4U10F22 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, Y, Y); }
        public readonly Vector4U10F22 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, Y, Z); }
        public readonly Vector4U10F22 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, Y, W); }
        public readonly Vector4U10F22 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, Z, X); }
        public readonly Vector4U10F22 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, Z, Y); }
        public readonly Vector4U10F22 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, Z, Z); }
        public readonly Vector4U10F22 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, Z, W); }
        public readonly Vector4U10F22 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, W, X); }
        public readonly Vector4U10F22 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, W, Y); }
        public readonly Vector4U10F22 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, W, Z); }
        public readonly Vector4U10F22 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Y, W, W); }
        public readonly Vector4U10F22 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, X, X); }
        public readonly Vector4U10F22 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, X, Y); }
        public readonly Vector4U10F22 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, X, Z); }
        public readonly Vector4U10F22 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, X, W); }
        public readonly Vector4U10F22 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, Y, X); }
        public readonly Vector4U10F22 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, Y, Y); }
        public readonly Vector4U10F22 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, Y, Z); }
        public readonly Vector4U10F22 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, Y, W); }
        public readonly Vector4U10F22 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, Z, X); }
        public readonly Vector4U10F22 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, Z, Y); }
        public readonly Vector4U10F22 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, Z, Z); }
        public readonly Vector4U10F22 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, Z, W); }
        public readonly Vector4U10F22 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, W, X); }
        public readonly Vector4U10F22 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, W, Y); }
        public readonly Vector4U10F22 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, W, Z); }
        public readonly Vector4U10F22 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, Z, W, W); }
        public readonly Vector4U10F22 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, X, X); }
        public readonly Vector4U10F22 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, X, Y); }
        public readonly Vector4U10F22 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, X, Z); }
        public readonly Vector4U10F22 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, X, W); }
        public readonly Vector4U10F22 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, Y, X); }
        public readonly Vector4U10F22 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, Y, Y); }
        public readonly Vector4U10F22 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, Y, Z); }
        public readonly Vector4U10F22 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, Y, W); }
        public readonly Vector4U10F22 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, Z, X); }
        public readonly Vector4U10F22 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, Z, Y); }
        public readonly Vector4U10F22 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, Z, Z); }
        public readonly Vector4U10F22 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, Z, W); }
        public readonly Vector4U10F22 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, W, X); }
        public readonly Vector4U10F22 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, W, Y); }
        public readonly Vector4U10F22 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, W, Z); }
        public readonly Vector4U10F22 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U10F22 lhs, Vector4U10F22 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U10F22 lhs, Vector4U10F22 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U10F22 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U10F22({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U10F22>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U10F22 other)
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
            return $"Vector4U10F22({x}, {y}, {z}, {w})";
        }
    }
}
