using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U30F2 : IEquatable<Vector4U30F2>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U30F2 X;
        public U30F2 Y;
        public U30F2 Z;
        public U30F2 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, U30F2 y, U30F2 z, U30F2 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, U30F2 y, Vector2U30F2 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, Vector3U30F2 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector2U30F2 xy, Vector2U30F2 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector4U30F2 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, Vector2U30F2 yz, U30F2 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector3U30F2 xyz, U30F2 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector2U30F2 xy, U30F2 z, U30F2 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U30F2 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.Zero);
        }
        public static Vector4U30F2 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.One);
        }
        public static Vector4U30F2 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.One, U30F2.Zero, U30F2.Zero, U30F2.Zero);
        }
        public static Vector4U30F2 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.Zero, U30F2.One, U30F2.Zero, U30F2.Zero);
        }
        public static Vector4U30F2 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.Zero, U30F2.Zero, U30F2.One, U30F2.Zero);
        }
        public static Vector4U30F2 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.Zero, U30F2.Zero, U30F2.Zero, U30F2.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator +(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator -(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator *(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator *(Vector4U30F2 a, U30F2 b) => new Vector4U30F2(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator *(U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator /(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator /(Vector4U30F2 a, U30F2 b) => new Vector4U30F2(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator /(U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U30F2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, X); }
        public readonly Vector2U30F2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, Y); }
        public readonly Vector2U30F2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, Z); }
        public readonly Vector2U30F2 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, W); }
        public readonly Vector2U30F2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, X); }
        public readonly Vector2U30F2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, Y); }
        public readonly Vector2U30F2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, Z); }
        public readonly Vector2U30F2 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, W); }
        public readonly Vector2U30F2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, X); }
        public readonly Vector2U30F2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, Y); }
        public readonly Vector2U30F2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, Z); }
        public readonly Vector2U30F2 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, W); }
        public readonly Vector2U30F2 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(W, X); }
        public readonly Vector2U30F2 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(W, Y); }
        public readonly Vector2U30F2 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(W, Z); }
        public readonly Vector2U30F2 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(W, W); }
        public readonly Vector3U30F2 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, X); }
        public readonly Vector3U30F2 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, Y); }
        public readonly Vector3U30F2 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, Z); }
        public readonly Vector3U30F2 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, W); }
        public readonly Vector3U30F2 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, X); }
        public readonly Vector3U30F2 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, Y); }
        public readonly Vector3U30F2 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, Z); }
        public readonly Vector3U30F2 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, W); }
        public readonly Vector3U30F2 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, X); }
        public readonly Vector3U30F2 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, Y); }
        public readonly Vector3U30F2 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, Z); }
        public readonly Vector3U30F2 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, W); }
        public readonly Vector3U30F2 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, W, X); }
        public readonly Vector3U30F2 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, W, Y); }
        public readonly Vector3U30F2 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, W, Z); }
        public readonly Vector3U30F2 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, W, W); }
        public readonly Vector3U30F2 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, X); }
        public readonly Vector3U30F2 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, Y); }
        public readonly Vector3U30F2 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, Z); }
        public readonly Vector3U30F2 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, W); }
        public readonly Vector3U30F2 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, X); }
        public readonly Vector3U30F2 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, Y); }
        public readonly Vector3U30F2 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, Z); }
        public readonly Vector3U30F2 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, W); }
        public readonly Vector3U30F2 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, X); }
        public readonly Vector3U30F2 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, Y); }
        public readonly Vector3U30F2 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, Z); }
        public readonly Vector3U30F2 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, W); }
        public readonly Vector3U30F2 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, W, X); }
        public readonly Vector3U30F2 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, W, Y); }
        public readonly Vector3U30F2 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, W, Z); }
        public readonly Vector3U30F2 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, W, W); }
        public readonly Vector3U30F2 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, X); }
        public readonly Vector3U30F2 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, Y); }
        public readonly Vector3U30F2 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, Z); }
        public readonly Vector3U30F2 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, W); }
        public readonly Vector3U30F2 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, X); }
        public readonly Vector3U30F2 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, Y); }
        public readonly Vector3U30F2 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, Z); }
        public readonly Vector3U30F2 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, W); }
        public readonly Vector3U30F2 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, X); }
        public readonly Vector3U30F2 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, Y); }
        public readonly Vector3U30F2 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, Z); }
        public readonly Vector3U30F2 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, W); }
        public readonly Vector3U30F2 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, W, X); }
        public readonly Vector3U30F2 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, W, Y); }
        public readonly Vector3U30F2 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, W, Z); }
        public readonly Vector3U30F2 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, W, W); }
        public readonly Vector3U30F2 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, X, X); }
        public readonly Vector3U30F2 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, X, Y); }
        public readonly Vector3U30F2 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, X, Z); }
        public readonly Vector3U30F2 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, X, W); }
        public readonly Vector3U30F2 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Y, X); }
        public readonly Vector3U30F2 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Y, Y); }
        public readonly Vector3U30F2 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Y, Z); }
        public readonly Vector3U30F2 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Y, W); }
        public readonly Vector3U30F2 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Z, X); }
        public readonly Vector3U30F2 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Z, Y); }
        public readonly Vector3U30F2 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Z, Z); }
        public readonly Vector3U30F2 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Z, W); }
        public readonly Vector3U30F2 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, W, X); }
        public readonly Vector3U30F2 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, W, Y); }
        public readonly Vector3U30F2 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, W, Z); }
        public readonly Vector3U30F2 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, W, W); }
        public readonly Vector4U30F2 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, X); }
        public readonly Vector4U30F2 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, Y); }
        public readonly Vector4U30F2 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, Z); }
        public readonly Vector4U30F2 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, W); }
        public readonly Vector4U30F2 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, X); }
        public readonly Vector4U30F2 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, Y); }
        public readonly Vector4U30F2 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, Z); }
        public readonly Vector4U30F2 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, W); }
        public readonly Vector4U30F2 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, X); }
        public readonly Vector4U30F2 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, Y); }
        public readonly Vector4U30F2 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, Z); }
        public readonly Vector4U30F2 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, W); }
        public readonly Vector4U30F2 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, W, X); }
        public readonly Vector4U30F2 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, W, Y); }
        public readonly Vector4U30F2 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, W, Z); }
        public readonly Vector4U30F2 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, W, W); }
        public readonly Vector4U30F2 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, X); }
        public readonly Vector4U30F2 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, Y); }
        public readonly Vector4U30F2 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, Z); }
        public readonly Vector4U30F2 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, W); }
        public readonly Vector4U30F2 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, X); }
        public readonly Vector4U30F2 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, Y); }
        public readonly Vector4U30F2 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, Z); }
        public readonly Vector4U30F2 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, W); }
        public readonly Vector4U30F2 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, X); }
        public readonly Vector4U30F2 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, Y); }
        public readonly Vector4U30F2 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, Z); }
        public readonly Vector4U30F2 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, W); }
        public readonly Vector4U30F2 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, W, X); }
        public readonly Vector4U30F2 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, W, Y); }
        public readonly Vector4U30F2 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, W, Z); }
        public readonly Vector4U30F2 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, W, W); }
        public readonly Vector4U30F2 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, X); }
        public readonly Vector4U30F2 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, Y); }
        public readonly Vector4U30F2 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, Z); }
        public readonly Vector4U30F2 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, W); }
        public readonly Vector4U30F2 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, X); }
        public readonly Vector4U30F2 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, Y); }
        public readonly Vector4U30F2 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, Z); }
        public readonly Vector4U30F2 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, W); }
        public readonly Vector4U30F2 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, X); }
        public readonly Vector4U30F2 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, Y); }
        public readonly Vector4U30F2 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, Z); }
        public readonly Vector4U30F2 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, W); }
        public readonly Vector4U30F2 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, W, X); }
        public readonly Vector4U30F2 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, W, Y); }
        public readonly Vector4U30F2 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, W, Z); }
        public readonly Vector4U30F2 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, W, W); }
        public readonly Vector4U30F2 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, X, X); }
        public readonly Vector4U30F2 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, X, Y); }
        public readonly Vector4U30F2 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, X, Z); }
        public readonly Vector4U30F2 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, X, W); }
        public readonly Vector4U30F2 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Y, X); }
        public readonly Vector4U30F2 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Y, Y); }
        public readonly Vector4U30F2 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Y, Z); }
        public readonly Vector4U30F2 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Y, W); }
        public readonly Vector4U30F2 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Z, X); }
        public readonly Vector4U30F2 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Z, Y); }
        public readonly Vector4U30F2 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Z, Z); }
        public readonly Vector4U30F2 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Z, W); }
        public readonly Vector4U30F2 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, W, X); }
        public readonly Vector4U30F2 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, W, Y); }
        public readonly Vector4U30F2 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, W, Z); }
        public readonly Vector4U30F2 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, W, W); }
        public readonly Vector4U30F2 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, X); }
        public readonly Vector4U30F2 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, Y); }
        public readonly Vector4U30F2 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, Z); }
        public readonly Vector4U30F2 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, W); }
        public readonly Vector4U30F2 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, X); }
        public readonly Vector4U30F2 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, Y); }
        public readonly Vector4U30F2 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, Z); }
        public readonly Vector4U30F2 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, W); }
        public readonly Vector4U30F2 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, X); }
        public readonly Vector4U30F2 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, Y); }
        public readonly Vector4U30F2 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, Z); }
        public readonly Vector4U30F2 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, W); }
        public readonly Vector4U30F2 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, W, X); }
        public readonly Vector4U30F2 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, W, Y); }
        public readonly Vector4U30F2 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, W, Z); }
        public readonly Vector4U30F2 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, W, W); }
        public readonly Vector4U30F2 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, X); }
        public readonly Vector4U30F2 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, Y); }
        public readonly Vector4U30F2 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, Z); }
        public readonly Vector4U30F2 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, W); }
        public readonly Vector4U30F2 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, X); }
        public readonly Vector4U30F2 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, Y); }
        public readonly Vector4U30F2 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, Z); }
        public readonly Vector4U30F2 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, W); }
        public readonly Vector4U30F2 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, X); }
        public readonly Vector4U30F2 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, Y); }
        public readonly Vector4U30F2 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, Z); }
        public readonly Vector4U30F2 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, W); }
        public readonly Vector4U30F2 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, W, X); }
        public readonly Vector4U30F2 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, W, Y); }
        public readonly Vector4U30F2 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, W, Z); }
        public readonly Vector4U30F2 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, W, W); }
        public readonly Vector4U30F2 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, X); }
        public readonly Vector4U30F2 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, Y); }
        public readonly Vector4U30F2 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, Z); }
        public readonly Vector4U30F2 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, W); }
        public readonly Vector4U30F2 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, X); }
        public readonly Vector4U30F2 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, Y); }
        public readonly Vector4U30F2 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, Z); }
        public readonly Vector4U30F2 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, W); }
        public readonly Vector4U30F2 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, X); }
        public readonly Vector4U30F2 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, Y); }
        public readonly Vector4U30F2 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, Z); }
        public readonly Vector4U30F2 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, W); }
        public readonly Vector4U30F2 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, W, X); }
        public readonly Vector4U30F2 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, W, Y); }
        public readonly Vector4U30F2 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, W, Z); }
        public readonly Vector4U30F2 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, W, W); }
        public readonly Vector4U30F2 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, X, X); }
        public readonly Vector4U30F2 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, X, Y); }
        public readonly Vector4U30F2 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, X, Z); }
        public readonly Vector4U30F2 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, X, W); }
        public readonly Vector4U30F2 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Y, X); }
        public readonly Vector4U30F2 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Y, Y); }
        public readonly Vector4U30F2 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Y, Z); }
        public readonly Vector4U30F2 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Y, W); }
        public readonly Vector4U30F2 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Z, X); }
        public readonly Vector4U30F2 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Z, Y); }
        public readonly Vector4U30F2 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Z, Z); }
        public readonly Vector4U30F2 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Z, W); }
        public readonly Vector4U30F2 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, W, X); }
        public readonly Vector4U30F2 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, W, Y); }
        public readonly Vector4U30F2 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, W, Z); }
        public readonly Vector4U30F2 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, W, W); }
        public readonly Vector4U30F2 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, X); }
        public readonly Vector4U30F2 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, Y); }
        public readonly Vector4U30F2 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, Z); }
        public readonly Vector4U30F2 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, W); }
        public readonly Vector4U30F2 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, X); }
        public readonly Vector4U30F2 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, Y); }
        public readonly Vector4U30F2 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, Z); }
        public readonly Vector4U30F2 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, W); }
        public readonly Vector4U30F2 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, X); }
        public readonly Vector4U30F2 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, Y); }
        public readonly Vector4U30F2 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, Z); }
        public readonly Vector4U30F2 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, W); }
        public readonly Vector4U30F2 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, W, X); }
        public readonly Vector4U30F2 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, W, Y); }
        public readonly Vector4U30F2 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, W, Z); }
        public readonly Vector4U30F2 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, W, W); }
        public readonly Vector4U30F2 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, X); }
        public readonly Vector4U30F2 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, Y); }
        public readonly Vector4U30F2 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, Z); }
        public readonly Vector4U30F2 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, W); }
        public readonly Vector4U30F2 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, X); }
        public readonly Vector4U30F2 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, Y); }
        public readonly Vector4U30F2 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, Z); }
        public readonly Vector4U30F2 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, W); }
        public readonly Vector4U30F2 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, X); }
        public readonly Vector4U30F2 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, Y); }
        public readonly Vector4U30F2 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, Z); }
        public readonly Vector4U30F2 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, W); }
        public readonly Vector4U30F2 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, W, X); }
        public readonly Vector4U30F2 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, W, Y); }
        public readonly Vector4U30F2 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, W, Z); }
        public readonly Vector4U30F2 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, W, W); }
        public readonly Vector4U30F2 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, X); }
        public readonly Vector4U30F2 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, Y); }
        public readonly Vector4U30F2 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, Z); }
        public readonly Vector4U30F2 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, W); }
        public readonly Vector4U30F2 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, X); }
        public readonly Vector4U30F2 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, Y); }
        public readonly Vector4U30F2 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, Z); }
        public readonly Vector4U30F2 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, W); }
        public readonly Vector4U30F2 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, X); }
        public readonly Vector4U30F2 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, Y); }
        public readonly Vector4U30F2 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, Z); }
        public readonly Vector4U30F2 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, W); }
        public readonly Vector4U30F2 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, W, X); }
        public readonly Vector4U30F2 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, W, Y); }
        public readonly Vector4U30F2 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, W, Z); }
        public readonly Vector4U30F2 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, W, W); }
        public readonly Vector4U30F2 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, X, X); }
        public readonly Vector4U30F2 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, X, Y); }
        public readonly Vector4U30F2 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, X, Z); }
        public readonly Vector4U30F2 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, X, W); }
        public readonly Vector4U30F2 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Y, X); }
        public readonly Vector4U30F2 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Y, Y); }
        public readonly Vector4U30F2 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Y, Z); }
        public readonly Vector4U30F2 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Y, W); }
        public readonly Vector4U30F2 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Z, X); }
        public readonly Vector4U30F2 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Z, Y); }
        public readonly Vector4U30F2 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Z, Z); }
        public readonly Vector4U30F2 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Z, W); }
        public readonly Vector4U30F2 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, W, X); }
        public readonly Vector4U30F2 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, W, Y); }
        public readonly Vector4U30F2 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, W, Z); }
        public readonly Vector4U30F2 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, W, W); }
        public readonly Vector4U30F2 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, X, X); }
        public readonly Vector4U30F2 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, X, Y); }
        public readonly Vector4U30F2 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, X, Z); }
        public readonly Vector4U30F2 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, X, W); }
        public readonly Vector4U30F2 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Y, X); }
        public readonly Vector4U30F2 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Y, Y); }
        public readonly Vector4U30F2 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Y, Z); }
        public readonly Vector4U30F2 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Y, W); }
        public readonly Vector4U30F2 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Z, X); }
        public readonly Vector4U30F2 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Z, Y); }
        public readonly Vector4U30F2 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Z, Z); }
        public readonly Vector4U30F2 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Z, W); }
        public readonly Vector4U30F2 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, W, X); }
        public readonly Vector4U30F2 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, W, Y); }
        public readonly Vector4U30F2 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, W, Z); }
        public readonly Vector4U30F2 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, W, W); }
        public readonly Vector4U30F2 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, X, X); }
        public readonly Vector4U30F2 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, X, Y); }
        public readonly Vector4U30F2 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, X, Z); }
        public readonly Vector4U30F2 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, X, W); }
        public readonly Vector4U30F2 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Y, X); }
        public readonly Vector4U30F2 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Y, Y); }
        public readonly Vector4U30F2 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Y, Z); }
        public readonly Vector4U30F2 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Y, W); }
        public readonly Vector4U30F2 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Z, X); }
        public readonly Vector4U30F2 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Z, Y); }
        public readonly Vector4U30F2 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Z, Z); }
        public readonly Vector4U30F2 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Z, W); }
        public readonly Vector4U30F2 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, W, X); }
        public readonly Vector4U30F2 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, W, Y); }
        public readonly Vector4U30F2 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, W, Z); }
        public readonly Vector4U30F2 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, W, W); }
        public readonly Vector4U30F2 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, X, X); }
        public readonly Vector4U30F2 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, X, Y); }
        public readonly Vector4U30F2 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, X, Z); }
        public readonly Vector4U30F2 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, X, W); }
        public readonly Vector4U30F2 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Y, X); }
        public readonly Vector4U30F2 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Y, Y); }
        public readonly Vector4U30F2 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Y, Z); }
        public readonly Vector4U30F2 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Y, W); }
        public readonly Vector4U30F2 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Z, X); }
        public readonly Vector4U30F2 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Z, Y); }
        public readonly Vector4U30F2 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Z, Z); }
        public readonly Vector4U30F2 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Z, W); }
        public readonly Vector4U30F2 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, W, X); }
        public readonly Vector4U30F2 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, W, Y); }
        public readonly Vector4U30F2 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, W, Z); }
        public readonly Vector4U30F2 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, W, W); }
        public readonly Vector4U30F2 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, X, X); }
        public readonly Vector4U30F2 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, X, Y); }
        public readonly Vector4U30F2 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, X, Z); }
        public readonly Vector4U30F2 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, X, W); }
        public readonly Vector4U30F2 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Y, X); }
        public readonly Vector4U30F2 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Y, Y); }
        public readonly Vector4U30F2 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Y, Z); }
        public readonly Vector4U30F2 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Y, W); }
        public readonly Vector4U30F2 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Z, X); }
        public readonly Vector4U30F2 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Z, Y); }
        public readonly Vector4U30F2 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Z, Z); }
        public readonly Vector4U30F2 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Z, W); }
        public readonly Vector4U30F2 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, W, X); }
        public readonly Vector4U30F2 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, W, Y); }
        public readonly Vector4U30F2 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, W, Z); }
        public readonly Vector4U30F2 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U30F2 lhs, Vector4U30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U30F2 lhs, Vector4U30F2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U30F2({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U30F2 other)
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
            return $"Vector4U30F2({x}, {y}, {z}, {w})";
        }
    }
}
