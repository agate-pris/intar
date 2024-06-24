using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I15F17 : IEquatable<Vector4I15F17>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I15F17 X;
        public I15F17 Y;
        public I15F17 Z;
        public I15F17 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4I15F17 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(I15F17 x, I15F17 y, I15F17 z, I15F17 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(I15F17 x, I15F17 y, Vector2I15F17 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(I15F17 x, Vector3I15F17 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(Vector2I15F17 xy, Vector2I15F17 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(Vector4I15F17 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(I15F17 x, Vector2I15F17 yz, I15F17 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(Vector3I15F17 xyz, I15F17 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I15F17(Vector2I15F17 xy, I15F17 z, I15F17 w) : this(xy.X, xy.Y, z, w) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator +(Vector4I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator -(Vector4I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator *(Vector4I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator *(Vector4I15F17 a, I15F17 b) => new Vector4I15F17(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator *(I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator /(Vector4I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator /(Vector4I15F17 a, I15F17 b) => new Vector4I15F17(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 operator /(I15F17 a, Vector4I15F17 b) => new Vector4I15F17(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I15F17 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(X, X); }
        public readonly Vector2I15F17 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(X, Y); }
        public readonly Vector2I15F17 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(X, Z); }
        public readonly Vector2I15F17 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(X, W); }
        public readonly Vector2I15F17 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Y, X); }
        public readonly Vector2I15F17 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Y, Y); }
        public readonly Vector2I15F17 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Y, Z); }
        public readonly Vector2I15F17 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Y, W); }
        public readonly Vector2I15F17 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Z, X); }
        public readonly Vector2I15F17 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Z, Y); }
        public readonly Vector2I15F17 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Z, Z); }
        public readonly Vector2I15F17 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(Z, W); }
        public readonly Vector2I15F17 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(W, X); }
        public readonly Vector2I15F17 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(W, Y); }
        public readonly Vector2I15F17 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(W, Z); }
        public readonly Vector2I15F17 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(W, W); }
        public readonly Vector3I15F17 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, X, X); }
        public readonly Vector3I15F17 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, X, Y); }
        public readonly Vector3I15F17 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, X, Z); }
        public readonly Vector3I15F17 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, X, W); }
        public readonly Vector3I15F17 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Y, X); }
        public readonly Vector3I15F17 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Y, Y); }
        public readonly Vector3I15F17 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Y, Z); }
        public readonly Vector3I15F17 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Y, W); }
        public readonly Vector3I15F17 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Z, X); }
        public readonly Vector3I15F17 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Z, Y); }
        public readonly Vector3I15F17 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Z, Z); }
        public readonly Vector3I15F17 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, Z, W); }
        public readonly Vector3I15F17 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, W, X); }
        public readonly Vector3I15F17 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, W, Y); }
        public readonly Vector3I15F17 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, W, Z); }
        public readonly Vector3I15F17 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(X, W, W); }
        public readonly Vector3I15F17 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, X, X); }
        public readonly Vector3I15F17 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, X, Y); }
        public readonly Vector3I15F17 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, X, Z); }
        public readonly Vector3I15F17 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, X, W); }
        public readonly Vector3I15F17 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Y, X); }
        public readonly Vector3I15F17 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Y, Y); }
        public readonly Vector3I15F17 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Y, Z); }
        public readonly Vector3I15F17 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Y, W); }
        public readonly Vector3I15F17 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Z, X); }
        public readonly Vector3I15F17 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Z, Y); }
        public readonly Vector3I15F17 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Z, Z); }
        public readonly Vector3I15F17 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, Z, W); }
        public readonly Vector3I15F17 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, W, X); }
        public readonly Vector3I15F17 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, W, Y); }
        public readonly Vector3I15F17 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, W, Z); }
        public readonly Vector3I15F17 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Y, W, W); }
        public readonly Vector3I15F17 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, X, X); }
        public readonly Vector3I15F17 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, X, Y); }
        public readonly Vector3I15F17 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, X, Z); }
        public readonly Vector3I15F17 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, X, W); }
        public readonly Vector3I15F17 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Y, X); }
        public readonly Vector3I15F17 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Y, Y); }
        public readonly Vector3I15F17 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Y, Z); }
        public readonly Vector3I15F17 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Y, W); }
        public readonly Vector3I15F17 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Z, X); }
        public readonly Vector3I15F17 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Z, Y); }
        public readonly Vector3I15F17 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Z, Z); }
        public readonly Vector3I15F17 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, Z, W); }
        public readonly Vector3I15F17 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, W, X); }
        public readonly Vector3I15F17 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, W, Y); }
        public readonly Vector3I15F17 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, W, Z); }
        public readonly Vector3I15F17 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(Z, W, W); }
        public readonly Vector3I15F17 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, X, X); }
        public readonly Vector3I15F17 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, X, Y); }
        public readonly Vector3I15F17 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, X, Z); }
        public readonly Vector3I15F17 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, X, W); }
        public readonly Vector3I15F17 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, Y, X); }
        public readonly Vector3I15F17 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, Y, Y); }
        public readonly Vector3I15F17 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, Y, Z); }
        public readonly Vector3I15F17 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, Y, W); }
        public readonly Vector3I15F17 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, Z, X); }
        public readonly Vector3I15F17 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, Z, Y); }
        public readonly Vector3I15F17 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, Z, Z); }
        public readonly Vector3I15F17 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, Z, W); }
        public readonly Vector3I15F17 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, W, X); }
        public readonly Vector3I15F17 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, W, Y); }
        public readonly Vector3I15F17 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, W, Z); }
        public readonly Vector3I15F17 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(W, W, W); }
        public readonly Vector4I15F17 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, X, X); }
        public readonly Vector4I15F17 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, X, Y); }
        public readonly Vector4I15F17 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, X, Z); }
        public readonly Vector4I15F17 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, X, W); }
        public readonly Vector4I15F17 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Y, X); }
        public readonly Vector4I15F17 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Y, Y); }
        public readonly Vector4I15F17 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Y, Z); }
        public readonly Vector4I15F17 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Y, W); }
        public readonly Vector4I15F17 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Z, X); }
        public readonly Vector4I15F17 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Z, Y); }
        public readonly Vector4I15F17 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Z, Z); }
        public readonly Vector4I15F17 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, Z, W); }
        public readonly Vector4I15F17 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, W, X); }
        public readonly Vector4I15F17 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, W, Y); }
        public readonly Vector4I15F17 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, W, Z); }
        public readonly Vector4I15F17 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, X, W, W); }
        public readonly Vector4I15F17 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, X, X); }
        public readonly Vector4I15F17 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, X, Y); }
        public readonly Vector4I15F17 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, X, Z); }
        public readonly Vector4I15F17 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, X, W); }
        public readonly Vector4I15F17 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Y, X); }
        public readonly Vector4I15F17 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Y, Y); }
        public readonly Vector4I15F17 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Y, Z); }
        public readonly Vector4I15F17 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Y, W); }
        public readonly Vector4I15F17 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Z, X); }
        public readonly Vector4I15F17 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Z, Y); }
        public readonly Vector4I15F17 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Z, Z); }
        public readonly Vector4I15F17 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, Z, W); }
        public readonly Vector4I15F17 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, W, X); }
        public readonly Vector4I15F17 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, W, Y); }
        public readonly Vector4I15F17 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, W, Z); }
        public readonly Vector4I15F17 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Y, W, W); }
        public readonly Vector4I15F17 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, X, X); }
        public readonly Vector4I15F17 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, X, Y); }
        public readonly Vector4I15F17 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, X, Z); }
        public readonly Vector4I15F17 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, X, W); }
        public readonly Vector4I15F17 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Y, X); }
        public readonly Vector4I15F17 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Y, Y); }
        public readonly Vector4I15F17 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Y, Z); }
        public readonly Vector4I15F17 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Y, W); }
        public readonly Vector4I15F17 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Z, X); }
        public readonly Vector4I15F17 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Z, Y); }
        public readonly Vector4I15F17 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Z, Z); }
        public readonly Vector4I15F17 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, Z, W); }
        public readonly Vector4I15F17 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, W, X); }
        public readonly Vector4I15F17 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, W, Y); }
        public readonly Vector4I15F17 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, W, Z); }
        public readonly Vector4I15F17 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, Z, W, W); }
        public readonly Vector4I15F17 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, X, X); }
        public readonly Vector4I15F17 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, X, Y); }
        public readonly Vector4I15F17 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, X, Z); }
        public readonly Vector4I15F17 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, X, W); }
        public readonly Vector4I15F17 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, Y, X); }
        public readonly Vector4I15F17 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, Y, Y); }
        public readonly Vector4I15F17 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, Y, Z); }
        public readonly Vector4I15F17 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, Y, W); }
        public readonly Vector4I15F17 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, Z, X); }
        public readonly Vector4I15F17 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, Z, Y); }
        public readonly Vector4I15F17 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, Z, Z); }
        public readonly Vector4I15F17 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, Z, W); }
        public readonly Vector4I15F17 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, W, X); }
        public readonly Vector4I15F17 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, W, Y); }
        public readonly Vector4I15F17 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, W, Z); }
        public readonly Vector4I15F17 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(X, W, W, W); }
        public readonly Vector4I15F17 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, X, X); }
        public readonly Vector4I15F17 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, X, Y); }
        public readonly Vector4I15F17 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, X, Z); }
        public readonly Vector4I15F17 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, X, W); }
        public readonly Vector4I15F17 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Y, X); }
        public readonly Vector4I15F17 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Y, Y); }
        public readonly Vector4I15F17 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Y, Z); }
        public readonly Vector4I15F17 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Y, W); }
        public readonly Vector4I15F17 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Z, X); }
        public readonly Vector4I15F17 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Z, Y); }
        public readonly Vector4I15F17 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Z, Z); }
        public readonly Vector4I15F17 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, Z, W); }
        public readonly Vector4I15F17 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, W, X); }
        public readonly Vector4I15F17 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, W, Y); }
        public readonly Vector4I15F17 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, W, Z); }
        public readonly Vector4I15F17 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, X, W, W); }
        public readonly Vector4I15F17 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, X, X); }
        public readonly Vector4I15F17 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, X, Y); }
        public readonly Vector4I15F17 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, X, Z); }
        public readonly Vector4I15F17 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, X, W); }
        public readonly Vector4I15F17 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Y, X); }
        public readonly Vector4I15F17 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Y, Y); }
        public readonly Vector4I15F17 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Y, Z); }
        public readonly Vector4I15F17 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Y, W); }
        public readonly Vector4I15F17 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Z, X); }
        public readonly Vector4I15F17 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Z, Y); }
        public readonly Vector4I15F17 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Z, Z); }
        public readonly Vector4I15F17 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, Z, W); }
        public readonly Vector4I15F17 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, W, X); }
        public readonly Vector4I15F17 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, W, Y); }
        public readonly Vector4I15F17 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, W, Z); }
        public readonly Vector4I15F17 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Y, W, W); }
        public readonly Vector4I15F17 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, X, X); }
        public readonly Vector4I15F17 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, X, Y); }
        public readonly Vector4I15F17 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, X, Z); }
        public readonly Vector4I15F17 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, X, W); }
        public readonly Vector4I15F17 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Y, X); }
        public readonly Vector4I15F17 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Y, Y); }
        public readonly Vector4I15F17 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Y, Z); }
        public readonly Vector4I15F17 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Y, W); }
        public readonly Vector4I15F17 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Z, X); }
        public readonly Vector4I15F17 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Z, Y); }
        public readonly Vector4I15F17 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Z, Z); }
        public readonly Vector4I15F17 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, Z, W); }
        public readonly Vector4I15F17 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, W, X); }
        public readonly Vector4I15F17 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, W, Y); }
        public readonly Vector4I15F17 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, W, Z); }
        public readonly Vector4I15F17 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, Z, W, W); }
        public readonly Vector4I15F17 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, X, X); }
        public readonly Vector4I15F17 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, X, Y); }
        public readonly Vector4I15F17 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, X, Z); }
        public readonly Vector4I15F17 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, X, W); }
        public readonly Vector4I15F17 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, Y, X); }
        public readonly Vector4I15F17 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, Y, Y); }
        public readonly Vector4I15F17 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, Y, Z); }
        public readonly Vector4I15F17 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, Y, W); }
        public readonly Vector4I15F17 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, Z, X); }
        public readonly Vector4I15F17 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, Z, Y); }
        public readonly Vector4I15F17 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, Z, Z); }
        public readonly Vector4I15F17 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, Z, W); }
        public readonly Vector4I15F17 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, W, X); }
        public readonly Vector4I15F17 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, W, Y); }
        public readonly Vector4I15F17 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, W, Z); }
        public readonly Vector4I15F17 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Y, W, W, W); }
        public readonly Vector4I15F17 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, X, X); }
        public readonly Vector4I15F17 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, X, Y); }
        public readonly Vector4I15F17 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, X, Z); }
        public readonly Vector4I15F17 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, X, W); }
        public readonly Vector4I15F17 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Y, X); }
        public readonly Vector4I15F17 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Y, Y); }
        public readonly Vector4I15F17 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Y, Z); }
        public readonly Vector4I15F17 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Y, W); }
        public readonly Vector4I15F17 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Z, X); }
        public readonly Vector4I15F17 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Z, Y); }
        public readonly Vector4I15F17 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Z, Z); }
        public readonly Vector4I15F17 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, Z, W); }
        public readonly Vector4I15F17 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, W, X); }
        public readonly Vector4I15F17 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, W, Y); }
        public readonly Vector4I15F17 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, W, Z); }
        public readonly Vector4I15F17 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, X, W, W); }
        public readonly Vector4I15F17 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, X, X); }
        public readonly Vector4I15F17 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, X, Y); }
        public readonly Vector4I15F17 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, X, Z); }
        public readonly Vector4I15F17 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, X, W); }
        public readonly Vector4I15F17 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Y, X); }
        public readonly Vector4I15F17 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Y, Y); }
        public readonly Vector4I15F17 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Y, Z); }
        public readonly Vector4I15F17 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Y, W); }
        public readonly Vector4I15F17 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Z, X); }
        public readonly Vector4I15F17 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Z, Y); }
        public readonly Vector4I15F17 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Z, Z); }
        public readonly Vector4I15F17 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, Z, W); }
        public readonly Vector4I15F17 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, W, X); }
        public readonly Vector4I15F17 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, W, Y); }
        public readonly Vector4I15F17 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, W, Z); }
        public readonly Vector4I15F17 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Y, W, W); }
        public readonly Vector4I15F17 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, X, X); }
        public readonly Vector4I15F17 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, X, Y); }
        public readonly Vector4I15F17 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, X, Z); }
        public readonly Vector4I15F17 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, X, W); }
        public readonly Vector4I15F17 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Y, X); }
        public readonly Vector4I15F17 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Y, Y); }
        public readonly Vector4I15F17 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Y, Z); }
        public readonly Vector4I15F17 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Y, W); }
        public readonly Vector4I15F17 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Z, X); }
        public readonly Vector4I15F17 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Z, Y); }
        public readonly Vector4I15F17 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Z, Z); }
        public readonly Vector4I15F17 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, Z, W); }
        public readonly Vector4I15F17 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, W, X); }
        public readonly Vector4I15F17 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, W, Y); }
        public readonly Vector4I15F17 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, W, Z); }
        public readonly Vector4I15F17 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, Z, W, W); }
        public readonly Vector4I15F17 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, X, X); }
        public readonly Vector4I15F17 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, X, Y); }
        public readonly Vector4I15F17 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, X, Z); }
        public readonly Vector4I15F17 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, X, W); }
        public readonly Vector4I15F17 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, Y, X); }
        public readonly Vector4I15F17 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, Y, Y); }
        public readonly Vector4I15F17 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, Y, Z); }
        public readonly Vector4I15F17 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, Y, W); }
        public readonly Vector4I15F17 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, Z, X); }
        public readonly Vector4I15F17 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, Z, Y); }
        public readonly Vector4I15F17 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, Z, Z); }
        public readonly Vector4I15F17 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, Z, W); }
        public readonly Vector4I15F17 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, W, X); }
        public readonly Vector4I15F17 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, W, Y); }
        public readonly Vector4I15F17 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, W, Z); }
        public readonly Vector4I15F17 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(Z, W, W, W); }
        public readonly Vector4I15F17 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, X, X); }
        public readonly Vector4I15F17 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, X, Y); }
        public readonly Vector4I15F17 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, X, Z); }
        public readonly Vector4I15F17 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, X, W); }
        public readonly Vector4I15F17 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, Y, X); }
        public readonly Vector4I15F17 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, Y, Y); }
        public readonly Vector4I15F17 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, Y, Z); }
        public readonly Vector4I15F17 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, Y, W); }
        public readonly Vector4I15F17 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, Z, X); }
        public readonly Vector4I15F17 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, Z, Y); }
        public readonly Vector4I15F17 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, Z, Z); }
        public readonly Vector4I15F17 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, Z, W); }
        public readonly Vector4I15F17 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, W, X); }
        public readonly Vector4I15F17 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, W, Y); }
        public readonly Vector4I15F17 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, W, Z); }
        public readonly Vector4I15F17 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, X, W, W); }
        public readonly Vector4I15F17 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, X, X); }
        public readonly Vector4I15F17 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, X, Y); }
        public readonly Vector4I15F17 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, X, Z); }
        public readonly Vector4I15F17 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, X, W); }
        public readonly Vector4I15F17 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, Y, X); }
        public readonly Vector4I15F17 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, Y, Y); }
        public readonly Vector4I15F17 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, Y, Z); }
        public readonly Vector4I15F17 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, Y, W); }
        public readonly Vector4I15F17 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, Z, X); }
        public readonly Vector4I15F17 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, Z, Y); }
        public readonly Vector4I15F17 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, Z, Z); }
        public readonly Vector4I15F17 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, Z, W); }
        public readonly Vector4I15F17 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, W, X); }
        public readonly Vector4I15F17 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, W, Y); }
        public readonly Vector4I15F17 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, W, Z); }
        public readonly Vector4I15F17 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Y, W, W); }
        public readonly Vector4I15F17 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, X, X); }
        public readonly Vector4I15F17 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, X, Y); }
        public readonly Vector4I15F17 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, X, Z); }
        public readonly Vector4I15F17 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, X, W); }
        public readonly Vector4I15F17 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, Y, X); }
        public readonly Vector4I15F17 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, Y, Y); }
        public readonly Vector4I15F17 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, Y, Z); }
        public readonly Vector4I15F17 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, Y, W); }
        public readonly Vector4I15F17 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, Z, X); }
        public readonly Vector4I15F17 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, Z, Y); }
        public readonly Vector4I15F17 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, Z, Z); }
        public readonly Vector4I15F17 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, Z, W); }
        public readonly Vector4I15F17 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, W, X); }
        public readonly Vector4I15F17 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, W, Y); }
        public readonly Vector4I15F17 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, W, Z); }
        public readonly Vector4I15F17 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, Z, W, W); }
        public readonly Vector4I15F17 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, X, X); }
        public readonly Vector4I15F17 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, X, Y); }
        public readonly Vector4I15F17 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, X, Z); }
        public readonly Vector4I15F17 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, X, W); }
        public readonly Vector4I15F17 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, Y, X); }
        public readonly Vector4I15F17 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, Y, Y); }
        public readonly Vector4I15F17 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, Y, Z); }
        public readonly Vector4I15F17 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, Y, W); }
        public readonly Vector4I15F17 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, Z, X); }
        public readonly Vector4I15F17 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, Z, Y); }
        public readonly Vector4I15F17 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, Z, Z); }
        public readonly Vector4I15F17 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, Z, W); }
        public readonly Vector4I15F17 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, W, X); }
        public readonly Vector4I15F17 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, W, Y); }
        public readonly Vector4I15F17 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, W, Z); }
        public readonly Vector4I15F17 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I15F17 lhs, Vector4I15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I15F17 lhs, Vector4I15F17 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I15F17({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I15F17 other)
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
            return $"Vector4I15F17({x}, {y}, {z}, {w})";
        }
    }
}
