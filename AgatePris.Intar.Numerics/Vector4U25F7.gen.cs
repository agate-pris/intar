using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U25F7 : IEquatable<Vector4U25F7>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U25F7 X;
        public U25F7 Y;
        public U25F7 Z;
        public U25F7 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, U25F7 y, U25F7 z, U25F7 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, U25F7 y, Vector2U25F7 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, Vector3U25F7 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector2U25F7 xy, Vector2U25F7 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector4U25F7 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, Vector2U25F7 yz, U25F7 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector3U25F7 xyz, U25F7 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector2U25F7 xy, U25F7 z, U25F7 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U25F7 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U25F7(U25F7.Zero);
        }
        public static Vector4U25F7 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U25F7(U25F7.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator +(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator -(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator *(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator *(Vector4U25F7 a, U25F7 b) => new Vector4U25F7(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator *(U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator /(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator /(Vector4U25F7 a, U25F7 b) => new Vector4U25F7(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator /(U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U25F7 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, X); }
        public readonly Vector2U25F7 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, Y); }
        public readonly Vector2U25F7 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, Z); }
        public readonly Vector2U25F7 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, W); }
        public readonly Vector2U25F7 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, X); }
        public readonly Vector2U25F7 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, Y); }
        public readonly Vector2U25F7 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, Z); }
        public readonly Vector2U25F7 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, W); }
        public readonly Vector2U25F7 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, X); }
        public readonly Vector2U25F7 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, Y); }
        public readonly Vector2U25F7 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, Z); }
        public readonly Vector2U25F7 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, W); }
        public readonly Vector2U25F7 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(W, X); }
        public readonly Vector2U25F7 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(W, Y); }
        public readonly Vector2U25F7 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(W, Z); }
        public readonly Vector2U25F7 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(W, W); }
        public readonly Vector3U25F7 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, X); }
        public readonly Vector3U25F7 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, Y); }
        public readonly Vector3U25F7 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, Z); }
        public readonly Vector3U25F7 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, W); }
        public readonly Vector3U25F7 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, X); }
        public readonly Vector3U25F7 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, Y); }
        public readonly Vector3U25F7 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, Z); }
        public readonly Vector3U25F7 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, W); }
        public readonly Vector3U25F7 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, X); }
        public readonly Vector3U25F7 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, Y); }
        public readonly Vector3U25F7 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, Z); }
        public readonly Vector3U25F7 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, W); }
        public readonly Vector3U25F7 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, W, X); }
        public readonly Vector3U25F7 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, W, Y); }
        public readonly Vector3U25F7 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, W, Z); }
        public readonly Vector3U25F7 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, W, W); }
        public readonly Vector3U25F7 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, X); }
        public readonly Vector3U25F7 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, Y); }
        public readonly Vector3U25F7 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, Z); }
        public readonly Vector3U25F7 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, W); }
        public readonly Vector3U25F7 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, X); }
        public readonly Vector3U25F7 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, Y); }
        public readonly Vector3U25F7 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, Z); }
        public readonly Vector3U25F7 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, W); }
        public readonly Vector3U25F7 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, X); }
        public readonly Vector3U25F7 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, Y); }
        public readonly Vector3U25F7 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, Z); }
        public readonly Vector3U25F7 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, W); }
        public readonly Vector3U25F7 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, W, X); }
        public readonly Vector3U25F7 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, W, Y); }
        public readonly Vector3U25F7 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, W, Z); }
        public readonly Vector3U25F7 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, W, W); }
        public readonly Vector3U25F7 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, X); }
        public readonly Vector3U25F7 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, Y); }
        public readonly Vector3U25F7 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, Z); }
        public readonly Vector3U25F7 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, W); }
        public readonly Vector3U25F7 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, X); }
        public readonly Vector3U25F7 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, Y); }
        public readonly Vector3U25F7 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, Z); }
        public readonly Vector3U25F7 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, W); }
        public readonly Vector3U25F7 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, X); }
        public readonly Vector3U25F7 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, Y); }
        public readonly Vector3U25F7 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, Z); }
        public readonly Vector3U25F7 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, W); }
        public readonly Vector3U25F7 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, W, X); }
        public readonly Vector3U25F7 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, W, Y); }
        public readonly Vector3U25F7 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, W, Z); }
        public readonly Vector3U25F7 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, W, W); }
        public readonly Vector3U25F7 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, X, X); }
        public readonly Vector3U25F7 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, X, Y); }
        public readonly Vector3U25F7 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, X, Z); }
        public readonly Vector3U25F7 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, X, W); }
        public readonly Vector3U25F7 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Y, X); }
        public readonly Vector3U25F7 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Y, Y); }
        public readonly Vector3U25F7 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Y, Z); }
        public readonly Vector3U25F7 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Y, W); }
        public readonly Vector3U25F7 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Z, X); }
        public readonly Vector3U25F7 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Z, Y); }
        public readonly Vector3U25F7 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Z, Z); }
        public readonly Vector3U25F7 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Z, W); }
        public readonly Vector3U25F7 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, W, X); }
        public readonly Vector3U25F7 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, W, Y); }
        public readonly Vector3U25F7 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, W, Z); }
        public readonly Vector3U25F7 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, W, W); }
        public readonly Vector4U25F7 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, X); }
        public readonly Vector4U25F7 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, Y); }
        public readonly Vector4U25F7 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, Z); }
        public readonly Vector4U25F7 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, W); }
        public readonly Vector4U25F7 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, X); }
        public readonly Vector4U25F7 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, Y); }
        public readonly Vector4U25F7 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, Z); }
        public readonly Vector4U25F7 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, W); }
        public readonly Vector4U25F7 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, X); }
        public readonly Vector4U25F7 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, Y); }
        public readonly Vector4U25F7 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, Z); }
        public readonly Vector4U25F7 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, W); }
        public readonly Vector4U25F7 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, W, X); }
        public readonly Vector4U25F7 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, W, Y); }
        public readonly Vector4U25F7 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, W, Z); }
        public readonly Vector4U25F7 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, W, W); }
        public readonly Vector4U25F7 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, X); }
        public readonly Vector4U25F7 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, Y); }
        public readonly Vector4U25F7 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, Z); }
        public readonly Vector4U25F7 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, W); }
        public readonly Vector4U25F7 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, X); }
        public readonly Vector4U25F7 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, Y); }
        public readonly Vector4U25F7 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, Z); }
        public readonly Vector4U25F7 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, W); }
        public readonly Vector4U25F7 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, X); }
        public readonly Vector4U25F7 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, Y); }
        public readonly Vector4U25F7 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, Z); }
        public readonly Vector4U25F7 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, W); }
        public readonly Vector4U25F7 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, W, X); }
        public readonly Vector4U25F7 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, W, Y); }
        public readonly Vector4U25F7 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, W, Z); }
        public readonly Vector4U25F7 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, W, W); }
        public readonly Vector4U25F7 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, X); }
        public readonly Vector4U25F7 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, Y); }
        public readonly Vector4U25F7 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, Z); }
        public readonly Vector4U25F7 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, W); }
        public readonly Vector4U25F7 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, X); }
        public readonly Vector4U25F7 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, Y); }
        public readonly Vector4U25F7 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, Z); }
        public readonly Vector4U25F7 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, W); }
        public readonly Vector4U25F7 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, X); }
        public readonly Vector4U25F7 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, Y); }
        public readonly Vector4U25F7 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, Z); }
        public readonly Vector4U25F7 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, W); }
        public readonly Vector4U25F7 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, W, X); }
        public readonly Vector4U25F7 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, W, Y); }
        public readonly Vector4U25F7 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, W, Z); }
        public readonly Vector4U25F7 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, W, W); }
        public readonly Vector4U25F7 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, X, X); }
        public readonly Vector4U25F7 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, X, Y); }
        public readonly Vector4U25F7 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, X, Z); }
        public readonly Vector4U25F7 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, X, W); }
        public readonly Vector4U25F7 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Y, X); }
        public readonly Vector4U25F7 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Y, Y); }
        public readonly Vector4U25F7 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Y, Z); }
        public readonly Vector4U25F7 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Y, W); }
        public readonly Vector4U25F7 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Z, X); }
        public readonly Vector4U25F7 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Z, Y); }
        public readonly Vector4U25F7 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Z, Z); }
        public readonly Vector4U25F7 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Z, W); }
        public readonly Vector4U25F7 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, W, X); }
        public readonly Vector4U25F7 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, W, Y); }
        public readonly Vector4U25F7 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, W, Z); }
        public readonly Vector4U25F7 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, W, W); }
        public readonly Vector4U25F7 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, X); }
        public readonly Vector4U25F7 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, Y); }
        public readonly Vector4U25F7 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, Z); }
        public readonly Vector4U25F7 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, W); }
        public readonly Vector4U25F7 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, X); }
        public readonly Vector4U25F7 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, Y); }
        public readonly Vector4U25F7 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, Z); }
        public readonly Vector4U25F7 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, W); }
        public readonly Vector4U25F7 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, X); }
        public readonly Vector4U25F7 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, Y); }
        public readonly Vector4U25F7 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, Z); }
        public readonly Vector4U25F7 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, W); }
        public readonly Vector4U25F7 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, W, X); }
        public readonly Vector4U25F7 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, W, Y); }
        public readonly Vector4U25F7 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, W, Z); }
        public readonly Vector4U25F7 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, W, W); }
        public readonly Vector4U25F7 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, X); }
        public readonly Vector4U25F7 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, Y); }
        public readonly Vector4U25F7 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, Z); }
        public readonly Vector4U25F7 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, W); }
        public readonly Vector4U25F7 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, X); }
        public readonly Vector4U25F7 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, Y); }
        public readonly Vector4U25F7 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, Z); }
        public readonly Vector4U25F7 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, W); }
        public readonly Vector4U25F7 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, X); }
        public readonly Vector4U25F7 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, Y); }
        public readonly Vector4U25F7 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, Z); }
        public readonly Vector4U25F7 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, W); }
        public readonly Vector4U25F7 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, W, X); }
        public readonly Vector4U25F7 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, W, Y); }
        public readonly Vector4U25F7 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, W, Z); }
        public readonly Vector4U25F7 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, W, W); }
        public readonly Vector4U25F7 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, X); }
        public readonly Vector4U25F7 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, Y); }
        public readonly Vector4U25F7 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, Z); }
        public readonly Vector4U25F7 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, W); }
        public readonly Vector4U25F7 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, X); }
        public readonly Vector4U25F7 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, Y); }
        public readonly Vector4U25F7 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, Z); }
        public readonly Vector4U25F7 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, W); }
        public readonly Vector4U25F7 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, X); }
        public readonly Vector4U25F7 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, Y); }
        public readonly Vector4U25F7 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, Z); }
        public readonly Vector4U25F7 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, W); }
        public readonly Vector4U25F7 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, W, X); }
        public readonly Vector4U25F7 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, W, Y); }
        public readonly Vector4U25F7 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, W, Z); }
        public readonly Vector4U25F7 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, W, W); }
        public readonly Vector4U25F7 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, X, X); }
        public readonly Vector4U25F7 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, X, Y); }
        public readonly Vector4U25F7 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, X, Z); }
        public readonly Vector4U25F7 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, X, W); }
        public readonly Vector4U25F7 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Y, X); }
        public readonly Vector4U25F7 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Y, Y); }
        public readonly Vector4U25F7 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Y, Z); }
        public readonly Vector4U25F7 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Y, W); }
        public readonly Vector4U25F7 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Z, X); }
        public readonly Vector4U25F7 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Z, Y); }
        public readonly Vector4U25F7 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Z, Z); }
        public readonly Vector4U25F7 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Z, W); }
        public readonly Vector4U25F7 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, W, X); }
        public readonly Vector4U25F7 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, W, Y); }
        public readonly Vector4U25F7 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, W, Z); }
        public readonly Vector4U25F7 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, W, W); }
        public readonly Vector4U25F7 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, X); }
        public readonly Vector4U25F7 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, Y); }
        public readonly Vector4U25F7 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, Z); }
        public readonly Vector4U25F7 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, W); }
        public readonly Vector4U25F7 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, X); }
        public readonly Vector4U25F7 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, Y); }
        public readonly Vector4U25F7 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, Z); }
        public readonly Vector4U25F7 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, W); }
        public readonly Vector4U25F7 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, X); }
        public readonly Vector4U25F7 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, Y); }
        public readonly Vector4U25F7 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, Z); }
        public readonly Vector4U25F7 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, W); }
        public readonly Vector4U25F7 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, W, X); }
        public readonly Vector4U25F7 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, W, Y); }
        public readonly Vector4U25F7 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, W, Z); }
        public readonly Vector4U25F7 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, W, W); }
        public readonly Vector4U25F7 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, X); }
        public readonly Vector4U25F7 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, Y); }
        public readonly Vector4U25F7 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, Z); }
        public readonly Vector4U25F7 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, W); }
        public readonly Vector4U25F7 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, X); }
        public readonly Vector4U25F7 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, Y); }
        public readonly Vector4U25F7 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, Z); }
        public readonly Vector4U25F7 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, W); }
        public readonly Vector4U25F7 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, X); }
        public readonly Vector4U25F7 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, Y); }
        public readonly Vector4U25F7 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, Z); }
        public readonly Vector4U25F7 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, W); }
        public readonly Vector4U25F7 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, W, X); }
        public readonly Vector4U25F7 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, W, Y); }
        public readonly Vector4U25F7 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, W, Z); }
        public readonly Vector4U25F7 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, W, W); }
        public readonly Vector4U25F7 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, X); }
        public readonly Vector4U25F7 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, Y); }
        public readonly Vector4U25F7 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, Z); }
        public readonly Vector4U25F7 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, W); }
        public readonly Vector4U25F7 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, X); }
        public readonly Vector4U25F7 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, Y); }
        public readonly Vector4U25F7 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, Z); }
        public readonly Vector4U25F7 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, W); }
        public readonly Vector4U25F7 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, X); }
        public readonly Vector4U25F7 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, Y); }
        public readonly Vector4U25F7 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, Z); }
        public readonly Vector4U25F7 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, W); }
        public readonly Vector4U25F7 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, W, X); }
        public readonly Vector4U25F7 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, W, Y); }
        public readonly Vector4U25F7 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, W, Z); }
        public readonly Vector4U25F7 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, W, W); }
        public readonly Vector4U25F7 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, X, X); }
        public readonly Vector4U25F7 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, X, Y); }
        public readonly Vector4U25F7 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, X, Z); }
        public readonly Vector4U25F7 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, X, W); }
        public readonly Vector4U25F7 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Y, X); }
        public readonly Vector4U25F7 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Y, Y); }
        public readonly Vector4U25F7 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Y, Z); }
        public readonly Vector4U25F7 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Y, W); }
        public readonly Vector4U25F7 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Z, X); }
        public readonly Vector4U25F7 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Z, Y); }
        public readonly Vector4U25F7 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Z, Z); }
        public readonly Vector4U25F7 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Z, W); }
        public readonly Vector4U25F7 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, W, X); }
        public readonly Vector4U25F7 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, W, Y); }
        public readonly Vector4U25F7 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, W, Z); }
        public readonly Vector4U25F7 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, W, W); }
        public readonly Vector4U25F7 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, X, X); }
        public readonly Vector4U25F7 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, X, Y); }
        public readonly Vector4U25F7 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, X, Z); }
        public readonly Vector4U25F7 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, X, W); }
        public readonly Vector4U25F7 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Y, X); }
        public readonly Vector4U25F7 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Y, Y); }
        public readonly Vector4U25F7 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Y, Z); }
        public readonly Vector4U25F7 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Y, W); }
        public readonly Vector4U25F7 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Z, X); }
        public readonly Vector4U25F7 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Z, Y); }
        public readonly Vector4U25F7 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Z, Z); }
        public readonly Vector4U25F7 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Z, W); }
        public readonly Vector4U25F7 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, W, X); }
        public readonly Vector4U25F7 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, W, Y); }
        public readonly Vector4U25F7 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, W, Z); }
        public readonly Vector4U25F7 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, W, W); }
        public readonly Vector4U25F7 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, X, X); }
        public readonly Vector4U25F7 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, X, Y); }
        public readonly Vector4U25F7 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, X, Z); }
        public readonly Vector4U25F7 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, X, W); }
        public readonly Vector4U25F7 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Y, X); }
        public readonly Vector4U25F7 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Y, Y); }
        public readonly Vector4U25F7 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Y, Z); }
        public readonly Vector4U25F7 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Y, W); }
        public readonly Vector4U25F7 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Z, X); }
        public readonly Vector4U25F7 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Z, Y); }
        public readonly Vector4U25F7 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Z, Z); }
        public readonly Vector4U25F7 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Z, W); }
        public readonly Vector4U25F7 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, W, X); }
        public readonly Vector4U25F7 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, W, Y); }
        public readonly Vector4U25F7 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, W, Z); }
        public readonly Vector4U25F7 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, W, W); }
        public readonly Vector4U25F7 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, X, X); }
        public readonly Vector4U25F7 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, X, Y); }
        public readonly Vector4U25F7 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, X, Z); }
        public readonly Vector4U25F7 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, X, W); }
        public readonly Vector4U25F7 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Y, X); }
        public readonly Vector4U25F7 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Y, Y); }
        public readonly Vector4U25F7 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Y, Z); }
        public readonly Vector4U25F7 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Y, W); }
        public readonly Vector4U25F7 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Z, X); }
        public readonly Vector4U25F7 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Z, Y); }
        public readonly Vector4U25F7 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Z, Z); }
        public readonly Vector4U25F7 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Z, W); }
        public readonly Vector4U25F7 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, W, X); }
        public readonly Vector4U25F7 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, W, Y); }
        public readonly Vector4U25F7 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, W, Z); }
        public readonly Vector4U25F7 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, W, W); }
        public readonly Vector4U25F7 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, X, X); }
        public readonly Vector4U25F7 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, X, Y); }
        public readonly Vector4U25F7 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, X, Z); }
        public readonly Vector4U25F7 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, X, W); }
        public readonly Vector4U25F7 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Y, X); }
        public readonly Vector4U25F7 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Y, Y); }
        public readonly Vector4U25F7 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Y, Z); }
        public readonly Vector4U25F7 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Y, W); }
        public readonly Vector4U25F7 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Z, X); }
        public readonly Vector4U25F7 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Z, Y); }
        public readonly Vector4U25F7 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Z, Z); }
        public readonly Vector4U25F7 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Z, W); }
        public readonly Vector4U25F7 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, W, X); }
        public readonly Vector4U25F7 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, W, Y); }
        public readonly Vector4U25F7 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, W, Z); }
        public readonly Vector4U25F7 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U25F7 lhs, Vector4U25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U25F7 lhs, Vector4U25F7 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U25F7({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U25F7 other)
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
            return $"Vector4U25F7({x}, {y}, {z}, {w})";
        }
    }
}
