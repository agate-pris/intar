using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U14F18 : IEquatable<Vector4U14F18>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U14F18 X;
        public U14F18 Y;
        public U14F18 Z;
        public U14F18 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(U14F18 x, U14F18 y, U14F18 z, U14F18 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(U14F18 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(U14F18 x, U14F18 y, Vector2U14F18 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(U14F18 x, Vector3U14F18 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(Vector2U14F18 xy, Vector2U14F18 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(Vector4U14F18 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(U14F18 x, Vector2U14F18 yz, U14F18 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(Vector3U14F18 xyz, U14F18 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18(Vector2U14F18 xy, U14F18 z, U14F18 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U14F18 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U14F18(U14F18.Zero);
        }
        public static Vector4U14F18 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U14F18(U14F18.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator +(Vector4U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator -(Vector4U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator *(Vector4U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator *(Vector4U14F18 a, U14F18 b) => new Vector4U14F18(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator *(U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator /(Vector4U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator /(Vector4U14F18 a, U14F18 b) => new Vector4U14F18(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 operator /(U14F18 a, Vector4U14F18 b) => new Vector4U14F18(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U14F18 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(X, X); }
        public readonly Vector2U14F18 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(X, Y); }
        public readonly Vector2U14F18 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(X, Z); }
        public readonly Vector2U14F18 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(X, W); }
        public readonly Vector2U14F18 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Y, X); }
        public readonly Vector2U14F18 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Y, Y); }
        public readonly Vector2U14F18 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Y, Z); }
        public readonly Vector2U14F18 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Y, W); }
        public readonly Vector2U14F18 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Z, X); }
        public readonly Vector2U14F18 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Z, Y); }
        public readonly Vector2U14F18 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Z, Z); }
        public readonly Vector2U14F18 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Z, W); }
        public readonly Vector2U14F18 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(W, X); }
        public readonly Vector2U14F18 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(W, Y); }
        public readonly Vector2U14F18 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(W, Z); }
        public readonly Vector2U14F18 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(W, W); }
        public readonly Vector3U14F18 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, X, X); }
        public readonly Vector3U14F18 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, X, Y); }
        public readonly Vector3U14F18 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, X, Z); }
        public readonly Vector3U14F18 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, X, W); }
        public readonly Vector3U14F18 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Y, X); }
        public readonly Vector3U14F18 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Y, Y); }
        public readonly Vector3U14F18 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Y, Z); }
        public readonly Vector3U14F18 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Y, W); }
        public readonly Vector3U14F18 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Z, X); }
        public readonly Vector3U14F18 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Z, Y); }
        public readonly Vector3U14F18 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Z, Z); }
        public readonly Vector3U14F18 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Z, W); }
        public readonly Vector3U14F18 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, W, X); }
        public readonly Vector3U14F18 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, W, Y); }
        public readonly Vector3U14F18 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, W, Z); }
        public readonly Vector3U14F18 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, W, W); }
        public readonly Vector3U14F18 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, X, X); }
        public readonly Vector3U14F18 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, X, Y); }
        public readonly Vector3U14F18 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, X, Z); }
        public readonly Vector3U14F18 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, X, W); }
        public readonly Vector3U14F18 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Y, X); }
        public readonly Vector3U14F18 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Y, Y); }
        public readonly Vector3U14F18 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Y, Z); }
        public readonly Vector3U14F18 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Y, W); }
        public readonly Vector3U14F18 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Z, X); }
        public readonly Vector3U14F18 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Z, Y); }
        public readonly Vector3U14F18 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Z, Z); }
        public readonly Vector3U14F18 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Z, W); }
        public readonly Vector3U14F18 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, W, X); }
        public readonly Vector3U14F18 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, W, Y); }
        public readonly Vector3U14F18 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, W, Z); }
        public readonly Vector3U14F18 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, W, W); }
        public readonly Vector3U14F18 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, X, X); }
        public readonly Vector3U14F18 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, X, Y); }
        public readonly Vector3U14F18 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, X, Z); }
        public readonly Vector3U14F18 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, X, W); }
        public readonly Vector3U14F18 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, Y, X); }
        public readonly Vector3U14F18 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, Y, Y); }
        public readonly Vector3U14F18 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, Y, Z); }
        public readonly Vector3U14F18 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, Y, W); }
        public readonly Vector3U14F18 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, Z, X); }
        public readonly Vector3U14F18 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, Z, Y); }
        public readonly Vector3U14F18 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, Z, Z); }
        public readonly Vector3U14F18 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, Z, W); }
        public readonly Vector3U14F18 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, W, X); }
        public readonly Vector3U14F18 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, W, Y); }
        public readonly Vector3U14F18 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, W, Z); }
        public readonly Vector3U14F18 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Z, W, W); }
        public readonly Vector3U14F18 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, X, X); }
        public readonly Vector3U14F18 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, X, Y); }
        public readonly Vector3U14F18 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, X, Z); }
        public readonly Vector3U14F18 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, X, W); }
        public readonly Vector3U14F18 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, Y, X); }
        public readonly Vector3U14F18 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, Y, Y); }
        public readonly Vector3U14F18 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, Y, Z); }
        public readonly Vector3U14F18 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, Y, W); }
        public readonly Vector3U14F18 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, Z, X); }
        public readonly Vector3U14F18 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, Z, Y); }
        public readonly Vector3U14F18 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, Z, Z); }
        public readonly Vector3U14F18 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, Z, W); }
        public readonly Vector3U14F18 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, W, X); }
        public readonly Vector3U14F18 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, W, Y); }
        public readonly Vector3U14F18 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, W, Z); }
        public readonly Vector3U14F18 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(W, W, W); }
        public readonly Vector4U14F18 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, X, X); }
        public readonly Vector4U14F18 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, X, Y); }
        public readonly Vector4U14F18 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, X, Z); }
        public readonly Vector4U14F18 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, X, W); }
        public readonly Vector4U14F18 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Y, X); }
        public readonly Vector4U14F18 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Y, Y); }
        public readonly Vector4U14F18 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Y, Z); }
        public readonly Vector4U14F18 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Y, W); }
        public readonly Vector4U14F18 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Z, X); }
        public readonly Vector4U14F18 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Z, Y); }
        public readonly Vector4U14F18 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Z, Z); }
        public readonly Vector4U14F18 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Z, W); }
        public readonly Vector4U14F18 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, W, X); }
        public readonly Vector4U14F18 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, W, Y); }
        public readonly Vector4U14F18 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, W, Z); }
        public readonly Vector4U14F18 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, W, W); }
        public readonly Vector4U14F18 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, X, X); }
        public readonly Vector4U14F18 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, X, Y); }
        public readonly Vector4U14F18 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, X, Z); }
        public readonly Vector4U14F18 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, X, W); }
        public readonly Vector4U14F18 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Y, X); }
        public readonly Vector4U14F18 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Y, Y); }
        public readonly Vector4U14F18 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Y, Z); }
        public readonly Vector4U14F18 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Y, W); }
        public readonly Vector4U14F18 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Z, X); }
        public readonly Vector4U14F18 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Z, Y); }
        public readonly Vector4U14F18 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Z, Z); }
        public readonly Vector4U14F18 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Z, W); }
        public readonly Vector4U14F18 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, W, X); }
        public readonly Vector4U14F18 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, W, Y); }
        public readonly Vector4U14F18 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, W, Z); }
        public readonly Vector4U14F18 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, W, W); }
        public readonly Vector4U14F18 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, X, X); }
        public readonly Vector4U14F18 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, X, Y); }
        public readonly Vector4U14F18 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, X, Z); }
        public readonly Vector4U14F18 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, X, W); }
        public readonly Vector4U14F18 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, Y, X); }
        public readonly Vector4U14F18 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, Y, Y); }
        public readonly Vector4U14F18 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, Y, Z); }
        public readonly Vector4U14F18 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, Y, W); }
        public readonly Vector4U14F18 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, Z, X); }
        public readonly Vector4U14F18 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, Z, Y); }
        public readonly Vector4U14F18 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, Z, Z); }
        public readonly Vector4U14F18 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, Z, W); }
        public readonly Vector4U14F18 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, W, X); }
        public readonly Vector4U14F18 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, W, Y); }
        public readonly Vector4U14F18 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, W, Z); }
        public readonly Vector4U14F18 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Z, W, W); }
        public readonly Vector4U14F18 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, X, X); }
        public readonly Vector4U14F18 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, X, Y); }
        public readonly Vector4U14F18 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, X, Z); }
        public readonly Vector4U14F18 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, X, W); }
        public readonly Vector4U14F18 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, Y, X); }
        public readonly Vector4U14F18 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, Y, Y); }
        public readonly Vector4U14F18 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, Y, Z); }
        public readonly Vector4U14F18 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, Y, W); }
        public readonly Vector4U14F18 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, Z, X); }
        public readonly Vector4U14F18 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, Z, Y); }
        public readonly Vector4U14F18 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, Z, Z); }
        public readonly Vector4U14F18 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, Z, W); }
        public readonly Vector4U14F18 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, W, X); }
        public readonly Vector4U14F18 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, W, Y); }
        public readonly Vector4U14F18 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, W, Z); }
        public readonly Vector4U14F18 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, W, W, W); }
        public readonly Vector4U14F18 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, X, X); }
        public readonly Vector4U14F18 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, X, Y); }
        public readonly Vector4U14F18 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, X, Z); }
        public readonly Vector4U14F18 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, X, W); }
        public readonly Vector4U14F18 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Y, X); }
        public readonly Vector4U14F18 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Y, Y); }
        public readonly Vector4U14F18 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Y, Z); }
        public readonly Vector4U14F18 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Y, W); }
        public readonly Vector4U14F18 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Z, X); }
        public readonly Vector4U14F18 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Z, Y); }
        public readonly Vector4U14F18 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Z, Z); }
        public readonly Vector4U14F18 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Z, W); }
        public readonly Vector4U14F18 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, W, X); }
        public readonly Vector4U14F18 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, W, Y); }
        public readonly Vector4U14F18 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, W, Z); }
        public readonly Vector4U14F18 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, W, W); }
        public readonly Vector4U14F18 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, X, X); }
        public readonly Vector4U14F18 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, X, Y); }
        public readonly Vector4U14F18 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, X, Z); }
        public readonly Vector4U14F18 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, X, W); }
        public readonly Vector4U14F18 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Y, X); }
        public readonly Vector4U14F18 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Y, Y); }
        public readonly Vector4U14F18 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Y, Z); }
        public readonly Vector4U14F18 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Y, W); }
        public readonly Vector4U14F18 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Z, X); }
        public readonly Vector4U14F18 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Z, Y); }
        public readonly Vector4U14F18 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Z, Z); }
        public readonly Vector4U14F18 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Z, W); }
        public readonly Vector4U14F18 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, W, X); }
        public readonly Vector4U14F18 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, W, Y); }
        public readonly Vector4U14F18 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, W, Z); }
        public readonly Vector4U14F18 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, W, W); }
        public readonly Vector4U14F18 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, X, X); }
        public readonly Vector4U14F18 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, X, Y); }
        public readonly Vector4U14F18 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, X, Z); }
        public readonly Vector4U14F18 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, X, W); }
        public readonly Vector4U14F18 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, Y, X); }
        public readonly Vector4U14F18 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, Y, Y); }
        public readonly Vector4U14F18 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, Y, Z); }
        public readonly Vector4U14F18 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, Y, W); }
        public readonly Vector4U14F18 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, Z, X); }
        public readonly Vector4U14F18 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, Z, Y); }
        public readonly Vector4U14F18 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, Z, Z); }
        public readonly Vector4U14F18 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, Z, W); }
        public readonly Vector4U14F18 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, W, X); }
        public readonly Vector4U14F18 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, W, Y); }
        public readonly Vector4U14F18 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, W, Z); }
        public readonly Vector4U14F18 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Z, W, W); }
        public readonly Vector4U14F18 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, X, X); }
        public readonly Vector4U14F18 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, X, Y); }
        public readonly Vector4U14F18 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, X, Z); }
        public readonly Vector4U14F18 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, X, W); }
        public readonly Vector4U14F18 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, Y, X); }
        public readonly Vector4U14F18 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, Y, Y); }
        public readonly Vector4U14F18 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, Y, Z); }
        public readonly Vector4U14F18 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, Y, W); }
        public readonly Vector4U14F18 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, Z, X); }
        public readonly Vector4U14F18 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, Z, Y); }
        public readonly Vector4U14F18 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, Z, Z); }
        public readonly Vector4U14F18 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, Z, W); }
        public readonly Vector4U14F18 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, W, X); }
        public readonly Vector4U14F18 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, W, Y); }
        public readonly Vector4U14F18 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, W, Z); }
        public readonly Vector4U14F18 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, W, W, W); }
        public readonly Vector4U14F18 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, X, X); }
        public readonly Vector4U14F18 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, X, Y); }
        public readonly Vector4U14F18 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, X, Z); }
        public readonly Vector4U14F18 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, X, W); }
        public readonly Vector4U14F18 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, Y, X); }
        public readonly Vector4U14F18 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, Y, Y); }
        public readonly Vector4U14F18 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, Y, Z); }
        public readonly Vector4U14F18 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, Y, W); }
        public readonly Vector4U14F18 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, Z, X); }
        public readonly Vector4U14F18 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, Z, Y); }
        public readonly Vector4U14F18 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, Z, Z); }
        public readonly Vector4U14F18 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, Z, W); }
        public readonly Vector4U14F18 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, W, X); }
        public readonly Vector4U14F18 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, W, Y); }
        public readonly Vector4U14F18 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, W, Z); }
        public readonly Vector4U14F18 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, X, W, W); }
        public readonly Vector4U14F18 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, X, X); }
        public readonly Vector4U14F18 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, X, Y); }
        public readonly Vector4U14F18 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, X, Z); }
        public readonly Vector4U14F18 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, X, W); }
        public readonly Vector4U14F18 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, Y, X); }
        public readonly Vector4U14F18 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, Y, Y); }
        public readonly Vector4U14F18 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, Y, Z); }
        public readonly Vector4U14F18 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, Y, W); }
        public readonly Vector4U14F18 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, Z, X); }
        public readonly Vector4U14F18 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, Z, Y); }
        public readonly Vector4U14F18 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, Z, Z); }
        public readonly Vector4U14F18 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, Z, W); }
        public readonly Vector4U14F18 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, W, X); }
        public readonly Vector4U14F18 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, W, Y); }
        public readonly Vector4U14F18 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, W, Z); }
        public readonly Vector4U14F18 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Y, W, W); }
        public readonly Vector4U14F18 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, X, X); }
        public readonly Vector4U14F18 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, X, Y); }
        public readonly Vector4U14F18 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, X, Z); }
        public readonly Vector4U14F18 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, X, W); }
        public readonly Vector4U14F18 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, Y, X); }
        public readonly Vector4U14F18 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, Y, Y); }
        public readonly Vector4U14F18 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, Y, Z); }
        public readonly Vector4U14F18 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, Y, W); }
        public readonly Vector4U14F18 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, Z, X); }
        public readonly Vector4U14F18 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, Z, Y); }
        public readonly Vector4U14F18 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, Z, Z); }
        public readonly Vector4U14F18 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, Z, W); }
        public readonly Vector4U14F18 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, W, X); }
        public readonly Vector4U14F18 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, W, Y); }
        public readonly Vector4U14F18 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, W, Z); }
        public readonly Vector4U14F18 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, Z, W, W); }
        public readonly Vector4U14F18 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, X, X); }
        public readonly Vector4U14F18 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, X, Y); }
        public readonly Vector4U14F18 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, X, Z); }
        public readonly Vector4U14F18 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, X, W); }
        public readonly Vector4U14F18 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, Y, X); }
        public readonly Vector4U14F18 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, Y, Y); }
        public readonly Vector4U14F18 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, Y, Z); }
        public readonly Vector4U14F18 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, Y, W); }
        public readonly Vector4U14F18 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, Z, X); }
        public readonly Vector4U14F18 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, Z, Y); }
        public readonly Vector4U14F18 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, Z, Z); }
        public readonly Vector4U14F18 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, Z, W); }
        public readonly Vector4U14F18 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, W, X); }
        public readonly Vector4U14F18 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, W, Y); }
        public readonly Vector4U14F18 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, W, Z); }
        public readonly Vector4U14F18 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Z, W, W, W); }
        public readonly Vector4U14F18 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, X, X); }
        public readonly Vector4U14F18 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, X, Y); }
        public readonly Vector4U14F18 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, X, Z); }
        public readonly Vector4U14F18 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, X, W); }
        public readonly Vector4U14F18 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, Y, X); }
        public readonly Vector4U14F18 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, Y, Y); }
        public readonly Vector4U14F18 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, Y, Z); }
        public readonly Vector4U14F18 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, Y, W); }
        public readonly Vector4U14F18 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, Z, X); }
        public readonly Vector4U14F18 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, Z, Y); }
        public readonly Vector4U14F18 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, Z, Z); }
        public readonly Vector4U14F18 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, Z, W); }
        public readonly Vector4U14F18 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, W, X); }
        public readonly Vector4U14F18 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, W, Y); }
        public readonly Vector4U14F18 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, W, Z); }
        public readonly Vector4U14F18 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, X, W, W); }
        public readonly Vector4U14F18 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, X, X); }
        public readonly Vector4U14F18 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, X, Y); }
        public readonly Vector4U14F18 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, X, Z); }
        public readonly Vector4U14F18 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, X, W); }
        public readonly Vector4U14F18 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, Y, X); }
        public readonly Vector4U14F18 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, Y, Y); }
        public readonly Vector4U14F18 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, Y, Z); }
        public readonly Vector4U14F18 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, Y, W); }
        public readonly Vector4U14F18 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, Z, X); }
        public readonly Vector4U14F18 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, Z, Y); }
        public readonly Vector4U14F18 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, Z, Z); }
        public readonly Vector4U14F18 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, Z, W); }
        public readonly Vector4U14F18 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, W, X); }
        public readonly Vector4U14F18 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, W, Y); }
        public readonly Vector4U14F18 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, W, Z); }
        public readonly Vector4U14F18 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Y, W, W); }
        public readonly Vector4U14F18 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, X, X); }
        public readonly Vector4U14F18 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, X, Y); }
        public readonly Vector4U14F18 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, X, Z); }
        public readonly Vector4U14F18 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, X, W); }
        public readonly Vector4U14F18 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, Y, X); }
        public readonly Vector4U14F18 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, Y, Y); }
        public readonly Vector4U14F18 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, Y, Z); }
        public readonly Vector4U14F18 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, Y, W); }
        public readonly Vector4U14F18 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, Z, X); }
        public readonly Vector4U14F18 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, Z, Y); }
        public readonly Vector4U14F18 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, Z, Z); }
        public readonly Vector4U14F18 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, Z, W); }
        public readonly Vector4U14F18 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, W, X); }
        public readonly Vector4U14F18 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, W, Y); }
        public readonly Vector4U14F18 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, W, Z); }
        public readonly Vector4U14F18 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, Z, W, W); }
        public readonly Vector4U14F18 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, X, X); }
        public readonly Vector4U14F18 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, X, Y); }
        public readonly Vector4U14F18 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, X, Z); }
        public readonly Vector4U14F18 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, X, W); }
        public readonly Vector4U14F18 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, Y, X); }
        public readonly Vector4U14F18 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, Y, Y); }
        public readonly Vector4U14F18 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, Y, Z); }
        public readonly Vector4U14F18 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, Y, W); }
        public readonly Vector4U14F18 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, Z, X); }
        public readonly Vector4U14F18 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, Z, Y); }
        public readonly Vector4U14F18 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, Z, Z); }
        public readonly Vector4U14F18 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, Z, W); }
        public readonly Vector4U14F18 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, W, X); }
        public readonly Vector4U14F18 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, W, Y); }
        public readonly Vector4U14F18 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, W, Z); }
        public readonly Vector4U14F18 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U14F18 lhs, Vector4U14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U14F18 lhs, Vector4U14F18 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U14F18({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U14F18 other)
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
            return $"Vector4U14F18({x}, {y}, {z}, {w})";
        }
    }
}
