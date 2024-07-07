using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I5F27 : IEquatable<Vector4I5F27>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I5F27 X;
        public I5F27 Y;
        public I5F27 Z;
        public I5F27 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, I5F27 y, I5F27 z, I5F27 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, I5F27 y, Vector2I5F27 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, Vector3I5F27 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector2I5F27 xy, Vector2I5F27 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector4I5F27 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, Vector2I5F27 yz, I5F27 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector3I5F27 xyz, I5F27 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector2I5F27 xy, I5F27 z, I5F27 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I5F27 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.Zero);
        }
        public static Vector4I5F27 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.One);
        }
        public static Vector4I5F27 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.One, I5F27.Zero, I5F27.Zero, I5F27.Zero);
        }
        public static Vector4I5F27 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.Zero, I5F27.One, I5F27.Zero, I5F27.Zero);
        }
        public static Vector4I5F27 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.Zero, I5F27.Zero, I5F27.One, I5F27.Zero);
        }
        public static Vector4I5F27 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.Zero, I5F27.Zero, I5F27.Zero, I5F27.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator +(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator -(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator *(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator *(Vector4I5F27 a, I5F27 b) => new Vector4I5F27(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator *(I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator /(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator /(Vector4I5F27 a, I5F27 b) => new Vector4I5F27(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator /(I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I5F27 lhs, Vector4I5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I5F27 lhs, Vector4I5F27 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I5F27 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, X); }
        public readonly Vector2I5F27 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, Y); }
        public readonly Vector2I5F27 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, Z); }
        public readonly Vector2I5F27 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, W); }
        public readonly Vector2I5F27 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, X); }
        public readonly Vector2I5F27 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, Y); }
        public readonly Vector2I5F27 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, Z); }
        public readonly Vector2I5F27 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, W); }
        public readonly Vector2I5F27 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, X); }
        public readonly Vector2I5F27 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, Y); }
        public readonly Vector2I5F27 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, Z); }
        public readonly Vector2I5F27 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Z, W); }
        public readonly Vector2I5F27 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(W, X); }
        public readonly Vector2I5F27 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(W, Y); }
        public readonly Vector2I5F27 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(W, Z); }
        public readonly Vector2I5F27 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(W, W); }
        public readonly Vector3I5F27 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, X); }
        public readonly Vector3I5F27 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, Y); }
        public readonly Vector3I5F27 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, Z); }
        public readonly Vector3I5F27 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, W); }
        public readonly Vector3I5F27 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, X); }
        public readonly Vector3I5F27 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, Y); }
        public readonly Vector3I5F27 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, Z); }
        public readonly Vector3I5F27 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, W); }
        public readonly Vector3I5F27 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, X); }
        public readonly Vector3I5F27 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, Y); }
        public readonly Vector3I5F27 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, Z); }
        public readonly Vector3I5F27 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Z, W); }
        public readonly Vector3I5F27 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, W, X); }
        public readonly Vector3I5F27 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, W, Y); }
        public readonly Vector3I5F27 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, W, Z); }
        public readonly Vector3I5F27 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, W, W); }
        public readonly Vector3I5F27 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, X); }
        public readonly Vector3I5F27 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, Y); }
        public readonly Vector3I5F27 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, Z); }
        public readonly Vector3I5F27 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, W); }
        public readonly Vector3I5F27 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, X); }
        public readonly Vector3I5F27 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, Y); }
        public readonly Vector3I5F27 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, Z); }
        public readonly Vector3I5F27 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, W); }
        public readonly Vector3I5F27 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, X); }
        public readonly Vector3I5F27 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, Y); }
        public readonly Vector3I5F27 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, Z); }
        public readonly Vector3I5F27 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Z, W); }
        public readonly Vector3I5F27 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, W, X); }
        public readonly Vector3I5F27 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, W, Y); }
        public readonly Vector3I5F27 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, W, Z); }
        public readonly Vector3I5F27 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, W, W); }
        public readonly Vector3I5F27 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, X); }
        public readonly Vector3I5F27 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, Y); }
        public readonly Vector3I5F27 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, Z); }
        public readonly Vector3I5F27 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, X, W); }
        public readonly Vector3I5F27 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, X); }
        public readonly Vector3I5F27 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, Y); }
        public readonly Vector3I5F27 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, Z); }
        public readonly Vector3I5F27 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Y, W); }
        public readonly Vector3I5F27 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, X); }
        public readonly Vector3I5F27 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, Y); }
        public readonly Vector3I5F27 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, Z); }
        public readonly Vector3I5F27 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, Z, W); }
        public readonly Vector3I5F27 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, W, X); }
        public readonly Vector3I5F27 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, W, Y); }
        public readonly Vector3I5F27 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, W, Z); }
        public readonly Vector3I5F27 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Z, W, W); }
        public readonly Vector3I5F27 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, X, X); }
        public readonly Vector3I5F27 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, X, Y); }
        public readonly Vector3I5F27 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, X, Z); }
        public readonly Vector3I5F27 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, X, W); }
        public readonly Vector3I5F27 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Y, X); }
        public readonly Vector3I5F27 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Y, Y); }
        public readonly Vector3I5F27 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Y, Z); }
        public readonly Vector3I5F27 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Y, W); }
        public readonly Vector3I5F27 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Z, X); }
        public readonly Vector3I5F27 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Z, Y); }
        public readonly Vector3I5F27 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Z, Z); }
        public readonly Vector3I5F27 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, Z, W); }
        public readonly Vector3I5F27 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, W, X); }
        public readonly Vector3I5F27 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, W, Y); }
        public readonly Vector3I5F27 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, W, Z); }
        public readonly Vector3I5F27 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(W, W, W); }
        public readonly Vector4I5F27 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, X); }
        public readonly Vector4I5F27 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, Y); }
        public readonly Vector4I5F27 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, Z); }
        public readonly Vector4I5F27 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, W); }
        public readonly Vector4I5F27 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, X); }
        public readonly Vector4I5F27 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, Y); }
        public readonly Vector4I5F27 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, Z); }
        public readonly Vector4I5F27 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, W); }
        public readonly Vector4I5F27 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, X); }
        public readonly Vector4I5F27 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, Y); }
        public readonly Vector4I5F27 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, Z); }
        public readonly Vector4I5F27 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Z, W); }
        public readonly Vector4I5F27 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, W, X); }
        public readonly Vector4I5F27 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, W, Y); }
        public readonly Vector4I5F27 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, W, Z); }
        public readonly Vector4I5F27 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, W, W); }
        public readonly Vector4I5F27 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, X); }
        public readonly Vector4I5F27 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, Y); }
        public readonly Vector4I5F27 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, Z); }
        public readonly Vector4I5F27 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, W); }
        public readonly Vector4I5F27 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, X); }
        public readonly Vector4I5F27 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, Y); }
        public readonly Vector4I5F27 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, Z); }
        public readonly Vector4I5F27 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, W); }
        public readonly Vector4I5F27 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, X); }
        public readonly Vector4I5F27 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, Y); }
        public readonly Vector4I5F27 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, Z); }
        public readonly Vector4I5F27 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Z, W); }
        public readonly Vector4I5F27 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, W, X); }
        public readonly Vector4I5F27 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, W, Y); }
        public readonly Vector4I5F27 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, W, Z); }
        public readonly Vector4I5F27 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, W, W); }
        public readonly Vector4I5F27 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, X); }
        public readonly Vector4I5F27 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, Y); }
        public readonly Vector4I5F27 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, Z); }
        public readonly Vector4I5F27 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, X, W); }
        public readonly Vector4I5F27 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, X); }
        public readonly Vector4I5F27 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, Y); }
        public readonly Vector4I5F27 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, Z); }
        public readonly Vector4I5F27 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Y, W); }
        public readonly Vector4I5F27 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, X); }
        public readonly Vector4I5F27 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, Y); }
        public readonly Vector4I5F27 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, Z); }
        public readonly Vector4I5F27 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, Z, W); }
        public readonly Vector4I5F27 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, W, X); }
        public readonly Vector4I5F27 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, W, Y); }
        public readonly Vector4I5F27 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, W, Z); }
        public readonly Vector4I5F27 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Z, W, W); }
        public readonly Vector4I5F27 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, X, X); }
        public readonly Vector4I5F27 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, X, Y); }
        public readonly Vector4I5F27 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, X, Z); }
        public readonly Vector4I5F27 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, X, W); }
        public readonly Vector4I5F27 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Y, X); }
        public readonly Vector4I5F27 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Y, Y); }
        public readonly Vector4I5F27 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Y, Z); }
        public readonly Vector4I5F27 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Y, W); }
        public readonly Vector4I5F27 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Z, X); }
        public readonly Vector4I5F27 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Z, Y); }
        public readonly Vector4I5F27 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Z, Z); }
        public readonly Vector4I5F27 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, Z, W); }
        public readonly Vector4I5F27 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, W, X); }
        public readonly Vector4I5F27 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, W, Y); }
        public readonly Vector4I5F27 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, W, Z); }
        public readonly Vector4I5F27 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, W, W, W); }
        public readonly Vector4I5F27 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, X); }
        public readonly Vector4I5F27 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, Y); }
        public readonly Vector4I5F27 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, Z); }
        public readonly Vector4I5F27 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, W); }
        public readonly Vector4I5F27 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, X); }
        public readonly Vector4I5F27 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, Y); }
        public readonly Vector4I5F27 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, Z); }
        public readonly Vector4I5F27 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, W); }
        public readonly Vector4I5F27 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, X); }
        public readonly Vector4I5F27 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, Y); }
        public readonly Vector4I5F27 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, Z); }
        public readonly Vector4I5F27 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Z, W); }
        public readonly Vector4I5F27 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, W, X); }
        public readonly Vector4I5F27 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, W, Y); }
        public readonly Vector4I5F27 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, W, Z); }
        public readonly Vector4I5F27 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, W, W); }
        public readonly Vector4I5F27 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, X); }
        public readonly Vector4I5F27 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, Y); }
        public readonly Vector4I5F27 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, Z); }
        public readonly Vector4I5F27 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, W); }
        public readonly Vector4I5F27 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, X); }
        public readonly Vector4I5F27 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, Y); }
        public readonly Vector4I5F27 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, Z); }
        public readonly Vector4I5F27 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, W); }
        public readonly Vector4I5F27 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, X); }
        public readonly Vector4I5F27 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, Y); }
        public readonly Vector4I5F27 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, Z); }
        public readonly Vector4I5F27 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Z, W); }
        public readonly Vector4I5F27 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, W, X); }
        public readonly Vector4I5F27 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, W, Y); }
        public readonly Vector4I5F27 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, W, Z); }
        public readonly Vector4I5F27 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, W, W); }
        public readonly Vector4I5F27 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, X); }
        public readonly Vector4I5F27 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, Y); }
        public readonly Vector4I5F27 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, Z); }
        public readonly Vector4I5F27 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, X, W); }
        public readonly Vector4I5F27 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, X); }
        public readonly Vector4I5F27 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, Y); }
        public readonly Vector4I5F27 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, Z); }
        public readonly Vector4I5F27 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Y, W); }
        public readonly Vector4I5F27 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, X); }
        public readonly Vector4I5F27 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, Y); }
        public readonly Vector4I5F27 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, Z); }
        public readonly Vector4I5F27 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, Z, W); }
        public readonly Vector4I5F27 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, W, X); }
        public readonly Vector4I5F27 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, W, Y); }
        public readonly Vector4I5F27 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, W, Z); }
        public readonly Vector4I5F27 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Z, W, W); }
        public readonly Vector4I5F27 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, X, X); }
        public readonly Vector4I5F27 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, X, Y); }
        public readonly Vector4I5F27 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, X, Z); }
        public readonly Vector4I5F27 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, X, W); }
        public readonly Vector4I5F27 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Y, X); }
        public readonly Vector4I5F27 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Y, Y); }
        public readonly Vector4I5F27 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Y, Z); }
        public readonly Vector4I5F27 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Y, W); }
        public readonly Vector4I5F27 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Z, X); }
        public readonly Vector4I5F27 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Z, Y); }
        public readonly Vector4I5F27 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Z, Z); }
        public readonly Vector4I5F27 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, Z, W); }
        public readonly Vector4I5F27 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, W, X); }
        public readonly Vector4I5F27 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, W, Y); }
        public readonly Vector4I5F27 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, W, Z); }
        public readonly Vector4I5F27 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, W, W, W); }
        public readonly Vector4I5F27 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, X); }
        public readonly Vector4I5F27 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, Y); }
        public readonly Vector4I5F27 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, Z); }
        public readonly Vector4I5F27 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, X, W); }
        public readonly Vector4I5F27 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, X); }
        public readonly Vector4I5F27 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, Y); }
        public readonly Vector4I5F27 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, Z); }
        public readonly Vector4I5F27 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Y, W); }
        public readonly Vector4I5F27 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, X); }
        public readonly Vector4I5F27 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, Y); }
        public readonly Vector4I5F27 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, Z); }
        public readonly Vector4I5F27 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, Z, W); }
        public readonly Vector4I5F27 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, W, X); }
        public readonly Vector4I5F27 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, W, Y); }
        public readonly Vector4I5F27 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, W, Z); }
        public readonly Vector4I5F27 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, X, W, W); }
        public readonly Vector4I5F27 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, X); }
        public readonly Vector4I5F27 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, Y); }
        public readonly Vector4I5F27 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, Z); }
        public readonly Vector4I5F27 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, X, W); }
        public readonly Vector4I5F27 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, X); }
        public readonly Vector4I5F27 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, Y); }
        public readonly Vector4I5F27 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, Z); }
        public readonly Vector4I5F27 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Y, W); }
        public readonly Vector4I5F27 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, X); }
        public readonly Vector4I5F27 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, Y); }
        public readonly Vector4I5F27 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, Z); }
        public readonly Vector4I5F27 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, Z, W); }
        public readonly Vector4I5F27 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, W, X); }
        public readonly Vector4I5F27 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, W, Y); }
        public readonly Vector4I5F27 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, W, Z); }
        public readonly Vector4I5F27 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Y, W, W); }
        public readonly Vector4I5F27 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, X); }
        public readonly Vector4I5F27 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, Y); }
        public readonly Vector4I5F27 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, Z); }
        public readonly Vector4I5F27 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, X, W); }
        public readonly Vector4I5F27 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, X); }
        public readonly Vector4I5F27 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, Y); }
        public readonly Vector4I5F27 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, Z); }
        public readonly Vector4I5F27 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Y, W); }
        public readonly Vector4I5F27 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, X); }
        public readonly Vector4I5F27 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, Y); }
        public readonly Vector4I5F27 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, Z); }
        public readonly Vector4I5F27 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, Z, W); }
        public readonly Vector4I5F27 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, W, X); }
        public readonly Vector4I5F27 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, W, Y); }
        public readonly Vector4I5F27 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, W, Z); }
        public readonly Vector4I5F27 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, Z, W, W); }
        public readonly Vector4I5F27 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, X, X); }
        public readonly Vector4I5F27 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, X, Y); }
        public readonly Vector4I5F27 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, X, Z); }
        public readonly Vector4I5F27 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, X, W); }
        public readonly Vector4I5F27 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Y, X); }
        public readonly Vector4I5F27 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Y, Y); }
        public readonly Vector4I5F27 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Y, Z); }
        public readonly Vector4I5F27 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Y, W); }
        public readonly Vector4I5F27 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Z, X); }
        public readonly Vector4I5F27 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Z, Y); }
        public readonly Vector4I5F27 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Z, Z); }
        public readonly Vector4I5F27 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, Z, W); }
        public readonly Vector4I5F27 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, W, X); }
        public readonly Vector4I5F27 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, W, Y); }
        public readonly Vector4I5F27 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, W, Z); }
        public readonly Vector4I5F27 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Z, W, W, W); }
        public readonly Vector4I5F27 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, X, X); }
        public readonly Vector4I5F27 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, X, Y); }
        public readonly Vector4I5F27 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, X, Z); }
        public readonly Vector4I5F27 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, X, W); }
        public readonly Vector4I5F27 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Y, X); }
        public readonly Vector4I5F27 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Y, Y); }
        public readonly Vector4I5F27 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Y, Z); }
        public readonly Vector4I5F27 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Y, W); }
        public readonly Vector4I5F27 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Z, X); }
        public readonly Vector4I5F27 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Z, Y); }
        public readonly Vector4I5F27 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Z, Z); }
        public readonly Vector4I5F27 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, Z, W); }
        public readonly Vector4I5F27 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, W, X); }
        public readonly Vector4I5F27 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, W, Y); }
        public readonly Vector4I5F27 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, W, Z); }
        public readonly Vector4I5F27 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, X, W, W); }
        public readonly Vector4I5F27 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, X, X); }
        public readonly Vector4I5F27 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, X, Y); }
        public readonly Vector4I5F27 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, X, Z); }
        public readonly Vector4I5F27 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, X, W); }
        public readonly Vector4I5F27 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Y, X); }
        public readonly Vector4I5F27 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Y, Y); }
        public readonly Vector4I5F27 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Y, Z); }
        public readonly Vector4I5F27 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Y, W); }
        public readonly Vector4I5F27 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Z, X); }
        public readonly Vector4I5F27 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Z, Y); }
        public readonly Vector4I5F27 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Z, Z); }
        public readonly Vector4I5F27 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, Z, W); }
        public readonly Vector4I5F27 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, W, X); }
        public readonly Vector4I5F27 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, W, Y); }
        public readonly Vector4I5F27 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, W, Z); }
        public readonly Vector4I5F27 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Y, W, W); }
        public readonly Vector4I5F27 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, X, X); }
        public readonly Vector4I5F27 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, X, Y); }
        public readonly Vector4I5F27 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, X, Z); }
        public readonly Vector4I5F27 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, X, W); }
        public readonly Vector4I5F27 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Y, X); }
        public readonly Vector4I5F27 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Y, Y); }
        public readonly Vector4I5F27 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Y, Z); }
        public readonly Vector4I5F27 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Y, W); }
        public readonly Vector4I5F27 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Z, X); }
        public readonly Vector4I5F27 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Z, Y); }
        public readonly Vector4I5F27 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Z, Z); }
        public readonly Vector4I5F27 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, Z, W); }
        public readonly Vector4I5F27 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, W, X); }
        public readonly Vector4I5F27 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, W, Y); }
        public readonly Vector4I5F27 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, W, Z); }
        public readonly Vector4I5F27 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, Z, W, W); }
        public readonly Vector4I5F27 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, X, X); }
        public readonly Vector4I5F27 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, X, Y); }
        public readonly Vector4I5F27 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, X, Z); }
        public readonly Vector4I5F27 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, X, W); }
        public readonly Vector4I5F27 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Y, X); }
        public readonly Vector4I5F27 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Y, Y); }
        public readonly Vector4I5F27 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Y, Z); }
        public readonly Vector4I5F27 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Y, W); }
        public readonly Vector4I5F27 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Z, X); }
        public readonly Vector4I5F27 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Z, Y); }
        public readonly Vector4I5F27 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Z, Z); }
        public readonly Vector4I5F27 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, Z, W); }
        public readonly Vector4I5F27 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, W, X); }
        public readonly Vector4I5F27 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, W, Y); }
        public readonly Vector4I5F27 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, W, Z); }
        public readonly Vector4I5F27 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I5F27 other)
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

        public readonly Vector4I5F27 Half() => new Vector4I5F27(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4I5F27 Twice() => new Vector4I5F27(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4I5F27 Clamp(I5F27 min, I5F27 max) => new Vector4I5F27(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4I5F27 Clamp(
            Vector4I5F27 min, Vector4I5F27 max
        ) => new Vector4I5F27(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I5F27 SaturatingAdd(Vector4I5F27 other) => new Vector4I5F27(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I5F27 SaturatingMul(I5F27 other) => new Vector4I5F27(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I12F52 WideningDot(Vector4I5F27 other) {
            var x = X.WideningMul(other.X);
            var y = Y.WideningMul(other.Y);
            var z = Z.WideningMul(other.Z);
            var w = W.WideningMul(other.W);

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x.Bits / 4) +
                (y.Bits / 4) +
                (z.Bits / 4) +
                (w.Bits / 4);
            return I12F52.FromBits(bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I5F27 Dot(Vector4I5F27 other) => (I5F27)WideningDot(other);

    }

    partial struct I5F27 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I5F27 SaturatingMul(Vector4I5F27 other) => other.SaturatingMul(this);
    }
}
