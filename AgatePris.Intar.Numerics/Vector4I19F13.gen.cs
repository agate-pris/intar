using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I19F13 : IEquatable<Vector4I19F13>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I19F13 X;
        public I19F13 Y;
        public I19F13 Z;
        public I19F13 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4I19F13 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, I19F13 y, I19F13 z, I19F13 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, I19F13 y, Vector2I19F13 zw) {
            X = x;
            Y = y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, Vector3I19F13 yzw) {
            X = x;
            Y = yzw.X;
            Z = yzw.Y;
            W = yzw.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector2I19F13 xy, Vector2I19F13 zw) {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector4I19F13 xyzw) {
            X = xyzw.X;
            Y = xyzw.Y;
            Z = xyzw.Z;
            W = xyzw.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, Vector2I19F13 yz, I19F13 w) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector3I19F13 xyz, I19F13 w) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector2I19F13 xy, I19F13 z, I19F13 w) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator +(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator -(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator *(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator *(Vector4I19F13 a, I19F13 b) => new Vector4I19F13(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator *(I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator /(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator /(Vector4I19F13 a, I19F13 b) => new Vector4I19F13(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator /(I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I19F13 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, X); }
        public readonly Vector2I19F13 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, Y); }
        public readonly Vector2I19F13 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, Z); }
        public readonly Vector2I19F13 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, W); }
        public readonly Vector2I19F13 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, X); }
        public readonly Vector2I19F13 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, Y); }
        public readonly Vector2I19F13 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, Z); }
        public readonly Vector2I19F13 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, W); }
        public readonly Vector2I19F13 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Z, X); }
        public readonly Vector2I19F13 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Z, Y); }
        public readonly Vector2I19F13 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Z, Z); }
        public readonly Vector2I19F13 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Z, W); }
        public readonly Vector2I19F13 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(W, X); }
        public readonly Vector2I19F13 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(W, Y); }
        public readonly Vector2I19F13 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(W, Z); }
        public readonly Vector2I19F13 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(W, W); }
        public readonly Vector3I19F13 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, X); }
        public readonly Vector3I19F13 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, Y); }
        public readonly Vector3I19F13 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, Z); }
        public readonly Vector3I19F13 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, W); }
        public readonly Vector3I19F13 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, X); }
        public readonly Vector3I19F13 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, Y); }
        public readonly Vector3I19F13 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, Z); }
        public readonly Vector3I19F13 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, W); }
        public readonly Vector3I19F13 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Z, X); }
        public readonly Vector3I19F13 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Z, Y); }
        public readonly Vector3I19F13 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Z, Z); }
        public readonly Vector3I19F13 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Z, W); }
        public readonly Vector3I19F13 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, W, X); }
        public readonly Vector3I19F13 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, W, Y); }
        public readonly Vector3I19F13 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, W, Z); }
        public readonly Vector3I19F13 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, W, W); }
        public readonly Vector3I19F13 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, X); }
        public readonly Vector3I19F13 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, Y); }
        public readonly Vector3I19F13 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, Z); }
        public readonly Vector3I19F13 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, W); }
        public readonly Vector3I19F13 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, X); }
        public readonly Vector3I19F13 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, Y); }
        public readonly Vector3I19F13 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, Z); }
        public readonly Vector3I19F13 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, W); }
        public readonly Vector3I19F13 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Z, X); }
        public readonly Vector3I19F13 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Z, Y); }
        public readonly Vector3I19F13 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Z, Z); }
        public readonly Vector3I19F13 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Z, W); }
        public readonly Vector3I19F13 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, W, X); }
        public readonly Vector3I19F13 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, W, Y); }
        public readonly Vector3I19F13 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, W, Z); }
        public readonly Vector3I19F13 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, W, W); }
        public readonly Vector3I19F13 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, X, X); }
        public readonly Vector3I19F13 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, X, Y); }
        public readonly Vector3I19F13 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, X, Z); }
        public readonly Vector3I19F13 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, X, W); }
        public readonly Vector3I19F13 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Y, X); }
        public readonly Vector3I19F13 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Y, Y); }
        public readonly Vector3I19F13 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Y, Z); }
        public readonly Vector3I19F13 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Y, W); }
        public readonly Vector3I19F13 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Z, X); }
        public readonly Vector3I19F13 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Z, Y); }
        public readonly Vector3I19F13 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Z, Z); }
        public readonly Vector3I19F13 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Z, W); }
        public readonly Vector3I19F13 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, W, X); }
        public readonly Vector3I19F13 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, W, Y); }
        public readonly Vector3I19F13 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, W, Z); }
        public readonly Vector3I19F13 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, W, W); }
        public readonly Vector3I19F13 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, X, X); }
        public readonly Vector3I19F13 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, X, Y); }
        public readonly Vector3I19F13 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, X, Z); }
        public readonly Vector3I19F13 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, X, W); }
        public readonly Vector3I19F13 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Y, X); }
        public readonly Vector3I19F13 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Y, Y); }
        public readonly Vector3I19F13 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Y, Z); }
        public readonly Vector3I19F13 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Y, W); }
        public readonly Vector3I19F13 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Z, X); }
        public readonly Vector3I19F13 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Z, Y); }
        public readonly Vector3I19F13 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Z, Z); }
        public readonly Vector3I19F13 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Z, W); }
        public readonly Vector3I19F13 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, W, X); }
        public readonly Vector3I19F13 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, W, Y); }
        public readonly Vector3I19F13 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, W, Z); }
        public readonly Vector3I19F13 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, W, W); }
        public readonly Vector4I19F13 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, X); }
        public readonly Vector4I19F13 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, Y); }
        public readonly Vector4I19F13 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, Z); }
        public readonly Vector4I19F13 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, W); }
        public readonly Vector4I19F13 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, X); }
        public readonly Vector4I19F13 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, Y); }
        public readonly Vector4I19F13 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, Z); }
        public readonly Vector4I19F13 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, W); }
        public readonly Vector4I19F13 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Z, X); }
        public readonly Vector4I19F13 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Z, Y); }
        public readonly Vector4I19F13 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Z, Z); }
        public readonly Vector4I19F13 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Z, W); }
        public readonly Vector4I19F13 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, W, X); }
        public readonly Vector4I19F13 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, W, Y); }
        public readonly Vector4I19F13 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, W, Z); }
        public readonly Vector4I19F13 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, W, W); }
        public readonly Vector4I19F13 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, X); }
        public readonly Vector4I19F13 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, Y); }
        public readonly Vector4I19F13 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, Z); }
        public readonly Vector4I19F13 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, W); }
        public readonly Vector4I19F13 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, X); }
        public readonly Vector4I19F13 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, Y); }
        public readonly Vector4I19F13 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, Z); }
        public readonly Vector4I19F13 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, W); }
        public readonly Vector4I19F13 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Z, X); }
        public readonly Vector4I19F13 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Z, Y); }
        public readonly Vector4I19F13 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Z, Z); }
        public readonly Vector4I19F13 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Z, W); }
        public readonly Vector4I19F13 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, W, X); }
        public readonly Vector4I19F13 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, W, Y); }
        public readonly Vector4I19F13 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, W, Z); }
        public readonly Vector4I19F13 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, W, W); }
        public readonly Vector4I19F13 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, X, X); }
        public readonly Vector4I19F13 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, X, Y); }
        public readonly Vector4I19F13 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, X, Z); }
        public readonly Vector4I19F13 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, X, W); }
        public readonly Vector4I19F13 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Y, X); }
        public readonly Vector4I19F13 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Y, Y); }
        public readonly Vector4I19F13 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Y, Z); }
        public readonly Vector4I19F13 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Y, W); }
        public readonly Vector4I19F13 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Z, X); }
        public readonly Vector4I19F13 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Z, Y); }
        public readonly Vector4I19F13 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Z, Z); }
        public readonly Vector4I19F13 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Z, W); }
        public readonly Vector4I19F13 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, W, X); }
        public readonly Vector4I19F13 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, W, Y); }
        public readonly Vector4I19F13 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, W, Z); }
        public readonly Vector4I19F13 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, W, W); }
        public readonly Vector4I19F13 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, X, X); }
        public readonly Vector4I19F13 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, X, Y); }
        public readonly Vector4I19F13 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, X, Z); }
        public readonly Vector4I19F13 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, X, W); }
        public readonly Vector4I19F13 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Y, X); }
        public readonly Vector4I19F13 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Y, Y); }
        public readonly Vector4I19F13 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Y, Z); }
        public readonly Vector4I19F13 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Y, W); }
        public readonly Vector4I19F13 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Z, X); }
        public readonly Vector4I19F13 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Z, Y); }
        public readonly Vector4I19F13 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Z, Z); }
        public readonly Vector4I19F13 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Z, W); }
        public readonly Vector4I19F13 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, W, X); }
        public readonly Vector4I19F13 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, W, Y); }
        public readonly Vector4I19F13 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, W, Z); }
        public readonly Vector4I19F13 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, W, W); }
        public readonly Vector4I19F13 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, X); }
        public readonly Vector4I19F13 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, Y); }
        public readonly Vector4I19F13 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, Z); }
        public readonly Vector4I19F13 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, W); }
        public readonly Vector4I19F13 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, X); }
        public readonly Vector4I19F13 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, Y); }
        public readonly Vector4I19F13 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, Z); }
        public readonly Vector4I19F13 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, W); }
        public readonly Vector4I19F13 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Z, X); }
        public readonly Vector4I19F13 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Z, Y); }
        public readonly Vector4I19F13 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Z, Z); }
        public readonly Vector4I19F13 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Z, W); }
        public readonly Vector4I19F13 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, W, X); }
        public readonly Vector4I19F13 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, W, Y); }
        public readonly Vector4I19F13 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, W, Z); }
        public readonly Vector4I19F13 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, W, W); }
        public readonly Vector4I19F13 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, X); }
        public readonly Vector4I19F13 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, Y); }
        public readonly Vector4I19F13 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, Z); }
        public readonly Vector4I19F13 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, W); }
        public readonly Vector4I19F13 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, X); }
        public readonly Vector4I19F13 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, Y); }
        public readonly Vector4I19F13 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, Z); }
        public readonly Vector4I19F13 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, W); }
        public readonly Vector4I19F13 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Z, X); }
        public readonly Vector4I19F13 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Z, Y); }
        public readonly Vector4I19F13 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Z, Z); }
        public readonly Vector4I19F13 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Z, W); }
        public readonly Vector4I19F13 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, W, X); }
        public readonly Vector4I19F13 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, W, Y); }
        public readonly Vector4I19F13 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, W, Z); }
        public readonly Vector4I19F13 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, W, W); }
        public readonly Vector4I19F13 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, X, X); }
        public readonly Vector4I19F13 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, X, Y); }
        public readonly Vector4I19F13 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, X, Z); }
        public readonly Vector4I19F13 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, X, W); }
        public readonly Vector4I19F13 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Y, X); }
        public readonly Vector4I19F13 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Y, Y); }
        public readonly Vector4I19F13 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Y, Z); }
        public readonly Vector4I19F13 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Y, W); }
        public readonly Vector4I19F13 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Z, X); }
        public readonly Vector4I19F13 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Z, Y); }
        public readonly Vector4I19F13 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Z, Z); }
        public readonly Vector4I19F13 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Z, W); }
        public readonly Vector4I19F13 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, W, X); }
        public readonly Vector4I19F13 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, W, Y); }
        public readonly Vector4I19F13 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, W, Z); }
        public readonly Vector4I19F13 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, W, W); }
        public readonly Vector4I19F13 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, X, X); }
        public readonly Vector4I19F13 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, X, Y); }
        public readonly Vector4I19F13 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, X, Z); }
        public readonly Vector4I19F13 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, X, W); }
        public readonly Vector4I19F13 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Y, X); }
        public readonly Vector4I19F13 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Y, Y); }
        public readonly Vector4I19F13 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Y, Z); }
        public readonly Vector4I19F13 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Y, W); }
        public readonly Vector4I19F13 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Z, X); }
        public readonly Vector4I19F13 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Z, Y); }
        public readonly Vector4I19F13 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Z, Z); }
        public readonly Vector4I19F13 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Z, W); }
        public readonly Vector4I19F13 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, W, X); }
        public readonly Vector4I19F13 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, W, Y); }
        public readonly Vector4I19F13 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, W, Z); }
        public readonly Vector4I19F13 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, W, W); }
        public readonly Vector4I19F13 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, X, X); }
        public readonly Vector4I19F13 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, X, Y); }
        public readonly Vector4I19F13 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, X, Z); }
        public readonly Vector4I19F13 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, X, W); }
        public readonly Vector4I19F13 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Y, X); }
        public readonly Vector4I19F13 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Y, Y); }
        public readonly Vector4I19F13 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Y, Z); }
        public readonly Vector4I19F13 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Y, W); }
        public readonly Vector4I19F13 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Z, X); }
        public readonly Vector4I19F13 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Z, Y); }
        public readonly Vector4I19F13 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Z, Z); }
        public readonly Vector4I19F13 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Z, W); }
        public readonly Vector4I19F13 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, W, X); }
        public readonly Vector4I19F13 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, W, Y); }
        public readonly Vector4I19F13 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, W, Z); }
        public readonly Vector4I19F13 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, W, W); }
        public readonly Vector4I19F13 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, X, X); }
        public readonly Vector4I19F13 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, X, Y); }
        public readonly Vector4I19F13 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, X, Z); }
        public readonly Vector4I19F13 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, X, W); }
        public readonly Vector4I19F13 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Y, X); }
        public readonly Vector4I19F13 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Y, Y); }
        public readonly Vector4I19F13 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Y, Z); }
        public readonly Vector4I19F13 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Y, W); }
        public readonly Vector4I19F13 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Z, X); }
        public readonly Vector4I19F13 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Z, Y); }
        public readonly Vector4I19F13 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Z, Z); }
        public readonly Vector4I19F13 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Z, W); }
        public readonly Vector4I19F13 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, W, X); }
        public readonly Vector4I19F13 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, W, Y); }
        public readonly Vector4I19F13 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, W, Z); }
        public readonly Vector4I19F13 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, W, W); }
        public readonly Vector4I19F13 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, X, X); }
        public readonly Vector4I19F13 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, X, Y); }
        public readonly Vector4I19F13 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, X, Z); }
        public readonly Vector4I19F13 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, X, W); }
        public readonly Vector4I19F13 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Y, X); }
        public readonly Vector4I19F13 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Y, Y); }
        public readonly Vector4I19F13 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Y, Z); }
        public readonly Vector4I19F13 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Y, W); }
        public readonly Vector4I19F13 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Z, X); }
        public readonly Vector4I19F13 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Z, Y); }
        public readonly Vector4I19F13 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Z, Z); }
        public readonly Vector4I19F13 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Z, W); }
        public readonly Vector4I19F13 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, W, X); }
        public readonly Vector4I19F13 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, W, Y); }
        public readonly Vector4I19F13 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, W, Z); }
        public readonly Vector4I19F13 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, W, W); }
        public readonly Vector4I19F13 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, X, X); }
        public readonly Vector4I19F13 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, X, Y); }
        public readonly Vector4I19F13 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, X, Z); }
        public readonly Vector4I19F13 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, X, W); }
        public readonly Vector4I19F13 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Y, X); }
        public readonly Vector4I19F13 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Y, Y); }
        public readonly Vector4I19F13 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Y, Z); }
        public readonly Vector4I19F13 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Y, W); }
        public readonly Vector4I19F13 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Z, X); }
        public readonly Vector4I19F13 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Z, Y); }
        public readonly Vector4I19F13 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Z, Z); }
        public readonly Vector4I19F13 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Z, W); }
        public readonly Vector4I19F13 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, W, X); }
        public readonly Vector4I19F13 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, W, Y); }
        public readonly Vector4I19F13 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, W, Z); }
        public readonly Vector4I19F13 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, W, W); }
        public readonly Vector4I19F13 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, X, X); }
        public readonly Vector4I19F13 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, X, Y); }
        public readonly Vector4I19F13 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, X, Z); }
        public readonly Vector4I19F13 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, X, W); }
        public readonly Vector4I19F13 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Y, X); }
        public readonly Vector4I19F13 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Y, Y); }
        public readonly Vector4I19F13 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Y, Z); }
        public readonly Vector4I19F13 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Y, W); }
        public readonly Vector4I19F13 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Z, X); }
        public readonly Vector4I19F13 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Z, Y); }
        public readonly Vector4I19F13 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Z, Z); }
        public readonly Vector4I19F13 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Z, W); }
        public readonly Vector4I19F13 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, W, X); }
        public readonly Vector4I19F13 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, W, Y); }
        public readonly Vector4I19F13 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, W, Z); }
        public readonly Vector4I19F13 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, W, W); }
        public readonly Vector4I19F13 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, X, X); }
        public readonly Vector4I19F13 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, X, Y); }
        public readonly Vector4I19F13 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, X, Z); }
        public readonly Vector4I19F13 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, X, W); }
        public readonly Vector4I19F13 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Y, X); }
        public readonly Vector4I19F13 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Y, Y); }
        public readonly Vector4I19F13 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Y, Z); }
        public readonly Vector4I19F13 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Y, W); }
        public readonly Vector4I19F13 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Z, X); }
        public readonly Vector4I19F13 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Z, Y); }
        public readonly Vector4I19F13 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Z, Z); }
        public readonly Vector4I19F13 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Z, W); }
        public readonly Vector4I19F13 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, W, X); }
        public readonly Vector4I19F13 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, W, Y); }
        public readonly Vector4I19F13 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, W, Z); }
        public readonly Vector4I19F13 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, W, W); }
        public readonly Vector4I19F13 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, X, X); }
        public readonly Vector4I19F13 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, X, Y); }
        public readonly Vector4I19F13 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, X, Z); }
        public readonly Vector4I19F13 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, X, W); }
        public readonly Vector4I19F13 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Y, X); }
        public readonly Vector4I19F13 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Y, Y); }
        public readonly Vector4I19F13 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Y, Z); }
        public readonly Vector4I19F13 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Y, W); }
        public readonly Vector4I19F13 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Z, X); }
        public readonly Vector4I19F13 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Z, Y); }
        public readonly Vector4I19F13 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Z, Z); }
        public readonly Vector4I19F13 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Z, W); }
        public readonly Vector4I19F13 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, W, X); }
        public readonly Vector4I19F13 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, W, Y); }
        public readonly Vector4I19F13 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, W, Z); }
        public readonly Vector4I19F13 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, W, W); }
        public readonly Vector4I19F13 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, X, X); }
        public readonly Vector4I19F13 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, X, Y); }
        public readonly Vector4I19F13 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, X, Z); }
        public readonly Vector4I19F13 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, X, W); }
        public readonly Vector4I19F13 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Y, X); }
        public readonly Vector4I19F13 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Y, Y); }
        public readonly Vector4I19F13 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Y, Z); }
        public readonly Vector4I19F13 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Y, W); }
        public readonly Vector4I19F13 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Z, X); }
        public readonly Vector4I19F13 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Z, Y); }
        public readonly Vector4I19F13 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Z, Z); }
        public readonly Vector4I19F13 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Z, W); }
        public readonly Vector4I19F13 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, W, X); }
        public readonly Vector4I19F13 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, W, Y); }
        public readonly Vector4I19F13 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, W, Z); }
        public readonly Vector4I19F13 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I19F13 lhs, Vector4I19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I19F13 lhs, Vector4I19F13 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I19F13({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I19F13>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I19F13 other)
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
            return $"Vector4I19F13({x}, {y}, {z}, {w})";
        }
    }
}
