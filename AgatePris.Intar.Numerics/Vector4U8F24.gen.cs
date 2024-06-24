using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U8F24 : IEquatable<Vector4U8F24>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U8F24 X;
        public U8F24 Y;
        public U8F24 Z;
        public U8F24 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4U8F24 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(U8F24 x, U8F24 y, U8F24 z, U8F24 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(U8F24 x, U8F24 y, Vector2U8F24 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(U8F24 x, Vector3U8F24 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(Vector2U8F24 xy, Vector2U8F24 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(Vector4U8F24 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(U8F24 x, Vector2U8F24 yz, U8F24 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(Vector3U8F24 xyz, U8F24 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(Vector2U8F24 xy, U8F24 z, U8F24 w) : this(xy.X, xy.Y, z, w) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator +(Vector4U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator -(Vector4U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator *(Vector4U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator *(Vector4U8F24 a, U8F24 b) => new Vector4U8F24(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator *(U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator /(Vector4U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator /(Vector4U8F24 a, U8F24 b) => new Vector4U8F24(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator /(U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U8F24 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(X, X); }
        public readonly Vector2U8F24 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(X, Y); }
        public readonly Vector2U8F24 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(X, Z); }
        public readonly Vector2U8F24 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(X, W); }
        public readonly Vector2U8F24 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Y, X); }
        public readonly Vector2U8F24 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Y, Y); }
        public readonly Vector2U8F24 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Y, Z); }
        public readonly Vector2U8F24 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Y, W); }
        public readonly Vector2U8F24 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Z, X); }
        public readonly Vector2U8F24 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Z, Y); }
        public readonly Vector2U8F24 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Z, Z); }
        public readonly Vector2U8F24 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Z, W); }
        public readonly Vector2U8F24 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(W, X); }
        public readonly Vector2U8F24 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(W, Y); }
        public readonly Vector2U8F24 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(W, Z); }
        public readonly Vector2U8F24 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(W, W); }
        public readonly Vector3U8F24 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, X, X); }
        public readonly Vector3U8F24 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, X, Y); }
        public readonly Vector3U8F24 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, X, Z); }
        public readonly Vector3U8F24 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, X, W); }
        public readonly Vector3U8F24 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Y, X); }
        public readonly Vector3U8F24 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Y, Y); }
        public readonly Vector3U8F24 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Y, Z); }
        public readonly Vector3U8F24 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Y, W); }
        public readonly Vector3U8F24 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Z, X); }
        public readonly Vector3U8F24 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Z, Y); }
        public readonly Vector3U8F24 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Z, Z); }
        public readonly Vector3U8F24 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Z, W); }
        public readonly Vector3U8F24 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, W, X); }
        public readonly Vector3U8F24 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, W, Y); }
        public readonly Vector3U8F24 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, W, Z); }
        public readonly Vector3U8F24 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, W, W); }
        public readonly Vector3U8F24 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, X, X); }
        public readonly Vector3U8F24 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, X, Y); }
        public readonly Vector3U8F24 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, X, Z); }
        public readonly Vector3U8F24 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, X, W); }
        public readonly Vector3U8F24 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Y, X); }
        public readonly Vector3U8F24 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Y, Y); }
        public readonly Vector3U8F24 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Y, Z); }
        public readonly Vector3U8F24 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Y, W); }
        public readonly Vector3U8F24 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Z, X); }
        public readonly Vector3U8F24 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Z, Y); }
        public readonly Vector3U8F24 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Z, Z); }
        public readonly Vector3U8F24 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Z, W); }
        public readonly Vector3U8F24 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, W, X); }
        public readonly Vector3U8F24 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, W, Y); }
        public readonly Vector3U8F24 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, W, Z); }
        public readonly Vector3U8F24 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, W, W); }
        public readonly Vector3U8F24 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, X, X); }
        public readonly Vector3U8F24 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, X, Y); }
        public readonly Vector3U8F24 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, X, Z); }
        public readonly Vector3U8F24 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, X, W); }
        public readonly Vector3U8F24 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Y, X); }
        public readonly Vector3U8F24 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Y, Y); }
        public readonly Vector3U8F24 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Y, Z); }
        public readonly Vector3U8F24 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Y, W); }
        public readonly Vector3U8F24 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Z, X); }
        public readonly Vector3U8F24 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Z, Y); }
        public readonly Vector3U8F24 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Z, Z); }
        public readonly Vector3U8F24 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, Z, W); }
        public readonly Vector3U8F24 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, W, X); }
        public readonly Vector3U8F24 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, W, Y); }
        public readonly Vector3U8F24 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, W, Z); }
        public readonly Vector3U8F24 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Z, W, W); }
        public readonly Vector3U8F24 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, X, X); }
        public readonly Vector3U8F24 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, X, Y); }
        public readonly Vector3U8F24 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, X, Z); }
        public readonly Vector3U8F24 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, X, W); }
        public readonly Vector3U8F24 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, Y, X); }
        public readonly Vector3U8F24 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, Y, Y); }
        public readonly Vector3U8F24 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, Y, Z); }
        public readonly Vector3U8F24 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, Y, W); }
        public readonly Vector3U8F24 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, Z, X); }
        public readonly Vector3U8F24 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, Z, Y); }
        public readonly Vector3U8F24 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, Z, Z); }
        public readonly Vector3U8F24 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, Z, W); }
        public readonly Vector3U8F24 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, W, X); }
        public readonly Vector3U8F24 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, W, Y); }
        public readonly Vector3U8F24 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, W, Z); }
        public readonly Vector3U8F24 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(W, W, W); }
        public readonly Vector4U8F24 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, X, X); }
        public readonly Vector4U8F24 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, X, Y); }
        public readonly Vector4U8F24 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, X, Z); }
        public readonly Vector4U8F24 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, X, W); }
        public readonly Vector4U8F24 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Y, X); }
        public readonly Vector4U8F24 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Y, Y); }
        public readonly Vector4U8F24 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Y, Z); }
        public readonly Vector4U8F24 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Y, W); }
        public readonly Vector4U8F24 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Z, X); }
        public readonly Vector4U8F24 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Z, Y); }
        public readonly Vector4U8F24 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Z, Z); }
        public readonly Vector4U8F24 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Z, W); }
        public readonly Vector4U8F24 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, W, X); }
        public readonly Vector4U8F24 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, W, Y); }
        public readonly Vector4U8F24 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, W, Z); }
        public readonly Vector4U8F24 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, W, W); }
        public readonly Vector4U8F24 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, X, X); }
        public readonly Vector4U8F24 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, X, Y); }
        public readonly Vector4U8F24 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, X, Z); }
        public readonly Vector4U8F24 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, X, W); }
        public readonly Vector4U8F24 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Y, X); }
        public readonly Vector4U8F24 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Y, Y); }
        public readonly Vector4U8F24 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Y, Z); }
        public readonly Vector4U8F24 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Y, W); }
        public readonly Vector4U8F24 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Z, X); }
        public readonly Vector4U8F24 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Z, Y); }
        public readonly Vector4U8F24 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Z, Z); }
        public readonly Vector4U8F24 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Z, W); }
        public readonly Vector4U8F24 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, W, X); }
        public readonly Vector4U8F24 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, W, Y); }
        public readonly Vector4U8F24 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, W, Z); }
        public readonly Vector4U8F24 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, W, W); }
        public readonly Vector4U8F24 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, X, X); }
        public readonly Vector4U8F24 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, X, Y); }
        public readonly Vector4U8F24 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, X, Z); }
        public readonly Vector4U8F24 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, X, W); }
        public readonly Vector4U8F24 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Y, X); }
        public readonly Vector4U8F24 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Y, Y); }
        public readonly Vector4U8F24 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Y, Z); }
        public readonly Vector4U8F24 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Y, W); }
        public readonly Vector4U8F24 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Z, X); }
        public readonly Vector4U8F24 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Z, Y); }
        public readonly Vector4U8F24 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Z, Z); }
        public readonly Vector4U8F24 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, Z, W); }
        public readonly Vector4U8F24 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, W, X); }
        public readonly Vector4U8F24 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, W, Y); }
        public readonly Vector4U8F24 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, W, Z); }
        public readonly Vector4U8F24 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Z, W, W); }
        public readonly Vector4U8F24 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, X, X); }
        public readonly Vector4U8F24 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, X, Y); }
        public readonly Vector4U8F24 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, X, Z); }
        public readonly Vector4U8F24 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, X, W); }
        public readonly Vector4U8F24 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, Y, X); }
        public readonly Vector4U8F24 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, Y, Y); }
        public readonly Vector4U8F24 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, Y, Z); }
        public readonly Vector4U8F24 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, Y, W); }
        public readonly Vector4U8F24 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, Z, X); }
        public readonly Vector4U8F24 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, Z, Y); }
        public readonly Vector4U8F24 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, Z, Z); }
        public readonly Vector4U8F24 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, Z, W); }
        public readonly Vector4U8F24 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, W, X); }
        public readonly Vector4U8F24 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, W, Y); }
        public readonly Vector4U8F24 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, W, Z); }
        public readonly Vector4U8F24 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, W, W, W); }
        public readonly Vector4U8F24 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, X, X); }
        public readonly Vector4U8F24 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, X, Y); }
        public readonly Vector4U8F24 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, X, Z); }
        public readonly Vector4U8F24 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, X, W); }
        public readonly Vector4U8F24 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Y, X); }
        public readonly Vector4U8F24 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Y, Y); }
        public readonly Vector4U8F24 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Y, Z); }
        public readonly Vector4U8F24 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Y, W); }
        public readonly Vector4U8F24 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Z, X); }
        public readonly Vector4U8F24 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Z, Y); }
        public readonly Vector4U8F24 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Z, Z); }
        public readonly Vector4U8F24 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Z, W); }
        public readonly Vector4U8F24 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, W, X); }
        public readonly Vector4U8F24 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, W, Y); }
        public readonly Vector4U8F24 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, W, Z); }
        public readonly Vector4U8F24 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, W, W); }
        public readonly Vector4U8F24 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, X, X); }
        public readonly Vector4U8F24 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, X, Y); }
        public readonly Vector4U8F24 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, X, Z); }
        public readonly Vector4U8F24 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, X, W); }
        public readonly Vector4U8F24 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Y, X); }
        public readonly Vector4U8F24 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Y, Y); }
        public readonly Vector4U8F24 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Y, Z); }
        public readonly Vector4U8F24 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Y, W); }
        public readonly Vector4U8F24 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Z, X); }
        public readonly Vector4U8F24 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Z, Y); }
        public readonly Vector4U8F24 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Z, Z); }
        public readonly Vector4U8F24 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Z, W); }
        public readonly Vector4U8F24 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, W, X); }
        public readonly Vector4U8F24 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, W, Y); }
        public readonly Vector4U8F24 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, W, Z); }
        public readonly Vector4U8F24 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, W, W); }
        public readonly Vector4U8F24 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, X, X); }
        public readonly Vector4U8F24 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, X, Y); }
        public readonly Vector4U8F24 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, X, Z); }
        public readonly Vector4U8F24 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, X, W); }
        public readonly Vector4U8F24 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Y, X); }
        public readonly Vector4U8F24 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Y, Y); }
        public readonly Vector4U8F24 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Y, Z); }
        public readonly Vector4U8F24 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Y, W); }
        public readonly Vector4U8F24 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Z, X); }
        public readonly Vector4U8F24 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Z, Y); }
        public readonly Vector4U8F24 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Z, Z); }
        public readonly Vector4U8F24 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, Z, W); }
        public readonly Vector4U8F24 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, W, X); }
        public readonly Vector4U8F24 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, W, Y); }
        public readonly Vector4U8F24 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, W, Z); }
        public readonly Vector4U8F24 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Z, W, W); }
        public readonly Vector4U8F24 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, X, X); }
        public readonly Vector4U8F24 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, X, Y); }
        public readonly Vector4U8F24 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, X, Z); }
        public readonly Vector4U8F24 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, X, W); }
        public readonly Vector4U8F24 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, Y, X); }
        public readonly Vector4U8F24 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, Y, Y); }
        public readonly Vector4U8F24 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, Y, Z); }
        public readonly Vector4U8F24 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, Y, W); }
        public readonly Vector4U8F24 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, Z, X); }
        public readonly Vector4U8F24 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, Z, Y); }
        public readonly Vector4U8F24 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, Z, Z); }
        public readonly Vector4U8F24 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, Z, W); }
        public readonly Vector4U8F24 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, W, X); }
        public readonly Vector4U8F24 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, W, Y); }
        public readonly Vector4U8F24 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, W, Z); }
        public readonly Vector4U8F24 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, W, W, W); }
        public readonly Vector4U8F24 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, X, X); }
        public readonly Vector4U8F24 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, X, Y); }
        public readonly Vector4U8F24 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, X, Z); }
        public readonly Vector4U8F24 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, X, W); }
        public readonly Vector4U8F24 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Y, X); }
        public readonly Vector4U8F24 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Y, Y); }
        public readonly Vector4U8F24 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Y, Z); }
        public readonly Vector4U8F24 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Y, W); }
        public readonly Vector4U8F24 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Z, X); }
        public readonly Vector4U8F24 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Z, Y); }
        public readonly Vector4U8F24 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Z, Z); }
        public readonly Vector4U8F24 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, Z, W); }
        public readonly Vector4U8F24 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, W, X); }
        public readonly Vector4U8F24 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, W, Y); }
        public readonly Vector4U8F24 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, W, Z); }
        public readonly Vector4U8F24 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, X, W, W); }
        public readonly Vector4U8F24 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, X, X); }
        public readonly Vector4U8F24 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, X, Y); }
        public readonly Vector4U8F24 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, X, Z); }
        public readonly Vector4U8F24 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, X, W); }
        public readonly Vector4U8F24 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Y, X); }
        public readonly Vector4U8F24 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Y, Y); }
        public readonly Vector4U8F24 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Y, Z); }
        public readonly Vector4U8F24 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Y, W); }
        public readonly Vector4U8F24 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Z, X); }
        public readonly Vector4U8F24 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Z, Y); }
        public readonly Vector4U8F24 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Z, Z); }
        public readonly Vector4U8F24 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, Z, W); }
        public readonly Vector4U8F24 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, W, X); }
        public readonly Vector4U8F24 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, W, Y); }
        public readonly Vector4U8F24 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, W, Z); }
        public readonly Vector4U8F24 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Y, W, W); }
        public readonly Vector4U8F24 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, X, X); }
        public readonly Vector4U8F24 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, X, Y); }
        public readonly Vector4U8F24 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, X, Z); }
        public readonly Vector4U8F24 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, X, W); }
        public readonly Vector4U8F24 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Y, X); }
        public readonly Vector4U8F24 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Y, Y); }
        public readonly Vector4U8F24 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Y, Z); }
        public readonly Vector4U8F24 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Y, W); }
        public readonly Vector4U8F24 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Z, X); }
        public readonly Vector4U8F24 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Z, Y); }
        public readonly Vector4U8F24 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Z, Z); }
        public readonly Vector4U8F24 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, Z, W); }
        public readonly Vector4U8F24 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, W, X); }
        public readonly Vector4U8F24 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, W, Y); }
        public readonly Vector4U8F24 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, W, Z); }
        public readonly Vector4U8F24 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, Z, W, W); }
        public readonly Vector4U8F24 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, X, X); }
        public readonly Vector4U8F24 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, X, Y); }
        public readonly Vector4U8F24 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, X, Z); }
        public readonly Vector4U8F24 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, X, W); }
        public readonly Vector4U8F24 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, Y, X); }
        public readonly Vector4U8F24 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, Y, Y); }
        public readonly Vector4U8F24 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, Y, Z); }
        public readonly Vector4U8F24 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, Y, W); }
        public readonly Vector4U8F24 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, Z, X); }
        public readonly Vector4U8F24 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, Z, Y); }
        public readonly Vector4U8F24 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, Z, Z); }
        public readonly Vector4U8F24 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, Z, W); }
        public readonly Vector4U8F24 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, W, X); }
        public readonly Vector4U8F24 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, W, Y); }
        public readonly Vector4U8F24 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, W, Z); }
        public readonly Vector4U8F24 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Z, W, W, W); }
        public readonly Vector4U8F24 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, X, X); }
        public readonly Vector4U8F24 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, X, Y); }
        public readonly Vector4U8F24 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, X, Z); }
        public readonly Vector4U8F24 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, X, W); }
        public readonly Vector4U8F24 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, Y, X); }
        public readonly Vector4U8F24 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, Y, Y); }
        public readonly Vector4U8F24 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, Y, Z); }
        public readonly Vector4U8F24 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, Y, W); }
        public readonly Vector4U8F24 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, Z, X); }
        public readonly Vector4U8F24 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, Z, Y); }
        public readonly Vector4U8F24 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, Z, Z); }
        public readonly Vector4U8F24 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, Z, W); }
        public readonly Vector4U8F24 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, W, X); }
        public readonly Vector4U8F24 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, W, Y); }
        public readonly Vector4U8F24 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, W, Z); }
        public readonly Vector4U8F24 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, X, W, W); }
        public readonly Vector4U8F24 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, X, X); }
        public readonly Vector4U8F24 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, X, Y); }
        public readonly Vector4U8F24 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, X, Z); }
        public readonly Vector4U8F24 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, X, W); }
        public readonly Vector4U8F24 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, Y, X); }
        public readonly Vector4U8F24 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, Y, Y); }
        public readonly Vector4U8F24 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, Y, Z); }
        public readonly Vector4U8F24 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, Y, W); }
        public readonly Vector4U8F24 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, Z, X); }
        public readonly Vector4U8F24 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, Z, Y); }
        public readonly Vector4U8F24 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, Z, Z); }
        public readonly Vector4U8F24 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, Z, W); }
        public readonly Vector4U8F24 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, W, X); }
        public readonly Vector4U8F24 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, W, Y); }
        public readonly Vector4U8F24 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, W, Z); }
        public readonly Vector4U8F24 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Y, W, W); }
        public readonly Vector4U8F24 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, X, X); }
        public readonly Vector4U8F24 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, X, Y); }
        public readonly Vector4U8F24 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, X, Z); }
        public readonly Vector4U8F24 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, X, W); }
        public readonly Vector4U8F24 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, Y, X); }
        public readonly Vector4U8F24 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, Y, Y); }
        public readonly Vector4U8F24 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, Y, Z); }
        public readonly Vector4U8F24 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, Y, W); }
        public readonly Vector4U8F24 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, Z, X); }
        public readonly Vector4U8F24 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, Z, Y); }
        public readonly Vector4U8F24 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, Z, Z); }
        public readonly Vector4U8F24 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, Z, W); }
        public readonly Vector4U8F24 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, W, X); }
        public readonly Vector4U8F24 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, W, Y); }
        public readonly Vector4U8F24 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, W, Z); }
        public readonly Vector4U8F24 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, Z, W, W); }
        public readonly Vector4U8F24 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, X, X); }
        public readonly Vector4U8F24 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, X, Y); }
        public readonly Vector4U8F24 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, X, Z); }
        public readonly Vector4U8F24 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, X, W); }
        public readonly Vector4U8F24 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, Y, X); }
        public readonly Vector4U8F24 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, Y, Y); }
        public readonly Vector4U8F24 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, Y, Z); }
        public readonly Vector4U8F24 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, Y, W); }
        public readonly Vector4U8F24 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, Z, X); }
        public readonly Vector4U8F24 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, Z, Y); }
        public readonly Vector4U8F24 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, Z, Z); }
        public readonly Vector4U8F24 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, Z, W); }
        public readonly Vector4U8F24 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, W, X); }
        public readonly Vector4U8F24 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, W, Y); }
        public readonly Vector4U8F24 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, W, Z); }
        public readonly Vector4U8F24 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U8F24 lhs, Vector4U8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U8F24 lhs, Vector4U8F24 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U8F24({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U8F24 other)
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
            return $"Vector4U8F24({x}, {y}, {z}, {w})";
        }
    }
}
