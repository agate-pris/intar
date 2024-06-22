using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U22F10 : IEquatable<Vector4U22F10>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U22F10 X;
        public U22F10 Y;
        public U22F10 Z;
        public U22F10 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4U22F10 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(U22F10 x, U22F10 y, U22F10 z, U22F10 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(U22F10 x, U22F10 y, Vector2U22F10 zw) {
            X = x;
            Y = y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(U22F10 x, Vector3U22F10 yzw) {
            X = x;
            Y = yzw.X;
            Z = yzw.Y;
            W = yzw.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(Vector2U22F10 xy, Vector2U22F10 zw) {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(Vector4U22F10 xyzw) {
            X = xyzw.X;
            Y = xyzw.Y;
            Z = xyzw.Z;
            W = xyzw.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(U22F10 x, Vector2U22F10 yz, U22F10 w) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(Vector3U22F10 xyz, U22F10 w) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(Vector2U22F10 xy, U22F10 z, U22F10 w) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator +(Vector4U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator -(Vector4U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator *(Vector4U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator *(Vector4U22F10 a, U22F10 b) => new Vector4U22F10(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator *(U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator /(Vector4U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator /(Vector4U22F10 a, U22F10 b) => new Vector4U22F10(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator /(U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U22F10 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, X); }
        public readonly Vector2U22F10 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, Y); }
        public readonly Vector2U22F10 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, Z); }
        public readonly Vector2U22F10 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, W); }
        public readonly Vector2U22F10 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, X); }
        public readonly Vector2U22F10 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, Y); }
        public readonly Vector2U22F10 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, Z); }
        public readonly Vector2U22F10 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, W); }
        public readonly Vector2U22F10 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Z, X); }
        public readonly Vector2U22F10 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Z, Y); }
        public readonly Vector2U22F10 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Z, Z); }
        public readonly Vector2U22F10 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Z, W); }
        public readonly Vector2U22F10 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(W, X); }
        public readonly Vector2U22F10 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(W, Y); }
        public readonly Vector2U22F10 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(W, Z); }
        public readonly Vector2U22F10 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(W, W); }
        public readonly Vector3U22F10 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, X); }
        public readonly Vector3U22F10 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, Y); }
        public readonly Vector3U22F10 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, Z); }
        public readonly Vector3U22F10 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, W); }
        public readonly Vector3U22F10 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, X); }
        public readonly Vector3U22F10 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, Y); }
        public readonly Vector3U22F10 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, Z); }
        public readonly Vector3U22F10 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, W); }
        public readonly Vector3U22F10 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Z, X); }
        public readonly Vector3U22F10 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Z, Y); }
        public readonly Vector3U22F10 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Z, Z); }
        public readonly Vector3U22F10 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Z, W); }
        public readonly Vector3U22F10 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, W, X); }
        public readonly Vector3U22F10 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, W, Y); }
        public readonly Vector3U22F10 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, W, Z); }
        public readonly Vector3U22F10 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, W, W); }
        public readonly Vector3U22F10 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, X); }
        public readonly Vector3U22F10 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, Y); }
        public readonly Vector3U22F10 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, Z); }
        public readonly Vector3U22F10 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, W); }
        public readonly Vector3U22F10 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, X); }
        public readonly Vector3U22F10 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, Y); }
        public readonly Vector3U22F10 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, Z); }
        public readonly Vector3U22F10 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, W); }
        public readonly Vector3U22F10 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Z, X); }
        public readonly Vector3U22F10 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Z, Y); }
        public readonly Vector3U22F10 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Z, Z); }
        public readonly Vector3U22F10 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Z, W); }
        public readonly Vector3U22F10 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, W, X); }
        public readonly Vector3U22F10 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, W, Y); }
        public readonly Vector3U22F10 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, W, Z); }
        public readonly Vector3U22F10 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, W, W); }
        public readonly Vector3U22F10 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, X, X); }
        public readonly Vector3U22F10 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, X, Y); }
        public readonly Vector3U22F10 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, X, Z); }
        public readonly Vector3U22F10 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, X, W); }
        public readonly Vector3U22F10 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Y, X); }
        public readonly Vector3U22F10 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Y, Y); }
        public readonly Vector3U22F10 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Y, Z); }
        public readonly Vector3U22F10 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Y, W); }
        public readonly Vector3U22F10 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Z, X); }
        public readonly Vector3U22F10 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Z, Y); }
        public readonly Vector3U22F10 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Z, Z); }
        public readonly Vector3U22F10 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, Z, W); }
        public readonly Vector3U22F10 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, W, X); }
        public readonly Vector3U22F10 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, W, Y); }
        public readonly Vector3U22F10 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, W, Z); }
        public readonly Vector3U22F10 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Z, W, W); }
        public readonly Vector3U22F10 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, X, X); }
        public readonly Vector3U22F10 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, X, Y); }
        public readonly Vector3U22F10 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, X, Z); }
        public readonly Vector3U22F10 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, X, W); }
        public readonly Vector3U22F10 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, Y, X); }
        public readonly Vector3U22F10 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, Y, Y); }
        public readonly Vector3U22F10 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, Y, Z); }
        public readonly Vector3U22F10 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, Y, W); }
        public readonly Vector3U22F10 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, Z, X); }
        public readonly Vector3U22F10 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, Z, Y); }
        public readonly Vector3U22F10 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, Z, Z); }
        public readonly Vector3U22F10 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, Z, W); }
        public readonly Vector3U22F10 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, W, X); }
        public readonly Vector3U22F10 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, W, Y); }
        public readonly Vector3U22F10 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, W, Z); }
        public readonly Vector3U22F10 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(W, W, W); }
        public readonly Vector4U22F10 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, X); }
        public readonly Vector4U22F10 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, Y); }
        public readonly Vector4U22F10 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, Z); }
        public readonly Vector4U22F10 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, W); }
        public readonly Vector4U22F10 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, X); }
        public readonly Vector4U22F10 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, Y); }
        public readonly Vector4U22F10 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, Z); }
        public readonly Vector4U22F10 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, W); }
        public readonly Vector4U22F10 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Z, X); }
        public readonly Vector4U22F10 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Z, Y); }
        public readonly Vector4U22F10 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Z, Z); }
        public readonly Vector4U22F10 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Z, W); }
        public readonly Vector4U22F10 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, W, X); }
        public readonly Vector4U22F10 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, W, Y); }
        public readonly Vector4U22F10 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, W, Z); }
        public readonly Vector4U22F10 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, W, W); }
        public readonly Vector4U22F10 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, X); }
        public readonly Vector4U22F10 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, Y); }
        public readonly Vector4U22F10 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, Z); }
        public readonly Vector4U22F10 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, W); }
        public readonly Vector4U22F10 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, X); }
        public readonly Vector4U22F10 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, Y); }
        public readonly Vector4U22F10 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, Z); }
        public readonly Vector4U22F10 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, W); }
        public readonly Vector4U22F10 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Z, X); }
        public readonly Vector4U22F10 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Z, Y); }
        public readonly Vector4U22F10 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Z, Z); }
        public readonly Vector4U22F10 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Z, W); }
        public readonly Vector4U22F10 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, W, X); }
        public readonly Vector4U22F10 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, W, Y); }
        public readonly Vector4U22F10 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, W, Z); }
        public readonly Vector4U22F10 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, W, W); }
        public readonly Vector4U22F10 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, X, X); }
        public readonly Vector4U22F10 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, X, Y); }
        public readonly Vector4U22F10 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, X, Z); }
        public readonly Vector4U22F10 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, X, W); }
        public readonly Vector4U22F10 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Y, X); }
        public readonly Vector4U22F10 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Y, Y); }
        public readonly Vector4U22F10 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Y, Z); }
        public readonly Vector4U22F10 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Y, W); }
        public readonly Vector4U22F10 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Z, X); }
        public readonly Vector4U22F10 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Z, Y); }
        public readonly Vector4U22F10 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Z, Z); }
        public readonly Vector4U22F10 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, Z, W); }
        public readonly Vector4U22F10 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, W, X); }
        public readonly Vector4U22F10 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, W, Y); }
        public readonly Vector4U22F10 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, W, Z); }
        public readonly Vector4U22F10 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Z, W, W); }
        public readonly Vector4U22F10 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, X, X); }
        public readonly Vector4U22F10 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, X, Y); }
        public readonly Vector4U22F10 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, X, Z); }
        public readonly Vector4U22F10 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, X, W); }
        public readonly Vector4U22F10 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, Y, X); }
        public readonly Vector4U22F10 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, Y, Y); }
        public readonly Vector4U22F10 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, Y, Z); }
        public readonly Vector4U22F10 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, Y, W); }
        public readonly Vector4U22F10 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, Z, X); }
        public readonly Vector4U22F10 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, Z, Y); }
        public readonly Vector4U22F10 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, Z, Z); }
        public readonly Vector4U22F10 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, Z, W); }
        public readonly Vector4U22F10 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, W, X); }
        public readonly Vector4U22F10 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, W, Y); }
        public readonly Vector4U22F10 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, W, Z); }
        public readonly Vector4U22F10 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, W, W, W); }
        public readonly Vector4U22F10 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, X); }
        public readonly Vector4U22F10 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, Y); }
        public readonly Vector4U22F10 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, Z); }
        public readonly Vector4U22F10 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, W); }
        public readonly Vector4U22F10 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, X); }
        public readonly Vector4U22F10 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, Y); }
        public readonly Vector4U22F10 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, Z); }
        public readonly Vector4U22F10 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, W); }
        public readonly Vector4U22F10 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Z, X); }
        public readonly Vector4U22F10 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Z, Y); }
        public readonly Vector4U22F10 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Z, Z); }
        public readonly Vector4U22F10 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Z, W); }
        public readonly Vector4U22F10 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, W, X); }
        public readonly Vector4U22F10 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, W, Y); }
        public readonly Vector4U22F10 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, W, Z); }
        public readonly Vector4U22F10 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, W, W); }
        public readonly Vector4U22F10 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, X); }
        public readonly Vector4U22F10 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, Y); }
        public readonly Vector4U22F10 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, Z); }
        public readonly Vector4U22F10 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, W); }
        public readonly Vector4U22F10 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, X); }
        public readonly Vector4U22F10 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, Y); }
        public readonly Vector4U22F10 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, Z); }
        public readonly Vector4U22F10 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, W); }
        public readonly Vector4U22F10 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Z, X); }
        public readonly Vector4U22F10 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Z, Y); }
        public readonly Vector4U22F10 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Z, Z); }
        public readonly Vector4U22F10 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Z, W); }
        public readonly Vector4U22F10 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, W, X); }
        public readonly Vector4U22F10 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, W, Y); }
        public readonly Vector4U22F10 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, W, Z); }
        public readonly Vector4U22F10 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, W, W); }
        public readonly Vector4U22F10 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, X, X); }
        public readonly Vector4U22F10 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, X, Y); }
        public readonly Vector4U22F10 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, X, Z); }
        public readonly Vector4U22F10 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, X, W); }
        public readonly Vector4U22F10 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Y, X); }
        public readonly Vector4U22F10 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Y, Y); }
        public readonly Vector4U22F10 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Y, Z); }
        public readonly Vector4U22F10 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Y, W); }
        public readonly Vector4U22F10 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Z, X); }
        public readonly Vector4U22F10 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Z, Y); }
        public readonly Vector4U22F10 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Z, Z); }
        public readonly Vector4U22F10 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, Z, W); }
        public readonly Vector4U22F10 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, W, X); }
        public readonly Vector4U22F10 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, W, Y); }
        public readonly Vector4U22F10 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, W, Z); }
        public readonly Vector4U22F10 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Z, W, W); }
        public readonly Vector4U22F10 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, X, X); }
        public readonly Vector4U22F10 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, X, Y); }
        public readonly Vector4U22F10 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, X, Z); }
        public readonly Vector4U22F10 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, X, W); }
        public readonly Vector4U22F10 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, Y, X); }
        public readonly Vector4U22F10 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, Y, Y); }
        public readonly Vector4U22F10 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, Y, Z); }
        public readonly Vector4U22F10 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, Y, W); }
        public readonly Vector4U22F10 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, Z, X); }
        public readonly Vector4U22F10 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, Z, Y); }
        public readonly Vector4U22F10 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, Z, Z); }
        public readonly Vector4U22F10 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, Z, W); }
        public readonly Vector4U22F10 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, W, X); }
        public readonly Vector4U22F10 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, W, Y); }
        public readonly Vector4U22F10 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, W, Z); }
        public readonly Vector4U22F10 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, W, W, W); }
        public readonly Vector4U22F10 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, X, X); }
        public readonly Vector4U22F10 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, X, Y); }
        public readonly Vector4U22F10 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, X, Z); }
        public readonly Vector4U22F10 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, X, W); }
        public readonly Vector4U22F10 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Y, X); }
        public readonly Vector4U22F10 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Y, Y); }
        public readonly Vector4U22F10 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Y, Z); }
        public readonly Vector4U22F10 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Y, W); }
        public readonly Vector4U22F10 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Z, X); }
        public readonly Vector4U22F10 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Z, Y); }
        public readonly Vector4U22F10 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Z, Z); }
        public readonly Vector4U22F10 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, Z, W); }
        public readonly Vector4U22F10 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, W, X); }
        public readonly Vector4U22F10 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, W, Y); }
        public readonly Vector4U22F10 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, W, Z); }
        public readonly Vector4U22F10 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, X, W, W); }
        public readonly Vector4U22F10 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, X, X); }
        public readonly Vector4U22F10 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, X, Y); }
        public readonly Vector4U22F10 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, X, Z); }
        public readonly Vector4U22F10 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, X, W); }
        public readonly Vector4U22F10 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Y, X); }
        public readonly Vector4U22F10 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Y, Y); }
        public readonly Vector4U22F10 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Y, Z); }
        public readonly Vector4U22F10 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Y, W); }
        public readonly Vector4U22F10 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Z, X); }
        public readonly Vector4U22F10 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Z, Y); }
        public readonly Vector4U22F10 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Z, Z); }
        public readonly Vector4U22F10 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, Z, W); }
        public readonly Vector4U22F10 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, W, X); }
        public readonly Vector4U22F10 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, W, Y); }
        public readonly Vector4U22F10 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, W, Z); }
        public readonly Vector4U22F10 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Y, W, W); }
        public readonly Vector4U22F10 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, X, X); }
        public readonly Vector4U22F10 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, X, Y); }
        public readonly Vector4U22F10 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, X, Z); }
        public readonly Vector4U22F10 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, X, W); }
        public readonly Vector4U22F10 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Y, X); }
        public readonly Vector4U22F10 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Y, Y); }
        public readonly Vector4U22F10 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Y, Z); }
        public readonly Vector4U22F10 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Y, W); }
        public readonly Vector4U22F10 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Z, X); }
        public readonly Vector4U22F10 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Z, Y); }
        public readonly Vector4U22F10 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Z, Z); }
        public readonly Vector4U22F10 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, Z, W); }
        public readonly Vector4U22F10 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, W, X); }
        public readonly Vector4U22F10 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, W, Y); }
        public readonly Vector4U22F10 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, W, Z); }
        public readonly Vector4U22F10 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, Z, W, W); }
        public readonly Vector4U22F10 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, X, X); }
        public readonly Vector4U22F10 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, X, Y); }
        public readonly Vector4U22F10 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, X, Z); }
        public readonly Vector4U22F10 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, X, W); }
        public readonly Vector4U22F10 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, Y, X); }
        public readonly Vector4U22F10 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, Y, Y); }
        public readonly Vector4U22F10 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, Y, Z); }
        public readonly Vector4U22F10 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, Y, W); }
        public readonly Vector4U22F10 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, Z, X); }
        public readonly Vector4U22F10 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, Z, Y); }
        public readonly Vector4U22F10 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, Z, Z); }
        public readonly Vector4U22F10 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, Z, W); }
        public readonly Vector4U22F10 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, W, X); }
        public readonly Vector4U22F10 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, W, Y); }
        public readonly Vector4U22F10 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, W, Z); }
        public readonly Vector4U22F10 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Z, W, W, W); }
        public readonly Vector4U22F10 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, X, X); }
        public readonly Vector4U22F10 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, X, Y); }
        public readonly Vector4U22F10 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, X, Z); }
        public readonly Vector4U22F10 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, X, W); }
        public readonly Vector4U22F10 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, Y, X); }
        public readonly Vector4U22F10 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, Y, Y); }
        public readonly Vector4U22F10 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, Y, Z); }
        public readonly Vector4U22F10 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, Y, W); }
        public readonly Vector4U22F10 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, Z, X); }
        public readonly Vector4U22F10 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, Z, Y); }
        public readonly Vector4U22F10 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, Z, Z); }
        public readonly Vector4U22F10 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, Z, W); }
        public readonly Vector4U22F10 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, W, X); }
        public readonly Vector4U22F10 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, W, Y); }
        public readonly Vector4U22F10 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, W, Z); }
        public readonly Vector4U22F10 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, X, W, W); }
        public readonly Vector4U22F10 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, X, X); }
        public readonly Vector4U22F10 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, X, Y); }
        public readonly Vector4U22F10 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, X, Z); }
        public readonly Vector4U22F10 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, X, W); }
        public readonly Vector4U22F10 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, Y, X); }
        public readonly Vector4U22F10 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, Y, Y); }
        public readonly Vector4U22F10 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, Y, Z); }
        public readonly Vector4U22F10 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, Y, W); }
        public readonly Vector4U22F10 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, Z, X); }
        public readonly Vector4U22F10 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, Z, Y); }
        public readonly Vector4U22F10 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, Z, Z); }
        public readonly Vector4U22F10 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, Z, W); }
        public readonly Vector4U22F10 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, W, X); }
        public readonly Vector4U22F10 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, W, Y); }
        public readonly Vector4U22F10 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, W, Z); }
        public readonly Vector4U22F10 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Y, W, W); }
        public readonly Vector4U22F10 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, X, X); }
        public readonly Vector4U22F10 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, X, Y); }
        public readonly Vector4U22F10 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, X, Z); }
        public readonly Vector4U22F10 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, X, W); }
        public readonly Vector4U22F10 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, Y, X); }
        public readonly Vector4U22F10 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, Y, Y); }
        public readonly Vector4U22F10 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, Y, Z); }
        public readonly Vector4U22F10 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, Y, W); }
        public readonly Vector4U22F10 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, Z, X); }
        public readonly Vector4U22F10 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, Z, Y); }
        public readonly Vector4U22F10 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, Z, Z); }
        public readonly Vector4U22F10 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, Z, W); }
        public readonly Vector4U22F10 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, W, X); }
        public readonly Vector4U22F10 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, W, Y); }
        public readonly Vector4U22F10 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, W, Z); }
        public readonly Vector4U22F10 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, Z, W, W); }
        public readonly Vector4U22F10 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, X, X); }
        public readonly Vector4U22F10 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, X, Y); }
        public readonly Vector4U22F10 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, X, Z); }
        public readonly Vector4U22F10 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, X, W); }
        public readonly Vector4U22F10 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, Y, X); }
        public readonly Vector4U22F10 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, Y, Y); }
        public readonly Vector4U22F10 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, Y, Z); }
        public readonly Vector4U22F10 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, Y, W); }
        public readonly Vector4U22F10 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, Z, X); }
        public readonly Vector4U22F10 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, Z, Y); }
        public readonly Vector4U22F10 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, Z, Z); }
        public readonly Vector4U22F10 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, Z, W); }
        public readonly Vector4U22F10 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, W, X); }
        public readonly Vector4U22F10 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, W, Y); }
        public readonly Vector4U22F10 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, W, Z); }
        public readonly Vector4U22F10 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U22F10 lhs, Vector4U22F10 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U22F10 lhs, Vector4U22F10 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U22F10 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U22F10({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U22F10>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U22F10 other)
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
            return $"Vector4U22F10({x}, {y}, {z}, {w})";
        }
    }
}
