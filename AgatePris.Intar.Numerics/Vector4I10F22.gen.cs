using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I10F22 : IEquatable<Vector4I10F22>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I10F22 X;
        public I10F22 Y;
        public I10F22 Z;
        public I10F22 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(I10F22 x, I10F22 y, I10F22 z, I10F22 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(I10F22 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(I10F22 x, I10F22 y, Vector2I10F22 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(I10F22 x, Vector3I10F22 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(Vector2I10F22 xy, Vector2I10F22 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(Vector4I10F22 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(I10F22 x, Vector2I10F22 yz, I10F22 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(Vector3I10F22 xyz, I10F22 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(Vector2I10F22 xy, I10F22 z, I10F22 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I10F22 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.Zero);
        }
        public static Vector4I10F22 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.One);
        }
        public static Vector4I10F22 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.One, I10F22.Zero, I10F22.Zero, I10F22.Zero);
        }
        public static Vector4I10F22 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.Zero, I10F22.One, I10F22.Zero, I10F22.Zero);
        }
        public static Vector4I10F22 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.Zero, I10F22.Zero, I10F22.One, I10F22.Zero);
        }
        public static Vector4I10F22 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.Zero, I10F22.Zero, I10F22.Zero, I10F22.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator +(Vector4I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator -(Vector4I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator *(Vector4I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator *(Vector4I10F22 a, I10F22 b) => new Vector4I10F22(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator *(I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator /(Vector4I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator /(Vector4I10F22 a, I10F22 b) => new Vector4I10F22(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator /(I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I10F22 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(X, X); }
        public readonly Vector2I10F22 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(X, Y); }
        public readonly Vector2I10F22 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(X, Z); }
        public readonly Vector2I10F22 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(X, W); }
        public readonly Vector2I10F22 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Y, X); }
        public readonly Vector2I10F22 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Y, Y); }
        public readonly Vector2I10F22 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Y, Z); }
        public readonly Vector2I10F22 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Y, W); }
        public readonly Vector2I10F22 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Z, X); }
        public readonly Vector2I10F22 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Z, Y); }
        public readonly Vector2I10F22 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Z, Z); }
        public readonly Vector2I10F22 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Z, W); }
        public readonly Vector2I10F22 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(W, X); }
        public readonly Vector2I10F22 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(W, Y); }
        public readonly Vector2I10F22 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(W, Z); }
        public readonly Vector2I10F22 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(W, W); }
        public readonly Vector3I10F22 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, X, X); }
        public readonly Vector3I10F22 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, X, Y); }
        public readonly Vector3I10F22 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, X, Z); }
        public readonly Vector3I10F22 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, X, W); }
        public readonly Vector3I10F22 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Y, X); }
        public readonly Vector3I10F22 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Y, Y); }
        public readonly Vector3I10F22 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Y, Z); }
        public readonly Vector3I10F22 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Y, W); }
        public readonly Vector3I10F22 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Z, X); }
        public readonly Vector3I10F22 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Z, Y); }
        public readonly Vector3I10F22 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Z, Z); }
        public readonly Vector3I10F22 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Z, W); }
        public readonly Vector3I10F22 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, W, X); }
        public readonly Vector3I10F22 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, W, Y); }
        public readonly Vector3I10F22 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, W, Z); }
        public readonly Vector3I10F22 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, W, W); }
        public readonly Vector3I10F22 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, X, X); }
        public readonly Vector3I10F22 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, X, Y); }
        public readonly Vector3I10F22 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, X, Z); }
        public readonly Vector3I10F22 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, X, W); }
        public readonly Vector3I10F22 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Y, X); }
        public readonly Vector3I10F22 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Y, Y); }
        public readonly Vector3I10F22 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Y, Z); }
        public readonly Vector3I10F22 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Y, W); }
        public readonly Vector3I10F22 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Z, X); }
        public readonly Vector3I10F22 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Z, Y); }
        public readonly Vector3I10F22 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Z, Z); }
        public readonly Vector3I10F22 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Z, W); }
        public readonly Vector3I10F22 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, W, X); }
        public readonly Vector3I10F22 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, W, Y); }
        public readonly Vector3I10F22 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, W, Z); }
        public readonly Vector3I10F22 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, W, W); }
        public readonly Vector3I10F22 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, X, X); }
        public readonly Vector3I10F22 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, X, Y); }
        public readonly Vector3I10F22 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, X, Z); }
        public readonly Vector3I10F22 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, X, W); }
        public readonly Vector3I10F22 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Y, X); }
        public readonly Vector3I10F22 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Y, Y); }
        public readonly Vector3I10F22 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Y, Z); }
        public readonly Vector3I10F22 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Y, W); }
        public readonly Vector3I10F22 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Z, X); }
        public readonly Vector3I10F22 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Z, Y); }
        public readonly Vector3I10F22 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Z, Z); }
        public readonly Vector3I10F22 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Z, W); }
        public readonly Vector3I10F22 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, W, X); }
        public readonly Vector3I10F22 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, W, Y); }
        public readonly Vector3I10F22 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, W, Z); }
        public readonly Vector3I10F22 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, W, W); }
        public readonly Vector3I10F22 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, X, X); }
        public readonly Vector3I10F22 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, X, Y); }
        public readonly Vector3I10F22 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, X, Z); }
        public readonly Vector3I10F22 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, X, W); }
        public readonly Vector3I10F22 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, Y, X); }
        public readonly Vector3I10F22 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, Y, Y); }
        public readonly Vector3I10F22 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, Y, Z); }
        public readonly Vector3I10F22 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, Y, W); }
        public readonly Vector3I10F22 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, Z, X); }
        public readonly Vector3I10F22 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, Z, Y); }
        public readonly Vector3I10F22 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, Z, Z); }
        public readonly Vector3I10F22 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, Z, W); }
        public readonly Vector3I10F22 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, W, X); }
        public readonly Vector3I10F22 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, W, Y); }
        public readonly Vector3I10F22 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, W, Z); }
        public readonly Vector3I10F22 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(W, W, W); }
        public readonly Vector4I10F22 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, X, X); }
        public readonly Vector4I10F22 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, X, Y); }
        public readonly Vector4I10F22 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, X, Z); }
        public readonly Vector4I10F22 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, X, W); }
        public readonly Vector4I10F22 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Y, X); }
        public readonly Vector4I10F22 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Y, Y); }
        public readonly Vector4I10F22 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Y, Z); }
        public readonly Vector4I10F22 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Y, W); }
        public readonly Vector4I10F22 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Z, X); }
        public readonly Vector4I10F22 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Z, Y); }
        public readonly Vector4I10F22 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Z, Z); }
        public readonly Vector4I10F22 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Z, W); }
        public readonly Vector4I10F22 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, W, X); }
        public readonly Vector4I10F22 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, W, Y); }
        public readonly Vector4I10F22 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, W, Z); }
        public readonly Vector4I10F22 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, W, W); }
        public readonly Vector4I10F22 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, X, X); }
        public readonly Vector4I10F22 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, X, Y); }
        public readonly Vector4I10F22 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, X, Z); }
        public readonly Vector4I10F22 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, X, W); }
        public readonly Vector4I10F22 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Y, X); }
        public readonly Vector4I10F22 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Y, Y); }
        public readonly Vector4I10F22 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Y, Z); }
        public readonly Vector4I10F22 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Y, W); }
        public readonly Vector4I10F22 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Z, X); }
        public readonly Vector4I10F22 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Z, Y); }
        public readonly Vector4I10F22 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Z, Z); }
        public readonly Vector4I10F22 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Z, W); }
        public readonly Vector4I10F22 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, W, X); }
        public readonly Vector4I10F22 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, W, Y); }
        public readonly Vector4I10F22 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, W, Z); }
        public readonly Vector4I10F22 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, W, W); }
        public readonly Vector4I10F22 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, X, X); }
        public readonly Vector4I10F22 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, X, Y); }
        public readonly Vector4I10F22 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, X, Z); }
        public readonly Vector4I10F22 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, X, W); }
        public readonly Vector4I10F22 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Y, X); }
        public readonly Vector4I10F22 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Y, Y); }
        public readonly Vector4I10F22 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Y, Z); }
        public readonly Vector4I10F22 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Y, W); }
        public readonly Vector4I10F22 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Z, X); }
        public readonly Vector4I10F22 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Z, Y); }
        public readonly Vector4I10F22 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Z, Z); }
        public readonly Vector4I10F22 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Z, W); }
        public readonly Vector4I10F22 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, W, X); }
        public readonly Vector4I10F22 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, W, Y); }
        public readonly Vector4I10F22 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, W, Z); }
        public readonly Vector4I10F22 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, W, W); }
        public readonly Vector4I10F22 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, X, X); }
        public readonly Vector4I10F22 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, X, Y); }
        public readonly Vector4I10F22 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, X, Z); }
        public readonly Vector4I10F22 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, X, W); }
        public readonly Vector4I10F22 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, Y, X); }
        public readonly Vector4I10F22 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, Y, Y); }
        public readonly Vector4I10F22 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, Y, Z); }
        public readonly Vector4I10F22 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, Y, W); }
        public readonly Vector4I10F22 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, Z, X); }
        public readonly Vector4I10F22 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, Z, Y); }
        public readonly Vector4I10F22 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, Z, Z); }
        public readonly Vector4I10F22 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, Z, W); }
        public readonly Vector4I10F22 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, W, X); }
        public readonly Vector4I10F22 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, W, Y); }
        public readonly Vector4I10F22 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, W, Z); }
        public readonly Vector4I10F22 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, W, W, W); }
        public readonly Vector4I10F22 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, X, X); }
        public readonly Vector4I10F22 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, X, Y); }
        public readonly Vector4I10F22 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, X, Z); }
        public readonly Vector4I10F22 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, X, W); }
        public readonly Vector4I10F22 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Y, X); }
        public readonly Vector4I10F22 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Y, Y); }
        public readonly Vector4I10F22 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Y, Z); }
        public readonly Vector4I10F22 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Y, W); }
        public readonly Vector4I10F22 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Z, X); }
        public readonly Vector4I10F22 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Z, Y); }
        public readonly Vector4I10F22 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Z, Z); }
        public readonly Vector4I10F22 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Z, W); }
        public readonly Vector4I10F22 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, W, X); }
        public readonly Vector4I10F22 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, W, Y); }
        public readonly Vector4I10F22 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, W, Z); }
        public readonly Vector4I10F22 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, W, W); }
        public readonly Vector4I10F22 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, X, X); }
        public readonly Vector4I10F22 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, X, Y); }
        public readonly Vector4I10F22 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, X, Z); }
        public readonly Vector4I10F22 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, X, W); }
        public readonly Vector4I10F22 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Y, X); }
        public readonly Vector4I10F22 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Y, Y); }
        public readonly Vector4I10F22 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Y, Z); }
        public readonly Vector4I10F22 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Y, W); }
        public readonly Vector4I10F22 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Z, X); }
        public readonly Vector4I10F22 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Z, Y); }
        public readonly Vector4I10F22 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Z, Z); }
        public readonly Vector4I10F22 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Z, W); }
        public readonly Vector4I10F22 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, W, X); }
        public readonly Vector4I10F22 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, W, Y); }
        public readonly Vector4I10F22 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, W, Z); }
        public readonly Vector4I10F22 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, W, W); }
        public readonly Vector4I10F22 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, X, X); }
        public readonly Vector4I10F22 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, X, Y); }
        public readonly Vector4I10F22 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, X, Z); }
        public readonly Vector4I10F22 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, X, W); }
        public readonly Vector4I10F22 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Y, X); }
        public readonly Vector4I10F22 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Y, Y); }
        public readonly Vector4I10F22 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Y, Z); }
        public readonly Vector4I10F22 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Y, W); }
        public readonly Vector4I10F22 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Z, X); }
        public readonly Vector4I10F22 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Z, Y); }
        public readonly Vector4I10F22 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Z, Z); }
        public readonly Vector4I10F22 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Z, W); }
        public readonly Vector4I10F22 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, W, X); }
        public readonly Vector4I10F22 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, W, Y); }
        public readonly Vector4I10F22 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, W, Z); }
        public readonly Vector4I10F22 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, W, W); }
        public readonly Vector4I10F22 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, X, X); }
        public readonly Vector4I10F22 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, X, Y); }
        public readonly Vector4I10F22 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, X, Z); }
        public readonly Vector4I10F22 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, X, W); }
        public readonly Vector4I10F22 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, Y, X); }
        public readonly Vector4I10F22 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, Y, Y); }
        public readonly Vector4I10F22 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, Y, Z); }
        public readonly Vector4I10F22 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, Y, W); }
        public readonly Vector4I10F22 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, Z, X); }
        public readonly Vector4I10F22 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, Z, Y); }
        public readonly Vector4I10F22 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, Z, Z); }
        public readonly Vector4I10F22 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, Z, W); }
        public readonly Vector4I10F22 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, W, X); }
        public readonly Vector4I10F22 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, W, Y); }
        public readonly Vector4I10F22 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, W, Z); }
        public readonly Vector4I10F22 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, W, W, W); }
        public readonly Vector4I10F22 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, X, X); }
        public readonly Vector4I10F22 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, X, Y); }
        public readonly Vector4I10F22 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, X, Z); }
        public readonly Vector4I10F22 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, X, W); }
        public readonly Vector4I10F22 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Y, X); }
        public readonly Vector4I10F22 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Y, Y); }
        public readonly Vector4I10F22 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Y, Z); }
        public readonly Vector4I10F22 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Y, W); }
        public readonly Vector4I10F22 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Z, X); }
        public readonly Vector4I10F22 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Z, Y); }
        public readonly Vector4I10F22 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Z, Z); }
        public readonly Vector4I10F22 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Z, W); }
        public readonly Vector4I10F22 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, W, X); }
        public readonly Vector4I10F22 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, W, Y); }
        public readonly Vector4I10F22 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, W, Z); }
        public readonly Vector4I10F22 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, W, W); }
        public readonly Vector4I10F22 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, X, X); }
        public readonly Vector4I10F22 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, X, Y); }
        public readonly Vector4I10F22 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, X, Z); }
        public readonly Vector4I10F22 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, X, W); }
        public readonly Vector4I10F22 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Y, X); }
        public readonly Vector4I10F22 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Y, Y); }
        public readonly Vector4I10F22 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Y, Z); }
        public readonly Vector4I10F22 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Y, W); }
        public readonly Vector4I10F22 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Z, X); }
        public readonly Vector4I10F22 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Z, Y); }
        public readonly Vector4I10F22 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Z, Z); }
        public readonly Vector4I10F22 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Z, W); }
        public readonly Vector4I10F22 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, W, X); }
        public readonly Vector4I10F22 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, W, Y); }
        public readonly Vector4I10F22 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, W, Z); }
        public readonly Vector4I10F22 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, W, W); }
        public readonly Vector4I10F22 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, X, X); }
        public readonly Vector4I10F22 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, X, Y); }
        public readonly Vector4I10F22 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, X, Z); }
        public readonly Vector4I10F22 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, X, W); }
        public readonly Vector4I10F22 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Y, X); }
        public readonly Vector4I10F22 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Y, Y); }
        public readonly Vector4I10F22 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Y, Z); }
        public readonly Vector4I10F22 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Y, W); }
        public readonly Vector4I10F22 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Z, X); }
        public readonly Vector4I10F22 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Z, Y); }
        public readonly Vector4I10F22 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Z, Z); }
        public readonly Vector4I10F22 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Z, W); }
        public readonly Vector4I10F22 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, W, X); }
        public readonly Vector4I10F22 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, W, Y); }
        public readonly Vector4I10F22 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, W, Z); }
        public readonly Vector4I10F22 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, W, W); }
        public readonly Vector4I10F22 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, X, X); }
        public readonly Vector4I10F22 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, X, Y); }
        public readonly Vector4I10F22 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, X, Z); }
        public readonly Vector4I10F22 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, X, W); }
        public readonly Vector4I10F22 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, Y, X); }
        public readonly Vector4I10F22 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, Y, Y); }
        public readonly Vector4I10F22 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, Y, Z); }
        public readonly Vector4I10F22 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, Y, W); }
        public readonly Vector4I10F22 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, Z, X); }
        public readonly Vector4I10F22 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, Z, Y); }
        public readonly Vector4I10F22 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, Z, Z); }
        public readonly Vector4I10F22 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, Z, W); }
        public readonly Vector4I10F22 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, W, X); }
        public readonly Vector4I10F22 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, W, Y); }
        public readonly Vector4I10F22 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, W, Z); }
        public readonly Vector4I10F22 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, W, W, W); }
        public readonly Vector4I10F22 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, X, X); }
        public readonly Vector4I10F22 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, X, Y); }
        public readonly Vector4I10F22 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, X, Z); }
        public readonly Vector4I10F22 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, X, W); }
        public readonly Vector4I10F22 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, Y, X); }
        public readonly Vector4I10F22 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, Y, Y); }
        public readonly Vector4I10F22 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, Y, Z); }
        public readonly Vector4I10F22 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, Y, W); }
        public readonly Vector4I10F22 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, Z, X); }
        public readonly Vector4I10F22 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, Z, Y); }
        public readonly Vector4I10F22 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, Z, Z); }
        public readonly Vector4I10F22 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, Z, W); }
        public readonly Vector4I10F22 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, W, X); }
        public readonly Vector4I10F22 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, W, Y); }
        public readonly Vector4I10F22 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, W, Z); }
        public readonly Vector4I10F22 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, X, W, W); }
        public readonly Vector4I10F22 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, X, X); }
        public readonly Vector4I10F22 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, X, Y); }
        public readonly Vector4I10F22 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, X, Z); }
        public readonly Vector4I10F22 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, X, W); }
        public readonly Vector4I10F22 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, Y, X); }
        public readonly Vector4I10F22 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, Y, Y); }
        public readonly Vector4I10F22 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, Y, Z); }
        public readonly Vector4I10F22 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, Y, W); }
        public readonly Vector4I10F22 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, Z, X); }
        public readonly Vector4I10F22 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, Z, Y); }
        public readonly Vector4I10F22 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, Z, Z); }
        public readonly Vector4I10F22 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, Z, W); }
        public readonly Vector4I10F22 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, W, X); }
        public readonly Vector4I10F22 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, W, Y); }
        public readonly Vector4I10F22 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, W, Z); }
        public readonly Vector4I10F22 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Y, W, W); }
        public readonly Vector4I10F22 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, X, X); }
        public readonly Vector4I10F22 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, X, Y); }
        public readonly Vector4I10F22 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, X, Z); }
        public readonly Vector4I10F22 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, X, W); }
        public readonly Vector4I10F22 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, Y, X); }
        public readonly Vector4I10F22 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, Y, Y); }
        public readonly Vector4I10F22 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, Y, Z); }
        public readonly Vector4I10F22 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, Y, W); }
        public readonly Vector4I10F22 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, Z, X); }
        public readonly Vector4I10F22 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, Z, Y); }
        public readonly Vector4I10F22 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, Z, Z); }
        public readonly Vector4I10F22 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, Z, W); }
        public readonly Vector4I10F22 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, W, X); }
        public readonly Vector4I10F22 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, W, Y); }
        public readonly Vector4I10F22 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, W, Z); }
        public readonly Vector4I10F22 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, Z, W, W); }
        public readonly Vector4I10F22 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, X, X); }
        public readonly Vector4I10F22 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, X, Y); }
        public readonly Vector4I10F22 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, X, Z); }
        public readonly Vector4I10F22 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, X, W); }
        public readonly Vector4I10F22 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, Y, X); }
        public readonly Vector4I10F22 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, Y, Y); }
        public readonly Vector4I10F22 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, Y, Z); }
        public readonly Vector4I10F22 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, Y, W); }
        public readonly Vector4I10F22 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, Z, X); }
        public readonly Vector4I10F22 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, Z, Y); }
        public readonly Vector4I10F22 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, Z, Z); }
        public readonly Vector4I10F22 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, Z, W); }
        public readonly Vector4I10F22 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, W, X); }
        public readonly Vector4I10F22 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, W, Y); }
        public readonly Vector4I10F22 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, W, Z); }
        public readonly Vector4I10F22 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(W, W, W, W); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I10F22 lhs, Vector4I10F22 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I10F22 lhs, Vector4I10F22 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I10F22 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4I10F22({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4I10F22>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I10F22 other)
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
            return $"Vector4I10F22({x}, {y}, {z}, {w})";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector4I10F22 Half() => new Vector4I10F22(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4I10F22 Twice() => new Vector4I10F22(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4I10F22 Clamp(I10F22 min, I10F22 max) => new Vector4I10F22(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4I10F22 Clamp(
            Vector4I10F22 min, Vector4I10F22 max
        ) => new Vector4I10F22(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

    }
}
