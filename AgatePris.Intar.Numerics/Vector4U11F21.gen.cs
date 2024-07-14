using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U11F21 : IEquatable<Vector4U11F21>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U11F21 X;
        public U11F21 Y;
        public U11F21 Z;
        public U11F21 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(U11F21 x, U11F21 y, U11F21 z, U11F21 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(U11F21 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(U11F21 x, U11F21 y, Vector2U11F21 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(U11F21 x, Vector3U11F21 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(Vector2U11F21 xy, Vector2U11F21 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(Vector4U11F21 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(U11F21 x, Vector2U11F21 yz, U11F21 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(Vector3U11F21 xyz, U11F21 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(Vector2U11F21 xy, U11F21 z, U11F21 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U11F21 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.Zero);
        }
        public static Vector4U11F21 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.One);
        }
        public static Vector4U11F21 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.One, U11F21.Zero, U11F21.Zero, U11F21.Zero);
        }
        public static Vector4U11F21 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.Zero, U11F21.One, U11F21.Zero, U11F21.Zero);
        }
        public static Vector4U11F21 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.Zero, U11F21.Zero, U11F21.One, U11F21.Zero);
        }
        public static Vector4U11F21 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.Zero, U11F21.Zero, U11F21.Zero, U11F21.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator +(Vector4U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator -(Vector4U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator *(Vector4U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator *(Vector4U11F21 a, U11F21 b) => new Vector4U11F21(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator *(U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator /(Vector4U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator /(Vector4U11F21 a, U11F21 b) => new Vector4U11F21(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator /(U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U11F21 lhs, Vector4U11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U11F21 lhs, Vector4U11F21 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U11F21 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, X); }
        public Vector2U11F21 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, Y); }
        public Vector2U11F21 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, Z); }
        public Vector2U11F21 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, W); }
        public Vector2U11F21 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, X); }
        public Vector2U11F21 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, Y); }
        public Vector2U11F21 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, Z); }
        public Vector2U11F21 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, W); }
        public Vector2U11F21 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Z, X); }
        public Vector2U11F21 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Z, Y); }
        public Vector2U11F21 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Z, Z); }
        public Vector2U11F21 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Z, W); }
        public Vector2U11F21 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(W, X); }
        public Vector2U11F21 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(W, Y); }
        public Vector2U11F21 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(W, Z); }
        public Vector2U11F21 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(W, W); }
        public Vector3U11F21 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, X); }
        public Vector3U11F21 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, Y); }
        public Vector3U11F21 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, Z); }
        public Vector3U11F21 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, W); }
        public Vector3U11F21 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, X); }
        public Vector3U11F21 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, Y); }
        public Vector3U11F21 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, Z); }
        public Vector3U11F21 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, W); }
        public Vector3U11F21 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Z, X); }
        public Vector3U11F21 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Z, Y); }
        public Vector3U11F21 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Z, Z); }
        public Vector3U11F21 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Z, W); }
        public Vector3U11F21 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, W, X); }
        public Vector3U11F21 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, W, Y); }
        public Vector3U11F21 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, W, Z); }
        public Vector3U11F21 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, W, W); }
        public Vector3U11F21 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, X); }
        public Vector3U11F21 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, Y); }
        public Vector3U11F21 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, Z); }
        public Vector3U11F21 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, W); }
        public Vector3U11F21 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, X); }
        public Vector3U11F21 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, Y); }
        public Vector3U11F21 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, Z); }
        public Vector3U11F21 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, W); }
        public Vector3U11F21 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Z, X); }
        public Vector3U11F21 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Z, Y); }
        public Vector3U11F21 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Z, Z); }
        public Vector3U11F21 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Z, W); }
        public Vector3U11F21 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, W, X); }
        public Vector3U11F21 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, W, Y); }
        public Vector3U11F21 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, W, Z); }
        public Vector3U11F21 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, W, W); }
        public Vector3U11F21 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, X, X); }
        public Vector3U11F21 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, X, Y); }
        public Vector3U11F21 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, X, Z); }
        public Vector3U11F21 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, X, W); }
        public Vector3U11F21 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Y, X); }
        public Vector3U11F21 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Y, Y); }
        public Vector3U11F21 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Y, Z); }
        public Vector3U11F21 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Y, W); }
        public Vector3U11F21 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Z, X); }
        public Vector3U11F21 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Z, Y); }
        public Vector3U11F21 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Z, Z); }
        public Vector3U11F21 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, Z, W); }
        public Vector3U11F21 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, W, X); }
        public Vector3U11F21 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, W, Y); }
        public Vector3U11F21 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, W, Z); }
        public Vector3U11F21 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Z, W, W); }
        public Vector3U11F21 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, X, X); }
        public Vector3U11F21 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, X, Y); }
        public Vector3U11F21 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, X, Z); }
        public Vector3U11F21 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, X, W); }
        public Vector3U11F21 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, Y, X); }
        public Vector3U11F21 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, Y, Y); }
        public Vector3U11F21 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, Y, Z); }
        public Vector3U11F21 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, Y, W); }
        public Vector3U11F21 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, Z, X); }
        public Vector3U11F21 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, Z, Y); }
        public Vector3U11F21 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, Z, Z); }
        public Vector3U11F21 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, Z, W); }
        public Vector3U11F21 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, W, X); }
        public Vector3U11F21 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, W, Y); }
        public Vector3U11F21 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, W, Z); }
        public Vector3U11F21 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(W, W, W); }
        public Vector4U11F21 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, X); }
        public Vector4U11F21 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, Y); }
        public Vector4U11F21 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, Z); }
        public Vector4U11F21 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, W); }
        public Vector4U11F21 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, X); }
        public Vector4U11F21 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, Y); }
        public Vector4U11F21 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, Z); }
        public Vector4U11F21 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, W); }
        public Vector4U11F21 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Z, X); }
        public Vector4U11F21 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Z, Y); }
        public Vector4U11F21 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Z, Z); }
        public Vector4U11F21 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Z, W); }
        public Vector4U11F21 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, W, X); }
        public Vector4U11F21 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, W, Y); }
        public Vector4U11F21 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, W, Z); }
        public Vector4U11F21 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, W, W); }
        public Vector4U11F21 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, X); }
        public Vector4U11F21 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, Y); }
        public Vector4U11F21 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, Z); }
        public Vector4U11F21 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, W); }
        public Vector4U11F21 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, X); }
        public Vector4U11F21 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, Y); }
        public Vector4U11F21 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, Z); }
        public Vector4U11F21 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, W); }
        public Vector4U11F21 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Z, X); }
        public Vector4U11F21 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Z, Y); }
        public Vector4U11F21 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Z, Z); }
        public Vector4U11F21 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Z, W); }
        public Vector4U11F21 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, W, X); }
        public Vector4U11F21 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, W, Y); }
        public Vector4U11F21 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, W, Z); }
        public Vector4U11F21 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, W, W); }
        public Vector4U11F21 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, X, X); }
        public Vector4U11F21 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, X, Y); }
        public Vector4U11F21 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, X, Z); }
        public Vector4U11F21 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, X, W); }
        public Vector4U11F21 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Y, X); }
        public Vector4U11F21 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Y, Y); }
        public Vector4U11F21 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Y, Z); }
        public Vector4U11F21 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Y, W); }
        public Vector4U11F21 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Z, X); }
        public Vector4U11F21 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Z, Y); }
        public Vector4U11F21 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Z, Z); }
        public Vector4U11F21 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, Z, W); }
        public Vector4U11F21 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, W, X); }
        public Vector4U11F21 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, W, Y); }
        public Vector4U11F21 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, W, Z); }
        public Vector4U11F21 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Z, W, W); }
        public Vector4U11F21 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, X, X); }
        public Vector4U11F21 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, X, Y); }
        public Vector4U11F21 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, X, Z); }
        public Vector4U11F21 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, X, W); }
        public Vector4U11F21 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, Y, X); }
        public Vector4U11F21 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, Y, Y); }
        public Vector4U11F21 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, Y, Z); }
        public Vector4U11F21 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, Y, W); }
        public Vector4U11F21 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, Z, X); }
        public Vector4U11F21 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, Z, Y); }
        public Vector4U11F21 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, Z, Z); }
        public Vector4U11F21 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, Z, W); }
        public Vector4U11F21 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, W, X); }
        public Vector4U11F21 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, W, Y); }
        public Vector4U11F21 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, W, Z); }
        public Vector4U11F21 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, W, W, W); }
        public Vector4U11F21 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, X); }
        public Vector4U11F21 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, Y); }
        public Vector4U11F21 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, Z); }
        public Vector4U11F21 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, W); }
        public Vector4U11F21 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, X); }
        public Vector4U11F21 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, Y); }
        public Vector4U11F21 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, Z); }
        public Vector4U11F21 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, W); }
        public Vector4U11F21 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Z, X); }
        public Vector4U11F21 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Z, Y); }
        public Vector4U11F21 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Z, Z); }
        public Vector4U11F21 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Z, W); }
        public Vector4U11F21 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, W, X); }
        public Vector4U11F21 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, W, Y); }
        public Vector4U11F21 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, W, Z); }
        public Vector4U11F21 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, W, W); }
        public Vector4U11F21 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, X); }
        public Vector4U11F21 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, Y); }
        public Vector4U11F21 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, Z); }
        public Vector4U11F21 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, W); }
        public Vector4U11F21 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, X); }
        public Vector4U11F21 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, Y); }
        public Vector4U11F21 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, Z); }
        public Vector4U11F21 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, W); }
        public Vector4U11F21 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Z, X); }
        public Vector4U11F21 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Z, Y); }
        public Vector4U11F21 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Z, Z); }
        public Vector4U11F21 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Z, W); }
        public Vector4U11F21 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, W, X); }
        public Vector4U11F21 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, W, Y); }
        public Vector4U11F21 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, W, Z); }
        public Vector4U11F21 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, W, W); }
        public Vector4U11F21 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, X, X); }
        public Vector4U11F21 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, X, Y); }
        public Vector4U11F21 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, X, Z); }
        public Vector4U11F21 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, X, W); }
        public Vector4U11F21 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Y, X); }
        public Vector4U11F21 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Y, Y); }
        public Vector4U11F21 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Y, Z); }
        public Vector4U11F21 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Y, W); }
        public Vector4U11F21 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Z, X); }
        public Vector4U11F21 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Z, Y); }
        public Vector4U11F21 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Z, Z); }
        public Vector4U11F21 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, Z, W); }
        public Vector4U11F21 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, W, X); }
        public Vector4U11F21 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, W, Y); }
        public Vector4U11F21 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, W, Z); }
        public Vector4U11F21 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Z, W, W); }
        public Vector4U11F21 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, X, X); }
        public Vector4U11F21 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, X, Y); }
        public Vector4U11F21 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, X, Z); }
        public Vector4U11F21 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, X, W); }
        public Vector4U11F21 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, Y, X); }
        public Vector4U11F21 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, Y, Y); }
        public Vector4U11F21 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, Y, Z); }
        public Vector4U11F21 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, Y, W); }
        public Vector4U11F21 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, Z, X); }
        public Vector4U11F21 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, Z, Y); }
        public Vector4U11F21 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, Z, Z); }
        public Vector4U11F21 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, Z, W); }
        public Vector4U11F21 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, W, X); }
        public Vector4U11F21 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, W, Y); }
        public Vector4U11F21 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, W, Z); }
        public Vector4U11F21 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, W, W, W); }
        public Vector4U11F21 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, X, X); }
        public Vector4U11F21 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, X, Y); }
        public Vector4U11F21 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, X, Z); }
        public Vector4U11F21 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, X, W); }
        public Vector4U11F21 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Y, X); }
        public Vector4U11F21 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Y, Y); }
        public Vector4U11F21 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Y, Z); }
        public Vector4U11F21 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Y, W); }
        public Vector4U11F21 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Z, X); }
        public Vector4U11F21 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Z, Y); }
        public Vector4U11F21 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Z, Z); }
        public Vector4U11F21 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, Z, W); }
        public Vector4U11F21 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, W, X); }
        public Vector4U11F21 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, W, Y); }
        public Vector4U11F21 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, W, Z); }
        public Vector4U11F21 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, X, W, W); }
        public Vector4U11F21 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, X, X); }
        public Vector4U11F21 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, X, Y); }
        public Vector4U11F21 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, X, Z); }
        public Vector4U11F21 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, X, W); }
        public Vector4U11F21 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Y, X); }
        public Vector4U11F21 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Y, Y); }
        public Vector4U11F21 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Y, Z); }
        public Vector4U11F21 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Y, W); }
        public Vector4U11F21 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Z, X); }
        public Vector4U11F21 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Z, Y); }
        public Vector4U11F21 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Z, Z); }
        public Vector4U11F21 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, Z, W); }
        public Vector4U11F21 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, W, X); }
        public Vector4U11F21 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, W, Y); }
        public Vector4U11F21 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, W, Z); }
        public Vector4U11F21 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Y, W, W); }
        public Vector4U11F21 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, X, X); }
        public Vector4U11F21 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, X, Y); }
        public Vector4U11F21 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, X, Z); }
        public Vector4U11F21 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, X, W); }
        public Vector4U11F21 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Y, X); }
        public Vector4U11F21 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Y, Y); }
        public Vector4U11F21 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Y, Z); }
        public Vector4U11F21 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Y, W); }
        public Vector4U11F21 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Z, X); }
        public Vector4U11F21 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Z, Y); }
        public Vector4U11F21 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Z, Z); }
        public Vector4U11F21 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, Z, W); }
        public Vector4U11F21 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, W, X); }
        public Vector4U11F21 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, W, Y); }
        public Vector4U11F21 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, W, Z); }
        public Vector4U11F21 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, Z, W, W); }
        public Vector4U11F21 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, X, X); }
        public Vector4U11F21 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, X, Y); }
        public Vector4U11F21 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, X, Z); }
        public Vector4U11F21 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, X, W); }
        public Vector4U11F21 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, Y, X); }
        public Vector4U11F21 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, Y, Y); }
        public Vector4U11F21 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, Y, Z); }
        public Vector4U11F21 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, Y, W); }
        public Vector4U11F21 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, Z, X); }
        public Vector4U11F21 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, Z, Y); }
        public Vector4U11F21 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, Z, Z); }
        public Vector4U11F21 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, Z, W); }
        public Vector4U11F21 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, W, X); }
        public Vector4U11F21 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, W, Y); }
        public Vector4U11F21 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, W, Z); }
        public Vector4U11F21 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Z, W, W, W); }
        public Vector4U11F21 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, X, X); }
        public Vector4U11F21 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, X, Y); }
        public Vector4U11F21 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, X, Z); }
        public Vector4U11F21 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, X, W); }
        public Vector4U11F21 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, Y, X); }
        public Vector4U11F21 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, Y, Y); }
        public Vector4U11F21 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, Y, Z); }
        public Vector4U11F21 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, Y, W); }
        public Vector4U11F21 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, Z, X); }
        public Vector4U11F21 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, Z, Y); }
        public Vector4U11F21 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, Z, Z); }
        public Vector4U11F21 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, Z, W); }
        public Vector4U11F21 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, W, X); }
        public Vector4U11F21 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, W, Y); }
        public Vector4U11F21 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, W, Z); }
        public Vector4U11F21 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, X, W, W); }
        public Vector4U11F21 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, X, X); }
        public Vector4U11F21 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, X, Y); }
        public Vector4U11F21 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, X, Z); }
        public Vector4U11F21 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, X, W); }
        public Vector4U11F21 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, Y, X); }
        public Vector4U11F21 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, Y, Y); }
        public Vector4U11F21 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, Y, Z); }
        public Vector4U11F21 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, Y, W); }
        public Vector4U11F21 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, Z, X); }
        public Vector4U11F21 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, Z, Y); }
        public Vector4U11F21 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, Z, Z); }
        public Vector4U11F21 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, Z, W); }
        public Vector4U11F21 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, W, X); }
        public Vector4U11F21 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, W, Y); }
        public Vector4U11F21 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, W, Z); }
        public Vector4U11F21 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Y, W, W); }
        public Vector4U11F21 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, X, X); }
        public Vector4U11F21 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, X, Y); }
        public Vector4U11F21 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, X, Z); }
        public Vector4U11F21 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, X, W); }
        public Vector4U11F21 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, Y, X); }
        public Vector4U11F21 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, Y, Y); }
        public Vector4U11F21 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, Y, Z); }
        public Vector4U11F21 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, Y, W); }
        public Vector4U11F21 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, Z, X); }
        public Vector4U11F21 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, Z, Y); }
        public Vector4U11F21 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, Z, Z); }
        public Vector4U11F21 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, Z, W); }
        public Vector4U11F21 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, W, X); }
        public Vector4U11F21 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, W, Y); }
        public Vector4U11F21 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, W, Z); }
        public Vector4U11F21 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, Z, W, W); }
        public Vector4U11F21 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, X, X); }
        public Vector4U11F21 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, X, Y); }
        public Vector4U11F21 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, X, Z); }
        public Vector4U11F21 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, X, W); }
        public Vector4U11F21 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, Y, X); }
        public Vector4U11F21 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, Y, Y); }
        public Vector4U11F21 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, Y, Z); }
        public Vector4U11F21 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, Y, W); }
        public Vector4U11F21 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, Z, X); }
        public Vector4U11F21 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, Z, Y); }
        public Vector4U11F21 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, Z, Z); }
        public Vector4U11F21 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, Z, W); }
        public Vector4U11F21 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, W, X); }
        public Vector4U11F21 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, W, Y); }
        public Vector4U11F21 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, W, Z); }
        public Vector4U11F21 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector4U11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U11F21 other)
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
        public Vector4U11F21 Min(Vector4U11F21 other) => new Vector4U11F21(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 Max(Vector4U11F21 other) => new Vector4U11F21(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 Half() => new Vector4U11F21(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 Twice() => new Vector4U11F21(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 Clamp(U11F21 min, U11F21 max) => new Vector4U11F21(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 Clamp(
            Vector4U11F21 min, Vector4U11F21 max
        ) => new Vector4U11F21(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 WrappingAdd(Vector4U11F21 other) => new Vector4U11F21(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 WrappingSub(Vector4U11F21 other) => new Vector4U11F21(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 WrappingMul(Vector4U11F21 other) => new Vector4U11F21(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 WrappingAddSigned(Vector4I11F21 other) => new Vector4U11F21(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 SaturatingAdd(Vector4U11F21 other) => new Vector4U11F21(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 SaturatingMul(U11F21 other) => new Vector4U11F21(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U11F21 other) {
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
        public U11F21 Dot(Vector4U11F21 other) {
            const ulong k = 1UL << 19;
            return U11F21.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U11F21 SaturatingDot(Vector4U11F21 other) {
            const ulong k = 1UL << 19;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U11F21.MaxValue;
            } else {
                return U11F21.FromBits((uint)bits);
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
        public U24F40 LengthSquared() {
            return U24F40.FromBits(LengthSquaredInternal());
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
        /// <para>This method differs from <c>LengthHalfSigned</c> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <c>LengthHalfSigned</c> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U11F21 LengthHalf() => U11F21.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><c>LengthHalf</c> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><c>LengthHalf</c> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I11F21 LengthHalfSigned() => I11F21.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U12F20 Length() => U12F20.FromBits(LengthInternal());

    }

    partial struct U11F21 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 SaturatingMul(Vector4U11F21 other) => other.SaturatingMul(this);
    }
}
