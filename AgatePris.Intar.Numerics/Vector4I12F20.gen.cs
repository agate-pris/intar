using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4I12F20 : IEquatable<Vector4I12F20>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I12F20 X;
        public I12F20 Y;
        public I12F20 Z;
        public I12F20 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4I12F20 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(I12F20 x, I12F20 y, I12F20 z, I12F20 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(I12F20 x, I12F20 y, Vector2I12F20 zw) {
            X = x;
            Y = y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(I12F20 x, Vector3I12F20 yzw) {
            X = x;
            Y = yzw.X;
            Z = yzw.Y;
            W = yzw.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(Vector2I12F20 xy, Vector2I12F20 zw) {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(Vector4I12F20 xyzw) {
            X = xyzw.X;
            Y = xyzw.Y;
            Z = xyzw.Z;
            W = xyzw.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(I12F20 x, Vector2I12F20 yz, I12F20 w) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(Vector3I12F20 xyz, I12F20 w) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(Vector2I12F20 xy, I12F20 z, I12F20 w) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator +(Vector4I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator -(Vector4I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator *(Vector4I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator *(Vector4I12F20 a, I12F20 b) => new Vector4I12F20(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator *(I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator /(Vector4I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator /(Vector4I12F20 a, I12F20 b) => new Vector4I12F20(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator /(I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I12F20 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, X); }
        public readonly Vector2I12F20 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, Y); }
        public readonly Vector2I12F20 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, Z); }
        public readonly Vector2I12F20 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, W); }
        public readonly Vector2I12F20 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, X); }
        public readonly Vector2I12F20 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, Y); }
        public readonly Vector2I12F20 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, Z); }
        public readonly Vector2I12F20 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, W); }
        public readonly Vector2I12F20 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, X); }
        public readonly Vector2I12F20 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, Y); }
        public readonly Vector2I12F20 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, Z); }
        public readonly Vector2I12F20 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, W); }
        public readonly Vector2I12F20 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(W, X); }
        public readonly Vector2I12F20 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(W, Y); }
        public readonly Vector2I12F20 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(W, Z); }
        public readonly Vector2I12F20 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(W, W); }
        public readonly Vector3I12F20 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, X); }
        public readonly Vector3I12F20 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, Y); }
        public readonly Vector3I12F20 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, Z); }
        public readonly Vector3I12F20 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, W); }
        public readonly Vector3I12F20 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, X); }
        public readonly Vector3I12F20 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, Y); }
        public readonly Vector3I12F20 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, Z); }
        public readonly Vector3I12F20 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, W); }
        public readonly Vector3I12F20 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, X); }
        public readonly Vector3I12F20 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, Y); }
        public readonly Vector3I12F20 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, Z); }
        public readonly Vector3I12F20 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, W); }
        public readonly Vector3I12F20 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, W, X); }
        public readonly Vector3I12F20 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, W, Y); }
        public readonly Vector3I12F20 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, W, Z); }
        public readonly Vector3I12F20 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, W, W); }
        public readonly Vector3I12F20 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, X); }
        public readonly Vector3I12F20 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, Y); }
        public readonly Vector3I12F20 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, Z); }
        public readonly Vector3I12F20 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, W); }
        public readonly Vector3I12F20 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, X); }
        public readonly Vector3I12F20 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, Y); }
        public readonly Vector3I12F20 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, Z); }
        public readonly Vector3I12F20 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, W); }
        public readonly Vector3I12F20 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, X); }
        public readonly Vector3I12F20 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, Y); }
        public readonly Vector3I12F20 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, Z); }
        public readonly Vector3I12F20 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, W); }
        public readonly Vector3I12F20 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, W, X); }
        public readonly Vector3I12F20 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, W, Y); }
        public readonly Vector3I12F20 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, W, Z); }
        public readonly Vector3I12F20 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, W, W); }
        public readonly Vector3I12F20 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, X); }
        public readonly Vector3I12F20 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, Y); }
        public readonly Vector3I12F20 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, Z); }
        public readonly Vector3I12F20 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, W); }
        public readonly Vector3I12F20 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, X); }
        public readonly Vector3I12F20 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, Y); }
        public readonly Vector3I12F20 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, Z); }
        public readonly Vector3I12F20 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, W); }
        public readonly Vector3I12F20 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, X); }
        public readonly Vector3I12F20 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, Y); }
        public readonly Vector3I12F20 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, Z); }
        public readonly Vector3I12F20 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, W); }
        public readonly Vector3I12F20 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, W, X); }
        public readonly Vector3I12F20 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, W, Y); }
        public readonly Vector3I12F20 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, W, Z); }
        public readonly Vector3I12F20 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, W, W); }
        public readonly Vector3I12F20 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, X, X); }
        public readonly Vector3I12F20 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, X, Y); }
        public readonly Vector3I12F20 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, X, Z); }
        public readonly Vector3I12F20 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, X, W); }
        public readonly Vector3I12F20 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Y, X); }
        public readonly Vector3I12F20 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Y, Y); }
        public readonly Vector3I12F20 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Y, Z); }
        public readonly Vector3I12F20 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Y, W); }
        public readonly Vector3I12F20 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Z, X); }
        public readonly Vector3I12F20 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Z, Y); }
        public readonly Vector3I12F20 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Z, Z); }
        public readonly Vector3I12F20 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Z, W); }
        public readonly Vector3I12F20 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, W, X); }
        public readonly Vector3I12F20 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, W, Y); }
        public readonly Vector3I12F20 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, W, Z); }
        public readonly Vector3I12F20 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, W, W); }
        public readonly Vector4I12F20 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, X); }
        public readonly Vector4I12F20 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, Y); }
        public readonly Vector4I12F20 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, Z); }
        public readonly Vector4I12F20 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, W); }
        public readonly Vector4I12F20 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, X); }
        public readonly Vector4I12F20 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, Y); }
        public readonly Vector4I12F20 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, Z); }
        public readonly Vector4I12F20 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, W); }
        public readonly Vector4I12F20 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, X); }
        public readonly Vector4I12F20 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, Y); }
        public readonly Vector4I12F20 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, Z); }
        public readonly Vector4I12F20 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, W); }
        public readonly Vector4I12F20 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, W, X); }
        public readonly Vector4I12F20 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, W, Y); }
        public readonly Vector4I12F20 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, W, Z); }
        public readonly Vector4I12F20 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, W, W); }
        public readonly Vector4I12F20 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, X); }
        public readonly Vector4I12F20 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, Y); }
        public readonly Vector4I12F20 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, Z); }
        public readonly Vector4I12F20 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, W); }
        public readonly Vector4I12F20 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, X); }
        public readonly Vector4I12F20 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, Y); }
        public readonly Vector4I12F20 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, Z); }
        public readonly Vector4I12F20 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, W); }
        public readonly Vector4I12F20 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, X); }
        public readonly Vector4I12F20 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, Y); }
        public readonly Vector4I12F20 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, Z); }
        public readonly Vector4I12F20 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, W); }
        public readonly Vector4I12F20 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, W, X); }
        public readonly Vector4I12F20 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, W, Y); }
        public readonly Vector4I12F20 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, W, Z); }
        public readonly Vector4I12F20 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, W, W); }
        public readonly Vector4I12F20 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, X); }
        public readonly Vector4I12F20 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, Y); }
        public readonly Vector4I12F20 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, Z); }
        public readonly Vector4I12F20 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, W); }
        public readonly Vector4I12F20 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, X); }
        public readonly Vector4I12F20 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, Y); }
        public readonly Vector4I12F20 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, Z); }
        public readonly Vector4I12F20 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, W); }
        public readonly Vector4I12F20 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, X); }
        public readonly Vector4I12F20 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, Y); }
        public readonly Vector4I12F20 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, Z); }
        public readonly Vector4I12F20 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, W); }
        public readonly Vector4I12F20 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, W, X); }
        public readonly Vector4I12F20 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, W, Y); }
        public readonly Vector4I12F20 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, W, Z); }
        public readonly Vector4I12F20 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, W, W); }
        public readonly Vector4I12F20 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, X, X); }
        public readonly Vector4I12F20 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, X, Y); }
        public readonly Vector4I12F20 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, X, Z); }
        public readonly Vector4I12F20 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, X, W); }
        public readonly Vector4I12F20 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Y, X); }
        public readonly Vector4I12F20 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Y, Y); }
        public readonly Vector4I12F20 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Y, Z); }
        public readonly Vector4I12F20 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Y, W); }
        public readonly Vector4I12F20 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Z, X); }
        public readonly Vector4I12F20 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Z, Y); }
        public readonly Vector4I12F20 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Z, Z); }
        public readonly Vector4I12F20 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Z, W); }
        public readonly Vector4I12F20 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, W, X); }
        public readonly Vector4I12F20 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, W, Y); }
        public readonly Vector4I12F20 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, W, Z); }
        public readonly Vector4I12F20 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, W, W); }
        public readonly Vector4I12F20 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, X); }
        public readonly Vector4I12F20 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, Y); }
        public readonly Vector4I12F20 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, Z); }
        public readonly Vector4I12F20 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, W); }
        public readonly Vector4I12F20 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, X); }
        public readonly Vector4I12F20 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, Y); }
        public readonly Vector4I12F20 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, Z); }
        public readonly Vector4I12F20 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, W); }
        public readonly Vector4I12F20 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, X); }
        public readonly Vector4I12F20 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, Y); }
        public readonly Vector4I12F20 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, Z); }
        public readonly Vector4I12F20 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, W); }
        public readonly Vector4I12F20 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, W, X); }
        public readonly Vector4I12F20 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, W, Y); }
        public readonly Vector4I12F20 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, W, Z); }
        public readonly Vector4I12F20 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, W, W); }
        public readonly Vector4I12F20 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, X); }
        public readonly Vector4I12F20 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, Y); }
        public readonly Vector4I12F20 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, Z); }
        public readonly Vector4I12F20 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, W); }
        public readonly Vector4I12F20 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, X); }
        public readonly Vector4I12F20 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, Y); }
        public readonly Vector4I12F20 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, Z); }
        public readonly Vector4I12F20 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, W); }
        public readonly Vector4I12F20 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, X); }
        public readonly Vector4I12F20 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, Y); }
        public readonly Vector4I12F20 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, Z); }
        public readonly Vector4I12F20 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, W); }
        public readonly Vector4I12F20 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, W, X); }
        public readonly Vector4I12F20 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, W, Y); }
        public readonly Vector4I12F20 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, W, Z); }
        public readonly Vector4I12F20 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, W, W); }
        public readonly Vector4I12F20 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, X); }
        public readonly Vector4I12F20 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, Y); }
        public readonly Vector4I12F20 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, Z); }
        public readonly Vector4I12F20 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, W); }
        public readonly Vector4I12F20 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, X); }
        public readonly Vector4I12F20 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, Y); }
        public readonly Vector4I12F20 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, Z); }
        public readonly Vector4I12F20 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, W); }
        public readonly Vector4I12F20 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, X); }
        public readonly Vector4I12F20 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, Y); }
        public readonly Vector4I12F20 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, Z); }
        public readonly Vector4I12F20 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, W); }
        public readonly Vector4I12F20 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, W, X); }
        public readonly Vector4I12F20 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, W, Y); }
        public readonly Vector4I12F20 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, W, Z); }
        public readonly Vector4I12F20 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, W, W); }
        public readonly Vector4I12F20 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, X, X); }
        public readonly Vector4I12F20 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, X, Y); }
        public readonly Vector4I12F20 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, X, Z); }
        public readonly Vector4I12F20 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, X, W); }
        public readonly Vector4I12F20 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Y, X); }
        public readonly Vector4I12F20 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Y, Y); }
        public readonly Vector4I12F20 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Y, Z); }
        public readonly Vector4I12F20 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Y, W); }
        public readonly Vector4I12F20 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Z, X); }
        public readonly Vector4I12F20 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Z, Y); }
        public readonly Vector4I12F20 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Z, Z); }
        public readonly Vector4I12F20 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Z, W); }
        public readonly Vector4I12F20 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, W, X); }
        public readonly Vector4I12F20 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, W, Y); }
        public readonly Vector4I12F20 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, W, Z); }
        public readonly Vector4I12F20 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, W, W); }
        public readonly Vector4I12F20 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, X); }
        public readonly Vector4I12F20 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, Y); }
        public readonly Vector4I12F20 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, Z); }
        public readonly Vector4I12F20 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, W); }
        public readonly Vector4I12F20 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, X); }
        public readonly Vector4I12F20 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, Y); }
        public readonly Vector4I12F20 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, Z); }
        public readonly Vector4I12F20 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, W); }
        public readonly Vector4I12F20 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, X); }
        public readonly Vector4I12F20 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, Y); }
        public readonly Vector4I12F20 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, Z); }
        public readonly Vector4I12F20 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, W); }
        public readonly Vector4I12F20 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, W, X); }
        public readonly Vector4I12F20 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, W, Y); }
        public readonly Vector4I12F20 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, W, Z); }
        public readonly Vector4I12F20 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, W, W); }
        public readonly Vector4I12F20 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, X); }
        public readonly Vector4I12F20 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, Y); }
        public readonly Vector4I12F20 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, Z); }
        public readonly Vector4I12F20 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, W); }
        public readonly Vector4I12F20 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, X); }
        public readonly Vector4I12F20 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, Y); }
        public readonly Vector4I12F20 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, Z); }
        public readonly Vector4I12F20 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, W); }
        public readonly Vector4I12F20 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, X); }
        public readonly Vector4I12F20 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, Y); }
        public readonly Vector4I12F20 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, Z); }
        public readonly Vector4I12F20 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, W); }
        public readonly Vector4I12F20 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, W, X); }
        public readonly Vector4I12F20 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, W, Y); }
        public readonly Vector4I12F20 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, W, Z); }
        public readonly Vector4I12F20 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, W, W); }
        public readonly Vector4I12F20 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, X); }
        public readonly Vector4I12F20 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, Y); }
        public readonly Vector4I12F20 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, Z); }
        public readonly Vector4I12F20 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, W); }
        public readonly Vector4I12F20 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, X); }
        public readonly Vector4I12F20 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, Y); }
        public readonly Vector4I12F20 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, Z); }
        public readonly Vector4I12F20 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, W); }
        public readonly Vector4I12F20 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, X); }
        public readonly Vector4I12F20 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, Y); }
        public readonly Vector4I12F20 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, Z); }
        public readonly Vector4I12F20 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, W); }
        public readonly Vector4I12F20 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, W, X); }
        public readonly Vector4I12F20 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, W, Y); }
        public readonly Vector4I12F20 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, W, Z); }
        public readonly Vector4I12F20 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, W, W); }
        public readonly Vector4I12F20 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, X, X); }
        public readonly Vector4I12F20 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, X, Y); }
        public readonly Vector4I12F20 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, X, Z); }
        public readonly Vector4I12F20 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, X, W); }
        public readonly Vector4I12F20 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Y, X); }
        public readonly Vector4I12F20 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Y, Y); }
        public readonly Vector4I12F20 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Y, Z); }
        public readonly Vector4I12F20 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Y, W); }
        public readonly Vector4I12F20 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Z, X); }
        public readonly Vector4I12F20 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Z, Y); }
        public readonly Vector4I12F20 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Z, Z); }
        public readonly Vector4I12F20 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Z, W); }
        public readonly Vector4I12F20 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, W, X); }
        public readonly Vector4I12F20 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, W, Y); }
        public readonly Vector4I12F20 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, W, Z); }
        public readonly Vector4I12F20 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, W, W); }
        public readonly Vector4I12F20 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, X, X); }
        public readonly Vector4I12F20 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, X, Y); }
        public readonly Vector4I12F20 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, X, Z); }
        public readonly Vector4I12F20 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, X, W); }
        public readonly Vector4I12F20 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Y, X); }
        public readonly Vector4I12F20 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Y, Y); }
        public readonly Vector4I12F20 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Y, Z); }
        public readonly Vector4I12F20 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Y, W); }
        public readonly Vector4I12F20 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Z, X); }
        public readonly Vector4I12F20 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Z, Y); }
        public readonly Vector4I12F20 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Z, Z); }
        public readonly Vector4I12F20 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Z, W); }
        public readonly Vector4I12F20 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, W, X); }
        public readonly Vector4I12F20 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, W, Y); }
        public readonly Vector4I12F20 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, W, Z); }
        public readonly Vector4I12F20 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, W, W); }
        public readonly Vector4I12F20 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, X, X); }
        public readonly Vector4I12F20 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, X, Y); }
        public readonly Vector4I12F20 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, X, Z); }
        public readonly Vector4I12F20 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, X, W); }
        public readonly Vector4I12F20 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Y, X); }
        public readonly Vector4I12F20 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Y, Y); }
        public readonly Vector4I12F20 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Y, Z); }
        public readonly Vector4I12F20 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Y, W); }
        public readonly Vector4I12F20 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Z, X); }
        public readonly Vector4I12F20 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Z, Y); }
        public readonly Vector4I12F20 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Z, Z); }
        public readonly Vector4I12F20 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Z, W); }
        public readonly Vector4I12F20 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, W, X); }
        public readonly Vector4I12F20 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, W, Y); }
        public readonly Vector4I12F20 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, W, Z); }
        public readonly Vector4I12F20 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, W, W); }
        public readonly Vector4I12F20 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, X, X); }
        public readonly Vector4I12F20 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, X, Y); }
        public readonly Vector4I12F20 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, X, Z); }
        public readonly Vector4I12F20 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, X, W); }
        public readonly Vector4I12F20 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Y, X); }
        public readonly Vector4I12F20 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Y, Y); }
        public readonly Vector4I12F20 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Y, Z); }
        public readonly Vector4I12F20 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Y, W); }
        public readonly Vector4I12F20 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Z, X); }
        public readonly Vector4I12F20 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Z, Y); }
        public readonly Vector4I12F20 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Z, Z); }
        public readonly Vector4I12F20 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Z, W); }
        public readonly Vector4I12F20 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, W, X); }
        public readonly Vector4I12F20 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, W, Y); }
        public readonly Vector4I12F20 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, W, Z); }
        public readonly Vector4I12F20 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, W, W); }
        public readonly Vector4I12F20 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, X, X); }
        public readonly Vector4I12F20 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, X, Y); }
        public readonly Vector4I12F20 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, X, Z); }
        public readonly Vector4I12F20 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, X, W); }
        public readonly Vector4I12F20 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Y, X); }
        public readonly Vector4I12F20 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Y, Y); }
        public readonly Vector4I12F20 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Y, Z); }
        public readonly Vector4I12F20 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Y, W); }
        public readonly Vector4I12F20 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Z, X); }
        public readonly Vector4I12F20 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Z, Y); }
        public readonly Vector4I12F20 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Z, Z); }
        public readonly Vector4I12F20 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Z, W); }
        public readonly Vector4I12F20 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, W, X); }
        public readonly Vector4I12F20 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, W, Y); }
        public readonly Vector4I12F20 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, W, Z); }
        public readonly Vector4I12F20 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I12F20 lhs, Vector4I12F20 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I12F20 lhs, Vector4I12F20 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I12F20 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I12F20({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I12F20>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I12F20 other)
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
            return $"Vector4I12F20({x}, {y}, {z}, {w})";
        }
    }
}
