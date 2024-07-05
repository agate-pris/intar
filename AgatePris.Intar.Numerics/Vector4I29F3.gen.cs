using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I29F3 : IEquatable<Vector4I29F3>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I29F3 X;
        public I29F3 Y;
        public I29F3 Z;
        public I29F3 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(I29F3 x, I29F3 y, I29F3 z, I29F3 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(I29F3 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(I29F3 x, I29F3 y, Vector2I29F3 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(I29F3 x, Vector3I29F3 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(Vector2I29F3 xy, Vector2I29F3 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(Vector4I29F3 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(I29F3 x, Vector2I29F3 yz, I29F3 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(Vector3I29F3 xyz, I29F3 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I29F3(Vector2I29F3 xy, I29F3 z, I29F3 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I29F3 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I29F3(I29F3.Zero);
        }
        public static Vector4I29F3 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I29F3(I29F3.One);
        }
        public static Vector4I29F3 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I29F3(I29F3.One, I29F3.Zero, I29F3.Zero, I29F3.Zero);
        }
        public static Vector4I29F3 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I29F3(I29F3.Zero, I29F3.One, I29F3.Zero, I29F3.Zero);
        }
        public static Vector4I29F3 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I29F3(I29F3.Zero, I29F3.Zero, I29F3.One, I29F3.Zero);
        }
        public static Vector4I29F3 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I29F3(I29F3.Zero, I29F3.Zero, I29F3.Zero, I29F3.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator +(Vector4I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator -(Vector4I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator *(Vector4I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator *(Vector4I29F3 a, I29F3 b) => new Vector4I29F3(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator *(I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator /(Vector4I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator /(Vector4I29F3 a, I29F3 b) => new Vector4I29F3(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 operator /(I29F3 a, Vector4I29F3 b) => new Vector4I29F3(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I29F3 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, X); }
        public readonly Vector2I29F3 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, Y); }
        public readonly Vector2I29F3 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, Z); }
        public readonly Vector2I29F3 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, W); }
        public readonly Vector2I29F3 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, X); }
        public readonly Vector2I29F3 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, Y); }
        public readonly Vector2I29F3 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, Z); }
        public readonly Vector2I29F3 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, W); }
        public readonly Vector2I29F3 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, X); }
        public readonly Vector2I29F3 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, Y); }
        public readonly Vector2I29F3 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, Z); }
        public readonly Vector2I29F3 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Z, W); }
        public readonly Vector2I29F3 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(W, X); }
        public readonly Vector2I29F3 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(W, Y); }
        public readonly Vector2I29F3 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(W, Z); }
        public readonly Vector2I29F3 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(W, W); }
        public readonly Vector3I29F3 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, X); }
        public readonly Vector3I29F3 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, Y); }
        public readonly Vector3I29F3 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, Z); }
        public readonly Vector3I29F3 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, W); }
        public readonly Vector3I29F3 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, X); }
        public readonly Vector3I29F3 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, Y); }
        public readonly Vector3I29F3 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, Z); }
        public readonly Vector3I29F3 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, W); }
        public readonly Vector3I29F3 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, X); }
        public readonly Vector3I29F3 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, Y); }
        public readonly Vector3I29F3 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, Z); }
        public readonly Vector3I29F3 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Z, W); }
        public readonly Vector3I29F3 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, W, X); }
        public readonly Vector3I29F3 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, W, Y); }
        public readonly Vector3I29F3 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, W, Z); }
        public readonly Vector3I29F3 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, W, W); }
        public readonly Vector3I29F3 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, X); }
        public readonly Vector3I29F3 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, Y); }
        public readonly Vector3I29F3 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, Z); }
        public readonly Vector3I29F3 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, W); }
        public readonly Vector3I29F3 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, X); }
        public readonly Vector3I29F3 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, Y); }
        public readonly Vector3I29F3 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, Z); }
        public readonly Vector3I29F3 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, W); }
        public readonly Vector3I29F3 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, X); }
        public readonly Vector3I29F3 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, Y); }
        public readonly Vector3I29F3 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, Z); }
        public readonly Vector3I29F3 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Z, W); }
        public readonly Vector3I29F3 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, W, X); }
        public readonly Vector3I29F3 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, W, Y); }
        public readonly Vector3I29F3 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, W, Z); }
        public readonly Vector3I29F3 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, W, W); }
        public readonly Vector3I29F3 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, X); }
        public readonly Vector3I29F3 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, Y); }
        public readonly Vector3I29F3 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, Z); }
        public readonly Vector3I29F3 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, X, W); }
        public readonly Vector3I29F3 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, X); }
        public readonly Vector3I29F3 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, Y); }
        public readonly Vector3I29F3 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, Z); }
        public readonly Vector3I29F3 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Y, W); }
        public readonly Vector3I29F3 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, X); }
        public readonly Vector3I29F3 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, Y); }
        public readonly Vector3I29F3 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, Z); }
        public readonly Vector3I29F3 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, Z, W); }
        public readonly Vector3I29F3 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, W, X); }
        public readonly Vector3I29F3 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, W, Y); }
        public readonly Vector3I29F3 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, W, Z); }
        public readonly Vector3I29F3 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Z, W, W); }
        public readonly Vector3I29F3 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, X, X); }
        public readonly Vector3I29F3 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, X, Y); }
        public readonly Vector3I29F3 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, X, Z); }
        public readonly Vector3I29F3 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, X, W); }
        public readonly Vector3I29F3 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Y, X); }
        public readonly Vector3I29F3 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Y, Y); }
        public readonly Vector3I29F3 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Y, Z); }
        public readonly Vector3I29F3 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Y, W); }
        public readonly Vector3I29F3 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Z, X); }
        public readonly Vector3I29F3 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Z, Y); }
        public readonly Vector3I29F3 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Z, Z); }
        public readonly Vector3I29F3 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, Z, W); }
        public readonly Vector3I29F3 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, W, X); }
        public readonly Vector3I29F3 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, W, Y); }
        public readonly Vector3I29F3 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, W, Z); }
        public readonly Vector3I29F3 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(W, W, W); }
        public readonly Vector4I29F3 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, X); }
        public readonly Vector4I29F3 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, Y); }
        public readonly Vector4I29F3 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, Z); }
        public readonly Vector4I29F3 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, W); }
        public readonly Vector4I29F3 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, X); }
        public readonly Vector4I29F3 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, Y); }
        public readonly Vector4I29F3 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, Z); }
        public readonly Vector4I29F3 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, W); }
        public readonly Vector4I29F3 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, X); }
        public readonly Vector4I29F3 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, Y); }
        public readonly Vector4I29F3 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, Z); }
        public readonly Vector4I29F3 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Z, W); }
        public readonly Vector4I29F3 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, W, X); }
        public readonly Vector4I29F3 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, W, Y); }
        public readonly Vector4I29F3 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, W, Z); }
        public readonly Vector4I29F3 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, W, W); }
        public readonly Vector4I29F3 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, X); }
        public readonly Vector4I29F3 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, Y); }
        public readonly Vector4I29F3 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, Z); }
        public readonly Vector4I29F3 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, W); }
        public readonly Vector4I29F3 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, X); }
        public readonly Vector4I29F3 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, Y); }
        public readonly Vector4I29F3 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, Z); }
        public readonly Vector4I29F3 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, W); }
        public readonly Vector4I29F3 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, X); }
        public readonly Vector4I29F3 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, Y); }
        public readonly Vector4I29F3 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, Z); }
        public readonly Vector4I29F3 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Z, W); }
        public readonly Vector4I29F3 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, W, X); }
        public readonly Vector4I29F3 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, W, Y); }
        public readonly Vector4I29F3 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, W, Z); }
        public readonly Vector4I29F3 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, W, W); }
        public readonly Vector4I29F3 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, X); }
        public readonly Vector4I29F3 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, Y); }
        public readonly Vector4I29F3 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, Z); }
        public readonly Vector4I29F3 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, X, W); }
        public readonly Vector4I29F3 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, X); }
        public readonly Vector4I29F3 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, Y); }
        public readonly Vector4I29F3 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, Z); }
        public readonly Vector4I29F3 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Y, W); }
        public readonly Vector4I29F3 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, X); }
        public readonly Vector4I29F3 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, Y); }
        public readonly Vector4I29F3 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, Z); }
        public readonly Vector4I29F3 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, Z, W); }
        public readonly Vector4I29F3 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, W, X); }
        public readonly Vector4I29F3 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, W, Y); }
        public readonly Vector4I29F3 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, W, Z); }
        public readonly Vector4I29F3 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Z, W, W); }
        public readonly Vector4I29F3 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, X, X); }
        public readonly Vector4I29F3 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, X, Y); }
        public readonly Vector4I29F3 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, X, Z); }
        public readonly Vector4I29F3 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, X, W); }
        public readonly Vector4I29F3 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Y, X); }
        public readonly Vector4I29F3 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Y, Y); }
        public readonly Vector4I29F3 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Y, Z); }
        public readonly Vector4I29F3 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Y, W); }
        public readonly Vector4I29F3 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Z, X); }
        public readonly Vector4I29F3 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Z, Y); }
        public readonly Vector4I29F3 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Z, Z); }
        public readonly Vector4I29F3 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, Z, W); }
        public readonly Vector4I29F3 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, W, X); }
        public readonly Vector4I29F3 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, W, Y); }
        public readonly Vector4I29F3 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, W, Z); }
        public readonly Vector4I29F3 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, W, W, W); }
        public readonly Vector4I29F3 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, X); }
        public readonly Vector4I29F3 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, Y); }
        public readonly Vector4I29F3 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, Z); }
        public readonly Vector4I29F3 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, W); }
        public readonly Vector4I29F3 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, X); }
        public readonly Vector4I29F3 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, Y); }
        public readonly Vector4I29F3 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, Z); }
        public readonly Vector4I29F3 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, W); }
        public readonly Vector4I29F3 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, X); }
        public readonly Vector4I29F3 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, Y); }
        public readonly Vector4I29F3 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, Z); }
        public readonly Vector4I29F3 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Z, W); }
        public readonly Vector4I29F3 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, W, X); }
        public readonly Vector4I29F3 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, W, Y); }
        public readonly Vector4I29F3 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, W, Z); }
        public readonly Vector4I29F3 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, W, W); }
        public readonly Vector4I29F3 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, X); }
        public readonly Vector4I29F3 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, Y); }
        public readonly Vector4I29F3 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, Z); }
        public readonly Vector4I29F3 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, W); }
        public readonly Vector4I29F3 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, X); }
        public readonly Vector4I29F3 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, Y); }
        public readonly Vector4I29F3 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, Z); }
        public readonly Vector4I29F3 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, W); }
        public readonly Vector4I29F3 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, X); }
        public readonly Vector4I29F3 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, Y); }
        public readonly Vector4I29F3 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, Z); }
        public readonly Vector4I29F3 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Z, W); }
        public readonly Vector4I29F3 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, W, X); }
        public readonly Vector4I29F3 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, W, Y); }
        public readonly Vector4I29F3 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, W, Z); }
        public readonly Vector4I29F3 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, W, W); }
        public readonly Vector4I29F3 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, X); }
        public readonly Vector4I29F3 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, Y); }
        public readonly Vector4I29F3 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, Z); }
        public readonly Vector4I29F3 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, X, W); }
        public readonly Vector4I29F3 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, X); }
        public readonly Vector4I29F3 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, Y); }
        public readonly Vector4I29F3 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, Z); }
        public readonly Vector4I29F3 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Y, W); }
        public readonly Vector4I29F3 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, X); }
        public readonly Vector4I29F3 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, Y); }
        public readonly Vector4I29F3 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, Z); }
        public readonly Vector4I29F3 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, Z, W); }
        public readonly Vector4I29F3 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, W, X); }
        public readonly Vector4I29F3 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, W, Y); }
        public readonly Vector4I29F3 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, W, Z); }
        public readonly Vector4I29F3 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Z, W, W); }
        public readonly Vector4I29F3 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, X, X); }
        public readonly Vector4I29F3 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, X, Y); }
        public readonly Vector4I29F3 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, X, Z); }
        public readonly Vector4I29F3 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, X, W); }
        public readonly Vector4I29F3 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Y, X); }
        public readonly Vector4I29F3 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Y, Y); }
        public readonly Vector4I29F3 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Y, Z); }
        public readonly Vector4I29F3 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Y, W); }
        public readonly Vector4I29F3 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Z, X); }
        public readonly Vector4I29F3 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Z, Y); }
        public readonly Vector4I29F3 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Z, Z); }
        public readonly Vector4I29F3 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, Z, W); }
        public readonly Vector4I29F3 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, W, X); }
        public readonly Vector4I29F3 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, W, Y); }
        public readonly Vector4I29F3 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, W, Z); }
        public readonly Vector4I29F3 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, W, W, W); }
        public readonly Vector4I29F3 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, X); }
        public readonly Vector4I29F3 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, Y); }
        public readonly Vector4I29F3 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, Z); }
        public readonly Vector4I29F3 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, X, W); }
        public readonly Vector4I29F3 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, X); }
        public readonly Vector4I29F3 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, Y); }
        public readonly Vector4I29F3 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, Z); }
        public readonly Vector4I29F3 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Y, W); }
        public readonly Vector4I29F3 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, X); }
        public readonly Vector4I29F3 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, Y); }
        public readonly Vector4I29F3 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, Z); }
        public readonly Vector4I29F3 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, Z, W); }
        public readonly Vector4I29F3 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, W, X); }
        public readonly Vector4I29F3 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, W, Y); }
        public readonly Vector4I29F3 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, W, Z); }
        public readonly Vector4I29F3 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, X, W, W); }
        public readonly Vector4I29F3 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, X); }
        public readonly Vector4I29F3 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, Y); }
        public readonly Vector4I29F3 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, Z); }
        public readonly Vector4I29F3 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, X, W); }
        public readonly Vector4I29F3 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, X); }
        public readonly Vector4I29F3 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, Y); }
        public readonly Vector4I29F3 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, Z); }
        public readonly Vector4I29F3 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Y, W); }
        public readonly Vector4I29F3 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, X); }
        public readonly Vector4I29F3 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, Y); }
        public readonly Vector4I29F3 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, Z); }
        public readonly Vector4I29F3 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, Z, W); }
        public readonly Vector4I29F3 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, W, X); }
        public readonly Vector4I29F3 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, W, Y); }
        public readonly Vector4I29F3 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, W, Z); }
        public readonly Vector4I29F3 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Y, W, W); }
        public readonly Vector4I29F3 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, X); }
        public readonly Vector4I29F3 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, Y); }
        public readonly Vector4I29F3 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, Z); }
        public readonly Vector4I29F3 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, X, W); }
        public readonly Vector4I29F3 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, X); }
        public readonly Vector4I29F3 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, Y); }
        public readonly Vector4I29F3 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, Z); }
        public readonly Vector4I29F3 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Y, W); }
        public readonly Vector4I29F3 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, X); }
        public readonly Vector4I29F3 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, Y); }
        public readonly Vector4I29F3 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, Z); }
        public readonly Vector4I29F3 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, Z, W); }
        public readonly Vector4I29F3 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, W, X); }
        public readonly Vector4I29F3 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, W, Y); }
        public readonly Vector4I29F3 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, W, Z); }
        public readonly Vector4I29F3 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, Z, W, W); }
        public readonly Vector4I29F3 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, X, X); }
        public readonly Vector4I29F3 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, X, Y); }
        public readonly Vector4I29F3 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, X, Z); }
        public readonly Vector4I29F3 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, X, W); }
        public readonly Vector4I29F3 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Y, X); }
        public readonly Vector4I29F3 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Y, Y); }
        public readonly Vector4I29F3 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Y, Z); }
        public readonly Vector4I29F3 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Y, W); }
        public readonly Vector4I29F3 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Z, X); }
        public readonly Vector4I29F3 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Z, Y); }
        public readonly Vector4I29F3 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Z, Z); }
        public readonly Vector4I29F3 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, Z, W); }
        public readonly Vector4I29F3 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, W, X); }
        public readonly Vector4I29F3 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, W, Y); }
        public readonly Vector4I29F3 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, W, Z); }
        public readonly Vector4I29F3 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Z, W, W, W); }
        public readonly Vector4I29F3 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, X, X); }
        public readonly Vector4I29F3 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, X, Y); }
        public readonly Vector4I29F3 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, X, Z); }
        public readonly Vector4I29F3 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, X, W); }
        public readonly Vector4I29F3 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Y, X); }
        public readonly Vector4I29F3 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Y, Y); }
        public readonly Vector4I29F3 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Y, Z); }
        public readonly Vector4I29F3 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Y, W); }
        public readonly Vector4I29F3 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Z, X); }
        public readonly Vector4I29F3 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Z, Y); }
        public readonly Vector4I29F3 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Z, Z); }
        public readonly Vector4I29F3 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, Z, W); }
        public readonly Vector4I29F3 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, W, X); }
        public readonly Vector4I29F3 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, W, Y); }
        public readonly Vector4I29F3 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, W, Z); }
        public readonly Vector4I29F3 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, X, W, W); }
        public readonly Vector4I29F3 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, X, X); }
        public readonly Vector4I29F3 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, X, Y); }
        public readonly Vector4I29F3 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, X, Z); }
        public readonly Vector4I29F3 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, X, W); }
        public readonly Vector4I29F3 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Y, X); }
        public readonly Vector4I29F3 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Y, Y); }
        public readonly Vector4I29F3 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Y, Z); }
        public readonly Vector4I29F3 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Y, W); }
        public readonly Vector4I29F3 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Z, X); }
        public readonly Vector4I29F3 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Z, Y); }
        public readonly Vector4I29F3 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Z, Z); }
        public readonly Vector4I29F3 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, Z, W); }
        public readonly Vector4I29F3 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, W, X); }
        public readonly Vector4I29F3 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, W, Y); }
        public readonly Vector4I29F3 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, W, Z); }
        public readonly Vector4I29F3 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Y, W, W); }
        public readonly Vector4I29F3 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, X, X); }
        public readonly Vector4I29F3 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, X, Y); }
        public readonly Vector4I29F3 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, X, Z); }
        public readonly Vector4I29F3 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, X, W); }
        public readonly Vector4I29F3 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Y, X); }
        public readonly Vector4I29F3 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Y, Y); }
        public readonly Vector4I29F3 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Y, Z); }
        public readonly Vector4I29F3 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Y, W); }
        public readonly Vector4I29F3 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Z, X); }
        public readonly Vector4I29F3 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Z, Y); }
        public readonly Vector4I29F3 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Z, Z); }
        public readonly Vector4I29F3 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, Z, W); }
        public readonly Vector4I29F3 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, W, X); }
        public readonly Vector4I29F3 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, W, Y); }
        public readonly Vector4I29F3 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, W, Z); }
        public readonly Vector4I29F3 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, Z, W, W); }
        public readonly Vector4I29F3 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, X, X); }
        public readonly Vector4I29F3 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, X, Y); }
        public readonly Vector4I29F3 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, X, Z); }
        public readonly Vector4I29F3 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, X, W); }
        public readonly Vector4I29F3 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Y, X); }
        public readonly Vector4I29F3 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Y, Y); }
        public readonly Vector4I29F3 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Y, Z); }
        public readonly Vector4I29F3 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Y, W); }
        public readonly Vector4I29F3 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Z, X); }
        public readonly Vector4I29F3 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Z, Y); }
        public readonly Vector4I29F3 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Z, Z); }
        public readonly Vector4I29F3 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, Z, W); }
        public readonly Vector4I29F3 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, W, X); }
        public readonly Vector4I29F3 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, W, Y); }
        public readonly Vector4I29F3 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, W, Z); }
        public readonly Vector4I29F3 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(W, W, W, W); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I29F3 lhs, Vector4I29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I29F3 lhs, Vector4I29F3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I29F3 other)
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

        public readonly Vector4I29F3 Half() => new Vector4I29F3(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4I29F3 Twice() => new Vector4I29F3(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4I29F3 Clamp(I29F3 min, I29F3 max) => new Vector4I29F3(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4I29F3 Clamp(
            Vector4I29F3 min, Vector4I29F3 max
        ) => new Vector4I29F3(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I29F3 SaturatingAdd(Vector4I29F3 other) => new Vector4I29F3(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I29F3 SaturatingMul(I29F3 other) => new Vector4I29F3(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

    }

    partial struct I29F3 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I29F3 SaturatingMul(Vector4I29F3 other) => other.SaturatingMul(this);
    }
}
