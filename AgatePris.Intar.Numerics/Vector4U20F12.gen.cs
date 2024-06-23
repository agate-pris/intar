using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U20F12 : IEquatable<Vector4U20F12>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U20F12 X;
        public U20F12 Y;
        public U20F12 Z;
        public U20F12 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4U20F12 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(U20F12 x, U20F12 y, U20F12 z, U20F12 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(U20F12 x, U20F12 y, Vector2U20F12 zw) {
            X = x;
            Y = y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(U20F12 x, Vector3U20F12 yzw) {
            X = x;
            Y = yzw.X;
            Z = yzw.Y;
            W = yzw.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(Vector2U20F12 xy, Vector2U20F12 zw) {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(Vector4U20F12 xyzw) {
            X = xyzw.X;
            Y = xyzw.Y;
            Z = xyzw.Z;
            W = xyzw.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(U20F12 x, Vector2U20F12 yz, U20F12 w) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(Vector3U20F12 xyz, U20F12 w) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12(Vector2U20F12 xy, U20F12 z, U20F12 w) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator +(Vector4U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator -(Vector4U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator *(Vector4U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator *(Vector4U20F12 a, U20F12 b) => new Vector4U20F12(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator *(U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator /(Vector4U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator /(Vector4U20F12 a, U20F12 b) => new Vector4U20F12(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 operator /(U20F12 a, Vector4U20F12 b) => new Vector4U20F12(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U20F12 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(X, X); }
        public readonly Vector2U20F12 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(X, Y); }
        public readonly Vector2U20F12 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(X, Z); }
        public readonly Vector2U20F12 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(X, W); }
        public readonly Vector2U20F12 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(Y, X); }
        public readonly Vector2U20F12 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(Y, Y); }
        public readonly Vector2U20F12 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(Y, Z); }
        public readonly Vector2U20F12 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(Y, W); }
        public readonly Vector2U20F12 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(Z, X); }
        public readonly Vector2U20F12 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(Z, Y); }
        public readonly Vector2U20F12 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(Z, Z); }
        public readonly Vector2U20F12 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(Z, W); }
        public readonly Vector2U20F12 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(W, X); }
        public readonly Vector2U20F12 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(W, Y); }
        public readonly Vector2U20F12 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(W, Z); }
        public readonly Vector2U20F12 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(W, W); }
        public readonly Vector3U20F12 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, X, X); }
        public readonly Vector3U20F12 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, X, Y); }
        public readonly Vector3U20F12 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, X, Z); }
        public readonly Vector3U20F12 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, X, W); }
        public readonly Vector3U20F12 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, Y, X); }
        public readonly Vector3U20F12 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, Y, Y); }
        public readonly Vector3U20F12 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, Y, Z); }
        public readonly Vector3U20F12 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, Y, W); }
        public readonly Vector3U20F12 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, Z, X); }
        public readonly Vector3U20F12 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, Z, Y); }
        public readonly Vector3U20F12 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, Z, Z); }
        public readonly Vector3U20F12 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, Z, W); }
        public readonly Vector3U20F12 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, W, X); }
        public readonly Vector3U20F12 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, W, Y); }
        public readonly Vector3U20F12 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, W, Z); }
        public readonly Vector3U20F12 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, W, W); }
        public readonly Vector3U20F12 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, X, X); }
        public readonly Vector3U20F12 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, X, Y); }
        public readonly Vector3U20F12 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, X, Z); }
        public readonly Vector3U20F12 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, X, W); }
        public readonly Vector3U20F12 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, Y, X); }
        public readonly Vector3U20F12 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, Y, Y); }
        public readonly Vector3U20F12 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, Y, Z); }
        public readonly Vector3U20F12 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, Y, W); }
        public readonly Vector3U20F12 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, Z, X); }
        public readonly Vector3U20F12 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, Z, Y); }
        public readonly Vector3U20F12 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, Z, Z); }
        public readonly Vector3U20F12 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, Z, W); }
        public readonly Vector3U20F12 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, W, X); }
        public readonly Vector3U20F12 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, W, Y); }
        public readonly Vector3U20F12 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, W, Z); }
        public readonly Vector3U20F12 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, W, W); }
        public readonly Vector3U20F12 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, X, X); }
        public readonly Vector3U20F12 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, X, Y); }
        public readonly Vector3U20F12 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, X, Z); }
        public readonly Vector3U20F12 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, X, W); }
        public readonly Vector3U20F12 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, Y, X); }
        public readonly Vector3U20F12 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, Y, Y); }
        public readonly Vector3U20F12 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, Y, Z); }
        public readonly Vector3U20F12 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, Y, W); }
        public readonly Vector3U20F12 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, Z, X); }
        public readonly Vector3U20F12 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, Z, Y); }
        public readonly Vector3U20F12 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, Z, Z); }
        public readonly Vector3U20F12 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, Z, W); }
        public readonly Vector3U20F12 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, W, X); }
        public readonly Vector3U20F12 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, W, Y); }
        public readonly Vector3U20F12 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, W, Z); }
        public readonly Vector3U20F12 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Z, W, W); }
        public readonly Vector3U20F12 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, X, X); }
        public readonly Vector3U20F12 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, X, Y); }
        public readonly Vector3U20F12 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, X, Z); }
        public readonly Vector3U20F12 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, X, W); }
        public readonly Vector3U20F12 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, Y, X); }
        public readonly Vector3U20F12 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, Y, Y); }
        public readonly Vector3U20F12 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, Y, Z); }
        public readonly Vector3U20F12 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, Y, W); }
        public readonly Vector3U20F12 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, Z, X); }
        public readonly Vector3U20F12 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, Z, Y); }
        public readonly Vector3U20F12 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, Z, Z); }
        public readonly Vector3U20F12 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, Z, W); }
        public readonly Vector3U20F12 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, W, X); }
        public readonly Vector3U20F12 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, W, Y); }
        public readonly Vector3U20F12 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, W, Z); }
        public readonly Vector3U20F12 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(W, W, W); }
        public readonly Vector4U20F12 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, X, X); }
        public readonly Vector4U20F12 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, X, Y); }
        public readonly Vector4U20F12 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, X, Z); }
        public readonly Vector4U20F12 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, X, W); }
        public readonly Vector4U20F12 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, Y, X); }
        public readonly Vector4U20F12 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, Y, Y); }
        public readonly Vector4U20F12 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, Y, Z); }
        public readonly Vector4U20F12 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, Y, W); }
        public readonly Vector4U20F12 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, Z, X); }
        public readonly Vector4U20F12 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, Z, Y); }
        public readonly Vector4U20F12 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, Z, Z); }
        public readonly Vector4U20F12 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, Z, W); }
        public readonly Vector4U20F12 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, W, X); }
        public readonly Vector4U20F12 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, W, Y); }
        public readonly Vector4U20F12 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, W, Z); }
        public readonly Vector4U20F12 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, W, W); }
        public readonly Vector4U20F12 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, X, X); }
        public readonly Vector4U20F12 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, X, Y); }
        public readonly Vector4U20F12 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, X, Z); }
        public readonly Vector4U20F12 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, X, W); }
        public readonly Vector4U20F12 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, Y, X); }
        public readonly Vector4U20F12 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, Y, Y); }
        public readonly Vector4U20F12 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, Y, Z); }
        public readonly Vector4U20F12 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, Y, W); }
        public readonly Vector4U20F12 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, Z, X); }
        public readonly Vector4U20F12 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, Z, Y); }
        public readonly Vector4U20F12 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, Z, Z); }
        public readonly Vector4U20F12 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, Z, W); }
        public readonly Vector4U20F12 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, W, X); }
        public readonly Vector4U20F12 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, W, Y); }
        public readonly Vector4U20F12 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, W, Z); }
        public readonly Vector4U20F12 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, W, W); }
        public readonly Vector4U20F12 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, X, X); }
        public readonly Vector4U20F12 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, X, Y); }
        public readonly Vector4U20F12 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, X, Z); }
        public readonly Vector4U20F12 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, X, W); }
        public readonly Vector4U20F12 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, Y, X); }
        public readonly Vector4U20F12 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, Y, Y); }
        public readonly Vector4U20F12 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, Y, Z); }
        public readonly Vector4U20F12 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, Y, W); }
        public readonly Vector4U20F12 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, Z, X); }
        public readonly Vector4U20F12 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, Z, Y); }
        public readonly Vector4U20F12 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, Z, Z); }
        public readonly Vector4U20F12 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, Z, W); }
        public readonly Vector4U20F12 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, W, X); }
        public readonly Vector4U20F12 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, W, Y); }
        public readonly Vector4U20F12 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, W, Z); }
        public readonly Vector4U20F12 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Z, W, W); }
        public readonly Vector4U20F12 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, X, X); }
        public readonly Vector4U20F12 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, X, Y); }
        public readonly Vector4U20F12 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, X, Z); }
        public readonly Vector4U20F12 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, X, W); }
        public readonly Vector4U20F12 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, Y, X); }
        public readonly Vector4U20F12 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, Y, Y); }
        public readonly Vector4U20F12 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, Y, Z); }
        public readonly Vector4U20F12 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, Y, W); }
        public readonly Vector4U20F12 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, Z, X); }
        public readonly Vector4U20F12 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, Z, Y); }
        public readonly Vector4U20F12 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, Z, Z); }
        public readonly Vector4U20F12 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, Z, W); }
        public readonly Vector4U20F12 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, W, X); }
        public readonly Vector4U20F12 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, W, Y); }
        public readonly Vector4U20F12 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, W, Z); }
        public readonly Vector4U20F12 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, W, W, W); }
        public readonly Vector4U20F12 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, X, X); }
        public readonly Vector4U20F12 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, X, Y); }
        public readonly Vector4U20F12 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, X, Z); }
        public readonly Vector4U20F12 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, X, W); }
        public readonly Vector4U20F12 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, Y, X); }
        public readonly Vector4U20F12 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, Y, Y); }
        public readonly Vector4U20F12 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, Y, Z); }
        public readonly Vector4U20F12 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, Y, W); }
        public readonly Vector4U20F12 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, Z, X); }
        public readonly Vector4U20F12 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, Z, Y); }
        public readonly Vector4U20F12 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, Z, Z); }
        public readonly Vector4U20F12 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, Z, W); }
        public readonly Vector4U20F12 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, W, X); }
        public readonly Vector4U20F12 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, W, Y); }
        public readonly Vector4U20F12 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, W, Z); }
        public readonly Vector4U20F12 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, W, W); }
        public readonly Vector4U20F12 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, X, X); }
        public readonly Vector4U20F12 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, X, Y); }
        public readonly Vector4U20F12 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, X, Z); }
        public readonly Vector4U20F12 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, X, W); }
        public readonly Vector4U20F12 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, Y, X); }
        public readonly Vector4U20F12 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, Y, Y); }
        public readonly Vector4U20F12 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, Y, Z); }
        public readonly Vector4U20F12 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, Y, W); }
        public readonly Vector4U20F12 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, Z, X); }
        public readonly Vector4U20F12 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, Z, Y); }
        public readonly Vector4U20F12 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, Z, Z); }
        public readonly Vector4U20F12 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, Z, W); }
        public readonly Vector4U20F12 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, W, X); }
        public readonly Vector4U20F12 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, W, Y); }
        public readonly Vector4U20F12 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, W, Z); }
        public readonly Vector4U20F12 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, W, W); }
        public readonly Vector4U20F12 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, X, X); }
        public readonly Vector4U20F12 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, X, Y); }
        public readonly Vector4U20F12 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, X, Z); }
        public readonly Vector4U20F12 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, X, W); }
        public readonly Vector4U20F12 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, Y, X); }
        public readonly Vector4U20F12 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, Y, Y); }
        public readonly Vector4U20F12 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, Y, Z); }
        public readonly Vector4U20F12 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, Y, W); }
        public readonly Vector4U20F12 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, Z, X); }
        public readonly Vector4U20F12 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, Z, Y); }
        public readonly Vector4U20F12 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, Z, Z); }
        public readonly Vector4U20F12 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, Z, W); }
        public readonly Vector4U20F12 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, W, X); }
        public readonly Vector4U20F12 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, W, Y); }
        public readonly Vector4U20F12 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, W, Z); }
        public readonly Vector4U20F12 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Z, W, W); }
        public readonly Vector4U20F12 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, X, X); }
        public readonly Vector4U20F12 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, X, Y); }
        public readonly Vector4U20F12 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, X, Z); }
        public readonly Vector4U20F12 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, X, W); }
        public readonly Vector4U20F12 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, Y, X); }
        public readonly Vector4U20F12 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, Y, Y); }
        public readonly Vector4U20F12 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, Y, Z); }
        public readonly Vector4U20F12 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, Y, W); }
        public readonly Vector4U20F12 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, Z, X); }
        public readonly Vector4U20F12 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, Z, Y); }
        public readonly Vector4U20F12 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, Z, Z); }
        public readonly Vector4U20F12 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, Z, W); }
        public readonly Vector4U20F12 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, W, X); }
        public readonly Vector4U20F12 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, W, Y); }
        public readonly Vector4U20F12 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, W, Z); }
        public readonly Vector4U20F12 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, W, W, W); }
        public readonly Vector4U20F12 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, X, X); }
        public readonly Vector4U20F12 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, X, Y); }
        public readonly Vector4U20F12 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, X, Z); }
        public readonly Vector4U20F12 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, X, W); }
        public readonly Vector4U20F12 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, Y, X); }
        public readonly Vector4U20F12 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, Y, Y); }
        public readonly Vector4U20F12 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, Y, Z); }
        public readonly Vector4U20F12 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, Y, W); }
        public readonly Vector4U20F12 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, Z, X); }
        public readonly Vector4U20F12 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, Z, Y); }
        public readonly Vector4U20F12 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, Z, Z); }
        public readonly Vector4U20F12 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, Z, W); }
        public readonly Vector4U20F12 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, W, X); }
        public readonly Vector4U20F12 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, W, Y); }
        public readonly Vector4U20F12 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, W, Z); }
        public readonly Vector4U20F12 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, X, W, W); }
        public readonly Vector4U20F12 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, X, X); }
        public readonly Vector4U20F12 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, X, Y); }
        public readonly Vector4U20F12 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, X, Z); }
        public readonly Vector4U20F12 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, X, W); }
        public readonly Vector4U20F12 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, Y, X); }
        public readonly Vector4U20F12 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, Y, Y); }
        public readonly Vector4U20F12 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, Y, Z); }
        public readonly Vector4U20F12 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, Y, W); }
        public readonly Vector4U20F12 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, Z, X); }
        public readonly Vector4U20F12 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, Z, Y); }
        public readonly Vector4U20F12 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, Z, Z); }
        public readonly Vector4U20F12 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, Z, W); }
        public readonly Vector4U20F12 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, W, X); }
        public readonly Vector4U20F12 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, W, Y); }
        public readonly Vector4U20F12 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, W, Z); }
        public readonly Vector4U20F12 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Y, W, W); }
        public readonly Vector4U20F12 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, X, X); }
        public readonly Vector4U20F12 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, X, Y); }
        public readonly Vector4U20F12 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, X, Z); }
        public readonly Vector4U20F12 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, X, W); }
        public readonly Vector4U20F12 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, Y, X); }
        public readonly Vector4U20F12 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, Y, Y); }
        public readonly Vector4U20F12 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, Y, Z); }
        public readonly Vector4U20F12 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, Y, W); }
        public readonly Vector4U20F12 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, Z, X); }
        public readonly Vector4U20F12 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, Z, Y); }
        public readonly Vector4U20F12 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, Z, Z); }
        public readonly Vector4U20F12 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, Z, W); }
        public readonly Vector4U20F12 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, W, X); }
        public readonly Vector4U20F12 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, W, Y); }
        public readonly Vector4U20F12 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, W, Z); }
        public readonly Vector4U20F12 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, Z, W, W); }
        public readonly Vector4U20F12 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, X, X); }
        public readonly Vector4U20F12 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, X, Y); }
        public readonly Vector4U20F12 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, X, Z); }
        public readonly Vector4U20F12 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, X, W); }
        public readonly Vector4U20F12 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, Y, X); }
        public readonly Vector4U20F12 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, Y, Y); }
        public readonly Vector4U20F12 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, Y, Z); }
        public readonly Vector4U20F12 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, Y, W); }
        public readonly Vector4U20F12 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, Z, X); }
        public readonly Vector4U20F12 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, Z, Y); }
        public readonly Vector4U20F12 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, Z, Z); }
        public readonly Vector4U20F12 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, Z, W); }
        public readonly Vector4U20F12 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, W, X); }
        public readonly Vector4U20F12 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, W, Y); }
        public readonly Vector4U20F12 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, W, Z); }
        public readonly Vector4U20F12 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Z, W, W, W); }
        public readonly Vector4U20F12 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, X, X); }
        public readonly Vector4U20F12 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, X, Y); }
        public readonly Vector4U20F12 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, X, Z); }
        public readonly Vector4U20F12 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, X, W); }
        public readonly Vector4U20F12 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, Y, X); }
        public readonly Vector4U20F12 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, Y, Y); }
        public readonly Vector4U20F12 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, Y, Z); }
        public readonly Vector4U20F12 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, Y, W); }
        public readonly Vector4U20F12 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, Z, X); }
        public readonly Vector4U20F12 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, Z, Y); }
        public readonly Vector4U20F12 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, Z, Z); }
        public readonly Vector4U20F12 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, Z, W); }
        public readonly Vector4U20F12 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, W, X); }
        public readonly Vector4U20F12 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, W, Y); }
        public readonly Vector4U20F12 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, W, Z); }
        public readonly Vector4U20F12 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, X, W, W); }
        public readonly Vector4U20F12 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, X, X); }
        public readonly Vector4U20F12 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, X, Y); }
        public readonly Vector4U20F12 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, X, Z); }
        public readonly Vector4U20F12 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, X, W); }
        public readonly Vector4U20F12 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, Y, X); }
        public readonly Vector4U20F12 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, Y, Y); }
        public readonly Vector4U20F12 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, Y, Z); }
        public readonly Vector4U20F12 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, Y, W); }
        public readonly Vector4U20F12 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, Z, X); }
        public readonly Vector4U20F12 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, Z, Y); }
        public readonly Vector4U20F12 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, Z, Z); }
        public readonly Vector4U20F12 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, Z, W); }
        public readonly Vector4U20F12 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, W, X); }
        public readonly Vector4U20F12 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, W, Y); }
        public readonly Vector4U20F12 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, W, Z); }
        public readonly Vector4U20F12 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Y, W, W); }
        public readonly Vector4U20F12 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, X, X); }
        public readonly Vector4U20F12 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, X, Y); }
        public readonly Vector4U20F12 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, X, Z); }
        public readonly Vector4U20F12 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, X, W); }
        public readonly Vector4U20F12 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, Y, X); }
        public readonly Vector4U20F12 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, Y, Y); }
        public readonly Vector4U20F12 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, Y, Z); }
        public readonly Vector4U20F12 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, Y, W); }
        public readonly Vector4U20F12 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, Z, X); }
        public readonly Vector4U20F12 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, Z, Y); }
        public readonly Vector4U20F12 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, Z, Z); }
        public readonly Vector4U20F12 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, Z, W); }
        public readonly Vector4U20F12 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, W, X); }
        public readonly Vector4U20F12 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, W, Y); }
        public readonly Vector4U20F12 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, W, Z); }
        public readonly Vector4U20F12 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, Z, W, W); }
        public readonly Vector4U20F12 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, X, X); }
        public readonly Vector4U20F12 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, X, Y); }
        public readonly Vector4U20F12 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, X, Z); }
        public readonly Vector4U20F12 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, X, W); }
        public readonly Vector4U20F12 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, Y, X); }
        public readonly Vector4U20F12 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, Y, Y); }
        public readonly Vector4U20F12 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, Y, Z); }
        public readonly Vector4U20F12 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, Y, W); }
        public readonly Vector4U20F12 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, Z, X); }
        public readonly Vector4U20F12 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, Z, Y); }
        public readonly Vector4U20F12 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, Z, Z); }
        public readonly Vector4U20F12 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, Z, W); }
        public readonly Vector4U20F12 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, W, X); }
        public readonly Vector4U20F12 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, W, Y); }
        public readonly Vector4U20F12 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, W, Z); }
        public readonly Vector4U20F12 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U20F12 lhs, Vector4U20F12 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U20F12 lhs, Vector4U20F12 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U20F12 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U20F12({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U20F12>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U20F12 other)
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
            return $"Vector4U20F12({x}, {y}, {z}, {w})";
        }
    }
}
