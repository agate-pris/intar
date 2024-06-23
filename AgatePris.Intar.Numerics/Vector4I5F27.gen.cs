using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I5F27 : IEquatable<Vector4I5F27>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I5F27 X;
        public I5F27 Y;
        public I5F27 Z;
        public I5F27 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4I5F27 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, I5F27 y, I5F27 z, I5F27 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, I5F27 y, Vector2I5F27 zw) {
            X = x;
            Y = y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, Vector3I5F27 yzw) {
            X = x;
            Y = yzw.X;
            Z = yzw.Y;
            W = yzw.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector2I5F27 xy, Vector2I5F27 zw) {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector4I5F27 xyzw) {
            X = xyzw.X;
            Y = xyzw.Y;
            Z = xyzw.Z;
            W = xyzw.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, Vector2I5F27 yz, I5F27 w) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector3I5F27 xyz, I5F27 w) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector2I5F27 xy, I5F27 z, I5F27 w) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator +(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator -(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator *(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator *(Vector4I5F27 a, I5F27 b) => new Vector4I5F27(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator *(I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator /(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator /(Vector4I5F27 a, I5F27 b) => new Vector4I5F27(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator /(I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I5F27 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, X); }
        public readonly Vector2I5F27 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, Y); }
        public readonly Vector2I5F27 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, Z); }
        public readonly Vector2I5F27 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, W); }
        public readonly Vector2I5F27 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, X); }
        public readonly Vector2I5F27 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, Y); }
        public readonly Vector2I5F27 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, Z); }
        public readonly Vector2I5F27 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, W); }
        public readonly Vector2I5F27 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, X); }
        public readonly Vector2I5F27 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, Y); }
        public readonly Vector2I5F27 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, Z); }
        public readonly Vector2I5F27 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, W); }
        public readonly Vector2I5F27 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(W, X); }
        public readonly Vector2I5F27 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(W, Y); }
        public readonly Vector2I5F27 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(W, Z); }
        public readonly Vector2I5F27 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(W, W); }
        public readonly Vector3I5F27 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, X); }
        public readonly Vector3I5F27 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, Y); }
        public readonly Vector3I5F27 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, Z); }
        public readonly Vector3I5F27 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, W); }
        public readonly Vector3I5F27 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, X); }
        public readonly Vector3I5F27 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, Y); }
        public readonly Vector3I5F27 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, Z); }
        public readonly Vector3I5F27 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, W); }
        public readonly Vector3I5F27 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, X); }
        public readonly Vector3I5F27 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, Y); }
        public readonly Vector3I5F27 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, Z); }
        public readonly Vector3I5F27 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, W); }
        public readonly Vector3I5F27 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, W, X); }
        public readonly Vector3I5F27 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, W, Y); }
        public readonly Vector3I5F27 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, W, Z); }
        public readonly Vector3I5F27 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, W, W); }
        public readonly Vector3I5F27 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, X); }
        public readonly Vector3I5F27 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, Y); }
        public readonly Vector3I5F27 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, Z); }
        public readonly Vector3I5F27 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, W); }
        public readonly Vector3I5F27 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, X); }
        public readonly Vector3I5F27 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, Y); }
        public readonly Vector3I5F27 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, Z); }
        public readonly Vector3I5F27 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, W); }
        public readonly Vector3I5F27 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, X); }
        public readonly Vector3I5F27 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, Y); }
        public readonly Vector3I5F27 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, Z); }
        public readonly Vector3I5F27 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, W); }
        public readonly Vector3I5F27 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, W, X); }
        public readonly Vector3I5F27 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, W, Y); }
        public readonly Vector3I5F27 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, W, Z); }
        public readonly Vector3I5F27 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, W, W); }
        public readonly Vector3I5F27 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, X); }
        public readonly Vector3I5F27 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, Y); }
        public readonly Vector3I5F27 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, Z); }
        public readonly Vector3I5F27 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, W); }
        public readonly Vector3I5F27 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, X); }
        public readonly Vector3I5F27 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, Y); }
        public readonly Vector3I5F27 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, Z); }
        public readonly Vector3I5F27 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, W); }
        public readonly Vector3I5F27 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, X); }
        public readonly Vector3I5F27 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, Y); }
        public readonly Vector3I5F27 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, Z); }
        public readonly Vector3I5F27 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, W); }
        public readonly Vector3I5F27 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, W, X); }
        public readonly Vector3I5F27 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, W, Y); }
        public readonly Vector3I5F27 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, W, Z); }
        public readonly Vector3I5F27 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, W, W); }
        public readonly Vector3I5F27 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, X, X); }
        public readonly Vector3I5F27 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, X, Y); }
        public readonly Vector3I5F27 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, X, Z); }
        public readonly Vector3I5F27 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, X, W); }
        public readonly Vector3I5F27 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Y, X); }
        public readonly Vector3I5F27 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Y, Y); }
        public readonly Vector3I5F27 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Y, Z); }
        public readonly Vector3I5F27 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Y, W); }
        public readonly Vector3I5F27 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Z, X); }
        public readonly Vector3I5F27 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Z, Y); }
        public readonly Vector3I5F27 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Z, Z); }
        public readonly Vector3I5F27 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Z, W); }
        public readonly Vector3I5F27 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, W, X); }
        public readonly Vector3I5F27 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, W, Y); }
        public readonly Vector3I5F27 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, W, Z); }
        public readonly Vector3I5F27 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, W, W); }
        public readonly Vector4I5F27 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, X); }
        public readonly Vector4I5F27 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, Y); }
        public readonly Vector4I5F27 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, Z); }
        public readonly Vector4I5F27 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, W); }
        public readonly Vector4I5F27 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, X); }
        public readonly Vector4I5F27 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, Y); }
        public readonly Vector4I5F27 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, Z); }
        public readonly Vector4I5F27 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, W); }
        public readonly Vector4I5F27 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, X); }
        public readonly Vector4I5F27 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, Y); }
        public readonly Vector4I5F27 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, Z); }
        public readonly Vector4I5F27 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, W); }
        public readonly Vector4I5F27 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, W, X); }
        public readonly Vector4I5F27 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, W, Y); }
        public readonly Vector4I5F27 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, W, Z); }
        public readonly Vector4I5F27 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, W, W); }
        public readonly Vector4I5F27 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, X); }
        public readonly Vector4I5F27 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, Y); }
        public readonly Vector4I5F27 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, Z); }
        public readonly Vector4I5F27 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, W); }
        public readonly Vector4I5F27 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, X); }
        public readonly Vector4I5F27 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, Y); }
        public readonly Vector4I5F27 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, Z); }
        public readonly Vector4I5F27 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, W); }
        public readonly Vector4I5F27 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, X); }
        public readonly Vector4I5F27 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, Y); }
        public readonly Vector4I5F27 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, Z); }
        public readonly Vector4I5F27 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, W); }
        public readonly Vector4I5F27 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, W, X); }
        public readonly Vector4I5F27 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, W, Y); }
        public readonly Vector4I5F27 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, W, Z); }
        public readonly Vector4I5F27 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, W, W); }
        public readonly Vector4I5F27 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, X); }
        public readonly Vector4I5F27 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, Y); }
        public readonly Vector4I5F27 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, Z); }
        public readonly Vector4I5F27 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, W); }
        public readonly Vector4I5F27 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, X); }
        public readonly Vector4I5F27 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, Y); }
        public readonly Vector4I5F27 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, Z); }
        public readonly Vector4I5F27 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, W); }
        public readonly Vector4I5F27 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, X); }
        public readonly Vector4I5F27 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, Y); }
        public readonly Vector4I5F27 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, Z); }
        public readonly Vector4I5F27 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, W); }
        public readonly Vector4I5F27 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, W, X); }
        public readonly Vector4I5F27 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, W, Y); }
        public readonly Vector4I5F27 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, W, Z); }
        public readonly Vector4I5F27 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, W, W); }
        public readonly Vector4I5F27 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, X, X); }
        public readonly Vector4I5F27 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, X, Y); }
        public readonly Vector4I5F27 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, X, Z); }
        public readonly Vector4I5F27 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, X, W); }
        public readonly Vector4I5F27 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Y, X); }
        public readonly Vector4I5F27 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Y, Y); }
        public readonly Vector4I5F27 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Y, Z); }
        public readonly Vector4I5F27 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Y, W); }
        public readonly Vector4I5F27 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Z, X); }
        public readonly Vector4I5F27 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Z, Y); }
        public readonly Vector4I5F27 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Z, Z); }
        public readonly Vector4I5F27 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Z, W); }
        public readonly Vector4I5F27 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, W, X); }
        public readonly Vector4I5F27 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, W, Y); }
        public readonly Vector4I5F27 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, W, Z); }
        public readonly Vector4I5F27 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, W, W); }
        public readonly Vector4I5F27 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, X); }
        public readonly Vector4I5F27 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, Y); }
        public readonly Vector4I5F27 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, Z); }
        public readonly Vector4I5F27 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, W); }
        public readonly Vector4I5F27 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, X); }
        public readonly Vector4I5F27 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, Y); }
        public readonly Vector4I5F27 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, Z); }
        public readonly Vector4I5F27 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, W); }
        public readonly Vector4I5F27 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, X); }
        public readonly Vector4I5F27 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, Y); }
        public readonly Vector4I5F27 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, Z); }
        public readonly Vector4I5F27 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, W); }
        public readonly Vector4I5F27 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, W, X); }
        public readonly Vector4I5F27 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, W, Y); }
        public readonly Vector4I5F27 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, W, Z); }
        public readonly Vector4I5F27 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, W, W); }
        public readonly Vector4I5F27 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, X); }
        public readonly Vector4I5F27 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, Y); }
        public readonly Vector4I5F27 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, Z); }
        public readonly Vector4I5F27 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, W); }
        public readonly Vector4I5F27 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, X); }
        public readonly Vector4I5F27 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, Y); }
        public readonly Vector4I5F27 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, Z); }
        public readonly Vector4I5F27 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, W); }
        public readonly Vector4I5F27 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, X); }
        public readonly Vector4I5F27 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, Y); }
        public readonly Vector4I5F27 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, Z); }
        public readonly Vector4I5F27 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, W); }
        public readonly Vector4I5F27 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, W, X); }
        public readonly Vector4I5F27 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, W, Y); }
        public readonly Vector4I5F27 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, W, Z); }
        public readonly Vector4I5F27 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, W, W); }
        public readonly Vector4I5F27 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, X); }
        public readonly Vector4I5F27 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, Y); }
        public readonly Vector4I5F27 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, Z); }
        public readonly Vector4I5F27 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, W); }
        public readonly Vector4I5F27 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, X); }
        public readonly Vector4I5F27 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, Y); }
        public readonly Vector4I5F27 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, Z); }
        public readonly Vector4I5F27 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, W); }
        public readonly Vector4I5F27 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, X); }
        public readonly Vector4I5F27 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, Y); }
        public readonly Vector4I5F27 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, Z); }
        public readonly Vector4I5F27 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, W); }
        public readonly Vector4I5F27 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, W, X); }
        public readonly Vector4I5F27 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, W, Y); }
        public readonly Vector4I5F27 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, W, Z); }
        public readonly Vector4I5F27 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, W, W); }
        public readonly Vector4I5F27 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, X, X); }
        public readonly Vector4I5F27 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, X, Y); }
        public readonly Vector4I5F27 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, X, Z); }
        public readonly Vector4I5F27 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, X, W); }
        public readonly Vector4I5F27 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Y, X); }
        public readonly Vector4I5F27 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Y, Y); }
        public readonly Vector4I5F27 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Y, Z); }
        public readonly Vector4I5F27 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Y, W); }
        public readonly Vector4I5F27 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Z, X); }
        public readonly Vector4I5F27 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Z, Y); }
        public readonly Vector4I5F27 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Z, Z); }
        public readonly Vector4I5F27 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Z, W); }
        public readonly Vector4I5F27 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, W, X); }
        public readonly Vector4I5F27 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, W, Y); }
        public readonly Vector4I5F27 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, W, Z); }
        public readonly Vector4I5F27 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, W, W); }
        public readonly Vector4I5F27 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, X); }
        public readonly Vector4I5F27 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, Y); }
        public readonly Vector4I5F27 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, Z); }
        public readonly Vector4I5F27 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, W); }
        public readonly Vector4I5F27 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, X); }
        public readonly Vector4I5F27 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, Y); }
        public readonly Vector4I5F27 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, Z); }
        public readonly Vector4I5F27 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, W); }
        public readonly Vector4I5F27 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, X); }
        public readonly Vector4I5F27 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, Y); }
        public readonly Vector4I5F27 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, Z); }
        public readonly Vector4I5F27 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, W); }
        public readonly Vector4I5F27 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, W, X); }
        public readonly Vector4I5F27 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, W, Y); }
        public readonly Vector4I5F27 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, W, Z); }
        public readonly Vector4I5F27 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, W, W); }
        public readonly Vector4I5F27 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, X); }
        public readonly Vector4I5F27 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, Y); }
        public readonly Vector4I5F27 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, Z); }
        public readonly Vector4I5F27 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, W); }
        public readonly Vector4I5F27 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, X); }
        public readonly Vector4I5F27 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, Y); }
        public readonly Vector4I5F27 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, Z); }
        public readonly Vector4I5F27 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, W); }
        public readonly Vector4I5F27 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, X); }
        public readonly Vector4I5F27 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, Y); }
        public readonly Vector4I5F27 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, Z); }
        public readonly Vector4I5F27 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, W); }
        public readonly Vector4I5F27 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, W, X); }
        public readonly Vector4I5F27 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, W, Y); }
        public readonly Vector4I5F27 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, W, Z); }
        public readonly Vector4I5F27 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, W, W); }
        public readonly Vector4I5F27 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, X); }
        public readonly Vector4I5F27 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, Y); }
        public readonly Vector4I5F27 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, Z); }
        public readonly Vector4I5F27 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, W); }
        public readonly Vector4I5F27 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, X); }
        public readonly Vector4I5F27 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, Y); }
        public readonly Vector4I5F27 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, Z); }
        public readonly Vector4I5F27 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, W); }
        public readonly Vector4I5F27 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, X); }
        public readonly Vector4I5F27 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, Y); }
        public readonly Vector4I5F27 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, Z); }
        public readonly Vector4I5F27 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, W); }
        public readonly Vector4I5F27 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, W, X); }
        public readonly Vector4I5F27 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, W, Y); }
        public readonly Vector4I5F27 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, W, Z); }
        public readonly Vector4I5F27 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, W, W); }
        public readonly Vector4I5F27 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, X, X); }
        public readonly Vector4I5F27 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, X, Y); }
        public readonly Vector4I5F27 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, X, Z); }
        public readonly Vector4I5F27 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, X, W); }
        public readonly Vector4I5F27 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Y, X); }
        public readonly Vector4I5F27 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Y, Y); }
        public readonly Vector4I5F27 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Y, Z); }
        public readonly Vector4I5F27 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Y, W); }
        public readonly Vector4I5F27 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Z, X); }
        public readonly Vector4I5F27 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Z, Y); }
        public readonly Vector4I5F27 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Z, Z); }
        public readonly Vector4I5F27 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Z, W); }
        public readonly Vector4I5F27 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, W, X); }
        public readonly Vector4I5F27 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, W, Y); }
        public readonly Vector4I5F27 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, W, Z); }
        public readonly Vector4I5F27 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, W, W); }
        public readonly Vector4I5F27 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, X, X); }
        public readonly Vector4I5F27 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, X, Y); }
        public readonly Vector4I5F27 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, X, Z); }
        public readonly Vector4I5F27 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, X, W); }
        public readonly Vector4I5F27 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Y, X); }
        public readonly Vector4I5F27 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Y, Y); }
        public readonly Vector4I5F27 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Y, Z); }
        public readonly Vector4I5F27 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Y, W); }
        public readonly Vector4I5F27 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Z, X); }
        public readonly Vector4I5F27 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Z, Y); }
        public readonly Vector4I5F27 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Z, Z); }
        public readonly Vector4I5F27 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Z, W); }
        public readonly Vector4I5F27 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, W, X); }
        public readonly Vector4I5F27 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, W, Y); }
        public readonly Vector4I5F27 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, W, Z); }
        public readonly Vector4I5F27 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, W, W); }
        public readonly Vector4I5F27 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, X, X); }
        public readonly Vector4I5F27 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, X, Y); }
        public readonly Vector4I5F27 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, X, Z); }
        public readonly Vector4I5F27 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, X, W); }
        public readonly Vector4I5F27 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Y, X); }
        public readonly Vector4I5F27 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Y, Y); }
        public readonly Vector4I5F27 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Y, Z); }
        public readonly Vector4I5F27 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Y, W); }
        public readonly Vector4I5F27 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Z, X); }
        public readonly Vector4I5F27 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Z, Y); }
        public readonly Vector4I5F27 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Z, Z); }
        public readonly Vector4I5F27 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Z, W); }
        public readonly Vector4I5F27 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, W, X); }
        public readonly Vector4I5F27 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, W, Y); }
        public readonly Vector4I5F27 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, W, Z); }
        public readonly Vector4I5F27 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, W, W); }
        public readonly Vector4I5F27 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, X, X); }
        public readonly Vector4I5F27 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, X, Y); }
        public readonly Vector4I5F27 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, X, Z); }
        public readonly Vector4I5F27 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, X, W); }
        public readonly Vector4I5F27 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Y, X); }
        public readonly Vector4I5F27 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Y, Y); }
        public readonly Vector4I5F27 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Y, Z); }
        public readonly Vector4I5F27 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Y, W); }
        public readonly Vector4I5F27 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Z, X); }
        public readonly Vector4I5F27 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Z, Y); }
        public readonly Vector4I5F27 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Z, Z); }
        public readonly Vector4I5F27 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Z, W); }
        public readonly Vector4I5F27 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, W, X); }
        public readonly Vector4I5F27 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, W, Y); }
        public readonly Vector4I5F27 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, W, Z); }
        public readonly Vector4I5F27 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, W, W); }
        public readonly Vector4I5F27 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, X, X); }
        public readonly Vector4I5F27 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, X, Y); }
        public readonly Vector4I5F27 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, X, Z); }
        public readonly Vector4I5F27 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, X, W); }
        public readonly Vector4I5F27 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Y, X); }
        public readonly Vector4I5F27 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Y, Y); }
        public readonly Vector4I5F27 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Y, Z); }
        public readonly Vector4I5F27 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Y, W); }
        public readonly Vector4I5F27 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Z, X); }
        public readonly Vector4I5F27 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Z, Y); }
        public readonly Vector4I5F27 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Z, Z); }
        public readonly Vector4I5F27 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Z, W); }
        public readonly Vector4I5F27 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, W, X); }
        public readonly Vector4I5F27 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, W, Y); }
        public readonly Vector4I5F27 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, W, Z); }
        public readonly Vector4I5F27 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I5F27 lhs, Vector4I5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I5F27 lhs, Vector4I5F27 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I5F27({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I5F27 other)
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
            return $"Vector4I5F27({x}, {y}, {z}, {w})";
        }
    }
}
