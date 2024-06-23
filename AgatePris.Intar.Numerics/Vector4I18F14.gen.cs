using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I18F14 : IEquatable<Vector4I18F14>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I18F14 X;
        public I18F14 Y;
        public I18F14 Z;
        public I18F14 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector4I18F14 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I18F14(I18F14 x, I18F14 y, I18F14 z, I18F14 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I18F14(I18F14 x, I18F14 y, Vector2I18F14 zw) {
            X = x;
            Y = y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I18F14(I18F14 x, Vector3I18F14 yzw) {
            X = x;
            Y = yzw.X;
            Z = yzw.Y;
            W = yzw.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I18F14(Vector2I18F14 xy, Vector2I18F14 zw) {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I18F14(Vector4I18F14 xyzw) {
            X = xyzw.X;
            Y = xyzw.Y;
            Z = xyzw.Z;
            W = xyzw.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I18F14(I18F14 x, Vector2I18F14 yz, I18F14 w) {
            X = x;
            Y = yz.X;
            Z = yz.Y;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I18F14(Vector3I18F14 xyz, I18F14 w) {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I18F14(Vector2I18F14 xy, I18F14 z, I18F14 w) {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 operator +(Vector4I18F14 a, Vector4I18F14 b) => new Vector4I18F14(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 operator -(Vector4I18F14 a, Vector4I18F14 b) => new Vector4I18F14(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 operator *(Vector4I18F14 a, Vector4I18F14 b) => new Vector4I18F14(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 operator *(Vector4I18F14 a, I18F14 b) => new Vector4I18F14(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 operator *(I18F14 a, Vector4I18F14 b) => new Vector4I18F14(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 operator /(Vector4I18F14 a, Vector4I18F14 b) => new Vector4I18F14(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 operator /(Vector4I18F14 a, I18F14 b) => new Vector4I18F14(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 operator /(I18F14 a, Vector4I18F14 b) => new Vector4I18F14(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I18F14 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, X); }
        public readonly Vector2I18F14 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, Y); }
        public readonly Vector2I18F14 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, Z); }
        public readonly Vector2I18F14 xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, W); }
        public readonly Vector2I18F14 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, X); }
        public readonly Vector2I18F14 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, Y); }
        public readonly Vector2I18F14 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, Z); }
        public readonly Vector2I18F14 yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, W); }
        public readonly Vector2I18F14 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Z, X); }
        public readonly Vector2I18F14 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Z, Y); }
        public readonly Vector2I18F14 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Z, Z); }
        public readonly Vector2I18F14 zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Z, W); }
        public readonly Vector2I18F14 wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(W, X); }
        public readonly Vector2I18F14 wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(W, Y); }
        public readonly Vector2I18F14 wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(W, Z); }
        public readonly Vector2I18F14 ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(W, W); }
        public readonly Vector3I18F14 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, X); }
        public readonly Vector3I18F14 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, Y); }
        public readonly Vector3I18F14 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, Z); }
        public readonly Vector3I18F14 xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, W); }
        public readonly Vector3I18F14 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, X); }
        public readonly Vector3I18F14 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, Y); }
        public readonly Vector3I18F14 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, Z); }
        public readonly Vector3I18F14 xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, W); }
        public readonly Vector3I18F14 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Z, X); }
        public readonly Vector3I18F14 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Z, Y); }
        public readonly Vector3I18F14 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Z, Z); }
        public readonly Vector3I18F14 xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Z, W); }
        public readonly Vector3I18F14 xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, W, X); }
        public readonly Vector3I18F14 xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, W, Y); }
        public readonly Vector3I18F14 xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, W, Z); }
        public readonly Vector3I18F14 xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, W, W); }
        public readonly Vector3I18F14 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, X); }
        public readonly Vector3I18F14 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, Y); }
        public readonly Vector3I18F14 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, Z); }
        public readonly Vector3I18F14 yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, W); }
        public readonly Vector3I18F14 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, X); }
        public readonly Vector3I18F14 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, Y); }
        public readonly Vector3I18F14 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, Z); }
        public readonly Vector3I18F14 yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, W); }
        public readonly Vector3I18F14 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Z, X); }
        public readonly Vector3I18F14 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Z, Y); }
        public readonly Vector3I18F14 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Z, Z); }
        public readonly Vector3I18F14 yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Z, W); }
        public readonly Vector3I18F14 ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, W, X); }
        public readonly Vector3I18F14 ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, W, Y); }
        public readonly Vector3I18F14 ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, W, Z); }
        public readonly Vector3I18F14 yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, W, W); }
        public readonly Vector3I18F14 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, X, X); }
        public readonly Vector3I18F14 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, X, Y); }
        public readonly Vector3I18F14 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, X, Z); }
        public readonly Vector3I18F14 zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, X, W); }
        public readonly Vector3I18F14 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Y, X); }
        public readonly Vector3I18F14 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Y, Y); }
        public readonly Vector3I18F14 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Y, Z); }
        public readonly Vector3I18F14 zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Y, W); }
        public readonly Vector3I18F14 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Z, X); }
        public readonly Vector3I18F14 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Z, Y); }
        public readonly Vector3I18F14 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Z, Z); }
        public readonly Vector3I18F14 zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, Z, W); }
        public readonly Vector3I18F14 zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, W, X); }
        public readonly Vector3I18F14 zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, W, Y); }
        public readonly Vector3I18F14 zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, W, Z); }
        public readonly Vector3I18F14 zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Z, W, W); }
        public readonly Vector3I18F14 wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, X, X); }
        public readonly Vector3I18F14 wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, X, Y); }
        public readonly Vector3I18F14 wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, X, Z); }
        public readonly Vector3I18F14 wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, X, W); }
        public readonly Vector3I18F14 wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, Y, X); }
        public readonly Vector3I18F14 wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, Y, Y); }
        public readonly Vector3I18F14 wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, Y, Z); }
        public readonly Vector3I18F14 wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, Y, W); }
        public readonly Vector3I18F14 wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, Z, X); }
        public readonly Vector3I18F14 wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, Z, Y); }
        public readonly Vector3I18F14 wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, Z, Z); }
        public readonly Vector3I18F14 wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, Z, W); }
        public readonly Vector3I18F14 wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, W, X); }
        public readonly Vector3I18F14 wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, W, Y); }
        public readonly Vector3I18F14 wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, W, Z); }
        public readonly Vector3I18F14 www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(W, W, W); }
        public readonly Vector4I18F14 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, X); }
        public readonly Vector4I18F14 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, Y); }
        public readonly Vector4I18F14 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, Z); }
        public readonly Vector4I18F14 xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, W); }
        public readonly Vector4I18F14 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, X); }
        public readonly Vector4I18F14 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, Y); }
        public readonly Vector4I18F14 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, Z); }
        public readonly Vector4I18F14 xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, W); }
        public readonly Vector4I18F14 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Z, X); }
        public readonly Vector4I18F14 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Z, Y); }
        public readonly Vector4I18F14 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Z, Z); }
        public readonly Vector4I18F14 xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Z, W); }
        public readonly Vector4I18F14 xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, W, X); }
        public readonly Vector4I18F14 xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, W, Y); }
        public readonly Vector4I18F14 xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, W, Z); }
        public readonly Vector4I18F14 xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, W, W); }
        public readonly Vector4I18F14 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, X); }
        public readonly Vector4I18F14 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, Y); }
        public readonly Vector4I18F14 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, Z); }
        public readonly Vector4I18F14 xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, W); }
        public readonly Vector4I18F14 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, X); }
        public readonly Vector4I18F14 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, Y); }
        public readonly Vector4I18F14 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, Z); }
        public readonly Vector4I18F14 xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, W); }
        public readonly Vector4I18F14 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Z, X); }
        public readonly Vector4I18F14 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Z, Y); }
        public readonly Vector4I18F14 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Z, Z); }
        public readonly Vector4I18F14 xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Z, W); }
        public readonly Vector4I18F14 xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, W, X); }
        public readonly Vector4I18F14 xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, W, Y); }
        public readonly Vector4I18F14 xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, W, Z); }
        public readonly Vector4I18F14 xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, W, W); }
        public readonly Vector4I18F14 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, X, X); }
        public readonly Vector4I18F14 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, X, Y); }
        public readonly Vector4I18F14 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, X, Z); }
        public readonly Vector4I18F14 xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, X, W); }
        public readonly Vector4I18F14 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Y, X); }
        public readonly Vector4I18F14 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Y, Y); }
        public readonly Vector4I18F14 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Y, Z); }
        public readonly Vector4I18F14 xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Y, W); }
        public readonly Vector4I18F14 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Z, X); }
        public readonly Vector4I18F14 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Z, Y); }
        public readonly Vector4I18F14 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Z, Z); }
        public readonly Vector4I18F14 xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, Z, W); }
        public readonly Vector4I18F14 xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, W, X); }
        public readonly Vector4I18F14 xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, W, Y); }
        public readonly Vector4I18F14 xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, W, Z); }
        public readonly Vector4I18F14 xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Z, W, W); }
        public readonly Vector4I18F14 xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, X, X); }
        public readonly Vector4I18F14 xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, X, Y); }
        public readonly Vector4I18F14 xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, X, Z); }
        public readonly Vector4I18F14 xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, X, W); }
        public readonly Vector4I18F14 xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, Y, X); }
        public readonly Vector4I18F14 xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, Y, Y); }
        public readonly Vector4I18F14 xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, Y, Z); }
        public readonly Vector4I18F14 xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, Y, W); }
        public readonly Vector4I18F14 xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, Z, X); }
        public readonly Vector4I18F14 xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, Z, Y); }
        public readonly Vector4I18F14 xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, Z, Z); }
        public readonly Vector4I18F14 xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, Z, W); }
        public readonly Vector4I18F14 xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, W, X); }
        public readonly Vector4I18F14 xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, W, Y); }
        public readonly Vector4I18F14 xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, W, Z); }
        public readonly Vector4I18F14 xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, W, W, W); }
        public readonly Vector4I18F14 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, X); }
        public readonly Vector4I18F14 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, Y); }
        public readonly Vector4I18F14 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, Z); }
        public readonly Vector4I18F14 yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, W); }
        public readonly Vector4I18F14 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, X); }
        public readonly Vector4I18F14 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, Y); }
        public readonly Vector4I18F14 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, Z); }
        public readonly Vector4I18F14 yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, W); }
        public readonly Vector4I18F14 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Z, X); }
        public readonly Vector4I18F14 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Z, Y); }
        public readonly Vector4I18F14 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Z, Z); }
        public readonly Vector4I18F14 yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Z, W); }
        public readonly Vector4I18F14 yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, W, X); }
        public readonly Vector4I18F14 yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, W, Y); }
        public readonly Vector4I18F14 yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, W, Z); }
        public readonly Vector4I18F14 yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, W, W); }
        public readonly Vector4I18F14 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, X); }
        public readonly Vector4I18F14 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, Y); }
        public readonly Vector4I18F14 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, Z); }
        public readonly Vector4I18F14 yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, W); }
        public readonly Vector4I18F14 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, X); }
        public readonly Vector4I18F14 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, Y); }
        public readonly Vector4I18F14 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, Z); }
        public readonly Vector4I18F14 yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, W); }
        public readonly Vector4I18F14 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Z, X); }
        public readonly Vector4I18F14 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Z, Y); }
        public readonly Vector4I18F14 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Z, Z); }
        public readonly Vector4I18F14 yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Z, W); }
        public readonly Vector4I18F14 yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, W, X); }
        public readonly Vector4I18F14 yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, W, Y); }
        public readonly Vector4I18F14 yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, W, Z); }
        public readonly Vector4I18F14 yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, W, W); }
        public readonly Vector4I18F14 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, X, X); }
        public readonly Vector4I18F14 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, X, Y); }
        public readonly Vector4I18F14 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, X, Z); }
        public readonly Vector4I18F14 yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, X, W); }
        public readonly Vector4I18F14 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Y, X); }
        public readonly Vector4I18F14 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Y, Y); }
        public readonly Vector4I18F14 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Y, Z); }
        public readonly Vector4I18F14 yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Y, W); }
        public readonly Vector4I18F14 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Z, X); }
        public readonly Vector4I18F14 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Z, Y); }
        public readonly Vector4I18F14 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Z, Z); }
        public readonly Vector4I18F14 yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, Z, W); }
        public readonly Vector4I18F14 yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, W, X); }
        public readonly Vector4I18F14 yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, W, Y); }
        public readonly Vector4I18F14 yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, W, Z); }
        public readonly Vector4I18F14 yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Z, W, W); }
        public readonly Vector4I18F14 ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, X, X); }
        public readonly Vector4I18F14 ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, X, Y); }
        public readonly Vector4I18F14 ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, X, Z); }
        public readonly Vector4I18F14 ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, X, W); }
        public readonly Vector4I18F14 ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, Y, X); }
        public readonly Vector4I18F14 ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, Y, Y); }
        public readonly Vector4I18F14 ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, Y, Z); }
        public readonly Vector4I18F14 ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, Y, W); }
        public readonly Vector4I18F14 ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, Z, X); }
        public readonly Vector4I18F14 ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, Z, Y); }
        public readonly Vector4I18F14 ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, Z, Z); }
        public readonly Vector4I18F14 ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, Z, W); }
        public readonly Vector4I18F14 ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, W, X); }
        public readonly Vector4I18F14 ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, W, Y); }
        public readonly Vector4I18F14 ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, W, Z); }
        public readonly Vector4I18F14 ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, W, W, W); }
        public readonly Vector4I18F14 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, X, X); }
        public readonly Vector4I18F14 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, X, Y); }
        public readonly Vector4I18F14 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, X, Z); }
        public readonly Vector4I18F14 zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, X, W); }
        public readonly Vector4I18F14 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Y, X); }
        public readonly Vector4I18F14 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Y, Y); }
        public readonly Vector4I18F14 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Y, Z); }
        public readonly Vector4I18F14 zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Y, W); }
        public readonly Vector4I18F14 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Z, X); }
        public readonly Vector4I18F14 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Z, Y); }
        public readonly Vector4I18F14 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Z, Z); }
        public readonly Vector4I18F14 zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, Z, W); }
        public readonly Vector4I18F14 zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, W, X); }
        public readonly Vector4I18F14 zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, W, Y); }
        public readonly Vector4I18F14 zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, W, Z); }
        public readonly Vector4I18F14 zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, X, W, W); }
        public readonly Vector4I18F14 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, X, X); }
        public readonly Vector4I18F14 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, X, Y); }
        public readonly Vector4I18F14 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, X, Z); }
        public readonly Vector4I18F14 zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, X, W); }
        public readonly Vector4I18F14 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Y, X); }
        public readonly Vector4I18F14 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Y, Y); }
        public readonly Vector4I18F14 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Y, Z); }
        public readonly Vector4I18F14 zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Y, W); }
        public readonly Vector4I18F14 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Z, X); }
        public readonly Vector4I18F14 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Z, Y); }
        public readonly Vector4I18F14 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Z, Z); }
        public readonly Vector4I18F14 zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, Z, W); }
        public readonly Vector4I18F14 zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, W, X); }
        public readonly Vector4I18F14 zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, W, Y); }
        public readonly Vector4I18F14 zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, W, Z); }
        public readonly Vector4I18F14 zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Y, W, W); }
        public readonly Vector4I18F14 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, X, X); }
        public readonly Vector4I18F14 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, X, Y); }
        public readonly Vector4I18F14 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, X, Z); }
        public readonly Vector4I18F14 zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, X, W); }
        public readonly Vector4I18F14 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Y, X); }
        public readonly Vector4I18F14 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Y, Y); }
        public readonly Vector4I18F14 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Y, Z); }
        public readonly Vector4I18F14 zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Y, W); }
        public readonly Vector4I18F14 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Z, X); }
        public readonly Vector4I18F14 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Z, Y); }
        public readonly Vector4I18F14 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Z, Z); }
        public readonly Vector4I18F14 zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, Z, W); }
        public readonly Vector4I18F14 zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, W, X); }
        public readonly Vector4I18F14 zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, W, Y); }
        public readonly Vector4I18F14 zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, W, Z); }
        public readonly Vector4I18F14 zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, Z, W, W); }
        public readonly Vector4I18F14 zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, X, X); }
        public readonly Vector4I18F14 zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, X, Y); }
        public readonly Vector4I18F14 zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, X, Z); }
        public readonly Vector4I18F14 zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, X, W); }
        public readonly Vector4I18F14 zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, Y, X); }
        public readonly Vector4I18F14 zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, Y, Y); }
        public readonly Vector4I18F14 zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, Y, Z); }
        public readonly Vector4I18F14 zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, Y, W); }
        public readonly Vector4I18F14 zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, Z, X); }
        public readonly Vector4I18F14 zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, Z, Y); }
        public readonly Vector4I18F14 zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, Z, Z); }
        public readonly Vector4I18F14 zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, Z, W); }
        public readonly Vector4I18F14 zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, W, X); }
        public readonly Vector4I18F14 zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, W, Y); }
        public readonly Vector4I18F14 zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, W, Z); }
        public readonly Vector4I18F14 zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Z, W, W, W); }
        public readonly Vector4I18F14 wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, X, X); }
        public readonly Vector4I18F14 wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, X, Y); }
        public readonly Vector4I18F14 wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, X, Z); }
        public readonly Vector4I18F14 wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, X, W); }
        public readonly Vector4I18F14 wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, Y, X); }
        public readonly Vector4I18F14 wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, Y, Y); }
        public readonly Vector4I18F14 wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, Y, Z); }
        public readonly Vector4I18F14 wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, Y, W); }
        public readonly Vector4I18F14 wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, Z, X); }
        public readonly Vector4I18F14 wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, Z, Y); }
        public readonly Vector4I18F14 wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, Z, Z); }
        public readonly Vector4I18F14 wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, Z, W); }
        public readonly Vector4I18F14 wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, W, X); }
        public readonly Vector4I18F14 wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, W, Y); }
        public readonly Vector4I18F14 wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, W, Z); }
        public readonly Vector4I18F14 wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, X, W, W); }
        public readonly Vector4I18F14 wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, X, X); }
        public readonly Vector4I18F14 wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, X, Y); }
        public readonly Vector4I18F14 wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, X, Z); }
        public readonly Vector4I18F14 wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, X, W); }
        public readonly Vector4I18F14 wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, Y, X); }
        public readonly Vector4I18F14 wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, Y, Y); }
        public readonly Vector4I18F14 wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, Y, Z); }
        public readonly Vector4I18F14 wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, Y, W); }
        public readonly Vector4I18F14 wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, Z, X); }
        public readonly Vector4I18F14 wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, Z, Y); }
        public readonly Vector4I18F14 wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, Z, Z); }
        public readonly Vector4I18F14 wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, Z, W); }
        public readonly Vector4I18F14 wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, W, X); }
        public readonly Vector4I18F14 wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, W, Y); }
        public readonly Vector4I18F14 wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, W, Z); }
        public readonly Vector4I18F14 wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Y, W, W); }
        public readonly Vector4I18F14 wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, X, X); }
        public readonly Vector4I18F14 wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, X, Y); }
        public readonly Vector4I18F14 wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, X, Z); }
        public readonly Vector4I18F14 wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, X, W); }
        public readonly Vector4I18F14 wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, Y, X); }
        public readonly Vector4I18F14 wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, Y, Y); }
        public readonly Vector4I18F14 wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, Y, Z); }
        public readonly Vector4I18F14 wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, Y, W); }
        public readonly Vector4I18F14 wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, Z, X); }
        public readonly Vector4I18F14 wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, Z, Y); }
        public readonly Vector4I18F14 wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, Z, Z); }
        public readonly Vector4I18F14 wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, Z, W); }
        public readonly Vector4I18F14 wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, W, X); }
        public readonly Vector4I18F14 wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, W, Y); }
        public readonly Vector4I18F14 wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, W, Z); }
        public readonly Vector4I18F14 wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, Z, W, W); }
        public readonly Vector4I18F14 wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, X, X); }
        public readonly Vector4I18F14 wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, X, Y); }
        public readonly Vector4I18F14 wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, X, Z); }
        public readonly Vector4I18F14 wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, X, W); }
        public readonly Vector4I18F14 wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, Y, X); }
        public readonly Vector4I18F14 wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, Y, Y); }
        public readonly Vector4I18F14 wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, Y, Z); }
        public readonly Vector4I18F14 wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, Y, W); }
        public readonly Vector4I18F14 wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, Z, X); }
        public readonly Vector4I18F14 wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, Z, Y); }
        public readonly Vector4I18F14 wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, Z, Z); }
        public readonly Vector4I18F14 wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, Z, W); }
        public readonly Vector4I18F14 wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, W, X); }
        public readonly Vector4I18F14 wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, W, Y); }
        public readonly Vector4I18F14 wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, W, Z); }
        public readonly Vector4I18F14 wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(W, W, W, W); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I18F14 lhs, Vector4I18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I18F14 lhs, Vector4I18F14 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I18F14({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I18F14 other)
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
            return $"Vector4I18F14({x}, {y}, {z}, {w})";
        }
    }
}
