using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U9F23 : IEquatable<Vector4U9F23>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U9F23 X;
        public U9F23 Y;
        public U9F23 Z;
        public U9F23 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4U9F23 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(U9F23 x, U9F23 y, U9F23 z, U9F23 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(U9F23 x, U9F23 y, Vector2U9F23 zw) {
            X = x;
            Y = y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(U9F23 x, Vector3U9F23 yzw) {
            X = x;
            Y = yzw.X;
            Z = yzw.Y;
            W = yzw.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(Vector2U9F23 xy, Vector2U9F23 zw) {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(Vector4U9F23 xyzw) {
            X = xyzw.X;
            Y = xyzw.Y;
            Z = xyzw.Z;
            W = xyzw.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(U9F23 x, Vector2U9F23 yz, U9F23 w) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(Vector3U9F23 xyz, U9F23 w) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(Vector2U9F23 xy, U9F23 z, U9F23 w) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator +(Vector4U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator -(Vector4U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator *(Vector4U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator *(Vector4U9F23 a, U9F23 b) => new Vector4U9F23(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator *(U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator /(Vector4U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator /(Vector4U9F23 a, U9F23 b) => new Vector4U9F23(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator /(U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U9F23 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, X); }
        public readonly Vector2U9F23 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, Y); }
        public readonly Vector2U9F23 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, Z); }
        public readonly Vector2U9F23 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, W); }
        public readonly Vector2U9F23 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, X); }
        public readonly Vector2U9F23 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, Y); }
        public readonly Vector2U9F23 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, Z); }
        public readonly Vector2U9F23 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, W); }
        public readonly Vector2U9F23 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Z, X); }
        public readonly Vector2U9F23 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Z, Y); }
        public readonly Vector2U9F23 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Z, Z); }
        public readonly Vector2U9F23 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Z, W); }
        public readonly Vector2U9F23 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(W, X); }
        public readonly Vector2U9F23 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(W, Y); }
        public readonly Vector2U9F23 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(W, Z); }
        public readonly Vector2U9F23 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(W, W); }
        public readonly Vector3U9F23 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, X); }
        public readonly Vector3U9F23 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, Y); }
        public readonly Vector3U9F23 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, Z); }
        public readonly Vector3U9F23 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, W); }
        public readonly Vector3U9F23 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, X); }
        public readonly Vector3U9F23 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, Y); }
        public readonly Vector3U9F23 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, Z); }
        public readonly Vector3U9F23 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, W); }
        public readonly Vector3U9F23 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Z, X); }
        public readonly Vector3U9F23 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Z, Y); }
        public readonly Vector3U9F23 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Z, Z); }
        public readonly Vector3U9F23 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Z, W); }
        public readonly Vector3U9F23 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, W, X); }
        public readonly Vector3U9F23 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, W, Y); }
        public readonly Vector3U9F23 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, W, Z); }
        public readonly Vector3U9F23 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, W, W); }
        public readonly Vector3U9F23 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, X); }
        public readonly Vector3U9F23 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, Y); }
        public readonly Vector3U9F23 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, Z); }
        public readonly Vector3U9F23 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, W); }
        public readonly Vector3U9F23 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, X); }
        public readonly Vector3U9F23 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, Y); }
        public readonly Vector3U9F23 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, Z); }
        public readonly Vector3U9F23 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, W); }
        public readonly Vector3U9F23 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Z, X); }
        public readonly Vector3U9F23 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Z, Y); }
        public readonly Vector3U9F23 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Z, Z); }
        public readonly Vector3U9F23 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Z, W); }
        public readonly Vector3U9F23 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, W, X); }
        public readonly Vector3U9F23 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, W, Y); }
        public readonly Vector3U9F23 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, W, Z); }
        public readonly Vector3U9F23 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, W, W); }
        public readonly Vector3U9F23 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, X, X); }
        public readonly Vector3U9F23 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, X, Y); }
        public readonly Vector3U9F23 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, X, Z); }
        public readonly Vector3U9F23 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, X, W); }
        public readonly Vector3U9F23 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Y, X); }
        public readonly Vector3U9F23 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Y, Y); }
        public readonly Vector3U9F23 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Y, Z); }
        public readonly Vector3U9F23 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Y, W); }
        public readonly Vector3U9F23 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Z, X); }
        public readonly Vector3U9F23 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Z, Y); }
        public readonly Vector3U9F23 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Z, Z); }
        public readonly Vector3U9F23 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, Z, W); }
        public readonly Vector3U9F23 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, W, X); }
        public readonly Vector3U9F23 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, W, Y); }
        public readonly Vector3U9F23 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, W, Z); }
        public readonly Vector3U9F23 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Z, W, W); }
        public readonly Vector3U9F23 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, X, X); }
        public readonly Vector3U9F23 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, X, Y); }
        public readonly Vector3U9F23 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, X, Z); }
        public readonly Vector3U9F23 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, X, W); }
        public readonly Vector3U9F23 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, Y, X); }
        public readonly Vector3U9F23 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, Y, Y); }
        public readonly Vector3U9F23 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, Y, Z); }
        public readonly Vector3U9F23 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, Y, W); }
        public readonly Vector3U9F23 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, Z, X); }
        public readonly Vector3U9F23 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, Z, Y); }
        public readonly Vector3U9F23 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, Z, Z); }
        public readonly Vector3U9F23 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, Z, W); }
        public readonly Vector3U9F23 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, W, X); }
        public readonly Vector3U9F23 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, W, Y); }
        public readonly Vector3U9F23 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, W, Z); }
        public readonly Vector3U9F23 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(W, W, W); }
        public readonly Vector4U9F23 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, X); }
        public readonly Vector4U9F23 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, Y); }
        public readonly Vector4U9F23 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, Z); }
        public readonly Vector4U9F23 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, W); }
        public readonly Vector4U9F23 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, X); }
        public readonly Vector4U9F23 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, Y); }
        public readonly Vector4U9F23 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, Z); }
        public readonly Vector4U9F23 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, W); }
        public readonly Vector4U9F23 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Z, X); }
        public readonly Vector4U9F23 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Z, Y); }
        public readonly Vector4U9F23 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Z, Z); }
        public readonly Vector4U9F23 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Z, W); }
        public readonly Vector4U9F23 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, W, X); }
        public readonly Vector4U9F23 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, W, Y); }
        public readonly Vector4U9F23 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, W, Z); }
        public readonly Vector4U9F23 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, W, W); }
        public readonly Vector4U9F23 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, X); }
        public readonly Vector4U9F23 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, Y); }
        public readonly Vector4U9F23 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, Z); }
        public readonly Vector4U9F23 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, W); }
        public readonly Vector4U9F23 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, X); }
        public readonly Vector4U9F23 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, Y); }
        public readonly Vector4U9F23 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, Z); }
        public readonly Vector4U9F23 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, W); }
        public readonly Vector4U9F23 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Z, X); }
        public readonly Vector4U9F23 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Z, Y); }
        public readonly Vector4U9F23 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Z, Z); }
        public readonly Vector4U9F23 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Z, W); }
        public readonly Vector4U9F23 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, W, X); }
        public readonly Vector4U9F23 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, W, Y); }
        public readonly Vector4U9F23 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, W, Z); }
        public readonly Vector4U9F23 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, W, W); }
        public readonly Vector4U9F23 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, X, X); }
        public readonly Vector4U9F23 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, X, Y); }
        public readonly Vector4U9F23 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, X, Z); }
        public readonly Vector4U9F23 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, X, W); }
        public readonly Vector4U9F23 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Y, X); }
        public readonly Vector4U9F23 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Y, Y); }
        public readonly Vector4U9F23 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Y, Z); }
        public readonly Vector4U9F23 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Y, W); }
        public readonly Vector4U9F23 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Z, X); }
        public readonly Vector4U9F23 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Z, Y); }
        public readonly Vector4U9F23 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Z, Z); }
        public readonly Vector4U9F23 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, Z, W); }
        public readonly Vector4U9F23 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, W, X); }
        public readonly Vector4U9F23 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, W, Y); }
        public readonly Vector4U9F23 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, W, Z); }
        public readonly Vector4U9F23 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Z, W, W); }
        public readonly Vector4U9F23 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, X, X); }
        public readonly Vector4U9F23 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, X, Y); }
        public readonly Vector4U9F23 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, X, Z); }
        public readonly Vector4U9F23 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, X, W); }
        public readonly Vector4U9F23 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, Y, X); }
        public readonly Vector4U9F23 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, Y, Y); }
        public readonly Vector4U9F23 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, Y, Z); }
        public readonly Vector4U9F23 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, Y, W); }
        public readonly Vector4U9F23 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, Z, X); }
        public readonly Vector4U9F23 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, Z, Y); }
        public readonly Vector4U9F23 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, Z, Z); }
        public readonly Vector4U9F23 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, Z, W); }
        public readonly Vector4U9F23 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, W, X); }
        public readonly Vector4U9F23 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, W, Y); }
        public readonly Vector4U9F23 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, W, Z); }
        public readonly Vector4U9F23 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, W, W, W); }
        public readonly Vector4U9F23 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, X); }
        public readonly Vector4U9F23 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, Y); }
        public readonly Vector4U9F23 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, Z); }
        public readonly Vector4U9F23 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, W); }
        public readonly Vector4U9F23 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, X); }
        public readonly Vector4U9F23 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, Y); }
        public readonly Vector4U9F23 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, Z); }
        public readonly Vector4U9F23 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, W); }
        public readonly Vector4U9F23 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Z, X); }
        public readonly Vector4U9F23 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Z, Y); }
        public readonly Vector4U9F23 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Z, Z); }
        public readonly Vector4U9F23 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Z, W); }
        public readonly Vector4U9F23 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, W, X); }
        public readonly Vector4U9F23 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, W, Y); }
        public readonly Vector4U9F23 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, W, Z); }
        public readonly Vector4U9F23 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, W, W); }
        public readonly Vector4U9F23 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, X); }
        public readonly Vector4U9F23 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, Y); }
        public readonly Vector4U9F23 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, Z); }
        public readonly Vector4U9F23 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, W); }
        public readonly Vector4U9F23 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, X); }
        public readonly Vector4U9F23 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, Y); }
        public readonly Vector4U9F23 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, Z); }
        public readonly Vector4U9F23 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, W); }
        public readonly Vector4U9F23 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Z, X); }
        public readonly Vector4U9F23 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Z, Y); }
        public readonly Vector4U9F23 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Z, Z); }
        public readonly Vector4U9F23 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Z, W); }
        public readonly Vector4U9F23 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, W, X); }
        public readonly Vector4U9F23 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, W, Y); }
        public readonly Vector4U9F23 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, W, Z); }
        public readonly Vector4U9F23 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, W, W); }
        public readonly Vector4U9F23 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, X, X); }
        public readonly Vector4U9F23 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, X, Y); }
        public readonly Vector4U9F23 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, X, Z); }
        public readonly Vector4U9F23 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, X, W); }
        public readonly Vector4U9F23 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Y, X); }
        public readonly Vector4U9F23 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Y, Y); }
        public readonly Vector4U9F23 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Y, Z); }
        public readonly Vector4U9F23 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Y, W); }
        public readonly Vector4U9F23 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Z, X); }
        public readonly Vector4U9F23 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Z, Y); }
        public readonly Vector4U9F23 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Z, Z); }
        public readonly Vector4U9F23 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, Z, W); }
        public readonly Vector4U9F23 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, W, X); }
        public readonly Vector4U9F23 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, W, Y); }
        public readonly Vector4U9F23 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, W, Z); }
        public readonly Vector4U9F23 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Z, W, W); }
        public readonly Vector4U9F23 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, X, X); }
        public readonly Vector4U9F23 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, X, Y); }
        public readonly Vector4U9F23 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, X, Z); }
        public readonly Vector4U9F23 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, X, W); }
        public readonly Vector4U9F23 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, Y, X); }
        public readonly Vector4U9F23 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, Y, Y); }
        public readonly Vector4U9F23 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, Y, Z); }
        public readonly Vector4U9F23 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, Y, W); }
        public readonly Vector4U9F23 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, Z, X); }
        public readonly Vector4U9F23 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, Z, Y); }
        public readonly Vector4U9F23 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, Z, Z); }
        public readonly Vector4U9F23 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, Z, W); }
        public readonly Vector4U9F23 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, W, X); }
        public readonly Vector4U9F23 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, W, Y); }
        public readonly Vector4U9F23 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, W, Z); }
        public readonly Vector4U9F23 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, W, W, W); }
        public readonly Vector4U9F23 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, X, X); }
        public readonly Vector4U9F23 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, X, Y); }
        public readonly Vector4U9F23 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, X, Z); }
        public readonly Vector4U9F23 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, X, W); }
        public readonly Vector4U9F23 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Y, X); }
        public readonly Vector4U9F23 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Y, Y); }
        public readonly Vector4U9F23 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Y, Z); }
        public readonly Vector4U9F23 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Y, W); }
        public readonly Vector4U9F23 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Z, X); }
        public readonly Vector4U9F23 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Z, Y); }
        public readonly Vector4U9F23 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Z, Z); }
        public readonly Vector4U9F23 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, Z, W); }
        public readonly Vector4U9F23 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, W, X); }
        public readonly Vector4U9F23 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, W, Y); }
        public readonly Vector4U9F23 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, W, Z); }
        public readonly Vector4U9F23 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, X, W, W); }
        public readonly Vector4U9F23 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, X, X); }
        public readonly Vector4U9F23 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, X, Y); }
        public readonly Vector4U9F23 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, X, Z); }
        public readonly Vector4U9F23 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, X, W); }
        public readonly Vector4U9F23 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Y, X); }
        public readonly Vector4U9F23 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Y, Y); }
        public readonly Vector4U9F23 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Y, Z); }
        public readonly Vector4U9F23 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Y, W); }
        public readonly Vector4U9F23 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Z, X); }
        public readonly Vector4U9F23 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Z, Y); }
        public readonly Vector4U9F23 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Z, Z); }
        public readonly Vector4U9F23 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, Z, W); }
        public readonly Vector4U9F23 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, W, X); }
        public readonly Vector4U9F23 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, W, Y); }
        public readonly Vector4U9F23 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, W, Z); }
        public readonly Vector4U9F23 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Y, W, W); }
        public readonly Vector4U9F23 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, X, X); }
        public readonly Vector4U9F23 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, X, Y); }
        public readonly Vector4U9F23 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, X, Z); }
        public readonly Vector4U9F23 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, X, W); }
        public readonly Vector4U9F23 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Y, X); }
        public readonly Vector4U9F23 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Y, Y); }
        public readonly Vector4U9F23 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Y, Z); }
        public readonly Vector4U9F23 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Y, W); }
        public readonly Vector4U9F23 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Z, X); }
        public readonly Vector4U9F23 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Z, Y); }
        public readonly Vector4U9F23 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Z, Z); }
        public readonly Vector4U9F23 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, Z, W); }
        public readonly Vector4U9F23 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, W, X); }
        public readonly Vector4U9F23 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, W, Y); }
        public readonly Vector4U9F23 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, W, Z); }
        public readonly Vector4U9F23 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, Z, W, W); }
        public readonly Vector4U9F23 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, X, X); }
        public readonly Vector4U9F23 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, X, Y); }
        public readonly Vector4U9F23 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, X, Z); }
        public readonly Vector4U9F23 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, X, W); }
        public readonly Vector4U9F23 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, Y, X); }
        public readonly Vector4U9F23 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, Y, Y); }
        public readonly Vector4U9F23 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, Y, Z); }
        public readonly Vector4U9F23 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, Y, W); }
        public readonly Vector4U9F23 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, Z, X); }
        public readonly Vector4U9F23 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, Z, Y); }
        public readonly Vector4U9F23 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, Z, Z); }
        public readonly Vector4U9F23 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, Z, W); }
        public readonly Vector4U9F23 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, W, X); }
        public readonly Vector4U9F23 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, W, Y); }
        public readonly Vector4U9F23 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, W, Z); }
        public readonly Vector4U9F23 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Z, W, W, W); }
        public readonly Vector4U9F23 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, X, X); }
        public readonly Vector4U9F23 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, X, Y); }
        public readonly Vector4U9F23 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, X, Z); }
        public readonly Vector4U9F23 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, X, W); }
        public readonly Vector4U9F23 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, Y, X); }
        public readonly Vector4U9F23 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, Y, Y); }
        public readonly Vector4U9F23 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, Y, Z); }
        public readonly Vector4U9F23 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, Y, W); }
        public readonly Vector4U9F23 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, Z, X); }
        public readonly Vector4U9F23 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, Z, Y); }
        public readonly Vector4U9F23 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, Z, Z); }
        public readonly Vector4U9F23 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, Z, W); }
        public readonly Vector4U9F23 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, W, X); }
        public readonly Vector4U9F23 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, W, Y); }
        public readonly Vector4U9F23 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, W, Z); }
        public readonly Vector4U9F23 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, X, W, W); }
        public readonly Vector4U9F23 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, X, X); }
        public readonly Vector4U9F23 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, X, Y); }
        public readonly Vector4U9F23 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, X, Z); }
        public readonly Vector4U9F23 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, X, W); }
        public readonly Vector4U9F23 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, Y, X); }
        public readonly Vector4U9F23 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, Y, Y); }
        public readonly Vector4U9F23 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, Y, Z); }
        public readonly Vector4U9F23 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, Y, W); }
        public readonly Vector4U9F23 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, Z, X); }
        public readonly Vector4U9F23 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, Z, Y); }
        public readonly Vector4U9F23 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, Z, Z); }
        public readonly Vector4U9F23 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, Z, W); }
        public readonly Vector4U9F23 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, W, X); }
        public readonly Vector4U9F23 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, W, Y); }
        public readonly Vector4U9F23 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, W, Z); }
        public readonly Vector4U9F23 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Y, W, W); }
        public readonly Vector4U9F23 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, X, X); }
        public readonly Vector4U9F23 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, X, Y); }
        public readonly Vector4U9F23 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, X, Z); }
        public readonly Vector4U9F23 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, X, W); }
        public readonly Vector4U9F23 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, Y, X); }
        public readonly Vector4U9F23 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, Y, Y); }
        public readonly Vector4U9F23 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, Y, Z); }
        public readonly Vector4U9F23 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, Y, W); }
        public readonly Vector4U9F23 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, Z, X); }
        public readonly Vector4U9F23 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, Z, Y); }
        public readonly Vector4U9F23 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, Z, Z); }
        public readonly Vector4U9F23 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, Z, W); }
        public readonly Vector4U9F23 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, W, X); }
        public readonly Vector4U9F23 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, W, Y); }
        public readonly Vector4U9F23 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, W, Z); }
        public readonly Vector4U9F23 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, Z, W, W); }
        public readonly Vector4U9F23 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, X, X); }
        public readonly Vector4U9F23 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, X, Y); }
        public readonly Vector4U9F23 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, X, Z); }
        public readonly Vector4U9F23 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, X, W); }
        public readonly Vector4U9F23 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, Y, X); }
        public readonly Vector4U9F23 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, Y, Y); }
        public readonly Vector4U9F23 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, Y, Z); }
        public readonly Vector4U9F23 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, Y, W); }
        public readonly Vector4U9F23 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, Z, X); }
        public readonly Vector4U9F23 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, Z, Y); }
        public readonly Vector4U9F23 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, Z, Z); }
        public readonly Vector4U9F23 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, Z, W); }
        public readonly Vector4U9F23 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, W, X); }
        public readonly Vector4U9F23 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, W, Y); }
        public readonly Vector4U9F23 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, W, Z); }
        public readonly Vector4U9F23 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U9F23 lhs, Vector4U9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U9F23 lhs, Vector4U9F23 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U9F23({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U9F23 other)
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
            return $"Vector4U9F23({x}, {y}, {z}, {w})";
        }
    }
}
