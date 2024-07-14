using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U21F11 : IEquatable<Vector4U21F11>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U21F11 X;
        public U21F11 Y;
        public U21F11 Z;
        public U21F11 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, U21F11 y, U21F11 z, U21F11 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, U21F11 y, Vector2U21F11 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, Vector3U21F11 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector2U21F11 xy, Vector2U21F11 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector4U21F11 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, Vector2U21F11 yz, U21F11 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector3U21F11 xyz, U21F11 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector2U21F11 xy, U21F11 z, U21F11 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U21F11 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.Zero);
        }
        public static Vector4U21F11 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.One);
        }
        public static Vector4U21F11 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.One, U21F11.Zero, U21F11.Zero, U21F11.Zero);
        }
        public static Vector4U21F11 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.Zero, U21F11.One, U21F11.Zero, U21F11.Zero);
        }
        public static Vector4U21F11 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.Zero, U21F11.Zero, U21F11.One, U21F11.Zero);
        }
        public static Vector4U21F11 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.Zero, U21F11.Zero, U21F11.Zero, U21F11.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator +(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator -(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator *(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator *(Vector4U21F11 a, U21F11 b) => new Vector4U21F11(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator *(U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator /(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator /(Vector4U21F11 a, U21F11 b) => new Vector4U21F11(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator /(U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U21F11 lhs, Vector4U21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U21F11 lhs, Vector4U21F11 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U21F11 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, X); }
        public Vector2U21F11 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, Y); }
        public Vector2U21F11 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, Z); }
        public Vector2U21F11 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, W); }
        public Vector2U21F11 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, X); }
        public Vector2U21F11 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, Y); }
        public Vector2U21F11 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, Z); }
        public Vector2U21F11 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, W); }
        public Vector2U21F11 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, X); }
        public Vector2U21F11 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, Y); }
        public Vector2U21F11 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, Z); }
        public Vector2U21F11 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Z, W); }
        public Vector2U21F11 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(W, X); }
        public Vector2U21F11 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(W, Y); }
        public Vector2U21F11 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(W, Z); }
        public Vector2U21F11 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(W, W); }
        public Vector3U21F11 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, X); }
        public Vector3U21F11 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, Y); }
        public Vector3U21F11 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, Z); }
        public Vector3U21F11 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, W); }
        public Vector3U21F11 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, X); }
        public Vector3U21F11 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, Y); }
        public Vector3U21F11 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, Z); }
        public Vector3U21F11 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, W); }
        public Vector3U21F11 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, X); }
        public Vector3U21F11 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, Y); }
        public Vector3U21F11 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, Z); }
        public Vector3U21F11 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Z, W); }
        public Vector3U21F11 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, W, X); }
        public Vector3U21F11 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, W, Y); }
        public Vector3U21F11 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, W, Z); }
        public Vector3U21F11 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, W, W); }
        public Vector3U21F11 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, X); }
        public Vector3U21F11 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, Y); }
        public Vector3U21F11 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, Z); }
        public Vector3U21F11 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, W); }
        public Vector3U21F11 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, X); }
        public Vector3U21F11 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, Y); }
        public Vector3U21F11 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, Z); }
        public Vector3U21F11 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, W); }
        public Vector3U21F11 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, X); }
        public Vector3U21F11 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, Y); }
        public Vector3U21F11 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, Z); }
        public Vector3U21F11 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Z, W); }
        public Vector3U21F11 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, W, X); }
        public Vector3U21F11 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, W, Y); }
        public Vector3U21F11 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, W, Z); }
        public Vector3U21F11 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, W, W); }
        public Vector3U21F11 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, X); }
        public Vector3U21F11 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, Y); }
        public Vector3U21F11 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, Z); }
        public Vector3U21F11 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, X, W); }
        public Vector3U21F11 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, X); }
        public Vector3U21F11 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, Y); }
        public Vector3U21F11 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, Z); }
        public Vector3U21F11 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Y, W); }
        public Vector3U21F11 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, X); }
        public Vector3U21F11 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, Y); }
        public Vector3U21F11 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, Z); }
        public Vector3U21F11 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, Z, W); }
        public Vector3U21F11 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, W, X); }
        public Vector3U21F11 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, W, Y); }
        public Vector3U21F11 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, W, Z); }
        public Vector3U21F11 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Z, W, W); }
        public Vector3U21F11 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, X, X); }
        public Vector3U21F11 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, X, Y); }
        public Vector3U21F11 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, X, Z); }
        public Vector3U21F11 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, X, W); }
        public Vector3U21F11 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Y, X); }
        public Vector3U21F11 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Y, Y); }
        public Vector3U21F11 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Y, Z); }
        public Vector3U21F11 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Y, W); }
        public Vector3U21F11 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Z, X); }
        public Vector3U21F11 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Z, Y); }
        public Vector3U21F11 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Z, Z); }
        public Vector3U21F11 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, Z, W); }
        public Vector3U21F11 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, W, X); }
        public Vector3U21F11 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, W, Y); }
        public Vector3U21F11 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, W, Z); }
        public Vector3U21F11 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(W, W, W); }
        public Vector4U21F11 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, X); }
        public Vector4U21F11 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, Y); }
        public Vector4U21F11 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, Z); }
        public Vector4U21F11 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, W); }
        public Vector4U21F11 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, X); }
        public Vector4U21F11 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, Y); }
        public Vector4U21F11 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, Z); }
        public Vector4U21F11 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, W); }
        public Vector4U21F11 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, X); }
        public Vector4U21F11 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, Y); }
        public Vector4U21F11 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, Z); }
        public Vector4U21F11 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Z, W); }
        public Vector4U21F11 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, W, X); }
        public Vector4U21F11 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, W, Y); }
        public Vector4U21F11 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, W, Z); }
        public Vector4U21F11 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, W, W); }
        public Vector4U21F11 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, X); }
        public Vector4U21F11 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, Y); }
        public Vector4U21F11 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, Z); }
        public Vector4U21F11 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, W); }
        public Vector4U21F11 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, X); }
        public Vector4U21F11 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, Y); }
        public Vector4U21F11 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, Z); }
        public Vector4U21F11 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, W); }
        public Vector4U21F11 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, X); }
        public Vector4U21F11 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, Y); }
        public Vector4U21F11 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, Z); }
        public Vector4U21F11 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Z, W); }
        public Vector4U21F11 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, W, X); }
        public Vector4U21F11 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, W, Y); }
        public Vector4U21F11 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, W, Z); }
        public Vector4U21F11 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, W, W); }
        public Vector4U21F11 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, X); }
        public Vector4U21F11 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, Y); }
        public Vector4U21F11 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, Z); }
        public Vector4U21F11 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, X, W); }
        public Vector4U21F11 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, X); }
        public Vector4U21F11 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, Y); }
        public Vector4U21F11 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, Z); }
        public Vector4U21F11 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Y, W); }
        public Vector4U21F11 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, X); }
        public Vector4U21F11 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, Y); }
        public Vector4U21F11 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, Z); }
        public Vector4U21F11 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, Z, W); }
        public Vector4U21F11 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, W, X); }
        public Vector4U21F11 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, W, Y); }
        public Vector4U21F11 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, W, Z); }
        public Vector4U21F11 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Z, W, W); }
        public Vector4U21F11 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, X, X); }
        public Vector4U21F11 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, X, Y); }
        public Vector4U21F11 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, X, Z); }
        public Vector4U21F11 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, X, W); }
        public Vector4U21F11 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Y, X); }
        public Vector4U21F11 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Y, Y); }
        public Vector4U21F11 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Y, Z); }
        public Vector4U21F11 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Y, W); }
        public Vector4U21F11 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Z, X); }
        public Vector4U21F11 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Z, Y); }
        public Vector4U21F11 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Z, Z); }
        public Vector4U21F11 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, Z, W); }
        public Vector4U21F11 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, W, X); }
        public Vector4U21F11 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, W, Y); }
        public Vector4U21F11 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, W, Z); }
        public Vector4U21F11 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, W, W, W); }
        public Vector4U21F11 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, X); }
        public Vector4U21F11 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, Y); }
        public Vector4U21F11 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, Z); }
        public Vector4U21F11 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, W); }
        public Vector4U21F11 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, X); }
        public Vector4U21F11 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, Y); }
        public Vector4U21F11 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, Z); }
        public Vector4U21F11 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, W); }
        public Vector4U21F11 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, X); }
        public Vector4U21F11 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, Y); }
        public Vector4U21F11 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, Z); }
        public Vector4U21F11 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Z, W); }
        public Vector4U21F11 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, W, X); }
        public Vector4U21F11 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, W, Y); }
        public Vector4U21F11 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, W, Z); }
        public Vector4U21F11 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, W, W); }
        public Vector4U21F11 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, X); }
        public Vector4U21F11 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, Y); }
        public Vector4U21F11 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, Z); }
        public Vector4U21F11 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, W); }
        public Vector4U21F11 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, X); }
        public Vector4U21F11 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, Y); }
        public Vector4U21F11 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, Z); }
        public Vector4U21F11 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, W); }
        public Vector4U21F11 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, X); }
        public Vector4U21F11 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, Y); }
        public Vector4U21F11 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, Z); }
        public Vector4U21F11 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Z, W); }
        public Vector4U21F11 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, W, X); }
        public Vector4U21F11 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, W, Y); }
        public Vector4U21F11 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, W, Z); }
        public Vector4U21F11 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, W, W); }
        public Vector4U21F11 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, X); }
        public Vector4U21F11 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, Y); }
        public Vector4U21F11 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, Z); }
        public Vector4U21F11 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, X, W); }
        public Vector4U21F11 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, X); }
        public Vector4U21F11 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, Y); }
        public Vector4U21F11 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, Z); }
        public Vector4U21F11 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Y, W); }
        public Vector4U21F11 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, X); }
        public Vector4U21F11 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, Y); }
        public Vector4U21F11 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, Z); }
        public Vector4U21F11 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, Z, W); }
        public Vector4U21F11 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, W, X); }
        public Vector4U21F11 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, W, Y); }
        public Vector4U21F11 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, W, Z); }
        public Vector4U21F11 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Z, W, W); }
        public Vector4U21F11 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, X, X); }
        public Vector4U21F11 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, X, Y); }
        public Vector4U21F11 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, X, Z); }
        public Vector4U21F11 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, X, W); }
        public Vector4U21F11 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Y, X); }
        public Vector4U21F11 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Y, Y); }
        public Vector4U21F11 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Y, Z); }
        public Vector4U21F11 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Y, W); }
        public Vector4U21F11 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Z, X); }
        public Vector4U21F11 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Z, Y); }
        public Vector4U21F11 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Z, Z); }
        public Vector4U21F11 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, Z, W); }
        public Vector4U21F11 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, W, X); }
        public Vector4U21F11 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, W, Y); }
        public Vector4U21F11 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, W, Z); }
        public Vector4U21F11 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, W, W, W); }
        public Vector4U21F11 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, X); }
        public Vector4U21F11 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, Y); }
        public Vector4U21F11 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, Z); }
        public Vector4U21F11 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, X, W); }
        public Vector4U21F11 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, X); }
        public Vector4U21F11 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, Y); }
        public Vector4U21F11 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, Z); }
        public Vector4U21F11 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Y, W); }
        public Vector4U21F11 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, X); }
        public Vector4U21F11 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, Y); }
        public Vector4U21F11 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, Z); }
        public Vector4U21F11 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, Z, W); }
        public Vector4U21F11 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, W, X); }
        public Vector4U21F11 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, W, Y); }
        public Vector4U21F11 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, W, Z); }
        public Vector4U21F11 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, X, W, W); }
        public Vector4U21F11 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, X); }
        public Vector4U21F11 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, Y); }
        public Vector4U21F11 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, Z); }
        public Vector4U21F11 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, X, W); }
        public Vector4U21F11 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, X); }
        public Vector4U21F11 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, Y); }
        public Vector4U21F11 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, Z); }
        public Vector4U21F11 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Y, W); }
        public Vector4U21F11 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, X); }
        public Vector4U21F11 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, Y); }
        public Vector4U21F11 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, Z); }
        public Vector4U21F11 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, Z, W); }
        public Vector4U21F11 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, W, X); }
        public Vector4U21F11 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, W, Y); }
        public Vector4U21F11 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, W, Z); }
        public Vector4U21F11 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Y, W, W); }
        public Vector4U21F11 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, X); }
        public Vector4U21F11 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, Y); }
        public Vector4U21F11 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, Z); }
        public Vector4U21F11 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, X, W); }
        public Vector4U21F11 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, X); }
        public Vector4U21F11 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, Y); }
        public Vector4U21F11 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, Z); }
        public Vector4U21F11 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Y, W); }
        public Vector4U21F11 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, X); }
        public Vector4U21F11 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, Y); }
        public Vector4U21F11 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, Z); }
        public Vector4U21F11 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, Z, W); }
        public Vector4U21F11 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, W, X); }
        public Vector4U21F11 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, W, Y); }
        public Vector4U21F11 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, W, Z); }
        public Vector4U21F11 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, Z, W, W); }
        public Vector4U21F11 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, X, X); }
        public Vector4U21F11 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, X, Y); }
        public Vector4U21F11 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, X, Z); }
        public Vector4U21F11 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, X, W); }
        public Vector4U21F11 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Y, X); }
        public Vector4U21F11 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Y, Y); }
        public Vector4U21F11 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Y, Z); }
        public Vector4U21F11 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Y, W); }
        public Vector4U21F11 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Z, X); }
        public Vector4U21F11 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Z, Y); }
        public Vector4U21F11 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Z, Z); }
        public Vector4U21F11 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, Z, W); }
        public Vector4U21F11 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, W, X); }
        public Vector4U21F11 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, W, Y); }
        public Vector4U21F11 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, W, Z); }
        public Vector4U21F11 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Z, W, W, W); }
        public Vector4U21F11 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, X, X); }
        public Vector4U21F11 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, X, Y); }
        public Vector4U21F11 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, X, Z); }
        public Vector4U21F11 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, X, W); }
        public Vector4U21F11 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Y, X); }
        public Vector4U21F11 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Y, Y); }
        public Vector4U21F11 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Y, Z); }
        public Vector4U21F11 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Y, W); }
        public Vector4U21F11 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Z, X); }
        public Vector4U21F11 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Z, Y); }
        public Vector4U21F11 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Z, Z); }
        public Vector4U21F11 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, Z, W); }
        public Vector4U21F11 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, W, X); }
        public Vector4U21F11 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, W, Y); }
        public Vector4U21F11 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, W, Z); }
        public Vector4U21F11 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, X, W, W); }
        public Vector4U21F11 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, X, X); }
        public Vector4U21F11 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, X, Y); }
        public Vector4U21F11 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, X, Z); }
        public Vector4U21F11 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, X, W); }
        public Vector4U21F11 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Y, X); }
        public Vector4U21F11 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Y, Y); }
        public Vector4U21F11 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Y, Z); }
        public Vector4U21F11 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Y, W); }
        public Vector4U21F11 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Z, X); }
        public Vector4U21F11 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Z, Y); }
        public Vector4U21F11 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Z, Z); }
        public Vector4U21F11 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, Z, W); }
        public Vector4U21F11 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, W, X); }
        public Vector4U21F11 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, W, Y); }
        public Vector4U21F11 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, W, Z); }
        public Vector4U21F11 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Y, W, W); }
        public Vector4U21F11 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, X, X); }
        public Vector4U21F11 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, X, Y); }
        public Vector4U21F11 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, X, Z); }
        public Vector4U21F11 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, X, W); }
        public Vector4U21F11 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Y, X); }
        public Vector4U21F11 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Y, Y); }
        public Vector4U21F11 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Y, Z); }
        public Vector4U21F11 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Y, W); }
        public Vector4U21F11 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Z, X); }
        public Vector4U21F11 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Z, Y); }
        public Vector4U21F11 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Z, Z); }
        public Vector4U21F11 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, Z, W); }
        public Vector4U21F11 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, W, X); }
        public Vector4U21F11 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, W, Y); }
        public Vector4U21F11 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, W, Z); }
        public Vector4U21F11 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, Z, W, W); }
        public Vector4U21F11 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, X, X); }
        public Vector4U21F11 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, X, Y); }
        public Vector4U21F11 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, X, Z); }
        public Vector4U21F11 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, X, W); }
        public Vector4U21F11 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Y, X); }
        public Vector4U21F11 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Y, Y); }
        public Vector4U21F11 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Y, Z); }
        public Vector4U21F11 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Y, W); }
        public Vector4U21F11 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Z, X); }
        public Vector4U21F11 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Z, Y); }
        public Vector4U21F11 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Z, Z); }
        public Vector4U21F11 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, Z, W); }
        public Vector4U21F11 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, W, X); }
        public Vector4U21F11 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, W, Y); }
        public Vector4U21F11 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, W, Z); }
        public Vector4U21F11 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector4U21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U21F11 other)
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
        public Vector4U21F11 Min(Vector4U21F11 other) => new Vector4U21F11(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 Max(Vector4U21F11 other) => new Vector4U21F11(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 Half() => new Vector4U21F11(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 Twice() => new Vector4U21F11(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 Clamp(U21F11 min, U21F11 max) => new Vector4U21F11(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 Clamp(
            Vector4U21F11 min, Vector4U21F11 max
        ) => new Vector4U21F11(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 WrappingAdd(Vector4U21F11 other) => new Vector4U21F11(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 WrappingSub(Vector4U21F11 other) => new Vector4U21F11(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 WrappingMul(Vector4U21F11 other) => new Vector4U21F11(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 WrappingAddSigned(Vector4I21F11 other) => new Vector4U21F11(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 SaturatingAdd(Vector4U21F11 other) => new Vector4U21F11(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 SaturatingMul(U21F11 other) => new Vector4U21F11(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U21F11 other) {
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
        public U21F11 Dot(Vector4U21F11 other) {
            const ulong k = 1UL << 9;
            return U21F11.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11 SaturatingDot(Vector4U21F11 other) {
            const ulong k = 1UL << 9;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U21F11.MaxValue;
            } else {
                return U21F11.FromBits((uint)bits);
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
        public U44F20 LengthSquared() {
            return U44F20.FromBits(LengthSquaredInternal());
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
        public U21F11 LengthHalf() => U21F11.FromBits(LengthInternal());

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
        public I21F11 LengthHalfSigned() => I21F11.FromBits(checked((int)LengthInternal()));

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <c>LengthSigned</c> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <c>LengthSigned</c> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U22F10 Length() => U22F10.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><c>Length</c> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><c>Length</c> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I22F10 LengthSigned() => I22F10.FromBits(checked((int)LengthInternal()));

    }

    partial struct U21F11 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 SaturatingMul(Vector4U21F11 other) => other.SaturatingMul(this);
    }
}
