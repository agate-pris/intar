using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I4F28 : IEquatable<Vector4I4F28>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I4F28 X;
        public I4F28 Y;
        public I4F28 Z;
        public I4F28 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(I4F28 x, I4F28 y, I4F28 z, I4F28 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(I4F28 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(I4F28 x, I4F28 y, Vector2I4F28 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(I4F28 x, Vector3I4F28 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(Vector2I4F28 xy, Vector2I4F28 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(Vector4I4F28 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(I4F28 x, Vector2I4F28 yz, I4F28 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(Vector3I4F28 xyz, I4F28 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F28(Vector2I4F28 xy, I4F28 z, I4F28 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I4F28 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I4F28(I4F28.Zero);
        }
        public static Vector4I4F28 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I4F28(I4F28.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator +(Vector4I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator -(Vector4I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator *(Vector4I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator *(Vector4I4F28 a, I4F28 b) => new Vector4I4F28(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator *(I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator /(Vector4I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator /(Vector4I4F28 a, I4F28 b) => new Vector4I4F28(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 operator /(I4F28 a, Vector4I4F28 b) => new Vector4I4F28(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I4F28 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, X); }
        public readonly Vector2I4F28 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, Y); }
        public readonly Vector2I4F28 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, Z); }
        public readonly Vector2I4F28 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, W); }
        public readonly Vector2I4F28 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, X); }
        public readonly Vector2I4F28 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, Y); }
        public readonly Vector2I4F28 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, Z); }
        public readonly Vector2I4F28 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, W); }
        public readonly Vector2I4F28 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Z, X); }
        public readonly Vector2I4F28 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Z, Y); }
        public readonly Vector2I4F28 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Z, Z); }
        public readonly Vector2I4F28 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Z, W); }
        public readonly Vector2I4F28 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(W, X); }
        public readonly Vector2I4F28 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(W, Y); }
        public readonly Vector2I4F28 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(W, Z); }
        public readonly Vector2I4F28 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(W, W); }
        public readonly Vector3I4F28 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, X); }
        public readonly Vector3I4F28 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, Y); }
        public readonly Vector3I4F28 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, Z); }
        public readonly Vector3I4F28 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, W); }
        public readonly Vector3I4F28 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, X); }
        public readonly Vector3I4F28 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, Y); }
        public readonly Vector3I4F28 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, Z); }
        public readonly Vector3I4F28 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, W); }
        public readonly Vector3I4F28 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Z, X); }
        public readonly Vector3I4F28 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Z, Y); }
        public readonly Vector3I4F28 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Z, Z); }
        public readonly Vector3I4F28 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Z, W); }
        public readonly Vector3I4F28 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, W, X); }
        public readonly Vector3I4F28 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, W, Y); }
        public readonly Vector3I4F28 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, W, Z); }
        public readonly Vector3I4F28 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, W, W); }
        public readonly Vector3I4F28 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, X); }
        public readonly Vector3I4F28 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, Y); }
        public readonly Vector3I4F28 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, Z); }
        public readonly Vector3I4F28 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, W); }
        public readonly Vector3I4F28 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, X); }
        public readonly Vector3I4F28 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, Y); }
        public readonly Vector3I4F28 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, Z); }
        public readonly Vector3I4F28 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, W); }
        public readonly Vector3I4F28 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Z, X); }
        public readonly Vector3I4F28 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Z, Y); }
        public readonly Vector3I4F28 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Z, Z); }
        public readonly Vector3I4F28 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Z, W); }
        public readonly Vector3I4F28 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, W, X); }
        public readonly Vector3I4F28 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, W, Y); }
        public readonly Vector3I4F28 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, W, Z); }
        public readonly Vector3I4F28 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, W, W); }
        public readonly Vector3I4F28 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, X, X); }
        public readonly Vector3I4F28 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, X, Y); }
        public readonly Vector3I4F28 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, X, Z); }
        public readonly Vector3I4F28 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, X, W); }
        public readonly Vector3I4F28 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Y, X); }
        public readonly Vector3I4F28 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Y, Y); }
        public readonly Vector3I4F28 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Y, Z); }
        public readonly Vector3I4F28 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Y, W); }
        public readonly Vector3I4F28 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Z, X); }
        public readonly Vector3I4F28 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Z, Y); }
        public readonly Vector3I4F28 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Z, Z); }
        public readonly Vector3I4F28 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, Z, W); }
        public readonly Vector3I4F28 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, W, X); }
        public readonly Vector3I4F28 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, W, Y); }
        public readonly Vector3I4F28 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, W, Z); }
        public readonly Vector3I4F28 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Z, W, W); }
        public readonly Vector3I4F28 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, X, X); }
        public readonly Vector3I4F28 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, X, Y); }
        public readonly Vector3I4F28 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, X, Z); }
        public readonly Vector3I4F28 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, X, W); }
        public readonly Vector3I4F28 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, Y, X); }
        public readonly Vector3I4F28 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, Y, Y); }
        public readonly Vector3I4F28 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, Y, Z); }
        public readonly Vector3I4F28 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, Y, W); }
        public readonly Vector3I4F28 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, Z, X); }
        public readonly Vector3I4F28 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, Z, Y); }
        public readonly Vector3I4F28 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, Z, Z); }
        public readonly Vector3I4F28 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, Z, W); }
        public readonly Vector3I4F28 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, W, X); }
        public readonly Vector3I4F28 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, W, Y); }
        public readonly Vector3I4F28 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, W, Z); }
        public readonly Vector3I4F28 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(W, W, W); }
        public readonly Vector4I4F28 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, X); }
        public readonly Vector4I4F28 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, Y); }
        public readonly Vector4I4F28 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, Z); }
        public readonly Vector4I4F28 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, W); }
        public readonly Vector4I4F28 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, X); }
        public readonly Vector4I4F28 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, Y); }
        public readonly Vector4I4F28 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, Z); }
        public readonly Vector4I4F28 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, W); }
        public readonly Vector4I4F28 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Z, X); }
        public readonly Vector4I4F28 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Z, Y); }
        public readonly Vector4I4F28 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Z, Z); }
        public readonly Vector4I4F28 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Z, W); }
        public readonly Vector4I4F28 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, W, X); }
        public readonly Vector4I4F28 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, W, Y); }
        public readonly Vector4I4F28 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, W, Z); }
        public readonly Vector4I4F28 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, W, W); }
        public readonly Vector4I4F28 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, X); }
        public readonly Vector4I4F28 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, Y); }
        public readonly Vector4I4F28 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, Z); }
        public readonly Vector4I4F28 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, W); }
        public readonly Vector4I4F28 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, X); }
        public readonly Vector4I4F28 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, Y); }
        public readonly Vector4I4F28 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, Z); }
        public readonly Vector4I4F28 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, W); }
        public readonly Vector4I4F28 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Z, X); }
        public readonly Vector4I4F28 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Z, Y); }
        public readonly Vector4I4F28 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Z, Z); }
        public readonly Vector4I4F28 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Z, W); }
        public readonly Vector4I4F28 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, W, X); }
        public readonly Vector4I4F28 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, W, Y); }
        public readonly Vector4I4F28 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, W, Z); }
        public readonly Vector4I4F28 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, W, W); }
        public readonly Vector4I4F28 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, X, X); }
        public readonly Vector4I4F28 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, X, Y); }
        public readonly Vector4I4F28 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, X, Z); }
        public readonly Vector4I4F28 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, X, W); }
        public readonly Vector4I4F28 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Y, X); }
        public readonly Vector4I4F28 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Y, Y); }
        public readonly Vector4I4F28 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Y, Z); }
        public readonly Vector4I4F28 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Y, W); }
        public readonly Vector4I4F28 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Z, X); }
        public readonly Vector4I4F28 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Z, Y); }
        public readonly Vector4I4F28 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Z, Z); }
        public readonly Vector4I4F28 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, Z, W); }
        public readonly Vector4I4F28 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, W, X); }
        public readonly Vector4I4F28 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, W, Y); }
        public readonly Vector4I4F28 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, W, Z); }
        public readonly Vector4I4F28 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Z, W, W); }
        public readonly Vector4I4F28 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, X, X); }
        public readonly Vector4I4F28 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, X, Y); }
        public readonly Vector4I4F28 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, X, Z); }
        public readonly Vector4I4F28 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, X, W); }
        public readonly Vector4I4F28 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, Y, X); }
        public readonly Vector4I4F28 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, Y, Y); }
        public readonly Vector4I4F28 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, Y, Z); }
        public readonly Vector4I4F28 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, Y, W); }
        public readonly Vector4I4F28 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, Z, X); }
        public readonly Vector4I4F28 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, Z, Y); }
        public readonly Vector4I4F28 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, Z, Z); }
        public readonly Vector4I4F28 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, Z, W); }
        public readonly Vector4I4F28 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, W, X); }
        public readonly Vector4I4F28 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, W, Y); }
        public readonly Vector4I4F28 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, W, Z); }
        public readonly Vector4I4F28 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, W, W, W); }
        public readonly Vector4I4F28 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, X); }
        public readonly Vector4I4F28 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, Y); }
        public readonly Vector4I4F28 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, Z); }
        public readonly Vector4I4F28 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, W); }
        public readonly Vector4I4F28 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, X); }
        public readonly Vector4I4F28 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, Y); }
        public readonly Vector4I4F28 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, Z); }
        public readonly Vector4I4F28 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, W); }
        public readonly Vector4I4F28 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Z, X); }
        public readonly Vector4I4F28 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Z, Y); }
        public readonly Vector4I4F28 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Z, Z); }
        public readonly Vector4I4F28 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Z, W); }
        public readonly Vector4I4F28 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, W, X); }
        public readonly Vector4I4F28 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, W, Y); }
        public readonly Vector4I4F28 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, W, Z); }
        public readonly Vector4I4F28 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, W, W); }
        public readonly Vector4I4F28 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, X); }
        public readonly Vector4I4F28 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, Y); }
        public readonly Vector4I4F28 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, Z); }
        public readonly Vector4I4F28 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, W); }
        public readonly Vector4I4F28 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, X); }
        public readonly Vector4I4F28 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, Y); }
        public readonly Vector4I4F28 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, Z); }
        public readonly Vector4I4F28 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, W); }
        public readonly Vector4I4F28 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Z, X); }
        public readonly Vector4I4F28 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Z, Y); }
        public readonly Vector4I4F28 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Z, Z); }
        public readonly Vector4I4F28 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Z, W); }
        public readonly Vector4I4F28 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, W, X); }
        public readonly Vector4I4F28 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, W, Y); }
        public readonly Vector4I4F28 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, W, Z); }
        public readonly Vector4I4F28 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, W, W); }
        public readonly Vector4I4F28 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, X, X); }
        public readonly Vector4I4F28 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, X, Y); }
        public readonly Vector4I4F28 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, X, Z); }
        public readonly Vector4I4F28 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, X, W); }
        public readonly Vector4I4F28 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Y, X); }
        public readonly Vector4I4F28 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Y, Y); }
        public readonly Vector4I4F28 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Y, Z); }
        public readonly Vector4I4F28 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Y, W); }
        public readonly Vector4I4F28 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Z, X); }
        public readonly Vector4I4F28 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Z, Y); }
        public readonly Vector4I4F28 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Z, Z); }
        public readonly Vector4I4F28 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, Z, W); }
        public readonly Vector4I4F28 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, W, X); }
        public readonly Vector4I4F28 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, W, Y); }
        public readonly Vector4I4F28 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, W, Z); }
        public readonly Vector4I4F28 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Z, W, W); }
        public readonly Vector4I4F28 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, X, X); }
        public readonly Vector4I4F28 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, X, Y); }
        public readonly Vector4I4F28 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, X, Z); }
        public readonly Vector4I4F28 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, X, W); }
        public readonly Vector4I4F28 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, Y, X); }
        public readonly Vector4I4F28 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, Y, Y); }
        public readonly Vector4I4F28 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, Y, Z); }
        public readonly Vector4I4F28 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, Y, W); }
        public readonly Vector4I4F28 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, Z, X); }
        public readonly Vector4I4F28 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, Z, Y); }
        public readonly Vector4I4F28 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, Z, Z); }
        public readonly Vector4I4F28 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, Z, W); }
        public readonly Vector4I4F28 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, W, X); }
        public readonly Vector4I4F28 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, W, Y); }
        public readonly Vector4I4F28 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, W, Z); }
        public readonly Vector4I4F28 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, W, W, W); }
        public readonly Vector4I4F28 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, X, X); }
        public readonly Vector4I4F28 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, X, Y); }
        public readonly Vector4I4F28 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, X, Z); }
        public readonly Vector4I4F28 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, X, W); }
        public readonly Vector4I4F28 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Y, X); }
        public readonly Vector4I4F28 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Y, Y); }
        public readonly Vector4I4F28 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Y, Z); }
        public readonly Vector4I4F28 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Y, W); }
        public readonly Vector4I4F28 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Z, X); }
        public readonly Vector4I4F28 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Z, Y); }
        public readonly Vector4I4F28 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Z, Z); }
        public readonly Vector4I4F28 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, Z, W); }
        public readonly Vector4I4F28 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, W, X); }
        public readonly Vector4I4F28 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, W, Y); }
        public readonly Vector4I4F28 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, W, Z); }
        public readonly Vector4I4F28 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, X, W, W); }
        public readonly Vector4I4F28 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, X, X); }
        public readonly Vector4I4F28 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, X, Y); }
        public readonly Vector4I4F28 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, X, Z); }
        public readonly Vector4I4F28 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, X, W); }
        public readonly Vector4I4F28 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Y, X); }
        public readonly Vector4I4F28 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Y, Y); }
        public readonly Vector4I4F28 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Y, Z); }
        public readonly Vector4I4F28 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Y, W); }
        public readonly Vector4I4F28 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Z, X); }
        public readonly Vector4I4F28 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Z, Y); }
        public readonly Vector4I4F28 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Z, Z); }
        public readonly Vector4I4F28 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, Z, W); }
        public readonly Vector4I4F28 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, W, X); }
        public readonly Vector4I4F28 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, W, Y); }
        public readonly Vector4I4F28 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, W, Z); }
        public readonly Vector4I4F28 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Y, W, W); }
        public readonly Vector4I4F28 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, X, X); }
        public readonly Vector4I4F28 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, X, Y); }
        public readonly Vector4I4F28 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, X, Z); }
        public readonly Vector4I4F28 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, X, W); }
        public readonly Vector4I4F28 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Y, X); }
        public readonly Vector4I4F28 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Y, Y); }
        public readonly Vector4I4F28 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Y, Z); }
        public readonly Vector4I4F28 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Y, W); }
        public readonly Vector4I4F28 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Z, X); }
        public readonly Vector4I4F28 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Z, Y); }
        public readonly Vector4I4F28 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Z, Z); }
        public readonly Vector4I4F28 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, Z, W); }
        public readonly Vector4I4F28 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, W, X); }
        public readonly Vector4I4F28 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, W, Y); }
        public readonly Vector4I4F28 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, W, Z); }
        public readonly Vector4I4F28 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, Z, W, W); }
        public readonly Vector4I4F28 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, X, X); }
        public readonly Vector4I4F28 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, X, Y); }
        public readonly Vector4I4F28 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, X, Z); }
        public readonly Vector4I4F28 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, X, W); }
        public readonly Vector4I4F28 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, Y, X); }
        public readonly Vector4I4F28 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, Y, Y); }
        public readonly Vector4I4F28 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, Y, Z); }
        public readonly Vector4I4F28 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, Y, W); }
        public readonly Vector4I4F28 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, Z, X); }
        public readonly Vector4I4F28 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, Z, Y); }
        public readonly Vector4I4F28 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, Z, Z); }
        public readonly Vector4I4F28 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, Z, W); }
        public readonly Vector4I4F28 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, W, X); }
        public readonly Vector4I4F28 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, W, Y); }
        public readonly Vector4I4F28 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, W, Z); }
        public readonly Vector4I4F28 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Z, W, W, W); }
        public readonly Vector4I4F28 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, X, X); }
        public readonly Vector4I4F28 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, X, Y); }
        public readonly Vector4I4F28 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, X, Z); }
        public readonly Vector4I4F28 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, X, W); }
        public readonly Vector4I4F28 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, Y, X); }
        public readonly Vector4I4F28 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, Y, Y); }
        public readonly Vector4I4F28 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, Y, Z); }
        public readonly Vector4I4F28 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, Y, W); }
        public readonly Vector4I4F28 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, Z, X); }
        public readonly Vector4I4F28 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, Z, Y); }
        public readonly Vector4I4F28 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, Z, Z); }
        public readonly Vector4I4F28 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, Z, W); }
        public readonly Vector4I4F28 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, W, X); }
        public readonly Vector4I4F28 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, W, Y); }
        public readonly Vector4I4F28 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, W, Z); }
        public readonly Vector4I4F28 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, X, W, W); }
        public readonly Vector4I4F28 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, X, X); }
        public readonly Vector4I4F28 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, X, Y); }
        public readonly Vector4I4F28 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, X, Z); }
        public readonly Vector4I4F28 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, X, W); }
        public readonly Vector4I4F28 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, Y, X); }
        public readonly Vector4I4F28 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, Y, Y); }
        public readonly Vector4I4F28 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, Y, Z); }
        public readonly Vector4I4F28 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, Y, W); }
        public readonly Vector4I4F28 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, Z, X); }
        public readonly Vector4I4F28 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, Z, Y); }
        public readonly Vector4I4F28 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, Z, Z); }
        public readonly Vector4I4F28 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, Z, W); }
        public readonly Vector4I4F28 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, W, X); }
        public readonly Vector4I4F28 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, W, Y); }
        public readonly Vector4I4F28 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, W, Z); }
        public readonly Vector4I4F28 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Y, W, W); }
        public readonly Vector4I4F28 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, X, X); }
        public readonly Vector4I4F28 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, X, Y); }
        public readonly Vector4I4F28 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, X, Z); }
        public readonly Vector4I4F28 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, X, W); }
        public readonly Vector4I4F28 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, Y, X); }
        public readonly Vector4I4F28 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, Y, Y); }
        public readonly Vector4I4F28 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, Y, Z); }
        public readonly Vector4I4F28 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, Y, W); }
        public readonly Vector4I4F28 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, Z, X); }
        public readonly Vector4I4F28 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, Z, Y); }
        public readonly Vector4I4F28 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, Z, Z); }
        public readonly Vector4I4F28 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, Z, W); }
        public readonly Vector4I4F28 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, W, X); }
        public readonly Vector4I4F28 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, W, Y); }
        public readonly Vector4I4F28 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, W, Z); }
        public readonly Vector4I4F28 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, Z, W, W); }
        public readonly Vector4I4F28 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, X, X); }
        public readonly Vector4I4F28 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, X, Y); }
        public readonly Vector4I4F28 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, X, Z); }
        public readonly Vector4I4F28 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, X, W); }
        public readonly Vector4I4F28 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, Y, X); }
        public readonly Vector4I4F28 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, Y, Y); }
        public readonly Vector4I4F28 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, Y, Z); }
        public readonly Vector4I4F28 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, Y, W); }
        public readonly Vector4I4F28 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, Z, X); }
        public readonly Vector4I4F28 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, Z, Y); }
        public readonly Vector4I4F28 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, Z, Z); }
        public readonly Vector4I4F28 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, Z, W); }
        public readonly Vector4I4F28 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, W, X); }
        public readonly Vector4I4F28 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, W, Y); }
        public readonly Vector4I4F28 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, W, Z); }
        public readonly Vector4I4F28 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I4F28 lhs, Vector4I4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I4F28 lhs, Vector4I4F28 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I4F28({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I4F28 other)
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
            return $"Vector4I4F28({x}, {y}, {z}, {w})";
        }
    }
}
