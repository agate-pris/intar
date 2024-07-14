using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U3F29 : IEquatable<Vector4U3F29>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U3F29 X;
        public U3F29 Y;
        public U3F29 Z;
        public U3F29 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, U3F29 y, U3F29 z, U3F29 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, U3F29 y, Vector2U3F29 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, Vector3U3F29 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector2U3F29 xy, Vector2U3F29 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector4U3F29 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, Vector2U3F29 yz, U3F29 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector3U3F29 xyz, U3F29 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector2U3F29 xy, U3F29 z, U3F29 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U3F29 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.Zero);
        }
        public static Vector4U3F29 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.One);
        }
        public static Vector4U3F29 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.One, U3F29.Zero, U3F29.Zero, U3F29.Zero);
        }
        public static Vector4U3F29 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.Zero, U3F29.One, U3F29.Zero, U3F29.Zero);
        }
        public static Vector4U3F29 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.Zero, U3F29.Zero, U3F29.One, U3F29.Zero);
        }
        public static Vector4U3F29 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.Zero, U3F29.Zero, U3F29.Zero, U3F29.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator +(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator -(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator *(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator *(Vector4U3F29 a, U3F29 b) => new Vector4U3F29(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator *(U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator /(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator /(Vector4U3F29 a, U3F29 b) => new Vector4U3F29(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator /(U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U3F29 lhs, Vector4U3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U3F29 lhs, Vector4U3F29 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U3F29 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, X); }
        public Vector2U3F29 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, Y); }
        public Vector2U3F29 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, Z); }
        public Vector2U3F29 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, W); }
        public Vector2U3F29 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, X); }
        public Vector2U3F29 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, Y); }
        public Vector2U3F29 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, Z); }
        public Vector2U3F29 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, W); }
        public Vector2U3F29 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, X); }
        public Vector2U3F29 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, Y); }
        public Vector2U3F29 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, Z); }
        public Vector2U3F29 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Z, W); }
        public Vector2U3F29 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(W, X); }
        public Vector2U3F29 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(W, Y); }
        public Vector2U3F29 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(W, Z); }
        public Vector2U3F29 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(W, W); }
        public Vector3U3F29 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, X); }
        public Vector3U3F29 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, Y); }
        public Vector3U3F29 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, Z); }
        public Vector3U3F29 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, W); }
        public Vector3U3F29 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, X); }
        public Vector3U3F29 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, Y); }
        public Vector3U3F29 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, Z); }
        public Vector3U3F29 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, W); }
        public Vector3U3F29 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, X); }
        public Vector3U3F29 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, Y); }
        public Vector3U3F29 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, Z); }
        public Vector3U3F29 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Z, W); }
        public Vector3U3F29 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, W, X); }
        public Vector3U3F29 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, W, Y); }
        public Vector3U3F29 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, W, Z); }
        public Vector3U3F29 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, W, W); }
        public Vector3U3F29 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, X); }
        public Vector3U3F29 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, Y); }
        public Vector3U3F29 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, Z); }
        public Vector3U3F29 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, W); }
        public Vector3U3F29 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, X); }
        public Vector3U3F29 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, Y); }
        public Vector3U3F29 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, Z); }
        public Vector3U3F29 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, W); }
        public Vector3U3F29 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, X); }
        public Vector3U3F29 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, Y); }
        public Vector3U3F29 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, Z); }
        public Vector3U3F29 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Z, W); }
        public Vector3U3F29 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, W, X); }
        public Vector3U3F29 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, W, Y); }
        public Vector3U3F29 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, W, Z); }
        public Vector3U3F29 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, W, W); }
        public Vector3U3F29 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, X); }
        public Vector3U3F29 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, Y); }
        public Vector3U3F29 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, Z); }
        public Vector3U3F29 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, X, W); }
        public Vector3U3F29 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, X); }
        public Vector3U3F29 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, Y); }
        public Vector3U3F29 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, Z); }
        public Vector3U3F29 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Y, W); }
        public Vector3U3F29 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, X); }
        public Vector3U3F29 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, Y); }
        public Vector3U3F29 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, Z); }
        public Vector3U3F29 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, Z, W); }
        public Vector3U3F29 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, W, X); }
        public Vector3U3F29 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, W, Y); }
        public Vector3U3F29 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, W, Z); }
        public Vector3U3F29 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Z, W, W); }
        public Vector3U3F29 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, X, X); }
        public Vector3U3F29 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, X, Y); }
        public Vector3U3F29 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, X, Z); }
        public Vector3U3F29 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, X, W); }
        public Vector3U3F29 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Y, X); }
        public Vector3U3F29 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Y, Y); }
        public Vector3U3F29 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Y, Z); }
        public Vector3U3F29 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Y, W); }
        public Vector3U3F29 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Z, X); }
        public Vector3U3F29 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Z, Y); }
        public Vector3U3F29 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Z, Z); }
        public Vector3U3F29 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, Z, W); }
        public Vector3U3F29 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, W, X); }
        public Vector3U3F29 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, W, Y); }
        public Vector3U3F29 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, W, Z); }
        public Vector3U3F29 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(W, W, W); }
        public Vector4U3F29 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, X); }
        public Vector4U3F29 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, Y); }
        public Vector4U3F29 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, Z); }
        public Vector4U3F29 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, W); }
        public Vector4U3F29 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, X); }
        public Vector4U3F29 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, Y); }
        public Vector4U3F29 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, Z); }
        public Vector4U3F29 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, W); }
        public Vector4U3F29 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, X); }
        public Vector4U3F29 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, Y); }
        public Vector4U3F29 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, Z); }
        public Vector4U3F29 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Z, W); }
        public Vector4U3F29 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, W, X); }
        public Vector4U3F29 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, W, Y); }
        public Vector4U3F29 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, W, Z); }
        public Vector4U3F29 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, W, W); }
        public Vector4U3F29 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, X); }
        public Vector4U3F29 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, Y); }
        public Vector4U3F29 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, Z); }
        public Vector4U3F29 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, W); }
        public Vector4U3F29 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, X); }
        public Vector4U3F29 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, Y); }
        public Vector4U3F29 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, Z); }
        public Vector4U3F29 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, W); }
        public Vector4U3F29 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, X); }
        public Vector4U3F29 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, Y); }
        public Vector4U3F29 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, Z); }
        public Vector4U3F29 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Z, W); }
        public Vector4U3F29 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, W, X); }
        public Vector4U3F29 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, W, Y); }
        public Vector4U3F29 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, W, Z); }
        public Vector4U3F29 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, W, W); }
        public Vector4U3F29 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, X); }
        public Vector4U3F29 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, Y); }
        public Vector4U3F29 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, Z); }
        public Vector4U3F29 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, X, W); }
        public Vector4U3F29 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, X); }
        public Vector4U3F29 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, Y); }
        public Vector4U3F29 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, Z); }
        public Vector4U3F29 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Y, W); }
        public Vector4U3F29 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, X); }
        public Vector4U3F29 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, Y); }
        public Vector4U3F29 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, Z); }
        public Vector4U3F29 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, Z, W); }
        public Vector4U3F29 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, W, X); }
        public Vector4U3F29 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, W, Y); }
        public Vector4U3F29 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, W, Z); }
        public Vector4U3F29 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Z, W, W); }
        public Vector4U3F29 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, X, X); }
        public Vector4U3F29 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, X, Y); }
        public Vector4U3F29 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, X, Z); }
        public Vector4U3F29 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, X, W); }
        public Vector4U3F29 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Y, X); }
        public Vector4U3F29 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Y, Y); }
        public Vector4U3F29 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Y, Z); }
        public Vector4U3F29 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Y, W); }
        public Vector4U3F29 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Z, X); }
        public Vector4U3F29 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Z, Y); }
        public Vector4U3F29 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Z, Z); }
        public Vector4U3F29 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, Z, W); }
        public Vector4U3F29 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, W, X); }
        public Vector4U3F29 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, W, Y); }
        public Vector4U3F29 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, W, Z); }
        public Vector4U3F29 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, W, W, W); }
        public Vector4U3F29 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, X); }
        public Vector4U3F29 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, Y); }
        public Vector4U3F29 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, Z); }
        public Vector4U3F29 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, W); }
        public Vector4U3F29 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, X); }
        public Vector4U3F29 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, Y); }
        public Vector4U3F29 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, Z); }
        public Vector4U3F29 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, W); }
        public Vector4U3F29 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, X); }
        public Vector4U3F29 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, Y); }
        public Vector4U3F29 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, Z); }
        public Vector4U3F29 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Z, W); }
        public Vector4U3F29 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, W, X); }
        public Vector4U3F29 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, W, Y); }
        public Vector4U3F29 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, W, Z); }
        public Vector4U3F29 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, W, W); }
        public Vector4U3F29 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, X); }
        public Vector4U3F29 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, Y); }
        public Vector4U3F29 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, Z); }
        public Vector4U3F29 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, W); }
        public Vector4U3F29 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, X); }
        public Vector4U3F29 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, Y); }
        public Vector4U3F29 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, Z); }
        public Vector4U3F29 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, W); }
        public Vector4U3F29 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, X); }
        public Vector4U3F29 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, Y); }
        public Vector4U3F29 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, Z); }
        public Vector4U3F29 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Z, W); }
        public Vector4U3F29 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, W, X); }
        public Vector4U3F29 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, W, Y); }
        public Vector4U3F29 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, W, Z); }
        public Vector4U3F29 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, W, W); }
        public Vector4U3F29 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, X); }
        public Vector4U3F29 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, Y); }
        public Vector4U3F29 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, Z); }
        public Vector4U3F29 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, X, W); }
        public Vector4U3F29 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, X); }
        public Vector4U3F29 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, Y); }
        public Vector4U3F29 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, Z); }
        public Vector4U3F29 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Y, W); }
        public Vector4U3F29 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, X); }
        public Vector4U3F29 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, Y); }
        public Vector4U3F29 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, Z); }
        public Vector4U3F29 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, Z, W); }
        public Vector4U3F29 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, W, X); }
        public Vector4U3F29 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, W, Y); }
        public Vector4U3F29 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, W, Z); }
        public Vector4U3F29 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Z, W, W); }
        public Vector4U3F29 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, X, X); }
        public Vector4U3F29 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, X, Y); }
        public Vector4U3F29 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, X, Z); }
        public Vector4U3F29 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, X, W); }
        public Vector4U3F29 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Y, X); }
        public Vector4U3F29 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Y, Y); }
        public Vector4U3F29 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Y, Z); }
        public Vector4U3F29 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Y, W); }
        public Vector4U3F29 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Z, X); }
        public Vector4U3F29 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Z, Y); }
        public Vector4U3F29 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Z, Z); }
        public Vector4U3F29 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, Z, W); }
        public Vector4U3F29 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, W, X); }
        public Vector4U3F29 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, W, Y); }
        public Vector4U3F29 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, W, Z); }
        public Vector4U3F29 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, W, W, W); }
        public Vector4U3F29 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, X); }
        public Vector4U3F29 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, Y); }
        public Vector4U3F29 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, Z); }
        public Vector4U3F29 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, X, W); }
        public Vector4U3F29 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, X); }
        public Vector4U3F29 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, Y); }
        public Vector4U3F29 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, Z); }
        public Vector4U3F29 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Y, W); }
        public Vector4U3F29 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, X); }
        public Vector4U3F29 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, Y); }
        public Vector4U3F29 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, Z); }
        public Vector4U3F29 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, Z, W); }
        public Vector4U3F29 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, W, X); }
        public Vector4U3F29 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, W, Y); }
        public Vector4U3F29 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, W, Z); }
        public Vector4U3F29 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, X, W, W); }
        public Vector4U3F29 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, X); }
        public Vector4U3F29 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, Y); }
        public Vector4U3F29 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, Z); }
        public Vector4U3F29 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, X, W); }
        public Vector4U3F29 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, X); }
        public Vector4U3F29 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, Y); }
        public Vector4U3F29 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, Z); }
        public Vector4U3F29 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Y, W); }
        public Vector4U3F29 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, X); }
        public Vector4U3F29 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, Y); }
        public Vector4U3F29 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, Z); }
        public Vector4U3F29 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, Z, W); }
        public Vector4U3F29 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, W, X); }
        public Vector4U3F29 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, W, Y); }
        public Vector4U3F29 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, W, Z); }
        public Vector4U3F29 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Y, W, W); }
        public Vector4U3F29 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, X); }
        public Vector4U3F29 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, Y); }
        public Vector4U3F29 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, Z); }
        public Vector4U3F29 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, X, W); }
        public Vector4U3F29 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, X); }
        public Vector4U3F29 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, Y); }
        public Vector4U3F29 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, Z); }
        public Vector4U3F29 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Y, W); }
        public Vector4U3F29 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, X); }
        public Vector4U3F29 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, Y); }
        public Vector4U3F29 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, Z); }
        public Vector4U3F29 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, Z, W); }
        public Vector4U3F29 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, W, X); }
        public Vector4U3F29 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, W, Y); }
        public Vector4U3F29 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, W, Z); }
        public Vector4U3F29 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, Z, W, W); }
        public Vector4U3F29 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, X, X); }
        public Vector4U3F29 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, X, Y); }
        public Vector4U3F29 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, X, Z); }
        public Vector4U3F29 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, X, W); }
        public Vector4U3F29 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Y, X); }
        public Vector4U3F29 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Y, Y); }
        public Vector4U3F29 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Y, Z); }
        public Vector4U3F29 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Y, W); }
        public Vector4U3F29 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Z, X); }
        public Vector4U3F29 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Z, Y); }
        public Vector4U3F29 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Z, Z); }
        public Vector4U3F29 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, Z, W); }
        public Vector4U3F29 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, W, X); }
        public Vector4U3F29 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, W, Y); }
        public Vector4U3F29 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, W, Z); }
        public Vector4U3F29 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Z, W, W, W); }
        public Vector4U3F29 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, X, X); }
        public Vector4U3F29 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, X, Y); }
        public Vector4U3F29 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, X, Z); }
        public Vector4U3F29 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, X, W); }
        public Vector4U3F29 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Y, X); }
        public Vector4U3F29 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Y, Y); }
        public Vector4U3F29 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Y, Z); }
        public Vector4U3F29 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Y, W); }
        public Vector4U3F29 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Z, X); }
        public Vector4U3F29 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Z, Y); }
        public Vector4U3F29 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Z, Z); }
        public Vector4U3F29 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, Z, W); }
        public Vector4U3F29 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, W, X); }
        public Vector4U3F29 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, W, Y); }
        public Vector4U3F29 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, W, Z); }
        public Vector4U3F29 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, X, W, W); }
        public Vector4U3F29 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, X, X); }
        public Vector4U3F29 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, X, Y); }
        public Vector4U3F29 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, X, Z); }
        public Vector4U3F29 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, X, W); }
        public Vector4U3F29 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Y, X); }
        public Vector4U3F29 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Y, Y); }
        public Vector4U3F29 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Y, Z); }
        public Vector4U3F29 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Y, W); }
        public Vector4U3F29 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Z, X); }
        public Vector4U3F29 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Z, Y); }
        public Vector4U3F29 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Z, Z); }
        public Vector4U3F29 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, Z, W); }
        public Vector4U3F29 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, W, X); }
        public Vector4U3F29 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, W, Y); }
        public Vector4U3F29 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, W, Z); }
        public Vector4U3F29 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Y, W, W); }
        public Vector4U3F29 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, X, X); }
        public Vector4U3F29 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, X, Y); }
        public Vector4U3F29 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, X, Z); }
        public Vector4U3F29 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, X, W); }
        public Vector4U3F29 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Y, X); }
        public Vector4U3F29 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Y, Y); }
        public Vector4U3F29 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Y, Z); }
        public Vector4U3F29 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Y, W); }
        public Vector4U3F29 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Z, X); }
        public Vector4U3F29 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Z, Y); }
        public Vector4U3F29 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Z, Z); }
        public Vector4U3F29 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, Z, W); }
        public Vector4U3F29 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, W, X); }
        public Vector4U3F29 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, W, Y); }
        public Vector4U3F29 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, W, Z); }
        public Vector4U3F29 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, Z, W, W); }
        public Vector4U3F29 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, X, X); }
        public Vector4U3F29 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, X, Y); }
        public Vector4U3F29 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, X, Z); }
        public Vector4U3F29 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, X, W); }
        public Vector4U3F29 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Y, X); }
        public Vector4U3F29 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Y, Y); }
        public Vector4U3F29 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Y, Z); }
        public Vector4U3F29 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Y, W); }
        public Vector4U3F29 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Z, X); }
        public Vector4U3F29 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Z, Y); }
        public Vector4U3F29 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Z, Z); }
        public Vector4U3F29 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, Z, W); }
        public Vector4U3F29 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, W, X); }
        public Vector4U3F29 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, W, Y); }
        public Vector4U3F29 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, W, Z); }
        public Vector4U3F29 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector4U3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U3F29 other)
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
        public Vector4U3F29 Min(Vector4U3F29 other) => new Vector4U3F29(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 Max(Vector4U3F29 other) => new Vector4U3F29(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 Half() => new Vector4U3F29(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 Twice() => new Vector4U3F29(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 Clamp(U3F29 min, U3F29 max) => new Vector4U3F29(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 Clamp(
            Vector4U3F29 min, Vector4U3F29 max
        ) => new Vector4U3F29(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 WrappingAdd(Vector4U3F29 other) => new Vector4U3F29(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 WrappingSub(Vector4U3F29 other) => new Vector4U3F29(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 WrappingMul(Vector4U3F29 other) => new Vector4U3F29(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 WrappingAddSigned(Vector4I3F29 other) => new Vector4U3F29(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 SaturatingAdd(Vector4U3F29 other) => new Vector4U3F29(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 SaturatingMul(U3F29 other) => new Vector4U3F29(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U3F29 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;
            var z = ((ulong)Z.Bits) * other.Z.Bits;
            var w = ((ulong)W.Bits) * other.W.Bits;

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
        public U3F29 Dot(Vector4U3F29 other) {
            const ulong k = 1UL << 27;
            return U3F29.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U3F29 SaturatingDot(Vector4U3F29 other) {
            const ulong k = 1UL << 27;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U3F29.MaxValue;
            } else {
                return U3F29.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

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
        public U8F56 LengthSquared() {
            return U8F56.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthHalfSigned">LengthHalfSigned</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalfSigned">LengthHalfSigned</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U3F29 LengthHalf() => U3F29.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalf">LengthHalf</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalf">LengthHalf</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I3F29 LengthHalfSigned() => I3F29.FromBits(checked((int)LengthInternal()));

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
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F28 Length() => U4F28.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><see cref="Length">Length</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="Length">Length</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfSigned"/>
        /// <seealso cref="Length"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F28 LengthSigned() => I4F28.FromBits(checked((int)LengthInternal()));

    }

    partial struct U3F29 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 SaturatingMul(Vector4U3F29 other) => other.SaturatingMul(this);
    }
}
