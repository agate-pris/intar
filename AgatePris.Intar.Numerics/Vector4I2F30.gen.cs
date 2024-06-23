using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I2F30 : IEquatable<Vector4I2F30>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I2F30 X;
        public I2F30 Y;
        public I2F30 Z;
        public I2F30 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4I2F30 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 x, I2F30 y, I2F30 z, I2F30 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 x, I2F30 y, Vector2I2F30 zw) {
            X = x;
            Y = y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 x, Vector3I2F30 yzw) {
            X = x;
            Y = yzw.X;
            Z = yzw.Y;
            W = yzw.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(Vector2I2F30 xy, Vector2I2F30 zw) {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(Vector4I2F30 xyzw) {
            X = xyzw.X;
            Y = xyzw.Y;
            Z = xyzw.Z;
            W = xyzw.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 x, Vector2I2F30 yz, I2F30 w) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(Vector3I2F30 xyz, I2F30 w) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(Vector2I2F30 xy, I2F30 z, I2F30 w) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator +(Vector4I2F30 a, Vector4I2F30 b) => new Vector4I2F30(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator -(Vector4I2F30 a, Vector4I2F30 b) => new Vector4I2F30(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator *(Vector4I2F30 a, Vector4I2F30 b) => new Vector4I2F30(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator *(Vector4I2F30 a, I2F30 b) => new Vector4I2F30(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator *(I2F30 a, Vector4I2F30 b) => new Vector4I2F30(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator /(Vector4I2F30 a, Vector4I2F30 b) => new Vector4I2F30(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator /(Vector4I2F30 a, I2F30 b) => new Vector4I2F30(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator /(I2F30 a, Vector4I2F30 b) => new Vector4I2F30(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I2F30 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, X); }
        public readonly Vector2I2F30 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, Y); }
        public readonly Vector2I2F30 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, Z); }
        public readonly Vector2I2F30 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, W); }
        public readonly Vector2I2F30 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, X); }
        public readonly Vector2I2F30 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, Y); }
        public readonly Vector2I2F30 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, Z); }
        public readonly Vector2I2F30 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, W); }
        public readonly Vector2I2F30 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, X); }
        public readonly Vector2I2F30 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, Y); }
        public readonly Vector2I2F30 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, Z); }
        public readonly Vector2I2F30 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, W); }
        public readonly Vector2I2F30 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(W, X); }
        public readonly Vector2I2F30 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(W, Y); }
        public readonly Vector2I2F30 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(W, Z); }
        public readonly Vector2I2F30 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(W, W); }
        public readonly Vector3I2F30 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, X); }
        public readonly Vector3I2F30 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, Y); }
        public readonly Vector3I2F30 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, Z); }
        public readonly Vector3I2F30 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, W); }
        public readonly Vector3I2F30 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, X); }
        public readonly Vector3I2F30 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, Y); }
        public readonly Vector3I2F30 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, Z); }
        public readonly Vector3I2F30 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, W); }
        public readonly Vector3I2F30 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, X); }
        public readonly Vector3I2F30 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, Y); }
        public readonly Vector3I2F30 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, Z); }
        public readonly Vector3I2F30 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, W); }
        public readonly Vector3I2F30 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, W, X); }
        public readonly Vector3I2F30 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, W, Y); }
        public readonly Vector3I2F30 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, W, Z); }
        public readonly Vector3I2F30 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, W, W); }
        public readonly Vector3I2F30 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, X); }
        public readonly Vector3I2F30 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, Y); }
        public readonly Vector3I2F30 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, Z); }
        public readonly Vector3I2F30 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, W); }
        public readonly Vector3I2F30 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, X); }
        public readonly Vector3I2F30 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, Y); }
        public readonly Vector3I2F30 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, Z); }
        public readonly Vector3I2F30 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, W); }
        public readonly Vector3I2F30 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, X); }
        public readonly Vector3I2F30 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, Y); }
        public readonly Vector3I2F30 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, Z); }
        public readonly Vector3I2F30 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, W); }
        public readonly Vector3I2F30 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, W, X); }
        public readonly Vector3I2F30 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, W, Y); }
        public readonly Vector3I2F30 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, W, Z); }
        public readonly Vector3I2F30 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, W, W); }
        public readonly Vector3I2F30 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, X); }
        public readonly Vector3I2F30 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, Y); }
        public readonly Vector3I2F30 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, Z); }
        public readonly Vector3I2F30 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, W); }
        public readonly Vector3I2F30 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, X); }
        public readonly Vector3I2F30 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, Y); }
        public readonly Vector3I2F30 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, Z); }
        public readonly Vector3I2F30 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, W); }
        public readonly Vector3I2F30 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, X); }
        public readonly Vector3I2F30 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, Y); }
        public readonly Vector3I2F30 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, Z); }
        public readonly Vector3I2F30 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, W); }
        public readonly Vector3I2F30 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, W, X); }
        public readonly Vector3I2F30 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, W, Y); }
        public readonly Vector3I2F30 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, W, Z); }
        public readonly Vector3I2F30 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, W, W); }
        public readonly Vector3I2F30 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, X, X); }
        public readonly Vector3I2F30 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, X, Y); }
        public readonly Vector3I2F30 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, X, Z); }
        public readonly Vector3I2F30 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, X, W); }
        public readonly Vector3I2F30 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Y, X); }
        public readonly Vector3I2F30 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Y, Y); }
        public readonly Vector3I2F30 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Y, Z); }
        public readonly Vector3I2F30 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Y, W); }
        public readonly Vector3I2F30 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Z, X); }
        public readonly Vector3I2F30 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Z, Y); }
        public readonly Vector3I2F30 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Z, Z); }
        public readonly Vector3I2F30 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Z, W); }
        public readonly Vector3I2F30 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, W, X); }
        public readonly Vector3I2F30 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, W, Y); }
        public readonly Vector3I2F30 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, W, Z); }
        public readonly Vector3I2F30 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, W, W); }
        public readonly Vector4I2F30 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, X); }
        public readonly Vector4I2F30 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, Y); }
        public readonly Vector4I2F30 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, Z); }
        public readonly Vector4I2F30 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, W); }
        public readonly Vector4I2F30 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, X); }
        public readonly Vector4I2F30 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, Y); }
        public readonly Vector4I2F30 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, Z); }
        public readonly Vector4I2F30 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, W); }
        public readonly Vector4I2F30 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, X); }
        public readonly Vector4I2F30 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, Y); }
        public readonly Vector4I2F30 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, Z); }
        public readonly Vector4I2F30 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, W); }
        public readonly Vector4I2F30 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, W, X); }
        public readonly Vector4I2F30 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, W, Y); }
        public readonly Vector4I2F30 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, W, Z); }
        public readonly Vector4I2F30 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, W, W); }
        public readonly Vector4I2F30 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, X); }
        public readonly Vector4I2F30 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, Y); }
        public readonly Vector4I2F30 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, Z); }
        public readonly Vector4I2F30 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, W); }
        public readonly Vector4I2F30 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, X); }
        public readonly Vector4I2F30 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, Y); }
        public readonly Vector4I2F30 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, Z); }
        public readonly Vector4I2F30 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, W); }
        public readonly Vector4I2F30 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, X); }
        public readonly Vector4I2F30 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, Y); }
        public readonly Vector4I2F30 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, Z); }
        public readonly Vector4I2F30 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, W); }
        public readonly Vector4I2F30 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, W, X); }
        public readonly Vector4I2F30 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, W, Y); }
        public readonly Vector4I2F30 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, W, Z); }
        public readonly Vector4I2F30 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, W, W); }
        public readonly Vector4I2F30 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, X); }
        public readonly Vector4I2F30 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, Y); }
        public readonly Vector4I2F30 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, Z); }
        public readonly Vector4I2F30 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, W); }
        public readonly Vector4I2F30 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, X); }
        public readonly Vector4I2F30 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, Y); }
        public readonly Vector4I2F30 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, Z); }
        public readonly Vector4I2F30 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, W); }
        public readonly Vector4I2F30 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, X); }
        public readonly Vector4I2F30 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, Y); }
        public readonly Vector4I2F30 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, Z); }
        public readonly Vector4I2F30 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, W); }
        public readonly Vector4I2F30 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, W, X); }
        public readonly Vector4I2F30 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, W, Y); }
        public readonly Vector4I2F30 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, W, Z); }
        public readonly Vector4I2F30 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, W, W); }
        public readonly Vector4I2F30 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, X, X); }
        public readonly Vector4I2F30 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, X, Y); }
        public readonly Vector4I2F30 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, X, Z); }
        public readonly Vector4I2F30 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, X, W); }
        public readonly Vector4I2F30 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Y, X); }
        public readonly Vector4I2F30 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Y, Y); }
        public readonly Vector4I2F30 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Y, Z); }
        public readonly Vector4I2F30 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Y, W); }
        public readonly Vector4I2F30 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Z, X); }
        public readonly Vector4I2F30 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Z, Y); }
        public readonly Vector4I2F30 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Z, Z); }
        public readonly Vector4I2F30 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Z, W); }
        public readonly Vector4I2F30 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, W, X); }
        public readonly Vector4I2F30 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, W, Y); }
        public readonly Vector4I2F30 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, W, Z); }
        public readonly Vector4I2F30 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, W, W); }
        public readonly Vector4I2F30 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, X); }
        public readonly Vector4I2F30 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, Y); }
        public readonly Vector4I2F30 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, Z); }
        public readonly Vector4I2F30 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, W); }
        public readonly Vector4I2F30 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, X); }
        public readonly Vector4I2F30 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, Y); }
        public readonly Vector4I2F30 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, Z); }
        public readonly Vector4I2F30 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, W); }
        public readonly Vector4I2F30 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, X); }
        public readonly Vector4I2F30 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, Y); }
        public readonly Vector4I2F30 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, Z); }
        public readonly Vector4I2F30 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, W); }
        public readonly Vector4I2F30 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, W, X); }
        public readonly Vector4I2F30 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, W, Y); }
        public readonly Vector4I2F30 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, W, Z); }
        public readonly Vector4I2F30 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, W, W); }
        public readonly Vector4I2F30 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, X); }
        public readonly Vector4I2F30 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, Y); }
        public readonly Vector4I2F30 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, Z); }
        public readonly Vector4I2F30 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, W); }
        public readonly Vector4I2F30 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, X); }
        public readonly Vector4I2F30 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, Y); }
        public readonly Vector4I2F30 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, Z); }
        public readonly Vector4I2F30 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, W); }
        public readonly Vector4I2F30 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, X); }
        public readonly Vector4I2F30 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, Y); }
        public readonly Vector4I2F30 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, Z); }
        public readonly Vector4I2F30 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, W); }
        public readonly Vector4I2F30 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, W, X); }
        public readonly Vector4I2F30 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, W, Y); }
        public readonly Vector4I2F30 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, W, Z); }
        public readonly Vector4I2F30 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, W, W); }
        public readonly Vector4I2F30 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, X); }
        public readonly Vector4I2F30 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, Y); }
        public readonly Vector4I2F30 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, Z); }
        public readonly Vector4I2F30 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, W); }
        public readonly Vector4I2F30 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, X); }
        public readonly Vector4I2F30 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, Y); }
        public readonly Vector4I2F30 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, Z); }
        public readonly Vector4I2F30 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, W); }
        public readonly Vector4I2F30 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, X); }
        public readonly Vector4I2F30 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, Y); }
        public readonly Vector4I2F30 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, Z); }
        public readonly Vector4I2F30 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, W); }
        public readonly Vector4I2F30 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, W, X); }
        public readonly Vector4I2F30 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, W, Y); }
        public readonly Vector4I2F30 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, W, Z); }
        public readonly Vector4I2F30 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, W, W); }
        public readonly Vector4I2F30 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, X, X); }
        public readonly Vector4I2F30 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, X, Y); }
        public readonly Vector4I2F30 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, X, Z); }
        public readonly Vector4I2F30 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, X, W); }
        public readonly Vector4I2F30 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Y, X); }
        public readonly Vector4I2F30 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Y, Y); }
        public readonly Vector4I2F30 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Y, Z); }
        public readonly Vector4I2F30 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Y, W); }
        public readonly Vector4I2F30 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Z, X); }
        public readonly Vector4I2F30 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Z, Y); }
        public readonly Vector4I2F30 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Z, Z); }
        public readonly Vector4I2F30 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Z, W); }
        public readonly Vector4I2F30 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, W, X); }
        public readonly Vector4I2F30 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, W, Y); }
        public readonly Vector4I2F30 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, W, Z); }
        public readonly Vector4I2F30 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, W, W); }
        public readonly Vector4I2F30 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, X); }
        public readonly Vector4I2F30 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, Y); }
        public readonly Vector4I2F30 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, Z); }
        public readonly Vector4I2F30 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, W); }
        public readonly Vector4I2F30 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, X); }
        public readonly Vector4I2F30 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, Y); }
        public readonly Vector4I2F30 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, Z); }
        public readonly Vector4I2F30 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, W); }
        public readonly Vector4I2F30 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, X); }
        public readonly Vector4I2F30 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, Y); }
        public readonly Vector4I2F30 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, Z); }
        public readonly Vector4I2F30 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, W); }
        public readonly Vector4I2F30 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, W, X); }
        public readonly Vector4I2F30 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, W, Y); }
        public readonly Vector4I2F30 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, W, Z); }
        public readonly Vector4I2F30 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, W, W); }
        public readonly Vector4I2F30 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, X); }
        public readonly Vector4I2F30 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, Y); }
        public readonly Vector4I2F30 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, Z); }
        public readonly Vector4I2F30 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, W); }
        public readonly Vector4I2F30 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, X); }
        public readonly Vector4I2F30 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, Y); }
        public readonly Vector4I2F30 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, Z); }
        public readonly Vector4I2F30 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, W); }
        public readonly Vector4I2F30 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, X); }
        public readonly Vector4I2F30 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, Y); }
        public readonly Vector4I2F30 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, Z); }
        public readonly Vector4I2F30 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, W); }
        public readonly Vector4I2F30 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, W, X); }
        public readonly Vector4I2F30 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, W, Y); }
        public readonly Vector4I2F30 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, W, Z); }
        public readonly Vector4I2F30 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, W, W); }
        public readonly Vector4I2F30 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, X); }
        public readonly Vector4I2F30 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, Y); }
        public readonly Vector4I2F30 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, Z); }
        public readonly Vector4I2F30 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, W); }
        public readonly Vector4I2F30 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, X); }
        public readonly Vector4I2F30 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, Y); }
        public readonly Vector4I2F30 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, Z); }
        public readonly Vector4I2F30 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, W); }
        public readonly Vector4I2F30 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, X); }
        public readonly Vector4I2F30 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, Y); }
        public readonly Vector4I2F30 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, Z); }
        public readonly Vector4I2F30 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, W); }
        public readonly Vector4I2F30 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, W, X); }
        public readonly Vector4I2F30 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, W, Y); }
        public readonly Vector4I2F30 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, W, Z); }
        public readonly Vector4I2F30 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, W, W); }
        public readonly Vector4I2F30 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, X, X); }
        public readonly Vector4I2F30 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, X, Y); }
        public readonly Vector4I2F30 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, X, Z); }
        public readonly Vector4I2F30 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, X, W); }
        public readonly Vector4I2F30 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Y, X); }
        public readonly Vector4I2F30 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Y, Y); }
        public readonly Vector4I2F30 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Y, Z); }
        public readonly Vector4I2F30 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Y, W); }
        public readonly Vector4I2F30 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Z, X); }
        public readonly Vector4I2F30 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Z, Y); }
        public readonly Vector4I2F30 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Z, Z); }
        public readonly Vector4I2F30 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Z, W); }
        public readonly Vector4I2F30 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, W, X); }
        public readonly Vector4I2F30 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, W, Y); }
        public readonly Vector4I2F30 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, W, Z); }
        public readonly Vector4I2F30 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, W, W); }
        public readonly Vector4I2F30 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, X, X); }
        public readonly Vector4I2F30 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, X, Y); }
        public readonly Vector4I2F30 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, X, Z); }
        public readonly Vector4I2F30 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, X, W); }
        public readonly Vector4I2F30 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Y, X); }
        public readonly Vector4I2F30 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Y, Y); }
        public readonly Vector4I2F30 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Y, Z); }
        public readonly Vector4I2F30 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Y, W); }
        public readonly Vector4I2F30 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Z, X); }
        public readonly Vector4I2F30 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Z, Y); }
        public readonly Vector4I2F30 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Z, Z); }
        public readonly Vector4I2F30 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Z, W); }
        public readonly Vector4I2F30 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, W, X); }
        public readonly Vector4I2F30 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, W, Y); }
        public readonly Vector4I2F30 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, W, Z); }
        public readonly Vector4I2F30 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, W, W); }
        public readonly Vector4I2F30 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, X, X); }
        public readonly Vector4I2F30 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, X, Y); }
        public readonly Vector4I2F30 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, X, Z); }
        public readonly Vector4I2F30 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, X, W); }
        public readonly Vector4I2F30 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Y, X); }
        public readonly Vector4I2F30 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Y, Y); }
        public readonly Vector4I2F30 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Y, Z); }
        public readonly Vector4I2F30 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Y, W); }
        public readonly Vector4I2F30 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Z, X); }
        public readonly Vector4I2F30 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Z, Y); }
        public readonly Vector4I2F30 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Z, Z); }
        public readonly Vector4I2F30 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Z, W); }
        public readonly Vector4I2F30 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, W, X); }
        public readonly Vector4I2F30 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, W, Y); }
        public readonly Vector4I2F30 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, W, Z); }
        public readonly Vector4I2F30 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, W, W); }
        public readonly Vector4I2F30 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, X, X); }
        public readonly Vector4I2F30 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, X, Y); }
        public readonly Vector4I2F30 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, X, Z); }
        public readonly Vector4I2F30 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, X, W); }
        public readonly Vector4I2F30 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Y, X); }
        public readonly Vector4I2F30 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Y, Y); }
        public readonly Vector4I2F30 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Y, Z); }
        public readonly Vector4I2F30 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Y, W); }
        public readonly Vector4I2F30 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Z, X); }
        public readonly Vector4I2F30 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Z, Y); }
        public readonly Vector4I2F30 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Z, Z); }
        public readonly Vector4I2F30 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Z, W); }
        public readonly Vector4I2F30 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, W, X); }
        public readonly Vector4I2F30 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, W, Y); }
        public readonly Vector4I2F30 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, W, Z); }
        public readonly Vector4I2F30 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, W, W); }
        public readonly Vector4I2F30 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, X, X); }
        public readonly Vector4I2F30 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, X, Y); }
        public readonly Vector4I2F30 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, X, Z); }
        public readonly Vector4I2F30 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, X, W); }
        public readonly Vector4I2F30 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Y, X); }
        public readonly Vector4I2F30 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Y, Y); }
        public readonly Vector4I2F30 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Y, Z); }
        public readonly Vector4I2F30 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Y, W); }
        public readonly Vector4I2F30 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Z, X); }
        public readonly Vector4I2F30 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Z, Y); }
        public readonly Vector4I2F30 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Z, Z); }
        public readonly Vector4I2F30 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Z, W); }
        public readonly Vector4I2F30 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, W, X); }
        public readonly Vector4I2F30 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, W, Y); }
        public readonly Vector4I2F30 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, W, Z); }
        public readonly Vector4I2F30 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I2F30 lhs, Vector4I2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I2F30 lhs, Vector4I2F30 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I2F30({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I2F30 other)
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
            return $"Vector4I2F30({x}, {y}, {z}, {w})";
        }
    }
}
