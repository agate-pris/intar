using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U13F19 : IEquatable<Vector4U13F19>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U13F19 X;
        public U13F19 Y;
        public U13F19 Z;
        public U13F19 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4U13F19 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, U13F19 y, U13F19 z, U13F19 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, U13F19 y, Vector2U13F19 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, Vector3U13F19 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector2U13F19 xy, Vector2U13F19 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector4U13F19 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, Vector2U13F19 yz, U13F19 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector3U13F19 xyz, U13F19 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector2U13F19 xy, U13F19 z, U13F19 w) : this(xy.X, xy.Y, z, w) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator +(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator -(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator *(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator *(Vector4U13F19 a, U13F19 b) => new Vector4U13F19(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator *(U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator /(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator /(Vector4U13F19 a, U13F19 b) => new Vector4U13F19(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator /(U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U13F19 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, X); }
        public readonly Vector2U13F19 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, Y); }
        public readonly Vector2U13F19 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, Z); }
        public readonly Vector2U13F19 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, W); }
        public readonly Vector2U13F19 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, X); }
        public readonly Vector2U13F19 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, Y); }
        public readonly Vector2U13F19 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, Z); }
        public readonly Vector2U13F19 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, W); }
        public readonly Vector2U13F19 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Z, X); }
        public readonly Vector2U13F19 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Z, Y); }
        public readonly Vector2U13F19 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Z, Z); }
        public readonly Vector2U13F19 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Z, W); }
        public readonly Vector2U13F19 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(W, X); }
        public readonly Vector2U13F19 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(W, Y); }
        public readonly Vector2U13F19 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(W, Z); }
        public readonly Vector2U13F19 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(W, W); }
        public readonly Vector3U13F19 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, X); }
        public readonly Vector3U13F19 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, Y); }
        public readonly Vector3U13F19 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, Z); }
        public readonly Vector3U13F19 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, W); }
        public readonly Vector3U13F19 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, X); }
        public readonly Vector3U13F19 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, Y); }
        public readonly Vector3U13F19 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, Z); }
        public readonly Vector3U13F19 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, W); }
        public readonly Vector3U13F19 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Z, X); }
        public readonly Vector3U13F19 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Z, Y); }
        public readonly Vector3U13F19 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Z, Z); }
        public readonly Vector3U13F19 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Z, W); }
        public readonly Vector3U13F19 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, W, X); }
        public readonly Vector3U13F19 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, W, Y); }
        public readonly Vector3U13F19 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, W, Z); }
        public readonly Vector3U13F19 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, W, W); }
        public readonly Vector3U13F19 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, X); }
        public readonly Vector3U13F19 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, Y); }
        public readonly Vector3U13F19 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, Z); }
        public readonly Vector3U13F19 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, W); }
        public readonly Vector3U13F19 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, X); }
        public readonly Vector3U13F19 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, Y); }
        public readonly Vector3U13F19 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, Z); }
        public readonly Vector3U13F19 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, W); }
        public readonly Vector3U13F19 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Z, X); }
        public readonly Vector3U13F19 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Z, Y); }
        public readonly Vector3U13F19 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Z, Z); }
        public readonly Vector3U13F19 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Z, W); }
        public readonly Vector3U13F19 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, W, X); }
        public readonly Vector3U13F19 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, W, Y); }
        public readonly Vector3U13F19 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, W, Z); }
        public readonly Vector3U13F19 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, W, W); }
        public readonly Vector3U13F19 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, X, X); }
        public readonly Vector3U13F19 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, X, Y); }
        public readonly Vector3U13F19 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, X, Z); }
        public readonly Vector3U13F19 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, X, W); }
        public readonly Vector3U13F19 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Y, X); }
        public readonly Vector3U13F19 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Y, Y); }
        public readonly Vector3U13F19 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Y, Z); }
        public readonly Vector3U13F19 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Y, W); }
        public readonly Vector3U13F19 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Z, X); }
        public readonly Vector3U13F19 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Z, Y); }
        public readonly Vector3U13F19 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Z, Z); }
        public readonly Vector3U13F19 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Z, W); }
        public readonly Vector3U13F19 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, W, X); }
        public readonly Vector3U13F19 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, W, Y); }
        public readonly Vector3U13F19 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, W, Z); }
        public readonly Vector3U13F19 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, W, W); }
        public readonly Vector3U13F19 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, X, X); }
        public readonly Vector3U13F19 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, X, Y); }
        public readonly Vector3U13F19 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, X, Z); }
        public readonly Vector3U13F19 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, X, W); }
        public readonly Vector3U13F19 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, Y, X); }
        public readonly Vector3U13F19 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, Y, Y); }
        public readonly Vector3U13F19 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, Y, Z); }
        public readonly Vector3U13F19 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, Y, W); }
        public readonly Vector3U13F19 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, Z, X); }
        public readonly Vector3U13F19 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, Z, Y); }
        public readonly Vector3U13F19 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, Z, Z); }
        public readonly Vector3U13F19 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, Z, W); }
        public readonly Vector3U13F19 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, W, X); }
        public readonly Vector3U13F19 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, W, Y); }
        public readonly Vector3U13F19 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, W, Z); }
        public readonly Vector3U13F19 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(W, W, W); }
        public readonly Vector4U13F19 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, X); }
        public readonly Vector4U13F19 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, Y); }
        public readonly Vector4U13F19 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, Z); }
        public readonly Vector4U13F19 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, W); }
        public readonly Vector4U13F19 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, X); }
        public readonly Vector4U13F19 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, Y); }
        public readonly Vector4U13F19 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, Z); }
        public readonly Vector4U13F19 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, W); }
        public readonly Vector4U13F19 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Z, X); }
        public readonly Vector4U13F19 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Z, Y); }
        public readonly Vector4U13F19 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Z, Z); }
        public readonly Vector4U13F19 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Z, W); }
        public readonly Vector4U13F19 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, W, X); }
        public readonly Vector4U13F19 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, W, Y); }
        public readonly Vector4U13F19 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, W, Z); }
        public readonly Vector4U13F19 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, W, W); }
        public readonly Vector4U13F19 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, X); }
        public readonly Vector4U13F19 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, Y); }
        public readonly Vector4U13F19 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, Z); }
        public readonly Vector4U13F19 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, W); }
        public readonly Vector4U13F19 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, X); }
        public readonly Vector4U13F19 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, Y); }
        public readonly Vector4U13F19 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, Z); }
        public readonly Vector4U13F19 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, W); }
        public readonly Vector4U13F19 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Z, X); }
        public readonly Vector4U13F19 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Z, Y); }
        public readonly Vector4U13F19 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Z, Z); }
        public readonly Vector4U13F19 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Z, W); }
        public readonly Vector4U13F19 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, W, X); }
        public readonly Vector4U13F19 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, W, Y); }
        public readonly Vector4U13F19 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, W, Z); }
        public readonly Vector4U13F19 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, W, W); }
        public readonly Vector4U13F19 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, X, X); }
        public readonly Vector4U13F19 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, X, Y); }
        public readonly Vector4U13F19 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, X, Z); }
        public readonly Vector4U13F19 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, X, W); }
        public readonly Vector4U13F19 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Y, X); }
        public readonly Vector4U13F19 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Y, Y); }
        public readonly Vector4U13F19 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Y, Z); }
        public readonly Vector4U13F19 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Y, W); }
        public readonly Vector4U13F19 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Z, X); }
        public readonly Vector4U13F19 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Z, Y); }
        public readonly Vector4U13F19 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Z, Z); }
        public readonly Vector4U13F19 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Z, W); }
        public readonly Vector4U13F19 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, W, X); }
        public readonly Vector4U13F19 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, W, Y); }
        public readonly Vector4U13F19 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, W, Z); }
        public readonly Vector4U13F19 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, W, W); }
        public readonly Vector4U13F19 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, X, X); }
        public readonly Vector4U13F19 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, X, Y); }
        public readonly Vector4U13F19 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, X, Z); }
        public readonly Vector4U13F19 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, X, W); }
        public readonly Vector4U13F19 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, Y, X); }
        public readonly Vector4U13F19 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, Y, Y); }
        public readonly Vector4U13F19 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, Y, Z); }
        public readonly Vector4U13F19 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, Y, W); }
        public readonly Vector4U13F19 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, Z, X); }
        public readonly Vector4U13F19 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, Z, Y); }
        public readonly Vector4U13F19 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, Z, Z); }
        public readonly Vector4U13F19 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, Z, W); }
        public readonly Vector4U13F19 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, W, X); }
        public readonly Vector4U13F19 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, W, Y); }
        public readonly Vector4U13F19 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, W, Z); }
        public readonly Vector4U13F19 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, W, W, W); }
        public readonly Vector4U13F19 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, X); }
        public readonly Vector4U13F19 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, Y); }
        public readonly Vector4U13F19 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, Z); }
        public readonly Vector4U13F19 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, W); }
        public readonly Vector4U13F19 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, X); }
        public readonly Vector4U13F19 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, Y); }
        public readonly Vector4U13F19 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, Z); }
        public readonly Vector4U13F19 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, W); }
        public readonly Vector4U13F19 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Z, X); }
        public readonly Vector4U13F19 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Z, Y); }
        public readonly Vector4U13F19 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Z, Z); }
        public readonly Vector4U13F19 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Z, W); }
        public readonly Vector4U13F19 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, W, X); }
        public readonly Vector4U13F19 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, W, Y); }
        public readonly Vector4U13F19 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, W, Z); }
        public readonly Vector4U13F19 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, W, W); }
        public readonly Vector4U13F19 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, X); }
        public readonly Vector4U13F19 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, Y); }
        public readonly Vector4U13F19 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, Z); }
        public readonly Vector4U13F19 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, W); }
        public readonly Vector4U13F19 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, X); }
        public readonly Vector4U13F19 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, Y); }
        public readonly Vector4U13F19 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, Z); }
        public readonly Vector4U13F19 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, W); }
        public readonly Vector4U13F19 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Z, X); }
        public readonly Vector4U13F19 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Z, Y); }
        public readonly Vector4U13F19 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Z, Z); }
        public readonly Vector4U13F19 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Z, W); }
        public readonly Vector4U13F19 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, W, X); }
        public readonly Vector4U13F19 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, W, Y); }
        public readonly Vector4U13F19 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, W, Z); }
        public readonly Vector4U13F19 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, W, W); }
        public readonly Vector4U13F19 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, X, X); }
        public readonly Vector4U13F19 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, X, Y); }
        public readonly Vector4U13F19 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, X, Z); }
        public readonly Vector4U13F19 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, X, W); }
        public readonly Vector4U13F19 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Y, X); }
        public readonly Vector4U13F19 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Y, Y); }
        public readonly Vector4U13F19 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Y, Z); }
        public readonly Vector4U13F19 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Y, W); }
        public readonly Vector4U13F19 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Z, X); }
        public readonly Vector4U13F19 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Z, Y); }
        public readonly Vector4U13F19 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Z, Z); }
        public readonly Vector4U13F19 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Z, W); }
        public readonly Vector4U13F19 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, W, X); }
        public readonly Vector4U13F19 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, W, Y); }
        public readonly Vector4U13F19 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, W, Z); }
        public readonly Vector4U13F19 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, W, W); }
        public readonly Vector4U13F19 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, X, X); }
        public readonly Vector4U13F19 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, X, Y); }
        public readonly Vector4U13F19 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, X, Z); }
        public readonly Vector4U13F19 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, X, W); }
        public readonly Vector4U13F19 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, Y, X); }
        public readonly Vector4U13F19 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, Y, Y); }
        public readonly Vector4U13F19 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, Y, Z); }
        public readonly Vector4U13F19 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, Y, W); }
        public readonly Vector4U13F19 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, Z, X); }
        public readonly Vector4U13F19 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, Z, Y); }
        public readonly Vector4U13F19 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, Z, Z); }
        public readonly Vector4U13F19 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, Z, W); }
        public readonly Vector4U13F19 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, W, X); }
        public readonly Vector4U13F19 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, W, Y); }
        public readonly Vector4U13F19 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, W, Z); }
        public readonly Vector4U13F19 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, W, W, W); }
        public readonly Vector4U13F19 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, X, X); }
        public readonly Vector4U13F19 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, X, Y); }
        public readonly Vector4U13F19 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, X, Z); }
        public readonly Vector4U13F19 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, X, W); }
        public readonly Vector4U13F19 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Y, X); }
        public readonly Vector4U13F19 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Y, Y); }
        public readonly Vector4U13F19 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Y, Z); }
        public readonly Vector4U13F19 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Y, W); }
        public readonly Vector4U13F19 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Z, X); }
        public readonly Vector4U13F19 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Z, Y); }
        public readonly Vector4U13F19 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Z, Z); }
        public readonly Vector4U13F19 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Z, W); }
        public readonly Vector4U13F19 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, W, X); }
        public readonly Vector4U13F19 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, W, Y); }
        public readonly Vector4U13F19 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, W, Z); }
        public readonly Vector4U13F19 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, W, W); }
        public readonly Vector4U13F19 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, X, X); }
        public readonly Vector4U13F19 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, X, Y); }
        public readonly Vector4U13F19 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, X, Z); }
        public readonly Vector4U13F19 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, X, W); }
        public readonly Vector4U13F19 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Y, X); }
        public readonly Vector4U13F19 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Y, Y); }
        public readonly Vector4U13F19 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Y, Z); }
        public readonly Vector4U13F19 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Y, W); }
        public readonly Vector4U13F19 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Z, X); }
        public readonly Vector4U13F19 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Z, Y); }
        public readonly Vector4U13F19 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Z, Z); }
        public readonly Vector4U13F19 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Z, W); }
        public readonly Vector4U13F19 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, W, X); }
        public readonly Vector4U13F19 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, W, Y); }
        public readonly Vector4U13F19 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, W, Z); }
        public readonly Vector4U13F19 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, W, W); }
        public readonly Vector4U13F19 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, X, X); }
        public readonly Vector4U13F19 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, X, Y); }
        public readonly Vector4U13F19 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, X, Z); }
        public readonly Vector4U13F19 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, X, W); }
        public readonly Vector4U13F19 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Y, X); }
        public readonly Vector4U13F19 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Y, Y); }
        public readonly Vector4U13F19 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Y, Z); }
        public readonly Vector4U13F19 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Y, W); }
        public readonly Vector4U13F19 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Z, X); }
        public readonly Vector4U13F19 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Z, Y); }
        public readonly Vector4U13F19 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Z, Z); }
        public readonly Vector4U13F19 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Z, W); }
        public readonly Vector4U13F19 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, W, X); }
        public readonly Vector4U13F19 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, W, Y); }
        public readonly Vector4U13F19 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, W, Z); }
        public readonly Vector4U13F19 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, W, W); }
        public readonly Vector4U13F19 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, X, X); }
        public readonly Vector4U13F19 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, X, Y); }
        public readonly Vector4U13F19 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, X, Z); }
        public readonly Vector4U13F19 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, X, W); }
        public readonly Vector4U13F19 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, Y, X); }
        public readonly Vector4U13F19 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, Y, Y); }
        public readonly Vector4U13F19 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, Y, Z); }
        public readonly Vector4U13F19 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, Y, W); }
        public readonly Vector4U13F19 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, Z, X); }
        public readonly Vector4U13F19 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, Z, Y); }
        public readonly Vector4U13F19 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, Z, Z); }
        public readonly Vector4U13F19 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, Z, W); }
        public readonly Vector4U13F19 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, W, X); }
        public readonly Vector4U13F19 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, W, Y); }
        public readonly Vector4U13F19 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, W, Z); }
        public readonly Vector4U13F19 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, W, W, W); }
        public readonly Vector4U13F19 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, X, X); }
        public readonly Vector4U13F19 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, X, Y); }
        public readonly Vector4U13F19 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, X, Z); }
        public readonly Vector4U13F19 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, X, W); }
        public readonly Vector4U13F19 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, Y, X); }
        public readonly Vector4U13F19 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, Y, Y); }
        public readonly Vector4U13F19 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, Y, Z); }
        public readonly Vector4U13F19 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, Y, W); }
        public readonly Vector4U13F19 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, Z, X); }
        public readonly Vector4U13F19 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, Z, Y); }
        public readonly Vector4U13F19 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, Z, Z); }
        public readonly Vector4U13F19 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, Z, W); }
        public readonly Vector4U13F19 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, W, X); }
        public readonly Vector4U13F19 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, W, Y); }
        public readonly Vector4U13F19 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, W, Z); }
        public readonly Vector4U13F19 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, X, W, W); }
        public readonly Vector4U13F19 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, X, X); }
        public readonly Vector4U13F19 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, X, Y); }
        public readonly Vector4U13F19 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, X, Z); }
        public readonly Vector4U13F19 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, X, W); }
        public readonly Vector4U13F19 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, Y, X); }
        public readonly Vector4U13F19 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, Y, Y); }
        public readonly Vector4U13F19 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, Y, Z); }
        public readonly Vector4U13F19 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, Y, W); }
        public readonly Vector4U13F19 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, Z, X); }
        public readonly Vector4U13F19 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, Z, Y); }
        public readonly Vector4U13F19 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, Z, Z); }
        public readonly Vector4U13F19 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, Z, W); }
        public readonly Vector4U13F19 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, W, X); }
        public readonly Vector4U13F19 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, W, Y); }
        public readonly Vector4U13F19 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, W, Z); }
        public readonly Vector4U13F19 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Y, W, W); }
        public readonly Vector4U13F19 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, X, X); }
        public readonly Vector4U13F19 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, X, Y); }
        public readonly Vector4U13F19 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, X, Z); }
        public readonly Vector4U13F19 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, X, W); }
        public readonly Vector4U13F19 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, Y, X); }
        public readonly Vector4U13F19 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, Y, Y); }
        public readonly Vector4U13F19 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, Y, Z); }
        public readonly Vector4U13F19 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, Y, W); }
        public readonly Vector4U13F19 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, Z, X); }
        public readonly Vector4U13F19 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, Z, Y); }
        public readonly Vector4U13F19 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, Z, Z); }
        public readonly Vector4U13F19 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, Z, W); }
        public readonly Vector4U13F19 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, W, X); }
        public readonly Vector4U13F19 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, W, Y); }
        public readonly Vector4U13F19 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, W, Z); }
        public readonly Vector4U13F19 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, Z, W, W); }
        public readonly Vector4U13F19 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, X, X); }
        public readonly Vector4U13F19 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, X, Y); }
        public readonly Vector4U13F19 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, X, Z); }
        public readonly Vector4U13F19 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, X, W); }
        public readonly Vector4U13F19 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, Y, X); }
        public readonly Vector4U13F19 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, Y, Y); }
        public readonly Vector4U13F19 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, Y, Z); }
        public readonly Vector4U13F19 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, Y, W); }
        public readonly Vector4U13F19 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, Z, X); }
        public readonly Vector4U13F19 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, Z, Y); }
        public readonly Vector4U13F19 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, Z, Z); }
        public readonly Vector4U13F19 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, Z, W); }
        public readonly Vector4U13F19 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, W, X); }
        public readonly Vector4U13F19 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, W, Y); }
        public readonly Vector4U13F19 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, W, Z); }
        public readonly Vector4U13F19 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U13F19 lhs, Vector4U13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U13F19 lhs, Vector4U13F19 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U13F19({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U13F19 other)
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
            return $"Vector4U13F19({x}, {y}, {z}, {w})";
        }
    }
}
