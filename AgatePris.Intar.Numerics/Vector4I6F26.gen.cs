using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I6F26 : IEquatable<Vector4I6F26>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I6F26 X;
        public I6F26 Y;
        public I6F26 Z;
        public I6F26 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4I6F26 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, I6F26 y, I6F26 z, I6F26 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, I6F26 y, Vector2I6F26 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, Vector3I6F26 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector2I6F26 xy, Vector2I6F26 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector4I6F26 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, Vector2I6F26 yz, I6F26 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector3I6F26 xyz, I6F26 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector2I6F26 xy, I6F26 z, I6F26 w) : this(xy.X, xy.Y, z, w) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator +(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator -(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator *(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator *(Vector4I6F26 a, I6F26 b) => new Vector4I6F26(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator *(I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator /(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator /(Vector4I6F26 a, I6F26 b) => new Vector4I6F26(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator /(I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I6F26 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(X, X); }
        public readonly Vector2I6F26 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(X, Y); }
        public readonly Vector2I6F26 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(X, Z); }
        public readonly Vector2I6F26 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(X, W); }
        public readonly Vector2I6F26 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Y, X); }
        public readonly Vector2I6F26 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Y, Y); }
        public readonly Vector2I6F26 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Y, Z); }
        public readonly Vector2I6F26 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Y, W); }
        public readonly Vector2I6F26 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Z, X); }
        public readonly Vector2I6F26 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Z, Y); }
        public readonly Vector2I6F26 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Z, Z); }
        public readonly Vector2I6F26 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Z, W); }
        public readonly Vector2I6F26 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(W, X); }
        public readonly Vector2I6F26 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(W, Y); }
        public readonly Vector2I6F26 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(W, Z); }
        public readonly Vector2I6F26 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(W, W); }
        public readonly Vector3I6F26 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, X, X); }
        public readonly Vector3I6F26 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, X, Y); }
        public readonly Vector3I6F26 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, X, Z); }
        public readonly Vector3I6F26 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, X, W); }
        public readonly Vector3I6F26 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Y, X); }
        public readonly Vector3I6F26 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Y, Y); }
        public readonly Vector3I6F26 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Y, Z); }
        public readonly Vector3I6F26 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Y, W); }
        public readonly Vector3I6F26 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Z, X); }
        public readonly Vector3I6F26 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Z, Y); }
        public readonly Vector3I6F26 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Z, Z); }
        public readonly Vector3I6F26 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Z, W); }
        public readonly Vector3I6F26 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, W, X); }
        public readonly Vector3I6F26 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, W, Y); }
        public readonly Vector3I6F26 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, W, Z); }
        public readonly Vector3I6F26 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, W, W); }
        public readonly Vector3I6F26 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, X, X); }
        public readonly Vector3I6F26 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, X, Y); }
        public readonly Vector3I6F26 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, X, Z); }
        public readonly Vector3I6F26 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, X, W); }
        public readonly Vector3I6F26 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Y, X); }
        public readonly Vector3I6F26 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Y, Y); }
        public readonly Vector3I6F26 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Y, Z); }
        public readonly Vector3I6F26 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Y, W); }
        public readonly Vector3I6F26 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Z, X); }
        public readonly Vector3I6F26 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Z, Y); }
        public readonly Vector3I6F26 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Z, Z); }
        public readonly Vector3I6F26 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Z, W); }
        public readonly Vector3I6F26 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, W, X); }
        public readonly Vector3I6F26 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, W, Y); }
        public readonly Vector3I6F26 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, W, Z); }
        public readonly Vector3I6F26 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, W, W); }
        public readonly Vector3I6F26 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, X, X); }
        public readonly Vector3I6F26 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, X, Y); }
        public readonly Vector3I6F26 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, X, Z); }
        public readonly Vector3I6F26 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, X, W); }
        public readonly Vector3I6F26 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Y, X); }
        public readonly Vector3I6F26 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Y, Y); }
        public readonly Vector3I6F26 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Y, Z); }
        public readonly Vector3I6F26 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Y, W); }
        public readonly Vector3I6F26 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Z, X); }
        public readonly Vector3I6F26 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Z, Y); }
        public readonly Vector3I6F26 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Z, Z); }
        public readonly Vector3I6F26 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Z, W); }
        public readonly Vector3I6F26 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, W, X); }
        public readonly Vector3I6F26 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, W, Y); }
        public readonly Vector3I6F26 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, W, Z); }
        public readonly Vector3I6F26 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, W, W); }
        public readonly Vector3I6F26 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, X, X); }
        public readonly Vector3I6F26 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, X, Y); }
        public readonly Vector3I6F26 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, X, Z); }
        public readonly Vector3I6F26 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, X, W); }
        public readonly Vector3I6F26 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Y, X); }
        public readonly Vector3I6F26 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Y, Y); }
        public readonly Vector3I6F26 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Y, Z); }
        public readonly Vector3I6F26 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Y, W); }
        public readonly Vector3I6F26 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Z, X); }
        public readonly Vector3I6F26 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Z, Y); }
        public readonly Vector3I6F26 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Z, Z); }
        public readonly Vector3I6F26 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Z, W); }
        public readonly Vector3I6F26 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, W, X); }
        public readonly Vector3I6F26 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, W, Y); }
        public readonly Vector3I6F26 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, W, Z); }
        public readonly Vector3I6F26 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, W, W); }
        public readonly Vector4I6F26 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, X, X); }
        public readonly Vector4I6F26 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, X, Y); }
        public readonly Vector4I6F26 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, X, Z); }
        public readonly Vector4I6F26 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, X, W); }
        public readonly Vector4I6F26 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Y, X); }
        public readonly Vector4I6F26 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Y, Y); }
        public readonly Vector4I6F26 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Y, Z); }
        public readonly Vector4I6F26 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Y, W); }
        public readonly Vector4I6F26 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Z, X); }
        public readonly Vector4I6F26 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Z, Y); }
        public readonly Vector4I6F26 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Z, Z); }
        public readonly Vector4I6F26 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Z, W); }
        public readonly Vector4I6F26 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, W, X); }
        public readonly Vector4I6F26 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, W, Y); }
        public readonly Vector4I6F26 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, W, Z); }
        public readonly Vector4I6F26 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, W, W); }
        public readonly Vector4I6F26 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, X, X); }
        public readonly Vector4I6F26 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, X, Y); }
        public readonly Vector4I6F26 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, X, Z); }
        public readonly Vector4I6F26 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, X, W); }
        public readonly Vector4I6F26 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Y, X); }
        public readonly Vector4I6F26 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Y, Y); }
        public readonly Vector4I6F26 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Y, Z); }
        public readonly Vector4I6F26 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Y, W); }
        public readonly Vector4I6F26 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Z, X); }
        public readonly Vector4I6F26 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Z, Y); }
        public readonly Vector4I6F26 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Z, Z); }
        public readonly Vector4I6F26 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Z, W); }
        public readonly Vector4I6F26 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, W, X); }
        public readonly Vector4I6F26 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, W, Y); }
        public readonly Vector4I6F26 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, W, Z); }
        public readonly Vector4I6F26 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, W, W); }
        public readonly Vector4I6F26 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, X, X); }
        public readonly Vector4I6F26 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, X, Y); }
        public readonly Vector4I6F26 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, X, Z); }
        public readonly Vector4I6F26 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, X, W); }
        public readonly Vector4I6F26 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Y, X); }
        public readonly Vector4I6F26 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Y, Y); }
        public readonly Vector4I6F26 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Y, Z); }
        public readonly Vector4I6F26 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Y, W); }
        public readonly Vector4I6F26 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Z, X); }
        public readonly Vector4I6F26 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Z, Y); }
        public readonly Vector4I6F26 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Z, Z); }
        public readonly Vector4I6F26 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Z, W); }
        public readonly Vector4I6F26 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, W, X); }
        public readonly Vector4I6F26 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, W, Y); }
        public readonly Vector4I6F26 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, W, Z); }
        public readonly Vector4I6F26 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, W, W); }
        public readonly Vector4I6F26 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, X, X); }
        public readonly Vector4I6F26 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, X, Y); }
        public readonly Vector4I6F26 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, X, Z); }
        public readonly Vector4I6F26 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, X, W); }
        public readonly Vector4I6F26 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Y, X); }
        public readonly Vector4I6F26 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Y, Y); }
        public readonly Vector4I6F26 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Y, Z); }
        public readonly Vector4I6F26 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Y, W); }
        public readonly Vector4I6F26 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Z, X); }
        public readonly Vector4I6F26 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Z, Y); }
        public readonly Vector4I6F26 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Z, Z); }
        public readonly Vector4I6F26 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Z, W); }
        public readonly Vector4I6F26 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, W, X); }
        public readonly Vector4I6F26 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, W, Y); }
        public readonly Vector4I6F26 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, W, Z); }
        public readonly Vector4I6F26 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, W, W); }
        public readonly Vector4I6F26 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, X, X); }
        public readonly Vector4I6F26 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, X, Y); }
        public readonly Vector4I6F26 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, X, Z); }
        public readonly Vector4I6F26 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, X, W); }
        public readonly Vector4I6F26 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Y, X); }
        public readonly Vector4I6F26 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Y, Y); }
        public readonly Vector4I6F26 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Y, Z); }
        public readonly Vector4I6F26 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Y, W); }
        public readonly Vector4I6F26 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Z, X); }
        public readonly Vector4I6F26 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Z, Y); }
        public readonly Vector4I6F26 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Z, Z); }
        public readonly Vector4I6F26 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Z, W); }
        public readonly Vector4I6F26 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, W, X); }
        public readonly Vector4I6F26 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, W, Y); }
        public readonly Vector4I6F26 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, W, Z); }
        public readonly Vector4I6F26 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, W, W); }
        public readonly Vector4I6F26 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, X, X); }
        public readonly Vector4I6F26 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, X, Y); }
        public readonly Vector4I6F26 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, X, Z); }
        public readonly Vector4I6F26 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, X, W); }
        public readonly Vector4I6F26 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Y, X); }
        public readonly Vector4I6F26 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Y, Y); }
        public readonly Vector4I6F26 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Y, Z); }
        public readonly Vector4I6F26 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Y, W); }
        public readonly Vector4I6F26 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Z, X); }
        public readonly Vector4I6F26 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Z, Y); }
        public readonly Vector4I6F26 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Z, Z); }
        public readonly Vector4I6F26 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Z, W); }
        public readonly Vector4I6F26 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, W, X); }
        public readonly Vector4I6F26 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, W, Y); }
        public readonly Vector4I6F26 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, W, Z); }
        public readonly Vector4I6F26 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, W, W); }
        public readonly Vector4I6F26 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, X, X); }
        public readonly Vector4I6F26 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, X, Y); }
        public readonly Vector4I6F26 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, X, Z); }
        public readonly Vector4I6F26 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, X, W); }
        public readonly Vector4I6F26 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Y, X); }
        public readonly Vector4I6F26 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Y, Y); }
        public readonly Vector4I6F26 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Y, Z); }
        public readonly Vector4I6F26 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Y, W); }
        public readonly Vector4I6F26 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Z, X); }
        public readonly Vector4I6F26 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Z, Y); }
        public readonly Vector4I6F26 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Z, Z); }
        public readonly Vector4I6F26 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Z, W); }
        public readonly Vector4I6F26 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, W, X); }
        public readonly Vector4I6F26 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, W, Y); }
        public readonly Vector4I6F26 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, W, Z); }
        public readonly Vector4I6F26 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, W, W); }
        public readonly Vector4I6F26 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, X, X); }
        public readonly Vector4I6F26 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, X, Y); }
        public readonly Vector4I6F26 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, X, Z); }
        public readonly Vector4I6F26 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, X, W); }
        public readonly Vector4I6F26 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Y, X); }
        public readonly Vector4I6F26 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Y, Y); }
        public readonly Vector4I6F26 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Y, Z); }
        public readonly Vector4I6F26 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Y, W); }
        public readonly Vector4I6F26 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Z, X); }
        public readonly Vector4I6F26 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Z, Y); }
        public readonly Vector4I6F26 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Z, Z); }
        public readonly Vector4I6F26 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Z, W); }
        public readonly Vector4I6F26 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, W, X); }
        public readonly Vector4I6F26 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, W, Y); }
        public readonly Vector4I6F26 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, W, Z); }
        public readonly Vector4I6F26 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, W, W); }
        public readonly Vector4I6F26 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, X, X); }
        public readonly Vector4I6F26 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, X, Y); }
        public readonly Vector4I6F26 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, X, Z); }
        public readonly Vector4I6F26 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, X, W); }
        public readonly Vector4I6F26 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Y, X); }
        public readonly Vector4I6F26 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Y, Y); }
        public readonly Vector4I6F26 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Y, Z); }
        public readonly Vector4I6F26 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Y, W); }
        public readonly Vector4I6F26 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Z, X); }
        public readonly Vector4I6F26 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Z, Y); }
        public readonly Vector4I6F26 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Z, Z); }
        public readonly Vector4I6F26 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Z, W); }
        public readonly Vector4I6F26 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, W, X); }
        public readonly Vector4I6F26 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, W, Y); }
        public readonly Vector4I6F26 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, W, Z); }
        public readonly Vector4I6F26 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, W, W); }
        public readonly Vector4I6F26 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, X, X); }
        public readonly Vector4I6F26 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, X, Y); }
        public readonly Vector4I6F26 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, X, Z); }
        public readonly Vector4I6F26 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, X, W); }
        public readonly Vector4I6F26 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Y, X); }
        public readonly Vector4I6F26 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Y, Y); }
        public readonly Vector4I6F26 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Y, Z); }
        public readonly Vector4I6F26 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Y, W); }
        public readonly Vector4I6F26 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Z, X); }
        public readonly Vector4I6F26 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Z, Y); }
        public readonly Vector4I6F26 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Z, Z); }
        public readonly Vector4I6F26 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Z, W); }
        public readonly Vector4I6F26 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, W, X); }
        public readonly Vector4I6F26 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, W, Y); }
        public readonly Vector4I6F26 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, W, Z); }
        public readonly Vector4I6F26 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, W, W); }
        public readonly Vector4I6F26 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, X, X); }
        public readonly Vector4I6F26 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, X, Y); }
        public readonly Vector4I6F26 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, X, Z); }
        public readonly Vector4I6F26 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, X, W); }
        public readonly Vector4I6F26 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Y, X); }
        public readonly Vector4I6F26 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Y, Y); }
        public readonly Vector4I6F26 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Y, Z); }
        public readonly Vector4I6F26 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Y, W); }
        public readonly Vector4I6F26 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Z, X); }
        public readonly Vector4I6F26 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Z, Y); }
        public readonly Vector4I6F26 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Z, Z); }
        public readonly Vector4I6F26 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Z, W); }
        public readonly Vector4I6F26 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, W, X); }
        public readonly Vector4I6F26 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, W, Y); }
        public readonly Vector4I6F26 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, W, Z); }
        public readonly Vector4I6F26 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, W, W); }
        public readonly Vector4I6F26 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, X, X); }
        public readonly Vector4I6F26 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, X, Y); }
        public readonly Vector4I6F26 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, X, Z); }
        public readonly Vector4I6F26 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, X, W); }
        public readonly Vector4I6F26 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Y, X); }
        public readonly Vector4I6F26 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Y, Y); }
        public readonly Vector4I6F26 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Y, Z); }
        public readonly Vector4I6F26 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Y, W); }
        public readonly Vector4I6F26 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Z, X); }
        public readonly Vector4I6F26 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Z, Y); }
        public readonly Vector4I6F26 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Z, Z); }
        public readonly Vector4I6F26 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Z, W); }
        public readonly Vector4I6F26 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, W, X); }
        public readonly Vector4I6F26 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, W, Y); }
        public readonly Vector4I6F26 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, W, Z); }
        public readonly Vector4I6F26 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, W, W); }
        public readonly Vector4I6F26 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, X, X); }
        public readonly Vector4I6F26 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, X, Y); }
        public readonly Vector4I6F26 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, X, Z); }
        public readonly Vector4I6F26 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, X, W); }
        public readonly Vector4I6F26 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Y, X); }
        public readonly Vector4I6F26 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Y, Y); }
        public readonly Vector4I6F26 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Y, Z); }
        public readonly Vector4I6F26 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Y, W); }
        public readonly Vector4I6F26 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Z, X); }
        public readonly Vector4I6F26 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Z, Y); }
        public readonly Vector4I6F26 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Z, Z); }
        public readonly Vector4I6F26 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Z, W); }
        public readonly Vector4I6F26 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, W, X); }
        public readonly Vector4I6F26 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, W, Y); }
        public readonly Vector4I6F26 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, W, Z); }
        public readonly Vector4I6F26 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, W, W); }
        public readonly Vector4I6F26 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, X, X); }
        public readonly Vector4I6F26 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, X, Y); }
        public readonly Vector4I6F26 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, X, Z); }
        public readonly Vector4I6F26 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, X, W); }
        public readonly Vector4I6F26 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Y, X); }
        public readonly Vector4I6F26 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Y, Y); }
        public readonly Vector4I6F26 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Y, Z); }
        public readonly Vector4I6F26 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Y, W); }
        public readonly Vector4I6F26 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Z, X); }
        public readonly Vector4I6F26 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Z, Y); }
        public readonly Vector4I6F26 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Z, Z); }
        public readonly Vector4I6F26 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Z, W); }
        public readonly Vector4I6F26 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, W, X); }
        public readonly Vector4I6F26 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, W, Y); }
        public readonly Vector4I6F26 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, W, Z); }
        public readonly Vector4I6F26 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, W, W); }
        public readonly Vector4I6F26 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, X, X); }
        public readonly Vector4I6F26 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, X, Y); }
        public readonly Vector4I6F26 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, X, Z); }
        public readonly Vector4I6F26 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, X, W); }
        public readonly Vector4I6F26 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Y, X); }
        public readonly Vector4I6F26 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Y, Y); }
        public readonly Vector4I6F26 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Y, Z); }
        public readonly Vector4I6F26 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Y, W); }
        public readonly Vector4I6F26 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Z, X); }
        public readonly Vector4I6F26 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Z, Y); }
        public readonly Vector4I6F26 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Z, Z); }
        public readonly Vector4I6F26 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Z, W); }
        public readonly Vector4I6F26 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, W, X); }
        public readonly Vector4I6F26 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, W, Y); }
        public readonly Vector4I6F26 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, W, Z); }
        public readonly Vector4I6F26 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, W, W); }
        public readonly Vector4I6F26 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, X, X); }
        public readonly Vector4I6F26 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, X, Y); }
        public readonly Vector4I6F26 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, X, Z); }
        public readonly Vector4I6F26 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, X, W); }
        public readonly Vector4I6F26 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Y, X); }
        public readonly Vector4I6F26 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Y, Y); }
        public readonly Vector4I6F26 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Y, Z); }
        public readonly Vector4I6F26 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Y, W); }
        public readonly Vector4I6F26 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Z, X); }
        public readonly Vector4I6F26 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Z, Y); }
        public readonly Vector4I6F26 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Z, Z); }
        public readonly Vector4I6F26 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Z, W); }
        public readonly Vector4I6F26 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, W, X); }
        public readonly Vector4I6F26 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, W, Y); }
        public readonly Vector4I6F26 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, W, Z); }
        public readonly Vector4I6F26 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I6F26 lhs, Vector4I6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I6F26 lhs, Vector4I6F26 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I6F26({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I6F26 other)
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
            return $"Vector4I6F26({x}, {y}, {z}, {w})";
        }
    }
}
