using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U23F9 : IEquatable<Vector4U23F9>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U23F9 X;
        public U23F9 Y;
        public U23F9 Z;
        public U23F9 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4U23F9 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(U23F9 x, U23F9 y, U23F9 z, U23F9 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(U23F9 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(U23F9 x, U23F9 y, Vector2U23F9 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(U23F9 x, Vector3U23F9 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(Vector2U23F9 xy, Vector2U23F9 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(Vector4U23F9 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(U23F9 x, Vector2U23F9 yz, U23F9 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(Vector3U23F9 xyz, U23F9 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9(Vector2U23F9 xy, U23F9 z, U23F9 w) : this(xy.X, xy.Y, z, w) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator +(Vector4U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator -(Vector4U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator *(Vector4U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator *(Vector4U23F9 a, U23F9 b) => new Vector4U23F9(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator *(U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator /(Vector4U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator /(Vector4U23F9 a, U23F9 b) => new Vector4U23F9(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 operator /(U23F9 a, Vector4U23F9 b) => new Vector4U23F9(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U23F9 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(X, X); }
        public readonly Vector2U23F9 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(X, Y); }
        public readonly Vector2U23F9 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(X, Z); }
        public readonly Vector2U23F9 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(X, W); }
        public readonly Vector2U23F9 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Y, X); }
        public readonly Vector2U23F9 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Y, Y); }
        public readonly Vector2U23F9 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Y, Z); }
        public readonly Vector2U23F9 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Y, W); }
        public readonly Vector2U23F9 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Z, X); }
        public readonly Vector2U23F9 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Z, Y); }
        public readonly Vector2U23F9 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Z, Z); }
        public readonly Vector2U23F9 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Z, W); }
        public readonly Vector2U23F9 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(W, X); }
        public readonly Vector2U23F9 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(W, Y); }
        public readonly Vector2U23F9 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(W, Z); }
        public readonly Vector2U23F9 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(W, W); }
        public readonly Vector3U23F9 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, X, X); }
        public readonly Vector3U23F9 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, X, Y); }
        public readonly Vector3U23F9 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, X, Z); }
        public readonly Vector3U23F9 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, X, W); }
        public readonly Vector3U23F9 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Y, X); }
        public readonly Vector3U23F9 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Y, Y); }
        public readonly Vector3U23F9 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Y, Z); }
        public readonly Vector3U23F9 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Y, W); }
        public readonly Vector3U23F9 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Z, X); }
        public readonly Vector3U23F9 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Z, Y); }
        public readonly Vector3U23F9 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Z, Z); }
        public readonly Vector3U23F9 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Z, W); }
        public readonly Vector3U23F9 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, W, X); }
        public readonly Vector3U23F9 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, W, Y); }
        public readonly Vector3U23F9 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, W, Z); }
        public readonly Vector3U23F9 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, W, W); }
        public readonly Vector3U23F9 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, X, X); }
        public readonly Vector3U23F9 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, X, Y); }
        public readonly Vector3U23F9 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, X, Z); }
        public readonly Vector3U23F9 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, X, W); }
        public readonly Vector3U23F9 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Y, X); }
        public readonly Vector3U23F9 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Y, Y); }
        public readonly Vector3U23F9 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Y, Z); }
        public readonly Vector3U23F9 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Y, W); }
        public readonly Vector3U23F9 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Z, X); }
        public readonly Vector3U23F9 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Z, Y); }
        public readonly Vector3U23F9 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Z, Z); }
        public readonly Vector3U23F9 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Z, W); }
        public readonly Vector3U23F9 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, W, X); }
        public readonly Vector3U23F9 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, W, Y); }
        public readonly Vector3U23F9 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, W, Z); }
        public readonly Vector3U23F9 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, W, W); }
        public readonly Vector3U23F9 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, X, X); }
        public readonly Vector3U23F9 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, X, Y); }
        public readonly Vector3U23F9 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, X, Z); }
        public readonly Vector3U23F9 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, X, W); }
        public readonly Vector3U23F9 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Y, X); }
        public readonly Vector3U23F9 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Y, Y); }
        public readonly Vector3U23F9 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Y, Z); }
        public readonly Vector3U23F9 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Y, W); }
        public readonly Vector3U23F9 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Z, X); }
        public readonly Vector3U23F9 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Z, Y); }
        public readonly Vector3U23F9 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Z, Z); }
        public readonly Vector3U23F9 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, Z, W); }
        public readonly Vector3U23F9 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, W, X); }
        public readonly Vector3U23F9 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, W, Y); }
        public readonly Vector3U23F9 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, W, Z); }
        public readonly Vector3U23F9 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Z, W, W); }
        public readonly Vector3U23F9 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, X, X); }
        public readonly Vector3U23F9 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, X, Y); }
        public readonly Vector3U23F9 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, X, Z); }
        public readonly Vector3U23F9 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, X, W); }
        public readonly Vector3U23F9 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, Y, X); }
        public readonly Vector3U23F9 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, Y, Y); }
        public readonly Vector3U23F9 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, Y, Z); }
        public readonly Vector3U23F9 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, Y, W); }
        public readonly Vector3U23F9 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, Z, X); }
        public readonly Vector3U23F9 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, Z, Y); }
        public readonly Vector3U23F9 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, Z, Z); }
        public readonly Vector3U23F9 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, Z, W); }
        public readonly Vector3U23F9 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, W, X); }
        public readonly Vector3U23F9 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, W, Y); }
        public readonly Vector3U23F9 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, W, Z); }
        public readonly Vector3U23F9 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(W, W, W); }
        public readonly Vector4U23F9 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, X, X); }
        public readonly Vector4U23F9 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, X, Y); }
        public readonly Vector4U23F9 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, X, Z); }
        public readonly Vector4U23F9 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, X, W); }
        public readonly Vector4U23F9 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Y, X); }
        public readonly Vector4U23F9 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Y, Y); }
        public readonly Vector4U23F9 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Y, Z); }
        public readonly Vector4U23F9 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Y, W); }
        public readonly Vector4U23F9 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Z, X); }
        public readonly Vector4U23F9 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Z, Y); }
        public readonly Vector4U23F9 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Z, Z); }
        public readonly Vector4U23F9 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Z, W); }
        public readonly Vector4U23F9 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, W, X); }
        public readonly Vector4U23F9 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, W, Y); }
        public readonly Vector4U23F9 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, W, Z); }
        public readonly Vector4U23F9 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, W, W); }
        public readonly Vector4U23F9 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, X, X); }
        public readonly Vector4U23F9 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, X, Y); }
        public readonly Vector4U23F9 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, X, Z); }
        public readonly Vector4U23F9 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, X, W); }
        public readonly Vector4U23F9 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Y, X); }
        public readonly Vector4U23F9 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Y, Y); }
        public readonly Vector4U23F9 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Y, Z); }
        public readonly Vector4U23F9 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Y, W); }
        public readonly Vector4U23F9 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Z, X); }
        public readonly Vector4U23F9 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Z, Y); }
        public readonly Vector4U23F9 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Z, Z); }
        public readonly Vector4U23F9 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Z, W); }
        public readonly Vector4U23F9 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, W, X); }
        public readonly Vector4U23F9 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, W, Y); }
        public readonly Vector4U23F9 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, W, Z); }
        public readonly Vector4U23F9 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, W, W); }
        public readonly Vector4U23F9 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, X, X); }
        public readonly Vector4U23F9 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, X, Y); }
        public readonly Vector4U23F9 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, X, Z); }
        public readonly Vector4U23F9 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, X, W); }
        public readonly Vector4U23F9 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Y, X); }
        public readonly Vector4U23F9 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Y, Y); }
        public readonly Vector4U23F9 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Y, Z); }
        public readonly Vector4U23F9 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Y, W); }
        public readonly Vector4U23F9 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Z, X); }
        public readonly Vector4U23F9 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Z, Y); }
        public readonly Vector4U23F9 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Z, Z); }
        public readonly Vector4U23F9 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, Z, W); }
        public readonly Vector4U23F9 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, W, X); }
        public readonly Vector4U23F9 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, W, Y); }
        public readonly Vector4U23F9 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, W, Z); }
        public readonly Vector4U23F9 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Z, W, W); }
        public readonly Vector4U23F9 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, X, X); }
        public readonly Vector4U23F9 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, X, Y); }
        public readonly Vector4U23F9 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, X, Z); }
        public readonly Vector4U23F9 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, X, W); }
        public readonly Vector4U23F9 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, Y, X); }
        public readonly Vector4U23F9 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, Y, Y); }
        public readonly Vector4U23F9 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, Y, Z); }
        public readonly Vector4U23F9 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, Y, W); }
        public readonly Vector4U23F9 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, Z, X); }
        public readonly Vector4U23F9 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, Z, Y); }
        public readonly Vector4U23F9 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, Z, Z); }
        public readonly Vector4U23F9 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, Z, W); }
        public readonly Vector4U23F9 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, W, X); }
        public readonly Vector4U23F9 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, W, Y); }
        public readonly Vector4U23F9 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, W, Z); }
        public readonly Vector4U23F9 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, W, W, W); }
        public readonly Vector4U23F9 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, X, X); }
        public readonly Vector4U23F9 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, X, Y); }
        public readonly Vector4U23F9 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, X, Z); }
        public readonly Vector4U23F9 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, X, W); }
        public readonly Vector4U23F9 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Y, X); }
        public readonly Vector4U23F9 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Y, Y); }
        public readonly Vector4U23F9 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Y, Z); }
        public readonly Vector4U23F9 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Y, W); }
        public readonly Vector4U23F9 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Z, X); }
        public readonly Vector4U23F9 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Z, Y); }
        public readonly Vector4U23F9 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Z, Z); }
        public readonly Vector4U23F9 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Z, W); }
        public readonly Vector4U23F9 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, W, X); }
        public readonly Vector4U23F9 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, W, Y); }
        public readonly Vector4U23F9 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, W, Z); }
        public readonly Vector4U23F9 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, W, W); }
        public readonly Vector4U23F9 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, X, X); }
        public readonly Vector4U23F9 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, X, Y); }
        public readonly Vector4U23F9 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, X, Z); }
        public readonly Vector4U23F9 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, X, W); }
        public readonly Vector4U23F9 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Y, X); }
        public readonly Vector4U23F9 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Y, Y); }
        public readonly Vector4U23F9 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Y, Z); }
        public readonly Vector4U23F9 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Y, W); }
        public readonly Vector4U23F9 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Z, X); }
        public readonly Vector4U23F9 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Z, Y); }
        public readonly Vector4U23F9 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Z, Z); }
        public readonly Vector4U23F9 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Z, W); }
        public readonly Vector4U23F9 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, W, X); }
        public readonly Vector4U23F9 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, W, Y); }
        public readonly Vector4U23F9 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, W, Z); }
        public readonly Vector4U23F9 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, W, W); }
        public readonly Vector4U23F9 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, X, X); }
        public readonly Vector4U23F9 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, X, Y); }
        public readonly Vector4U23F9 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, X, Z); }
        public readonly Vector4U23F9 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, X, W); }
        public readonly Vector4U23F9 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Y, X); }
        public readonly Vector4U23F9 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Y, Y); }
        public readonly Vector4U23F9 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Y, Z); }
        public readonly Vector4U23F9 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Y, W); }
        public readonly Vector4U23F9 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Z, X); }
        public readonly Vector4U23F9 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Z, Y); }
        public readonly Vector4U23F9 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Z, Z); }
        public readonly Vector4U23F9 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, Z, W); }
        public readonly Vector4U23F9 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, W, X); }
        public readonly Vector4U23F9 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, W, Y); }
        public readonly Vector4U23F9 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, W, Z); }
        public readonly Vector4U23F9 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Z, W, W); }
        public readonly Vector4U23F9 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, X, X); }
        public readonly Vector4U23F9 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, X, Y); }
        public readonly Vector4U23F9 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, X, Z); }
        public readonly Vector4U23F9 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, X, W); }
        public readonly Vector4U23F9 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, Y, X); }
        public readonly Vector4U23F9 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, Y, Y); }
        public readonly Vector4U23F9 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, Y, Z); }
        public readonly Vector4U23F9 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, Y, W); }
        public readonly Vector4U23F9 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, Z, X); }
        public readonly Vector4U23F9 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, Z, Y); }
        public readonly Vector4U23F9 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, Z, Z); }
        public readonly Vector4U23F9 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, Z, W); }
        public readonly Vector4U23F9 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, W, X); }
        public readonly Vector4U23F9 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, W, Y); }
        public readonly Vector4U23F9 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, W, Z); }
        public readonly Vector4U23F9 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, W, W, W); }
        public readonly Vector4U23F9 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, X, X); }
        public readonly Vector4U23F9 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, X, Y); }
        public readonly Vector4U23F9 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, X, Z); }
        public readonly Vector4U23F9 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, X, W); }
        public readonly Vector4U23F9 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Y, X); }
        public readonly Vector4U23F9 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Y, Y); }
        public readonly Vector4U23F9 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Y, Z); }
        public readonly Vector4U23F9 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Y, W); }
        public readonly Vector4U23F9 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Z, X); }
        public readonly Vector4U23F9 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Z, Y); }
        public readonly Vector4U23F9 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Z, Z); }
        public readonly Vector4U23F9 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, Z, W); }
        public readonly Vector4U23F9 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, W, X); }
        public readonly Vector4U23F9 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, W, Y); }
        public readonly Vector4U23F9 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, W, Z); }
        public readonly Vector4U23F9 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, X, W, W); }
        public readonly Vector4U23F9 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, X, X); }
        public readonly Vector4U23F9 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, X, Y); }
        public readonly Vector4U23F9 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, X, Z); }
        public readonly Vector4U23F9 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, X, W); }
        public readonly Vector4U23F9 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Y, X); }
        public readonly Vector4U23F9 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Y, Y); }
        public readonly Vector4U23F9 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Y, Z); }
        public readonly Vector4U23F9 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Y, W); }
        public readonly Vector4U23F9 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Z, X); }
        public readonly Vector4U23F9 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Z, Y); }
        public readonly Vector4U23F9 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Z, Z); }
        public readonly Vector4U23F9 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, Z, W); }
        public readonly Vector4U23F9 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, W, X); }
        public readonly Vector4U23F9 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, W, Y); }
        public readonly Vector4U23F9 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, W, Z); }
        public readonly Vector4U23F9 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Y, W, W); }
        public readonly Vector4U23F9 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, X, X); }
        public readonly Vector4U23F9 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, X, Y); }
        public readonly Vector4U23F9 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, X, Z); }
        public readonly Vector4U23F9 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, X, W); }
        public readonly Vector4U23F9 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Y, X); }
        public readonly Vector4U23F9 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Y, Y); }
        public readonly Vector4U23F9 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Y, Z); }
        public readonly Vector4U23F9 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Y, W); }
        public readonly Vector4U23F9 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Z, X); }
        public readonly Vector4U23F9 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Z, Y); }
        public readonly Vector4U23F9 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Z, Z); }
        public readonly Vector4U23F9 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, Z, W); }
        public readonly Vector4U23F9 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, W, X); }
        public readonly Vector4U23F9 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, W, Y); }
        public readonly Vector4U23F9 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, W, Z); }
        public readonly Vector4U23F9 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, Z, W, W); }
        public readonly Vector4U23F9 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, X, X); }
        public readonly Vector4U23F9 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, X, Y); }
        public readonly Vector4U23F9 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, X, Z); }
        public readonly Vector4U23F9 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, X, W); }
        public readonly Vector4U23F9 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, Y, X); }
        public readonly Vector4U23F9 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, Y, Y); }
        public readonly Vector4U23F9 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, Y, Z); }
        public readonly Vector4U23F9 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, Y, W); }
        public readonly Vector4U23F9 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, Z, X); }
        public readonly Vector4U23F9 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, Z, Y); }
        public readonly Vector4U23F9 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, Z, Z); }
        public readonly Vector4U23F9 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, Z, W); }
        public readonly Vector4U23F9 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, W, X); }
        public readonly Vector4U23F9 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, W, Y); }
        public readonly Vector4U23F9 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, W, Z); }
        public readonly Vector4U23F9 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Z, W, W, W); }
        public readonly Vector4U23F9 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, X, X); }
        public readonly Vector4U23F9 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, X, Y); }
        public readonly Vector4U23F9 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, X, Z); }
        public readonly Vector4U23F9 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, X, W); }
        public readonly Vector4U23F9 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, Y, X); }
        public readonly Vector4U23F9 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, Y, Y); }
        public readonly Vector4U23F9 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, Y, Z); }
        public readonly Vector4U23F9 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, Y, W); }
        public readonly Vector4U23F9 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, Z, X); }
        public readonly Vector4U23F9 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, Z, Y); }
        public readonly Vector4U23F9 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, Z, Z); }
        public readonly Vector4U23F9 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, Z, W); }
        public readonly Vector4U23F9 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, W, X); }
        public readonly Vector4U23F9 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, W, Y); }
        public readonly Vector4U23F9 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, W, Z); }
        public readonly Vector4U23F9 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, X, W, W); }
        public readonly Vector4U23F9 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, X, X); }
        public readonly Vector4U23F9 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, X, Y); }
        public readonly Vector4U23F9 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, X, Z); }
        public readonly Vector4U23F9 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, X, W); }
        public readonly Vector4U23F9 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, Y, X); }
        public readonly Vector4U23F9 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, Y, Y); }
        public readonly Vector4U23F9 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, Y, Z); }
        public readonly Vector4U23F9 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, Y, W); }
        public readonly Vector4U23F9 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, Z, X); }
        public readonly Vector4U23F9 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, Z, Y); }
        public readonly Vector4U23F9 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, Z, Z); }
        public readonly Vector4U23F9 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, Z, W); }
        public readonly Vector4U23F9 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, W, X); }
        public readonly Vector4U23F9 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, W, Y); }
        public readonly Vector4U23F9 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, W, Z); }
        public readonly Vector4U23F9 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Y, W, W); }
        public readonly Vector4U23F9 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, X, X); }
        public readonly Vector4U23F9 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, X, Y); }
        public readonly Vector4U23F9 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, X, Z); }
        public readonly Vector4U23F9 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, X, W); }
        public readonly Vector4U23F9 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, Y, X); }
        public readonly Vector4U23F9 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, Y, Y); }
        public readonly Vector4U23F9 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, Y, Z); }
        public readonly Vector4U23F9 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, Y, W); }
        public readonly Vector4U23F9 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, Z, X); }
        public readonly Vector4U23F9 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, Z, Y); }
        public readonly Vector4U23F9 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, Z, Z); }
        public readonly Vector4U23F9 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, Z, W); }
        public readonly Vector4U23F9 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, W, X); }
        public readonly Vector4U23F9 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, W, Y); }
        public readonly Vector4U23F9 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, W, Z); }
        public readonly Vector4U23F9 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, Z, W, W); }
        public readonly Vector4U23F9 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, X, X); }
        public readonly Vector4U23F9 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, X, Y); }
        public readonly Vector4U23F9 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, X, Z); }
        public readonly Vector4U23F9 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, X, W); }
        public readonly Vector4U23F9 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, Y, X); }
        public readonly Vector4U23F9 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, Y, Y); }
        public readonly Vector4U23F9 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, Y, Z); }
        public readonly Vector4U23F9 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, Y, W); }
        public readonly Vector4U23F9 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, Z, X); }
        public readonly Vector4U23F9 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, Z, Y); }
        public readonly Vector4U23F9 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, Z, Z); }
        public readonly Vector4U23F9 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, Z, W); }
        public readonly Vector4U23F9 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, W, X); }
        public readonly Vector4U23F9 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, W, Y); }
        public readonly Vector4U23F9 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, W, Z); }
        public readonly Vector4U23F9 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U23F9 lhs, Vector4U23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U23F9 lhs, Vector4U23F9 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U23F9({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U23F9 other)
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
            return $"Vector4U23F9({x}, {y}, {z}, {w})";
        }
    }
}
