using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I19F13
    : IEquatable<Vector4I19F13>
    , IFormattable
    , IVector<U40F24, I40F24, U20F12, I20F12> {
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
        public Vector4I19F13(I19F13 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, I19F13 y, Vector2I19F13 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, Vector3I19F13 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector2I19F13 xy, Vector2I19F13 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector4I19F13 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, Vector2I19F13 yz, I19F13 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector3I19F13 xyz, I19F13 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector2I19F13 xy, I19F13 z, I19F13 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I19F13 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.Zero);
        }
        public static Vector4I19F13 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.One);
        }
        public static Vector4I19F13 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.One, I19F13.Zero, I19F13.Zero, I19F13.Zero);
        }
        public static Vector4I19F13 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.Zero, I19F13.One, I19F13.Zero, I19F13.Zero);
        }
        public static Vector4I19F13 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.Zero, I19F13.Zero, I19F13.One, I19F13.Zero);
        }
        public static Vector4I19F13 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.Zero, I19F13.Zero, I19F13.Zero, I19F13.One);
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

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I19F13 lhs, Vector4I19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I19F13 lhs, Vector4I19F13 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I19F13 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, X); }
        public Vector2I19F13 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, Y); }
        public Vector2I19F13 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, Z); }
        public Vector2I19F13 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, W); }
        public Vector2I19F13 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, X); }
        public Vector2I19F13 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, Y); }
        public Vector2I19F13 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, Z); }
        public Vector2I19F13 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, W); }
        public Vector2I19F13 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Z, X); }
        public Vector2I19F13 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Z, Y); }
        public Vector2I19F13 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Z, Z); }
        public Vector2I19F13 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Z, W); }
        public Vector2I19F13 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(W, X); }
        public Vector2I19F13 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(W, Y); }
        public Vector2I19F13 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(W, Z); }
        public Vector2I19F13 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(W, W); }
        public Vector3I19F13 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, X); }
        public Vector3I19F13 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, Y); }
        public Vector3I19F13 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, Z); }
        public Vector3I19F13 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, W); }
        public Vector3I19F13 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, X); }
        public Vector3I19F13 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, Y); }
        public Vector3I19F13 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, Z); }
        public Vector3I19F13 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, W); }
        public Vector3I19F13 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Z, X); }
        public Vector3I19F13 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Z, Y); }
        public Vector3I19F13 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Z, Z); }
        public Vector3I19F13 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Z, W); }
        public Vector3I19F13 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, W, X); }
        public Vector3I19F13 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, W, Y); }
        public Vector3I19F13 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, W, Z); }
        public Vector3I19F13 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, W, W); }
        public Vector3I19F13 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, X); }
        public Vector3I19F13 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, Y); }
        public Vector3I19F13 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, Z); }
        public Vector3I19F13 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, W); }
        public Vector3I19F13 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, X); }
        public Vector3I19F13 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, Y); }
        public Vector3I19F13 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, Z); }
        public Vector3I19F13 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, W); }
        public Vector3I19F13 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Z, X); }
        public Vector3I19F13 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Z, Y); }
        public Vector3I19F13 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Z, Z); }
        public Vector3I19F13 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Z, W); }
        public Vector3I19F13 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, W, X); }
        public Vector3I19F13 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, W, Y); }
        public Vector3I19F13 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, W, Z); }
        public Vector3I19F13 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, W, W); }
        public Vector3I19F13 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, X, X); }
        public Vector3I19F13 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, X, Y); }
        public Vector3I19F13 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, X, Z); }
        public Vector3I19F13 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, X, W); }
        public Vector3I19F13 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Y, X); }
        public Vector3I19F13 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Y, Y); }
        public Vector3I19F13 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Y, Z); }
        public Vector3I19F13 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Y, W); }
        public Vector3I19F13 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Z, X); }
        public Vector3I19F13 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Z, Y); }
        public Vector3I19F13 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Z, Z); }
        public Vector3I19F13 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, Z, W); }
        public Vector3I19F13 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, W, X); }
        public Vector3I19F13 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, W, Y); }
        public Vector3I19F13 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, W, Z); }
        public Vector3I19F13 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Z, W, W); }
        public Vector3I19F13 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, X, X); }
        public Vector3I19F13 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, X, Y); }
        public Vector3I19F13 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, X, Z); }
        public Vector3I19F13 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, X, W); }
        public Vector3I19F13 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Y, X); }
        public Vector3I19F13 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Y, Y); }
        public Vector3I19F13 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Y, Z); }
        public Vector3I19F13 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Y, W); }
        public Vector3I19F13 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Z, X); }
        public Vector3I19F13 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Z, Y); }
        public Vector3I19F13 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Z, Z); }
        public Vector3I19F13 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, Z, W); }
        public Vector3I19F13 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, W, X); }
        public Vector3I19F13 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, W, Y); }
        public Vector3I19F13 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, W, Z); }
        public Vector3I19F13 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(W, W, W); }
        public Vector4I19F13 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, X); }
        public Vector4I19F13 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, Y); }
        public Vector4I19F13 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, Z); }
        public Vector4I19F13 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, W); }
        public Vector4I19F13 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, X); }
        public Vector4I19F13 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, Y); }
        public Vector4I19F13 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, Z); }
        public Vector4I19F13 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, W); }
        public Vector4I19F13 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Z, X); }
        public Vector4I19F13 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Z, Y); }
        public Vector4I19F13 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Z, Z); }
        public Vector4I19F13 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Z, W); }
        public Vector4I19F13 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, W, X); }
        public Vector4I19F13 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, W, Y); }
        public Vector4I19F13 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, W, Z); }
        public Vector4I19F13 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, W, W); }
        public Vector4I19F13 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, X); }
        public Vector4I19F13 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, Y); }
        public Vector4I19F13 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, Z); }
        public Vector4I19F13 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, W); }
        public Vector4I19F13 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, X); }
        public Vector4I19F13 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, Y); }
        public Vector4I19F13 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, Z); }
        public Vector4I19F13 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, W); }
        public Vector4I19F13 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Z, X); }
        public Vector4I19F13 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Z, Y); }
        public Vector4I19F13 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Z, Z); }
        public Vector4I19F13 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Z, W); }
        public Vector4I19F13 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, W, X); }
        public Vector4I19F13 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, W, Y); }
        public Vector4I19F13 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, W, Z); }
        public Vector4I19F13 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, W, W); }
        public Vector4I19F13 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, X, X); }
        public Vector4I19F13 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, X, Y); }
        public Vector4I19F13 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, X, Z); }
        public Vector4I19F13 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, X, W); }
        public Vector4I19F13 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Y, X); }
        public Vector4I19F13 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Y, Y); }
        public Vector4I19F13 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Y, Z); }
        public Vector4I19F13 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Y, W); }
        public Vector4I19F13 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Z, X); }
        public Vector4I19F13 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Z, Y); }
        public Vector4I19F13 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Z, Z); }
        public Vector4I19F13 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, Z, W); }
        public Vector4I19F13 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, W, X); }
        public Vector4I19F13 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, W, Y); }
        public Vector4I19F13 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, W, Z); }
        public Vector4I19F13 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Z, W, W); }
        public Vector4I19F13 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, X, X); }
        public Vector4I19F13 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, X, Y); }
        public Vector4I19F13 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, X, Z); }
        public Vector4I19F13 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, X, W); }
        public Vector4I19F13 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Y, X); }
        public Vector4I19F13 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Y, Y); }
        public Vector4I19F13 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Y, Z); }
        public Vector4I19F13 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Y, W); }
        public Vector4I19F13 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Z, X); }
        public Vector4I19F13 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Z, Y); }
        public Vector4I19F13 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Z, Z); }
        public Vector4I19F13 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, Z, W); }
        public Vector4I19F13 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, W, X); }
        public Vector4I19F13 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, W, Y); }
        public Vector4I19F13 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, W, Z); }
        public Vector4I19F13 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, W, W, W); }
        public Vector4I19F13 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, X); }
        public Vector4I19F13 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, Y); }
        public Vector4I19F13 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, Z); }
        public Vector4I19F13 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, W); }
        public Vector4I19F13 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, X); }
        public Vector4I19F13 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, Y); }
        public Vector4I19F13 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, Z); }
        public Vector4I19F13 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, W); }
        public Vector4I19F13 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Z, X); }
        public Vector4I19F13 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Z, Y); }
        public Vector4I19F13 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Z, Z); }
        public Vector4I19F13 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Z, W); }
        public Vector4I19F13 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, W, X); }
        public Vector4I19F13 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, W, Y); }
        public Vector4I19F13 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, W, Z); }
        public Vector4I19F13 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, W, W); }
        public Vector4I19F13 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, X); }
        public Vector4I19F13 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, Y); }
        public Vector4I19F13 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, Z); }
        public Vector4I19F13 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, W); }
        public Vector4I19F13 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, X); }
        public Vector4I19F13 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, Y); }
        public Vector4I19F13 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, Z); }
        public Vector4I19F13 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, W); }
        public Vector4I19F13 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Z, X); }
        public Vector4I19F13 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Z, Y); }
        public Vector4I19F13 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Z, Z); }
        public Vector4I19F13 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Z, W); }
        public Vector4I19F13 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, W, X); }
        public Vector4I19F13 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, W, Y); }
        public Vector4I19F13 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, W, Z); }
        public Vector4I19F13 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, W, W); }
        public Vector4I19F13 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, X, X); }
        public Vector4I19F13 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, X, Y); }
        public Vector4I19F13 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, X, Z); }
        public Vector4I19F13 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, X, W); }
        public Vector4I19F13 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Y, X); }
        public Vector4I19F13 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Y, Y); }
        public Vector4I19F13 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Y, Z); }
        public Vector4I19F13 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Y, W); }
        public Vector4I19F13 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Z, X); }
        public Vector4I19F13 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Z, Y); }
        public Vector4I19F13 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Z, Z); }
        public Vector4I19F13 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, Z, W); }
        public Vector4I19F13 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, W, X); }
        public Vector4I19F13 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, W, Y); }
        public Vector4I19F13 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, W, Z); }
        public Vector4I19F13 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Z, W, W); }
        public Vector4I19F13 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, X, X); }
        public Vector4I19F13 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, X, Y); }
        public Vector4I19F13 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, X, Z); }
        public Vector4I19F13 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, X, W); }
        public Vector4I19F13 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Y, X); }
        public Vector4I19F13 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Y, Y); }
        public Vector4I19F13 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Y, Z); }
        public Vector4I19F13 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Y, W); }
        public Vector4I19F13 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Z, X); }
        public Vector4I19F13 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Z, Y); }
        public Vector4I19F13 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Z, Z); }
        public Vector4I19F13 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, Z, W); }
        public Vector4I19F13 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, W, X); }
        public Vector4I19F13 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, W, Y); }
        public Vector4I19F13 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, W, Z); }
        public Vector4I19F13 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, W, W, W); }
        public Vector4I19F13 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, X, X); }
        public Vector4I19F13 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, X, Y); }
        public Vector4I19F13 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, X, Z); }
        public Vector4I19F13 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, X, W); }
        public Vector4I19F13 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Y, X); }
        public Vector4I19F13 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Y, Y); }
        public Vector4I19F13 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Y, Z); }
        public Vector4I19F13 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Y, W); }
        public Vector4I19F13 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Z, X); }
        public Vector4I19F13 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Z, Y); }
        public Vector4I19F13 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Z, Z); }
        public Vector4I19F13 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, Z, W); }
        public Vector4I19F13 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, W, X); }
        public Vector4I19F13 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, W, Y); }
        public Vector4I19F13 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, W, Z); }
        public Vector4I19F13 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, X, W, W); }
        public Vector4I19F13 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, X, X); }
        public Vector4I19F13 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, X, Y); }
        public Vector4I19F13 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, X, Z); }
        public Vector4I19F13 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, X, W); }
        public Vector4I19F13 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Y, X); }
        public Vector4I19F13 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Y, Y); }
        public Vector4I19F13 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Y, Z); }
        public Vector4I19F13 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Y, W); }
        public Vector4I19F13 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Z, X); }
        public Vector4I19F13 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Z, Y); }
        public Vector4I19F13 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Z, Z); }
        public Vector4I19F13 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, Z, W); }
        public Vector4I19F13 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, W, X); }
        public Vector4I19F13 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, W, Y); }
        public Vector4I19F13 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, W, Z); }
        public Vector4I19F13 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Y, W, W); }
        public Vector4I19F13 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, X, X); }
        public Vector4I19F13 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, X, Y); }
        public Vector4I19F13 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, X, Z); }
        public Vector4I19F13 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, X, W); }
        public Vector4I19F13 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Y, X); }
        public Vector4I19F13 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Y, Y); }
        public Vector4I19F13 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Y, Z); }
        public Vector4I19F13 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Y, W); }
        public Vector4I19F13 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Z, X); }
        public Vector4I19F13 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Z, Y); }
        public Vector4I19F13 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Z, Z); }
        public Vector4I19F13 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, Z, W); }
        public Vector4I19F13 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, W, X); }
        public Vector4I19F13 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, W, Y); }
        public Vector4I19F13 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, W, Z); }
        public Vector4I19F13 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, Z, W, W); }
        public Vector4I19F13 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, X, X); }
        public Vector4I19F13 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, X, Y); }
        public Vector4I19F13 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, X, Z); }
        public Vector4I19F13 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, X, W); }
        public Vector4I19F13 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Y, X); }
        public Vector4I19F13 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Y, Y); }
        public Vector4I19F13 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Y, Z); }
        public Vector4I19F13 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Y, W); }
        public Vector4I19F13 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Z, X); }
        public Vector4I19F13 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Z, Y); }
        public Vector4I19F13 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Z, Z); }
        public Vector4I19F13 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, Z, W); }
        public Vector4I19F13 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, W, X); }
        public Vector4I19F13 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, W, Y); }
        public Vector4I19F13 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, W, Z); }
        public Vector4I19F13 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Z, W, W, W); }
        public Vector4I19F13 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, X, X); }
        public Vector4I19F13 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, X, Y); }
        public Vector4I19F13 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, X, Z); }
        public Vector4I19F13 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, X, W); }
        public Vector4I19F13 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Y, X); }
        public Vector4I19F13 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Y, Y); }
        public Vector4I19F13 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Y, Z); }
        public Vector4I19F13 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Y, W); }
        public Vector4I19F13 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Z, X); }
        public Vector4I19F13 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Z, Y); }
        public Vector4I19F13 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Z, Z); }
        public Vector4I19F13 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, Z, W); }
        public Vector4I19F13 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, W, X); }
        public Vector4I19F13 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, W, Y); }
        public Vector4I19F13 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, W, Z); }
        public Vector4I19F13 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, X, W, W); }
        public Vector4I19F13 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, X, X); }
        public Vector4I19F13 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, X, Y); }
        public Vector4I19F13 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, X, Z); }
        public Vector4I19F13 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, X, W); }
        public Vector4I19F13 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Y, X); }
        public Vector4I19F13 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Y, Y); }
        public Vector4I19F13 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Y, Z); }
        public Vector4I19F13 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Y, W); }
        public Vector4I19F13 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Z, X); }
        public Vector4I19F13 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Z, Y); }
        public Vector4I19F13 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Z, Z); }
        public Vector4I19F13 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, Z, W); }
        public Vector4I19F13 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, W, X); }
        public Vector4I19F13 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, W, Y); }
        public Vector4I19F13 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, W, Z); }
        public Vector4I19F13 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Y, W, W); }
        public Vector4I19F13 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, X, X); }
        public Vector4I19F13 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, X, Y); }
        public Vector4I19F13 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, X, Z); }
        public Vector4I19F13 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, X, W); }
        public Vector4I19F13 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Y, X); }
        public Vector4I19F13 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Y, Y); }
        public Vector4I19F13 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Y, Z); }
        public Vector4I19F13 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Y, W); }
        public Vector4I19F13 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Z, X); }
        public Vector4I19F13 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Z, Y); }
        public Vector4I19F13 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Z, Z); }
        public Vector4I19F13 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, Z, W); }
        public Vector4I19F13 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, W, X); }
        public Vector4I19F13 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, W, Y); }
        public Vector4I19F13 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, W, Z); }
        public Vector4I19F13 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, Z, W, W); }
        public Vector4I19F13 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, X, X); }
        public Vector4I19F13 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, X, Y); }
        public Vector4I19F13 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, X, Z); }
        public Vector4I19F13 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, X, W); }
        public Vector4I19F13 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Y, X); }
        public Vector4I19F13 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Y, Y); }
        public Vector4I19F13 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Y, Z); }
        public Vector4I19F13 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Y, W); }
        public Vector4I19F13 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Z, X); }
        public Vector4I19F13 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Z, Y); }
        public Vector4I19F13 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Z, Z); }
        public Vector4I19F13 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, Z, W); }
        public Vector4I19F13 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, W, X); }
        public Vector4I19F13 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, W, Y); }
        public Vector4I19F13 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, W, Z); }
        public Vector4I19F13 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector4I19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I19F13>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I19F13 other)
            => other.X == X
            && other.Y == Y
            && other.Z == Z
            && other.W == W;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            var w = W.ToString(format, formatProvider);
            return $"<{x}, {y}, {z}, {w}>";
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Min(Vector4I19F13 other) => new Vector4I19F13(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Max(Vector4I19F13 other) => new Vector4I19F13(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Abs() => new Vector4I19F13(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Half() => new Vector4I19F13(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Twice() => new Vector4I19F13(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Clamp(I19F13 min, I19F13 max) => new Vector4I19F13(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Clamp(
            Vector4I19F13 min, Vector4I19F13 max
        ) => new Vector4I19F13(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 WrappingAdd(Vector4I19F13 other) => new Vector4I19F13(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 WrappingSub(Vector4I19F13 other) => new Vector4I19F13(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 WrappingMul(Vector4I19F13 other) => new Vector4I19F13(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 WrappingAddUnsigned(Vector4U19F13 other) => new Vector4I19F13(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 WrappingSubUnsigned(Vector4U19F13 other) => new Vector4I19F13(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U19F13 UnsignedAbs() => new Vector4U19F13(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 SaturatingAdd(Vector4I19F13 other) => new Vector4I19F13(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 SaturatingMul(I19F13 other) => new Vector4I19F13(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I19F13 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;
            var z = ((long)Z.Bits) * other.Z.Bits;
            var w = ((long)W.Bits) * other.W.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4) +
                (z / 4) +
                (w / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I19F13 Dot(Vector4I19F13 other) {
            const long k = 1L << 11;
            return I19F13.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I19F13 SaturatingDot(Vector4I19F13 other) {
            const long k = 1L << 11;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I19F13.MaxValue;
            } else if (bits < int.MinValue) {
                return I19F13.MinValue;
            } else {
                return I19F13.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U40F24 LengthSquaredUnsigned() => U40F24.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I40F24 LengthSquaredSigned() => I40F24.FromBits(
            LengthSquaredInternal()
        );

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <div class="TIP alert alert-info">
        /// <h5>Tip</h5>
        /// <para>This method divides the square of each element by 4
        /// during the calculation to prevent overflow.</para>
        /// <para>このメソッドはオーバーフローを防ぐため､
        /// 計算の過程で各要素の 2 乗を 4 で除算します｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I40F24 LengthSquared() => LengthSquaredSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            var squared = LengthSquaredInternal();
            return (uint)Mathi.Sqrt((ulong)squared);
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthHalf">LengthHalf</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalf">LengthHalf</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U19F13 LengthHalfUnsigned() => U19F13.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I19F13 LengthHalf() => I19F13.FromBits(checked((int)LengthInternal()));

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthSigned">LengthSigned</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthSigned">LengthSigned</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        /// <seealso cref="LengthSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U20F12 LengthUnsigned() => U20F12.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I20F12 LengthSigned() => I20F12.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I20F12 Length() => LengthSigned();

    }

    partial struct I19F13 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 SaturatingMul(Vector4I19F13 other) => other.SaturatingMul(this);
    }
}
