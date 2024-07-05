using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I31F1 : IEquatable<Vector4I31F1>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I31F1 X;
        public I31F1 Y;
        public I31F1 Z;
        public I31F1 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, I31F1 y, I31F1 z, I31F1 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, I31F1 y, Vector2I31F1 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, Vector3I31F1 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector2I31F1 xy, Vector2I31F1 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector4I31F1 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(I31F1 x, Vector2I31F1 yz, I31F1 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector3I31F1 xyz, I31F1 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I31F1(Vector2I31F1 xy, I31F1 z, I31F1 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I31F1 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I31F1(I31F1.Zero);
        }
        public static Vector4I31F1 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I31F1(I31F1.One);
        }
        public static Vector4I31F1 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I31F1(I31F1.One, I31F1.Zero, I31F1.Zero, I31F1.Zero);
        }
        public static Vector4I31F1 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I31F1(I31F1.Zero, I31F1.One, I31F1.Zero, I31F1.Zero);
        }
        public static Vector4I31F1 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I31F1(I31F1.Zero, I31F1.Zero, I31F1.One, I31F1.Zero);
        }
        public static Vector4I31F1 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I31F1(I31F1.Zero, I31F1.Zero, I31F1.Zero, I31F1.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator +(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator -(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator *(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator *(Vector4I31F1 a, I31F1 b) => new Vector4I31F1(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator *(I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator /(Vector4I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator /(Vector4I31F1 a, I31F1 b) => new Vector4I31F1(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 operator /(I31F1 a, Vector4I31F1 b) => new Vector4I31F1(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I31F1 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, X); }
        public readonly Vector2I31F1 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, Y); }
        public readonly Vector2I31F1 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, Z); }
        public readonly Vector2I31F1 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(X, W); }
        public readonly Vector2I31F1 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, X); }
        public readonly Vector2I31F1 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, Y); }
        public readonly Vector2I31F1 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, Z); }
        public readonly Vector2I31F1 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Y, W); }
        public readonly Vector2I31F1 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, X); }
        public readonly Vector2I31F1 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, Y); }
        public readonly Vector2I31F1 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, Z); }
        public readonly Vector2I31F1 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(Z, W); }
        public readonly Vector2I31F1 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(W, X); }
        public readonly Vector2I31F1 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(W, Y); }
        public readonly Vector2I31F1 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(W, Z); }
        public readonly Vector2I31F1 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(W, W); }
        public readonly Vector3I31F1 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, X); }
        public readonly Vector3I31F1 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, Y); }
        public readonly Vector3I31F1 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, Z); }
        public readonly Vector3I31F1 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, X, W); }
        public readonly Vector3I31F1 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, X); }
        public readonly Vector3I31F1 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, Y); }
        public readonly Vector3I31F1 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, Z); }
        public readonly Vector3I31F1 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Y, W); }
        public readonly Vector3I31F1 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, X); }
        public readonly Vector3I31F1 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, Y); }
        public readonly Vector3I31F1 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, Z); }
        public readonly Vector3I31F1 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, Z, W); }
        public readonly Vector3I31F1 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, W, X); }
        public readonly Vector3I31F1 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, W, Y); }
        public readonly Vector3I31F1 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, W, Z); }
        public readonly Vector3I31F1 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(X, W, W); }
        public readonly Vector3I31F1 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, X); }
        public readonly Vector3I31F1 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, Y); }
        public readonly Vector3I31F1 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, Z); }
        public readonly Vector3I31F1 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, X, W); }
        public readonly Vector3I31F1 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, X); }
        public readonly Vector3I31F1 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, Y); }
        public readonly Vector3I31F1 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, Z); }
        public readonly Vector3I31F1 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Y, W); }
        public readonly Vector3I31F1 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, X); }
        public readonly Vector3I31F1 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, Y); }
        public readonly Vector3I31F1 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, Z); }
        public readonly Vector3I31F1 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, Z, W); }
        public readonly Vector3I31F1 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, W, X); }
        public readonly Vector3I31F1 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, W, Y); }
        public readonly Vector3I31F1 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, W, Z); }
        public readonly Vector3I31F1 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Y, W, W); }
        public readonly Vector3I31F1 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, X); }
        public readonly Vector3I31F1 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, Y); }
        public readonly Vector3I31F1 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, Z); }
        public readonly Vector3I31F1 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, X, W); }
        public readonly Vector3I31F1 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, X); }
        public readonly Vector3I31F1 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, Y); }
        public readonly Vector3I31F1 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, Z); }
        public readonly Vector3I31F1 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Y, W); }
        public readonly Vector3I31F1 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, X); }
        public readonly Vector3I31F1 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, Y); }
        public readonly Vector3I31F1 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, Z); }
        public readonly Vector3I31F1 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, Z, W); }
        public readonly Vector3I31F1 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, W, X); }
        public readonly Vector3I31F1 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, W, Y); }
        public readonly Vector3I31F1 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, W, Z); }
        public readonly Vector3I31F1 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(Z, W, W); }
        public readonly Vector3I31F1 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, X, X); }
        public readonly Vector3I31F1 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, X, Y); }
        public readonly Vector3I31F1 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, X, Z); }
        public readonly Vector3I31F1 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, X, W); }
        public readonly Vector3I31F1 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Y, X); }
        public readonly Vector3I31F1 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Y, Y); }
        public readonly Vector3I31F1 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Y, Z); }
        public readonly Vector3I31F1 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Y, W); }
        public readonly Vector3I31F1 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Z, X); }
        public readonly Vector3I31F1 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Z, Y); }
        public readonly Vector3I31F1 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Z, Z); }
        public readonly Vector3I31F1 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, Z, W); }
        public readonly Vector3I31F1 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, W, X); }
        public readonly Vector3I31F1 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, W, Y); }
        public readonly Vector3I31F1 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, W, Z); }
        public readonly Vector3I31F1 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(W, W, W); }
        public readonly Vector4I31F1 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, X); }
        public readonly Vector4I31F1 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, Y); }
        public readonly Vector4I31F1 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, Z); }
        public readonly Vector4I31F1 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, X, W); }
        public readonly Vector4I31F1 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, X); }
        public readonly Vector4I31F1 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, Y); }
        public readonly Vector4I31F1 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, Z); }
        public readonly Vector4I31F1 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Y, W); }
        public readonly Vector4I31F1 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, X); }
        public readonly Vector4I31F1 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, Y); }
        public readonly Vector4I31F1 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, Z); }
        public readonly Vector4I31F1 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, Z, W); }
        public readonly Vector4I31F1 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, W, X); }
        public readonly Vector4I31F1 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, W, Y); }
        public readonly Vector4I31F1 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, W, Z); }
        public readonly Vector4I31F1 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, X, W, W); }
        public readonly Vector4I31F1 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, X); }
        public readonly Vector4I31F1 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, Y); }
        public readonly Vector4I31F1 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, Z); }
        public readonly Vector4I31F1 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, X, W); }
        public readonly Vector4I31F1 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, X); }
        public readonly Vector4I31F1 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, Y); }
        public readonly Vector4I31F1 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, Z); }
        public readonly Vector4I31F1 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Y, W); }
        public readonly Vector4I31F1 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, X); }
        public readonly Vector4I31F1 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, Y); }
        public readonly Vector4I31F1 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, Z); }
        public readonly Vector4I31F1 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, Z, W); }
        public readonly Vector4I31F1 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, W, X); }
        public readonly Vector4I31F1 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, W, Y); }
        public readonly Vector4I31F1 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, W, Z); }
        public readonly Vector4I31F1 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Y, W, W); }
        public readonly Vector4I31F1 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, X); }
        public readonly Vector4I31F1 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, Y); }
        public readonly Vector4I31F1 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, Z); }
        public readonly Vector4I31F1 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, X, W); }
        public readonly Vector4I31F1 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, X); }
        public readonly Vector4I31F1 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, Y); }
        public readonly Vector4I31F1 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, Z); }
        public readonly Vector4I31F1 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Y, W); }
        public readonly Vector4I31F1 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, X); }
        public readonly Vector4I31F1 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, Y); }
        public readonly Vector4I31F1 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, Z); }
        public readonly Vector4I31F1 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, Z, W); }
        public readonly Vector4I31F1 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, W, X); }
        public readonly Vector4I31F1 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, W, Y); }
        public readonly Vector4I31F1 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, W, Z); }
        public readonly Vector4I31F1 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, Z, W, W); }
        public readonly Vector4I31F1 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, X, X); }
        public readonly Vector4I31F1 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, X, Y); }
        public readonly Vector4I31F1 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, X, Z); }
        public readonly Vector4I31F1 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, X, W); }
        public readonly Vector4I31F1 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Y, X); }
        public readonly Vector4I31F1 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Y, Y); }
        public readonly Vector4I31F1 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Y, Z); }
        public readonly Vector4I31F1 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Y, W); }
        public readonly Vector4I31F1 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Z, X); }
        public readonly Vector4I31F1 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Z, Y); }
        public readonly Vector4I31F1 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Z, Z); }
        public readonly Vector4I31F1 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, Z, W); }
        public readonly Vector4I31F1 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, W, X); }
        public readonly Vector4I31F1 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, W, Y); }
        public readonly Vector4I31F1 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, W, Z); }
        public readonly Vector4I31F1 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(X, W, W, W); }
        public readonly Vector4I31F1 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, X); }
        public readonly Vector4I31F1 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, Y); }
        public readonly Vector4I31F1 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, Z); }
        public readonly Vector4I31F1 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, X, W); }
        public readonly Vector4I31F1 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, X); }
        public readonly Vector4I31F1 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, Y); }
        public readonly Vector4I31F1 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, Z); }
        public readonly Vector4I31F1 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Y, W); }
        public readonly Vector4I31F1 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, X); }
        public readonly Vector4I31F1 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, Y); }
        public readonly Vector4I31F1 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, Z); }
        public readonly Vector4I31F1 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, Z, W); }
        public readonly Vector4I31F1 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, W, X); }
        public readonly Vector4I31F1 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, W, Y); }
        public readonly Vector4I31F1 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, W, Z); }
        public readonly Vector4I31F1 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, X, W, W); }
        public readonly Vector4I31F1 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, X); }
        public readonly Vector4I31F1 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, Y); }
        public readonly Vector4I31F1 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, Z); }
        public readonly Vector4I31F1 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, X, W); }
        public readonly Vector4I31F1 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, X); }
        public readonly Vector4I31F1 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, Y); }
        public readonly Vector4I31F1 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, Z); }
        public readonly Vector4I31F1 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Y, W); }
        public readonly Vector4I31F1 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, X); }
        public readonly Vector4I31F1 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, Y); }
        public readonly Vector4I31F1 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, Z); }
        public readonly Vector4I31F1 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, Z, W); }
        public readonly Vector4I31F1 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, W, X); }
        public readonly Vector4I31F1 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, W, Y); }
        public readonly Vector4I31F1 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, W, Z); }
        public readonly Vector4I31F1 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Y, W, W); }
        public readonly Vector4I31F1 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, X); }
        public readonly Vector4I31F1 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, Y); }
        public readonly Vector4I31F1 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, Z); }
        public readonly Vector4I31F1 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, X, W); }
        public readonly Vector4I31F1 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, X); }
        public readonly Vector4I31F1 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, Y); }
        public readonly Vector4I31F1 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, Z); }
        public readonly Vector4I31F1 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Y, W); }
        public readonly Vector4I31F1 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, X); }
        public readonly Vector4I31F1 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, Y); }
        public readonly Vector4I31F1 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, Z); }
        public readonly Vector4I31F1 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, Z, W); }
        public readonly Vector4I31F1 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, W, X); }
        public readonly Vector4I31F1 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, W, Y); }
        public readonly Vector4I31F1 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, W, Z); }
        public readonly Vector4I31F1 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, Z, W, W); }
        public readonly Vector4I31F1 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, X, X); }
        public readonly Vector4I31F1 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, X, Y); }
        public readonly Vector4I31F1 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, X, Z); }
        public readonly Vector4I31F1 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, X, W); }
        public readonly Vector4I31F1 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Y, X); }
        public readonly Vector4I31F1 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Y, Y); }
        public readonly Vector4I31F1 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Y, Z); }
        public readonly Vector4I31F1 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Y, W); }
        public readonly Vector4I31F1 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Z, X); }
        public readonly Vector4I31F1 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Z, Y); }
        public readonly Vector4I31F1 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Z, Z); }
        public readonly Vector4I31F1 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, Z, W); }
        public readonly Vector4I31F1 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, W, X); }
        public readonly Vector4I31F1 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, W, Y); }
        public readonly Vector4I31F1 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, W, Z); }
        public readonly Vector4I31F1 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Y, W, W, W); }
        public readonly Vector4I31F1 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, X); }
        public readonly Vector4I31F1 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, Y); }
        public readonly Vector4I31F1 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, Z); }
        public readonly Vector4I31F1 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, X, W); }
        public readonly Vector4I31F1 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, X); }
        public readonly Vector4I31F1 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, Y); }
        public readonly Vector4I31F1 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, Z); }
        public readonly Vector4I31F1 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Y, W); }
        public readonly Vector4I31F1 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, X); }
        public readonly Vector4I31F1 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, Y); }
        public readonly Vector4I31F1 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, Z); }
        public readonly Vector4I31F1 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, Z, W); }
        public readonly Vector4I31F1 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, W, X); }
        public readonly Vector4I31F1 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, W, Y); }
        public readonly Vector4I31F1 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, W, Z); }
        public readonly Vector4I31F1 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, X, W, W); }
        public readonly Vector4I31F1 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, X); }
        public readonly Vector4I31F1 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, Y); }
        public readonly Vector4I31F1 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, Z); }
        public readonly Vector4I31F1 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, X, W); }
        public readonly Vector4I31F1 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, X); }
        public readonly Vector4I31F1 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, Y); }
        public readonly Vector4I31F1 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, Z); }
        public readonly Vector4I31F1 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Y, W); }
        public readonly Vector4I31F1 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, X); }
        public readonly Vector4I31F1 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, Y); }
        public readonly Vector4I31F1 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, Z); }
        public readonly Vector4I31F1 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, Z, W); }
        public readonly Vector4I31F1 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, W, X); }
        public readonly Vector4I31F1 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, W, Y); }
        public readonly Vector4I31F1 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, W, Z); }
        public readonly Vector4I31F1 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Y, W, W); }
        public readonly Vector4I31F1 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, X); }
        public readonly Vector4I31F1 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, Y); }
        public readonly Vector4I31F1 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, Z); }
        public readonly Vector4I31F1 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, X, W); }
        public readonly Vector4I31F1 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, X); }
        public readonly Vector4I31F1 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, Y); }
        public readonly Vector4I31F1 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, Z); }
        public readonly Vector4I31F1 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Y, W); }
        public readonly Vector4I31F1 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, X); }
        public readonly Vector4I31F1 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, Y); }
        public readonly Vector4I31F1 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, Z); }
        public readonly Vector4I31F1 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, Z, W); }
        public readonly Vector4I31F1 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, W, X); }
        public readonly Vector4I31F1 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, W, Y); }
        public readonly Vector4I31F1 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, W, Z); }
        public readonly Vector4I31F1 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, Z, W, W); }
        public readonly Vector4I31F1 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, X, X); }
        public readonly Vector4I31F1 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, X, Y); }
        public readonly Vector4I31F1 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, X, Z); }
        public readonly Vector4I31F1 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, X, W); }
        public readonly Vector4I31F1 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Y, X); }
        public readonly Vector4I31F1 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Y, Y); }
        public readonly Vector4I31F1 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Y, Z); }
        public readonly Vector4I31F1 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Y, W); }
        public readonly Vector4I31F1 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Z, X); }
        public readonly Vector4I31F1 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Z, Y); }
        public readonly Vector4I31F1 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Z, Z); }
        public readonly Vector4I31F1 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, Z, W); }
        public readonly Vector4I31F1 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, W, X); }
        public readonly Vector4I31F1 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, W, Y); }
        public readonly Vector4I31F1 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, W, Z); }
        public readonly Vector4I31F1 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(Z, W, W, W); }
        public readonly Vector4I31F1 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, X, X); }
        public readonly Vector4I31F1 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, X, Y); }
        public readonly Vector4I31F1 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, X, Z); }
        public readonly Vector4I31F1 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, X, W); }
        public readonly Vector4I31F1 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Y, X); }
        public readonly Vector4I31F1 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Y, Y); }
        public readonly Vector4I31F1 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Y, Z); }
        public readonly Vector4I31F1 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Y, W); }
        public readonly Vector4I31F1 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Z, X); }
        public readonly Vector4I31F1 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Z, Y); }
        public readonly Vector4I31F1 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Z, Z); }
        public readonly Vector4I31F1 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, Z, W); }
        public readonly Vector4I31F1 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, W, X); }
        public readonly Vector4I31F1 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, W, Y); }
        public readonly Vector4I31F1 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, W, Z); }
        public readonly Vector4I31F1 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, X, W, W); }
        public readonly Vector4I31F1 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, X, X); }
        public readonly Vector4I31F1 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, X, Y); }
        public readonly Vector4I31F1 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, X, Z); }
        public readonly Vector4I31F1 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, X, W); }
        public readonly Vector4I31F1 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Y, X); }
        public readonly Vector4I31F1 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Y, Y); }
        public readonly Vector4I31F1 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Y, Z); }
        public readonly Vector4I31F1 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Y, W); }
        public readonly Vector4I31F1 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Z, X); }
        public readonly Vector4I31F1 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Z, Y); }
        public readonly Vector4I31F1 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Z, Z); }
        public readonly Vector4I31F1 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, Z, W); }
        public readonly Vector4I31F1 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, W, X); }
        public readonly Vector4I31F1 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, W, Y); }
        public readonly Vector4I31F1 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, W, Z); }
        public readonly Vector4I31F1 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Y, W, W); }
        public readonly Vector4I31F1 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, X, X); }
        public readonly Vector4I31F1 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, X, Y); }
        public readonly Vector4I31F1 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, X, Z); }
        public readonly Vector4I31F1 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, X, W); }
        public readonly Vector4I31F1 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Y, X); }
        public readonly Vector4I31F1 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Y, Y); }
        public readonly Vector4I31F1 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Y, Z); }
        public readonly Vector4I31F1 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Y, W); }
        public readonly Vector4I31F1 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Z, X); }
        public readonly Vector4I31F1 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Z, Y); }
        public readonly Vector4I31F1 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Z, Z); }
        public readonly Vector4I31F1 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, Z, W); }
        public readonly Vector4I31F1 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, W, X); }
        public readonly Vector4I31F1 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, W, Y); }
        public readonly Vector4I31F1 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, W, Z); }
        public readonly Vector4I31F1 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, Z, W, W); }
        public readonly Vector4I31F1 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, X, X); }
        public readonly Vector4I31F1 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, X, Y); }
        public readonly Vector4I31F1 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, X, Z); }
        public readonly Vector4I31F1 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, X, W); }
        public readonly Vector4I31F1 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Y, X); }
        public readonly Vector4I31F1 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Y, Y); }
        public readonly Vector4I31F1 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Y, Z); }
        public readonly Vector4I31F1 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Y, W); }
        public readonly Vector4I31F1 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Z, X); }
        public readonly Vector4I31F1 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Z, Y); }
        public readonly Vector4I31F1 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Z, Z); }
        public readonly Vector4I31F1 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, Z, W); }
        public readonly Vector4I31F1 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, W, X); }
        public readonly Vector4I31F1 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, W, Y); }
        public readonly Vector4I31F1 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, W, Z); }
        public readonly Vector4I31F1 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(W, W, W, W); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I31F1 lhs, Vector4I31F1 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I31F1 lhs, Vector4I31F1 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I31F1 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I31F1>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I31F1 other)
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
            return $"<{x}, {y}, {z}, {w}>";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector4I31F1 Half() => new Vector4I31F1(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4I31F1 Twice() => new Vector4I31F1(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4I31F1 Clamp(I31F1 min, I31F1 max) => new Vector4I31F1(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4I31F1 Clamp(
            Vector4I31F1 min, Vector4I31F1 max
        ) => new Vector4I31F1(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I31F1 SaturatingAdd(Vector4I31F1 other) => new Vector4I31F1(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

    }
}
