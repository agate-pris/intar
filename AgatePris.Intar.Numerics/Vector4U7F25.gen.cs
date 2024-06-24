using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U7F25 : IEquatable<Vector4U7F25>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U7F25 X;
        public U7F25 Y;
        public U7F25 Z;
        public U7F25 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(U7F25 x, U7F25 y, U7F25 z, U7F25 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(U7F25 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(U7F25 x, U7F25 y, Vector2U7F25 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(U7F25 x, Vector3U7F25 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(Vector2U7F25 xy, Vector2U7F25 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(Vector4U7F25 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(U7F25 x, Vector2U7F25 yz, U7F25 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(Vector3U7F25 xyz, U7F25 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(Vector2U7F25 xy, U7F25 z, U7F25 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U7F25 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.Zero);
        }
        public static Vector4U7F25 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.One);
        }
        public static Vector4U7F25 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.One, U7F25.Zero, U7F25.Zero, U7F25.Zero);
        }
        public static Vector4U7F25 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.Zero, U7F25.One, U7F25.Zero, U7F25.Zero);
        }
        public static Vector4U7F25 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.Zero, U7F25.Zero, U7F25.One, U7F25.Zero);
        }
        public static Vector4U7F25 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.Zero, U7F25.Zero, U7F25.Zero, U7F25.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator +(Vector4U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator -(Vector4U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator *(Vector4U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator *(Vector4U7F25 a, U7F25 b) => new Vector4U7F25(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator *(U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator /(Vector4U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator /(Vector4U7F25 a, U7F25 b) => new Vector4U7F25(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator /(U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U7F25 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(X, X); }
        public readonly Vector2U7F25 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(X, Y); }
        public readonly Vector2U7F25 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(X, Z); }
        public readonly Vector2U7F25 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(X, W); }
        public readonly Vector2U7F25 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Y, X); }
        public readonly Vector2U7F25 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Y, Y); }
        public readonly Vector2U7F25 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Y, Z); }
        public readonly Vector2U7F25 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Y, W); }
        public readonly Vector2U7F25 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Z, X); }
        public readonly Vector2U7F25 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Z, Y); }
        public readonly Vector2U7F25 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Z, Z); }
        public readonly Vector2U7F25 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Z, W); }
        public readonly Vector2U7F25 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(W, X); }
        public readonly Vector2U7F25 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(W, Y); }
        public readonly Vector2U7F25 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(W, Z); }
        public readonly Vector2U7F25 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(W, W); }
        public readonly Vector3U7F25 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, X, X); }
        public readonly Vector3U7F25 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, X, Y); }
        public readonly Vector3U7F25 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, X, Z); }
        public readonly Vector3U7F25 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, X, W); }
        public readonly Vector3U7F25 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Y, X); }
        public readonly Vector3U7F25 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Y, Y); }
        public readonly Vector3U7F25 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Y, Z); }
        public readonly Vector3U7F25 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Y, W); }
        public readonly Vector3U7F25 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Z, X); }
        public readonly Vector3U7F25 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Z, Y); }
        public readonly Vector3U7F25 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Z, Z); }
        public readonly Vector3U7F25 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Z, W); }
        public readonly Vector3U7F25 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, W, X); }
        public readonly Vector3U7F25 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, W, Y); }
        public readonly Vector3U7F25 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, W, Z); }
        public readonly Vector3U7F25 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, W, W); }
        public readonly Vector3U7F25 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, X, X); }
        public readonly Vector3U7F25 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, X, Y); }
        public readonly Vector3U7F25 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, X, Z); }
        public readonly Vector3U7F25 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, X, W); }
        public readonly Vector3U7F25 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Y, X); }
        public readonly Vector3U7F25 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Y, Y); }
        public readonly Vector3U7F25 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Y, Z); }
        public readonly Vector3U7F25 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Y, W); }
        public readonly Vector3U7F25 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Z, X); }
        public readonly Vector3U7F25 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Z, Y); }
        public readonly Vector3U7F25 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Z, Z); }
        public readonly Vector3U7F25 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Z, W); }
        public readonly Vector3U7F25 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, W, X); }
        public readonly Vector3U7F25 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, W, Y); }
        public readonly Vector3U7F25 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, W, Z); }
        public readonly Vector3U7F25 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, W, W); }
        public readonly Vector3U7F25 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, X, X); }
        public readonly Vector3U7F25 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, X, Y); }
        public readonly Vector3U7F25 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, X, Z); }
        public readonly Vector3U7F25 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, X, W); }
        public readonly Vector3U7F25 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Y, X); }
        public readonly Vector3U7F25 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Y, Y); }
        public readonly Vector3U7F25 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Y, Z); }
        public readonly Vector3U7F25 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Y, W); }
        public readonly Vector3U7F25 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Z, X); }
        public readonly Vector3U7F25 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Z, Y); }
        public readonly Vector3U7F25 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Z, Z); }
        public readonly Vector3U7F25 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, Z, W); }
        public readonly Vector3U7F25 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, W, X); }
        public readonly Vector3U7F25 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, W, Y); }
        public readonly Vector3U7F25 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, W, Z); }
        public readonly Vector3U7F25 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Z, W, W); }
        public readonly Vector3U7F25 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, X, X); }
        public readonly Vector3U7F25 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, X, Y); }
        public readonly Vector3U7F25 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, X, Z); }
        public readonly Vector3U7F25 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, X, W); }
        public readonly Vector3U7F25 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, Y, X); }
        public readonly Vector3U7F25 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, Y, Y); }
        public readonly Vector3U7F25 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, Y, Z); }
        public readonly Vector3U7F25 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, Y, W); }
        public readonly Vector3U7F25 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, Z, X); }
        public readonly Vector3U7F25 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, Z, Y); }
        public readonly Vector3U7F25 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, Z, Z); }
        public readonly Vector3U7F25 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, Z, W); }
        public readonly Vector3U7F25 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, W, X); }
        public readonly Vector3U7F25 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, W, Y); }
        public readonly Vector3U7F25 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, W, Z); }
        public readonly Vector3U7F25 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(W, W, W); }
        public readonly Vector4U7F25 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, X, X); }
        public readonly Vector4U7F25 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, X, Y); }
        public readonly Vector4U7F25 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, X, Z); }
        public readonly Vector4U7F25 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, X, W); }
        public readonly Vector4U7F25 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Y, X); }
        public readonly Vector4U7F25 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Y, Y); }
        public readonly Vector4U7F25 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Y, Z); }
        public readonly Vector4U7F25 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Y, W); }
        public readonly Vector4U7F25 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Z, X); }
        public readonly Vector4U7F25 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Z, Y); }
        public readonly Vector4U7F25 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Z, Z); }
        public readonly Vector4U7F25 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Z, W); }
        public readonly Vector4U7F25 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, W, X); }
        public readonly Vector4U7F25 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, W, Y); }
        public readonly Vector4U7F25 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, W, Z); }
        public readonly Vector4U7F25 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, W, W); }
        public readonly Vector4U7F25 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, X, X); }
        public readonly Vector4U7F25 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, X, Y); }
        public readonly Vector4U7F25 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, X, Z); }
        public readonly Vector4U7F25 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, X, W); }
        public readonly Vector4U7F25 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Y, X); }
        public readonly Vector4U7F25 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Y, Y); }
        public readonly Vector4U7F25 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Y, Z); }
        public readonly Vector4U7F25 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Y, W); }
        public readonly Vector4U7F25 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Z, X); }
        public readonly Vector4U7F25 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Z, Y); }
        public readonly Vector4U7F25 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Z, Z); }
        public readonly Vector4U7F25 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Z, W); }
        public readonly Vector4U7F25 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, W, X); }
        public readonly Vector4U7F25 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, W, Y); }
        public readonly Vector4U7F25 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, W, Z); }
        public readonly Vector4U7F25 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, W, W); }
        public readonly Vector4U7F25 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, X, X); }
        public readonly Vector4U7F25 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, X, Y); }
        public readonly Vector4U7F25 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, X, Z); }
        public readonly Vector4U7F25 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, X, W); }
        public readonly Vector4U7F25 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Y, X); }
        public readonly Vector4U7F25 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Y, Y); }
        public readonly Vector4U7F25 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Y, Z); }
        public readonly Vector4U7F25 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Y, W); }
        public readonly Vector4U7F25 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Z, X); }
        public readonly Vector4U7F25 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Z, Y); }
        public readonly Vector4U7F25 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Z, Z); }
        public readonly Vector4U7F25 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, Z, W); }
        public readonly Vector4U7F25 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, W, X); }
        public readonly Vector4U7F25 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, W, Y); }
        public readonly Vector4U7F25 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, W, Z); }
        public readonly Vector4U7F25 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Z, W, W); }
        public readonly Vector4U7F25 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, X, X); }
        public readonly Vector4U7F25 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, X, Y); }
        public readonly Vector4U7F25 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, X, Z); }
        public readonly Vector4U7F25 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, X, W); }
        public readonly Vector4U7F25 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, Y, X); }
        public readonly Vector4U7F25 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, Y, Y); }
        public readonly Vector4U7F25 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, Y, Z); }
        public readonly Vector4U7F25 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, Y, W); }
        public readonly Vector4U7F25 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, Z, X); }
        public readonly Vector4U7F25 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, Z, Y); }
        public readonly Vector4U7F25 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, Z, Z); }
        public readonly Vector4U7F25 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, Z, W); }
        public readonly Vector4U7F25 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, W, X); }
        public readonly Vector4U7F25 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, W, Y); }
        public readonly Vector4U7F25 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, W, Z); }
        public readonly Vector4U7F25 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, W, W, W); }
        public readonly Vector4U7F25 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, X, X); }
        public readonly Vector4U7F25 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, X, Y); }
        public readonly Vector4U7F25 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, X, Z); }
        public readonly Vector4U7F25 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, X, W); }
        public readonly Vector4U7F25 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Y, X); }
        public readonly Vector4U7F25 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Y, Y); }
        public readonly Vector4U7F25 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Y, Z); }
        public readonly Vector4U7F25 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Y, W); }
        public readonly Vector4U7F25 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Z, X); }
        public readonly Vector4U7F25 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Z, Y); }
        public readonly Vector4U7F25 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Z, Z); }
        public readonly Vector4U7F25 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Z, W); }
        public readonly Vector4U7F25 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, W, X); }
        public readonly Vector4U7F25 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, W, Y); }
        public readonly Vector4U7F25 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, W, Z); }
        public readonly Vector4U7F25 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, W, W); }
        public readonly Vector4U7F25 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, X, X); }
        public readonly Vector4U7F25 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, X, Y); }
        public readonly Vector4U7F25 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, X, Z); }
        public readonly Vector4U7F25 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, X, W); }
        public readonly Vector4U7F25 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Y, X); }
        public readonly Vector4U7F25 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Y, Y); }
        public readonly Vector4U7F25 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Y, Z); }
        public readonly Vector4U7F25 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Y, W); }
        public readonly Vector4U7F25 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Z, X); }
        public readonly Vector4U7F25 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Z, Y); }
        public readonly Vector4U7F25 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Z, Z); }
        public readonly Vector4U7F25 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Z, W); }
        public readonly Vector4U7F25 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, W, X); }
        public readonly Vector4U7F25 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, W, Y); }
        public readonly Vector4U7F25 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, W, Z); }
        public readonly Vector4U7F25 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, W, W); }
        public readonly Vector4U7F25 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, X, X); }
        public readonly Vector4U7F25 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, X, Y); }
        public readonly Vector4U7F25 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, X, Z); }
        public readonly Vector4U7F25 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, X, W); }
        public readonly Vector4U7F25 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Y, X); }
        public readonly Vector4U7F25 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Y, Y); }
        public readonly Vector4U7F25 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Y, Z); }
        public readonly Vector4U7F25 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Y, W); }
        public readonly Vector4U7F25 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Z, X); }
        public readonly Vector4U7F25 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Z, Y); }
        public readonly Vector4U7F25 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Z, Z); }
        public readonly Vector4U7F25 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, Z, W); }
        public readonly Vector4U7F25 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, W, X); }
        public readonly Vector4U7F25 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, W, Y); }
        public readonly Vector4U7F25 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, W, Z); }
        public readonly Vector4U7F25 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Z, W, W); }
        public readonly Vector4U7F25 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, X, X); }
        public readonly Vector4U7F25 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, X, Y); }
        public readonly Vector4U7F25 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, X, Z); }
        public readonly Vector4U7F25 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, X, W); }
        public readonly Vector4U7F25 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, Y, X); }
        public readonly Vector4U7F25 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, Y, Y); }
        public readonly Vector4U7F25 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, Y, Z); }
        public readonly Vector4U7F25 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, Y, W); }
        public readonly Vector4U7F25 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, Z, X); }
        public readonly Vector4U7F25 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, Z, Y); }
        public readonly Vector4U7F25 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, Z, Z); }
        public readonly Vector4U7F25 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, Z, W); }
        public readonly Vector4U7F25 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, W, X); }
        public readonly Vector4U7F25 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, W, Y); }
        public readonly Vector4U7F25 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, W, Z); }
        public readonly Vector4U7F25 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, W, W, W); }
        public readonly Vector4U7F25 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, X, X); }
        public readonly Vector4U7F25 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, X, Y); }
        public readonly Vector4U7F25 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, X, Z); }
        public readonly Vector4U7F25 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, X, W); }
        public readonly Vector4U7F25 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Y, X); }
        public readonly Vector4U7F25 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Y, Y); }
        public readonly Vector4U7F25 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Y, Z); }
        public readonly Vector4U7F25 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Y, W); }
        public readonly Vector4U7F25 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Z, X); }
        public readonly Vector4U7F25 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Z, Y); }
        public readonly Vector4U7F25 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Z, Z); }
        public readonly Vector4U7F25 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, Z, W); }
        public readonly Vector4U7F25 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, W, X); }
        public readonly Vector4U7F25 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, W, Y); }
        public readonly Vector4U7F25 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, W, Z); }
        public readonly Vector4U7F25 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, X, W, W); }
        public readonly Vector4U7F25 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, X, X); }
        public readonly Vector4U7F25 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, X, Y); }
        public readonly Vector4U7F25 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, X, Z); }
        public readonly Vector4U7F25 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, X, W); }
        public readonly Vector4U7F25 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Y, X); }
        public readonly Vector4U7F25 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Y, Y); }
        public readonly Vector4U7F25 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Y, Z); }
        public readonly Vector4U7F25 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Y, W); }
        public readonly Vector4U7F25 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Z, X); }
        public readonly Vector4U7F25 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Z, Y); }
        public readonly Vector4U7F25 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Z, Z); }
        public readonly Vector4U7F25 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, Z, W); }
        public readonly Vector4U7F25 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, W, X); }
        public readonly Vector4U7F25 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, W, Y); }
        public readonly Vector4U7F25 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, W, Z); }
        public readonly Vector4U7F25 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Y, W, W); }
        public readonly Vector4U7F25 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, X, X); }
        public readonly Vector4U7F25 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, X, Y); }
        public readonly Vector4U7F25 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, X, Z); }
        public readonly Vector4U7F25 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, X, W); }
        public readonly Vector4U7F25 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Y, X); }
        public readonly Vector4U7F25 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Y, Y); }
        public readonly Vector4U7F25 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Y, Z); }
        public readonly Vector4U7F25 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Y, W); }
        public readonly Vector4U7F25 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Z, X); }
        public readonly Vector4U7F25 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Z, Y); }
        public readonly Vector4U7F25 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Z, Z); }
        public readonly Vector4U7F25 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, Z, W); }
        public readonly Vector4U7F25 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, W, X); }
        public readonly Vector4U7F25 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, W, Y); }
        public readonly Vector4U7F25 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, W, Z); }
        public readonly Vector4U7F25 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, Z, W, W); }
        public readonly Vector4U7F25 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, X, X); }
        public readonly Vector4U7F25 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, X, Y); }
        public readonly Vector4U7F25 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, X, Z); }
        public readonly Vector4U7F25 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, X, W); }
        public readonly Vector4U7F25 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, Y, X); }
        public readonly Vector4U7F25 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, Y, Y); }
        public readonly Vector4U7F25 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, Y, Z); }
        public readonly Vector4U7F25 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, Y, W); }
        public readonly Vector4U7F25 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, Z, X); }
        public readonly Vector4U7F25 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, Z, Y); }
        public readonly Vector4U7F25 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, Z, Z); }
        public readonly Vector4U7F25 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, Z, W); }
        public readonly Vector4U7F25 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, W, X); }
        public readonly Vector4U7F25 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, W, Y); }
        public readonly Vector4U7F25 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, W, Z); }
        public readonly Vector4U7F25 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Z, W, W, W); }
        public readonly Vector4U7F25 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, X, X); }
        public readonly Vector4U7F25 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, X, Y); }
        public readonly Vector4U7F25 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, X, Z); }
        public readonly Vector4U7F25 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, X, W); }
        public readonly Vector4U7F25 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, Y, X); }
        public readonly Vector4U7F25 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, Y, Y); }
        public readonly Vector4U7F25 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, Y, Z); }
        public readonly Vector4U7F25 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, Y, W); }
        public readonly Vector4U7F25 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, Z, X); }
        public readonly Vector4U7F25 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, Z, Y); }
        public readonly Vector4U7F25 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, Z, Z); }
        public readonly Vector4U7F25 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, Z, W); }
        public readonly Vector4U7F25 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, W, X); }
        public readonly Vector4U7F25 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, W, Y); }
        public readonly Vector4U7F25 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, W, Z); }
        public readonly Vector4U7F25 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, X, W, W); }
        public readonly Vector4U7F25 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, X, X); }
        public readonly Vector4U7F25 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, X, Y); }
        public readonly Vector4U7F25 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, X, Z); }
        public readonly Vector4U7F25 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, X, W); }
        public readonly Vector4U7F25 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, Y, X); }
        public readonly Vector4U7F25 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, Y, Y); }
        public readonly Vector4U7F25 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, Y, Z); }
        public readonly Vector4U7F25 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, Y, W); }
        public readonly Vector4U7F25 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, Z, X); }
        public readonly Vector4U7F25 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, Z, Y); }
        public readonly Vector4U7F25 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, Z, Z); }
        public readonly Vector4U7F25 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, Z, W); }
        public readonly Vector4U7F25 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, W, X); }
        public readonly Vector4U7F25 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, W, Y); }
        public readonly Vector4U7F25 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, W, Z); }
        public readonly Vector4U7F25 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Y, W, W); }
        public readonly Vector4U7F25 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, X, X); }
        public readonly Vector4U7F25 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, X, Y); }
        public readonly Vector4U7F25 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, X, Z); }
        public readonly Vector4U7F25 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, X, W); }
        public readonly Vector4U7F25 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, Y, X); }
        public readonly Vector4U7F25 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, Y, Y); }
        public readonly Vector4U7F25 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, Y, Z); }
        public readonly Vector4U7F25 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, Y, W); }
        public readonly Vector4U7F25 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, Z, X); }
        public readonly Vector4U7F25 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, Z, Y); }
        public readonly Vector4U7F25 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, Z, Z); }
        public readonly Vector4U7F25 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, Z, W); }
        public readonly Vector4U7F25 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, W, X); }
        public readonly Vector4U7F25 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, W, Y); }
        public readonly Vector4U7F25 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, W, Z); }
        public readonly Vector4U7F25 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, Z, W, W); }
        public readonly Vector4U7F25 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, X, X); }
        public readonly Vector4U7F25 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, X, Y); }
        public readonly Vector4U7F25 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, X, Z); }
        public readonly Vector4U7F25 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, X, W); }
        public readonly Vector4U7F25 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, Y, X); }
        public readonly Vector4U7F25 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, Y, Y); }
        public readonly Vector4U7F25 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, Y, Z); }
        public readonly Vector4U7F25 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, Y, W); }
        public readonly Vector4U7F25 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, Z, X); }
        public readonly Vector4U7F25 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, Z, Y); }
        public readonly Vector4U7F25 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, Z, Z); }
        public readonly Vector4U7F25 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, Z, W); }
        public readonly Vector4U7F25 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, W, X); }
        public readonly Vector4U7F25 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, W, Y); }
        public readonly Vector4U7F25 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, W, Z); }
        public readonly Vector4U7F25 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U7F25 lhs, Vector4U7F25 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U7F25 lhs, Vector4U7F25 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U7F25({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U7F25 other)
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
            return $"Vector4U7F25({x}, {y}, {z}, {w})";
        }
    }
}
