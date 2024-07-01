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
        public Vector4I2F30(I2F30 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 x, I2F30 y, Vector2I2F30 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 x, Vector3I2F30 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(Vector2I2F30 xy, Vector2I2F30 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(Vector4I2F30 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 x, Vector2I2F30 yz, I2F30 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(Vector3I2F30 xyz, I2F30 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(Vector2I2F30 xy, I2F30 z, I2F30 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I2F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I2F30(I2F30.Zero);
        }
        public static Vector4I2F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I2F30(I2F30.One);
        }
        public static Vector4I2F30 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I2F30(I2F30.One, I2F30.Zero, I2F30.Zero, I2F30.Zero);
        }
        public static Vector4I2F30 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I2F30(I2F30.Zero, I2F30.One, I2F30.Zero, I2F30.Zero);
        }
        public static Vector4I2F30 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I2F30(I2F30.Zero, I2F30.Zero, I2F30.One, I2F30.Zero);
        }
        public static Vector4I2F30 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I2F30(I2F30.Zero, I2F30.Zero, I2F30.Zero, I2F30.One);
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

        public readonly Vector2I2F30 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, X); }
        public readonly Vector2I2F30 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, Y); }
        public readonly Vector2I2F30 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, Z); }
        public readonly Vector2I2F30 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, W); }
        public readonly Vector2I2F30 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, X); }
        public readonly Vector2I2F30 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, Y); }
        public readonly Vector2I2F30 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, Z); }
        public readonly Vector2I2F30 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, W); }
        public readonly Vector2I2F30 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, X); }
        public readonly Vector2I2F30 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, Y); }
        public readonly Vector2I2F30 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, Z); }
        public readonly Vector2I2F30 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Z, W); }
        public readonly Vector2I2F30 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(W, X); }
        public readonly Vector2I2F30 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(W, Y); }
        public readonly Vector2I2F30 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(W, Z); }
        public readonly Vector2I2F30 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(W, W); }
        public readonly Vector3I2F30 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, X); }
        public readonly Vector3I2F30 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, Y); }
        public readonly Vector3I2F30 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, Z); }
        public readonly Vector3I2F30 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, W); }
        public readonly Vector3I2F30 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, X); }
        public readonly Vector3I2F30 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, Y); }
        public readonly Vector3I2F30 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, Z); }
        public readonly Vector3I2F30 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, W); }
        public readonly Vector3I2F30 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, X); }
        public readonly Vector3I2F30 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, Y); }
        public readonly Vector3I2F30 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, Z); }
        public readonly Vector3I2F30 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Z, W); }
        public readonly Vector3I2F30 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, W, X); }
        public readonly Vector3I2F30 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, W, Y); }
        public readonly Vector3I2F30 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, W, Z); }
        public readonly Vector3I2F30 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, W, W); }
        public readonly Vector3I2F30 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, X); }
        public readonly Vector3I2F30 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, Y); }
        public readonly Vector3I2F30 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, Z); }
        public readonly Vector3I2F30 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, W); }
        public readonly Vector3I2F30 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, X); }
        public readonly Vector3I2F30 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, Y); }
        public readonly Vector3I2F30 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, Z); }
        public readonly Vector3I2F30 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, W); }
        public readonly Vector3I2F30 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, X); }
        public readonly Vector3I2F30 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, Y); }
        public readonly Vector3I2F30 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, Z); }
        public readonly Vector3I2F30 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Z, W); }
        public readonly Vector3I2F30 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, W, X); }
        public readonly Vector3I2F30 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, W, Y); }
        public readonly Vector3I2F30 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, W, Z); }
        public readonly Vector3I2F30 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, W, W); }
        public readonly Vector3I2F30 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, X); }
        public readonly Vector3I2F30 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, Y); }
        public readonly Vector3I2F30 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, Z); }
        public readonly Vector3I2F30 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, X, W); }
        public readonly Vector3I2F30 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, X); }
        public readonly Vector3I2F30 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, Y); }
        public readonly Vector3I2F30 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, Z); }
        public readonly Vector3I2F30 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Y, W); }
        public readonly Vector3I2F30 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, X); }
        public readonly Vector3I2F30 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, Y); }
        public readonly Vector3I2F30 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, Z); }
        public readonly Vector3I2F30 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, Z, W); }
        public readonly Vector3I2F30 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, W, X); }
        public readonly Vector3I2F30 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, W, Y); }
        public readonly Vector3I2F30 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, W, Z); }
        public readonly Vector3I2F30 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Z, W, W); }
        public readonly Vector3I2F30 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, X, X); }
        public readonly Vector3I2F30 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, X, Y); }
        public readonly Vector3I2F30 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, X, Z); }
        public readonly Vector3I2F30 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, X, W); }
        public readonly Vector3I2F30 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Y, X); }
        public readonly Vector3I2F30 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Y, Y); }
        public readonly Vector3I2F30 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Y, Z); }
        public readonly Vector3I2F30 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Y, W); }
        public readonly Vector3I2F30 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Z, X); }
        public readonly Vector3I2F30 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Z, Y); }
        public readonly Vector3I2F30 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Z, Z); }
        public readonly Vector3I2F30 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, Z, W); }
        public readonly Vector3I2F30 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, W, X); }
        public readonly Vector3I2F30 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, W, Y); }
        public readonly Vector3I2F30 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, W, Z); }
        public readonly Vector3I2F30 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(W, W, W); }
        public readonly Vector4I2F30 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, X); }
        public readonly Vector4I2F30 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, Y); }
        public readonly Vector4I2F30 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, Z); }
        public readonly Vector4I2F30 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, W); }
        public readonly Vector4I2F30 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, X); }
        public readonly Vector4I2F30 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, Y); }
        public readonly Vector4I2F30 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, Z); }
        public readonly Vector4I2F30 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, W); }
        public readonly Vector4I2F30 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, X); }
        public readonly Vector4I2F30 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, Y); }
        public readonly Vector4I2F30 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, Z); }
        public readonly Vector4I2F30 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Z, W); }
        public readonly Vector4I2F30 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, W, X); }
        public readonly Vector4I2F30 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, W, Y); }
        public readonly Vector4I2F30 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, W, Z); }
        public readonly Vector4I2F30 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, W, W); }
        public readonly Vector4I2F30 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, X); }
        public readonly Vector4I2F30 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, Y); }
        public readonly Vector4I2F30 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, Z); }
        public readonly Vector4I2F30 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, W); }
        public readonly Vector4I2F30 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, X); }
        public readonly Vector4I2F30 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, Y); }
        public readonly Vector4I2F30 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, Z); }
        public readonly Vector4I2F30 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, W); }
        public readonly Vector4I2F30 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, X); }
        public readonly Vector4I2F30 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, Y); }
        public readonly Vector4I2F30 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, Z); }
        public readonly Vector4I2F30 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Z, W); }
        public readonly Vector4I2F30 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, W, X); }
        public readonly Vector4I2F30 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, W, Y); }
        public readonly Vector4I2F30 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, W, Z); }
        public readonly Vector4I2F30 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, W, W); }
        public readonly Vector4I2F30 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, X); }
        public readonly Vector4I2F30 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, Y); }
        public readonly Vector4I2F30 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, Z); }
        public readonly Vector4I2F30 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, X, W); }
        public readonly Vector4I2F30 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, X); }
        public readonly Vector4I2F30 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, Y); }
        public readonly Vector4I2F30 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, Z); }
        public readonly Vector4I2F30 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Y, W); }
        public readonly Vector4I2F30 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, X); }
        public readonly Vector4I2F30 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, Y); }
        public readonly Vector4I2F30 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, Z); }
        public readonly Vector4I2F30 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, Z, W); }
        public readonly Vector4I2F30 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, W, X); }
        public readonly Vector4I2F30 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, W, Y); }
        public readonly Vector4I2F30 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, W, Z); }
        public readonly Vector4I2F30 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Z, W, W); }
        public readonly Vector4I2F30 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, X, X); }
        public readonly Vector4I2F30 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, X, Y); }
        public readonly Vector4I2F30 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, X, Z); }
        public readonly Vector4I2F30 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, X, W); }
        public readonly Vector4I2F30 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Y, X); }
        public readonly Vector4I2F30 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Y, Y); }
        public readonly Vector4I2F30 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Y, Z); }
        public readonly Vector4I2F30 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Y, W); }
        public readonly Vector4I2F30 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Z, X); }
        public readonly Vector4I2F30 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Z, Y); }
        public readonly Vector4I2F30 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Z, Z); }
        public readonly Vector4I2F30 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, Z, W); }
        public readonly Vector4I2F30 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, W, X); }
        public readonly Vector4I2F30 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, W, Y); }
        public readonly Vector4I2F30 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, W, Z); }
        public readonly Vector4I2F30 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, W, W, W); }
        public readonly Vector4I2F30 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, X); }
        public readonly Vector4I2F30 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, Y); }
        public readonly Vector4I2F30 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, Z); }
        public readonly Vector4I2F30 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, W); }
        public readonly Vector4I2F30 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, X); }
        public readonly Vector4I2F30 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, Y); }
        public readonly Vector4I2F30 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, Z); }
        public readonly Vector4I2F30 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, W); }
        public readonly Vector4I2F30 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, X); }
        public readonly Vector4I2F30 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, Y); }
        public readonly Vector4I2F30 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, Z); }
        public readonly Vector4I2F30 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Z, W); }
        public readonly Vector4I2F30 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, W, X); }
        public readonly Vector4I2F30 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, W, Y); }
        public readonly Vector4I2F30 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, W, Z); }
        public readonly Vector4I2F30 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, W, W); }
        public readonly Vector4I2F30 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, X); }
        public readonly Vector4I2F30 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, Y); }
        public readonly Vector4I2F30 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, Z); }
        public readonly Vector4I2F30 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, W); }
        public readonly Vector4I2F30 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, X); }
        public readonly Vector4I2F30 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, Y); }
        public readonly Vector4I2F30 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, Z); }
        public readonly Vector4I2F30 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, W); }
        public readonly Vector4I2F30 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, X); }
        public readonly Vector4I2F30 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, Y); }
        public readonly Vector4I2F30 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, Z); }
        public readonly Vector4I2F30 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Z, W); }
        public readonly Vector4I2F30 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, W, X); }
        public readonly Vector4I2F30 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, W, Y); }
        public readonly Vector4I2F30 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, W, Z); }
        public readonly Vector4I2F30 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, W, W); }
        public readonly Vector4I2F30 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, X); }
        public readonly Vector4I2F30 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, Y); }
        public readonly Vector4I2F30 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, Z); }
        public readonly Vector4I2F30 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, X, W); }
        public readonly Vector4I2F30 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, X); }
        public readonly Vector4I2F30 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, Y); }
        public readonly Vector4I2F30 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, Z); }
        public readonly Vector4I2F30 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Y, W); }
        public readonly Vector4I2F30 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, X); }
        public readonly Vector4I2F30 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, Y); }
        public readonly Vector4I2F30 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, Z); }
        public readonly Vector4I2F30 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, Z, W); }
        public readonly Vector4I2F30 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, W, X); }
        public readonly Vector4I2F30 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, W, Y); }
        public readonly Vector4I2F30 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, W, Z); }
        public readonly Vector4I2F30 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Z, W, W); }
        public readonly Vector4I2F30 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, X, X); }
        public readonly Vector4I2F30 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, X, Y); }
        public readonly Vector4I2F30 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, X, Z); }
        public readonly Vector4I2F30 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, X, W); }
        public readonly Vector4I2F30 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Y, X); }
        public readonly Vector4I2F30 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Y, Y); }
        public readonly Vector4I2F30 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Y, Z); }
        public readonly Vector4I2F30 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Y, W); }
        public readonly Vector4I2F30 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Z, X); }
        public readonly Vector4I2F30 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Z, Y); }
        public readonly Vector4I2F30 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Z, Z); }
        public readonly Vector4I2F30 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, Z, W); }
        public readonly Vector4I2F30 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, W, X); }
        public readonly Vector4I2F30 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, W, Y); }
        public readonly Vector4I2F30 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, W, Z); }
        public readonly Vector4I2F30 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, W, W, W); }
        public readonly Vector4I2F30 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, X); }
        public readonly Vector4I2F30 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, Y); }
        public readonly Vector4I2F30 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, Z); }
        public readonly Vector4I2F30 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, X, W); }
        public readonly Vector4I2F30 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, X); }
        public readonly Vector4I2F30 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, Y); }
        public readonly Vector4I2F30 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, Z); }
        public readonly Vector4I2F30 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Y, W); }
        public readonly Vector4I2F30 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, X); }
        public readonly Vector4I2F30 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, Y); }
        public readonly Vector4I2F30 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, Z); }
        public readonly Vector4I2F30 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, Z, W); }
        public readonly Vector4I2F30 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, W, X); }
        public readonly Vector4I2F30 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, W, Y); }
        public readonly Vector4I2F30 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, W, Z); }
        public readonly Vector4I2F30 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, X, W, W); }
        public readonly Vector4I2F30 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, X); }
        public readonly Vector4I2F30 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, Y); }
        public readonly Vector4I2F30 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, Z); }
        public readonly Vector4I2F30 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, X, W); }
        public readonly Vector4I2F30 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, X); }
        public readonly Vector4I2F30 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, Y); }
        public readonly Vector4I2F30 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, Z); }
        public readonly Vector4I2F30 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Y, W); }
        public readonly Vector4I2F30 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, X); }
        public readonly Vector4I2F30 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, Y); }
        public readonly Vector4I2F30 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, Z); }
        public readonly Vector4I2F30 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, Z, W); }
        public readonly Vector4I2F30 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, W, X); }
        public readonly Vector4I2F30 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, W, Y); }
        public readonly Vector4I2F30 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, W, Z); }
        public readonly Vector4I2F30 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Y, W, W); }
        public readonly Vector4I2F30 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, X); }
        public readonly Vector4I2F30 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, Y); }
        public readonly Vector4I2F30 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, Z); }
        public readonly Vector4I2F30 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, X, W); }
        public readonly Vector4I2F30 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, X); }
        public readonly Vector4I2F30 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, Y); }
        public readonly Vector4I2F30 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, Z); }
        public readonly Vector4I2F30 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Y, W); }
        public readonly Vector4I2F30 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, X); }
        public readonly Vector4I2F30 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, Y); }
        public readonly Vector4I2F30 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, Z); }
        public readonly Vector4I2F30 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, Z, W); }
        public readonly Vector4I2F30 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, W, X); }
        public readonly Vector4I2F30 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, W, Y); }
        public readonly Vector4I2F30 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, W, Z); }
        public readonly Vector4I2F30 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, Z, W, W); }
        public readonly Vector4I2F30 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, X, X); }
        public readonly Vector4I2F30 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, X, Y); }
        public readonly Vector4I2F30 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, X, Z); }
        public readonly Vector4I2F30 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, X, W); }
        public readonly Vector4I2F30 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Y, X); }
        public readonly Vector4I2F30 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Y, Y); }
        public readonly Vector4I2F30 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Y, Z); }
        public readonly Vector4I2F30 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Y, W); }
        public readonly Vector4I2F30 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Z, X); }
        public readonly Vector4I2F30 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Z, Y); }
        public readonly Vector4I2F30 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Z, Z); }
        public readonly Vector4I2F30 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, Z, W); }
        public readonly Vector4I2F30 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, W, X); }
        public readonly Vector4I2F30 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, W, Y); }
        public readonly Vector4I2F30 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, W, Z); }
        public readonly Vector4I2F30 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Z, W, W, W); }
        public readonly Vector4I2F30 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, X, X); }
        public readonly Vector4I2F30 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, X, Y); }
        public readonly Vector4I2F30 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, X, Z); }
        public readonly Vector4I2F30 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, X, W); }
        public readonly Vector4I2F30 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Y, X); }
        public readonly Vector4I2F30 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Y, Y); }
        public readonly Vector4I2F30 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Y, Z); }
        public readonly Vector4I2F30 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Y, W); }
        public readonly Vector4I2F30 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Z, X); }
        public readonly Vector4I2F30 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Z, Y); }
        public readonly Vector4I2F30 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Z, Z); }
        public readonly Vector4I2F30 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, Z, W); }
        public readonly Vector4I2F30 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, W, X); }
        public readonly Vector4I2F30 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, W, Y); }
        public readonly Vector4I2F30 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, W, Z); }
        public readonly Vector4I2F30 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, X, W, W); }
        public readonly Vector4I2F30 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, X, X); }
        public readonly Vector4I2F30 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, X, Y); }
        public readonly Vector4I2F30 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, X, Z); }
        public readonly Vector4I2F30 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, X, W); }
        public readonly Vector4I2F30 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Y, X); }
        public readonly Vector4I2F30 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Y, Y); }
        public readonly Vector4I2F30 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Y, Z); }
        public readonly Vector4I2F30 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Y, W); }
        public readonly Vector4I2F30 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Z, X); }
        public readonly Vector4I2F30 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Z, Y); }
        public readonly Vector4I2F30 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Z, Z); }
        public readonly Vector4I2F30 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, Z, W); }
        public readonly Vector4I2F30 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, W, X); }
        public readonly Vector4I2F30 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, W, Y); }
        public readonly Vector4I2F30 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, W, Z); }
        public readonly Vector4I2F30 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Y, W, W); }
        public readonly Vector4I2F30 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, X, X); }
        public readonly Vector4I2F30 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, X, Y); }
        public readonly Vector4I2F30 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, X, Z); }
        public readonly Vector4I2F30 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, X, W); }
        public readonly Vector4I2F30 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Y, X); }
        public readonly Vector4I2F30 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Y, Y); }
        public readonly Vector4I2F30 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Y, Z); }
        public readonly Vector4I2F30 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Y, W); }
        public readonly Vector4I2F30 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Z, X); }
        public readonly Vector4I2F30 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Z, Y); }
        public readonly Vector4I2F30 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Z, Z); }
        public readonly Vector4I2F30 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, Z, W); }
        public readonly Vector4I2F30 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, W, X); }
        public readonly Vector4I2F30 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, W, Y); }
        public readonly Vector4I2F30 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, W, Z); }
        public readonly Vector4I2F30 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, Z, W, W); }
        public readonly Vector4I2F30 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, X, X); }
        public readonly Vector4I2F30 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, X, Y); }
        public readonly Vector4I2F30 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, X, Z); }
        public readonly Vector4I2F30 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, X, W); }
        public readonly Vector4I2F30 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Y, X); }
        public readonly Vector4I2F30 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Y, Y); }
        public readonly Vector4I2F30 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Y, Z); }
        public readonly Vector4I2F30 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Y, W); }
        public readonly Vector4I2F30 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Z, X); }
        public readonly Vector4I2F30 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Z, Y); }
        public readonly Vector4I2F30 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Z, Z); }
        public readonly Vector4I2F30 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, Z, W); }
        public readonly Vector4I2F30 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, W, X); }
        public readonly Vector4I2F30 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, W, Y); }
        public readonly Vector4I2F30 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, W, Z); }
        public readonly Vector4I2F30 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(W, W, W, W); }

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
