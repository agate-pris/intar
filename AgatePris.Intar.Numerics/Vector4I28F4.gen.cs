using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I28F4 : IEquatable<Vector4I28F4>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I28F4 X;
        public I28F4 Y;
        public I28F4 Z;
        public I28F4 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I28F4(I28F4 x, I28F4 y, I28F4 z, I28F4 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I28F4(I28F4 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I28F4(I28F4 x, I28F4 y, Vector2I28F4 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I28F4(I28F4 x, Vector3I28F4 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I28F4(Vector2I28F4 xy, Vector2I28F4 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I28F4(Vector4I28F4 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I28F4(I28F4 x, Vector2I28F4 yz, I28F4 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I28F4(Vector3I28F4 xyz, I28F4 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I28F4(Vector2I28F4 xy, I28F4 z, I28F4 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I28F4 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I28F4(I28F4.Zero);
        }
        public static Vector4I28F4 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I28F4(I28F4.One);
        }
        public static Vector4I28F4 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I28F4(I28F4.One, I28F4.Zero, I28F4.Zero, I28F4.Zero);
        }
        public static Vector4I28F4 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I28F4(I28F4.Zero, I28F4.One, I28F4.Zero, I28F4.Zero);
        }
        public static Vector4I28F4 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I28F4(I28F4.Zero, I28F4.Zero, I28F4.One, I28F4.Zero);
        }
        public static Vector4I28F4 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I28F4(I28F4.Zero, I28F4.Zero, I28F4.Zero, I28F4.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 operator +(Vector4I28F4 a, Vector4I28F4 b) => new Vector4I28F4(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 operator -(Vector4I28F4 a, Vector4I28F4 b) => new Vector4I28F4(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 operator *(Vector4I28F4 a, Vector4I28F4 b) => new Vector4I28F4(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 operator *(Vector4I28F4 a, I28F4 b) => new Vector4I28F4(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 operator *(I28F4 a, Vector4I28F4 b) => new Vector4I28F4(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 operator /(Vector4I28F4 a, Vector4I28F4 b) => new Vector4I28F4(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 operator /(Vector4I28F4 a, I28F4 b) => new Vector4I28F4(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 operator /(I28F4 a, Vector4I28F4 b) => new Vector4I28F4(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I28F4 lhs, Vector4I28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I28F4 lhs, Vector4I28F4 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I28F4 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, X); }
        public readonly Vector2I28F4 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, Y); }
        public readonly Vector2I28F4 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, Z); }
        public readonly Vector2I28F4 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, W); }
        public readonly Vector2I28F4 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, X); }
        public readonly Vector2I28F4 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, Y); }
        public readonly Vector2I28F4 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, Z); }
        public readonly Vector2I28F4 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, W); }
        public readonly Vector2I28F4 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Z, X); }
        public readonly Vector2I28F4 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Z, Y); }
        public readonly Vector2I28F4 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Z, Z); }
        public readonly Vector2I28F4 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Z, W); }
        public readonly Vector2I28F4 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(W, X); }
        public readonly Vector2I28F4 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(W, Y); }
        public readonly Vector2I28F4 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(W, Z); }
        public readonly Vector2I28F4 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(W, W); }
        public readonly Vector3I28F4 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, X); }
        public readonly Vector3I28F4 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, Y); }
        public readonly Vector3I28F4 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, Z); }
        public readonly Vector3I28F4 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, W); }
        public readonly Vector3I28F4 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, X); }
        public readonly Vector3I28F4 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, Y); }
        public readonly Vector3I28F4 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, Z); }
        public readonly Vector3I28F4 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, W); }
        public readonly Vector3I28F4 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Z, X); }
        public readonly Vector3I28F4 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Z, Y); }
        public readonly Vector3I28F4 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Z, Z); }
        public readonly Vector3I28F4 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Z, W); }
        public readonly Vector3I28F4 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, W, X); }
        public readonly Vector3I28F4 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, W, Y); }
        public readonly Vector3I28F4 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, W, Z); }
        public readonly Vector3I28F4 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, W, W); }
        public readonly Vector3I28F4 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, X); }
        public readonly Vector3I28F4 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, Y); }
        public readonly Vector3I28F4 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, Z); }
        public readonly Vector3I28F4 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, W); }
        public readonly Vector3I28F4 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, X); }
        public readonly Vector3I28F4 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, Y); }
        public readonly Vector3I28F4 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, Z); }
        public readonly Vector3I28F4 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, W); }
        public readonly Vector3I28F4 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Z, X); }
        public readonly Vector3I28F4 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Z, Y); }
        public readonly Vector3I28F4 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Z, Z); }
        public readonly Vector3I28F4 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Z, W); }
        public readonly Vector3I28F4 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, W, X); }
        public readonly Vector3I28F4 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, W, Y); }
        public readonly Vector3I28F4 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, W, Z); }
        public readonly Vector3I28F4 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, W, W); }
        public readonly Vector3I28F4 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, X, X); }
        public readonly Vector3I28F4 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, X, Y); }
        public readonly Vector3I28F4 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, X, Z); }
        public readonly Vector3I28F4 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, X, W); }
        public readonly Vector3I28F4 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Y, X); }
        public readonly Vector3I28F4 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Y, Y); }
        public readonly Vector3I28F4 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Y, Z); }
        public readonly Vector3I28F4 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Y, W); }
        public readonly Vector3I28F4 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Z, X); }
        public readonly Vector3I28F4 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Z, Y); }
        public readonly Vector3I28F4 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Z, Z); }
        public readonly Vector3I28F4 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, Z, W); }
        public readonly Vector3I28F4 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, W, X); }
        public readonly Vector3I28F4 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, W, Y); }
        public readonly Vector3I28F4 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, W, Z); }
        public readonly Vector3I28F4 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Z, W, W); }
        public readonly Vector3I28F4 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, X, X); }
        public readonly Vector3I28F4 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, X, Y); }
        public readonly Vector3I28F4 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, X, Z); }
        public readonly Vector3I28F4 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, X, W); }
        public readonly Vector3I28F4 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, Y, X); }
        public readonly Vector3I28F4 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, Y, Y); }
        public readonly Vector3I28F4 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, Y, Z); }
        public readonly Vector3I28F4 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, Y, W); }
        public readonly Vector3I28F4 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, Z, X); }
        public readonly Vector3I28F4 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, Z, Y); }
        public readonly Vector3I28F4 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, Z, Z); }
        public readonly Vector3I28F4 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, Z, W); }
        public readonly Vector3I28F4 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, W, X); }
        public readonly Vector3I28F4 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, W, Y); }
        public readonly Vector3I28F4 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, W, Z); }
        public readonly Vector3I28F4 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(W, W, W); }
        public readonly Vector4I28F4 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, X); }
        public readonly Vector4I28F4 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, Y); }
        public readonly Vector4I28F4 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, Z); }
        public readonly Vector4I28F4 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, W); }
        public readonly Vector4I28F4 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, X); }
        public readonly Vector4I28F4 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, Y); }
        public readonly Vector4I28F4 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, Z); }
        public readonly Vector4I28F4 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, W); }
        public readonly Vector4I28F4 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Z, X); }
        public readonly Vector4I28F4 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Z, Y); }
        public readonly Vector4I28F4 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Z, Z); }
        public readonly Vector4I28F4 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Z, W); }
        public readonly Vector4I28F4 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, W, X); }
        public readonly Vector4I28F4 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, W, Y); }
        public readonly Vector4I28F4 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, W, Z); }
        public readonly Vector4I28F4 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, W, W); }
        public readonly Vector4I28F4 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, X); }
        public readonly Vector4I28F4 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, Y); }
        public readonly Vector4I28F4 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, Z); }
        public readonly Vector4I28F4 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, W); }
        public readonly Vector4I28F4 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, X); }
        public readonly Vector4I28F4 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, Y); }
        public readonly Vector4I28F4 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, Z); }
        public readonly Vector4I28F4 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, W); }
        public readonly Vector4I28F4 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Z, X); }
        public readonly Vector4I28F4 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Z, Y); }
        public readonly Vector4I28F4 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Z, Z); }
        public readonly Vector4I28F4 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Z, W); }
        public readonly Vector4I28F4 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, W, X); }
        public readonly Vector4I28F4 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, W, Y); }
        public readonly Vector4I28F4 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, W, Z); }
        public readonly Vector4I28F4 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, W, W); }
        public readonly Vector4I28F4 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, X, X); }
        public readonly Vector4I28F4 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, X, Y); }
        public readonly Vector4I28F4 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, X, Z); }
        public readonly Vector4I28F4 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, X, W); }
        public readonly Vector4I28F4 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Y, X); }
        public readonly Vector4I28F4 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Y, Y); }
        public readonly Vector4I28F4 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Y, Z); }
        public readonly Vector4I28F4 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Y, W); }
        public readonly Vector4I28F4 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Z, X); }
        public readonly Vector4I28F4 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Z, Y); }
        public readonly Vector4I28F4 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Z, Z); }
        public readonly Vector4I28F4 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, Z, W); }
        public readonly Vector4I28F4 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, W, X); }
        public readonly Vector4I28F4 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, W, Y); }
        public readonly Vector4I28F4 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, W, Z); }
        public readonly Vector4I28F4 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Z, W, W); }
        public readonly Vector4I28F4 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, X, X); }
        public readonly Vector4I28F4 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, X, Y); }
        public readonly Vector4I28F4 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, X, Z); }
        public readonly Vector4I28F4 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, X, W); }
        public readonly Vector4I28F4 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, Y, X); }
        public readonly Vector4I28F4 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, Y, Y); }
        public readonly Vector4I28F4 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, Y, Z); }
        public readonly Vector4I28F4 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, Y, W); }
        public readonly Vector4I28F4 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, Z, X); }
        public readonly Vector4I28F4 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, Z, Y); }
        public readonly Vector4I28F4 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, Z, Z); }
        public readonly Vector4I28F4 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, Z, W); }
        public readonly Vector4I28F4 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, W, X); }
        public readonly Vector4I28F4 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, W, Y); }
        public readonly Vector4I28F4 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, W, Z); }
        public readonly Vector4I28F4 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, W, W, W); }
        public readonly Vector4I28F4 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, X); }
        public readonly Vector4I28F4 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, Y); }
        public readonly Vector4I28F4 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, Z); }
        public readonly Vector4I28F4 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, W); }
        public readonly Vector4I28F4 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, X); }
        public readonly Vector4I28F4 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, Y); }
        public readonly Vector4I28F4 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, Z); }
        public readonly Vector4I28F4 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, W); }
        public readonly Vector4I28F4 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Z, X); }
        public readonly Vector4I28F4 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Z, Y); }
        public readonly Vector4I28F4 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Z, Z); }
        public readonly Vector4I28F4 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Z, W); }
        public readonly Vector4I28F4 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, W, X); }
        public readonly Vector4I28F4 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, W, Y); }
        public readonly Vector4I28F4 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, W, Z); }
        public readonly Vector4I28F4 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, W, W); }
        public readonly Vector4I28F4 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, X); }
        public readonly Vector4I28F4 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, Y); }
        public readonly Vector4I28F4 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, Z); }
        public readonly Vector4I28F4 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, W); }
        public readonly Vector4I28F4 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, X); }
        public readonly Vector4I28F4 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, Y); }
        public readonly Vector4I28F4 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, Z); }
        public readonly Vector4I28F4 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, W); }
        public readonly Vector4I28F4 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Z, X); }
        public readonly Vector4I28F4 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Z, Y); }
        public readonly Vector4I28F4 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Z, Z); }
        public readonly Vector4I28F4 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Z, W); }
        public readonly Vector4I28F4 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, W, X); }
        public readonly Vector4I28F4 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, W, Y); }
        public readonly Vector4I28F4 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, W, Z); }
        public readonly Vector4I28F4 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, W, W); }
        public readonly Vector4I28F4 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, X, X); }
        public readonly Vector4I28F4 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, X, Y); }
        public readonly Vector4I28F4 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, X, Z); }
        public readonly Vector4I28F4 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, X, W); }
        public readonly Vector4I28F4 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Y, X); }
        public readonly Vector4I28F4 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Y, Y); }
        public readonly Vector4I28F4 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Y, Z); }
        public readonly Vector4I28F4 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Y, W); }
        public readonly Vector4I28F4 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Z, X); }
        public readonly Vector4I28F4 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Z, Y); }
        public readonly Vector4I28F4 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Z, Z); }
        public readonly Vector4I28F4 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, Z, W); }
        public readonly Vector4I28F4 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, W, X); }
        public readonly Vector4I28F4 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, W, Y); }
        public readonly Vector4I28F4 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, W, Z); }
        public readonly Vector4I28F4 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Z, W, W); }
        public readonly Vector4I28F4 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, X, X); }
        public readonly Vector4I28F4 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, X, Y); }
        public readonly Vector4I28F4 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, X, Z); }
        public readonly Vector4I28F4 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, X, W); }
        public readonly Vector4I28F4 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, Y, X); }
        public readonly Vector4I28F4 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, Y, Y); }
        public readonly Vector4I28F4 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, Y, Z); }
        public readonly Vector4I28F4 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, Y, W); }
        public readonly Vector4I28F4 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, Z, X); }
        public readonly Vector4I28F4 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, Z, Y); }
        public readonly Vector4I28F4 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, Z, Z); }
        public readonly Vector4I28F4 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, Z, W); }
        public readonly Vector4I28F4 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, W, X); }
        public readonly Vector4I28F4 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, W, Y); }
        public readonly Vector4I28F4 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, W, Z); }
        public readonly Vector4I28F4 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, W, W, W); }
        public readonly Vector4I28F4 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, X, X); }
        public readonly Vector4I28F4 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, X, Y); }
        public readonly Vector4I28F4 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, X, Z); }
        public readonly Vector4I28F4 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, X, W); }
        public readonly Vector4I28F4 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Y, X); }
        public readonly Vector4I28F4 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Y, Y); }
        public readonly Vector4I28F4 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Y, Z); }
        public readonly Vector4I28F4 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Y, W); }
        public readonly Vector4I28F4 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Z, X); }
        public readonly Vector4I28F4 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Z, Y); }
        public readonly Vector4I28F4 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Z, Z); }
        public readonly Vector4I28F4 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, Z, W); }
        public readonly Vector4I28F4 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, W, X); }
        public readonly Vector4I28F4 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, W, Y); }
        public readonly Vector4I28F4 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, W, Z); }
        public readonly Vector4I28F4 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, X, W, W); }
        public readonly Vector4I28F4 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, X, X); }
        public readonly Vector4I28F4 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, X, Y); }
        public readonly Vector4I28F4 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, X, Z); }
        public readonly Vector4I28F4 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, X, W); }
        public readonly Vector4I28F4 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Y, X); }
        public readonly Vector4I28F4 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Y, Y); }
        public readonly Vector4I28F4 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Y, Z); }
        public readonly Vector4I28F4 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Y, W); }
        public readonly Vector4I28F4 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Z, X); }
        public readonly Vector4I28F4 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Z, Y); }
        public readonly Vector4I28F4 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Z, Z); }
        public readonly Vector4I28F4 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, Z, W); }
        public readonly Vector4I28F4 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, W, X); }
        public readonly Vector4I28F4 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, W, Y); }
        public readonly Vector4I28F4 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, W, Z); }
        public readonly Vector4I28F4 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Y, W, W); }
        public readonly Vector4I28F4 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, X, X); }
        public readonly Vector4I28F4 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, X, Y); }
        public readonly Vector4I28F4 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, X, Z); }
        public readonly Vector4I28F4 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, X, W); }
        public readonly Vector4I28F4 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Y, X); }
        public readonly Vector4I28F4 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Y, Y); }
        public readonly Vector4I28F4 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Y, Z); }
        public readonly Vector4I28F4 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Y, W); }
        public readonly Vector4I28F4 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Z, X); }
        public readonly Vector4I28F4 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Z, Y); }
        public readonly Vector4I28F4 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Z, Z); }
        public readonly Vector4I28F4 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, Z, W); }
        public readonly Vector4I28F4 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, W, X); }
        public readonly Vector4I28F4 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, W, Y); }
        public readonly Vector4I28F4 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, W, Z); }
        public readonly Vector4I28F4 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, Z, W, W); }
        public readonly Vector4I28F4 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, X, X); }
        public readonly Vector4I28F4 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, X, Y); }
        public readonly Vector4I28F4 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, X, Z); }
        public readonly Vector4I28F4 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, X, W); }
        public readonly Vector4I28F4 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, Y, X); }
        public readonly Vector4I28F4 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, Y, Y); }
        public readonly Vector4I28F4 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, Y, Z); }
        public readonly Vector4I28F4 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, Y, W); }
        public readonly Vector4I28F4 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, Z, X); }
        public readonly Vector4I28F4 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, Z, Y); }
        public readonly Vector4I28F4 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, Z, Z); }
        public readonly Vector4I28F4 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, Z, W); }
        public readonly Vector4I28F4 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, W, X); }
        public readonly Vector4I28F4 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, W, Y); }
        public readonly Vector4I28F4 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, W, Z); }
        public readonly Vector4I28F4 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Z, W, W, W); }
        public readonly Vector4I28F4 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, X, X); }
        public readonly Vector4I28F4 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, X, Y); }
        public readonly Vector4I28F4 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, X, Z); }
        public readonly Vector4I28F4 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, X, W); }
        public readonly Vector4I28F4 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, Y, X); }
        public readonly Vector4I28F4 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, Y, Y); }
        public readonly Vector4I28F4 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, Y, Z); }
        public readonly Vector4I28F4 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, Y, W); }
        public readonly Vector4I28F4 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, Z, X); }
        public readonly Vector4I28F4 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, Z, Y); }
        public readonly Vector4I28F4 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, Z, Z); }
        public readonly Vector4I28F4 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, Z, W); }
        public readonly Vector4I28F4 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, W, X); }
        public readonly Vector4I28F4 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, W, Y); }
        public readonly Vector4I28F4 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, W, Z); }
        public readonly Vector4I28F4 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, X, W, W); }
        public readonly Vector4I28F4 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, X, X); }
        public readonly Vector4I28F4 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, X, Y); }
        public readonly Vector4I28F4 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, X, Z); }
        public readonly Vector4I28F4 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, X, W); }
        public readonly Vector4I28F4 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, Y, X); }
        public readonly Vector4I28F4 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, Y, Y); }
        public readonly Vector4I28F4 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, Y, Z); }
        public readonly Vector4I28F4 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, Y, W); }
        public readonly Vector4I28F4 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, Z, X); }
        public readonly Vector4I28F4 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, Z, Y); }
        public readonly Vector4I28F4 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, Z, Z); }
        public readonly Vector4I28F4 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, Z, W); }
        public readonly Vector4I28F4 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, W, X); }
        public readonly Vector4I28F4 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, W, Y); }
        public readonly Vector4I28F4 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, W, Z); }
        public readonly Vector4I28F4 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Y, W, W); }
        public readonly Vector4I28F4 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, X, X); }
        public readonly Vector4I28F4 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, X, Y); }
        public readonly Vector4I28F4 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, X, Z); }
        public readonly Vector4I28F4 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, X, W); }
        public readonly Vector4I28F4 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, Y, X); }
        public readonly Vector4I28F4 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, Y, Y); }
        public readonly Vector4I28F4 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, Y, Z); }
        public readonly Vector4I28F4 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, Y, W); }
        public readonly Vector4I28F4 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, Z, X); }
        public readonly Vector4I28F4 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, Z, Y); }
        public readonly Vector4I28F4 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, Z, Z); }
        public readonly Vector4I28F4 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, Z, W); }
        public readonly Vector4I28F4 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, W, X); }
        public readonly Vector4I28F4 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, W, Y); }
        public readonly Vector4I28F4 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, W, Z); }
        public readonly Vector4I28F4 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, Z, W, W); }
        public readonly Vector4I28F4 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, X, X); }
        public readonly Vector4I28F4 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, X, Y); }
        public readonly Vector4I28F4 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, X, Z); }
        public readonly Vector4I28F4 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, X, W); }
        public readonly Vector4I28F4 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, Y, X); }
        public readonly Vector4I28F4 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, Y, Y); }
        public readonly Vector4I28F4 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, Y, Z); }
        public readonly Vector4I28F4 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, Y, W); }
        public readonly Vector4I28F4 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, Z, X); }
        public readonly Vector4I28F4 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, Z, Y); }
        public readonly Vector4I28F4 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, Z, Z); }
        public readonly Vector4I28F4 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, Z, W); }
        public readonly Vector4I28F4 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, W, X); }
        public readonly Vector4I28F4 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, W, Y); }
        public readonly Vector4I28F4 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, W, Z); }
        public readonly Vector4I28F4 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I28F4 other)
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

        public readonly Vector4I28F4 Half() => new Vector4I28F4(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4I28F4 Twice() => new Vector4I28F4(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4I28F4 Clamp(I28F4 min, I28F4 max) => new Vector4I28F4(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4I28F4 Clamp(
            Vector4I28F4 min, Vector4I28F4 max
        ) => new Vector4I28F4(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I28F4 SaturatingAdd(Vector4I28F4 other) => new Vector4I28F4(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I28F4 SaturatingMul(I28F4 other) => new Vector4I28F4(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

    }

    partial struct I28F4 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I28F4 SaturatingMul(Vector4I28F4 other) => other.SaturatingMul(this);
    }
}
