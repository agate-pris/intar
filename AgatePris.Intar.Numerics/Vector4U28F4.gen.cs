using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U28F4 : IEquatable<Vector4U28F4>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U28F4 X;
        public U28F4 Y;
        public U28F4 Z;
        public U28F4 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, U28F4 y, U28F4 z, U28F4 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, U28F4 y, Vector2U28F4 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, Vector3U28F4 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector2U28F4 xy, Vector2U28F4 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector4U28F4 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, Vector2U28F4 yz, U28F4 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector3U28F4 xyz, U28F4 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector2U28F4 xy, U28F4 z, U28F4 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U28F4 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.Zero);
        }
        public static Vector4U28F4 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.One);
        }
        public static Vector4U28F4 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.One, U28F4.Zero, U28F4.Zero, U28F4.Zero);
        }
        public static Vector4U28F4 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.Zero, U28F4.One, U28F4.Zero, U28F4.Zero);
        }
        public static Vector4U28F4 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.Zero, U28F4.Zero, U28F4.One, U28F4.Zero);
        }
        public static Vector4U28F4 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.Zero, U28F4.Zero, U28F4.Zero, U28F4.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator +(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator -(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator *(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator *(Vector4U28F4 a, U28F4 b) => new Vector4U28F4(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator *(U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator /(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator /(Vector4U28F4 a, U28F4 b) => new Vector4U28F4(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator /(U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U28F4 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, X); }
        public readonly Vector2U28F4 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, Y); }
        public readonly Vector2U28F4 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, Z); }
        public readonly Vector2U28F4 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, W); }
        public readonly Vector2U28F4 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, X); }
        public readonly Vector2U28F4 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, Y); }
        public readonly Vector2U28F4 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, Z); }
        public readonly Vector2U28F4 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, W); }
        public readonly Vector2U28F4 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Z, X); }
        public readonly Vector2U28F4 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Z, Y); }
        public readonly Vector2U28F4 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Z, Z); }
        public readonly Vector2U28F4 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Z, W); }
        public readonly Vector2U28F4 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(W, X); }
        public readonly Vector2U28F4 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(W, Y); }
        public readonly Vector2U28F4 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(W, Z); }
        public readonly Vector2U28F4 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(W, W); }
        public readonly Vector3U28F4 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, X); }
        public readonly Vector3U28F4 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, Y); }
        public readonly Vector3U28F4 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, Z); }
        public readonly Vector3U28F4 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, W); }
        public readonly Vector3U28F4 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, X); }
        public readonly Vector3U28F4 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, Y); }
        public readonly Vector3U28F4 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, Z); }
        public readonly Vector3U28F4 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, W); }
        public readonly Vector3U28F4 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Z, X); }
        public readonly Vector3U28F4 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Z, Y); }
        public readonly Vector3U28F4 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Z, Z); }
        public readonly Vector3U28F4 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Z, W); }
        public readonly Vector3U28F4 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, W, X); }
        public readonly Vector3U28F4 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, W, Y); }
        public readonly Vector3U28F4 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, W, Z); }
        public readonly Vector3U28F4 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, W, W); }
        public readonly Vector3U28F4 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, X); }
        public readonly Vector3U28F4 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, Y); }
        public readonly Vector3U28F4 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, Z); }
        public readonly Vector3U28F4 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, W); }
        public readonly Vector3U28F4 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, X); }
        public readonly Vector3U28F4 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, Y); }
        public readonly Vector3U28F4 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, Z); }
        public readonly Vector3U28F4 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, W); }
        public readonly Vector3U28F4 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Z, X); }
        public readonly Vector3U28F4 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Z, Y); }
        public readonly Vector3U28F4 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Z, Z); }
        public readonly Vector3U28F4 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Z, W); }
        public readonly Vector3U28F4 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, W, X); }
        public readonly Vector3U28F4 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, W, Y); }
        public readonly Vector3U28F4 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, W, Z); }
        public readonly Vector3U28F4 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, W, W); }
        public readonly Vector3U28F4 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, X, X); }
        public readonly Vector3U28F4 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, X, Y); }
        public readonly Vector3U28F4 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, X, Z); }
        public readonly Vector3U28F4 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, X, W); }
        public readonly Vector3U28F4 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Y, X); }
        public readonly Vector3U28F4 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Y, Y); }
        public readonly Vector3U28F4 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Y, Z); }
        public readonly Vector3U28F4 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Y, W); }
        public readonly Vector3U28F4 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Z, X); }
        public readonly Vector3U28F4 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Z, Y); }
        public readonly Vector3U28F4 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Z, Z); }
        public readonly Vector3U28F4 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, Z, W); }
        public readonly Vector3U28F4 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, W, X); }
        public readonly Vector3U28F4 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, W, Y); }
        public readonly Vector3U28F4 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, W, Z); }
        public readonly Vector3U28F4 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Z, W, W); }
        public readonly Vector3U28F4 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, X, X); }
        public readonly Vector3U28F4 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, X, Y); }
        public readonly Vector3U28F4 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, X, Z); }
        public readonly Vector3U28F4 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, X, W); }
        public readonly Vector3U28F4 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, Y, X); }
        public readonly Vector3U28F4 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, Y, Y); }
        public readonly Vector3U28F4 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, Y, Z); }
        public readonly Vector3U28F4 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, Y, W); }
        public readonly Vector3U28F4 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, Z, X); }
        public readonly Vector3U28F4 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, Z, Y); }
        public readonly Vector3U28F4 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, Z, Z); }
        public readonly Vector3U28F4 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, Z, W); }
        public readonly Vector3U28F4 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, W, X); }
        public readonly Vector3U28F4 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, W, Y); }
        public readonly Vector3U28F4 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, W, Z); }
        public readonly Vector3U28F4 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(W, W, W); }
        public readonly Vector4U28F4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, X); }
        public readonly Vector4U28F4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, Y); }
        public readonly Vector4U28F4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, Z); }
        public readonly Vector4U28F4 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, W); }
        public readonly Vector4U28F4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, X); }
        public readonly Vector4U28F4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, Y); }
        public readonly Vector4U28F4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, Z); }
        public readonly Vector4U28F4 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, W); }
        public readonly Vector4U28F4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Z, X); }
        public readonly Vector4U28F4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Z, Y); }
        public readonly Vector4U28F4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Z, Z); }
        public readonly Vector4U28F4 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Z, W); }
        public readonly Vector4U28F4 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, W, X); }
        public readonly Vector4U28F4 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, W, Y); }
        public readonly Vector4U28F4 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, W, Z); }
        public readonly Vector4U28F4 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, W, W); }
        public readonly Vector4U28F4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, X); }
        public readonly Vector4U28F4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, Y); }
        public readonly Vector4U28F4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, Z); }
        public readonly Vector4U28F4 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, W); }
        public readonly Vector4U28F4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, X); }
        public readonly Vector4U28F4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, Y); }
        public readonly Vector4U28F4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, Z); }
        public readonly Vector4U28F4 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, W); }
        public readonly Vector4U28F4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Z, X); }
        public readonly Vector4U28F4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Z, Y); }
        public readonly Vector4U28F4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Z, Z); }
        public readonly Vector4U28F4 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Z, W); }
        public readonly Vector4U28F4 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, W, X); }
        public readonly Vector4U28F4 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, W, Y); }
        public readonly Vector4U28F4 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, W, Z); }
        public readonly Vector4U28F4 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, W, W); }
        public readonly Vector4U28F4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, X, X); }
        public readonly Vector4U28F4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, X, Y); }
        public readonly Vector4U28F4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, X, Z); }
        public readonly Vector4U28F4 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, X, W); }
        public readonly Vector4U28F4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Y, X); }
        public readonly Vector4U28F4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Y, Y); }
        public readonly Vector4U28F4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Y, Z); }
        public readonly Vector4U28F4 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Y, W); }
        public readonly Vector4U28F4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Z, X); }
        public readonly Vector4U28F4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Z, Y); }
        public readonly Vector4U28F4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Z, Z); }
        public readonly Vector4U28F4 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, Z, W); }
        public readonly Vector4U28F4 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, W, X); }
        public readonly Vector4U28F4 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, W, Y); }
        public readonly Vector4U28F4 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, W, Z); }
        public readonly Vector4U28F4 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Z, W, W); }
        public readonly Vector4U28F4 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, X, X); }
        public readonly Vector4U28F4 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, X, Y); }
        public readonly Vector4U28F4 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, X, Z); }
        public readonly Vector4U28F4 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, X, W); }
        public readonly Vector4U28F4 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, Y, X); }
        public readonly Vector4U28F4 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, Y, Y); }
        public readonly Vector4U28F4 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, Y, Z); }
        public readonly Vector4U28F4 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, Y, W); }
        public readonly Vector4U28F4 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, Z, X); }
        public readonly Vector4U28F4 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, Z, Y); }
        public readonly Vector4U28F4 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, Z, Z); }
        public readonly Vector4U28F4 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, Z, W); }
        public readonly Vector4U28F4 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, W, X); }
        public readonly Vector4U28F4 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, W, Y); }
        public readonly Vector4U28F4 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, W, Z); }
        public readonly Vector4U28F4 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, W, W, W); }
        public readonly Vector4U28F4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, X); }
        public readonly Vector4U28F4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, Y); }
        public readonly Vector4U28F4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, Z); }
        public readonly Vector4U28F4 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, W); }
        public readonly Vector4U28F4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, X); }
        public readonly Vector4U28F4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, Y); }
        public readonly Vector4U28F4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, Z); }
        public readonly Vector4U28F4 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, W); }
        public readonly Vector4U28F4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Z, X); }
        public readonly Vector4U28F4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Z, Y); }
        public readonly Vector4U28F4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Z, Z); }
        public readonly Vector4U28F4 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Z, W); }
        public readonly Vector4U28F4 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, W, X); }
        public readonly Vector4U28F4 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, W, Y); }
        public readonly Vector4U28F4 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, W, Z); }
        public readonly Vector4U28F4 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, W, W); }
        public readonly Vector4U28F4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, X); }
        public readonly Vector4U28F4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, Y); }
        public readonly Vector4U28F4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, Z); }
        public readonly Vector4U28F4 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, W); }
        public readonly Vector4U28F4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, X); }
        public readonly Vector4U28F4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, Y); }
        public readonly Vector4U28F4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, Z); }
        public readonly Vector4U28F4 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, W); }
        public readonly Vector4U28F4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Z, X); }
        public readonly Vector4U28F4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Z, Y); }
        public readonly Vector4U28F4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Z, Z); }
        public readonly Vector4U28F4 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Z, W); }
        public readonly Vector4U28F4 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, W, X); }
        public readonly Vector4U28F4 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, W, Y); }
        public readonly Vector4U28F4 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, W, Z); }
        public readonly Vector4U28F4 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, W, W); }
        public readonly Vector4U28F4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, X, X); }
        public readonly Vector4U28F4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, X, Y); }
        public readonly Vector4U28F4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, X, Z); }
        public readonly Vector4U28F4 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, X, W); }
        public readonly Vector4U28F4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Y, X); }
        public readonly Vector4U28F4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Y, Y); }
        public readonly Vector4U28F4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Y, Z); }
        public readonly Vector4U28F4 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Y, W); }
        public readonly Vector4U28F4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Z, X); }
        public readonly Vector4U28F4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Z, Y); }
        public readonly Vector4U28F4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Z, Z); }
        public readonly Vector4U28F4 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, Z, W); }
        public readonly Vector4U28F4 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, W, X); }
        public readonly Vector4U28F4 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, W, Y); }
        public readonly Vector4U28F4 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, W, Z); }
        public readonly Vector4U28F4 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Z, W, W); }
        public readonly Vector4U28F4 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, X, X); }
        public readonly Vector4U28F4 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, X, Y); }
        public readonly Vector4U28F4 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, X, Z); }
        public readonly Vector4U28F4 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, X, W); }
        public readonly Vector4U28F4 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, Y, X); }
        public readonly Vector4U28F4 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, Y, Y); }
        public readonly Vector4U28F4 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, Y, Z); }
        public readonly Vector4U28F4 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, Y, W); }
        public readonly Vector4U28F4 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, Z, X); }
        public readonly Vector4U28F4 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, Z, Y); }
        public readonly Vector4U28F4 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, Z, Z); }
        public readonly Vector4U28F4 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, Z, W); }
        public readonly Vector4U28F4 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, W, X); }
        public readonly Vector4U28F4 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, W, Y); }
        public readonly Vector4U28F4 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, W, Z); }
        public readonly Vector4U28F4 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, W, W, W); }
        public readonly Vector4U28F4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, X, X); }
        public readonly Vector4U28F4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, X, Y); }
        public readonly Vector4U28F4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, X, Z); }
        public readonly Vector4U28F4 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, X, W); }
        public readonly Vector4U28F4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Y, X); }
        public readonly Vector4U28F4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Y, Y); }
        public readonly Vector4U28F4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Y, Z); }
        public readonly Vector4U28F4 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Y, W); }
        public readonly Vector4U28F4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Z, X); }
        public readonly Vector4U28F4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Z, Y); }
        public readonly Vector4U28F4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Z, Z); }
        public readonly Vector4U28F4 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, Z, W); }
        public readonly Vector4U28F4 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, W, X); }
        public readonly Vector4U28F4 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, W, Y); }
        public readonly Vector4U28F4 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, W, Z); }
        public readonly Vector4U28F4 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, X, W, W); }
        public readonly Vector4U28F4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, X, X); }
        public readonly Vector4U28F4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, X, Y); }
        public readonly Vector4U28F4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, X, Z); }
        public readonly Vector4U28F4 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, X, W); }
        public readonly Vector4U28F4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Y, X); }
        public readonly Vector4U28F4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Y, Y); }
        public readonly Vector4U28F4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Y, Z); }
        public readonly Vector4U28F4 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Y, W); }
        public readonly Vector4U28F4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Z, X); }
        public readonly Vector4U28F4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Z, Y); }
        public readonly Vector4U28F4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Z, Z); }
        public readonly Vector4U28F4 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, Z, W); }
        public readonly Vector4U28F4 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, W, X); }
        public readonly Vector4U28F4 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, W, Y); }
        public readonly Vector4U28F4 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, W, Z); }
        public readonly Vector4U28F4 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Y, W, W); }
        public readonly Vector4U28F4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, X, X); }
        public readonly Vector4U28F4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, X, Y); }
        public readonly Vector4U28F4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, X, Z); }
        public readonly Vector4U28F4 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, X, W); }
        public readonly Vector4U28F4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Y, X); }
        public readonly Vector4U28F4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Y, Y); }
        public readonly Vector4U28F4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Y, Z); }
        public readonly Vector4U28F4 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Y, W); }
        public readonly Vector4U28F4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Z, X); }
        public readonly Vector4U28F4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Z, Y); }
        public readonly Vector4U28F4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Z, Z); }
        public readonly Vector4U28F4 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, Z, W); }
        public readonly Vector4U28F4 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, W, X); }
        public readonly Vector4U28F4 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, W, Y); }
        public readonly Vector4U28F4 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, W, Z); }
        public readonly Vector4U28F4 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, Z, W, W); }
        public readonly Vector4U28F4 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, X, X); }
        public readonly Vector4U28F4 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, X, Y); }
        public readonly Vector4U28F4 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, X, Z); }
        public readonly Vector4U28F4 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, X, W); }
        public readonly Vector4U28F4 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, Y, X); }
        public readonly Vector4U28F4 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, Y, Y); }
        public readonly Vector4U28F4 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, Y, Z); }
        public readonly Vector4U28F4 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, Y, W); }
        public readonly Vector4U28F4 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, Z, X); }
        public readonly Vector4U28F4 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, Z, Y); }
        public readonly Vector4U28F4 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, Z, Z); }
        public readonly Vector4U28F4 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, Z, W); }
        public readonly Vector4U28F4 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, W, X); }
        public readonly Vector4U28F4 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, W, Y); }
        public readonly Vector4U28F4 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, W, Z); }
        public readonly Vector4U28F4 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Z, W, W, W); }
        public readonly Vector4U28F4 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, X, X); }
        public readonly Vector4U28F4 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, X, Y); }
        public readonly Vector4U28F4 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, X, Z); }
        public readonly Vector4U28F4 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, X, W); }
        public readonly Vector4U28F4 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, Y, X); }
        public readonly Vector4U28F4 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, Y, Y); }
        public readonly Vector4U28F4 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, Y, Z); }
        public readonly Vector4U28F4 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, Y, W); }
        public readonly Vector4U28F4 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, Z, X); }
        public readonly Vector4U28F4 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, Z, Y); }
        public readonly Vector4U28F4 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, Z, Z); }
        public readonly Vector4U28F4 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, Z, W); }
        public readonly Vector4U28F4 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, W, X); }
        public readonly Vector4U28F4 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, W, Y); }
        public readonly Vector4U28F4 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, W, Z); }
        public readonly Vector4U28F4 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, X, W, W); }
        public readonly Vector4U28F4 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, X, X); }
        public readonly Vector4U28F4 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, X, Y); }
        public readonly Vector4U28F4 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, X, Z); }
        public readonly Vector4U28F4 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, X, W); }
        public readonly Vector4U28F4 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, Y, X); }
        public readonly Vector4U28F4 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, Y, Y); }
        public readonly Vector4U28F4 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, Y, Z); }
        public readonly Vector4U28F4 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, Y, W); }
        public readonly Vector4U28F4 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, Z, X); }
        public readonly Vector4U28F4 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, Z, Y); }
        public readonly Vector4U28F4 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, Z, Z); }
        public readonly Vector4U28F4 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, Z, W); }
        public readonly Vector4U28F4 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, W, X); }
        public readonly Vector4U28F4 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, W, Y); }
        public readonly Vector4U28F4 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, W, Z); }
        public readonly Vector4U28F4 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Y, W, W); }
        public readonly Vector4U28F4 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, X, X); }
        public readonly Vector4U28F4 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, X, Y); }
        public readonly Vector4U28F4 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, X, Z); }
        public readonly Vector4U28F4 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, X, W); }
        public readonly Vector4U28F4 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, Y, X); }
        public readonly Vector4U28F4 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, Y, Y); }
        public readonly Vector4U28F4 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, Y, Z); }
        public readonly Vector4U28F4 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, Y, W); }
        public readonly Vector4U28F4 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, Z, X); }
        public readonly Vector4U28F4 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, Z, Y); }
        public readonly Vector4U28F4 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, Z, Z); }
        public readonly Vector4U28F4 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, Z, W); }
        public readonly Vector4U28F4 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, W, X); }
        public readonly Vector4U28F4 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, W, Y); }
        public readonly Vector4U28F4 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, W, Z); }
        public readonly Vector4U28F4 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, Z, W, W); }
        public readonly Vector4U28F4 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, X, X); }
        public readonly Vector4U28F4 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, X, Y); }
        public readonly Vector4U28F4 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, X, Z); }
        public readonly Vector4U28F4 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, X, W); }
        public readonly Vector4U28F4 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, Y, X); }
        public readonly Vector4U28F4 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, Y, Y); }
        public readonly Vector4U28F4 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, Y, Z); }
        public readonly Vector4U28F4 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, Y, W); }
        public readonly Vector4U28F4 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, Z, X); }
        public readonly Vector4U28F4 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, Z, Y); }
        public readonly Vector4U28F4 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, Z, Z); }
        public readonly Vector4U28F4 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, Z, W); }
        public readonly Vector4U28F4 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, W, X); }
        public readonly Vector4U28F4 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, W, Y); }
        public readonly Vector4U28F4 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, W, Z); }
        public readonly Vector4U28F4 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U28F4 lhs, Vector4U28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U28F4 lhs, Vector4U28F4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U28F4({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U28F4 other)
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
            return $"Vector4U28F4({x}, {y}, {z}, {w})";
        }
    }
}
