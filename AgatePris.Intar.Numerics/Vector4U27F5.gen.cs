using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U27F5 : IEquatable<Vector4U27F5>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U27F5 X;
        public U27F5 Y;
        public U27F5 Z;
        public U27F5 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4U27F5 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, U27F5 y, U27F5 z, U27F5 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, U27F5 y, Vector2U27F5 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, Vector3U27F5 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector2U27F5 xy, Vector2U27F5 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector4U27F5 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, Vector2U27F5 yz, U27F5 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector3U27F5 xyz, U27F5 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector2U27F5 xy, U27F5 z, U27F5 w) : this(xy.X, xy.Y, z, w) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator +(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator -(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator *(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator *(Vector4U27F5 a, U27F5 b) => new Vector4U27F5(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator *(U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator /(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator /(Vector4U27F5 a, U27F5 b) => new Vector4U27F5(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator /(U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U27F5 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(X, X); }
        public readonly Vector2U27F5 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(X, Y); }
        public readonly Vector2U27F5 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(X, Z); }
        public readonly Vector2U27F5 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(X, W); }
        public readonly Vector2U27F5 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Y, X); }
        public readonly Vector2U27F5 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Y, Y); }
        public readonly Vector2U27F5 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Y, Z); }
        public readonly Vector2U27F5 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Y, W); }
        public readonly Vector2U27F5 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Z, X); }
        public readonly Vector2U27F5 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Z, Y); }
        public readonly Vector2U27F5 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Z, Z); }
        public readonly Vector2U27F5 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Z, W); }
        public readonly Vector2U27F5 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(W, X); }
        public readonly Vector2U27F5 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(W, Y); }
        public readonly Vector2U27F5 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(W, Z); }
        public readonly Vector2U27F5 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(W, W); }
        public readonly Vector3U27F5 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, X, X); }
        public readonly Vector3U27F5 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, X, Y); }
        public readonly Vector3U27F5 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, X, Z); }
        public readonly Vector3U27F5 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, X, W); }
        public readonly Vector3U27F5 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Y, X); }
        public readonly Vector3U27F5 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Y, Y); }
        public readonly Vector3U27F5 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Y, Z); }
        public readonly Vector3U27F5 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Y, W); }
        public readonly Vector3U27F5 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Z, X); }
        public readonly Vector3U27F5 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Z, Y); }
        public readonly Vector3U27F5 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Z, Z); }
        public readonly Vector3U27F5 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Z, W); }
        public readonly Vector3U27F5 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, W, X); }
        public readonly Vector3U27F5 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, W, Y); }
        public readonly Vector3U27F5 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, W, Z); }
        public readonly Vector3U27F5 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, W, W); }
        public readonly Vector3U27F5 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, X, X); }
        public readonly Vector3U27F5 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, X, Y); }
        public readonly Vector3U27F5 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, X, Z); }
        public readonly Vector3U27F5 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, X, W); }
        public readonly Vector3U27F5 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Y, X); }
        public readonly Vector3U27F5 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Y, Y); }
        public readonly Vector3U27F5 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Y, Z); }
        public readonly Vector3U27F5 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Y, W); }
        public readonly Vector3U27F5 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Z, X); }
        public readonly Vector3U27F5 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Z, Y); }
        public readonly Vector3U27F5 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Z, Z); }
        public readonly Vector3U27F5 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Z, W); }
        public readonly Vector3U27F5 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, W, X); }
        public readonly Vector3U27F5 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, W, Y); }
        public readonly Vector3U27F5 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, W, Z); }
        public readonly Vector3U27F5 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, W, W); }
        public readonly Vector3U27F5 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, X, X); }
        public readonly Vector3U27F5 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, X, Y); }
        public readonly Vector3U27F5 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, X, Z); }
        public readonly Vector3U27F5 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, X, W); }
        public readonly Vector3U27F5 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Y, X); }
        public readonly Vector3U27F5 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Y, Y); }
        public readonly Vector3U27F5 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Y, Z); }
        public readonly Vector3U27F5 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Y, W); }
        public readonly Vector3U27F5 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Z, X); }
        public readonly Vector3U27F5 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Z, Y); }
        public readonly Vector3U27F5 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Z, Z); }
        public readonly Vector3U27F5 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, Z, W); }
        public readonly Vector3U27F5 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, W, X); }
        public readonly Vector3U27F5 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, W, Y); }
        public readonly Vector3U27F5 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, W, Z); }
        public readonly Vector3U27F5 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Z, W, W); }
        public readonly Vector3U27F5 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, X, X); }
        public readonly Vector3U27F5 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, X, Y); }
        public readonly Vector3U27F5 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, X, Z); }
        public readonly Vector3U27F5 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, X, W); }
        public readonly Vector3U27F5 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, Y, X); }
        public readonly Vector3U27F5 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, Y, Y); }
        public readonly Vector3U27F5 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, Y, Z); }
        public readonly Vector3U27F5 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, Y, W); }
        public readonly Vector3U27F5 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, Z, X); }
        public readonly Vector3U27F5 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, Z, Y); }
        public readonly Vector3U27F5 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, Z, Z); }
        public readonly Vector3U27F5 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, Z, W); }
        public readonly Vector3U27F5 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, W, X); }
        public readonly Vector3U27F5 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, W, Y); }
        public readonly Vector3U27F5 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, W, Z); }
        public readonly Vector3U27F5 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(W, W, W); }
        public readonly Vector4U27F5 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, X, X); }
        public readonly Vector4U27F5 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, X, Y); }
        public readonly Vector4U27F5 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, X, Z); }
        public readonly Vector4U27F5 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, X, W); }
        public readonly Vector4U27F5 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Y, X); }
        public readonly Vector4U27F5 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Y, Y); }
        public readonly Vector4U27F5 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Y, Z); }
        public readonly Vector4U27F5 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Y, W); }
        public readonly Vector4U27F5 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Z, X); }
        public readonly Vector4U27F5 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Z, Y); }
        public readonly Vector4U27F5 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Z, Z); }
        public readonly Vector4U27F5 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Z, W); }
        public readonly Vector4U27F5 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, W, X); }
        public readonly Vector4U27F5 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, W, Y); }
        public readonly Vector4U27F5 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, W, Z); }
        public readonly Vector4U27F5 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, W, W); }
        public readonly Vector4U27F5 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, X, X); }
        public readonly Vector4U27F5 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, X, Y); }
        public readonly Vector4U27F5 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, X, Z); }
        public readonly Vector4U27F5 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, X, W); }
        public readonly Vector4U27F5 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Y, X); }
        public readonly Vector4U27F5 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Y, Y); }
        public readonly Vector4U27F5 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Y, Z); }
        public readonly Vector4U27F5 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Y, W); }
        public readonly Vector4U27F5 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Z, X); }
        public readonly Vector4U27F5 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Z, Y); }
        public readonly Vector4U27F5 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Z, Z); }
        public readonly Vector4U27F5 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Z, W); }
        public readonly Vector4U27F5 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, W, X); }
        public readonly Vector4U27F5 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, W, Y); }
        public readonly Vector4U27F5 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, W, Z); }
        public readonly Vector4U27F5 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, W, W); }
        public readonly Vector4U27F5 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, X, X); }
        public readonly Vector4U27F5 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, X, Y); }
        public readonly Vector4U27F5 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, X, Z); }
        public readonly Vector4U27F5 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, X, W); }
        public readonly Vector4U27F5 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Y, X); }
        public readonly Vector4U27F5 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Y, Y); }
        public readonly Vector4U27F5 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Y, Z); }
        public readonly Vector4U27F5 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Y, W); }
        public readonly Vector4U27F5 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Z, X); }
        public readonly Vector4U27F5 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Z, Y); }
        public readonly Vector4U27F5 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Z, Z); }
        public readonly Vector4U27F5 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, Z, W); }
        public readonly Vector4U27F5 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, W, X); }
        public readonly Vector4U27F5 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, W, Y); }
        public readonly Vector4U27F5 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, W, Z); }
        public readonly Vector4U27F5 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Z, W, W); }
        public readonly Vector4U27F5 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, X, X); }
        public readonly Vector4U27F5 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, X, Y); }
        public readonly Vector4U27F5 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, X, Z); }
        public readonly Vector4U27F5 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, X, W); }
        public readonly Vector4U27F5 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, Y, X); }
        public readonly Vector4U27F5 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, Y, Y); }
        public readonly Vector4U27F5 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, Y, Z); }
        public readonly Vector4U27F5 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, Y, W); }
        public readonly Vector4U27F5 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, Z, X); }
        public readonly Vector4U27F5 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, Z, Y); }
        public readonly Vector4U27F5 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, Z, Z); }
        public readonly Vector4U27F5 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, Z, W); }
        public readonly Vector4U27F5 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, W, X); }
        public readonly Vector4U27F5 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, W, Y); }
        public readonly Vector4U27F5 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, W, Z); }
        public readonly Vector4U27F5 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, W, W, W); }
        public readonly Vector4U27F5 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, X, X); }
        public readonly Vector4U27F5 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, X, Y); }
        public readonly Vector4U27F5 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, X, Z); }
        public readonly Vector4U27F5 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, X, W); }
        public readonly Vector4U27F5 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Y, X); }
        public readonly Vector4U27F5 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Y, Y); }
        public readonly Vector4U27F5 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Y, Z); }
        public readonly Vector4U27F5 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Y, W); }
        public readonly Vector4U27F5 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Z, X); }
        public readonly Vector4U27F5 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Z, Y); }
        public readonly Vector4U27F5 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Z, Z); }
        public readonly Vector4U27F5 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Z, W); }
        public readonly Vector4U27F5 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, W, X); }
        public readonly Vector4U27F5 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, W, Y); }
        public readonly Vector4U27F5 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, W, Z); }
        public readonly Vector4U27F5 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, W, W); }
        public readonly Vector4U27F5 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, X, X); }
        public readonly Vector4U27F5 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, X, Y); }
        public readonly Vector4U27F5 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, X, Z); }
        public readonly Vector4U27F5 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, X, W); }
        public readonly Vector4U27F5 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Y, X); }
        public readonly Vector4U27F5 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Y, Y); }
        public readonly Vector4U27F5 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Y, Z); }
        public readonly Vector4U27F5 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Y, W); }
        public readonly Vector4U27F5 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Z, X); }
        public readonly Vector4U27F5 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Z, Y); }
        public readonly Vector4U27F5 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Z, Z); }
        public readonly Vector4U27F5 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Z, W); }
        public readonly Vector4U27F5 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, W, X); }
        public readonly Vector4U27F5 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, W, Y); }
        public readonly Vector4U27F5 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, W, Z); }
        public readonly Vector4U27F5 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, W, W); }
        public readonly Vector4U27F5 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, X, X); }
        public readonly Vector4U27F5 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, X, Y); }
        public readonly Vector4U27F5 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, X, Z); }
        public readonly Vector4U27F5 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, X, W); }
        public readonly Vector4U27F5 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Y, X); }
        public readonly Vector4U27F5 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Y, Y); }
        public readonly Vector4U27F5 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Y, Z); }
        public readonly Vector4U27F5 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Y, W); }
        public readonly Vector4U27F5 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Z, X); }
        public readonly Vector4U27F5 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Z, Y); }
        public readonly Vector4U27F5 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Z, Z); }
        public readonly Vector4U27F5 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, Z, W); }
        public readonly Vector4U27F5 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, W, X); }
        public readonly Vector4U27F5 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, W, Y); }
        public readonly Vector4U27F5 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, W, Z); }
        public readonly Vector4U27F5 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Z, W, W); }
        public readonly Vector4U27F5 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, X, X); }
        public readonly Vector4U27F5 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, X, Y); }
        public readonly Vector4U27F5 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, X, Z); }
        public readonly Vector4U27F5 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, X, W); }
        public readonly Vector4U27F5 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, Y, X); }
        public readonly Vector4U27F5 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, Y, Y); }
        public readonly Vector4U27F5 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, Y, Z); }
        public readonly Vector4U27F5 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, Y, W); }
        public readonly Vector4U27F5 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, Z, X); }
        public readonly Vector4U27F5 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, Z, Y); }
        public readonly Vector4U27F5 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, Z, Z); }
        public readonly Vector4U27F5 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, Z, W); }
        public readonly Vector4U27F5 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, W, X); }
        public readonly Vector4U27F5 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, W, Y); }
        public readonly Vector4U27F5 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, W, Z); }
        public readonly Vector4U27F5 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, W, W, W); }
        public readonly Vector4U27F5 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, X, X); }
        public readonly Vector4U27F5 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, X, Y); }
        public readonly Vector4U27F5 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, X, Z); }
        public readonly Vector4U27F5 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, X, W); }
        public readonly Vector4U27F5 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Y, X); }
        public readonly Vector4U27F5 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Y, Y); }
        public readonly Vector4U27F5 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Y, Z); }
        public readonly Vector4U27F5 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Y, W); }
        public readonly Vector4U27F5 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Z, X); }
        public readonly Vector4U27F5 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Z, Y); }
        public readonly Vector4U27F5 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Z, Z); }
        public readonly Vector4U27F5 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, Z, W); }
        public readonly Vector4U27F5 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, W, X); }
        public readonly Vector4U27F5 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, W, Y); }
        public readonly Vector4U27F5 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, W, Z); }
        public readonly Vector4U27F5 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, X, W, W); }
        public readonly Vector4U27F5 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, X, X); }
        public readonly Vector4U27F5 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, X, Y); }
        public readonly Vector4U27F5 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, X, Z); }
        public readonly Vector4U27F5 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, X, W); }
        public readonly Vector4U27F5 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Y, X); }
        public readonly Vector4U27F5 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Y, Y); }
        public readonly Vector4U27F5 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Y, Z); }
        public readonly Vector4U27F5 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Y, W); }
        public readonly Vector4U27F5 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Z, X); }
        public readonly Vector4U27F5 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Z, Y); }
        public readonly Vector4U27F5 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Z, Z); }
        public readonly Vector4U27F5 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, Z, W); }
        public readonly Vector4U27F5 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, W, X); }
        public readonly Vector4U27F5 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, W, Y); }
        public readonly Vector4U27F5 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, W, Z); }
        public readonly Vector4U27F5 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Y, W, W); }
        public readonly Vector4U27F5 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, X, X); }
        public readonly Vector4U27F5 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, X, Y); }
        public readonly Vector4U27F5 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, X, Z); }
        public readonly Vector4U27F5 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, X, W); }
        public readonly Vector4U27F5 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Y, X); }
        public readonly Vector4U27F5 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Y, Y); }
        public readonly Vector4U27F5 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Y, Z); }
        public readonly Vector4U27F5 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Y, W); }
        public readonly Vector4U27F5 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Z, X); }
        public readonly Vector4U27F5 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Z, Y); }
        public readonly Vector4U27F5 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Z, Z); }
        public readonly Vector4U27F5 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, Z, W); }
        public readonly Vector4U27F5 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, W, X); }
        public readonly Vector4U27F5 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, W, Y); }
        public readonly Vector4U27F5 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, W, Z); }
        public readonly Vector4U27F5 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, Z, W, W); }
        public readonly Vector4U27F5 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, X, X); }
        public readonly Vector4U27F5 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, X, Y); }
        public readonly Vector4U27F5 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, X, Z); }
        public readonly Vector4U27F5 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, X, W); }
        public readonly Vector4U27F5 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, Y, X); }
        public readonly Vector4U27F5 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, Y, Y); }
        public readonly Vector4U27F5 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, Y, Z); }
        public readonly Vector4U27F5 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, Y, W); }
        public readonly Vector4U27F5 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, Z, X); }
        public readonly Vector4U27F5 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, Z, Y); }
        public readonly Vector4U27F5 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, Z, Z); }
        public readonly Vector4U27F5 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, Z, W); }
        public readonly Vector4U27F5 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, W, X); }
        public readonly Vector4U27F5 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, W, Y); }
        public readonly Vector4U27F5 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, W, Z); }
        public readonly Vector4U27F5 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Z, W, W, W); }
        public readonly Vector4U27F5 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, X, X); }
        public readonly Vector4U27F5 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, X, Y); }
        public readonly Vector4U27F5 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, X, Z); }
        public readonly Vector4U27F5 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, X, W); }
        public readonly Vector4U27F5 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, Y, X); }
        public readonly Vector4U27F5 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, Y, Y); }
        public readonly Vector4U27F5 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, Y, Z); }
        public readonly Vector4U27F5 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, Y, W); }
        public readonly Vector4U27F5 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, Z, X); }
        public readonly Vector4U27F5 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, Z, Y); }
        public readonly Vector4U27F5 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, Z, Z); }
        public readonly Vector4U27F5 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, Z, W); }
        public readonly Vector4U27F5 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, W, X); }
        public readonly Vector4U27F5 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, W, Y); }
        public readonly Vector4U27F5 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, W, Z); }
        public readonly Vector4U27F5 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, X, W, W); }
        public readonly Vector4U27F5 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, X, X); }
        public readonly Vector4U27F5 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, X, Y); }
        public readonly Vector4U27F5 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, X, Z); }
        public readonly Vector4U27F5 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, X, W); }
        public readonly Vector4U27F5 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, Y, X); }
        public readonly Vector4U27F5 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, Y, Y); }
        public readonly Vector4U27F5 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, Y, Z); }
        public readonly Vector4U27F5 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, Y, W); }
        public readonly Vector4U27F5 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, Z, X); }
        public readonly Vector4U27F5 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, Z, Y); }
        public readonly Vector4U27F5 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, Z, Z); }
        public readonly Vector4U27F5 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, Z, W); }
        public readonly Vector4U27F5 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, W, X); }
        public readonly Vector4U27F5 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, W, Y); }
        public readonly Vector4U27F5 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, W, Z); }
        public readonly Vector4U27F5 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Y, W, W); }
        public readonly Vector4U27F5 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, X, X); }
        public readonly Vector4U27F5 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, X, Y); }
        public readonly Vector4U27F5 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, X, Z); }
        public readonly Vector4U27F5 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, X, W); }
        public readonly Vector4U27F5 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, Y, X); }
        public readonly Vector4U27F5 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, Y, Y); }
        public readonly Vector4U27F5 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, Y, Z); }
        public readonly Vector4U27F5 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, Y, W); }
        public readonly Vector4U27F5 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, Z, X); }
        public readonly Vector4U27F5 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, Z, Y); }
        public readonly Vector4U27F5 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, Z, Z); }
        public readonly Vector4U27F5 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, Z, W); }
        public readonly Vector4U27F5 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, W, X); }
        public readonly Vector4U27F5 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, W, Y); }
        public readonly Vector4U27F5 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, W, Z); }
        public readonly Vector4U27F5 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, Z, W, W); }
        public readonly Vector4U27F5 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, X, X); }
        public readonly Vector4U27F5 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, X, Y); }
        public readonly Vector4U27F5 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, X, Z); }
        public readonly Vector4U27F5 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, X, W); }
        public readonly Vector4U27F5 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, Y, X); }
        public readonly Vector4U27F5 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, Y, Y); }
        public readonly Vector4U27F5 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, Y, Z); }
        public readonly Vector4U27F5 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, Y, W); }
        public readonly Vector4U27F5 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, Z, X); }
        public readonly Vector4U27F5 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, Z, Y); }
        public readonly Vector4U27F5 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, Z, Z); }
        public readonly Vector4U27F5 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, Z, W); }
        public readonly Vector4U27F5 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, W, X); }
        public readonly Vector4U27F5 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, W, Y); }
        public readonly Vector4U27F5 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, W, Z); }
        public readonly Vector4U27F5 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U27F5 lhs, Vector4U27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U27F5 lhs, Vector4U27F5 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U27F5({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U27F5 other)
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
            return $"Vector4U27F5({x}, {y}, {z}, {w})";
        }
    }
}
