using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I23F9 : IEquatable<Vector4I23F9>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I23F9 X;
        public I23F9 Y;
        public I23F9 Z;
        public I23F9 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(I23F9 x, I23F9 y, I23F9 z, I23F9 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(I23F9 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(I23F9 x, I23F9 y, Vector2I23F9 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(I23F9 x, Vector3I23F9 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(Vector2I23F9 xy, Vector2I23F9 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(Vector4I23F9 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(I23F9 x, Vector2I23F9 yz, I23F9 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(Vector3I23F9 xyz, I23F9 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(Vector2I23F9 xy, I23F9 z, I23F9 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I23F9 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.Zero);
        }
        public static Vector4I23F9 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.One);
        }
        public static Vector4I23F9 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.One, I23F9.Zero, I23F9.Zero, I23F9.Zero);
        }
        public static Vector4I23F9 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.Zero, I23F9.One, I23F9.Zero, I23F9.Zero);
        }
        public static Vector4I23F9 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.Zero, I23F9.Zero, I23F9.One, I23F9.Zero);
        }
        public static Vector4I23F9 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.Zero, I23F9.Zero, I23F9.Zero, I23F9.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator +(Vector4I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator -(Vector4I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator *(Vector4I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator *(Vector4I23F9 a, I23F9 b) => new Vector4I23F9(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator *(I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator /(Vector4I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator /(Vector4I23F9 a, I23F9 b) => new Vector4I23F9(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator /(I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I23F9 lhs, Vector4I23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I23F9 lhs, Vector4I23F9 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I23F9 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(X, X); }
        public Vector2I23F9 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(X, Y); }
        public Vector2I23F9 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(X, Z); }
        public Vector2I23F9 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(X, W); }
        public Vector2I23F9 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Y, X); }
        public Vector2I23F9 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Y, Y); }
        public Vector2I23F9 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Y, Z); }
        public Vector2I23F9 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Y, W); }
        public Vector2I23F9 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Z, X); }
        public Vector2I23F9 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Z, Y); }
        public Vector2I23F9 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Z, Z); }
        public Vector2I23F9 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Z, W); }
        public Vector2I23F9 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(W, X); }
        public Vector2I23F9 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(W, Y); }
        public Vector2I23F9 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(W, Z); }
        public Vector2I23F9 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(W, W); }
        public Vector3I23F9 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, X, X); }
        public Vector3I23F9 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, X, Y); }
        public Vector3I23F9 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, X, Z); }
        public Vector3I23F9 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, X, W); }
        public Vector3I23F9 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Y, X); }
        public Vector3I23F9 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Y, Y); }
        public Vector3I23F9 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Y, Z); }
        public Vector3I23F9 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Y, W); }
        public Vector3I23F9 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Z, X); }
        public Vector3I23F9 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Z, Y); }
        public Vector3I23F9 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Z, Z); }
        public Vector3I23F9 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Z, W); }
        public Vector3I23F9 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, W, X); }
        public Vector3I23F9 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, W, Y); }
        public Vector3I23F9 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, W, Z); }
        public Vector3I23F9 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, W, W); }
        public Vector3I23F9 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, X, X); }
        public Vector3I23F9 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, X, Y); }
        public Vector3I23F9 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, X, Z); }
        public Vector3I23F9 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, X, W); }
        public Vector3I23F9 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Y, X); }
        public Vector3I23F9 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Y, Y); }
        public Vector3I23F9 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Y, Z); }
        public Vector3I23F9 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Y, W); }
        public Vector3I23F9 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Z, X); }
        public Vector3I23F9 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Z, Y); }
        public Vector3I23F9 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Z, Z); }
        public Vector3I23F9 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Z, W); }
        public Vector3I23F9 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, W, X); }
        public Vector3I23F9 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, W, Y); }
        public Vector3I23F9 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, W, Z); }
        public Vector3I23F9 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, W, W); }
        public Vector3I23F9 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, X, X); }
        public Vector3I23F9 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, X, Y); }
        public Vector3I23F9 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, X, Z); }
        public Vector3I23F9 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, X, W); }
        public Vector3I23F9 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Y, X); }
        public Vector3I23F9 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Y, Y); }
        public Vector3I23F9 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Y, Z); }
        public Vector3I23F9 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Y, W); }
        public Vector3I23F9 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Z, X); }
        public Vector3I23F9 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Z, Y); }
        public Vector3I23F9 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Z, Z); }
        public Vector3I23F9 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, Z, W); }
        public Vector3I23F9 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, W, X); }
        public Vector3I23F9 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, W, Y); }
        public Vector3I23F9 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, W, Z); }
        public Vector3I23F9 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Z, W, W); }
        public Vector3I23F9 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, X, X); }
        public Vector3I23F9 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, X, Y); }
        public Vector3I23F9 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, X, Z); }
        public Vector3I23F9 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, X, W); }
        public Vector3I23F9 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, Y, X); }
        public Vector3I23F9 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, Y, Y); }
        public Vector3I23F9 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, Y, Z); }
        public Vector3I23F9 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, Y, W); }
        public Vector3I23F9 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, Z, X); }
        public Vector3I23F9 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, Z, Y); }
        public Vector3I23F9 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, Z, Z); }
        public Vector3I23F9 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, Z, W); }
        public Vector3I23F9 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, W, X); }
        public Vector3I23F9 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, W, Y); }
        public Vector3I23F9 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, W, Z); }
        public Vector3I23F9 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(W, W, W); }
        public Vector4I23F9 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, X, X); }
        public Vector4I23F9 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, X, Y); }
        public Vector4I23F9 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, X, Z); }
        public Vector4I23F9 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, X, W); }
        public Vector4I23F9 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Y, X); }
        public Vector4I23F9 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Y, Y); }
        public Vector4I23F9 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Y, Z); }
        public Vector4I23F9 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Y, W); }
        public Vector4I23F9 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Z, X); }
        public Vector4I23F9 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Z, Y); }
        public Vector4I23F9 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Z, Z); }
        public Vector4I23F9 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Z, W); }
        public Vector4I23F9 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, W, X); }
        public Vector4I23F9 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, W, Y); }
        public Vector4I23F9 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, W, Z); }
        public Vector4I23F9 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, W, W); }
        public Vector4I23F9 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, X, X); }
        public Vector4I23F9 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, X, Y); }
        public Vector4I23F9 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, X, Z); }
        public Vector4I23F9 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, X, W); }
        public Vector4I23F9 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Y, X); }
        public Vector4I23F9 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Y, Y); }
        public Vector4I23F9 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Y, Z); }
        public Vector4I23F9 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Y, W); }
        public Vector4I23F9 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Z, X); }
        public Vector4I23F9 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Z, Y); }
        public Vector4I23F9 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Z, Z); }
        public Vector4I23F9 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Z, W); }
        public Vector4I23F9 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, W, X); }
        public Vector4I23F9 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, W, Y); }
        public Vector4I23F9 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, W, Z); }
        public Vector4I23F9 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, W, W); }
        public Vector4I23F9 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, X, X); }
        public Vector4I23F9 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, X, Y); }
        public Vector4I23F9 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, X, Z); }
        public Vector4I23F9 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, X, W); }
        public Vector4I23F9 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Y, X); }
        public Vector4I23F9 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Y, Y); }
        public Vector4I23F9 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Y, Z); }
        public Vector4I23F9 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Y, W); }
        public Vector4I23F9 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Z, X); }
        public Vector4I23F9 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Z, Y); }
        public Vector4I23F9 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Z, Z); }
        public Vector4I23F9 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, Z, W); }
        public Vector4I23F9 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, W, X); }
        public Vector4I23F9 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, W, Y); }
        public Vector4I23F9 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, W, Z); }
        public Vector4I23F9 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Z, W, W); }
        public Vector4I23F9 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, X, X); }
        public Vector4I23F9 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, X, Y); }
        public Vector4I23F9 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, X, Z); }
        public Vector4I23F9 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, X, W); }
        public Vector4I23F9 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, Y, X); }
        public Vector4I23F9 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, Y, Y); }
        public Vector4I23F9 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, Y, Z); }
        public Vector4I23F9 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, Y, W); }
        public Vector4I23F9 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, Z, X); }
        public Vector4I23F9 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, Z, Y); }
        public Vector4I23F9 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, Z, Z); }
        public Vector4I23F9 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, Z, W); }
        public Vector4I23F9 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, W, X); }
        public Vector4I23F9 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, W, Y); }
        public Vector4I23F9 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, W, Z); }
        public Vector4I23F9 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, W, W, W); }
        public Vector4I23F9 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, X, X); }
        public Vector4I23F9 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, X, Y); }
        public Vector4I23F9 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, X, Z); }
        public Vector4I23F9 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, X, W); }
        public Vector4I23F9 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Y, X); }
        public Vector4I23F9 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Y, Y); }
        public Vector4I23F9 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Y, Z); }
        public Vector4I23F9 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Y, W); }
        public Vector4I23F9 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Z, X); }
        public Vector4I23F9 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Z, Y); }
        public Vector4I23F9 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Z, Z); }
        public Vector4I23F9 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Z, W); }
        public Vector4I23F9 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, W, X); }
        public Vector4I23F9 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, W, Y); }
        public Vector4I23F9 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, W, Z); }
        public Vector4I23F9 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, W, W); }
        public Vector4I23F9 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, X, X); }
        public Vector4I23F9 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, X, Y); }
        public Vector4I23F9 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, X, Z); }
        public Vector4I23F9 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, X, W); }
        public Vector4I23F9 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Y, X); }
        public Vector4I23F9 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Y, Y); }
        public Vector4I23F9 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Y, Z); }
        public Vector4I23F9 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Y, W); }
        public Vector4I23F9 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Z, X); }
        public Vector4I23F9 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Z, Y); }
        public Vector4I23F9 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Z, Z); }
        public Vector4I23F9 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Z, W); }
        public Vector4I23F9 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, W, X); }
        public Vector4I23F9 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, W, Y); }
        public Vector4I23F9 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, W, Z); }
        public Vector4I23F9 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, W, W); }
        public Vector4I23F9 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, X, X); }
        public Vector4I23F9 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, X, Y); }
        public Vector4I23F9 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, X, Z); }
        public Vector4I23F9 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, X, W); }
        public Vector4I23F9 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Y, X); }
        public Vector4I23F9 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Y, Y); }
        public Vector4I23F9 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Y, Z); }
        public Vector4I23F9 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Y, W); }
        public Vector4I23F9 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Z, X); }
        public Vector4I23F9 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Z, Y); }
        public Vector4I23F9 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Z, Z); }
        public Vector4I23F9 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, Z, W); }
        public Vector4I23F9 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, W, X); }
        public Vector4I23F9 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, W, Y); }
        public Vector4I23F9 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, W, Z); }
        public Vector4I23F9 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Z, W, W); }
        public Vector4I23F9 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, X, X); }
        public Vector4I23F9 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, X, Y); }
        public Vector4I23F9 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, X, Z); }
        public Vector4I23F9 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, X, W); }
        public Vector4I23F9 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, Y, X); }
        public Vector4I23F9 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, Y, Y); }
        public Vector4I23F9 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, Y, Z); }
        public Vector4I23F9 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, Y, W); }
        public Vector4I23F9 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, Z, X); }
        public Vector4I23F9 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, Z, Y); }
        public Vector4I23F9 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, Z, Z); }
        public Vector4I23F9 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, Z, W); }
        public Vector4I23F9 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, W, X); }
        public Vector4I23F9 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, W, Y); }
        public Vector4I23F9 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, W, Z); }
        public Vector4I23F9 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, W, W, W); }
        public Vector4I23F9 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, X, X); }
        public Vector4I23F9 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, X, Y); }
        public Vector4I23F9 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, X, Z); }
        public Vector4I23F9 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, X, W); }
        public Vector4I23F9 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Y, X); }
        public Vector4I23F9 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Y, Y); }
        public Vector4I23F9 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Y, Z); }
        public Vector4I23F9 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Y, W); }
        public Vector4I23F9 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Z, X); }
        public Vector4I23F9 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Z, Y); }
        public Vector4I23F9 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Z, Z); }
        public Vector4I23F9 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, Z, W); }
        public Vector4I23F9 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, W, X); }
        public Vector4I23F9 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, W, Y); }
        public Vector4I23F9 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, W, Z); }
        public Vector4I23F9 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, X, W, W); }
        public Vector4I23F9 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, X, X); }
        public Vector4I23F9 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, X, Y); }
        public Vector4I23F9 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, X, Z); }
        public Vector4I23F9 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, X, W); }
        public Vector4I23F9 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Y, X); }
        public Vector4I23F9 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Y, Y); }
        public Vector4I23F9 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Y, Z); }
        public Vector4I23F9 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Y, W); }
        public Vector4I23F9 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Z, X); }
        public Vector4I23F9 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Z, Y); }
        public Vector4I23F9 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Z, Z); }
        public Vector4I23F9 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, Z, W); }
        public Vector4I23F9 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, W, X); }
        public Vector4I23F9 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, W, Y); }
        public Vector4I23F9 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, W, Z); }
        public Vector4I23F9 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Y, W, W); }
        public Vector4I23F9 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, X, X); }
        public Vector4I23F9 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, X, Y); }
        public Vector4I23F9 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, X, Z); }
        public Vector4I23F9 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, X, W); }
        public Vector4I23F9 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Y, X); }
        public Vector4I23F9 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Y, Y); }
        public Vector4I23F9 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Y, Z); }
        public Vector4I23F9 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Y, W); }
        public Vector4I23F9 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Z, X); }
        public Vector4I23F9 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Z, Y); }
        public Vector4I23F9 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Z, Z); }
        public Vector4I23F9 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, Z, W); }
        public Vector4I23F9 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, W, X); }
        public Vector4I23F9 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, W, Y); }
        public Vector4I23F9 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, W, Z); }
        public Vector4I23F9 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, Z, W, W); }
        public Vector4I23F9 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, X, X); }
        public Vector4I23F9 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, X, Y); }
        public Vector4I23F9 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, X, Z); }
        public Vector4I23F9 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, X, W); }
        public Vector4I23F9 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, Y, X); }
        public Vector4I23F9 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, Y, Y); }
        public Vector4I23F9 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, Y, Z); }
        public Vector4I23F9 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, Y, W); }
        public Vector4I23F9 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, Z, X); }
        public Vector4I23F9 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, Z, Y); }
        public Vector4I23F9 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, Z, Z); }
        public Vector4I23F9 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, Z, W); }
        public Vector4I23F9 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, W, X); }
        public Vector4I23F9 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, W, Y); }
        public Vector4I23F9 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, W, Z); }
        public Vector4I23F9 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Z, W, W, W); }
        public Vector4I23F9 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, X, X); }
        public Vector4I23F9 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, X, Y); }
        public Vector4I23F9 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, X, Z); }
        public Vector4I23F9 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, X, W); }
        public Vector4I23F9 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, Y, X); }
        public Vector4I23F9 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, Y, Y); }
        public Vector4I23F9 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, Y, Z); }
        public Vector4I23F9 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, Y, W); }
        public Vector4I23F9 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, Z, X); }
        public Vector4I23F9 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, Z, Y); }
        public Vector4I23F9 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, Z, Z); }
        public Vector4I23F9 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, Z, W); }
        public Vector4I23F9 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, W, X); }
        public Vector4I23F9 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, W, Y); }
        public Vector4I23F9 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, W, Z); }
        public Vector4I23F9 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, X, W, W); }
        public Vector4I23F9 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, X, X); }
        public Vector4I23F9 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, X, Y); }
        public Vector4I23F9 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, X, Z); }
        public Vector4I23F9 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, X, W); }
        public Vector4I23F9 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, Y, X); }
        public Vector4I23F9 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, Y, Y); }
        public Vector4I23F9 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, Y, Z); }
        public Vector4I23F9 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, Y, W); }
        public Vector4I23F9 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, Z, X); }
        public Vector4I23F9 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, Z, Y); }
        public Vector4I23F9 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, Z, Z); }
        public Vector4I23F9 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, Z, W); }
        public Vector4I23F9 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, W, X); }
        public Vector4I23F9 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, W, Y); }
        public Vector4I23F9 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, W, Z); }
        public Vector4I23F9 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Y, W, W); }
        public Vector4I23F9 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, X, X); }
        public Vector4I23F9 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, X, Y); }
        public Vector4I23F9 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, X, Z); }
        public Vector4I23F9 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, X, W); }
        public Vector4I23F9 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, Y, X); }
        public Vector4I23F9 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, Y, Y); }
        public Vector4I23F9 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, Y, Z); }
        public Vector4I23F9 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, Y, W); }
        public Vector4I23F9 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, Z, X); }
        public Vector4I23F9 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, Z, Y); }
        public Vector4I23F9 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, Z, Z); }
        public Vector4I23F9 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, Z, W); }
        public Vector4I23F9 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, W, X); }
        public Vector4I23F9 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, W, Y); }
        public Vector4I23F9 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, W, Z); }
        public Vector4I23F9 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, Z, W, W); }
        public Vector4I23F9 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, X, X); }
        public Vector4I23F9 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, X, Y); }
        public Vector4I23F9 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, X, Z); }
        public Vector4I23F9 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, X, W); }
        public Vector4I23F9 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, Y, X); }
        public Vector4I23F9 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, Y, Y); }
        public Vector4I23F9 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, Y, Z); }
        public Vector4I23F9 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, Y, W); }
        public Vector4I23F9 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, Z, X); }
        public Vector4I23F9 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, Z, Y); }
        public Vector4I23F9 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, Z, Z); }
        public Vector4I23F9 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, Z, W); }
        public Vector4I23F9 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, W, X); }
        public Vector4I23F9 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, W, Y); }
        public Vector4I23F9 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, W, Z); }
        public Vector4I23F9 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector4I23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I23F9 other)
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
        public Vector4I23F9 Min(Vector4I23F9 other) => new Vector4I23F9(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Max(Vector4I23F9 other) => new Vector4I23F9(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Abs() => new Vector4I23F9(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Half() => new Vector4I23F9(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Twice() => new Vector4I23F9(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Clamp(I23F9 min, I23F9 max) => new Vector4I23F9(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Clamp(
            Vector4I23F9 min, Vector4I23F9 max
        ) => new Vector4I23F9(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 WrappingAdd(Vector4I23F9 other) => new Vector4I23F9(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 WrappingSub(Vector4I23F9 other) => new Vector4I23F9(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 WrappingMul(Vector4I23F9 other) => new Vector4I23F9(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 WrappingAddUnsigned(Vector4U23F9 other) => new Vector4I23F9(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 WrappingSubUnsigned(Vector4U23F9 other) => new Vector4I23F9(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9 UnsignedAbs() => new Vector4U23F9(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 SaturatingAdd(Vector4I23F9 other) => new Vector4I23F9(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 SaturatingMul(I23F9 other) => new Vector4I23F9(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I23F9 other) {
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
        public I23F9 Dot(Vector4I23F9 other) {
            const long k = 1L << 7;
            return I23F9.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I23F9 SaturatingDot(Vector4I23F9 other) {
            const long k = 1L << 7;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I23F9.MaxValue;
            } else if (bits < int.MinValue) {
                return I23F9.MinValue;
            } else {
                return I23F9.FromBits((int)bits);
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
        public I48F16 LengthSquared() {
            return I48F16.FromBits(LengthSquaredInternal());
        }

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
        public U23F9 LengthHalfUnsigned() => U23F9.FromBits(LengthInternal());

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
        public I23F9 LengthHalf() => I23F9.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I24F8 Length() => I24F8.FromBits((int)LengthInternal());

    }

    partial struct I23F9 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 SaturatingMul(Vector4I23F9 other) => other.SaturatingMul(this);
    }
}
