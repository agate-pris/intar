using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U24F8 : IEquatable<Vector4U24F8>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U24F8 X;
        public U24F8 Y;
        public U24F8 Z;
        public U24F8 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, U24F8 y, U24F8 z, U24F8 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, U24F8 y, Vector2U24F8 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, Vector3U24F8 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector2U24F8 xy, Vector2U24F8 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector4U24F8 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, Vector2U24F8 yz, U24F8 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector3U24F8 xyz, U24F8 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector2U24F8 xy, U24F8 z, U24F8 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U24F8 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U24F8(U24F8.Zero);
        }
        public static Vector4U24F8 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U24F8(U24F8.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator +(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator -(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator *(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator *(Vector4U24F8 a, U24F8 b) => new Vector4U24F8(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator *(U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator /(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator /(Vector4U24F8 a, U24F8 b) => new Vector4U24F8(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator /(U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U24F8 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(X, X); }
        public readonly Vector2U24F8 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(X, Y); }
        public readonly Vector2U24F8 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(X, Z); }
        public readonly Vector2U24F8 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(X, W); }
        public readonly Vector2U24F8 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Y, X); }
        public readonly Vector2U24F8 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Y, Y); }
        public readonly Vector2U24F8 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Y, Z); }
        public readonly Vector2U24F8 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Y, W); }
        public readonly Vector2U24F8 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Z, X); }
        public readonly Vector2U24F8 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Z, Y); }
        public readonly Vector2U24F8 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Z, Z); }
        public readonly Vector2U24F8 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Z, W); }
        public readonly Vector2U24F8 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(W, X); }
        public readonly Vector2U24F8 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(W, Y); }
        public readonly Vector2U24F8 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(W, Z); }
        public readonly Vector2U24F8 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(W, W); }
        public readonly Vector3U24F8 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, X, X); }
        public readonly Vector3U24F8 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, X, Y); }
        public readonly Vector3U24F8 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, X, Z); }
        public readonly Vector3U24F8 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, X, W); }
        public readonly Vector3U24F8 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Y, X); }
        public readonly Vector3U24F8 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Y, Y); }
        public readonly Vector3U24F8 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Y, Z); }
        public readonly Vector3U24F8 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Y, W); }
        public readonly Vector3U24F8 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Z, X); }
        public readonly Vector3U24F8 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Z, Y); }
        public readonly Vector3U24F8 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Z, Z); }
        public readonly Vector3U24F8 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Z, W); }
        public readonly Vector3U24F8 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, W, X); }
        public readonly Vector3U24F8 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, W, Y); }
        public readonly Vector3U24F8 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, W, Z); }
        public readonly Vector3U24F8 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, W, W); }
        public readonly Vector3U24F8 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, X, X); }
        public readonly Vector3U24F8 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, X, Y); }
        public readonly Vector3U24F8 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, X, Z); }
        public readonly Vector3U24F8 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, X, W); }
        public readonly Vector3U24F8 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Y, X); }
        public readonly Vector3U24F8 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Y, Y); }
        public readonly Vector3U24F8 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Y, Z); }
        public readonly Vector3U24F8 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Y, W); }
        public readonly Vector3U24F8 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Z, X); }
        public readonly Vector3U24F8 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Z, Y); }
        public readonly Vector3U24F8 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Z, Z); }
        public readonly Vector3U24F8 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Z, W); }
        public readonly Vector3U24F8 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, W, X); }
        public readonly Vector3U24F8 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, W, Y); }
        public readonly Vector3U24F8 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, W, Z); }
        public readonly Vector3U24F8 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, W, W); }
        public readonly Vector3U24F8 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, X, X); }
        public readonly Vector3U24F8 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, X, Y); }
        public readonly Vector3U24F8 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, X, Z); }
        public readonly Vector3U24F8 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, X, W); }
        public readonly Vector3U24F8 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Y, X); }
        public readonly Vector3U24F8 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Y, Y); }
        public readonly Vector3U24F8 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Y, Z); }
        public readonly Vector3U24F8 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Y, W); }
        public readonly Vector3U24F8 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Z, X); }
        public readonly Vector3U24F8 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Z, Y); }
        public readonly Vector3U24F8 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Z, Z); }
        public readonly Vector3U24F8 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Z, W); }
        public readonly Vector3U24F8 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, W, X); }
        public readonly Vector3U24F8 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, W, Y); }
        public readonly Vector3U24F8 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, W, Z); }
        public readonly Vector3U24F8 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, W, W); }
        public readonly Vector3U24F8 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, X, X); }
        public readonly Vector3U24F8 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, X, Y); }
        public readonly Vector3U24F8 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, X, Z); }
        public readonly Vector3U24F8 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, X, W); }
        public readonly Vector3U24F8 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Y, X); }
        public readonly Vector3U24F8 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Y, Y); }
        public readonly Vector3U24F8 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Y, Z); }
        public readonly Vector3U24F8 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Y, W); }
        public readonly Vector3U24F8 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Z, X); }
        public readonly Vector3U24F8 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Z, Y); }
        public readonly Vector3U24F8 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Z, Z); }
        public readonly Vector3U24F8 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Z, W); }
        public readonly Vector3U24F8 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, W, X); }
        public readonly Vector3U24F8 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, W, Y); }
        public readonly Vector3U24F8 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, W, Z); }
        public readonly Vector3U24F8 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, W, W); }
        public readonly Vector4U24F8 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, X, X); }
        public readonly Vector4U24F8 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, X, Y); }
        public readonly Vector4U24F8 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, X, Z); }
        public readonly Vector4U24F8 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, X, W); }
        public readonly Vector4U24F8 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Y, X); }
        public readonly Vector4U24F8 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Y, Y); }
        public readonly Vector4U24F8 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Y, Z); }
        public readonly Vector4U24F8 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Y, W); }
        public readonly Vector4U24F8 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Z, X); }
        public readonly Vector4U24F8 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Z, Y); }
        public readonly Vector4U24F8 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Z, Z); }
        public readonly Vector4U24F8 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Z, W); }
        public readonly Vector4U24F8 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, W, X); }
        public readonly Vector4U24F8 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, W, Y); }
        public readonly Vector4U24F8 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, W, Z); }
        public readonly Vector4U24F8 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, W, W); }
        public readonly Vector4U24F8 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, X, X); }
        public readonly Vector4U24F8 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, X, Y); }
        public readonly Vector4U24F8 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, X, Z); }
        public readonly Vector4U24F8 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, X, W); }
        public readonly Vector4U24F8 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Y, X); }
        public readonly Vector4U24F8 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Y, Y); }
        public readonly Vector4U24F8 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Y, Z); }
        public readonly Vector4U24F8 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Y, W); }
        public readonly Vector4U24F8 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Z, X); }
        public readonly Vector4U24F8 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Z, Y); }
        public readonly Vector4U24F8 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Z, Z); }
        public readonly Vector4U24F8 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Z, W); }
        public readonly Vector4U24F8 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, W, X); }
        public readonly Vector4U24F8 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, W, Y); }
        public readonly Vector4U24F8 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, W, Z); }
        public readonly Vector4U24F8 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, W, W); }
        public readonly Vector4U24F8 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, X, X); }
        public readonly Vector4U24F8 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, X, Y); }
        public readonly Vector4U24F8 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, X, Z); }
        public readonly Vector4U24F8 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, X, W); }
        public readonly Vector4U24F8 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Y, X); }
        public readonly Vector4U24F8 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Y, Y); }
        public readonly Vector4U24F8 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Y, Z); }
        public readonly Vector4U24F8 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Y, W); }
        public readonly Vector4U24F8 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Z, X); }
        public readonly Vector4U24F8 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Z, Y); }
        public readonly Vector4U24F8 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Z, Z); }
        public readonly Vector4U24F8 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Z, W); }
        public readonly Vector4U24F8 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, W, X); }
        public readonly Vector4U24F8 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, W, Y); }
        public readonly Vector4U24F8 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, W, Z); }
        public readonly Vector4U24F8 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, W, W); }
        public readonly Vector4U24F8 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, X, X); }
        public readonly Vector4U24F8 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, X, Y); }
        public readonly Vector4U24F8 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, X, Z); }
        public readonly Vector4U24F8 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, X, W); }
        public readonly Vector4U24F8 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Y, X); }
        public readonly Vector4U24F8 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Y, Y); }
        public readonly Vector4U24F8 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Y, Z); }
        public readonly Vector4U24F8 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Y, W); }
        public readonly Vector4U24F8 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Z, X); }
        public readonly Vector4U24F8 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Z, Y); }
        public readonly Vector4U24F8 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Z, Z); }
        public readonly Vector4U24F8 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Z, W); }
        public readonly Vector4U24F8 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, W, X); }
        public readonly Vector4U24F8 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, W, Y); }
        public readonly Vector4U24F8 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, W, Z); }
        public readonly Vector4U24F8 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, W, W); }
        public readonly Vector4U24F8 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, X, X); }
        public readonly Vector4U24F8 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, X, Y); }
        public readonly Vector4U24F8 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, X, Z); }
        public readonly Vector4U24F8 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, X, W); }
        public readonly Vector4U24F8 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Y, X); }
        public readonly Vector4U24F8 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Y, Y); }
        public readonly Vector4U24F8 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Y, Z); }
        public readonly Vector4U24F8 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Y, W); }
        public readonly Vector4U24F8 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Z, X); }
        public readonly Vector4U24F8 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Z, Y); }
        public readonly Vector4U24F8 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Z, Z); }
        public readonly Vector4U24F8 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Z, W); }
        public readonly Vector4U24F8 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, W, X); }
        public readonly Vector4U24F8 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, W, Y); }
        public readonly Vector4U24F8 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, W, Z); }
        public readonly Vector4U24F8 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, W, W); }
        public readonly Vector4U24F8 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, X, X); }
        public readonly Vector4U24F8 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, X, Y); }
        public readonly Vector4U24F8 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, X, Z); }
        public readonly Vector4U24F8 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, X, W); }
        public readonly Vector4U24F8 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Y, X); }
        public readonly Vector4U24F8 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Y, Y); }
        public readonly Vector4U24F8 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Y, Z); }
        public readonly Vector4U24F8 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Y, W); }
        public readonly Vector4U24F8 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Z, X); }
        public readonly Vector4U24F8 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Z, Y); }
        public readonly Vector4U24F8 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Z, Z); }
        public readonly Vector4U24F8 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Z, W); }
        public readonly Vector4U24F8 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, W, X); }
        public readonly Vector4U24F8 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, W, Y); }
        public readonly Vector4U24F8 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, W, Z); }
        public readonly Vector4U24F8 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, W, W); }
        public readonly Vector4U24F8 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, X, X); }
        public readonly Vector4U24F8 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, X, Y); }
        public readonly Vector4U24F8 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, X, Z); }
        public readonly Vector4U24F8 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, X, W); }
        public readonly Vector4U24F8 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Y, X); }
        public readonly Vector4U24F8 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Y, Y); }
        public readonly Vector4U24F8 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Y, Z); }
        public readonly Vector4U24F8 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Y, W); }
        public readonly Vector4U24F8 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Z, X); }
        public readonly Vector4U24F8 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Z, Y); }
        public readonly Vector4U24F8 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Z, Z); }
        public readonly Vector4U24F8 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Z, W); }
        public readonly Vector4U24F8 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, W, X); }
        public readonly Vector4U24F8 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, W, Y); }
        public readonly Vector4U24F8 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, W, Z); }
        public readonly Vector4U24F8 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, W, W); }
        public readonly Vector4U24F8 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, X, X); }
        public readonly Vector4U24F8 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, X, Y); }
        public readonly Vector4U24F8 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, X, Z); }
        public readonly Vector4U24F8 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, X, W); }
        public readonly Vector4U24F8 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Y, X); }
        public readonly Vector4U24F8 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Y, Y); }
        public readonly Vector4U24F8 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Y, Z); }
        public readonly Vector4U24F8 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Y, W); }
        public readonly Vector4U24F8 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Z, X); }
        public readonly Vector4U24F8 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Z, Y); }
        public readonly Vector4U24F8 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Z, Z); }
        public readonly Vector4U24F8 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Z, W); }
        public readonly Vector4U24F8 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, W, X); }
        public readonly Vector4U24F8 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, W, Y); }
        public readonly Vector4U24F8 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, W, Z); }
        public readonly Vector4U24F8 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, W, W); }
        public readonly Vector4U24F8 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, X, X); }
        public readonly Vector4U24F8 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, X, Y); }
        public readonly Vector4U24F8 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, X, Z); }
        public readonly Vector4U24F8 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, X, W); }
        public readonly Vector4U24F8 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Y, X); }
        public readonly Vector4U24F8 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Y, Y); }
        public readonly Vector4U24F8 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Y, Z); }
        public readonly Vector4U24F8 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Y, W); }
        public readonly Vector4U24F8 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Z, X); }
        public readonly Vector4U24F8 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Z, Y); }
        public readonly Vector4U24F8 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Z, Z); }
        public readonly Vector4U24F8 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Z, W); }
        public readonly Vector4U24F8 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, W, X); }
        public readonly Vector4U24F8 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, W, Y); }
        public readonly Vector4U24F8 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, W, Z); }
        public readonly Vector4U24F8 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, W, W); }
        public readonly Vector4U24F8 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, X, X); }
        public readonly Vector4U24F8 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, X, Y); }
        public readonly Vector4U24F8 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, X, Z); }
        public readonly Vector4U24F8 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, X, W); }
        public readonly Vector4U24F8 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Y, X); }
        public readonly Vector4U24F8 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Y, Y); }
        public readonly Vector4U24F8 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Y, Z); }
        public readonly Vector4U24F8 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Y, W); }
        public readonly Vector4U24F8 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Z, X); }
        public readonly Vector4U24F8 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Z, Y); }
        public readonly Vector4U24F8 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Z, Z); }
        public readonly Vector4U24F8 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Z, W); }
        public readonly Vector4U24F8 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, W, X); }
        public readonly Vector4U24F8 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, W, Y); }
        public readonly Vector4U24F8 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, W, Z); }
        public readonly Vector4U24F8 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, W, W); }
        public readonly Vector4U24F8 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, X, X); }
        public readonly Vector4U24F8 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, X, Y); }
        public readonly Vector4U24F8 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, X, Z); }
        public readonly Vector4U24F8 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, X, W); }
        public readonly Vector4U24F8 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Y, X); }
        public readonly Vector4U24F8 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Y, Y); }
        public readonly Vector4U24F8 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Y, Z); }
        public readonly Vector4U24F8 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Y, W); }
        public readonly Vector4U24F8 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Z, X); }
        public readonly Vector4U24F8 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Z, Y); }
        public readonly Vector4U24F8 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Z, Z); }
        public readonly Vector4U24F8 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Z, W); }
        public readonly Vector4U24F8 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, W, X); }
        public readonly Vector4U24F8 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, W, Y); }
        public readonly Vector4U24F8 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, W, Z); }
        public readonly Vector4U24F8 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, W, W); }
        public readonly Vector4U24F8 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, X, X); }
        public readonly Vector4U24F8 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, X, Y); }
        public readonly Vector4U24F8 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, X, Z); }
        public readonly Vector4U24F8 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, X, W); }
        public readonly Vector4U24F8 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Y, X); }
        public readonly Vector4U24F8 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Y, Y); }
        public readonly Vector4U24F8 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Y, Z); }
        public readonly Vector4U24F8 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Y, W); }
        public readonly Vector4U24F8 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Z, X); }
        public readonly Vector4U24F8 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Z, Y); }
        public readonly Vector4U24F8 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Z, Z); }
        public readonly Vector4U24F8 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Z, W); }
        public readonly Vector4U24F8 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, W, X); }
        public readonly Vector4U24F8 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, W, Y); }
        public readonly Vector4U24F8 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, W, Z); }
        public readonly Vector4U24F8 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, W, W); }
        public readonly Vector4U24F8 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, X, X); }
        public readonly Vector4U24F8 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, X, Y); }
        public readonly Vector4U24F8 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, X, Z); }
        public readonly Vector4U24F8 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, X, W); }
        public readonly Vector4U24F8 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Y, X); }
        public readonly Vector4U24F8 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Y, Y); }
        public readonly Vector4U24F8 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Y, Z); }
        public readonly Vector4U24F8 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Y, W); }
        public readonly Vector4U24F8 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Z, X); }
        public readonly Vector4U24F8 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Z, Y); }
        public readonly Vector4U24F8 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Z, Z); }
        public readonly Vector4U24F8 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Z, W); }
        public readonly Vector4U24F8 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, W, X); }
        public readonly Vector4U24F8 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, W, Y); }
        public readonly Vector4U24F8 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, W, Z); }
        public readonly Vector4U24F8 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, W, W); }
        public readonly Vector4U24F8 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, X, X); }
        public readonly Vector4U24F8 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, X, Y); }
        public readonly Vector4U24F8 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, X, Z); }
        public readonly Vector4U24F8 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, X, W); }
        public readonly Vector4U24F8 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Y, X); }
        public readonly Vector4U24F8 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Y, Y); }
        public readonly Vector4U24F8 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Y, Z); }
        public readonly Vector4U24F8 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Y, W); }
        public readonly Vector4U24F8 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Z, X); }
        public readonly Vector4U24F8 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Z, Y); }
        public readonly Vector4U24F8 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Z, Z); }
        public readonly Vector4U24F8 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Z, W); }
        public readonly Vector4U24F8 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, W, X); }
        public readonly Vector4U24F8 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, W, Y); }
        public readonly Vector4U24F8 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, W, Z); }
        public readonly Vector4U24F8 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, W, W); }
        public readonly Vector4U24F8 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, X, X); }
        public readonly Vector4U24F8 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, X, Y); }
        public readonly Vector4U24F8 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, X, Z); }
        public readonly Vector4U24F8 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, X, W); }
        public readonly Vector4U24F8 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Y, X); }
        public readonly Vector4U24F8 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Y, Y); }
        public readonly Vector4U24F8 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Y, Z); }
        public readonly Vector4U24F8 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Y, W); }
        public readonly Vector4U24F8 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Z, X); }
        public readonly Vector4U24F8 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Z, Y); }
        public readonly Vector4U24F8 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Z, Z); }
        public readonly Vector4U24F8 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Z, W); }
        public readonly Vector4U24F8 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, W, X); }
        public readonly Vector4U24F8 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, W, Y); }
        public readonly Vector4U24F8 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, W, Z); }
        public readonly Vector4U24F8 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, W, W); }
        public readonly Vector4U24F8 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, X, X); }
        public readonly Vector4U24F8 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, X, Y); }
        public readonly Vector4U24F8 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, X, Z); }
        public readonly Vector4U24F8 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, X, W); }
        public readonly Vector4U24F8 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Y, X); }
        public readonly Vector4U24F8 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Y, Y); }
        public readonly Vector4U24F8 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Y, Z); }
        public readonly Vector4U24F8 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Y, W); }
        public readonly Vector4U24F8 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Z, X); }
        public readonly Vector4U24F8 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Z, Y); }
        public readonly Vector4U24F8 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Z, Z); }
        public readonly Vector4U24F8 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Z, W); }
        public readonly Vector4U24F8 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, W, X); }
        public readonly Vector4U24F8 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, W, Y); }
        public readonly Vector4U24F8 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, W, Z); }
        public readonly Vector4U24F8 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U24F8 lhs, Vector4U24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U24F8 lhs, Vector4U24F8 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U24F8({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U24F8 other)
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
            return $"Vector4U24F8({x}, {y}, {z}, {w})";
        }
    }
}
