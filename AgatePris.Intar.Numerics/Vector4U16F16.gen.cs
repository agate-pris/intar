using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector4U16F16 : IEquatable<Vector4U16F16>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U16F16 X;
        public U16F16 Y;
        public U16F16 Z;
        public U16F16 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4U16F16 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, U16F16 y, U16F16 z, U16F16 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, U16F16 y, Vector2U16F16 zw) {
            X = x;
            Y = y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, Vector3U16F16 yzw) {
            X = x;
            Y = yzw.X;
            Z = yzw.Y;
            W = yzw.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector2U16F16 xy, Vector2U16F16 zw) {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector4U16F16 xyzw) {
            X = xyzw.X;
            Y = xyzw.Y;
            Z = xyzw.Z;
            W = xyzw.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, Vector2U16F16 yz, U16F16 w) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector3U16F16 xyz, U16F16 w) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector2U16F16 xy, U16F16 z, U16F16 w) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator +(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator -(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(Vector4U16F16 a, U16F16 b) => new Vector4U16F16(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(Vector4U16F16 a, U16F16 b) => new Vector4U16F16(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U16F16 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, X); }
        public readonly Vector2U16F16 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, Y); }
        public readonly Vector2U16F16 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, Z); }
        public readonly Vector2U16F16 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, W); }
        public readonly Vector2U16F16 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, X); }
        public readonly Vector2U16F16 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, Y); }
        public readonly Vector2U16F16 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, Z); }
        public readonly Vector2U16F16 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, W); }
        public readonly Vector2U16F16 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, X); }
        public readonly Vector2U16F16 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, Y); }
        public readonly Vector2U16F16 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, Z); }
        public readonly Vector2U16F16 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, W); }
        public readonly Vector2U16F16 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(W, X); }
        public readonly Vector2U16F16 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(W, Y); }
        public readonly Vector2U16F16 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(W, Z); }
        public readonly Vector2U16F16 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(W, W); }
        public readonly Vector3U16F16 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, X); }
        public readonly Vector3U16F16 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, Y); }
        public readonly Vector3U16F16 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, Z); }
        public readonly Vector3U16F16 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, W); }
        public readonly Vector3U16F16 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, X); }
        public readonly Vector3U16F16 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, Y); }
        public readonly Vector3U16F16 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, Z); }
        public readonly Vector3U16F16 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, W); }
        public readonly Vector3U16F16 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, X); }
        public readonly Vector3U16F16 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, Y); }
        public readonly Vector3U16F16 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, Z); }
        public readonly Vector3U16F16 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, W); }
        public readonly Vector3U16F16 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, W, X); }
        public readonly Vector3U16F16 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, W, Y); }
        public readonly Vector3U16F16 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, W, Z); }
        public readonly Vector3U16F16 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, W, W); }
        public readonly Vector3U16F16 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, X); }
        public readonly Vector3U16F16 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, Y); }
        public readonly Vector3U16F16 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, Z); }
        public readonly Vector3U16F16 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, W); }
        public readonly Vector3U16F16 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, X); }
        public readonly Vector3U16F16 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, Y); }
        public readonly Vector3U16F16 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, Z); }
        public readonly Vector3U16F16 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, W); }
        public readonly Vector3U16F16 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, X); }
        public readonly Vector3U16F16 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, Y); }
        public readonly Vector3U16F16 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, Z); }
        public readonly Vector3U16F16 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, W); }
        public readonly Vector3U16F16 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, W, X); }
        public readonly Vector3U16F16 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, W, Y); }
        public readonly Vector3U16F16 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, W, Z); }
        public readonly Vector3U16F16 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, W, W); }
        public readonly Vector3U16F16 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, X); }
        public readonly Vector3U16F16 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, Y); }
        public readonly Vector3U16F16 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, Z); }
        public readonly Vector3U16F16 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, W); }
        public readonly Vector3U16F16 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, X); }
        public readonly Vector3U16F16 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, Y); }
        public readonly Vector3U16F16 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, Z); }
        public readonly Vector3U16F16 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, W); }
        public readonly Vector3U16F16 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, X); }
        public readonly Vector3U16F16 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, Y); }
        public readonly Vector3U16F16 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, Z); }
        public readonly Vector3U16F16 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, W); }
        public readonly Vector3U16F16 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, W, X); }
        public readonly Vector3U16F16 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, W, Y); }
        public readonly Vector3U16F16 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, W, Z); }
        public readonly Vector3U16F16 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, W, W); }
        public readonly Vector3U16F16 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, X, X); }
        public readonly Vector3U16F16 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, X, Y); }
        public readonly Vector3U16F16 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, X, Z); }
        public readonly Vector3U16F16 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, X, W); }
        public readonly Vector3U16F16 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Y, X); }
        public readonly Vector3U16F16 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Y, Y); }
        public readonly Vector3U16F16 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Y, Z); }
        public readonly Vector3U16F16 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Y, W); }
        public readonly Vector3U16F16 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Z, X); }
        public readonly Vector3U16F16 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Z, Y); }
        public readonly Vector3U16F16 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Z, Z); }
        public readonly Vector3U16F16 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Z, W); }
        public readonly Vector3U16F16 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, W, X); }
        public readonly Vector3U16F16 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, W, Y); }
        public readonly Vector3U16F16 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, W, Z); }
        public readonly Vector3U16F16 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, W, W); }
        public readonly Vector4U16F16 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, X); }
        public readonly Vector4U16F16 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, Y); }
        public readonly Vector4U16F16 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, Z); }
        public readonly Vector4U16F16 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, W); }
        public readonly Vector4U16F16 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, X); }
        public readonly Vector4U16F16 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, Y); }
        public readonly Vector4U16F16 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, Z); }
        public readonly Vector4U16F16 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, W); }
        public readonly Vector4U16F16 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, X); }
        public readonly Vector4U16F16 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, Y); }
        public readonly Vector4U16F16 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, Z); }
        public readonly Vector4U16F16 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, W); }
        public readonly Vector4U16F16 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, W, X); }
        public readonly Vector4U16F16 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, W, Y); }
        public readonly Vector4U16F16 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, W, Z); }
        public readonly Vector4U16F16 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, W, W); }
        public readonly Vector4U16F16 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, X); }
        public readonly Vector4U16F16 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, Y); }
        public readonly Vector4U16F16 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, Z); }
        public readonly Vector4U16F16 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, W); }
        public readonly Vector4U16F16 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, X); }
        public readonly Vector4U16F16 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, Y); }
        public readonly Vector4U16F16 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, Z); }
        public readonly Vector4U16F16 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, W); }
        public readonly Vector4U16F16 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, X); }
        public readonly Vector4U16F16 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, Y); }
        public readonly Vector4U16F16 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, Z); }
        public readonly Vector4U16F16 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, W); }
        public readonly Vector4U16F16 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, W, X); }
        public readonly Vector4U16F16 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, W, Y); }
        public readonly Vector4U16F16 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, W, Z); }
        public readonly Vector4U16F16 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, W, W); }
        public readonly Vector4U16F16 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, X); }
        public readonly Vector4U16F16 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, Y); }
        public readonly Vector4U16F16 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, Z); }
        public readonly Vector4U16F16 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, W); }
        public readonly Vector4U16F16 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, X); }
        public readonly Vector4U16F16 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, Y); }
        public readonly Vector4U16F16 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, Z); }
        public readonly Vector4U16F16 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, W); }
        public readonly Vector4U16F16 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, X); }
        public readonly Vector4U16F16 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, Y); }
        public readonly Vector4U16F16 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, Z); }
        public readonly Vector4U16F16 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, W); }
        public readonly Vector4U16F16 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, W, X); }
        public readonly Vector4U16F16 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, W, Y); }
        public readonly Vector4U16F16 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, W, Z); }
        public readonly Vector4U16F16 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, W, W); }
        public readonly Vector4U16F16 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, X, X); }
        public readonly Vector4U16F16 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, X, Y); }
        public readonly Vector4U16F16 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, X, Z); }
        public readonly Vector4U16F16 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, X, W); }
        public readonly Vector4U16F16 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Y, X); }
        public readonly Vector4U16F16 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Y, Y); }
        public readonly Vector4U16F16 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Y, Z); }
        public readonly Vector4U16F16 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Y, W); }
        public readonly Vector4U16F16 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Z, X); }
        public readonly Vector4U16F16 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Z, Y); }
        public readonly Vector4U16F16 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Z, Z); }
        public readonly Vector4U16F16 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Z, W); }
        public readonly Vector4U16F16 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, W, X); }
        public readonly Vector4U16F16 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, W, Y); }
        public readonly Vector4U16F16 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, W, Z); }
        public readonly Vector4U16F16 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, W, W); }
        public readonly Vector4U16F16 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, X); }
        public readonly Vector4U16F16 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, Y); }
        public readonly Vector4U16F16 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, Z); }
        public readonly Vector4U16F16 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, W); }
        public readonly Vector4U16F16 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, X); }
        public readonly Vector4U16F16 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, Y); }
        public readonly Vector4U16F16 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, Z); }
        public readonly Vector4U16F16 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, W); }
        public readonly Vector4U16F16 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, X); }
        public readonly Vector4U16F16 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, Y); }
        public readonly Vector4U16F16 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, Z); }
        public readonly Vector4U16F16 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, W); }
        public readonly Vector4U16F16 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, W, X); }
        public readonly Vector4U16F16 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, W, Y); }
        public readonly Vector4U16F16 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, W, Z); }
        public readonly Vector4U16F16 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, W, W); }
        public readonly Vector4U16F16 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, X); }
        public readonly Vector4U16F16 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, Y); }
        public readonly Vector4U16F16 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, Z); }
        public readonly Vector4U16F16 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, W); }
        public readonly Vector4U16F16 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, X); }
        public readonly Vector4U16F16 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, Y); }
        public readonly Vector4U16F16 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, Z); }
        public readonly Vector4U16F16 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, W); }
        public readonly Vector4U16F16 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, X); }
        public readonly Vector4U16F16 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, Y); }
        public readonly Vector4U16F16 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, Z); }
        public readonly Vector4U16F16 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, W); }
        public readonly Vector4U16F16 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, W, X); }
        public readonly Vector4U16F16 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, W, Y); }
        public readonly Vector4U16F16 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, W, Z); }
        public readonly Vector4U16F16 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, W, W); }
        public readonly Vector4U16F16 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, X); }
        public readonly Vector4U16F16 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, Y); }
        public readonly Vector4U16F16 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, Z); }
        public readonly Vector4U16F16 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, W); }
        public readonly Vector4U16F16 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, X); }
        public readonly Vector4U16F16 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, Y); }
        public readonly Vector4U16F16 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, Z); }
        public readonly Vector4U16F16 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, W); }
        public readonly Vector4U16F16 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, X); }
        public readonly Vector4U16F16 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, Y); }
        public readonly Vector4U16F16 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, Z); }
        public readonly Vector4U16F16 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, W); }
        public readonly Vector4U16F16 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, W, X); }
        public readonly Vector4U16F16 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, W, Y); }
        public readonly Vector4U16F16 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, W, Z); }
        public readonly Vector4U16F16 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, W, W); }
        public readonly Vector4U16F16 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, X, X); }
        public readonly Vector4U16F16 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, X, Y); }
        public readonly Vector4U16F16 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, X, Z); }
        public readonly Vector4U16F16 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, X, W); }
        public readonly Vector4U16F16 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Y, X); }
        public readonly Vector4U16F16 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Y, Y); }
        public readonly Vector4U16F16 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Y, Z); }
        public readonly Vector4U16F16 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Y, W); }
        public readonly Vector4U16F16 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Z, X); }
        public readonly Vector4U16F16 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Z, Y); }
        public readonly Vector4U16F16 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Z, Z); }
        public readonly Vector4U16F16 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Z, W); }
        public readonly Vector4U16F16 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, W, X); }
        public readonly Vector4U16F16 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, W, Y); }
        public readonly Vector4U16F16 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, W, Z); }
        public readonly Vector4U16F16 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, W, W); }
        public readonly Vector4U16F16 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, X); }
        public readonly Vector4U16F16 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, Y); }
        public readonly Vector4U16F16 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, Z); }
        public readonly Vector4U16F16 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, W); }
        public readonly Vector4U16F16 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, X); }
        public readonly Vector4U16F16 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, Y); }
        public readonly Vector4U16F16 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, Z); }
        public readonly Vector4U16F16 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, W); }
        public readonly Vector4U16F16 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, X); }
        public readonly Vector4U16F16 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, Y); }
        public readonly Vector4U16F16 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, Z); }
        public readonly Vector4U16F16 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, W); }
        public readonly Vector4U16F16 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, W, X); }
        public readonly Vector4U16F16 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, W, Y); }
        public readonly Vector4U16F16 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, W, Z); }
        public readonly Vector4U16F16 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, W, W); }
        public readonly Vector4U16F16 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, X); }
        public readonly Vector4U16F16 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, Y); }
        public readonly Vector4U16F16 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, Z); }
        public readonly Vector4U16F16 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, W); }
        public readonly Vector4U16F16 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, X); }
        public readonly Vector4U16F16 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, Y); }
        public readonly Vector4U16F16 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, Z); }
        public readonly Vector4U16F16 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, W); }
        public readonly Vector4U16F16 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, X); }
        public readonly Vector4U16F16 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, Y); }
        public readonly Vector4U16F16 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, Z); }
        public readonly Vector4U16F16 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, W); }
        public readonly Vector4U16F16 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, W, X); }
        public readonly Vector4U16F16 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, W, Y); }
        public readonly Vector4U16F16 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, W, Z); }
        public readonly Vector4U16F16 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, W, W); }
        public readonly Vector4U16F16 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, X); }
        public readonly Vector4U16F16 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, Y); }
        public readonly Vector4U16F16 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, Z); }
        public readonly Vector4U16F16 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, W); }
        public readonly Vector4U16F16 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, X); }
        public readonly Vector4U16F16 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, Y); }
        public readonly Vector4U16F16 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, Z); }
        public readonly Vector4U16F16 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, W); }
        public readonly Vector4U16F16 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, X); }
        public readonly Vector4U16F16 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, Y); }
        public readonly Vector4U16F16 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, Z); }
        public readonly Vector4U16F16 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, W); }
        public readonly Vector4U16F16 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, W, X); }
        public readonly Vector4U16F16 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, W, Y); }
        public readonly Vector4U16F16 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, W, Z); }
        public readonly Vector4U16F16 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, W, W); }
        public readonly Vector4U16F16 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, X, X); }
        public readonly Vector4U16F16 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, X, Y); }
        public readonly Vector4U16F16 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, X, Z); }
        public readonly Vector4U16F16 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, X, W); }
        public readonly Vector4U16F16 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Y, X); }
        public readonly Vector4U16F16 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Y, Y); }
        public readonly Vector4U16F16 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Y, Z); }
        public readonly Vector4U16F16 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Y, W); }
        public readonly Vector4U16F16 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Z, X); }
        public readonly Vector4U16F16 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Z, Y); }
        public readonly Vector4U16F16 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Z, Z); }
        public readonly Vector4U16F16 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Z, W); }
        public readonly Vector4U16F16 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, W, X); }
        public readonly Vector4U16F16 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, W, Y); }
        public readonly Vector4U16F16 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, W, Z); }
        public readonly Vector4U16F16 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, W, W); }
        public readonly Vector4U16F16 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, X, X); }
        public readonly Vector4U16F16 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, X, Y); }
        public readonly Vector4U16F16 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, X, Z); }
        public readonly Vector4U16F16 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, X, W); }
        public readonly Vector4U16F16 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Y, X); }
        public readonly Vector4U16F16 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Y, Y); }
        public readonly Vector4U16F16 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Y, Z); }
        public readonly Vector4U16F16 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Y, W); }
        public readonly Vector4U16F16 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Z, X); }
        public readonly Vector4U16F16 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Z, Y); }
        public readonly Vector4U16F16 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Z, Z); }
        public readonly Vector4U16F16 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Z, W); }
        public readonly Vector4U16F16 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, W, X); }
        public readonly Vector4U16F16 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, W, Y); }
        public readonly Vector4U16F16 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, W, Z); }
        public readonly Vector4U16F16 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, W, W); }
        public readonly Vector4U16F16 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, X, X); }
        public readonly Vector4U16F16 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, X, Y); }
        public readonly Vector4U16F16 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, X, Z); }
        public readonly Vector4U16F16 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, X, W); }
        public readonly Vector4U16F16 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Y, X); }
        public readonly Vector4U16F16 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Y, Y); }
        public readonly Vector4U16F16 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Y, Z); }
        public readonly Vector4U16F16 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Y, W); }
        public readonly Vector4U16F16 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Z, X); }
        public readonly Vector4U16F16 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Z, Y); }
        public readonly Vector4U16F16 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Z, Z); }
        public readonly Vector4U16F16 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Z, W); }
        public readonly Vector4U16F16 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, W, X); }
        public readonly Vector4U16F16 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, W, Y); }
        public readonly Vector4U16F16 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, W, Z); }
        public readonly Vector4U16F16 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, W, W); }
        public readonly Vector4U16F16 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, X, X); }
        public readonly Vector4U16F16 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, X, Y); }
        public readonly Vector4U16F16 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, X, Z); }
        public readonly Vector4U16F16 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, X, W); }
        public readonly Vector4U16F16 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Y, X); }
        public readonly Vector4U16F16 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Y, Y); }
        public readonly Vector4U16F16 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Y, Z); }
        public readonly Vector4U16F16 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Y, W); }
        public readonly Vector4U16F16 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Z, X); }
        public readonly Vector4U16F16 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Z, Y); }
        public readonly Vector4U16F16 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Z, Z); }
        public readonly Vector4U16F16 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Z, W); }
        public readonly Vector4U16F16 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, W, X); }
        public readonly Vector4U16F16 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, W, Y); }
        public readonly Vector4U16F16 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, W, Z); }
        public readonly Vector4U16F16 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, W, W); }
        public readonly Vector4U16F16 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, X, X); }
        public readonly Vector4U16F16 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, X, Y); }
        public readonly Vector4U16F16 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, X, Z); }
        public readonly Vector4U16F16 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, X, W); }
        public readonly Vector4U16F16 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Y, X); }
        public readonly Vector4U16F16 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Y, Y); }
        public readonly Vector4U16F16 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Y, Z); }
        public readonly Vector4U16F16 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Y, W); }
        public readonly Vector4U16F16 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Z, X); }
        public readonly Vector4U16F16 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Z, Y); }
        public readonly Vector4U16F16 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Z, Z); }
        public readonly Vector4U16F16 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Z, W); }
        public readonly Vector4U16F16 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, W, X); }
        public readonly Vector4U16F16 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, W, Y); }
        public readonly Vector4U16F16 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, W, Z); }
        public readonly Vector4U16F16 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U16F16 lhs, Vector4U16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U16F16 lhs, Vector4U16F16 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U16F16({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U16F16 other)
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
            return $"Vector4U16F16({x}, {y}, {z}, {w})";
        }
    }
}
