using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U21F11 : IEquatable<Vector4U21F11>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U21F11 X;
        public U21F11 Y;
        public U21F11 Z;
        public U21F11 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4U21F11 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, U21F11 y, U21F11 z, U21F11 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, U21F11 y, Vector2U21F11 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, Vector3U21F11 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector2U21F11 xy, Vector2U21F11 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector4U21F11 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, Vector2U21F11 yz, U21F11 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector3U21F11 xyz, U21F11 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector2U21F11 xy, U21F11 z, U21F11 w) : this(xy.X, xy.Y, z, w) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator +(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator -(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator *(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator *(Vector4U21F11 a, U21F11 b) => new Vector4U21F11(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator *(U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator /(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator /(Vector4U21F11 a, U21F11 b) => new Vector4U21F11(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator /(U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U21F11 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, X); }
        public readonly Vector2U21F11 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, Y); }
        public readonly Vector2U21F11 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, Z); }
        public readonly Vector2U21F11 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, W); }
        public readonly Vector2U21F11 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, X); }
        public readonly Vector2U21F11 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, Y); }
        public readonly Vector2U21F11 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, Z); }
        public readonly Vector2U21F11 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, W); }
        public readonly Vector2U21F11 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, X); }
        public readonly Vector2U21F11 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, Y); }
        public readonly Vector2U21F11 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, Z); }
        public readonly Vector2U21F11 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, W); }
        public readonly Vector2U21F11 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(W, X); }
        public readonly Vector2U21F11 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(W, Y); }
        public readonly Vector2U21F11 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(W, Z); }
        public readonly Vector2U21F11 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(W, W); }
        public readonly Vector3U21F11 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, X); }
        public readonly Vector3U21F11 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, Y); }
        public readonly Vector3U21F11 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, Z); }
        public readonly Vector3U21F11 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, W); }
        public readonly Vector3U21F11 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, X); }
        public readonly Vector3U21F11 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, Y); }
        public readonly Vector3U21F11 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, Z); }
        public readonly Vector3U21F11 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, W); }
        public readonly Vector3U21F11 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, X); }
        public readonly Vector3U21F11 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, Y); }
        public readonly Vector3U21F11 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, Z); }
        public readonly Vector3U21F11 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, W); }
        public readonly Vector3U21F11 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, W, X); }
        public readonly Vector3U21F11 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, W, Y); }
        public readonly Vector3U21F11 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, W, Z); }
        public readonly Vector3U21F11 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, W, W); }
        public readonly Vector3U21F11 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, X); }
        public readonly Vector3U21F11 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, Y); }
        public readonly Vector3U21F11 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, Z); }
        public readonly Vector3U21F11 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, W); }
        public readonly Vector3U21F11 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, X); }
        public readonly Vector3U21F11 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, Y); }
        public readonly Vector3U21F11 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, Z); }
        public readonly Vector3U21F11 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, W); }
        public readonly Vector3U21F11 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, X); }
        public readonly Vector3U21F11 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, Y); }
        public readonly Vector3U21F11 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, Z); }
        public readonly Vector3U21F11 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, W); }
        public readonly Vector3U21F11 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, W, X); }
        public readonly Vector3U21F11 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, W, Y); }
        public readonly Vector3U21F11 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, W, Z); }
        public readonly Vector3U21F11 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, W, W); }
        public readonly Vector3U21F11 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, X); }
        public readonly Vector3U21F11 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, Y); }
        public readonly Vector3U21F11 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, Z); }
        public readonly Vector3U21F11 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, W); }
        public readonly Vector3U21F11 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, X); }
        public readonly Vector3U21F11 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, Y); }
        public readonly Vector3U21F11 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, Z); }
        public readonly Vector3U21F11 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, W); }
        public readonly Vector3U21F11 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, X); }
        public readonly Vector3U21F11 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, Y); }
        public readonly Vector3U21F11 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, Z); }
        public readonly Vector3U21F11 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, W); }
        public readonly Vector3U21F11 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, W, X); }
        public readonly Vector3U21F11 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, W, Y); }
        public readonly Vector3U21F11 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, W, Z); }
        public readonly Vector3U21F11 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, W, W); }
        public readonly Vector3U21F11 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, X, X); }
        public readonly Vector3U21F11 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, X, Y); }
        public readonly Vector3U21F11 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, X, Z); }
        public readonly Vector3U21F11 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, X, W); }
        public readonly Vector3U21F11 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Y, X); }
        public readonly Vector3U21F11 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Y, Y); }
        public readonly Vector3U21F11 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Y, Z); }
        public readonly Vector3U21F11 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Y, W); }
        public readonly Vector3U21F11 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Z, X); }
        public readonly Vector3U21F11 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Z, Y); }
        public readonly Vector3U21F11 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Z, Z); }
        public readonly Vector3U21F11 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Z, W); }
        public readonly Vector3U21F11 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, W, X); }
        public readonly Vector3U21F11 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, W, Y); }
        public readonly Vector3U21F11 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, W, Z); }
        public readonly Vector3U21F11 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, W, W); }
        public readonly Vector4U21F11 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, X); }
        public readonly Vector4U21F11 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, Y); }
        public readonly Vector4U21F11 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, Z); }
        public readonly Vector4U21F11 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, W); }
        public readonly Vector4U21F11 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, X); }
        public readonly Vector4U21F11 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, Y); }
        public readonly Vector4U21F11 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, Z); }
        public readonly Vector4U21F11 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, W); }
        public readonly Vector4U21F11 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, X); }
        public readonly Vector4U21F11 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, Y); }
        public readonly Vector4U21F11 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, Z); }
        public readonly Vector4U21F11 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, W); }
        public readonly Vector4U21F11 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, W, X); }
        public readonly Vector4U21F11 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, W, Y); }
        public readonly Vector4U21F11 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, W, Z); }
        public readonly Vector4U21F11 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, W, W); }
        public readonly Vector4U21F11 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, X); }
        public readonly Vector4U21F11 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, Y); }
        public readonly Vector4U21F11 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, Z); }
        public readonly Vector4U21F11 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, W); }
        public readonly Vector4U21F11 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, X); }
        public readonly Vector4U21F11 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, Y); }
        public readonly Vector4U21F11 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, Z); }
        public readonly Vector4U21F11 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, W); }
        public readonly Vector4U21F11 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, X); }
        public readonly Vector4U21F11 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, Y); }
        public readonly Vector4U21F11 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, Z); }
        public readonly Vector4U21F11 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, W); }
        public readonly Vector4U21F11 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, W, X); }
        public readonly Vector4U21F11 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, W, Y); }
        public readonly Vector4U21F11 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, W, Z); }
        public readonly Vector4U21F11 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, W, W); }
        public readonly Vector4U21F11 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, X); }
        public readonly Vector4U21F11 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, Y); }
        public readonly Vector4U21F11 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, Z); }
        public readonly Vector4U21F11 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, W); }
        public readonly Vector4U21F11 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, X); }
        public readonly Vector4U21F11 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, Y); }
        public readonly Vector4U21F11 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, Z); }
        public readonly Vector4U21F11 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, W); }
        public readonly Vector4U21F11 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, X); }
        public readonly Vector4U21F11 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, Y); }
        public readonly Vector4U21F11 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, Z); }
        public readonly Vector4U21F11 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, W); }
        public readonly Vector4U21F11 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, W, X); }
        public readonly Vector4U21F11 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, W, Y); }
        public readonly Vector4U21F11 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, W, Z); }
        public readonly Vector4U21F11 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, W, W); }
        public readonly Vector4U21F11 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, X, X); }
        public readonly Vector4U21F11 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, X, Y); }
        public readonly Vector4U21F11 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, X, Z); }
        public readonly Vector4U21F11 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, X, W); }
        public readonly Vector4U21F11 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Y, X); }
        public readonly Vector4U21F11 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Y, Y); }
        public readonly Vector4U21F11 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Y, Z); }
        public readonly Vector4U21F11 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Y, W); }
        public readonly Vector4U21F11 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Z, X); }
        public readonly Vector4U21F11 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Z, Y); }
        public readonly Vector4U21F11 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Z, Z); }
        public readonly Vector4U21F11 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Z, W); }
        public readonly Vector4U21F11 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, W, X); }
        public readonly Vector4U21F11 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, W, Y); }
        public readonly Vector4U21F11 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, W, Z); }
        public readonly Vector4U21F11 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, W, W); }
        public readonly Vector4U21F11 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, X); }
        public readonly Vector4U21F11 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, Y); }
        public readonly Vector4U21F11 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, Z); }
        public readonly Vector4U21F11 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, W); }
        public readonly Vector4U21F11 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, X); }
        public readonly Vector4U21F11 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, Y); }
        public readonly Vector4U21F11 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, Z); }
        public readonly Vector4U21F11 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, W); }
        public readonly Vector4U21F11 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, X); }
        public readonly Vector4U21F11 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, Y); }
        public readonly Vector4U21F11 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, Z); }
        public readonly Vector4U21F11 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, W); }
        public readonly Vector4U21F11 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, W, X); }
        public readonly Vector4U21F11 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, W, Y); }
        public readonly Vector4U21F11 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, W, Z); }
        public readonly Vector4U21F11 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, W, W); }
        public readonly Vector4U21F11 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, X); }
        public readonly Vector4U21F11 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, Y); }
        public readonly Vector4U21F11 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, Z); }
        public readonly Vector4U21F11 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, W); }
        public readonly Vector4U21F11 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, X); }
        public readonly Vector4U21F11 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, Y); }
        public readonly Vector4U21F11 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, Z); }
        public readonly Vector4U21F11 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, W); }
        public readonly Vector4U21F11 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, X); }
        public readonly Vector4U21F11 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, Y); }
        public readonly Vector4U21F11 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, Z); }
        public readonly Vector4U21F11 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, W); }
        public readonly Vector4U21F11 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, W, X); }
        public readonly Vector4U21F11 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, W, Y); }
        public readonly Vector4U21F11 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, W, Z); }
        public readonly Vector4U21F11 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, W, W); }
        public readonly Vector4U21F11 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, X); }
        public readonly Vector4U21F11 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, Y); }
        public readonly Vector4U21F11 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, Z); }
        public readonly Vector4U21F11 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, W); }
        public readonly Vector4U21F11 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, X); }
        public readonly Vector4U21F11 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, Y); }
        public readonly Vector4U21F11 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, Z); }
        public readonly Vector4U21F11 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, W); }
        public readonly Vector4U21F11 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, X); }
        public readonly Vector4U21F11 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, Y); }
        public readonly Vector4U21F11 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, Z); }
        public readonly Vector4U21F11 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, W); }
        public readonly Vector4U21F11 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, W, X); }
        public readonly Vector4U21F11 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, W, Y); }
        public readonly Vector4U21F11 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, W, Z); }
        public readonly Vector4U21F11 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, W, W); }
        public readonly Vector4U21F11 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, X, X); }
        public readonly Vector4U21F11 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, X, Y); }
        public readonly Vector4U21F11 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, X, Z); }
        public readonly Vector4U21F11 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, X, W); }
        public readonly Vector4U21F11 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Y, X); }
        public readonly Vector4U21F11 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Y, Y); }
        public readonly Vector4U21F11 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Y, Z); }
        public readonly Vector4U21F11 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Y, W); }
        public readonly Vector4U21F11 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Z, X); }
        public readonly Vector4U21F11 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Z, Y); }
        public readonly Vector4U21F11 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Z, Z); }
        public readonly Vector4U21F11 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Z, W); }
        public readonly Vector4U21F11 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, W, X); }
        public readonly Vector4U21F11 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, W, Y); }
        public readonly Vector4U21F11 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, W, Z); }
        public readonly Vector4U21F11 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, W, W); }
        public readonly Vector4U21F11 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, X); }
        public readonly Vector4U21F11 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, Y); }
        public readonly Vector4U21F11 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, Z); }
        public readonly Vector4U21F11 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, W); }
        public readonly Vector4U21F11 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, X); }
        public readonly Vector4U21F11 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, Y); }
        public readonly Vector4U21F11 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, Z); }
        public readonly Vector4U21F11 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, W); }
        public readonly Vector4U21F11 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, X); }
        public readonly Vector4U21F11 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, Y); }
        public readonly Vector4U21F11 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, Z); }
        public readonly Vector4U21F11 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, W); }
        public readonly Vector4U21F11 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, W, X); }
        public readonly Vector4U21F11 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, W, Y); }
        public readonly Vector4U21F11 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, W, Z); }
        public readonly Vector4U21F11 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, W, W); }
        public readonly Vector4U21F11 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, X); }
        public readonly Vector4U21F11 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, Y); }
        public readonly Vector4U21F11 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, Z); }
        public readonly Vector4U21F11 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, W); }
        public readonly Vector4U21F11 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, X); }
        public readonly Vector4U21F11 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, Y); }
        public readonly Vector4U21F11 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, Z); }
        public readonly Vector4U21F11 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, W); }
        public readonly Vector4U21F11 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, X); }
        public readonly Vector4U21F11 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, Y); }
        public readonly Vector4U21F11 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, Z); }
        public readonly Vector4U21F11 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, W); }
        public readonly Vector4U21F11 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, W, X); }
        public readonly Vector4U21F11 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, W, Y); }
        public readonly Vector4U21F11 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, W, Z); }
        public readonly Vector4U21F11 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, W, W); }
        public readonly Vector4U21F11 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, X); }
        public readonly Vector4U21F11 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, Y); }
        public readonly Vector4U21F11 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, Z); }
        public readonly Vector4U21F11 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, W); }
        public readonly Vector4U21F11 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, X); }
        public readonly Vector4U21F11 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, Y); }
        public readonly Vector4U21F11 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, Z); }
        public readonly Vector4U21F11 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, W); }
        public readonly Vector4U21F11 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, X); }
        public readonly Vector4U21F11 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, Y); }
        public readonly Vector4U21F11 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, Z); }
        public readonly Vector4U21F11 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, W); }
        public readonly Vector4U21F11 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, W, X); }
        public readonly Vector4U21F11 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, W, Y); }
        public readonly Vector4U21F11 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, W, Z); }
        public readonly Vector4U21F11 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, W, W); }
        public readonly Vector4U21F11 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, X, X); }
        public readonly Vector4U21F11 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, X, Y); }
        public readonly Vector4U21F11 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, X, Z); }
        public readonly Vector4U21F11 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, X, W); }
        public readonly Vector4U21F11 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Y, X); }
        public readonly Vector4U21F11 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Y, Y); }
        public readonly Vector4U21F11 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Y, Z); }
        public readonly Vector4U21F11 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Y, W); }
        public readonly Vector4U21F11 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Z, X); }
        public readonly Vector4U21F11 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Z, Y); }
        public readonly Vector4U21F11 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Z, Z); }
        public readonly Vector4U21F11 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Z, W); }
        public readonly Vector4U21F11 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, W, X); }
        public readonly Vector4U21F11 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, W, Y); }
        public readonly Vector4U21F11 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, W, Z); }
        public readonly Vector4U21F11 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, W, W); }
        public readonly Vector4U21F11 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, X, X); }
        public readonly Vector4U21F11 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, X, Y); }
        public readonly Vector4U21F11 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, X, Z); }
        public readonly Vector4U21F11 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, X, W); }
        public readonly Vector4U21F11 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Y, X); }
        public readonly Vector4U21F11 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Y, Y); }
        public readonly Vector4U21F11 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Y, Z); }
        public readonly Vector4U21F11 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Y, W); }
        public readonly Vector4U21F11 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Z, X); }
        public readonly Vector4U21F11 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Z, Y); }
        public readonly Vector4U21F11 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Z, Z); }
        public readonly Vector4U21F11 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Z, W); }
        public readonly Vector4U21F11 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, W, X); }
        public readonly Vector4U21F11 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, W, Y); }
        public readonly Vector4U21F11 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, W, Z); }
        public readonly Vector4U21F11 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, W, W); }
        public readonly Vector4U21F11 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, X, X); }
        public readonly Vector4U21F11 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, X, Y); }
        public readonly Vector4U21F11 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, X, Z); }
        public readonly Vector4U21F11 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, X, W); }
        public readonly Vector4U21F11 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Y, X); }
        public readonly Vector4U21F11 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Y, Y); }
        public readonly Vector4U21F11 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Y, Z); }
        public readonly Vector4U21F11 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Y, W); }
        public readonly Vector4U21F11 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Z, X); }
        public readonly Vector4U21F11 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Z, Y); }
        public readonly Vector4U21F11 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Z, Z); }
        public readonly Vector4U21F11 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Z, W); }
        public readonly Vector4U21F11 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, W, X); }
        public readonly Vector4U21F11 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, W, Y); }
        public readonly Vector4U21F11 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, W, Z); }
        public readonly Vector4U21F11 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, W, W); }
        public readonly Vector4U21F11 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, X, X); }
        public readonly Vector4U21F11 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, X, Y); }
        public readonly Vector4U21F11 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, X, Z); }
        public readonly Vector4U21F11 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, X, W); }
        public readonly Vector4U21F11 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Y, X); }
        public readonly Vector4U21F11 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Y, Y); }
        public readonly Vector4U21F11 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Y, Z); }
        public readonly Vector4U21F11 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Y, W); }
        public readonly Vector4U21F11 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Z, X); }
        public readonly Vector4U21F11 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Z, Y); }
        public readonly Vector4U21F11 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Z, Z); }
        public readonly Vector4U21F11 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Z, W); }
        public readonly Vector4U21F11 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, W, X); }
        public readonly Vector4U21F11 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, W, Y); }
        public readonly Vector4U21F11 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, W, Z); }
        public readonly Vector4U21F11 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, W, W); }
        public readonly Vector4U21F11 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, X, X); }
        public readonly Vector4U21F11 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, X, Y); }
        public readonly Vector4U21F11 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, X, Z); }
        public readonly Vector4U21F11 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, X, W); }
        public readonly Vector4U21F11 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Y, X); }
        public readonly Vector4U21F11 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Y, Y); }
        public readonly Vector4U21F11 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Y, Z); }
        public readonly Vector4U21F11 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Y, W); }
        public readonly Vector4U21F11 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Z, X); }
        public readonly Vector4U21F11 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Z, Y); }
        public readonly Vector4U21F11 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Z, Z); }
        public readonly Vector4U21F11 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Z, W); }
        public readonly Vector4U21F11 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, W, X); }
        public readonly Vector4U21F11 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, W, Y); }
        public readonly Vector4U21F11 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, W, Z); }
        public readonly Vector4U21F11 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U21F11 lhs, Vector4U21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U21F11 lhs, Vector4U21F11 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U21F11({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U21F11 other)
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
            return $"Vector4U21F11({x}, {y}, {z}, {w})";
        }
    }
}
