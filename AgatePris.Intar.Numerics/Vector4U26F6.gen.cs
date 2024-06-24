using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U26F6 : IEquatable<Vector4U26F6>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U26F6 X;
        public U26F6 Y;
        public U26F6 Z;
        public U26F6 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, U26F6 y, U26F6 z, U26F6 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, U26F6 y, Vector2U26F6 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, Vector3U26F6 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector2U26F6 xy, Vector2U26F6 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector4U26F6 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, Vector2U26F6 yz, U26F6 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector3U26F6 xyz, U26F6 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector2U26F6 xy, U26F6 z, U26F6 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U26F6 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero);
        }
        public static Vector4U26F6 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.One);
        }
        public static Vector4U26F6 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.One, U26F6.Zero, U26F6.Zero, U26F6.Zero);
        }
        public static Vector4U26F6 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero, U26F6.One, U26F6.Zero, U26F6.Zero);
        }
        public static Vector4U26F6 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero, U26F6.Zero, U26F6.One, U26F6.Zero);
        }
        public static Vector4U26F6 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero, U26F6.Zero, U26F6.Zero, U26F6.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator +(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator -(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator *(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator *(Vector4U26F6 a, U26F6 b) => new Vector4U26F6(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator *(U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator /(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator /(Vector4U26F6 a, U26F6 b) => new Vector4U26F6(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator /(U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U26F6 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, X); }
        public readonly Vector2U26F6 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, Y); }
        public readonly Vector2U26F6 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, Z); }
        public readonly Vector2U26F6 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, W); }
        public readonly Vector2U26F6 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, X); }
        public readonly Vector2U26F6 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, Y); }
        public readonly Vector2U26F6 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, Z); }
        public readonly Vector2U26F6 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, W); }
        public readonly Vector2U26F6 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, X); }
        public readonly Vector2U26F6 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, Y); }
        public readonly Vector2U26F6 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, Z); }
        public readonly Vector2U26F6 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, W); }
        public readonly Vector2U26F6 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(W, X); }
        public readonly Vector2U26F6 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(W, Y); }
        public readonly Vector2U26F6 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(W, Z); }
        public readonly Vector2U26F6 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(W, W); }
        public readonly Vector3U26F6 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, X); }
        public readonly Vector3U26F6 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, Y); }
        public readonly Vector3U26F6 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, Z); }
        public readonly Vector3U26F6 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, W); }
        public readonly Vector3U26F6 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, X); }
        public readonly Vector3U26F6 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, Y); }
        public readonly Vector3U26F6 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, Z); }
        public readonly Vector3U26F6 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, W); }
        public readonly Vector3U26F6 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, X); }
        public readonly Vector3U26F6 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, Y); }
        public readonly Vector3U26F6 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, Z); }
        public readonly Vector3U26F6 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, W); }
        public readonly Vector3U26F6 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, W, X); }
        public readonly Vector3U26F6 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, W, Y); }
        public readonly Vector3U26F6 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, W, Z); }
        public readonly Vector3U26F6 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, W, W); }
        public readonly Vector3U26F6 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, X); }
        public readonly Vector3U26F6 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, Y); }
        public readonly Vector3U26F6 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, Z); }
        public readonly Vector3U26F6 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, W); }
        public readonly Vector3U26F6 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, X); }
        public readonly Vector3U26F6 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, Y); }
        public readonly Vector3U26F6 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, Z); }
        public readonly Vector3U26F6 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, W); }
        public readonly Vector3U26F6 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, X); }
        public readonly Vector3U26F6 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, Y); }
        public readonly Vector3U26F6 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, Z); }
        public readonly Vector3U26F6 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, W); }
        public readonly Vector3U26F6 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, W, X); }
        public readonly Vector3U26F6 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, W, Y); }
        public readonly Vector3U26F6 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, W, Z); }
        public readonly Vector3U26F6 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, W, W); }
        public readonly Vector3U26F6 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, X); }
        public readonly Vector3U26F6 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, Y); }
        public readonly Vector3U26F6 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, Z); }
        public readonly Vector3U26F6 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, W); }
        public readonly Vector3U26F6 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, X); }
        public readonly Vector3U26F6 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, Y); }
        public readonly Vector3U26F6 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, Z); }
        public readonly Vector3U26F6 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, W); }
        public readonly Vector3U26F6 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, X); }
        public readonly Vector3U26F6 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, Y); }
        public readonly Vector3U26F6 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, Z); }
        public readonly Vector3U26F6 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, W); }
        public readonly Vector3U26F6 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, W, X); }
        public readonly Vector3U26F6 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, W, Y); }
        public readonly Vector3U26F6 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, W, Z); }
        public readonly Vector3U26F6 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, W, W); }
        public readonly Vector3U26F6 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, X, X); }
        public readonly Vector3U26F6 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, X, Y); }
        public readonly Vector3U26F6 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, X, Z); }
        public readonly Vector3U26F6 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, X, W); }
        public readonly Vector3U26F6 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Y, X); }
        public readonly Vector3U26F6 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Y, Y); }
        public readonly Vector3U26F6 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Y, Z); }
        public readonly Vector3U26F6 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Y, W); }
        public readonly Vector3U26F6 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Z, X); }
        public readonly Vector3U26F6 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Z, Y); }
        public readonly Vector3U26F6 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Z, Z); }
        public readonly Vector3U26F6 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Z, W); }
        public readonly Vector3U26F6 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, W, X); }
        public readonly Vector3U26F6 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, W, Y); }
        public readonly Vector3U26F6 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, W, Z); }
        public readonly Vector3U26F6 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, W, W); }
        public readonly Vector4U26F6 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, X); }
        public readonly Vector4U26F6 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, Y); }
        public readonly Vector4U26F6 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, Z); }
        public readonly Vector4U26F6 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, W); }
        public readonly Vector4U26F6 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, X); }
        public readonly Vector4U26F6 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, Y); }
        public readonly Vector4U26F6 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, Z); }
        public readonly Vector4U26F6 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, W); }
        public readonly Vector4U26F6 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, X); }
        public readonly Vector4U26F6 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, Y); }
        public readonly Vector4U26F6 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, Z); }
        public readonly Vector4U26F6 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, W); }
        public readonly Vector4U26F6 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, W, X); }
        public readonly Vector4U26F6 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, W, Y); }
        public readonly Vector4U26F6 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, W, Z); }
        public readonly Vector4U26F6 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, W, W); }
        public readonly Vector4U26F6 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, X); }
        public readonly Vector4U26F6 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, Y); }
        public readonly Vector4U26F6 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, Z); }
        public readonly Vector4U26F6 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, W); }
        public readonly Vector4U26F6 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, X); }
        public readonly Vector4U26F6 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, Y); }
        public readonly Vector4U26F6 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, Z); }
        public readonly Vector4U26F6 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, W); }
        public readonly Vector4U26F6 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, X); }
        public readonly Vector4U26F6 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, Y); }
        public readonly Vector4U26F6 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, Z); }
        public readonly Vector4U26F6 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, W); }
        public readonly Vector4U26F6 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, W, X); }
        public readonly Vector4U26F6 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, W, Y); }
        public readonly Vector4U26F6 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, W, Z); }
        public readonly Vector4U26F6 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, W, W); }
        public readonly Vector4U26F6 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, X); }
        public readonly Vector4U26F6 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, Y); }
        public readonly Vector4U26F6 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, Z); }
        public readonly Vector4U26F6 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, W); }
        public readonly Vector4U26F6 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, X); }
        public readonly Vector4U26F6 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, Y); }
        public readonly Vector4U26F6 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, Z); }
        public readonly Vector4U26F6 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, W); }
        public readonly Vector4U26F6 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, X); }
        public readonly Vector4U26F6 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, Y); }
        public readonly Vector4U26F6 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, Z); }
        public readonly Vector4U26F6 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, W); }
        public readonly Vector4U26F6 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, W, X); }
        public readonly Vector4U26F6 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, W, Y); }
        public readonly Vector4U26F6 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, W, Z); }
        public readonly Vector4U26F6 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, W, W); }
        public readonly Vector4U26F6 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, X, X); }
        public readonly Vector4U26F6 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, X, Y); }
        public readonly Vector4U26F6 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, X, Z); }
        public readonly Vector4U26F6 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, X, W); }
        public readonly Vector4U26F6 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Y, X); }
        public readonly Vector4U26F6 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Y, Y); }
        public readonly Vector4U26F6 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Y, Z); }
        public readonly Vector4U26F6 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Y, W); }
        public readonly Vector4U26F6 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Z, X); }
        public readonly Vector4U26F6 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Z, Y); }
        public readonly Vector4U26F6 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Z, Z); }
        public readonly Vector4U26F6 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Z, W); }
        public readonly Vector4U26F6 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, W, X); }
        public readonly Vector4U26F6 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, W, Y); }
        public readonly Vector4U26F6 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, W, Z); }
        public readonly Vector4U26F6 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, W, W); }
        public readonly Vector4U26F6 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, X); }
        public readonly Vector4U26F6 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, Y); }
        public readonly Vector4U26F6 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, Z); }
        public readonly Vector4U26F6 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, W); }
        public readonly Vector4U26F6 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, X); }
        public readonly Vector4U26F6 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, Y); }
        public readonly Vector4U26F6 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, Z); }
        public readonly Vector4U26F6 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, W); }
        public readonly Vector4U26F6 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, X); }
        public readonly Vector4U26F6 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, Y); }
        public readonly Vector4U26F6 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, Z); }
        public readonly Vector4U26F6 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, W); }
        public readonly Vector4U26F6 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, W, X); }
        public readonly Vector4U26F6 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, W, Y); }
        public readonly Vector4U26F6 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, W, Z); }
        public readonly Vector4U26F6 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, W, W); }
        public readonly Vector4U26F6 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, X); }
        public readonly Vector4U26F6 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, Y); }
        public readonly Vector4U26F6 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, Z); }
        public readonly Vector4U26F6 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, W); }
        public readonly Vector4U26F6 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, X); }
        public readonly Vector4U26F6 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, Y); }
        public readonly Vector4U26F6 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, Z); }
        public readonly Vector4U26F6 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, W); }
        public readonly Vector4U26F6 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, X); }
        public readonly Vector4U26F6 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, Y); }
        public readonly Vector4U26F6 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, Z); }
        public readonly Vector4U26F6 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, W); }
        public readonly Vector4U26F6 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, W, X); }
        public readonly Vector4U26F6 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, W, Y); }
        public readonly Vector4U26F6 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, W, Z); }
        public readonly Vector4U26F6 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, W, W); }
        public readonly Vector4U26F6 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, X); }
        public readonly Vector4U26F6 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, Y); }
        public readonly Vector4U26F6 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, Z); }
        public readonly Vector4U26F6 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, W); }
        public readonly Vector4U26F6 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, X); }
        public readonly Vector4U26F6 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, Y); }
        public readonly Vector4U26F6 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, Z); }
        public readonly Vector4U26F6 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, W); }
        public readonly Vector4U26F6 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, X); }
        public readonly Vector4U26F6 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, Y); }
        public readonly Vector4U26F6 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, Z); }
        public readonly Vector4U26F6 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, W); }
        public readonly Vector4U26F6 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, W, X); }
        public readonly Vector4U26F6 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, W, Y); }
        public readonly Vector4U26F6 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, W, Z); }
        public readonly Vector4U26F6 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, W, W); }
        public readonly Vector4U26F6 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, X, X); }
        public readonly Vector4U26F6 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, X, Y); }
        public readonly Vector4U26F6 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, X, Z); }
        public readonly Vector4U26F6 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, X, W); }
        public readonly Vector4U26F6 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Y, X); }
        public readonly Vector4U26F6 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Y, Y); }
        public readonly Vector4U26F6 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Y, Z); }
        public readonly Vector4U26F6 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Y, W); }
        public readonly Vector4U26F6 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Z, X); }
        public readonly Vector4U26F6 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Z, Y); }
        public readonly Vector4U26F6 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Z, Z); }
        public readonly Vector4U26F6 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Z, W); }
        public readonly Vector4U26F6 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, W, X); }
        public readonly Vector4U26F6 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, W, Y); }
        public readonly Vector4U26F6 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, W, Z); }
        public readonly Vector4U26F6 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, W, W); }
        public readonly Vector4U26F6 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, X); }
        public readonly Vector4U26F6 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, Y); }
        public readonly Vector4U26F6 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, Z); }
        public readonly Vector4U26F6 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, W); }
        public readonly Vector4U26F6 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, X); }
        public readonly Vector4U26F6 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, Y); }
        public readonly Vector4U26F6 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, Z); }
        public readonly Vector4U26F6 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, W); }
        public readonly Vector4U26F6 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, X); }
        public readonly Vector4U26F6 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, Y); }
        public readonly Vector4U26F6 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, Z); }
        public readonly Vector4U26F6 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, W); }
        public readonly Vector4U26F6 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, W, X); }
        public readonly Vector4U26F6 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, W, Y); }
        public readonly Vector4U26F6 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, W, Z); }
        public readonly Vector4U26F6 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, W, W); }
        public readonly Vector4U26F6 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, X); }
        public readonly Vector4U26F6 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, Y); }
        public readonly Vector4U26F6 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, Z); }
        public readonly Vector4U26F6 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, W); }
        public readonly Vector4U26F6 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, X); }
        public readonly Vector4U26F6 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, Y); }
        public readonly Vector4U26F6 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, Z); }
        public readonly Vector4U26F6 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, W); }
        public readonly Vector4U26F6 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, X); }
        public readonly Vector4U26F6 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, Y); }
        public readonly Vector4U26F6 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, Z); }
        public readonly Vector4U26F6 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, W); }
        public readonly Vector4U26F6 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, W, X); }
        public readonly Vector4U26F6 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, W, Y); }
        public readonly Vector4U26F6 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, W, Z); }
        public readonly Vector4U26F6 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, W, W); }
        public readonly Vector4U26F6 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, X); }
        public readonly Vector4U26F6 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, Y); }
        public readonly Vector4U26F6 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, Z); }
        public readonly Vector4U26F6 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, W); }
        public readonly Vector4U26F6 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, X); }
        public readonly Vector4U26F6 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, Y); }
        public readonly Vector4U26F6 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, Z); }
        public readonly Vector4U26F6 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, W); }
        public readonly Vector4U26F6 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, X); }
        public readonly Vector4U26F6 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, Y); }
        public readonly Vector4U26F6 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, Z); }
        public readonly Vector4U26F6 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, W); }
        public readonly Vector4U26F6 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, W, X); }
        public readonly Vector4U26F6 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, W, Y); }
        public readonly Vector4U26F6 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, W, Z); }
        public readonly Vector4U26F6 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, W, W); }
        public readonly Vector4U26F6 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, X, X); }
        public readonly Vector4U26F6 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, X, Y); }
        public readonly Vector4U26F6 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, X, Z); }
        public readonly Vector4U26F6 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, X, W); }
        public readonly Vector4U26F6 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Y, X); }
        public readonly Vector4U26F6 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Y, Y); }
        public readonly Vector4U26F6 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Y, Z); }
        public readonly Vector4U26F6 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Y, W); }
        public readonly Vector4U26F6 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Z, X); }
        public readonly Vector4U26F6 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Z, Y); }
        public readonly Vector4U26F6 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Z, Z); }
        public readonly Vector4U26F6 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Z, W); }
        public readonly Vector4U26F6 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, W, X); }
        public readonly Vector4U26F6 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, W, Y); }
        public readonly Vector4U26F6 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, W, Z); }
        public readonly Vector4U26F6 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, W, W); }
        public readonly Vector4U26F6 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, X, X); }
        public readonly Vector4U26F6 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, X, Y); }
        public readonly Vector4U26F6 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, X, Z); }
        public readonly Vector4U26F6 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, X, W); }
        public readonly Vector4U26F6 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Y, X); }
        public readonly Vector4U26F6 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Y, Y); }
        public readonly Vector4U26F6 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Y, Z); }
        public readonly Vector4U26F6 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Y, W); }
        public readonly Vector4U26F6 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Z, X); }
        public readonly Vector4U26F6 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Z, Y); }
        public readonly Vector4U26F6 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Z, Z); }
        public readonly Vector4U26F6 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Z, W); }
        public readonly Vector4U26F6 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, W, X); }
        public readonly Vector4U26F6 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, W, Y); }
        public readonly Vector4U26F6 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, W, Z); }
        public readonly Vector4U26F6 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, W, W); }
        public readonly Vector4U26F6 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, X, X); }
        public readonly Vector4U26F6 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, X, Y); }
        public readonly Vector4U26F6 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, X, Z); }
        public readonly Vector4U26F6 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, X, W); }
        public readonly Vector4U26F6 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Y, X); }
        public readonly Vector4U26F6 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Y, Y); }
        public readonly Vector4U26F6 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Y, Z); }
        public readonly Vector4U26F6 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Y, W); }
        public readonly Vector4U26F6 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Z, X); }
        public readonly Vector4U26F6 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Z, Y); }
        public readonly Vector4U26F6 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Z, Z); }
        public readonly Vector4U26F6 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Z, W); }
        public readonly Vector4U26F6 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, W, X); }
        public readonly Vector4U26F6 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, W, Y); }
        public readonly Vector4U26F6 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, W, Z); }
        public readonly Vector4U26F6 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, W, W); }
        public readonly Vector4U26F6 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, X, X); }
        public readonly Vector4U26F6 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, X, Y); }
        public readonly Vector4U26F6 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, X, Z); }
        public readonly Vector4U26F6 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, X, W); }
        public readonly Vector4U26F6 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Y, X); }
        public readonly Vector4U26F6 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Y, Y); }
        public readonly Vector4U26F6 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Y, Z); }
        public readonly Vector4U26F6 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Y, W); }
        public readonly Vector4U26F6 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Z, X); }
        public readonly Vector4U26F6 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Z, Y); }
        public readonly Vector4U26F6 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Z, Z); }
        public readonly Vector4U26F6 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Z, W); }
        public readonly Vector4U26F6 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, W, X); }
        public readonly Vector4U26F6 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, W, Y); }
        public readonly Vector4U26F6 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, W, Z); }
        public readonly Vector4U26F6 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, W, W); }
        public readonly Vector4U26F6 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, X, X); }
        public readonly Vector4U26F6 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, X, Y); }
        public readonly Vector4U26F6 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, X, Z); }
        public readonly Vector4U26F6 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, X, W); }
        public readonly Vector4U26F6 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Y, X); }
        public readonly Vector4U26F6 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Y, Y); }
        public readonly Vector4U26F6 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Y, Z); }
        public readonly Vector4U26F6 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Y, W); }
        public readonly Vector4U26F6 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Z, X); }
        public readonly Vector4U26F6 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Z, Y); }
        public readonly Vector4U26F6 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Z, Z); }
        public readonly Vector4U26F6 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Z, W); }
        public readonly Vector4U26F6 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, W, X); }
        public readonly Vector4U26F6 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, W, Y); }
        public readonly Vector4U26F6 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, W, Z); }
        public readonly Vector4U26F6 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U26F6 lhs, Vector4U26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U26F6 lhs, Vector4U26F6 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U26F6({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U26F6 other)
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
            return $"Vector4U26F6({x}, {y}, {z}, {w})";
        }
    }
}
