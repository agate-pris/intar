using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I14F18 : IEquatable<Vector4I14F18>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I14F18 X;
        public I14F18 Y;
        public I14F18 Z;
        public I14F18 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(I14F18 x, I14F18 y, I14F18 z, I14F18 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(I14F18 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(I14F18 x, I14F18 y, Vector2I14F18 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(I14F18 x, Vector3I14F18 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(Vector2I14F18 xy, Vector2I14F18 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(Vector4I14F18 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(I14F18 x, Vector2I14F18 yz, I14F18 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(Vector3I14F18 xyz, I14F18 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(Vector2I14F18 xy, I14F18 z, I14F18 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I14F18 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.Zero);
        }
        public static Vector4I14F18 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.One);
        }
        public static Vector4I14F18 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.One, I14F18.Zero, I14F18.Zero, I14F18.Zero);
        }
        public static Vector4I14F18 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.Zero, I14F18.One, I14F18.Zero, I14F18.Zero);
        }
        public static Vector4I14F18 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.Zero, I14F18.Zero, I14F18.One, I14F18.Zero);
        }
        public static Vector4I14F18 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.Zero, I14F18.Zero, I14F18.Zero, I14F18.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator +(Vector4I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator -(Vector4I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator *(Vector4I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator *(Vector4I14F18 a, I14F18 b) => new Vector4I14F18(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator *(I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator /(Vector4I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator /(Vector4I14F18 a, I14F18 b) => new Vector4I14F18(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator /(I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I14F18 lhs, Vector4I14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I14F18 lhs, Vector4I14F18 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I14F18 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, X); }
        public Vector2I14F18 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, Y); }
        public Vector2I14F18 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, Z); }
        public Vector2I14F18 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, W); }
        public Vector2I14F18 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, X); }
        public Vector2I14F18 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, Y); }
        public Vector2I14F18 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, Z); }
        public Vector2I14F18 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, W); }
        public Vector2I14F18 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Z, X); }
        public Vector2I14F18 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Z, Y); }
        public Vector2I14F18 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Z, Z); }
        public Vector2I14F18 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Z, W); }
        public Vector2I14F18 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(W, X); }
        public Vector2I14F18 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(W, Y); }
        public Vector2I14F18 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(W, Z); }
        public Vector2I14F18 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(W, W); }
        public Vector3I14F18 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, X); }
        public Vector3I14F18 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, Y); }
        public Vector3I14F18 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, Z); }
        public Vector3I14F18 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, W); }
        public Vector3I14F18 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, X); }
        public Vector3I14F18 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, Y); }
        public Vector3I14F18 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, Z); }
        public Vector3I14F18 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, W); }
        public Vector3I14F18 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Z, X); }
        public Vector3I14F18 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Z, Y); }
        public Vector3I14F18 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Z, Z); }
        public Vector3I14F18 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Z, W); }
        public Vector3I14F18 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, W, X); }
        public Vector3I14F18 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, W, Y); }
        public Vector3I14F18 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, W, Z); }
        public Vector3I14F18 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, W, W); }
        public Vector3I14F18 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, X); }
        public Vector3I14F18 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, Y); }
        public Vector3I14F18 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, Z); }
        public Vector3I14F18 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, W); }
        public Vector3I14F18 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, X); }
        public Vector3I14F18 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, Y); }
        public Vector3I14F18 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, Z); }
        public Vector3I14F18 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, W); }
        public Vector3I14F18 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Z, X); }
        public Vector3I14F18 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Z, Y); }
        public Vector3I14F18 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Z, Z); }
        public Vector3I14F18 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Z, W); }
        public Vector3I14F18 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, W, X); }
        public Vector3I14F18 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, W, Y); }
        public Vector3I14F18 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, W, Z); }
        public Vector3I14F18 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, W, W); }
        public Vector3I14F18 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, X, X); }
        public Vector3I14F18 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, X, Y); }
        public Vector3I14F18 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, X, Z); }
        public Vector3I14F18 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, X, W); }
        public Vector3I14F18 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Y, X); }
        public Vector3I14F18 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Y, Y); }
        public Vector3I14F18 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Y, Z); }
        public Vector3I14F18 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Y, W); }
        public Vector3I14F18 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Z, X); }
        public Vector3I14F18 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Z, Y); }
        public Vector3I14F18 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Z, Z); }
        public Vector3I14F18 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, Z, W); }
        public Vector3I14F18 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, W, X); }
        public Vector3I14F18 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, W, Y); }
        public Vector3I14F18 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, W, Z); }
        public Vector3I14F18 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Z, W, W); }
        public Vector3I14F18 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, X, X); }
        public Vector3I14F18 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, X, Y); }
        public Vector3I14F18 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, X, Z); }
        public Vector3I14F18 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, X, W); }
        public Vector3I14F18 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, Y, X); }
        public Vector3I14F18 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, Y, Y); }
        public Vector3I14F18 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, Y, Z); }
        public Vector3I14F18 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, Y, W); }
        public Vector3I14F18 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, Z, X); }
        public Vector3I14F18 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, Z, Y); }
        public Vector3I14F18 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, Z, Z); }
        public Vector3I14F18 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, Z, W); }
        public Vector3I14F18 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, W, X); }
        public Vector3I14F18 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, W, Y); }
        public Vector3I14F18 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, W, Z); }
        public Vector3I14F18 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(W, W, W); }
        public Vector4I14F18 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, X); }
        public Vector4I14F18 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, Y); }
        public Vector4I14F18 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, Z); }
        public Vector4I14F18 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, W); }
        public Vector4I14F18 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, X); }
        public Vector4I14F18 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, Y); }
        public Vector4I14F18 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, Z); }
        public Vector4I14F18 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, W); }
        public Vector4I14F18 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Z, X); }
        public Vector4I14F18 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Z, Y); }
        public Vector4I14F18 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Z, Z); }
        public Vector4I14F18 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Z, W); }
        public Vector4I14F18 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, W, X); }
        public Vector4I14F18 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, W, Y); }
        public Vector4I14F18 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, W, Z); }
        public Vector4I14F18 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, W, W); }
        public Vector4I14F18 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, X); }
        public Vector4I14F18 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, Y); }
        public Vector4I14F18 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, Z); }
        public Vector4I14F18 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, W); }
        public Vector4I14F18 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, X); }
        public Vector4I14F18 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, Y); }
        public Vector4I14F18 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, Z); }
        public Vector4I14F18 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, W); }
        public Vector4I14F18 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Z, X); }
        public Vector4I14F18 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Z, Y); }
        public Vector4I14F18 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Z, Z); }
        public Vector4I14F18 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Z, W); }
        public Vector4I14F18 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, W, X); }
        public Vector4I14F18 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, W, Y); }
        public Vector4I14F18 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, W, Z); }
        public Vector4I14F18 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, W, W); }
        public Vector4I14F18 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, X, X); }
        public Vector4I14F18 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, X, Y); }
        public Vector4I14F18 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, X, Z); }
        public Vector4I14F18 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, X, W); }
        public Vector4I14F18 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Y, X); }
        public Vector4I14F18 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Y, Y); }
        public Vector4I14F18 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Y, Z); }
        public Vector4I14F18 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Y, W); }
        public Vector4I14F18 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Z, X); }
        public Vector4I14F18 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Z, Y); }
        public Vector4I14F18 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Z, Z); }
        public Vector4I14F18 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, Z, W); }
        public Vector4I14F18 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, W, X); }
        public Vector4I14F18 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, W, Y); }
        public Vector4I14F18 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, W, Z); }
        public Vector4I14F18 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Z, W, W); }
        public Vector4I14F18 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, X, X); }
        public Vector4I14F18 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, X, Y); }
        public Vector4I14F18 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, X, Z); }
        public Vector4I14F18 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, X, W); }
        public Vector4I14F18 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, Y, X); }
        public Vector4I14F18 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, Y, Y); }
        public Vector4I14F18 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, Y, Z); }
        public Vector4I14F18 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, Y, W); }
        public Vector4I14F18 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, Z, X); }
        public Vector4I14F18 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, Z, Y); }
        public Vector4I14F18 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, Z, Z); }
        public Vector4I14F18 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, Z, W); }
        public Vector4I14F18 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, W, X); }
        public Vector4I14F18 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, W, Y); }
        public Vector4I14F18 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, W, Z); }
        public Vector4I14F18 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, W, W, W); }
        public Vector4I14F18 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, X); }
        public Vector4I14F18 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, Y); }
        public Vector4I14F18 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, Z); }
        public Vector4I14F18 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, W); }
        public Vector4I14F18 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, X); }
        public Vector4I14F18 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, Y); }
        public Vector4I14F18 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, Z); }
        public Vector4I14F18 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, W); }
        public Vector4I14F18 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Z, X); }
        public Vector4I14F18 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Z, Y); }
        public Vector4I14F18 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Z, Z); }
        public Vector4I14F18 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Z, W); }
        public Vector4I14F18 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, W, X); }
        public Vector4I14F18 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, W, Y); }
        public Vector4I14F18 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, W, Z); }
        public Vector4I14F18 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, W, W); }
        public Vector4I14F18 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, X); }
        public Vector4I14F18 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, Y); }
        public Vector4I14F18 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, Z); }
        public Vector4I14F18 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, W); }
        public Vector4I14F18 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, X); }
        public Vector4I14F18 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, Y); }
        public Vector4I14F18 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, Z); }
        public Vector4I14F18 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, W); }
        public Vector4I14F18 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Z, X); }
        public Vector4I14F18 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Z, Y); }
        public Vector4I14F18 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Z, Z); }
        public Vector4I14F18 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Z, W); }
        public Vector4I14F18 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, W, X); }
        public Vector4I14F18 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, W, Y); }
        public Vector4I14F18 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, W, Z); }
        public Vector4I14F18 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, W, W); }
        public Vector4I14F18 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, X, X); }
        public Vector4I14F18 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, X, Y); }
        public Vector4I14F18 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, X, Z); }
        public Vector4I14F18 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, X, W); }
        public Vector4I14F18 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Y, X); }
        public Vector4I14F18 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Y, Y); }
        public Vector4I14F18 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Y, Z); }
        public Vector4I14F18 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Y, W); }
        public Vector4I14F18 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Z, X); }
        public Vector4I14F18 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Z, Y); }
        public Vector4I14F18 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Z, Z); }
        public Vector4I14F18 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, Z, W); }
        public Vector4I14F18 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, W, X); }
        public Vector4I14F18 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, W, Y); }
        public Vector4I14F18 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, W, Z); }
        public Vector4I14F18 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Z, W, W); }
        public Vector4I14F18 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, X, X); }
        public Vector4I14F18 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, X, Y); }
        public Vector4I14F18 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, X, Z); }
        public Vector4I14F18 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, X, W); }
        public Vector4I14F18 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, Y, X); }
        public Vector4I14F18 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, Y, Y); }
        public Vector4I14F18 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, Y, Z); }
        public Vector4I14F18 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, Y, W); }
        public Vector4I14F18 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, Z, X); }
        public Vector4I14F18 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, Z, Y); }
        public Vector4I14F18 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, Z, Z); }
        public Vector4I14F18 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, Z, W); }
        public Vector4I14F18 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, W, X); }
        public Vector4I14F18 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, W, Y); }
        public Vector4I14F18 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, W, Z); }
        public Vector4I14F18 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, W, W, W); }
        public Vector4I14F18 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, X, X); }
        public Vector4I14F18 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, X, Y); }
        public Vector4I14F18 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, X, Z); }
        public Vector4I14F18 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, X, W); }
        public Vector4I14F18 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Y, X); }
        public Vector4I14F18 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Y, Y); }
        public Vector4I14F18 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Y, Z); }
        public Vector4I14F18 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Y, W); }
        public Vector4I14F18 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Z, X); }
        public Vector4I14F18 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Z, Y); }
        public Vector4I14F18 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Z, Z); }
        public Vector4I14F18 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, Z, W); }
        public Vector4I14F18 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, W, X); }
        public Vector4I14F18 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, W, Y); }
        public Vector4I14F18 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, W, Z); }
        public Vector4I14F18 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, X, W, W); }
        public Vector4I14F18 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, X, X); }
        public Vector4I14F18 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, X, Y); }
        public Vector4I14F18 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, X, Z); }
        public Vector4I14F18 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, X, W); }
        public Vector4I14F18 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Y, X); }
        public Vector4I14F18 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Y, Y); }
        public Vector4I14F18 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Y, Z); }
        public Vector4I14F18 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Y, W); }
        public Vector4I14F18 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Z, X); }
        public Vector4I14F18 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Z, Y); }
        public Vector4I14F18 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Z, Z); }
        public Vector4I14F18 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, Z, W); }
        public Vector4I14F18 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, W, X); }
        public Vector4I14F18 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, W, Y); }
        public Vector4I14F18 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, W, Z); }
        public Vector4I14F18 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Y, W, W); }
        public Vector4I14F18 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, X, X); }
        public Vector4I14F18 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, X, Y); }
        public Vector4I14F18 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, X, Z); }
        public Vector4I14F18 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, X, W); }
        public Vector4I14F18 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Y, X); }
        public Vector4I14F18 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Y, Y); }
        public Vector4I14F18 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Y, Z); }
        public Vector4I14F18 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Y, W); }
        public Vector4I14F18 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Z, X); }
        public Vector4I14F18 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Z, Y); }
        public Vector4I14F18 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Z, Z); }
        public Vector4I14F18 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, Z, W); }
        public Vector4I14F18 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, W, X); }
        public Vector4I14F18 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, W, Y); }
        public Vector4I14F18 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, W, Z); }
        public Vector4I14F18 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, Z, W, W); }
        public Vector4I14F18 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, X, X); }
        public Vector4I14F18 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, X, Y); }
        public Vector4I14F18 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, X, Z); }
        public Vector4I14F18 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, X, W); }
        public Vector4I14F18 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, Y, X); }
        public Vector4I14F18 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, Y, Y); }
        public Vector4I14F18 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, Y, Z); }
        public Vector4I14F18 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, Y, W); }
        public Vector4I14F18 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, Z, X); }
        public Vector4I14F18 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, Z, Y); }
        public Vector4I14F18 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, Z, Z); }
        public Vector4I14F18 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, Z, W); }
        public Vector4I14F18 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, W, X); }
        public Vector4I14F18 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, W, Y); }
        public Vector4I14F18 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, W, Z); }
        public Vector4I14F18 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Z, W, W, W); }
        public Vector4I14F18 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, X, X); }
        public Vector4I14F18 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, X, Y); }
        public Vector4I14F18 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, X, Z); }
        public Vector4I14F18 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, X, W); }
        public Vector4I14F18 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, Y, X); }
        public Vector4I14F18 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, Y, Y); }
        public Vector4I14F18 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, Y, Z); }
        public Vector4I14F18 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, Y, W); }
        public Vector4I14F18 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, Z, X); }
        public Vector4I14F18 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, Z, Y); }
        public Vector4I14F18 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, Z, Z); }
        public Vector4I14F18 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, Z, W); }
        public Vector4I14F18 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, W, X); }
        public Vector4I14F18 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, W, Y); }
        public Vector4I14F18 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, W, Z); }
        public Vector4I14F18 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, X, W, W); }
        public Vector4I14F18 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, X, X); }
        public Vector4I14F18 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, X, Y); }
        public Vector4I14F18 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, X, Z); }
        public Vector4I14F18 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, X, W); }
        public Vector4I14F18 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, Y, X); }
        public Vector4I14F18 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, Y, Y); }
        public Vector4I14F18 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, Y, Z); }
        public Vector4I14F18 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, Y, W); }
        public Vector4I14F18 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, Z, X); }
        public Vector4I14F18 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, Z, Y); }
        public Vector4I14F18 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, Z, Z); }
        public Vector4I14F18 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, Z, W); }
        public Vector4I14F18 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, W, X); }
        public Vector4I14F18 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, W, Y); }
        public Vector4I14F18 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, W, Z); }
        public Vector4I14F18 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Y, W, W); }
        public Vector4I14F18 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, X, X); }
        public Vector4I14F18 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, X, Y); }
        public Vector4I14F18 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, X, Z); }
        public Vector4I14F18 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, X, W); }
        public Vector4I14F18 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, Y, X); }
        public Vector4I14F18 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, Y, Y); }
        public Vector4I14F18 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, Y, Z); }
        public Vector4I14F18 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, Y, W); }
        public Vector4I14F18 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, Z, X); }
        public Vector4I14F18 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, Z, Y); }
        public Vector4I14F18 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, Z, Z); }
        public Vector4I14F18 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, Z, W); }
        public Vector4I14F18 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, W, X); }
        public Vector4I14F18 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, W, Y); }
        public Vector4I14F18 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, W, Z); }
        public Vector4I14F18 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, Z, W, W); }
        public Vector4I14F18 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, X, X); }
        public Vector4I14F18 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, X, Y); }
        public Vector4I14F18 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, X, Z); }
        public Vector4I14F18 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, X, W); }
        public Vector4I14F18 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, Y, X); }
        public Vector4I14F18 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, Y, Y); }
        public Vector4I14F18 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, Y, Z); }
        public Vector4I14F18 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, Y, W); }
        public Vector4I14F18 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, Z, X); }
        public Vector4I14F18 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, Z, Y); }
        public Vector4I14F18 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, Z, Z); }
        public Vector4I14F18 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, Z, W); }
        public Vector4I14F18 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, W, X); }
        public Vector4I14F18 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, W, Y); }
        public Vector4I14F18 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, W, Z); }
        public Vector4I14F18 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector4I14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I14F18 other)
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
        public Vector4I14F18 Min(Vector4I14F18 other) => new Vector4I14F18(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Max(Vector4I14F18 other) => new Vector4I14F18(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Abs() => new Vector4I14F18(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Half() => new Vector4I14F18(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Twice() => new Vector4I14F18(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Clamp(I14F18 min, I14F18 max) => new Vector4I14F18(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Clamp(
            Vector4I14F18 min, Vector4I14F18 max
        ) => new Vector4I14F18(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 WrappingAdd(Vector4I14F18 other) => new Vector4I14F18(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 WrappingSub(Vector4I14F18 other) => new Vector4I14F18(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 WrappingMul(Vector4I14F18 other) => new Vector4I14F18(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 WrappingAddUnsigned(Vector4U14F18 other) => new Vector4I14F18(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 WrappingSubUnsigned(Vector4U14F18 other) => new Vector4I14F18(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18 UnsignedAbs() => new Vector4U14F18(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 SaturatingAdd(Vector4I14F18 other) => new Vector4I14F18(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 SaturatingMul(I14F18 other) => new Vector4I14F18(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I14F18 other) {
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
        public I14F18 Dot(Vector4I14F18 other) {
            const long k = 1L << 16;
            return I14F18.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I14F18 SaturatingDot(Vector4I14F18 other) {
            const long k = 1L << 16;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I14F18.MaxValue;
            } else if (bits < int.MinValue) {
                return I14F18.MinValue;
            } else {
                return I14F18.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

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
        public I30F34 LengthSquared() {
            return I30F34.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I14F18 LengthHalf() => I14F18.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I15F17 Length() => I15F17.FromBits(LengthInternal());

    }

    partial struct I14F18 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 SaturatingMul(Vector4I14F18 other) => other.SaturatingMul(this);
    }
}
