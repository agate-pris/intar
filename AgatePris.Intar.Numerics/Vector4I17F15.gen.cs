using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I17F15 : IEquatable<Vector4I17F15>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I17F15 X;
        public I17F15 Y;
        public I17F15 Z;
        public I17F15 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4I17F15 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 x, I17F15 y, I17F15 z, I17F15 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 x, I17F15 y, Vector2I17F15 zw) {
            X = x;
            Y = y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 x, Vector3I17F15 yzw) {
            X = x;
            Y = yzw.X;
            Z = yzw.Y;
            W = yzw.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(Vector2I17F15 xy, Vector2I17F15 zw) {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(Vector4I17F15 xyzw) {
            X = xyzw.X;
            Y = xyzw.Y;
            Z = xyzw.Z;
            W = xyzw.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 x, Vector2I17F15 yz, I17F15 w) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(Vector3I17F15 xyz, I17F15 w) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(Vector2I17F15 xy, I17F15 z, I17F15 w) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator +(Vector4I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator -(Vector4I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator *(Vector4I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator *(Vector4I17F15 a, I17F15 b) => new Vector4I17F15(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator *(I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator /(Vector4I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator /(Vector4I17F15 a, I17F15 b) => new Vector4I17F15(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator /(I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I17F15 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, X); }
        public readonly Vector2I17F15 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, Y); }
        public readonly Vector2I17F15 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, Z); }
        public readonly Vector2I17F15 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, W); }
        public readonly Vector2I17F15 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, X); }
        public readonly Vector2I17F15 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, Y); }
        public readonly Vector2I17F15 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, Z); }
        public readonly Vector2I17F15 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, W); }
        public readonly Vector2I17F15 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Z, X); }
        public readonly Vector2I17F15 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Z, Y); }
        public readonly Vector2I17F15 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Z, Z); }
        public readonly Vector2I17F15 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Z, W); }
        public readonly Vector2I17F15 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(W, X); }
        public readonly Vector2I17F15 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(W, Y); }
        public readonly Vector2I17F15 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(W, Z); }
        public readonly Vector2I17F15 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(W, W); }
        public readonly Vector3I17F15 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, X); }
        public readonly Vector3I17F15 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, Y); }
        public readonly Vector3I17F15 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, Z); }
        public readonly Vector3I17F15 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, W); }
        public readonly Vector3I17F15 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, X); }
        public readonly Vector3I17F15 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, Y); }
        public readonly Vector3I17F15 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, Z); }
        public readonly Vector3I17F15 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, W); }
        public readonly Vector3I17F15 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Z, X); }
        public readonly Vector3I17F15 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Z, Y); }
        public readonly Vector3I17F15 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Z, Z); }
        public readonly Vector3I17F15 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Z, W); }
        public readonly Vector3I17F15 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, W, X); }
        public readonly Vector3I17F15 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, W, Y); }
        public readonly Vector3I17F15 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, W, Z); }
        public readonly Vector3I17F15 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, W, W); }
        public readonly Vector3I17F15 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, X); }
        public readonly Vector3I17F15 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, Y); }
        public readonly Vector3I17F15 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, Z); }
        public readonly Vector3I17F15 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, W); }
        public readonly Vector3I17F15 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, X); }
        public readonly Vector3I17F15 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, Y); }
        public readonly Vector3I17F15 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, Z); }
        public readonly Vector3I17F15 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, W); }
        public readonly Vector3I17F15 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Z, X); }
        public readonly Vector3I17F15 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Z, Y); }
        public readonly Vector3I17F15 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Z, Z); }
        public readonly Vector3I17F15 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Z, W); }
        public readonly Vector3I17F15 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, W, X); }
        public readonly Vector3I17F15 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, W, Y); }
        public readonly Vector3I17F15 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, W, Z); }
        public readonly Vector3I17F15 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, W, W); }
        public readonly Vector3I17F15 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, X, X); }
        public readonly Vector3I17F15 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, X, Y); }
        public readonly Vector3I17F15 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, X, Z); }
        public readonly Vector3I17F15 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, X, W); }
        public readonly Vector3I17F15 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Y, X); }
        public readonly Vector3I17F15 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Y, Y); }
        public readonly Vector3I17F15 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Y, Z); }
        public readonly Vector3I17F15 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Y, W); }
        public readonly Vector3I17F15 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Z, X); }
        public readonly Vector3I17F15 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Z, Y); }
        public readonly Vector3I17F15 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Z, Z); }
        public readonly Vector3I17F15 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Z, W); }
        public readonly Vector3I17F15 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, W, X); }
        public readonly Vector3I17F15 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, W, Y); }
        public readonly Vector3I17F15 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, W, Z); }
        public readonly Vector3I17F15 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, W, W); }
        public readonly Vector3I17F15 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, X, X); }
        public readonly Vector3I17F15 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, X, Y); }
        public readonly Vector3I17F15 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, X, Z); }
        public readonly Vector3I17F15 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, X, W); }
        public readonly Vector3I17F15 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, Y, X); }
        public readonly Vector3I17F15 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, Y, Y); }
        public readonly Vector3I17F15 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, Y, Z); }
        public readonly Vector3I17F15 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, Y, W); }
        public readonly Vector3I17F15 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, Z, X); }
        public readonly Vector3I17F15 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, Z, Y); }
        public readonly Vector3I17F15 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, Z, Z); }
        public readonly Vector3I17F15 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, Z, W); }
        public readonly Vector3I17F15 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, W, X); }
        public readonly Vector3I17F15 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, W, Y); }
        public readonly Vector3I17F15 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, W, Z); }
        public readonly Vector3I17F15 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(W, W, W); }
        public readonly Vector4I17F15 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, X); }
        public readonly Vector4I17F15 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, Y); }
        public readonly Vector4I17F15 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, Z); }
        public readonly Vector4I17F15 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, W); }
        public readonly Vector4I17F15 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, X); }
        public readonly Vector4I17F15 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, Y); }
        public readonly Vector4I17F15 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, Z); }
        public readonly Vector4I17F15 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, W); }
        public readonly Vector4I17F15 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Z, X); }
        public readonly Vector4I17F15 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Z, Y); }
        public readonly Vector4I17F15 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Z, Z); }
        public readonly Vector4I17F15 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Z, W); }
        public readonly Vector4I17F15 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, W, X); }
        public readonly Vector4I17F15 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, W, Y); }
        public readonly Vector4I17F15 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, W, Z); }
        public readonly Vector4I17F15 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, W, W); }
        public readonly Vector4I17F15 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, X); }
        public readonly Vector4I17F15 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, Y); }
        public readonly Vector4I17F15 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, Z); }
        public readonly Vector4I17F15 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, W); }
        public readonly Vector4I17F15 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, X); }
        public readonly Vector4I17F15 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, Y); }
        public readonly Vector4I17F15 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, Z); }
        public readonly Vector4I17F15 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, W); }
        public readonly Vector4I17F15 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Z, X); }
        public readonly Vector4I17F15 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Z, Y); }
        public readonly Vector4I17F15 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Z, Z); }
        public readonly Vector4I17F15 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Z, W); }
        public readonly Vector4I17F15 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, W, X); }
        public readonly Vector4I17F15 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, W, Y); }
        public readonly Vector4I17F15 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, W, Z); }
        public readonly Vector4I17F15 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, W, W); }
        public readonly Vector4I17F15 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, X, X); }
        public readonly Vector4I17F15 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, X, Y); }
        public readonly Vector4I17F15 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, X, Z); }
        public readonly Vector4I17F15 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, X, W); }
        public readonly Vector4I17F15 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Y, X); }
        public readonly Vector4I17F15 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Y, Y); }
        public readonly Vector4I17F15 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Y, Z); }
        public readonly Vector4I17F15 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Y, W); }
        public readonly Vector4I17F15 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Z, X); }
        public readonly Vector4I17F15 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Z, Y); }
        public readonly Vector4I17F15 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Z, Z); }
        public readonly Vector4I17F15 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Z, W); }
        public readonly Vector4I17F15 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, W, X); }
        public readonly Vector4I17F15 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, W, Y); }
        public readonly Vector4I17F15 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, W, Z); }
        public readonly Vector4I17F15 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, W, W); }
        public readonly Vector4I17F15 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, X, X); }
        public readonly Vector4I17F15 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, X, Y); }
        public readonly Vector4I17F15 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, X, Z); }
        public readonly Vector4I17F15 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, X, W); }
        public readonly Vector4I17F15 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, Y, X); }
        public readonly Vector4I17F15 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, Y, Y); }
        public readonly Vector4I17F15 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, Y, Z); }
        public readonly Vector4I17F15 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, Y, W); }
        public readonly Vector4I17F15 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, Z, X); }
        public readonly Vector4I17F15 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, Z, Y); }
        public readonly Vector4I17F15 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, Z, Z); }
        public readonly Vector4I17F15 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, Z, W); }
        public readonly Vector4I17F15 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, W, X); }
        public readonly Vector4I17F15 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, W, Y); }
        public readonly Vector4I17F15 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, W, Z); }
        public readonly Vector4I17F15 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, W, W, W); }
        public readonly Vector4I17F15 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, X); }
        public readonly Vector4I17F15 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, Y); }
        public readonly Vector4I17F15 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, Z); }
        public readonly Vector4I17F15 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, W); }
        public readonly Vector4I17F15 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, X); }
        public readonly Vector4I17F15 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, Y); }
        public readonly Vector4I17F15 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, Z); }
        public readonly Vector4I17F15 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, W); }
        public readonly Vector4I17F15 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Z, X); }
        public readonly Vector4I17F15 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Z, Y); }
        public readonly Vector4I17F15 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Z, Z); }
        public readonly Vector4I17F15 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Z, W); }
        public readonly Vector4I17F15 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, W, X); }
        public readonly Vector4I17F15 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, W, Y); }
        public readonly Vector4I17F15 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, W, Z); }
        public readonly Vector4I17F15 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, W, W); }
        public readonly Vector4I17F15 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, X); }
        public readonly Vector4I17F15 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, Y); }
        public readonly Vector4I17F15 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, Z); }
        public readonly Vector4I17F15 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, W); }
        public readonly Vector4I17F15 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, X); }
        public readonly Vector4I17F15 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, Y); }
        public readonly Vector4I17F15 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, Z); }
        public readonly Vector4I17F15 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, W); }
        public readonly Vector4I17F15 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Z, X); }
        public readonly Vector4I17F15 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Z, Y); }
        public readonly Vector4I17F15 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Z, Z); }
        public readonly Vector4I17F15 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Z, W); }
        public readonly Vector4I17F15 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, W, X); }
        public readonly Vector4I17F15 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, W, Y); }
        public readonly Vector4I17F15 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, W, Z); }
        public readonly Vector4I17F15 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, W, W); }
        public readonly Vector4I17F15 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, X, X); }
        public readonly Vector4I17F15 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, X, Y); }
        public readonly Vector4I17F15 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, X, Z); }
        public readonly Vector4I17F15 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, X, W); }
        public readonly Vector4I17F15 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Y, X); }
        public readonly Vector4I17F15 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Y, Y); }
        public readonly Vector4I17F15 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Y, Z); }
        public readonly Vector4I17F15 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Y, W); }
        public readonly Vector4I17F15 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Z, X); }
        public readonly Vector4I17F15 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Z, Y); }
        public readonly Vector4I17F15 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Z, Z); }
        public readonly Vector4I17F15 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Z, W); }
        public readonly Vector4I17F15 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, W, X); }
        public readonly Vector4I17F15 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, W, Y); }
        public readonly Vector4I17F15 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, W, Z); }
        public readonly Vector4I17F15 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, W, W); }
        public readonly Vector4I17F15 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, X, X); }
        public readonly Vector4I17F15 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, X, Y); }
        public readonly Vector4I17F15 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, X, Z); }
        public readonly Vector4I17F15 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, X, W); }
        public readonly Vector4I17F15 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, Y, X); }
        public readonly Vector4I17F15 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, Y, Y); }
        public readonly Vector4I17F15 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, Y, Z); }
        public readonly Vector4I17F15 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, Y, W); }
        public readonly Vector4I17F15 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, Z, X); }
        public readonly Vector4I17F15 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, Z, Y); }
        public readonly Vector4I17F15 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, Z, Z); }
        public readonly Vector4I17F15 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, Z, W); }
        public readonly Vector4I17F15 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, W, X); }
        public readonly Vector4I17F15 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, W, Y); }
        public readonly Vector4I17F15 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, W, Z); }
        public readonly Vector4I17F15 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, W, W, W); }
        public readonly Vector4I17F15 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, X, X); }
        public readonly Vector4I17F15 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, X, Y); }
        public readonly Vector4I17F15 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, X, Z); }
        public readonly Vector4I17F15 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, X, W); }
        public readonly Vector4I17F15 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Y, X); }
        public readonly Vector4I17F15 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Y, Y); }
        public readonly Vector4I17F15 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Y, Z); }
        public readonly Vector4I17F15 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Y, W); }
        public readonly Vector4I17F15 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Z, X); }
        public readonly Vector4I17F15 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Z, Y); }
        public readonly Vector4I17F15 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Z, Z); }
        public readonly Vector4I17F15 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Z, W); }
        public readonly Vector4I17F15 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, W, X); }
        public readonly Vector4I17F15 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, W, Y); }
        public readonly Vector4I17F15 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, W, Z); }
        public readonly Vector4I17F15 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, W, W); }
        public readonly Vector4I17F15 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, X, X); }
        public readonly Vector4I17F15 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, X, Y); }
        public readonly Vector4I17F15 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, X, Z); }
        public readonly Vector4I17F15 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, X, W); }
        public readonly Vector4I17F15 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Y, X); }
        public readonly Vector4I17F15 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Y, Y); }
        public readonly Vector4I17F15 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Y, Z); }
        public readonly Vector4I17F15 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Y, W); }
        public readonly Vector4I17F15 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Z, X); }
        public readonly Vector4I17F15 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Z, Y); }
        public readonly Vector4I17F15 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Z, Z); }
        public readonly Vector4I17F15 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Z, W); }
        public readonly Vector4I17F15 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, W, X); }
        public readonly Vector4I17F15 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, W, Y); }
        public readonly Vector4I17F15 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, W, Z); }
        public readonly Vector4I17F15 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, W, W); }
        public readonly Vector4I17F15 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, X, X); }
        public readonly Vector4I17F15 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, X, Y); }
        public readonly Vector4I17F15 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, X, Z); }
        public readonly Vector4I17F15 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, X, W); }
        public readonly Vector4I17F15 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Y, X); }
        public readonly Vector4I17F15 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Y, Y); }
        public readonly Vector4I17F15 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Y, Z); }
        public readonly Vector4I17F15 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Y, W); }
        public readonly Vector4I17F15 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Z, X); }
        public readonly Vector4I17F15 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Z, Y); }
        public readonly Vector4I17F15 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Z, Z); }
        public readonly Vector4I17F15 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Z, W); }
        public readonly Vector4I17F15 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, W, X); }
        public readonly Vector4I17F15 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, W, Y); }
        public readonly Vector4I17F15 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, W, Z); }
        public readonly Vector4I17F15 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, W, W); }
        public readonly Vector4I17F15 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, X, X); }
        public readonly Vector4I17F15 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, X, Y); }
        public readonly Vector4I17F15 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, X, Z); }
        public readonly Vector4I17F15 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, X, W); }
        public readonly Vector4I17F15 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, Y, X); }
        public readonly Vector4I17F15 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, Y, Y); }
        public readonly Vector4I17F15 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, Y, Z); }
        public readonly Vector4I17F15 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, Y, W); }
        public readonly Vector4I17F15 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, Z, X); }
        public readonly Vector4I17F15 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, Z, Y); }
        public readonly Vector4I17F15 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, Z, Z); }
        public readonly Vector4I17F15 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, Z, W); }
        public readonly Vector4I17F15 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, W, X); }
        public readonly Vector4I17F15 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, W, Y); }
        public readonly Vector4I17F15 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, W, Z); }
        public readonly Vector4I17F15 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, W, W, W); }
        public readonly Vector4I17F15 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, X, X); }
        public readonly Vector4I17F15 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, X, Y); }
        public readonly Vector4I17F15 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, X, Z); }
        public readonly Vector4I17F15 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, X, W); }
        public readonly Vector4I17F15 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, Y, X); }
        public readonly Vector4I17F15 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, Y, Y); }
        public readonly Vector4I17F15 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, Y, Z); }
        public readonly Vector4I17F15 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, Y, W); }
        public readonly Vector4I17F15 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, Z, X); }
        public readonly Vector4I17F15 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, Z, Y); }
        public readonly Vector4I17F15 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, Z, Z); }
        public readonly Vector4I17F15 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, Z, W); }
        public readonly Vector4I17F15 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, W, X); }
        public readonly Vector4I17F15 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, W, Y); }
        public readonly Vector4I17F15 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, W, Z); }
        public readonly Vector4I17F15 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, X, W, W); }
        public readonly Vector4I17F15 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, X, X); }
        public readonly Vector4I17F15 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, X, Y); }
        public readonly Vector4I17F15 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, X, Z); }
        public readonly Vector4I17F15 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, X, W); }
        public readonly Vector4I17F15 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, Y, X); }
        public readonly Vector4I17F15 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, Y, Y); }
        public readonly Vector4I17F15 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, Y, Z); }
        public readonly Vector4I17F15 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, Y, W); }
        public readonly Vector4I17F15 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, Z, X); }
        public readonly Vector4I17F15 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, Z, Y); }
        public readonly Vector4I17F15 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, Z, Z); }
        public readonly Vector4I17F15 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, Z, W); }
        public readonly Vector4I17F15 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, W, X); }
        public readonly Vector4I17F15 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, W, Y); }
        public readonly Vector4I17F15 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, W, Z); }
        public readonly Vector4I17F15 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Y, W, W); }
        public readonly Vector4I17F15 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, X, X); }
        public readonly Vector4I17F15 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, X, Y); }
        public readonly Vector4I17F15 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, X, Z); }
        public readonly Vector4I17F15 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, X, W); }
        public readonly Vector4I17F15 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, Y, X); }
        public readonly Vector4I17F15 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, Y, Y); }
        public readonly Vector4I17F15 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, Y, Z); }
        public readonly Vector4I17F15 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, Y, W); }
        public readonly Vector4I17F15 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, Z, X); }
        public readonly Vector4I17F15 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, Z, Y); }
        public readonly Vector4I17F15 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, Z, Z); }
        public readonly Vector4I17F15 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, Z, W); }
        public readonly Vector4I17F15 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, W, X); }
        public readonly Vector4I17F15 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, W, Y); }
        public readonly Vector4I17F15 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, W, Z); }
        public readonly Vector4I17F15 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, Z, W, W); }
        public readonly Vector4I17F15 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, X, X); }
        public readonly Vector4I17F15 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, X, Y); }
        public readonly Vector4I17F15 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, X, Z); }
        public readonly Vector4I17F15 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, X, W); }
        public readonly Vector4I17F15 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, Y, X); }
        public readonly Vector4I17F15 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, Y, Y); }
        public readonly Vector4I17F15 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, Y, Z); }
        public readonly Vector4I17F15 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, Y, W); }
        public readonly Vector4I17F15 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, Z, X); }
        public readonly Vector4I17F15 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, Z, Y); }
        public readonly Vector4I17F15 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, Z, Z); }
        public readonly Vector4I17F15 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, Z, W); }
        public readonly Vector4I17F15 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, W, X); }
        public readonly Vector4I17F15 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, W, Y); }
        public readonly Vector4I17F15 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, W, Z); }
        public readonly Vector4I17F15 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I17F15 lhs, Vector4I17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I17F15 lhs, Vector4I17F15 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I17F15({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I17F15 other)
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
            return $"Vector4I17F15({x}, {y}, {z}, {w})";
        }
    }
}
